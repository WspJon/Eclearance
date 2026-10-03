<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffRequestsForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        btnNavLogout = New Button()
        btnNavHistory = New Button()
        btnNavRequests = New Button()
        btnNavDashboard = New Button()
        lblNavSection = New Label()
        pnlLogo = New Panel()
        lblLogoSub = New Label()
        lblLogoTitle = New Label()
        picSchoolLogo = New PictureBox()
        pnlMain = New Panel()
        pnlRightColumn = New Panel()
        pnlMyOfficeCard = New Panel()
        pnlOfficeInner = New Panel()
        lblOfficeDescSub = New Label()
        lblMyOfficeStatus = New Label()
        lblMyOfficeTitle = New Label()
        lblOfficeBadgeIcon = New Label()
        lblMyOfficeHeader = New Label()
        pnlQuickActionsCard = New Panel()
        btnQuickHistory = New Button()
        btnQuickRefresh = New Button()
        btnQuickReviewNext = New Button()
        lblQuickTitle = New Label()
        pnlTableCard = New Panel()
        dgvRequests = New DataGridView()
        colReqNum = New DataGridViewTextBoxColumn()
        colReqRecordID = New DataGridViewTextBoxColumn()
        colReqStudentNo = New DataGridViewTextBoxColumn()
        colReqStudentName = New DataGridViewTextBoxColumn()
        colReqRequirement = New DataGridViewTextBoxColumn()
        colReqSubmittedAt = New DataGridViewTextBoxColumn()
        colReqStatus = New DataGridViewTextBoxColumn()
        colReqAction = New DataGridViewButtonColumn()
        lblRecordCount = New Label()
        lblTableTitle = New Label()
        lblTableIcon = New Label()
        pnlFilterBar = New Panel()
        btnRefresh = New Button()
        btnFilterRejected = New Button()
        btnFilterCleared = New Button()
        btnFilterReview = New Button()
        btnFilterPending = New Button()
        btnFilterAll = New Button()
        txtSearch = New TextBox()
        lblSearchIcon = New Label()
        pnlSummaryPending = New Panel()
        lblPendingArrow = New Label()
        lblPendingSub = New Label()
        lblPendingTitle = New Label()
        lblPendingCount = New Label()
        lblPendingIcon = New Label()
        pnlSummaryTotal = New Panel()
        lblTotalArrow = New Label()
        lblTotalSub = New Label()
        lblTotalTitle = New Label()
        lblTotalCount = New Label()
        lblTotalIcon = New Label()
        lblDateTimeBadge = New Label()
        pnlStaffBadge = New Panel()
        lblStaffRole = New Label()
        lblStaffName = New Label()
        lblStaffIcon = New Label()
        pnlOfficeBadge = New Panel()
        lblOfficeSub = New Label()
        lblOfficeName = New Label()
        lblOfficeIcon = New Label()
        lblHeaderSub = New Label()
        lblHeaderTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).BeginInit()
        pnlMain.SuspendLayout()
        pnlRightColumn.SuspendLayout()
        pnlMyOfficeCard.SuspendLayout()
        pnlOfficeInner.SuspendLayout()
        pnlQuickActionsCard.SuspendLayout()
        pnlTableCard.SuspendLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).BeginInit()
        pnlFilterBar.SuspendLayout()
        pnlSummaryPending.SuspendLayout()
        pnlSummaryTotal.SuspendLayout()
        pnlStaffBadge.SuspendLayout()
        pnlOfficeBadge.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavRequests)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 808)
        pnlSidebar.TabIndex = 0
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F)
        btnNavLogout.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavLogout.Location = New Point(16, 743)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Size = New Size(188, 44)
        btnNavLogout.TabIndex = 5
        btnNavLogout.Text = "  Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = True
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.Cursor = Cursors.Hand
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F)
        btnNavHistory.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavHistory.Location = New Point(16, 224)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Size = New Size(188, 44)
        btnNavHistory.TabIndex = 4
        btnNavHistory.Text = "  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = True
        ' 
        ' btnNavRequests
        ' 
        btnNavRequests.BackColor = Color.FromArgb(CByte(28), CByte(91), CByte(184))
        btnNavRequests.Cursor = Cursors.Hand
        btnNavRequests.FlatAppearance.BorderSize = 0
        btnNavRequests.FlatStyle = FlatStyle.Flat
        btnNavRequests.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavRequests.ForeColor = Color.White
        btnNavRequests.Location = New Point(16, 172)
        btnNavRequests.Name = "btnNavRequests"
        btnNavRequests.Size = New Size(188, 44)
        btnNavRequests.TabIndex = 3
        btnNavRequests.Text = "  Requests"
        btnNavRequests.TextAlign = ContentAlignment.MiddleLeft
        btnNavRequests.UseVisualStyleBackColor = False
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.Cursor = Cursors.Hand
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI", 9.5F)
        btnNavDashboard.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavDashboard.Location = New Point(16, 120)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(188, 44)
        btnNavDashboard.TabIndex = 2
        btnNavDashboard.Text = "  Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = True
        ' 
        ' lblNavSection
        ' 
        lblNavSection.AutoSize = True
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold)
        lblNavSection.ForeColor = Color.FromArgb(CByte(100), CByte(130), CByte(170))
        lblNavSection.Location = New Point(16, 95)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(74, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "STAFF PORTAL"
        ' 
        ' pnlLogo
        ' 
        pnlLogo.Controls.Add(lblLogoSub)
        pnlLogo.Controls.Add(lblLogoTitle)
        pnlLogo.Controls.Add(picSchoolLogo)
        pnlLogo.Location = New Point(0, 0)
        pnlLogo.Name = "pnlLogo"
        pnlLogo.Size = New Size(220, 75)
        pnlLogo.TabIndex = 0
        ' 
        ' lblLogoSub
        ' 
        lblLogoSub.AutoSize = True
        lblLogoSub.Font = New Font("Segoe UI", 7.5F)
        lblLogoSub.ForeColor = Color.FromArgb(CByte(140), CByte(168), CByte(205))
        lblLogoSub.Location = New Point(50, 38)
        lblLogoSub.Name = "lblLogoSub"
        lblLogoSub.Size = New Size(118, 12)
        lblLogoSub.TabIndex = 2
        lblLogoSub.Text = "Student Clearance System"
        ' 
        ' lblLogoTitle
        ' 
        lblLogoTitle.AutoSize = True
        lblLogoTitle.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblLogoTitle.ForeColor = Color.White
        lblLogoTitle.Location = New Point(48, 16)
        lblLogoTitle.Name = "lblLogoTitle"
        lblLogoTitle.Size = New Size(94, 21)
        lblLogoTitle.TabIndex = 1
        lblLogoTitle.Text = "EClearance"
        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Location = New Point(12, 16)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(32, 32)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlMain.Controls.Add(pnlRightColumn)
        pnlMain.Controls.Add(pnlTableCard)
        pnlMain.Controls.Add(pnlFilterBar)
        pnlMain.Controls.Add(pnlSummaryPending)
        pnlMain.Controls.Add(pnlSummaryTotal)
        pnlMain.Controls.Add(lblDateTimeBadge)
        pnlMain.Controls.Add(pnlStaffBadge)
        pnlMain.Controls.Add(pnlOfficeBadge)
        pnlMain.Controls.Add(lblHeaderSub)
        pnlMain.Controls.Add(lblHeaderTitle)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(980, 808)
        pnlMain.TabIndex = 1
        ' 
        ' pnlRightColumn
        ' 
        pnlRightColumn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlRightColumn.Controls.Add(pnlMyOfficeCard)
        pnlRightColumn.Controls.Add(pnlQuickActionsCard)
        pnlRightColumn.Location = New Point(680, 194)
        pnlRightColumn.Name = "pnlRightColumn"
        pnlRightColumn.Size = New Size(272, 578)
        pnlRightColumn.TabIndex = 9
        ' 
        ' pnlMyOfficeCard
        ' 
        pnlMyOfficeCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMyOfficeCard.BackColor = Color.White
        pnlMyOfficeCard.BorderStyle = BorderStyle.FixedSingle
        pnlMyOfficeCard.Controls.Add(pnlOfficeInner)
        pnlMyOfficeCard.Controls.Add(lblMyOfficeHeader)
        pnlMyOfficeCard.Location = New Point(0, 264)
        pnlMyOfficeCard.Name = "pnlMyOfficeCard"
        pnlMyOfficeCard.Padding = New Padding(16)
        pnlMyOfficeCard.Size = New Size(272, 314)
        pnlMyOfficeCard.TabIndex = 1
        ' 
        ' pnlOfficeInner
        ' 
        pnlOfficeInner.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlOfficeInner.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        pnlOfficeInner.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeInner.Controls.Add(lblOfficeDescSub)
        pnlOfficeInner.Controls.Add(lblMyOfficeStatus)
        pnlOfficeInner.Controls.Add(lblMyOfficeTitle)
        pnlOfficeInner.Controls.Add(lblOfficeBadgeIcon)
        pnlOfficeInner.Location = New Point(16, 48)
        pnlOfficeInner.Name = "pnlOfficeInner"
        pnlOfficeInner.Size = New Size(238, 80)
        pnlOfficeInner.TabIndex = 1
        ' 
        ' lblOfficeDescSub
        ' 
        lblOfficeDescSub.AutoSize = True
        lblOfficeDescSub.Font = New Font("Segoe UI", 8F)
        lblOfficeDescSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeDescSub.Location = New Point(58, 44)
        lblOfficeDescSub.Name = "lblOfficeDescSub"
        lblOfficeDescSub.Size = New Size(164, 13)
        lblOfficeDescSub.TabIndex = 3
        lblOfficeDescSub.Text = "You are assigned to this office."
        ' 
        ' lblMyOfficeStatus
        ' 
        lblMyOfficeStatus.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblMyOfficeStatus.BackColor = Color.FromArgb(CByte(220), CByte(252), CByte(231))
        lblMyOfficeStatus.Font = New Font("Segoe UI Semibold", 7.5F, FontStyle.Bold)
        lblMyOfficeStatus.ForeColor = Color.FromArgb(CByte(21), CByte(128), CByte(61))
        lblMyOfficeStatus.Location = New Point(180, 14)
        lblMyOfficeStatus.Name = "lblMyOfficeStatus"
        lblMyOfficeStatus.Size = New Size(48, 20)
        lblMyOfficeStatus.TabIndex = 2
        lblMyOfficeStatus.Text = "Active"
        lblMyOfficeStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMyOfficeTitle
        ' 
        lblMyOfficeTitle.AutoSize = True
        lblMyOfficeTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lblMyOfficeTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblMyOfficeTitle.Location = New Point(58, 14)
        lblMyOfficeTitle.Name = "lblMyOfficeTitle"
        lblMyOfficeTitle.Size = New Size(115, 19)
        lblMyOfficeTitle.TabIndex = 1
        lblMyOfficeTitle.Text = "Guidance Office"
        ' 
        ' lblOfficeBadgeIcon
        ' 
        lblOfficeBadgeIcon.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblOfficeBadgeIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblOfficeBadgeIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblOfficeBadgeIcon.Location = New Point(12, 14)
        lblOfficeBadgeIcon.Name = "lblOfficeBadgeIcon"
        lblOfficeBadgeIcon.Size = New Size(38, 38)
        lblOfficeBadgeIcon.TabIndex = 0
        lblOfficeBadgeIcon.Text = "📖"
        lblOfficeBadgeIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblMyOfficeHeader
        ' 
        lblMyOfficeHeader.AutoSize = True
        lblMyOfficeHeader.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblMyOfficeHeader.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblMyOfficeHeader.Location = New Point(16, 16)
        lblMyOfficeHeader.Name = "lblMyOfficeHeader"
        lblMyOfficeHeader.Size = New Size(103, 20)
        lblMyOfficeHeader.TabIndex = 0
        lblMyOfficeHeader.Text = "🏛 My Office"
        ' 
        ' pnlQuickActionsCard
        ' 
        pnlQuickActionsCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlQuickActionsCard.BackColor = Color.White
        pnlQuickActionsCard.BorderStyle = BorderStyle.FixedSingle
        pnlQuickActionsCard.Controls.Add(btnQuickHistory)
        pnlQuickActionsCard.Controls.Add(btnQuickRefresh)
        pnlQuickActionsCard.Controls.Add(btnQuickReviewNext)
        pnlQuickActionsCard.Controls.Add(lblQuickTitle)
        pnlQuickActionsCard.Location = New Point(0, 0)
        pnlQuickActionsCard.Name = "pnlQuickActionsCard"
        pnlQuickActionsCard.Padding = New Padding(16)
        pnlQuickActionsCard.Size = New Size(272, 252)
        pnlQuickActionsCard.TabIndex = 0
        ' 
        ' btnQuickHistory
        ' 
        btnQuickHistory.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnQuickHistory.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        btnQuickHistory.Cursor = Cursors.Hand
        btnQuickHistory.FlatAppearance.BorderColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnQuickHistory.FlatStyle = FlatStyle.Flat
        btnQuickHistory.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnQuickHistory.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnQuickHistory.Location = New Point(16, 180)
        btnQuickHistory.Name = "btnQuickHistory"
        btnQuickHistory.Size = New Size(238, 54)
        btnQuickHistory.TabIndex = 3
        btnQuickHistory.Text = "🕒  View History" & vbCrLf & "     See processed records"
        btnQuickHistory.TextAlign = ContentAlignment.MiddleLeft
        btnQuickHistory.UseVisualStyleBackColor = False
        ' 
        ' btnQuickRefresh
        ' 
        btnQuickRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnQuickRefresh.BackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        btnQuickRefresh.Cursor = Cursors.Hand
        btnQuickRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnQuickRefresh.FlatStyle = FlatStyle.Flat
        btnQuickRefresh.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnQuickRefresh.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnQuickRefresh.Location = New Point(16, 114)
        btnQuickRefresh.Name = "btnQuickRefresh"
        btnQuickRefresh.Size = New Size(238, 54)
        btnQuickRefresh.TabIndex = 2
        btnQuickRefresh.Text = "🔄  Refresh Requests" & vbCrLf & "     Reload the latest submissions"
        btnQuickRefresh.TextAlign = ContentAlignment.MiddleLeft
        btnQuickRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnQuickReviewNext
        ' 
        btnQuickReviewNext.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnQuickReviewNext.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnQuickReviewNext.Cursor = Cursors.Hand
        btnQuickReviewNext.FlatAppearance.BorderSize = 0
        btnQuickReviewNext.FlatStyle = FlatStyle.Flat
        btnQuickReviewNext.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnQuickReviewNext.ForeColor = Color.White
        btnQuickReviewNext.Location = New Point(16, 48)
        btnQuickReviewNext.Name = "btnQuickReviewNext"
        btnQuickReviewNext.Size = New Size(238, 54)
        btnQuickReviewNext.TabIndex = 1
        btnQuickReviewNext.Text = "📄  Review Next Pending" & vbCrLf & "     Go to the next pending request"
        btnQuickReviewNext.TextAlign = ContentAlignment.MiddleLeft
        btnQuickReviewNext.UseVisualStyleBackColor = False
        ' 
        ' lblQuickTitle
        ' 
        lblQuickTitle.AutoSize = True
        lblQuickTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblQuickTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblQuickTitle.Location = New Point(16, 16)
        lblQuickTitle.Name = "lblQuickTitle"
        lblQuickTitle.Size = New Size(131, 20)
        lblQuickTitle.TabIndex = 0
        lblQuickTitle.Text = "⚡ Quick Actions"
        ' 
        ' pnlTableCard
        ' 
        pnlTableCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlTableCard.BackColor = Color.White
        pnlTableCard.BorderStyle = BorderStyle.FixedSingle
        pnlTableCard.Controls.Add(dgvRequests)
        pnlTableCard.Controls.Add(lblRecordCount)
        pnlTableCard.Controls.Add(lblTableTitle)
        pnlTableCard.Controls.Add(lblTableIcon)
        pnlTableCard.Location = New Point(24, 260)
        pnlTableCard.Name = "pnlTableCard"
        pnlTableCard.Padding = New Padding(16)
        pnlTableCard.Size = New Size(640, 512)
        pnlTableCard.TabIndex = 8
        ' 
        ' dgvRequests
        ' 
        dgvRequests.AllowUserToAddRows = False
        dgvRequests.AllowUserToDeleteRows = False
        dgvRequests.AllowUserToResizeRows = False
        dgvRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRequests.BackgroundColor = Color.White
        dgvRequests.BorderStyle = BorderStyle.None
        dgvRequests.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRequests.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        DataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvRequests.ColumnHeadersHeight = 42
        dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRequests.Columns.AddRange(New DataGridViewColumn() {colReqNum, colReqRecordID, colReqStudentNo, colReqStudentName, colReqRequirement, colReqSubmittedAt, colReqStatus, colReqAction})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvRequests.DefaultCellStyle = DataGridViewCellStyle3
        dgvRequests.EnableHeadersVisualStyles = False
        dgvRequests.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvRequests.Location = New Point(16, 52)
        dgvRequests.MultiSelect = False
        dgvRequests.Name = "dgvRequests"
        dgvRequests.ReadOnly = True
        dgvRequests.RowHeadersVisible = False
        dgvRequests.RowTemplate.Height = 46
        dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRequests.Size = New Size(606, 442)
        dgvRequests.TabIndex = 3
        ' 
        ' colReqNum
        ' 
        colReqNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.Padding = New Padding(8, 0, 0, 0)
        colReqNum.DefaultCellStyle = DataGridViewCellStyle2
        colReqNum.HeaderText = "#"
        colReqNum.Name = "colReqNum"
        colReqNum.ReadOnly = True
        colReqNum.Resizable = DataGridViewTriState.False
        colReqNum.Width = 40
        ' 
        ' colReqRecordID
        ' 
        colReqRecordID.HeaderText = "RecordID"
        colReqRecordID.Name = "colReqRecordID"
        colReqRecordID.ReadOnly = True
        colReqRecordID.Visible = False
        ' 
        ' colReqStudentNo
        ' 
        colReqStudentNo.FillWeight = 14F
        colReqStudentNo.HeaderText = "Student No."
        colReqStudentNo.MinimumWidth = 85
        colReqStudentNo.Name = "colReqStudentNo"
        colReqStudentNo.ReadOnly = True
        ' 
        ' colReqStudentName
        ' 
        colReqStudentName.FillWeight = 22F
        colReqStudentName.HeaderText = "Student Name"
        colReqStudentName.MinimumWidth = 110
        colReqStudentName.Name = "colReqStudentName"
        colReqStudentName.ReadOnly = True
        ' 
        ' colReqRequirement
        ' 
        colReqRequirement.FillWeight = 24F
        colReqRequirement.HeaderText = "Requirement"
        colReqRequirement.MinimumWidth = 120
        colReqRequirement.Name = "colReqRequirement"
        colReqRequirement.ReadOnly = True
        ' 
        ' colReqSubmittedAt
        ' 
        colReqSubmittedAt.FillWeight = 18F
        colReqSubmittedAt.HeaderText = "Submitted At"
        colReqSubmittedAt.MinimumWidth = 120
        colReqSubmittedAt.Name = "colReqSubmittedAt"
        colReqSubmittedAt.ReadOnly = True
        ' 
        ' colReqStatus
        ' 
        colReqStatus.FillWeight = 12F
        colReqStatus.HeaderText = "Status"
        colReqStatus.MinimumWidth = 95
        colReqStatus.Name = "colReqStatus"
        colReqStatus.ReadOnly = True
        ' 
        ' colReqAction
        ' 
        colReqAction.FillWeight = 10F
        colReqAction.FlatStyle = FlatStyle.Flat
        colReqAction.HeaderText = "Action"
        colReqAction.MinimumWidth = 85
        colReqAction.Name = "colReqAction"
        colReqAction.ReadOnly = True
        colReqAction.Text = "Review"
        ' 
        ' lblRecordCount
        ' 
        lblRecordCount.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRecordCount.AutoSize = True
        lblRecordCount.Font = New Font("Segoe UI", 8.5F)
        lblRecordCount.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRecordCount.Location = New Point(490, 18)
        lblRecordCount.Name = "lblRecordCount"
        lblRecordCount.Size = New Size(109, 15)
        lblRecordCount.TabIndex = 2
        lblRecordCount.Text = "Showing 0 requests"
        ' 
        ' lblTableTitle
        ' 
        lblTableTitle.AutoSize = True
        lblTableTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblTableTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblTableTitle.Location = New Point(44, 16)
        lblTableTitle.Name = "lblTableTitle"
        lblTableTitle.Size = New Size(221, 21)
        lblTableTitle.TabIndex = 1
        lblTableTitle.Text = "Student Clearance Requests"
        ' 
        ' lblTableIcon
        ' 
        lblTableIcon.AutoSize = True
        lblTableIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblTableIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblTableIcon.Location = New Point(16, 16)
        lblTableIcon.Name = "lblTableIcon"
        lblTableIcon.Size = New Size(32, 21)
        lblTableIcon.TabIndex = 0
        lblTableIcon.Text = "📄"
        ' 
        ' pnlFilterBar
        ' 
        pnlFilterBar.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilterBar.BackColor = Color.White
        pnlFilterBar.BorderStyle = BorderStyle.FixedSingle
        pnlFilterBar.Controls.Add(btnRefresh)
        pnlFilterBar.Controls.Add(btnFilterRejected)
        pnlFilterBar.Controls.Add(btnFilterCleared)
        pnlFilterBar.Controls.Add(btnFilterReview)
        pnlFilterBar.Controls.Add(btnFilterPending)
        pnlFilterBar.Controls.Add(btnFilterAll)
        pnlFilterBar.Controls.Add(txtSearch)
        pnlFilterBar.Controls.Add(lblSearchIcon)
        pnlFilterBar.Location = New Point(24, 194)
        pnlFilterBar.Name = "pnlFilterBar"
        pnlFilterBar.Size = New Size(640, 52)
        pnlFilterBar.TabIndex = 7
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(544, 10)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(88, 32)
        btnRefresh.TabIndex = 7
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnFilterRejected
        ' 
        btnFilterRejected.BackColor = Color.White
        btnFilterRejected.Cursor = Cursors.Hand
        btnFilterRejected.FlatAppearance.BorderColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnFilterRejected.FlatStyle = FlatStyle.Flat
        btnFilterRejected.Font = New Font("Segoe UI Semibold", 8.5F)
        btnFilterRejected.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnFilterRejected.Location = New Point(678, 10)
        btnFilterRejected.Name = "btnFilterRejected"
        btnFilterRejected.Size = New Size(76, 32)
        btnFilterRejected.TabIndex = 6
        btnFilterRejected.Text = "Rejected"
        btnFilterRejected.UseVisualStyleBackColor = False
        ' 
        ' btnFilterCleared
        ' 
        btnFilterCleared.BackColor = Color.White
        btnFilterCleared.Cursor = Cursors.Hand
        btnFilterCleared.FlatAppearance.BorderColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnFilterCleared.FlatStyle = FlatStyle.Flat
        btnFilterCleared.Font = New Font("Segoe UI Semibold", 8.5F)
        btnFilterCleared.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnFilterCleared.Location = New Point(592, 10)
        btnFilterCleared.Name = "btnFilterCleared"
        btnFilterCleared.Size = New Size(80, 32)
        btnFilterCleared.TabIndex = 5
        btnFilterCleared.Text = "Approved"
        btnFilterCleared.UseVisualStyleBackColor = False
        ' 
        ' btnFilterReview
        ' 
        btnFilterReview.BackColor = Color.White
        btnFilterReview.Cursor = Cursors.Hand
        btnFilterReview.FlatAppearance.BorderColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnFilterReview.FlatStyle = FlatStyle.Flat
        btnFilterReview.Font = New Font("Segoe UI Semibold", 8.5F)
        btnFilterReview.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnFilterReview.Location = New Point(474, 10)
        btnFilterReview.Name = "btnFilterReview"
        btnFilterReview.Size = New Size(112, 32)
        btnFilterReview.TabIndex = 4
        btnFilterReview.Text = "Under Review"
        btnFilterReview.UseVisualStyleBackColor = False
        ' 
        ' btnFilterPending
        ' 
        btnFilterPending.BackColor = Color.White
        btnFilterPending.Cursor = Cursors.Hand
        btnFilterPending.FlatAppearance.BorderColor = Color.FromArgb(CByte(226), CByte(232), CByte(240))
        btnFilterPending.FlatStyle = FlatStyle.Flat
        btnFilterPending.Font = New Font("Segoe UI Semibold", 8.5F)
        btnFilterPending.ForeColor = Color.FromArgb(CByte(51), CByte(65), CByte(85))
        btnFilterPending.Location = New Point(396, 10)
        btnFilterPending.Name = "btnFilterPending"
        btnFilterPending.Size = New Size(72, 32)
        btnFilterPending.TabIndex = 3
        btnFilterPending.Text = "Pending"
        btnFilterPending.UseVisualStyleBackColor = False
        ' 
        ' btnFilterAll
        ' 
        btnFilterAll.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnFilterAll.Cursor = Cursors.Hand
        btnFilterAll.FlatAppearance.BorderSize = 0
        btnFilterAll.FlatStyle = FlatStyle.Flat
        btnFilterAll.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        btnFilterAll.ForeColor = Color.White
        btnFilterAll.Location = New Point(346, 10)
        btnFilterAll.Name = "btnFilterAll"
        btnFilterAll.Size = New Size(44, 32)
        btnFilterAll.TabIndex = 2
        btnFilterAll.Text = "All"
        btnFilterAll.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.White
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 9F)
        txtSearch.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        txtSearch.Location = New Point(34, 14)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Search by student name or student number"
        txtSearch.Size = New Size(300, 23)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearchIcon
        ' 
        lblSearchIcon.AutoSize = True
        lblSearchIcon.Font = New Font("Segoe UI Emoji", 10F)
        lblSearchIcon.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblSearchIcon.Location = New Point(10, 16)
        lblSearchIcon.Name = "lblSearchIcon"
        lblSearchIcon.Size = New Size(28, 19)
        lblSearchIcon.TabIndex = 0
        lblSearchIcon.Text = "🔍"
        ' 
        ' pnlSummaryPending
        ' 
        pnlSummaryPending.BackColor = Color.White
        pnlSummaryPending.BorderStyle = BorderStyle.FixedSingle
        pnlSummaryPending.Controls.Add(lblPendingArrow)
        pnlSummaryPending.Controls.Add(lblPendingSub)
        pnlSummaryPending.Controls.Add(lblPendingTitle)
        pnlSummaryPending.Controls.Add(lblPendingCount)
        pnlSummaryPending.Controls.Add(lblPendingIcon)
        pnlSummaryPending.Cursor = Cursors.Hand
        pnlSummaryPending.Location = New Point(350, 92)
        pnlSummaryPending.Name = "pnlSummaryPending"
        pnlSummaryPending.Size = New Size(314, 86)
        pnlSummaryPending.TabIndex = 6
        ' 
        ' lblPendingArrow
        ' 
        lblPendingArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPendingArrow.AutoSize = True
        lblPendingArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblPendingArrow.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblPendingArrow.Location = New Point(282, 32)
        lblPendingArrow.Name = "lblPendingArrow"
        lblPendingArrow.Size = New Size(21, 21)
        lblPendingArrow.TabIndex = 4
        lblPendingArrow.Text = ">"
        ' 
        ' lblPendingSub
        ' 
        lblPendingSub.AutoSize = True
        lblPendingSub.Font = New Font("Segoe UI", 8F)
        lblPendingSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblPendingSub.Location = New Point(68, 56)
        lblPendingSub.Name = "lblPendingSub"
        lblPendingSub.Size = New Size(114, 13)
        lblPendingSub.TabIndex = 3
        lblPendingSub.Text = "Awaiting your action"
        ' 
        ' lblPendingTitle
        ' 
        lblPendingTitle.AutoSize = True
        lblPendingTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblPendingTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblPendingTitle.Location = New Point(68, 38)
        lblPendingTitle.Name = "lblPendingTitle"
        lblPendingTitle.Size = New Size(91, 15)
        lblPendingTitle.TabIndex = 2
        lblPendingTitle.Text = "Pending Review"
        ' 
        ' lblPendingCount
        ' 
        lblPendingCount.AutoSize = True
        lblPendingCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblPendingCount.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblPendingCount.Location = New Point(68, 6)
        lblPendingCount.Name = "lblPendingCount"
        lblPendingCount.Size = New Size(28, 32)
        lblPendingCount.TabIndex = 1
        lblPendingCount.Text = "0"
        ' 
        ' lblPendingIcon
        ' 
        lblPendingIcon.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblPendingIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblPendingIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblPendingIcon.Location = New Point(16, 16)
        lblPendingIcon.Name = "lblPendingIcon"
        lblPendingIcon.Size = New Size(42, 42)
        lblPendingIcon.TabIndex = 0
        lblPendingIcon.Text = "⌛"
        lblPendingIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSummaryTotal
        ' 
        pnlSummaryTotal.BackColor = Color.White
        pnlSummaryTotal.BorderStyle = BorderStyle.FixedSingle
        pnlSummaryTotal.Controls.Add(lblTotalArrow)
        pnlSummaryTotal.Controls.Add(lblTotalSub)
        pnlSummaryTotal.Controls.Add(lblTotalTitle)
        pnlSummaryTotal.Controls.Add(lblTotalCount)
        pnlSummaryTotal.Controls.Add(lblTotalIcon)
        pnlSummaryTotal.Cursor = Cursors.Hand
        pnlSummaryTotal.Location = New Point(24, 92)
        pnlSummaryTotal.Name = "pnlSummaryTotal"
        pnlSummaryTotal.Size = New Size(314, 86)
        pnlSummaryTotal.TabIndex = 5
        ' 
        ' lblTotalArrow
        ' 
        lblTotalArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTotalArrow.AutoSize = True
        lblTotalArrow.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblTotalArrow.ForeColor = Color.FromArgb(CByte(217), CByte(119), CByte(6))
        lblTotalArrow.Location = New Point(282, 32)
        lblTotalArrow.Name = "lblTotalArrow"
        lblTotalArrow.Size = New Size(21, 21)
        lblTotalArrow.TabIndex = 4
        lblTotalArrow.Text = ">"
        ' 
        ' lblTotalSub
        ' 
        lblTotalSub.AutoSize = True
        lblTotalSub.Font = New Font("Segoe UI", 8F)
        lblTotalSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblTotalSub.Location = New Point(68, 56)
        lblTotalSub.Name = "lblTotalSub"
        lblTotalSub.Size = New Size(137, 13)
        lblTotalSub.TabIndex = 3
        lblTotalSub.Text = "All clearance submissions"
        ' 
        ' lblTotalTitle
        ' 
        lblTotalTitle.AutoSize = True
        lblTotalTitle.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        lblTotalTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblTotalTitle.Location = New Point(68, 38)
        lblTotalTitle.Name = "lblTotalTitle"
        lblTotalTitle.Size = New Size(83, 15)
        lblTotalTitle.TabIndex = 2
        lblTotalTitle.Text = "Total Requests"
        ' 
        ' lblTotalCount
        ' 
        lblTotalCount.AutoSize = True
        lblTotalCount.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        lblTotalCount.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblTotalCount.Location = New Point(68, 6)
        lblTotalCount.Name = "lblTotalCount"
        lblTotalCount.Size = New Size(28, 32)
        lblTotalCount.TabIndex = 1
        lblTotalCount.Text = "0"
        ' 
        ' lblTotalIcon
        ' 
        lblTotalIcon.BackColor = Color.FromArgb(CByte(254), CByte(243), CByte(199))
        lblTotalIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblTotalIcon.ForeColor = Color.FromArgb(CByte(217), CByte(119), CByte(6))
        lblTotalIcon.Location = New Point(16, 16)
        lblTotalIcon.Name = "lblTotalIcon"
        lblTotalIcon.Size = New Size(42, 42)
        lblTotalIcon.TabIndex = 0
        lblTotalIcon.Text = "📄"
        lblTotalIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateTimeBadge
        ' 
        lblDateTimeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTimeBadge.Font = New Font("Segoe UI", 8F)
        lblDateTimeBadge.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTimeBadge.Location = New Point(854, 16)
        lblDateTimeBadge.Name = "lblDateTimeBadge"
        lblDateTimeBadge.Size = New Size(100, 48)
        lblDateTimeBadge.TabIndex = 4
        lblDateTimeBadge.Text = "📅 Today"
        lblDateTimeBadge.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pnlStaffBadge
        ' 
        pnlStaffBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlStaffBadge.BackColor = Color.White
        pnlStaffBadge.BorderStyle = BorderStyle.FixedSingle
        pnlStaffBadge.Controls.Add(lblStaffRole)
        pnlStaffBadge.Controls.Add(lblStaffName)
        pnlStaffBadge.Controls.Add(lblStaffIcon)
        pnlStaffBadge.Location = New Point(680, 16)
        pnlStaffBadge.Name = "pnlStaffBadge"
        pnlStaffBadge.Size = New Size(168, 48)
        pnlStaffBadge.TabIndex = 3
        ' 
        ' lblStaffRole
        ' 
        lblStaffRole.AutoSize = True
        lblStaffRole.Font = New Font("Segoe UI", 7.5F)
        lblStaffRole.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblStaffRole.Location = New Point(38, 26)
        lblStaffRole.Name = "lblStaffRole"
        lblStaffRole.Size = New Size(72, 12)
        lblStaffRole.TabIndex = 2
        lblStaffRole.Text = "Clearing Officer"
        ' 
        ' lblStaffName
        ' 
        lblStaffName.AutoSize = True
        lblStaffName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblStaffName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblStaffName.Location = New Point(38, 8)
        lblStaffName.Name = "lblStaffName"
        lblStaffName.Size = New Size(80, 15)
        lblStaffName.TabIndex = 1
        lblStaffName.Text = "Staff Member"
        ' 
        ' lblStaffIcon
        ' 
        lblStaffIcon.AutoSize = True
        lblStaffIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblStaffIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblStaffIcon.Location = New Point(8, 10)
        lblStaffIcon.Name = "lblStaffIcon"
        lblStaffIcon.Size = New Size(38, 26)
        lblStaffIcon.TabIndex = 0
        lblStaffIcon.Text = "👤"
        ' 
        ' pnlOfficeBadge
        ' 
        pnlOfficeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlOfficeBadge.BackColor = Color.White
        pnlOfficeBadge.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeBadge.Controls.Add(lblOfficeSub)
        pnlOfficeBadge.Controls.Add(lblOfficeName)
        pnlOfficeBadge.Controls.Add(lblOfficeIcon)
        pnlOfficeBadge.Location = New Point(504, 16)
        pnlOfficeBadge.Name = "pnlOfficeBadge"
        pnlOfficeBadge.Size = New Size(168, 48)
        pnlOfficeBadge.TabIndex = 2
        ' 
        ' lblOfficeSub
        ' 
        lblOfficeSub.AutoSize = True
        lblOfficeSub.Font = New Font("Segoe UI", 7.5F)
        lblOfficeSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblOfficeSub.Location = New Point(38, 26)
        lblOfficeSub.Name = "lblOfficeSub"
        lblOfficeSub.Size = New Size(73, 12)
        lblOfficeSub.TabIndex = 2
        lblOfficeSub.Text = "Assigned Office"
        ' 
        ' lblOfficeName
        ' 
        lblOfficeName.AutoSize = True
        lblOfficeName.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblOfficeName.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblOfficeName.Location = New Point(38, 8)
        lblOfficeName.Name = "lblOfficeName"
        lblOfficeName.Size = New Size(90, 15)
        lblOfficeName.TabIndex = 1
        lblOfficeName.Text = "Assigned Office"
        ' 
        ' lblOfficeIcon
        ' 
        lblOfficeIcon.AutoSize = True
        lblOfficeIcon.Font = New Font("Segoe UI Emoji", 14F)
        lblOfficeIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblOfficeIcon.Location = New Point(8, 10)
        lblOfficeIcon.Name = "lblOfficeIcon"
        lblOfficeIcon.Size = New Size(38, 26)
        lblOfficeIcon.TabIndex = 0
        lblOfficeIcon.Text = "🏛"
        ' 
        ' lblHeaderSub
        ' 
        lblHeaderSub.AutoSize = True
        lblHeaderSub.Font = New Font("Segoe UI", 9.5F)
        lblHeaderSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblHeaderSub.Location = New Point(24, 56)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(405, 17)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "Review and manage clearance submissions for your assigned office."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(20, 16)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(199, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Staff Requests"
        ' 
        ' StaffRequestsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        ClientSize = New Size(1200, 808)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 750)
        Name = "StaffRequestsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EClearance - Staff Requests"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        CType(picSchoolLogo, ComponentModel.ISupportInitialize).EndInit()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlRightColumn.ResumeLayout(False)
        pnlMyOfficeCard.ResumeLayout(False)
        pnlMyOfficeCard.PerformLayout()
        pnlOfficeInner.ResumeLayout(False)
        pnlOfficeInner.PerformLayout()
        pnlQuickActionsCard.ResumeLayout(False)
        pnlQuickActionsCard.PerformLayout()
        pnlTableCard.ResumeLayout(False)
        pnlTableCard.PerformLayout()
        CType(dgvRequests, ComponentModel.ISupportInitialize).EndInit()
        pnlFilterBar.ResumeLayout(False)
        pnlFilterBar.PerformLayout()
        pnlSummaryPending.ResumeLayout(False)
        pnlSummaryPending.PerformLayout()
        pnlSummaryTotal.ResumeLayout(False)
        pnlSummaryTotal.PerformLayout()
        pnlStaffBadge.ResumeLayout(False)
        pnlStaffBadge.PerformLayout()
        pnlOfficeBadge.ResumeLayout(False)
        pnlOfficeBadge.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents picSchoolLogo As PictureBox
    Friend WithEvents lblLogoTitle As Label
    Friend WithEvents lblLogoSub As Label
    Friend WithEvents lblNavSection As Label
    Friend WithEvents btnNavDashboard As Button
    Friend WithEvents btnNavRequests As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblHeaderSub As Label
    Friend WithEvents pnlOfficeBadge As Panel
    Friend WithEvents lblOfficeIcon As Label
    Friend WithEvents lblOfficeName As Label
    Friend WithEvents lblOfficeSub As Label
    Friend WithEvents pnlStaffBadge As Panel
    Friend WithEvents lblStaffIcon As Label
    Friend WithEvents lblStaffName As Label
    Friend WithEvents lblStaffRole As Label
    Friend WithEvents lblDateTimeBadge As Label
    Friend WithEvents pnlSummaryTotal As Panel
    Friend WithEvents lblTotalIcon As Label
    Friend WithEvents lblTotalCount As Label
    Friend WithEvents lblTotalTitle As Label
    Friend WithEvents lblTotalSub As Label
    Friend WithEvents lblTotalArrow As Label
    Friend WithEvents pnlSummaryPending As Panel
    Friend WithEvents lblPendingIcon As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents lblPendingSub As Label
    Friend WithEvents lblPendingArrow As Label
    Friend WithEvents pnlFilterBar As Panel
    Friend WithEvents lblSearchIcon As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnFilterAll As Button
    Friend WithEvents btnFilterPending As Button
    Friend WithEvents btnFilterReview As Button
    Friend WithEvents btnFilterCleared As Button
    Friend WithEvents btnFilterRejected As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlTableCard As Panel
    Friend WithEvents lblTableIcon As Label
    Friend WithEvents lblTableTitle As Label
    Friend WithEvents lblRecordCount As Label
    Friend WithEvents dgvRequests As DataGridView
    Friend WithEvents colReqNum As DataGridViewTextBoxColumn
    Friend WithEvents colReqRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colReqStudentNo As DataGridViewTextBoxColumn
    Friend WithEvents colReqStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colReqRequirement As DataGridViewTextBoxColumn
    Friend WithEvents colReqSubmittedAt As DataGridViewTextBoxColumn
    Friend WithEvents colReqStatus As DataGridViewTextBoxColumn
    Friend WithEvents colReqAction As DataGridViewButtonColumn
    Friend WithEvents pnlRightColumn As Panel
    Friend WithEvents pnlQuickActionsCard As Panel
    Friend WithEvents lblQuickTitle As Label
    Friend WithEvents btnQuickReviewNext As Button
    Friend WithEvents btnQuickRefresh As Button
    Friend WithEvents btnQuickHistory As Button
    Friend WithEvents pnlMyOfficeCard As Panel
    Friend WithEvents lblMyOfficeHeader As Label
    Friend WithEvents pnlOfficeInner As Panel
    Friend WithEvents lblOfficeBadgeIcon As Label
    Friend WithEvents lblMyOfficeTitle As Label
    Friend WithEvents lblMyOfficeStatus As Label
    Friend WithEvents lblOfficeDescSub As Label

End Class
