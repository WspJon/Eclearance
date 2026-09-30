Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Diagnostics
Imports System.Linq

Public Class StudentClearanceForm

    Private ReadOnly db As New DatabaseHelper()

    Private allClearanceItems As New List(Of ClearanceWorkflowHelper.ClearanceItemInfo)()
    Private filteredClearanceItems As New List(Of ClearanceWorkflowHelper.ClearanceItemInfo)()


    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub StudentClearanceForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        SetupStudentInformation()
        SetupFilter()
        LoadClearanceData()

    End Sub


    ' ============================================================
    ' STUDENT INFORMATION
    ' ============================================================
    Private Sub SetupStudentInformation()

        lblUserName.Text = AppSession.FullName
        lblUserRole.Text = "Student"

        lblStudentCourseYear.Text =
            AppSession.Course &
            "  •  " &
            AppSession.YearLevel

        Dim initials As String = ""

        If Not String.IsNullOrWhiteSpace(AppSession.FullName) Then

            Dim names() As String =
                AppSession.FullName.Split(
                    " "c,
                    StringSplitOptions.RemoveEmptyEntries
                )

            If names.Length >= 2 Then

                initials =
                    names(0).Substring(0, 1).ToUpper() &
                    names(names.Length - 1).Substring(0, 1).ToUpper()

            ElseIf names.Length = 1 Then

                initials =
                    names(0).Substring(0, 1).ToUpper()

            End If

        End If

        lblUserAvatar.Text = initials

    End Sub


    ' ============================================================
    ' FILTER OPTIONS
    ' ============================================================
    Private Sub SetupFilter()

        cmbFilterOffices.Items.Clear()

        cmbFilterOffices.Items.Add("All offices")
        cmbFilterOffices.Items.Add("Pending")
        cmbFilterOffices.Items.Add("Under Review")
        cmbFilterOffices.Items.Add("Cleared")
        cmbFilterOffices.Items.Add("Rejected")
        cmbFilterOffices.Items.Add("Locked")
        cmbFilterOffices.Items.Add("Not Applicable")

        cmbFilterOffices.SelectedIndex = 0

    End Sub


    ' ============================================================
    ' LOAD ALL CLEARANCE DATA
    ' ============================================================
    Private Sub LoadClearanceData()

        Try

            Dim activeTermID As Integer =
                GetActiveTermID()

            If activeTermID = 0 Then

                lblTermBadge.Text = "No Active Term"
                ClearOfficeCards()

                lblProgressSub.Text = "No active clearance term"
                lblProgressPercent.Text = "0%"
                pbOverall.Value = 0

                lblAttentionTitle.Text = "No clearance term available"
                lblAttentionDesc.Text = "Please contact the administrator."

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

            ApplyFilter()
            UpdateProgress()

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
            lblTermBadge.Text = row("AcademicYear").ToString() & " • " & row("Semester").ToString()
        Else
            lblTermBadge.Text = "Current Term"
        End If

    End Sub


    ' ============================================================
    ' APPLY STATUS FILTER
    ' ============================================================
    Private Sub ApplyFilter()

        filteredClearanceItems.Clear()

        Dim selectedFilter As String = "All offices"

        If cmbFilterOffices.SelectedItem IsNot Nothing Then
            selectedFilter = cmbFilterOffices.SelectedItem.ToString()
        End If

        For Each item In allClearanceItems
            If selectedFilter = "All offices" OrElse
               item.EffectiveStatus.Equals(selectedFilter, StringComparison.OrdinalIgnoreCase) Then
                filteredClearanceItems.Add(item)
            End If
        Next

        DisplayOfficeCards()

    End Sub


    ' ============================================================
    ' DISPLAY OFFICE CARDS (NATURAL SCROLLING)
    ' ============================================================
    Private Sub DisplayOfficeCards()

        ClearOfficeCards()

        Dim totalCount As Integer = allClearanceItems.Count
        Dim filteredCount As Integer = filteredClearanceItems.Count

        If filteredCount = 0 Then
            lblShowingOffices.Text = "Showing 0 of " & totalCount.ToString() & " offices"
            Return
        End If

        For i As Integer = 0 To Math.Min(filteredCount - 1, 8)
            PopulateOfficeCard(i, filteredClearanceItems(i))
        Next

        lblShowingOffices.Text =
            "Showing " & filteredCount.ToString() & " of " & totalCount.ToString() & " offices (Sequential Clearance)"

    End Sub


    ' ============================================================
    ' HIDE/RESET OFFICE CARDS
    ' ============================================================
    Private Sub ClearOfficeCards()

        pnlOfficeCard1.Visible = False
        pnlOfficeCard2.Visible = False
        pnlOfficeCard3.Visible = False
        pnlOfficeCard4.Visible = False
        pnlOfficeCard5.Visible = False
        pnlOfficeCard6.Visible = False
        pnlOfficeCard7.Visible = False
        pnlOfficeCard8.Visible = False
        pnlOfficeCard9.Visible = False

    End Sub


    ' ============================================================
    ' POPULATE DESIGNER OFFICE CARD
    ' ============================================================
    Private Sub PopulateOfficeCard(
        cardIndex As Integer,
        item As ClearanceWorkflowHelper.ClearanceItemInfo
    )

        Dim cardPanel As Panel = Nothing
        Dim lblIcon As Label = Nothing
        Dim lblTitle As Label = Nothing
        Dim lblBadge As Label = Nothing
        Dim lblDesc As Label = Nothing
        Dim pnlFile As Panel = Nothing
        Dim lblFileIco As Label = Nothing
        Dim lblFileNm As Label = Nothing
        Dim lblFileDt As Label = Nothing
        Dim btnAct As Button = Nothing
        Dim btnRmv As Button = Nothing
        Dim btnViewReq As Button = Nothing

        Select Case cardIndex
            Case 0
                cardPanel = pnlOfficeCard1
                lblIcon = lblOfficeIcon1
                lblTitle = lblOfficeTitle1
                lblBadge = lblOfficeStatusBadge1
                lblDesc = lblOfficeDesc1
                pnlFile = pnlFileAttach1
                lblFileIco = lblFileIcon1
                lblFileNm = lblFileName1
                lblFileDt = lblFileDate1
                btnAct = btnAction1
                btnRmv = btnrmvsub1
                btnViewReq = btnViewReq1

            Case 1
                cardPanel = pnlOfficeCard2
                lblIcon = lblOfficeIcon2
                lblTitle = lblOfficeTitle2
                lblBadge = lblOfficeStatusBadge2
                lblDesc = lblOfficeDesc2
                pnlFile = pnlFileAttach2
                lblFileIco = lblFileIcon2
                lblFileNm = lblFileName2
                lblFileDt = lblFileDate2
                btnAct = btnAction2
                btnRmv = btnrmvsub2
                btnViewReq = btnViewReq2

            Case 2
                cardPanel = pnlOfficeCard3
                lblIcon = lblOfficeIcon3
                lblTitle = lblOfficeTitle3
                lblBadge = lblOfficeStatusBadge3
                lblDesc = lblOfficeDesc3
                pnlFile = pnlFileAttach3
                lblFileIco = lblFileIcon3
                lblFileNm = lblFileName3
                lblFileDt = lblFileDate3
                btnAct = btnAction3
                btnRmv = btnrmvsub3
                btnViewReq = btnViewReq3

            Case 3
                cardPanel = pnlOfficeCard4
                lblIcon = lblOfficeIcon4
                lblTitle = lblOfficeTitle4
                lblBadge = lblOfficeStatusBadge4
                lblDesc = lblOfficeDesc4
                pnlFile = pnlFileAttach4
                lblFileIco = lblFileIcon4
                lblFileNm = lblFileName4
                lblFileDt = lblFileDate4
                btnAct = btnAction4
                btnRmv = btnrmvsub4
                btnViewReq = btnViewReq4

            Case 4
                cardPanel = pnlOfficeCard5
                lblIcon = lblOfficeIcon5
                lblTitle = lblOfficeTitle5
                lblBadge = lblOfficeStatusBadge5
                lblDesc = lblOfficeDesc5
                pnlFile = pnlFileAttach5
                lblFileIco = lblFileIcon5
                lblFileNm = lblFileName5
                lblFileDt = lblFileDate5
                btnAct = btnAction5
                btnRmv = btnrmvsub5
                btnViewReq = btnViewReq5

            Case 5
                cardPanel = pnlOfficeCard6
                lblIcon = lblOfficeIcon6
                lblTitle = lblOfficeTitle6
                lblBadge = lblOfficeStatusBadge6
                lblDesc = lblOfficeDesc6
                pnlFile = pnlFileAttach6
                lblFileIco = lblFileIcon6
                lblFileNm = lblFileName6
                lblFileDt = lblFileDate6
                btnAct = btnAction6
                btnRmv = btnrmvsub6
                btnViewReq = btnViewReq6

            Case 6
                cardPanel = pnlOfficeCard7
                lblIcon = lblOfficeIcon7
                lblTitle = lblOfficeTitle7
                lblBadge = lblOfficeStatusBadge7
                lblDesc = lblOfficeDesc7
                pnlFile = pnlFileAttach7
                lblFileIco = lblFileIcon7
                lblFileNm = lblFileName7
                lblFileDt = lblFileDate7
                btnAct = btnAction7
                btnRmv = btnrmvsub7
                btnViewReq = btnViewReq7

            Case 7
                cardPanel = pnlOfficeCard8
                lblIcon = lblOfficeIcon8
                lblTitle = lblOfficeTitle8
                lblBadge = lblOfficeStatusBadge8
                lblDesc = lblOfficeDesc8
                pnlFile = pnlFileAttach8
                lblFileIco = lblFileIcon8
                lblFileNm = lblFileName8
                lblFileDt = lblFileDate8
                btnAct = btnAction8
                btnRmv = btnrmvsub8
                btnViewReq = btnViewReq8

            Case 8
                cardPanel = pnlOfficeCard9
                lblIcon = lblOfficeIcon9
                lblTitle = lblOfficeTitle9
                lblBadge = lblOfficeStatusBadge9
                lblDesc = lblOfficeDesc9
                pnlFile = pnlFileAttach9
                lblFileIco = lblFileIcon9
                lblFileNm = lblFileName9
                lblFileDt = lblFileDate9
                btnAct = btnAction9
                btnRmv = btnrmvsub9
                btnViewReq = btnViewReq9

            Case Else
                Return
        End Select

        cardPanel.Visible = True
        lblTitle.Text = item.SequenceOrder.ToString() & ". " & item.DepartmentName
        lblDesc.Text = item.RequirementName & If(Not String.IsNullOrWhiteSpace(item.Instructions), " — " & item.Instructions, "")
        lblBadge.Text = item.EffectiveStatus
        ApplyStatusStyle(lblBadge, item.EffectiveStatus)

        Dim hasFile As Boolean = (Not String.IsNullOrWhiteSpace(item.SubmittedFileName) OrElse item.FileCount > 0)

        If hasFile Then
            pnlFile.Visible = True
            Dim displayFileName As String = item.SubmittedFileName
            If item.FileCount > 1 Then
                displayFileName &= " (+" & (item.FileCount - 1).ToString() & " more)"
            End If
            lblFileNm.Text = displayFileName

            Dim submittedAtText As String = "Submitted file"
            If item.SubmittedAt IsNot Nothing AndAlso Not IsDBNull(item.SubmittedAt) Then
                Dim submittedDate As DateTime = Convert.ToDateTime(item.SubmittedAt)
                submittedAtText = "Submitted " & submittedDate.ToString("MMM dd, yyyy hh:mm tt")
            End If
            lblFileDt.Text = submittedAtText
        Else
            pnlFile.Visible = True
            lblFileNm.Text = "No document uploaded"
            lblFileDt.Text = If(item.RequiresFile, "Upload required", "No file required")
        End If

        btnAct.Tag = item
        ConfigureActionButton(btnAct, item, hasFile)

        If btnRmv IsNot Nothing Then
            btnRmv.Tag = item
            ConfigureRemoveButton(btnRmv, item, hasFile)
        End If

        If btnViewReq IsNot Nothing Then
            btnViewReq.Tag = item
        End If

    End Sub


    ' ============================================================
    ' STATUS COLORS
    ' ============================================================
    Private Sub ApplyStatusStyle(
        lblStatus As Label,
        status As String
    )

        Select Case status.ToLowerInvariant()
            Case "cleared"
                lblStatus.BackColor = Color.FromArgb(220, 252, 231)
                lblStatus.ForeColor = Color.FromArgb(22, 101, 52)

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
                lblStatus.BackColor = Color.FromArgb(243, 244, 246)
                lblStatus.ForeColor = Color.FromArgb(107, 114, 128)

            Case Else
                lblStatus.BackColor = Color.FromArgb(254, 243, 199)
                lblStatus.ForeColor = Color.FromArgb(146, 64, 14)
        End Select

    End Sub


    ' ============================================================
    ' ACTION BUTTON APPEARANCE
    ' ============================================================
    Private Sub ConfigureActionButton(
        button As Button,
        item As ClearanceWorkflowHelper.ClearanceItemInfo,
        hasFile As Boolean
    )

        Select Case item.EffectiveStatus.ToLowerInvariant()

            Case "locked"
                button.Text = "🔒 Locked"
                button.Enabled = False
                button.BackColor = Color.FromArgb(226, 232, 240)
                button.ForeColor = Color.FromArgb(100, 116, 139)

            Case "not applicable"
                button.Text = "Not Applicable"
                button.Enabled = False
                button.BackColor = Color.FromArgb(243, 244, 246)
                button.ForeColor = Color.FromArgb(148, 163, 184)

            Case "cleared"
                If hasFile Then
                    button.Text = "Cleared - View document"
                    button.Enabled = True
                    button.BackColor = Color.FromArgb(22, 163, 74)
                    button.ForeColor = Color.White
                Else
                    button.Text = "Requirement cleared"
                    button.Enabled = False
                    button.BackColor = Color.FromArgb(220, 252, 231)
                    button.ForeColor = Color.FromArgb(22, 101, 52)
                End If

            Case "under review"
                If hasFile Then
                    button.Text = "View submitted document"
                    button.Enabled = True
                    button.BackColor = Color.FromArgb(59, 130, 246)
                    button.ForeColor = Color.White
                Else
                    button.Text = "Under Review"
                    button.Enabled = False
                    button.BackColor = Color.FromArgb(219, 234, 254)
                    button.ForeColor = Color.FromArgb(30, 64, 175)
                End If

            Case "rejected"
                button.Text = "Upload corrected document"
                button.Enabled = True
                button.BackColor = Color.FromArgb(220, 38, 38)
                button.ForeColor = Color.White

            Case Else ' "pending"
                If Not item.RequiresFile Then
                    button.Text = "Waiting for office clearance"
                    button.Enabled = False
                    button.BackColor = Color.FromArgb(226, 232, 240)
                    button.ForeColor = Color.FromArgb(100, 116, 139)
                Else
                    button.Text = "Upload requirement"
                    button.Enabled = True
                    button.BackColor = Color.FromArgb(11, 99, 229)
                    button.ForeColor = Color.White
                End If

        End Select

    End Sub


    ' ============================================================
    ' REMOVE BUTTON APPEARANCE
    ' ============================================================
    Private Sub ConfigureRemoveButton(
        button As Button,
        item As ClearanceWorkflowHelper.ClearanceItemInfo,
        hasFile As Boolean
    )

        If button Is Nothing Then Return

        If Not item.RequiresFile Then
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "No file required"
            Return
        End If

        If item.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "Cleared - Locked"
            Return
        End If

        If item.EffectiveStatus.Equals("Locked", StringComparison.OrdinalIgnoreCase) Then
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "🔒 Locked"
            Return
        End If

        If item.EffectiveStatus.Equals("Not Applicable", StringComparison.OrdinalIgnoreCase) Then
            button.Enabled = False
            button.BackColor = Color.FromArgb(243, 244, 246)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "Not Applicable"
            Return
        End If

        If hasFile Then
            button.Enabled = True
            button.BackColor = Color.FromArgb(220, 38, 38)
            button.ForeColor = Color.White
            button.Text = "Remove submitted document"
        Else
            button.Enabled = False
            button.BackColor = Color.FromArgb(226, 232, 240)
            button.ForeColor = Color.FromArgb(148, 163, 184)
            button.Text = "No document uploaded"
        End If

    End Sub


    ' ============================================================
    ' CARD VIEW REQUIREMENTS BUTTON CLICK
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

        ' Refresh data in case personal information was updated
        LoadClearanceData()

    End Sub


    ' ============================================================
    ' CARD ACTION BUTTON CLICK
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

        If item.EffectiveStatus.Equals("Locked", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This clearance step is currently locked. Complete the preceding applicable step to unlock it.", "Requirement Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If item.EffectiveStatus.Equals("Not Applicable", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This clearance step does not apply to your course or year level.", "Not Applicable", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' If Under Review or Cleared with file, open file viewer
        If item.EffectiveStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase) OrElse
           item.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
            If Not String.IsNullOrWhiteSpace(item.SubmittedFilePath) Then
                OpenSubmittedDocument(item.SubmittedFilePath)
            End If
            Return
        End If

        ' Upload requirement (Pending or Rejected)
        If item.CanSubmit Then
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
    ' CARD REMOVE SUBMITTED DOCUMENT CLICK
    ' ============================================================
    Private Sub RemoveSubmittedDocumentButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnrmvsub1.Click, btnrmvsub2.Click, btnrmvsub3.Click, btnrmvsub4.Click,
              btnrmvsub5.Click, btnrmvsub6.Click, btnrmvsub7.Click, btnrmvsub8.Click, btnrmvsub9.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceWorkflowHelper.ClearanceItemInfo) Then
            Return
        End If

        Dim item = DirectCast(button.Tag, ClearanceWorkflowHelper.ClearanceItemInfo)

        If item.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("A cleared clearance requirement cannot be removed.", "Cannot Remove", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(item.SubmittedFilePath) AndAlso item.FileCount = 0 Then
            MessageBox.Show("There is no submitted document to remove.", "No Document", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show(
            "Are you sure you want to remove your submitted document(s) for " & item.DepartmentName & "?" & Environment.NewLine & Environment.NewLine &
            "Your submitted files will be removed and your clearance status will be reset to Pending.",
            "Remove Submitted Documents",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirmResult <> DialogResult.Yes Then Return

        ExecuteRemoveSubmittedDocuments(item.RecordID, item.SubmittedFilePath, item.EffectiveStatus)

    End Sub


    Private Sub ExecuteRemoveSubmittedDocuments(
        recordID As Integer,
        filePath As String,
        oldStatus As String
    )
        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' 1. Delete rows from ClearanceRecordFiles
                        Dim deleteFilesSql As String =
                            "DELETE FROM ClearanceRecordFiles WHERE RecordID = @RecordID;"

                        Using delFilesCmd As New MySqlCommand(deleteFilesSql, conn, transaction)
                            delFilesCmd.Parameters.AddWithValue("@RecordID", recordID)
                            delFilesCmd.ExecuteNonQuery()
                        End Using

                        ' 2. Update ClearanceRecords
                        Dim updateQuery As String =
                            "UPDATE ClearanceRecords " &
                            "SET SubmittedFilePath = NULL, " &
                            "SubmittedFileName = NULL, " &
                            "SubmittedAt = NULL, " &
                            "Status = 'Pending', " &
                            "Remarks = NULL, " &
                            "ReviewedBy = NULL, " &
                            "ReviewedAt = NULL " &
                            "WHERE RecordID = @RecordID AND StudentID = @StudentID;"

                        Using updateCmd As New MySqlCommand(updateQuery, conn, transaction)
                            updateCmd.Parameters.AddWithValue("@RecordID", recordID)
                            updateCmd.Parameters.AddWithValue("@StudentID", AppSession.UserID)
                            updateCmd.ExecuteNonQuery()
                        End Using

                        ' 3. Add History row
                        Dim historyQuery As String =
                            "INSERT INTO ClearanceHistory " &
                            "(RecordID, ActionBy, ActionType, OldStatus, NewStatus, Remarks) " &
                            "VALUES (@RecordID, @ActionBy, 'Document Removed', @OldStatus, 'Pending', 'Student removed submitted document');"

                        Using histCmd As New MySqlCommand(historyQuery, conn, transaction)
                            histCmd.Parameters.AddWithValue("@RecordID", recordID)
                            histCmd.Parameters.AddWithValue("@ActionBy", AppSession.UserID)
                            histCmd.Parameters.AddWithValue("@OldStatus", oldStatus)
                            histCmd.ExecuteNonQuery()
                        End Using

                        transaction.Commit()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            ' Delete physical file from disk if single path exists
            If Not String.IsNullOrWhiteSpace(filePath) Then
                Try
                    Dim fullPath As String = filePath
                    If Not Path.IsPathRooted(fullPath) Then
                        fullPath = Path.Combine(Application.StartupPath, filePath)
                    End If
                    If File.Exists(fullPath) Then
                        File.Delete(fullPath)
                    End If
                Catch
                End Try
            End If

            MessageBox.Show(
                "Your submitted documents have been removed successfully. Clearance status is now Pending.",
                "Documents Removed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            LoadClearanceData()

        Catch ex As Exception
            MessageBox.Show("Failed to remove submitted documents: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ' ============================================================
    ' OPEN SUBMITTED DOCUMENT IN DEFAULT VIEWER
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
    ' UPDATE PROGRESS (BASED ON APPLICABLE REQUIREMENTS ONLY)
    ' ============================================================
    Private Sub UpdateProgress()

        Dim applicableItems = allClearanceItems.Where(Function(i) i.IsApplicable).ToList()
        Dim totalApplicable As Integer = applicableItems.Count

        If totalApplicable = 0 Then
            pbOverall.Value = 0
            lblProgressPercent.Text = "0%"
            lblProgressSub.Text = "No applicable clearance requirements"
            lblAttentionTitle.Text = "No clearance requirements"
            lblAttentionDesc.Text = "No requirements are available for your current course/term."
            Return
        End If

        Dim clearedCount As Integer = 0
        For Each itm In applicableItems
            If itm.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                clearedCount += 1
            End If
        Next

        Dim percent As Integer =
            CInt(Math.Round(clearedCount * 100.0 / totalApplicable))

        percent = Math.Max(0, Math.Min(100, percent))

        pbOverall.Value = percent
        lblProgressPercent.Text = percent.ToString() & "%"
        lblProgressSub.Text = clearedCount.ToString() & " of " & totalApplicable.ToString() & " applicable offices cleared"

        If clearedCount = totalApplicable Then
            lblAttentionTitle.Text = "🎉 Clearance Fully Cleared!"
            lblAttentionDesc.Text = "Congratulations! All your applicable clearance requirements have been cleared."
        Else
            Dim currentStep =
                allClearanceItems.FirstOrDefault(Function(i) i.IsApplicable AndAlso Not i.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase))

            If currentStep IsNot Nothing Then
                lblAttentionTitle.Text = "Current Step: " & currentStep.DepartmentName & " (" & currentStep.EffectiveStatus & ")"
                If currentStep.EffectiveStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                    lblAttentionDesc.Text = "Your submission was rejected by the office. Please review the remarks and upload a corrected document."
                ElseIf currentStep.EffectiveStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                    lblAttentionDesc.Text = "Your submission is currently under review by " & currentStep.DepartmentName & "."
                Else
                    lblAttentionDesc.Text = "Complete this step to unlock the subsequent clearance requirements."
                End If
            Else
                lblAttentionTitle.Text = "Clearance in Progress"
                lblAttentionDesc.Text = "Complete pending clearance steps."
            End If
        End If

    End Sub


    ' ============================================================
    ' FILTER CHANGED
    ' ============================================================
    Private Sub cmbFilterOffices_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbFilterOffices.SelectedIndexChanged

        If Me.IsHandleCreated Then
            ApplyFilter()
        End If

    End Sub


    ' ============================================================
    ' REFRESH
    ' ============================================================
    Private Sub btnRefresh_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnRefresh.Click

        LoadClearanceData()

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
    ' SPA VIEW SWITCHING (SINGLE PAGE ARCHITECTURE)
    ' ============================================================
    Private pnlViewHost As Panel = Nothing

    Private Sub EnsureViewHost()
        If pnlViewHost Is Nothing Then
            pnlViewHost = New Panel()
            pnlViewHost.Dock = DockStyle.Fill
            pnlViewHost.Visible = False
            pnlViewHost.BackColor = Color.FromArgb(244, 246, 250)
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
        cmbFilterOffices.SelectedIndex = 0
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
        Dim navButtons As Button() = {btnNavMyClearance, btnNavHistory}

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
