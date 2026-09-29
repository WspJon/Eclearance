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
        pnlNextInfoCard = New Panel()
        lblStepDesc3 = New Label()
        lblStepNum3 = New Label()
        lblStepDesc2 = New Label()
        lblStepNum2 = New Label()
        lblStepDesc1 = New Label()
        lblStepNum1 = New Label()
        lblNextTitle = New Label()
        lblNextIcon = New Label()
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
        pnlNextInfoCard.SuspendLayout()
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
        pnlSidebar.Size = New Size(220, 850)
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
        btnNavStudents.BackColor = Color.FromArgb(28, 91, 184)
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
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
        btnNavStaff.BackColor = Color.FromArgb(15, 39, 74)
        btnNavStaff.FlatAppearance.BorderSize = 0
        btnNavStaff.FlatStyle = FlatStyle.Flat
        btnNavStaff.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavStaff.ForeColor = Color.FromArgb(160, 180, 208)
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
        pnlMain.Controls.Add(pnlNextInfoCard)
        pnlMain.Controls.Add(pnlFormCard)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 16, 28, 20)
        pnlMain.Size = New Size(980, 850)
        pnlMain.TabIndex = 1
        ' 
        ' pnlNextInfoCard
        ' 
        pnlNextInfoCard.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlNextInfoCard.BackColor = Color.FromArgb(241, 246, 254)
        pnlNextInfoCard.BorderStyle = BorderStyle.FixedSingle
        pnlNextInfoCard.Controls.Add(lblStepDesc3)
        pnlNextInfoCard.Controls.Add(lblStepNum3)
        pnlNextInfoCard.Controls.Add(lblStepDesc2)
        pnlNextInfoCard.Controls.Add(lblStepNum2)
        pnlNextInfoCard.Controls.Add(lblStepDesc1)
        pnlNextInfoCard.Controls.Add(lblStepNum1)
        pnlNextInfoCard.Controls.Add(lblNextTitle)
        pnlNextInfoCard.Controls.Add(lblNextIcon)
        pnlNextInfoCard.Location = New Point(680, 110)
        pnlNextInfoCard.Name = "pnlNextInfoCard"
        pnlNextInfoCard.Padding = New Padding(20)
        pnlNextInfoCard.Size = New Size(270, 240)
        pnlNextInfoCard.TabIndex = 2
        ' 
        ' lblStepDesc3
        ' 
        lblStepDesc3.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStepDesc3.ForeColor = Color.FromArgb(51, 65, 85)
        lblStepDesc3.Location = New Point(52, 172)
        lblStepDesc3.Name = "lblStepDesc3"
        lblStepDesc3.Size = New Size(195, 38)
        lblStepDesc3.TabIndex = 7
        lblStepDesc3.Text = "Requirements start as Pending"
        ' 
        ' lblStepNum3
        ' 
        lblStepNum3.BackColor = Color.FromArgb(219, 234, 254)
        lblStepNum3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStepNum3.ForeColor = Color.FromArgb(29, 78, 216)
        lblStepNum3.Location = New Point(18, 170)
        lblStepNum3.Name = "lblStepNum3"
        lblStepNum3.Size = New Size(24, 24)
        lblStepNum3.TabIndex = 6
        lblStepNum3.Text = "3"
        lblStepNum3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStepDesc2
        ' 
        lblStepDesc2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStepDesc2.ForeColor = Color.FromArgb(51, 65, 85)
        lblStepDesc2.Location = New Point(52, 117)
        lblStepDesc2.Name = "lblStepDesc2"
        lblStepDesc2.Size = New Size(195, 38)
        lblStepDesc2.TabIndex = 5
        lblStepDesc2.Text = "Applicable offices are assigned"
        ' 
        ' lblStepNum2
        ' 
        lblStepNum2.BackColor = Color.FromArgb(219, 234, 254)
        lblStepNum2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStepNum2.ForeColor = Color.FromArgb(29, 78, 216)
        lblStepNum2.Location = New Point(18, 115)
        lblStepNum2.Name = "lblStepNum2"
        lblStepNum2.Size = New Size(24, 24)
        lblStepNum2.TabIndex = 4
        lblStepNum2.Text = "2"
        lblStepNum2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStepDesc1
        ' 
        lblStepDesc1.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblStepDesc1.ForeColor = Color.FromArgb(51, 65, 85)
        lblStepDesc1.Location = New Point(52, 62)
        lblStepDesc1.Name = "lblStepDesc1"
        lblStepDesc1.Size = New Size(195, 38)
        lblStepDesc1.TabIndex = 3
        lblStepDesc1.Text = "Student account is created"
        ' 
        ' lblStepNum1
        ' 
        lblStepNum1.BackColor = Color.FromArgb(219, 234, 254)
        lblStepNum1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStepNum1.ForeColor = Color.FromArgb(29, 78, 216)
        lblStepNum1.Location = New Point(18, 60)
        lblStepNum1.Name = "lblStepNum1"
        lblStepNum1.Size = New Size(24, 24)
        lblStepNum1.TabIndex = 2
        lblStepNum1.Text = "1"
        lblStepNum1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNextTitle
        ' 
        lblNextTitle.AutoSize = True
        lblNextTitle.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblNextTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblNextTitle.Location = New Point(46, 18)
        lblNextTitle.Name = "lblNextTitle"
        lblNextTitle.Size = New Size(149, 19)
        lblNextTitle.TabIndex = 1
        lblNextTitle.Text = "What happens next?"
        ' 
        ' lblNextIcon
        ' 
        lblNextIcon.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblNextIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblNextIcon.Location = New Point(16, 15)
        lblNextIcon.Name = "lblNextIcon"
        lblNextIcon.Size = New Size(28, 26)
        lblNextIcon.TabIndex = 0
        lblNextIcon.Text = "💡"
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
        pnlFormCard.Size = New Size(630, 690)
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
        btnCreateAccount.Location = New Point(470, 630)
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
        btnClearForm.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnClearForm.FlatStyle = FlatStyle.Flat
        btnClearForm.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnClearForm.ForeColor = Color.FromArgb(71, 85, 105)
        btnClearForm.Location = New Point(24, 630)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(110, 38)
        btnClearForm.TabIndex = 22
        btnClearForm.Text = "Clear form"
        btnClearForm.UseVisualStyleBackColor = False
        ' 
        ' lblPwdHelp
        ' 
        lblPwdHelp.AutoSize = True
        lblPwdHelp.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblPwdHelp.ForeColor = Color.FromArgb(148, 163, 184)
        lblPwdHelp.Location = New Point(314, 574)
        lblPwdHelp.Name = "lblPwdHelp"
        lblPwdHelp.Size = New Size(111, 13)
        lblPwdHelp.TabIndex = 21
        lblPwdHelp.Text = "At least 8 characters."
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(314, 544)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(290, 24)
        txtPassword.TabIndex = 20
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblPassword.Location = New Point(314, 524)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 19
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(24, 544)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(270, 24)
        txtUsername.TabIndex = 18
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.FromArgb(51, 65, 85)
        lblUsername.Location = New Point(24, 524)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 17
        lblUsername.Text = "Username"
        ' 
        ' lblBadge03
        ' 
        lblBadge03.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge03.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge03.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge03.Location = New Point(24, 480)
        lblBadge03.Name = "lblBadge03"
        lblBadge03.Size = New Size(26, 24)
        lblBadge03.TabIndex = 16
        lblBadge03.Text = "03"
        lblBadge03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec03
        ' 
        lblSec03.AutoSize = True
        lblSec03.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSec03.ForeColor = Color.FromArgb(15, 23, 42)
        lblSec03.Location = New Point(58, 482)
        lblSec03.Name = "lblSec03"
        lblSec03.Size = New Size(117, 20)
        lblSec03.TabIndex = 15
        lblSec03.Text = "Account details"
        ' 
        ' chkNSTP
        ' 
        chkNSTP.AutoSize = True
        chkNSTP.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        chkNSTP.ForeColor = Color.FromArgb(51, 65, 85)
        chkNSTP.Location = New Point(24, 425)
        chkNSTP.Name = "chkNSTP"
        chkNSTP.Size = New Size(117, 19)
        chkNSTP.TabIndex = 14
        chkNSTP.Text = "Enrolled in NSTP"
        chkNSTP.UseVisualStyleBackColor = True
        ' 
        ' cmbYearLevel
        ' 
        cmbYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYearLevel.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbYearLevel.FormattingEnabled = True
        cmbYearLevel.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        cmbYearLevel.Location = New Point(314, 380)
        cmbYearLevel.Name = "cmbYearLevel"
        cmbYearLevel.Size = New Size(290, 24)
        cmbYearLevel.TabIndex = 13
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblYearLevel.ForeColor = Color.FromArgb(51, 65, 85)
        lblYearLevel.Location = New Point(314, 360)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(57, 15)
        lblYearLevel.TabIndex = 12
        lblYearLevel.Text = "Year level"
        ' 
        ' cmbCourse
        ' 
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Items.AddRange(New Object() {"BS Information Technology", "BS Computer Science", "BS CTHM", "BS Business Administration", "BS Accountancy"})
        cmbCourse.Location = New Point(24, 380)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(270, 24)
        cmbCourse.TabIndex = 11
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.ForeColor = Color.FromArgb(51, 65, 85)
        lblCourse.Location = New Point(24, 360)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(44, 15)
        lblCourse.TabIndex = 10
        lblCourse.Text = "Course"
        ' 
        ' lblBadge02
        ' 
        lblBadge02.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge02.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge02.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge02.Location = New Point(24, 315)
        lblBadge02.Name = "lblBadge02"
        lblBadge02.Size = New Size(26, 24)
        lblBadge02.TabIndex = 9
        lblBadge02.Text = "02"
        lblBadge02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec02
        ' 
        lblSec02.AutoSize = True
        lblSec02.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSec02.ForeColor = Color.FromArgb(15, 23, 42)
        lblSec02.Location = New Point(58, 317)
        lblSec02.Name = "lblSec02"
        lblSec02.Size = New Size(128, 20)
        lblSec02.TabIndex = 8
        lblSec02.Text = "Academic details"
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastName.Location = New Point(314, 235)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(290, 24)
        txtLastName.TabIndex = 7
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblLastName.ForeColor = Color.FromArgb(51, 65, 85)
        lblLastName.Location = New Point(314, 215)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(60, 15)
        lblLastName.TabIndex = 6
        lblLastName.Text = "Last name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstName.Location = New Point(24, 235)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(270, 24)
        txtFirstName.TabIndex = 5
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblFirstName.ForeColor = Color.FromArgb(51, 65, 85)
        lblFirstName.Location = New Point(24, 215)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(62, 15)
        lblFirstName.TabIndex = 4
        lblFirstName.Text = "First name"
        ' 
        ' txtStudentNo
        ' 
        txtStudentNo.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtStudentNo.BorderStyle = BorderStyle.FixedSingle
        txtStudentNo.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentNo.Location = New Point(24, 155)
        txtStudentNo.Name = "txtStudentNo"
        txtStudentNo.Size = New Size(580, 24)
        txtStudentNo.TabIndex = 3
        ' 
        ' lblStudentNo
        ' 
        lblStudentNo.AutoSize = True
        lblStudentNo.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStudentNo.ForeColor = Color.FromArgb(51, 65, 85)
        lblStudentNo.Location = New Point(24, 135)
        lblStudentNo.Name = "lblStudentNo"
        lblStudentNo.Size = New Size(92, 15)
        lblStudentNo.TabIndex = 2
        lblStudentNo.Text = "Student number"
        ' 
        ' lblBadge01
        ' 
        lblBadge01.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge01.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge01.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge01.Location = New Point(24, 90)
        lblBadge01.Name = "lblBadge01"
        lblBadge01.Size = New Size(26, 24)
        lblBadge01.TabIndex = 1
        lblBadge01.Text = "01"
        lblBadge01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec01
        ' 
        lblSec01.AutoSize = True
        lblSec01.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSec01.ForeColor = Color.FromArgb(15, 23, 42)
        lblSec01.Location = New Point(58, 92)
        lblSec01.Name = "lblSec01"
        lblSec01.Size = New Size(149, 20)
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
        pnlHeader.Size = New Size(924, 85)
        pnlHeader.TabIndex = 0
        ' 
        ' lblTermBadge
        ' 
        lblTermBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTermBadge.BackColor = Color.FromArgb(238, 242, 255)
        lblTermBadge.BorderStyle = BorderStyle.FixedSingle
        lblTermBadge.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblTermBadge.ForeColor = Color.FromArgb(49, 46, 129)
        lblTermBadge.Location = New Point(744, 25)
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
        lblSubHeader.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubHeader.Location = New Point(0, 58)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(260, 17)
        lblSubHeader.TabIndex = 2
        lblSubHeader.Text = "Add student details and set up their account."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 20)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(307, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Create student account"
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
        lblBreadcrumb.Text = "Students  /  New student"
        ' 
        ' CreateStudentForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 850)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1100, 750)
        Name = "CreateStudentForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Create Student Account"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlNextInfoCard.ResumeLayout(False)
        pnlNextInfoCard.PerformLayout()
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
    Friend WithEvents pnlNextInfoCard As Panel
    Friend WithEvents lblNextIcon As Label
    Friend WithEvents lblNextTitle As Label
    Friend WithEvents lblStepNum1 As Label
    Friend WithEvents lblStepDesc1 As Label
    Friend WithEvents lblStepNum2 As Label
    Friend WithEvents lblStepDesc2 As Label
    Friend WithEvents lblStepNum3 As Label
    Friend WithEvents lblStepDesc3 As Label

End Class
