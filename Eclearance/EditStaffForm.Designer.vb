<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStaffForm
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
        lblFullName = New Label()
        txtFullName = New TextBox()
        lblAssignedOffice = New Label()
        cmbAssignedOffice = New ComboBox()
        lblBadge02 = New Label()
        lblSec02 = New Label()
        lblUsername = New Label()
        txtUsername = New TextBox()
        pnlOfficeHint = New Panel()
        lblOfficeHintIcon = New Label()
        lblOfficeHintTitle = New Label()
        lblOfficeHintText = New Label()
        btnCancel = New Button()
        btnSaveChanges = New Button()
        pnlCard.SuspendLayout()
        pnlOfficeHint.SuspendLayout()
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
        pnlCard.Controls.Add(lblFullName)
        pnlCard.Controls.Add(txtFullName)
        pnlCard.Controls.Add(lblAssignedOffice)
        pnlCard.Controls.Add(cmbAssignedOffice)
        pnlCard.Controls.Add(lblBadge02)
        pnlCard.Controls.Add(lblSec02)
        pnlCard.Controls.Add(lblUsername)
        pnlCard.Controls.Add(txtUsername)
        pnlCard.Controls.Add(pnlOfficeHint)
        pnlCard.Controls.Add(btnCancel)
        pnlCard.Controls.Add(btnSaveChanges)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Name = "pnlCard"
        pnlCard.Size = New Size(580, 470)
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
        lblModalTitle.Size = New Size(174, 28)
        lblModalTitle.TabIndex = 1
        lblModalTitle.Text = "Edit staff account"
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
        lblSec01.Size = New Size(126, 20)
        lblSec01.TabIndex = 3
        lblSec01.Text = "Staff information"
        ' 
        ' lblFullName
        ' 
        lblFullName.AutoSize = True
        lblFullName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblFullName.ForeColor = Color.FromArgb(51, 65, 85)
        lblFullName.Location = New Point(24, 104)
        lblFullName.Name = "lblFullName"
        lblFullName.Size = New Size(59, 15)
        lblFullName.TabIndex = 4
        lblFullName.Text = "Full name"
        ' 
        ' txtFullName
        ' 
        txtFullName.BorderStyle = BorderStyle.FixedSingle
        txtFullName.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtFullName.ForeColor = Color.FromArgb(15, 23, 42)
        txtFullName.Location = New Point(24, 124)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(528, 24)
        txtFullName.TabIndex = 5
        ' 
        ' lblAssignedOffice
        ' 
        lblAssignedOffice.AutoSize = True
        lblAssignedOffice.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAssignedOffice.ForeColor = Color.FromArgb(51, 65, 85)
        lblAssignedOffice.Location = New Point(24, 160)
        lblAssignedOffice.Name = "lblAssignedOffice"
        lblAssignedOffice.Size = New Size(89, 15)
        lblAssignedOffice.TabIndex = 6
        lblAssignedOffice.Text = "Assigned office"
        ' 
        ' cmbAssignedOffice
        ' 
        cmbAssignedOffice.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAssignedOffice.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbAssignedOffice.FormattingEnabled = True
        cmbAssignedOffice.Location = New Point(24, 180)
        cmbAssignedOffice.Name = "cmbAssignedOffice"
        cmbAssignedOffice.Size = New Size(528, 25)
        cmbAssignedOffice.TabIndex = 7
        ' 
        ' lblBadge02
        ' 
        lblBadge02.BackColor = Color.FromArgb(219, 234, 254)
        lblBadge02.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblBadge02.ForeColor = Color.FromArgb(29, 78, 216)
        lblBadge02.Location = New Point(24, 224)
        lblBadge02.Name = "lblBadge02"
        lblBadge02.Size = New Size(26, 24)
        lblBadge02.TabIndex = 8
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
        lblSec02.Size = New Size(117, 20)
        lblSec02.TabIndex = 9
        lblSec02.Text = "Account details"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUsername.ForeColor = Color.FromArgb(51, 65, 85)
        lblUsername.Location = New Point(24, 256)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(60, 15)
        lblUsername.TabIndex = 10
        lblUsername.Text = "Username"
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.ForeColor = Color.FromArgb(15, 23, 42)
        txtUsername.Location = New Point(24, 276)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(528, 24)
        txtUsername.TabIndex = 11
        ' 
        ' pnlOfficeHint
        ' 
        pnlOfficeHint.BackColor = Color.FromArgb(248, 250, 252)
        pnlOfficeHint.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeHint.Controls.Add(lblOfficeHintText)
        pnlOfficeHint.Controls.Add(lblOfficeHintTitle)
        pnlOfficeHint.Controls.Add(lblOfficeHintIcon)
        pnlOfficeHint.Location = New Point(24, 318)
        pnlOfficeHint.Name = "pnlOfficeHint"
        pnlOfficeHint.Size = New Size(528, 56)
        pnlOfficeHint.TabIndex = 12
        ' 
        ' lblOfficeHintIcon
        ' 
        lblOfficeHintIcon.AutoSize = True
        lblOfficeHintIcon.Font = New Font("Segoe UI Emoji", 13.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeHintIcon.Location = New Point(12, 14)
        lblOfficeHintIcon.Name = "lblOfficeHintIcon"
        lblOfficeHintIcon.Size = New Size(28, 24)
        lblOfficeHintIcon.TabIndex = 0
        lblOfficeHintIcon.Text = "🏛"
        ' 
        ' lblOfficeHintTitle
        ' 
        lblOfficeHintTitle.AutoSize = True
        lblOfficeHintTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeHintTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblOfficeHintTitle.Location = New Point(44, 9)
        lblOfficeHintTitle.Name = "lblOfficeHintTitle"
        lblOfficeHintTitle.Size = New Size(147, 15)
        lblOfficeHintTitle.TabIndex = 1
        lblOfficeHintTitle.Text = "Assigned clearance office"
        ' 
        ' lblOfficeHintText
        ' 
        lblOfficeHintText.AutoSize = True
        lblOfficeHintText.Font = New Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeHintText.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeHintText.Location = New Point(44, 28)
        lblOfficeHintText.Name = "lblOfficeHintText"
        lblOfficeHintText.Size = New Size(428, 13)
        lblOfficeHintText.TabIndex = 2
        lblOfficeHintText.Text = "Updating the assigned office redirects future clearance submissions to this staff member."
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.FromArgb(71, 85, 105)
        btnCancel.Location = New Point(24, 396)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(120, 38)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.BackColor = Color.FromArgb(11, 99, 229)
        btnSaveChanges.Cursor = Cursors.Hand
        btnSaveChanges.FlatAppearance.BorderSize = 0
        btnSaveChanges.FlatStyle = FlatStyle.Flat
        btnSaveChanges.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnSaveChanges.ForeColor = Color.White
        btnSaveChanges.Location = New Point(392, 396)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(160, 38)
        btnSaveChanges.TabIndex = 14
        btnSaveChanges.Text = "Save changes"
        btnSaveChanges.UseVisualStyleBackColor = False
        ' 
        ' EditStaffForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(580, 470)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditStaffForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit staff account"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlOfficeHint.ResumeLayout(False)
        pnlOfficeHint.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblModalTitle As Label
    Friend WithEvents lblBadge01 As Label
    Friend WithEvents lblSec01 As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents lblAssignedOffice As Label
    Friend WithEvents cmbAssignedOffice As ComboBox
    Friend WithEvents lblBadge02 As Label
    Friend WithEvents lblSec02 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents pnlOfficeHint As Panel
    Friend WithEvents lblOfficeHintIcon As Label
    Friend WithEvents lblOfficeHintTitle As Label
    Friend WithEvents lblOfficeHintText As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveChanges As Button

End Class
