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
        Dim dgvTimelineCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dgvTimelineCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        pnlGuidanceHeader = New Panel()
        lblGuidanceIcon = New Label()
        lblGuidanceInfoTitle = New Label()
        lblGuidanceInfoSubtitle = New Label()
        pnlGuidanceBody = New Panel()
        lblAddressTitle = New Label()
        lblAddressValue = New Label()
        lblContactTitle = New Label()
        lblContactValue = New Label()
        lblEmailTitle = New Label()
        lblEmailValue = New Label()
        lblCivilStatusTitle = New Label()
        lblCivilStatusValue = New Label()
        lblEmergencyNameTitle = New Label()
        lblEmergencyNameValue = New Label()
        lblRelationshipTitle = New Label()
        lblRelationshipValue = New Label()
        lblEmergencyContactTitle = New Label()
        lblEmergencyContactValue = New Label()
        lblNotesTitle = New Label()
        lblNotesValue = New Label()
        pnlGuidanceInfoNote = New Panel()
        lblGuidanceNoteIcon = New Label()
        lblGuidanceInfoNote = New Label()
        lblStatusTitle = New Label()
        lblStatusVal = New Label()
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
        dgvTimeline = New DataGridView()
        colActivityAction = New DataGridViewTextBoxColumn()
        colActivityDate = New DataGridViewTextBoxColumn()
        colActivityRemarks = New DataGridViewTextBoxColumn()
        lblTimelineEmpty = New Label()
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
        pnlGuidanceHeader.SuspendLayout()
        pnlGuidanceBody.SuspendLayout()
        pnlGuidanceInfoNote.SuspendLayout()
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
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1000, 750)
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
        btnClose.Location = New Point(952, 14)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(34, 34)
        btnClose.TabIndex = 0
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(20, 14)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(316, 30)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Review Clearance Submission"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 8.5F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHeaderSub.Location = New Point(22, 46)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(356, 15)
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
        pnlOfficeBadge.Location = New Point(530, 14)
        pnlOfficeBadge.Name = "pnlOfficeBadge"
        pnlOfficeBadge.Size = New Size(130, 44)
        pnlOfficeBadge.TabIndex = 3
        ' 
        ' lblOfficeIcon
        ' 
        lblOfficeIcon.AutoSize = True
        lblOfficeIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblOfficeIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblOfficeIcon.Location = New Point(6, 10)
        lblOfficeIcon.Name = "lblOfficeIcon"
        lblOfficeIcon.Size = New Size(32, 21)
        lblOfficeIcon.TabIndex = 0
        lblOfficeIcon.Text = "🏛"
        ' 
        ' lblOfficeName
        ' 
        lblOfficeName.AutoEllipsis = True
        lblOfficeName.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblOfficeName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeName.Location = New Point(39, 6)
        lblOfficeName.Name = "lblOfficeName"
        lblOfficeName.Size = New Size(92, 15)
        lblOfficeName.TabIndex = 1
        lblOfficeName.Text = "Assigned Office"
        ' 
        ' lblOfficeSub
        ' 
        lblOfficeSub.AutoSize = True
        lblOfficeSub.Font = New Font("Segoe UI", 7F)
        lblOfficeSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeSub.Location = New Point(40, 22)
        lblOfficeSub.Name = "lblOfficeSub"
        lblOfficeSub.Size = New Size(69, 12)
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
        pnlStaffBadge.Location = New Point(668, 14)
        pnlStaffBadge.Name = "pnlStaffBadge"
        pnlStaffBadge.Size = New Size(130, 44)
        pnlStaffBadge.TabIndex = 4
        ' 
        ' lblStaffIcon
        ' 
        lblStaffIcon.AutoSize = True
        lblStaffIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblStaffIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblStaffIcon.Location = New Point(6, 10)
        lblStaffIcon.Name = "lblStaffIcon"
        lblStaffIcon.Size = New Size(32, 21)
        lblStaffIcon.TabIndex = 0
        lblStaffIcon.Text = "👤"
        ' 
        ' lblStaffName
        ' 
        lblStaffName.AutoEllipsis = True
        lblStaffName.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStaffName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStaffName.Location = New Point(37, 6)
        lblStaffName.Name = "lblStaffName"
        lblStaffName.Size = New Size(92, 15)
        lblStaffName.TabIndex = 1
        lblStaffName.Text = "Staff Member"
        ' 
        ' lblStaffRole
        ' 
        lblStaffRole.AutoSize = True
        lblStaffRole.Font = New Font("Segoe UI", 7F)
        lblStaffRole.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStaffRole.Location = New Point(37, 22)
        lblStaffRole.Name = "lblStaffRole"
        lblStaffRole.Size = New Size(72, 12)
        lblStaffRole.TabIndex = 2
        lblStaffRole.Text = "Clearing Officer"
        ' 
        ' lblDateTimeBadge
        ' 
        lblDateTimeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTimeBadge.Font = New Font("Segoe UI", 7.5F)
        lblDateTimeBadge.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTimeBadge.Location = New Point(804, 14)
        lblDateTimeBadge.Name = "lblDateTimeBadge"
        lblDateTimeBadge.Size = New Size(140, 44)
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
        pnlLeftSection.Location = New Point(20, 72)
        pnlLeftSection.Name = "pnlLeftSection"
        pnlLeftSection.Size = New Size(620, 658)
        pnlLeftSection.TabIndex = 6
        ' 
        ' pnlGuidanceInfo
        ' 
        pnlGuidanceInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceInfo.BackColor = Color.White
        pnlGuidanceInfo.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceInfo.Controls.Add(pnlGuidanceBody)
        pnlGuidanceInfo.Controls.Add(pnlGuidanceHeader)
        pnlGuidanceInfo.Location = New Point(0, 172)
        pnlGuidanceInfo.Name = "pnlGuidanceInfo"
        pnlGuidanceInfo.Size = New Size(620, 486)
        pnlGuidanceInfo.TabIndex = 2
        pnlGuidanceInfo.Visible = False
        ' 
        ' pnlGuidanceHeader
        ' 
        pnlGuidanceHeader.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        pnlGuidanceHeader.Controls.Add(lblGuidanceInfoSubtitle)
        pnlGuidanceHeader.Controls.Add(lblGuidanceInfoTitle)
        pnlGuidanceHeader.Controls.Add(lblGuidanceIcon)
        pnlGuidanceHeader.Dock = DockStyle.Top
        pnlGuidanceHeader.Location = New Point(0, 0)
        pnlGuidanceHeader.Name = "pnlGuidanceHeader"
        pnlGuidanceHeader.Size = New Size(618, 56)
        pnlGuidanceHeader.TabIndex = 0
        ' 
        ' lblGuidanceIcon
        ' 
        lblGuidanceIcon.AutoSize = True
        lblGuidanceIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblGuidanceIcon.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        lblGuidanceIcon.Location = New Point(14, 12)
        lblGuidanceIcon.Name = "lblGuidanceIcon"
        lblGuidanceIcon.Size = New Size(30, 25)
        lblGuidanceIcon.TabIndex = 0
        lblGuidanceIcon.Text = "📄"
        ' 
        ' lblGuidanceInfoTitle
        ' 
        lblGuidanceInfoTitle.AutoSize = True
        lblGuidanceInfoTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        lblGuidanceInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblGuidanceInfoTitle.Location = New Point(44, 9)
        lblGuidanceInfoTitle.Name = "lblGuidanceInfoTitle"
        lblGuidanceInfoTitle.Size = New Size(205, 19)
        lblGuidanceInfoTitle.TabIndex = 1
        lblGuidanceInfoTitle.Text = "Guidance Information Update"
        ' 
        ' lblGuidanceInfoSubtitle
        ' 
        lblGuidanceInfoSubtitle.AutoSize = True
        lblGuidanceInfoSubtitle.Font = New Font("Segoe UI", 8F)
        lblGuidanceInfoSubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblGuidanceInfoSubtitle.Location = New Point(45, 29)
        lblGuidanceInfoSubtitle.Name = "lblGuidanceInfoSubtitle"
        lblGuidanceInfoSubtitle.Size = New Size(385, 13)
        lblGuidanceInfoSubtitle.TabIndex = 2
        lblGuidanceInfoSubtitle.Text = "Below is the updated information submitted by the student for Guidance clearance."
        ' 
        ' pnlGuidanceBody
        ' 
        pnlGuidanceBody.BackColor = Color.White
        pnlGuidanceBody.Controls.Add(pnlGuidanceInfoNote)
        pnlGuidanceBody.Controls.Add(lblNotesValue)
        pnlGuidanceBody.Controls.Add(lblNotesTitle)
        pnlGuidanceBody.Controls.Add(lblEmergencyContactValue)
        pnlGuidanceBody.Controls.Add(lblEmergencyContactTitle)
        pnlGuidanceBody.Controls.Add(lblRelationshipValue)
        pnlGuidanceBody.Controls.Add(lblRelationshipTitle)
        pnlGuidanceBody.Controls.Add(lblEmergencyNameValue)
        pnlGuidanceBody.Controls.Add(lblEmergencyNameTitle)
        pnlGuidanceBody.Controls.Add(lblCivilStatusValue)
        pnlGuidanceBody.Controls.Add(lblCivilStatusTitle)
        pnlGuidanceBody.Controls.Add(lblEmailValue)
        pnlGuidanceBody.Controls.Add(lblEmailTitle)
        pnlGuidanceBody.Controls.Add(lblContactValue)
        pnlGuidanceBody.Controls.Add(lblContactTitle)
        pnlGuidanceBody.Controls.Add(lblAddressValue)
        pnlGuidanceBody.Controls.Add(lblAddressTitle)
        pnlGuidanceBody.Dock = DockStyle.Fill
        pnlGuidanceBody.Location = New Point(0, 56)
        pnlGuidanceBody.Name = "pnlGuidanceBody"
        pnlGuidanceBody.Padding = New Padding(20)
        pnlGuidanceBody.Size = New Size(618, 428)
        pnlGuidanceBody.TabIndex = 1
        ' 
        ' lblAddressTitle
        ' 
        lblAddressTitle.AutoSize = True
        lblAddressTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblAddressTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAddressTitle.Location = New Point(20, 14)
        lblAddressTitle.Name = "lblAddressTitle"
        lblAddressTitle.Size = New Size(89, 15)
        lblAddressTitle.TabIndex = 0
        lblAddressTitle.Text = "Current Address"
        ' 
        ' lblAddressValue
        ' 
        lblAddressValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblAddressValue.BorderStyle = BorderStyle.FixedSingle
        lblAddressValue.Font = New Font("Segoe UI", 9F)
        lblAddressValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAddressValue.Location = New Point(20, 32)
        lblAddressValue.Name = "lblAddressValue"
        lblAddressValue.Padding = New Padding(8, 4, 8, 4)
        lblAddressValue.Size = New Size(275, 34)
        lblAddressValue.TabIndex = 1
        lblAddressValue.Text = "Not provided"
        lblAddressValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblContactTitle
        ' 
        lblContactTitle.AutoSize = True
        lblContactTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblContactTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblContactTitle.Location = New Point(20, 74)
        lblContactTitle.Name = "lblContactTitle"
        lblContactTitle.Size = New Size(95, 15)
        lblContactTitle.TabIndex = 2
        lblContactTitle.Text = "Contact Number"
        ' 
        ' lblContactValue
        ' 
        lblContactValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblContactValue.BorderStyle = BorderStyle.FixedSingle
        lblContactValue.Font = New Font("Segoe UI", 9F)
        lblContactValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblContactValue.Location = New Point(20, 92)
        lblContactValue.Name = "lblContactValue"
        lblContactValue.Padding = New Padding(8, 4, 8, 4)
        lblContactValue.Size = New Size(275, 34)
        lblContactValue.TabIndex = 3
        lblContactValue.Text = "Not provided"
        lblContactValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmailTitle
        ' 
        lblEmailTitle.AutoSize = True
        lblEmailTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmailTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmailTitle.Location = New Point(20, 134)
        lblEmailTitle.Name = "lblEmailTitle"
        lblEmailTitle.Size = New Size(81, 15)
        lblEmailTitle.TabIndex = 4
        lblEmailTitle.Text = "Email Address"
        ' 
        ' lblEmailValue
        ' 
        lblEmailValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmailValue.BorderStyle = BorderStyle.FixedSingle
        lblEmailValue.Font = New Font("Segoe UI", 9F)
        lblEmailValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmailValue.Location = New Point(20, 152)
        lblEmailValue.Name = "lblEmailValue"
        lblEmailValue.Padding = New Padding(8, 4, 8, 4)
        lblEmailValue.Size = New Size(275, 34)
        lblEmailValue.TabIndex = 5
        lblEmailValue.Text = "Not provided"
        lblEmailValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCivilStatusTitle
        ' 
        lblCivilStatusTitle.AutoSize = True
        lblCivilStatusTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblCivilStatusTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCivilStatusTitle.Location = New Point(20, 194)
        lblCivilStatusTitle.Name = "lblCivilStatusTitle"
        lblCivilStatusTitle.Size = New Size(65, 15)
        lblCivilStatusTitle.TabIndex = 6
        lblCivilStatusTitle.Text = "Civil Status"
        ' 
        ' lblCivilStatusValue
        ' 
        lblCivilStatusValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblCivilStatusValue.BorderStyle = BorderStyle.FixedSingle
        lblCivilStatusValue.Font = New Font("Segoe UI", 9F)
        lblCivilStatusValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCivilStatusValue.Location = New Point(20, 212)
        lblCivilStatusValue.Name = "lblCivilStatusValue"
        lblCivilStatusValue.Padding = New Padding(8, 4, 8, 4)
        lblCivilStatusValue.Size = New Size(275, 34)
        lblCivilStatusValue.TabIndex = 7
        lblCivilStatusValue.Text = "Not provided"
        lblCivilStatusValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmergencyNameTitle
        ' 
        lblEmergencyNameTitle.AutoSize = True
        lblEmergencyNameTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyNameTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyNameTitle.Location = New Point(315, 14)
        lblEmergencyNameTitle.Name = "lblEmergencyNameTitle"
        lblEmergencyNameTitle.Size = New Size(140, 15)
        lblEmergencyNameTitle.TabIndex = 8
        lblEmergencyNameTitle.Text = "Emergency Contact Name"
        ' 
        ' lblEmergencyNameValue
        ' 
        lblEmergencyNameValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmergencyNameValue.BorderStyle = BorderStyle.FixedSingle
        lblEmergencyNameValue.Font = New Font("Segoe UI", 9F)
        lblEmergencyNameValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyNameValue.Location = New Point(315, 32)
        lblEmergencyNameValue.Name = "lblEmergencyNameValue"
        lblEmergencyNameValue.Padding = New Padding(8, 4, 8, 4)
        lblEmergencyNameValue.Size = New Size(275, 34)
        lblEmergencyNameValue.TabIndex = 9
        lblEmergencyNameValue.Text = "Not provided"
        lblEmergencyNameValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblRelationshipTitle
        ' 
        lblRelationshipTitle.AutoSize = True
        lblRelationshipTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblRelationshipTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRelationshipTitle.Location = New Point(315, 74)
        lblRelationshipTitle.Name = "lblRelationshipTitle"
        lblRelationshipTitle.Size = New Size(73, 15)
        lblRelationshipTitle.TabIndex = 10
        lblRelationshipTitle.Text = "Relationship"
        ' 
        ' lblRelationshipValue
        ' 
        lblRelationshipValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblRelationshipValue.BorderStyle = BorderStyle.FixedSingle
        lblRelationshipValue.Font = New Font("Segoe UI", 9F)
        lblRelationshipValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRelationshipValue.Location = New Point(315, 92)
        lblRelationshipValue.Name = "lblRelationshipValue"
        lblRelationshipValue.Padding = New Padding(8, 4, 8, 4)
        lblRelationshipValue.Size = New Size(275, 34)
        lblRelationshipValue.TabIndex = 11
        lblRelationshipValue.Text = "Not provided"
        lblRelationshipValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmergencyContactTitle
        ' 
        lblEmergencyContactTitle.AutoSize = True
        lblEmergencyContactTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyContactTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyContactTitle.Location = New Point(315, 134)
        lblEmergencyContactTitle.Name = "lblEmergencyContactTitle"
        lblEmergencyContactTitle.Size = New Size(155, 15)
        lblEmergencyContactTitle.TabIndex = 12
        lblEmergencyContactTitle.Text = "Emergency Contact Number"
        ' 
        ' lblEmergencyContactValue
        ' 
        lblEmergencyContactValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmergencyContactValue.BorderStyle = BorderStyle.FixedSingle
        lblEmergencyContactValue.Font = New Font("Segoe UI", 9F)
        lblEmergencyContactValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyContactValue.Location = New Point(315, 152)
        lblEmergencyContactValue.Name = "lblEmergencyContactValue"
        lblEmergencyContactValue.Padding = New Padding(8, 4, 8, 4)
        lblEmergencyContactValue.Size = New Size(275, 34)
        lblEmergencyContactValue.TabIndex = 13
        lblEmergencyContactValue.Text = "Not provided"
        lblEmergencyContactValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNotesTitle
        ' 
        lblNotesTitle.AutoSize = True
        lblNotesTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblNotesTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNotesTitle.Location = New Point(315, 194)
        lblNotesTitle.Name = "lblNotesTitle"
        lblNotesTitle.Size = New Size(99, 15)
        lblNotesTitle.TabIndex = 14
        lblNotesTitle.Text = "Additional Notes"
        ' 
        ' lblNotesValue
        ' 
        lblNotesValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblNotesValue.BorderStyle = BorderStyle.FixedSingle
        lblNotesValue.Font = New Font("Segoe UI", 9F)
        lblNotesValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNotesValue.Location = New Point(315, 212)
        lblNotesValue.Name = "lblNotesValue"
        lblNotesValue.Padding = New Padding(8, 4, 8, 4)
        lblNotesValue.Size = New Size(275, 34)
        lblNotesValue.TabIndex = 15
        lblNotesValue.Text = "Not provided"
        lblNotesValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlGuidanceInfoNote
        ' 
        pnlGuidanceInfoNote.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceInfoNote.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        pnlGuidanceInfoNote.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceInfoNote.Controls.Add(lblGuidanceInfoNote)
        pnlGuidanceInfoNote.Controls.Add(lblGuidanceNoteIcon)
        pnlGuidanceInfoNote.Location = New Point(20, 360)
        pnlGuidanceInfoNote.Name = "pnlGuidanceInfoNote"
        pnlGuidanceInfoNote.Padding = New Padding(8, 6, 8, 6)
        pnlGuidanceInfoNote.Size = New Size(570, 52)
        pnlGuidanceInfoNote.TabIndex = 16
        ' 
        ' lblGuidanceNoteIcon
        ' 
        lblGuidanceNoteIcon.AutoSize = True
        lblGuidanceNoteIcon.Font = New Font("Segoe UI Emoji", 13F)
        lblGuidanceNoteIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblGuidanceNoteIcon.Location = New Point(8, 12)
        lblGuidanceNoteIcon.Name = "lblGuidanceNoteIcon"
        lblGuidanceNoteIcon.Size = New Size(20, 24)
        lblGuidanceNoteIcon.TabIndex = 0
        lblGuidanceNoteIcon.Text = "ℹ"
        ' 
        ' lblGuidanceInfoNote
        ' 
        lblGuidanceInfoNote.Font = New Font("Segoe UI", 8.25F)
        lblGuidanceInfoNote.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblGuidanceInfoNote.Location = New Point(34, 8)
        lblGuidanceInfoNote.Name = "lblGuidanceInfoNote"
        lblGuidanceInfoNote.Size = New Size(524, 34)
        lblGuidanceInfoNote.TabIndex = 1
        lblGuidanceInfoNote.Text = "This information was provided by the student as part of the Guidance Office requirement." & vbCrLf & "Please review the details before approving or rejecting this clearance."
        ' 
        '         ' 
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
        pnlDocumentCard.Location = New Point(0, 172)
        pnlDocumentCard.Name = "pnlDocumentCard"
        pnlDocumentCard.Padding = New Padding(14)
        pnlDocumentCard.Size = New Size(620, 486)
        pnlDocumentCard.TabIndex = 1
        ' 
        ' btnOpenExternal
        ' 
        ' 
        ' cmbSubmittedFiles
        ' 
        cmbSubmittedFiles.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbSubmittedFiles.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubmittedFiles.Font = New Font("Segoe UI", 8.5F)
        cmbSubmittedFiles.FormattingEnabled = True
        cmbSubmittedFiles.Location = New Point(265, 12)
        cmbSubmittedFiles.Name = "cmbSubmittedFiles"
        cmbSubmittedFiles.Size = New Size(215, 23)
        cmbSubmittedFiles.TabIndex = 4
        cmbSubmittedFiles.Visible = False
        btnOpenExternal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenExternal.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        btnOpenExternal.Cursor = Cursors.Hand
        btnOpenExternal.FlatAppearance.BorderSize = 0
        btnOpenExternal.FlatStyle = FlatStyle.Flat
        btnOpenExternal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        btnOpenExternal.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnOpenExternal.Location = New Point(490, 10)
        btnOpenExternal.Name = "btnOpenExternal"
        btnOpenExternal.Size = New Size(116, 28)
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
        lblDocFileName.Location = New Point(192, 17)
        lblDocFileName.Name = "lblDocFileName"
        lblDocFileName.Size = New Size(314, 16)
        lblDocFileName.TabIndex = 2
        lblDocFileName.Text = "filename.png"
        ' 
        ' lblDocTitle
        ' 
        lblDocTitle.AutoSize = True
        lblDocTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblDocTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDocTitle.Location = New Point(36, 14)
        lblDocTitle.Name = "lblDocTitle"
        lblDocTitle.Size = New Size(150, 19)
        lblDocTitle.TabIndex = 1
        lblDocTitle.Text = "Submitted Document"
        ' 
        ' lblDocIcon
        ' 
        lblDocIcon.AutoSize = True
        lblDocIcon.Font = New Font("Segoe UI Emoji", 11F)
        lblDocIcon.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblDocIcon.Location = New Point(14, 14)
        lblDocIcon.Name = "lblDocIcon"
        lblDocIcon.Size = New Size(30, 20)
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
        pnlDocPreview.Location = New Point(14, 46)
        pnlDocPreview.Name = "pnlDocPreview"
        pnlDocPreview.Size = New Size(590, 424)
        pnlDocPreview.TabIndex = 4
        ' 
        ' picPreview
        ' 
        picPreview.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        picPreview.Dock = DockStyle.Fill
        picPreview.Location = New Point(0, 0)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(588, 422)
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
        pnlPdfFallback.Location = New Point(154, 120)
        pnlPdfFallback.Name = "pnlPdfFallback"
        pnlPdfFallback.Size = New Size(280, 180)
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
        btnOpenPdfCenter.Location = New Point(40, 126)
        btnOpenPdfCenter.Name = "btnOpenPdfCenter"
        btnOpenPdfCenter.Size = New Size(200, 36)
        btnOpenPdfCenter.TabIndex = 3
        btnOpenPdfCenter.Text = "Open in Default Viewer"
        btnOpenPdfCenter.UseVisualStyleBackColor = False
        ' 
        ' lblPdfSub
        ' 
        lblPdfSub.Font = New Font("Segoe UI", 7.5F)
        lblPdfSub.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblPdfSub.Location = New Point(10, 88)
        lblPdfSub.Name = "lblPdfSub"
        lblPdfSub.Size = New Size(260, 28)
        lblPdfSub.TabIndex = 2
        lblPdfSub.Text = "Click below to inspect the original PDF document."
        lblPdfSub.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPdfPrompt
        ' 
        lblPdfPrompt.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblPdfPrompt.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblPdfPrompt.Location = New Point(10, 64)
        lblPdfPrompt.Name = "lblPdfPrompt"
        lblPdfPrompt.Size = New Size(260, 20)
        lblPdfPrompt.TabIndex = 1
        lblPdfPrompt.Text = "PDF Document Attached"
        lblPdfPrompt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPdfIcon
        ' 
        lblPdfIcon.Font = New Font("Segoe UI Emoji", 30F)
        lblPdfIcon.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        lblPdfIcon.Location = New Point(110, 8)
        lblPdfIcon.Name = "lblPdfIcon"
        lblPdfIcon.Size = New Size(60, 50)
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
        pnlStudentInfoCard.Name = "pnlStudentInfoCard"
        pnlStudentInfoCard.Padding = New Padding(14)
        pnlStudentInfoCard.Size = New Size(620, 160)
        pnlStudentInfoCard.TabIndex = 0
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Segoe UI", 8F)
        lblStatusTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatusTitle.Location = New Point(310, 126)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(42, 13)
        lblStatusTitle.TabIndex = 18
        lblStatusTitle.Text = "Status :"
        lblStatusTitle.Visible = False
        ' 
        ' lblStatusVal
        ' 
        lblStatusVal.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblStatusVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStatusVal.ForeColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        lblStatusVal.Location = New Point(400, 122)
        lblStatusVal.Name = "lblStatusVal"
        lblStatusVal.Size = New Size(110, 22)
        lblStatusVal.TabIndex = 19
        lblStatusVal.Text = "Under Review"
        lblStatusVal.TextAlign = ContentAlignment.MiddleCenter
        lblStatusVal.Visible = False
        ' 
        ' 
        ' lblFileVal
        ' 
        lblFileVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFileVal.AutoEllipsis = True
        lblFileVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblFileVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblFileVal.Location = New Point(400, 126)
        lblFileVal.Name = "lblFileVal"
        lblFileVal.Size = New Size(204, 15)
        lblFileVal.TabIndex = 17
        lblFileVal.Text = "-"
        ' 
        ' lblFileTitle
        ' 
        lblFileTitle.AutoSize = True
        lblFileTitle.Font = New Font("Segoe UI", 8F)
        lblFileTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFileTitle.Location = New Point(310, 126)
        lblFileTitle.Name = "lblFileTitle"
        lblFileTitle.Size = New Size(60, 13)
        lblFileTitle.TabIndex = 16
        lblFileTitle.Text = "File Name:"
        ' 
        ' lblDateVal
        ' 
        lblDateVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDateVal.AutoEllipsis = True
        lblDateVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblDateVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDateVal.Location = New Point(400, 98)
        lblDateVal.Name = "lblDateVal"
        lblDateVal.Size = New Size(204, 15)
        lblDateVal.TabIndex = 15
        lblDateVal.Text = "-"
        ' 
        ' lblDateTitle
        ' 
        lblDateTitle.AutoSize = True
        lblDateTitle.Font = New Font("Segoe UI", 8F)
        lblDateTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTitle.Location = New Point(310, 98)
        lblDateTitle.Name = "lblDateTitle"
        lblDateTitle.Size = New Size(77, 13)
        lblDateTitle.TabIndex = 14
        lblDateTitle.Text = "Submitted At:"
        ' 
        ' lblReqVal
        ' 
        lblReqVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblReqVal.AutoEllipsis = True
        lblReqVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblReqVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblReqVal.Location = New Point(400, 70)
        lblReqVal.Name = "lblReqVal"
        lblReqVal.Size = New Size(204, 15)
        lblReqVal.TabIndex = 13
        lblReqVal.Text = "-"
        ' 
        ' lblReqTitle
        ' 
        lblReqTitle.AutoSize = True
        lblReqTitle.Font = New Font("Segoe UI", 8F)
        lblReqTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblReqTitle.Location = New Point(310, 70)
        lblReqTitle.Name = "lblReqTitle"
        lblReqTitle.Size = New Size(76, 13)
        lblReqTitle.TabIndex = 12
        lblReqTitle.Text = "Requirement:"
        ' 
        ' lblOfficeVal
        ' 
        lblOfficeVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblOfficeVal.AutoEllipsis = True
        lblOfficeVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblOfficeVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeVal.Location = New Point(400, 42)
        lblOfficeVal.Name = "lblOfficeVal"
        lblOfficeVal.Size = New Size(204, 15)
        lblOfficeVal.TabIndex = 11
        lblOfficeVal.Text = "-"
        ' 
        ' lblOfficeTitle
        ' 
        lblOfficeTitle.AutoSize = True
        lblOfficeTitle.Font = New Font("Segoe UI", 8F)
        lblOfficeTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeTitle.Location = New Point(310, 42)
        lblOfficeTitle.Name = "lblOfficeTitle"
        lblOfficeTitle.Size = New Size(41, 13)
        lblOfficeTitle.TabIndex = 10
        lblOfficeTitle.Text = "Office:"
        ' 
        ' lblYearVal
        ' 
        lblYearVal.AutoEllipsis = True
        lblYearVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblYearVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblYearVal.Location = New Point(110, 126)
        lblYearVal.Name = "lblYearVal"
        lblYearVal.Size = New Size(180, 15)
        lblYearVal.TabIndex = 9
        lblYearVal.Text = "-"
        ' 
        ' lblYearTitle
        ' 
        lblYearTitle.AutoSize = True
        lblYearTitle.Font = New Font("Segoe UI", 8F)
        lblYearTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblYearTitle.Location = New Point(14, 126)
        lblYearTitle.Name = "lblYearTitle"
        lblYearTitle.Size = New Size(58, 13)
        lblYearTitle.TabIndex = 8
        lblYearTitle.Text = "Year Level:"
        ' 
        ' lblCourseVal
        ' 
        lblCourseVal.AutoEllipsis = True
        lblCourseVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblCourseVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCourseVal.Location = New Point(110, 98)
        lblCourseVal.Name = "lblCourseVal"
        lblCourseVal.Size = New Size(180, 15)
        lblCourseVal.TabIndex = 7
        lblCourseVal.Text = "-"
        ' 
        ' lblCourseTitle
        ' 
        lblCourseTitle.AutoSize = True
        lblCourseTitle.Font = New Font("Segoe UI", 8F)
        lblCourseTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblCourseTitle.Location = New Point(14, 98)
        lblCourseTitle.Name = "lblCourseTitle"
        lblCourseTitle.Size = New Size(46, 13)
        lblCourseTitle.TabIndex = 6
        lblCourseTitle.Text = "Course:"
        ' 
        ' lblStudentNameVal
        ' 
        lblStudentNameVal.AutoEllipsis = True
        lblStudentNameVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStudentNameVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentNameVal.Location = New Point(110, 70)
        lblStudentNameVal.Name = "lblStudentNameVal"
        lblStudentNameVal.Size = New Size(180, 15)
        lblStudentNameVal.TabIndex = 5
        lblStudentNameVal.Text = "-"
        ' 
        ' lblStudentNameTitle
        ' 
        lblStudentNameTitle.AutoSize = True
        lblStudentNameTitle.Font = New Font("Segoe UI", 8F)
        lblStudentNameTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNameTitle.Location = New Point(14, 70)
        lblStudentNameTitle.Name = "lblStudentNameTitle"
        lblStudentNameTitle.Size = New Size(83, 13)
        lblStudentNameTitle.TabIndex = 4
        lblStudentNameTitle.Text = "Student Name:"
        ' 
        ' lblStudentNoVal
        ' 
        lblStudentNoVal.AutoEllipsis = True
        lblStudentNoVal.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        lblStudentNoVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentNoVal.Location = New Point(110, 42)
        lblStudentNoVal.Name = "lblStudentNoVal"
        lblStudentNoVal.Size = New Size(180, 15)
        lblStudentNoVal.TabIndex = 3
        lblStudentNoVal.Text = "-"
        ' 
        ' lblStudentNoTitle
        ' 
        lblStudentNoTitle.AutoSize = True
        lblStudentNoTitle.Font = New Font("Segoe UI", 8F)
        lblStudentNoTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNoTitle.Location = New Point(14, 42)
        lblStudentNoTitle.Name = "lblStudentNoTitle"
        lblStudentNoTitle.Size = New Size(72, 13)
        lblStudentNoTitle.TabIndex = 2
        lblStudentNoTitle.Text = "Student No.:"
        ' 
        ' lblInfoTitle
        ' 
        lblInfoTitle.AutoSize = True
        lblInfoTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblInfoTitle.Location = New Point(36, 14)
        lblInfoTitle.Name = "lblInfoTitle"
        lblInfoTitle.Size = New Size(198, 19)
        lblInfoTitle.TabIndex = 1
        lblInfoTitle.Text = "Student / Submission Details"
        ' 
        ' lblInfoIcon
        ' 
        lblInfoIcon.AutoSize = True
        lblInfoIcon.Font = New Font("Segoe UI Emoji", 11F)
        lblInfoIcon.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblInfoIcon.Location = New Point(14, 14)
        lblInfoIcon.Name = "lblInfoIcon"
        lblInfoIcon.Size = New Size(30, 20)
        lblInfoIcon.TabIndex = 0
        lblInfoIcon.Text = "👤"
        ' 
        ' pnlRightSection
        ' 
        pnlRightSection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlRightSection.Controls.Add(pnlTimelineCard)
        pnlRightSection.Controls.Add(pnlDecisionCard)
        pnlRightSection.Controls.Add(pnlCurrentStatusCard)
        pnlRightSection.Location = New Point(652, 72)
        pnlRightSection.Name = "pnlRightSection"
        pnlRightSection.Size = New Size(328, 658)
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
        pnlTimelineCard.Location = New Point(0, 420)
        pnlTimelineCard.Name = "pnlTimelineCard"
        pnlTimelineCard.Padding = New Padding(12)
        pnlTimelineCard.Size = New Size(328, 238)
        pnlTimelineCard.TabIndex = 2
        ' 

        ' 




        ' dgvTimeline

        dgvTimeline.AllowUserToAddRows = False
        dgvTimeline.AllowUserToDeleteRows = False
        dgvTimeline.AllowUserToResizeRows = False
        dgvTimeline.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvTimeline.BackgroundColor = Color.White
        dgvTimeline.BorderStyle = BorderStyle.None
        dgvTimeline.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvTimelineCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvTimelineCellStyle1.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        dgvTimelineCellStyle1.Font = New Font("Segoe UI Semibold", 8F, FontStyle.Bold)
        dgvTimelineCellStyle1.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        dgvTimelineCellStyle1.SelectionBackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        dgvTimelineCellStyle1.SelectionForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        dgvTimelineCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTimeline.ColumnHeadersDefaultCellStyle = dgvTimelineCellStyle1
        dgvTimeline.ColumnHeadersHeight = 28
        dgvTimeline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTimeline.Columns.AddRange(New DataGridViewColumn() {colActivityAction, colActivityDate, colActivityRemarks})
        dgvTimelineCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvTimelineCellStyle2.BackColor = Color.White
        dgvTimelineCellStyle2.Font = New Font("Segoe UI", 8F)
        dgvTimelineCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        dgvTimelineCellStyle2.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        dgvTimelineCellStyle2.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        dgvTimelineCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTimeline.DefaultCellStyle = dgvTimelineCellStyle2
        dgvTimeline.EnableHeadersVisualStyles = False
        dgvTimeline.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvTimeline.Location = New Point(10, 36)
        dgvTimeline.MultiSelect = False
        dgvTimeline.Name = "dgvTimeline"
        dgvTimeline.ReadOnly = True
        dgvTimeline.RowHeadersVisible = False
        dgvTimeline.RowTemplate.Height = 28
        dgvTimeline.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTimeline.Size = New Size(306, 188)
        dgvTimeline.TabIndex = 1
        ' 
        ' colActivityAction
        ' 
        colActivityAction.HeaderText = "Action"
        colActivityAction.Name = "colActivityAction"
        colActivityAction.ReadOnly = True
        colActivityAction.Width = 85
        ' 
        ' colActivityDate
        ' 
        colActivityDate.HeaderText = "Date / Time"
        colActivityDate.Name = "colActivityDate"
        colActivityDate.ReadOnly = True
        colActivityDate.Width = 105
        ' 
        ' colActivityRemarks
        ' 
        colActivityRemarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colActivityRemarks.HeaderText = "Remarks / Details"
        colActivityRemarks.Name = "colActivityRemarks"
        colActivityRemarks.ReadOnly = True
        ' 
        ' lblTimelineEmpty
        ' 
        lblTimelineEmpty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTimelineEmpty.Font = New Font("Segoe UI", 8F)
        lblTimelineEmpty.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTimelineEmpty.Location = New Point(10, 45)
        lblTimelineEmpty.Name = "lblTimelineEmpty"
        lblTimelineEmpty.Size = New Size(306, 40)
        lblTimelineEmpty.TabIndex = 2
        lblTimelineEmpty.Text = "No previous activity logged."
        lblTimelineEmpty.TextAlign = ContentAlignment.MiddleCenter
        lblTimelineEmpty.Visible = False
        ' 
        ' lblTimelineHeader
        ' 
        lblTimelineHeader.AutoSize = True
        lblTimelineHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblTimelineHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblTimelineHeader.Location = New Point(10, 10)
        lblTimelineHeader.Name = "lblTimelineHeader"
        lblTimelineHeader.Size = New Size(125, 17)
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
        pnlDecisionCard.Location = New Point(0, 96)
        pnlDecisionCard.Name = "pnlDecisionCard"
        pnlDecisionCard.Padding = New Padding(12)
        pnlDecisionCard.Size = New Size(328, 312)
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
        btnBackToRequests.Location = New Point(12, 276)
        btnBackToRequests.Name = "btnBackToRequests"
        btnBackToRequests.Size = New Size(302, 26)
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
        btnReject.Location = New Point(12, 234)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(302, 36)
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
        btnApprove.Location = New Point(12, 192)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(302, 36)
        btnApprove.TabIndex = 4
        btnApprove.Text = "✓  Approve / Clear Submission"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' lblCharCount
        ' 
        lblCharCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCharCount.Font = New Font("Segoe UI", 7F)
        lblCharCount.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblCharCount.Location = New Point(234, 168)
        lblCharCount.Name = "lblCharCount"
        lblCharCount.Size = New Size(80, 14)
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
        txtRemarks.Location = New Point(12, 58)
        txtRemarks.MaxLength = 500
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.PlaceholderText = "Write your remarks or feedback here... (Required if rejecting)"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(302, 106)
        txtRemarks.TabIndex = 2
        ' 
        ' lblRemarksTitle
        ' 
        lblRemarksTitle.AutoSize = True
        lblRemarksTitle.Font = New Font("Segoe UI", 7.5F)
        lblRemarksTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRemarksTitle.Location = New Point(12, 38)
        lblRemarksTitle.Name = "lblRemarksTitle"
        lblRemarksTitle.Size = New Size(241, 12)
        lblRemarksTitle.TabIndex = 1
        lblRemarksTitle.Text = "Remarks (Optional for approval, required for rejection)"
        ' 
        ' lblDecisionHeader
        ' 
        lblDecisionHeader.AutoSize = True
        lblDecisionHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblDecisionHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblDecisionHeader.Location = New Point(10, 10)
        lblDecisionHeader.Name = "lblDecisionHeader"
        lblDecisionHeader.Size = New Size(119, 17)
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
        pnlCurrentStatusCard.Name = "pnlCurrentStatusCard"
        pnlCurrentStatusCard.Padding = New Padding(12)
        pnlCurrentStatusCard.Size = New Size(328, 84)
        pnlCurrentStatusCard.TabIndex = 0
        ' 
        ' lblStatusSubText
        ' 
        lblStatusSubText.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStatusSubText.AutoEllipsis = True
        lblStatusSubText.Font = New Font("Segoe UI", 7.5F)
        lblStatusSubText.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatusSubText.Location = New Point(50, 56)
        lblStatusSubText.Name = "lblStatusSubText"
        lblStatusSubText.Size = New Size(264, 16)
        lblStatusSubText.TabIndex = 3
        lblStatusSubText.Text = "This submission is waiting for your evaluation."
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.AutoSize = True
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStatusBadge.Location = New Point(50, 34)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Size = New Size(91, 17)
        lblStatusBadge.TabIndex = 2
        lblStatusBadge.Text = "Under Review"
        ' 
        ' lblStatusIconBig
        ' 
        lblStatusIconBig.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        lblStatusIconBig.Font = New Font("Segoe UI Emoji", 14F)
        lblStatusIconBig.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStatusIconBig.Location = New Point(10, 32)
        lblStatusIconBig.Name = "lblStatusIconBig"
        lblStatusIconBig.Size = New Size(34, 34)
        lblStatusIconBig.TabIndex = 1
        lblStatusIconBig.Text = "📄"
        lblStatusIconBig.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatusHeader
        ' 
        lblStatusHeader.AutoSize = True
        lblStatusHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStatusHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblStatusHeader.Location = New Point(10, 10)
        lblStatusHeader.Name = "lblStatusHeader"
        lblStatusHeader.Size = New Size(96, 17)
        lblStatusHeader.TabIndex = 0
        lblStatusHeader.Text = "Current Status"
        ' 
        ' ReviewClearanceForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1000, 750)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9F)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ReviewClearanceForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Review Clearance Submission"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlOfficeBadge.ResumeLayout(False)
        pnlOfficeBadge.PerformLayout()
        pnlStaffBadge.ResumeLayout(False)
        pnlStaffBadge.PerformLayout()
        pnlLeftSection.ResumeLayout(False)
        pnlGuidanceInfoNote.ResumeLayout(False)
        pnlGuidanceInfoNote.PerformLayout()
        pnlGuidanceBody.ResumeLayout(False)
        pnlGuidanceBody.PerformLayout()
        pnlGuidanceHeader.ResumeLayout(False)
        pnlGuidanceHeader.PerformLayout()
        pnlGuidanceInfo.ResumeLayout(False)
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
    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents lblStatusVal As Label
End Class
