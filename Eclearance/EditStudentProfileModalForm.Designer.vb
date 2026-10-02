<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStudentProfileModalForm
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
        txtEmergencyContactNo = New TextBox()
        lblEmergencyContactNo = New Label()
        cmbRelationship = New ComboBox()
        lblRelationship = New Label()
        txtEmergencyContactName = New TextBox()
        lblEmergencyContactName = New Label()
        cmbCivilStatus = New ComboBox()
        lblCivilStatus = New Label()
        txtAddress = New TextBox()
        lblAddress = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtContactNo = New TextBox()
        lblContactNo = New Label()
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
        pnlHeader.Padding = New Padding(20, 14, 20, 12)
        pnlHeader.Size = New Size(500, 68)
        pnlHeader.TabIndex = 0
        ' 
        ' lblHeaderSubtitle
        ' 
        lblHeaderSubtitle.AutoSize = True
        lblHeaderSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblHeaderSubtitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblHeaderSubtitle.Location = New Point(20, 38)
        lblHeaderSubtitle.Name = "lblHeaderSubtitle"
        lblHeaderSubtitle.Size = New Size(346, 15)
        lblHeaderSubtitle.TabIndex = 1
        lblHeaderSubtitle.Text = "Update your contact details, home address, and emergency contact."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI Semibold", 13.0F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 39, 74)
        lblHeaderTitle.Location = New Point(18, 12)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(207, 25)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Edit Profile Information"
        ' 
        ' pnlBody
        ' 
        pnlBody.BackColor = Color.FromArgb(248, 250, 252)
        pnlBody.Controls.Add(btnCancel)
        pnlBody.Controls.Add(btnSave)
        pnlBody.Controls.Add(txtEmergencyContactNo)
        pnlBody.Controls.Add(lblEmergencyContactNo)
        pnlBody.Controls.Add(cmbRelationship)
        pnlBody.Controls.Add(lblRelationship)
        pnlBody.Controls.Add(txtEmergencyContactName)
        pnlBody.Controls.Add(lblEmergencyContactName)
        pnlBody.Controls.Add(cmbCivilStatus)
        pnlBody.Controls.Add(lblCivilStatus)
        pnlBody.Controls.Add(txtAddress)
        pnlBody.Controls.Add(lblAddress)
        pnlBody.Controls.Add(txtEmail)
        pnlBody.Controls.Add(lblEmail)
        pnlBody.Controls.Add(txtContactNo)
        pnlBody.Controls.Add(lblContactNo)
        pnlBody.Dock = DockStyle.Fill
        pnlBody.Location = New Point(0, 68)
        pnlBody.Name = "pnlBody"
        pnlBody.Padding = New Padding(24, 16, 24, 16)
        pnlBody.Size = New Size(500, 512)
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
        btnCancel.Location = New Point(266, 456)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 36)
        btnCancel.TabIndex = 15
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
        btnSave.Location = New Point(374, 456)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(102, 36)
        btnSave.TabIndex = 14
        btnSave.Text = "Save Changes"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtEmergencyContactNo
        ' 
        txtEmergencyContactNo.BorderStyle = BorderStyle.FixedSingle
        txtEmergencyContactNo.Font = New Font("Segoe UI", 9.5F)
        txtEmergencyContactNo.Location = New Point(24, 404)
        txtEmergencyContactNo.MaxLength = 20
        txtEmergencyContactNo.Name = "txtEmergencyContactNo"
        txtEmergencyContactNo.Size = New Size(452, 24)
        txtEmergencyContactNo.TabIndex = 13
        ' 
        ' lblEmergencyContactNo
        ' 
        lblEmergencyContactNo.AutoSize = True
        lblEmergencyContactNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyContactNo.ForeColor = Color.FromArgb(51, 65, 85)
        lblEmergencyContactNo.Location = New Point(24, 386)
        lblEmergencyContactNo.Name = "lblEmergencyContactNo"
        lblEmergencyContactNo.Size = New Size(157, 15)
        lblEmergencyContactNo.TabIndex = 12
        lblEmergencyContactNo.Text = "Emergency Contact Number *"
        ' 
        ' cmbRelationship
        ' 
        cmbRelationship.DropDownStyle = ComboBoxStyle.DropDownList
        cmbRelationship.Font = New Font("Segoe UI", 9.5F)
        cmbRelationship.FormattingEnabled = True
        cmbRelationship.Items.AddRange(New Object() {"Mother", "Father", "Guardian", "Spouse", "Sibling", "Other"})
        cmbRelationship.Location = New Point(256, 345)
        cmbRelationship.Name = "cmbRelationship"
        cmbRelationship.Size = New Size(220, 25)
        cmbRelationship.TabIndex = 11
        ' 
        ' lblRelationship
        ' 
        lblRelationship.AutoSize = True
        lblRelationship.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblRelationship.ForeColor = Color.FromArgb(51, 65, 85)
        lblRelationship.Location = New Point(256, 327)
        lblRelationship.Name = "lblRelationship"
        lblRelationship.Size = New Size(79, 15)
        lblRelationship.TabIndex = 10
        lblRelationship.Text = "Relationship *"
        ' 
        ' txtEmergencyContactName
        ' 
        txtEmergencyContactName.BorderStyle = BorderStyle.FixedSingle
        txtEmergencyContactName.Font = New Font("Segoe UI", 9.5F)
        txtEmergencyContactName.Location = New Point(24, 346)
        txtEmergencyContactName.MaxLength = 100
        txtEmergencyContactName.Name = "txtEmergencyContactName"
        txtEmergencyContactName.Size = New Size(220, 24)
        txtEmergencyContactName.TabIndex = 9
        ' 
        ' lblEmergencyContactName
        ' 
        lblEmergencyContactName.AutoSize = True
        lblEmergencyContactName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmergencyContactName.ForeColor = Color.FromArgb(51, 65, 85)
        lblEmergencyContactName.Location = New Point(24, 327)
        lblEmergencyContactName.Name = "lblEmergencyContactName"
        lblEmergencyContactName.Size = New Size(150, 15)
        lblEmergencyContactName.TabIndex = 8
        lblEmergencyContactName.Text = "Emergency Contact Person *"
        ' 
        ' cmbCivilStatus
        ' 
        cmbCivilStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCivilStatus.Font = New Font("Segoe UI", 9.5F)
        cmbCivilStatus.FormattingEnabled = True
        cmbCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widowed"})
        cmbCivilStatus.Location = New Point(24, 286)
        cmbCivilStatus.Name = "cmbCivilStatus"
        cmbCivilStatus.Size = New Size(452, 25)
        cmbCivilStatus.TabIndex = 7
        ' 
        ' lblCivilStatus
        ' 
        lblCivilStatus.AutoSize = True
        lblCivilStatus.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblCivilStatus.ForeColor = Color.FromArgb(51, 65, 85)
        lblCivilStatus.Location = New Point(24, 268)
        lblCivilStatus.Name = "lblCivilStatus"
        lblCivilStatus.Size = New Size(73, 15)
        lblCivilStatus.TabIndex = 6
        lblCivilStatus.Text = "Civil Status *"
        ' 
        ' txtAddress
        ' 
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI", 9.5F)
        txtAddress.Location = New Point(24, 185)
        txtAddress.MaxLength = 255
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.ScrollBars = ScrollBars.Vertical
        txtAddress.Size = New Size(452, 65)
        txtAddress.TabIndex = 5
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblAddress.ForeColor = Color.FromArgb(51, 65, 85)
        lblAddress.Location = New Point(24, 166)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(99, 15)
        lblAddress.TabIndex = 4
        lblAddress.Text = "Current Address *"
        ' 
        ' txtEmail
        ' 
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI", 9.5F)
        txtEmail.Location = New Point(24, 126)
        txtEmail.MaxLength = 100
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(452, 24)
        txtEmail.TabIndex = 3
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblEmail.ForeColor = Color.FromArgb(51, 65, 85)
        lblEmail.Location = New Point(24, 107)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(89, 15)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email Address *"
        ' 
        ' txtContactNo
        ' 
        txtContactNo.BorderStyle = BorderStyle.FixedSingle
        txtContactNo.Font = New Font("Segoe UI", 9.5F)
        txtContactNo.Location = New Point(24, 67)
        txtContactNo.MaxLength = 20
        txtContactNo.Name = "txtContactNo"
        txtContactNo.Size = New Size(452, 24)
        txtContactNo.TabIndex = 1
        ' 
        ' lblContactNo
        ' 
        lblContactNo.AutoSize = True
        lblContactNo.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblContactNo.ForeColor = Color.FromArgb(51, 65, 85)
        lblContactNo.Location = New Point(24, 48)
        lblContactNo.Name = "lblContactNo"
        lblContactNo.Size = New Size(101, 15)
        lblContactNo.TabIndex = 0
        lblContactNo.Text = "Contact Number *"
        ' 
        ' EditStudentProfileModalForm
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(500, 580)
        Controls.Add(pnlBody)
        Controls.Add(pnlHeader)
        Font = New Font("Segoe UI", 9.0F)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "EditStudentProfileModalForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Profile"
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
    Friend WithEvents lblContactNo As Label
    Friend WithEvents txtContactNo As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCivilStatus As Label
    Friend WithEvents cmbCivilStatus As ComboBox
    Friend WithEvents lblEmergencyContactName As Label
    Friend WithEvents txtEmergencyContactName As TextBox
    Friend WithEvents lblRelationship As Label
    Friend WithEvents cmbRelationship As ComboBox
    Friend WithEvents lblEmergencyContactNo As Label
    Friend WithEvents txtEmergencyContactNo As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
