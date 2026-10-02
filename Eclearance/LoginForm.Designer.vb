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
        pnlHeroDivider = New Panel()
        lblHeroTitle = New Label()
        picSchoolLogo = New PictureBox()
        pnlRightLogin = New Panel()
        pnlLoginCard = New Panel()
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
        pnlLeftHero.BackColor = Color.FromArgb(CByte(11), CByte(44), CByte(99))
        pnlLeftHero.Controls.Add(pnlHeroDivider)
        pnlLeftHero.Controls.Add(lblHeroTitle)
        pnlLeftHero.Controls.Add(picSchoolLogo)
        pnlLeftHero.Dock = DockStyle.Left
        pnlLeftHero.Location = New Point(0, 0)
        pnlLeftHero.Name = "pnlLeftHero"
        pnlLeftHero.Padding = New Padding(50)
        pnlLeftHero.Size = New Size(430, 650)
        pnlLeftHero.TabIndex = 0
        ' 
        ' pnlHeroDivider
        ' 
        pnlHeroDivider.BackColor = Color.FromArgb(CByte(30), CByte(96), CByte(198))
        pnlHeroDivider.Location = New Point(50, 360)
        pnlHeroDivider.Name = "pnlHeroDivider"
        pnlHeroDivider.Size = New Size(60, 4)
        pnlHeroDivider.TabIndex = 3
        ' 
        ' lblHeroTitle
        ' 
        lblHeroTitle.AutoSize = True
        lblHeroTitle.Font = New Font("Segoe UI", 26F, FontStyle.Bold)
        lblHeroTitle.ForeColor = Color.White
        lblHeroTitle.Location = New Point(50, 285)
        lblHeroTitle.Name = "lblHeroTitle"
        lblHeroTitle.Size = New Size(300, 47)
        lblHeroTitle.TabIndex = 1
        lblHeroTitle.Text = "EClearance"        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Location = New Point(50, 186)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(80, 80)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' pnlRightLogin
        ' 
        pnlRightLogin.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
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
        ' btnSignIn
        ' 
        btnSignIn.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnSignIn.Cursor = Cursors.Hand
        btnSignIn.FlatAppearance.BorderSize = 0
        btnSignIn.FlatStyle = FlatStyle.Flat
        btnSignIn.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold)
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
        chkShowPassword.Font = New Font("Segoe UI", 9F)
        chkShowPassword.ForeColor = Color.FromArgb(CByte(71), CByte(85), CByte(105))
        chkShowPassword.Location = New Point(40, 305)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 6
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        txtPassword.Location = New Point(40, 258)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(370, 27)
        txtPassword.TabIndex = 5
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblPassword.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblPassword.Location = New Point(37, 233)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(66, 17)
        lblPassword.TabIndex = 4
        lblPassword.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 11F)
        txtUsername.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        txtUsername.Location = New Point(40, 178)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(370, 27)
        txtUsername.TabIndex = 3
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        lblUsername.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        lblUsername.Location = New Point(37, 153)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(69, 17)
        lblUsername.TabIndex = 2
        lblUsername.Text = "Username"
        ' 
        ' lblWelcomeSub
        ' 
        lblWelcomeSub.AutoSize = True
        lblWelcomeSub.Font = New Font("Segoe UI", 10F)
        lblWelcomeSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblWelcomeSub.Location = New Point(37, 85)
        lblWelcomeSub.Name = "lblWelcomeSub"
        lblWelcomeSub.Size = New Size(124, 19)
        lblWelcomeSub.TabIndex = 1
        lblWelcomeSub.Text = "Sign in to continue"
        ' 
        ' lblWelcomeTitle
        ' 
        lblWelcomeTitle.AutoSize = True
        lblWelcomeTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblWelcomeTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblWelcomeTitle.Location = New Point(35, 42)
        lblWelcomeTitle.Name = "lblWelcomeTitle"
        lblWelcomeTitle.Size = New Size(136, 37)
        lblWelcomeTitle.TabIndex = 0
        lblWelcomeTitle.Text = "Welcome"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        ClientSize = New Size(1000, 650)
        Controls.Add(pnlRightLogin)
        Controls.Add(pnlLeftHero)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(950, 650)
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EClearance - Sign in"
        pnlLeftHero.ResumeLayout(False)
        pnlLeftHero.PerformLayout()
        pnlRightLogin.ResumeLayout(False)
        pnlLoginCard.ResumeLayout(False)
        pnlLoginCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlLeftHero As Panel
    Friend WithEvents picSchoolLogo As PictureBox
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

End Class
