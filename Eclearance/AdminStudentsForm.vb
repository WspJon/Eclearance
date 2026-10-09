Public Class AdminStudentsForm

    Private ReadOnly db As New DatabaseHelper()
    Private _isLoadingFilters As Boolean = False

    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private WithEvents btnExportCSV As Button

    Private Sub AdminStudentsForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        ApplySchoolLogo(picSchoolLogo)
        LoadCurrentTermLabel()
        InitializeFilters()

        ' Dynamically add Export CSV button to preserve Designer
        btnExportCSV = New Button()
        btnExportCSV.Text = "⬇ Export CSV"
        btnExportCSV.Size = New Size(105, 38)
        btnExportCSV.Location = New Point(btnAddStudent.Location.X - 115, btnAddStudent.Location.Y)
        btnExportCSV.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnExportCSV.BackColor = Color.White
        btnExportCSV.ForeColor = Color.FromArgb(51, 65, 85)
        btnExportCSV.FlatStyle = FlatStyle.Flat
        btnExportCSV.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnExportCSV.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnExportCSV.Cursor = Cursors.Hand
        pnlHeader.Controls.Add(btnExportCSV)

        LoadStudents()

    End Sub

    ' ============================================================
    ' INITIALIZE FILTERS
    ' ============================================================
    Private Sub InitializeFilters()
        _isLoadingFilters = True

        Try
            ' 1. Course Filter
            cmbFilterCourse.Items.Clear()
            cmbFilterCourse.Items.Add("All Courses")

            Dim db As New DatabaseHelper()
            Dim coursesFound As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

            Try
                Dim dtSections As DataTable = db.ExecuteQuery(
                    "SELECT DISTINCT CourseName FROM Sections WHERE IsActive = 1 ORDER BY CourseName ASC;"
                )
                For Each r As DataRow In dtSections.Rows
                    Dim cName As String = If(IsDBNull(r("CourseName")), "", r("CourseName").ToString().Trim())
                    If Not String.IsNullOrWhiteSpace(cName) AndAlso coursesFound.Add(cName) Then
                        cmbFilterCourse.Items.Add(cName)
                    End If
                Next
            Catch
            End Try

            Try
                Dim dtUsers As DataTable = db.ExecuteQuery(
                    "SELECT DISTINCT Course FROM Students WHERE Course IS NOT NULL AND Course <> '' ORDER BY Course ASC;"
                )
                For Each r As DataRow In dtUsers.Rows
                    Dim cName As String = If(IsDBNull(r("Course")), "", r("Course").ToString().Trim())
                    If Not String.IsNullOrWhiteSpace(cName) AndAlso coursesFound.Add(cName) Then
                        cmbFilterCourse.Items.Add(cName)
                    End If
                Next
            Catch
            End Try

            If coursesFound.Count = 0 Then
                Dim fallbackCourses As String() = {"BSIT", "BSBA", "BSA", "BSTM", "BSCpE", "BSHM", "CTHM"}
                For Each c In fallbackCourses
                    cmbFilterCourse.Items.Add(c)
                Next
            End If

            cmbFilterCourse.SelectedIndex = 0

            ' 2. Year Level Filter
            cmbFilterYear.Items.Clear()
            cmbFilterYear.Items.AddRange(New Object() {"All Year Levels", "1st Year", "2nd Year", "3rd Year", "4th Year"})
            cmbFilterYear.SelectedIndex = 0

            ' 3. Section Filter
            PopulateSectionFilter()

            ' 4. Status Filter
            cmbFilterStatus.Items.Clear()
            cmbFilterStatus.Items.AddRange(New Object() {"All Statuses", "Cleared", "In Progress", "Needs Attention"})
            cmbFilterStatus.SelectedIndex = 0

        Finally
            _isLoadingFilters = False
        End Try
    End Sub

    Private Sub PopulateSectionFilter()
        cmbFilterSection.Items.Clear()
        cmbFilterSection.Items.Add("All Sections")

        Dim db As New DatabaseHelper()
        Dim sectionsFound As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

        Try
            Dim selectedCourse As String = If(cmbFilterCourse.SelectedIndex > 0, cmbFilterCourse.SelectedItem.ToString(), "")

            If String.IsNullOrWhiteSpace(selectedCourse) OrElse selectedCourse.Equals("All Courses", StringComparison.OrdinalIgnoreCase) Then
                Dim dtSec As DataTable = db.ExecuteQuery(
                    "SELECT DISTINCT SectionName FROM Sections WHERE IsActive = 1 ORDER BY SectionName ASC;"
                )
                For Each r As DataRow In dtSec.Rows
                    Dim sName As String = If(IsDBNull(r("SectionName")), "", r("SectionName").ToString().Trim())
                    If Not String.IsNullOrWhiteSpace(sName) AndAlso sectionsFound.Add(sName) Then
                        cmbFilterSection.Items.Add(sName)
                    End If
                Next

                Dim dtUserSec As DataTable = db.ExecuteQuery(
                    "SELECT DISTINCT s.Section FROM Students s INNER JOIN Users u ON s.UserID = u.UserID WHERE u.Role = 'Student' AND s.Section IS NOT NULL AND s.Section <> '' ORDER BY s.Section ASC;"
                )
                For Each r As DataRow In dtUserSec.Rows
                    Dim sName As String = If(IsDBNull(r("Section")), "", r("Section").ToString().Trim())
                    If Not String.IsNullOrWhiteSpace(sName) AndAlso sectionsFound.Add(sName) Then
                        cmbFilterSection.Items.Add(sName)
                    End If
                Next
            Else
                Dim dtSec As DataTable = db.ExecuteQuery(
                    "SELECT SectionName FROM Sections WHERE CourseName = @Course AND IsActive = 1 ORDER BY SectionName ASC;",
                    New Dictionary(Of String, Object) From {{"@Course", selectedCourse}}
                )
                For Each r As DataRow In dtSec.Rows
                    Dim sName As String = If(IsDBNull(r("SectionName")), "", r("SectionName").ToString().Trim())
                    If Not String.IsNullOrWhiteSpace(sName) AndAlso sectionsFound.Add(sName) Then
                        cmbFilterSection.Items.Add(sName)
                    End If
                Next

                Dim dtUserSec As DataTable = db.ExecuteQuery(
                    "SELECT DISTINCT s.Section FROM Students s INNER JOIN Users u ON s.UserID = u.UserID WHERE u.Role = 'Student' AND s.Course = @Course AND s.Section IS NOT NULL AND s.Section <> '' ORDER BY s.Section ASC;",
                    New Dictionary(Of String, Object) From {{"@Course", selectedCourse}}
                )
                For Each r As DataRow In dtUserSec.Rows
                    Dim sName As String = If(IsDBNull(r("Section")), "", r("Section").ToString().Trim())
                    If Not String.IsNullOrWhiteSpace(sName) AndAlso sectionsFound.Add(sName) Then
                        cmbFilterSection.Items.Add(sName)
                    End If
                Next
            End If
        Catch
        End Try

        cmbFilterSection.SelectedIndex = 0
    End Sub

    ' ============================================================
    ' FILTER EVENT HANDLERS
    ' ============================================================
    Private Sub cmbFilterCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterCourse.SelectedIndexChanged
        If _isLoadingFilters Then Return
        _isLoadingFilters = True
        PopulateSectionFilter()
        _isLoadingFilters = False
        LoadStudents()
    End Sub

    Private Sub cmbFilterYear_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterYear.SelectedIndexChanged
        If _isLoadingFilters Then Return
        LoadStudents()
    End Sub

    Private Sub cmbFilterSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterSection.SelectedIndexChanged
        If _isLoadingFilters Then Return
        LoadStudents()
    End Sub

    Private Sub cmbFilterStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilterStatus.SelectedIndexChanged
        If _isLoadingFilters Then Return
        LoadStudents()
    End Sub

    Private Sub btnResetFilters_Click(sender As Object, e As EventArgs) Handles btnResetFilters.Click
        _isLoadingFilters = True
        txtSearch.Text = ""
        cmbFilterCourse.SelectedIndex = 0
        cmbFilterYear.SelectedIndex = 0
        PopulateSectionFilter()
        cmbFilterStatus.SelectedIndex = 0
        _isLoadingFilters = False
        LoadStudents()
    End Sub


    ' ============================================================
    ' ADD STUDENT BUTTON
    ' ============================================================
    Private Sub btnAddStudent_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAddStudent.Click

        Dim modalBackdrop As New Form()

        Try
            modalBackdrop.FormBorderStyle = FormBorderStyle.None
            modalBackdrop.BackColor = Color.Black
            modalBackdrop.Opacity = 0.45R
            modalBackdrop.ShowInTaskbar = False
            modalBackdrop.StartPosition = FormStartPosition.Manual
            modalBackdrop.Location = Me.PointToScreen(Point.Empty)
            modalBackdrop.Size = Me.ClientSize
            modalBackdrop.Owner = Me
            modalBackdrop.Show()

            Using frm As New CreateStudentForm()
                If frm.ShowDialog(modalBackdrop) = DialogResult.OK Then
                    LoadStudents()
                End If
            End Using

        Finally
            modalBackdrop.Dispose()
        End Try

    End Sub


    ' ============================================================
    ' REFRESH BUTTON
    ' ============================================================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        LoadStudents()

    End Sub


    ' ============================================================
    ' SEARCH
    ' ============================================================
    Private Sub txtSearch_TextChanged(
        sender As Object,
        e As EventArgs
    ) Handles txtSearch.TextChanged

        LoadStudents()

    End Sub


    ' ============================================================
    ' LOAD STUDENTS
    ' ============================================================
    Private Sub LoadStudents()

        Try

            dgvStudents.Rows.Clear()

            Dim searchText As String = txtSearch.Text.Trim()
            Dim selectedCourse As String = If(cmbFilterCourse.SelectedIndex > 0, cmbFilterCourse.SelectedItem.ToString(), "")
            Dim selectedYear As String = If(cmbFilterYear.SelectedIndex > 0, cmbFilterYear.SelectedItem.ToString(), "")
            Dim selectedSection As String = If(cmbFilterSection.SelectedIndex > 0, cmbFilterSection.SelectedItem.ToString(), "")
            Dim selectedStatus As String = If(cmbFilterStatus.SelectedIndex > 0, cmbFilterStatus.SelectedItem.ToString(), "")

            Dim query As String =
                "SELECT " &
                "  u.UserID, " &
                "  COALESCE(s.StudentNo, '') AS StudentNo, " &
                "  u.FullName, " &
                "  COALESCE(s.Course, '') AS Course, " &
                "  COALESCE(s.YearLevel, '') AS YearLevel, " &
                "  COALESCE(s.Section, '') AS Section " &
                "FROM Users u " &
                "INNER JOIN Students s ON s.UserID = u.UserID " &
                "WHERE u.Role = 'Student' " &
                "AND u.IsActive = 1 "

            Dim parameters As New Dictionary(Of String, Object)()

            If Not String.IsNullOrWhiteSpace(searchText) Then
                query &=
                    "AND (" &
                    "u.FullName LIKE @Search " &
                    "OR s.StudentNo LIKE @Search" &
                    ") "
                parameters.Add("@Search", "%" & searchText & "%")
            End If

            If Not String.IsNullOrWhiteSpace(selectedCourse) AndAlso Not selectedCourse.Equals("All Courses", StringComparison.OrdinalIgnoreCase) Then
                query &= "AND s.Course = @Course "
                parameters.Add("@Course", selectedCourse)
            End If

            If Not String.IsNullOrWhiteSpace(selectedYear) AndAlso Not selectedYear.Equals("All Year Levels", StringComparison.OrdinalIgnoreCase) Then
                query &= "AND s.YearLevel = @YearLevel "
                parameters.Add("@YearLevel", selectedYear)
            End If

            If Not String.IsNullOrWhiteSpace(selectedSection) AndAlso Not selectedSection.Equals("All Sections", StringComparison.OrdinalIgnoreCase) Then
                query &= "AND s.Section = @Section "
                parameters.Add("@Section", selectedSection)
            End If

            query &= "ORDER BY u.FullName ASC;"

            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )

            For Each row As DataRow In table.Rows

                Dim userID As Integer =
                    Convert.ToInt32(
                        row("UserID")
                    )

                Dim studentNo As String =
                    row("StudentNo").ToString()

                Dim fullName As String =
                    row("FullName").ToString()

                Dim course As String =
                    row("Course").ToString()

                Dim yearLevel As String =
                    row("YearLevel").ToString()

                Dim progressText As String =
                    GetStudentProgress(userID, course, yearLevel)

                Dim statusText As String =
                    GetOverallStatus(userID, course, yearLevel)

                ' Clearance Status Filter
                If Not String.IsNullOrWhiteSpace(selectedStatus) AndAlso Not selectedStatus.Equals("All Statuses", StringComparison.OrdinalIgnoreCase) Then
                    Select Case selectedStatus
                        Case "Cleared"
                            If Not statusText.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                                Continue For
                            End If
                        Case "In Progress"
                            If Not (statusText.Equals("In Progress", StringComparison.OrdinalIgnoreCase) OrElse
                                    statusText.Equals("Pending", StringComparison.OrdinalIgnoreCase) OrElse
                                    statusText.Equals("Under Review", StringComparison.OrdinalIgnoreCase)) Then
                                Continue For
                            End If
                        Case "Needs Attention"
                            If Not statusText.Equals("Needs Attention", StringComparison.OrdinalIgnoreCase) Then
                                Continue For
                            End If
                    End Select
                End If

                Dim rowIndex As Integer =
                    dgvStudents.Rows.Add(
                        studentNo,
                        fullName,
                        course,
                        yearLevel,
                        progressText,
                        statusText
                    )

                dgvStudents.Rows(rowIndex).Tag =
                    userID

            Next

            UpdateStatistics()

            dgvClearanceDetails.Rows.Clear()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load students." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Students Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' GET STUDENT PROGRESS
    ' ============================================================
    Private Function GetStudentProgress(
        studentID As Integer,
        course As String,
        yearLevel As String
    ) As String
        Try
            Dim termID As Integer = GetActiveTermID()
            If termID = 0 Then Return "0 / 0"
            Return ClearanceWorkflowHelper.GetStudentProgressText(studentID, termID, course, yearLevel, db)
        Catch
            Return "0 / 0"
        End Try
    End Function

    ' ============================================================
    ' GET OVERALL STATUS
    ' ============================================================
    Private Function GetOverallStatus(
        studentID As Integer,
        course As String,
        yearLevel As String
    ) As String
        Try
            Dim termID As Integer = GetActiveTermID()
            If termID = 0 Then Return "No Term"
            Return ClearanceWorkflowHelper.ComputeStudentOverallStatus(studentID, termID, course, yearLevel, db)
        Catch
            Return "Pending"
        End Try
    End Function


    ' ============================================================
    ' UPDATE STATISTICS
    ' ============================================================
    Private Sub UpdateStatistics()

        Dim total As Integer =
            dgvStudents.Rows.Count

        Dim fullyCleared As Integer = 0

        Dim needsAttention As Integer = 0


        For Each row As DataGridViewRow In dgvStudents.Rows

            If row.IsNewRow Then
                Continue For
            End If


            Dim status As String =
                row.Cells(
                    colStatus.Index
                ).Value.ToString()


            If status.Equals(
                "Cleared",
                StringComparison.OrdinalIgnoreCase
            ) Then

                fullyCleared += 1

            End If


            If status.Equals(
                "Needs Attention",
                StringComparison.OrdinalIgnoreCase
            ) Then

                needsAttention += 1

            End If

        Next


        lblStatTotalVal.Text =
            total.ToString()

        lblStatClearedVal.Text =
            fullyCleared.ToString()

        lblStatAttentionVal.Text =
            needsAttention.ToString()

    End Sub


    ' ============================================================
    ' STUDENT SELECTION CHANGED
    ' ============================================================
    Private Sub dgvStudents_SelectionChanged(
        sender As Object,
        e As EventArgs
    ) Handles dgvStudents.SelectionChanged

        LoadSelectedStudentDetails()

    End Sub


    ' ============================================================
    ' LOAD CLEARANCE DETAILS FOR SELECTED STUDENT
    ' ============================================================
    Private Sub LoadSelectedStudentDetails()

        If dgvStudents.SelectedRows.Count = 0 Then

            dgvClearanceDetails.Rows.Clear()

            Return

        End If


        If dgvStudents.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim studentID As Integer =
            Convert.ToInt32(
                dgvStudents.SelectedRows(0).Tag
            )
        Dim course As String = If(dgvStudents.SelectedRows(0).Cells(colCourse.Index).Value, "").ToString()
        Dim yearLevel As String = If(dgvStudents.SelectedRows(0).Cells(colYear.Index).Value, "").ToString()

        Try

            dgvClearanceDetails.Rows.Clear()

            Dim termID As Integer =
                GetActiveTermID()

            If termID = 0 Then
                Return
            End If

            Dim items = ClearanceWorkflowHelper.GetStudentClearanceItems(studentID, termID, course, yearLevel, db)
            For Each itm In items
                dgvClearanceDetails.Rows.Add(
                    itm.DepartmentName,
                    itm.EffectiveStatus,
                    itm.Remarks
                )
            Next


        Catch ex As Exception

            MessageBox.Show(
                "Unable to load student clearance details." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Clearance Details Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' VIEW HISTORY
    ' ============================================================
    Private Sub btnViewHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewHistory.Click

        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "View History",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If dgvStudents.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim studentID As Integer =
            Convert.ToInt32(
                dgvStudents.SelectedRows(0).Tag
            )


        Dim studentName As String =
            dgvStudents.SelectedRows(0).
            Cells(colStudentName.Index).
            Value.ToString()


        ShowHistoryView(studentID, studentName)

    End Sub


    ' ============================================================
    ' RESET CURRENT TERM
    ' ============================================================
    Private Sub btnResetTerm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnResetTerm.Click

        If dgvStudents.SelectedRows.Count = 0 Then

            MessageBox.Show(
                "Please select a student first.",
                "Reset Current Term",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Return

        End If


        If dgvStudents.SelectedRows(0).Tag Is Nothing Then

            Return

        End If


        Dim answer As DialogResult =
            MessageBox.Show(
                "Reset this student's clearance for the current term?" &
                Environment.NewLine &
                Environment.NewLine &
                "All current statuses will return to Pending.",
                "Reset Current Term",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )


        If answer <> DialogResult.Yes Then

            Return

        End If


        Try

            Dim studentID As Integer =
                Convert.ToInt32(
                    dgvStudents.SelectedRows(0).Tag
                )


            Dim termID As Integer =
                GetActiveTermID()


            If termID = 0 Then

                MessageBox.Show(
                    "No active term was found.",
                    "Reset Current Term",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim query As String =
                "UPDATE ClearanceRecords " &
                "SET Status = 'Pending', " &
                "Remarks = NULL, " &
                "SubmittedFilePath = NULL, " &
                "SubmittedFileName = NULL, " &
                "SubmittedAt = NULL, " &
                "ReviewedBy = NULL, " &
                "ReviewedAt = NULL " &
                "WHERE StudentID = @StudentID " &
                "AND TermID = @TermID;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", studentID},
                {"@TermID", termID}
            }


            Dim db As New DatabaseHelper()

            db.ExecuteNonQuery(
                query,
                parameters
            )


            MessageBox.Show(
                "The student's current clearance term was reset.",
                "Reset Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )


            LoadStudents()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to reset the student's clearance." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Reset Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' CURRENT TERM LABEL
    ' ============================================================
    Private Sub LoadCurrentTermLabel()

        Try

            Dim query As String =
                "SELECT AcademicYear, Semester " &
                "FROM AcademicTerms " &
                "WHERE IsActive = 1 " &
                "ORDER BY TermID DESC " &
                "LIMIT 1;"


            Dim db As New DatabaseHelper()

            Dim table As DataTable =
                db.ExecuteQuery(query)


            If table.Rows.Count > 0 Then

                lblTermBadge.Text =
                    table.Rows(0)("AcademicYear").ToString() &
                    " - " &
                    table.Rows(0)("Semester").ToString()

            Else

                lblTermBadge.Text =
                    "No Active Term"

            End If


        Catch

            lblTermBadge.Text =
                "Current Term"

        End Try

    End Sub


    ' ============================================================
    ' GET ACTIVE TERM
    ' ============================================================
    Private Function GetActiveTermID() As Integer

        Dim query As String =
            "SELECT TermID " &
            "FROM AcademicTerms " &
            "WHERE IsActive = 1 " &
            "ORDER BY TermID DESC " &
            "LIMIT 1;"


        Dim db As New DatabaseHelper()

        Dim result As Object =
            db.ExecuteScalar(query)


        If result Is Nothing OrElse
           result Is DBNull.Value Then

            Return 0

        End If


        Return Convert.ToInt32(result)

    End Function


    ' ============================================================
    ' NAV - STUDENTS
    ' ============================================================
    Private Sub btnNavStudents_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStudents.Click

        ShowStudentsView()

    End Sub


    ' ============================================================
    ' NAV - STAFF & OFFICES
    ' ============================================================
    Private Sub btnNavStaff_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStaff.Click

        ShowStaffOfficesView()

    End Sub


    ' ============================================================
    ' NAV - HISTORY
    ' ============================================================
    Private Sub btnNavHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavHistory.Click

        ShowHistoryView()

    End Sub


    ' ============================================================
    ' NAV - START NEW TERM
    ' ============================================================
    Private Sub btnNavStartTerm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavStartTerm.Click

        ShowStartNewTermView()

    End Sub


    ' ============================================================
    ' SPA VIEW SWITCHING (SINGLE PAGE ARCHITECTURE)
    ' ============================================================
    Private pnlViewHost As Panel = Nothing

    Private Sub EnsureViewHost()
        If pnlViewHost Is Nothing Then
            pnlViewHost = New Panel()
            pnlViewHost.Dock = DockStyle.Fill
            pnlViewHost.Visible = False
            pnlViewHost.BackColor = Color.FromArgb(244, 247, 251)
            Me.Controls.Add(pnlViewHost)
        End If
    End Sub

    Public Sub ShowStudentsView()
        SetActiveNavButton(btnNavStudents)
        If pnlViewHost IsNot Nothing Then
            pnlViewHost.Visible = False
            pnlViewHost.Controls.Clear()
        End If
        pnlMain.Visible = True
        pnlMain.BringToFront()
        LoadCurrentTermLabel()
        LoadStudents()
    End Sub

    Public Sub ShowStaffOfficesView()
        SetActiveNavButton(btnNavStaff)
        LoadChildFormView(New StaffOfficesForm())
    End Sub

    Public Sub ShowHistoryView(Optional studentId As Integer? = Nothing, Optional studentName As String = "")
        SetActiveNavButton(btnNavHistory)
        Dim historyForm As New ClearanceHistoryForm()
        If studentId.HasValue Then
            historyForm.StudentIDFilter = studentId
            historyForm.StudentNameFilter = studentName
        End If
        LoadChildFormView(historyForm)
    End Sub

    Public Sub ShowStartNewTermView()
        SetActiveNavButton(btnNavStartTerm)
        LoadChildFormView(New StartNewTermForm())
    End Sub

    Private Sub LoadChildFormView(childForm As Form)
        EnsureViewHost()
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        Dim childSidebar As Control = childForm.Controls("pnlSidebar")
        If childSidebar IsNot Nothing Then
            childSidebar.Visible = False
        End If

        pnlViewHost.Controls.Clear()
        pnlViewHost.Controls.Add(childForm)
        pnlMain.Visible = False
        pnlViewHost.Visible = True
        pnlViewHost.BringToFront()
        childForm.Show()
    End Sub

    Private Sub SetActiveNavButton(activeBtn As Button)
        Dim navButtons As Button() = {btnNavStudents, btnNavStaff, btnNavHistory, btnNavStartTerm}

        For Each btn In navButtons
            If btn Is activeBtn Then
                btn.BackColor = Color.FromArgb(28, 91, 184)
                btn.ForeColor = Color.White
                btn.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
            Else
                btn.BackColor = Color.FromArgb(15, 39, 74)
                btn.ForeColor = Color.FromArgb(160, 180, 208)
                btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
            End If
        Next
    End Sub


    ' ============================================================
    ' LOGOUT
    ' ============================================================
    Private Sub btnNavLogout_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavLogout.Click

        Dim answer As DialogResult =
            MessageBox.Show(
                "Are you sure you want to log out?",
                "Log Out",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )


        If answer = DialogResult.Yes Then

            AppSession.Clear()

            Me.Close()

        End If

    End Sub

    ' ============================================================
    ' EXPORT CSV REPORT
    ' ============================================================
    Private Sub btnExportCSV_Click(sender As Object, e As EventArgs) Handles btnExportCSV.Click
        If dgvStudents.Rows.Count = 0 Then
            MessageBox.Show("No student records available to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.FileName = "Student_Clearance_Report_" & DateTime.Now.ToString("yyyyMMdd") & ".csv"
            
            If sfd.ShowDialog() = DialogResult.OK Then
                Dim sb As New System.Text.StringBuilder()
                
                ' Headers
                Dim headers = {"Student No", "Name", "Course", "Year", "Progress", "Status"}
                sb.AppendLine(String.Join(",", headers))

                ' Rows
                For Each row As DataGridViewRow In dgvStudents.Rows
                    If Not row.IsNewRow Then
                        Dim vals As New List(Of String)()
                        For i As Integer = 0 To 5
                            Dim cellVal As String = ""
                            If row.Cells(i).Value IsNot Nothing Then
                                cellVal = row.Cells(i).Value.ToString().Replace("""", """""")
                            End If
                            vals.Add("""" & cellVal & """")
                        Next
                        sb.AppendLine(String.Join(",", vals))
                    End If
                Next

                System.IO.File.WriteAllText(sfd.FileName, sb.ToString())
                MessageBox.Show("Report exported successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Error exporting report: " & ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class