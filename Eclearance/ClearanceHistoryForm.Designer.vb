<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClearanceHistoryForm
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
        Dim dataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim dataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        lblReadOnlyNotice = New Label()
        pnlEventDetails = New Panel()
        btnViewSavedFile = New Button()
        pnlFileBox = New Panel()
        lblFileMeta = New Label()
        lblFileName = New Label()
        lblFileIcon = New Label()
        lblFileAttachmentLabel = New Label()
        lblRemarksVal = New Label()
        lblRemarksLabel = New Label()
        lblNewStatusBadge = New Label()
        lblNewStatusLabel = New Label()
        lblPrevStatusBadge = New Label()
        lblPrevStatusLabel = New Label()
        lblChangedByVal = New Label()
        lblChangedByLabel = New Label()
        lblActionVal = New Label()
        lblActionLabel = New Label()
        lblEventDetailsTitle = New Label()
        dgvHistory = New DataGridView()
        colDateTime = New DataGridViewTextBoxColumn()
        colTerm = New DataGridViewTextBoxColumn()
        colOffice = New DataGridViewTextBoxColumn()
        colAction = New DataGridViewTextBoxColumn()
        colChangedBy = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        pnlInfoCallout = New Panel()
        lblCalloutText = New Label()
        lblCalloutIcon = New Label()
        pnlHeader = New Panel()
        btnRefresh = New Button()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlEventDetails.SuspendLayout()
        pnlFileBox.SuspendLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        pnlInfoCallout.SuspendLayout()
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
        pnlSidebar.Size = New Size(220, 800)
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
        btnNavStudents.BackColor = Color.FromArgb(15, 39, 74)
        btnNavStudents.FlatAppearance.BorderSize = 0
        btnNavStudents.FlatStyle = FlatStyle.Flat
        btnNavStudents.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavStudents.ForeColor = Color.FromArgb(160, 180, 208)
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
        btnNavHistory.BackColor = Color.FromArgb(28, 91, 184)
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnNavHistory.ForeColor = Color.White
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
        btnNavLogout.Location = New Point(0, 752)
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
        pnlMain.Controls.Add(lblReadOnlyNotice)
        pnlMain.Controls.Add(pnlEventDetails)
        pnlMain.Controls.Add(dgvHistory)
        pnlMain.Controls.Add(pnlInfoCallout)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 20, 28, 20)
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' lblReadOnlyNotice
        ' 
        lblReadOnlyNotice.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblReadOnlyNotice.AutoSize = True
        lblReadOnlyNotice.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblReadOnlyNotice.ForeColor = Color.FromArgb(148, 163, 184)
        lblReadOnlyNotice.Location = New Point(28, 765)
        lblReadOnlyNotice.Name = "lblReadOnlyNotice"
        lblReadOnlyNotice.Size = New Size(116, 15)
        lblReadOnlyNotice.TabIndex = 4
        lblReadOnlyNotice.Text = "ℹ History is read-only."
        ' 
        ' pnlEventDetails
        ' 
        pnlEventDetails.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlEventDetails.BackColor = Color.White
        pnlEventDetails.BorderStyle = BorderStyle.FixedSingle
        pnlEventDetails.Controls.Add(btnViewSavedFile)
        pnlEventDetails.Controls.Add(pnlFileBox)
        pnlEventDetails.Controls.Add(lblFileAttachmentLabel)
        pnlEventDetails.Controls.Add(lblRemarksVal)
        pnlEventDetails.Controls.Add(lblRemarksLabel)
        pnlEventDetails.Controls.Add(lblNewStatusBadge)
        pnlEventDetails.Controls.Add(lblNewStatusLabel)
        pnlEventDetails.Controls.Add(lblPrevStatusBadge)
        pnlEventDetails.Controls.Add(lblPrevStatusLabel)
        pnlEventDetails.Controls.Add(lblChangedByVal)
        pnlEventDetails.Controls.Add(lblChangedByLabel)
        pnlEventDetails.Controls.Add(lblActionVal)
        pnlEventDetails.Controls.Add(lblActionLabel)
        pnlEventDetails.Controls.Add(lblEventDetailsTitle)
        pnlEventDetails.Location = New Point(28, 480)
        pnlEventDetails.Name = "pnlEventDetails"
        pnlEventDetails.Padding = New Padding(20)
        pnlEventDetails.Size = New Size(924, 260)
        pnlEventDetails.TabIndex = 3
        ' 
        ' btnViewSavedFile
        ' 
        btnViewSavedFile.BackColor = Color.White
        btnViewSavedFile.Cursor = Cursors.Hand
        btnViewSavedFile.FlatAppearance.BorderColor = Color.FromArgb(11, 99, 229)
        btnViewSavedFile.FlatStyle = FlatStyle.Flat
        btnViewSavedFile.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnViewSavedFile.ForeColor = Color.FromArgb(11, 99, 229)
        btnViewSavedFile.Location = New Point(770, 185)
        btnViewSavedFile.Name = "btnViewSavedFile"
        btnViewSavedFile.Size = New Size(120, 48)
        btnViewSavedFile.TabIndex = 13
        btnViewSavedFile.Text = "View saved file"
        btnViewSavedFile.UseVisualStyleBackColor = False
        ' 
        ' pnlFileBox
        ' 
        pnlFileBox.BackColor = Color.FromArgb(248, 250, 252)
        pnlFileBox.BorderStyle = BorderStyle.FixedSingle
        pnlFileBox.Controls.Add(lblFileMeta)
        pnlFileBox.Controls.Add(lblFileName)
        pnlFileBox.Controls.Add(lblFileIcon)
        pnlFileBox.Location = New Point(550, 185)
        pnlFileBox.Name = "pnlFileBox"
        pnlFileBox.Size = New Size(210, 48)
        pnlFileBox.TabIndex = 12
        ' 
        ' lblFileMeta
        ' 
        lblFileMeta.AutoSize = True
        lblFileMeta.Font = New Font("Segoe UI", 7.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileMeta.ForeColor = Color.FromArgb(148, 163, 184)
        lblFileMeta.Location = New Point(38, 26)
        lblFileMeta.Name = "lblFileMeta"
        lblFileMeta.Size = New Size(14, 12)
        lblFileMeta.TabIndex = 2
        lblFileMeta.Text = "--"
        ' 
        ' lblFileName
        ' 
        lblFileName.AutoSize = True
        lblFileName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileName.ForeColor = Color.FromArgb(30, 41, 59)
        lblFileName.Location = New Point(38, 8)
        lblFileName.Name = "lblFileName"
        lblFileName.Size = New Size(93, 15)
        lblFileName.TabIndex = 1
        lblFileName.Text = "No file attached"
        ' 
        ' lblFileIcon
        ' 
        lblFileIcon.BackColor = Color.FromArgb(254, 226, 226)
        lblFileIcon.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileIcon.ForeColor = Color.FromArgb(220, 38, 38)
        lblFileIcon.Location = New Point(6, 8)
        lblFileIcon.Name = "lblFileIcon"
        lblFileIcon.Size = New Size(28, 30)
        lblFileIcon.TabIndex = 0
        lblFileIcon.Text = "📄"
        lblFileIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFileAttachmentLabel
        ' 
        lblFileAttachmentLabel.AutoSize = True
        lblFileAttachmentLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileAttachmentLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblFileAttachmentLabel.Location = New Point(420, 200)
        lblFileAttachmentLabel.Name = "lblFileAttachmentLabel"
        lblFileAttachmentLabel.Size = New Size(89, 15)
        lblFileAttachmentLabel.TabIndex = 11
        lblFileAttachmentLabel.Text = "File attachment"
        ' 
        ' lblRemarksVal
        ' 
        lblRemarksVal.AutoSize = True
        lblRemarksVal.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRemarksVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblRemarksVal.Location = New Point(550, 135)
        lblRemarksVal.Name = "lblRemarksVal"
        lblRemarksVal.Size = New Size(16, 15)
        lblRemarksVal.TabIndex = 10
        lblRemarksVal.Text = "--"
        ' 
        ' lblRemarksLabel
        ' 
        lblRemarksLabel.AutoSize = True
        lblRemarksLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblRemarksLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblRemarksLabel.Location = New Point(420, 135)
        lblRemarksLabel.Name = "lblRemarksLabel"
        lblRemarksLabel.Size = New Size(52, 15)
        lblRemarksLabel.TabIndex = 9
        lblRemarksLabel.Text = "Remarks"
        ' 
        ' lblNewStatusBadge
        ' 
        lblNewStatusBadge.BackColor = Color.FromArgb(241, 245, 249)
        lblNewStatusBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblNewStatusBadge.ForeColor = Color.FromArgb(71, 85, 105)
        lblNewStatusBadge.Location = New Point(550, 68)
        lblNewStatusBadge.Name = "lblNewStatusBadge"
        lblNewStatusBadge.Size = New Size(100, 26)
        lblNewStatusBadge.TabIndex = 8
        lblNewStatusBadge.Text = "--"
        lblNewStatusBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblNewStatusLabel
        ' 
        lblNewStatusLabel.AutoSize = True
        lblNewStatusLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblNewStatusLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblNewStatusLabel.Location = New Point(420, 72)
        lblNewStatusLabel.Name = "lblNewStatusLabel"
        lblNewStatusLabel.Size = New Size(65, 15)
        lblNewStatusLabel.TabIndex = 7
        lblNewStatusLabel.Text = "New status"
        ' 
        ' lblPrevStatusBadge
        ' 
        lblPrevStatusBadge.BackColor = Color.FromArgb(241, 245, 249)
        lblPrevStatusBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblPrevStatusBadge.ForeColor = Color.FromArgb(71, 85, 105)
        lblPrevStatusBadge.Location = New Point(140, 195)
        lblPrevStatusBadge.Name = "lblPrevStatusBadge"
        lblPrevStatusBadge.Size = New Size(100, 26)
        lblPrevStatusBadge.TabIndex = 6
        lblPrevStatusBadge.Text = "--"
        lblPrevStatusBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblPrevStatusLabel
        ' 
        lblPrevStatusLabel.AutoSize = True
        lblPrevStatusLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblPrevStatusLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblPrevStatusLabel.Location = New Point(20, 200)
        lblPrevStatusLabel.Name = "lblPrevStatusLabel"
        lblPrevStatusLabel.Size = New Size(86, 15)
        lblPrevStatusLabel.TabIndex = 5
        lblPrevStatusLabel.Text = "Previous status"
        ' 
        ' lblChangedByVal
        ' 
        lblChangedByVal.AutoSize = True
        lblChangedByVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblChangedByVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblChangedByVal.Location = New Point(140, 133)
        lblChangedByVal.Name = "lblChangedByVal"
        lblChangedByVal.Size = New Size(18, 17)
        lblChangedByVal.TabIndex = 4
        lblChangedByVal.Text = "--"
        ' 
        ' lblChangedByLabel
        ' 
        lblChangedByLabel.AutoSize = True
        lblChangedByLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblChangedByLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblChangedByLabel.Location = New Point(20, 135)
        lblChangedByLabel.Name = "lblChangedByLabel"
        lblChangedByLabel.Size = New Size(70, 15)
        lblChangedByLabel.TabIndex = 3
        lblChangedByLabel.Text = "Changed by"
        ' 
        ' lblActionVal
        ' 
        lblActionVal.AutoSize = True
        lblActionVal.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblActionVal.ForeColor = Color.FromArgb(15, 23, 42)
        lblActionVal.Location = New Point(140, 70)
        lblActionVal.Name = "lblActionVal"
        lblActionVal.Size = New Size(18, 17)
        lblActionVal.TabIndex = 2
        lblActionVal.Text = "--"
        ' 
        ' lblActionLabel
        ' 
        lblActionLabel.AutoSize = True
        lblActionLabel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblActionLabel.ForeColor = Color.FromArgb(100, 116, 139)
        lblActionLabel.Location = New Point(20, 72)
        lblActionLabel.Name = "lblActionLabel"
        lblActionLabel.Size = New Size(42, 15)
        lblActionLabel.TabIndex = 1
        lblActionLabel.Text = "Action"
        ' 
        ' lblEventDetailsTitle
        ' 
        lblEventDetailsTitle.AutoSize = True
        lblEventDetailsTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblEventDetailsTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblEventDetailsTitle.Location = New Point(20, 18)
        lblEventDetailsTitle.Name = "lblEventDetailsTitle"
        lblEventDetailsTitle.Size = New Size(108, 21)
        lblEventDetailsTitle.TabIndex = 0
        lblEventDetailsTitle.Text = "Event details"
        ' 
        ' dgvHistory
        ' 
        dgvHistory.AllowUserToAddRows = False
        dgvHistory.AllowUserToDeleteRows = False
        dgvHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        dgvHistory.BackgroundColor = Color.White
        dgvHistory.BorderStyle = BorderStyle.FixedSingle
        dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        dataGridViewCellStyle1.ForeColor = Color.FromArgb(71, 85, 105)
        dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(248, 250, 252)
        dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(71, 85, 105)
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1
        dgvHistory.ColumnHeadersHeight = 36
        dgvHistory.Columns.AddRange(New DataGridViewColumn() {colDateTime, colTerm, colOffice, colAction, colChangedBy, colStatus})
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        dataGridViewCellStyle2.BackColor = Color.White
        dataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 238, 255)
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(15, 23, 42)
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvHistory.DefaultCellStyle = dataGridViewCellStyle2
        dgvHistory.EnableHeadersVisualStyles = False
        dgvHistory.GridColor = Color.FromArgb(241, 245, 249)
        dgvHistory.Location = New Point(28, 160)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.ReadOnly = True
        dgvHistory.RowHeadersVisible = False
        dgvHistory.RowTemplate.Height = 36
        dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHistory.Size = New Size(924, 290)
        dgvHistory.TabIndex = 2
        ' 
        ' colDateTime
        ' 
        colDateTime.HeaderText = "Date & time (UTC)"
        colDateTime.Name = "colDateTime"
        colDateTime.ReadOnly = True
        colDateTime.Width = 160
        ' 
        ' colTerm
        ' 
        colTerm.HeaderText = "Term"
        colTerm.Name = "colTerm"
        colTerm.ReadOnly = True
        colTerm.Width = 140
        ' 
        ' colOffice
        ' 
        colOffice.HeaderText = "Office"
        colOffice.Name = "colOffice"
        colOffice.ReadOnly = True
        colOffice.Width = 150
        ' 
        ' colAction
        ' 
        colAction.HeaderText = "Action"
        colAction.Name = "colAction"
        colAction.ReadOnly = True
        colAction.Width = 130
        ' 
        ' colChangedBy
        ' 
        colChangedBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colChangedBy.HeaderText = "Changed by"
        colChangedBy.Name = "colChangedBy"
        colChangedBy.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 130
        ' 
        ' pnlInfoCallout
        ' 
        pnlInfoCallout.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlInfoCallout.BackColor = Color.FromArgb(241, 246, 254)
        pnlInfoCallout.BorderStyle = BorderStyle.FixedSingle
        pnlInfoCallout.Controls.Add(lblCalloutText)
        pnlInfoCallout.Controls.Add(lblCalloutIcon)
        pnlInfoCallout.Location = New Point(28, 95)
        pnlInfoCallout.Name = "pnlInfoCallout"
        pnlInfoCallout.Size = New Size(924, 48)
        pnlInfoCallout.TabIndex = 1
        ' 
        ' lblCalloutText
        ' 
        lblCalloutText.AutoSize = True
        lblCalloutText.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblCalloutText.ForeColor = Color.FromArgb(30, 58, 138)
        lblCalloutText.Location = New Point(45, 15)
        lblCalloutText.Name = "lblCalloutText"
        lblCalloutText.Size = New Size(302, 15)
        lblCalloutText.TabIndex = 1
        lblCalloutText.Text = "Previous submissions and decisions are preserved here."
        ' 
        ' lblCalloutIcon
        ' 
        lblCalloutIcon.Font = New Font("Segoe UI Semibold", 10.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblCalloutIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblCalloutIcon.Location = New Point(15, 12)
        lblCalloutIcon.Name = "lblCalloutIcon"
        lblCalloutIcon.Size = New Size(24, 20)
        lblCalloutIcon.TabIndex = 0
        lblCalloutIcon.Text = "ℹ"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(btnRefresh)
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Location = New Point(28, 15)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 65)
        pnlHeader.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(11, 99, 229)
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(816, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(108, 38)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "🔄 Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubHeader.Location = New Point(0, 38)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(170, 17)
        lblSubHeader.TabIndex = 1
        lblSubHeader.Text = "Student Name  •  Student No."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(230, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Clearance history"
        ' 
        ' ClearanceHistoryForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1100, 750)
        Name = "ClearanceHistoryForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Clearance History"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlEventDetails.ResumeLayout(False)
        pnlEventDetails.PerformLayout()
        pnlFileBox.ResumeLayout(False)
        pnlFileBox.PerformLayout()
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        pnlInfoCallout.ResumeLayout(False)
        pnlInfoCallout.PerformLayout()
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
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlInfoCallout As Panel
    Friend WithEvents lblCalloutIcon As Label
    Friend WithEvents lblCalloutText As Label
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents colDateTime As DataGridViewTextBoxColumn
    Friend WithEvents colTerm As DataGridViewTextBoxColumn
    Friend WithEvents colOffice As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewTextBoxColumn
    Friend WithEvents colChangedBy As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents pnlEventDetails As Panel
    Friend WithEvents lblEventDetailsTitle As Label
    Friend WithEvents lblActionLabel As Label
    Friend WithEvents lblActionVal As Label
    Friend WithEvents lblChangedByLabel As Label
    Friend WithEvents lblChangedByVal As Label
    Friend WithEvents lblPrevStatusLabel As Label
    Friend WithEvents lblPrevStatusBadge As Label
    Friend WithEvents lblNewStatusLabel As Label
    Friend WithEvents lblNewStatusBadge As Label
    Friend WithEvents lblRemarksLabel As Label
    Friend WithEvents lblRemarksVal As Label
    Friend WithEvents lblFileAttachmentLabel As Label
    Friend WithEvents pnlFileBox As Panel
    Friend WithEvents lblFileIcon As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents lblFileMeta As Label
    Friend WithEvents btnViewSavedFile As Button
    Friend WithEvents lblReadOnlyNotice As Label

End Class
