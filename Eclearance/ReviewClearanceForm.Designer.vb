<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReviewClearanceForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlCard = New Panel()
        btnClose = New Button()
        lblHeaderTitle = New Label()
        lblHeaderSub = New Label()
        pnlOfficeBadge = New Panel()
        lblOfficeIcon = New Label()
        lblOfficeName = New Label()
        lblOfficeSub = New Label()
        pnlStaffBadge = New Panel()
        lblStaffIcon = New Label()
        lblStaffName = New Label()
        lblStaffRole = New Label()
        lblDateTimeBadge = New Label()
        pnlLeftSection = New Panel()
        pnlGuidanceInfo = New Panel()
        pnlGuidanceBody = New Panel()
        pnlGuidanceNoUpdate = New Panel()
        pnlGuidanceNoUpdateCard = New Panel()
        lblNoUpdateMessage = New Label()
        lblNoUpdateTitle = New Label()
        lblNoUpdateIcon = New Label()
        pnlGuidanceFields = New Panel()
        pnlGuidanceInfoNote = New Panel()
        lblGuidanceInfoNote = New Label()
        lblGuidanceNoteIcon = New Label()
        lblNotesValue = New Label()
        lblNotesTitle = New Label()
        lblEmergencyContactValue = New Label()
        lblEmergencyContactTitle = New Label()
        lblRelationshipValue = New Label()
        lblRelationshipTitle = New Label()
        lblEmergencyNameValue = New Label()
        lblEmergencyNameTitle = New Label()
        lblCivilStatusValue = New Label()
        lblCivilStatusTitle = New Label()
        lblEmailValue = New Label()
        lblEmailTitle = New Label()
        lblContactValue = New Label()
        lblContactTitle = New Label()
        lblAddressValue = New Label()
        lblAddressTitle = New Label()
        pnlGuidanceHeader = New Panel()
        lblGuidanceInfoSubtitle = New Label()
        lblGuidanceInfoTitle = New Label()
        lblGuidanceIcon = New Label()
        pnlDocumentCard = New Panel()
        cmbSubmittedFiles = New ComboBox()
        btnOpenExternal = New Button()
        lblDocFileName = New Label()
        lblDocTitle = New Label()
        lblDocIcon = New Label()
        pnlDocPreview = New Panel()
        picPreview = New PictureBox()
        pnlPdfFallback = New Panel()
        btnOpenPdfCenter = New Button()
        lblPdfSub = New Label()
        lblPdfPrompt = New Label()
        lblPdfIcon = New Label()
        pnlStudentInfoCard = New Panel()
        lblStatusVal = New Label()
        lblStatusTitle = New Label()
        lblFileVal = New Label()
        lblFileTitle = New Label()
        lblDateVal = New Label()
        lblDateTitle = New Label()
        lblReqVal = New Label()
        lblReqTitle = New Label()
        lblOfficeVal = New Label()
        lblOfficeTitle = New Label()
        lblYearVal = New Label()
        lblYearTitle = New Label()
        lblCourseVal = New Label()
        lblCourseTitle = New Label()
        lblStudentNameVal = New Label()
        lblStudentNameTitle = New Label()
        lblStudentNoVal = New Label()
        lblStudentNoTitle = New Label()
        lblInfoTitle = New Label()
        lblInfoIcon = New Label()
        pnlRightSection = New Panel()
        pnlTimelineCard = New Panel()
        lblTimelineEmpty = New Label()
        dgvTimeline = New DataGridView()
        colActivityAction = New DataGridViewTextBoxColumn()
        colActivityDate = New DataGridViewTextBoxColumn()
        colActivityRemarks = New DataGridViewTextBoxColumn()
        lblTimelineHeader = New Label()
        pnlDecisionCard = New Panel()
        btnBackToRequests = New Button()
        btnReject = New Button()
        btnApprove = New Button()
        lblCharCount = New Label()
        txtRemarks = New TextBox()
        lblRemarksTitle = New Label()
        lblDecisionHeader = New Label()
        pnlCurrentStatusCard = New Panel()
        lblStatusSubText = New Label()
        lblStatusBadge = New Label()
        lblStatusIconBig = New Label()
        lblStatusHeader = New Label()
        pnlCard.SuspendLayout()
        pnlOfficeBadge.SuspendLayout()
        pnlStaffBadge.SuspendLayout()
        pnlLeftSection.SuspendLayout()
        pnlGuidanceInfo.SuspendLayout()
        pnlGuidanceBody.SuspendLayout()
        pnlGuidanceNoUpdate.SuspendLayout()
        pnlGuidanceNoUpdateCard.SuspendLayout()
        pnlGuidanceFields.SuspendLayout()
        pnlGuidanceInfoNote.SuspendLayout()
        pnlGuidanceHeader.SuspendLayout()
        pnlDocumentCard.SuspendLayout()
        pnlDocPreview.SuspendLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        pnlPdfFallback.SuspendLayout()
        pnlStudentInfoCard.SuspendLayout()
        pnlRightSection.SuspendLayout()
        pnlTimelineCard.SuspendLayout()
        CType(dgvTimeline, ComponentModel.ISupportInitialize).BeginInit()
        pnlDecisionCard.SuspendLayout()
        pnlCurrentStatusCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlCard.BorderStyle = BorderStyle.FixedSingle
        pnlCard.Controls.Add(btnClose)
        pnlCard.Controls.Add(lblHeaderTitle)
        pnlCard.Controls.Add(lblHeaderSub)
        pnlCard.Controls.Add(pnlOfficeBadge)
        pnlCard.Controls.Add(pnlStaffBadge)
        pnlCard.Controls.Add(lblDateTimeBadge)
        pnlCard.Controls.Add(pnlLeftSection)
        pnlCard.Controls.Add(pnlRightSection)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Margin = New Padding(3, 4, 3, 4)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1143, 1000)
        pnlCard.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F)
        btnClose.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnClose.Location = New Point(1088, 19)
        btnClose.Margin = New Padding(3, 4, 3, 4)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(39, 45)
        btnClose.TabIndex = 0
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(23, 19)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(394, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Review Clearance Submission"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 8.5F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHeaderSub.Location = New Point(25, 61)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(447, 20)
        lblHeaderSub.TabIndex = 2
        lblHeaderSub.Text = "Check submission details and decide whether to approve or reject."
        ' 
        ' pnlOfficeBadge
        ' 
        pnlOfficeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlOfficeBadge.BackColor = Color.White
        pnlOfficeBadge.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeBadge.Controls.Add(lblOfficeIcon)
        pnlOfficeBadge.Controls.Add(lblOfficeName)
        pnlOfficeBadge.Controls.Add(lblOfficeSub)
        pnlOfficeBadge.Location = New Point(606, 19)
        pnlOfficeBadge.Margin = New Padding(3, 4, 3, 4)
        pnlOfficeBadge.Name = "pnlOfficeBadge"
        pnlOfficeBadge.Size = New Size(148, 58)
        pnlOfficeBadge.TabIndex = 3
        ' 
        ' lblOfficeIcon
        ' 
        lblOfficeIcon.AutoSize = True
        lblOfficeIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblOfficeIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblOfficeIcon.Location = New Point(7, 13)
        lblOfficeIcon.Name = "lblOfficeIcon"
        lblOfficeIcon.Size = New Size(39, 27)
        lblOfficeIcon.TabIndex = 0
        lblOfficeIcon.Text = "🏛"
        ' 
        ' lblOfficeName
        ' 
        lblOfficeName.AutoEllipsis = True
        lblOfficeName.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblOfficeName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeName.Location = New Point(45, 8)
        lblOfficeName.Name = "lblOfficeName"
        lblOfficeName.Size = New Size(105, 20)
        lblOfficeName.TabIndex = 1
        lblOfficeName.Text = "Assigned Office"
        ' 
        ' lblOfficeSub
        ' 
        lblOfficeSub.AutoSize = True
        lblOfficeSub.Font = New Font("Segoe UI", 7F)
        lblOfficeSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeSub.Location = New Point(46, 29)
        lblOfficeSub.Name = "lblOfficeSub"
        lblOfficeSub.Size = New Size(86, 15)
        lblOfficeSub.TabIndex = 2
        lblOfficeSub.Text = "Clearing Office"
        ' 
        ' pnlStaffBadge
        ' 
        pnlStaffBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlStaffBadge.BackColor = Color.White
        pnlStaffBadge.BorderStyle = BorderStyle.FixedSingle
        pnlStaffBadge.Controls.Add(lblStaffIcon)
        pnlStaffBadge.Controls.Add(lblStaffName)
        pnlStaffBadge.Controls.Add(lblStaffRole)
        pnlStaffBadge.Location = New Point(763, 19)
        pnlStaffBadge.Margin = New Padding(3, 4, 3, 4)
        pnlStaffBadge.Name = "pnlStaffBadge"
        pnlStaffBadge.Size = New Size(148, 58)
        pnlStaffBadge.TabIndex = 4
        ' 
        ' lblStaffIcon
        ' 
        lblStaffIcon.AutoSize = True
        lblStaffIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblStaffIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblStaffIcon.Location = New Point(7, 13)
        lblStaffIcon.Name = "lblStaffIcon"
        lblStaffIcon.Size = New Size(39, 27)
        lblStaffIcon.TabIndex = 0
        lblStaffIcon.Text = "👤"
        ' 
        ' lblStaffName
        ' 
        lblStaffName.AutoEllipsis = True
        lblStaffName.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStaffName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStaffName.Location = New Point(42, 8)
        lblStaffName.Name = "lblStaffName"
        lblStaffName.Size = New Size(105, 20)
        lblStaffName.TabIndex = 1
        lblStaffName.Text = "Staff Member"
        ' 
        ' lblStaffRole
        ' 
        lblStaffRole.AutoSize = True
        lblStaffRole.Font = New Font("Segoe UI", 7F)
        lblStaffRole.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStaffRole.Location = New Point(42, 29)
        lblStaffRole.Name = "lblStaffRole"
        lblStaffRole.Size = New Size(90, 15)
        lblStaffRole.TabIndex = 2
        lblStaffRole.Text = "Clearing Officer"
        ' 
        ' lblDateTimeBadge
        ' 
        lblDateTimeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTimeBadge.Font = New Font("Segoe UI", 7.5F)
        lblDateTimeBadge.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTimeBadge.Location = New Point(919, 19)
        lblDateTimeBadge.Name = "lblDateTimeBadge"
        lblDateTimeBadge.Size = New Size(160, 59)
        lblDateTimeBadge.TabIndex = 5
        lblDateTimeBadge.Text = "📅 Today"
        lblDateTimeBadge.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlLeftSection
        ' 
        pnlLeftSection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLeftSection.Controls.Add(pnlGuidanceInfo)
        pnlLeftSection.Controls.Add(pnlDocumentCard)
        pnlLeftSection.Controls.Add(pnlStudentInfoCard)
        pnlLeftSection.Location = New Point(23, 96)
        pnlLeftSection.Margin = New Padding(3, 4, 3, 4)
        pnlLeftSection.Name = "pnlLeftSection"
        pnlLeftSection.Size = New Size(709, 878)
        pnlLeftSection.TabIndex = 6
        ' 
        ' pnlGuidanceInfo
        ' 
        pnlGuidanceInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceInfo.BackColor = Color.White
        pnlGuidanceInfo.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceInfo.Controls.Add(pnlGuidanceBody)
        pnlGuidanceInfo.Controls.Add(pnlGuidanceHeader)
        pnlGuidanceInfo.Location = New Point(0, 229)
        pnlGuidanceInfo.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceInfo.Name = "pnlGuidanceInfo"
        pnlGuidanceInfo.Size = New Size(708, 648)
        pnlGuidanceInfo.TabIndex = 2
        pnlGuidanceInfo.Visible = False
        ' 
        ' pnlGuidanceBody
        ' 
        pnlGuidanceBody.BackColor = Color.White
        pnlGuidanceBody.Controls.Add(pnlGuidanceNoUpdate)
        pnlGuidanceBody.Controls.Add(pnlGuidanceFields)
        pnlGuidanceBody.Dock = DockStyle.Fill
        pnlGuidanceBody.Location = New Point(0, 75)
        pnlGuidanceBody.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceBody.Name = "pnlGuidanceBody"
        pnlGuidanceBody.Size = New Size(706, 571)
        pnlGuidanceBody.TabIndex = 1
        ' 
        ' pnlGuidanceNoUpdate
        ' 
        pnlGuidanceNoUpdate.BackColor = Color.White
        pnlGuidanceNoUpdate.Controls.Add(pnlGuidanceNoUpdateCard)
        pnlGuidanceNoUpdate.Location = New Point(0, 0)
        pnlGuidanceNoUpdate.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceNoUpdate.Name = "pnlGuidanceNoUpdate"
        pnlGuidanceNoUpdate.Padding = New Padding(23, 27, 23, 27)
        pnlGuidanceNoUpdate.Size = New Size(706, 571)
        pnlGuidanceNoUpdate.TabIndex = 1
        pnlGuidanceNoUpdate.Visible = False
        ' 
        ' pnlGuidanceNoUpdateCard
        ' 
        pnlGuidanceNoUpdateCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceNoUpdateCard.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlGuidanceNoUpdateCard.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceNoUpdateCard.Controls.Add(lblNoUpdateMessage)
        pnlGuidanceNoUpdateCard.Controls.Add(lblNoUpdateTitle)
        pnlGuidanceNoUpdateCard.Controls.Add(lblNoUpdateIcon)
        pnlGuidanceNoUpdateCard.Location = New Point(46, 53)
        pnlGuidanceNoUpdateCard.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceNoUpdateCard.Name = "pnlGuidanceNoUpdateCard"
        pnlGuidanceNoUpdateCard.Size = New Size(1083, 213)
        pnlGuidanceNoUpdateCard.TabIndex = 0
        ' 
        ' lblNoUpdateMessage
        ' 
        lblNoUpdateMessage.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblNoUpdateMessage.Font = New Font("Segoe UI", 9.5F)
        lblNoUpdateMessage.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblNoUpdateMessage.Location = New Point(73, 69)
        lblNoUpdateMessage.Name = "lblNoUpdateMessage"
        lblNoUpdateMessage.Size = New Size(1401, 113)
        lblNoUpdateMessage.TabIndex = 2
        lblNoUpdateMessage.Text = "Personal information update is not required for this student." & vbCrLf & vbCrLf & "Please review and evaluate the student's Guidance clearance requirement."
        ' 
        ' lblNoUpdateTitle
        ' 
        lblNoUpdateTitle.AutoSize = True
        lblNoUpdateTitle.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
        lblNoUpdateTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNoUpdateTitle.Location = New Point(73, 27)
        lblNoUpdateTitle.Name = "lblNoUpdateTitle"
        lblNoUpdateTitle.Size = New Size(266, 25)
        lblNoUpdateTitle.TabIndex = 1
        lblNoUpdateTitle.Text = "Guidance Clearance Evaluation"
        ' 
        ' lblNoUpdateIcon
        ' 
        lblNoUpdateIcon.AutoSize = True
        lblNoUpdateIcon.Font = New Font("Segoe UI Emoji", 20F)
        lblNoUpdateIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblNoUpdateIcon.Location = New Point(23, 32)
        lblNoUpdateIcon.Name = "lblNoUpdateIcon"
        lblNoUpdateIcon.Size = New Size(67, 46)
        lblNoUpdateIcon.TabIndex = 0
        lblNoUpdateIcon.Text = "ℹ"
        ' 
        ' pnlGuidanceFields
        ' 
        pnlGuidanceFields.BackColor = Color.White
        pnlGuidanceFields.Controls.Add(pnlGuidanceInfoNote)
        pnlGuidanceFields.Controls.Add(lblNotesValue)
        pnlGuidanceFields.Controls.Add(lblNotesTitle)
        pnlGuidanceFields.Controls.Add(lblEmergencyContactValue)
        pnlGuidanceFields.Controls.Add(lblEmergencyContactTitle)
        pnlGuidanceFields.Controls.Add(lblRelationshipValue)
        pnlGuidanceFields.Controls.Add(lblRelationshipTitle)
        pnlGuidanceFields.Controls.Add(lblEmergencyNameValue)
        pnlGuidanceFields.Controls.Add(lblEmergencyNameTitle)
        pnlGuidanceFields.Controls.Add(lblCivilStatusValue)
        pnlGuidanceFields.Controls.Add(lblCivilStatusTitle)
        pnlGuidanceFields.Controls.Add(lblEmailValue)
        pnlGuidanceFields.Controls.Add(lblEmailTitle)
        pnlGuidanceFields.Controls.Add(lblContactValue)
        pnlGuidanceFields.Controls.Add(lblContactTitle)
        pnlGuidanceFields.Controls.Add(lblAddressValue)
        pnlGuidanceFields.Controls.Add(lblAddressTitle)
        pnlGuidanceFields.Dock = DockStyle.Fill
        pnlGuidanceFields.Location = New Point(0, 0)
        pnlGuidanceFields.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceFields.Name = "pnlGuidanceFields"
        pnlGuidanceFields.Padding = New Padding(23, 27, 23, 27)
        pnlGuidanceFields.Size = New Size(706, 571)
        pnlGuidanceFields.TabIndex = 0
        ' 
        ' pnlGuidanceInfoNote
        ' 
        pnlGuidanceInfoNote.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceInfoNote.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        pnlGuidanceInfoNote.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceInfoNote.Controls.Add(lblGuidanceInfoNote)
        pnlGuidanceInfoNote.Controls.Add(lblGuidanceNoteIcon)
        pnlGuidanceInfoNote.Location = New Point(46, 891)
        pnlGuidanceInfoNote.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceInfoNote.Name = "pnlGuidanceInfoNote"
        pnlGuidanceInfoNote.Padding = New Padding(9, 8, 9, 8)
        pnlGuidanceInfoNote.Size = New Size(1083, 69)
        pnlGuidanceInfoNote.TabIndex = 16
        ' 
        ' lblGuidanceInfoNote
        ' 
        lblGuidanceInfoNote.Font = New Font("Segoe UI", 8.25F)
        lblGuidanceInfoNote.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblGuidanceInfoNote.Location = New Point(39, 11)
        lblGuidanceInfoNote.Name = "lblGuidanceInfoNote"
        lblGuidanceInfoNote.Size = New Size(599, 45)
        lblGuidanceInfoNote.TabIndex = 1
        lblGuidanceInfoNote.Text = "This information was provided by the student as part of the Guidance Office requirement." & vbCrLf & "Please review the details before approving or rejecting this clearance."
        ' 
        ' lblGuidanceNoteIcon
        ' 
        lblGuidanceNoteIcon.AutoSize = True
        lblGuidanceNoteIcon.Font = New Font("Segoe UI Emoji", 13F)
        lblGuidanceNoteIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblGuidanceNoteIcon.Location = New Point(9, 16)
        lblGuidanceNoteIcon.Name = "lblGuidanceNoteIcon"
        lblGuidanceNoteIcon.Size = New Size(43, 30)
        lblGuidanceNoteIcon.TabIndex = 0
        lblGuidanceNoteIcon.Text = "ℹ"
        ' 
        ' lblNotesValue
        ' 
        lblNotesValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblNotesValue.BorderStyle = BorderStyle.FixedSingle
        lblNotesValue.Font = New Font("Segoe UI", 9F)
        lblNotesValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNotesValue.Location = New Point(360, 283)
        lblNotesValue.Name = "lblNotesValue"
        lblNotesValue.Padding = New Padding(9, 5, 9, 5)
        lblNotesValue.Size = New Size(314, 45)
        lblNotesValue.TabIndex = 15
        lblNotesValue.Text = "Not provided"
        lblNotesValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNotesTitle
        ' 
        lblNotesTitle.AutoSize = True
        lblNotesTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblNotesTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNotesTitle.Location = New Point(383, 285)
        lblNotesTitle.Name = "lblNotesTitle"
        lblNotesTitle.Size = New Size(124, 20)
        lblNotesTitle.TabIndex = 14
        lblNotesTitle.Text = "Additional Notes"
        ' 
        ' lblEmergencyContactValue
        ' 
        lblEmergencyContactValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmergencyContactValue.BorderStyle = BorderStyle.FixedSingle
        lblEmergencyContactValue.Font = New Font("Segoe UI", 9F)
        lblEmergencyContactValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyContactValue.Location = New Point(360, 203)
        lblEmergencyContactValue.Name = "lblEmergencyContactValue"
        lblEmergencyContactValue.Padding = New Padding(9, 5, 9, 5)
        lblEmergencyContactValue.Size = New Size(314, 45)
        lblEmergencyContactValue.TabIndex = 13
        lblEmergencyContactValue.Text = "Not provided"
        lblEmergencyContactValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmergencyContactTitle
        ' 
        lblEmergencyContactTitle.AutoSize = True
        lblEmergencyContactTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyContactTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyContactTitle.Location = New Point(383, 205)
        lblEmergencyContactTitle.Name = "lblEmergencyContactTitle"
        lblEmergencyContactTitle.Size = New Size(202, 20)
        lblEmergencyContactTitle.TabIndex = 12
        lblEmergencyContactTitle.Text = "Emergency Contact Number"
        ' 
        ' lblRelationshipValue
        ' 
        lblRelationshipValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblRelationshipValue.BorderStyle = BorderStyle.FixedSingle
        lblRelationshipValue.Font = New Font("Segoe UI", 9F)
        lblRelationshipValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRelationshipValue.Location = New Point(360, 123)
        lblRelationshipValue.Name = "lblRelationshipValue"
        lblRelationshipValue.Padding = New Padding(9, 5, 9, 5)
        lblRelationshipValue.Size = New Size(314, 45)
        lblRelationshipValue.TabIndex = 11
        lblRelationshipValue.Text = "Not provided"
        lblRelationshipValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblRelationshipTitle
        ' 
        lblRelationshipTitle.AutoSize = True
        lblRelationshipTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblRelationshipTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRelationshipTitle.Location = New Point(383, 125)
        lblRelationshipTitle.Name = "lblRelationshipTitle"
        lblRelationshipTitle.Size = New Size(93, 20)
        lblRelationshipTitle.TabIndex = 10
        lblRelationshipTitle.Text = "Relationship"
        ' 
        ' lblEmergencyNameValue
        ' 
        lblEmergencyNameValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmergencyNameValue.BorderStyle = BorderStyle.FixedSingle
        lblEmergencyNameValue.Font = New Font("Segoe UI", 9F)
        lblEmergencyNameValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyNameValue.Location = New Point(360, 43)
        lblEmergencyNameValue.Name = "lblEmergencyNameValue"
        lblEmergencyNameValue.Padding = New Padding(9, 5, 9, 5)
        lblEmergencyNameValue.Size = New Size(314, 45)
        lblEmergencyNameValue.TabIndex = 9
        lblEmergencyNameValue.Text = "Not provided"
        lblEmergencyNameValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmergencyNameTitle
        ' 
        lblEmergencyNameTitle.AutoSize = True
        lblEmergencyNameTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyNameTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyNameTitle.Location = New Point(383, 45)
        lblEmergencyNameTitle.Name = "lblEmergencyNameTitle"
        lblEmergencyNameTitle.Size = New Size(186, 20)
        lblEmergencyNameTitle.TabIndex = 8
        lblEmergencyNameTitle.Text = "Emergency Contact Name"
        ' 
        ' lblCivilStatusValue
        ' 
        lblCivilStatusValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblCivilStatusValue.BorderStyle = BorderStyle.FixedSingle
        lblCivilStatusValue.Font = New Font("Segoe UI", 9F)
        lblCivilStatusValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCivilStatusValue.Location = New Point(23, 283)
        lblCivilStatusValue.Name = "lblCivilStatusValue"
        lblCivilStatusValue.Padding = New Padding(9, 5, 9, 5)
        lblCivilStatusValue.Size = New Size(314, 45)
        lblCivilStatusValue.TabIndex = 7
        lblCivilStatusValue.Text = "Not provided"
        lblCivilStatusValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCivilStatusTitle
        ' 
        lblCivilStatusTitle.AutoSize = True
        lblCivilStatusTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblCivilStatusTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCivilStatusTitle.Location = New Point(46, 285)
        lblCivilStatusTitle.Name = "lblCivilStatusTitle"
        lblCivilStatusTitle.Size = New Size(83, 20)
        lblCivilStatusTitle.TabIndex = 6
        lblCivilStatusTitle.Text = "Civil Status"
        ' 
        ' lblEmailValue
        ' 
        lblEmailValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmailValue.BorderStyle = BorderStyle.FixedSingle
        lblEmailValue.Font = New Font("Segoe UI", 9F)
        lblEmailValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmailValue.Location = New Point(23, 203)
        lblEmailValue.Name = "lblEmailValue"
        lblEmailValue.Padding = New Padding(9, 5, 9, 5)
        lblEmailValue.Size = New Size(314, 45)
        lblEmailValue.TabIndex = 5
        lblEmailValue.Text = "Not provided"
        lblEmailValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmailTitle
        ' 
        lblEmailTitle.AutoSize = True
        lblEmailTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmailTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmailTitle.Location = New Point(46, 205)
        lblEmailTitle.Name = "lblEmailTitle"
        lblEmailTitle.Size = New Size(104, 20)
        lblEmailTitle.TabIndex = 4
        lblEmailTitle.Text = "Email Address"
        ' 
        ' lblContactValue
        ' 
        lblContactValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblContactValue.BorderStyle = BorderStyle.FixedSingle
        lblContactValue.Font = New Font("Segoe UI", 9F)
        lblContactValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblContactValue.Location = New Point(23, 123)
        lblContactValue.Name = "lblContactValue"
        lblContactValue.Padding = New Padding(9, 5, 9, 5)
        lblContactValue.Size = New Size(314, 45)
        lblContactValue.TabIndex = 3
        lblContactValue.Text = "Not provided"
        lblContactValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblContactTitle
        ' 
        lblContactTitle.AutoSize = True
        lblContactTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblContactTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblContactTitle.Location = New Point(46, 125)
        lblContactTitle.Name = "lblContactTitle"
        lblContactTitle.Size = New Size(122, 20)
        lblContactTitle.TabIndex = 2
        lblContactTitle.Text = "Contact Number"
        ' 
        ' lblAddressValue
        ' 
        lblAddressValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblAddressValue.BorderStyle = BorderStyle.FixedSingle
        lblAddressValue.Font = New Font("Segoe UI", 9F)
        lblAddressValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAddressValue.Location = New Point(23, 43)
        lblAddressValue.Name = "lblAddressValue"
        lblAddressValue.Padding = New Padding(9, 5, 9, 5)
        lblAddressValue.Size = New Size(314, 45)
        lblAddressValue.TabIndex = 1
        lblAddressValue.Text = "Not provided"
        lblAddressValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblAddressTitle
        ' 
        lblAddressTitle.AutoSize = True
        lblAddressTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblAddressTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAddressTitle.Location = New Point(46, 45)
        lblAddressTitle.Name = "lblAddressTitle"
        lblAddressTitle.Size = New Size(119, 20)
        lblAddressTitle.TabIndex = 0
        lblAddressTitle.Text = "Current Address"
        ' 
        ' pnlGuidanceHeader
        ' 
        pnlGuidanceHeader.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        pnlGuidanceHeader.Controls.Add(lblGuidanceInfoSubtitle)
        pnlGuidanceHeader.Controls.Add(lblGuidanceInfoTitle)
        pnlGuidanceHeader.Controls.Add(lblGuidanceIcon)
        pnlGuidanceHeader.Dock = DockStyle.Top
        pnlGuidanceHeader.Location = New Point(0, 0)
        pnlGuidanceHeader.Margin = New Padding(3, 4, 3, 4)
        pnlGuidanceHeader.Name = "pnlGuidanceHeader"
        pnlGuidanceHeader.Size = New Size(706, 75)
        pnlGuidanceHeader.TabIndex = 0
        ' 
        ' lblGuidanceInfoSubtitle
        ' 
        lblGuidanceInfoSubtitle.AutoSize = True
        lblGuidanceInfoSubtitle.Font = New Font("Segoe UI", 8F)
        lblGuidanceInfoSubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblGuidanceInfoSubtitle.Location = New Point(51, 39)
        lblGuidanceInfoSubtitle.Name = "lblGuidanceInfoSubtitle"
        lblGuidanceInfoSubtitle.Size = New Size(517, 19)
        lblGuidanceInfoSubtitle.TabIndex = 2
        lblGuidanceInfoSubtitle.Text = "Below is the updated information submitted by the student for Guidance clearance."
        ' 
        ' lblGuidanceInfoTitle
        ' 
        lblGuidanceInfoTitle.AutoSize = True
        lblGuidanceInfoTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblGuidanceInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblGuidanceInfoTitle.Location = New Point(50, 12)
        lblGuidanceInfoTitle.Name = "lblGuidanceInfoTitle"
        lblGuidanceInfoTitle.Size = New Size(266, 25)
        lblGuidanceInfoTitle.TabIndex = 1
        lblGuidanceInfoTitle.Text = "Guidance Information Update"
        ' 
        ' lblGuidanceIcon
        ' 
        lblGuidanceIcon.AutoSize = True
        lblGuidanceIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblGuidanceIcon.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        lblGuidanceIcon.Location = New Point(16, 16)
        lblGuidanceIcon.Name = "lblGuidanceIcon"
        lblGuidanceIcon.Size = New Size(47, 32)
        lblGuidanceIcon.TabIndex = 0
        lblGuidanceIcon.Text = "📄"
        ' 
        ' pnlDocumentCard
        ' 
        pnlDocumentCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDocumentCard.BackColor = Color.White
        pnlDocumentCard.BorderStyle = BorderStyle.FixedSingle
        pnlDocumentCard.Controls.Add(cmbSubmittedFiles)
        pnlDocumentCard.Controls.Add(btnOpenExternal)
        pnlDocumentCard.Controls.Add(lblDocFileName)
        pnlDocumentCard.Controls.Add(lblDocTitle)
        pnlDocumentCard.Controls.Add(lblDocIcon)
        pnlDocumentCard.Controls.Add(pnlDocPreview)
        pnlDocumentCard.Location = New Point(0, 229)
        pnlDocumentCard.Margin = New Padding(3, 4, 3, 4)
        pnlDocumentCard.Name = "pnlDocumentCard"
        pnlDocumentCard.Padding = New Padding(16, 19, 16, 19)
        pnlDocumentCard.Size = New Size(708, 648)
        pnlDocumentCard.TabIndex = 1
        ' 
        ' cmbSubmittedFiles
        ' 
        cmbSubmittedFiles.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbSubmittedFiles.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubmittedFiles.Font = New Font("Segoe UI", 8.5F)
        cmbSubmittedFiles.FormattingEnabled = True
        cmbSubmittedFiles.Location = New Point(303, 16)
        cmbSubmittedFiles.Margin = New Padding(3, 4, 3, 4)
        cmbSubmittedFiles.Name = "cmbSubmittedFiles"
        cmbSubmittedFiles.Size = New Size(245, 27)
        cmbSubmittedFiles.TabIndex = 4
        cmbSubmittedFiles.Visible = False
        ' 
        ' btnOpenExternal
        ' 
        btnOpenExternal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenExternal.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        btnOpenExternal.Cursor = Cursors.Hand
        btnOpenExternal.FlatAppearance.BorderSize = 0
        btnOpenExternal.FlatStyle = FlatStyle.Flat
        btnOpenExternal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        btnOpenExternal.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnOpenExternal.Location = New Point(560, 13)
        btnOpenExternal.Margin = New Padding(3, 4, 3, 4)
        btnOpenExternal.Name = "btnOpenExternal"
        btnOpenExternal.Size = New Size(133, 37)
        btnOpenExternal.TabIndex = 3
        btnOpenExternal.Text = "↗ Open Document"
        btnOpenExternal.UseVisualStyleBackColor = False
        ' 
        ' lblDocFileName
        ' 
        lblDocFileName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDocFileName.AutoEllipsis = True
        lblDocFileName.Font = New Font("Segoe UI", 8F)
        lblDocFileName.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDocFileName.Location = New Point(219, 23)
        lblDocFileName.Name = "lblDocFileName"
        lblDocFileName.Size = New Size(359, 21)
        lblDocFileName.TabIndex = 2
        lblDocFileName.Text = "filename.png"
        ' 
        ' lblDocTitle
        ' 
        lblDocTitle.AutoSize = True
        lblDocTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblDocTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDocTitle.Location = New Point(41, 19)
        lblDocTitle.Name = "lblDocTitle"
        lblDocTitle.Size = New Size(184, 23)
        lblDocTitle.TabIndex = 1
        lblDocTitle.Text = "Submitted Document"
        ' 
        ' lblDocIcon
        ' 
        lblDocIcon.AutoSize = True
        lblDocIcon.Font = New Font("Segoe UI Emoji", 11F)
        lblDocIcon.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblDocIcon.Location = New Point(16, 19)
        lblDocIcon.Name = "lblDocIcon"
        lblDocIcon.Size = New Size(38, 26)
        lblDocIcon.TabIndex = 0
        lblDocIcon.Text = "📄"
        ' 
        ' pnlDocPreview
        ' 
        pnlDocPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDocPreview.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlDocPreview.BorderStyle = BorderStyle.FixedSingle
        pnlDocPreview.Controls.Add(picPreview)
        pnlDocPreview.Controls.Add(pnlPdfFallback)
        pnlDocPreview.Location = New Point(16, 61)
        pnlDocPreview.Margin = New Padding(3, 4, 3, 4)
        pnlDocPreview.Name = "pnlDocPreview"
        pnlDocPreview.Size = New Size(674, 566)
        pnlDocPreview.TabIndex = 4
        ' 
        ' picPreview
        ' 
        picPreview.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        picPreview.Dock = DockStyle.Fill
        picPreview.Location = New Point(0, 0)
        picPreview.Margin = New Padding(3, 4, 3, 4)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(672, 564)
        picPreview.SizeMode = PictureBoxSizeMode.Zoom
        picPreview.TabIndex = 0
        picPreview.TabStop = False
        ' 
        ' pnlPdfFallback
        ' 
        pnlPdfFallback.Anchor = AnchorStyles.None
        pnlPdfFallback.BackColor = Color.Transparent
        pnlPdfFallback.Controls.Add(btnOpenPdfCenter)
        pnlPdfFallback.Controls.Add(lblPdfSub)
        pnlPdfFallback.Controls.Add(lblPdfPrompt)
        pnlPdfFallback.Controls.Add(lblPdfIcon)
        pnlPdfFallback.Location = New Point(176, 161)
        pnlPdfFallback.Margin = New Padding(3, 4, 3, 4)
        pnlPdfFallback.Name = "pnlPdfFallback"
        pnlPdfFallback.Size = New Size(320, 240)
        pnlPdfFallback.TabIndex = 1
        pnlPdfFallback.Visible = False
        ' 
        ' btnOpenPdfCenter
        ' 
        btnOpenPdfCenter.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnOpenPdfCenter.Cursor = Cursors.Hand
        btnOpenPdfCenter.FlatAppearance.BorderSize = 0
        btnOpenPdfCenter.FlatStyle = FlatStyle.Flat
        btnOpenPdfCenter.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnOpenPdfCenter.ForeColor = Color.White
        btnOpenPdfCenter.Location = New Point(46, 168)
        btnOpenPdfCenter.Margin = New Padding(3, 4, 3, 4)
        btnOpenPdfCenter.Name = "btnOpenPdfCenter"
        btnOpenPdfCenter.Size = New Size(229, 48)
        btnOpenPdfCenter.TabIndex = 3
        btnOpenPdfCenter.Text = "Open in Default Viewer"
        btnOpenPdfCenter.UseVisualStyleBackColor = False
        ' 
        ' lblPdfSub
        ' 
        lblPdfSub.Font = New Font("Segoe UI", 7.5F)
        lblPdfSub.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblPdfSub.Location = New Point(11, 117)
        lblPdfSub.Name = "lblPdfSub"
        lblPdfSub.Size = New Size(297, 37)
        lblPdfSub.TabIndex = 2
        lblPdfSub.Text = "Click below to inspect the original PDF document."
        lblPdfSub.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPdfPrompt
        ' 
        lblPdfPrompt.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblPdfPrompt.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblPdfPrompt.Location = New Point(11, 85)
        lblPdfPrompt.Name = "lblPdfPrompt"
        lblPdfPrompt.Size = New Size(297, 27)
        lblPdfPrompt.TabIndex = 1
        lblPdfPrompt.Text = "PDF Document Attached"
        lblPdfPrompt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPdfIcon
        ' 
        lblPdfIcon.Font = New Font("Segoe UI Emoji", 30F)
        lblPdfIcon.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        lblPdfIcon.Location = New Point(126, 11)
        lblPdfIcon.Name = "lblPdfIcon"
        lblPdfIcon.Size = New Size(69, 67)
        lblPdfIcon.TabIndex = 0
        lblPdfIcon.Text = "📄"
        lblPdfIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlStudentInfoCard
        ' 
        pnlStudentInfoCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudentInfoCard.BackColor = Color.White
        pnlStudentInfoCard.BorderStyle = BorderStyle.FixedSingle
        pnlStudentInfoCard.Controls.Add(lblStatusVal)
        pnlStudentInfoCard.Controls.Add(lblStatusTitle)
        pnlStudentInfoCard.Controls.Add(lblFileVal)
        pnlStudentInfoCard.Controls.Add(lblFileTitle)
        pnlStudentInfoCard.Controls.Add(lblDateVal)
        pnlStudentInfoCard.Controls.Add(lblDateTitle)
        pnlStudentInfoCard.Controls.Add(lblReqVal)
        pnlStudentInfoCard.Controls.Add(lblReqTitle)
        pnlStudentInfoCard.Controls.Add(lblOfficeVal)
        pnlStudentInfoCard.Controls.Add(lblOfficeTitle)
        pnlStudentInfoCard.Controls.Add(lblYearVal)
        pnlStudentInfoCard.Controls.Add(lblYearTitle)
        pnlStudentInfoCard.Controls.Add(lblCourseVal)
        pnlStudentInfoCard.Controls.Add(lblCourseTitle)
        pnlStudentInfoCard.Controls.Add(lblStudentNameVal)
        pnlStudentInfoCard.Controls.Add(lblStudentNameTitle)
        pnlStudentInfoCard.Controls.Add(lblStudentNoVal)
        pnlStudentInfoCard.Controls.Add(lblStudentNoTitle)
        pnlStudentInfoCard.Controls.Add(lblInfoTitle)
        pnlStudentInfoCard.Controls.Add(lblInfoIcon)
        pnlStudentInfoCard.Location = New Point(0, 0)
        pnlStudentInfoCard.Margin = New Padding(3, 4, 3, 4)
        pnlStudentInfoCard.Name = "pnlStudentInfoCard"
        pnlStudentInfoCard.Padding = New Padding(16, 19, 16, 19)
        pnlStudentInfoCard.Size = New Size(708, 213)
        pnlStudentInfoCard.TabIndex = 0
        ' 
        ' lblStatusVal
        ' 
        lblStatusVal.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblStatusVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStatusVal.ForeColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        lblStatusVal.Location = New Point(457, 163)
        lblStatusVal.Name = "lblStatusVal"
        lblStatusVal.Size = New Size(126, 29)
        lblStatusVal.TabIndex = 19
        lblStatusVal.Text = "Under Review"
        lblStatusVal.TextAlign = ContentAlignment.MiddleCenter
        lblStatusVal.Visible = False
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Segoe UI", 8F)
        lblStatusTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatusTitle.Location = New Point(354, 168)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(54, 19)
        lblStatusTitle.TabIndex = 18
        lblStatusTitle.Text = "Status :"
        lblStatusTitle.Visible = False
        ' 
        ' lblFileVal
        ' 
        lblFileVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFileVal.AutoEllipsis = True
        lblFileVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblFileVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblFileVal.Location = New Point(457, 168)
        lblFileVal.Name = "lblFileVal"
        lblFileVal.Size = New Size(233, 20)
        lblFileVal.TabIndex = 17
        lblFileVal.Text = "-"
        ' 
        ' lblFileTitle
        ' 
        lblFileTitle.AutoSize = True
        lblFileTitle.Font = New Font("Segoe UI", 8F)
        lblFileTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFileTitle.Location = New Point(354, 168)
        lblFileTitle.Name = "lblFileTitle"
        lblFileTitle.Size = New Size(72, 19)
        lblFileTitle.TabIndex = 16
        lblFileTitle.Text = "File Name:"
        ' 
        ' lblDateVal
        ' 
        lblDateVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDateVal.AutoEllipsis = True
        lblDateVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblDateVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDateVal.Location = New Point(457, 131)
        lblDateVal.Name = "lblDateVal"
        lblDateVal.Size = New Size(233, 20)
        lblDateVal.TabIndex = 15
        lblDateVal.Text = "-"
        ' 
        ' lblDateTitle
        ' 
        lblDateTitle.AutoSize = True
        lblDateTitle.Font = New Font("Segoe UI", 8F)
        lblDateTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTitle.Location = New Point(354, 131)
        lblDateTitle.Name = "lblDateTitle"
        lblDateTitle.Size = New Size(93, 19)
        lblDateTitle.TabIndex = 14
        lblDateTitle.Text = "Submitted At:"
        ' 
        ' lblReqVal
        ' 
        lblReqVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblReqVal.AutoEllipsis = True
        lblReqVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblReqVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblReqVal.Location = New Point(457, 93)
        lblReqVal.Name = "lblReqVal"
        lblReqVal.Size = New Size(233, 20)
        lblReqVal.TabIndex = 13
        lblReqVal.Text = "-"
        ' 
        ' lblReqTitle
        ' 
        lblReqTitle.AutoSize = True
        lblReqTitle.Font = New Font("Segoe UI", 8F)
        lblReqTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblReqTitle.Location = New Point(354, 93)
        lblReqTitle.Name = "lblReqTitle"
        lblReqTitle.Size = New Size(90, 19)
        lblReqTitle.TabIndex = 12
        lblReqTitle.Text = "Requirement:"
        ' 
        ' lblOfficeVal
        ' 
        lblOfficeVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOfficeVal.AutoEllipsis = True
        lblOfficeVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblOfficeVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeVal.Location = New Point(457, 56)
        lblOfficeVal.Name = "lblOfficeVal"
        lblOfficeVal.Size = New Size(233, 20)
        lblOfficeVal.TabIndex = 11
        lblOfficeVal.Text = "-"
        ' 
        ' lblOfficeTitle
        ' 
        lblOfficeTitle.AutoSize = True
        lblOfficeTitle.Font = New Font("Segoe UI", 8F)
        lblOfficeTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeTitle.Location = New Point(354, 56)
        lblOfficeTitle.Name = "lblOfficeTitle"
        lblOfficeTitle.Size = New Size(47, 19)
        lblOfficeTitle.TabIndex = 10
        lblOfficeTitle.Text = "Office:"
        ' 
        ' lblYearVal
        ' 
        lblYearVal.AutoEllipsis = True
        lblYearVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblYearVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblYearVal.Location = New Point(126, 168)
        lblYearVal.Name = "lblYearVal"
        lblYearVal.Size = New Size(206, 20)
        lblYearVal.TabIndex = 9
        lblYearVal.Text = "-"
        ' 
        ' lblYearTitle
        ' 
        lblYearTitle.AutoSize = True
        lblYearTitle.Font = New Font("Segoe UI", 8F)
        lblYearTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblYearTitle.Location = New Point(16, 168)
        lblYearTitle.Name = "lblYearTitle"
        lblYearTitle.Size = New Size(73, 19)
        lblYearTitle.TabIndex = 8
        lblYearTitle.Text = "Year Level:"
        ' 
        ' lblCourseVal
        ' 
        lblCourseVal.AutoEllipsis = True
        lblCourseVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblCourseVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCourseVal.Location = New Point(126, 131)
        lblCourseVal.Name = "lblCourseVal"
        lblCourseVal.Size = New Size(206, 20)
        lblCourseVal.TabIndex = 7
        lblCourseVal.Text = "-"
        ' 
        ' lblCourseTitle
        ' 
        lblCourseTitle.AutoSize = True
        lblCourseTitle.Font = New Font("Segoe UI", 8F)
        lblCourseTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblCourseTitle.Location = New Point(16, 131)
        lblCourseTitle.Name = "lblCourseTitle"
        lblCourseTitle.Size = New Size(55, 19)
        lblCourseTitle.TabIndex = 6
        lblCourseTitle.Text = "Course:"
        ' 
        ' lblStudentNameVal
        ' 
        lblStudentNameVal.AutoEllipsis = True
        lblStudentNameVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStudentNameVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentNameVal.Location = New Point(126, 93)
        lblStudentNameVal.Name = "lblStudentNameVal"
        lblStudentNameVal.Size = New Size(206, 20)
        lblStudentNameVal.TabIndex = 5
        lblStudentNameVal.Text = "-"
        ' 
        ' lblStudentNameTitle
        ' 
        lblStudentNameTitle.AutoSize = True
        lblStudentNameTitle.Font = New Font("Segoe UI", 8F)
        lblStudentNameTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNameTitle.Location = New Point(16, 93)
        lblStudentNameTitle.Name = "lblStudentNameTitle"
        lblStudentNameTitle.Size = New Size(100, 19)
        lblStudentNameTitle.TabIndex = 4
        lblStudentNameTitle.Text = "Student Name:"
        ' 
        ' lblStudentNoVal
        ' 
        lblStudentNoVal.AutoEllipsis = True
        lblStudentNoVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStudentNoVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentNoVal.Location = New Point(126, 56)
        lblStudentNoVal.Name = "lblStudentNoVal"
        lblStudentNoVal.Size = New Size(206, 20)
        lblStudentNoVal.TabIndex = 3
        lblStudentNoVal.Text = "-"
        ' 
        ' lblStudentNoTitle
        ' 
        lblStudentNoTitle.AutoSize = True
        lblStudentNoTitle.Font = New Font("Segoe UI", 8F)
        lblStudentNoTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNoTitle.Location = New Point(16, 56)
        lblStudentNoTitle.Name = "lblStudentNoTitle"
        lblStudentNoTitle.Size = New Size(85, 19)
        lblStudentNoTitle.TabIndex = 2
        lblStudentNoTitle.Text = "Student No.:"
        ' 
        ' lblInfoTitle
        ' 
        lblInfoTitle.AutoSize = True
        lblInfoTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblInfoTitle.Location = New Point(41, 19)
        lblInfoTitle.Name = "lblInfoTitle"
        lblInfoTitle.Size = New Size(243, 23)
        lblInfoTitle.TabIndex = 1
        lblInfoTitle.Text = "Student / Submission Details"
        ' 
        ' lblInfoIcon
        ' 
        lblInfoIcon.AutoSize = True
        lblInfoIcon.Font = New Font("Segoe UI Emoji", 11F)
        lblInfoIcon.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblInfoIcon.Location = New Point(16, 19)
        lblInfoIcon.Name = "lblInfoIcon"
        lblInfoIcon.Size = New Size(38, 26)
        lblInfoIcon.TabIndex = 0
        lblInfoIcon.Text = "👤"
        ' 
        ' pnlRightSection
        ' 
        pnlRightSection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlRightSection.Controls.Add(pnlTimelineCard)
        pnlRightSection.Controls.Add(pnlDecisionCard)
        pnlRightSection.Controls.Add(pnlCurrentStatusCard)
        pnlRightSection.Location = New Point(745, 96)
        pnlRightSection.Margin = New Padding(3, 4, 3, 4)
        pnlRightSection.Name = "pnlRightSection"
        pnlRightSection.Size = New Size(375, 878)
        pnlRightSection.TabIndex = 7
        ' 
        ' pnlTimelineCard
        ' 
        pnlTimelineCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTimelineCard.BackColor = Color.White
        pnlTimelineCard.BorderStyle = BorderStyle.FixedSingle
        pnlTimelineCard.Controls.Add(lblTimelineEmpty)
        pnlTimelineCard.Controls.Add(dgvTimeline)
        pnlTimelineCard.Controls.Add(lblTimelineHeader)
        pnlTimelineCard.Location = New Point(0, 560)
        pnlTimelineCard.Margin = New Padding(3, 4, 3, 4)
        pnlTimelineCard.Name = "pnlTimelineCard"
        pnlTimelineCard.Padding = New Padding(14, 16, 14, 16)
        pnlTimelineCard.Size = New Size(375, 318)
        pnlTimelineCard.TabIndex = 2
        ' 
        ' lblTimelineEmpty
        ' 
        lblTimelineEmpty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTimelineEmpty.Font = New Font("Segoe UI", 8F)
        lblTimelineEmpty.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTimelineEmpty.Location = New Point(11, 60)
        lblTimelineEmpty.Name = "lblTimelineEmpty"
        lblTimelineEmpty.Size = New Size(345, 53)
        lblTimelineEmpty.TabIndex = 2
        lblTimelineEmpty.Text = "No previous activity logged."
        lblTimelineEmpty.TextAlign = ContentAlignment.MiddleCenter
        lblTimelineEmpty.Visible = False
        ' 
        ' dgvTimeline
        ' 
        dgvTimeline.AllowUserToAddRows = False
        dgvTimeline.AllowUserToDeleteRows = False
        dgvTimeline.AllowUserToResizeRows = False
        dgvTimeline.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTimeline.BackgroundColor = Color.White
        dgvTimeline.BorderStyle = BorderStyle.None
        dgvTimeline.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTimeline.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTimeline.ColumnHeadersHeight = 28
        dgvTimeline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTimeline.Columns.AddRange(New DataGridViewColumn() {colActivityAction, colActivityDate, colActivityRemarks})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 8F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTimeline.DefaultCellStyle = DataGridViewCellStyle2
        dgvTimeline.EnableHeadersVisualStyles = False
        dgvTimeline.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvTimeline.Location = New Point(11, 48)
        dgvTimeline.Margin = New Padding(3, 4, 3, 4)
        dgvTimeline.MultiSelect = False
        dgvTimeline.Name = "dgvTimeline"
        dgvTimeline.ReadOnly = True
        dgvTimeline.RowHeadersVisible = False
        dgvTimeline.RowHeadersWidth = 51
        dgvTimeline.RowTemplate.Height = 28
        dgvTimeline.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTimeline.Size = New Size(350, 252)
        dgvTimeline.TabIndex = 1
        ' 
        ' colActivityAction
        ' 
        colActivityAction.HeaderText = "Action"
        colActivityAction.MinimumWidth = 6
        colActivityAction.Name = "colActivityAction"
        colActivityAction.ReadOnly = True
        colActivityAction.Width = 85
        ' 
        ' colActivityDate
        ' 
        colActivityDate.HeaderText = "Date / Time"
        colActivityDate.MinimumWidth = 6
        colActivityDate.Name = "colActivityDate"
        colActivityDate.ReadOnly = True
        colActivityDate.Width = 105
        ' 
        ' colActivityRemarks
        ' 
        colActivityRemarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colActivityRemarks.HeaderText = "Remarks / Details"
        colActivityRemarks.MinimumWidth = 6
        colActivityRemarks.Name = "colActivityRemarks"
        colActivityRemarks.ReadOnly = True
        ' 
        ' lblTimelineHeader
        ' 
        lblTimelineHeader.AutoSize = True
        lblTimelineHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblTimelineHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblTimelineHeader.Location = New Point(11, 13)
        lblTimelineHeader.Name = "lblTimelineHeader"
        lblTimelineHeader.Size = New Size(150, 21)
        lblTimelineHeader.TabIndex = 0
        lblTimelineHeader.Text = "🕒 Activity History"
        ' 
        ' pnlDecisionCard
        ' 
        pnlDecisionCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDecisionCard.BackColor = Color.White
        pnlDecisionCard.BorderStyle = BorderStyle.FixedSingle
        pnlDecisionCard.Controls.Add(btnBackToRequests)
        pnlDecisionCard.Controls.Add(btnReject)
        pnlDecisionCard.Controls.Add(btnApprove)
        pnlDecisionCard.Controls.Add(lblCharCount)
        pnlDecisionCard.Controls.Add(txtRemarks)
        pnlDecisionCard.Controls.Add(lblRemarksTitle)
        pnlDecisionCard.Controls.Add(lblDecisionHeader)
        pnlDecisionCard.Location = New Point(0, 128)
        pnlDecisionCard.Margin = New Padding(3, 4, 3, 4)
        pnlDecisionCard.Name = "pnlDecisionCard"
        pnlDecisionCard.Padding = New Padding(14, 16, 14, 16)
        pnlDecisionCard.Size = New Size(375, 415)
        pnlDecisionCard.TabIndex = 1
        ' 
        ' btnBackToRequests
        ' 
        btnBackToRequests.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBackToRequests.BackColor = Color.Transparent
        btnBackToRequests.Cursor = Cursors.Hand
        btnBackToRequests.FlatAppearance.BorderSize = 0
        btnBackToRequests.FlatStyle = FlatStyle.Flat
        btnBackToRequests.Font = New Font("Segoe UI", 8F)
        btnBackToRequests.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnBackToRequests.Location = New Point(14, 368)
        btnBackToRequests.Margin = New Padding(3, 4, 3, 4)
        btnBackToRequests.Name = "btnBackToRequests"
        btnBackToRequests.Size = New Size(345, 35)
        btnBackToRequests.TabIndex = 6
        btnBackToRequests.Text = "← Back to Requests"
        btnBackToRequests.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnReject.BackColor = Color.FromArgb(CByte(254), CByte(242), CByte(242))
        btnReject.Cursor = Cursors.Hand
        btnReject.FlatAppearance.BorderColor = Color.FromArgb(CByte(254), CByte(202), CByte(202))
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnReject.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnReject.Location = New Point(14, 312)
        btnReject.Margin = New Padding(3, 4, 3, 4)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(345, 48)
        btnReject.TabIndex = 5
        btnReject.Text = "✕  Reject Submission"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' btnApprove
        ' 
        btnApprove.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnApprove.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnApprove.Cursor = Cursors.Hand
        btnApprove.FlatAppearance.BorderSize = 0
        btnApprove.FlatStyle = FlatStyle.Flat
        btnApprove.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnApprove.ForeColor = Color.White
        btnApprove.Location = New Point(14, 256)
        btnApprove.Margin = New Padding(3, 4, 3, 4)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(345, 48)
        btnApprove.TabIndex = 4
        btnApprove.Text = "✓  Approve / Clear Submission"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' lblCharCount
        ' 
        lblCharCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCharCount.Font = New Font("Segoe UI", 7F)
        lblCharCount.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblCharCount.Location = New Point(267, 224)
        lblCharCount.Name = "lblCharCount"
        lblCharCount.Size = New Size(91, 19)
        lblCharCount.TabIndex = 3
        lblCharCount.Text = "0 / 500"
        lblCharCount.TextAlign = ContentAlignment.TopRight
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtRemarks.BackColor = Color.White
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 8F)
        txtRemarks.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtRemarks.Location = New Point(14, 77)
        txtRemarks.Margin = New Padding(3, 4, 3, 4)
        txtRemarks.MaxLength = 500
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.PlaceholderText = "Write your remarks or feedback here... (Required if rejecting)"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(345, 141)
        txtRemarks.TabIndex = 2
        ' 
        ' lblRemarksTitle
        ' 
        lblRemarksTitle.AutoSize = True
        lblRemarksTitle.Font = New Font("Segoe UI", 7.5F)
        lblRemarksTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRemarksTitle.Location = New Point(14, 51)
        lblRemarksTitle.Name = "lblRemarksTitle"
        lblRemarksTitle.Size = New Size(329, 17)
        lblRemarksTitle.TabIndex = 1
        lblRemarksTitle.Text = "Remarks (Optional for approval, required for rejection)"
        ' 
        ' lblDecisionHeader
        ' 
        lblDecisionHeader.AutoSize = True
        lblDecisionHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblDecisionHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblDecisionHeader.Location = New Point(11, 13)
        lblDecisionHeader.Name = "lblDecisionHeader"
        lblDecisionHeader.Size = New Size(145, 21)
        lblDecisionHeader.TabIndex = 0
        lblDecisionHeader.Text = "✓ Review Decision"
        ' 
        ' pnlCurrentStatusCard
        ' 
        pnlCurrentStatusCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCurrentStatusCard.BackColor = Color.White
        pnlCurrentStatusCard.BorderStyle = BorderStyle.FixedSingle
        pnlCurrentStatusCard.Controls.Add(lblStatusSubText)
        pnlCurrentStatusCard.Controls.Add(lblStatusBadge)
        pnlCurrentStatusCard.Controls.Add(lblStatusIconBig)
        pnlCurrentStatusCard.Controls.Add(lblStatusHeader)
        pnlCurrentStatusCard.Location = New Point(0, 0)
        pnlCurrentStatusCard.Margin = New Padding(3, 4, 3, 4)
        pnlCurrentStatusCard.Name = "pnlCurrentStatusCard"
        pnlCurrentStatusCard.Padding = New Padding(14, 16, 14, 16)
        pnlCurrentStatusCard.Size = New Size(375, 111)
        pnlCurrentStatusCard.TabIndex = 0
        ' 
        ' lblStatusSubText
        ' 
        lblStatusSubText.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStatusSubText.AutoEllipsis = True
        lblStatusSubText.Font = New Font("Segoe UI", 7.5F)
        lblStatusSubText.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatusSubText.Location = New Point(57, 75)
        lblStatusSubText.Name = "lblStatusSubText"
        lblStatusSubText.Size = New Size(302, 21)
        lblStatusSubText.TabIndex = 3
        lblStatusSubText.Text = "This submission is waiting for your evaluation."
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.AutoSize = True
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStatusBadge.Location = New Point(57, 45)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Size = New Size(111, 21)
        lblStatusBadge.TabIndex = 2
        lblStatusBadge.Text = "Under Review"
        ' 
        ' lblStatusIconBig
        ' 
        lblStatusIconBig.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        lblStatusIconBig.Font = New Font("Segoe UI Emoji", 14F)
        lblStatusIconBig.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStatusIconBig.Location = New Point(11, 43)
        lblStatusIconBig.Name = "lblStatusIconBig"
        lblStatusIconBig.Size = New Size(39, 45)
        lblStatusIconBig.TabIndex = 1
        lblStatusIconBig.Text = "📄"
        lblStatusIconBig.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatusHeader
        ' 
        lblStatusHeader.AutoSize = True
        lblStatusHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblStatusHeader.Location = New Point(11, 13)
        lblStatusHeader.Name = "lblStatusHeader"
        lblStatusHeader.Size = New Size(114, 21)
        lblStatusHeader.TabIndex = 0
        lblStatusHeader.Text = "Current Status"
        ' 
        ' ReviewClearanceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1143, 1000)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ReviewClearanceForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "EClearance - Review Clearance Submission"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlOfficeBadge.ResumeLayout(False)
        pnlOfficeBadge.PerformLayout()
        pnlStaffBadge.ResumeLayout(False)
        pnlStaffBadge.PerformLayout()
        pnlLeftSection.ResumeLayout(False)
        pnlGuidanceInfo.ResumeLayout(False)
        pnlGuidanceBody.ResumeLayout(False)
        pnlGuidanceNoUpdate.ResumeLayout(False)
        pnlGuidanceNoUpdateCard.ResumeLayout(False)
        pnlGuidanceNoUpdateCard.PerformLayout()
        pnlGuidanceFields.ResumeLayout(False)
        pnlGuidanceFields.PerformLayout()
        pnlGuidanceInfoNote.ResumeLayout(False)
        pnlGuidanceInfoNote.PerformLayout()
        pnlGuidanceHeader.ResumeLayout(False)
        pnlGuidanceHeader.PerformLayout()
        pnlDocumentCard.ResumeLayout(False)
        pnlDocumentCard.PerformLayout()
        pnlDocPreview.ResumeLayout(False)
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        pnlPdfFallback.ResumeLayout(False)
        pnlStudentInfoCard.ResumeLayout(False)
        pnlStudentInfoCard.PerformLayout()
        pnlRightSection.ResumeLayout(False)
        pnlTimelineCard.ResumeLayout(False)
        pnlTimelineCard.PerformLayout()
        CType(dgvTimeline, ComponentModel.ISupportInitialize).EndInit()
        pnlDecisionCard.ResumeLayout(False)
        pnlDecisionCard.PerformLayout()
        pnlCurrentStatusCard.ResumeLayout(False)
        pnlCurrentStatusCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlOfficeBadge As Panel
    Friend WithEvents lblOfficeIcon As Label
    Friend WithEvents lblOfficeName As Label
    Friend WithEvents lblOfficeSub As Label
    Friend WithEvents pnlStaffBadge As Panel
    Friend WithEvents lblStaffIcon As Label
    Friend WithEvents lblStaffName As Label
    Friend WithEvents lblStaffRole As Label
    Friend WithEvents lblDateTimeBadge As Label
    Friend WithEvents pnlLeftSection As Panel
    Friend WithEvents pnlStudentInfoCard As Panel
    Friend WithEvents lblInfoIcon As Label
    Friend WithEvents lblInfoTitle As Label
    Friend WithEvents lblStudentNoTitle As Label
    Friend WithEvents lblStudentNoVal As Label
    Friend WithEvents lblStudentNameTitle As Label
    Friend WithEvents lblStudentNameVal As Label
    Friend WithEvents lblCourseTitle As Label
    Friend WithEvents lblCourseVal As Label
    Friend WithEvents lblYearTitle As Label
    Friend WithEvents lblYearVal As Label
    Friend WithEvents lblOfficeTitle As Label
    Friend WithEvents lblOfficeVal As Label
    Friend WithEvents lblReqTitle As Label
    Friend WithEvents lblReqVal As Label
    Friend WithEvents lblDateTitle As Label
    Friend WithEvents lblDateVal As Label
    Friend WithEvents lblFileTitle As Label
    Friend WithEvents lblFileVal As Label
    Friend WithEvents pnlDocumentCard As Panel
    Friend WithEvents lblDocIcon As Label
    Friend WithEvents lblDocTitle As Label
    Friend WithEvents lblDocFileName As Label
    Friend WithEvents btnOpenExternal As Button
    Friend WithEvents pnlDocPreview As Panel
    Friend WithEvents picPreview As PictureBox
    Friend WithEvents pnlPdfFallback As Panel
    Friend WithEvents lblPdfIcon As Label
    Friend WithEvents lblPdfPrompt As Label
    Friend WithEvents lblPdfSub As Label
    Friend WithEvents btnOpenPdfCenter As Button
    Friend WithEvents pnlRightSection As Panel
    Friend WithEvents pnlCurrentStatusCard As Panel
    Friend WithEvents lblStatusHeader As Label
    Friend WithEvents lblStatusIconBig As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents lblStatusSubText As Label
    Friend WithEvents pnlDecisionCard As Panel
    Friend WithEvents lblDecisionHeader As Label
    Friend WithEvents lblRemarksTitle As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lblCharCount As Label
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnReject As Button
    Friend WithEvents btnBackToRequests As Button
    Friend WithEvents pnlTimelineCard As Panel
    Friend WithEvents lblTimelineHeader As Label
    Friend WithEvents dgvTimeline As DataGridView
    Friend WithEvents colActivityAction As DataGridViewTextBoxColumn
    Friend WithEvents colActivityDate As DataGridViewTextBoxColumn
    Friend WithEvents colActivityRemarks As DataGridViewTextBoxColumn
    Friend WithEvents lblTimelineEmpty As Label

    Friend WithEvents cmbSubmittedFiles As ComboBox
    Friend WithEvents pnlGuidanceInfo As Panel
    Friend WithEvents pnlGuidanceHeader As Panel
    Friend WithEvents lblGuidanceIcon As Label
    Friend WithEvents lblGuidanceInfoTitle As Label
    Friend WithEvents lblGuidanceInfoSubtitle As Label
    Friend WithEvents pnlGuidanceBody As Panel
    Friend WithEvents lblAddressTitle As Label
    Friend WithEvents lblAddressValue As Label
    Friend WithEvents lblContactTitle As Label
    Friend WithEvents lblContactValue As Label
    Friend WithEvents lblEmailTitle As Label
    Friend WithEvents lblEmailValue As Label
    Friend WithEvents lblCivilStatusTitle As Label
    Friend WithEvents lblCivilStatusValue As Label
    Friend WithEvents lblEmergencyNameTitle As Label
    Friend WithEvents lblEmergencyNameValue As Label
    Friend WithEvents lblRelationshipTitle As Label
    Friend WithEvents lblRelationshipValue As Label
    Friend WithEvents lblEmergencyContactTitle As Label
    Friend WithEvents lblEmergencyContactValue As Label
    Friend WithEvents lblNotesTitle As Label
    Friend WithEvents lblNotesValue As Label
    Friend WithEvents pnlGuidanceInfoNote As Panel
    Friend WithEvents lblGuidanceNoteIcon As Label
    Friend WithEvents lblGuidanceInfoNote As Label
    Friend WithEvents pnlGuidanceFields As Panel
    Friend WithEvents pnlGuidanceNoUpdate As Panel
    Friend WithEvents pnlGuidanceNoUpdateCard As Panel
    Friend WithEvents lblNoUpdateIcon As Label
    Friend WithEvents lblNoUpdateTitle As Label
    Friend WithEvents lblNoUpdateMessage As Label
    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents lblStatusVal As Label
End Class
