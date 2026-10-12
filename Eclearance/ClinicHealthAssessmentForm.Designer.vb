<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClinicHealthAssessmentForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        pnlHeader = New Panel()
        lblHeaderIcon = New Label()
        lblHeaderTitle = New Label()
        lblHeaderSubtitle = New Label()
        lblStatusBadge = New Label()
        btnClose = New Button()
        pnlFooter = New Panel()
        btnCancel = New Button()
        btnSaveDraft = New Button()
        btnSubmit = New Button()
        pnlScrollContent = New Panel()
        pnlRemarksAlert = New Panel()
        lblRemarksAlertIcon = New Label()
        lblRemarksAlertTitle = New Label()
        lblRemarksAlertText = New Label()
        pnlStudentInfoCard = New Panel()
        lblStudentInfoTitle = New Label()
        lblStudentNo = New Label()
        txtStudentNo = New TextBox()
        lblStudentName = New Label()
        txtStudentName = New TextBox()
        lblCourse = New Label()
        txtCourse = New TextBox()
        lblYearLevel = New Label()
        txtYearLevel = New TextBox()
        lblTerm = New Label()
        txtTerm = New TextBox()
        pnlMedHistoryCard = New Panel()
        lblMedHistoryTitle = New Label()
        lblMedHistoryQuestion = New Label()
        rdoMedHistoryNo = New RadioButton()
        rdoMedHistoryYes = New RadioButton()
        lblMedHistoryDetails = New Label()
        txtMedHistoryDetails = New TextBox()
        pnlAllergiesCard = New Panel()
        lblAllergiesTitle = New Label()
        lblAllergiesQuestion = New Label()
        rdoAllergiesNo = New RadioButton()
        rdoAllergiesYes = New RadioButton()
        lblAllergiesDetails = New Label()
        txtAllergiesDetails = New TextBox()
        pnlMedicationsCard = New Panel()
        lblMedicationsTitle = New Label()
        lblMedicationsQuestion = New Label()
        rdoMedicationsNo = New RadioButton()
        rdoMedicationsYes = New RadioButton()
        lblMedicationsDetails = New Label()
        txtMedicationsDetails = New TextBox()
        pnlHealthConcernsCard = New Panel()
        lblHealthConcernsTitle = New Label()
        lblHealthConcernsQuestion = New Label()
        rdoHealthConcernsNo = New RadioButton()
        rdoHealthConcernsYes = New RadioButton()
        lblHealthConcernsDetails = New Label()
        txtHealthConcernsDetails = New TextBox()
        pnlEmergencyCard = New Panel()
        lblEmergencyTitle = New Label()
        lblEmergencySubtitle = New Label()
        lblEmergencyName = New Label()
        txtEmergencyName = New TextBox()
        lblRelationship = New Label()
        txtRelationship = New TextBox()
        lblEmergencyContactNo = New Label()
        txtEmergencyContactNo = New TextBox()
        pnlDocumentsCard = New Panel()
        lblDocumentsTitle = New Label()
        lblDocumentsSubtitle = New Label()
        btnAttachDocument = New Button()
        btnRemoveDocument = New Button()
        btnViewDocument = New Button()
        lblAttachedFileName = New Label()
        pnlDeclarationCard = New Panel()
        lblDeclarationTitle = New Label()
        chkDeclaration = New CheckBox()
        lblDeclarationNote = New Label()
        pnlHeader.SuspendLayout()
        pnlFooter.SuspendLayout()
        pnlScrollContent.SuspendLayout()
        pnlRemarksAlert.SuspendLayout()
        pnlStudentInfoCard.SuspendLayout()
        pnlMedHistoryCard.SuspendLayout()
        pnlAllergiesCard.SuspendLayout()
        pnlMedicationsCard.SuspendLayout()
        pnlHealthConcernsCard.SuspendLayout()
        pnlEmergencyCard.SuspendLayout()
        pnlDocumentsCard.SuspendLayout()
        pnlDeclarationCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.BorderStyle = BorderStyle.FixedSingle
        pnlHeader.Controls.Add(lblHeaderIcon)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblHeaderSubtitle)
        pnlHeader.Controls.Add(lblStatusBadge)
        pnlHeader.Controls.Add(btnClose)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(760, 75)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderIcon
        ' 
        lblHeaderIcon.BackColor = Color.FromArgb(CByte(224), CByte(242), CByte(254))
        lblHeaderIcon.Font = New Font("Segoe UI", 16.0F, FontStyle.Bold)
        lblHeaderIcon.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        lblHeaderIcon.Location = New Point(18, 16)
        lblHeaderIcon.Name = "lblHeaderIcon"
        lblHeaderIcon.Size = New Size(42, 42)
        lblHeaderIcon.TabIndex = 0
        lblHeaderIcon.Text = "✚"
        lblHeaderIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 13.5F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(68, 14)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(254, 25)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Clinic Health Assessment"
        ' 
        ' lblHeaderSubtitle
        ' 
        lblHeaderSubtitle.AutoSize = True
        lblHeaderSubtitle.Font = New Font("Segoe UI", 8.5F)
        lblHeaderSubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHeaderSubtitle.Location = New Point(70, 42)
        lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        lblHeaderSubtitle.Size = New Size(302, 15)
        lblHeaderSubtitle.TabIndex = 2
        lblHeaderSubtitle.Text = "Digital Student Health and Medical Assessment Questionnaire"
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatusBadge.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblStatusBadge.Location = New Point(570, 24)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Size = New Size(140, 26)
        lblStatusBadge.TabIndex = 3
        lblStatusBadge.Text = "Not Submitted"
        lblStatusBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnClose.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        btnClose.Location = New Point(718, 14)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(32, 32)
        btnClose.TabIndex = 4
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' pnlFooter
        ' 
        pnlFooter.BackColor = Color.White
        pnlFooter.BorderStyle = BorderStyle.FixedSingle
        pnlFooter.Controls.Add(btnCancel)
        pnlFooter.Controls.Add(btnSaveDraft)
        pnlFooter.Controls.Add(btnSubmit)
        pnlFooter.Dock = DockStyle.Bottom
        pnlFooter.Location = New Point(0, 655)
        pnlFooter.Name = "pnlFooter"
        pnlFooter.Size = New Size(760, 65)
        pnlFooter.TabIndex = 2
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        btnCancel.Location = New Point(18, 14)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 36)
        btnCancel.TabIndex = 0
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSaveDraft
        ' 
        btnSaveDraft.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSaveDraft.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnSaveDraft.Cursor = Cursors.Hand
        btnSaveDraft.FlatAppearance.BorderSize = 0
        btnSaveDraft.FlatStyle = FlatStyle.Flat
        btnSaveDraft.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSaveDraft.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnSaveDraft.Location = New Point(445, 14)
        btnSaveDraft.Name = "btnSaveDraft"
        btnSaveDraft.Size = New Size(125, 36)
        btnSaveDraft.TabIndex = 1
        btnSaveDraft.Text = "Save Draft"
        btnSaveDraft.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnSubmit.BackColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(580, 14)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(160, 36)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "Submit Assessment"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' pnlScrollContent
        ' 
        pnlScrollContent.AutoScroll = True
        pnlScrollContent.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlScrollContent.Controls.Add(pnlRemarksAlert)
        pnlScrollContent.Controls.Add(pnlStudentInfoCard)
        pnlScrollContent.Controls.Add(pnlMedHistoryCard)
        pnlScrollContent.Controls.Add(pnlAllergiesCard)
        pnlMedicationsCard.Location = New Point(18, 595)
        pnlScrollContent.Controls.Add(pnlMedicationsCard)
        pnlHealthConcernsCard.Location = New Point(18, 745)
        pnlScrollContent.Controls.Add(pnlHealthConcernsCard)
        pnlEmergencyCard.Location = New Point(18, 895)
        pnlScrollContent.Controls.Add(pnlEmergencyCard)
        pnlDocumentsCard.Location = New Point(18, 1055)
        pnlScrollContent.Controls.Add(pnlDocumentsCard)
        pnlDeclarationCard.Location = New Point(18, 1205)
        pnlScrollContent.Controls.Add(pnlDeclarationCard)
        pnlScrollContent.Dock = DockStyle.Fill
        pnlScrollContent.Location = New Point(0, 75)
        pnlScrollContent.Name = "pnlScrollContent"
        pnlScrollContent.Padding = New Padding(18, 14, 18, 20)
        pnlScrollContent.Size = New Size(760, 580)
        pnlScrollContent.TabIndex = 1
        ' 
        ' pnlRemarksAlert
        ' 
        pnlRemarksAlert.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRemarksAlert.BackColor = Color.FromArgb(CByte(254), CByte(243), CByte(199))
        pnlRemarksAlert.BorderStyle = BorderStyle.FixedSingle
        pnlRemarksAlert.Controls.Add(lblRemarksAlertIcon)
        pnlRemarksAlert.Controls.Add(lblRemarksAlertTitle)
        pnlRemarksAlert.Controls.Add(lblRemarksAlertText)
        pnlRemarksAlert.Location = New Point(18, 14)
        pnlRemarksAlert.Name = "pnlRemarksAlert"
        pnlRemarksAlert.Size = New Size(706, 68)
        pnlRemarksAlert.TabIndex = 0
        pnlRemarksAlert.Visible = False
        ' 
        ' lblRemarksAlertIcon
        ' 
        lblRemarksAlertIcon.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        lblRemarksAlertIcon.ForeColor = Color.FromArgb(CByte(180), CByte(83), CByte(9))
        lblRemarksAlertIcon.Location = New Point(10, 8)
        lblRemarksAlertIcon.Name = "lblRemarksAlertIcon"
        lblRemarksAlertIcon.Size = New Size(24, 24)
        lblRemarksAlertIcon.TabIndex = 0
        lblRemarksAlertIcon.Text = "⚠"
        ' 
        ' lblRemarksAlertTitle
        ' 
        lblRemarksAlertTitle.AutoSize = True
        lblRemarksAlertTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblRemarksAlertTitle.ForeColor = Color.FromArgb(CByte(146), CByte(64), CByte(14))
        lblRemarksAlertTitle.Location = New Point(36, 10)
        lblRemarksAlertTitle.Name = "lblRemarksAlertTitle"
        lblRemarksAlertTitle.Size = New Size(245, 15)
        lblRemarksAlertTitle.TabIndex = 1
        lblRemarksAlertTitle.Text = "Clinic Office Notice — Returned for Completion:"
        ' 
        ' lblRemarksAlertText
        ' 
        lblRemarksAlertText.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblRemarksAlertText.Font = New Font("Segoe UI", 8.5F)
        lblRemarksAlertText.ForeColor = Color.FromArgb(CByte(120), CByte(53), CByte(15))
        lblRemarksAlertText.Location = New Point(36, 30)
        lblRemarksAlertText.Name = "lblRemarksAlertText"
        lblRemarksAlertText.Size = New Size(656, 30)
        lblRemarksAlertText.TabIndex = 2
        lblRemarksAlertText.Text = "Please update your assessment or provide the requested information below and resubmit."
        ' 
        ' pnlStudentInfoCard
        ' 
        pnlStudentInfoCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlStudentInfoCard.BackColor = Color.White
        pnlStudentInfoCard.BorderStyle = BorderStyle.FixedSingle
        pnlStudentInfoCard.Controls.Add(lblStudentInfoTitle)
        pnlStudentInfoCard.Controls.Add(lblStudentNo)
        pnlStudentInfoCard.Controls.Add(txtStudentNo)
        pnlStudentInfoCard.Controls.Add(lblStudentName)
        pnlStudentInfoCard.Controls.Add(txtStudentName)
        pnlStudentInfoCard.Controls.Add(lblCourse)
        pnlStudentInfoCard.Controls.Add(txtCourse)
        pnlStudentInfoCard.Controls.Add(lblYearLevel)
        pnlStudentInfoCard.Controls.Add(txtYearLevel)
        pnlStudentInfoCard.Controls.Add(lblTerm)
        pnlStudentInfoCard.Controls.Add(txtTerm)
        pnlStudentInfoCard.Location = New Point(18, 92)
        pnlStudentInfoCard.Name = "pnlStudentInfoCard"
        pnlStudentInfoCard.Padding = New Padding(14)
        pnlStudentInfoCard.Size = New Size(706, 185)
        pnlStudentInfoCard.TabIndex = 1
        ' 
        ' lblStudentInfoTitle
        ' 
        lblStudentInfoTitle.AutoSize = True
        lblStudentInfoTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblStudentInfoTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStudentInfoTitle.Location = New Point(14, 12)
        lblStudentInfoTitle.Name = "lblStudentInfoTitle"
        lblStudentInfoTitle.Size = New Size(198, 17)
        lblStudentInfoTitle.TabIndex = 0
        lblStudentInfoTitle.Text = "SECTION 1: Student Information"
        ' 
        ' lblStudentNo
        ' 
        lblStudentNo.AutoSize = True
        lblStudentNo.Font = New Font("Segoe UI", 8.0F)
        lblStudentNo.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentNo.Location = New Point(16, 42)
        lblStudentNo.Name = "lblStudentNo"
        lblStudentNo.Size = New Size(65, 13)
        lblStudentNo.TabIndex = 1
        lblStudentNo.Text = "Student No:"
        ' 
        ' txtStudentNo
        ' 
        txtStudentNo.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        txtStudentNo.Font = New Font("Segoe UI", 9.0F)
        txtStudentNo.Location = New Point(16, 60)
        txtStudentNo.Name = "txtStudentNo"
        txtStudentNo.ReadOnly = True
        txtStudentNo.Size = New Size(190, 23)
        txtStudentNo.TabIndex = 2
        ' 
        ' lblStudentName
        ' 
        lblStudentName.AutoSize = True
        lblStudentName.Font = New Font("Segoe UI", 8.0F)
        lblStudentName.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStudentName.Location = New Point(226, 42)
        lblStudentName.Name = "lblStudentName"
        lblStudentName.Size = New Size(61, 13)
        lblStudentName.TabIndex = 3
        lblStudentName.Text = "Full Name:"
        ' 
        ' txtStudentName
        ' 
        txtStudentName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtStudentName.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        txtStudentName.Font = New Font("Segoe UI", 9.0F)
        txtStudentName.Location = New Point(226, 60)
        txtStudentName.Name = "txtStudentName"
        txtStudentName.ReadOnly = True
        txtStudentName.Size = New Size(462, 23)
        txtStudentName.TabIndex = 4
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 8.0F)
        lblCourse.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblCourse.Location = New Point(16, 100)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(99, 13)
        lblCourse.TabIndex = 5
        lblCourse.Text = "Program / Course:"
        ' 
        ' txtCourse
        ' 
        txtCourse.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        txtCourse.Font = New Font("Segoe UI", 9.0F)
        txtCourse.Location = New Point(16, 118)
        txtCourse.Name = "txtCourse"
        txtCourse.ReadOnly = True
        txtCourse.Size = New Size(190, 23)
        txtCourse.TabIndex = 6
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI", 8.0F)
        lblYearLevel.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblYearLevel.Location = New Point(226, 100)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(59, 13)
        lblYearLevel.TabIndex = 7
        lblYearLevel.Text = "Year Level:"
        ' 
        ' txtYearLevel
        ' 
        txtYearLevel.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        txtYearLevel.Font = New Font("Segoe UI", 9.0F)
        txtYearLevel.Location = New Point(226, 118)
        txtYearLevel.Name = "txtYearLevel"
        txtYearLevel.ReadOnly = True
        txtYearLevel.Size = New Size(190, 23)
        txtYearLevel.TabIndex = 8
        ' 
        ' lblTerm
        ' 
        lblTerm.AutoSize = True
        lblTerm.Font = New Font("Segoe UI", 8.0F)
        lblTerm.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTerm.Location = New Point(436, 100)
        lblTerm.Name = "lblTerm"
        lblTerm.Size = New Size(86, 13)
        lblTerm.TabIndex = 9
        lblTerm.Text = "Academic Term:"
        ' 
        ' txtTerm
        ' 
        txtTerm.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtTerm.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        txtTerm.Font = New Font("Segoe UI", 9.0F)
        txtTerm.Location = New Point(436, 118)
        txtTerm.Name = "txtTerm"
        txtTerm.ReadOnly = True
        txtTerm.Size = New Size(252, 23)
        txtTerm.TabIndex = 10
        ' 
        ' pnlMedHistoryCard
        ' 
        pnlMedHistoryCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMedHistoryCard.BackColor = Color.White
        pnlMedHistoryCard.BorderStyle = BorderStyle.FixedSingle
        pnlMedHistoryCard.Controls.Add(lblMedHistoryTitle)
        pnlMedHistoryCard.Controls.Add(lblMedHistoryQuestion)
        pnlMedHistoryCard.Controls.Add(rdoMedHistoryNo)
        pnlMedHistoryCard.Controls.Add(rdoMedHistoryYes)
        pnlMedHistoryCard.Controls.Add(lblMedHistoryDetails)
        pnlMedHistoryCard.Controls.Add(txtMedHistoryDetails)
        pnlMedHistoryCard.Location = New Point(18, 290)
        pnlMedHistoryCard.Name = "pnlMedHistoryCard"
        pnlMedHistoryCard.Padding = New Padding(14)
        pnlMedHistoryCard.Size = New Size(706, 138)
        pnlMedHistoryCard.TabIndex = 2
        ' 
        ' lblMedHistoryTitle
        ' 
        lblMedHistoryTitle.AutoSize = True
        lblMedHistoryTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblMedHistoryTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblMedHistoryTitle.Location = New Point(14, 12)
        lblMedHistoryTitle.Name = "lblMedHistoryTitle"
        lblMedHistoryTitle.Size = New Size(176, 17)
        lblMedHistoryTitle.TabIndex = 0
        lblMedHistoryTitle.Text = "SECTION 2: Medical History"
        ' 
        ' lblMedHistoryQuestion
        ' 
        lblMedHistoryQuestion.AutoSize = True
        lblMedHistoryQuestion.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblMedHistoryQuestion.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblMedHistoryQuestion.Location = New Point(14, 38)
        lblMedHistoryQuestion.Name = "lblMedHistoryQuestion"
        lblMedHistoryQuestion.Size = New Size(544, 15)
        lblMedHistoryQuestion.TabIndex = 1
        lblMedHistoryQuestion.Text = "Do you have any known medical conditions (e.g. asthma, heart condition, diabetes, hypertension)?"
        ' 
        ' rdoMedHistoryNo
        ' 
        rdoMedHistoryNo.AutoSize = True
        rdoMedHistoryNo.Checked = True
        rdoMedHistoryNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoMedHistoryNo.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoMedHistoryNo.Location = New Point(18, 62)
        rdoMedHistoryNo.Name = "rdoMedHistoryNo"
        rdoMedHistoryNo.Size = New Size(41, 19)
        rdoMedHistoryNo.TabIndex = 2
        rdoMedHistoryNo.TabStop = True
        rdoMedHistoryNo.Text = "No"
        rdoMedHistoryNo.UseVisualStyleBackColor = True
        ' 
        ' rdoMedHistoryYes
        ' 
        rdoMedHistoryYes.AutoSize = True
        rdoMedHistoryYes.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoMedHistoryYes.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoMedHistoryYes.Location = New Point(80, 62)
        rdoMedHistoryYes.Name = "rdoMedHistoryYes"
        rdoMedHistoryYes.Size = New Size(42, 19)
        rdoMedHistoryYes.TabIndex = 3
        rdoMedHistoryYes.Text = "Yes"
        rdoMedHistoryYes.UseVisualStyleBackColor = True
        ' 
        ' lblMedHistoryDetails
        ' 
        lblMedHistoryDetails.AutoSize = True
        lblMedHistoryDetails.Font = New Font("Segoe UI", 8.0F)
        lblMedHistoryDetails.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblMedHistoryDetails.Location = New Point(148, 65)
        lblMedHistoryDetails.Name = "lblMedHistoryDetails"
        lblMedHistoryDetails.Size = New Size(244, 13)
        lblMedHistoryDetails.TabIndex = 4
        lblMedHistoryDetails.Text = "Please specify (optional details for Clinic review):"
        ' 
        ' txtMedHistoryDetails
        ' 
        txtMedHistoryDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMedHistoryDetails.Enabled = False
        txtMedHistoryDetails.Font = New Font("Segoe UI", 8.5F)
        txtMedHistoryDetails.Location = New Point(148, 84)
        txtMedHistoryDetails.Multiline = True
        txtMedHistoryDetails.Name = "txtMedHistoryDetails"
        txtMedHistoryDetails.ScrollBars = ScrollBars.Vertical
        txtMedHistoryDetails.Size = New Size(540, 40)
        txtMedHistoryDetails.TabIndex = 5
        ' 
        ' pnlAllergiesCard
        ' 
        pnlAllergiesCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlAllergiesCard.BackColor = Color.White
        pnlAllergiesCard.BorderStyle = BorderStyle.FixedSingle
        pnlAllergiesCard.Controls.Add(lblAllergiesTitle)
        pnlAllergiesCard.Controls.Add(lblAllergiesQuestion)
        pnlAllergiesCard.Controls.Add(rdoAllergiesNo)
        pnlAllergiesCard.Controls.Add(rdoAllergiesYes)
        pnlAllergiesCard.Controls.Add(lblAllergiesDetails)
        pnlAllergiesCard.Controls.Add(txtAllergiesDetails)
        pnlAllergiesCard.Location = New Point(18, 442)
        pnlAllergiesCard.Name = "pnlAllergiesCard"
        pnlAllergiesCard.Padding = New Padding(14)
        pnlAllergiesCard.Size = New Size(706, 138)
        pnlAllergiesCard.TabIndex = 3
        ' 
        ' lblAllergiesTitle
        ' 
        lblAllergiesTitle.AutoSize = True
        lblAllergiesTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblAllergiesTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblAllergiesTitle.Location = New Point(14, 12)
        lblAllergiesTitle.Name = "lblAllergiesTitle"
        lblAllergiesTitle.Size = New Size(134, 17)
        lblAllergiesTitle.TabIndex = 0
        lblAllergiesTitle.Text = "SECTION 3: Allergies"
        ' 
        ' lblAllergiesQuestion
        ' 
        lblAllergiesQuestion.AutoSize = True
        lblAllergiesQuestion.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblAllergiesQuestion.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblAllergiesQuestion.Location = New Point(14, 38)
        lblAllergiesQuestion.Name = "lblAllergiesQuestion"
        lblAllergiesQuestion.Size = New Size(473, 15)
        lblAllergiesQuestion.TabIndex = 1
        lblAllergiesQuestion.Text = "Do you have any known allergies to food, medications, or other substances/materials?"
        ' 
        ' rdoAllergiesNo
        ' 
        rdoAllergiesNo.AutoSize = True
        rdoAllergiesNo.Checked = True
        rdoAllergiesNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoAllergiesNo.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoAllergiesNo.Location = New Point(18, 62)
        rdoAllergiesNo.Name = "rdoAllergiesNo"
        rdoAllergiesNo.Size = New Size(41, 19)
        rdoAllergiesNo.TabIndex = 2
        rdoAllergiesNo.TabStop = True
        rdoAllergiesNo.Text = "No"
        rdoAllergiesNo.UseVisualStyleBackColor = True
        ' 
        ' rdoAllergiesYes
        ' 
        rdoAllergiesYes.AutoSize = True
        rdoAllergiesYes.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoAllergiesYes.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoAllergiesYes.Location = New Point(80, 62)
        rdoAllergiesYes.Name = "rdoAllergiesYes"
        rdoAllergiesYes.Size = New Size(42, 19)
        rdoAllergiesYes.TabIndex = 3
        rdoAllergiesYes.Text = "Yes"
        rdoAllergiesYes.UseVisualStyleBackColor = True
        ' 
        ' lblAllergiesDetails
        ' 
        lblAllergiesDetails.AutoSize = True
        lblAllergiesDetails.Font = New Font("Segoe UI", 8.0F)
        lblAllergiesDetails.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblAllergiesDetails.Location = New Point(148, 65)
        lblAllergiesDetails.Name = "lblAllergiesDetails"
        lblAllergiesDetails.Size = New Size(81, 13)
        lblAllergiesDetails.TabIndex = 4
        lblAllergiesDetails.Text = "Please specify:"
        ' 
        ' txtAllergiesDetails
        ' 
        txtAllergiesDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtAllergiesDetails.Enabled = False
        txtAllergiesDetails.Font = New Font("Segoe UI", 8.5F)
        txtAllergiesDetails.Location = New Point(148, 84)
        txtAllergiesDetails.Multiline = True
        txtAllergiesDetails.Name = "txtAllergiesDetails"
        txtAllergiesDetails.ScrollBars = ScrollBars.Vertical
        txtAllergiesDetails.Size = New Size(540, 40)
        txtAllergiesDetails.TabIndex = 5
        ' 
        ' pnlMedicationsCard
        ' 
        pnlMedicationsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMedicationsCard.BackColor = Color.White
        pnlMedicationsCard.BorderStyle = BorderStyle.FixedSingle
        pnlMedicationsCard.Controls.Add(lblMedicationsTitle)
        pnlMedicationsCard.Controls.Add(lblMedicationsQuestion)
        pnlMedicationsCard.Controls.Add(rdoMedicationsNo)
        pnlMedicationsCard.Controls.Add(rdoMedicationsYes)
        pnlMedicationsCard.Controls.Add(lblMedicationsDetails)
        pnlMedicationsCard.Controls.Add(txtMedicationsDetails)
        pnlMedicationsCard.Location = New Point(18, 595)
        pnlMedicationsCard.Name = "pnlMedicationsCard"
        pnlMedicationsCard.Padding = New Padding(14)
        pnlMedicationsCard.Size = New Size(706, 138)
        pnlMedicationsCard.TabIndex = 4
        ' 
        ' lblMedicationsTitle
        ' 
        lblMedicationsTitle.AutoSize = True
        lblMedicationsTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblMedicationsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblMedicationsTitle.Location = New Point(14, 12)
        lblMedicationsTitle.Name = "lblMedicationsTitle"
        lblMedicationsTitle.Size = New Size(207, 17)
        lblMedicationsTitle.TabIndex = 0
        lblMedicationsTitle.Text = "SECTION 4: Current Medications"
        ' 
        ' lblMedicationsQuestion
        ' 
        lblMedicationsQuestion.AutoSize = True
        lblMedicationsQuestion.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblMedicationsQuestion.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblMedicationsQuestion.Location = New Point(14, 38)
        lblMedicationsQuestion.Name = "lblMedicationsQuestion"
        lblMedicationsQuestion.Size = New Size(397, 15)
        lblMedicationsQuestion.TabIndex = 1
        lblMedicationsQuestion.Text = "Are you currently taking any regular or maintenance medications?"
        ' 
        ' rdoMedicationsNo
        ' 
        rdoMedicationsNo.AutoSize = True
        rdoMedicationsNo.Checked = True
        rdoMedicationsNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoMedicationsNo.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoMedicationsNo.Location = New Point(18, 62)
        rdoMedicationsNo.Name = "rdoMedicationsNo"
        rdoMedicationsNo.Size = New Size(41, 19)
        rdoMedicationsNo.TabIndex = 2
        rdoMedicationsNo.TabStop = True
        rdoMedicationsNo.Text = "No"
        rdoMedicationsNo.UseVisualStyleBackColor = True
        ' 
        ' rdoMedicationsYes
        ' 
        rdoMedicationsYes.AutoSize = True
        rdoMedicationsYes.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoMedicationsYes.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoMedicationsYes.Location = New Point(80, 62)
        rdoMedicationsYes.Name = "rdoMedicationsYes"
        rdoMedicationsYes.Size = New Size(42, 19)
        rdoMedicationsYes.TabIndex = 3
        rdoMedicationsYes.Text = "Yes"
        rdoMedicationsYes.UseVisualStyleBackColor = True
        ' 
        ' lblMedicationsDetails
        ' 
        lblMedicationsDetails.AutoSize = True
        lblMedicationsDetails.Font = New Font("Segoe UI", 8.0F)
        lblMedicationsDetails.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblMedicationsDetails.Location = New Point(148, 65)
        lblMedicationsDetails.Name = "lblMedicationsDetails"
        lblMedicationsDetails.Size = New Size(244, 13)
        lblMedicationsDetails.TabIndex = 4
        lblMedicationsDetails.Text = "You may provide relevant details for the Clinic:"
        ' 
        ' txtMedicationsDetails
        ' 
        txtMedicationsDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtMedicationsDetails.Enabled = False
        txtMedicationsDetails.Font = New Font("Segoe UI", 8.5F)
        txtMedicationsDetails.Location = New Point(148, 84)
        txtMedicationsDetails.Multiline = True
        txtMedicationsDetails.Name = "txtMedicationsDetails"
        txtMedicationsDetails.ScrollBars = ScrollBars.Vertical
        txtMedicationsDetails.Size = New Size(540, 40)
        txtMedicationsDetails.TabIndex = 5
        ' 
        ' pnlHealthConcernsCard
        ' 
        pnlHealthConcernsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHealthConcernsCard.BackColor = Color.White
        pnlHealthConcernsCard.BorderStyle = BorderStyle.FixedSingle
        pnlHealthConcernsCard.Controls.Add(lblHealthConcernsTitle)
        pnlHealthConcernsCard.Controls.Add(lblHealthConcernsQuestion)
        pnlHealthConcernsCard.Controls.Add(rdoHealthConcernsNo)
        pnlHealthConcernsCard.Controls.Add(rdoHealthConcernsYes)
        pnlHealthConcernsCard.Controls.Add(lblHealthConcernsDetails)
        pnlHealthConcernsCard.Controls.Add(txtHealthConcernsDetails)
        pnlHealthConcernsCard.Location = New Point(18, 745)
        pnlHealthConcernsCard.Name = "pnlHealthConcernsCard"
        pnlHealthConcernsCard.Padding = New Padding(14)
        pnlHealthConcernsCard.Size = New Size(706, 138)
        pnlHealthConcernsCard.TabIndex = 5
        ' 
        ' lblHealthConcernsTitle
        ' 
        lblHealthConcernsTitle.AutoSize = True
        lblHealthConcernsTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblHealthConcernsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHealthConcernsTitle.Location = New Point(14, 12)
        lblHealthConcernsTitle.Name = "lblHealthConcernsTitle"
        lblHealthConcernsTitle.Size = New Size(185, 17)
        lblHealthConcernsTitle.TabIndex = 0
        lblHealthConcernsTitle.Text = "SECTION 5: Health Concerns"
        ' 
        ' lblHealthConcernsQuestion
        ' 
        lblHealthConcernsQuestion.AutoSize = True
        lblHealthConcernsQuestion.Font = New Font("Segoe UI", 8.5F, FontStyle.Bold)
        lblHealthConcernsQuestion.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblHealthConcernsQuestion.Location = New Point(14, 38)
        lblHealthConcernsQuestion.Name = "lblHealthConcernsQuestion"
        lblHealthConcernsQuestion.Size = New Size(498, 15)
        lblHealthConcernsQuestion.TabIndex = 1
        lblHealthConcernsQuestion.Text = "Do you have any health concerns or symptoms that the School Clinic should be aware of?"
        ' 
        ' rdoHealthConcernsNo
        ' 
        rdoHealthConcernsNo.AutoSize = True
        rdoHealthConcernsNo.Checked = True
        rdoHealthConcernsNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoHealthConcernsNo.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoHealthConcernsNo.Location = New Point(18, 62)
        rdoHealthConcernsNo.Name = "rdoHealthConcernsNo"
        rdoHealthConcernsNo.Size = New Size(41, 19)
        rdoHealthConcernsNo.TabIndex = 2
        rdoHealthConcernsNo.TabStop = True
        rdoHealthConcernsNo.Text = "No"
        rdoHealthConcernsNo.UseVisualStyleBackColor = True
        ' 
        ' rdoHealthConcernsYes
        ' 
        rdoHealthConcernsYes.AutoSize = True
        rdoHealthConcernsYes.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        rdoHealthConcernsYes.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        rdoHealthConcernsYes.Location = New Point(80, 62)
        rdoHealthConcernsYes.Name = "rdoHealthConcernsYes"
        rdoHealthConcernsYes.Size = New Size(42, 19)
        rdoHealthConcernsYes.TabIndex = 3
        rdoHealthConcernsYes.Text = "Yes"
        rdoHealthConcernsYes.UseVisualStyleBackColor = True
        ' 
        ' lblHealthConcernsDetails
        ' 
        lblHealthConcernsDetails.AutoSize = True
        lblHealthConcernsDetails.Font = New Font("Segoe UI", 8.0F)
        lblHealthConcernsDetails.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHealthConcernsDetails.Location = New Point(148, 65)
        lblHealthConcernsDetails.Name = "lblHealthConcernsDetails"
        lblHealthConcernsDetails.Size = New Size(81, 13)
        lblHealthConcernsDetails.TabIndex = 4
        lblHealthConcernsDetails.Text = "Please specify:"
        ' 
        ' txtHealthConcernsDetails
        ' 
        txtHealthConcernsDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtHealthConcernsDetails.Enabled = False
        txtHealthConcernsDetails.Font = New Font("Segoe UI", 8.5F)
        txtHealthConcernsDetails.Location = New Point(148, 84)
        txtHealthConcernsDetails.Multiline = True
        txtHealthConcernsDetails.Name = "txtHealthConcernsDetails"
        txtHealthConcernsDetails.ScrollBars = ScrollBars.Vertical
        txtHealthConcernsDetails.Size = New Size(540, 40)
        txtHealthConcernsDetails.TabIndex = 5
        ' 
        ' pnlEmergencyCard
        ' 
        pnlEmergencyCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEmergencyCard.BackColor = Color.White
        pnlEmergencyCard.BorderStyle = BorderStyle.FixedSingle
        pnlEmergencyCard.Controls.Add(lblEmergencyTitle)
        pnlEmergencyCard.Controls.Add(lblEmergencySubtitle)
        pnlEmergencyCard.Controls.Add(lblEmergencyName)
        pnlEmergencyCard.Controls.Add(txtEmergencyName)
        pnlEmergencyCard.Controls.Add(lblRelationship)
        pnlEmergencyCard.Controls.Add(txtRelationship)
        pnlEmergencyCard.Controls.Add(lblEmergencyContactNo)
        pnlEmergencyCard.Controls.Add(txtEmergencyContactNo)
        pnlEmergencyCard.Location = New Point(18, 895)
        pnlEmergencyCard.Name = "pnlEmergencyCard"
        pnlEmergencyCard.Padding = New Padding(14)
        pnlEmergencyCard.Size = New Size(706, 145)
        pnlEmergencyCard.TabIndex = 6
        ' 
        ' lblEmergencyTitle
        ' 
        lblEmergencyTitle.AutoSize = True
        lblEmergencyTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblEmergencyTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblEmergencyTitle.Location = New Point(14, 12)
        lblEmergencyTitle.Name = "lblEmergencyTitle"
        lblEmergencyTitle.Size = New Size(260, 17)
        lblEmergencyTitle.TabIndex = 0
        lblEmergencyTitle.Text = "SECTION 6: Emergency Contact Details *"
        ' 
        ' lblEmergencySubtitle
        ' 
        lblEmergencySubtitle.AutoSize = True
        lblEmergencySubtitle.Font = New Font("Segoe UI", 8.0F)
        lblEmergencySubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblEmergencySubtitle.Location = New Point(14, 34)
        lblEmergencySubtitle.Name = "lblEmergencySubtitle"
        lblEmergencySubtitle.Size = New Size(309, 13)
        lblEmergencySubtitle.TabIndex = 1
        lblEmergencySubtitle.Text = "Authorized parent, guardian, or relative in case of emergency."
        ' 
        ' lblEmergencyName
        ' 
        lblEmergencyName.AutoSize = True
        lblEmergencyName.Font = New Font("Segoe UI", 8.0F)
        lblEmergencyName.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblEmergencyName.Location = New Point(16, 62)
        lblEmergencyName.Name = "lblEmergencyName"
        lblEmergencyName.Size = New Size(119, 13)
        lblEmergencyName.TabIndex = 2
        lblEmergencyName.Text = "Emergency Contact Full Name:"
        ' 
        ' txtEmergencyName
        ' 
        txtEmergencyName.Font = New Font("Segoe UI", 9.0F)
        txtEmergencyName.Location = New Point(16, 80)
        txtEmergencyName.Name = "txtEmergencyName"
        txtEmergencyName.Size = New Size(250, 23)
        txtEmergencyName.TabIndex = 3
        ' 
        ' lblRelationship
        ' 
        lblRelationship.AutoSize = True
        lblRelationship.Font = New Font("Segoe UI", 8.0F)
        lblRelationship.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRelationship.Location = New Point(286, 62)
        lblRelationship.Name = "lblRelationship"
        lblRelationship.Size = New Size(74, 13)
        lblRelationship.TabIndex = 4
        lblRelationship.Text = "Relationship:"
        ' 
        ' txtRelationship
        ' 
        txtRelationship.Font = New Font("Segoe UI", 9.0F)
        txtRelationship.Location = New Point(286, 80)
        txtRelationship.Name = "txtRelationship"
        txtRelationship.Size = New Size(170, 23)
        txtRelationship.TabIndex = 5
        ' 
        ' lblEmergencyContactNo
        ' 
        lblEmergencyContactNo.AutoSize = True
        lblEmergencyContactNo.Font = New Font("Segoe UI", 8.0F)
        lblEmergencyContactNo.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblEmergencyContactNo.Location = New Point(476, 62)
        lblEmergencyContactNo.Name = "lblEmergencyContactNo"
        lblEmergencyContactNo.Size = New Size(94, 13)
        lblEmergencyContactNo.TabIndex = 6
        lblEmergencyContactNo.Text = "Contact Number:"
        ' 
        ' txtEmergencyContactNo
        ' 
        txtEmergencyContactNo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtEmergencyContactNo.Font = New Font("Segoe UI", 9.0F)
        txtEmergencyContactNo.Location = New Point(476, 80)
        txtEmergencyContactNo.Name = "txtEmergencyContactNo"
        txtEmergencyContactNo.Size = New Size(212, 23)
        txtEmergencyContactNo.TabIndex = 7
        ' 
        ' pnlDocumentsCard
        ' 
        pnlDocumentsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDocumentsCard.BackColor = Color.White
        pnlDocumentsCard.BorderStyle = BorderStyle.FixedSingle
        pnlDocumentsCard.Controls.Add(lblDocumentsTitle)
        pnlDocumentsCard.Controls.Add(lblDocumentsSubtitle)
        pnlDocumentsCard.Controls.Add(btnAttachDocument)
        pnlDocumentsCard.Controls.Add(btnRemoveDocument)
        pnlDocumentsCard.Controls.Add(btnViewDocument)
        pnlDocumentsCard.Controls.Add(lblAttachedFileName)
        pnlDocumentsCard.Location = New Point(18, 1055)
        pnlDocumentsCard.Name = "pnlDocumentsCard"
        pnlDocumentsCard.Padding = New Padding(14)
        pnlDocumentsCard.Size = New Size(706, 135)
        pnlDocumentsCard.TabIndex = 7
        ' 
        ' lblDocumentsTitle
        ' 
        lblDocumentsTitle.AutoSize = True
        lblDocumentsTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblDocumentsTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDocumentsTitle.Location = New Point(14, 12)
        lblDocumentsTitle.Name = "lblDocumentsTitle"
        lblDocumentsTitle.Size = New Size(393, 17)
        lblDocumentsTitle.TabIndex = 0
        lblDocumentsTitle.Text = "SECTION 7: Supporting Medical Documents (Conditional / Optional)"
        ' 
        ' lblDocumentsSubtitle
        ' 
        lblDocumentsSubtitle.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDocumentsSubtitle.Font = New Font("Segoe UI", 8.0F)
        lblDocumentsSubtitle.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDocumentsSubtitle.Location = New Point(14, 34)
        lblDocumentsSubtitle.Name = "lblDocumentsSubtitle"
        lblDocumentsSubtitle.Size = New Size(674, 28)
        lblDocumentsSubtitle.TabIndex = 1
        lblDocumentsSubtitle.Text = "Medical certificates, laboratory results, or medical clearances are required only if requested by Clinic staff. Allowed formats: PDF, JPG, JPEG, PNG (Max 5MB)."
        ' 
        ' btnAttachDocument
        ' 
        btnAttachDocument.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnAttachDocument.Cursor = Cursors.Hand
        btnAttachDocument.FlatAppearance.BorderSize = 0
        btnAttachDocument.FlatStyle = FlatStyle.Flat
        btnAttachDocument.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnAttachDocument.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        btnAttachDocument.Location = New Point(16, 74)
        btnAttachDocument.Name = "btnAttachDocument"
        btnAttachDocument.Size = New Size(160, 32)
        btnAttachDocument.TabIndex = 2
        btnAttachDocument.Text = "📎 Attach File..."
        btnAttachDocument.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveDocument
        ' 
        btnRemoveDocument.BackColor = Color.FromArgb(CByte(254), CByte(242), CByte(242))
        btnRemoveDocument.Cursor = Cursors.Hand
        btnRemoveDocument.FlatAppearance.BorderSize = 0
        btnRemoveDocument.FlatStyle = FlatStyle.Flat
        btnRemoveDocument.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnRemoveDocument.ForeColor = Color.FromArgb(CByte(185), CByte(28), CByte(28))
        btnRemoveDocument.Location = New Point(184, 74)
        btnRemoveDocument.Name = "btnRemoveDocument"
        btnRemoveDocument.Size = New Size(80, 32)
        btnRemoveDocument.TabIndex = 3
        btnRemoveDocument.Text = "Remove"
        btnRemoveDocument.UseVisualStyleBackColor = False
        btnRemoveDocument.Visible = False
        ' 
        ' btnViewDocument
        ' 
        btnViewDocument.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        btnViewDocument.Cursor = Cursors.Hand
        btnViewDocument.FlatAppearance.BorderSize = 0
        btnViewDocument.FlatStyle = FlatStyle.Flat
        btnViewDocument.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnViewDocument.ForeColor = Color.FromArgb(CByte(2), CByte(132), CByte(199))
        btnViewDocument.Location = New Point(272, 74)
        btnViewDocument.Name = "btnViewDocument"
        btnViewDocument.Size = New Size(110, 32)
        btnViewDocument.TabIndex = 4
        btnViewDocument.Text = "View Document"
        btnViewDocument.UseVisualStyleBackColor = False
        btnViewDocument.Visible = False
        ' 
        ' lblAttachedFileName
        ' 
        lblAttachedFileName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblAttachedFileName.AutoEllipsis = True
        lblAttachedFileName.Font = New Font("Segoe UI", 8.5F, FontStyle.Italic)
        lblAttachedFileName.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblAttachedFileName.Location = New Point(390, 80)
        lblAttachedFileName.Name = "lblAttachedFileName"
        lblAttachedFileName.Size = New Size(298, 20)
        lblAttachedFileName.TabIndex = 5
        lblAttachedFileName.Text = "No document attached"
        lblAttachedFileName.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlDeclarationCard
        ' 
        pnlDeclarationCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDeclarationCard.BackColor = Color.White
        pnlDeclarationCard.BorderStyle = BorderStyle.FixedSingle
        pnlDeclarationCard.Controls.Add(lblDeclarationTitle)
        pnlDeclarationCard.Controls.Add(chkDeclaration)
        pnlDeclarationCard.Controls.Add(lblDeclarationNote)
        pnlDeclarationCard.Location = New Point(18, 1205)
        pnlDeclarationCard.Name = "pnlDeclarationCard"
        pnlDeclarationCard.Padding = New Padding(14)
        pnlDeclarationCard.Size = New Size(706, 115)
        pnlDeclarationCard.TabIndex = 8
        ' 
        ' lblDeclarationTitle
        ' 
        lblDeclarationTitle.AutoSize = True
        lblDeclarationTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblDeclarationTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblDeclarationTitle.Location = New Point(14, 12)
        lblDeclarationTitle.Name = "lblDeclarationTitle"
        lblDeclarationTitle.Size = New Size(218, 17)
        lblDeclarationTitle.TabIndex = 0
        lblDeclarationTitle.Text = "SECTION 8: Student Declaration *"
        ' 
        ' chkDeclaration
        ' 
        chkDeclaration.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        chkDeclaration.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        chkDeclaration.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        chkDeclaration.Location = New Point(18, 38)
        chkDeclaration.Name = "chkDeclaration"
        chkDeclaration.Size = New Size(670, 24)
        chkDeclaration.TabIndex = 1
        chkDeclaration.Text = "I confirm that the information I provided is accurate to the best of my knowledge."
        chkDeclaration.UseVisualStyleBackColor = True
        ' 
        ' lblDeclarationNote
        ' 
        lblDeclarationNote.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblDeclarationNote.Font = New Font("Segoe UI", 7.5F)
        lblDeclarationNote.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDeclarationNote.Location = New Point(36, 68)
        lblDeclarationNote.Name = "lblDeclarationNote"
        lblDeclarationNote.Size = New Size(652, 34)
        lblDeclarationNote.TabIndex = 2
        lblDeclarationNote.Text = "Note: Submitting this digital assessment does not automatically clear your Clinic clearance requirement. The Clinic clearing officer will review and verify your responses."
        ' 
        ' ClinicHealthAssessmentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        ClientSize = New Size(760, 720)
        Controls.Add(pnlScrollContent)
        Controls.Add(pnlFooter)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New Size(760, 600)
        Name = "ClinicHealthAssessmentForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "EClearance - Clinic Health Assessment"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlFooter.ResumeLayout(False)
        pnlScrollContent.ResumeLayout(False)
        pnlRemarksAlert.ResumeLayout(False)
        pnlRemarksAlert.PerformLayout()
        pnlStudentInfoCard.ResumeLayout(False)
        pnlStudentInfoCard.PerformLayout()
        pnlMedHistoryCard.ResumeLayout(False)
        pnlMedHistoryCard.PerformLayout()
        pnlAllergiesCard.ResumeLayout(False)
        pnlAllergiesCard.PerformLayout()
        pnlMedicationsCard.ResumeLayout(False)
        pnlMedicationsCard.PerformLayout()
        pnlHealthConcernsCard.ResumeLayout(False)
        pnlHealthConcernsCard.PerformLayout()
        pnlEmergencyCard.ResumeLayout(False)
        pnlEmergencyCard.PerformLayout()
        pnlDocumentsCard.ResumeLayout(False)
        pnlDeclarationCard.ResumeLayout(False)
        pnlDeclarationCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderIcon As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents pnlFooter As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveDraft As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents pnlScrollContent As Panel
    Friend WithEvents pnlRemarksAlert As Panel
    Friend WithEvents lblRemarksAlertIcon As Label
    Friend WithEvents lblRemarksAlertTitle As Label
    Friend WithEvents lblRemarksAlertText As Label
    Friend WithEvents pnlStudentInfoCard As Panel
    Friend WithEvents lblStudentInfoTitle As Label
    Friend WithEvents lblStudentNo As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents lblStudentName As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents lblCourse As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents txtYearLevel As TextBox
    Friend WithEvents lblTerm As Label
    Friend WithEvents txtTerm As TextBox
    Friend WithEvents pnlMedHistoryCard As Panel
    Friend WithEvents lblMedHistoryTitle As Label
    Friend WithEvents lblMedHistoryQuestion As Label
    Friend WithEvents rdoMedHistoryNo As RadioButton
    Friend WithEvents rdoMedHistoryYes As RadioButton
    Friend WithEvents lblMedHistoryDetails As Label
    Friend WithEvents txtMedHistoryDetails As TextBox
    Friend WithEvents pnlAllergiesCard As Panel
    Friend WithEvents lblAllergiesTitle As Label
    Friend WithEvents lblAllergiesQuestion As Label
    Friend WithEvents rdoAllergiesNo As RadioButton
    Friend WithEvents rdoAllergiesYes As RadioButton
    Friend WithEvents lblAllergiesDetails As Label
    Friend WithEvents txtAllergiesDetails As TextBox
    Friend WithEvents pnlMedicationsCard As Panel
    Friend WithEvents lblMedicationsTitle As Label
    Friend WithEvents lblMedicationsQuestion As Label
    Friend WithEvents rdoMedicationsNo As RadioButton
    Friend WithEvents rdoMedicationsYes As RadioButton
    Friend WithEvents lblMedicationsDetails As Label
    Friend WithEvents txtMedicationsDetails As TextBox
    Friend WithEvents pnlHealthConcernsCard As Panel
    Friend WithEvents lblHealthConcernsTitle As Label
    Friend WithEvents lblHealthConcernsQuestion As Label
    Friend WithEvents rdoHealthConcernsNo As RadioButton
    Friend WithEvents rdoHealthConcernsYes As RadioButton
    Friend WithEvents lblHealthConcernsDetails As Label
    Friend WithEvents txtHealthConcernsDetails As TextBox
    Friend WithEvents pnlEmergencyCard As Panel
    Friend WithEvents lblEmergencyTitle As Label
    Friend WithEvents lblEmergencySubtitle As Label
    Friend WithEvents lblEmergencyName As Label
    Friend WithEvents txtEmergencyName As TextBox
    Friend WithEvents lblRelationship As Label
    Friend WithEvents txtRelationship As TextBox
    Friend WithEvents lblEmergencyContactNo As Label
    Friend WithEvents txtEmergencyContactNo As TextBox
    Friend WithEvents pnlDocumentsCard As Panel
    Friend WithEvents lblDocumentsTitle As Label
    Friend WithEvents lblDocumentsSubtitle As Label
    Friend WithEvents btnAttachDocument As Button
    Friend WithEvents btnRemoveDocument As Button
    Friend WithEvents btnViewDocument As Button
    Friend WithEvents lblAttachedFileName As Label
    Friend WithEvents pnlDeclarationCard As Panel
    Friend WithEvents lblDeclarationTitle As Label
    Friend WithEvents chkDeclaration As CheckBox
    Friend WithEvents lblDeclarationNote As Label

End Class
