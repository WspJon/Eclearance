<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentClearanceForm
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
        pnlSidebar = New Panel()
        pnlUserProfile = New Panel()
        btnNavLogout = New Button()
        lblUserRole = New Label()
        lblUserName = New Label()
        lblUserAvatar = New Label()
        btnNavHistory = New Button()
        btnNavMyClearance = New Button()
        lblNavSection = New Label()
        pnlLogo = New Panel()
        lblLogoText = New Label()
        lblLogoIcon = New Label()
        pnlMain = New Panel()
        pnlViewHost = New Panel()
        pnlPagination = New Panel()
        btnNextPage = New Button()
        btnPage2 = New Button()
        btnPage1 = New Button()
        lblShowingOffices = New Label()
        flpOfficesGrid = New FlowLayoutPanel()
        pnlOfficeCard1 = New Panel()
        btnAction1 = New Button()
        pnlFileAttach1 = New Panel()
        lblFileDate1 = New Label()
        lblFileName1 = New Label()
        lblFileIcon1 = New Label()
        lblOfficeDesc1 = New Label()
        lblOfficeStatusBadge1 = New Label()
        lblOfficeTitle1 = New Label()
        lblOfficeIcon1 = New Label()
        pnlOfficeCard2 = New Panel()
        btnAction2 = New Button()
        pnlFileAttach2 = New Panel()
        lblFileDate2 = New Label()
        lblFileName2 = New Label()
        lblFileIcon2 = New Label()
        lblOfficeDesc2 = New Label()
        lblOfficeStatusBadge2 = New Label()
        lblOfficeTitle2 = New Label()
        lblOfficeIcon2 = New Label()
        pnlOfficeCard3 = New Panel()
        btnAction3 = New Button()
        pnlFileAttach3 = New Panel()
        lblFileDate3 = New Label()
        lblFileName3 = New Label()
        lblFileIcon3 = New Label()
        lblOfficeDesc3 = New Label()
        lblOfficeStatusBadge3 = New Label()
        lblOfficeTitle3 = New Label()
        lblOfficeIcon3 = New Label()
        pnlOfficeCard4 = New Panel()
        btnAction4 = New Button()
        pnlFileAttach4 = New Panel()
        lblFileDate4 = New Label()
        lblFileName4 = New Label()
        lblFileIcon4 = New Label()
        lblOfficeDesc4 = New Label()
        lblOfficeStatusBadge4 = New Label()
        lblOfficeTitle4 = New Label()
        lblOfficeIcon4 = New Label()
        pnlFilterRow = New Panel()
        cmbFilterOffices = New ComboBox()
        lblFilterSection = New Label()
        pnlProgressCard = New Panel()
        pnlAttentionBox = New Panel()
        lblAttentionDesc = New Label()
        lblAttentionTitle = New Label()
        lblAttentionIcon = New Label()
        lblProgressPercent = New Label()
        pbOverall = New ProgressBar()
        lblProgressSub = New Label()
        lblProgressTitle = New Label()
        pnlHeader = New Panel()
        btnRefresh = New Button()
        lblTermBadge = New Label()
        lblStudentCourseYear = New Label()
        lblHeaderTitle = New Label()
        pnlSidebar.SuspendLayout()
        pnlUserProfile.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlPagination.SuspendLayout()
        flpOfficesGrid.SuspendLayout()
        pnlOfficeCard1.SuspendLayout()
        pnlFileAttach1.SuspendLayout()
        pnlOfficeCard2.SuspendLayout()
        pnlFileAttach2.SuspendLayout()
        pnlOfficeCard3.SuspendLayout()
        pnlFileAttach3.SuspendLayout()
        pnlOfficeCard4.SuspendLayout()
        pnlFileAttach4.SuspendLayout()
        pnlFilterRow.SuspendLayout()
        pnlProgressCard.SuspendLayout()
        pnlAttentionBox.SuspendLayout()
        pnlHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(15, 39, 74)
        pnlSidebar.Controls.Add(pnlUserProfile)
        pnlSidebar.Controls.Add(btnNavHistory)
        pnlSidebar.Controls.Add(btnNavMyClearance)
        pnlSidebar.Controls.Add(lblNavSection)
        pnlSidebar.Controls.Add(pnlLogo)
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.Size = New Size(220, 800)
        pnlSidebar.TabIndex = 0
        ' 
        ' pnlUserProfile
        ' 
        pnlUserProfile.Controls.Add(btnNavLogout)
        pnlUserProfile.Controls.Add(lblUserRole)
        pnlUserProfile.Controls.Add(lblUserName)
        pnlUserProfile.Controls.Add(lblUserAvatar)
        pnlUserProfile.Dock = DockStyle.Bottom
        pnlUserProfile.Location = New Point(0, 690)
        pnlUserProfile.Name = "pnlUserProfile"
        pnlUserProfile.Size = New Size(220, 110)
        pnlUserProfile.TabIndex = 4
        ' 
        ' btnNavLogout
        ' 
        btnNavLogout.Dock = DockStyle.Bottom
        btnNavLogout.FlatAppearance.BorderSize = 0
        btnNavLogout.FlatStyle = FlatStyle.Flat
        btnNavLogout.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavLogout.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavLogout.Location = New Point(0, 68)
        btnNavLogout.Name = "btnNavLogout"
        btnNavLogout.Padding = New Padding(16, 0, 0, 0)
        btnNavLogout.Size = New Size(220, 42)
        btnNavLogout.TabIndex = 3
        btnNavLogout.Text = "↪  Log out"
        btnNavLogout.TextAlign = ContentAlignment.MiddleLeft
        btnNavLogout.UseVisualStyleBackColor = False
        ' 
        ' lblUserRole
        ' 
        lblUserRole.AutoSize = True
        lblUserRole.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblUserRole.ForeColor = Color.FromArgb(160, 180, 208)
        lblUserRole.Location = New Point(52, 38)
        lblUserRole.Name = "lblUserRole"
        lblUserRole.Size = New Size(48, 13)
        lblUserRole.TabIndex = 2
        lblUserRole.Text = "Student"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserName.ForeColor = Color.White
        lblUserName.Location = New Point(52, 20)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(90, 15)
        lblUserName.TabIndex = 1
        lblUserName.Text = "Jonnidel Reales"
        ' 
        ' lblUserAvatar
        ' 
        lblUserAvatar.BackColor = Color.FromArgb(28, 91, 184)
        lblUserAvatar.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserAvatar.ForeColor = Color.White
        lblUserAvatar.Location = New Point(14, 18)
        lblUserAvatar.Name = "lblUserAvatar"
        lblUserAvatar.Size = New Size(32, 32)
        lblUserAvatar.TabIndex = 0
        lblUserAvatar.Text = "JR"
        lblUserAvatar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnNavHistory
        ' 
        btnNavHistory.BackColor = Color.FromArgb(15, 39, 74)
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavHistory.ForeColor = Color.FromArgb(160, 180, 208)
        btnNavHistory.Location = New Point(12, 163)
        btnNavHistory.Name = "btnNavHistory"
        btnNavHistory.Padding = New Padding(12, 0, 0, 0)
        btnNavHistory.Size = New Size(196, 42)
        btnNavHistory.TabIndex = 3
        btnNavHistory.Text = "⏱  History"
        btnNavHistory.TextAlign = ContentAlignment.MiddleLeft
        btnNavHistory.UseVisualStyleBackColor = False
        ' 
        ' btnNavMyClearance
        ' 
        btnNavMyClearance.BackColor = Color.FromArgb(28, 91, 184)
        btnNavMyClearance.FlatAppearance.BorderSize = 0
        btnNavMyClearance.FlatStyle = FlatStyle.Flat
        btnNavMyClearance.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnNavMyClearance.ForeColor = Color.White
        btnNavMyClearance.Location = New Point(12, 115)
        btnNavMyClearance.Name = "btnNavMyClearance"
        btnNavMyClearance.Padding = New Padding(12, 0, 0, 0)
        btnNavMyClearance.Size = New Size(196, 42)
        btnNavMyClearance.TabIndex = 2
        btnNavMyClearance.Text = "📇  My clearance"
        btnNavMyClearance.TextAlign = ContentAlignment.MiddleLeft
        btnNavMyClearance.UseVisualStyleBackColor = False
        ' 
        ' lblNavSection
        ' 
        lblNavSection.AutoSize = True
        lblNavSection.Font = New Font("Segoe UI", 7.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblNavSection.ForeColor = Color.FromArgb(91, 122, 159)
        lblNavSection.Location = New Point(18, 90)
        lblNavSection.Name = "lblNavSection"
        lblNavSection.Size = New Size(95, 12)
        lblNavSection.TabIndex = 1
        lblNavSection.Text = "STUDENT PORTAL"
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
        lblLogoText.Text = "School" & Global.System.Environment.NewLine & "Clearance"
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
        pnlMain.Controls.Add(pnlPagination)
        pnlMain.Controls.Add(flpOfficesGrid)
        pnlMain.Controls.Add(pnlFilterRow)
        pnlMain.Controls.Add(pnlProgressCard)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 20, 28, 20)
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' pnlViewHost
        ' 
        pnlViewHost.BackColor = Color.FromArgb(244, 247, 251)
        pnlViewHost.Dock = DockStyle.Fill
        pnlViewHost.Location = New Point(220, 0)
        pnlViewHost.Name = "pnlViewHost"
        pnlViewHost.Size = New Size(980, 800)
        pnlViewHost.TabIndex = 2
        pnlViewHost.Visible = False
        ' 
        ' pnlPagination
        ' 
        pnlPagination.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pnlPagination.Controls.Add(btnNextPage)
        pnlPagination.Controls.Add(btnPage2)
        pnlPagination.Controls.Add(btnPage1)
        pnlPagination.Controls.Add(lblShowingOffices)
        pnlPagination.Location = New Point(28, 735)
        pnlPagination.Name = "pnlPagination"
        pnlPagination.Size = New Size(924, 40)
        pnlPagination.TabIndex = 4
        ' 
        ' btnNextPage
        ' 
        btnNextPage.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnNextPage.BackColor = Color.White
        btnNextPage.Cursor = Cursors.Hand
        btnNextPage.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnNextPage.FlatStyle = FlatStyle.Flat
        btnNextPage.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNextPage.ForeColor = Color.FromArgb(71, 85, 105)
        btnNextPage.Location = New Point(894, 5)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(30, 30)
        btnNextPage.TabIndex = 3
        btnNextPage.Text = "›"
        btnNextPage.UseVisualStyleBackColor = False
        ' 
        ' btnPage2
        ' 
        btnPage2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPage2.BackColor = Color.White
        btnPage2.Cursor = Cursors.Hand
        btnPage2.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnPage2.FlatStyle = FlatStyle.Flat
        btnPage2.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnPage2.ForeColor = Color.FromArgb(71, 85, 105)
        btnPage2.Location = New Point(858, 5)
        btnPage2.Name = "btnPage2"
        btnPage2.Size = New Size(30, 30)
        btnPage2.TabIndex = 2
        btnPage2.Text = "2"
        btnPage2.UseVisualStyleBackColor = False
        ' 
        ' btnPage1
        ' 
        btnPage1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPage1.BackColor = Color.FromArgb(11, 99, 229)
        btnPage1.Cursor = Cursors.Hand
        btnPage1.FlatAppearance.BorderSize = 0
        btnPage1.FlatStyle = FlatStyle.Flat
        btnPage1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnPage1.ForeColor = Color.White
        btnPage1.Location = New Point(822, 5)
        btnPage1.Name = "btnPage1"
        btnPage1.Size = New Size(30, 30)
        btnPage1.TabIndex = 1
        btnPage1.Text = "1"
        btnPage1.UseVisualStyleBackColor = False
        ' 
        ' lblShowingOffices
        ' 
        lblShowingOffices.AutoSize = True
        lblShowingOffices.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblShowingOffices.ForeColor = Color.FromArgb(100, 116, 139)
        lblShowingOffices.Location = New Point(0, 12)
        lblShowingOffices.Name = "lblShowingOffices"
        lblShowingOffices.Size = New Size(137, 15)
        lblShowingOffices.TabIndex = 0
        lblShowingOffices.Text = "Showing 1-4 of 6 offices"
        ' 
        ' flpOfficesGrid
        ' 
        flpOfficesGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpOfficesGrid.AutoScroll = True
        flpOfficesGrid.Controls.Add(pnlOfficeCard1)
        flpOfficesGrid.Controls.Add(pnlOfficeCard2)
        flpOfficesGrid.Controls.Add(pnlOfficeCard3)
        flpOfficesGrid.Controls.Add(pnlOfficeCard4)
        flpOfficesGrid.Location = New Point(28, 275)
        flpOfficesGrid.Name = "flpOfficesGrid"
        flpOfficesGrid.Size = New Size(924, 450)
        flpOfficesGrid.TabIndex = 3
        ' 
        ' pnlOfficeCard1
        ' 
        pnlOfficeCard1.BackColor = Color.White
        pnlOfficeCard1.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeCard1.Controls.Add(btnAction1)
        pnlOfficeCard1.Controls.Add(pnlFileAttach1)
        pnlOfficeCard1.Controls.Add(lblOfficeDesc1)
        pnlOfficeCard1.Controls.Add(lblOfficeStatusBadge1)
        pnlOfficeCard1.Controls.Add(lblOfficeTitle1)
        pnlOfficeCard1.Controls.Add(lblOfficeIcon1)
        pnlOfficeCard1.Location = New Point(3, 3)
        pnlOfficeCard1.Margin = New Padding(3, 3, 16, 16)
        pnlOfficeCard1.Name = "pnlOfficeCard1"
        pnlOfficeCard1.Padding = New Padding(16)
        pnlOfficeCard1.Size = New Size(440, 215)
        pnlOfficeCard1.TabIndex = 0
        ' 
        ' btnAction1
        ' 
        btnAction1.BackColor = Color.FromArgb(59, 130, 246)
        btnAction1.Cursor = Cursors.Hand
        btnAction1.FlatAppearance.BorderSize = 0
        btnAction1.FlatStyle = FlatStyle.Flat
        btnAction1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAction1.ForeColor = Color.White
        btnAction1.Location = New Point(16, 154)
        btnAction1.Name = "btnAction1"
        btnAction1.Size = New Size(406, 36)
        btnAction1.TabIndex = 5
        btnAction1.Text = "View submitted document"
        btnAction1.UseVisualStyleBackColor = False
        ' 
        ' pnlFileAttach1
        ' 
        pnlFileAttach1.BackColor = Color.FromArgb(248, 250, 252)
        pnlFileAttach1.BorderStyle = BorderStyle.FixedSingle
        pnlFileAttach1.Controls.Add(lblFileDate1)
        pnlFileAttach1.Controls.Add(lblFileName1)
        pnlFileAttach1.Controls.Add(lblFileIcon1)
        pnlFileAttach1.Location = New Point(16, 95)
        pnlFileAttach1.Name = "pnlFileAttach1"
        pnlFileAttach1.Size = New Size(406, 48)
        pnlFileAttach1.TabIndex = 4
        ' 
        ' lblFileDate1
        ' 
        lblFileDate1.AutoSize = True
        lblFileDate1.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileDate1.ForeColor = Color.FromArgb(148, 163, 184)
        lblFileDate1.Location = New Point(42, 26)
        lblFileDate1.Name = "lblFileDate1"
        lblFileDate1.Size = New Size(168, 13)
        lblFileDate1.TabIndex = 2
        lblFileDate1.Text = "Submitted Sep 29, 2026 09:35 pm"
        ' 
        ' lblFileName1
        ' 
        lblFileName1.AutoSize = True
        lblFileName1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileName1.ForeColor = Color.FromArgb(30, 41, 59)
        lblFileName1.Location = New Point(42, 8)
        lblFileName1.Name = "lblFileName1"
        lblFileName1.Size = New Size(183, 15)
        lblFileName1.TabIndex = 1
        lblFileName1.Text = "Screenshot 2026-01-21 200242.png"
        ' 
        ' lblFileIcon1
        ' 
        lblFileIcon1.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileIcon1.Location = New Point(8, 8)
        lblFileIcon1.Name = "lblFileIcon1"
        lblFileIcon1.Size = New Size(28, 30)
        lblFileIcon1.TabIndex = 0
        lblFileIcon1.Text = "📄"
        lblFileIcon1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeDesc1
        ' 
        lblOfficeDesc1.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeDesc1.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeDesc1.Location = New Point(16, 60)
        lblOfficeDesc1.Name = "lblOfficeDesc1"
        lblOfficeDesc1.Size = New Size(406, 28)
        lblOfficeDesc1.TabIndex = 3
        lblOfficeDesc1.Text = "Finance Clearance — Settle all outstanding balances and submit the required proof if requested."
        ' 
        ' lblOfficeStatusBadge1
        ' 
        lblOfficeStatusBadge1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblOfficeStatusBadge1.BackColor = Color.FromArgb(219, 234, 254)
        lblOfficeStatusBadge1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeStatusBadge1.ForeColor = Color.FromArgb(30, 64, 175)
        lblOfficeStatusBadge1.Location = New Point(320, 18)
        lblOfficeStatusBadge1.Name = "lblOfficeStatusBadge1"
        lblOfficeStatusBadge1.Size = New Size(102, 26)
        lblOfficeStatusBadge1.TabIndex = 2
        lblOfficeStatusBadge1.Text = "Under Review"
        lblOfficeStatusBadge1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeTitle1
        ' 
        lblOfficeTitle1.AutoSize = True
        lblOfficeTitle1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeTitle1.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeTitle1.Location = New Point(54, 20)
        lblOfficeTitle1.Name = "lblOfficeTitle1"
        lblOfficeTitle1.Size = New Size(106, 20)
        lblOfficeTitle1.TabIndex = 1
        lblOfficeTitle1.Text = "Finance Office"
        ' 
        ' lblOfficeIcon1
        ' 
        lblOfficeIcon1.BackColor = Color.FromArgb(238, 242, 255)
        lblOfficeIcon1.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeIcon1.Location = New Point(16, 15)
        lblOfficeIcon1.Name = "lblOfficeIcon1"
        lblOfficeIcon1.Size = New Size(32, 32)
        lblOfficeIcon1.TabIndex = 0
        lblOfficeIcon1.Text = "🏛"
        lblOfficeIcon1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlOfficeCard2
        ' 
        pnlOfficeCard2.BackColor = Color.White
        pnlOfficeCard2.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeCard2.Controls.Add(btnAction2)
        pnlOfficeCard2.Controls.Add(pnlFileAttach2)
        pnlOfficeCard2.Controls.Add(lblOfficeDesc2)
        pnlOfficeCard2.Controls.Add(lblOfficeStatusBadge2)
        pnlOfficeCard2.Controls.Add(lblOfficeTitle2)
        pnlOfficeCard2.Controls.Add(lblOfficeIcon2)
        pnlOfficeCard2.Location = New Point(462, 3)
        pnlOfficeCard2.Margin = New Padding(3, 3, 16, 16)
        pnlOfficeCard2.Name = "pnlOfficeCard2"
        pnlOfficeCard2.Padding = New Padding(16)
        pnlOfficeCard2.Size = New Size(440, 215)
        pnlOfficeCard2.TabIndex = 1
        ' 
        ' btnAction2
        ' 
        btnAction2.BackColor = Color.FromArgb(59, 130, 246)
        btnAction2.Cursor = Cursors.Hand
        btnAction2.FlatAppearance.BorderSize = 0
        btnAction2.FlatStyle = FlatStyle.Flat
        btnAction2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAction2.ForeColor = Color.White
        btnAction2.Location = New Point(16, 154)
        btnAction2.Name = "btnAction2"
        btnAction2.Size = New Size(406, 36)
        btnAction2.TabIndex = 5
        btnAction2.Text = "View submitted document"
        btnAction2.UseVisualStyleBackColor = False
        ' 
        ' pnlFileAttach2
        ' 
        pnlFileAttach2.BackColor = Color.FromArgb(248, 250, 252)
        pnlFileAttach2.BorderStyle = BorderStyle.FixedSingle
        pnlFileAttach2.Controls.Add(lblFileDate2)
        pnlFileAttach2.Controls.Add(lblFileName2)
        pnlFileAttach2.Controls.Add(lblFileIcon2)
        pnlFileAttach2.Location = New Point(16, 95)
        pnlFileAttach2.Name = "pnlFileAttach2"
        pnlFileAttach2.Size = New Size(406, 48)
        pnlFileAttach2.TabIndex = 4
        ' 
        ' lblFileDate2
        ' 
        lblFileDate2.AutoSize = True
        lblFileDate2.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileDate2.ForeColor = Color.FromArgb(148, 163, 184)
        lblFileDate2.Location = New Point(42, 26)
        lblFileDate2.Name = "lblFileDate2"
        lblFileDate2.Size = New Size(168, 13)
        lblFileDate2.TabIndex = 2
        lblFileDate2.Text = "Submitted Sep 29, 2026 09:36 pm"
        ' 
        ' lblFileName2
        ' 
        lblFileName2.AutoSize = True
        lblFileName2.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileName2.ForeColor = Color.FromArgb(30, 41, 59)
        lblFileName2.Location = New Point(42, 8)
        lblFileName2.Name = "lblFileName2"
        lblFileName2.Size = New Size(183, 15)
        lblFileName2.TabIndex = 1
        lblFileName2.Text = "Screenshot 2026-01-20 012035.png"
        ' 
        ' lblFileIcon2
        ' 
        lblFileIcon2.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileIcon2.Location = New Point(8, 8)
        lblFileIcon2.Name = "lblFileIcon2"
        lblFileIcon2.Size = New Size(28, 30)
        lblFileIcon2.TabIndex = 0
        lblFileIcon2.Text = "📄"
        lblFileIcon2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeDesc2
        ' 
        lblOfficeDesc2.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeDesc2.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeDesc2.Location = New Point(16, 60)
        lblOfficeDesc2.Name = "lblOfficeDesc2"
        lblOfficeDesc2.Size = New Size(406, 28)
        lblOfficeDesc2.TabIndex = 3
        lblOfficeDesc2.Text = "Guidance Clearance — Complete the required non-confidential clearance requirement."
        ' 
        ' lblOfficeStatusBadge2
        ' 
        lblOfficeStatusBadge2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblOfficeStatusBadge2.BackColor = Color.FromArgb(219, 234, 254)
        lblOfficeStatusBadge2.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeStatusBadge2.ForeColor = Color.FromArgb(30, 64, 175)
        lblOfficeStatusBadge2.Location = New Point(320, 18)
        lblOfficeStatusBadge2.Name = "lblOfficeStatusBadge2"
        lblOfficeStatusBadge2.Size = New Size(102, 26)
        lblOfficeStatusBadge2.TabIndex = 2
        lblOfficeStatusBadge2.Text = "Under Review"
        lblOfficeStatusBadge2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeTitle2
        ' 
        lblOfficeTitle2.AutoSize = True
        lblOfficeTitle2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeTitle2.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeTitle2.Location = New Point(54, 20)
        lblOfficeTitle2.Name = "lblOfficeTitle2"
        lblOfficeTitle2.Size = New Size(119, 20)
        lblOfficeTitle2.TabIndex = 1
        lblOfficeTitle2.Text = "Guidance Office"
        ' 
        ' lblOfficeIcon2
        ' 
        lblOfficeIcon2.BackColor = Color.FromArgb(238, 242, 255)
        lblOfficeIcon2.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeIcon2.Location = New Point(16, 15)
        lblOfficeIcon2.Name = "lblOfficeIcon2"
        lblOfficeIcon2.Size = New Size(32, 32)
        lblOfficeIcon2.TabIndex = 0
        lblOfficeIcon2.Text = "🏛"
        lblOfficeIcon2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlOfficeCard3
        ' 
        pnlOfficeCard3.BackColor = Color.White
        pnlOfficeCard3.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeCard3.Controls.Add(btnAction3)
        pnlOfficeCard3.Controls.Add(pnlFileAttach3)
        pnlOfficeCard3.Controls.Add(lblOfficeDesc3)
        pnlOfficeCard3.Controls.Add(lblOfficeStatusBadge3)
        pnlOfficeCard3.Controls.Add(lblOfficeTitle3)
        pnlOfficeCard3.Controls.Add(lblOfficeIcon3)
        pnlOfficeCard3.Location = New Point(3, 237)
        pnlOfficeCard3.Margin = New Padding(3, 3, 16, 16)
        pnlOfficeCard3.Name = "pnlOfficeCard3"
        pnlOfficeCard3.Padding = New Padding(16)
        pnlOfficeCard3.Size = New Size(440, 215)
        pnlOfficeCard3.TabIndex = 2
        ' 
        ' btnAction3
        ' 
        btnAction3.BackColor = Color.FromArgb(59, 130, 246)
        btnAction3.Cursor = Cursors.Hand
        btnAction3.FlatAppearance.BorderSize = 0
        btnAction3.FlatStyle = FlatStyle.Flat
        btnAction3.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAction3.ForeColor = Color.White
        btnAction3.Location = New Point(16, 154)
        btnAction3.Name = "btnAction3"
        btnAction3.Size = New Size(406, 36)
        btnAction3.TabIndex = 5
        btnAction3.Text = "View submitted document"
        btnAction3.UseVisualStyleBackColor = False
        ' 
        ' pnlFileAttach3
        ' 
        pnlFileAttach3.BackColor = Color.FromArgb(248, 250, 252)
        pnlFileAttach3.BorderStyle = BorderStyle.FixedSingle
        pnlFileAttach3.Controls.Add(lblFileDate3)
        pnlFileAttach3.Controls.Add(lblFileName3)
        pnlFileAttach3.Controls.Add(lblFileIcon3)
        pnlFileAttach3.Location = New Point(16, 95)
        pnlFileAttach3.Name = "pnlFileAttach3"
        pnlFileAttach3.Size = New Size(406, 48)
        pnlFileAttach3.TabIndex = 4
        ' 
        ' lblFileDate3
        ' 
        lblFileDate3.AutoSize = True
        lblFileDate3.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileDate3.ForeColor = Color.FromArgb(148, 163, 184)
        lblFileDate3.Location = New Point(42, 26)
        lblFileDate3.Name = "lblFileDate3"
        lblFileDate3.Size = New Size(168, 13)
        lblFileDate3.TabIndex = 2
        lblFileDate3.Text = "Submitted Sep 29, 2026 09:37 pm"
        ' 
        ' lblFileName3
        ' 
        lblFileName3.AutoSize = True
        lblFileName3.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileName3.ForeColor = Color.FromArgb(30, 41, 59)
        lblFileName3.Location = New Point(42, 8)
        lblFileName3.Name = "lblFileName3"
        lblFileName3.Size = New Size(183, 15)
        lblFileName3.TabIndex = 1
        lblFileName3.Text = "Screenshot 2026-01-21 200242.png"
        ' 
        ' lblFileIcon3
        ' 
        lblFileIcon3.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileIcon3.Location = New Point(8, 8)
        lblFileIcon3.Name = "lblFileIcon3"
        lblFileIcon3.Size = New Size(28, 30)
        lblFileIcon3.TabIndex = 0
        lblFileIcon3.Text = "📄"
        lblFileIcon3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeDesc3
        ' 
        lblOfficeDesc3.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeDesc3.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeDesc3.Location = New Point(16, 60)
        lblOfficeDesc3.Name = "lblOfficeDesc3"
        lblOfficeDesc3.Size = New Size(406, 28)
        lblOfficeDesc3.TabIndex = 3
        lblOfficeDesc3.Text = "Library Clearance — Return all borrowed books and settle any library obligations."
        ' 
        ' lblOfficeStatusBadge3
        ' 
        lblOfficeStatusBadge3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblOfficeStatusBadge3.BackColor = Color.FromArgb(219, 234, 254)
        lblOfficeStatusBadge3.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeStatusBadge3.ForeColor = Color.FromArgb(30, 64, 175)
        lblOfficeStatusBadge3.Location = New Point(320, 18)
        lblOfficeStatusBadge3.Name = "lblOfficeStatusBadge3"
        lblOfficeStatusBadge3.Size = New Size(102, 26)
        lblOfficeStatusBadge3.TabIndex = 2
        lblOfficeStatusBadge3.Text = "Under Review"
        lblOfficeStatusBadge3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeTitle3
        ' 
        lblOfficeTitle3.AutoSize = True
        lblOfficeTitle3.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeTitle3.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeTitle3.Location = New Point(54, 20)
        lblOfficeTitle3.Name = "lblOfficeTitle3"
        lblOfficeTitle3.Size = New Size(57, 20)
        lblOfficeTitle3.TabIndex = 1
        lblOfficeTitle3.Text = "Library"
        ' 
        ' lblOfficeIcon3
        ' 
        lblOfficeIcon3.BackColor = Color.FromArgb(238, 242, 255)
        lblOfficeIcon3.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeIcon3.Location = New Point(16, 15)
        lblOfficeIcon3.Name = "lblOfficeIcon3"
        lblOfficeIcon3.Size = New Size(32, 32)
        lblOfficeIcon3.TabIndex = 0
        lblOfficeIcon3.Text = "🏛"
        lblOfficeIcon3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlOfficeCard4
        ' 
        pnlOfficeCard4.BackColor = Color.White
        pnlOfficeCard4.BorderStyle = BorderStyle.FixedSingle
        pnlOfficeCard4.Controls.Add(btnAction4)
        pnlOfficeCard4.Controls.Add(pnlFileAttach4)
        pnlOfficeCard4.Controls.Add(lblOfficeDesc4)
        pnlOfficeCard4.Controls.Add(lblOfficeStatusBadge4)
        pnlOfficeCard4.Controls.Add(lblOfficeTitle4)
        pnlOfficeCard4.Controls.Add(lblOfficeIcon4)
        pnlOfficeCard4.Location = New Point(462, 237)
        pnlOfficeCard4.Margin = New Padding(3, 3, 16, 16)
        pnlOfficeCard4.Name = "pnlOfficeCard4"
        pnlOfficeCard4.Padding = New Padding(16)
        pnlOfficeCard4.Size = New Size(440, 215)
        pnlOfficeCard4.TabIndex = 3
        ' 
        ' btnAction4
        ' 
        btnAction4.BackColor = Color.FromArgb(11, 99, 229)
        btnAction4.Cursor = Cursors.Hand
        btnAction4.FlatAppearance.BorderSize = 0
        btnAction4.FlatStyle = FlatStyle.Flat
        btnAction4.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAction4.ForeColor = Color.White
        btnAction4.Location = New Point(16, 154)
        btnAction4.Name = "btnAction4"
        btnAction4.Size = New Size(406, 36)
        btnAction4.TabIndex = 5
        btnAction4.Text = "Upload requirement"
        btnAction4.UseVisualStyleBackColor = False
        ' 
        ' pnlFileAttach4
        ' 
        pnlFileAttach4.BackColor = Color.FromArgb(248, 250, 252)
        pnlFileAttach4.BorderStyle = BorderStyle.FixedSingle
        pnlFileAttach4.Controls.Add(lblFileDate4)
        pnlFileAttach4.Controls.Add(lblFileName4)
        pnlFileAttach4.Controls.Add(lblFileIcon4)
        pnlFileAttach4.Location = New Point(16, 95)
        pnlFileAttach4.Name = "pnlFileAttach4"
        pnlFileAttach4.Size = New Size(406, 48)
        pnlFileAttach4.TabIndex = 4
        ' 
        ' lblFileDate4
        ' 
        lblFileDate4.AutoSize = True
        lblFileDate4.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileDate4.ForeColor = Color.FromArgb(148, 163, 184)
        lblFileDate4.Location = New Point(42, 26)
        lblFileDate4.Name = "lblFileDate4"
        lblFileDate4.Size = New Size(89, 13)
        lblFileDate4.TabIndex = 2
        lblFileDate4.Text = "Upload required"
        ' 
        ' lblFileName4
        ' 
        lblFileName4.AutoSize = True
        lblFileName4.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileName4.ForeColor = Color.FromArgb(30, 41, 59)
        lblFileName4.Location = New Point(42, 8)
        lblFileName4.Name = "lblFileName4"
        lblFileName4.Size = New Size(127, 15)
        lblFileName4.TabIndex = 1
        lblFileName4.Text = "No document uploaded"
        ' 
        ' lblFileIcon4
        ' 
        lblFileIcon4.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFileIcon4.Location = New Point(8, 8)
        lblFileIcon4.Name = "lblFileIcon4"
        lblFileIcon4.Size = New Size(28, 30)
        lblFileIcon4.TabIndex = 0
        lblFileIcon4.Text = "📄"
        lblFileIcon4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeDesc4
        ' 
        lblOfficeDesc4.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeDesc4.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeDesc4.Location = New Point(16, 60)
        lblOfficeDesc4.Name = "lblOfficeDesc4"
        lblOfficeDesc4.Size = New Size(406, 28)
        lblOfficeDesc4.TabIndex = 3
        lblOfficeDesc4.Text = "OAA Clearance — Complete all academic affairs clearance requirements."
        ' 
        ' lblOfficeStatusBadge4
        ' 
        lblOfficeStatusBadge4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblOfficeStatusBadge4.BackColor = Color.FromArgb(254, 243, 199)
        lblOfficeStatusBadge4.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeStatusBadge4.ForeColor = Color.FromArgb(146, 64, 14)
        lblOfficeStatusBadge4.Location = New Point(320, 18)
        lblOfficeStatusBadge4.Name = "lblOfficeStatusBadge4"
        lblOfficeStatusBadge4.Size = New Size(102, 26)
        lblOfficeStatusBadge4.TabIndex = 2
        lblOfficeStatusBadge4.Text = "Pending"
        lblOfficeStatusBadge4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeTitle4
        ' 
        lblOfficeTitle4.AutoSize = True
        lblOfficeTitle4.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeTitle4.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeTitle4.Location = New Point(54, 20)
        lblOfficeTitle4.Name = "lblOfficeTitle4"
        lblOfficeTitle4.Size = New Size(41, 20)
        lblOfficeTitle4.TabIndex = 1
        lblOfficeTitle4.Text = "OAA"
        ' 
        ' lblOfficeIcon4
        ' 
        lblOfficeIcon4.BackColor = Color.FromArgb(238, 242, 255)
        lblOfficeIcon4.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeIcon4.Location = New Point(16, 15)
        lblOfficeIcon4.Name = "lblOfficeIcon4"
        lblOfficeIcon4.Size = New Size(32, 32)
        lblOfficeIcon4.TabIndex = 0
        lblOfficeIcon4.Text = "🏛"
        lblOfficeIcon4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlFilterRow
        ' 
        pnlFilterRow.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlFilterRow.Controls.Add(cmbFilterOffices)
        pnlFilterRow.Controls.Add(lblFilterSection)
        pnlFilterRow.Location = New Point(28, 225)
        pnlFilterRow.Name = "pnlFilterRow"
        pnlFilterRow.Size = New Size(924, 38)
        pnlFilterRow.TabIndex = 2
        ' 
        ' cmbFilterOffices
        ' 
        cmbFilterOffices.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        cmbFilterOffices.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilterOffices.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbFilterOffices.FormattingEnabled = True
        cmbFilterOffices.Location = New Point(724, 6)
        cmbFilterOffices.Name = "cmbFilterOffices"
        cmbFilterOffices.Size = New Size(200, 25)
        cmbFilterOffices.TabIndex = 1
        ' 
        ' lblFilterSection
        ' 
        lblFilterSection.AutoSize = True
        lblFilterSection.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblFilterSection.ForeColor = Color.FromArgb(15, 23, 42)
        lblFilterSection.Location = New Point(0, 8)
        lblFilterSection.Name = "lblFilterSection"
        lblFilterSection.Size = New Size(164, 21)
        lblFilterSection.TabIndex = 0
        lblFilterSection.Text = "Office requirements"
        ' 
        ' pnlProgressCard
        ' 
        pnlProgressCard.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlProgressCard.BackColor = Color.White
        pnlProgressCard.BorderStyle = BorderStyle.FixedSingle
        pnlProgressCard.Controls.Add(pnlAttentionBox)
        pnlProgressCard.Controls.Add(lblProgressPercent)
        pnlProgressCard.Controls.Add(pbOverall)
        pnlProgressCard.Controls.Add(lblProgressSub)
        pnlProgressCard.Controls.Add(lblProgressTitle)
        pnlProgressCard.Location = New Point(28, 80)
        pnlProgressCard.Name = "pnlProgressCard"
        pnlProgressCard.Padding = New Padding(20)
        pnlProgressCard.Size = New Size(924, 125)
        pnlProgressCard.TabIndex = 1
        ' 
        ' pnlAttentionBox
        ' 
        pnlAttentionBox.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnlAttentionBox.BackColor = Color.FromArgb(248, 250, 252)
        pnlAttentionBox.BorderStyle = BorderStyle.FixedSingle
        pnlAttentionBox.Controls.Add(lblAttentionDesc)
        pnlAttentionBox.Controls.Add(lblAttentionTitle)
        pnlAttentionBox.Controls.Add(lblAttentionIcon)
        pnlAttentionBox.Location = New Point(610, 18)
        pnlAttentionBox.Name = "pnlAttentionBox"
        pnlAttentionBox.Size = New Size(292, 85)
        pnlAttentionBox.TabIndex = 4
        ' 
        ' lblAttentionDesc
        ' 
        lblAttentionDesc.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblAttentionDesc.ForeColor = Color.FromArgb(100, 116, 139)
        lblAttentionDesc.Location = New Point(44, 38)
        lblAttentionDesc.Name = "lblAttentionDesc"
        lblAttentionDesc.Size = New Size(236, 38)
        lblAttentionDesc.TabIndex = 2
        lblAttentionDesc.Text = "Complete pending or rejected requirements to finalize your clearance."
        ' 
        ' lblAttentionTitle
        ' 
        lblAttentionTitle.AutoSize = True
        lblAttentionTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAttentionTitle.ForeColor = Color.FromArgb(30, 41, 59)
        lblAttentionTitle.Location = New Point(44, 16)
        lblAttentionTitle.Name = "lblAttentionTitle"
        lblAttentionTitle.Size = New Size(160, 15)
        lblAttentionTitle.TabIndex = 1
        lblAttentionTitle.Text = "3 offices need your attention"
        ' 
        ' lblAttentionIcon
        ' 
        lblAttentionIcon.BackColor = Color.FromArgb(238, 242, 255)
        lblAttentionIcon.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblAttentionIcon.Location = New Point(10, 14)
        lblAttentionIcon.Name = "lblAttentionIcon"
        lblAttentionIcon.Size = New Size(28, 28)
        lblAttentionIcon.TabIndex = 0
        lblAttentionIcon.Text = "📋"
        lblAttentionIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblProgressPercent
        ' 
        lblProgressPercent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblProgressPercent.AutoSize = True
        lblProgressPercent.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblProgressPercent.ForeColor = Color.FromArgb(30, 41, 59)
        lblProgressPercent.Location = New Point(560, 78)
        lblProgressPercent.Name = "lblProgressPercent"
        lblProgressPercent.Size = New Size(23, 15)
        lblProgressPercent.TabIndex = 3
        lblProgressPercent.Text = "0%"
        ' 
        ' pbOverall
        ' 
        pbOverall.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbOverall.Location = New Point(20, 76)
        pbOverall.Name = "pbOverall"
        pbOverall.Size = New Size(530, 18)
        pbOverall.TabIndex = 2
        ' 
        ' lblProgressSub
        ' 
        lblProgressSub.AutoSize = True
        lblProgressSub.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblProgressSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblProgressSub.Location = New Point(20, 45)
        lblProgressSub.Name = "lblProgressSub"
        lblProgressSub.Size = New Size(107, 15)
        lblProgressSub.TabIndex = 1
        lblProgressSub.Text = "0 of 6 offices cleared"
        ' 
        ' lblProgressTitle
        ' 
        lblProgressTitle.AutoSize = True
        lblProgressTitle.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblProgressTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblProgressTitle.Location = New Point(20, 18)
        lblProgressTitle.Name = "lblProgressTitle"
        lblProgressTitle.Size = New Size(153, 21)
        lblProgressTitle.TabIndex = 0
        lblProgressTitle.Text = "Clearance progress"
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(btnRefresh)
        pnlHeader.Controls.Add(lblTermBadge)
        pnlHeader.Controls.Add(lblStudentCourseYear)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Location = New Point(28, 12)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 52)
        pnlHeader.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.White
        btnRefresh.Cursor = Cursors.Hand
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnRefresh.ForeColor = Color.FromArgb(71, 85, 105)
        btnRefresh.Location = New Point(836, 12)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(88, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "⟳ Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblTermBadge
        ' 
        lblTermBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTermBadge.BackColor = Color.FromArgb(238, 242, 255)
        lblTermBadge.BorderStyle = BorderStyle.FixedSingle
        lblTermBadge.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblTermBadge.ForeColor = Color.FromArgb(30, 64, 175)
        lblTermBadge.Location = New Point(640, 12)
        lblTermBadge.Name = "lblTermBadge"
        lblTermBadge.Size = New Size(185, 34)
        lblTermBadge.TabIndex = 2
        lblTermBadge.Text = "2026-2027 • 1st Semester"
        lblTermBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStudentCourseYear
        ' 
        lblStudentCourseYear.AutoSize = True
        lblStudentCourseYear.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudentCourseYear.ForeColor = Color.FromArgb(100, 116, 139)
        lblStudentCourseYear.Location = New Point(0, 32)
        lblStudentCourseYear.Name = "lblStudentCourseYear"
        lblStudentCourseYear.Size = New Size(99, 17)
        lblStudentCourseYear.TabIndex = 1
        lblStudentCourseYear.Text = "BSIT  •  3rd Year"
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(168, 32)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "My clearance"
        ' 
        ' StudentClearanceForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlViewHost)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1100, 750)
        Name = "StudentClearanceForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Student Portal"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlUserProfile.ResumeLayout(False)
        pnlUserProfile.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlPagination.ResumeLayout(False)
        pnlPagination.PerformLayout()
        flpOfficesGrid.ResumeLayout(False)
        pnlOfficeCard1.ResumeLayout(False)
        pnlOfficeCard1.PerformLayout()
        pnlFileAttach1.ResumeLayout(False)
        pnlFileAttach1.PerformLayout()
        pnlOfficeCard2.ResumeLayout(False)
        pnlOfficeCard2.PerformLayout()
        pnlFileAttach2.ResumeLayout(False)
        pnlFileAttach2.PerformLayout()
        pnlOfficeCard3.ResumeLayout(False)
        pnlOfficeCard3.PerformLayout()
        pnlFileAttach3.ResumeLayout(False)
        pnlFileAttach3.PerformLayout()
        pnlOfficeCard4.ResumeLayout(False)
        pnlOfficeCard4.PerformLayout()
        pnlFileAttach4.ResumeLayout(False)
        pnlFileAttach4.PerformLayout()
        pnlFilterRow.ResumeLayout(False)
        pnlFilterRow.PerformLayout()
        pnlProgressCard.ResumeLayout(False)
        pnlProgressCard.PerformLayout()
        pnlAttentionBox.ResumeLayout(False)
        pnlAttentionBox.PerformLayout()
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As Panel
    Friend WithEvents pnlLogo As Panel
    Friend WithEvents lblLogoIcon As Label
    Friend WithEvents lblLogoText As Label
    Friend WithEvents lblNavSection As Label
    Friend WithEvents btnNavMyClearance As Button
    Friend WithEvents btnNavHistory As Button
    Friend WithEvents pnlUserProfile As Panel
    Friend WithEvents lblUserAvatar As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents btnNavLogout As Button
    Friend WithEvents pnlMain As Panel
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblStudentCourseYear As Label
    Friend WithEvents lblTermBadge As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents pnlProgressCard As Panel
    Friend WithEvents lblProgressTitle As Label
    Friend WithEvents lblProgressSub As Label
    Friend WithEvents pbOverall As ProgressBar
    Friend WithEvents lblProgressPercent As Label
    Friend WithEvents pnlAttentionBox As Panel
    Friend WithEvents lblAttentionIcon As Label
    Friend WithEvents lblAttentionTitle As Label
    Friend WithEvents lblAttentionDesc As Label
    Friend WithEvents pnlFilterRow As Panel
    Friend WithEvents lblFilterSection As Label
    Friend WithEvents cmbFilterOffices As ComboBox
    Friend WithEvents flpOfficesGrid As FlowLayoutPanel
    Friend WithEvents pnlOfficeCard1 As Panel
    Friend WithEvents lblOfficeIcon1 As Label
    Friend WithEvents lblOfficeTitle1 As Label
    Friend WithEvents lblOfficeStatusBadge1 As Label
    Friend WithEvents lblOfficeDesc1 As Label
    Friend WithEvents pnlFileAttach1 As Panel
    Friend WithEvents lblFileIcon1 As Label
    Friend WithEvents lblFileName1 As Label
    Friend WithEvents lblFileDate1 As Label
    Friend WithEvents btnAction1 As Button
    Friend WithEvents pnlOfficeCard2 As Panel
    Friend WithEvents lblOfficeIcon2 As Label
    Friend WithEvents lblOfficeTitle2 As Label
    Friend WithEvents lblOfficeStatusBadge2 As Label
    Friend WithEvents lblOfficeDesc2 As Label
    Friend WithEvents pnlFileAttach2 As Panel
    Friend WithEvents lblFileIcon2 As Label
    Friend WithEvents lblFileName2 As Label
    Friend WithEvents lblFileDate2 As Label
    Friend WithEvents btnAction2 As Button
    Friend WithEvents pnlOfficeCard3 As Panel
    Friend WithEvents lblOfficeIcon3 As Label
    Friend WithEvents lblOfficeTitle3 As Label
    Friend WithEvents lblOfficeStatusBadge3 As Label
    Friend WithEvents lblOfficeDesc3 As Label
    Friend WithEvents pnlFileAttach3 As Panel
    Friend WithEvents lblFileIcon3 As Label
    Friend WithEvents lblFileName3 As Label
    Friend WithEvents lblFileDate3 As Label
    Friend WithEvents btnAction3 As Button
    Friend WithEvents pnlOfficeCard4 As Panel
    Friend WithEvents lblOfficeIcon4 As Label
    Friend WithEvents lblOfficeTitle4 As Label
    Friend WithEvents lblOfficeStatusBadge4 As Label
    Friend WithEvents lblOfficeDesc4 As Label
    Friend WithEvents pnlFileAttach4 As Panel
    Friend WithEvents lblFileIcon4 As Label
    Friend WithEvents lblFileName4 As Label
    Friend WithEvents lblFileDate4 As Label
    Friend WithEvents btnAction4 As Button
    Friend WithEvents pnlPagination As Panel
    Friend WithEvents lblShowingOffices As Label
    Friend WithEvents btnPage1 As Button
    Friend WithEvents btnPage2 As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents pnlViewHost As Panel

End Class
