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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ReviewClearanceForm))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlContentViewport = New Panel()
        pnlCard = New Panel()
        btnClose = New Button()
        btnMinimize = New Button()
        btnEditGuidance = New Button()
        btnSaveGuidance = New Button()
        btnCancelGuidance = New Button()
        txtAddress = New TextBox()
        txtEmergencyName = New TextBox()
        txtContact = New TextBox()
        txtRelationship = New TextBox()
        txtEmail = New TextBox()
        txtEmergencyContact = New TextBox()
        txtCivilStatus = New TextBox()
        txtNotes = New TextBox()
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
        pnlPrerequisiteAccent = New Panel()
        picPrerequisiteStatus = New PictureBox()
        lblPrerequisiteApprovedBy = New Label()
        lblPrerequisiteApproverName = New Label()
        lblPrerequisiteDateCaption = New Label()
        lblPrerequisiteApprovalDate = New Label()
        pnlPrerequisiteApproval = New Panel()
        lblPrerequisiteApprovalTitle = New Label()
        lblPrerequisiteApprovalDetails = New Label()
        pnlSequentialReview = New Panel()
        lblSequentialReviewTitle = New Label()
        lblSequentialReviewInstructions = New Label()
        pnlFinanceVerification = New Panel()
        lblFinanceVerificationTitle = New Label()
        lblFinanceVerificationInstructions = New Label()
        chkFinanceVerified = New CheckBox()
        pnlStudentAffairs = New Panel()
        lblStudentAffairsTitle = New Label()
        lblStudentAffairsInstructions = New Label()
        chkStudentAffairsVerified = New CheckBox()
        pnlLeftSection = New Panel()
        pnlStudentInfoCard = New Panel()
        lblInfoIcon = New Label()
        lblInfoTitle = New Label()
        lblStudentNoTitle = New Label()
        lblStudentNoVal = New Label()
        lblStudentNameTitle = New Label()
        lblStudentNameVal = New Label()
        lblCourseTitle = New Label()
        lblCourseVal = New Label()
        lblYearTitle = New Label()
        lblYearVal = New Label()
        lblOfficeTitle = New Label()
        lblOfficeVal = New Label()
        lblReqTitle = New Label()
        lblReqVal = New Label()
        lblDateTitle = New Label()
        lblDateVal = New Label()
        lblFileTitle = New Label()
        lblFileVal = New Label()
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
        lblPdfIcon = New Label()
        lblPdfPrompt = New Label()
        lblPdfSub = New Label()
        btnOpenPdfCenter = New Button()
        pnlGuidanceInfo = New Panel()
        pnlGuidanceBody = New Panel()
        pnlGuidanceNoUpdate = New Panel()
        pnlGuidanceNoUpdateCard = New Panel()
        lblNoUpdateIcon = New Label()
        lblNoUpdateTitle = New Label()
        lblNoUpdateMessage = New Label()
        pnlGuidanceFields = New Panel()
        lblAddressTitle = New Label()
        lblAddressValue = New Label()
        lblEmergencyNameTitle = New Label()
        lblEmergencyNameValue = New Label()
        lblContactTitle = New Label()
        lblContactValue = New Label()
        lblRelationshipTitle = New Label()
        lblRelationshipValue = New Label()
        lblEmailTitle = New Label()
        lblEmailValue = New Label()
        lblEmergencyContactTitle = New Label()
        lblEmergencyContactValue = New Label()
        lblCivilStatusTitle = New Label()
        lblCivilStatusValue = New Label()
        lblNotesTitle = New Label()
        lblNotesValue = New Label()
        pnlGuidanceInfoNote = New Panel()
        lblGuidanceNoteIcon = New Label()
        lblGuidanceInfoNote = New Label()
        pnlGuidanceHeader = New Panel()
        lblGuidanceIcon = New Label()
        lblGuidanceInfoTitle = New Label()
        lblGuidanceInfoSubtitle = New Label()
        pnlClinicInfo = New Panel()
        pnlClinicHeader = New Panel()
        lblClinicIcon = New Label()
        lblClinicInfoTitle = New Label()
        lblClinicInfoSubtitle = New Label()
        btnOpenAssessmentModal = New Button()
        pnlClinicBody = New Panel()
        pnlClinicRestricted = New Panel()
        pnlClinicRestrictedCard = New Panel()
        lblRestrictedIcon = New Label()
        lblRestrictedTitle = New Label()
        lblRestrictedMessage = New Label()
        pnlClinicNoUpdate = New Panel()
        pnlClinicNoUpdateCard = New Panel()
        lblClinicNoUpdateIcon = New Label()
        lblClinicNoUpdateTitle = New Label()
        lblClinicNoUpdateMessage = New Label()
        pnlClinicFields = New Panel()
        lblClinicMedLabel = New Label()
        lblClinicMedVal = New Label()
        lblClinicAlgLabel = New Label()
        lblClinicAlgVal = New Label()
        lblClinicMedsLabel = New Label()
        lblClinicMedsVal = New Label()
        lblClinicConcernsLabel = New Label()
        lblClinicConcernsVal = New Label()
        lblClinicEmLabel = New Label()
        lblClinicEmVal = New Label()
        lblClinicDecLabel = New Label()
        lblClinicDecVal = New Label()
        lblClinicDocLabel = New Label()
        lblClinicDocVal = New Label()
        btnViewClinicDoc = New Button()
        pnlRightSection = New Panel()
        pnlCurrentStatusCard = New Panel()
        lblStatusHeader = New Label()
        lblStatusIconBig = New Label()
        lblStatusBadge = New Label()
        lblStatusSubText = New Label()
        pnlDecisionCard = New Panel()
        lblDecisionHeader = New Label()
        lblRemarksTitle = New Label()
        txtRemarks = New TextBox()
        lblCharCount = New Label()
        btnApprove = New Button()
        btnReject = New Button()
        btnBackToRequests = New Button()
        pnlTimelineCard = New Panel()
        lblTimelineHeader = New Label()
        dgvTimeline = New DataGridView()
        colActivityAction = New DataGridViewTextBoxColumn()
        colActivityDate = New DataGridViewTextBoxColumn()
        colActivityRemarks = New DataGridViewTextBoxColumn()
        lblTimelineEmpty = New Label()
        pnlCard.SuspendLayout()
        pnlOfficeBadge.SuspendLayout()
        pnlStaffBadge.SuspendLayout()
        pnlLeftSection.SuspendLayout()
        pnlStudentInfoCard.SuspendLayout()
        pnlDocumentCard.SuspendLayout()
        pnlDocPreview.SuspendLayout()
        CType(picPreview, ComponentModel.ISupportInitialize).BeginInit()
        pnlPdfFallback.SuspendLayout()
        pnlGuidanceInfo.SuspendLayout()
        pnlGuidanceBody.SuspendLayout()
        pnlGuidanceNoUpdate.SuspendLayout()
        pnlGuidanceNoUpdateCard.SuspendLayout()
        pnlGuidanceFields.SuspendLayout()
        pnlGuidanceInfoNote.SuspendLayout()
        pnlGuidanceHeader.SuspendLayout()
        pnlClinicInfo.SuspendLayout()
        pnlClinicHeader.SuspendLayout()
        pnlClinicBody.SuspendLayout()
        pnlClinicRestricted.SuspendLayout()
        pnlClinicRestrictedCard.SuspendLayout()
        pnlClinicNoUpdate.SuspendLayout()
        pnlClinicNoUpdateCard.SuspendLayout()
        pnlClinicFields.SuspendLayout()
        pnlRightSection.SuspendLayout()
        pnlCurrentStatusCard.SuspendLayout()
        pnlDecisionCard.SuspendLayout()
        pnlTimelineCard.SuspendLayout()
        CType(dgvTimeline, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlCard.BorderStyle = BorderStyle.FixedSingle


        pnlCard.Controls.Add(lblHeaderTitle)
        pnlCard.Controls.Add(lblHeaderSub)
        pnlCard.Controls.Add(pnlOfficeBadge)
        pnlCard.Controls.Add(pnlStaffBadge)
        pnlCard.Controls.Add(lblDateTimeBadge)
        pnlCard.Controls.Add(pnlLeftSection)
        pnlCard.Controls.Add(pnlRightSection)
        pnlCard.Dock = DockStyle.None
        pnlCard.Location = New Point(0, 0)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(1140, 748)
        pnlCard.TabIndex = 0
        ' 
        ' btnMinimize
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BackColor = Color.Transparent
        btnMinimize.Cursor = Cursors.Hand
        btnMinimize.FlatAppearance.BorderSize = 0
        btnMinimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnMinimize.FlatStyle = FlatStyle.Flat
        btnMinimize.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnMinimize.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnMinimize.Location = New Point(1046, 13)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.Size = New Size(38, 40)
        btnMinimize.TabIndex = 3
        btnMinimize.Text = "-"
        btnMinimize.UseVisualStyleBackColor = False
        ' btnEditGuidance
        btnEditGuidance.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnEditGuidance.BackColor = Color.FromArgb(15, 39, 74)
        btnEditGuidance.ForeColor = Color.White
        btnEditGuidance.FlatStyle = FlatStyle.Flat
        btnEditGuidance.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnEditGuidance.Location = New Point(550, 15)
        btnEditGuidance.Name = "btnEditGuidance"
        btnEditGuidance.Size = New Size(125, 30)
        btnEditGuidance.Text = "✎ Edit Information"
        btnEditGuidance.Cursor = Cursors.Hand
        btnEditGuidance.UseVisualStyleBackColor = False
        btnEditGuidance.Visible = False
        ' btnSaveGuidance
        btnSaveGuidance.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSaveGuidance.BackColor = Color.FromArgb(22, 163, 74)
        btnSaveGuidance.ForeColor = Color.White
        btnSaveGuidance.FlatStyle = FlatStyle.Flat
        btnSaveGuidance.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnSaveGuidance.Location = New Point(420, 15)
        btnSaveGuidance.Name = "btnSaveGuidance"
        btnSaveGuidance.Size = New Size(120, 30)
        btnSaveGuidance.Text = "✓ Save Changes"
        btnSaveGuidance.Cursor = Cursors.Hand
        btnSaveGuidance.UseVisualStyleBackColor = False
        btnSaveGuidance.Visible = False
        ' btnCancelGuidance
        btnCancelGuidance.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCancelGuidance.BackColor = Color.White
        btnCancelGuidance.ForeColor = Color.FromArgb(51, 65, 85)
        btnCancelGuidance.FlatStyle = FlatStyle.Flat
        btnCancelGuidance.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnCancelGuidance.Location = New Point(550, 15)
        btnCancelGuidance.Name = "btnCancelGuidance"
        btnCancelGuidance.Size = New Size(125, 30)
        btnCancelGuidance.Text = "✗ Cancel"
        btnCancelGuidance.Cursor = Cursors.Hand
        btnCancelGuidance.UseVisualStyleBackColor = False
        btnCancelGuidance.Visible = False
        ' txtAddress
        txtAddress.Location = New Point(18, 32)
        txtAddress.Size = New Size(310, 36)
        txtAddress.Font = New Font("Segoe UI", 9.0F)
        txtAddress.Multiline = True
        txtAddress.Visible = False
        ' txtEmergencyName
        txtEmergencyName.Location = New Point(354, 32)
        txtEmergencyName.Size = New Size(310, 36)
        txtEmergencyName.Font = New Font("Segoe UI", 9.0F)
        txtEmergencyName.Multiline = True
        txtEmergencyName.Visible = False
        ' txtContact
        txtContact.Location = New Point(18, 98)
        txtContact.Size = New Size(310, 36)
        txtContact.Font = New Font("Segoe UI", 9.0F)
        txtContact.Multiline = True
        txtContact.Visible = False
        ' txtRelationship
        txtRelationship.Location = New Point(354, 98)
        txtRelationship.Size = New Size(310, 36)
        txtRelationship.Font = New Font("Segoe UI", 9.0F)
        txtRelationship.Multiline = True
        txtRelationship.Visible = False
        ' txtEmail
        txtEmail.Location = New Point(18, 164)
        txtEmail.Size = New Size(310, 36)
        txtEmail.Font = New Font("Segoe UI", 9.0F)
        txtEmail.Multiline = True
        txtEmail.Visible = False
        ' txtEmergencyContact
        txtEmergencyContact.Location = New Point(354, 164)
        txtEmergencyContact.Size = New Size(310, 36)
        txtEmergencyContact.Font = New Font("Segoe UI", 9.0F)
        txtEmergencyContact.Multiline = True
        txtEmergencyContact.Visible = False
        ' txtCivilStatus
        txtCivilStatus.Location = New Point(18, 230)
        txtCivilStatus.Size = New Size(310, 36)
        txtCivilStatus.Font = New Font("Segoe UI", 9.0F)
        txtCivilStatus.Multiline = True
        txtCivilStatus.Visible = False
        ' txtNotes
        txtNotes.Location = New Point(354, 230)
        txtNotes.Size = New Size(310, 36)
        txtNotes.Font = New Font("Segoe UI", 9.0F)
        txtNotes.Multiline = True
        txtNotes.Visible = False
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12.0F)
        btnClose.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnClose.Location = New Point(1086, 13)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(38, 40)
        btnClose.TabIndex = 2
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(20, 14)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(361, 35)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Review Clearance Submission"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 8.0F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHeaderSub.Location = New Point(22, 52)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(413, 19)
        lblHeaderSub.TabIndex = 1
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
        pnlOfficeBadge.Location = New Point(550, 14)
        pnlOfficeBadge.Name = "pnlOfficeBadge"
        pnlOfficeBadge.Size = New Size(260, 62)
        pnlOfficeBadge.TabIndex = 3
        ' 
        ' lblOfficeIcon
        ' 
        lblOfficeIcon.Font = New Font("Segoe UI Emoji", 14.0F)
        lblOfficeIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblOfficeIcon.Location = New Point(8, 12)
        lblOfficeIcon.Name = "lblOfficeIcon"
        lblOfficeIcon.Size = New Size(32, 34)
        lblOfficeIcon.TabIndex = 0
        lblOfficeIcon.Text = "🏛"
        lblOfficeIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeName
        ' 
        lblOfficeName.AutoEllipsis = True
        lblOfficeName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblOfficeName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeName.Location = New Point(44, 8)
        lblOfficeName.Name = "lblOfficeName"
        lblOfficeName.Size = New Size(204, 28)
        lblOfficeName.TextAlign = ContentAlignment.MiddleLeft
        lblOfficeName.TabIndex = 1
        lblOfficeName.Text = "Guidance Office"
        ' 
        ' lblOfficeSub
        ' 
        lblOfficeSub.Font = New Font("Segoe UI", 7.5F)
        lblOfficeSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeSub.Location = New Point(44, 36)
        lblOfficeSub.Name = "lblOfficeSub"
        lblOfficeSub.Size = New Size(204, 18)
        lblOfficeSub.TabIndex = 2
        lblOfficeSub.Text = "Assigned Office"
        ' 
        ' pnlStaffBadge
        ' 
        pnlStaffBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlStaffBadge.BackColor = Color.White
        pnlStaffBadge.BorderStyle = BorderStyle.FixedSingle
        pnlStaffBadge.Controls.Add(lblStaffIcon)
        pnlStaffBadge.Controls.Add(lblStaffName)
        pnlStaffBadge.Controls.Add(lblStaffRole)
        pnlStaffBadge.Location = New Point(822, 14)
        pnlStaffBadge.Name = "pnlStaffBadge"
        pnlStaffBadge.Size = New Size(210, 62)
        pnlStaffBadge.TabIndex = 4
        ' 
        ' lblStaffIcon
        ' 
        lblStaffIcon.Font = New Font("Segoe UI Emoji", 14.0F)
        lblStaffIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblStaffIcon.Location = New Point(8, 12)
        lblStaffIcon.Name = "lblStaffIcon"
        lblStaffIcon.Size = New Size(32, 34)
        lblStaffIcon.TabIndex = 0
        lblStaffIcon.Text = "👤"
        lblStaffIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStaffName
        ' 
        lblStaffName.AutoEllipsis = True
        lblStaffName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblStaffName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStaffName.Location = New Point(44, 8)
        lblStaffName.Name = "lblStaffName"
        lblStaffName.Size = New Size(154, 28)
        lblStaffName.TextAlign = ContentAlignment.MiddleLeft
        lblStaffName.TabIndex = 1
        lblStaffName.Text = "Department Head"
        ' 
        ' lblStaffRole
        ' 
        lblStaffRole.Font = New Font("Segoe UI", 7.5F)
        lblStaffRole.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStaffRole.Location = New Point(44, 36)
        lblStaffRole.Name = "lblStaffRole"
        lblStaffRole.Size = New Size(154, 18)
        lblStaffRole.TabIndex = 2
        lblStaffRole.Text = "Clearing Officer"
        ' 
        ' lblDateTimeBadge
        ' 
        lblDateTimeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblDateTimeBadge.Font = New Font("Segoe UI", 7.0F)
        lblDateTimeBadge.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTimeBadge.Location = New Point(22, 78)
        lblDateTimeBadge.Name = "lblDateTimeBadge"
        lblDateTimeBadge.Size = New Size(490, 22)
        lblDateTimeBadge.TabIndex = 5
        lblDateTimeBadge.Text = "Today"
        lblDateTimeBadge.TextAlign = ContentAlignment.MiddleLeft        ' Office of Student Affairs verification controls remain editable in Designer.
        pnlPrerequisiteAccent.Dock = DockStyle.Left
        pnlPrerequisiteAccent.BackColor = Color.FromArgb(37, 99, 235)
        pnlPrerequisiteAccent.Size = New Size(5, 98)
        pnlPrerequisiteAccent.Name = "pnlPrerequisiteAccent"
        picPrerequisiteStatus.Location = New Point(20, 18)
        picPrerequisiteStatus.Size = New Size(64, 64)
        picPrerequisiteStatus.SizeMode = PictureBoxSizeMode.Zoom
        picPrerequisiteStatus.Image = CType(resources.GetObject("PrerequisiteInfoIcon"), Image)
        picPrerequisiteStatus.Name = "picPrerequisiteStatus"
        picPrerequisiteStatus.TabStop = False
        lblPrerequisiteApprovedBy.Location = New Point(100, 45)
        lblPrerequisiteApprovedBy.Size = New Size(90, 20)
        lblPrerequisiteApprovedBy.Font = New Font("Segoe UI", 9.5F)
        lblPrerequisiteApprovedBy.ForeColor = Color.FromArgb(100, 116, 139)
        lblPrerequisiteApprovedBy.Text = "Approved by:"
        lblPrerequisiteApprovedBy.Name = "lblPrerequisiteApprovedBy"
        lblPrerequisiteApprovedBy.Visible = False
        lblPrerequisiteApproverName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPrerequisiteApproverName.Location = New Point(195, 45)
        lblPrerequisiteApproverName.Size = New Size(480, 20)
        lblPrerequisiteApproverName.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblPrerequisiteApproverName.ForeColor = Color.FromArgb(15, 23, 42)
        lblPrerequisiteApproverName.AutoEllipsis = True
        lblPrerequisiteApproverName.Name = "lblPrerequisiteApproverName"
        lblPrerequisiteApproverName.Visible = False
        lblPrerequisiteDateCaption.Location = New Point(100, 69)
        lblPrerequisiteDateCaption.Size = New Size(90, 20)
        lblPrerequisiteDateCaption.Font = New Font("Segoe UI", 9.5F)
        lblPrerequisiteDateCaption.ForeColor = Color.FromArgb(100, 116, 139)
        lblPrerequisiteDateCaption.Text = "Date:"
        lblPrerequisiteDateCaption.Name = "lblPrerequisiteDateCaption"
        lblPrerequisiteDateCaption.Visible = False
        lblPrerequisiteApprovalDate.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPrerequisiteApprovalDate.Location = New Point(195, 69)
        lblPrerequisiteApprovalDate.Size = New Size(480, 20)
        lblPrerequisiteApprovalDate.Font = New Font("Segoe UI", 9.5F)
        lblPrerequisiteApprovalDate.ForeColor = Color.FromArgb(15, 23, 42)
        lblPrerequisiteApprovalDate.Name = "lblPrerequisiteApprovalDate"
        lblPrerequisiteApprovalDate.Visible = False
        pnlPrerequisiteApproval.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPrerequisiteApproval.AutoScroll = True
        pnlPrerequisiteApproval.BackColor = Color.FromArgb(239, 246, 255)
        pnlPrerequisiteApproval.BorderStyle = BorderStyle.FixedSingle
        pnlPrerequisiteApproval.Location = New Point(0, 202)
        pnlPrerequisiteApproval.Size = New Size(700, 100)
        pnlPrerequisiteApproval.Name = "pnlPrerequisiteApproval"
        pnlPrerequisiteApproval.Controls.Add(pnlPrerequisiteAccent)
        pnlPrerequisiteApproval.Controls.Add(picPrerequisiteStatus)
        pnlPrerequisiteApproval.Controls.Add(lblPrerequisiteApprovedBy)
        pnlPrerequisiteApproval.Controls.Add(lblPrerequisiteApproverName)
        pnlPrerequisiteApproval.Controls.Add(lblPrerequisiteDateCaption)
        pnlPrerequisiteApproval.Controls.Add(lblPrerequisiteApprovalDate)
        pnlPrerequisiteApproval.Controls.Add(lblPrerequisiteApprovalTitle)
        pnlPrerequisiteApproval.Controls.Add(lblPrerequisiteApprovalDetails)
        lblPrerequisiteApprovalTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblPrerequisiteApprovalTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblPrerequisiteApprovalTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblPrerequisiteApprovalTitle.Location = New Point(100, 9)
        lblPrerequisiteApprovalTitle.Size = New Size(575, 30)
        lblPrerequisiteApprovalTitle.Name = "lblPrerequisiteApprovalTitle"
        lblPrerequisiteApprovalTitle.Text = "Prerequisite approvals"
        lblPrerequisiteApprovalDetails.AutoSize = True
        lblPrerequisiteApprovalDetails.MaximumSize = New Size(565, 0)
        lblPrerequisiteApprovalDetails.Font = New Font("Segoe UI", 9F)
        lblPrerequisiteApprovalDetails.ForeColor = Color.FromArgb(71, 85, 105)
        lblPrerequisiteApprovalDetails.Location = New Point(100, 44)
        lblPrerequisiteApprovalDetails.Size = New Size(650, 32)
        lblPrerequisiteApprovalDetails.Name = "lblPrerequisiteApprovalDetails"
        lblPrerequisiteApprovalDetails.Text = "Office approval details"
        pnlSequentialReview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSequentialReview.BackColor = Color.White
        pnlSequentialReview.BorderStyle = BorderStyle.FixedSingle
        pnlSequentialReview.Location = New Point(0, 314)
        pnlSequentialReview.Size = New Size(700, 140)
        pnlSequentialReview.Name = "pnlSequentialReview"
        pnlSequentialReview.Visible = False
        pnlSequentialReview.Controls.Add(lblSequentialReviewTitle)
        pnlSequentialReview.Controls.Add(lblSequentialReviewInstructions)
        lblSequentialReviewTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblSequentialReviewTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblSequentialReviewTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblSequentialReviewTitle.Location = New Point(24, 22)
        lblSequentialReviewTitle.Size = New Size(650, 30)
        lblSequentialReviewTitle.Name = "lblSequentialReviewTitle"
        lblSequentialReviewTitle.Text = "Clearance Review"
        lblSequentialReviewInstructions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblSequentialReviewInstructions.Font = New Font("Segoe UI", 10F)
        lblSequentialReviewInstructions.ForeColor = Color.FromArgb(71, 85, 105)
        lblSequentialReviewInstructions.Location = New Point(24, 62)
        lblSequentialReviewInstructions.Size = New Size(650, 46)
        lblSequentialReviewInstructions.Name = "lblSequentialReviewInstructions"
        lblSequentialReviewInstructions.Text = "Review the submitted request after the preceding office has approved clearance."
        pnlFinanceVerification.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFinanceVerification.BackColor = Color.White
        pnlFinanceVerification.BorderStyle = BorderStyle.FixedSingle
        pnlFinanceVerification.Location = New Point(0, 314)
        pnlFinanceVerification.Size = New Size(700, 190)
        pnlFinanceVerification.Name = "pnlFinanceVerification"
        pnlFinanceVerification.Visible = False
        pnlFinanceVerification.Controls.Add(lblFinanceVerificationTitle)
        pnlFinanceVerification.Controls.Add(lblFinanceVerificationInstructions)
        pnlFinanceVerification.Controls.Add(chkFinanceVerified)
        lblFinanceVerificationTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFinanceVerificationTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblFinanceVerificationTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblFinanceVerificationTitle.Location = New Point(24, 22)
        lblFinanceVerificationTitle.Size = New Size(650, 30)
        lblFinanceVerificationTitle.Name = "lblFinanceVerificationTitle"
        lblFinanceVerificationTitle.Text = "Finance Payment Verification"
        lblFinanceVerificationInstructions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblFinanceVerificationInstructions.Font = New Font("Segoe UI", 10F)
        lblFinanceVerificationInstructions.ForeColor = Color.FromArgb(71, 85, 105)
        lblFinanceVerificationInstructions.Location = New Point(24, 62)
        lblFinanceVerificationInstructions.Size = New Size(650, 46)
        lblFinanceVerificationInstructions.Name = "lblFinanceVerificationInstructions"
        lblFinanceVerificationInstructions.Text = "Verify the student's payment status. Approve if fully paid; otherwise, return with remarks."
        chkFinanceVerified.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        chkFinanceVerified.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        chkFinanceVerified.ForeColor = Color.FromArgb(15, 23, 42)
        chkFinanceVerified.Location = New Point(24, 124)
        chkFinanceVerified.Size = New Size(650, 40)
        chkFinanceVerified.Name = "chkFinanceVerified"
        chkFinanceVerified.Text = "Payment verified. No outstanding balance."
        chkFinanceVerified.TabIndex = 0
        chkFinanceVerified.UseVisualStyleBackColor = True
        pnlStudentAffairs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudentAffairs.BackColor = Color.White
        pnlStudentAffairs.BorderStyle = BorderStyle.FixedSingle
        pnlStudentAffairs.Location = New Point(0, 314)
        pnlStudentAffairs.Name = "pnlStudentAffairs"
        pnlStudentAffairs.Size = New Size(700, 304)
        pnlStudentAffairs.Visible = False
        pnlStudentAffairs.Controls.Add(lblStudentAffairsTitle)
        pnlStudentAffairs.Controls.Add(lblStudentAffairsInstructions)
        pnlStudentAffairs.Controls.Add(chkStudentAffairsVerified)
        lblStudentAffairsTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStudentAffairsTitle.Font = New Font("Segoe UI", 13F, FontStyle.Bold)
        lblStudentAffairsTitle.Location = New Point(20, 20)
        lblStudentAffairsTitle.Size = New Size(655, 34)
        lblStudentAffairsTitle.Name = "lblStudentAffairsTitle"
        lblStudentAffairsTitle.Text = "Office of Student Affairs Verification"
        lblStudentAffairsInstructions.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStudentAffairsInstructions.Font = New Font("Segoe UI", 10F)
        lblStudentAffairsInstructions.Location = New Point(20, 72)
        lblStudentAffairsInstructions.Size = New Size(655, 140)
        lblStudentAffairsInstructions.Name = "lblStudentAffairsInstructions"
        lblStudentAffairsInstructions.Text = "Check the student record before making a decision. Students without outstanding concerns do not need an office visit." & vbCrLf & vbCrLf & "If there is an unresolved concern, return the request with remarks explaining the required compliance and any necessary office visit. Approve only after compliance has been verified."
        chkStudentAffairsVerified.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        chkStudentAffairsVerified.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        chkStudentAffairsVerified.Location = New Point(20, 232)
        chkStudentAffairsVerified.Size = New Size(655, 64)
        chkStudentAffairsVerified.Name = "chkStudentAffairsVerified"
        chkStudentAffairsVerified.Text = "I verified the student record and confirm that there are no unresolved concerns."
        chkStudentAffairsVerified.TabIndex = 0
        chkStudentAffairsVerified.UseVisualStyleBackColor = True

        ' 
        ' pnlLeftSection
        ' 
        pnlLeftSection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlLeftSection.Controls.Add(pnlPrerequisiteApproval)
        pnlLeftSection.Controls.Add(pnlSequentialReview)
        pnlLeftSection.Controls.Add(pnlFinanceVerification)
        pnlLeftSection.Controls.Add(pnlStudentAffairs)
        pnlLeftSection.Controls.Add(pnlStudentInfoCard)
        pnlLeftSection.Controls.Add(pnlDocumentCard)
        pnlLeftSection.Controls.Add(pnlGuidanceInfo)
        pnlLeftSection.Controls.Add(pnlClinicInfo)
        pnlLeftSection.Location = New Point(20, 110)
        pnlLeftSection.Name = "pnlLeftSection"
        pnlLeftSection.Size = New Size(700, 618)
        pnlLeftSection.TabIndex = 6
        ' 
        ' pnlStudentInfoCard
        ' 
        pnlStudentInfoCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudentInfoCard.BackColor = Color.White
        pnlStudentInfoCard.BorderStyle = BorderStyle.FixedSingle
        pnlStudentInfoCard.Controls.Add(lblInfoIcon)
        pnlStudentInfoCard.Controls.Add(lblInfoTitle)
        pnlStudentInfoCard.Controls.Add(lblStudentNoTitle)
        pnlStudentInfoCard.Controls.Add(lblStudentNoVal)
        pnlStudentInfoCard.Controls.Add(lblStudentNameTitle)
        pnlStudentInfoCard.Controls.Add(lblStudentNameVal)
        pnlStudentInfoCard.Controls.Add(lblCourseTitle)
        pnlStudentInfoCard.Controls.Add(lblCourseVal)
        pnlStudentInfoCard.Controls.Add(lblYearTitle)
        pnlStudentInfoCard.Controls.Add(lblYearVal)
        pnlStudentInfoCard.Controls.Add(lblOfficeTitle)
        pnlStudentInfoCard.Controls.Add(lblOfficeVal)
        pnlStudentInfoCard.Controls.Add(lblReqTitle)
        pnlStudentInfoCard.Controls.Add(lblReqVal)
        pnlStudentInfoCard.Controls.Add(lblDateTitle)
        pnlStudentInfoCard.Controls.Add(lblDateVal)
        pnlStudentInfoCard.Controls.Add(lblFileTitle)
        pnlStudentInfoCard.Controls.Add(lblFileVal)
        pnlStudentInfoCard.Controls.Add(lblStatusTitle)
        pnlStudentInfoCard.Controls.Add(lblStatusVal)
        pnlStudentInfoCard.Location = New Point(0, 0)
        pnlStudentInfoCard.Name = "pnlStudentInfoCard"
        pnlStudentInfoCard.Size = New Size(700, 190)
        pnlStudentInfoCard.TabIndex = 0
        ' 
        ' lblInfoIcon
        ' 
        lblInfoIcon.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblInfoIcon.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblInfoIcon.Location = New Point(14, 13)
        lblInfoIcon.Name = "lblInfoIcon"
        lblInfoIcon.Size = New Size(22, 24)
        lblInfoIcon.TabIndex = 0
        lblInfoIcon.Text = "i"
        lblInfoIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblInfoTitle
        ' 
        lblInfoTitle.AutoSize = True
        lblInfoTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblInfoTitle.Location = New Point(40, 14)
        lblInfoTitle.Name = "lblInfoTitle"
        lblInfoTitle.Size = New Size(230, 21)
        lblInfoTitle.TabIndex = 1
        lblInfoTitle.Text = "Student / Submission Details"
        ' 
        ' lblStudentNoTitle
        ' 
        lblStudentNoTitle.AutoSize = True
        lblStudentNoTitle.Font = New Font("Segoe UI", 7.5F)
        lblStudentNoTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNoTitle.Location = New Point(14, 50)
        lblStudentNoTitle.Name = "lblStudentNoTitle"
        lblStudentNoTitle.Size = New Size(80, 17)
        lblStudentNoTitle.TabIndex = 2
        lblStudentNoTitle.Text = "Student No.:"
        ' 
        ' lblStudentNoVal
        ' 
        lblStudentNoVal.AutoEllipsis = True
        lblStudentNoVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblStudentNoVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentNoVal.Location = New Point(112, 50)
        lblStudentNoVal.Name = "lblStudentNoVal"
        lblStudentNoVal.Size = New Size(205, 19)
        lblStudentNoVal.TabIndex = 3
        lblStudentNoVal.Text = "-"
        ' 
        ' lblStudentNameTitle
        ' 
        lblStudentNameTitle.AutoSize = True
        lblStudentNameTitle.Font = New Font("Segoe UI", 7.5F)
        lblStudentNameTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNameTitle.Location = New Point(14, 82)
        lblStudentNameTitle.Name = "lblStudentNameTitle"
        lblStudentNameTitle.Size = New Size(94, 17)
        lblStudentNameTitle.TabIndex = 4
        lblStudentNameTitle.Text = "Student Name:"
        ' 
        ' lblStudentNameVal
        ' 
        lblStudentNameVal.AutoEllipsis = True
        lblStudentNameVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblStudentNameVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentNameVal.Location = New Point(112, 82)
        lblStudentNameVal.Name = "lblStudentNameVal"
        lblStudentNameVal.Size = New Size(205, 19)
        lblStudentNameVal.TabIndex = 5
        lblStudentNameVal.Text = "-"
        ' 
        ' lblCourseTitle
        ' 
        lblCourseTitle.AutoSize = True
        lblCourseTitle.Font = New Font("Segoe UI", 7.5F)
        lblCourseTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblCourseTitle.Location = New Point(14, 114)
        lblCourseTitle.Name = "lblCourseTitle"
        lblCourseTitle.Size = New Size(52, 17)
        lblCourseTitle.TabIndex = 6
        lblCourseTitle.Text = "Course:"
        ' 
        ' lblCourseVal
        ' 
        lblCourseVal.AutoEllipsis = True
        lblCourseVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblCourseVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCourseVal.Location = New Point(112, 114)
        lblCourseVal.Name = "lblCourseVal"
        lblCourseVal.Size = New Size(205, 19)
        lblCourseVal.TabIndex = 7
        lblCourseVal.Text = "-"
        ' 
        ' lblYearTitle
        ' 
        lblYearTitle.AutoSize = True
        lblYearTitle.Font = New Font("Segoe UI", 7.5F)
        lblYearTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblYearTitle.Location = New Point(14, 146)
        lblYearTitle.Name = "lblYearTitle"
        lblYearTitle.Size = New Size(69, 17)
        lblYearTitle.TabIndex = 8
        lblYearTitle.Text = "Year Level:"
        ' 
        ' lblYearVal
        ' 
        lblYearVal.AutoEllipsis = True
        lblYearVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblYearVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblYearVal.Location = New Point(112, 146)
        lblYearVal.Name = "lblYearVal"
        lblYearVal.Size = New Size(205, 19)
        lblYearVal.TabIndex = 9
        lblYearVal.Text = "-"
        ' 
        ' lblOfficeTitle
        ' 
        lblOfficeTitle.AutoSize = True
        lblOfficeTitle.Font = New Font("Segoe UI", 7.5F)
        lblOfficeTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeTitle.Location = New Point(350, 50)
        lblOfficeTitle.Name = "lblOfficeTitle"
        lblOfficeTitle.Size = New Size(45, 17)
        lblOfficeTitle.TabIndex = 10
        lblOfficeTitle.Text = "Office:"
        ' 
        ' lblOfficeVal
        ' 
        lblOfficeVal.AutoEllipsis = True
        lblOfficeVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblOfficeVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeVal.Location = New Point(445, 50)
        lblOfficeVal.Name = "lblOfficeVal"
        lblOfficeVal.Size = New Size(235, 19)
        lblOfficeVal.TabIndex = 11
        lblOfficeVal.Text = "-"
        ' 
        ' lblReqTitle
        ' 
        lblReqTitle.AutoSize = True
        lblReqTitle.Font = New Font("Segoe UI", 7.5F)
        lblReqTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblReqTitle.Location = New Point(350, 82)
        lblReqTitle.Name = "lblReqTitle"
        lblReqTitle.Size = New Size(85, 17)
        lblReqTitle.TabIndex = 12
        lblReqTitle.Text = "Requirement:"
        ' 
        ' lblReqVal
        ' 
        lblReqVal.AutoEllipsis = True
        lblReqVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblReqVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblReqVal.Location = New Point(445, 82)
        lblReqVal.Name = "lblReqVal"
        lblReqVal.Size = New Size(235, 19)
        lblReqVal.TabIndex = 13
        lblReqVal.Text = "-"
        ' 
        ' lblDateTitle
        ' 
        lblDateTitle.AutoSize = True
        lblDateTitle.Font = New Font("Segoe UI", 7.5F)
        lblDateTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTitle.Location = New Point(350, 114)
        lblDateTitle.Name = "lblDateTitle"
        lblDateTitle.Size = New Size(86, 17)
        lblDateTitle.TabIndex = 14
        lblDateTitle.Text = "Submitted At:"
        ' 
        ' lblDateVal
        ' 
        lblDateVal.AutoEllipsis = True
        lblDateVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblDateVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDateVal.Location = New Point(445, 114)
        lblDateVal.Name = "lblDateVal"
        lblDateVal.Size = New Size(235, 19)
        lblDateVal.TabIndex = 15
        lblDateVal.Text = "-"
        ' 
        ' lblFileTitle
        ' 
        lblFileTitle.AutoSize = True
        lblFileTitle.Font = New Font("Segoe UI", 7.5F)
        lblFileTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblFileTitle.Location = New Point(350, 146)
        lblFileTitle.Name = "lblFileTitle"
        lblFileTitle.Size = New Size(69, 17)
        lblFileTitle.TabIndex = 16
        lblFileTitle.Text = "File Name:"
        ' 
        ' lblFileVal
        ' 
        lblFileVal.AutoEllipsis = True
        lblFileVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblFileVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblFileVal.Location = New Point(445, 146)
        lblFileVal.Name = "lblFileVal"
        lblFileVal.Size = New Size(235, 19)
        lblFileVal.TabIndex = 17
        lblFileVal.Text = "-"
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Segoe UI", 7.5F)
        lblStatusTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatusTitle.Location = New Point(350, 146)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(46, 17)
        lblStatusTitle.TabIndex = 18
        lblStatusTitle.Text = "Status:"
        lblStatusTitle.Visible = False
        ' 
        ' lblStatusVal
        ' 
        lblStatusVal.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblStatusVal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblStatusVal.ForeColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        lblStatusVal.Location = New Point(445, 141)
        lblStatusVal.Name = "lblStatusVal"
        lblStatusVal.Size = New Size(125, 27)
        lblStatusVal.TabIndex = 19
        lblStatusVal.Text = "Under Review"
        lblStatusVal.TextAlign = ContentAlignment.MiddleCenter
        lblStatusVal.Visible = False
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
        pnlDocumentCard.Location = New Point(0, 314)
        pnlDocumentCard.Name = "pnlDocumentCard"
        pnlDocumentCard.Size = New Size(700, 304)
        pnlDocumentCard.TabIndex = 1
        ' 
        ' cmbSubmittedFiles
        ' 
        cmbSubmittedFiles.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbSubmittedFiles.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSubmittedFiles.Font = New Font("Segoe UI", 7.5F)
        cmbSubmittedFiles.FormattingEnabled = True
        cmbSubmittedFiles.Location = New Point(285, 11)
        cmbSubmittedFiles.Name = "cmbSubmittedFiles"
        cmbSubmittedFiles.Size = New Size(240, 23)
        cmbSubmittedFiles.TabIndex = 0
        cmbSubmittedFiles.Visible = False
        ' 
        ' btnOpenExternal
        ' 
        btnOpenExternal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenExternal.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        btnOpenExternal.Cursor = Cursors.Hand
        btnOpenExternal.FlatAppearance.BorderSize = 0
        btnOpenExternal.FlatStyle = FlatStyle.Flat
        btnOpenExternal.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        btnOpenExternal.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnOpenExternal.Location = New Point(550, 9)
        btnOpenExternal.Name = "btnOpenExternal"
        btnOpenExternal.Size = New Size(132, 32)
        btnOpenExternal.TabIndex = 1
        btnOpenExternal.Text = "Open Document"
        btnOpenExternal.UseVisualStyleBackColor = False
        ' 
        ' lblDocFileName
        ' 
        lblDocFileName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDocFileName.AutoEllipsis = True
        lblDocFileName.Font = New Font("Segoe UI", 7.4F)
        lblDocFileName.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDocFileName.Location = New Point(210, 16)
        lblDocFileName.Name = "lblDocFileName"
        lblDocFileName.Size = New Size(265, 19)
        lblDocFileName.TabIndex = 2
        lblDocFileName.Text = "filename.png"
        ' 
        ' lblDocTitle
        ' 
        lblDocTitle.AutoSize = True
        lblDocTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDocTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDocTitle.Location = New Point(42, 14)
        lblDocTitle.Name = "lblDocTitle"
        lblDocTitle.Size = New Size(174, 21)
        lblDocTitle.TabIndex = 3
        lblDocTitle.Text = "Submitted Document"
        ' 
        ' lblDocIcon
        ' 
        lblDocIcon.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblDocIcon.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblDocIcon.Location = New Point(14, 12)
        lblDocIcon.Name = "lblDocIcon"
        lblDocIcon.Size = New Size(24, 26)
        lblDocIcon.TabIndex = 4
        lblDocIcon.Text = "D"
        lblDocIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlDocPreview
        ' 
        pnlDocPreview.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDocPreview.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlDocPreview.BorderStyle = BorderStyle.FixedSingle
        pnlDocPreview.Controls.Add(picPreview)
        pnlDocPreview.Controls.Add(pnlPdfFallback)
        pnlDocPreview.Location = New Point(14, 50)
        pnlDocPreview.Name = "pnlDocPreview"
        pnlDocPreview.Size = New Size(670, 238)
        pnlDocPreview.TabIndex = 5
        ' 
        ' picPreview
        ' 
        picPreview.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        picPreview.Dock = DockStyle.Fill
        picPreview.Location = New Point(0, 0)
        picPreview.Name = "picPreview"
        picPreview.Size = New Size(668, 236)
        picPreview.SizeMode = PictureBoxSizeMode.Zoom
        picPreview.TabIndex = 0
        picPreview.TabStop = False
        ' 
        ' pnlPdfFallback
        ' 
        pnlPdfFallback.Anchor = AnchorStyles.None
        pnlPdfFallback.BackColor = Color.Transparent
        pnlPdfFallback.Controls.Add(lblPdfIcon)
        pnlPdfFallback.Controls.Add(lblPdfPrompt)
        pnlPdfFallback.Controls.Add(lblPdfSub)
        pnlPdfFallback.Controls.Add(btnOpenPdfCenter)
        pnlPdfFallback.Location = New Point(174, 3)
        pnlPdfFallback.Name = "pnlPdfFallback"
        pnlPdfFallback.Size = New Size(320, 230)
        pnlPdfFallback.TabIndex = 1
        pnlPdfFallback.Visible = False
        ' 
        ' lblPdfIcon
        ' 
        lblPdfIcon.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblPdfIcon.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        lblPdfIcon.Location = New Point(125, 8)
        lblPdfIcon.Name = "lblPdfIcon"
        lblPdfIcon.Size = New Size(70, 60)
        lblPdfIcon.TabIndex = 0
        lblPdfIcon.Text = "PDF"
        lblPdfIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPdfPrompt
        ' 
        lblPdfPrompt.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblPdfPrompt.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblPdfPrompt.Location = New Point(10, 75)
        lblPdfPrompt.Name = "lblPdfPrompt"
        lblPdfPrompt.Size = New Size(300, 25)
        lblPdfPrompt.TabIndex = 1
        lblPdfPrompt.Text = "PDF Document Attached"
        lblPdfPrompt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPdfSub
        ' 
        lblPdfSub.Font = New Font("Segoe UI", 7.0F)
        lblPdfSub.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblPdfSub.Location = New Point(10, 104)
        lblPdfSub.Name = "lblPdfSub"
        lblPdfSub.Size = New Size(300, 35)
        lblPdfSub.TabIndex = 2
        lblPdfSub.Text = "Click below to inspect the original PDF document."
        lblPdfSub.TextAlign = ContentAlignment.TopCenter
        ' 
        ' btnOpenPdfCenter
        ' 
        btnOpenPdfCenter.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnOpenPdfCenter.Cursor = Cursors.Hand
        btnOpenPdfCenter.FlatAppearance.BorderSize = 0
        btnOpenPdfCenter.FlatStyle = FlatStyle.Flat
        btnOpenPdfCenter.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        btnOpenPdfCenter.ForeColor = Color.White
        btnOpenPdfCenter.Location = New Point(45, 155)
        btnOpenPdfCenter.Name = "btnOpenPdfCenter"
        btnOpenPdfCenter.Size = New Size(230, 42)
        btnOpenPdfCenter.TabIndex = 3
        btnOpenPdfCenter.Text = "Open in Default Viewer"
        btnOpenPdfCenter.UseVisualStyleBackColor = False
        ' 
        ' pnlGuidanceInfo
        ' 
        pnlGuidanceInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceInfo.BackColor = Color.White
        pnlGuidanceInfo.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceInfo.Controls.Add(pnlGuidanceBody)
        pnlGuidanceInfo.Controls.Add(pnlGuidanceHeader)
        pnlGuidanceInfo.Location = New Point(0, 314)
        pnlGuidanceInfo.Name = "pnlGuidanceInfo"
        pnlGuidanceInfo.Size = New Size(700, 304)
        pnlGuidanceInfo.TabIndex = 2
        pnlGuidanceInfo.Visible = False
        ' 
        ' pnlGuidanceBody
        ' 
        pnlGuidanceBody.BackColor = Color.White
        pnlGuidanceBody.Controls.Add(pnlGuidanceNoUpdate)
        pnlGuidanceBody.Controls.Add(pnlGuidanceFields)
        pnlGuidanceBody.Dock = DockStyle.Fill
        pnlGuidanceBody.Location = New Point(0, 66)
        pnlGuidanceBody.Name = "pnlGuidanceBody"
        pnlGuidanceBody.Size = New Size(698, 348)
        pnlGuidanceBody.TabIndex = 1
        ' 
        ' pnlGuidanceNoUpdate
        ' 
        pnlGuidanceNoUpdate.BackColor = Color.White
        pnlGuidanceNoUpdate.Controls.Add(pnlGuidanceNoUpdateCard)
        pnlGuidanceNoUpdate.Dock = DockStyle.Fill
        pnlGuidanceNoUpdate.Location = New Point(0, 0)
        pnlGuidanceNoUpdate.Name = "pnlGuidanceNoUpdate"
        pnlGuidanceNoUpdate.Size = New Size(698, 348)
        pnlGuidanceNoUpdate.TabIndex = 1
        pnlGuidanceNoUpdate.Visible = False
        ' 
        ' pnlGuidanceNoUpdateCard
        ' 
        pnlGuidanceNoUpdateCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceNoUpdateCard.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlGuidanceNoUpdateCard.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceNoUpdateCard.Controls.Add(lblNoUpdateIcon)
        pnlGuidanceNoUpdateCard.Controls.Add(lblNoUpdateTitle)
        pnlGuidanceNoUpdateCard.Controls.Add(lblNoUpdateMessage)
        pnlGuidanceNoUpdateCard.Location = New Point(20, 25)
        pnlGuidanceNoUpdateCard.Name = "pnlGuidanceNoUpdateCard"
        pnlGuidanceNoUpdateCard.Size = New Size(655, 165)
        pnlGuidanceNoUpdateCard.TabIndex = 0
        ' 
        ' lblNoUpdateIcon
        ' 
        lblNoUpdateIcon.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblNoUpdateIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblNoUpdateIcon.Location = New Point(18, 23)
        lblNoUpdateIcon.Name = "lblNoUpdateIcon"
        lblNoUpdateIcon.Size = New Size(35, 38)
        lblNoUpdateIcon.TabIndex = 0
        lblNoUpdateIcon.Text = "i"
        lblNoUpdateIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNoUpdateTitle
        ' 
        lblNoUpdateTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblNoUpdateTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNoUpdateTitle.Location = New Point(65, 23)
        lblNoUpdateTitle.Name = "lblNoUpdateTitle"
        lblNoUpdateTitle.Size = New Size(555, 25)
        lblNoUpdateTitle.TabIndex = 1
        lblNoUpdateTitle.Text = "No Guidance Information Submitted"
        ' 
        ' lblNoUpdateMessage
        ' 
        lblNoUpdateMessage.Font = New Font("Segoe UI", 8.3F)
        lblNoUpdateMessage.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblNoUpdateMessage.Location = New Point(65, 58)
        lblNoUpdateMessage.Name = "lblNoUpdateMessage"
        lblNoUpdateMessage.Size = New Size(555, 85)
        lblNoUpdateMessage.TabIndex = 2
        lblNoUpdateMessage.Text = "No Guidance information has been submitted for the current academic year." & vbCrLf & vbCrLf & "The student must complete or review/update their Guidance information before clearance approval."
        ' 
        ' pnlGuidanceFields
        ' 
        pnlGuidanceFields.AutoScroll = True
        pnlGuidanceFields.BackColor = Color.White
        pnlGuidanceFields.Controls.Add(lblAddressTitle)
        pnlGuidanceFields.Controls.Add(lblAddressValue)
        pnlGuidanceFields.Controls.Add(lblEmergencyNameTitle)
        pnlGuidanceFields.Controls.Add(lblEmergencyNameValue)
        pnlGuidanceFields.Controls.Add(lblContactTitle)
        pnlGuidanceFields.Controls.Add(lblContactValue)
        pnlGuidanceFields.Controls.Add(lblRelationshipTitle)
        pnlGuidanceFields.Controls.Add(lblRelationshipValue)
        pnlGuidanceFields.Controls.Add(lblEmailTitle)
        pnlGuidanceFields.Controls.Add(lblEmailValue)
        pnlGuidanceFields.Controls.Add(lblEmergencyContactTitle)
        pnlGuidanceFields.Controls.Add(lblEmergencyContactValue)
        pnlGuidanceFields.Controls.Add(lblCivilStatusTitle)
        pnlGuidanceFields.Controls.Add(lblCivilStatusValue)
        pnlGuidanceFields.Controls.Add(lblNotesTitle)
        pnlGuidanceFields.Controls.Add(lblNotesValue)
        pnlGuidanceFields.Controls.Add(txtAddress)
        pnlGuidanceFields.Controls.Add(txtEmergencyName)
        pnlGuidanceFields.Controls.Add(txtContact)
        pnlGuidanceFields.Controls.Add(txtRelationship)
        pnlGuidanceFields.Controls.Add(txtEmail)
        pnlGuidanceFields.Controls.Add(txtEmergencyContact)
        pnlGuidanceFields.Controls.Add(txtCivilStatus)
        pnlGuidanceFields.Controls.Add(txtNotes)
        pnlGuidanceFields.Controls.Add(pnlGuidanceInfoNote)
        pnlGuidanceFields.Dock = DockStyle.Fill
        pnlGuidanceFields.Location = New Point(0, 0)
        pnlGuidanceFields.Name = "pnlGuidanceFields"
        pnlGuidanceFields.Padding = New Padding(18)
        pnlGuidanceFields.Size = New Size(698, 348)
        pnlGuidanceFields.TabIndex = 0
        ' 
        ' lblAddressTitle
        ' 
        lblAddressTitle.AutoSize = True
        lblAddressTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblAddressTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblAddressTitle.Location = New Point(18, 12)
        lblAddressTitle.Name = "lblAddressTitle"
        lblAddressTitle.Size = New Size(107, 17)
        lblAddressTitle.TabIndex = 0
        lblAddressTitle.Text = "Current Address"
        ' 
        ' lblAddressValue
        ' 
        lblAddressValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblAddressValue.BorderStyle = BorderStyle.FixedSingle
        lblAddressValue.Font = New Font("Segoe UI", 8.0F)
        lblAddressValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAddressValue.Location = New Point(18, 32)
        lblAddressValue.Name = "lblAddressValue"
        lblAddressValue.Padding = New Padding(8, 4, 8, 4)
        lblAddressValue.Size = New Size(310, 36)
        lblAddressValue.TabIndex = 1
        lblAddressValue.Text = "Not provided"
        lblAddressValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmergencyNameTitle
        ' 
        lblEmergencyNameTitle.AutoSize = True
        lblEmergencyNameTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblEmergencyNameTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblEmergencyNameTitle.Location = New Point(354, 12)
        lblEmergencyNameTitle.Name = "lblEmergencyNameTitle"
        lblEmergencyNameTitle.Size = New Size(166, 17)
        lblEmergencyNameTitle.TabIndex = 2
        lblEmergencyNameTitle.Text = "Emergency Contact Name"
        ' 
        ' lblEmergencyNameValue
        ' 
        lblEmergencyNameValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmergencyNameValue.BorderStyle = BorderStyle.FixedSingle
        lblEmergencyNameValue.Font = New Font("Segoe UI", 8.0F)
        lblEmergencyNameValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyNameValue.Location = New Point(354, 32)
        lblEmergencyNameValue.Name = "lblEmergencyNameValue"
        lblEmergencyNameValue.Padding = New Padding(8, 4, 8, 4)
        lblEmergencyNameValue.Size = New Size(310, 36)
        lblEmergencyNameValue.TabIndex = 3
        lblEmergencyNameValue.Text = "Not provided"
        lblEmergencyNameValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblContactTitle
        ' 
        lblContactTitle.AutoSize = True
        lblContactTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblContactTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblContactTitle.Location = New Point(18, 78)
        lblContactTitle.Name = "lblContactTitle"
        lblContactTitle.Size = New Size(109, 17)
        lblContactTitle.TabIndex = 4
        lblContactTitle.Text = "Contact Number"
        ' 
        ' lblContactValue
        ' 
        lblContactValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblContactValue.BorderStyle = BorderStyle.FixedSingle
        lblContactValue.Font = New Font("Segoe UI", 8.0F)
        lblContactValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblContactValue.Location = New Point(18, 98)
        lblContactValue.Name = "lblContactValue"
        lblContactValue.Padding = New Padding(8, 4, 8, 4)
        lblContactValue.Size = New Size(310, 36)
        lblContactValue.TabIndex = 5
        lblContactValue.Text = "Not provided"
        lblContactValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblRelationshipTitle
        ' 
        lblRelationshipTitle.AutoSize = True
        lblRelationshipTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblRelationshipTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblRelationshipTitle.Location = New Point(354, 78)
        lblRelationshipTitle.Name = "lblRelationshipTitle"
        lblRelationshipTitle.Size = New Size(82, 17)
        lblRelationshipTitle.TabIndex = 6
        lblRelationshipTitle.Text = "Relationship"
        ' 
        ' lblRelationshipValue
        ' 
        lblRelationshipValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblRelationshipValue.BorderStyle = BorderStyle.FixedSingle
        lblRelationshipValue.Font = New Font("Segoe UI", 8.0F)
        lblRelationshipValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRelationshipValue.Location = New Point(354, 98)
        lblRelationshipValue.Name = "lblRelationshipValue"
        lblRelationshipValue.Padding = New Padding(8, 4, 8, 4)
        lblRelationshipValue.Size = New Size(310, 36)
        lblRelationshipValue.TabIndex = 7
        lblRelationshipValue.Text = "Not provided"
        lblRelationshipValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmailTitle
        ' 
        lblEmailTitle.AutoSize = True
        lblEmailTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblEmailTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblEmailTitle.Location = New Point(18, 144)
        lblEmailTitle.Name = "lblEmailTitle"
        lblEmailTitle.Size = New Size(93, 17)
        lblEmailTitle.TabIndex = 8
        lblEmailTitle.Text = "Email Address"
        ' 
        ' lblEmailValue
        ' 
        lblEmailValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmailValue.BorderStyle = BorderStyle.FixedSingle
        lblEmailValue.Font = New Font("Segoe UI", 8.0F)
        lblEmailValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmailValue.Location = New Point(18, 164)
        lblEmailValue.Name = "lblEmailValue"
        lblEmailValue.Padding = New Padding(8, 4, 8, 4)
        lblEmailValue.Size = New Size(310, 36)
        lblEmailValue.TabIndex = 9
        lblEmailValue.Text = "Not provided"
        lblEmailValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblEmergencyContactTitle
        ' 
        lblEmergencyContactTitle.AutoSize = True
        lblEmergencyContactTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblEmergencyContactTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblEmergencyContactTitle.Location = New Point(354, 144)
        lblEmergencyContactTitle.Name = "lblEmergencyContactTitle"
        lblEmergencyContactTitle.Size = New Size(180, 17)
        lblEmergencyContactTitle.TabIndex = 10
        lblEmergencyContactTitle.Text = "Emergency Contact Number"
        ' 
        ' lblEmergencyContactValue
        ' 
        lblEmergencyContactValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblEmergencyContactValue.BorderStyle = BorderStyle.FixedSingle
        lblEmergencyContactValue.Font = New Font("Segoe UI", 8.0F)
        lblEmergencyContactValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyContactValue.Location = New Point(354, 164)
        lblEmergencyContactValue.Name = "lblEmergencyContactValue"
        lblEmergencyContactValue.Padding = New Padding(8, 4, 8, 4)
        lblEmergencyContactValue.Size = New Size(310, 36)
        lblEmergencyContactValue.TabIndex = 11
        lblEmergencyContactValue.Text = "Not provided"
        lblEmergencyContactValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblCivilStatusTitle
        ' 
        lblCivilStatusTitle.AutoSize = True
        lblCivilStatusTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblCivilStatusTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblCivilStatusTitle.Location = New Point(18, 210)
        lblCivilStatusTitle.Name = "lblCivilStatusTitle"
        lblCivilStatusTitle.Size = New Size(74, 17)
        lblCivilStatusTitle.TabIndex = 12
        lblCivilStatusTitle.Text = "Civil Status"
        ' 
        ' lblCivilStatusValue
        ' 
        lblCivilStatusValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblCivilStatusValue.BorderStyle = BorderStyle.FixedSingle
        lblCivilStatusValue.Font = New Font("Segoe UI", 8.0F)
        lblCivilStatusValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblCivilStatusValue.Location = New Point(18, 230)
        lblCivilStatusValue.Name = "lblCivilStatusValue"
        lblCivilStatusValue.Padding = New Padding(8, 4, 8, 4)
        lblCivilStatusValue.Size = New Size(310, 36)
        lblCivilStatusValue.TabIndex = 13
        lblCivilStatusValue.Text = "Not provided"
        lblCivilStatusValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblNotesTitle
        ' 
        lblNotesTitle.AutoSize = True
        lblNotesTitle.Font = New Font("Segoe UI Semibold", 7.7F, FontStyle.Bold)
        lblNotesTitle.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblNotesTitle.Location = New Point(354, 210)
        lblNotesTitle.Name = "lblNotesTitle"
        lblNotesTitle.Size = New Size(110, 17)
        lblNotesTitle.TabIndex = 14
        lblNotesTitle.Text = "Additional Notes"
        ' 
        ' lblNotesValue
        ' 
        lblNotesValue.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        lblNotesValue.BorderStyle = BorderStyle.FixedSingle
        lblNotesValue.Font = New Font("Segoe UI", 8.0F)
        lblNotesValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblNotesValue.Location = New Point(354, 230)
        lblNotesValue.Name = "lblNotesValue"
        lblNotesValue.Padding = New Padding(8, 4, 8, 4)
        lblNotesValue.Size = New Size(310, 36)
        lblNotesValue.TabIndex = 15
        lblNotesValue.Text = "Not provided"
        lblNotesValue.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlGuidanceInfoNote
        ' 
        pnlGuidanceInfoNote.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlGuidanceInfoNote.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        pnlGuidanceInfoNote.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceInfoNote.Controls.Add(lblGuidanceNoteIcon)
        pnlGuidanceInfoNote.Controls.Add(lblGuidanceInfoNote)
        pnlGuidanceInfoNote.Location = New Point(18, 282)
        pnlGuidanceInfoNote.Name = "pnlGuidanceInfoNote"
        pnlGuidanceInfoNote.Size = New Size(646, 58)
        pnlGuidanceInfoNote.TabIndex = 16
        ' 
        ' lblGuidanceNoteIcon
        ' 
        lblGuidanceNoteIcon.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblGuidanceNoteIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblGuidanceNoteIcon.Location = New Point(9, 13)
        lblGuidanceNoteIcon.Name = "lblGuidanceNoteIcon"
        lblGuidanceNoteIcon.Size = New Size(24, 28)
        lblGuidanceNoteIcon.TabIndex = 0
        lblGuidanceNoteIcon.Text = "i"
        lblGuidanceNoteIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblGuidanceInfoNote
        ' 
        lblGuidanceInfoNote.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGuidanceInfoNote.Font = New Font("Segoe UI", 7.3F)
        lblGuidanceInfoNote.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblGuidanceInfoNote.Location = New Point(40, 8)
        lblGuidanceInfoNote.Name = "lblGuidanceInfoNote"
        lblGuidanceInfoNote.Size = New Size(590, 40)
        lblGuidanceInfoNote.TabIndex = 1
        lblGuidanceInfoNote.Text = "This information was submitted by the student for the current academic year." & vbCrLf & "Please review the details before approving or rejecting this clearance."
        ' 
        ' pnlGuidanceHeader
        ' 
        pnlGuidanceHeader.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        pnlGuidanceHeader.Controls.Add(lblGuidanceIcon)
        pnlGuidanceHeader.Controls.Add(lblGuidanceInfoTitle)
        pnlGuidanceHeader.Controls.Add(lblGuidanceInfoSubtitle)
        pnlGuidanceHeader.Controls.Add(btnEditGuidance)
        pnlGuidanceHeader.Controls.Add(btnSaveGuidance)
        pnlGuidanceHeader.Controls.Add(btnCancelGuidance)
        pnlGuidanceHeader.Dock = DockStyle.Top
        pnlGuidanceHeader.Location = New Point(0, 0)
        pnlGuidanceHeader.Name = "pnlGuidanceHeader"
        pnlGuidanceHeader.Size = New Size(698, 66)
        pnlGuidanceHeader.TabIndex = 0
        ' 
        ' lblGuidanceIcon
        ' 
        lblGuidanceIcon.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        lblGuidanceIcon.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        lblGuidanceIcon.Location = New Point(14, 13)
        lblGuidanceIcon.Name = "lblGuidanceIcon"
        lblGuidanceIcon.Size = New Size(24, 28)
        lblGuidanceIcon.TabIndex = 0
        lblGuidanceIcon.Text = "i"
        lblGuidanceIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblGuidanceInfoTitle
        ' 
        lblGuidanceInfoTitle.AutoSize = True
        lblGuidanceInfoTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblGuidanceInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblGuidanceInfoTitle.Location = New Point(42, 11)
        lblGuidanceInfoTitle.Name = "lblGuidanceInfoTitle"
        lblGuidanceInfoTitle.Size = New Size(178, 21)
        lblGuidanceInfoTitle.TabIndex = 1
        lblGuidanceInfoTitle.Text = "Guidance Information"
        ' 
        ' lblGuidanceInfoSubtitle
        ' 
        lblGuidanceInfoSubtitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGuidanceInfoSubtitle.Font = New Font("Segoe UI", 7.4F)
        lblGuidanceInfoSubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblGuidanceInfoSubtitle.Location = New Point(42, 35)
        lblGuidanceInfoSubtitle.Name = "lblGuidanceInfoSubtitle"
        lblGuidanceInfoSubtitle.Size = New Size(640, 20)
        lblGuidanceInfoSubtitle.TabIndex = 2
        lblGuidanceInfoSubtitle.Text = "Below is the information submitted by the student for the current academic year."
        ' 
        ' pnlClinicInfo
        ' 
        pnlClinicInfo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlClinicInfo.BackColor = Color.White
        pnlClinicInfo.BorderStyle = BorderStyle.FixedSingle
        pnlClinicInfo.Controls.Add(pnlClinicBody)
        pnlClinicInfo.Controls.Add(pnlClinicHeader)
        pnlClinicInfo.Location = New Point(0, 314)
        pnlClinicInfo.Name = "pnlClinicInfo"
        pnlClinicInfo.Size = New Size(700, 304)
        pnlClinicInfo.TabIndex = 3
        pnlClinicInfo.Visible = False
        ' 
        ' pnlClinicHeader
        ' 
        pnlClinicHeader.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        pnlClinicHeader.Controls.Add(lblClinicIcon)
        pnlClinicHeader.Controls.Add(lblClinicInfoTitle)
        pnlClinicHeader.Controls.Add(lblClinicInfoSubtitle)
        pnlClinicHeader.Controls.Add(btnOpenAssessmentModal)
        pnlClinicHeader.Dock = DockStyle.Top
        pnlClinicHeader.Location = New Point(0, 0)
        pnlClinicHeader.Name = "pnlClinicHeader"
        pnlClinicHeader.Size = New Size(698, 66)
        pnlClinicHeader.TabIndex = 0
        ' 
        ' lblClinicIcon
        ' 
        lblClinicIcon.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblClinicIcon.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        lblClinicIcon.Location = New Point(14, 13)
        lblClinicIcon.Name = "lblClinicIcon"
        lblClinicIcon.Size = New Size(24, 28)
        lblClinicIcon.TabIndex = 0
        lblClinicIcon.Text = "✚"
        lblClinicIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblClinicInfoTitle
        ' 
        lblClinicInfoTitle.AutoSize = True
        lblClinicInfoTitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
        lblClinicInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicInfoTitle.Location = New Point(42, 11)
        lblClinicInfoTitle.Name = "lblClinicInfoTitle"
        lblClinicInfoTitle.Size = New Size(245, 21)
        lblClinicInfoTitle.TabIndex = 1
        lblClinicInfoTitle.Text = "Clinic Health Assessment Information"
        ' 
        ' lblClinicInfoSubtitle
        ' 
        lblClinicInfoSubtitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicInfoSubtitle.Font = New Font("Segoe UI", 7.4F)
        lblClinicInfoSubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblClinicInfoSubtitle.Location = New Point(42, 35)
        lblClinicInfoSubtitle.Name = "lblClinicInfoSubtitle"
        lblClinicInfoSubtitle.Size = New Size(470, 20)
        lblClinicInfoSubtitle.TabIndex = 2
        lblClinicInfoSubtitle.Text = "Review the student's digital health assessment responses and medical declarations."
        ' 
        ' btnOpenAssessmentModal
        ' 
        btnOpenAssessmentModal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenAssessmentModal.BackColor = Color.White
        btnOpenAssessmentModal.Cursor = Cursors.Hand
        btnOpenAssessmentModal.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnOpenAssessmentModal.FlatStyle = FlatStyle.Flat
        btnOpenAssessmentModal.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        btnOpenAssessmentModal.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        btnOpenAssessmentModal.Location = New Point(520, 16)
        btnOpenAssessmentModal.Name = "btnOpenAssessmentModal"
        btnOpenAssessmentModal.Size = New Size(165, 32)
        btnOpenAssessmentModal.TabIndex = 3
        btnOpenAssessmentModal.Text = "Open Full Assessment"
        btnOpenAssessmentModal.UseVisualStyleBackColor = False
        ' 
        ' pnlClinicBody
        ' 
        pnlClinicBody.BackColor = Color.White
        pnlClinicBody.Controls.Add(pnlClinicRestricted)
        pnlClinicBody.Controls.Add(pnlClinicNoUpdate)
        pnlClinicBody.Controls.Add(pnlClinicFields)
        pnlClinicBody.Dock = DockStyle.Fill
        pnlClinicBody.Location = New Point(0, 66)
        pnlClinicBody.Name = "pnlClinicBody"
        pnlClinicBody.Size = New Size(698, 348)
        pnlClinicBody.TabIndex = 1
        ' 
        ' pnlClinicRestricted
        ' 
        pnlClinicRestricted.BackColor = Color.White
        pnlClinicRestricted.Controls.Add(pnlClinicRestrictedCard)
        pnlClinicRestricted.Dock = DockStyle.Fill
        pnlClinicRestricted.Location = New Point(0, 0)
        pnlClinicRestricted.Name = "pnlClinicRestricted"
        pnlClinicRestricted.Size = New Size(698, 348)
        pnlClinicRestricted.TabIndex = 2
        pnlClinicRestricted.Visible = False
        ' 
        ' pnlClinicRestrictedCard
        ' 
        pnlClinicRestrictedCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlClinicRestrictedCard.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlClinicRestrictedCard.BorderStyle = BorderStyle.FixedSingle
        pnlClinicRestrictedCard.Controls.Add(lblRestrictedIcon)
        pnlClinicRestrictedCard.Controls.Add(lblRestrictedTitle)
        pnlClinicRestrictedCard.Controls.Add(lblRestrictedMessage)
        pnlClinicRestrictedCard.Location = New Point(20, 25)
        pnlClinicRestrictedCard.Name = "pnlClinicRestrictedCard"
        pnlClinicRestrictedCard.Size = New Size(655, 165)
        pnlClinicRestrictedCard.TabIndex = 0
        ' 
        ' lblRestrictedIcon
        ' 
        lblRestrictedIcon.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblRestrictedIcon.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRestrictedIcon.Location = New Point(18, 23)
        lblRestrictedIcon.Name = "lblRestrictedIcon"
        lblRestrictedIcon.Size = New Size(35, 38)
        lblRestrictedIcon.TabIndex = 0
        lblRestrictedIcon.Text = "🔒"
        lblRestrictedIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRestrictedTitle
        ' 
        lblRestrictedTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblRestrictedTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRestrictedTitle.Location = New Point(65, 23)
        lblRestrictedTitle.Name = "lblRestrictedTitle"
        lblRestrictedTitle.Size = New Size(555, 25)
        lblRestrictedTitle.TabIndex = 1
        lblRestrictedTitle.Text = "Confidential Medical Information"
        ' 
        ' lblRestrictedMessage
        ' 
        lblRestrictedMessage.Font = New Font("Segoe UI", 8.3F)
        lblRestrictedMessage.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblRestrictedMessage.Location = New Point(65, 58)
        lblRestrictedMessage.Name = "lblRestrictedMessage"
        lblRestrictedMessage.Size = New Size(565, 85)
        lblRestrictedMessage.TabIndex = 2
        lblRestrictedMessage.Text = "Digital health assessment details are strictly confidential." & vbCrLf & vbCrLf & "Detailed medical responses and health declarations are restricted to authorized School Clinic personnel."
        ' 
        ' pnlClinicNoUpdate
        ' 
        pnlClinicNoUpdate.BackColor = Color.White
        pnlClinicNoUpdate.Controls.Add(pnlClinicNoUpdateCard)
        pnlClinicNoUpdate.Dock = DockStyle.Fill
        pnlClinicNoUpdate.Location = New Point(0, 0)
        pnlClinicNoUpdate.Name = "pnlClinicNoUpdate"
        pnlClinicNoUpdate.Size = New Size(698, 348)
        pnlClinicNoUpdate.TabIndex = 1
        pnlClinicNoUpdate.Visible = False
        ' 
        ' pnlClinicNoUpdateCard
        ' 
        pnlClinicNoUpdateCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlClinicNoUpdateCard.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlClinicNoUpdateCard.BorderStyle = BorderStyle.FixedSingle
        pnlClinicNoUpdateCard.Controls.Add(lblClinicNoUpdateIcon)
        pnlClinicNoUpdateCard.Controls.Add(lblClinicNoUpdateTitle)
        pnlClinicNoUpdateCard.Controls.Add(lblClinicNoUpdateMessage)
        pnlClinicNoUpdateCard.Location = New Point(20, 25)
        pnlClinicNoUpdateCard.Name = "pnlClinicNoUpdateCard"
        pnlClinicNoUpdateCard.Size = New Size(655, 165)
        pnlClinicNoUpdateCard.TabIndex = 0
        ' 
        ' lblClinicNoUpdateIcon
        ' 
        lblClinicNoUpdateIcon.Font = New Font("Segoe UI", 15.0F, FontStyle.Bold)
        lblClinicNoUpdateIcon.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        lblClinicNoUpdateIcon.Location = New Point(18, 23)
        lblClinicNoUpdateIcon.Name = "lblClinicNoUpdateIcon"
        lblClinicNoUpdateIcon.Size = New Size(35, 38)
        lblClinicNoUpdateIcon.TabIndex = 0
        lblClinicNoUpdateIcon.Text = "✚"
        lblClinicNoUpdateIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblClinicNoUpdateTitle
        ' 
        lblClinicNoUpdateTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblClinicNoUpdateTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicNoUpdateTitle.Location = New Point(65, 23)
        lblClinicNoUpdateTitle.Name = "lblClinicNoUpdateTitle"
        lblClinicNoUpdateTitle.Size = New Size(555, 25)
        lblClinicNoUpdateTitle.TabIndex = 1
        lblClinicNoUpdateTitle.Text = "No Health Assessment Submitted"
        ' 
        ' lblClinicNoUpdateMessage
        ' 
        lblClinicNoUpdateMessage.Font = New Font("Segoe UI", 8.3F)
        lblClinicNoUpdateMessage.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblClinicNoUpdateMessage.Location = New Point(65, 58)
        lblClinicNoUpdateMessage.Name = "lblClinicNoUpdateMessage"
        lblClinicNoUpdateMessage.Size = New Size(565, 85)
        lblClinicNoUpdateMessage.TabIndex = 2
        lblClinicNoUpdateMessage.Text = "No digital Health Assessment has been submitted by the student for this clearance requirement." & vbCrLf & vbCrLf & "The student must complete and submit their Health Assessment Form before this clearance can be approved."
        ' 
        ' pnlClinicFields
        ' 
        pnlClinicFields.AutoScroll = True
        pnlClinicFields.Controls.Add(lblClinicMedLabel)
        pnlClinicFields.Controls.Add(lblClinicMedVal)
        pnlClinicFields.Controls.Add(lblClinicAlgLabel)
        pnlClinicFields.Controls.Add(lblClinicAlgVal)
        pnlClinicFields.Controls.Add(lblClinicMedsLabel)
        pnlClinicFields.Controls.Add(lblClinicMedsVal)
        pnlClinicFields.Controls.Add(lblClinicConcernsLabel)
        pnlClinicFields.Controls.Add(lblClinicConcernsVal)
        pnlClinicFields.Controls.Add(lblClinicEmLabel)
        pnlClinicFields.Controls.Add(lblClinicEmVal)
        pnlClinicFields.Controls.Add(lblClinicDecLabel)
        pnlClinicFields.Controls.Add(lblClinicDecVal)
        pnlClinicFields.Controls.Add(lblClinicDocLabel)
        pnlClinicFields.Controls.Add(lblClinicDocVal)
        pnlClinicFields.Controls.Add(btnViewClinicDoc)
        pnlClinicFields.Dock = DockStyle.Fill
        pnlClinicFields.Location = New Point(0, 0)
        pnlClinicFields.Name = "pnlClinicFields"
        pnlClinicFields.Padding = New Padding(14)
        pnlClinicFields.Size = New Size(698, 348)
        pnlClinicFields.TabIndex = 0
        ' 
        ' lblClinicMedLabel
        ' 
        lblClinicMedLabel.AutoSize = True
        lblClinicMedLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicMedLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicMedLabel.Location = New Point(14, 10)
        lblClinicMedLabel.Name = "lblClinicMedLabel"
        lblClinicMedLabel.Size = New Size(160, 15)
        lblClinicMedLabel.TabIndex = 0
        lblClinicMedLabel.Text = "1. Known Medical Conditions:"
        ' 
        ' lblClinicMedVal
        ' 
        lblClinicMedVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicMedVal.Font = New Font("Segoe UI", 8.5F)
        lblClinicMedVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicMedVal.Location = New Point(14, 28)
        lblClinicMedVal.Name = "lblClinicMedVal"
        lblClinicMedVal.Size = New Size(650, 32)
        lblClinicMedVal.TabIndex = 1
        lblClinicMedVal.Text = "No"
        ' 
        ' lblClinicAlgLabel
        ' 
        lblClinicAlgLabel.AutoSize = True
        lblClinicAlgLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicAlgLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicAlgLabel.Location = New Point(14, 65)
        lblClinicAlgLabel.Name = "lblClinicAlgLabel"
        lblClinicAlgLabel.Size = New Size(69, 15)
        lblClinicAlgLabel.TabIndex = 2
        lblClinicAlgLabel.Text = "2. Allergies:"
        ' 
        ' lblClinicAlgVal
        ' 
        lblClinicAlgVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicAlgVal.Font = New Font("Segoe UI", 8.5F)
        lblClinicAlgVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicAlgVal.Location = New Point(14, 83)
        lblClinicAlgVal.Name = "lblClinicAlgVal"
        lblClinicAlgVal.Size = New Size(650, 32)
        lblClinicAlgVal.TabIndex = 3
        lblClinicAlgVal.Text = "No"
        ' 
        ' lblClinicMedsLabel
        ' 
        lblClinicMedsLabel.AutoSize = True
        lblClinicMedsLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicMedsLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicMedsLabel.Location = New Point(14, 120)
        lblClinicMedsLabel.Name = "lblClinicMedsLabel"
        lblClinicMedsLabel.Size = New Size(129, 15)
        lblClinicMedsLabel.TabIndex = 4
        lblClinicMedsLabel.Text = "3. Current Medications:"
        ' 
        ' lblClinicMedsVal
        ' 
        lblClinicMedsVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicMedsVal.Font = New Font("Segoe UI", 8.5F)
        lblClinicMedsVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicMedsVal.Location = New Point(14, 138)
        lblClinicMedsVal.Name = "lblClinicMedsVal"
        lblClinicMedsVal.Size = New Size(650, 32)
        lblClinicMedsVal.TabIndex = 5
        lblClinicMedsVal.Text = "No"
        ' 
        ' lblClinicConcernsLabel
        ' 
        lblClinicConcernsLabel.AutoSize = True
        lblClinicConcernsLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicConcernsLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicConcernsLabel.Location = New Point(14, 175)
        lblClinicConcernsLabel.Name = "lblClinicConcernsLabel"
        lblClinicConcernsLabel.Size = New Size(108, 15)
        lblClinicConcernsLabel.TabIndex = 6
        lblClinicConcernsLabel.Text = "4. Health Concerns:"
        ' 
        ' lblClinicConcernsVal
        ' 
        lblClinicConcernsVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicConcernsVal.Font = New Font("Segoe UI", 8.5F)
        lblClinicConcernsVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicConcernsVal.Location = New Point(14, 193)
        lblClinicConcernsVal.Name = "lblClinicConcernsVal"
        lblClinicConcernsVal.Size = New Size(650, 32)
        lblClinicConcernsVal.TabIndex = 7
        lblClinicConcernsVal.Text = "No"
        ' 
        ' lblClinicEmLabel
        ' 
        lblClinicEmLabel.AutoSize = True
        lblClinicEmLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicEmLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicEmLabel.Location = New Point(14, 230)
        lblClinicEmLabel.Name = "lblClinicEmLabel"
        lblClinicEmLabel.Size = New Size(125, 15)
        lblClinicEmLabel.TabIndex = 8
        lblClinicEmLabel.Text = "5. Emergency Contact:"
        ' 
        ' lblClinicEmVal
        ' 
        lblClinicEmVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicEmVal.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblClinicEmVal.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblClinicEmVal.Location = New Point(14, 248)
        lblClinicEmVal.Name = "lblClinicEmVal"
        lblClinicEmVal.Size = New Size(650, 20)
        lblClinicEmVal.TabIndex = 9
        lblClinicEmVal.Text = "-"
        ' 
        ' lblClinicDecLabel
        ' 
        lblClinicDecLabel.AutoSize = True
        lblClinicDecLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicDecLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicDecLabel.Location = New Point(14, 275)
        lblClinicDecLabel.Name = "lblClinicDecLabel"
        lblClinicDecLabel.Size = New Size(124, 15)
        lblClinicDecLabel.TabIndex = 10
        lblClinicDecLabel.Text = "6. Student Declaration:"
        ' 
        ' lblClinicDecVal
        ' 
        lblClinicDecVal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblClinicDecVal.Font = New Font("Segoe UI", 8.5F)
        lblClinicDecVal.ForeColor = Color.FromArgb(CByte(22), CByte(101), CByte(52))
        lblClinicDecVal.Location = New Point(14, 293)
        lblClinicDecVal.Name = "lblClinicDecVal"
        lblClinicDecVal.Size = New Size(650, 20)
        lblClinicDecVal.TabIndex = 11
        lblClinicDecVal.Text = "Confirmed by student"
        ' 
        ' lblClinicDocLabel
        ' 
        lblClinicDocLabel.AutoSize = True
        lblClinicDocLabel.Font = New Font("Segoe UI Semibold", 8.2F, FontStyle.Bold)
        lblClinicDocLabel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblClinicDocLabel.Location = New Point(14, 320)
        lblClinicDocLabel.Name = "lblClinicDocLabel"
        lblClinicDocLabel.Size = New Size(225, 15)
        lblClinicDocLabel.TabIndex = 12
        lblClinicDocLabel.Text = "7. Supporting Medical Document (if any):"
        ' 
        ' lblClinicDocVal
        ' 
        lblClinicDocVal.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        lblClinicDocVal.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblClinicDocVal.Location = New Point(14, 340)
        lblClinicDocVal.Name = "lblClinicDocVal"
        lblClinicDocVal.Size = New Size(450, 25)
        lblClinicDocVal.TabIndex = 13
        lblClinicDocVal.Text = "No document attached"
        lblClinicDocVal.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btnViewClinicDoc
        ' 
        btnViewClinicDoc.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnViewClinicDoc.Cursor = Cursors.Hand
        btnViewClinicDoc.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnViewClinicDoc.FlatStyle = FlatStyle.Flat
        btnViewClinicDoc.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        btnViewClinicDoc.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        btnViewClinicDoc.Location = New Point(475, 336)
        btnViewClinicDoc.Name = "btnViewClinicDoc"
        btnViewClinicDoc.Size = New Size(135, 30)
        btnViewClinicDoc.TabIndex = 14
        btnViewClinicDoc.Text = "View Document"
        btnViewClinicDoc.UseVisualStyleBackColor = False
        btnViewClinicDoc.Visible = False
        ' 
        ' pnlRightSection
        ' 
        pnlRightSection.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlRightSection.Controls.Add(pnlCurrentStatusCard)
        pnlRightSection.Controls.Add(pnlDecisionCard)
        pnlRightSection.Controls.Add(pnlTimelineCard)
        pnlRightSection.Location = New Point(738, 110)
        pnlRightSection.Name = "pnlRightSection"
        pnlRightSection.Size = New Size(382, 618)
        pnlRightSection.TabIndex = 7
        ' 
        ' pnlCurrentStatusCard
        ' 
        pnlCurrentStatusCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlCurrentStatusCard.BackColor = Color.White
        pnlCurrentStatusCard.BorderStyle = BorderStyle.FixedSingle
        pnlCurrentStatusCard.Controls.Add(lblStatusHeader)
        pnlCurrentStatusCard.Controls.Add(lblStatusIconBig)
        pnlCurrentStatusCard.Controls.Add(lblStatusBadge)
        pnlCurrentStatusCard.Controls.Add(lblStatusSubText)
        pnlCurrentStatusCard.Location = New Point(0, 0)
        pnlCurrentStatusCard.Name = "pnlCurrentStatusCard"
        pnlCurrentStatusCard.Size = New Size(382, 100)
        pnlCurrentStatusCard.TabIndex = 0
        ' 
        ' lblStatusHeader
        ' 
        lblStatusHeader.AutoSize = True
        lblStatusHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblStatusHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblStatusHeader.Location = New Point(12, 10)
        lblStatusHeader.Name = "lblStatusHeader"
        lblStatusHeader.Size = New Size(106, 20)
        lblStatusHeader.TabIndex = 0
        lblStatusHeader.Text = "Current Status"
        ' 
        ' lblStatusIconBig
        ' 
        lblStatusIconBig.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        lblStatusIconBig.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblStatusIconBig.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStatusIconBig.Location = New Point(12, 38)
        lblStatusIconBig.Name = "lblStatusIconBig"
        lblStatusIconBig.Size = New Size(36, 42)
        lblStatusIconBig.TabIndex = 1
        lblStatusIconBig.Text = "i"
        lblStatusIconBig.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStatusBadge.Location = New Point(56, 38)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Size = New Size(260, 22)
        lblStatusBadge.TabIndex = 2
        lblStatusBadge.Text = "Under Review"
        ' 
        ' lblStatusSubText
        ' 
        lblStatusSubText.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblStatusSubText.AutoEllipsis = True
        lblStatusSubText.Font = New Font("Segoe UI", 7.0F)
        lblStatusSubText.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStatusSubText.Location = New Point(56, 62)
        lblStatusSubText.Name = "lblStatusSubText"
        lblStatusSubText.Size = New Size(310, 34)
        lblStatusSubText.TabIndex = 3
        lblStatusSubText.Text = "This submission is waiting for your evaluation."
        ' 
        ' pnlDecisionCard
        ' 
        pnlDecisionCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDecisionCard.BackColor = Color.White
        pnlDecisionCard.BorderStyle = BorderStyle.FixedSingle
        pnlDecisionCard.Controls.Add(lblDecisionHeader)
        pnlDecisionCard.Controls.Add(lblRemarksTitle)
        pnlDecisionCard.Controls.Add(txtRemarks)
        pnlDecisionCard.Controls.Add(lblCharCount)
        pnlDecisionCard.Controls.Add(btnApprove)
        pnlDecisionCard.Controls.Add(btnReject)
        pnlDecisionCard.Controls.Add(btnBackToRequests)
        pnlDecisionCard.Location = New Point(0, 110)
        pnlDecisionCard.Name = "pnlDecisionCard"
        pnlDecisionCard.Size = New Size(382, 350)
        pnlDecisionCard.TabIndex = 1
        ' 
        ' lblDecisionHeader
        ' 
        lblDecisionHeader.AutoSize = True
        lblDecisionHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblDecisionHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblDecisionHeader.Location = New Point(12, 10)
        lblDecisionHeader.Name = "lblDecisionHeader"
        lblDecisionHeader.Size = New Size(119, 20)
        lblDecisionHeader.TabIndex = 0
        lblDecisionHeader.Text = "Review Decision"
        ' 
        ' lblRemarksTitle
        ' 
        lblRemarksTitle.AutoSize = True
        lblRemarksTitle.Font = New Font("Segoe UI", 7.0F)
        lblRemarksTitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRemarksTitle.Location = New Point(12, 39)
        lblRemarksTitle.Name = "lblRemarksTitle"
        lblRemarksTitle.Size = New Size(293, 15)
        lblRemarksTitle.TabIndex = 1
        lblRemarksTitle.Text = "Remarks (Optional for approval, required for rejection)"
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtRemarks.BackColor = Color.White
        txtRemarks.BorderStyle = BorderStyle.FixedSingle
        txtRemarks.Font = New Font("Segoe UI", 7.5F)
        txtRemarks.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtRemarks.Location = New Point(12, 61)
        txtRemarks.MaxLength = 500
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.PlaceholderText = "Write your remarks or feedback here... (Required if rejecting)"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(356, 95)
        txtRemarks.TabIndex = 2
        ' 
        ' lblCharCount
        ' 
        lblCharCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblCharCount.Font = New Font("Segoe UI", 6.8F)
        lblCharCount.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblCharCount.Location = New Point(282, 160)
        lblCharCount.Name = "lblCharCount"
        lblCharCount.Size = New Size(85, 17)
        lblCharCount.TabIndex = 3
        lblCharCount.Text = "0 / 500"
        lblCharCount.TextAlign = ContentAlignment.TopRight
        ' 
        ' btnApprove
        ' 
        btnApprove.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnApprove.BackColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        btnApprove.Cursor = Cursors.Hand
        btnApprove.FlatAppearance.BorderSize = 0
        btnApprove.FlatStyle = FlatStyle.Flat
        btnApprove.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        btnApprove.ForeColor = Color.White
        btnApprove.Location = New Point(12, 185)
        btnApprove.Name = "btnApprove"
        btnApprove.Size = New Size(356, 43)
        btnApprove.TabIndex = 4
        btnApprove.Text = "Approve / Clear Submission"
        btnApprove.UseVisualStyleBackColor = False
        ' 
        ' btnReject
        ' 
        btnReject.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnReject.BackColor = Color.FromArgb(CByte(254), CByte(242), CByte(242))
        btnReject.Cursor = Cursors.Hand
        btnReject.FlatAppearance.BorderColor = Color.FromArgb(CByte(254), CByte(202), CByte(202))
        btnReject.FlatStyle = FlatStyle.Flat
        btnReject.Font = New Font("Segoe UI Semibold", 8.0F, FontStyle.Bold)
        btnReject.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        btnReject.Location = New Point(12, 235)
        btnReject.Name = "btnReject"
        btnReject.Size = New Size(356, 43)
        btnReject.TabIndex = 5
        btnReject.Text = "Reject Submission"
        btnReject.UseVisualStyleBackColor = False
        ' 
        ' btnBackToRequests
        ' 
        btnBackToRequests.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBackToRequests.BackColor = Color.Transparent
        btnBackToRequests.Cursor = Cursors.Hand
        btnBackToRequests.FlatAppearance.BorderSize = 0
        btnBackToRequests.FlatStyle = FlatStyle.Flat
        btnBackToRequests.Font = New Font("Segoe UI", 7.5F)
        btnBackToRequests.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        btnBackToRequests.Location = New Point(12, 289)
        btnBackToRequests.Name = "btnBackToRequests"
        btnBackToRequests.Size = New Size(356, 35)
        btnBackToRequests.TabIndex = 6
        btnBackToRequests.Text = "Back to Requests"
        btnBackToRequests.UseVisualStyleBackColor = False
        ' 
        ' pnlTimelineCard
        ' 
        pnlTimelineCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTimelineCard.BackColor = Color.White
        pnlTimelineCard.BorderStyle = BorderStyle.FixedSingle
        pnlTimelineCard.Controls.Add(lblTimelineHeader)
        pnlTimelineCard.Controls.Add(dgvTimeline)
        pnlTimelineCard.Controls.Add(lblTimelineEmpty)
        pnlTimelineCard.Location = New Point(0, 470)
        pnlTimelineCard.Name = "pnlTimelineCard"
        pnlTimelineCard.Size = New Size(382, 148)
        pnlTimelineCard.TabIndex = 2
        ' 
        ' lblTimelineHeader
        ' 
        lblTimelineHeader.AutoSize = True
        lblTimelineHeader.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblTimelineHeader.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblTimelineHeader.Location = New Point(11, 9)
        lblTimelineHeader.Name = "lblTimelineHeader"
        lblTimelineHeader.Size = New Size(114, 20)
        lblTimelineHeader.TabIndex = 0
        lblTimelineHeader.Text = "Activity History"
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
        DataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 7.2F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvTimeline.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvTimeline.ColumnHeadersHeight = 25
        dgvTimeline.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvTimeline.Columns.AddRange(New DataGridViewColumn() {colActivityAction, colActivityDate, colActivityRemarks})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.White
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 7.2F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvTimeline.DefaultCellStyle = DataGridViewCellStyle2
        dgvTimeline.EnableHeadersVisualStyles = False
        dgvTimeline.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvTimeline.Location = New Point(10, 36)
        dgvTimeline.MultiSelect = False
        dgvTimeline.Name = "dgvTimeline"
        dgvTimeline.ReadOnly = True
        dgvTimeline.RowHeadersVisible = False
        dgvTimeline.RowHeadersWidth = 51
        dgvTimeline.RowTemplate.Height = 25
        dgvTimeline.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvTimeline.Size = New Size(360, 100)
        dgvTimeline.TabIndex = 1
        ' 
        ' colActivityAction
        ' 
        colActivityAction.HeaderText = "Action"
        colActivityAction.MinimumWidth = 6
        colActivityAction.Name = "colActivityAction"
        colActivityAction.ReadOnly = True
        colActivityAction.Width = 80
        ' 
        ' colActivityDate
        ' 
        colActivityDate.HeaderText = "Date / Time"
        colActivityDate.MinimumWidth = 6
        colActivityDate.Name = "colActivityDate"
        colActivityDate.ReadOnly = True
        colActivityDate.Width = 95
        ' 
        ' colActivityRemarks
        ' 
        colActivityRemarks.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colActivityRemarks.HeaderText = "Remarks / Details"
        colActivityRemarks.MinimumWidth = 6
        colActivityRemarks.Name = "colActivityRemarks"
        colActivityRemarks.ReadOnly = True
        ' 
        ' lblTimelineEmpty
        ' 
        lblTimelineEmpty.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblTimelineEmpty.Font = New Font("Segoe UI", 7.5F)
        lblTimelineEmpty.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTimelineEmpty.Location = New Point(10, 55)
        lblTimelineEmpty.Name = "lblTimelineEmpty"
        lblTimelineEmpty.Size = New Size(360, 45)
        lblTimelineEmpty.TabIndex = 2
        lblTimelineEmpty.Text = "No previous activity logged."
        lblTimelineEmpty.TextAlign = ContentAlignment.MiddleCenter
        lblTimelineEmpty.Visible = False
        ' 
        ' ReviewClearanceForm
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.White
        ClientSize = New Size(1140, 748)
        pnlContentViewport.AutoScroll = True
        pnlContentViewport.Dock = DockStyle.Fill
        pnlContentViewport.Name = "pnlContentViewport"
        pnlContentViewport.Size = New Size(1140, 748)
        pnlContentViewport.Controls.Add(pnlCard)
        Controls.Add(btnClose)
        Controls.Add(btnMinimize)
        Controls.Add(pnlContentViewport)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(640, 480)
        Name = "ReviewClearanceForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "EClearance - Review Clearance Submission"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlOfficeBadge.ResumeLayout(False)
        pnlStaffBadge.ResumeLayout(False)
        pnlLeftSection.ResumeLayout(False)
        pnlStudentInfoCard.ResumeLayout(False)
        pnlStudentInfoCard.PerformLayout()
        pnlDocumentCard.ResumeLayout(False)
        pnlDocumentCard.PerformLayout()
        pnlDocPreview.ResumeLayout(False)
        CType(picPreview, ComponentModel.ISupportInitialize).EndInit()
        pnlPdfFallback.ResumeLayout(False)
        pnlGuidanceInfo.ResumeLayout(False)
        pnlGuidanceBody.ResumeLayout(False)
        pnlGuidanceNoUpdate.ResumeLayout(False)
        pnlGuidanceNoUpdateCard.ResumeLayout(False)
        pnlGuidanceFields.ResumeLayout(False)
        pnlGuidanceFields.PerformLayout()
        pnlGuidanceInfoNote.ResumeLayout(False)
        pnlGuidanceHeader.ResumeLayout(False)
        pnlGuidanceHeader.PerformLayout()
        pnlClinicFields.ResumeLayout(False)
        pnlClinicFields.PerformLayout()
        pnlClinicNoUpdateCard.ResumeLayout(False)
        pnlClinicNoUpdate.ResumeLayout(False)
        pnlClinicRestrictedCard.ResumeLayout(False)
        pnlClinicRestricted.ResumeLayout(False)
        pnlClinicBody.ResumeLayout(False)
        pnlClinicHeader.ResumeLayout(False)
        pnlClinicHeader.PerformLayout()
        pnlClinicInfo.ResumeLayout(False)
        pnlRightSection.ResumeLayout(False)
        pnlCurrentStatusCard.ResumeLayout(False)
        pnlCurrentStatusCard.PerformLayout()
        pnlDecisionCard.ResumeLayout(False)
        pnlDecisionCard.PerformLayout()
        pnlTimelineCard.ResumeLayout(False)
        pnlTimelineCard.PerformLayout()
        CType(dgvTimeline, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

        PerformLayout()
        pnlContentViewport.AutoScrollMinSize = New Size(1140, 748)
    End Sub

    Friend WithEvents pnlCard As Panel

    Friend WithEvents btnClose As Button
    Friend WithEvents btnMinimize As Button
    Friend WithEvents btnEditGuidance As Button
    Friend WithEvents btnSaveGuidance As Button
    Friend WithEvents btnCancelGuidance As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmergencyName As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtRelationship As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtEmergencyContact As TextBox
    Friend WithEvents txtCivilStatus As TextBox
    Friend WithEvents txtNotes As TextBox

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

    Friend WithEvents lblStatusTitle As Label
    Friend WithEvents lblStatusVal As Label

    Friend WithEvents pnlGuidanceInfo As Panel

    Friend WithEvents pnlGuidanceHeader As Panel

    Friend WithEvents lblGuidanceIcon As Label
    Friend WithEvents lblGuidanceInfoTitle As Label
    Friend WithEvents lblGuidanceInfoSubtitle As Label

    Friend WithEvents pnlGuidanceBody As Panel

    Friend WithEvents pnlGuidanceFields As Panel

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

    Friend WithEvents pnlGuidanceNoUpdate As Panel

    Friend WithEvents pnlGuidanceNoUpdateCard As Panel

    Friend WithEvents lblNoUpdateIcon As Label
    Friend WithEvents lblNoUpdateTitle As Label
    Friend WithEvents lblNoUpdateMessage As Label

    Friend WithEvents pnlDocumentCard As Panel

    Friend WithEvents cmbSubmittedFiles As ComboBox

    Friend WithEvents btnOpenExternal As Button

    Friend WithEvents lblDocFileName As Label
    Friend WithEvents lblDocTitle As Label
    Friend WithEvents lblDocIcon As Label

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

    Friend WithEvents pnlClinicInfo As Panel
    Friend WithEvents pnlClinicHeader As Panel
    Friend WithEvents lblClinicIcon As Label
    Friend WithEvents lblClinicInfoTitle As Label
    Friend WithEvents lblClinicInfoSubtitle As Label
    Friend WithEvents btnOpenAssessmentModal As Button
    Friend WithEvents pnlClinicBody As Panel
    Friend WithEvents pnlClinicRestricted As Panel
    Friend WithEvents pnlClinicRestrictedCard As Panel
    Friend WithEvents lblRestrictedIcon As Label
    Friend WithEvents lblRestrictedTitle As Label
    Friend WithEvents lblRestrictedMessage As Label
    Friend WithEvents pnlClinicNoUpdate As Panel
    Friend WithEvents pnlClinicNoUpdateCard As Panel
    Friend WithEvents lblClinicNoUpdateIcon As Label
    Friend WithEvents lblClinicNoUpdateTitle As Label
    Friend WithEvents lblClinicNoUpdateMessage As Label
    Friend WithEvents pnlClinicFields As Panel
    Friend WithEvents lblClinicMedLabel As Label
    Friend WithEvents lblClinicMedVal As Label
    Friend WithEvents lblClinicAlgLabel As Label
    Friend WithEvents lblClinicAlgVal As Label
    Friend WithEvents lblClinicMedsLabel As Label
    Friend WithEvents lblClinicMedsVal As Label
    Friend WithEvents lblClinicConcernsLabel As Label
    Friend WithEvents lblClinicConcernsVal As Label
    Friend WithEvents lblClinicEmLabel As Label
    Friend WithEvents lblClinicEmVal As Label
    Friend WithEvents lblClinicDecLabel As Label
    Friend WithEvents lblClinicDecVal As Label
    Friend WithEvents lblClinicDocLabel As Label
    Friend WithEvents lblClinicDocVal As Label
    Friend WithEvents btnViewClinicDoc As Button

    Friend WithEvents pnlStudentAffairs As Panel
    Friend WithEvents lblStudentAffairsTitle As Label
    Friend WithEvents lblStudentAffairsInstructions As Label
    Friend WithEvents chkStudentAffairsVerified As CheckBox
    Friend WithEvents pnlContentViewport As Panel
    Friend WithEvents pnlFinanceVerification As Panel
    Friend WithEvents lblFinanceVerificationTitle As Label
    Friend WithEvents lblFinanceVerificationInstructions As Label
    Friend WithEvents chkFinanceVerified As CheckBox
    Friend WithEvents pnlSequentialReview As Panel
    Friend WithEvents lblSequentialReviewTitle As Label
    Friend WithEvents lblSequentialReviewInstructions As Label
    Friend WithEvents pnlPrerequisiteApproval As Panel
    Friend WithEvents lblPrerequisiteApprovalTitle As Label
    Friend WithEvents lblPrerequisiteApprovalDetails As Label
    Friend WithEvents pnlPrerequisiteAccent As Panel
    Friend WithEvents picPrerequisiteStatus As PictureBox
    Friend WithEvents lblPrerequisiteApprovedBy As Label
    Friend WithEvents lblPrerequisiteApproverName As Label
    Friend WithEvents lblPrerequisiteDateCaption As Label
    Friend WithEvents lblPrerequisiteApprovalDate As Label
End Class
