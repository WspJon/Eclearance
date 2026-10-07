<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffDashboardForm
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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        pnlSidebar = New Panel()
        pnlNavIndicator = New Panel()
        btnNavLogout = New Button()
        btnNavHistory = New Button()
        btnNavRequests = New Button()
        btnNavDashboard = New Button()
        lblNavSection = New Label()
        pnlLogo = New Panel()
        lblLogoSub = New Label()
        lblLogoTitle = New Label()
        picSchoolLogo = New PictureBox()
        pnlViewHost = New Panel()
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
        btnQuickReview = New Button()
        btnQuickRequests = New Button()
        lblQuickTitle = New Label()
        pnlRecentCard = New Panel()
        dgvRecent = New DataGridView()
        colNum = New DataGridViewTextBoxColumn()
        colRecordID = New DataGridViewTextBoxColumn()
        colStudentNo = New DataGridViewTextBoxColumn()
        colStudentName = New DataGridViewTextBoxColumn()
        colRequirement = New DataGridViewTextBoxColumn()
        colSubmittedAt = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colAction = New DataGridViewButtonColumn()
        btnViewAll = New Button()
        lblRecentTitle = New Label()
        lblRecentIcon = New Label()
        pnlSummaryCards = New Panel()
        pnlCardRejected = New Panel()
        lblRejectedArrow = New Label()
        lblRejectedSub = New Label()
        lblRejectedTitle = New Label()
        lblRejectedCount = New Label()
        lblRejectedIcon = New Label()
        pnlCardApproved = New Panel()
        lblApprovedArrow = New Label()
        lblApprovedSub = New Label()
        lblApprovedTitle = New Label()
        lblApprovedCount = New Label()
        lblApprovedIcon = New Label()
        pnlCardReview = New Panel()
        lblReviewArrow = New Label()
        lblReviewSub = New Label()
        lblReviewTitle = New Label()
        lblReviewCount = New Label()
        lblReviewIcon = New Label()
        pnlCardPending = New Panel()
        lblPendingArrow = New Label()
        lblPendingSub = New Label()
        lblPendingTitle = New Label()
        lblPendingCount = New Label()
        lblPendingIcon = New Label()
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
        pnlRecentCard.SuspendLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).BeginInit()
        pnlSummaryCards.SuspendLayout()
        pnlCardRejected.SuspendLayout()
        pnlCardApproved.SuspendLayout()
        pnlCardReview.SuspendLayout()
        pnlCardPending.SuspendLayout()
        pnlStaffBadge.SuspendLayout()
        pnlOfficeBadge.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(15), CByte(39), CByte(74))
        pnlSidebar.Controls.Add(pnlNavIndicator)
        pnlSidebar.Controls.Add(btnNavLogout)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavRequests)
        pnlSidebar.Controls.Add(btnNavDashboard)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlNavIndicator
        ' 
        pnlNavIndicator.BackColor = Color.FromArgb(CByte(59), CByte(130), CByte(246))
        pnlNavIndicator.Location = New Point(8, 120)
        pnlNavIndicator.Name = "pnlNavIndicator"
        pnlNavIndicator.Size = New Size(4, 44)
        pnlNavIndicator.TabIndex = 6
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNavLogout.Cursor = Cursors.Hand
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F)
        btnNavLogout.ForeColor = Color.FromArgb(CByte(160), CByte(180), CByte(208))
        btnNavLogout.Location = New Point(16, 735)
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
        btnNavHistory.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavHistory.ForeColor = Color.White
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
        btnNavRequests.UseVisualStyleBackColor = True
        ' 
        ' btnNavDashboard
        ' 
        btnNavDashboard.BackColor = Color.FromArgb(CByte(28), CByte(91), CByte(184))
        btnNavDashboard.Cursor = Cursors.Hand
        btnNavDashboard.FlatAppearance.BorderSize = 0
        btnNavDashboard.FlatStyle = FlatStyle.Flat
        btnNavDashboard.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold)
        btnNavDashboard.ForeColor = Color.White
        btnNavDashboard.Location = New Point(16, 120)
        btnNavDashboard.Name = "btnNavDashboard"
        btnNavDashboard.Size = New Size(188, 44)
        btnNavDashboard.TabIndex = 2
        btnNavDashboard.Text = "  Dashboard"
        btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnNavDashboard.UseVisualStyleBackColor = False
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
        lblLogoSub.Location = New Point(50, 44)
        lblLogoSub.Name = "lblLogoSub"
        lblLogoSub.Size = New Size(118, 12)
        lblLogoSub.TabIndex = 2
        lblLogoSub.Text = "Student Clearance System"
        ' 
        ' lblLogoTitle
        ' 
        lblLogoTitle.AutoSize = True
        lblLogoTitle.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        lblLogoTitle.ForeColor = Color.White
        lblLogoTitle.Location = New Point(50, 16)
        lblLogoTitle.Name = "lblLogoTitle"
        lblLogoTitle.Size = New Size(115, 28)
        lblLogoTitle.TabIndex = 1
        lblLogoTitle.Text = "EClearance"
        ' 
        ' picSchoolLogo
        ' 
        picSchoolLogo.Location = New Point(8, 16)
        picSchoolLogo.Name = "picSchoolLogo"
        picSchoolLogo.Size = New Size(39, 40)
        picSchoolLogo.SizeMode = PictureBoxSizeMode.Zoom
        picSchoolLogo.TabIndex = 0
        picSchoolLogo.TabStop = False
        ' 
        ' pnlViewHost
        ' 
        pnlViewHost.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlViewHost.Dock = DockStyle.Fill
        pnlViewHost.Location = New Point(220, 0)
        pnlViewHost.Name = "pnlViewHost"
        pnlViewHost.Size = New Size(980, 800)
        pnlViewHost.TabIndex = 2
        pnlViewHost.Visible = False
        ' 
        ' pnlMain
        ' 
        pnlMain.BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        pnlMain.Controls.Add(pnlRightColumn)
        pnlMain.Controls.Add(pnlRecentCard)
        pnlMain.Controls.Add(pnlSummaryCards)
        pnlMain.Controls.Add(lblDateTimeBadge)
        pnlMain.Controls.Add(pnlStaffBadge)
        pnlMain.Controls.Add(pnlOfficeBadge)
        pnlMain.Controls.Add(lblHeaderSub)
        pnlMain.Controls.Add(lblHeaderTitle)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' pnlRightColumn
        ' 
        pnlRightColumn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        pnlRightColumn.Controls.Add(pnlMyOfficeCard)
        pnlRightColumn.Controls.Add(pnlQuickActionsCard)
        pnlRightColumn.Location = New Point(680, 204)
        pnlRightColumn.Name = "pnlRightColumn"
        pnlRightColumn.Size = New Size(272, 560)
        pnlRightColumn.TabIndex = 8
        ' 
        ' pnlMyOfficeCard
        ' 
        pnlMyOfficeCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlMyOfficeCard.BackColor = Color.White
        pnlMyOfficeCard.BorderStyle = BorderStyle.FixedSingle
        pnlMyOfficeCard.Controls.Add(pnlOfficeInner)
        pnlMyOfficeCard.Controls.Add(lblMyOfficeHeader)
        pnlMyOfficeCard.Location = New Point(0, 260)
        pnlMyOfficeCard.Name = "pnlMyOfficeCard"
        pnlMyOfficeCard.Padding = New Padding(16)
        pnlMyOfficeCard.Size = New Size(272, 300)
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
        lblOfficeDescSub.Size = New Size(161, 13)
        lblOfficeDescSub.TabIndex = 3
        lblOfficeDescSub.Text = "You are assigned to this office"
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
        lblMyOfficeTitle.Size = New Size(102, 19)
        lblMyOfficeTitle.TabIndex = 1
        lblMyOfficeTitle.Text = "Library Office"
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
        pnlQuickActionsCard.Controls.Add(btnQuickReview)
        pnlQuickActionsCard.Controls.Add(btnQuickRequests)
        pnlQuickActionsCard.Controls.Add(lblQuickTitle)
        pnlQuickActionsCard.Location = New Point(0, 0)
        pnlQuickActionsCard.Name = "pnlQuickActionsCard"
        pnlQuickActionsCard.Padding = New Padding(16)
        pnlQuickActionsCard.Size = New Size(272, 246)
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
        btnQuickHistory.Location = New Point(16, 172)
        btnQuickHistory.Name = "btnQuickHistory"
        btnQuickHistory.Size = New Size(238, 54)
        btnQuickHistory.TabIndex = 3
        btnQuickHistory.Text = "🕒  View History" & vbCrLf & "     See processed records"
        btnQuickHistory.TextAlign = ContentAlignment.MiddleLeft
        btnQuickHistory.UseVisualStyleBackColor = False
        ' 
        ' btnQuickReview
        ' 
        btnQuickReview.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnQuickReview.BackColor = Color.FromArgb(CByte(240), CByte(253), CByte(244))
        btnQuickReview.Cursor = Cursors.Hand
        btnQuickReview.FlatAppearance.BorderColor = Color.FromArgb(CByte(187), CByte(247), CByte(208))
        btnQuickReview.FlatStyle = FlatStyle.Flat
        btnQuickReview.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnQuickReview.ForeColor = Color.FromArgb(CByte(21), CByte(128), CByte(61))
        btnQuickReview.Location = New Point(16, 110)
        btnQuickReview.Name = "btnQuickReview"
        btnQuickReview.Size = New Size(238, 54)
        btnQuickReview.TabIndex = 2
        btnQuickReview.Text = "👥  Review Latest Submission" & vbCrLf & "     Check newest request"
        btnQuickReview.TextAlign = ContentAlignment.MiddleLeft
        btnQuickReview.UseVisualStyleBackColor = False
        ' 
        ' btnQuickRequests
        ' 
        btnQuickRequests.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnQuickRequests.BackColor = Color.FromArgb(CByte(11), CByte(99), CByte(229))
        btnQuickRequests.Cursor = Cursors.Hand
        btnQuickRequests.FlatAppearance.BorderSize = 0
        btnQuickRequests.FlatStyle = FlatStyle.Flat
        btnQuickRequests.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnQuickRequests.ForeColor = Color.White
        btnQuickRequests.Location = New Point(16, 48)
        btnQuickRequests.Name = "btnQuickRequests"
        btnQuickRequests.Size = New Size(238, 54)
        btnQuickRequests.TabIndex = 1
        btnQuickRequests.Text = "📄  View Requests" & vbCrLf & "     Browse all office requests"
        btnQuickRequests.TextAlign = ContentAlignment.MiddleLeft
        btnQuickRequests.UseVisualStyleBackColor = False
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
        ' pnlRecentCard
        ' 
        pnlRecentCard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlRecentCard.BackColor = Color.White
        pnlRecentCard.BorderStyle = BorderStyle.FixedSingle
        pnlRecentCard.Controls.Add(dgvRecent)
        pnlRecentCard.Controls.Add(btnViewAll)
        pnlRecentCard.Controls.Add(lblRecentTitle)
        pnlRecentCard.Controls.Add(lblRecentIcon)
        pnlRecentCard.Location = New Point(28, 204)
        pnlRecentCard.Name = "pnlRecentCard"
        pnlRecentCard.Padding = New Padding(16)
        pnlRecentCard.Size = New Size(636, 560)
        pnlRecentCard.TabIndex = 7
        ' 
        ' dgvRecent
        ' 
        dgvRecent.AllowUserToAddRows = False
        dgvRecent.AllowUserToDeleteRows = False
        dgvRecent.AllowUserToResizeRows = False
        dgvRecent.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvRecent.BackgroundColor = Color.White
        dgvRecent.BorderStyle = BorderStyle.None
        dgvRecent.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRecent.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgvRecent.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        dgvRecent.ColumnHeadersHeight = 42
        dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvRecent.Columns.AddRange(New DataGridViewColumn() {colNum, colRecordID, colStudentNo, colStudentName, colRequirement, colSubmittedAt, colStatus, colAction})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(248), CByte(250), CByte(252))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvRecent.DefaultCellStyle = DataGridViewCellStyle6
        dgvRecent.EnableHeadersVisualStyles = False
        dgvRecent.GridColor = Color.FromArgb(CByte(241), CByte(245), CByte(249))
        dgvRecent.Location = New Point(16, 52)
        dgvRecent.MultiSelect = False
        dgvRecent.Name = "dgvRecent"
        dgvRecent.ReadOnly = True
        dgvRecent.RowHeadersVisible = False
        dgvRecent.RowTemplate.Height = 46
        dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecent.Size = New Size(602, 490)
        dgvRecent.TabIndex = 3
        ' 
        ' colNum
        ' 
        colNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.Padding = New Padding(8, 0, 0, 0)
        colNum.DefaultCellStyle = DataGridViewCellStyle5
        colNum.HeaderText = "#"
        colNum.Name = "colNum"
        colNum.ReadOnly = True
        colNum.Resizable = DataGridViewTriState.False
        colNum.Width = 40
        ' 
        ' colRecordID
        ' 
        colRecordID.HeaderText = "RecordID"
        colRecordID.Name = "colRecordID"
        colRecordID.ReadOnly = True
        colRecordID.Visible = False
        ' 
        ' colStudentNo
        ' 
        colStudentNo.FillWeight = 14F
        colStudentNo.HeaderText = "Student No."
        colStudentNo.MinimumWidth = 85
        colStudentNo.Name = "colStudentNo"
        colStudentNo.ReadOnly = True
        ' 
        ' colStudentName
        ' 
        colStudentName.FillWeight = 22F
        colStudentName.HeaderText = "Student Name"
        colStudentName.MinimumWidth = 110
        colStudentName.Name = "colStudentName"
        colStudentName.ReadOnly = True
        ' 
        ' colRequirement
        ' 
        colRequirement.FillWeight = 24F
        colRequirement.HeaderText = "Requirement"
        colRequirement.MinimumWidth = 120
        colRequirement.Name = "colRequirement"
        colRequirement.ReadOnly = True
        ' 
        ' colSubmittedAt
        ' 
        colSubmittedAt.FillWeight = 18F
        colSubmittedAt.HeaderText = "Submitted At"
        colSubmittedAt.MinimumWidth = 120
        colSubmittedAt.Name = "colSubmittedAt"
        colSubmittedAt.ReadOnly = True
        ' 
        ' colStatus
        ' 
        colStatus.FillWeight = 12F
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 95
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        ' 
        ' colAction
        ' 
        colAction.FillWeight = 10F
        colAction.FlatStyle = FlatStyle.Flat
        colAction.HeaderText = "Action"
        colAction.MinimumWidth = 85
        colAction.Name = "colAction"
        colAction.ReadOnly = True
        colAction.Text = "Review"
        colAction.UseColumnTextForButtonValue = True
        ' 
        ' btnViewAll
        ' 
        btnViewAll.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnViewAll.Cursor = Cursors.Hand
        btnViewAll.FlatAppearance.BorderSize = 0
        btnViewAll.FlatStyle = FlatStyle.Flat
        btnViewAll.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnViewAll.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        btnViewAll.Location = New Point(532, 14)
        btnViewAll.Name = "btnViewAll"
        btnViewAll.Size = New Size(86, 26)
        btnViewAll.TabIndex = 2
        btnViewAll.Text = "View All >"
        btnViewAll.TextAlign = ContentAlignment.MiddleRight
        btnViewAll.UseVisualStyleBackColor = True
        ' 
        ' lblRecentTitle
        ' 
        lblRecentTitle.AutoSize = True
        lblRecentTitle.Font = New Font("Segoe UI", 11.5F, FontStyle.Bold)
        lblRecentTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRecentTitle.Location = New Point(44, 16)
        lblRecentTitle.Name = "lblRecentTitle"
        lblRecentTitle.Size = New Size(161, 21)
        lblRecentTitle.TabIndex = 1
        lblRecentTitle.Text = "Recent Submissions"
        ' 
        ' lblRecentIcon
        ' 
        lblRecentIcon.AutoSize = True
        lblRecentIcon.Font = New Font("Segoe UI Emoji", 12F)
        lblRecentIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblRecentIcon.Location = New Point(16, 16)
        lblRecentIcon.Name = "lblRecentIcon"
        lblRecentIcon.Size = New Size(32, 21)
        lblRecentIcon.TabIndex = 0
        lblRecentIcon.Text = "📄"
        ' 
        ' pnlSummaryCards
        ' 
        pnlSummaryCards.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlSummaryCards.Controls.Add(pnlCardRejected)
        pnlSummaryCards.Controls.Add(pnlCardApproved)
        pnlSummaryCards.Controls.Add(pnlCardReview)
        pnlSummaryCards.Controls.Add(pnlCardPending)
        pnlSummaryCards.Location = New Point(28, 92)
        pnlSummaryCards.Name = "pnlSummaryCards"
        pnlSummaryCards.Size = New Size(924, 96)
        pnlSummaryCards.TabIndex = 6
        ' 
        ' pnlCardRejected
        ' 
        pnlCardRejected.BackColor = Color.White
        pnlCardRejected.BorderStyle = BorderStyle.FixedSingle
        pnlCardRejected.Controls.Add(lblRejectedArrow)
        pnlCardRejected.Controls.Add(lblRejectedSub)
        pnlCardRejected.Controls.Add(lblRejectedTitle)
        pnlCardRejected.Controls.Add(lblRejectedCount)
        pnlCardRejected.Controls.Add(lblRejectedIcon)
        pnlCardRejected.Location = New Point(696, 0)
        pnlCardRejected.Name = "pnlCardRejected"
        pnlCardRejected.Size = New Size(228, 96)
        pnlCardRejected.TabIndex = 3
        ' 
        ' lblRejectedArrow
        ' 
        lblRejectedArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblRejectedArrow.AutoSize = True
        lblRejectedArrow.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblRejectedArrow.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        lblRejectedArrow.Location = New Point(200, 38)
        lblRejectedArrow.Name = "lblRejectedArrow"
        lblRejectedArrow.Size = New Size(20, 20)
        lblRejectedArrow.TabIndex = 4
        lblRejectedArrow.Text = ">"
        ' 
        ' lblRejectedSub
        ' 
        lblRejectedSub.AutoSize = True
        lblRejectedSub.Font = New Font("Segoe UI", 7.5F)
        lblRejectedSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblRejectedSub.Location = New Point(60, 64)
        lblRejectedSub.Name = "lblRejectedSub"
        lblRejectedSub.Size = New Size(123, 12)
        lblRejectedSub.TabIndex = 3
        lblRejectedSub.Text = "Did not meet requirements"
        ' 
        ' lblRejectedTitle
        ' 
        lblRejectedTitle.AutoSize = True
        lblRejectedTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblRejectedTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblRejectedTitle.Location = New Point(60, 44)
        lblRejectedTitle.Name = "lblRejectedTitle"
        lblRejectedTitle.Size = New Size(87, 15)
        lblRejectedTitle.TabIndex = 2
        lblRejectedTitle.Text = "Rejected Today"
        ' 
        ' lblRejectedCount
        ' 
        lblRejectedCount.AutoSize = True
        lblRejectedCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblRejectedCount.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblRejectedCount.Location = New Point(60, 12)
        lblRejectedCount.Name = "lblRejectedCount"
        lblRejectedCount.Size = New Size(26, 30)
        lblRejectedCount.TabIndex = 1
        lblRejectedCount.Text = "0"
        ' 
        ' lblRejectedIcon
        ' 
        lblRejectedIcon.BackColor = Color.FromArgb(CByte(254), CByte(226), CByte(226))
        lblRejectedIcon.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblRejectedIcon.ForeColor = Color.FromArgb(CByte(220), CByte(38), CByte(38))
        lblRejectedIcon.Location = New Point(14, 16)
        lblRejectedIcon.Name = "lblRejectedIcon"
        lblRejectedIcon.Size = New Size(36, 36)
        lblRejectedIcon.TabIndex = 0
        lblRejectedIcon.Text = "✕"
        lblRejectedIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlCardApproved
        ' 
        pnlCardApproved.BackColor = Color.White
        pnlCardApproved.BorderStyle = BorderStyle.FixedSingle
        pnlCardApproved.Controls.Add(lblApprovedArrow)
        pnlCardApproved.Controls.Add(lblApprovedSub)
        pnlCardApproved.Controls.Add(lblApprovedTitle)
        pnlCardApproved.Controls.Add(lblApprovedCount)
        pnlCardApproved.Controls.Add(lblApprovedIcon)
        pnlCardApproved.Location = New Point(464, 0)
        pnlCardApproved.Name = "pnlCardApproved"
        pnlCardApproved.Size = New Size(224, 96)
        pnlCardApproved.TabIndex = 2
        ' 
        ' lblApprovedArrow
        ' 
        lblApprovedArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblApprovedArrow.AutoSize = True
        lblApprovedArrow.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblApprovedArrow.ForeColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        lblApprovedArrow.Location = New Point(196, 38)
        lblApprovedArrow.Name = "lblApprovedArrow"
        lblApprovedArrow.Size = New Size(20, 20)
        lblApprovedArrow.TabIndex = 4
        lblApprovedArrow.Text = ">"
        ' 
        ' lblApprovedSub
        ' 
        lblApprovedSub.AutoSize = True
        lblApprovedSub.Font = New Font("Segoe UI", 7.5F)
        lblApprovedSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblApprovedSub.Location = New Point(60, 64)
        lblApprovedSub.Name = "lblApprovedSub"
        lblApprovedSub.Size = New Size(93, 12)
        lblApprovedSub.TabIndex = 3
        lblApprovedSub.Text = "Cleared submissions"
        ' 
        ' lblApprovedTitle
        ' 
        lblApprovedTitle.AutoSize = True
        lblApprovedTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblApprovedTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblApprovedTitle.Location = New Point(60, 44)
        lblApprovedTitle.Name = "lblApprovedTitle"
        lblApprovedTitle.Size = New Size(94, 15)
        lblApprovedTitle.TabIndex = 2
        lblApprovedTitle.Text = "Approved Today"
        ' 
        ' lblApprovedCount
        ' 
        lblApprovedCount.AutoSize = True
        lblApprovedCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblApprovedCount.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblApprovedCount.Location = New Point(60, 12)
        lblApprovedCount.Name = "lblApprovedCount"
        lblApprovedCount.Size = New Size(26, 30)
        lblApprovedCount.TabIndex = 1
        lblApprovedCount.Text = "0"
        ' 
        ' lblApprovedIcon
        ' 
        lblApprovedIcon.BackColor = Color.FromArgb(CByte(220), CByte(252), CByte(231))
        lblApprovedIcon.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        lblApprovedIcon.ForeColor = Color.FromArgb(CByte(22), CByte(163), CByte(74))
        lblApprovedIcon.Location = New Point(14, 16)
        lblApprovedIcon.Name = "lblApprovedIcon"
        lblApprovedIcon.Size = New Size(36, 36)
        lblApprovedIcon.TabIndex = 0
        lblApprovedIcon.Text = "✓"
        lblApprovedIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlCardReview
        ' 
        pnlCardReview.BackColor = Color.White
        pnlCardReview.BorderStyle = BorderStyle.FixedSingle
        pnlCardReview.Controls.Add(lblReviewArrow)
        pnlCardReview.Controls.Add(lblReviewSub)
        pnlCardReview.Controls.Add(lblReviewTitle)
        pnlCardReview.Controls.Add(lblReviewCount)
        pnlCardReview.Controls.Add(lblReviewIcon)
        pnlCardReview.Location = New Point(232, 0)
        pnlCardReview.Name = "pnlCardReview"
        pnlCardReview.Size = New Size(224, 96)
        pnlCardReview.TabIndex = 1
        ' 
        ' lblReviewArrow
        ' 
        lblReviewArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblReviewArrow.AutoSize = True
        lblReviewArrow.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblReviewArrow.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblReviewArrow.Location = New Point(196, 38)
        lblReviewArrow.Name = "lblReviewArrow"
        lblReviewArrow.Size = New Size(20, 20)
        lblReviewArrow.TabIndex = 4
        lblReviewArrow.Text = ">"
        ' 
        ' lblReviewSub
        ' 
        lblReviewSub.AutoSize = True
        lblReviewSub.Font = New Font("Segoe UI", 7.5F)
        lblReviewSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblReviewSub.Location = New Point(60, 64)
        lblReviewSub.Name = "lblReviewSub"
        lblReviewSub.Size = New Size(91, 12)
        lblReviewSub.TabIndex = 3
        lblReviewSub.Text = "Currently in process"
        ' 
        ' lblReviewTitle
        ' 
        lblReviewTitle.AutoSize = True
        lblReviewTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblReviewTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblReviewTitle.Location = New Point(60, 44)
        lblReviewTitle.Name = "lblReviewTitle"
        lblReviewTitle.Size = New Size(79, 15)
        lblReviewTitle.TabIndex = 2
        lblReviewTitle.Text = "Under Review"
        ' 
        ' lblReviewCount
        ' 
        lblReviewCount.AutoSize = True
        lblReviewCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblReviewCount.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblReviewCount.Location = New Point(60, 12)
        lblReviewCount.Name = "lblReviewCount"
        lblReviewCount.Size = New Size(26, 30)
        lblReviewCount.TabIndex = 1
        lblReviewCount.Text = "0"
        ' 
        ' lblReviewIcon
        ' 
        lblReviewIcon.BackColor = Color.FromArgb(CByte(219), CByte(234), CByte(254))
        lblReviewIcon.Font = New Font("Segoe UI", 12F)
        lblReviewIcon.ForeColor = Color.FromArgb(CByte(37), CByte(99), CByte(235))
        lblReviewIcon.Location = New Point(14, 16)
        lblReviewIcon.Name = "lblReviewIcon"
        lblReviewIcon.Size = New Size(36, 36)
        lblReviewIcon.TabIndex = 0
        lblReviewIcon.Text = "⏳"
        lblReviewIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlCardPending
        ' 
        pnlCardPending.BackColor = Color.White
        pnlCardPending.BorderStyle = BorderStyle.FixedSingle
        pnlCardPending.Controls.Add(lblPendingArrow)
        pnlCardPending.Controls.Add(lblPendingSub)
        pnlCardPending.Controls.Add(lblPendingTitle)
        pnlCardPending.Controls.Add(lblPendingCount)
        pnlCardPending.Controls.Add(lblPendingIcon)
        pnlCardPending.Location = New Point(0, 0)
        pnlCardPending.Name = "pnlCardPending"
        pnlCardPending.Size = New Size(224, 96)
        pnlCardPending.TabIndex = 0
        ' 
        ' lblPendingArrow
        ' 
        lblPendingArrow.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblPendingArrow.AutoSize = True
        lblPendingArrow.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblPendingArrow.ForeColor = Color.FromArgb(CByte(217), CByte(119), CByte(6))
        lblPendingArrow.Location = New Point(196, 38)
        lblPendingArrow.Name = "lblPendingArrow"
        lblPendingArrow.Size = New Size(20, 20)
        lblPendingArrow.TabIndex = 4
        lblPendingArrow.Text = ">"
        ' 
        ' lblPendingSub
        ' 
        lblPendingSub.AutoSize = True
        lblPendingSub.Font = New Font("Segoe UI", 7.5F)
        lblPendingSub.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblPendingSub.Location = New Point(60, 64)
        lblPendingSub.Name = "lblPendingSub"
        lblPendingSub.Size = New Size(95, 12)
        lblPendingSub.TabIndex = 3
        lblPendingSub.Text = "Awaiting your review"
        ' 
        ' lblPendingTitle
        ' 
        lblPendingTitle.AutoSize = True
        lblPendingTitle.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
        lblPendingTitle.ForeColor = Color.FromArgb(CByte(30), CByte(41), CByte(59))
        lblPendingTitle.Location = New Point(60, 44)
        lblPendingTitle.Name = "lblPendingTitle"
        lblPendingTitle.Size = New Size(101, 15)
        lblPendingTitle.TabIndex = 2
        lblPendingTitle.Text = "Pending Requests"
        ' 
        ' lblPendingCount
        ' 
        lblPendingCount.AutoSize = True
        lblPendingCount.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        lblPendingCount.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblPendingCount.Location = New Point(60, 12)
        lblPendingCount.Name = "lblPendingCount"
        lblPendingCount.Size = New Size(26, 30)
        lblPendingCount.TabIndex = 1
        lblPendingCount.Text = "0"
        ' 
        ' lblPendingIcon
        ' 
        lblPendingIcon.BackColor = Color.FromArgb(CByte(254), CByte(243), CByte(199))
        lblPendingIcon.Font = New Font("Segoe UI", 12F)
        lblPendingIcon.ForeColor = Color.FromArgb(CByte(217), CByte(119), CByte(6))
        lblPendingIcon.Location = New Point(14, 16)
        lblPendingIcon.Name = "lblPendingIcon"
        lblPendingIcon.Size = New Size(36, 36)
        lblPendingIcon.TabIndex = 0
        lblPendingIcon.Text = "📄"
        lblPendingIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblDateTimeBadge
        ' 
        lblDateTimeBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblDateTimeBadge.Font = New Font("Segoe UI", 8F)
        lblDateTimeBadge.ForeColor = Color.FromArgb(CByte(100), CByte(116), CByte(139))
        lblDateTimeBadge.Location = New Point(854, 16)
        lblDateTimeBadge.Name = "lblDateTimeBadge"
        lblDateTimeBadge.Size = New Size(98, 48)
        lblDateTimeBadge.TabIndex = 5
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
        pnlStaffBadge.TabIndex = 4
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
        pnlOfficeBadge.TabIndex = 3
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
        lblHeaderSub.Location = New Point(28, 56)
        lblHeaderSub.Name = "lblHeaderSub"
        lblHeaderSub.Size = New Size(294, 17)
        lblHeaderSub.TabIndex = 1
        lblHeaderSub.Text = "Manage your assigned office clearance requests."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblHeaderTitle.ForeColor = Color.FromArgb(CByte(15), CByte(23), CByte(42))
        lblHeaderTitle.Location = New Point(24, 16)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(224, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "Staff Dashboard"
        ' 
        ' StaffDashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(244), CByte(247), CByte(251))
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlViewHost)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(1100, 750)
        Name = "StaffDashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EClearance - Staff Dashboard"
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
        pnlRecentCard.ResumeLayout(False)
        pnlRecentCard.PerformLayout()
        CType(dgvRecent, ComponentModel.ISupportInitialize).EndInit()
        pnlSummaryCards.ResumeLayout(False)
        pnlCardRejected.ResumeLayout(False)
        pnlCardRejected.PerformLayout()
        pnlCardApproved.ResumeLayout(False)
        pnlCardApproved.PerformLayout()
        pnlCardReview.ResumeLayout(False)
        pnlCardReview.PerformLayout()
        pnlCardPending.ResumeLayout(False)
        pnlCardPending.PerformLayout()
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
    Friend WithEvents pnlSummaryCards As Panel
    Friend WithEvents pnlCardPending As Panel
    Friend WithEvents lblPendingIcon As Label
    Friend WithEvents lblPendingCount As Label
    Friend WithEvents lblPendingTitle As Label
    Friend WithEvents lblPendingSub As Label
    Friend WithEvents lblPendingArrow As Label
    Friend WithEvents pnlCardReview As Panel
    Friend WithEvents lblReviewIcon As Label
    Friend WithEvents lblReviewCount As Label
    Friend WithEvents lblReviewTitle As Label
    Friend WithEvents lblReviewSub As Label
    Friend WithEvents lblReviewArrow As Label
    Friend WithEvents pnlCardApproved As Panel
    Friend WithEvents lblApprovedIcon As Label
    Friend WithEvents lblApprovedCount As Label
    Friend WithEvents lblApprovedTitle As Label
    Friend WithEvents lblApprovedSub As Label
    Friend WithEvents lblApprovedArrow As Label
    Friend WithEvents pnlCardRejected As Panel
    Friend WithEvents lblRejectedIcon As Label
    Friend WithEvents lblRejectedCount As Label
    Friend WithEvents lblRejectedTitle As Label
    Friend WithEvents lblRejectedSub As Label
    Friend WithEvents lblRejectedArrow As Label
    Friend WithEvents pnlRecentCard As Panel
    Friend WithEvents lblRecentIcon As Label
    Friend WithEvents lblRecentTitle As Label
    Friend WithEvents btnViewAll As Button
    Friend WithEvents dgvRecent As DataGridView
    Friend WithEvents colNum As DataGridViewTextBoxColumn
    Friend WithEvents colRecordID As DataGridViewTextBoxColumn
    Friend WithEvents colStudentNo As DataGridViewTextBoxColumn
    Friend WithEvents colStudentName As DataGridViewTextBoxColumn
    Friend WithEvents colRequirement As DataGridViewTextBoxColumn
    Friend WithEvents colSubmittedAt As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colAction As DataGridViewButtonColumn
    Friend WithEvents pnlRightColumn As Panel
    Friend WithEvents pnlQuickActionsCard As Panel
    Friend WithEvents lblQuickTitle As Label
    Friend WithEvents btnQuickRequests As Button
    Friend WithEvents btnQuickReview As Button
    Friend WithEvents btnQuickHistory As Button
    Friend WithEvents pnlMyOfficeCard As Panel
    Friend WithEvents lblMyOfficeHeader As Label
    Friend WithEvents pnlOfficeInner As Panel
    Friend WithEvents lblOfficeBadgeIcon As Label
    Friend WithEvents lblMyOfficeTitle As Label
    Friend WithEvents lblMyOfficeStatus As Label
    Friend WithEvents lblOfficeDescSub As Label
    Friend WithEvents pnlNavIndicator As Panel
    Friend WithEvents pnlViewHost As Panel

End Class
