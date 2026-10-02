<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewRequirementModalForm
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
        pnlMainCard = New Panel()
        btnClose = New Button()
        lblModalHeader = New Label()
        pnlDetails = New Panel()
        pnlGuidanceSection = New Panel()
        lblGuidanceNotice = New Label()
        btnSaveGuidanceInfo = New Button()
        txtEmergencyContactNo = New TextBox()
        lblEmergencyContactNo = New Label()
        txtEmergencyContactName = New TextBox()
        lblEmergencyContactName = New Label()
        lblRelationship = New Label()
        cmbRelationship = New ComboBox()
        lblCivilStatus = New Label()
        cmbCivilStatus = New ComboBox()
        txtAddress = New TextBox()
        lblAddress = New Label()
        lblEmail = New Label()
        txtEmail = New TextBox()
        txtContactNo = New TextBox()
        lblContactNo = New Label()
        lblAdditionalNotes = New Label()
        txtAdditionalNotes = New TextBox()
        lblGuidanceHeader = New Label()
        pnlLinkSection = New Panel()
        btnOpenLink = New Button()
        lblLinkDesc = New Label()
        lblLinkHeader = New Label()
        pnlProofSection = New Panel()
        lblProofValue = New Label()
        lblProofHeader = New Label()
        pnlInstructionsSection = New Panel()
        lblInstructionsValue = New Label()
        lblInstructionsHeader = New Label()
        lblStatusBadge = New Label()
        lblRequirementTitle = New Label()
        lblStepOrder = New Label()
        btnDismiss = New Button()
        pnlMainCard.SuspendLayout()
        pnlDetails.SuspendLayout()
        pnlGuidanceSection.SuspendLayout()
        pnlLinkSection.SuspendLayout()
        pnlProofSection.SuspendLayout()
        pnlInstructionsSection.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlMainCard
        ' 
        pnlMainCard.BackColor = Color.White
        pnlMainCard.BorderStyle = BorderStyle.FixedSingle
        pnlMainCard.Controls.Add(btnClose)
        pnlMainCard.Controls.Add(lblModalHeader)
        pnlMainCard.Controls.Add(pnlDetails)
        pnlMainCard.Controls.Add(btnDismiss)
        pnlMainCard.Dock = DockStyle.Fill
        pnlMainCard.Location = New Point(0, 0)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Padding = New Padding(20)
        pnlMainCard.Size = New Size(560, 620)
        pnlMainCard.TabIndex = 0
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BackColor = Color.Transparent
        btnClose.Cursor = Cursors.Hand
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249)
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnClose.ForeColor = Color.FromArgb(100, 116, 139)
        btnClose.Location = New Point(508, 14)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(36, 36)
        btnClose.TabIndex = 0
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblModalHeader
        ' 
        lblModalHeader.AutoSize = True
        lblModalHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblModalHeader.ForeColor = Color.FromArgb(15, 23, 42)
        lblModalHeader.Location = New Point(20, 18)
        lblModalHeader.Name = "lblModalHeader"
        lblModalHeader.Size = New Size(229, 25)
        lblModalHeader.TabIndex = 1
        lblModalHeader.Text = "Requirement Instructions"
        ' 
        ' pnlDetails
        ' 
        pnlDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDetails.AutoScroll = True
        pnlDetails.BackColor = Color.FromArgb(248, 250, 252)
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(pnlGuidanceSection)
        pnlDetails.Controls.Add(pnlLinkSection)
        pnlDetails.Controls.Add(pnlProofSection)
        pnlDetails.Controls.Add(pnlInstructionsSection)
        pnlDetails.Controls.Add(lblStatusBadge)
        pnlDetails.Controls.Add(lblRequirementTitle)
        pnlDetails.Controls.Add(lblStepOrder)
        pnlDetails.Location = New Point(20, 60)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Padding = New Padding(16)
        pnlDetails.Size = New Size(518, 485)
        pnlDetails.TabIndex = 2
        ' 
        ' pnlGuidanceSection
        ' 
        pnlGuidanceSection.BackColor = Color.White
        pnlGuidanceSection.BorderStyle = BorderStyle.FixedSingle
        pnlGuidanceSection.Controls.Add(lblGuidanceNotice)
        pnlGuidanceSection.Controls.Add(btnSaveGuidanceInfo)
        pnlGuidanceSection.Controls.Add(txtAdditionalNotes)
        pnlGuidanceSection.Controls.Add(lblAdditionalNotes)
        pnlGuidanceSection.Controls.Add(txtEmergencyContactNo)
        pnlGuidanceSection.Controls.Add(lblEmergencyContactNo)
        pnlGuidanceSection.Controls.Add(txtEmergencyContactName)
        pnlGuidanceSection.Controls.Add(lblEmergencyContactName)
        pnlGuidanceSection.Controls.Add(cmbRelationship)
        pnlGuidanceSection.Controls.Add(lblRelationship)
        pnlGuidanceSection.Controls.Add(cmbCivilStatus)
        pnlGuidanceSection.Controls.Add(lblCivilStatus)
        pnlGuidanceSection.Controls.Add(txtAddress)
        pnlGuidanceSection.Controls.Add(lblAddress)
        pnlGuidanceSection.Controls.Add(txtEmail)
        pnlGuidanceSection.Controls.Add(lblEmail)
        pnlGuidanceSection.Controls.Add(txtContactNo)
        pnlGuidanceSection.Controls.Add(lblContactNo)
        pnlGuidanceSection.Controls.Add(lblGuidanceHeader)
        pnlGuidanceSection.Location = New Point(16, 260)
        pnlGuidanceSection.Name = "pnlGuidanceSection"
        pnlGuidanceSection.Padding = New Padding(12)
        pnlGuidanceSection.Size = New Size(470, 385)
        pnlGuidanceSection.TabIndex = 6
        pnlGuidanceSection.Visible = False
        ' 
        ' lblGuidanceNotice
        ' 
        lblGuidanceNotice.AutoSize = True
        lblGuidanceNotice.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point)
        lblGuidanceNotice.ForeColor = Color.FromArgb(71, 85, 105)
        lblGuidanceNotice.Location = New Point(12, 32)
        lblGuidanceNotice.Name = "lblGuidanceNotice"
        lblGuidanceNotice.Size = New Size(362, 13)
        lblGuidanceNotice.TabIndex = 18
        lblGuidanceNotice.Text = "Students required by Guidance must update student personal information before clearance approval."
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblContactNo.ForeColor = Color.FromArgb(71, 85, 105)
        lblContactNo.Location = New Point(12, 54)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(122, 15)
        lblContactNo.TabIndex = 1
        lblContactNo.Text = "Student Contact No. *"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.BorderStyle = BorderStyle.FixedSingle
        txtContactNo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtContactNo.Location = New Point(12, 72)
        txtContactNo.MaxLength = 11
        txtContactNo.Name = "txtContactNo"
        txtContactNo.PlaceholderText = "09xxxxxxxxx"
        txtContactNo.Size = New Size(215, 23)
        txtContactNo.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.ForeColor = Color.FromArgb(71, 85, 105)
        lblEmail.Location = New Point(241, 54)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(88, 15)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email Address *"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(241, 72)
        txtEmail.MaxLength = 100
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "student@email.com"
        txtEmail.Size = New Size(215, 23)
        txtEmail.TabIndex = 4
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblAddress.ForeColor = Color.FromArgb(71, 85, 105)
        lblAddress.Location = New Point(12, 102)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(100, 15)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Current Address *"
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtAddress.Location = New Point(12, 120)
        txtAddress.MaxLength = 255
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "House No., Street, Barangay, City/Municipality"
        txtAddress.Size = New Size(444, 23)
        txtAddress.TabIndex = 6
        ' 
        ' lblCivilStatus
        ' 
        lblCivilStatus.AutoSize = True
        lblCivilStatus.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblCivilStatus.ForeColor = Color.FromArgb(71, 85, 105)
        lblCivilStatus.Location = New Point(12, 150)
        lblCivilStatus.Name = "lblCivilStatus"
        lblCivilStatus.Size = New Size(73, 15)
        lblCivilStatus.TabIndex = 7
        lblCivilStatus.Text = "Civil Status *"
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        cmbCivilStatus.Location = New Point(12, 168)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(215, 23)
        cmbCivilStatus.TabIndex = 8
        ' 
        ' lblRelationship
        ' 
        lblRelationship.AutoSize = True
        lblRelationship.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblRelationship.ForeColor = Color.FromArgb(71, 85, 105)
        lblRelationship.Location = New Point(241, 150)
        lblRelationship.Name = "lblRelationship"
        lblRelationship.Size = New Size(140, 15)
        lblRelationship.TabIndex = 9
        lblRelationship.Text = "Relationship to Contact *"
        ' 
        ' cmbRelationship
        ' 
        cmbRelationship.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRelationship.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        cmbRelationship.FormattingEnabled = True
        cmbRelationship.Items.AddRange(New Object() {"Mother", "Father", "Guardian", "Sibling", "Relative", "Other"})
        cmbRelationship.Location = New Point(241, 168)
        cmbRelationship.Name = "cmbRelationship"
        cmbRelationship.Size = New Size(215, 23)
        cmbRelationship.TabIndex = 10
        ' 
        ' lblEmergencyContactName
        ' 
        lblEmergencyContactName.AutoSize = True
        lblEmergencyContactName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmergencyContactName.ForeColor = Color.FromArgb(71, 85, 105)
        lblEmergencyContactName.Location = New Point(12, 198)
        lblEmergencyContactName.Name = "lblEmergencyContactName"
        lblEmergencyContactName.Size = New Size(157, 15)
        lblEmergencyContactName.TabIndex = 11
        lblEmergencyContactName.Text = "Emergency Contact Person *"
        ' 
        ' txtEmergencyContactName
        ' 
        txtEmergencyContactName.BorderStyle = BorderStyle.FixedSingle
        txtEmergencyContactName.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmergencyContactName.Location = New Point(12, 216)
        txtEmergencyContactName.MaxLength = 100
        txtEmergencyContactName.Name = "txtEmergencyContactName"
        txtEmergencyContactName.PlaceholderText = "Full Name of Contact Person"
        txtEmergencyContactName.Size = New Size(215, 23)
        txtEmergencyContactName.TabIndex = 12
        ' 
        ' lblEmergencyContactNo
        ' 
        lblEmergencyContactNo.AutoSize = True
        lblEmergencyContactNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmergencyContactNo.ForeColor = Color.FromArgb(71, 85, 105)
        lblEmergencyContactNo.Location = New Point(241, 198)
        lblEmergencyContactNo.Name = "lblEmergencyContactNo"
        lblEmergencyContactNo.Size = New Size(143, 15)
        lblEmergencyContactNo.TabIndex = 13
        lblEmergencyContactNo.Text = "Emergency Contact No. *"
        ' 
        ' txtEmergencyContactNo
        ' 
        txtEmergencyContactNo.BorderStyle = BorderStyle.FixedSingle
        txtEmergencyContactNo.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmergencyContactNo.Location = New Point(241, 216)
        txtEmergencyContactNo.MaxLength = 11
        txtEmergencyContactNo.Name = "txtEmergencyContactNo"
        txtEmergencyContactNo.PlaceholderText = "09xxxxxxxxx"
        txtEmergencyContactNo.Size = New Size(215, 23)
        txtEmergencyContactNo.TabIndex = 14
        ' 
        ' lblAdditionalNotes
        ' 
        lblAdditionalNotes.AutoSize = True
        lblAdditionalNotes.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblAdditionalNotes.ForeColor = Color.FromArgb(71, 85, 105)
        lblAdditionalNotes.Location = New Point(12, 246)
        lblAdditionalNotes.Name = "lblAdditionalNotes"
        lblAdditionalNotes.Size = New Size(149, 15)
        lblAdditionalNotes.TabIndex = 15
        lblAdditionalNotes.Text = "Additional Notes (Optional)"
        ' 
        ' txtAdditionalNotes
        ' 
        txtAdditionalNotes.BorderStyle = BorderStyle.FixedSingle
        txtAdditionalNotes.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtAdditionalNotes.Location = New Point(12, 264)
        txtAdditionalNotes.MaxLength = 500
        txtAdditionalNotes.Multiline = True
        txtAdditionalNotes.Name = "txtAdditionalNotes"
        txtAdditionalNotes.PlaceholderText = "Any medical conditions, remarks, or notes..."
        txtAdditionalNotes.ScrollBars = ScrollBars.Vertical
        txtAdditionalNotes.Size = New Size(444, 55)
        txtAdditionalNotes.TabIndex = 16
        ' 
        ' btnSaveGuidanceInfo
        ' 
        btnSaveGuidanceInfo.BackColor = Color.FromArgb(11, 99, 229)
        btnSaveGuidanceInfo.Cursor = Cursors.Hand
        btnSaveGuidanceInfo.FlatAppearance.BorderSize = 0
        btnSaveGuidanceInfo.FlatStyle = FlatStyle.Flat
        btnSaveGuidanceInfo.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSaveGuidanceInfo.ForeColor = Color.White
        btnSaveGuidanceInfo.Location = New Point(12, 332)
        btnSaveGuidanceInfo.Name = "btnSaveGuidanceInfo"
        btnSaveGuidanceInfo.Size = New Size(200, 34)
        btnSaveGuidanceInfo.TabIndex = 17
        btnSaveGuidanceInfo.Text = "Save & Update Information"
        btnSaveGuidanceInfo.UseVisualStyleBackColor = False
        ' 
        ' lblGuidanceHeader
        ' 
        lblGuidanceHeader.AutoSize = True
        lblGuidanceHeader.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblGuidanceHeader.ForeColor = Color.FromArgb(15, 23, 42)
        lblGuidanceHeader.Location = New Point(12, 10)
        lblGuidanceHeader.Name = "lblGuidanceHeader"
        lblGuidanceHeader.Size = New Size(230, 19)
        lblGuidanceHeader.TabIndex = 0
        lblGuidanceHeader.Text = "Guidance Information Record"
        ' 
        ' pnlLinkSection
        ' 
        pnlLinkSection.BackColor = Color.FromArgb(239, 246, 255)
        pnlLinkSection.BorderStyle = BorderStyle.FixedSingle
        pnlLinkSection.Controls.Add(btnOpenLink)
        pnlLinkSection.Controls.Add(lblLinkDesc)
        pnlLinkSection.Controls.Add(lblLinkHeader)
        pnlLinkSection.Location = New Point(16, 185)
        pnlLinkSection.Name = "pnlLinkSection"
        pnlLinkSection.Padding = New Padding(12)
        pnlLinkSection.Size = New Size(470, 65)
        pnlLinkSection.TabIndex = 5
        pnlLinkSection.Visible = False
        ' 
        ' btnOpenLink
        ' 
        btnOpenLink.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenLink.BackColor = Color.FromArgb(37, 99, 235)
        btnOpenLink.Cursor = Cursors.Hand
        btnOpenLink.FlatAppearance.BorderSize = 0
        btnOpenLink.FlatStyle = FlatStyle.Flat
        btnOpenLink.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnOpenLink.ForeColor = Color.White
        btnOpenLink.Location = New Point(328, 15)
        btnOpenLink.Name = "btnOpenLink"
        btnOpenLink.Size = New Size(128, 34)
        btnOpenLink.TabIndex = 2
        btnOpenLink.Text = "🌐 Open Survey"
        btnOpenLink.UseVisualStyleBackColor = False
        ' 
        ' lblLinkDesc
        ' 
        lblLinkDesc.AutoSize = True
        lblLinkDesc.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblLinkDesc.ForeColor = Color.FromArgb(30, 64, 175)
        lblLinkDesc.Location = New Point(12, 34)
        lblLinkDesc.Name = "lblLinkDesc"
        lblLinkDesc.Size = New Size(270, 15)
        lblLinkDesc.TabIndex = 1
        lblLinkDesc.Text = "Click the button to access the external survey form."
        ' 
        ' lblLinkHeader
        ' 
        lblLinkHeader.AutoSize = True
        lblLinkHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblLinkHeader.ForeColor = Color.FromArgb(30, 58, 138)
        lblLinkHeader.Location = New Point(12, 12)
        lblLinkHeader.Name = "lblLinkHeader"
        lblLinkHeader.Size = New Size(136, 17)
        lblLinkHeader.TabIndex = 0
        lblLinkHeader.Text = "External Form / Survey"
        ' 
        ' pnlProofSection
        ' 
        pnlProofSection.BackColor = Color.White
        pnlProofSection.BorderStyle = BorderStyle.FixedSingle
        pnlProofSection.Controls.Add(lblProofValue)
        pnlProofSection.Controls.Add(lblProofHeader)
        pnlProofSection.Location = New Point(16, 120)
        pnlProofSection.Name = "pnlProofSection"
        pnlProofSection.Padding = New Padding(10)
        pnlProofSection.Size = New Size(470, 55)
        pnlProofSection.TabIndex = 4
        ' 
        ' lblProofValue
        ' 
        lblProofValue.AutoSize = True
        lblProofValue.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblProofValue.ForeColor = Color.FromArgb(15, 23, 42)
        lblProofValue.Location = New Point(10, 28)
        lblProofValue.Name = "lblProofValue"
        lblProofValue.Size = New Size(244, 15)
        lblProofValue.TabIndex = 1
        lblProofValue.Text = "Screenshot of completed survey or receipt."
        ' 
        ' lblProofHeader
        ' 
        lblProofHeader.AutoSize = True
        lblProofHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblProofHeader.ForeColor = Color.FromArgb(71, 85, 105)
        lblProofHeader.Location = New Point(10, 8)
        lblProofHeader.Name = "lblProofHeader"
        lblProofHeader.Size = New Size(92, 15)
        lblProofHeader.TabIndex = 0
        lblProofHeader.Text = "Required Proof:"
        ' 
        ' pnlInstructionsSection
        ' 
        pnlInstructionsSection.BackColor = Color.White
        pnlInstructionsSection.BorderStyle = BorderStyle.FixedSingle
        pnlInstructionsSection.Controls.Add(lblInstructionsValue)
        pnlInstructionsSection.Controls.Add(lblInstructionsHeader)
        pnlInstructionsSection.Location = New Point(16, 50)
        pnlInstructionsSection.Name = "pnlInstructionsSection"
        pnlInstructionsSection.Padding = New Padding(10)
        pnlInstructionsSection.Size = New Size(470, 60)
        pnlInstructionsSection.TabIndex = 3
        ' 
        ' lblInstructionsValue
        ' 
        lblInstructionsValue.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblInstructionsValue.ForeColor = Color.FromArgb(15, 23, 42)
        lblInstructionsValue.Location = New Point(10, 26)
        lblInstructionsValue.Name = "lblInstructionsValue"
        lblInstructionsValue.Size = New Size(446, 28)
        lblInstructionsValue.TabIndex = 1
        lblInstructionsValue.Text = "Requirement instructions description text."
        ' 
        ' lblInstructionsHeader
        ' 
        lblInstructionsHeader.AutoSize = True
        lblInstructionsHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblInstructionsHeader.ForeColor = Color.FromArgb(71, 85, 105)
        lblInstructionsHeader.Location = New Point(10, 8)
        lblInstructionsHeader.Name = "lblInstructionsHeader"
        lblInstructionsHeader.Size = New Size(77, 15)
        lblInstructionsHeader.TabIndex = 0
        lblInstructionsHeader.Text = "Instructions:"
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatusBadge.BackColor = Color.FromArgb(219, 234, 254)
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblStatusBadge.ForeColor = Color.FromArgb(30, 64, 175)
        lblStatusBadge.Location = New Point(366, 16)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Size = New Size(120, 24)
        lblStatusBadge.TabIndex = 2
        lblStatusBadge.Text = "Pending"
        lblStatusBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRequirementTitle
        ' 
        lblRequirementTitle.AutoSize = True
        lblRequirementTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblRequirementTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblRequirementTitle.Location = New Point(80, 16)
        lblRequirementTitle.Name = "lblRequirementTitle"
        lblRequirementTitle.Size = New Size(157, 21)
        lblRequirementTitle.TabIndex = 1
        lblRequirementTitle.Text = "Requirement Name"
        ' 
        ' lblStepOrder
        ' 
        lblStepOrder.BackColor = Color.FromArgb(11, 99, 229)
        lblStepOrder.Font = New Font("Segoe UI Bold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStepOrder.ForeColor = Color.White
        lblStepOrder.Location = New Point(16, 14)
        lblStepOrder.Name = "lblStepOrder"
        lblStepOrder.Size = New Size(54, 26)
        lblStepOrder.TabIndex = 0
        lblStepOrder.Text = "Step 1"
        lblStepOrder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnDismiss
        ' 
        btnDismiss.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDismiss.BackColor = Color.FromArgb(11, 99, 229)
        btnDismiss.Cursor = Cursors.Hand
        btnDismiss.FlatAppearance.BorderSize = 0
        btnDismiss.FlatStyle = FlatStyle.Flat
        btnDismiss.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnDismiss.ForeColor = Color.White
        btnDismiss.Location = New Point(428, 560)
        btnDismiss.Name = "btnDismiss"
        btnDismiss.Size = New Size(110, 36)
        btnDismiss.TabIndex = 3
        btnDismiss.Text = "Close"
        btnDismiss.UseVisualStyleBackColor = False
        ' 
        ' ViewRequirementModalForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(560, 620)
        Controls.Add(pnlMainCard)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "ViewRequirementModalForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Requirement Details"
        pnlMainCard.ResumeLayout(False)
        pnlMainCard.PerformLayout()
        pnlDetails.ResumeLayout(False)
        pnlDetails.PerformLayout()
        pnlGuidanceSection.ResumeLayout(False)
        pnlGuidanceSection.PerformLayout()
        pnlLinkSection.ResumeLayout(False)
        pnlLinkSection.PerformLayout()
        pnlProofSection.ResumeLayout(False)
        pnlProofSection.PerformLayout()
        pnlInstructionsSection.ResumeLayout(False)
        pnlInstructionsSection.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlMainCard As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblModalHeader As Label
    Friend WithEvents pnlDetails As Panel
    Friend WithEvents lblStepOrder As Label
    Friend WithEvents lblRequirementTitle As Label
    Friend WithEvents lblStatusBadge As Label
    Friend WithEvents pnlInstructionsSection As Panel
    Friend WithEvents lblInstructionsHeader As Label
    Friend WithEvents lblInstructionsValue As Label
    Friend WithEvents pnlProofSection As Panel
    Friend WithEvents lblProofHeader As Label
    Friend WithEvents lblProofValue As Label
    Friend WithEvents pnlLinkSection As Panel
    Friend WithEvents lblLinkHeader As Label
    Friend WithEvents lblLinkDesc As Label
    Friend WithEvents btnOpenLink As Button
    Friend WithEvents pnlGuidanceSection As Panel
    Friend WithEvents lblGuidanceHeader As Label
    Friend WithEvents lblGuidanceNotice As Label
    Friend WithEvents lblContactNo As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCivilStatus As Label
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents lblRelationship As Label
    Friend WithEvents cmbRelationship As ComboBox
    Friend WithEvents lblEmergencyContactName As Label
    Friend WithEvents txtEmergencyContactName As TextBox
    Friend WithEvents lblEmergencyContactNo As Label
    Friend WithEvents txtEmergencyContactNo As TextBox
    Friend WithEvents lblAdditionalNotes As Label
    Friend WithEvents txtAdditionalNotes As TextBox
    Friend WithEvents btnSaveGuidanceInfo As Button
    Friend WithEvents btnDismiss As Button

End Class
