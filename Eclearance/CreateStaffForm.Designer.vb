<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateStaffForm
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
        pnlSidebar = New Panel()
        lblNavSection = New Label()
        btnNavStudents = New Button()
        btnNavStaff = New Button()
        btnNavHistory = New Button()
        btnNavStartTerm = New Button()
        btnNavLogout = New Button()
        pnlLogo = New Panel()
        lblLogoText = New Label()
        lblLogoIcon = New Label()
        pnlMain = New Panel()
        pnlAccessCard = New Panel()
        lblAssignedBadge = New Label()
        lblAssignedLabel = New Label()
        lblAccessDesc = New Label()
        lblAccessTitle = New Label()
        lblAccessIcon = New Label()
        pnlFormCard = New Panel()
        btnCreateAccount = New Button()
        btnClearForm = New Button()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblSecAccount = New Label()
        cmbAssignedOffice = New ComboBox()
        lblAssignedOffice = New Label()
        txtFullName = New TextBox()
        lblFullName = New Label()
        lblSecStaff = New Label()
        pnlHeader = New Panel()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        lblBreadcrumb = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlAccessCard.SuspendLayout()
        pnlFormCard.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(15, 39, 74)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(btnNavStudents)
        pnlSidebar.Controls.Add(btnNavStaff)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavStartTerm)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' lblNavSection
        ' 
        lblNavSection.AutoSize = True
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblNavSection.ForeColor = Color.FromArgb(91, 122, 159)
        lblNavSection.Location = New Point(18, 90)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(94, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "ADMINISTRATION"
        ' 
        ' btnNavStudents
        ' 
        btnNavStudents.BackColor = Color.FromArgb(15, 39, 74)
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavStudents.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavStudents.Location = New Point(12, 115)
        btnNavStudents.Name = "btnNavStudents"
        btnNavStudents.Padding = New Padding(12, 0, 0, 0)
        btnNavStudents.Size = New Size(196, 42)
        btnNavStudents.TabIndex = 2
        btnNavStudents.Text = "👥  Students"
        btnNavStudents.TextAlign = ContentAlignment.MiddleLeft
        btnNavStudents.UseVisualStyleBackColor = False
        ' 
        ' btnNavStaff
        ' 
        btnNavStaff.BackColor = Color.FromArgb(28, 91, 184)
        btnNavStaff.FlatAppearance.BorderSize = 0
        btnNavStaff.FlatStyle = FlatStyle.Flat
        btnNavStaff.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnNavStaff.ForeColor = Color.White
        btnNavStaff.Location = New Point(12, 163)
        btnNavStaff.Name = "btnNavStaff"
        btnNavStaff.Padding = New Padding(12, 0, 0, 0)
        btnNavStaff.Size = New Size(196, 42)
        btnNavStaff.TabIndex = 3
        btnNavStaff.Text = "🏛  Staff & offices"
        btnNavStaff.TextAlign = ContentAlignment.MiddleLeft
        btnNavStaff.UseVisualStyleBackColor = False
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.BackColor = Color.FromArgb(15, 39, 74)
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavHistory.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavHistory.Location = New Point(12, 211)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Padding = New Padding(12, 0, 0, 0)
        btnNavHistory.Size = New Size(196, 42)
        btnNavHistory.TabIndex = 4
        btnNavHistory.Text = "⏱  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = False
        ' 
        ' btnNavStartTerm
        ' 
        btnNavStartTerm.BackColor = Color.FromArgb(15, 39, 74)
        btnNavStartTerm.FlatAppearance.BorderSize = 0
        btnNavStartTerm.FlatStyle = FlatStyle.Flat
        btnNavStartTerm.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavStartTerm.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavStartTerm.Location = New Point(12, 259)
        btnNavStartTerm.Name = "btnNavStartTerm"
        btnNavStartTerm.Padding = New Padding(12, 0, 0, 0)
        btnNavStartTerm.Size = New Size(196, 42)
        btnNavStartTerm.TabIndex = 5
        btnNavStartTerm.Text = "📅  Start new term"
        btnNavStartTerm.TextAlign = ContentAlignment.MiddleLeft
        btnNavStartTerm.UseVisualStyleBackColor = False
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Dock = DockStyle.Bottom
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavLogout.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavLogout.Location = New Point(0, 752)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Padding = New Padding(20, 0, 0, 0)
        btnNavLogout.Size = New Size(220, 48)
        btnNavLogout.TabIndex = 6
        btnNavLogout.Text = "↪  Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = False
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(lblLogoText)
        pnlLogo.Controls.Add(lblLogoIcon)
        pnlLogo.Dock = DockStyle.Top
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 75)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogoText
        ' 
        lblLogoText.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblLogoText.ForeColor = Color.White
        lblLogoText.Location = New Point(55, 18)
        lblLogoText.Name = "lblLogoText"
        lblLogoText.Size = New Size(140, 40)
        lblLogoText.TabIndex = 1
        lblLogoText.Text = "School" & vbCrLf & "Clearance"
        ' 
        ' lblLogoIcon
        ' 
        lblLogoIcon.AutoSize = True
        lblLogoIcon.Font = New Font("Segoe UI Emoji", 18.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblLogoIcon.ForeColor = Color.White
        lblLogoIcon.Location = New Point(14, 20)
        lblLogoIcon.Name = "lblLogoIcon"
        lblLogoIcon.Size = New Size(38, 32)
        lblLogoIcon.TabIndex = 0
        lblLogoIcon.Text = "🎓"
        ' 
        ' pnlMain
        ' 
        pnlMain.AutoScroll = True
        pnlMain.BackColor = Color.FromArgb(244, 247, 251)
        pnlMain.Controls.Add(pnlAccessCard)
        pnlFormCard.Controls.Add(btnCreateAccount)
        pnlFormCard.Controls.Add(btnClearForm)
        pnlFormCard.Controls.Add(txtPassword)
        pnlFormCard.Controls.Add(lblPassword)
        pnlFormCard.Controls.Add(txtUsername)
        pnlFormCard.Controls.Add(lblUsername)
        pnlFormCard.Controls.Add(lblSecAccount)
        pnlFormCard.Controls.Add(cmbAssignedOffice)
        pnlFormCard.Controls.Add(lblAssignedOffice)
        pnlFormCard.Controls.Add(txtFullName)
        pnlFormCard.Controls.Add(lblFullName)
        pnlFormCard.Controls.Add(lblSecStaff)
        pnlMain.Controls.Add(pnlFormCard)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 16, 28, 20)
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' pnlAccessCard
        ' 
        pnlAccessCard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlAccessCard.BackColor = Color.FromArgb(241, 246, 254)
        pnlAccessCard.BorderStyle = BorderStyle.FixedSingle
        pnlAccessCard.Controls.Add(lblAssignedBadge)
        pnlAccessCard.Controls.Add(lblAssignedLabel)
        pnlAccessCard.Controls.Add(lblAccessDesc)
        pnlAccessCard.Controls.Add(lblAccessTitle)
        pnlAccessCard.Controls.Add(lblAccessIcon)
        pnlAccessCard.Location = New Point(680, 110)
        pnlAccessCard.Name = "pnlAccessCard"
        pnlAccessCard.Padding = New Padding(20)
        pnlAccessCard.Size = New Size(270, 240)
        pnlAccessCard.TabIndex = 2
        ' 
        ' lblAssignedBadge
        ' 
        lblAssignedBadge.BackColor = Color.FromArgb(219, 234, 254)
        lblAssignedBadge.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAssignedBadge.ForeColor = Color.FromArgb(29, 78, 216)
        lblAssignedBadge.Location = New Point(20, 185)
        lblAssignedBadge.Name = "lblAssignedBadge"
        lblAssignedBadge.Size = New Size(110, 28)
        lblAssignedBadge.TabIndex = 4
        lblAssignedBadge.Text = "Office"
        lblAssignedBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblAssignedLabel
        ' 
        lblAssignedLabel.AutoSize = True
        lblAssignedLabel.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblAssignedLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblAssignedLabel.Location = New Point(20, 160)
        lblAssignedLabel.Name = "lblAssignedLabel"
        lblAssignedLabel.Size = New Size(69, 15)
        lblAssignedLabel.TabIndex = 3
        lblAssignedLabel.Text = "Assigned to"
        ' 
        ' lblAccessDesc
        ' 
        lblAccessDesc.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblAccessDesc.ForeColor = Color.FromArgb(51, 65, 85)
        lblAccessDesc.Location = New Point(20, 95)
        lblAccessDesc.Name = "lblAccessDesc"
        lblAccessDesc.Size = New Size(228, 55)
        lblAccessDesc.TabIndex = 2
        lblAccessDesc.Text = "This staff member can review clearance requests and manage instructions for the selected office."
        ' 
        ' lblAccessTitle
        ' 
        lblAccessTitle.AutoSize = True
        lblAccessTitle.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAccessTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblAccessTitle.Location = New Point(20, 65)
        lblAccessTitle.Name = "lblAccessTitle"
        lblAccessTitle.Size = New Size(102, 20)
        lblAccessTitle.TabIndex = 1
        lblAccessTitle.Text = "Office access"
        ' 
        ' lblAccessIcon
        ' 
        lblAccessIcon.Font = New Font("Segoe UI Emoji", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblAccessIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblAccessIcon.Location = New Point(16, 15)
        lblAccessIcon.Name = "lblAccessIcon"
        lblAccessIcon.Size = New Size(48, 45)
        lblAccessIcon.TabIndex = 0
        lblAccessIcon.Text = "🏛"
        ' 
        ' pnlFormCard
        ' 
        pnlFormCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFormCard.BackColor = Color.White
        pnlFormCard.BorderStyle = BorderStyle.FixedSingle
        pnlFormCard.Controls.Add(btnCreateAccount)
        pnlFormCard.Controls.Add(btnClearForm)
        pnlFormCard.Controls.Add(txtPassword)
        pnlFormCard.Controls.Add(lblPassword)
        pnlFormCard.Controls.Add(txtUsername)
        pnlFormCard.Controls.Add(lblUsername)
        pnlFormCard.Controls.Add(lblSecAccount)
        pnlFormCard.Controls.Add(cmbAssignedOffice)
        pnlFormCard.Controls.Add(lblAssignedOffice)
        pnlFormCard.Controls.Add(txtFullName)
        pnlFormCard.Controls.Add(lblFullName)
        pnlFormCard.Controls.Add(lblSecStaff)
        pnlFormCard.Location = New Point(28, 110)
        pnlFormCard.Name = "pnlFormCard"
        pnlFormCard.Padding = New Padding(24)
        pnlFormCard.Size = New Size(630, 520)
        pnlFormCard.TabIndex = 1
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCreateAccount.BackColor = Color.FromArgb(11, 99, 229)
        btnCreateAccount.Cursor = Cursors.Hand
        btnCreateAccount.FlatAppearance.BorderSize = 0
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnCreateAccount.ForeColor = Color.White
        btnCreateAccount.Location = New Point(470, 460)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(136, 38)
        btnCreateAccount.TabIndex = 11
        btnCreateAccount.Text = "Create account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' btnClearForm
        ' 
        btnClearForm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClearForm.BackColor = Color.White
        btnClearForm.Cursor = Cursors.Hand
        btnClearForm.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnClearForm.FlatStyle = FlatStyle.Flat
        btnClearForm.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnClearForm.ForeColor = Color.FromArgb(71, 85, 105)
        btnClearForm.Location = New Point(24, 460)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(110, 38)
        btnClearForm.TabIndex = 10
        btnClearForm.Text = "Clear form"
        btnClearForm.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(24, 385)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(582, 24)
        txtPassword.TabIndex = 9
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblPassword.Location = New Point(24, 365)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 8
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(24, 315)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(582, 24)
        txtUsername.TabIndex = 7
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.FromArgb(51, 65, 85)
        lblUsername.Location = New Point(24, 295)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 6
        lblUsername.Text = "Username"
        ' 
        ' lblSecAccount
        ' 
        lblSecAccount.AutoSize = True
        lblSecAccount.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblSecAccount.ForeColor = Color.FromArgb(15, 23, 42)
        lblSecAccount.Location = New Point(24, 255)
        lblSecAccount.Name = "lblSecAccount"
        lblSecAccount.Size = New Size(123, 21)
        lblSecAccount.TabIndex = 5
        lblSecAccount.Text = "Account details"
        ' 
        ' cmbAssignedOffice
        ' 
        cmbAssignedOffice.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbAssignedOffice.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAssignedOffice.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbAssignedOffice.FormattingEnabled = True
        cmbAssignedOffice.Items.AddRange(New Object() {"Library", "Finance", "Registrar", "Guidance", "Clinic", "Dean's Office", "Student Affairs"})
        cmbAssignedOffice.Location = New Point(24, 180)
        cmbAssignedOffice.Name = "cmbAssignedOffice"
        cmbAssignedOffice.Size = New Size(582, 24)
        cmbAssignedOffice.TabIndex = 4
        ' 
        ' lblAssignedOffice
        ' 
        lblAssignedOffice.AutoSize = True
        lblAssignedOffice.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAssignedOffice.ForeColor = Color.FromArgb(51, 65, 85)
        lblAssignedOffice.Location = New Point(24, 160)
        lblAssignedOffice.Name = "lblAssignedOffice"
        lblAssignedOffice.Size = New Size(89, 15)
        lblAssignedOffice.TabIndex = 3
        lblAssignedOffice.Text = "Assigned office"
        ' 
        ' txtFullName
        ' 
        txtFullName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullName.Location = New Point(24, 110)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(582, 24)
        txtFullName.TabIndex = 2
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.ForeColor = Color.FromArgb(51, 65, 85)
        lblFullName.Location = New Point(24, 90)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(58, 15)
        lblFullName.TabIndex = 1
        lblFullName.Text = "Full name"
        ' 
        ' lblSecStaff
        ' 
        lblSecStaff.AutoSize = True
        lblSecStaff.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblSecStaff.ForeColor = Color.FromArgb(15, 23, 42)
        lblSecStaff.Location = New Point(24, 50)
        lblSecStaff.Name = "lblSecStaff"
        lblSecStaff.Size = New Size(141, 21)
        lblSecStaff.TabIndex = 0
        lblSecStaff.Text = "Staff information"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblBreadcrumb)
        pnlHeader.Location = New Point(28, 12)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 85)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubHeader.Location = New Point(0, 58)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(260, 17)
        lblSubHeader.TabIndex = 2
        lblSubHeader.Text = "Assign a staff member to a clearance office."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 20)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(260, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Create staff account"
        ' 
        ' lblBreadcrumb
        ' 
        lblBreadcrumb.AutoSize = True
        lblBreadcrumb.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblBreadcrumb.ForeColor = Color.FromArgb(100, 116, 139)
        lblBreadcrumb.Location = New Point(0, 0)
        lblBreadcrumb.Name = "lblBreadcrumb"
        lblBreadcrumb.Size = New Size(141, 15)
        lblBreadcrumb.TabIndex = 0
        lblBreadcrumb.Text = "Staff & offices  /  New staff"
        ' 
        ' CreateStaffForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1100, 750)
        Name = "CreateStaffForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Create Staff Account"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlAccessCard.ResumeLayout(False)
        pnlAccessCard.PerformLayout()
        pnlFormCard.ResumeLayout(False)
        pnlFormCard.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogoIcon As Label
    Friend WithEvents lblLogoText As Label
    Friend WithEvents lblNavSection As Label
    Friend WithEvents btnNavStudents As Button
    Friend WithEvents btnNavStaff As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents btnNavStartTerm As Button
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblBreadcrumb As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents pnlFormCard As Panel
    Friend WithEvents lblSecStaff As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblAssignedOffice As Label
    Friend WithEvents cmbAssignedOffice As ComboBox
    Friend WithEvents lblSecAccount As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents pnlAccessCard As Panel
    Friend WithEvents lblAccessIcon As Label
    Friend WithEvents lblAccessTitle As Label
    Friend WithEvents lblAccessDesc As Label
    Friend WithEvents lblAssignedLabel As Label
    Friend WithEvents lblAssignedBadge As Label

End Class
