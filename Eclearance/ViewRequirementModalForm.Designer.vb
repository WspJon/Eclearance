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
        lblModalHeader = New Label()
        pnlDetails = New Panel()
        pnlGuidanceSection = New Panel()
        lblGuidanceNotice = New Label()
        btnSaveGuidanceInfo = New Button()
        txtAdditionalNotes = New TextBox()
        lblAdditionalNotes = New Label()
        txtEmergencyContactNo = New TextBox()
        lblEmergencyContactNo = New Label()
        txtEmergencyContactName = New TextBox()
        lblEmergencyContactName = New Label()
        cmbRelationship = New ComboBox()
        lblRelationship = New Label()
        cmbCivilStatus = New ComboBox()
        lblCivilStatus = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtContactNo = New TextBox()
        lblContactNo = New Label()
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
        pnlMainCard.Controls.Add(lblModalHeader)
        pnlMainCard.Controls.Add(pnlDetails)
        pnlMainCard.Controls.Add(btnDismiss)
        pnlMainCard.Dock = DockStyle.Fill
        pnlMainCard.Location = New Point(0, 0)
        pnlMainCard.Margin = New Padding(4, 5, 4, 5)
        pnlMainCard.Name = "pnlMainCard"
        pnlMainCard.Padding = New Padding(29, 25, 29, 25)
        pnlMainCard.Size = New Size(800, 812)
        pnlMainCard.TabIndex = 0
        ' 
        ' lblModalHeader
        ' 
        lblModalHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblModalHeader.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        lblModalHeader.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblModalHeader.Location = New Point(29, 18)
        lblModalHeader.Margin = New Padding(4, 0, 4, 0)
        lblModalHeader.Name = "lblModalHeader"
        lblModalHeader.Size = New Size(662, 52)
        lblModalHeader.TabIndex = 1
        lblModalHeader.Text = "Requirement Instructions"
        lblModalHeader.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' pnlDetails
        ' 
        pnlDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlDetails.AutoScroll = True
        pnlDetails.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlDetails.BorderStyle = BorderStyle.FixedSingle
        pnlDetails.Controls.Add(pnlGuidanceSection)
        pnlDetails.Controls.Add(pnlLinkSection)
        pnlDetails.Controls.Add(pnlProofSection)
        pnlDetails.Controls.Add(pnlInstructionsSection)
        pnlDetails.Controls.Add(lblStatusBadge)
        pnlDetails.Controls.Add(lblRequirementTitle)
        pnlDetails.Controls.Add(lblStepOrder)
        pnlDetails.Location = New Point(29, 85)
        pnlDetails.Margin = New Padding(4, 5, 4, 5)
        pnlDetails.Name = "pnlDetails"
        pnlDetails.Padding = New Padding(22, 26, 22, 26)
        pnlDetails.Size = New Size(740, 612)
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
        pnlGuidanceSection.Location = New Point(22, 434)
        pnlGuidanceSection.Margin = New Padding(4, 5, 4, 5)
        pnlGuidanceSection.Name = "pnlGuidanceSection"
        pnlGuidanceSection.Padding = New Padding(18, 20, 18, 20)
        pnlGuidanceSection.Size = New Size(671, 656)
        pnlGuidanceSection.TabIndex = 6
        pnlGuidanceSection.Visible = False
        ' 
        ' lblGuidanceNotice
        ' 
        lblGuidanceNotice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblGuidanceNotice.Font = New Font("Segoe UI", 8.25F, FontStyle.Italic)
        lblGuidanceNotice.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblGuidanceNotice.Location = New Point(18, 54)
        lblGuidanceNotice.Margin = New Padding(4, 0, 4, 0)
        lblGuidanceNotice.Name = "lblGuidanceNotice"
        lblGuidanceNotice.Size = New Size(634, 52)
        lblGuidanceNotice.TabIndex = 18
        lblGuidanceNotice.Text = "Students required by Guidance must update student personal information before clearance approval."
        ' 
        ' btnSaveGuidanceInfo
        ' 
        btnSaveGuidanceInfo.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnSaveGuidanceInfo.Cursor = Cursors.Hand
        btnSaveGuidanceInfo.FlatAppearance.BorderSize = 0
        btnSaveGuidanceInfo.FlatStyle = FlatStyle.Flat
        btnSaveGuidanceInfo.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSaveGuidanceInfo.ForeColor = Color.White
        btnSaveGuidanceInfo.Location = New Point(18, 569)
        btnSaveGuidanceInfo.Margin = New Padding(4, 5, 4, 5)
        btnSaveGuidanceInfo.Name = "btnSaveGuidanceInfo"
        btnSaveGuidanceInfo.Size = New Size(286, 56)
        btnSaveGuidanceInfo.TabIndex = 17
        btnSaveGuidanceInfo.Text = "Save & Update Information"
        btnSaveGuidanceInfo.UseVisualStyleBackColor = False
        ' 
        ' txtAdditionalNotes
        ' 
        txtAdditionalNotes.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtAdditionalNotes.BorderStyle = BorderStyle.FixedSingle
        txtAdditionalNotes.Font = New Font("Segoe UI", 9.0F)
        txtAdditionalNotes.Location = New Point(18, 455)
        txtAdditionalNotes.Margin = New Padding(4, 5, 4, 5)
        txtAdditionalNotes.MaxLength = 500
        txtAdditionalNotes.Multiline = True
        txtAdditionalNotes.Name = "txtAdditionalNotes"
        txtAdditionalNotes.PlaceholderText = "Any medical conditions, remarks, or notes..."
        txtAdditionalNotes.ScrollBars = ScrollBars.Vertical
        txtAdditionalNotes.Size = New Size(633, 91)
        txtAdditionalNotes.TabIndex = 16
        ' 
        ' lblAdditionalNotes
        ' 
        lblAdditionalNotes.AutoSize = True
        lblAdditionalNotes.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblAdditionalNotes.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblAdditionalNotes.Location = New Point(18, 425)
        lblAdditionalNotes.Margin = New Padding(4, 0, 4, 0)
        lblAdditionalNotes.Name = "lblAdditionalNotes"
        lblAdditionalNotes.Size = New Size(197, 20)
        lblAdditionalNotes.TabIndex = 15
        lblAdditionalNotes.Text = "Additional Notes (Optional)"
        ' 
        ' txtEmergencyContactNo
        ' 
        txtEmergencyContactNo.BorderStyle = BorderStyle.FixedSingle
        txtEmergencyContactNo.Font = New Font("Segoe UI", 9.0F)
        txtEmergencyContactNo.Location = New Point(344, 375)
        txtEmergencyContactNo.Margin = New Padding(4, 5, 4, 5)
        txtEmergencyContactNo.MaxLength = 11
        txtEmergencyContactNo.Name = "txtEmergencyContactNo"
        txtEmergencyContactNo.PlaceholderText = "09xxxxxxxxx"
        txtEmergencyContactNo.Size = New Size(306, 27)
        txtEmergencyContactNo.TabIndex = 14
        ' 
        ' lblEmergencyContactNo
        ' 
        lblEmergencyContactNo.AutoSize = True
        lblEmergencyContactNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyContactNo.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblEmergencyContactNo.Location = New Point(344, 345)
        lblEmergencyContactNo.Margin = New Padding(4, 0, 4, 0)
        lblEmergencyContactNo.Name = "lblEmergencyContactNo"
        lblEmergencyContactNo.Size = New Size(181, 20)
        lblEmergencyContactNo.TabIndex = 13
        lblEmergencyContactNo.Text = "Emergency Contact No. *"
        ' 
        ' txtEmergencyContactName
        ' 
        txtEmergencyContactName.BorderStyle = BorderStyle.FixedSingle
        txtEmergencyContactName.Font = New Font("Segoe UI", 9.0F)
        txtEmergencyContactName.Location = New Point(18, 375)
        txtEmergencyContactName.Margin = New Padding(4, 5, 4, 5)
        txtEmergencyContactName.MaxLength = 100
        txtEmergencyContactName.Name = "txtEmergencyContactName"
        txtEmergencyContactName.PlaceholderText = "Full Name of Contact Person"
        txtEmergencyContactName.Size = New Size(306, 27)
        txtEmergencyContactName.TabIndex = 12
        ' 
        ' lblEmergencyContactName
        ' 
        lblEmergencyContactName.AutoSize = True
        lblEmergencyContactName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyContactName.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblEmergencyContactName.Location = New Point(18, 345)
        lblEmergencyContactName.Margin = New Padding(4, 0, 4, 0)
        lblEmergencyContactName.Name = "lblEmergencyContactName"
        lblEmergencyContactName.Size = New Size(202, 20)
        lblEmergencyContactName.TabIndex = 11
        lblEmergencyContactName.Text = "Emergency Contact Person *"
        ' 
        ' cmbRelationship
        ' 
        cmbRelationship.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRelationship.Font = New Font("Segoe UI", 9.0F)
        cmbRelationship.FormattingEnabled = True
        cmbRelationship.Items.AddRange(New Object() {"Mother", "Father", "Guardian", "Sibling", "Relative", "Other"})
        cmbRelationship.Location = New Point(344, 295)
        cmbRelationship.Margin = New Padding(4, 5, 4, 5)
        cmbRelationship.Name = "cmbRelationship"
        cmbRelationship.Size = New Size(305, 28)
        cmbRelationship.TabIndex = 10
        ' 
        ' lblRelationship
        ' 
        lblRelationship.AutoSize = True
        lblRelationship.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblRelationship.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblRelationship.Location = New Point(344, 265)
        lblRelationship.Margin = New Padding(4, 0, 4, 0)
        lblRelationship.Name = "lblRelationship"
        lblRelationship.Size = New Size(178, 20)
        lblRelationship.TabIndex = 9
        lblRelationship.Text = "Relationship to Contact *"
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.Font = New Font("Segoe UI", 9.0F)
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        cmbCivilStatus.Location = New Point(18, 295)
        cmbCivilStatus.Margin = New Padding(4, 5, 4, 5)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(305, 28)
        cmbCivilStatus.TabIndex = 8
        ' 
        ' lblCivilStatus
        ' 
        lblCivilStatus.AutoSize = True
        lblCivilStatus.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblCivilStatus.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblCivilStatus.Location = New Point(18, 265)
        lblCivilStatus.Margin = New Padding(4, 0, 4, 0)
        lblCivilStatus.Name = "lblCivilStatus"
        lblCivilStatus.Size = New Size(94, 20)
        lblCivilStatus.TabIndex = 7
        lblCivilStatus.Text = "Civil Status *"
        ' 
        ' txtAddress
        ' 
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 9.0F)
        txtAddress.Location = New Point(18, 215)
        txtAddress.Margin = New Padding(4, 5, 4, 5)
        txtAddress.MaxLength = 255
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "House No., Street, Barangay, City/Municipality"
        txtAddress.Size = New Size(633, 27)
        txtAddress.TabIndex = 6
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblAddress.Location = New Point(18, 185)
        lblAddress.Margin = New Padding(4, 0, 4, 0)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(130, 20)
        lblAddress.TabIndex = 5
        lblAddress.Text = "Current Address *"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 9.0F)
        txtEmail.Location = New Point(344, 135)
        txtEmail.Margin = New Padding(4, 5, 4, 5)
        txtEmail.MaxLength = 100
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "student@email.com"
        txtEmail.Size = New Size(306, 27)
        txtEmail.TabIndex = 4
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblEmail.Location = New Point(344, 105)
        lblEmail.Margin = New Padding(4, 0, 4, 0)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(115, 20)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email Address *"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.BorderStyle = BorderStyle.FixedSingle
        txtContactNo.Font = New Font("Segoe UI", 9.0F)
        txtContactNo.Location = New Point(18, 135)
        txtContactNo.Margin = New Padding(4, 5, 4, 5)
        txtContactNo.MaxLength = 11
        txtContactNo.Name = "txtContactNo"
        txtContactNo.PlaceholderText = "09xxxxxxxxx"
        txtContactNo.Size = New Size(306, 27)
        txtContactNo.TabIndex = 2
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblContactNo.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblContactNo.Location = New Point(18, 105)
        lblContactNo.Margin = New Padding(4, 0, 4, 0)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(158, 20)
        lblContactNo.TabIndex = 1
        lblContactNo.Text = "Student Contact No. *"
        ' 
        ' lblGuidanceHeader
        ' 
        lblGuidanceHeader.AutoSize = True
        lblGuidanceHeader.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        lblGuidanceHeader.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblGuidanceHeader.Location = New Point(18, 16)
        lblGuidanceHeader.Margin = New Padding(4, 0, 4, 0)
        lblGuidanceHeader.Name = "lblGuidanceHeader"
        lblGuidanceHeader.Size = New Size(246, 23)
        lblGuidanceHeader.TabIndex = 0
        lblGuidanceHeader.Text = "Guidance Information Record"
        ' 
        ' pnlLinkSection
        ' 
        pnlLinkSection.BackColor = Color.FromArgb(CByte(239), CByte(246), CByte(255))
        pnlLinkSection.BorderStyle = BorderStyle.FixedSingle
        pnlLinkSection.Controls.Add(btnOpenLink)
        pnlLinkSection.Controls.Add(lblLinkDesc)
        pnlLinkSection.Controls.Add(lblLinkHeader)
        pnlLinkSection.Location = New Point(22, 309)
        pnlLinkSection.Margin = New Padding(4, 5, 4, 5)
        pnlLinkSection.Name = "pnlLinkSection"
        pnlLinkSection.Padding = New Padding(18, 20, 18, 20)
        pnlLinkSection.Size = New Size(671, 107)
        pnlLinkSection.TabIndex = 5
        pnlLinkSection.Visible = False
        ' 
        ' btnOpenLink
        ' 
        btnOpenLink.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnOpenLink.BackColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnOpenLink.Cursor = Cursors.Hand
        btnOpenLink.FlatAppearance.BorderSize = 0
        btnOpenLink.FlatStyle = FlatStyle.Flat
        btnOpenLink.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnOpenLink.ForeColor = Color.White
        btnOpenLink.Location = New Point(469, 25)
        btnOpenLink.Margin = New Padding(4, 5, 4, 5)
        btnOpenLink.Name = "btnOpenLink"
        btnOpenLink.Size = New Size(182, 56)
        btnOpenLink.TabIndex = 2
        btnOpenLink.Text = "Open Survey"
        btnOpenLink.UseVisualStyleBackColor = False
        ' 
        ' lblLinkDesc
        ' 
        lblLinkDesc.AutoSize = True
        lblLinkDesc.Font = New Font("Segoe UI", 8.5F)
        lblLinkDesc.ForeColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        lblLinkDesc.Location = New Point(18, 56)
        lblLinkDesc.Margin = New Padding(4, 0, 4, 0)
        lblLinkDesc.Name = "lblLinkDesc"
        lblLinkDesc.Size = New Size(343, 20)
        lblLinkDesc.TabIndex = 1
        lblLinkDesc.Text = "Click the button to access the external survey form."
        ' 
        ' lblLinkHeader
        ' 
        lblLinkHeader.AutoSize = True
        lblLinkHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblLinkHeader.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(138))
        lblLinkHeader.Location = New Point(18, 20)
        lblLinkHeader.Margin = New Padding(4, 0, 4, 0)
        lblLinkHeader.Name = "lblLinkHeader"
        lblLinkHeader.Size = New Size(175, 21)
        lblLinkHeader.TabIndex = 0
        lblLinkHeader.Text = "External Form / Survey"
        ' 
        ' pnlProofSection
        ' 
        pnlProofSection.BackColor = Color.White
        pnlProofSection.BorderStyle = BorderStyle.FixedSingle
        pnlProofSection.Controls.Add(lblProofValue)
        pnlProofSection.Controls.Add(lblProofHeader)
        pnlProofSection.Location = New Point(22, 200)
        pnlProofSection.Margin = New Padding(4, 5, 4, 5)
        pnlProofSection.Name = "pnlProofSection"
        pnlProofSection.Padding = New Padding(14, 16, 14, 16)
        pnlProofSection.Size = New Size(671, 91)
        pnlProofSection.TabIndex = 4
        ' 
        ' lblProofValue
        ' 
        lblProofValue.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblProofValue.Font = New Font("Segoe UI", 9.0F)
        lblProofValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblProofValue.Location = New Point(14, 46)
        lblProofValue.Margin = New Padding(4, 0, 4, 0)
        lblProofValue.Name = "lblProofValue"
        lblProofValue.Size = New Size(638, 31)
        lblProofValue.TabIndex = 1
        lblProofValue.Text = "Screenshot of completed survey or receipt."
        ' 
        ' lblProofHeader
        ' 
        lblProofHeader.AutoSize = True
        lblProofHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblProofHeader.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblProofHeader.Location = New Point(14, 14)
        lblProofHeader.Margin = New Padding(4, 0, 4, 0)
        lblProofHeader.Name = "lblProofHeader"
        lblProofHeader.Size = New Size(118, 20)
        lblProofHeader.TabIndex = 0
        lblProofHeader.Text = "Required Proof:"
        ' 
        ' pnlInstructionsSection
        ' 
        pnlInstructionsSection.BackColor = Color.White
        pnlInstructionsSection.BorderStyle = BorderStyle.FixedSingle
        pnlInstructionsSection.Controls.Add(lblInstructionsValue)
        pnlInstructionsSection.Controls.Add(lblInstructionsHeader)
        pnlInstructionsSection.Location = New Point(22, 84)
        pnlInstructionsSection.Margin = New Padding(4, 5, 4, 5)
        pnlInstructionsSection.Name = "pnlInstructionsSection"
        pnlInstructionsSection.Padding = New Padding(14, 16, 14, 16)
        pnlInstructionsSection.Size = New Size(671, 98)
        pnlInstructionsSection.TabIndex = 3
        ' 
        ' lblInstructionsValue
        ' 
        lblInstructionsValue.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        lblInstructionsValue.Font = New Font("Segoe UI", 9.0F)
        lblInstructionsValue.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblInstructionsValue.Location = New Point(14, 44)
        lblInstructionsValue.Margin = New Padding(4, 0, 4, 0)
        lblInstructionsValue.Name = "lblInstructionsValue"
        lblInstructionsValue.Size = New Size(638, 46)
        lblInstructionsValue.TabIndex = 1
        lblInstructionsValue.Text = "Requirement instructions description text."
        ' 
        ' lblInstructionsHeader
        ' 
        lblInstructionsHeader.AutoSize = True
        lblInstructionsHeader.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblInstructionsHeader.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        lblInstructionsHeader.Location = New Point(14, 14)
        lblInstructionsHeader.Margin = New Padding(4, 0, 4, 0)
        lblInstructionsHeader.Name = "lblInstructionsHeader"
        lblInstructionsHeader.Size = New Size(92, 20)
        lblInstructionsHeader.TabIndex = 0
        lblInstructionsHeader.Text = "Instructions:"
        ' 
        ' lblStatusBadge
        ' 
        lblStatusBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblStatusBadge.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblStatusBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblStatusBadge.ForeColor = Color.FromArgb(CByte(30), CByte(64), CByte(175))
        lblStatusBadge.Location = New Point(498, 26)
        lblStatusBadge.Margin = New Padding(4, 0, 4, 0)
        lblStatusBadge.Name = "lblStatusBadge"
        lblStatusBadge.Size = New Size(171, 40)
        lblStatusBadge.TabIndex = 2
        lblStatusBadge.Text = "Pending"
        lblStatusBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRequirementTitle
        ' 
        lblRequirementTitle.AutoEllipsis = True
        lblRequirementTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblRequirementTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRequirementTitle.Location = New Point(114, 26)
        lblRequirementTitle.Margin = New Padding(4, 0, 4, 0)
        lblRequirementTitle.Name = "lblRequirementTitle"
        lblRequirementTitle.Size = New Size(362, 40)
        lblRequirementTitle.TabIndex = 1
        lblRequirementTitle.Text = "Requirement Name"
        lblRequirementTitle.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblStepOrder
        ' 
        lblStepOrder.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        lblStepOrder.Font = New Font("Microsoft Sans Serif", 9.0F, FontStyle.Bold)
        lblStepOrder.ForeColor = Color.White
        lblStepOrder.Location = New Point(22, 24)
        lblStepOrder.Margin = New Padding(4, 0, 4, 0)
        lblStepOrder.Name = "lblStepOrder"
        lblStepOrder.Size = New Size(78, 44)
        lblStepOrder.TabIndex = 0
        lblStepOrder.Text = "Step 1"
        lblStepOrder.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnDismiss
        ' 
        btnDismiss.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDismiss.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnDismiss.Cursor = Cursors.Hand
        btnDismiss.FlatAppearance.BorderSize = 0
        btnDismiss.FlatStyle = FlatStyle.Flat
        btnDismiss.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnDismiss.ForeColor = Color.White
        btnDismiss.Location = New Point(611, 724)
        btnDismiss.Margin = New Padding(4, 5, 4, 5)
        btnDismiss.Name = "btnDismiss"
        btnDismiss.Size = New Size(158, 60)
        btnDismiss.TabIndex = 3
        btnDismiss.Text = "Close"
        btnDismiss.UseVisualStyleBackColor = False
        ' 
        ' ViewRequirementModalForm
        ' 
        AutoScaleDimensions = New SizeF(120.0F, 120.0F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.White
        ClientSize = New Size(800, 812)
        Controls.Add(pnlMainCard)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 5, 4, 5)
        MaximizeBox = False
        MinimizeBox = False
        Name = "ViewRequirementModalForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Requirement Details"
        pnlMainCard.ResumeLayout(False)
        pnlDetails.ResumeLayout(False)
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