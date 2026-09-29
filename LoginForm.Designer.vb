<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlLeftHero = New Panel()
        lblHeroTagline = New Label()
        pnlHeroDivider = New Panel()
        lblHeroSubtitle = New Label()
        lblHeroTitle = New Label()
        lblHeroLogo = New Label()
        pnlRightLogin = New Panel()
        pnlLoginCard = New Panel()
        lblRolesHelp = New Label()
        btnSignIn = New Button()
        chkShowPassword = New CheckBox()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtUsername = New TextBox()
        lblUsername = New Label()
        lblWelcomeSub = New Label()
        lblWelcomeTitle = New Label()
        pnlLeftHero.SuspendLayout()
        pnlRightLogin.SuspendLayout()
        pnlLoginCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlLeftHero
        ' 
        pnlLeftHero.BackColor = Color.FromArgb(11, 44, 99)
        pnlLeftHero.Controls.Add(lblHeroTagline)
        pnlLeftHero.Controls.Add(pnlHeroDivider)
        pnlLeftHero.Controls.Add(lblHeroSubtitle)
        pnlLeftHero.Controls.Add(lblHeroTitle)
        pnlLeftHero.Controls.Add(lblHeroLogo)
        pnlLeftHero.Dock = DockStyle.Left
        pnlLeftHero.Location = New Point(0, 0)
        pnlLeftHero.Name = "pnlLeftHero"
        pnlLeftHero.Padding = New Padding(50)
        pnlLeftHero.Size = New Size(430, 650)
        pnlLeftHero.TabIndex = 0
        ' 
        ' lblHeroTagline
        ' 
        lblHeroTagline.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblHeroTagline.AutoSize = True
        lblHeroTagline.Font = New Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeroTagline.ForeColor = Color.FromArgb(120, 155, 205)
        lblHeroTagline.Location = New Point(50, 580)
        lblHeroTagline.Name = "lblHeroTagline"
        lblHeroTagline.Size = New Size(140, 26)
        lblHeroTagline.TabIndex = 4
        lblHeroTagline.Text = "CLEAR RECORDS" & vbCrLf & "BRIGHTER TOMORROWS"
        ' 
        ' pnlHeroDivider
        ' 
        pnlHeroDivider.BackColor = Color.FromArgb(30, 96, 198)
        pnlHeroDivider.Location = New Point(50, 360)
        pnlHeroDivider.Name = "pnlHeroDivider"
        pnlHeroDivider.Size = New Size(60, 4)
        pnlHeroDivider.TabIndex = 3
        ' 
        ' lblHeroSubtitle
        ' 
        lblHeroSubtitle.AutoSize = True
        lblHeroSubtitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeroSubtitle.ForeColor = Color.FromArgb(180, 205, 237)
        lblHeroSubtitle.Location = New Point(50, 320)
        lblHeroSubtitle.Name = "lblHeroSubtitle"
        lblHeroSubtitle.Size = New Size(223, 21)
        lblHeroSubtitle.TabIndex = 2
        lblHeroSubtitle.Text = "Your clearance, in one place."
        ' 
        ' lblHeroTitle
        ' 
        lblHeroTitle.AutoSize = True
        lblHeroTitle.Font = New Font("Segoe UI", 26.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeroTitle.ForeColor = Color.White
        lblHeroTitle.Location = New Point(46, 265)
        lblHeroTitle.Name = "lblHeroTitle"
        lblHeroTitle.Size = New Size(307, 47)
        lblHeroTitle.TabIndex = 1
        lblHeroTitle.Text = "School Clearance"
        ' 
        ' lblHeroLogo
        ' 
        lblHeroLogo.AutoSize = True
        lblHeroLogo.Font = New Font("Segoe UI Emoji", 48.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblHeroLogo.ForeColor = Color.White
        lblHeroLogo.Location = New Point(45, 170)
        lblHeroLogo.Name = "lblHeroLogo"
        lblHeroLogo.Size = New Size(99, 86)
        lblHeroLogo.TabIndex = 0
        lblHeroLogo.Text = "🎓"
        ' 
        ' pnlRightLogin
        ' 
        pnlRightLogin.BackColor = Color.FromArgb(244, 247, 251)
        pnlRightLogin.Controls.Add(pnlLoginCard)
        pnlRightLogin.Dock = DockStyle.Fill
        pnlRightLogin.Location = New Point(430, 0)
        pnlRightLogin.Name = "pnlRightLogin"
        pnlRightLogin.Size = New Size(570, 650)
        pnlRightLogin.TabIndex = 1
        ' 
        ' pnlLoginCard
        ' 
        pnlLoginCard.Anchor = AnchorStyles.None
        pnlLoginCard.BackColor = Color.White
        pnlLoginCard.BorderStyle = BorderStyle.FixedSingle
        pnlLoginCard.Controls.Add(lblRolesHelp)
        pnlLoginCard.Controls.Add(btnSignIn)
        pnlLoginCard.Controls.Add(chkShowPassword)
        pnlLoginCard.Controls.Add(txtPassword)
        pnlLoginCard.Controls.Add(lblPassword)
        pnlLoginCard.Controls.Add(txtUsername)
        pnlLoginCard.Controls.Add(lblUsername)
        pnlLoginCard.Controls.Add(lblWelcomeSub)
        pnlLoginCard.Controls.Add(lblWelcomeTitle)
        pnlLoginCard.Location = New Point(60, 75)
        pnlLoginCard.Name = "pnlLoginCard"
        pnlLoginCard.Padding = New Padding(40)
        pnlLoginCard.Size = New Size(450, 500)
        pnlLoginCard.TabIndex = 0
        ' 
        ' lblRolesHelp
        ' 
        lblRolesHelp.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblRolesHelp.ForeColor = Color.FromArgb(100, 116, 139)
        lblRolesHelp.Location = New Point(40, 435)
        lblRolesHelp.Name = "lblRolesHelp"
        lblRolesHelp.Size = New Size(370, 25)
        lblRolesHelp.TabIndex = 8
        lblRolesHelp.Text = "Student  •  Staff  •  Administrator"
        lblRolesHelp.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.FromArgb(11, 99, 229)
        btnSignIn.Cursor = Cursors.Hand
        btnSignIn.FlatAppearance.BorderSize = 0
        btnSignIn.FlatStyle = FlatStyle.Flat
        btnSignIn.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnSignIn.ForeColor = Color.White
        btnSignIn.Location = New Point(40, 355)
        btnSignIn.Name = "btnSignIn"
        btnSignIn.Size = New Size(370, 46)
        btnSignIn.TabIndex = 7
        btnSignIn.Text = "Sign in"
        btnSignIn.UseVisualStyleBackColor = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        chkShowPassword.ForeColor = Color.FromArgb(71, 85, 105)
        chkShowPassword.Location = New Point(40, 305)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(107, 19)
        chkShowPassword.TabIndex = 6
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.ForeColor = Color.FromArgb(15, 23, 42)
        txtPassword.Location = New Point(40, 258)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(370, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblPassword.Location = New Point(37, 233)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(66, 17)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.FromArgb(15, 23, 42)
        txtUsername.Location = New Point(40, 178)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(370, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.FromArgb(51, 65, 85)
        lblUsername.Location = New Point(37, 153)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 17)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lblWelcomeSub
        ' 
        lblWelcomeSub.AutoSize = True
        lblWelcomeSub.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblWelcomeSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblWelcomeSub.Location = New Point(37, 85)
        lblWelcomeSub.Name = "lblWelcomeSub"
        lblWelcomeSub.Size = New Size(119, 19)
        lblWelcomeSub.TabIndex = 1
        lblWelcomeSub.Text = "Sign in to continue"
        ' 
        ' lblWelcomeTitle
        ' 
        lblWelcomeTitle.AutoSize = True
        lblWelcomeTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblWelcomeTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblWelcomeTitle.Location = New Point(35, 42)
        lblWelcomeTitle.Name = "lblWelcomeTitle"
        lblWelcomeTitle.Size = New Size(207, 37)
        lblWelcomeTitle.TabIndex = 0
        lblWelcomeTitle.Text = "Welcome back"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1000, 650)
        Controls.Add(pnlRightLogin)
        Controls.Add(pnlLeftHero)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(950, 650)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Sign in"
        pnlLeftHero.ResumeLayout(False)
        pnlLeftHero.PerformLayout()
        pnlRightLogin.ResumeLayout(False)
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeftHero As Panel
    Friend WithEvents lblHeroLogo As Label
    Friend WithEvents lblHeroTitle As Label
    Friend WithEvents lblHeroSubtitle As Label
    Friend WithEvents pnlHeroDivider As Panel
    Friend WithEvents lblHeroTagline As Label
    Friend WithEvents pnlRightLogin As Panel
    Friend WithEvents pnlLoginCard As Panel
    Friend WithEvents lblWelcomeTitle As Label
    Friend WithEvents lblWelcomeSub As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnSignIn As Button
    Friend WithEvents lblRolesHelp As Label

End Class
