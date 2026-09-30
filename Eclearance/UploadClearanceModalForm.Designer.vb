<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UploadClearanceModalForm
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
        lblOfficeSubtitle = New Label()
        pnlListContainer = New Panel()
        lstSelectedFiles = New ListBox()
        pnlToolbar = New Panel()
        btnRemoveFile = New Button()
        btnAddFiles = New Button()
        lblFilesCount = New Label()
        lblSelectedFilesHeader = New Label()
        lblNotice = New Label()
        btnCancel = New Button()
        btnSubmit = New Button()
        pnlCard.SuspendLayout()
        pnlListContainer.SuspendLayout()
        pnlToolbar.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlCard
        ' 
        pnlCard.BackColor = Color.White
        pnlCard.BorderStyle = BorderStyle.FixedSingle
        pnlCard.Controls.Add(btnClose)
        pnlCard.Controls.Add(lblModalTitle)
        pnlCard.Controls.Add(lblOfficeSubtitle)
        pnlCard.Controls.Add(pnlListContainer)
        pnlCard.Controls.Add(lblNotice)
        pnlCard.Controls.Add(btnCancel)
        pnlCard.Controls.Add(btnSubmit)
        pnlCard.Dock = DockStyle.Fill
        pnlCard.Location = New Point(0, 0)
        pnlCard.Name = "pnlCard"
        pnlCard.Padding = New Padding(20)
        pnlCard.Size = New Size(540, 480)
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
        btnClose.Location = New Point(488, 14)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(36, 36)
        btnClose.TabIndex = 0
        btnClose.Text = "✕"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' lblModalTitle
        ' 
        lblModalTitle.AutoSize = True
        lblModalTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblModalTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblModalTitle.Location = New Point(20, 18)
        lblModalTitle.Name = "lblModalTitle"
        lblModalTitle.Size = New Size(207, 25)
        lblModalTitle.TabIndex = 1
        lblModalTitle.Text = "Upload Requirement"
        ' 
        ' lblOfficeSubtitle
        ' 
        lblOfficeSubtitle.AutoSize = True
        lblOfficeSubtitle.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeSubtitle.ForeColor = Color.FromArgb(71, 85, 105)
        lblOfficeSubtitle.Location = New Point(20, 46)
        lblOfficeSubtitle.Name = "lblOfficeSubtitle"
        lblOfficeSubtitle.Size = New Size(245, 17)
        lblOfficeSubtitle.TabIndex = 2
        lblOfficeSubtitle.Text = "Select one or more files to submit for review."
        ' 
        ' pnlListContainer
        ' 
        pnlListContainer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlListContainer.BackColor = Color.FromArgb(248, 250, 252)
        pnlListContainer.BorderStyle = BorderStyle.FixedSingle
        pnlListContainer.Controls.Add(lstSelectedFiles)
        pnlListContainer.Controls.Add(pnlToolbar)
        pnlListContainer.Location = New Point(20, 80)
        pnlListContainer.Name = "pnlListContainer"
        pnlListContainer.Padding = New Padding(12)
        pnlListContainer.Size = New Size(498, 280)
        pnlListContainer.TabIndex = 3
        ' 
        ' lstSelectedFiles
        ' 
        lstSelectedFiles.BorderStyle = BorderStyle.FixedSingle
        lstSelectedFiles.Dock = DockStyle.Fill
        lstSelectedFiles.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lstSelectedFiles.FormattingEnabled = True
        lstSelectedFiles.ItemHeight = 17
        lstSelectedFiles.Location = New Point(12, 56)
        lstSelectedFiles.Name = "lstSelectedFiles"
        lstSelectedFiles.Size = New Size(472, 210)
        lstSelectedFiles.TabIndex = 1
        ' 
        ' pnlToolbar
        ' 
        pnlToolbar.Controls.Add(btnRemoveFile)
        pnlToolbar.Controls.Add(btnAddFiles)
        pnlToolbar.Controls.Add(lblFilesCount)
        pnlToolbar.Controls.Add(lblSelectedFilesHeader)
        pnlToolbar.Dock = DockStyle.Top
        pnlToolbar.Location = New Point(12, 12)
        pnlToolbar.Name = "pnlToolbar"
        pnlToolbar.Size = New Size(472, 44)
        pnlToolbar.TabIndex = 0
        ' 
        ' btnRemoveFile
        ' 
        btnRemoveFile.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRemoveFile.BackColor = Color.FromArgb(254, 226, 226)
        btnRemoveFile.Cursor = Cursors.Hand
        btnRemoveFile.FlatAppearance.BorderSize = 0
        btnRemoveFile.FlatStyle = FlatStyle.Flat
        btnRemoveFile.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnRemoveFile.ForeColor = Color.FromArgb(185, 28, 28)
        btnRemoveFile.Location = New Point(362, 5)
        btnRemoveFile.Name = "btnRemoveFile"
        btnRemoveFile.Size = New Size(106, 32)
        btnRemoveFile.TabIndex = 3
        btnRemoveFile.Text = "🗑 Remove"
        btnRemoveFile.UseVisualStyleBackColor = False
        ' 
        ' btnAddFiles
        ' 
        btnAddFiles.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAddFiles.BackColor = Color.FromArgb(11, 99, 229)
        btnAddFiles.Cursor = Cursors.Hand
        btnAddFiles.FlatAppearance.BorderSize = 0
        btnAddFiles.FlatStyle = FlatStyle.Flat
        btnAddFiles.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddFiles.ForeColor = Color.White
        btnAddFiles.Location = New Point(246, 5)
        btnAddFiles.Name = "btnAddFiles"
        btnAddFiles.Size = New Size(110, 32)
        btnAddFiles.TabIndex = 2
        btnAddFiles.Text = "➕ Add Files..."
        btnAddFiles.UseVisualStyleBackColor = False
        ' 
        ' lblFilesCount
        ' 
        lblFilesCount.AutoSize = True
        lblFilesCount.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblFilesCount.ForeColor = Color.FromArgb(100, 116, 139)
        lblFilesCount.Location = New Point(128, 14)
        lblFilesCount.Name = "lblFilesCount"
        lblFilesCount.Size = New Size(81, 15)
        lblFilesCount.TabIndex = 1
        lblFilesCount.Text = "(0 files added)"
        ' 
        ' lblSelectedFilesHeader
        ' 
        lblSelectedFilesHeader.AutoSize = True
        lblSelectedFilesHeader.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblSelectedFilesHeader.ForeColor = Color.FromArgb(15, 23, 42)
        lblSelectedFilesHeader.Location = New Point(0, 12)
        lblSelectedFilesHeader.Name = "lblSelectedFilesHeader"
        lblSelectedFilesHeader.Size = New Size(119, 17)
        lblSelectedFilesHeader.TabIndex = 0
        lblSelectedFilesHeader.Text = "Files to be uploaded"
        ' 
        ' lblNotice
        ' 
        lblNotice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblNotice.AutoSize = True
        lblNotice.Font = New Font("Segoe UI", 8.0F, FontStyle.Italic, GraphicsUnit.Point)
        lblNotice.ForeColor = Color.FromArgb(100, 116, 139)
        lblNotice.Location = New Point(20, 370)
        lblNotice.Name = "lblNotice"
        lblNotice.Size = New Size(322, 13)
        lblNotice.TabIndex = 4
        lblNotice.Text = "Supported formats: PDF, JPG, JPEG, PNG. Maximum 10 MB per file."
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.FromArgb(71, 85, 105)
        btnCancel.Location = New Point(278, 415)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 38)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnSubmit.BackColor = Color.FromArgb(11, 99, 229)
        btnSubmit.Cursor = Cursors.Hand
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(398, 415)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(120, 38)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit Files"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' UploadClearanceModalForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(540, 480)
        Controls.Add(pnlCard)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        MaximizeBox = False
        MinimizeBox = False
        Name = "UploadClearanceModalForm"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Upload Clearance Requirement"
        pnlCard.ResumeLayout(False)
        pnlCard.PerformLayout()
        pnlListContainer.ResumeLayout(False)
        pnlToolbar.ResumeLayout(False)
        pnlToolbar.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlCard As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblModalTitle As Label
    Friend WithEvents lblOfficeSubtitle As Label
    Friend WithEvents pnlListContainer As Panel
    Friend WithEvents pnlToolbar As Panel
    Friend WithEvents lblSelectedFilesHeader As Label
    Friend WithEvents lblFilesCount As Label
    Friend WithEvents btnAddFiles As Button
    Friend WithEvents btnRemoveFile As Button
    Friend WithEvents lstSelectedFiles As ListBox
    Friend WithEvents lblNotice As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSubmit As Button

End Class
