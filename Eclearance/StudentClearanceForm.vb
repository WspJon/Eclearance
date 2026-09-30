Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports System.Linq

Public Class StudentClearanceForm

    Private ReadOnly db As New DatabaseHelper()

    Private allClearanceItems As New List(Of ClearanceWorkflowHelper.ClearanceItemInfo)()

    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub StudentClearanceForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetupStudentInformation()
        LoadClearanceData()

    End Sub

    ' ============================================================
    ' STUDENT INFORMATION
    ' ============================================================
    Private Sub SetupStudentInformation()

        lblStudentName.Text = AppSession.FullName & "  ▾"
        lblStudentDetails.Text =
            AppSession.StudentNo &
            " | " &
            AppSession.Course &
            " - " &
            AppSession.YearLevel

    End Sub

    ' ============================================================
    ' LOAD ALL CLEARANCE DATA
    ' ============================================================
    Public Sub LoadClearanceData()

        Try

            Dim activeTermID As Integer = GetActiveTermID()

            If activeTermID = 0 Then
                lblTermText.Text = "No Active Term"
                ClearRows()
                Return
            End If

            LoadCurrentTerm(activeTermID)

            Dim query As String =
                "SELECT " &
                "  r.RequirementID, " &
                "  r.RequirementName, " &
                "  r.Instructions, " &
                "  r.RequiresFile, " &
                "  r.SequenceOrder, " &
                "  r.RequirementLink, " &
                "  r.AppliesToCourse, " &
                "  r.RequiresNSTP, " &
                "  r.ApplicableCourses, " &
                "  r.ApplicableYearLevels, " &
                "  d.DepartmentID, " &
                "  d.DepartmentName, " &
                "  COALESCE(cr.RecordID, 0) AS RecordID, " &
                "  COALESCE(cr.Status, 'Pending') AS DBStatus, " &
                "  cr.Remarks, " &
                "  cr.SubmittedFilePath, " &
                "  cr.SubmittedFileName, " &
                "  cr.SubmittedAt, " &
                "  (SELECT COUNT(*) FROM ClearanceRecordFiles crf WHERE crf.RecordID = cr.RecordID) AS FileCount " &
                "FROM ClearanceRequirements r " &
                "INNER JOIN Departments d ON r.DepartmentID = d.DepartmentID " &
                "LEFT JOIN ClearanceRecords cr ON cr.RequirementID = r.RequirementID AND cr.StudentID = @StudentID AND cr.TermID = @TermID " &
                "WHERE r.IsActive = 1 " &
                "ORDER BY r.SequenceOrder ASC;"

            Dim parameters As New Dictionary(Of String, Object) From {
                {"@StudentID", AppSession.UserID},
                {"@TermID", activeTermID}
            }

            Dim dt As DataTable = db.ExecuteQuery(query, parameters)

            allClearanceItems.Clear()

            For Each row As DataRow In dt.Rows
                Dim item As New ClearanceWorkflowHelper.ClearanceItemInfo With {
                    .RecordID = Convert.ToInt32(row("RecordID")),
                    .RequirementID = Convert.ToInt32(row("RequirementID")),
                    .DepartmentID = Convert.ToInt32(row("DepartmentID")),
                    .DepartmentName = row("DepartmentName").ToString(),
                    .RequirementName = row("RequirementName").ToString(),
                    .Instructions = If(IsDBNull(row("Instructions")), "", row("Instructions").ToString()),
                    .RequirementLink = If(IsDBNull(row("RequirementLink")), "", row("RequirementLink").ToString()),
                    .RequiresFile = Convert.ToBoolean(row("RequiresFile")),
                    .SequenceOrder = Convert.ToInt32(row("SequenceOrder")),
                    .AppliesToCourse = If(IsDBNull(row("AppliesToCourse")), "", row("AppliesToCourse").ToString()),
                    .RequiresNSTP = Convert.ToBoolean(row("RequiresNSTP")),
                    .ApplicableCourses = If(IsDBNull(row("ApplicableCourses")), "", row("ApplicableCourses").ToString()),
                    .ApplicableYearLevels = If(IsDBNull(row("ApplicableYearLevels")), "", row("ApplicableYearLevels").ToString()),
                    .DBStatus = row("DBStatus").ToString(),
                    .Remarks = If(IsDBNull(row("Remarks")), "", row("Remarks").ToString()),
                    .SubmittedFilePath = If(IsDBNull(row("SubmittedFilePath")), "", row("SubmittedFilePath").ToString()),
                    .SubmittedFileName = If(IsDBNull(row("SubmittedFileName")), "", row("SubmittedFileName").ToString()),
                    .SubmittedAt = row("SubmittedAt"),
                    .FileCount = Convert.ToInt32(row("FileCount"))
                }

                allClearanceItems.Add(item)
            Next

            ' Evaluate strict sequential clearance workflow
            ClearanceWorkflowHelper.EvaluateSequentialWorkflow(allClearanceItems, AppSession.Course, AppSession.YearLevel)

            DisplayClearanceTable()

        Catch ex As Exception

            MessageBox.Show(
                "Unable to load your clearance information." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Clearance Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub

    ' ============================================================
    ' GET ACTIVE TERM ID
    ' ============================================================
    Private Function GetActiveTermID() As Integer

        Dim query As String =
            "SELECT TermID " &
            "FROM AcademicTerms " &
            "WHERE IsActive = 1 " &
            "ORDER BY TermID DESC " &
            "LIMIT 1;"

        Dim result As Object = db.ExecuteScalar(query)

        If result Is Nothing OrElse result Is DBNull.Value Then
            Return 0
        End If

        Return Convert.ToInt32(result)

    End Function

    ' ============================================================
    ' DISPLAY CURRENT TERM
    ' ============================================================
    Private Sub LoadCurrentTerm(termID As Integer)

        Dim query As String =
            "SELECT AcademicYear, Semester " &
            "FROM AcademicTerms " &
            "WHERE TermID = @TermID " &
            "LIMIT 1;"

        Dim parameters As New Dictionary(Of String, Object) From {
            {"@TermID", termID}
        }

        Dim dt As DataTable = db.ExecuteQuery(query, parameters)

        If dt.Rows.Count > 0 Then
            Dim row As DataRow = dt.Rows(0)
            lblTermText.Text = "Academic Year: " & row("AcademicYear").ToString() & "  |  Semester: " & row("Semester").ToString()
        Else
            lblTermText.Text = "Current Term"
        End If

    End Sub

    ' ============================================================
    ' DISPLAY CLEARANCE TABLE
    ' ============================================================
    Private Sub DisplayClearanceTable()

        ClearRows()

        Dim count As Integer = allClearanceItems.Count

        For i As Integer = 0 To Math.Min(count - 1, 8)
            PopulateRow(i, allClearanceItems(i))
        Next

    End Sub

    ' ============================================================
    ' HIDE ALL ROWS
    ' ============================================================
    Private Sub ClearRows()

        pnlRow1.Visible = False
        pnlRow2.Visible = False
        pnlRow3.Visible = False
        pnlRow4.Visible = False
        pnlRow5.Visible = False
        pnlRow6.Visible = False
        pnlRow7.Visible = False
        pnlRow8.Visible = False
        pnlRow9.Visible = False

    End Sub

    ' ============================================================
    ' POPULATE TABLE ROW
    ' ============================================================
    Private Sub PopulateRow(
        rowIndex As Integer,
        item As ClearanceWorkflowHelper.ClearanceItemInfo
    )

        Dim rowPanel As Panel = Nothing
        Dim lblNum As Label = Nothing
        Dim lblDept As Label = Nothing
        Dim lblReq As Label = Nothing
        Dim lblStatus As Label = Nothing
        Dim btnAct As Button = Nothing
        Dim btnViewReq As Button = Nothing
        Dim lblDash As Label = Nothing

        Select Case rowIndex
            Case 0
                rowPanel = pnlRow1
                lblNum = lblNum1
                lblDept = lblDept1
                lblReq = lblReq1
                lblStatus = lblStatus1
                btnAct = btnAction1
                btnViewReq = btnViewReq1
                lblDash = lblDash1
            Case 1
                rowPanel = pnlRow2
                lblNum = lblNum2
                lblDept = lblDept2
                lblReq = lblReq2
                lblStatus = lblStatus2
                btnAct = btnAction2
                btnViewReq = btnViewReq2
                lblDash = lblDash2
            Case 2
                rowPanel = pnlRow3
                lblNum = lblNum3
                lblDept = lblDept3
                lblReq = lblReq3
                lblStatus = lblStatus3
                btnAct = btnAction3
                btnViewReq = btnViewReq3
                lblDash = lblDash3
            Case 3
                rowPanel = pnlRow4
                lblNum = lblNum4
                lblDept = lblDept4
                lblReq = lblReq4
                lblStatus = lblStatus4
                btnAct = btnAction4
                btnViewReq = btnViewReq4
                lblDash = lblDash4
            Case 4
                rowPanel = pnlRow5
                lblNum = lblNum5
                lblDept = lblDept5
                lblReq = lblReq5
                lblStatus = lblStatus5
                btnAct = btnAction5
                btnViewReq = btnViewReq5
                lblDash = lblDash5
            Case 5
                rowPanel = pnlRow6
                lblNum = lblNum6
                lblDept = lblDept6
                lblReq = lblReq6
                lblStatus = lblStatus6
                btnAct = btnAction6
                btnViewReq = btnViewReq6
                lblDash = lblDash6
            Case 6
                rowPanel = pnlRow7
                lblNum = lblNum7
                lblDept = lblDept7
                lblReq = lblReq7
                lblStatus = lblStatus7
                btnAct = btnAction7
                btnViewReq = btnViewReq7
                lblDash = lblDash7
            Case 7
                rowPanel = pnlRow8
                lblNum = lblNum8
                lblDept = lblDept8
                lblReq = lblReq8
                lblStatus = lblStatus8
                btnAct = btnAction8
                btnViewReq = btnViewReq8
                lblDash = lblDash8
            Case 8
                rowPanel = pnlRow9
                lblNum = lblNum9
                lblDept = lblDept9
                lblReq = lblReq9
                lblStatus = lblStatus9
                btnAct = btnAction9
                btnViewReq = btnViewReq9
                lblDash = lblDash9
            Case Else
                Return
        End Select

        rowPanel.Visible = True
        lblNum.Text = (rowIndex + 1).ToString()
        lblDept.Text = item.DepartmentName
        lblReq.Text = If(String.IsNullOrWhiteSpace(item.Instructions), item.RequirementName, item.RequirementName & " — " & item.Instructions)
        lblStatus.Text = item.EffectiveStatus
        ApplyStatusStyle(lblStatus, item.EffectiveStatus)

        btnAct.Tag = item
        btnViewReq.Tag = item

        Dim isGuidance As Boolean = (item.SequenceOrder = 1 OrElse item.DepartmentName.ToLowerInvariant().Contains("guidance"))
        Dim hasFile As Boolean = (Not String.IsNullOrWhiteSpace(item.SubmittedFileName) OrElse item.FileCount > 0)

        Select Case item.EffectiveStatus.ToLowerInvariant()

            Case "cleared"
                btnAct.Visible = True
                btnAct.Enabled = True
                btnAct.Text = "View Details"
                btnAct.BackColor = Color.FromArgb(226, 232, 240)
                btnAct.ForeColor = Color.FromArgb(30, 41, 59)
                btnAct.Size = New Size(110, 32)
                btnAct.Location = New Point(0, 0)
                btnViewReq.Visible = False
                lblDash.Visible = False

            Case "under review"
                btnAct.Visible = True
                btnAct.Enabled = True
                btnAct.Text = "View Details"
                btnAct.BackColor = Color.FromArgb(226, 232, 240)
                btnAct.ForeColor = Color.FromArgb(30, 41, 59)
                btnAct.Size = New Size(110, 32)
                btnAct.Location = New Point(0, 0)
                btnViewReq.Visible = False
                lblDash.Visible = False

            Case "pending"
                If item.RequiresFile Then
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Upload Requirement"
                    btnAct.BackColor = Color.FromArgb(2, 132, 199)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(110, 32)
                    btnAct.Location = New Point(0, 0)

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Location = New Point(116, 0)
                    btnViewReq.Size = New Size(114, 32)

                    lblDash.Visible = False
                Else
                    If isGuidance Then
                        btnAct.Visible = True
                        btnAct.Enabled = True
                        btnAct.Text = "Update Information"
                        btnAct.BackColor = Color.FromArgb(2, 132, 199)
                        btnAct.ForeColor = Color.White
                        btnAct.Size = New Size(110, 32)
                        btnAct.Location = New Point(0, 0)

                        btnViewReq.Visible = True
                        btnViewReq.Text = "View Requirements"
                        btnViewReq.Location = New Point(116, 0)
                        btnViewReq.Size = New Size(114, 32)

                        lblDash.Visible = False
                    Else
                        btnAct.Visible = False

                        btnViewReq.Visible = True
                        btnViewReq.Text = "View Requirements"
                        btnViewReq.Location = New Point(0, 0)
                        btnViewReq.Size = New Size(130, 32)

                        lblDash.Visible = False
                    End If
                End If

            Case "rejected"
                If item.RequiresFile Then
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Upload Corrected"
                    btnAct.BackColor = Color.FromArgb(220, 38, 38)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(110, 32)
                    btnAct.Location = New Point(0, 0)

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Location = New Point(116, 0)
                    btnViewReq.Size = New Size(114, 32)

                    lblDash.Visible = False
                Else
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Request Re-evaluation"
                    btnAct.BackColor = Color.FromArgb(2, 132, 199)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(122, 32)
                    btnAct.Location = New Point(0, 0)

                    btnViewReq.Visible = True
                    btnViewReq.Text = If(isGuidance, "Update Information", "View Requirements")
                    btnViewReq.Location = New Point(126, 0)
                    btnViewReq.Size = New Size(106, 32)

                    lblDash.Visible = False
                End If

            Case "locked", "not applicable"
                btnAct.Visible = False
                btnViewReq.Visible = False
                lblDash.Visible = True
                lblDash.Text = "-"
                lblDash.TextAlign = ContentAlignment.MiddleCenter

            Case Else
                btnAct.Visible = False
                btnViewReq.Visible = True
                lblDash.Visible = False

        End Select

    End Sub

    ' ============================================================
    ' STATUS STYLING
    ' ============================================================
    Private Sub ApplyStatusStyle(
        lblStatus As Label,
        status As String
    )

        Select Case status.ToLowerInvariant()
            Case "cleared"
                lblStatus.BackColor = Color.FromArgb(220, 252, 231)
                lblStatus.ForeColor = Color.FromArgb(21, 128, 61)

            Case "under review"
                lblStatus.BackColor = Color.FromArgb(219, 234, 254)
                lblStatus.ForeColor = Color.FromArgb(30, 64, 175)

            Case "rejected"
                lblStatus.BackColor = Color.FromArgb(254, 226, 226)
                lblStatus.ForeColor = Color.FromArgb(185, 28, 28)

            Case "locked"
                lblStatus.BackColor = Color.FromArgb(241, 245, 249)
                lblStatus.ForeColor = Color.FromArgb(100, 116, 139)

            Case "not applicable"
                lblStatus.BackColor = Color.FromArgb(241, 245, 249)
                lblStatus.ForeColor = Color.FromArgb(100, 116, 139)

            Case Else ' Pending
                lblStatus.BackColor = Color.FromArgb(254, 243, 199)
                lblStatus.ForeColor = Color.FromArgb(180, 83, 9)
        End Select

    End Sub

    ' ============================================================
    ' PRIMARY ACTION BUTTON CLICK
    ' ============================================================
    Private Sub ClearanceActionButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnAction1.Click, btnAction2.Click, btnAction3.Click, btnAction4.Click,
              btnAction5.Click, btnAction6.Click, btnAction7.Click, btnAction8.Click, btnAction9.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceWorkflowHelper.ClearanceItemInfo) Then
            Return
        End If

        Dim item = DirectCast(button.Tag, ClearanceWorkflowHelper.ClearanceItemInfo)
        Dim isGuidance As Boolean = (item.SequenceOrder = 1 OrElse item.DepartmentName.ToLowerInvariant().Contains("guidance"))

        If item.EffectiveStatus.Equals("Locked", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This clearance step is currently locked. Complete the preceding applicable step to unlock it.", "Requirement Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If item.EffectiveStatus.Equals("Not Applicable", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This clearance step does not apply to your course or year level.", "Not Applicable", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' View Details (for Cleared or Under Review)
        If button.Text.Equals("View Details", StringComparison.OrdinalIgnoreCase) Then
            If isGuidance Then
                OpenGuidanceUpdateModal(item)
            Else
                If item.RequiresFile AndAlso Not String.IsNullOrWhiteSpace(item.SubmittedFilePath) Then
                    OpenSubmittedDocument(item.SubmittedFilePath)
                Else
                    OpenRequirementDetailsModal(item)
                End If
            End If
            Return
        End If

        ' Update Information (Guidance Pending / Rejected)
        If button.Text.Equals("Update Information", StringComparison.OrdinalIgnoreCase) Then
            OpenGuidanceUpdateModal(item)
            Return
        End If

        ' Request Re-evaluation (Rejected non-file)
        If button.Text.Equals("Request Re-evaluation", StringComparison.OrdinalIgnoreCase) Then
            RequestReevaluation(item)
            Return
        End If

        ' Upload Requirement / Upload Corrected
        If item.RequiresFile AndAlso item.CanSubmit Then
            Using uploadModal As New UploadClearanceModalForm()
                uploadModal.RecordID = item.RecordID
                uploadModal.DepartmentName = item.DepartmentName
                uploadModal.RequirementName = item.RequirementName

                If uploadModal.ShowDialog(Me) = DialogResult.OK Then
                    LoadClearanceData()
                End If
            End Using
        End If

    End Sub

    ' ============================================================
    ' SECONDARY VIEW REQUIREMENTS BUTTON CLICK
    ' ============================================================
    Private Sub ViewRequirementButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewReq1.Click, btnViewReq2.Click, btnViewReq3.Click, btnViewReq4.Click,
              btnViewReq5.Click, btnViewReq6.Click, btnViewReq7.Click, btnViewReq8.Click, btnViewReq9.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceWorkflowHelper.ClearanceItemInfo) Then
            Return
        End If

        Dim item = DirectCast(button.Tag, ClearanceWorkflowHelper.ClearanceItemInfo)

        If button.Text.Equals("Update Information", StringComparison.OrdinalIgnoreCase) Then
            OpenGuidanceUpdateModal(item)
            Return
        End If

        OpenRequirementDetailsModal(item)

    End Sub

    ' ============================================================
    ' OPEN REQUIREMENT MODAL
    ' ============================================================
    Private Sub OpenRequirementDetailsModal(item As ClearanceWorkflowHelper.ClearanceItemInfo)

        Using modal As New ViewRequirementModalForm()
            modal.DepartmentName = item.DepartmentName
            modal.RequirementName = item.RequirementName
            modal.SequenceOrder = item.SequenceOrder
            modal.EffectiveStatus = item.EffectiveStatus
            modal.InstructionsText = item.Instructions
            modal.RequiresFile = item.RequiresFile
            modal.RequirementLink = item.RequirementLink
            modal.IsGuidanceOffice = (item.SequenceOrder = 1 OrElse item.DepartmentName.ToLowerInvariant().Contains("guidance"))

            modal.ShowDialog(Me)
        End Using

        LoadClearanceData()

    End Sub

    ' ============================================================
    ' OPEN GUIDANCE UPDATE MODAL
    ' ============================================================
    Private Sub OpenGuidanceUpdateModal(item As ClearanceWorkflowHelper.ClearanceItemInfo)

        Using modal As New ViewRequirementModalForm()
            modal.DepartmentName = item.DepartmentName
            modal.RequirementName = item.RequirementName
            modal.SequenceOrder = item.SequenceOrder
            modal.EffectiveStatus = item.EffectiveStatus
            modal.InstructionsText = item.Instructions
            modal.RequiresFile = item.RequiresFile
            modal.RequirementLink = item.RequirementLink
            modal.IsGuidanceOffice = True

            modal.ShowDialog(Me)
        End Using

        LoadClearanceData()

    End Sub

    ' ============================================================
    ' REQUEST RE-EVALUATION
    ' ============================================================
    Private Sub RequestReevaluation(item As ClearanceWorkflowHelper.ClearanceItemInfo)

        Dim msg As String =
            "Have you completed the required evaluation and updated any necessary information for " & item.DepartmentName & "?" & Environment.NewLine & Environment.NewLine &
            "Click Yes to submit a request for re-evaluation to the office."

        Dim res As DialogResult = MessageBox.Show(msg, "Request Re-evaluation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res <> DialogResult.Yes Then Return

        Try
            ' 1. Update ClearanceRecords Status to 'Under Review'
            Dim updateSql As String =
                "UPDATE ClearanceRecords " &
                "SET Status = 'Under Review', " &
                "    SubmittedAt = NOW() " &
                "WHERE RecordID = @RecordID AND StudentID = @StudentID;"

            db.ExecuteNonQuery(updateSql, New Dictionary(Of String, Object) From {
                {"@RecordID", item.RecordID},
                {"@StudentID", AppSession.UserID}
            })

            ' 2. Log History
            Dim histSql As String =
                "INSERT INTO ClearanceHistory (RecordID, ActionType, OldStatus, NewStatus, Remarks, ActionAt, ActionBy) " &
                "VALUES (@RecordID, 'Re-evaluation Requested', 'Rejected', 'Under Review', 'Student requested re-evaluation after addressing remarks.', NOW(), @StudentID);"

            db.ExecuteNonQuery(histSql, New Dictionary(Of String, Object) From {
                {"@RecordID", item.RecordID},
                {"@StudentID", AppSession.UserID}
            })

            MessageBox.Show(
                "Your request for re-evaluation has been submitted to " & item.DepartmentName & "." & Environment.NewLine &
                "The clearing officer will review your request.",
                "Re-evaluation Requested",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadClearanceData()

        Catch ex As Exception
            MessageBox.Show("Unable to submit re-evaluation request: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' ============================================================
    ' OPEN SUBMITTED DOCUMENT
    ' ============================================================
    Private Sub OpenSubmittedDocument(filePath As String)

        If String.IsNullOrWhiteSpace(filePath) Then Return

        Dim fullPath As String = filePath
        If Not Path.IsPathRooted(fullPath) Then
            fullPath = Path.Combine(Application.StartupPath, filePath)
        End If

        If Not File.Exists(fullPath) Then
            MessageBox.Show("The submitted document could not be found at: " & Path.GetFileName(fullPath), "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Process.Start(New ProcessStartInfo(fullPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Unable to open the document: " & ex.Message, "Document Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' ============================================================
    ' NAVIGATION - MY CLEARANCE
    ' ============================================================
    Private Sub btnNavMyClearance_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavMyClearance.Click

        ShowMyClearanceView()

    End Sub

    ' ============================================================
    ' NAVIGATION - HISTORY
    ' ============================================================
    Private Sub btnNavHistory_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavHistory.Click

        ShowHistoryView()

    End Sub

    ' ============================================================
    ' NAVIGATION - PROFILE
    ' ============================================================
    Private Sub btnNavProfile_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnNavProfile.Click

        ' Open personal information update modal
        Dim guidanceItem = allClearanceItems.FirstOrDefault(Function(i) i.SequenceOrder = 1 OrElse i.DepartmentName.ToLowerInvariant().Contains("guidance"))

        If guidanceItem IsNot Nothing Then
            OpenGuidanceUpdateModal(guidanceItem)
        Else
            MessageBox.Show(
                "Student Profile:" & Environment.NewLine & Environment.NewLine &
                "Name: " & AppSession.FullName & Environment.NewLine &
                "Student No: " & AppSession.StudentNo & Environment.NewLine &
                "Course: " & AppSession.Course & Environment.NewLine &
                "Year Level: " & AppSession.YearLevel,
                "Student Profile",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        End If

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
            pnlViewHost.BackColor = Color.FromArgb(248, 250, 252)
            Me.Controls.Add(pnlViewHost)
        End If
    End Sub

    Public Sub ShowMyClearanceView()
        SetActiveNavButton(btnNavMyClearance)
        If pnlViewHost IsNot Nothing Then
            pnlViewHost.Visible = False
            pnlViewHost.Controls.Clear()
        End If
        pnlMain.Visible = True
        pnlMain.BringToFront()
        LoadClearanceData()
    End Sub

    Public Sub ShowHistoryView()
        SetActiveNavButton(btnNavHistory)
        Dim historyForm As New ClearanceHistoryForm()
        historyForm.StudentIDFilter = AppSession.UserID
        historyForm.StudentNameFilter = AppSession.FullName
        LoadChildFormView(historyForm)
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
        Dim navButtons As Button() = {btnNavMyClearance, btnNavHistory, btnNavProfile}

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

End Class
