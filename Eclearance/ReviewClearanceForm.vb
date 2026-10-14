Imports System.Data
Imports System.Diagnostics
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class ReviewClearanceForm

    Public Property TargetRecordID As Integer = 0

    Private ReadOnly db As New DatabaseHelper()
    Private ReadOnly approvalResources As New System.ComponentModel.ComponentResourceManager(GetType(ReviewClearanceForm))
    Private currentDepartmentName As String = "Assigned Office"
    Private currentFilePath As String = ""
    Private currentStatus As String = "Pending"
    Private _isStudentAffairs As Boolean = False
    Private _isFinance As Boolean = False
    Private _isOfficeVerification As Boolean = False
    Private _isGuidanceOffice As Boolean = False
    Private _requiresFile As Boolean = True
    Private _hasGuidanceInfo As Boolean = False
    Private _hasSubmittedDocument As Boolean = False
    Private _guidanceUpdateRequired As Boolean = False
    Private _studentID As Integer = 0
    Private _termID As Integer = 0
    Private _studentCourse As String = ""
    Private _studentYearLevel As String = ""
    Private _isEditingGuidance As Boolean = False
    Private _guidanceProfileID As Integer = 0
    Private _isClinicOffice As Boolean = False
    Private _hasClinicAssessment As Boolean = False
    Private _clinicStudentID As Integer = 0
    Private _clinicAttachedFilePath As String = ""
    Private _clinicAcademicYear As String = ""

    Public Sub PrepareForDisplay(host As Form)
        Dim workArea As Rectangle = Screen.FromControl(host).WorkingArea
        Dim available As Rectangle = Rectangle.Inflate(workArea, -12, -12)
        Dim windowSize As New Size(Math.Min(1140, available.Width), Math.Min(748, available.Height))
        ' Keep the window on its owner's monitor; the Designer viewport handles smaller screens.
        MinimumSize = New Size(Math.Min(640, windowSize.Width), Math.Min(480, windowSize.Height))
        StartPosition = FormStartPosition.Manual
        Size = windowSize
        Dim center As Point = New Point(host.Left + host.Width \ 2, host.Top + host.Height \ 2)
        Location = New Point(
            Math.Max(available.Left, Math.Min(center.X - Width \ 2, available.Right - Width)),
            Math.Max(available.Top, Math.Min(center.Y - Height \ 2, available.Bottom - Height)))
    End Sub

    Private Sub ReviewClearanceForm_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Initial focus must not scroll the title out of view on a narrow display.
        ActiveControl = btnClose
        pnlContentViewport.AutoScrollPosition = Point.Empty
        BeginInvoke(New Action(Sub()
                                   If IsDisposed Then Return
                                   ActiveControl = btnClose
                                   pnlContentViewport.AutoScrollPosition = Point.Empty
                               End Sub))
    End Sub

    Private Sub ReviewClearanceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not AppSession.Role.Equals("Staff", StringComparison.OrdinalIgnoreCase) OrElse Not AppSession.DepartmentID.HasValue Then
            MessageBox.Show(
                "Access Denied: You do not have an assigned office/department.",
                "Security Authorization Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
            Return
        End If

        InitializeStaffInfo()
        If TargetRecordID > 0 Then
            LoadSubmissionDetails()
            LoadTimeline()
        Else
            MessageBox.Show("No clearance submission specified.", "Invalid Record", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Private Sub InitializeStaffInfo()
        lblStaffName.Text = If(String.IsNullOrWhiteSpace(AppSession.FullName), "Department Head", AppSession.FullName)
        lblDateTimeBadge.Text = "📅 " & DateTime.Now.ToString("dddd, MMM dd, yyyy")

        If AppSession.DepartmentID.HasValue Then
            Try
                Dim dtDept As DataTable = db.ExecuteQuery(
                    "SELECT DepartmentName FROM Departments WHERE DepartmentID = @DeptID LIMIT 1;",
                    New Dictionary(Of String, Object) From {{"@DeptID", AppSession.DepartmentID.Value}}
                )
                If dtDept.Rows.Count > 0 Then
                    currentDepartmentName = dtDept.Rows(0)("DepartmentName").ToString()
                End If
            Catch ex As Exception
                ' Keep fallback
            End Try
        End If

        lblOfficeName.Text = currentDepartmentName
    End Sub

    Private Sub LoadSubmissionDetails()
        Try
            If Not AppSession.DepartmentID.HasValue OrElse Not ClearanceWorkflowHelper.HasStaffDepartmentAccess(AppSession.DepartmentID.Value, db) Then
                Throw New UnauthorizedAccessException("Your staff assignment is not authorized to review this request.")
            End If
            Dim query As String =
                "SELECT " &
                "  cr.RecordID, " &
                "  cr.StudentID, " &
                "  cr.TermID, " &
                "  t.AcademicYear, " &
                "  cr.Status, " &
                "  cr.Remarks, " &
                "  cr.SubmittedFilePath, " &
                "  cr.SubmittedFileName, " &
                "  cr.SubmittedAt, " &
                "  COALESCE(s.StudentNo, '') AS StudentNo, " &
                "  u.FullName AS StudentName, " &
                "  COALESCE(s.Course, '') AS Course, " &
                "  COALESCE(s.YearLevel, '') AS YearLevel, " &
                "  COALESCE(s.StudentType, 'Regular') AS StudentType, " &
                "  d.DepartmentID, " &
                "  d.DepartmentName, " &
                "  r.RequirementName, " &
                "  r.RequiresFile " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN Departments d ON r.DepartmentID = d.DepartmentID " &
                "INNER JOIN Users u ON cr.StudentID = u.UserID " &
                "LEFT JOIN Students s ON s.UserID = u.UserID " &
                "LEFT JOIN AcademicTerms t ON cr.TermID = t.TermID " &
                "WHERE cr.RecordID = @RecordID AND r.DepartmentID = @DeptID LIMIT 1;"

            Dim dt As DataTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@RecordID", TargetRecordID},
                {"@DeptID", AppSession.DepartmentID.Value}
            })
            If dt.Rows.Count = 0 Then
                MessageBox.Show(
                    "Access Denied: This submission record does not exist or does not belong to your assigned office.",
                    "Unauthorized Record Access",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Return
            End If

            Dim row = dt.Rows(0)
            _studentID = Convert.ToInt32(row("StudentID"))
            _termID = Convert.ToInt32(row("TermID"))
            _studentCourse = If(IsDBNull(row("Course")), "", row("Course").ToString())
            _studentYearLevel = If(IsDBNull(row("YearLevel")), "", row("YearLevel").ToString())

            lblStudentNoVal.Text = row("StudentNo").ToString()
            lblStudentNameVal.Text = row("StudentName").ToString()
            lblCourseVal.Text = If(IsDBNull(row("Course")) OrElse String.IsNullOrWhiteSpace(row("Course").ToString()), "N/A", row("Course").ToString())
            Dim yearValStr As String = If(IsDBNull(row("YearLevel")) OrElse String.IsNullOrWhiteSpace(row("YearLevel").ToString()), "N/A", row("YearLevel").ToString())
            Dim studentTypeValStr As String = If(IsDBNull(row("StudentType")) OrElse String.IsNullOrWhiteSpace(row("StudentType").ToString()), "", row("StudentType").ToString())
            lblYearVal.Text = If(Not String.IsNullOrWhiteSpace(studentTypeValStr), yearValStr & " (" & studentTypeValStr & ")", yearValStr)
            lblOfficeVal.Text = row("DepartmentName").ToString()
            lblReqVal.Text = row("RequirementName").ToString()

            If Not IsDBNull(row("SubmittedAt")) Then
                Dim subDate As DateTime = Convert.ToDateTime(row("SubmittedAt"))
                lblDateVal.Text = subDate.ToString("MMM dd, yyyy hh:mm tt")
            Else
                lblDateVal.Text = "Not yet submitted"
            End If

            currentStatus = row("Status").ToString()
            lblStatusBadge.Text = currentStatus

            If Not IsDBNull(row("Remarks")) Then
                txtRemarks.Text = row("Remarks").ToString()
                lblCharCount.Text = txtRemarks.Text.Length.ToString() & " / 500"
            End If

            Dim deptID As Integer = Convert.ToInt32(row("DepartmentID"))
            Dim deptName As String = row("DepartmentName").ToString()
            Dim requiresFile As Boolean = Convert.ToBoolean(row("RequiresFile"))
            Dim isGuidanceOffice As Boolean = (deptID = 6 OrElse deptName.ToLowerInvariant().Contains("guidance"))
            Dim isClinicOffice As Boolean = (deptID = 9 OrElse deptName.ToLowerInvariant().Contains("clinic"))

            _isStudentAffairs = deptName.Equals("Office of Student Affairs", StringComparison.OrdinalIgnoreCase)
            _isFinance = deptName.Equals("Finance Office", StringComparison.OrdinalIgnoreCase)
            _isOfficeVerification = _isStudentAffairs OrElse _isFinance
            pnlStudentAffairs.Visible = False
            pnlFinanceVerification.Visible = False
            pnlSequentialReview.Visible = False
            chkFinanceVerified.Checked = False
            chkStudentAffairsVerified.Checked = False
            _isGuidanceOffice = isGuidanceOffice
            _isClinicOffice = isClinicOffice
            _requiresFile = requiresFile AndAlso Not isClinicOffice
            _hasClinicAssessment = False
            _clinicStudentID = 0
            _clinicAttachedFilePath = ""
            pnlClinicInfo.Visible = False

            If isGuidanceOffice Then
                Dim studentID As Integer = Convert.ToInt32(row("StudentID"))
                Dim academicYear As String = If(IsDBNull(row("AcademicYear")), "", row("AcademicYear").ToString())
                If String.IsNullOrWhiteSpace(academicYear) Then
                    Try
                        Dim dtTerm = db.ExecuteQuery("SELECT AcademicYear FROM AcademicTerms WHERE IsActive = 1 LIMIT 1;")
                        If dtTerm.Rows.Count > 0 Then academicYear = dtTerm.Rows(0)("AcademicYear").ToString()
                    Catch
                    End Try
                    If String.IsNullOrWhiteSpace(academicYear) Then academicYear = "2026-2027"
                End If

                ' Check GuidanceStudentProfiles for current student and academicYear
                Dim gProfileQuery As String =
                    "SELECT * FROM GuidanceStudentProfiles WHERE StudentID = @StudentID AND AcademicYear = @AcademicYear LIMIT 1;"
                Dim dtGProfile As DataTable = db.ExecuteQuery(gProfileQuery, New Dictionary(Of String, Object) From {
                    {"@StudentID", studentID},
                    {"@AcademicYear", academicYear}
                })

                _hasGuidanceInfo = False

                ' Guidance non-file mode: Show Guidance panel, hide document preview
                pnlDocumentCard.Visible = False
                pnlGuidanceInfo.Visible = True

                ' In student info header: show Status pill badge instead of File Name
                lblFileTitle.Visible = False
                lblFileVal.Visible = False
                lblStatusTitle.Visible = True
                lblStatusVal.Visible = True
                lblStatusVal.Text = currentStatus
                ApplyStatusBadgeStyle(lblStatusVal, currentStatus)

                btnEditGuidance.Visible = False
                btnSaveGuidance.Visible = False
                btnCancelGuidance.Visible = False

                If dtGProfile.Rows.Count > 0 Then
                    Dim gRow = dtGProfile.Rows(0)
                    _guidanceProfileID = Convert.ToInt32(gRow("GuidanceProfileID"))
                    btnEditGuidance.Visible = True
                    Dim addressStr = If(IsDBNull(gRow("Address")), "", gRow("Address").ToString().Trim())
                    Dim contactStr = If(IsDBNull(gRow("ContactNo")), "", gRow("ContactNo").ToString().Trim())
                    Dim emailStr = If(IsDBNull(gRow("Email")), "", gRow("Email").ToString().Trim())
                    Dim emNameStr = If(IsDBNull(gRow("EmergencyContactName")), "", gRow("EmergencyContactName").ToString().Trim())
                    Dim emNoStr = If(IsDBNull(gRow("EmergencyContactNo")), "", gRow("EmergencyContactNo").ToString().Trim())

                    _hasGuidanceInfo = (Not String.IsNullOrWhiteSpace(addressStr)) AndAlso
                                       (Not String.IsNullOrWhiteSpace(contactStr)) AndAlso
                                       (Not String.IsNullOrWhiteSpace(emailStr)) AndAlso
                                       (Not String.IsNullOrWhiteSpace(emNameStr)) AndAlso
                                       (Not String.IsNullOrWhiteSpace(emNoStr))

                    lblGuidanceInfoTitle.Text = "Guidance Information (" & academicYear & ")"
                    lblGuidanceInfoSubtitle.Text = "Below is the information submitted by the student for Academic Year " & academicYear & "."
                    pnlGuidanceFields.Visible = True
                    pnlGuidanceNoUpdate.Visible = False

                    pnlGuidanceInfoNote.BackColor = Color.FromArgb(239, 246, 255)
                    lblGuidanceNoteIcon.Text = "ℹ"
                    lblGuidanceNoteIcon.ForeColor = Color.FromArgb(37, 99, 235)
                    lblGuidanceInfoNote.ForeColor = Color.FromArgb(30, 58, 138)
                    lblGuidanceInfoNote.Text = "This information was submitted by the student for Academic Year " & academicYear & "." & vbCrLf & "Please review the details before approving or rejecting this clearance."

                    FormatGuidanceField(lblAddressValue, If(IsDBNull(gRow("Address")), "", gRow("Address").ToString()))
                    FormatGuidanceField(lblContactValue, If(IsDBNull(gRow("ContactNo")), "", gRow("ContactNo").ToString()))
                    FormatGuidanceField(lblEmailValue, If(IsDBNull(gRow("Email")), "", gRow("Email").ToString()))
                    FormatGuidanceField(lblCivilStatusValue, If(IsDBNull(gRow("CivilStatus")), "", gRow("CivilStatus").ToString()))
                    FormatGuidanceField(lblEmergencyNameValue, If(IsDBNull(gRow("EmergencyContactName")), "", gRow("EmergencyContactName").ToString()))
                    FormatGuidanceField(lblRelationshipValue, If(IsDBNull(gRow("Relationship")), "", gRow("Relationship").ToString()))
                    FormatGuidanceField(lblEmergencyContactValue, If(IsDBNull(gRow("EmergencyContactNo")), "", gRow("EmergencyContactNo").ToString()))
                    FormatGuidanceField(lblNotesValue, If(IsDBNull(gRow("AdditionalNotes")), "", gRow("AdditionalNotes").ToString()))
                Else
                    ' Clean empty state when student has not yet submitted guidance profile for current academic year
                    lblGuidanceInfoTitle.Text = "Guidance Office Requirement (" & academicYear & ")"
                    lblGuidanceInfoSubtitle.Text = "Review and evaluate the student's Guidance clearance requirement."
                    pnlGuidanceFields.Visible = False
                    pnlGuidanceNoUpdate.Visible = True
                    lblNoUpdateTitle.Text = "No Guidance Information Submitted"
                    lblNoUpdateMessage.Text = "No Guidance information has been submitted for the current academic year (" & academicYear & ")." & vbCrLf & vbCrLf & "The student must complete or review/update their Guidance student information before this clearance can be approved."
                End If

            ElseIf _isOfficeVerification Then
                pnlGuidanceInfo.Visible = False
                pnlDocumentCard.Visible = False
                pnlStudentAffairs.Visible = Not _isFinance
                pnlFinanceVerification.Visible = _isFinance
                lblFileTitle.Visible = False
                lblFileVal.Visible = False
                lblStatusTitle.Visible = True
                lblStatusVal.Visible = True
                lblStatusVal.Text = currentStatus
                ApplyStatusBadgeStyle(lblStatusVal, currentStatus)
                lblStatusSubText.Text = If(_isFinance, "Verify payment status before approval. Return unpaid balances with remarks.", "Verify the student record. Return unresolved concerns with clear instructions.")
                btnReject.Text = "Return for Compliance"
                btnApprove.Enabled = False
                btnReject.Enabled = currentStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase) AndAlso Not IsDBNull(row("SubmittedAt"))
            ElseIf Not requiresFile AndAlso (deptName.Equals("Registrar", StringComparison.OrdinalIgnoreCase) OrElse deptName.Equals("OAA", StringComparison.OrdinalIgnoreCase)) Then
                pnlGuidanceInfo.Visible = False
                pnlDocumentCard.Visible = False
                pnlSequentialReview.Visible = True
                lblSequentialReviewTitle.Text = deptName & " Clearance Review"
                lblSequentialReviewInstructions.Text = If(deptName.Equals("Registrar", StringComparison.OrdinalIgnoreCase),
                    "Registrar will review your clearance after Finance approval.",
                    "OAA will review your clearance after Registrar approval.")
                lblStatusSubText.Text = lblSequentialReviewInstructions.Text
                lblFileTitle.Visible = False
                lblFileVal.Visible = False
                lblStatusTitle.Visible = True
                lblStatusVal.Visible = True
                lblStatusVal.Text = currentStatus
                ApplyStatusBadgeStyle(lblStatusVal, currentStatus)
                btnReject.Text = "Return for Compliance"
                Dim canReview = currentStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase) AndAlso Not IsDBNull(row("SubmittedAt"))
                btnApprove.Enabled = canReview
                btnReject.Enabled = canReview
            ElseIf isClinicOffice Then
                pnlGuidanceInfo.Visible = False
                pnlDocumentCard.Visible = False
                pnlClinicInfo.Visible = True
                _clinicStudentID = _studentID
                _clinicAcademicYear = row("AcademicYear").ToString()

                lblFileTitle.Visible = False
                lblFileVal.Visible = False
                lblStatusTitle.Visible = True
                lblStatusVal.Visible = True
                Dim clinicStatus As String = If(currentStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase), "Needs Completion", currentStatus)
                lblStatusBadge.Text = clinicStatus
                lblStatusVal.Text = clinicStatus
                ApplyStatusBadgeStyle(lblStatusBadge, clinicStatus)
                ApplyStatusBadgeStyle(lblStatusVal, clinicStatus)
                btnReject.Text = "Return for Completion"
                btnReject.BackColor = Color.FromArgb(234, 88, 12)
                btnReject.ForeColor = Color.White
                lblStatusSubText.Text = "Review the submitted assessment. Supporting documents are only required when requested by Clinic Department Head."
                LoadClinicAssessment()
            Else
                ' Standard file-based offices: Show document preview, hide guidance panel
                pnlGuidanceInfo.Visible = False
                pnlDocumentCard.Visible = True

                lblStatusTitle.Visible = False
                lblStatusVal.Visible = False
                lblFileTitle.Visible = True
                lblFileVal.Visible = True

                currentFilePath = ""
                If Not IsDBNull(row("SubmittedFilePath")) Then
                    currentFilePath = row("SubmittedFilePath").ToString()
                End If

                Dim fileName As String = "No document attached"
                If Not IsDBNull(row("SubmittedFileName")) Then
                    fileName = row("SubmittedFileName").ToString()
                End If
                lblFileVal.Text = fileName
                lblDocFileName.Text = fileName

                ' Load all files for this record
                cmbSubmittedFiles.Items.Clear()
                Try
                    Dim filesQuery As String =
                        "SELECT StoredFilePath, OriginalFileName FROM ClearanceRecordFiles WHERE RecordID = @RecordID ORDER BY FileID ASC;"
                    Dim dtFiles As DataTable = db.ExecuteQuery(filesQuery, New Dictionary(Of String, Object) From {{"@RecordID", TargetRecordID}})

                    If dtFiles.Rows.Count > 0 Then
                        For Each fRow As DataRow In dtFiles.Rows
                            Dim fPath = fRow("StoredFilePath").ToString()
                            Dim fName = fRow("OriginalFileName").ToString()
                            cmbSubmittedFiles.Items.Add(New SubmittedFileItem With {.OriginalFileName = fName, .StoredFilePath = fPath})
                        Next

                        If dtFiles.Rows.Count > 1 Then
                            cmbSubmittedFiles.Visible = True
                            lblDocFileName.Visible = False
                        Else
                            cmbSubmittedFiles.Visible = False
                            lblDocFileName.Visible = True
                        End If

                        cmbSubmittedFiles.SelectedIndex = 0
                    Else
                        cmbSubmittedFiles.Visible = False
                        lblDocFileName.Visible = True
                        LoadDocumentPreview()
                    End If
                Catch exFiles As Exception
                    cmbSubmittedFiles.Visible = False
                    lblDocFileName.Visible = True
                    LoadDocumentPreview()
                End Try

                _hasSubmittedDocument = (Not String.IsNullOrWhiteSpace(currentFilePath)) OrElse (cmbSubmittedFiles.Items.Count > 0)
            End If

            LoadPrerequisiteApprovals()
        Catch ex As Exception
            MessageBox.Show("Failed to load submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadPrerequisiteApprovals()
        Dim items = ClearanceWorkflowHelper.GetStudentClearanceItems(_studentID, _termID, _studentCourse, _studentYearLevel, db)
        Dim current = items.FirstOrDefault(Function(i) i.RecordID = TargetRecordID)
        ApplyPrerequisiteCardStyle("info")
        SetApprovalMetadataVisible(False)
        lblPrerequisiteApprovalDetails.Visible = True
        lblPrerequisiteApprovalTitle.Text = "Prerequisite approvals"
        lblPrerequisiteApprovalDetails.Text = "Approval details unavailable."
        If current Is Nothing Then Return

        Dim prerequisites As List(Of ClearanceWorkflowHelper.ClearanceItemInfo)
        If current.SequenceOrder = 6 Then
            prerequisites = items.Where(Function(i) i.SequenceOrder >= 1 AndAlso i.SequenceOrder <= 5 AndAlso i.IsApplicable).ToList()
        ElseIf current.SequenceOrder > 6 Then
            prerequisites = items.Where(Function(i) i.SequenceOrder = current.SequenceOrder - 1 AndAlso i.IsApplicable).ToList()
        Else
            lblPrerequisiteApprovalTitle.Text = "Parallel clearance"
            lblPrerequisiteApprovalDetails.Text = "This office can review independently."
            Return
        End If

        If prerequisites.Count = 0 Then
            lblPrerequisiteApprovalDetails.Text = "No applicable prerequisite office."
            Return
        End If
        Dim allApproved = prerequisites.All(Function(i) i.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase))
        ApplyPrerequisiteCardStyle(If(allApproved, "approved", "pending"))
        If prerequisites.Count = 1 Then
            Dim item = prerequisites(0)
            ShowSinglePrerequisiteApproval(item.DepartmentName, allApproved,
                If(allApproved, GetApprovalMetadata(item), ""), item.DisplayStatus)
        Else
            Dim lines As New List(Of String)
            For Each item In prerequisites
                If item.EffectiveStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                    lines.Add("Approved by " & item.DepartmentName & " — " & GetApprovalMetadata(item))
                Else
                    lines.Add(item.DepartmentName & " — " & item.DisplayStatus)
                End If
            Next
            lblPrerequisiteApprovalDetails.Text = String.Join(vbCrLf, lines)
        End If
    End Sub

    Private Sub ApplyPrerequisiteCardStyle(state As String)
        Dim accent As Color
        Dim iconKey As String
        Select Case state
            Case "approved"
                pnlPrerequisiteApproval.BackColor = Color.FromArgb(240, 253, 244)
                accent = Color.FromArgb(22, 163, 74)
                lblPrerequisiteApprovalTitle.ForeColor = Color.FromArgb(22, 101, 52)
                iconKey = "PrerequisiteApprovedIcon"
            Case "pending"
                pnlPrerequisiteApproval.BackColor = Color.FromArgb(255, 251, 235)
                accent = Color.FromArgb(217, 119, 6)
                lblPrerequisiteApprovalTitle.ForeColor = Color.FromArgb(146, 64, 14)
                iconKey = "PrerequisitePendingIcon"
            Case Else
                pnlPrerequisiteApproval.BackColor = Color.FromArgb(239, 246, 255)
                accent = Color.FromArgb(37, 99, 235)
                lblPrerequisiteApprovalTitle.ForeColor = Color.FromArgb(30, 64, 175)
                iconKey = "PrerequisiteInfoIcon"
        End Select
        pnlPrerequisiteAccent.BackColor = accent
        picPrerequisiteStatus.Image = CType(approvalResources.GetObject(iconKey), Image)
    End Sub

    Private Sub SetApprovalMetadataVisible(visible As Boolean)
        lblPrerequisiteApprovedBy.Visible = visible
        lblPrerequisiteApproverName.Visible = visible
        lblPrerequisiteDateCaption.Visible = visible
        lblPrerequisiteApprovalDate.Visible = visible
    End Sub

    Private Sub ShowSinglePrerequisiteApproval(office As String, approved As Boolean, metadata As String, status As String)
        Dim officeTitle = If(office.Equals("Finance Office", StringComparison.OrdinalIgnoreCase), "Finance", office)
        ApplyPrerequisiteCardStyle(If(approved, "approved", "pending"))
        lblPrerequisiteApprovalTitle.Text = If(approved, officeTitle & " APPROVED", "AWAITING " & officeTitle & " APPROVAL").ToUpperInvariant()
        SetApprovalMetadataVisible(approved)
        lblPrerequisiteApprovalDetails.Visible = Not approved
        If approved Then
            Dim separator = metadata.LastIndexOf(" · ", StringComparison.Ordinal)
            lblPrerequisiteApproverName.Text = If(separator < 0, "Approving Department Head not recorded", metadata.Substring(0, separator))
            lblPrerequisiteApprovalDate.Text = If(separator < 0, "Approval date not recorded", metadata.Substring(separator + 3).Replace(" am", " AM").Replace(" pm", " PM"))
        Else
            lblPrerequisiteApprovalDetails.Text = "Status: " & status
        End If
    End Sub

    Private Function GetApprovalMetadata(item As ClearanceWorkflowHelper.ClearanceItemInfo) As String
        ' Use the latest approval audit entry so older batch approvals also identify the actual actor.
        Dim query = "SELECT approver.FullName AS ApproverName, " &
            "CASE WHEN h.HistoryID IS NOT NULL THEN h.ActionAt ELSE cr.ReviewedAt END AS ApprovedAt " &
            "FROM ClearanceRecords cr LEFT JOIN ClearanceHistory h ON h.HistoryID = " &
            "(SELECT h2.HistoryID FROM ClearanceHistory h2 WHERE h2.RecordID = cr.RecordID AND h2.NewStatus = 'Cleared' " &
            "ORDER BY h2.ActionAt DESC, h2.HistoryID DESC LIMIT 1) " &
            "LEFT JOIN Users approver ON approver.UserID = CASE WHEN h.HistoryID IS NOT NULL THEN h.ActionBy ELSE cr.ReviewedBy END " &
            "WHERE cr.RecordID = @RecordID AND cr.StudentID = @StudentID AND cr.TermID = @TermID AND cr.Status = 'Cleared';"
        Dim table = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
            {"@RecordID", item.RecordID}, {"@StudentID", _studentID}, {"@TermID", _termID}})
        Return FormatApprovalMetadata(If(table.Rows.Count = 0, Nothing, table.Rows(0)))
    End Function

    Private Shared Function FormatApprovalMetadata(row As DataRow) As String
        Dim name = If(row Is Nothing OrElse IsDBNull(row("ApproverName")), "", row("ApproverName").ToString().Trim())
        If String.IsNullOrWhiteSpace(name) Then name = "Approving Department Head not recorded"
        Dim dateText = If(row Is Nothing OrElse IsDBNull(row("ApprovedAt")), "Approval date not recorded", Convert.ToDateTime(row("ApprovedAt")).ToString("MMM dd, yyyy hh:mm tt"))
        Return name & " · " & dateText
    End Function

    Private Function HasClinicReviewAccess() As Boolean
        If Not AppSession.Role.Equals("Staff", StringComparison.OrdinalIgnoreCase) OrElse
           Not AppSession.DepartmentID.HasValue OrElse AppSession.DepartmentID.Value <> 9 Then Return False

        Try
            ' Check the current account assignment as well as the session.
            Dim sql As String =
                "SELECT COUNT(*) FROM Staff st INNER JOIN Users u ON st.UserID = u.UserID " &
                "WHERE u.UserID = @UserID AND u.Role = 'Staff' AND u.IsActive = 1 AND st.DepartmentID = 9;"
            Return Convert.ToInt32(db.ExecuteScalar(sql, New Dictionary(Of String, Object) From {{"@UserID", AppSession.UserID}})) > 0
        Catch
            Return False
        End Try
    End Function

    Private Sub LoadClinicAssessment()
        _hasClinicAssessment = False
        _clinicAttachedFilePath = ""
        btnViewClinicDoc.Visible = False
        btnOpenAssessmentModal.Enabled = False
        pnlClinicFields.Visible = False
        pnlClinicNoUpdate.Visible = False
        pnlClinicRestricted.Visible = Not HasClinicReviewAccess()

        If pnlClinicRestricted.Visible Then
            btnApprove.Enabled = False
            btnReject.Enabled = False
            Return
        End If

        Dim sql As String =
            "SELECT a.HasMedicalCondition, a.MedicalConditionDetails, a.HasAllergies, a.AllergiesDetails, " &
            "a.HasMedications, a.MedicationsDetails, a.HasHealthConcerns, a.HealthConcernsDetails, " &
            "a.EmergencyContactName, a.Relationship, a.EmergencyContactNo, a.IsConfirmed, a.SubmittedAt " &
            "FROM ClinicHealthAssessments a " &
            "INNER JOIN ClearanceRecords cr ON a.RecordID = cr.RecordID AND a.StudentID = cr.StudentID AND a.TermID = cr.TermID " &
            "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
            "WHERE a.RecordID = @RecordID AND a.StudentID = @StudentID AND a.TermID = @TermID " &
            "AND r.DepartmentID = 9 AND a.IsDraft = 0 LIMIT 1;"
        Dim parameters As New Dictionary(Of String, Object) From {
            {"@RecordID", TargetRecordID}, {"@StudentID", _clinicStudentID}, {"@TermID", _termID}
        }
        Dim assessment As DataTable = db.ExecuteQuery(sql, parameters)
        _hasClinicAssessment = assessment.Rows.Count > 0
        pnlClinicFields.Visible = _hasClinicAssessment
        pnlClinicNoUpdate.Visible = Not _hasClinicAssessment
        btnOpenAssessmentModal.Enabled = _hasClinicAssessment
        btnApprove.Enabled = _hasClinicAssessment

        If Not _hasClinicAssessment Then Return

        Dim row As DataRow = assessment.Rows(0)
        FormatGuidanceField(lblClinicMedVal, FormatClinicAnswer(row, "HasMedicalCondition", "MedicalConditionDetails"))
        FormatGuidanceField(lblClinicAlgVal, FormatClinicAnswer(row, "HasAllergies", "AllergiesDetails"))
        FormatGuidanceField(lblClinicMedsVal, FormatClinicAnswer(row, "HasMedications", "MedicationsDetails"))
        FormatGuidanceField(lblClinicConcernsVal, FormatClinicAnswer(row, "HasHealthConcerns", "HealthConcernsDetails"))
        FormatGuidanceField(lblClinicEmVal, String.Join(" / ", {row("EmergencyContactName").ToString(), row("Relationship").ToString(), row("EmergencyContactNo").ToString()}))
        lblClinicDecVal.Text = If(Convert.ToBoolean(row("IsConfirmed")), "Confirmed by student", "Not confirmed by student")
        If Not IsDBNull(row("SubmittedAt")) Then
            lblDateVal.Text = Convert.ToDateTime(row("SubmittedAt")).ToString("MMM dd, yyyy hh:mm tt")
        End If

        Dim filesSql As String =
            "SELECT f.StoredFilePath, f.OriginalFileName FROM ClearanceRecordFiles f " &
            "INNER JOIN ClearanceRecords cr ON f.RecordID = cr.RecordID " &
            "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
            "WHERE cr.RecordID = @RecordID AND cr.StudentID = @StudentID AND cr.TermID = @TermID " &
            "AND r.DepartmentID = 9 ORDER BY f.FileID DESC;"
        Dim files As DataTable = db.ExecuteQuery(filesSql, parameters)
        lblClinicDocVal.Text = "No document attached (optional unless requested)"
        If files.Rows.Count > 0 Then
            _clinicAttachedFilePath = files.Rows(0)("StoredFilePath").ToString()
            lblClinicDocVal.Text = files.Rows(0)("OriginalFileName").ToString()
            If files.Rows.Count > 1 Then lblClinicDocVal.Text &= " (+" & (files.Rows.Count - 1).ToString() & " earlier document(s))"
        Else
            Dim record As DataTable = db.ExecuteQuery(
                "SELECT cr.SubmittedFilePath, cr.SubmittedFileName FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "WHERE cr.RecordID = @RecordID AND cr.StudentID = @StudentID AND cr.TermID = @TermID AND r.DepartmentID = 9;", parameters)
            If record.Rows.Count > 0 AndAlso Not IsDBNull(record.Rows(0)("SubmittedFilePath")) Then
                _clinicAttachedFilePath = record.Rows(0)("SubmittedFilePath").ToString()
                If Not String.IsNullOrWhiteSpace(_clinicAttachedFilePath) Then lblClinicDocVal.Text = record.Rows(0)("SubmittedFileName").ToString()
            End If
        End If
        btnViewClinicDoc.Visible = Not String.IsNullOrWhiteSpace(_clinicAttachedFilePath)
    End Sub

    Private Function FormatClinicAnswer(row As DataRow, answerColumn As String, detailsColumn As String) As String
        If IsDBNull(row(answerColumn)) Then Return "Not answered"
        If Not Convert.ToBoolean(row(answerColumn)) Then Return "No"
        Dim details As String = row(detailsColumn).ToString().Trim()
        Return If(String.IsNullOrWhiteSpace(details), "Yes (no optional details provided)", "Yes — " & details)
    End Function

    Private Sub btnOpenAssessmentModal_Click(sender As Object, e As EventArgs) Handles btnOpenAssessmentModal.Click
        If Not _isClinicOffice OrElse Not HasClinicReviewAccess() Then Return
        Try
            LoadClinicAssessment()
            If Not _hasClinicAssessment Then Return
            Using modal As New ClinicHealthAssessmentForm() With {
                .RecordID = TargetRecordID, .StudentID = _clinicStudentID, .TermID = _termID, .AcademicYear = _clinicAcademicYear,
                .IsReadOnly = True, .IsStaffReview = True
            }
                modal.ShowDialog(Me)
            End Using
        Catch ex As Exception
            MessageBox.Show("Unable to open the submitted Clinic assessment: " & ex.Message, "Clinic Assessment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnViewClinicDoc_Click(sender As Object, e As EventArgs) Handles btnViewClinicDoc.Click
        If Not _isClinicOffice OrElse Not HasClinicReviewAccess() Then Return
        Try
            LoadClinicAssessment()
            If Not _hasClinicAssessment OrElse String.IsNullOrWhiteSpace(_clinicAttachedFilePath) Then Return
            Dim documentPath As String = _clinicAttachedFilePath
            If Not Path.IsPathRooted(documentPath) Then documentPath = Path.Combine(Application.StartupPath, documentPath)
            documentPath = Path.GetFullPath(documentPath)
            Dim extension As String = Path.GetExtension(documentPath).ToLowerInvariant()
            If Not {".pdf", ".jpg", ".jpeg", ".png"}.Contains(extension) Then
                MessageBox.Show("Only PDF, JPG, JPEG, and PNG Clinic supporting documents can be opened.", "Unsupported Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Not File.Exists(documentPath) Then
                MessageBox.Show("The attached Clinic document could not be found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            Process.Start(New ProcessStartInfo(documentPath) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Unable to open the Clinic document: " & ex.Message, "Clinic Document", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub FormatGuidanceField(lbl As Label, value As String)
        If String.IsNullOrWhiteSpace(value) Then
            lbl.Text = "Not provided"
            lbl.ForeColor = Color.FromArgb(148, 163, 184)
            lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, FontStyle.Italic)
        Else
            lbl.Text = value.Trim()
            lbl.ForeColor = Color.FromArgb(15, 23, 42)
            lbl.Font = New Font(lbl.Font.FontFamily, lbl.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub ApplyStatusBadgeStyle(lbl As Label, status As String)
        Select Case status.ToLowerInvariant()
            Case "needs completion"
                lbl.BackColor = Color.FromArgb(255, 237, 213)
                lbl.ForeColor = Color.FromArgb(194, 65, 12)
            Case "cleared"
                lbl.BackColor = Color.FromArgb(220, 252, 231)
                lbl.ForeColor = Color.FromArgb(22, 101, 52)
            Case "under review"
                lbl.BackColor = Color.FromArgb(219, 234, 254)
                lbl.ForeColor = Color.FromArgb(30, 64, 175)
            Case "rejected"
                lbl.BackColor = Color.FromArgb(254, 226, 226)
                lbl.ForeColor = Color.FromArgb(185, 28, 28)
            Case Else
                lbl.BackColor = Color.FromArgb(254, 243, 199)
                lbl.ForeColor = Color.FromArgb(146, 64, 14)
        End Select
    End Sub

    Private Sub LoadDocumentPreview()
        If String.IsNullOrWhiteSpace(currentFilePath) Then
            picPreview.Visible = False
            pnlPdfFallback.Visible = True
            lblPdfPrompt.Text = "No Document Attached"
            lblPdfSub.Text = "The student has not uploaded any file for this clearance requirement."
            btnOpenExternal.Enabled = False
            btnOpenPdfCenter.Enabled = False
            Return
        End If

        btnOpenExternal.Enabled = True
        btnOpenPdfCenter.Enabled = True

        Dim fullPath As String = currentFilePath
        If Not Path.IsPathRooted(fullPath) Then
            fullPath = Path.Combine(Application.StartupPath, currentFilePath)
        End If

        If Not File.Exists(fullPath) Then
            picPreview.Visible = False
            pnlPdfFallback.Visible = True
            lblPdfPrompt.Text = "File Not Found On Server"
            lblPdfSub.Text = "The submitted document file cannot be found at: " & Path.GetFileName(fullPath)
            Return
        End If

        Dim ext As String = Path.GetExtension(fullPath).ToLower()
        If ext = ".jpg" OrElse ext = ".jpeg" OrElse ext = ".png" OrElse ext = ".bmp" Then
            Try
                Using stream As New FileStream(fullPath, FileMode.Open, FileAccess.Read)
                    picPreview.Image = Image.FromStream(stream)
                End Using
                picPreview.Visible = True
                pnlPdfFallback.Visible = False
            Catch
                picPreview.Visible = False
                pnlPdfFallback.Visible = True
                lblPdfPrompt.Text = "Image Preview Error"
                lblPdfSub.Text = "Click Open Document to view this image in default photos app."
            End Try
        Else
            picPreview.Visible = False
            pnlPdfFallback.Visible = True
            lblPdfPrompt.Text = "PDF Document Ready"
            lblPdfSub.Text = "Click Open Document to view this file in your default PDF reader."
        End If
    End Sub

    Private Sub OpenSubmittedDocument()
        If String.IsNullOrWhiteSpace(currentFilePath) Then
            MessageBox.Show("No document attached.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim fullPath As String = currentFilePath
        If Not Path.IsPathRooted(fullPath) Then
            fullPath = Path.Combine(Application.StartupPath, currentFilePath)
        End If

        If Not File.Exists(fullPath) Then
            MessageBox.Show("The file does not exist on disk: " & fullPath, "File Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim psi As New ProcessStartInfo(fullPath) With {.UseShellExecute = True}
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show("Failed to open document: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadTimeline()
        If Not AppSession.DepartmentID.HasValue Then Return

        dgvTimeline.Rows.Clear()
        Try
            Dim query As String =
                "SELECT " &
                "  h.ActionType, " &
                "  h.OldStatus, " &
                "  h.NewStatus, " &
                "  h.Remarks, " &
                "  h.ActionAt, " &
                "  COALESCE(u.FullName, 'System') AS PerformedBy " &
                "FROM ClearanceHistory h " &
                "INNER JOIN ClearanceRecords cr ON h.RecordID = cr.RecordID " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "LEFT JOIN Users u ON h.ActionBy = u.UserID " &
                "WHERE h.RecordID = @RecordID AND r.DepartmentID = @DeptID " &
                "ORDER BY h.ActionAt DESC;"

            Dim dt As DataTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {
                {"@RecordID", TargetRecordID},
                {"@DeptID", AppSession.DepartmentID.Value}
            })

            If dt.Rows.Count = 0 Then
                lblTimelineEmpty.Visible = True
                dgvTimeline.Visible = False
                Return
            End If

            lblTimelineEmpty.Visible = False
            dgvTimeline.Visible = True

            For Each row As DataRow In dt.Rows
                Dim actionType As String = row("ActionType").ToString()
                Dim actionDate As DateTime = Convert.ToDateTime(row("ActionAt"))
                Dim timeText As String = actionDate.ToString("yyyy-MM-dd HH:mm")
                Dim remarksText As String = If(IsDBNull(row("Remarks")), "", row("Remarks").ToString())
                Dim actorText As String = row("PerformedBy").ToString()
                Dim detailText As String = If(String.IsNullOrWhiteSpace(remarksText), "By " & actorText, remarksText & " (by " & actorText & ")")

                dgvTimeline.Rows.Add(actionType, timeText, detailText)
            Next

        Catch ex As Exception
            lblTimelineEmpty.Text = "Unable to load activity history."
            lblTimelineEmpty.Visible = True
            dgvTimeline.Visible = False
        End Try
    End Sub

    ' Remarks char count
    Private Sub txtRemarks_TextChanged(sender As Object, e As EventArgs) Handles txtRemarks.TextChanged
        lblCharCount.Text = txtRemarks.Text.Length.ToString() & " / 500"
    End Sub

    ' Open Document buttons
    Private Sub btnOpenExternal_Click(sender As Object, e As EventArgs) Handles btnOpenExternal.Click, btnOpenPdfCenter.Click
        OpenSubmittedDocument()
    End Sub

    ' Decision: Approve / Clear
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        If _isEditingGuidance Then
            MessageBox.Show("Please save or cancel your Guidance information changes before approving.", "Unsaved Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not AppSession.DepartmentID.HasValue Then
            MessageBox.Show("Security Error: Your account is not authorized for any department.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If _isClinicOffice AndAlso (Not HasClinicReviewAccess() OrElse Not _hasClinicAssessment) Then
            MessageBox.Show("Clinic approval requires an assessment submitted by the student and an authorized Clinic officer.", "Clinic Assessment Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validation: Guidance requirement requires student to have submitted their guidance information for the current academic year!
        If _isGuidanceOffice AndAlso Not _hasGuidanceInfo Then
            MessageBox.Show(
                "Cannot approve clearance: The student has not yet submitted or updated their Guidance information for the current academic year." & vbCrLf & vbCrLf &
                "The student must complete and submit their Guidance information before Guidance clearance can be approved." & vbCrLf & vbCrLf &
                "You may reject the request with remarks explaining what they need to provide, or wait for them to update their information.",
                "Guidance Information Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        ' Validation: File-based requirement without any uploaded document cannot be approved!
        If _requiresFile AndAlso Not _hasSubmittedDocument Then
            MessageBox.Show(
                "Cannot approve clearance: No document has been submitted by the student for this requirement." & vbCrLf & vbCrLf &
                "The student must upload the required file before this clearance can be approved.",
                "Document Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        ' Sequential Clearance Gate: Validate prerequisite steps
        Dim blockerReason As String = ""
        If Not ClearanceWorkflowHelper.CanStaffApproveRecord(TargetRecordID, db, blockerReason) Then
            MessageBox.Show(
                blockerReason,
                "Prerequisites Incomplete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        If _isOfficeVerification AndAlso Not OfficeVerificationConfirmed Then
            MessageBox.Show(If(_isFinance, "Verify that all balances are settled before approval.", "Verify that there are no unresolved concerns before approval."), "Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim remarks As String = txtRemarks.Text.Trim()
        Dim confirm = MessageBox.Show(
            "Are you sure you want to APPROVE and CLEAR this requirement for " & lblStudentNameVal.Text & "?",
            "Confirm Clearance Approval",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm <> DialogResult.Yes Then Return

        UpdateClearanceStatus("Cleared", remarks, "Requirement Approved / Cleared")
    End Sub

    ' Decision: Reject (Remarks REQUIRED!)
    Private Sub btnReject_Click(sender As Object, e As EventArgs) Handles btnReject.Click
        If _isEditingGuidance Then
            MessageBox.Show("Please save or cancel your Guidance information changes before rejecting.", "Unsaved Changes", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not AppSession.DepartmentID.HasValue Then
            MessageBox.Show("Security Error: Your account is not authorized for any department.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim remarks As String = txtRemarks.Text.Trim()

        If String.IsNullOrWhiteSpace(remarks) Then
            MessageBox.Show(
                If(_isClinicOffice, "Remarks are REQUIRED when returning a Clinic assessment for completion.", "Remarks are REQUIRED when rejecting a clearance request.") & vbCrLf & vbCrLf &
                "Please explain to the student what is missing or needs correction.",
                "Remarks Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtRemarks.Focus()
            Return
        End If

        Dim confirm = MessageBox.Show(
            If(_isClinicOffice, "Return this assessment to the student for completion?", "Are you sure you want to REJECT this requirement?"),
            If(_isClinicOffice, "Confirm Return for Completion", "Confirm Rejection"),
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning
        )

        If confirm <> DialogResult.Yes Then Return

        UpdateClearanceStatus("Rejected", remarks, If(_isOfficeVerification, "Returned for Compliance", If(_isClinicOffice, "Returned for Completion", "Requirement Rejected")))
    End Sub

    Private ReadOnly Property OfficeVerificationConfirmed As Boolean
        Get
            Return If(_isFinance, chkFinanceVerified.Checked, chkStudentAffairsVerified.Checked)
        End Get
    End Property

    Private Sub chkStudentAffairsVerified_CheckedChanged(sender As Object, e As EventArgs) Handles chkStudentAffairsVerified.CheckedChanged, chkFinanceVerified.CheckedChanged
        If _isOfficeVerification Then btnApprove.Enabled = OfficeVerificationConfirmed AndAlso currentStatus.Equals("Under Review", StringComparison.OrdinalIgnoreCase)
    End Sub

    Private Sub UpdateClearanceStatus(newStatus As String, remarks As String, actionTypeName As String)
        If Not AppSession.DepartmentID.HasValue Then
            MessageBox.Show("Security Error: No assigned department found in session.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If _isOfficeVerification AndAlso newStatus = "Cleared" AndAlso Not OfficeVerificationConfirmed Then
            MessageBox.Show(If(_isFinance, "Verify that all balances are settled before approval.", "Verify that there are no unresolved concerns before approval."), "Verification Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If Not ClearanceWorkflowHelper.HasStaffDepartmentAccess(AppSession.DepartmentID.Value, db) Then
            MessageBox.Show("Your staff assignment is no longer authorized.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If _isClinicOffice AndAlso Not HasClinicReviewAccess() Then
            MessageBox.Show("Clinic decisions are restricted to authorized Clinic personnel.", "Authorization Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newStatus = "Cleared" Then
            Dim reason As String = ""
            If Not ClearanceWorkflowHelper.CanStaffApproveRecord(TargetRecordID, db, reason) Then
                MessageBox.Show(reason, "Approval Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If
        If newStatus = "Rejected" AndAlso String.IsNullOrWhiteSpace(remarks) Then Return

        Try
            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        Dim updateQuery As String =
                            "UPDATE ClearanceRecords cr " &
                            "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                            "SET cr.Status = @NewStatus, " &
                            "    cr.Remarks = @Remarks, " &
                            "    cr.ReviewedBy = @ReviewedBy, " &
                            "    cr.ReviewedAt = CURRENT_TIMESTAMP " &
                            "WHERE cr.RecordID = @RecordID AND r.DepartmentID = @DeptID " &
                            "AND cr.Status = 'Under Review' AND cr.SubmittedAt IS NOT NULL " &
                            "AND EXISTS (SELECT 1 FROM AcademicTerms t WHERE t.TermID = cr.TermID AND t.IsActive = 1) " &
                            "AND EXISTS (SELECT 1 FROM Staff st INNER JOIN Users u ON u.UserID = st.UserID " &
                            "WHERE st.UserID = @ReviewedBy AND st.DepartmentID = r.DepartmentID AND u.Role = 'Staff' AND u.IsActive = 1 AND st.IsActive = 1) " &
                            "AND (r.DepartmentID <> 9 OR EXISTS (SELECT 1 FROM Staff st INNER JOIN Users u ON st.UserID = u.UserID " &
                            "WHERE u.UserID = @ReviewedBy AND u.Role = 'Staff' AND u.IsActive = 1 AND st.DepartmentID = 9)) " &
                            "AND (@NewStatus <> 'Cleared' OR r.DepartmentID <> 9 OR EXISTS " &
                            "(SELECT 1 FROM ClinicHealthAssessments a WHERE a.RecordID = cr.RecordID " &
                            "AND a.StudentID = cr.StudentID AND a.TermID = cr.TermID AND a.IsDraft = 0));"

                        Using updateCmd As New MySqlCommand(updateQuery, conn, transaction)
                            updateCmd.Parameters.AddWithValue("@NewStatus", newStatus)
                            updateCmd.Parameters.AddWithValue("@Remarks", If(String.IsNullOrWhiteSpace(remarks), DBNull.Value, CObj(remarks)))
                            updateCmd.Parameters.AddWithValue("@ReviewedBy", AppSession.UserID)
                            updateCmd.Parameters.AddWithValue("@RecordID", TargetRecordID)
                            updateCmd.Parameters.AddWithValue("@DeptID", AppSession.DepartmentID.Value)

                            Dim rowsAffected As Integer = updateCmd.ExecuteNonQuery()
                            If rowsAffected = 0 Then
                                transaction.Rollback()
                                MessageBox.Show(
                                    "Update Failed: You are not authorized to update clearance records for another department.",
                                    "Unauthorized Action",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error
                                )
                                Return
                            End If
                        End Using

                        Dim histQuery As String =
                            "INSERT INTO ClearanceHistory " &
                            "(RecordID, ActionBy, ActionType, OldStatus, NewStatus, Remarks) " &
                            "VALUES (@RecordID, @ActionBy, @ActionType, @OldStatus, @NewStatus, @Remarks);"

                        Using histCmd As New MySqlCommand(histQuery, conn, transaction)
                            histCmd.Parameters.AddWithValue("@RecordID", TargetRecordID)
                            histCmd.Parameters.AddWithValue("@ActionBy", AppSession.UserID)
                            histCmd.Parameters.AddWithValue("@ActionType", actionTypeName)
                            histCmd.Parameters.AddWithValue("@OldStatus", currentStatus)
                            histCmd.Parameters.AddWithValue("@NewStatus", newStatus)
                            Dim historyRemarks = If(_isOfficeVerification AndAlso newStatus = "Cleared",
                                If(_isFinance, "Finance verified: all balances settled. ", "Department Head verified: no unresolved concerns. ") & remarks,
                                If(String.IsNullOrWhiteSpace(remarks), actionTypeName, remarks))
                            histCmd.Parameters.AddWithValue("@Remarks", historyRemarks.Substring(0, Math.Min(500, historyRemarks.Length)))
                            histCmd.ExecuteNonQuery()
                        End Using

                        ' If cleared, automatically unlock next sequential step in the active term
                        If newStatus.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                            ClearanceWorkflowHelper.UnlockNextStepsInDatabase(_studentID, _termID, _studentCourse, _studentYearLevel, db, conn, transaction, TargetRecordID, newStatus)
                        End If

                        transaction.Commit()

                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show(
                If(_isClinicOffice AndAlso newStatus.Equals("Rejected", StringComparison.OrdinalIgnoreCase),
                   "The assessment has been returned to the student for completion with your remarks.",
                   "Clearance status has been updated to: " & newStatus & " successfully."),
                "Decision Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to save decision: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ReturnToRequests()
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        If _isEditingGuidance Then
            MessageBox.Show("Please save or cancel your changes before minimizing.", "Editing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        
        Dim rootForm As Form = Me.Owner
        While rootForm IsNot Nothing AndAlso rootForm.Owner IsNot Nothing
            rootForm = rootForm.Owner
        End While
        If rootForm IsNot Nothing Then
            rootForm.WindowState = FormWindowState.Minimized
        Else
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click, btnBackToRequests.Click
        If _isEditingGuidance Then
            Dim confirm = MessageBox.Show("You have unsaved changes to the Guidance information. Are you sure you want to close and discard them?", "Unsaved Changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If confirm <> DialogResult.Yes Then Return
        End If
        ReturnToRequests()
    End Sub

    Private Sub cmbSubmittedFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSubmittedFiles.SelectedIndexChanged
        If cmbSubmittedFiles.SelectedItem IsNot Nothing Then
            Dim fItem = DirectCast(cmbSubmittedFiles.SelectedItem, SubmittedFileItem)
            currentFilePath = fItem.StoredFilePath
            lblDocFileName.Text = fItem.OriginalFileName
            LoadDocumentPreview()
        End If
    End Sub

    Private Class SubmittedFileItem
        Public Property OriginalFileName As String
        Public Property StoredFilePath As String

        Public Overrides Function ToString() As String
            Return OriginalFileName
        End Function
    End Class

    Private Sub lblOfficeName_Click(sender As Object, e As EventArgs) Handles lblOfficeName.Click

    End Sub

    Private Sub btnEditGuidance_Click(sender As Object, e As EventArgs) Handles btnEditGuidance.Click
        _isEditingGuidance = True
        btnEditGuidance.Visible = False
        btnSaveGuidance.Visible = True
        btnCancelGuidance.Visible = True

        ' Populate TextBoxes with label values (except "Not provided")
        txtAddress.Text = If(lblAddressValue.Text = "Not provided", "", lblAddressValue.Text)
        txtContact.Text = If(lblContactValue.Text = "Not provided", "", lblContactValue.Text)
        txtEmail.Text = If(lblEmailValue.Text = "Not provided", "", lblEmailValue.Text)
        txtCivilStatus.Text = If(lblCivilStatusValue.Text = "Not provided", "", lblCivilStatusValue.Text)
        txtEmergencyName.Text = If(lblEmergencyNameValue.Text = "Not provided", "", lblEmergencyNameValue.Text)
        txtRelationship.Text = If(lblRelationshipValue.Text = "Not provided", "", lblRelationshipValue.Text)
        txtEmergencyContact.Text = If(lblEmergencyContactValue.Text = "Not provided", "", lblEmergencyContactValue.Text)
        txtNotes.Text = If(lblNotesValue.Text = "Not provided", "", lblNotesValue.Text)

        ' Toggle visibility
        lblAddressValue.Visible = False
        txtAddress.Visible = True
        lblContactValue.Visible = False
        txtContact.Visible = True
        lblEmailValue.Visible = False
        txtEmail.Visible = True
        lblCivilStatusValue.Visible = False
        txtCivilStatus.Visible = True
        lblEmergencyNameValue.Visible = False
        txtEmergencyName.Visible = True
        lblRelationshipValue.Visible = False
        txtRelationship.Visible = True
        lblEmergencyContactValue.Visible = False
        txtEmergencyContact.Visible = True
        lblNotesValue.Visible = False
        txtNotes.Visible = True
    End Sub

    Private Sub EndGuidanceEditMode()
        _isEditingGuidance = False
        btnEditGuidance.Visible = True
        btnSaveGuidance.Visible = False
        btnCancelGuidance.Visible = False

        lblAddressValue.Visible = True
        txtAddress.Visible = False
        lblContactValue.Visible = True
        txtContact.Visible = False
        lblEmailValue.Visible = True
        txtEmail.Visible = False
        lblCivilStatusValue.Visible = True
        txtCivilStatus.Visible = False
        lblEmergencyNameValue.Visible = True
        txtEmergencyName.Visible = False
        lblRelationshipValue.Visible = True
        txtRelationship.Visible = False
        lblEmergencyContactValue.Visible = True
        txtEmergencyContact.Visible = False
        lblNotesValue.Visible = True
        txtNotes.Visible = False
    End Sub

    Private Sub btnCancelGuidance_Click(sender As Object, e As EventArgs) Handles btnCancelGuidance.Click
        EndGuidanceEditMode()
    End Sub

    Private Sub btnSaveGuidance_Click(sender As Object, e As EventArgs) Handles btnSaveGuidance.Click
        If _guidanceProfileID = 0 Then Return

        ' Basic validation
        If String.IsNullOrWhiteSpace(txtAddress.Text) OrElse String.IsNullOrWhiteSpace(txtContact.Text) OrElse String.IsNullOrWhiteSpace(txtEmergencyName.Text) Then
            MessageBox.Show("Address, Contact Number, and Emergency Contact Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Check changes for audit
            Dim changedFields As New List(Of String)()
            If txtAddress.Text <> If(lblAddressValue.Text = "Not provided", "", lblAddressValue.Text) Then changedFields.Add("Address")
            If txtContact.Text <> If(lblContactValue.Text = "Not provided", "", lblContactValue.Text) Then changedFields.Add("ContactNo")
            If txtEmail.Text <> If(lblEmailValue.Text = "Not provided", "", lblEmailValue.Text) Then changedFields.Add("Email")
            If txtCivilStatus.Text <> If(lblCivilStatusValue.Text = "Not provided", "", lblCivilStatusValue.Text) Then changedFields.Add("CivilStatus")
            If txtEmergencyName.Text <> If(lblEmergencyNameValue.Text = "Not provided", "", lblEmergencyNameValue.Text) Then changedFields.Add("EmergencyContactName")
            If txtRelationship.Text <> If(lblRelationshipValue.Text = "Not provided", "", lblRelationshipValue.Text) Then changedFields.Add("Relationship")
            If txtEmergencyContact.Text <> If(lblEmergencyContactValue.Text = "Not provided", "", lblEmergencyContactValue.Text) Then changedFields.Add("EmergencyContactNo")
            If txtNotes.Text <> If(lblNotesValue.Text = "Not provided", "", lblNotesValue.Text) Then changedFields.Add("AdditionalNotes")

            If changedFields.Count = 0 Then
                EndGuidanceEditMode()
                Return
            End If

            Dim updateQuery = "UPDATE GuidanceStudentProfiles SET Address = @a, ContactNo = @c, Email = @e, CivilStatus = @cs, EmergencyContactName = @en, Relationship = @er, EmergencyContactNo = @ec, AdditionalNotes = @n, UpdatedAt = CURRENT_TIMESTAMP() WHERE GuidanceProfileID = @pid"
            Dim p As New Dictionary(Of String, Object) From {
                {"@a", txtAddress.Text.Trim()},
                {"@c", txtContact.Text.Trim()},
                {"@e", txtEmail.Text.Trim()},
                {"@cs", txtCivilStatus.Text.Trim()},
                {"@en", txtEmergencyName.Text.Trim()},
                {"@er", txtRelationship.Text.Trim()},
                {"@ec", txtEmergencyContact.Text.Trim()},
                {"@n", txtNotes.Text.Trim()},
                {"@pid", _guidanceProfileID}
            }

            db.ExecuteNonQuery(updateQuery, p)

            Dim auditMsg = "Guidance staff edited: " & String.Join(", ", changedFields) & " (Sensitive values protected)."
            Dim histQuery = "INSERT INTO ClearanceHistory (RecordID, ActionBy, ActionType, Remarks, ActionAt) VALUES (@r, @u, 'Updated Profile', @rm, CURRENT_TIMESTAMP())"
            db.ExecuteNonQuery(histQuery, New Dictionary(Of String, Object) From {
                {"@r", TargetRecordID},
                {"@u", AppSession.UserID},
                {"@rm", auditMsg}
            })

            MessageBox.Show("Guidance information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            EndGuidanceEditMode()
            LoadSubmissionDetails()
            LoadTimeline()

        Catch ex As Exception
            MessageBox.Show("Error saving changes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
