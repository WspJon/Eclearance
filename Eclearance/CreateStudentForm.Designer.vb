<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateStudentForm
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
        pnlFormCard = New Panel()
        btnCreateAccount = New Button()
        btnClearForm = New Button()
        lblPwdHelp = New Label()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblBadge03 = New Label()
        lblSec03 = New Label()
        chkNSTP = New CheckBox()
        cmbYearLevel = New ComboBox()
        lblYearLevel = New Label()
        cmbCourse = New ComboBox()
        lblCourse = New Label()
        lblBadge02 = New Label()
        lblSec02 = New Label()
        txtLastName = New TextBox()
        lblLastName = New Label()
        txtFirstName = New TextBox()
        lblFirstName = New Label()
        txtStudentNo = New TextBox()
        lblStudentNo = New Label()
        lblBadge01 = New Label()
        lblSec01 = New Label()
        pnlHeader = New Panel()
        lblTermBadge = New Label()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        lblBreadcrumb = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlFormCard.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
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
        pnlSidebar.Size = New Size(220, 850)
        pnlSidebar.TabIndex = 0
        ' 
        ' lblNavSection
        ' 
        lblNavSection.AutoSize = True
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblNavSection.ForeColor = Color.FromArgb(CByte(91), CByte(122), CByte(159))
        lblNavSection.Location = New Point(18, 90)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(93, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "ADMINISTRATION"
        ' 
        ' btnNavStudents
        ' 
        btnNavStudents.BackColor = Color.FromArgb(CByte(28), CByte(91), CByte(184))
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavStudents.ForeColor = Color.White
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
        btnNavStaff.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStaff.FlatAppearance.BorderSize = 0
        btnNavStaff.FlatStyle = FlatStyle.Flat
        btnNavStaff.Font = New Font("Segoe UI", 9.5F)
        btnNavStaff.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
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
        btnNavHistory.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F)
        btnNavHistory.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
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
        btnNavStartTerm.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        btnNavStartTerm.FlatAppearance.BorderSize = 0
        btnNavStartTerm.FlatStyle = FlatStyle.Flat
        btnNavStartTerm.Font = New Font("Segoe UI", 9.5F)
        btnNavStartTerm.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
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
        btnNavLogout.Font = New Font("Segoe UI", 9.5F)
        btnNavLogout.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavLogout.Location = New Point(0, 802)
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
        lblLogoText.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
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
        lblLogoIcon.Font = New Font("Segoe UI Emoji", 18F)
        lblLogoIcon.ForeColor = Color.White
        lblLogoIcon.Location = New Point(14, 20)
        lblLogoIcon.Name = "lblLogoIcon"
        lblLogoIcon.Size = New Size(47, 32)
        lblLogoIcon.TabIndex = 0
        lblLogoIcon.Text = "🎓"
        ' 
        ' pnlMain
        ' 
        pnlMain.AutoScroll = True
        pnlMain.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlMain.Controls.Add(pnlFormCard)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 16, 28, 20)
        pnlMain.Size = New Size(864, 850)
        pnlMain.TabIndex = 1
        ' 
        ' pnlFormCard
        ' 
        pnlFormCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFormCard.BackColor = Color.White
        pnlFormCard.BorderStyle = BorderStyle.FixedSingle
        pnlFormCard.Controls.Add(btnCreateAccount)
        pnlFormCard.Controls.Add(btnClearForm)
        pnlFormCard.Controls.Add(lblPwdHelp)
        pnlFormCard.Controls.Add(txtPassword)
        pnlFormCard.Controls.Add(lblPassword)
        pnlFormCard.Controls.Add(txtUsername)
        pnlFormCard.Controls.Add(lblUsername)
        pnlFormCard.Controls.Add(lblBadge03)
        pnlFormCard.Controls.Add(lblSec03)
        pnlFormCard.Controls.Add(chkNSTP)
        pnlFormCard.Controls.Add(cmbYearLevel)
        pnlFormCard.Controls.Add(lblYearLevel)
        pnlFormCard.Controls.Add(cmbCourse)
        pnlFormCard.Controls.Add(lblCourse)
        pnlFormCard.Controls.Add(lblBadge02)
        pnlFormCard.Controls.Add(lblSec02)
        pnlFormCard.Controls.Add(txtLastName)
        pnlFormCard.Controls.Add(lblLastName)
        pnlFormCard.Controls.Add(txtFirstName)
        pnlFormCard.Controls.Add(lblFirstName)
        pnlFormCard.Controls.Add(txtStudentNo)
        pnlFormCard.Controls.Add(lblStudentNo)
        pnlFormCard.Controls.Add(lblBadge01)
        pnlFormCard.Controls.Add(lblSec01)
        pnlFormCard.Location = New Point(28, 110)
        pnlFormCard.Name = "pnlFormCard"
        pnlFormCard.Padding = New Padding(24)
        pnlFormCard.Size = New Size(747, 690)
        pnlFormCard.TabIndex = 1
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCreateAccount.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnCreateAccount.Cursor = Cursors.Hand
        btnCreateAccount.FlatAppearance.BorderSize = 0
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnCreateAccount.ForeColor = Color.White
        btnCreateAccount.Location = New Point(466, 574)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(136, 38)
        btnCreateAccount.TabIndex = 23
        btnCreateAccount.Text = "Create account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' btnClearForm
        ' 
        btnClearForm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnClearForm.BackColor = Color.White
        btnClearForm.Cursor = Cursors.Hand
        btnClearForm.FlatAppearance.BorderColor = Color.FromArgb(CByte(203), CByte(213), CByte(225))
        btnClearForm.FlatStyle = FlatStyle.Flat
        btnClearForm.Font = New Font("Segoe UI", 9F)
        btnClearForm.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        btnClearForm.Location = New Point(22, 574)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(110, 38)
        btnClearForm.TabIndex = 22
        btnClearForm.Text = "Clear form"
        btnClearForm.UseVisualStyleBackColor = False
        ' 
        ' lblPwdHelp
        ' 
        lblPwdHelp.AutoSize = True
        lblPwdHelp.Font = New Font("Segoe UI", 8F)
        lblPwdHelp.ForeColor = Color.FromArgb(CByte(148), CByte(163), CByte(184))
        lblPwdHelp.Location = New Point(312, 518)
        lblPwdHelp.Name = "lblPwdHelp"
        lblPwdHelp.Size = New Size(112, 13)
        lblPwdHelp.TabIndex = 21
        lblPwdHelp.Text = "At least 8 characters."
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 9.5F)
        txtPassword.Location = New Point(312, 488)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(290, 24)
        txtPassword.TabIndex = 20
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblPassword.Location = New Point(312, 468)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 19
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 9.5F)
        txtUsername.Location = New Point(22, 488)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(270, 24)
        txtUsername.TabIndex = 18
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblUsername.Location = New Point(22, 468)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 17
        lblUsername.Text = "Username"
        ' 
        ' lblBadge03
        ' 
        lblBadge03.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblBadge03.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblBadge03.ForeColor = Color.FromArgb(CByte(29), CByte(78), CByte(216))
        lblBadge03.Location = New Point(22, 424)
        lblBadge03.Name = "lblBadge03"
        lblBadge03.Size = New Size(26, 24)
        lblBadge03.TabIndex = 16
        lblBadge03.Text = "03"
        lblBadge03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec03
        ' 
        lblSec03.AutoSize = True
        lblSec03.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSec03.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSec03.Location = New Point(56, 426)
        lblSec03.Name = "lblSec03"
        lblSec03.Size = New Size(117, 20)
        lblSec03.TabIndex = 15
        lblSec03.Text = "Account details"
        ' 
        ' chkNSTP
        ' 
        chkNSTP.AutoSize = True
        chkNSTP.Font = New Font("Segoe UI", 9F)
        chkNSTP.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        chkNSTP.Location = New Point(22, 369)
        chkNSTP.Name = "chkNSTP"
        chkNSTP.Size = New Size(114, 19)
        chkNSTP.TabIndex = 14
        chkNSTP.Text = "Enrolled in NSTP"
        chkNSTP.UseVisualStyleBackColor = True
        ' 
        ' cmbYearLevel
        ' 
        cmbYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYearLevel.Font = New Font("Segoe UI", 9.5F)
        cmbYearLevel.FormattingEnabled = True
        cmbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cmbYearLevel.Location = New Point(312, 324)
        cmbYearLevel.Name = "cmbYearLevel"
        cmbYearLevel.Size = New Size(290, 25)
        cmbYearLevel.TabIndex = 13
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblYearLevel.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblYearLevel.Location = New Point(312, 304)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(56, 15)
        lblYearLevel.TabIndex = 12
        lblYearLevel.Text = "Year level"
        ' 
        ' cmbCourse
        ' 
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.Font = New Font("Segoe UI", 9.5F)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"BS Information Technology", "BS Computer Science", "BS CTHM", "BS Business Administration", "BS Accountancy"})
        cmbCourse.Location = New Point(22, 324)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(270, 25)
        cmbCourse.TabIndex = 11
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblCourse.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblCourse.Location = New Point(22, 304)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(43, 15)
        lblCourse.TabIndex = 10
        lblCourse.Text = "Course"
        ' 
        ' lblBadge02
        ' 
        lblBadge02.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblBadge02.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblBadge02.ForeColor = Color.FromArgb(CByte(29), CByte(78), CByte(216))
        lblBadge02.Location = New Point(22, 259)
        lblBadge02.Name = "lblBadge02"
        lblBadge02.Size = New Size(26, 24)
        lblBadge02.TabIndex = 9
        lblBadge02.Text = "02"
        lblBadge02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec02
        ' 
        lblSec02.AutoSize = True
        lblSec02.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSec02.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSec02.Location = New Point(56, 261)
        lblSec02.Name = "lblSec02"
        lblSec02.Size = New Size(127, 20)
        lblSec02.TabIndex = 8
        lblSec02.Text = "Academic details"
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Segoe UI", 9.5F)
        txtLastName.Location = New Point(312, 179)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(290, 24)
        txtLastName.TabIndex = 7
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblLastName.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblLastName.Location = New Point(312, 159)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(61, 15)
        lblLastName.TabIndex = 6
        lblLastName.Text = "Last name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Segoe UI", 9.5F)
        txtFirstName.Location = New Point(22, 179)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(270, 24)
        txtFirstName.TabIndex = 5
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblFirstName.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblFirstName.Location = New Point(22, 159)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(62, 15)
        lblFirstName.TabIndex = 4
        lblFirstName.Text = "First name"
        ' 
        ' txtStudentNo
        ' 
        txtStudentNo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtStudentNo.BorderStyle = BorderStyle.FixedSingle
        txtStudentNo.Font = New Font("Segoe UI", 9.5F)
        txtStudentNo.Location = New Point(22, 99)
        txtStudentNo.Name = "txtStudentNo"
        txtStudentNo.Size = New Size(580, 24)
        txtStudentNo.TabIndex = 3
        ' 
        ' lblStudentNo
        ' 
        lblStudentNo.AutoSize = True
        lblStudentNo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblStudentNo.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblStudentNo.Location = New Point(22, 79)
        lblStudentNo.Name = "lblStudentNo"
        lblStudentNo.Size = New Size(94, 15)
        lblStudentNo.TabIndex = 2
        lblStudentNo.Text = "Student number"
        ' 
        ' lblBadge01
        ' 
        lblBadge01.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblBadge01.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblBadge01.ForeColor = Color.FromArgb(CByte(29), CByte(78), CByte(216))
        lblBadge01.Location = New Point(24, 34)
        lblBadge01.Name = "lblBadge01"
        lblBadge01.Size = New Size(26, 24)
        lblBadge01.TabIndex = 1
        lblBadge01.Text = "01"
        lblBadge01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec01
        ' 
        lblSec01.AutoSize = True
        lblSec01.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblSec01.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblSec01.Location = New Point(58, 36)
        lblSec01.Name = "lblSec01"
        lblSec01.Size = New Size(152, 20)
        lblSec01.TabIndex = 0
        lblSec01.Text = "Student information"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(lblTermBadge)
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblBreadcrumb)
        pnlHeader.Location = New Point(28, 12)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(808, 85)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTermBadge
        ' 
        lblTermBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTermBadge.BackColor = Color.FromArgb(CByte(238), CByte(242), CByte(255))
        lblTermBadge.BorderStyle = BorderStyle.FixedSingle
        lblTermBadge.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblTermBadge.ForeColor = Color.FromArgb(CByte(49), CByte(46), CByte(129))
        lblTermBadge.Location = New Point(628, 25)
        lblTermBadge.Name = "lblTermBadge"
        lblTermBadge.Padding = New Padding(6)
        lblTermBadge.Size = New Size(180, 34)
        lblTermBadge.TabIndex = 3
        lblTermBadge.Text = "📅 Current Term"
        lblTermBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F)
        lblSubHeader.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblSubHeader.Location = New Point(0, 58)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(269, 17)
        lblSubHeader.TabIndex = 2
        lblSubHeader.Text = "Add student details and set up their account."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(-3, 20)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(314, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Create student account"
        ' 
        ' lblBreadcrumb
        ' 
        lblBreadcrumb.AutoSize = True
        lblBreadcrumb.Font = New Font("Segoe UI", 9F)
        lblBreadcrumb.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblBreadcrumb.Location = New Point(0, 0)
        lblBreadcrumb.Name = "lblBreadcrumb"
        lblBreadcrumb.Size = New Size(137, 15)
        lblBreadcrumb.TabIndex = 0
        lblBreadcrumb.Text = "Students  /  New student"
        ' 
        ' CreateStudentForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        ClientSize = New Size(1084, 850)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 750)
        Name = "CreateStudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Create Student Account"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
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
    Friend WithEvents lblTermBadge As Label
    Friend WithEvents pnlFormCard As Panel
    Friend WithEvents lblBadge01 As Label
    Friend WithEvents lblSec01 As Label
    Friend WithEvents lblStudentNo As Label
    Friend WithEvents txtStudentNo As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblBadge02 As Label
    Friend WithEvents lblSec02 As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblYearLevel As Label
    Friend WithEvents cmbYearLevel As ComboBox
    Friend WithEvents chkNSTP As CheckBox
    Friend WithEvents lblBadge03 As Label
    Friend WithEvents lblSec03 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPwdHelp As Label
    Friend WithEvents btnClearForm As Button
    Friend WithEvents btnCreateAccount As Button

End Class
