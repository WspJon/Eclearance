<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ManageEnrollmentModalForm
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
        pnlContainer = New Panel()
        lblAuditInfo = New Label()
        lblBasis = New Label()
        cmbVerificationBasis = New ComboBox()
        btnCancel = New Button()
        btnSave = New Button()
        pnlNotice = New Panel()
        lblNotice = New Label()
        txtRemarks = New TextBox()
        lblRemarks = New Label()
        cmbEnrollmentStatus = New ComboBox()
        lblStatus = New Label()
        cmbAcademicTerm = New ComboBox()
        lblTerm = New Label()
        pnlStudentCard = New Panel()
        lblStudentInfoVal = New Label()
        lblStudentNameVal = New Label()
        lblModalSubtitle = New Label()
        lblModalTitle = New Label()
        pnlContainer.SuspendLayout()
        pnlNotice.SuspendLayout()
        pnlStudentCard.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlContainer
        ' 
        pnlContainer.BackColor = Color.White
        pnlContainer.Controls.Add(lblAuditInfo)
        pnlContainer.Controls.Add(lblBasis)
        pnlContainer.Controls.Add(cmbVerificationBasis)
        pnlContainer.Controls.Add(btnCancel)
        pnlContainer.Controls.Add(btnSave)
        pnlContainer.Controls.Add(pnlNotice)
        pnlContainer.Controls.Add(txtRemarks)
        pnlContainer.Controls.Add(lblRemarks)
        pnlContainer.Controls.Add(cmbEnrollmentStatus)
        pnlContainer.Controls.Add(lblStatus)
        pnlContainer.Controls.Add(cmbAcademicTerm)
        pnlContainer.Controls.Add(lblTerm)
        pnlContainer.Controls.Add(pnlStudentCard)
        pnlContainer.Controls.Add(lblModalSubtitle)
        pnlContainer.Controls.Add(lblModalTitle)
        pnlContainer.Dock = DockStyle.Fill
        pnlContainer.Location = New Point(0, 0)
        pnlContainer.Name = "pnlContainer"
        pnlContainer.Padding = New Padding(24)
        pnlContainer.Size = New Size(540, 610)
        pnlContainer.TabIndex = 0
        ' 
        ' lblAuditInfo
        ' 
        lblAuditInfo.AutoSize = True
        lblAuditInfo.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic)
        lblAuditInfo.ForeColor = Color.FromArgb(100, 116, 139)
        lblAuditInfo.Location = New Point(26, 474)
        lblAuditInfo.Name = "lblAuditInfo"
        lblAuditInfo.Size = New Size(140, 13)
        lblAuditInfo.TabIndex = 12
        lblAuditInfo.Text = "Last verified: No record yet"
        ' 
        ' lblBasis
        ' 
        lblBasis.AutoSize = True
        lblBasis.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblBasis.ForeColor = Color.FromArgb(51, 65, 85)
        lblBasis.Location = New Point(26, 260)
        lblBasis.Name = "lblBasis"
        lblBasis.Size = New Size(117, 15)
        lblBasis.TabIndex = 7
        lblBasis.Text = "Basis of Verification"
        ' 
        ' cmbVerificationBasis
        ' 
        cmbVerificationBasis.DropDownStyle = ComboBoxStyle.DropDownList
        cmbVerificationBasis.Font = New Font("Segoe UI", 9.5F)
        cmbVerificationBasis.FormattingEnabled = True
        cmbVerificationBasis.Items.AddRange(New Object() {"Official Registrar Enrollment List", "Certificate of Registration (COR)", "Assessment Form Submitted", "Student Admission Type (New/Transferee)", "Historical Term Clearance Activity", "Manual Department Verification", "No Document Available / Unestablished"})
        cmbVerificationBasis.Location = New Point(26, 280)
        cmbVerificationBasis.Name = "cmbVerificationBasis"
        cmbVerificationBasis.Size = New Size(488, 25)
        cmbVerificationBasis.TabIndex = 8
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnCancel.ForeColor = Color.FromArgb(71, 85, 105)
        btnCancel.Location = New Point(186, 505)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(108, 38)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(11, 99, 229)
        btnSave.Cursor = Cursors.Hand
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(304, 505)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(210, 38)
        btnSave.TabIndex = 13
        btnSave.Text = "Save Enrollment Record"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' pnlNotice
        ' 
        pnlNotice.BackColor = Color.FromArgb(239, 246, 255)
        pnlNotice.BorderStyle = BorderStyle.FixedSingle
        pnlNotice.Controls.Add(lblNotice)
        pnlNotice.Location = New Point(26, 405)
        pnlNotice.Name = "pnlNotice"
        pnlNotice.Padding = New Padding(10)
        pnlNotice.Size = New Size(488, 56)
        pnlNotice.TabIndex = 11
        ' 
        ' lblNotice
        ' 
        lblNotice.Dock = DockStyle.Fill
        lblNotice.Font = New Font("Segoe UI", 8.25F)
        lblNotice.ForeColor = Color.FromArgb(29, 78, 216)
        lblNotice.Location = New Point(10, 10)
        lblNotice.Name = "lblNotice"
        lblNotice.Size = New Size(466, 34)
        lblNotice.TabIndex = 0
        lblNotice.Text = "ℹ Previous-semester enrollment information is informational only and does not prevent the student from processing clearance."
        ' 
        ' txtRemarks
        ' 
        txtRemarks.Font = New Font("Segoe UI", 9.5F)
        txtRemarks.Location = New Point(26, 335)
        txtRemarks.Multiline = True
        txtRemarks.Name = "txtRemarks"
        txtRemarks.ScrollBars = ScrollBars.Vertical
        txtRemarks.Size = New Size(488, 55)
        txtRemarks.TabIndex = 10
        ' 
        ' lblRemarks
        ' 
        lblRemarks.AutoSize = True
        lblRemarks.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblRemarks.ForeColor = Color.FromArgb(51, 65, 85)
        lblRemarks.Location = New Point(26, 315)
        lblRemarks.Name = "lblRemarks"
        lblRemarks.Size = New Size(106, 15)
        lblRemarks.TabIndex = 9
        lblRemarks.Text = "Remarks (Optional)"
        ' 
        ' cmbEnrollmentStatus
        ' 
        cmbEnrollmentStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cmbEnrollmentStatus.Font = New Font("Segoe UI", 9.5F)
        cmbEnrollmentStatus.FormattingEnabled = True
        cmbEnrollmentStatus.Items.AddRange(New Object() {"Enrolled", "Not Enrolled", "Not Enrolled (Returnee / Drop-out)", "N/A (New Student)", "N/A (Transferee)", "No Record"})
        cmbEnrollmentStatus.Location = New Point(26, 224)
        cmbEnrollmentStatus.Name = "cmbEnrollmentStatus"
        cmbEnrollmentStatus.Size = New Size(488, 25)
        cmbEnrollmentStatus.TabIndex = 6
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblStatus.ForeColor = Color.FromArgb(51, 65, 85)
        lblStatus.Location = New Point(26, 204)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(98, 15)
        lblStatus.TabIndex = 5
        lblStatus.Text = "Enrollment Status"
        ' 
        ' cmbAcademicTerm
        ' 
        cmbAcademicTerm.DropDownStyle = ComboBoxStyle.DropDownList
        cmbAcademicTerm.Font = New Font("Segoe UI", 9.5F)
        cmbAcademicTerm.FormattingEnabled = True
        cmbAcademicTerm.Location = New Point(26, 166)
        cmbAcademicTerm.Name = "cmbAcademicTerm"
        cmbAcademicTerm.Size = New Size(488, 25)
        cmbAcademicTerm.TabIndex = 4
        ' 
        ' lblTerm
        ' 
        lblTerm.AutoSize = True
        lblTerm.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold)
        lblTerm.ForeColor = Color.FromArgb(51, 65, 85)
        lblTerm.Location = New Point(26, 146)
        lblTerm.Name = "lblTerm"
        lblTerm.Size = New Size(150, 15)
        lblTerm.TabIndex = 3
        lblTerm.Text = "Academic Term / Semester"
        ' 
        ' pnlStudentCard
        ' 
        pnlStudentCard.BackColor = Color.FromArgb(248, 250, 252)
        pnlStudentCard.BorderStyle = BorderStyle.FixedSingle
        pnlStudentCard.Controls.Add(lblStudentInfoVal)
        pnlStudentCard.Controls.Add(lblStudentNameVal)
        pnlStudentCard.Location = New Point(26, 72)
        pnlStudentCard.Name = "pnlStudentCard"
        pnlStudentCard.Padding = New Padding(12)
        pnlStudentCard.Size = New Size(488, 62)
        pnlStudentCard.TabIndex = 2
        ' 
        ' lblStudentInfoVal
        ' 
        lblStudentInfoVal.AutoSize = True
        lblStudentInfoVal.Font = New Font("Segoe UI", 8.5F)
        lblStudentInfoVal.ForeColor = Color.FromArgb(100, 116, 139)
        lblStudentInfoVal.Location = New Point(12, 31)
        lblStudentInfoVal.Name = "lblStudentInfoVal"
        lblStudentInfoVal.Size = New Size(170, 15)
        lblStudentInfoVal.TabIndex = 1
        lblStudentInfoVal.Text = "Student No | Course - Year Level"
        ' 
        ' lblStudentNameVal
        ' 
        lblStudentNameVal.AutoSize = True
        lblStudentNameVal.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lblStudentNameVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblStudentNameVal.Location = New Point(12, 10)
        lblStudentNameVal.Name = "lblStudentNameVal"
        lblStudentNameVal.Size = New Size(98, 19)
        lblStudentNameVal.TabIndex = 0
        lblStudentNameVal.Text = "Student Name"
        ' 
        ' lblModalSubtitle
        ' 
        lblModalSubtitle.AutoSize = True
        lblModalSubtitle.Font = New Font("Segoe UI", 9.0F)
        lblModalSubtitle.ForeColor = Color.FromArgb(100, 116, 139)
        lblModalSubtitle.Location = New Point(25, 47)
        lblModalSubtitle.Name = "lblModalSubtitle"
        lblModalSubtitle.Size = New Size(430, 15)
        lblModalSubtitle.TabIndex = 1
        lblModalSubtitle.Text = "Maintain student enrollment status for previous terms with verified school basis."
        ' 
        ' lblModalTitle
        ' 
        lblModalTitle.AutoSize = True
        lblModalTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold)
        lblModalTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblModalTitle.Location = New Point(24, 20)
        lblModalTitle.Name = "lblModalTitle"
        lblModalTitle.Size = New Size(300, 25)
        lblModalTitle.TabIndex = 0
        lblModalTitle.Text = "Previous-Semester Enrollment"
        ' 
        ' ManageEnrollmentModalForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(540, 565)
        Controls.Add(pnlContainer)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "ManageEnrollmentModalForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Manage Previous-Semester Enrollment"
        pnlContainer.ResumeLayout(False)
        pnlContainer.PerformLayout()
        pnlNotice.ResumeLayout(False)
        pnlStudentCard.ResumeLayout(False)
        pnlStudentCard.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlContainer As Panel
    Friend WithEvents lblModalTitle As Label
    Friend WithEvents lblModalSubtitle As Label
    Friend WithEvents pnlStudentCard As Panel
    Friend WithEvents lblStudentNameVal As Label
    Friend WithEvents lblStudentInfoVal As Label
    Friend WithEvents lblTerm As Label
    Friend WithEvents cmbAcademicTerm As ComboBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbEnrollmentStatus As ComboBox
    Friend WithEvents lblBasis As Label
    Friend WithEvents cmbVerificationBasis As ComboBox
    Friend WithEvents lblRemarks As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents pnlNotice As Panel
    Friend WithEvents lblNotice As Label
    Friend WithEvents lblAuditInfo As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
