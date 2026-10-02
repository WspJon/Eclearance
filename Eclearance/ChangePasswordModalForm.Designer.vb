<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePasswordModalForm
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
        lblHeaderSubtitle = New Label()
        lblHeaderTitle = New Label()
        pnlBody = New Panel()
        btnCancel = New Button()
        btnSave = New Button()
        chkShowPassword = New CheckBox()
        txtConfirmPassword = New TextBox()
        lblConfirmPassword = New Label()
        txtNewPassword = New TextBox()
        lblNewPassword = New Label()
        txtCurrentPassword = New TextBox()
        lblCurrentPassword = New Label()
        pnlHeader.SuspendLayout()
        pnlBody.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lblHeaderSubtitle)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(0, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Padding = New Padding(20, 16, 20, 14)
        pnlHeader.Size = New Size(420, 70)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderSubtitle
        ' 
        lblHeaderSubtitle.AutoSize = True
        lblHeaderSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblHeaderSubtitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblHeaderSubtitle.Location = New Point(20, 40)
        lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        lblHeaderSubtitle.Size = New Size(305, 15)
        lblHeaderSubtitle.TabIndex = 1
        lblHeaderSubtitle.Text = "Enter your current password and choose a new password."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 13.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblHeaderTitle.Location = New Point(18, 14)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(160, 25)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Change Password"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(248, 250, 252)
        pnlBody.Controls.Add(btnCancel)
        pnlBody.Controls.Add(btnSave)
        pnlBody.Controls.Add(chkShowPassword)
        pnlBody.Controls.Add(txtConfirmPassword)
        pnlBody.Controls.Add(lblConfirmPassword)
        pnlBody.Controls.Add(txtNewPassword)
        pnlBody.Controls.Add(lblNewPassword)
        pnlBody.Controls.Add(txtCurrentPassword)
        pnlBody.Controls.Add(lblCurrentPassword)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 70)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(24, 20, 24, 20)
        pnlBody.Size = New Size(420, 310)
        pnlBody.TabIndex = 1
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(71, 85, 105)
        btnCancel.Location = New Point(206, 252)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(92, 34)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(28, 91, 184)
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(304, 252)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(92, 34)
        btnSave.TabIndex = 7
        btnSave.Text = "Update"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Cursor = Cursors.Hand
        chkShowPassword.Font = New Font("Segoe UI", 8.5F)
        chkShowPassword.ForeColor = Color.FromArgb(100, 116, 139)
        chkShowPassword.Location = New Point(24, 208)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(108, 19)
        chkShowPassword.TabIndex = 6
        chkShowPassword.Text = "Show password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle
        txtConfirmPassword.Font = New Font("Segoe UI", 9.5F)
        txtConfirmPassword.Location = New Point(24, 168)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(372, 24)
        txtConfirmPassword.TabIndex = 5
        txtConfirmPassword.UseSystemPasswordChar = True
        ' 
        ' lblConfirmPassword
        ' 
        lblConfirmPassword.AutoSize = True
        lblConfirmPassword.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblConfirmPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblConfirmPassword.Location = New Point(24, 149)
        lblConfirmPassword.Name = "lblConfirmPassword"
        lblConfirmPassword.Size = New Size(136, 15)
        lblConfirmPassword.TabIndex = 4
        lblConfirmPassword.Text = "Confirm New Password *"
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.BorderStyle = BorderStyle.FixedSingle
        txtNewPassword.Font = New Font("Segoe UI", 9.5F)
        txtNewPassword.Location = New Point(24, 107)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(372, 24)
        txtNewPassword.TabIndex = 3
        txtNewPassword.UseSystemPasswordChar = True
        ' 
        ' lblNewPassword
        ' 
        lblNewPassword.AutoSize = True
        lblNewPassword.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblNewPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblNewPassword.Location = New Point(24, 88)
        lblNewPassword.Name = "lblNewPassword"
        lblNewPassword.Size = New Size(92, 15)
        lblNewPassword.TabIndex = 2
        lblNewPassword.Text = "New Password *"
        ' 
        ' txtCurrentPassword
        ' 
        txtCurrentPassword.BorderStyle = BorderStyle.FixedSingle
        txtCurrentPassword.Font = New Font("Segoe UI", 9.5F)
        txtCurrentPassword.Location = New Point(24, 46)
        txtCurrentPassword.Name = "txtCurrentPassword"
        txtCurrentPassword.Size = New Size(372, 24)
        txtCurrentPassword.TabIndex = 1
        txtCurrentPassword.UseSystemPasswordChar = True
        ' 
        ' lblCurrentPassword
        ' 
        lblCurrentPassword.AutoSize = True
        lblCurrentPassword.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblCurrentPassword.ForeColor = Color.FromArgb(51, 65, 85)
        lblCurrentPassword.Location = New Point(24, 27)
        lblCurrentPassword.Name = "lblCurrentPassword"
        lblCurrentPassword.Size = New Size(107, 15)
        lblCurrentPassword.TabIndex = 0
        lblCurrentPassword.Text = "Current Password *"
        ' 
        ' ChangePasswordModalForm
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(420, 380)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ChangePasswordModalForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Change Password"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        pnlBody.ResumeLayout(False)
        pnlBody.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSubtitle As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents lblCurrentPassword As Label
    Friend WithEvents txtCurrentPassword As TextBox
    Friend WithEvents lblNewPassword As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
