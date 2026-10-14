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

        ApplySchoolLogo(picSchoolLogo)
        SetupStudentInformation()
        ApplyTableLayout()
        LoadClearanceData()

    End Sub

    Private Sub StudentClearanceForm_Resize(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Resize

        ApplyStepperLayout()
        If pnlMain IsNot Nothing AndAlso pnlClearanceTable IsNot Nothing Then
            pnlClearanceTable.Height = Math.Max(200, pnlMain.ClientSize.Height - pnlClearanceTable.Top - 20)
        End If
        ApplyTableLayout()

    End Sub

    ' ============================================================
    ' STUDENT INFORMATION
    ' ============================================================
    Private Sub SetupStudentInformation()

        lblStudentName.Text = AppSession.FullName
        Dim detailsText As String = AppSession.StudentNo & " | " & AppSession.Course & " - " & AppSession.YearLevel
        If Not String.IsNullOrWhiteSpace(AppSession.StudentType) Then
            detailsText &= " (" & AppSession.StudentType & ")"
        End If
        lblStudentDetails.Text = detailsText

    End Sub

    ' ============================================================
    ' LOAD ALL CLEARANCE DATA
    ' ============================================================
    Public Sub LoadClearanceData()

        UpdateCompletionBanner(Nothing)
        Try

            ' Refresh student metadata from Students
            Try
                Dim studentInfoQuery As String =
                    "SELECT COALESCE(s.StudentType, 'Regular') AS StudentType, " &
                    "       COALESCE(s.Course, '') AS Course, " &
                    "       COALESCE(s.YearLevel, '') AS YearLevel, " &
                    "       COALESCE(s.StudentNo, '') AS StudentNo " &
                    "FROM Students s " &
                    "WHERE s.UserID = @UserID LIMIT 1;"
                Dim studentInfoDt As DataTable = db.ExecuteQuery(studentInfoQuery, New Dictionary(Of String, Object) From {{"@UserID", AppSession.UserID}})
                If studentInfoDt.Rows.Count > 0 Then
                    Dim sRow = studentInfoDt.Rows(0)
                    AppSession.StudentType = sRow("StudentType").ToString()
                    AppSession.Course = sRow("Course").ToString()
                    AppSession.YearLevel = sRow("YearLevel").ToString()
                    AppSession.StudentNo = sRow("StudentNo").ToString()
                    SetupStudentInformation()
                End If
            Catch
            End Try

            Dim activeTermID As Integer = GetActiveTermID()

            If activeTermID = 0 Then
                lblTermText.Text = "No Active Term"
                ClearRows()
                Return
            End If

            LoadCurrentTerm(activeTermID)

            allClearanceItems = ClearanceWorkflowHelper.GetStudentClearanceItems(AppSession.UserID, activeTermID, AppSession.Course, AppSession.YearLevel, db)

            ' Ensure CTHM Stock Room is completely hidden when not applicable to the student's program
            If allClearanceItems IsNot Nothing Then
                allClearanceItems = allClearanceItems.Where(Function(i) Not ((i.DepartmentID = 8 OrElse i.RequirementName.IndexOf("CTHM Stock Room", StringComparison.OrdinalIgnoreCase) >= 0) AndAlso Not i.IsApplicable)).ToList()
                ' Hide NSTP when the existing enrollment/year applicability rules exclude it.
                allClearanceItems = allClearanceItems.Where(Function(i) Not (i.RequiresNSTP AndAlso Not i.IsApplicable)).ToList()
            End If

            UpdateProgressDisplay(allClearanceItems)
            UpdateCompletionBanner(allClearanceItems)

            ClearanceWorkflowHelper.UnlockNextStepsInDatabase(AppSession.UserID, activeTermID, AppSession.Course, AppSession.YearLevel, db)

            DisplayClearanceTable()

            ' Notify student of any rejected requirements once per session
            Static _hasShownNotification As Boolean = False
            If Not _hasShownNotification AndAlso allClearanceItems IsNot Nothing Then
                Dim rejectedItems = allClearanceItems.Where(Function(i) i.EffectiveStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase)).ToList()
                If rejectedItems.Count > 0 Then
                    _hasShownNotification = True
                    Dim msg = "You have " & rejectedItems.Count & " requirement(s) that require your attention:" & vbCrLf & vbCrLf
                    For Each item In rejectedItems
                        msg &= "• " & item.DepartmentName & vbCrLf
                    Next
                    msg &= vbCrLf & "Please review the remarks and resubmit."
                    MessageBox.Show(msg, "Action Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If

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

    Private Sub UpdateCompletionBanner(items As List(Of ClearanceWorkflowHelper.ClearanceItemInfo))
        Dim applicable = If(items, New List(Of ClearanceWorkflowHelper.ClearanceItemInfo)()).Where(Function(i) i.IsApplicable).ToList()
        Dim completed As Boolean = applicable.Count > 0 AndAlso applicable.All(Function(i) String.Equals(i.EffectiveStatus, "Cleared", StringComparison.OrdinalIgnoreCase))
        pnlCompletionBanner.Visible = completed

        If completed Then
            pnlCompletionBanner.Location = New Point(28, 300)
            pnlClearanceTable.Location = New Point(28, pnlCompletionBanner.Bottom + 10)
        Else
            pnlClearanceTable.Location = New Point(28, 300)
        End If
        pnlClearanceTable.Height = Math.Max(200, pnlMain.ClientSize.Height - pnlClearanceTable.Top - 20)
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
    ' DISPLAY CURRENT & PREVIOUS TERM INFORMATION
    ' ============================================================
    Private Sub LoadCurrentTerm(termID As Integer)

        Dim currentAY As String = "2026-2027"
        Dim currentSem As String = "1st Semester"

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
            currentAY = row("AcademicYear").ToString()
            currentSem = row("Semester").ToString()
            lblTermText.Text = "Academic Year: " & currentAY & "  |  Semester: " & currentSem
        Else
            lblTermText.Text = "Current Term"
        End If

        lblCurrentTermValue.Text = currentAY & " | " & currentSem

        ' Previous Semester information determined chronologically
        Dim prevTerm = ClearanceWorkflowHelper.GetPreviousAcademicTerm(termID, db)
        lblPrevTermValue.Text = prevTerm.DisplayText

        ' Previous Semester Enrollment Status (Enrolled, Not Enrolled, No Record)
        Dim prevEnrollStatus = ClearanceWorkflowHelper.GetStudentPreviousEnrollment(AppSession.UserID, prevTerm.TermID, db)
        lblPrevEnrollBadge.Text = prevEnrollStatus
        Select Case prevEnrollStatus.ToLowerInvariant()
            Case "enrolled"
                lblPrevEnrollBadge.BackColor = Color.FromArgb(220, 252, 231)
                lblPrevEnrollBadge.ForeColor = Color.FromArgb(21, 128, 61)
            Case "not enrolled"
                lblPrevEnrollBadge.BackColor = Color.FromArgb(254, 243, 199)
                lblPrevEnrollBadge.ForeColor = Color.FromArgb(146, 64, 14)
            Case Else ' "no record"
                lblPrevEnrollBadge.BackColor = Color.FromArgb(241, 245, 249)
                lblPrevEnrollBadge.ForeColor = Color.FromArgb(71, 85, 105)
        End Select

    End Sub

    ' ============================================================
    ' PROGRESS DISPLAY & STEPPER BINDING
    ' ============================================================
    Private Sub UpdateProgressDisplay(items As List(Of ClearanceWorkflowHelper.ClearanceItemInfo))
        Dim progress = ClearanceWorkflowHelper.ComputeClearanceProgress(items)
        lblProgressCount.Text = progress.ProgressSummary
        lblNextStep.Text = "Next step: " & progress.NextStepText

        ' Clearance Status Badge
        lblClearanceStatusBadge.Text = progress.OverallStatus
        Select Case progress.OverallStatus.ToLowerInvariant()
            Case "cleared"
                lblClearanceStatusBadge.BackColor = Color.FromArgb(220, 252, 231)
                lblClearanceStatusBadge.ForeColor = Color.FromArgb(21, 128, 61)
            Case "needs attention"
                lblClearanceStatusBadge.BackColor = Color.FromArgb(254, 226, 226)
                lblClearanceStatusBadge.ForeColor = Color.FromArgb(185, 28, 28)
            Case Else ' "in progress"
                lblClearanceStatusBadge.BackColor = Color.FromArgb(239, 246, 255)
                lblClearanceStatusBadge.ForeColor = Color.FromArgb(29, 78, 216)
        End Select

        ' Progress bar fill width
        Dim fillWidth As Integer = 0
        If pnlProgressBarBg.Width > 0 AndAlso progress.Percentage > 0 Then
            fillWidth = CInt(Math.Round((pnlProgressBarBg.Width * progress.Percentage) / 100.0))
        End If
        pnlProgressBarFill.Width = Math.Min(pnlProgressBarBg.Width, fillWidth)

        ' Stepper nodes
        UpdateStepperDisplay(items)
    End Sub

    Private Sub UpdateStepperDisplay(items As List(Of ClearanceWorkflowHelper.ClearanceItemInfo))
        If items Is Nothing Then Return

        ' 1. Guidance
        Dim itemGuidance = items.FirstOrDefault(Function(i) i.DepartmentID = 6 OrElse (i.DepartmentName IsNot Nothing AndAlso i.DepartmentName.ToLowerInvariant().Contains("guidance")))
        SetStepperNode(1, lblStepCircle1, lblStepStatus1, pnlStepLine1, itemGuidance)

        ' 2. Library
        Dim itemLibrary = items.FirstOrDefault(Function(i) i.DepartmentID = 3 OrElse (i.DepartmentName IsNot Nothing AndAlso i.DepartmentName.ToLowerInvariant().Contains("library")))
        SetStepperNode(2, lblStepCircle2, lblStepStatus2, pnlStepLine2, itemLibrary)

        ' 3. OSA (Office of Student Affairs)
        Dim itemOSA = items.FirstOrDefault(Function(i) i.DepartmentID = 4 OrElse (i.DepartmentName IsNot Nothing AndAlso (i.DepartmentName.ToLowerInvariant().Contains("student affairs") OrElse i.DepartmentName.Equals("OSA", StringComparison.OrdinalIgnoreCase))))
        SetStepperNode(3, lblStepCircle3, lblStepStatus3, pnlStepLine3, itemOSA)

        ' 4. Clinic
        Dim itemClinic = items.FirstOrDefault(Function(i) i.DepartmentID = 9 OrElse (i.DepartmentName IsNot Nothing AndAlso i.DepartmentName.ToLowerInvariant().Contains("clinic")))
        SetStepperNode(4, lblStepCircle4, lblStepStatus4, pnlStepLine4, itemClinic)

        ' 5. College Dean (CCS, CTHM, CBA, COE)
        Dim itemDean = items.FirstOrDefault(Function(i) i.SequenceOrder = 6 OrElse (i.DepartmentName IsNot Nothing AndAlso (i.DepartmentName.ToLowerInvariant().Contains("dean") OrElse i.DepartmentName.Equals("CCS", StringComparison.OrdinalIgnoreCase) OrElse i.DepartmentName.Equals("CTHM", StringComparison.OrdinalIgnoreCase) OrElse i.DepartmentName.Equals("CBA", StringComparison.OrdinalIgnoreCase) OrElse i.DepartmentName.Equals("COE", StringComparison.OrdinalIgnoreCase))))
        If itemDean IsNot Nothing Then
            Dim dName = itemDean.DepartmentName.Replace("College Dean", "").Replace("Dean", "").Trim()
            If Not String.IsNullOrWhiteSpace(dName) Then
                lblStepName5.Text = dName
            Else
                lblStepName5.Text = "Dean"
            End If
        End If
        SetStepperNode(5, lblStepCircle5, lblStepStatus5, pnlStepLine5, itemDean)

        ' 6. Finance
        Dim itemFinance = items.FirstOrDefault(Function(i) i.DepartmentID = 1 OrElse (i.DepartmentName IsNot Nothing AndAlso i.DepartmentName.ToLowerInvariant().Contains("finance")))
        SetStepperNode(6, lblStepCircle6, lblStepStatus6, pnlStepLine6, itemFinance)

        ' 7. Registrar
        Dim itemRegistrar = items.FirstOrDefault(Function(i) i.DepartmentID = 2 OrElse (i.DepartmentName IsNot Nothing AndAlso i.DepartmentName.ToLowerInvariant().Contains("registrar")))
        SetStepperNode(7, lblStepCircle7, lblStepStatus7, pnlStepLine7, itemRegistrar)

        ' 8. OAA
        Dim itemOAA = items.FirstOrDefault(Function(i) i.DepartmentID = 5 OrElse (i.DepartmentName IsNot Nothing AndAlso i.DepartmentName.ToLowerInvariant().Contains("oaa")))
        SetStepperNode(8, lblStepCircle8, lblStepStatus8, Nothing, itemOAA)

        ApplyStepperLayout()
    End Sub

    Private Sub SetStepperNode(
        stepNum As Integer,
        circle As Label,
        statusLbl As Label,
        line As Panel,
        item As ClearanceWorkflowHelper.ClearanceItemInfo
    )
        Dim status = If(item IsNot Nothing, item.EffectiveStatus, "Pending")
        Select Case status.ToLowerInvariant()
            Case "cleared"
                circle.BackColor = Color.FromArgb(22, 163, 74)
                circle.ForeColor = Color.White
                circle.Text = "✓"
                statusLbl.Text = "Cleared"
                statusLbl.ForeColor = Color.FromArgb(22, 163, 74)
                If line IsNot Nothing Then line.BackColor = Color.FromArgb(22, 163, 74)

            Case "under review"
                circle.BackColor = Color.FromArgb(37, 99, 235)
                circle.ForeColor = Color.White
                circle.Text = "⏳"
                statusLbl.Text = "In Progress"
                statusLbl.ForeColor = Color.FromArgb(37, 99, 235)
                If line IsNot Nothing Then line.BackColor = Color.FromArgb(226, 232, 240)

            Case "rejected"
                circle.BackColor = Color.FromArgb(239, 68, 68)
                circle.ForeColor = Color.White
                circle.Text = "!"
                statusLbl.Text = "Attention"
                statusLbl.ForeColor = Color.FromArgb(220, 38, 38)
                If line IsNot Nothing Then line.BackColor = Color.FromArgb(226, 232, 240)

            Case "locked"
                circle.BackColor = Color.FromArgb(241, 245, 249)
                circle.ForeColor = Color.FromArgb(148, 163, 184)
                circle.Text = "🔒"
                statusLbl.Text = "Locked"
                statusLbl.ForeColor = Color.FromArgb(148, 163, 184)
                If line IsNot Nothing Then line.BackColor = Color.FromArgb(226, 232, 240)

            Case Else ' "pending"
                circle.BackColor = Color.FromArgb(241, 245, 249)
                circle.ForeColor = Color.FromArgb(71, 85, 105)
                circle.Text = stepNum.ToString()
                statusLbl.Text = "Pending"
                statusLbl.ForeColor = Color.FromArgb(100, 116, 139)
                If line IsNot Nothing Then line.BackColor = Color.FromArgb(226, 232, 240)
        End Select
    End Sub

    Private Sub ApplyStepperLayout()
        Try
            If pnlStepper Is Nothing Then Return
            Dim totalStepperWidth As Integer = pnlStepper.ClientSize.Width
            If totalStepperWidth < 800 Then totalStepperWidth = 800

            Dim colWidth As Integer = totalStepperWidth \ 8
            Dim stepPanels = {pnlStep1, pnlStep2, pnlStep3, pnlStep4, pnlStep5, pnlStep6, pnlStep7, pnlStep8}
            Dim stepCircles = {lblStepCircle1, lblStepCircle2, lblStepCircle3, lblStepCircle4, lblStepCircle5, lblStepCircle6, lblStepCircle7, lblStepCircle8}
            Dim stepNames = {lblStepName1, lblStepName2, lblStepName3, lblStepName4, lblStepName5, lblStepName6, lblStepName7, lblStepName8}
            Dim stepStatuses = {lblStepStatus1, lblStepStatus2, lblStepStatus3, lblStepStatus4, lblStepStatus5, lblStepStatus6, lblStepStatus7, lblStepStatus8}
            Dim stepLines = {pnlStepLine1, pnlStepLine2, pnlStepLine3, pnlStepLine4, pnlStepLine5, pnlStepLine6, pnlStepLine7}

            For idx As Integer = 0 To 7
                Dim sPanel = stepPanels(idx)
                sPanel.Location = New Point(idx * colWidth, 0)
                sPanel.Size = New Size(colWidth, pnlStepper.ClientSize.Height)

                Dim circle = stepCircles(idx)
                Dim circleX = (colWidth - circle.Width) \ 2
                circle.Location = New Point(circleX, 2)

                Dim nameLbl = stepNames(idx)
                nameLbl.Location = New Point(0, 30)
                nameLbl.Size = New Size(colWidth, 16)

                Dim statLbl = stepStatuses(idx)
                statLbl.Location = New Point(0, 46)
                statLbl.Size = New Size(colWidth, 16)

                If idx < 7 Then
                    Dim line = stepLines(idx)
                    line.Location = New Point(circleX + circle.Width, 14)
                    line.Size = New Size(colWidth - circle.Width, 2)
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    ' ============================================================
    ' DISPLAY CLEARANCE TABLE
    ' ============================================================
    Private Sub DisplayClearanceTable()

        ClearRows()

        Dim count As Integer = allClearanceItems.Count

        For i As Integer = 0 To Math.Min(count - 1, 9)
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
        pnlRow10.Visible = False

    End Sub

    Private Sub pnlClearanceTable_Resize(sender As Object, e As EventArgs) Handles pnlClearanceTable.Resize
        ApplyTableLayout()
    End Sub

    Private Function GetCurrentAcademicYear() As String
        Try
            Dim dt = db.ExecuteQuery("SELECT AcademicYear FROM AcademicTerms WHERE IsActive = 1 LIMIT 1;")
            If dt.Rows.Count > 0 Then Return dt.Rows(0)("AcademicYear").ToString()
        Catch
        End Try
        Return "2026-2027"
    End Function

    Private Function HasCurrentYearGuidanceProfile() As Boolean
        Try
            Dim activeAY As String = GetCurrentAcademicYear()
            Dim query As String = "SELECT GuidanceProfileID FROM GuidanceStudentProfiles WHERE StudentID = @StudentID AND AcademicYear = @AcademicYear LIMIT 1;"
            Dim dt = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@StudentID", AppSession.UserID},
                {"@AcademicYear", activeAY}
            })
            Return dt.Rows.Count > 0
        Catch
            Return False
        End Try
    End Function

    Private Sub ApplyTableLayout()
        Try
            Dim totalWidth As Integer = pnlClearanceTable.ClientSize.Width
            If totalWidth < 900 Then totalWidth = 900

            Dim numX As Integer = 12
            Dim numWidth As Integer = 32

            Dim deptX As Integer = 48
            Dim deptWidth As Integer = 138

            Dim actionWidth As Integer = 330
            Dim actionX As Integer = totalWidth - actionWidth - 12

            Dim statusWidth As Integer = 96
            Dim statusX As Integer = actionX - statusWidth - 12

            Dim reqX As Integer = 192
            Dim reqWidth As Integer = statusX - reqX - 12
            If reqWidth < 280 Then reqWidth = 280

            ' Apply to header
            pnlTableHeader.Width = totalWidth
            lblColNum.Location = New Point(numX, 11)
            lblColNum.Size = New Size(numWidth, 20)
            lblColNum.TextAlign = ContentAlignment.MiddleCenter

            lblColDept.Location = New Point(deptX, 11)
            lblColDept.Size = New Size(deptWidth, 20)
            lblColDept.TextAlign = ContentAlignment.MiddleLeft

            lblColReq.Location = New Point(reqX, 11)
            lblColReq.Size = New Size(reqWidth, 20)
            lblColReq.TextAlign = ContentAlignment.MiddleLeft

            lblColStatus.Location = New Point(statusX, 11)
            lblColStatus.Size = New Size(statusWidth, 20)
            lblColStatus.TextAlign = ContentAlignment.MiddleCenter

            lblColAction.Location = New Point(actionX, 11)
            lblColAction.Size = New Size(actionWidth, 20)
            lblColAction.TextAlign = ContentAlignment.MiddleLeft

            ' Row configuration
            Dim rowHeight As Integer = 72
            Dim rowPanels = {pnlRow1, pnlRow2, pnlRow3, pnlRow4, pnlRow5, pnlRow6, pnlRow7, pnlRow8, pnlRow9, pnlRow10}
            Dim numLabels = {lblNum1, lblNum2, lblNum3, lblNum4, lblNum5, lblNum6, lblNum7, lblNum8, lblNum9, lblNum10}
            Dim deptLabels = {lblDept1, lblDept2, lblDept3, lblDept4, lblDept5, lblDept6, lblDept7, lblDept8, lblDept9, lblDept10}
            Dim reqLabels = {lblReq1, lblReq2, lblReq3, lblReq4, lblReq5, lblReq6, lblReq7, lblReq8, lblReq9, lblReq10}
            Dim statusLabels = {lblStatus1, lblStatus2, lblStatus3, lblStatus4, lblStatus5, lblStatus6, lblStatus7, lblStatus8, lblStatus9, lblStatus10}
            Dim actionPanels = {pnlAction1, pnlAction2, pnlAction3, pnlAction4, pnlAction5, pnlAction6, pnlAction7, pnlAction8, pnlAction9, pnlAction10}
            Dim dashLabels = {lblDash1, lblDash2, lblDash3, lblDash4, lblDash5, lblDash6, lblDash7, lblDash8, lblDash9, lblDash10}
            Dim dividers = {pnlDivider1, pnlDivider2, pnlDivider3, pnlDivider4, pnlDivider5, pnlDivider6, pnlDivider7, pnlDivider8, pnlDivider9, pnlDivider10}

            For i As Integer = 0 To 9
                Dim rPanel = rowPanels(i)
                Dim curY As Integer = 42 + (i * rowHeight)
                rPanel.Location = New Point(0, curY)
                rPanel.Size = New Size(totalWidth, rowHeight)

                Dim numLbl = numLabels(i)
                numLbl.Location = New Point(numX + (numWidth - 28) \ 2, (rowHeight - 28) \ 2)
                numLbl.Size = New Size(28, 28)

                Dim deptLbl = deptLabels(i)
                deptLbl.Location = New Point(deptX, 8)
                deptLbl.Size = New Size(deptWidth, rowHeight - 16)

                Dim reqLbl = reqLabels(i)
                reqLbl.AutoEllipsis = False
                reqLbl.Location = New Point(reqX, 8)
                reqLbl.Size = New Size(reqWidth, rowHeight - 16)

                Dim statusLbl = statusLabels(i)
                statusLbl.Location = New Point(statusX, (rowHeight - 28) \ 2)
                statusLbl.Size = New Size(statusWidth, 28)

                Dim actPanel = actionPanels(i)
                actPanel.Location = New Point(actionX, (rowHeight - 32) \ 2)
                actPanel.Size = New Size(actionWidth, 32)

                Dim dashLbl = dashLabels(i)
                dashLbl.Location = New Point(0, 0)
                dashLbl.Size = New Size(actionWidth, 32)
                dashLbl.TextAlign = ContentAlignment.MiddleCenter

                Dim div = dividers(i)
                div.Location = New Point(0, rowHeight - 1)
                div.Size = New Size(totalWidth, 1)
            Next

            ApplyStepperLayout()
        Catch ex As Exception
        End Try
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
        Dim btnReeval As Button = Nothing
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
                btnReeval = btnReeval1
                btnViewReq = btnViewReq1
                lblDash = lblDash1
            Case 1
                rowPanel = pnlRow2
                lblNum = lblNum2
                lblDept = lblDept2
                lblReq = lblReq2
                lblStatus = lblStatus2
                btnAct = btnAction2
                btnReeval = btnReeval2
                btnViewReq = btnViewReq2
                lblDash = lblDash2
            Case 2
                rowPanel = pnlRow3
                lblNum = lblNum3
                lblDept = lblDept3
                lblReq = lblReq3
                lblStatus = lblStatus3
                btnAct = btnAction3
                btnReeval = btnReeval3
                btnViewReq = btnViewReq3
                lblDash = lblDash3
            Case 3
                rowPanel = pnlRow4
                lblNum = lblNum4
                lblDept = lblDept4
                lblReq = lblReq4
                lblStatus = lblStatus4
                btnAct = btnAction4
                btnReeval = btnReeval4
                btnViewReq = btnViewReq4
                lblDash = lblDash4
            Case 4
                rowPanel = pnlRow5
                lblNum = lblNum5
                lblDept = lblDept5
                lblReq = lblReq5
                lblStatus = lblStatus5
                btnAct = btnAction5
                btnReeval = btnReeval5
                btnViewReq = btnViewReq5
                lblDash = lblDash5
            Case 5
                rowPanel = pnlRow6
                lblNum = lblNum6
                lblDept = lblDept6
                lblReq = lblReq6
                lblStatus = lblStatus6
                btnAct = btnAction6
                btnReeval = btnReeval6
                btnViewReq = btnViewReq6
                lblDash = lblDash6
            Case 6
                rowPanel = pnlRow7
                lblNum = lblNum7
                lblDept = lblDept7
                lblReq = lblReq7
                lblStatus = lblStatus7
                btnAct = btnAction7
                btnReeval = btnReeval7
                btnViewReq = btnViewReq7
                lblDash = lblDash7
            Case 7
                rowPanel = pnlRow8
                lblNum = lblNum8
                lblDept = lblDept8
                lblReq = lblReq8
                lblStatus = lblStatus8
                btnAct = btnAction8
                btnReeval = btnReeval8
                btnViewReq = btnViewReq8
                lblDash = lblDash8
            Case 8
                rowPanel = pnlRow9
                lblNum = lblNum9
                lblDept = lblDept9
                lblReq = lblReq9
                lblStatus = lblStatus9
                btnAct = btnAction9
                btnReeval = btnReeval9
                btnViewReq = btnViewReq9
                lblDash = lblDash9
            Case 9
                rowPanel = pnlRow10
                lblNum = lblNum10
                lblDept = lblDept10
                lblReq = lblReq10
                lblStatus = lblStatus10
                btnAct = btnAction10
                btnReeval = btnReeval10
                btnViewReq = btnViewReq10
                lblDash = lblDash10
            Case Else
                Return
        End Select

        rowPanel.Visible = True
        lblNum.Text = (rowIndex + 1).ToString()
        Dim deptName As String = item.DepartmentName
        If String.Equals(deptName, "OSA", StringComparison.OrdinalIgnoreCase) Then
            deptName = "Office of Student Affairs"
        End If
        lblDept.Text = deptName
        lblReq.Text = If(String.IsNullOrWhiteSpace(item.Instructions), item.RequirementName, item.RequirementName & " — " & item.Instructions)
        If item.IsStudentAffairs Then lblReq.Text = item.RequirementName & " — Approval is subject to department head verification of any outstanding concerns."
        lblStatus.Text = item.DisplayStatus
        ApplyStatusStyle(lblStatus, item.DisplayStatus)

        btnAct.Tag = item
        btnReeval.Tag = item
        btnViewReq.Tag = item

        Dim isGuidance As Boolean = (item.SequenceOrder = 1 OrElse item.DepartmentName.ToLowerInvariant().Contains("guidance"))
        Dim isClinic As Boolean = (item.SequenceOrder = 3 OrElse item.DepartmentName.ToLowerInvariant().Contains("clinic"))
        Dim hasFile As Boolean = (Not String.IsNullOrWhiteSpace(item.SubmittedFileName) OrElse item.FileCount > 0)

        Select Case item.DisplayStatus.ToLowerInvariant()

            Case "cleared"
                btnAct.Visible = True
                btnAct.Enabled = True
                btnAct.Text = "View Details"
                btnAct.BackColor = Color.FromArgb(226, 232, 240)
                btnAct.ForeColor = Color.FromArgb(30, 41, 59)
                btnAct.Size = New Size(110, 32)
                btnAct.Location = New Point(0, 0)
                btnReeval.Visible = False
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
                btnReeval.Visible = True
                btnReeval.Enabled = True
                btnReeval.Text = "Cancel Submission"
                btnReeval.Location = New Point(116, 0)
                btnReeval.Size = New Size(130, 32)
                btnReeval.BackColor = Color.FromArgb(226, 232, 240)
                btnReeval.ForeColor = Color.FromArgb(30, 41, 59)
                btnViewReq.Visible = False
                lblDash.Visible = False

            Case "not submitted", "pending"
                btnReeval.Visible = False
                lblDash.Visible = False

                If item.RequiresFile Then
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Submit Requirement"
                    btnAct.BackColor = Color.FromArgb(2, 132, 199)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(125, 32)
                    btnAct.Location = New Point(0, 0)

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Location = New Point(132, 0)
                    btnViewReq.Size = New Size(125, 32)
                Else
                    If isGuidance Then
                        btnAct.Visible = True
                        btnAct.Enabled = True
                        Dim hasProfile As Boolean = HasCurrentYearGuidanceProfile()
                        If hasProfile Then
                            btnAct.Text = "Review / Update Information"
                            btnAct.Size = New Size(168, 32)
                        Else
                            btnAct.Text = "Complete Information"
                            btnAct.Size = New Size(140, 32)
                        End If
                        btnAct.BackColor = Color.FromArgb(2, 132, 199)
                        btnAct.ForeColor = Color.White
                        btnAct.Location = New Point(0, 0)

                        btnViewReq.Visible = True
                        btnViewReq.Text = "View Requirements"
                        btnViewReq.Location = New Point(btnAct.Location.X + btnAct.Size.Width + 6, 0)
                        btnViewReq.Size = New Size(125, 32)
                    ElseIf isClinic Then
                        btnAct.Visible = True
                        btnAct.Enabled = True
                        btnAct.Text = "Complete Health Assessment"
                        btnAct.BackColor = Color.FromArgb(2, 132, 199)
                        btnAct.ForeColor = Color.White
                        btnAct.Size = New Size(185, 32)
                        btnAct.Location = New Point(0, 0)

                        btnViewReq.Visible = True
                        btnViewReq.Text = "View Requirements"
                        btnViewReq.Location = New Point(btnAct.Location.X + btnAct.Size.Width + 6, 0)
                        btnViewReq.Size = New Size(125, 32)
                    ElseIf item.IsOfficeRequest Then
                        btnAct.Visible = True
                        btnAct.Enabled = item.CanSubmit
                        btnAct.Text = "Submit for Review"
                        btnAct.BackColor = Color.FromArgb(2, 132, 199)
                        btnAct.ForeColor = Color.White
                        btnAct.Size = New Size(125, 32)
                        btnAct.Location = New Point(0, 0)
                        btnViewReq.Visible = True
                        btnViewReq.Text = "View Requirements"
                        btnViewReq.Location = New Point(132, 0)
                        btnViewReq.Size = New Size(125, 32)
                    Else
                        btnAct.Visible = False

                        btnViewReq.Visible = True
                        btnViewReq.Text = "View Requirements"
                        btnViewReq.Location = New Point(0, 0)
                        btnViewReq.Size = New Size(130, 32)
                    End If
                End If

            Case "needs completion", "rejected"
                lblDash.Visible = False

                If isGuidance Then
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    Dim hasProfile As Boolean = HasCurrentYearGuidanceProfile()
                    If hasProfile Then
                        btnAct.Text = "Review / Update Information"
                        btnAct.Size = New Size(168, 32)
                    Else
                        btnAct.Text = "Complete Information"
                        btnAct.Size = New Size(140, 32)
                    End If
                    btnAct.BackColor = Color.FromArgb(2, 132, 199)
                    btnAct.ForeColor = Color.White
                    btnAct.Location = New Point(0, 0)

                    btnReeval.Visible = False

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Size = New Size(125, 32)
                    btnViewReq.Location = New Point(btnAct.Location.X + btnAct.Size.Width + 6, 0)

                ElseIf isClinic Then
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Update Assessment"
                    btnAct.BackColor = Color.FromArgb(234, 88, 12)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(150, 32)
                    btnAct.Location = New Point(0, 0)

                    btnReeval.Visible = False

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Location = New Point(btnAct.Location.X + btnAct.Size.Width + 6, 0)
                    btnViewReq.Size = New Size(125, 32)

                ElseIf item.RequiresFile Then
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Resubmit Requirement"
                    btnAct.BackColor = Color.FromArgb(220, 38, 38)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(130, 32)
                    btnAct.Location = New Point(0, 0)

                    btnReeval.Visible = False

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Location = New Point(136, 0)
                    btnViewReq.Size = New Size(120, 32)

                Else
                    ' Non-guidance non-file
                    btnAct.Visible = True
                    btnAct.Enabled = True
                    btnAct.Text = "Request Re-evaluation"
                    btnAct.BackColor = Color.FromArgb(2, 132, 199)
                    btnAct.ForeColor = Color.White
                    btnAct.Size = New Size(125, 32)
                    btnAct.Location = New Point(0, 0)

                    btnReeval.Visible = False

                    btnViewReq.Visible = True
                    btnViewReq.Text = "View Requirements"
                    btnViewReq.Location = New Point(132, 0)
                    btnViewReq.Size = New Size(125, 32)
                End If

            Case "locked", "not applicable"
                btnAct.Visible = False
                btnReeval.Visible = False
                btnViewReq.Visible = False
                lblDash.Visible = True
                lblDash.Text = "-"
                lblDash.TextAlign = ContentAlignment.MiddleCenter

            Case Else
                btnAct.Visible = False
                btnReeval.Visible = False
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

            Case "needs completion"
                lblStatus.BackColor = Color.FromArgb(254, 243, 199)
                lblStatus.ForeColor = Color.FromArgb(180, 83, 9)

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
              btnAction5.Click, btnAction6.Click, btnAction7.Click, btnAction8.Click, btnAction9.Click, btnAction10.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceWorkflowHelper.ClearanceItemInfo) Then
            Return
        End If

        Dim item = DirectCast(button.Tag, ClearanceWorkflowHelper.ClearanceItemInfo)
        Dim isGuidance As Boolean = (item.SequenceOrder = 1 OrElse item.DepartmentName.ToLowerInvariant().Contains("guidance"))
        Dim isClinic As Boolean = (item.SequenceOrder = 3 OrElse item.DepartmentName.ToLowerInvariant().Contains("clinic"))

        If item.EffectiveStatus.Equals("Locked", StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("This clearance step is currently locked. Complete the preceding required clearance steps to unlock it.", "Requirement Locked", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            ElseIf isClinic Then
                OpenClinicAssessmentModal(item)
            Else
                If item.RequiresFile AndAlso Not String.IsNullOrWhiteSpace(item.SubmittedFilePath) Then
                    OpenSubmittedDocument(item.SubmittedFilePath)
                Else
                    OpenRequirementDetailsModal(item)
                End If
            End If
            Return
        End If

        ' Complete / Update Health Assessment for Clinic
        If isClinic AndAlso (button.Text.Equals("Complete Health Assessment", StringComparison.OrdinalIgnoreCase) OrElse
                             button.Text.Equals("Update Assessment", StringComparison.OrdinalIgnoreCase) OrElse
                             button.Text.Equals("Complete Assessment", StringComparison.OrdinalIgnoreCase) OrElse
                             button.Text.Equals("View Assessment", StringComparison.OrdinalIgnoreCase)) Then
            OpenClinicAssessmentModal(item)
            Return
        End If

        ' Review / Complete / Update Information for Guidance
        If isGuidance AndAlso (button.Text.Equals("Review / Update Information", StringComparison.OrdinalIgnoreCase) OrElse
                              button.Text.Equals("Complete Information", StringComparison.OrdinalIgnoreCase) OrElse
                              button.Text.Equals("Update Information", StringComparison.OrdinalIgnoreCase) OrElse
                              button.Text.Equals("Complete Requirement", StringComparison.OrdinalIgnoreCase) OrElse
                              button.Text.Equals("Complete Required Action", StringComparison.OrdinalIgnoreCase)) Then
            OpenGuidanceUpdateModal(item)
            Return
        End If

        If item.IsOfficeRequest Then
            RequestOfficeVerification(item)
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
    ' RE-EVALUATION BUTTON CLICK
    ' ============================================================
    Private Sub ReevaluationButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnReeval1.Click, btnReeval2.Click, btnReeval3.Click, btnReeval4.Click,
              btnReeval5.Click, btnReeval6.Click, btnReeval7.Click, btnReeval8.Click, btnReeval9.Click, btnReeval10.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceWorkflowHelper.ClearanceItemInfo) Then
            Return
        End If

        Dim item = DirectCast(button.Tag, ClearanceWorkflowHelper.ClearanceItemInfo)
        If button.Text.Equals("Cancel Submission", StringComparison.OrdinalIgnoreCase) Then
            If MessageBox.Show("Cancel this submission? You can edit and submit it again.", "Cancel Submission", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                ClearanceWorkflowHelper.CancelStudentSubmission(item.RecordID, db)
                LoadClearanceData()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
            Return
        End If
        RequestReevaluation(item)

    End Sub


    ' ============================================================
    ' SECONDARY VIEW REQUIREMENTS BUTTON CLICK
    ' ============================================================
    Private Sub ViewRequirementButton_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnViewReq1.Click, btnViewReq2.Click, btnViewReq3.Click, btnViewReq4.Click,
              btnViewReq5.Click, btnViewReq6.Click, btnViewReq7.Click, btnViewReq8.Click, btnViewReq9.Click, btnViewReq10.Click

        Dim button = DirectCast(sender, Button)
        If button.Tag Is Nothing OrElse Not (TypeOf button.Tag Is ClearanceWorkflowHelper.ClearanceItemInfo) Then
            Return
        End If

        Dim item = DirectCast(button.Tag, ClearanceWorkflowHelper.ClearanceItemInfo)
        Dim isClinic As Boolean = (item.SequenceOrder = 3 OrElse item.DepartmentName.ToLowerInvariant().Contains("clinic"))

        If isClinic AndAlso (button.Text.Equals("Update Assessment", StringComparison.OrdinalIgnoreCase) OrElse
                             button.Text.Equals("Complete Health Assessment", StringComparison.OrdinalIgnoreCase) OrElse
                             button.Text.Equals("Complete Assessment", StringComparison.OrdinalIgnoreCase)) Then
            OpenClinicAssessmentModal(item)
            Return
        End If

        If button.Text.Equals("Update Information", StringComparison.OrdinalIgnoreCase) OrElse
           button.Text.Equals("Review / Update Information", StringComparison.OrdinalIgnoreCase) OrElse
           button.Text.Equals("Complete Information", StringComparison.OrdinalIgnoreCase) Then
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
            modal.SequenceOrder = item.DisplayOrder
            modal.EffectiveStatus = item.EffectiveStatus
            modal.InstructionsText = item.Instructions
            modal.StaffRemarks = item.Remarks
            modal.RequiresFile = item.RequiresFile
            modal.RequirementLink = item.RequirementLink
            modal.IsGuidanceOffice = (item.SequenceOrder = 1 OrElse item.DepartmentName.ToLowerInvariant().Contains("guidance"))
            modal.AcademicYear = GetCurrentAcademicYear()
            modal.TermID = GetActiveTermID()

            modal.ShowDialog(Me)
        End Using

        LoadClearanceData()

    End Sub

    ' ============================================================
    ' OPEN CLINIC HEALTH ASSESSMENT MODAL
    ' ============================================================
    Private Sub OpenClinicAssessmentModal(item As ClearanceWorkflowHelper.ClearanceItemInfo)

        Using modal As New ClinicHealthAssessmentForm()
            modal.RecordID = item.RecordID
            modal.StudentID = AppSession.UserID
            modal.TermID = GetActiveTermID()
            modal.AcademicYear = GetCurrentAcademicYear()
            modal.IsReadOnly = item.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) OrElse
                               item.EffectiveStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase)
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
            modal.SequenceOrder = item.DisplayOrder
            modal.EffectiveStatus = item.EffectiveStatus
            modal.InstructionsText = item.Instructions
            modal.StaffRemarks = item.Remarks
            modal.RequiresFile = item.RequiresFile
            modal.RequirementLink = item.RequirementLink
            modal.IsGuidanceOffice = True
            modal.AcademicYear = GetCurrentAcademicYear()
            modal.TermID = GetActiveTermID()

            modal.ShowDialog(Me)
        End Using

        LoadClearanceData()

    End Sub

    ' ============================================================
    ' REQUEST RE-EVALUATION
    ' ============================================================
    Private Sub RequestOfficeVerification(item As ClearanceWorkflowHelper.ClearanceItemInfo)
        Dim message = If(item.DBStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase),
            "Have you completed the instructions in the department head remarks? Request verification of your compliance?",
            If(item.IsFinance, "Request Finance clearance? The Department Head will verify your payment status.", If(item.IsStudentAffairs, "Request clearance verification from the Office of Student Affairs? No office visit is required unless the Department Head identifies an unresolved concern.", "Request clearance from " & item.DepartmentName & "?")))
        If MessageBox.Show(message, item.DepartmentName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
        Try
            ClearanceWorkflowHelper.SubmitOfficeVerificationRequest(item.RecordID, db)
            LoadClearanceData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Request Not Submitted", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RequestReevaluation(item As ClearanceWorkflowHelper.ClearanceItemInfo)
        If item.IsOfficeRequest Then
            RequestOfficeVerification(item)
            Return
        End If

        Dim msg As String =
            "Have you addressed the remarks and completed the requirements for " & item.DepartmentName & "?" & Environment.NewLine & Environment.NewLine &
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

        ShowProfileView()

    End Sub

    Public Sub ShowProfileView()
        SetActiveNavButton(btnNavProfile)
        Dim profileForm As New StudentProfileForm()
        LoadChildFormView(profileForm)
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

    Private Sub lblReq1_Click(sender As Object, e As EventArgs) Handles lblReq1.Click

    End Sub
End Class
