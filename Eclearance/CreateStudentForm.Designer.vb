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
        pnlCard = New Panel()
        btnClose = New Button()
        lblModalTitle = New Label()
        lblBadge01 = New Label()
        lblSec01 = New Label()
        lblStudentNo = New Label()
        txtStudentNo = New TextBox()
        lblFirstName = New Label()
        txtFirstName = New TextBox()
        lblLastName = New Label()
        txtLastName = New TextBox()
        lblBadge02 = New Label()
        lblSec02 = New Label()
        lblCourse = New Label()
        cmbCourse = New ComboBox()
        lblYearLevel = New Label()
        cmbYearLevel = New ComboBox()
        chkNSTP = New CheckBox()
        lblBadge03 = New Label()
        lblSec03 = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        lblPassword = New Label()
        txtPassword = New TextBox()
        lblPwdHelp = New Label()
        btnClearForm = New Button()
        btnCreateAccount = New Button()
        pnlCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.BorderStyle = BorderStyle.FixedSingle
        pnlCard.Controls.Add(btnClose)
        pnlCard.Controls.Add(lblModalTitle)
        pnlCard.Controls.Add(lblBadge01)
        pnlCard.Controls.Add(lblSec01)
        pnlCard.Controls.Add(lblStudentNo)
        pnlCard.Controls.Add(txtStudentNo)
        pnlCard.Controls.Add(lblFirstName)
        pnlCard.Controls.Add(txtFirstName)
        pnlCard.Controls.Add(lblLastName)
        pnlCard.Controls.Add(txtLastName)
        pnlCard.Controls.Add(lblBadge02)
        pnlCard.Controls.Add(lblSec02)
        pnlCard.Controls.Add(lblCourse)
        pnlCard.Controls.Add(cmbCourse)
        pnlCard.Controls.Add(lblYearLevel)
        pnlCard.Controls.Add(cmbYearLevel)
        pnlCard.Controls.Add(chkNSTP)
        pnlCard.Controls.Add(lblBadge03)
        pnlCard.Controls.Add(lblSec03)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtUsername)
        pnlCard.Controls.Add(lblPassword)
        pnlCard.Controls.Add(txtPassword)
        pnlCard.Controls.Add(lblPwdHelp)
        pnlCard.Controls.Add(btnClearForm)
        pnlCard.Controls.Add(btnCreateAccount)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(580, 565)
        pnlCard.TabIndex = 0
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
        btnClose.Location = New Point(528, 16)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(34, 34)
        btnClose.TabIndex = 0
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblModalTitle
        ' 
        lblModalTitle.AutoSize = True
        lblModalTitle.Font = New Font("Segoe UI", 14.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblModalTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblModalTitle.Location = New Point(24, 20)
        lblModalTitle.Name = "lblModalTitle"
        lblModalTitle.Size = New Size(225, 28)
        lblModalTitle.TabIndex = 1
        lblModalTitle.Text = "Create student account"
        ' 
        ' lblBadge01
        ' 
        lblBadge01.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge01.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge01.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge01.Location = New Point(24, 68)
        lblBadge01.Name = "lblBadge01"
        lblBadge01.Size = New Size(26, 24)
        lblBadge01.TabIndex = 2
        lblBadge01.Text = "01"
        lblBadge01.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec01
        ' 
        lblSec01.AutoSize = True
        lblSec01.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSec01.ForeColor = Color.FromArgb(15, 23, 42)
        lblSec01.Location = New Point(58, 70)
        lblSec01.Name = "lblSec01"
        lblSec01.Size = New Size(149, 20)
        lblSec01.TabIndex = 3
        lblSec01.Text = "Student information"
        ' 
        ' lblStudentNo
        ' 
        lblStudentNo.AutoSize = True
        lblStudentNo.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStudentNo.ForeColor = Color.FromArgb(51, 65, 85)
        lblStudentNo.Location = New Point(24, 102)
        lblStudentNo.Name = "lblStudentNo"
        lblStudentNo.Size = New Size(92, 15)
        lblStudentNo.TabIndex = 4
        lblStudentNo.Text = "Student number"
        ' 
        ' txtStudentNo
        ' 
        txtStudentNo.BorderStyle = BorderStyle.FixedSingle
        txtStudentNo.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtStudentNo.ForeColor = Color.FromArgb(15, 23, 42)
        txtStudentNo.Location = New Point(24, 122)
        txtStudentNo.Name = "txtStudentNo"
        txtStudentNo.Size = New Size(528, 24)
        txtStudentNo.TabIndex = 5
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblFirstName.ForeColor = Color.FromArgb(51, 65, 85)
        lblFirstName.Location = New Point(24, 160)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(62, 15)
        lblFirstName.TabIndex = 6
        lblFirstName.Text = "First name"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.BorderStyle = BorderStyle.FixedSingle
        txtFirstName.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtFirstName.ForeColor = Color.FromArgb(15, 23, 42)
        txtFirstName.Location = New Point(24, 180)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(254, 24)
        txtFirstName.TabIndex = 7
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblLastName.ForeColor = Color.FromArgb(51, 65, 85)
        lblLastName.Location = New Point(298, 160)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(60, 15)
        lblLastName.TabIndex = 8
        lblLastName.Text = "Last name"
        ' 
        ' txtLastName
        ' 
        txtLastName.BorderStyle = BorderStyle.FixedSingle
        txtLastName.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtLastName.ForeColor = Color.FromArgb(15, 23, 42)
        txtLastName.Location = New Point(298, 180)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(254, 24)
        txtLastName.TabIndex = 9
        ' 
        ' lblBadge02
        ' 
        lblBadge02.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge02.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge02.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge02.Location = New Point(24, 224)
        lblBadge02.Name = "lblBadge02"
        lblBadge02.Size = New Size(26, 24)
        lblBadge02.TabIndex = 10
        lblBadge02.Text = "02"
        lblBadge02.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec02
        ' 
        lblSec02.AutoSize = True
        lblSec02.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSec02.ForeColor = Color.FromArgb(15, 23, 42)
        lblSec02.Location = New Point(58, 226)
        lblSec02.Name = "lblSec02"
        lblSec02.Size = New Size(128, 20)
        lblSec02.TabIndex = 11
        lblSec02.Text = "Academic details"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblCourse.ForeColor = Color.FromArgb(51, 65, 85)
        lblCourse.Location = New Point(24, 258)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(44, 15)
        lblCourse.TabIndex = 12
        lblCourse.Text = "Course"
        ' 
        ' cmbCourse
        ' 
        cmbCourse.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourse.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(24, 278)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(254, 25)
        cmbCourse.TabIndex = 13
        ' 
        ' lblYearLevel
        ' 
        lblYearLevel.AutoSize = True
        lblYearLevel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblYearLevel.ForeColor = Color.FromArgb(51, 65, 85)
        lblYearLevel.Location = New Point(298, 258)
        lblYearLevel.Name = "lblYearLevel"
        lblYearLevel.Size = New Size(57, 15)
        lblYearLevel.TabIndex = 14
        lblYearLevel.Text = "Year level"
        ' 
        ' cmbYearLevel
        ' 
        cmbYearLevel.DropDownStyle = ComboBoxStyle.DropDownList
        cmbYearLevel.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbYearLevel.FormattingEnabled = True
        cmbYearLevel.Location = New Point(298, 278)
        cmbYearLevel.Name = "cmbYearLevel"
        cmbYearLevel.Size = New Size(254, 25)
        cmbYearLevel.TabIndex = 15
        ' 
        ' chkNSTP
        ' 
        chkNSTP.AutoSize = True
        chkNSTP.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        chkNSTP.ForeColor = Color.FromArgb(51, 65, 85)
        chkNSTP.Location = New Point(24, 318)
        chkNSTP.Name = "chkNSTP"
        chkNSTP.Size = New Size(117, 19)
        chkNSTP.TabIndex = 16
        chkNSTP.Text = "Enrolled in NSTP"
        chkNSTP.UseVisualStyleBackColor = True
        ' 
        ' lblBadge03
        ' 
        lblBadge03.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge03.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge03.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge03.Location = New Point(24, 356)
        lblBadge03.Name = "lblBadge03"
        lblBadge03.Size = New Size(26, 24)
        lblBadge03.TabIndex = 17
        lblBadge03.Text = "03"
        lblBadge03.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblSec03
        ' 
        lblSec03.AutoSize = True
        lblSec03.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSec03.ForeColor = Color.FromArgb(15, 23, 42)
        lblSec03.Location = New Point(58, 358)
        lblSec03.Name = "lblSec03"
        lblSec03.Size = New Size(117, 20)
        lblSec03.TabIndex = 18
        lblSec03.Text = "Account details"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.FromArgb(51, 65, 85)
        lblUsername.Location = New Point(24, 390)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 19
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.FromArgb(15, 23, 42)
        txtUsername.Location = New Point(24, 410)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(254, 24)
        txtUsername.TabIndex = 20
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblPassword.Location = New Point(298, 390)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(57, 15)
        lblPassword.TabIndex = 21
        lblPassword.Text = "Password"
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.FromArgb(15, 23, 42)
        txtPassword.Location = New Point(298, 410)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(254, 24)
        txtPassword.TabIndex = 22
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPwdHelp
        ' 
        lblPwdHelp.AutoSize = True
        lblPwdHelp.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblPwdHelp.ForeColor = Color.FromArgb(100, 116, 139)
        lblPwdHelp.Location = New Point(298, 440)
        lblPwdHelp.Name = "lblPwdHelp"
        lblPwdHelp.Size = New Size(116, 13)
        lblPwdHelp.TabIndex = 23
        lblPwdHelp.Text = ""
        lblPwdHelp.Visible = False
        ' 
        ' btnClearForm
        ' 
        btnClearForm.BackColor = Color.White
        btnClearForm.Cursor = Cursors.Hand
        btnClearForm.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnClearForm.FlatStyle = FlatStyle.Flat
        btnClearForm.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnClearForm.ForeColor = Color.FromArgb(71, 85, 105)
        btnClearForm.Location = New Point(24, 500)
        btnClearForm.Name = "btnClearForm"
        btnClearForm.Size = New Size(120, 38)
        btnClearForm.TabIndex = 24
        btnClearForm.Text = "Clear form"
        btnClearForm.UseVisualStyleBackColor = False
        ' 
        ' btnCreateAccount
        ' 
        btnCreateAccount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCreateAccount.BackColor = Color.FromArgb(11, 99, 229)
        btnCreateAccount.Cursor = Cursors.Hand
        btnCreateAccount.FlatAppearance.BorderSize = 0
        btnCreateAccount.FlatStyle = FlatStyle.Flat
        btnCreateAccount.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnCreateAccount.ForeColor = Color.White
        btnCreateAccount.Location = New Point(402, 500)
        btnCreateAccount.Name = "btnCreateAccount"
        btnCreateAccount.Size = New Size(150, 38)
        btnCreateAccount.TabIndex = 25
        btnCreateAccount.Text = "Create account"
        btnCreateAccount.UseVisualStyleBackColor = False
        ' 
        ' CreateStudentForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(580, 565)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "CreateStudentForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Create student account"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblModalTitle As Label
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
