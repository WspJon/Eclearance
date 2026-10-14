Imports System.Data
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Threading.Tasks

Public Class ReportsForm
    Private ReadOnly db As New DatabaseHelper()
    Private reportUserID As Integer
    Private loading As Boolean
    Private loaded As Boolean
    Private filtersChanged As Boolean
    Private pageIndex As Integer
    Private Const PageSize As Integer = 10
    Private allRows As New List(Of StudentReportRow)
    Private filteredRows As New List(Of StudentReportRow)
    Private officeRows As New List(Of OfficeReportRow)
    Private reportTerm As String = ""
    Private reportFilters As String = ""
    Private generatedAt As DateTime
    Private selectedOffice As Integer
    Private selectedCourse As String = ""
    Private selectedYear As String = ""
    Private selectedStatus As String = ""
    Private reportTitle As String = "Student clearance status"
    Private printRows As List(Of StudentReportRow)
    Private printIndex As Integer
    Private printPageNumber As Integer
    Private ReadOnly green As Color = Color.FromArgb(21, 128, 61)
    Private ReadOnly amber As Color = Color.FromArgb(251, 191, 36)
    Private ReadOnly red As Color = Color.FromArgb(220, 38, 38)
    Private ReadOnly blue As Color = Color.FromArgb(59, 130, 246)

    Friend Class StudentReportRow
        Public UserID As Integer
        Public StudentNo As String
        Public FullName As String
        Public Course As String
        Public Year As String
        Public Status As String
        Public Progress As String
        Public WaitingOn As String
        Public LastActivity As DateTime?
        Public Items As List(Of ClearanceWorkflowHelper.ClearanceItemInfo)
        Public ReadOnly Property Applicable As List(Of ClearanceWorkflowHelper.ClearanceItemInfo)
            Get
                Return Items.Where(Function(i) i.IsApplicable).ToList()
            End Get
        End Property
    End Class

    Private Class OfficeReportRow
        Public Name As String
        Public Counts As Integer()
    End Class

    Private Function SessionAllowed() As Boolean
        Return String.Equals(AppSession.Role, "Admin", StringComparison.OrdinalIgnoreCase) AndAlso AppSession.UserID = reportUserID AndAlso reportUserID > 0
    End Function

    Private Sub CheckAdmin(userID As Integer)
        Dim allowed = db.ExecuteScalar("SELECT COUNT(*) FROM Users WHERE UserID=@UserID AND Role=@Role AND IsActive=@Active;", New Dictionary(Of String, Object) From {{"@UserID", userID}, {"@Role", "Admin"}, {"@Active", 1}})
        If Convert.ToInt32(allowed) <> 1 Then Throw New UnauthorizedAccessException("Only active administrators can open reports.")
    End Sub

    Private Async Sub ReportsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reportUserID = AppSession.UserID
        If Not SessionAllowed() Then
            MessageBox.Show("Only administrators can open reports.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Return
        End If
        ApplySchoolLogo(picSchoolLogo)
        SetLoading(True)
        Try
            Dim userID = reportUserID
            Dim tables = Await Task.Run(Function()
                                            CheckAdmin(userID)
                                            Return New DataTable() {
                                                db.ExecuteQuery("SELECT TermID, CONCAT(AcademicYear, ' - ', Semester) AS Caption, IsActive FROM AcademicTerms ORDER BY TermID DESC;"),
                                                db.ExecuteQuery("SELECT DepartmentID, DepartmentName FROM Departments WHERE IsActive=@Active ORDER BY DepartmentName;", New Dictionary(Of String, Object) From {{"@Active", 1}}),
                                                db.ExecuteQuery("SELECT CourseCode FROM CoursePrograms WHERE IsActive=@Active ORDER BY CourseCode;", New Dictionary(Of String, Object) From {{"@Active", 1}}),
                                                db.ExecuteQuery("SELECT DISTINCT YearLevel FROM Students ORDER BY YearLevel;")}
                                        End Function)
            If IsDisposed OrElse Not SessionAllowed() Then Return
            cmbTerm.DisplayMember = "Caption"
            cmbTerm.ValueMember = "TermID"
            cmbTerm.DataSource = tables(0)
            Dim active = tables(0).AsEnumerable().FirstOrDefault(Function(r) Convert.ToBoolean(r("IsActive")))
            lblActiveTerm.Text = If(active Is Nothing, "No active term", "Active term: " & active("Caption").ToString())
            If active IsNot Nothing Then cmbTerm.SelectedValue = CInt(active("TermID"))
            Dim offices = tables(1)
            Dim allOffice = offices.NewRow()
            allOffice("DepartmentID") = 0
            allOffice("DepartmentName") = "All offices"
            offices.Rows.InsertAt(allOffice, 0)
            cmbOffice.DisplayMember = "DepartmentName"
            cmbOffice.ValueMember = "DepartmentID"
            cmbOffice.DataSource = offices
            cmbCourse.Items.Add("All courses")
            For Each r As DataRow In tables(2).Rows
                cmbCourse.Items.Add(r("CourseCode").ToString())
            Next
            cmbYear.Items.Add("All years")
            For Each r As DataRow In tables(3).Rows
                If Not String.IsNullOrWhiteSpace(r("YearLevel").ToString()) Then cmbYear.Items.Add(r("YearLevel").ToString())
            Next
            cmbStatus.Items.AddRange({"All statuses", "Cleared", "In Progress", "Needs Attention"})
            cmbCourse.SelectedIndex = 0
            cmbYear.SelectedIndex = 0
            cmbStatus.SelectedIndex = 0
        Catch ex As Exception
            If Not IsDisposed Then MessageBox.Show("Unable to load report filters. " & ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Not IsDisposed Then SetLoading(False)
        End Try
        If Not IsDisposed AndAlso cmbTerm.SelectedValue IsNot Nothing Then Await GenerateReportAsync()
    End Sub

    Private Sub SetLoading(value As Boolean)
        loading = value
        For Each c As Control In {cmbTerm, cmbOffice, cmbCourse, cmbYear, cmbStatus, btnGenerate, txtSearch, pnlPresets}
            c.Enabled = Not value
        Next
        lblLoading.Text = If(value, "Loading report...", If(loaded, "Generated " & generatedAt.ToString("MMM dd, yyyy h:mm tt"), "Select a term to generate a report."))
        btnExportCsv.Enabled = Not value AndAlso loaded AndAlso Not filtersChanged AndAlso filteredRows.Count > 0
        btnExportPdf.Enabled = btnExportCsv.Enabled
        btnPrint.Enabled = btnExportCsv.Enabled
        UpdatePaging()
    End Sub

    Private Async Sub Generate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        reportTitle = "Student clearance status"
        Await GenerateReportAsync()
    End Sub

    Private Sub FilterChanged(sender As Object, e As EventArgs) Handles cmbTerm.SelectedIndexChanged, cmbOffice.SelectedIndexChanged, cmbCourse.SelectedIndexChanged, cmbYear.SelectedIndexChanged, cmbStatus.SelectedIndexChanged
        If loading OrElse Not loaded Then Return
        filtersChanged = True
        lblLoading.Text = "Filters changed. Click Generate report to refresh."
        btnExportCsv.Enabled = False
        btnExportPdf.Enabled = False
        btnPrint.Enabled = False
    End Sub

    Private Async Function GenerateReportAsync() As Task
        If loading Then Return
        If Not SessionAllowed() Then
            MessageBox.Show("Your administrator session is no longer active.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Close()
            Return
        End If
        If cmbTerm.SelectedValue Is Nothing Then
            allRows.Clear()
            loaded = False
            RefreshResults()
            lblLoading.Text = "No academic terms are available."
            Return
        End If
        Dim termID = CInt(cmbTerm.SelectedValue)
        Dim termText = cmbTerm.Text
        Dim officeID = If(cmbOffice.SelectedValue Is Nothing, 0, CInt(cmbOffice.SelectedValue))
        Dim courseText = If(cmbCourse.SelectedIndex > 0, cmbCourse.Text, "")
        Dim yearText = If(cmbYear.SelectedIndex > 0, cmbYear.Text, "")
        Dim statusText = If(cmbStatus.SelectedIndex > 0, cmbStatus.Text, "")
        Dim captions = String.Join(" | ", {cmbOffice.Text, cmbCourse.Text, cmbYear.Text, cmbStatus.Text})
        SetLoading(True)
        Try
            Dim userID = reportUserID
            Dim result = Await Task.Run(Function()
                                           CheckAdmin(userID)
                                           Return LoadSnapshot(termID)
                                       End Function)
            If IsDisposed OrElse Not SessionAllowed() Then Return
            allRows = result
            selectedOffice = officeID
            selectedCourse = courseText
            selectedYear = yearText
            selectedStatus = statusText
            reportTerm = termText
            reportFilters = captions
            generatedAt = DateTime.Now
            loaded = True
            filtersChanged = False
            pageIndex = 0
            RefreshResults()
        Catch ex As Exception
            If Not IsDisposed Then
                loaded = False
                allRows.Clear()
                RefreshResults()
                MessageBox.Show("Unable to generate the report. " & ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            If Not IsDisposed Then SetLoading(False)
        End Try
    End Function

    Friend Function LoadSnapshot(termID As Integer) As List(Of StudentReportRow)
        Dim args As New Dictionary(Of String, Object) From {{"@TermID", termID}, {"@Role", "Student"}, {"@Active", 1}, {"@Pending", "Pending"}, {"@StudentAffairs", "Office of Student Affairs"}}
        Dim students = db.ExecuteQuery("SELECT u.UserID, s.StudentNo, u.FullName, s.Course, s.YearLevel, s.EnrolledInNSTP FROM Users u JOIN Students s ON s.UserID=u.UserID WHERE u.Role=@Role AND u.IsActive=@Active ORDER BY u.FullName, u.UserID;", args)
        Dim requirements = db.ExecuteQuery(
            "SELECT u.UserID AS ReportStudentID, r.*, d.DepartmentName, COALESCE(cr.RecordID,0) AS RecordID, COALESCE(cr.Status,@Pending) AS DBStatus, cr.Remarks, cr.SubmittedFilePath, cr.SubmittedFileName, cr.SubmittedAt, 0 AS FileCount " &
            "FROM Users u JOIN Students s ON s.UserID=u.UserID CROSS JOIN ClearanceRequirements r JOIN Departments d ON d.DepartmentID=r.DepartmentID " &
            "LEFT JOIN ClearanceRecords cr ON cr.RequirementID=r.RequirementID AND cr.StudentID=u.UserID AND cr.TermID=@TermID " &
            "WHERE u.Role=@Role AND u.IsActive=@Active AND r.IsActive=@Active AND d.IsActive=@Active " &
            "AND (d.DepartmentName<>@StudentAffairs OR cr.RecordID IS NOT NULL OR EXISTS(SELECT 1 FROM AcademicTerms t WHERE t.TermID=@TermID AND t.IsActive=@Active)) " &
            "ORDER BY u.UserID,r.DisplayOrder,r.SequenceOrder,r.RequirementID;", args)
        Dim activities = db.ExecuteQuery("SELECT cr.StudentID, MAX(h.ActionAt) AS LastHistory, MAX(cr.SubmittedAt) AS LastSubmission FROM ClearanceRecords cr LEFT JOIN ClearanceHistory h ON h.RecordID=cr.RecordID WHERE cr.TermID=@TermID GROUP BY cr.StudentID;", args)
        Dim grouped = requirements.AsEnumerable().ToLookup(Function(r) CInt(r("ReportStudentID")))
        Dim dates = activities.AsEnumerable().ToDictionary(Function(r) CInt(r("StudentID")))
        Dim result As New List(Of StudentReportRow)
        For Each r As DataRow In students.Rows
            Dim studentID = CInt(r("UserID"))
            Dim items = ClearanceWorkflowHelper.GetStudentClearanceItems(grouped(studentID), r("Course").ToString(), r("YearLevel").ToString(), Convert.ToBoolean(r("EnrolledInNSTP")))
            Dim waiting = items.Where(Function(i) i.IsApplicable AndAlso Not String.Equals(i.EffectiveStatus, "Cleared", StringComparison.OrdinalIgnoreCase)).OrderBy(Function(i) i.SequenceOrder).ThenBy(Function(i) i.DisplayOrder).FirstOrDefault()
            Dim lastActivity As DateTime? = Nothing
            If dates.ContainsKey(studentID) Then
                Dim dr = dates(studentID)
                Dim raw = If(IsDBNull(dr("LastHistory")), dr("LastSubmission"), dr("LastHistory"))
                If Not IsDBNull(raw) Then lastActivity = Convert.ToDateTime(raw)
            End If
            result.Add(New StudentReportRow With {
                .UserID = studentID, .StudentNo = r("StudentNo").ToString(), .FullName = r("FullName").ToString(),
                .Course = r("Course").ToString(), .Year = r("YearLevel").ToString(), .Items = items,
                .Status = ClearanceWorkflowHelper.ComputeStudentOverallStatus(items), .Progress = ClearanceWorkflowHelper.GetStudentProgressText(items),
                .WaitingOn = If(waiting Is Nothing, "-", waiting.DepartmentName & If(waiting.EffectiveStatus = "Rejected", " (returned)", "")), .LastActivity = lastActivity})
        Next
        Return result
    End Function

    Private Sub RefreshResults()
        Dim search = txtSearch.Text.Trim()
        filteredRows = allRows.Where(Function(r) (selectedCourse = "" OrElse r.Course = selectedCourse) AndAlso
            (selectedYear = "" OrElse r.Year = selectedYear) AndAlso (selectedStatus = "" OrElse r.Status = selectedStatus) AndAlso
            (selectedOffice = 0 OrElse r.Applicable.Any(Function(i) i.DepartmentID = selectedOffice)) AndAlso
            (search = "" OrElse r.FullName.Contains(search, StringComparison.OrdinalIgnoreCase) OrElse r.StudentNo.Contains(search, StringComparison.OrdinalIgnoreCase))).ToList()
        Dim counts = StatusCounts()
        lblClearedCount.Text = counts(0).ToString()
        lblProgressCount.Text = counts(1).ToString()
        lblAttentionCount.Text = counts(2).ToString()
        lblClearedDetail.Text = Percent(counts(0), filteredRows.Count) & " of students"
        lblProgressDetail.Text = Percent(counts(1), filteredRows.Count) & " of students"
        lblAttentionDetail.Text = Percent(counts(2), filteredRows.Count) & " of students"
        Dim applicable = filteredRows.SelectMany(Function(r) r.Applicable).Where(Function(i) selectedOffice = 0 OrElse i.DepartmentID = selectedOffice).ToList()
        lblReviewCount.Text = Enumerable.Count(applicable, Function(i) i.DBStatus = "Under Review" AndAlso i.RecordID > 0).ToString()
        lblReviewDetail.Text = "submissions under review"
        officeRows = applicable.GroupBy(Function(i) i.DepartmentID).OrderBy(Function(g) g.Min(Function(i) i.DisplayOrder)).Select(Function(g) New OfficeReportRow With {
            .Name = g.First().DepartmentName,
            .Counts = {g.Count(Function(i) i.EffectiveStatus = "Cleared"), g.Count(Function(i) i.EffectiveStatus = "Under Review"), g.Count(Function(i) i.EffectiveStatus = "Pending" OrElse i.EffectiveStatus = "Locked"), g.Count(Function(i) i.EffectiveStatus = "Rejected")}}).ToList()
        chartOffices.AutoScrollMinSize = New Size(0, 36 + officeRows.Count * 34)
        chartOffices.Invalidate()
        chartOverall.Invalidate()
        DisplayPage()
        btnExportCsv.Enabled = Not loading AndAlso loaded AndAlso Not filtersChanged AndAlso filteredRows.Count > 0
        btnExportPdf.Enabled = btnExportCsv.Enabled
        btnPrint.Enabled = btnExportCsv.Enabled
    End Sub

    Private Function StatusCounts() As Integer()
        Return {Enumerable.Count(filteredRows, Function(r) r.Status = "Cleared"), Enumerable.Count(filteredRows, Function(r) r.Status <> "Cleared" AndAlso r.Status <> "Needs Attention"), Enumerable.Count(filteredRows, Function(r) r.Status = "Needs Attention")}
    End Function

    Private Shared Function Percent(value As Integer, total As Integer) As String
        Return If(total = 0, "0%", (value * 100.0 / Math.Max(total, 1)).ToString("0.#", CultureInfo.CurrentCulture) & "%")
    End Function

    Private Sub DisplayPage()
        pageIndex = Math.Max(0, Math.Min(pageIndex, Math.Max(0, (filteredRows.Count - 1) \ PageSize)))
        dgvStudents.Rows.Clear()
        For Each r In filteredRows.Skip(pageIndex * PageSize).Take(PageSize)
            Dim index = dgvStudents.Rows.Add(RowValues(r))
            dgvStudents.Rows(index).Tag = r
        Next
        UpdatePaging()
    End Sub

    Private Shared Function RowValues(r As StudentReportRow) As String()
        Return {r.StudentNo, r.FullName, r.Course & " / " & r.Year, r.Progress, r.Status, r.WaitingOn, If(r.LastActivity.HasValue, r.LastActivity.GetValueOrDefault().ToString("MMM dd, yyyy h:mm tt"), "-")}
    End Function

    Private Sub UpdatePaging()
        btnPrevious.Enabled = Not loading AndAlso pageIndex > 0
        btnNext.Enabled = Not loading AndAlso (pageIndex + 1) * PageSize < filteredRows.Count
        lblPage.Text = If(filteredRows.Count = 0, "No students match this report.", "Showing " & (pageIndex * PageSize + 1).ToString() & "-" & Math.Min((pageIndex + 1) * PageSize, filteredRows.Count).ToString() & " of " & filteredRows.Count.ToString() & " students")
    End Sub

    Private Sub SearchChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If loading Then Return
        pageIndex = 0
        RefreshResults()
    End Sub

    Private Sub PageClicked(sender As Object, e As EventArgs) Handles btnPrevious.Click, btnNext.Click
        pageIndex += If(sender Is btnNext, 1, -1)
        DisplayPage()
    End Sub

    Private Async Sub PresetClicked(sender As Object, e As EventArgs) Handles btnPresetAll.Click, btnPresetCleared.Click, btnPresetAttention.Click, btnPresetOffice.Click, btnPresetWaiting.Click
        If loading Then Return
        cmbStatus.SelectedIndex = If(sender Is btnPresetCleared, 1, If(sender Is btnPresetAttention, 3, 0))
        reportTitle = DirectCast(sender, Button).Text
        Await GenerateReportAsync()
        If sender Is btnPresetOffice Then pnlViewport.ScrollControlIntoView(pnlOfficeChart)
        If sender Is btnPresetWaiting Then pnlViewport.ScrollControlIntoView(pnlStudents)
    End Sub

    Private Sub OfficesPaint(sender As Object, e As PaintEventArgs) Handles chartOffices.Paint
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        g.TranslateTransform(0, chartOffices.AutoScrollPosition.Y)
        Dim colors = {green, blue, amber, red}
        Dim labels = {"Cleared", "Under review", "Pending / locked", "Rejected"}
        Using small As New Font("Segoe UI", 8.5F)
            For j As Integer = 0 To 3
                Using b As New SolidBrush(colors(j))
                    g.FillRectangle(b, j * 172, 2, 12, 12)
                End Using
                g.DrawString(labels(j), small, Brushes.SlateGray, j * 172 + 18, 0)
            Next
            If officeRows.Count = 0 Then g.DrawString("No applicable clearance records.", small, Brushes.SlateGray, 4, 48)
            For n As Integer = 0 To officeRows.Count - 1
                Dim r = officeRows(n)
                Dim total = r.Counts.Sum()
                Dim y = 33 + n * 34
                g.DrawString(r.Name, small, Brushes.Black, New RectangleF(0, y - 4, 188, 33))
                Dim x As Single = 194
                Dim width = Math.Max(80, chartOffices.ClientSize.Width - 323)
                For j As Integer = 0 To 3
                    Dim segment As Single = CSng(width * r.Counts(j) / Math.Max(1, total))
                    Using b As New SolidBrush(colors(j))
                        g.FillRectangle(b, x, y, segment, 19)
                    End Using
                    x += segment
                Next
                g.DrawString(r.Counts(0).ToString() & " / " & total.ToString() & " cleared", small, Brushes.SlateGray, 202 + width, y)
            Next
        End Using
    End Sub

    Private Sub OverallPaint(sender As Object, e As PaintEventArgs) Handles chartOverall.Paint
        Dim g = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias
        Dim counts = StatusCounts()
        Dim colors = {green, amber, red}
        Dim labels = {"Fully cleared", "In progress", "Needs attention"}
        Dim diameter = Math.Min(192, chartOverall.ClientSize.Width - 30)
        Dim x = (chartOverall.ClientSize.Width - diameter) \ 2
        Dim circle As New Rectangle(x, 4, diameter, diameter)
        g.FillEllipse(Brushes.Gainsboro, circle)
        Dim angle As Single = -90
        For j As Integer = 0 To 2
            Dim sweep As Single = CSng(counts(j) * 360.0 / Math.Max(filteredRows.Count, 1))
            If sweep > 0 Then
                Using b As New SolidBrush(colors(j))
                    g.FillPie(b, circle, angle, sweep)
                End Using
            End If
            angle += sweep
        Next
        Dim hole = Rectangle.Inflate(circle, -36, -36)
        g.FillEllipse(Brushes.White, hole)
        Using big As New Font("Segoe UI", 23, FontStyle.Bold), small As New Font("Segoe UI", 9), center As New StringFormat With {.Alignment = StringAlignment.Center, .LineAlignment = StringAlignment.Center}
            g.DrawString(filteredRows.Count.ToString(), big, Brushes.Black, New RectangleF(x, 60, diameter, 44), center)
            g.DrawString("students", small, Brushes.SlateGray, New RectangleF(x, 103, diameter, 24), center)
            For j As Integer = 0 To 2
                Dim y = 220 + j * 29
                Using b As New SolidBrush(colors(j))
                    g.FillRectangle(b, 5, y + 3, 12, 12)
                End Using
                g.DrawString(labels(j), small, Brushes.Black, 25, y)
                g.DrawString(counts(j).ToString() & " (" & Percent(counts(j), filteredRows.Count) & ")", small, Brushes.SlateGray, chartOverall.Width - 108, y)
            Next
        End Using
    End Sub

    Private Sub CellPaint(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvStudents.CellPainting
        If e.RowIndex < 0 OrElse (e.ColumnIndex <> colProgress.Index AndAlso e.ColumnIndex <> colStatus.Index) Then Return
        Dim r = TryCast(dgvStudents.Rows(e.RowIndex).Tag, StudentReportRow)
        If r Is Nothing Then Return
        e.PaintBackground(e.ClipBounds, True)
        Dim bounds = e.CellBounds
        If e.ColumnIndex = colProgress.Index Then
            Dim total = r.Applicable.Count
            Dim cleared = Enumerable.Count(r.Applicable, Function(i) i.EffectiveStatus = "Cleared")
            e.Graphics.FillRectangle(Brushes.Gainsboro, bounds.X + 8, bounds.Y + 30, bounds.Width - 16, 5)
            Using b As New SolidBrush(blue)
                e.Graphics.FillRectangle(b, bounds.X + 8, bounds.Y + 30, CSng((bounds.Width - 16) * cleared / Math.Max(total, 1)), 5)
            End Using
            TextRenderer.DrawText(e.Graphics, r.Progress, dgvStudents.Font, New Rectangle(bounds.X + 8, bounds.Y + 6, bounds.Width - 16, 22), Color.SlateGray)
        Else
            Dim textColor = If(r.Status = "Cleared", green, If(r.Status = "Needs Attention", red, Color.FromArgb(180, 83, 9)))
            Dim background = If(r.Status = "Cleared", Color.FromArgb(220, 252, 231), If(r.Status = "Needs Attention", Color.FromArgb(254, 226, 226), Color.FromArgb(254, 243, 199)))
            Dim pill = Rectangle.Inflate(bounds, -6, -10)
            Using b As New SolidBrush(background)
                e.Graphics.FillRectangle(b, pill)
            End Using
            TextRenderer.DrawText(e.Graphics, r.Status, dgvStudents.Font, pill, textColor, TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter)
        End If
        e.Handled = True
    End Sub

    Private Function CanExport() As Boolean
        If Not SessionAllowed() Then
            MessageBox.Show("Only administrators can export reports.", "Access denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If loading OrElse Not loaded OrElse filtersChanged OrElse filteredRows.Count = 0 Then
            MessageBox.Show("Generate a report with matching students first.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If
        Return True
    End Function

    Friend Shared Function CsvField(value As String) As String
        Dim text = If(value, "")
        Dim leading = text.TrimStart()
        If leading.Length > 1 AndAlso "=+-@".Contains(leading(0)) Then text = "'" & text
        Return """" & text.Replace("""", """""") & """"
    End Function

    Private Sub ExportCsv(sender As Object, e As EventArgs) Handles btnExportCsv.Click
        If Not CanExport() Then Return
        Try
            Using dialog As New SaveFileDialog With {.Filter = "CSV files (*.csv)|*.csv", .FileName = "Clearance_Report_" & generatedAt.ToString("yyyyMMdd") & ".csv"}
                If dialog.ShowDialog(Me) <> DialogResult.OK Then Return
                WriteCsv(dialog.FileName, filteredRows)
            End Using
            MessageBox.Show("Report exported successfully.", "Reports", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Unable to export CSV. " & ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend Shared Sub WriteCsv(path As String, rows As IEnumerable(Of StudentReportRow))
        Using writer As New StreamWriter(path, False, New UTF8Encoding(True))
            writer.WriteLine(String.Join(",", {"Student No.", "Name", "Course / Year", "Progress", "Status", "Waiting on", "Last activity"}.Select(Function(v) CsvField(v))))
            For Each r In rows
                writer.WriteLine(String.Join(",", RowValues(r).Select(Function(v) CsvField(v))))
            Next
        End Using
    End Sub

    Private Sub PrintReport(sender As Object, e As EventArgs) Handles btnPrint.Click, btnExportPdf.Click
        If Not CanExport() Then Return
        Try
            printRows = filteredRows.ToList()
            Using doc As New PrintDocument()
                doc.DocumentName = reportTitle
                doc.DefaultPageSettings.Landscape = True
                doc.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)
                AddHandler doc.BeginPrint, Sub(s, args)
                                              printIndex = 0
                                              printPageNumber = 0
                                          End Sub
                AddHandler doc.PrintPage, AddressOf DrawPrintPage
                If sender Is btnExportPdf Then
                    Using dialog As New PrintDialog With {.Document = doc, .UseEXDialog = True, .AllowSomePages = False}
                        MessageBox.Show("Select Microsoft Print to PDF in the printer list, then click Print to save the report.", "Export PDF", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If dialog.ShowDialog(Me) = DialogResult.OK Then doc.Print()
                    End Using
                Else
                    Using preview As New PrintPreviewDialog With {.Document = doc, .Width = 1100, .Height = 800}
                        preview.ShowDialog(Me)
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to print the report. " & ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DrawPrintPage(sender As Object, e As PrintPageEventArgs)
        printPageNumber += 1
        Dim g = e.Graphics
        Dim area = e.MarginBounds
        Dim y As Single = area.Top
        Using heading As New Font("Segoe UI", 15, FontStyle.Bold), normal As New Font("Segoe UI", 9), bold As New Font("Segoe UI", 9, FontStyle.Bold)
            g.DrawString("Lyceum of Alabang - Student EClearance", heading, Brushes.Black, area.Left, y)
            y += 30
            g.DrawString(reportTitle & " | " & reportTerm, bold, Brushes.Black, area.Left, y)
            y += 24
            Dim filterText = reportFilters & If(txtSearch.Text.Trim() = "", "", " | Search: " & txtSearch.Text.Trim())
            Dim filterHeight = g.MeasureString(filterText, normal, area.Width).Height
            g.DrawString(filterText, normal, Brushes.Black, New RectangleF(area.Left, y, area.Width, filterHeight + 5))
            y += filterHeight + 10
            g.DrawString("Generated: " & generatedAt.ToString("MMM dd, yyyy h:mm tt"), normal, Brushes.Black, area.Left, y)
            y += 24
            Dim counts = StatusCounts()
            g.DrawString("Fully cleared: " & counts(0) & "   In progress: " & counts(1) & "   Needs attention: " & counts(2) & "   Awaiting review: " & lblReviewCount.Text, bold, Brushes.Black, area.Left, y)
            y += 30
            Dim fractions = {0.1F, 0.17F, 0.14F, 0.08F, 0.12F, 0.23F, 0.16F}
            Dim headers = {"Student No.", "Name", "Course / Year", "Progress", "Status", "Waiting on", "Last activity"}
            Dim x As Single = area.Left
            For j As Integer = 0 To headers.Length - 1
                Dim w = area.Width * fractions(j)
                g.FillRectangle(Brushes.WhiteSmoke, x, y, w, 34)
                g.DrawString(headers(j), bold, Brushes.Black, New RectangleF(x + 4, y + 3, w - 8, 30))
                x += w
            Next
            y += 34
            Dim firstIndex = printIndex
            While printIndex < printRows.Count
                Dim values = RowValues(printRows(printIndex))
                Dim rowHeight As Single = 34
                For j As Integer = 0 To values.Length - 1
                    rowHeight = Math.Max(rowHeight, g.MeasureString(values(j), normal, CInt(area.Width * fractions(j) - 8)).Height + 12)
                Next
                If y + rowHeight > area.Bottom - 30 Then
                    If printIndex = firstIndex Then Throw New InvalidOperationException("The selected paper size is too small for a report row. Choose a larger paper size.")
                    Exit While
                End If
                x = area.Left
                For j As Integer = 0 To values.Length - 1
                    Dim w = area.Width * fractions(j)
                    g.DrawString(values(j), normal, Brushes.Black, New RectangleF(x + 4, y + 5, w - 8, rowHeight - 8))
                    x += w
                Next
                g.DrawLine(Pens.LightGray, area.Left, y + rowHeight, area.Right, y + rowHeight)
                y += rowHeight
                printIndex += 1
            End While
            g.DrawString("Page " & printPageNumber.ToString() & " | " & printRows.Count.ToString() & " students", normal, Brushes.Gray, area.Left, area.Bottom - 20)
            e.HasMorePages = printIndex < printRows.Count
        End Using
    End Sub

    Private Sub Navigate(sender As Object, e As EventArgs) Handles btnNavStudents.Click, btnNavStaff.Click, btnNavHistory.Click, btnNavStartTerm.Click
        If Not SessionAllowed() Then Return
        Dim host = Application.OpenForms.OfType(Of AdminStudentsForm)().FirstOrDefault()
        If host Is Nothing Then
            host = New AdminStudentsForm()
            host.Show()
        End If
        If sender Is btnNavStudents Then host.ShowStudentsView()
        If sender Is btnNavStaff Then host.ShowStaffOfficesView()
        If sender Is btnNavHistory Then host.ShowHistoryView()
        If sender Is btnNavStartTerm Then host.ShowStartNewTermView()
        If TopLevel Then Close()
    End Sub

    Private Async Sub ReportsClicked(sender As Object, e As EventArgs) Handles btnNavReports.Click
        Await GenerateReportAsync()
    End Sub

    Private Sub Logout(sender As Object, e As EventArgs) Handles btnNavLogout.Click
        If MessageBox.Show("Are you sure you want to log out?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        AppSession.Clear()
        Dim host = Application.OpenForms.OfType(Of AdminStudentsForm)().FirstOrDefault()
        If host IsNot Nothing Then host.Close()
        Close()
    End Sub

    Private Sub pnlViewport_Resize(sender As Object, e As EventArgs) Handles pnlViewport.Resize
        If pnlCanvas IsNot Nothing AndAlso pnlViewport IsNot Nothing Then
            Dim targetWidth = Math.Max(pnlCanvas.MinimumSize.Width, pnlViewport.ClientSize.Width)
            If pnlCanvas.Width <> targetWidth Then
                pnlCanvas.Width = targetWidth
            End If
        End If
    End Sub
End Class

Public Class ReportsChartPanel
    Inherits Panel
    Public Sub New()
        DoubleBuffered = True
        ResizeRedraw = True
    End Sub
    Protected Overrides Sub OnScroll(se As ScrollEventArgs)
        MyBase.OnScroll(se)
        Invalidate()
    End Sub
End Class
