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
        pnlSampleOfficeCard1 = New Panel()
        btnAction1 = New Button()
        pnlFileAttach1 = New Panel()
        lblFileDate1 = New Label()
        lblFileName1 = New Label()
        lblFileIcon1 = New Label()
        lblOfficeDesc1 = New Label()
        lblOfficeStatusBadge1 = New Label()
        lblOfficeTitle1 = New Label()
        lblOfficeIcon1 = New Label()
        pnlSampleOfficeCard2 = New Panel()
        btnAction2 = New Button()
        lblOfficeDesc2 = New Label()
        lblOfficeStatusBadge2 = New Label()
        lblOfficeTitle2 = New Label()
        lblOfficeIcon2 = New Label()
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
        pnlSampleOfficeCard1.SuspendLayout()
        pnlFileAttach1.SuspendLayout()
        pnlSampleOfficeCard2.SuspendLayout()
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
        lblUserRole.ForeColor = Color.FromArgb(148, 163, 184)
        lblUserRole.Location = New Point(58, 38)
        lblUserRole.Name = "lblUserRole"
        lblUserRole.Size = New Size(47, 13)
        lblUserRole.TabIndex = 2
        lblUserRole.Text = "Student"
        ' 
        ' lblUserName
        ' 
        lblUserName.AutoSize = True
        lblUserName.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserName.ForeColor = Color.White
        lblUserName.Location = New Point(58, 18)
        lblUserName.Name = "lblUserName"
        lblUserName.Size = New Size(94, 17)
        lblUserName.TabIndex = 1
        lblUserName.Text = "[Student Name]"
        ' 
        ' lblUserAvatar
        ' 
        lblUserAvatar.BackColor = Color.FromArgb(30, 64, 110)
        lblUserAvatar.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblUserAvatar.ForeColor = Color.White
        lblUserAvatar.Location = New Point(16, 16)
        lblUserAvatar.Name = "lblUserAvatar"
        lblUserAvatar.Size = New Size(36, 36)
        lblUserAvatar.TabIndex = 0
        lblUserAvatar.Text = "--"
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
        btnNavMyClearance.Text = "📄  My clearance"
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
        btnNextPage.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240)
        btnNextPage.FlatStyle = FlatStyle.Flat
        btnNextPage.Location = New Point(888, 4)
        btnNextPage.Name = "btnNextPage"
        btnNextPage.Size = New Size(32, 32)
        btnNextPage.TabIndex = 3
        btnNextPage.Text = "›"
        btnNextPage.UseVisualStyleBackColor = False
        ' 
        ' btnPage2
        ' 
        btnPage2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPage2.BackColor = Color.White
        btnPage2.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240)
        btnPage2.FlatStyle = FlatStyle.Flat
        btnPage2.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnPage2.Location = New Point(852, 4)
        btnPage2.Name = "btnPage2"
        btnPage2.Size = New Size(32, 32)
        btnPage2.TabIndex = 2
        btnPage2.Text = "2"
        btnPage2.UseVisualStyleBackColor = False
        ' 
        ' btnPage1
        ' 
        btnPage1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnPage1.BackColor = Color.FromArgb(11, 99, 229)
        btnPage1.FlatAppearance.BorderSize = 0
        btnPage1.FlatStyle = FlatStyle.Flat
        btnPage1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnPage1.ForeColor = Color.White
        btnPage1.Location = New Point(816, 4)
        btnPage1.Name = "btnPage1"
        btnPage1.Size = New Size(32, 32)
        btnPage1.TabIndex = 1
        btnPage1.Text = "1"
        btnPage1.UseVisualStyleBackColor = False
        ' 
        ' lblShowingOffices
        ' 
        lblShowingOffices.AutoSize = True
        lblShowingOffices.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblShowingOffices.ForeColor = Color.FromArgb(100, 116, 139)
        lblShowingOffices.Location = New Point(3, 12)
        lblShowingOffices.Name = "lblShowingOffices"
        lblShowingOffices.Size = New Size(119, 15)
        lblShowingOffices.TabIndex = 0
        lblShowingOffices.Text = "Showing 0 of 0 offices"
        ' 
        ' flpOfficesGrid
        ' 
        flpOfficesGrid.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        flpOfficesGrid.AutoScroll = True
        flpOfficesGrid.Controls.Add(pnlSampleOfficeCard1)
        flpOfficesGrid.Controls.Add(pnlSampleOfficeCard2)
        flpOfficesGrid.Location = New Point(28, 275)
        flpOfficesGrid.Name = "flpOfficesGrid"
        flpOfficesGrid.Size = New Size(924, 450)
        flpOfficesGrid.TabIndex = 3
        ' 
        ' pnlSampleOfficeCard1
        ' 
        pnlSampleOfficeCard1.BackColor = Color.White
        pnlSampleOfficeCard1.BorderStyle = BorderStyle.FixedSingle
        pnlSampleOfficeCard1.Controls.Add(btnAction1)
        pnlSampleOfficeCard1.Controls.Add(pnlFileAttach1)
        pnlSampleOfficeCard1.Controls.Add(lblOfficeDesc1)
        pnlSampleOfficeCard1.Controls.Add(lblOfficeStatusBadge1)
        pnlSampleOfficeCard1.Controls.Add(lblOfficeTitle1)
        pnlSampleOfficeCard1.Controls.Add(lblOfficeIcon1)
        pnlSampleOfficeCard1.Location = New Point(3, 3)
        pnlSampleOfficeCard1.Margin = New Padding(3, 3, 16, 16)
        pnlSampleOfficeCard1.Name = "pnlSampleOfficeCard1"
        pnlSampleOfficeCard1.Padding = New Padding(16)
        pnlSampleOfficeCard1.Size = New Size(440, 205)
        pnlSampleOfficeCard1.TabIndex = 0
        ' 
        ' btnAction1
        ' 
        btnAction1.BackColor = Color.FromArgb(11, 99, 229)
        btnAction1.Cursor = Cursors.Hand
        btnAction1.FlatAppearance.BorderSize = 0
        btnAction1.FlatStyle = FlatStyle.Flat
        btnAction1.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAction1.ForeColor = Color.White
        btnAction1.Location = New Point(16, 154)
        btnAction1.Name = "btnAction1"
        btnAction1.Size = New Size(406, 36)
        btnAction1.TabIndex = 5
        btnAction1.Text = "⬆ Upload requirement"
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
        lblFileDate1.Size = New Size(100, 13)
        lblFileDate1.TabIndex = 2
        lblFileDate1.Text = "No file uploaded"
        ' 
        ' lblFileName1
        ' 
        lblFileName1.AutoSize = True
        lblFileName1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblFileName1.ForeColor = Color.FromArgb(30, 41, 59)
        lblFileName1.Location = New Point(42, 8)
        lblFileName1.Name = "lblFileName1"
        lblFileName1.Size = New Size(100, 15)
        lblFileName1.TabIndex = 1
        lblFileName1.Text = "Document Name"
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
        lblOfficeDesc1.Location = New Point(16, 62)
        lblOfficeDesc1.Name = "lblOfficeDesc1"
        lblOfficeDesc1.Size = New Size(406, 26)
        lblOfficeDesc1.TabIndex = 3
        lblOfficeDesc1.Text = "Requirement instructions or status note."
        ' 
        ' lblOfficeStatusBadge1
        ' 
        lblOfficeStatusBadge1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblOfficeStatusBadge1.BackColor = Color.FromArgb(241, 245, 249)
        lblOfficeStatusBadge1.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeStatusBadge1.ForeColor = Color.FromArgb(71, 85, 105)
        lblOfficeStatusBadge1.Location = New Point(320, 18)
        lblOfficeStatusBadge1.Name = "lblOfficeStatusBadge1"
        lblOfficeStatusBadge1.Size = New Size(102, 26)
        lblOfficeStatusBadge1.TabIndex = 2
        lblOfficeStatusBadge1.Text = "Pending"
        lblOfficeStatusBadge1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeTitle1
        ' 
        lblOfficeTitle1.AutoSize = True
        lblOfficeTitle1.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeTitle1.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeTitle1.Location = New Point(54, 20)
        lblOfficeTitle1.Name = "lblOfficeTitle1"
        lblOfficeTitle1.Size = New Size(95, 20)
        lblOfficeTitle1.TabIndex = 1
        lblOfficeTitle1.Text = "Office Name"
        ' 
        ' lblOfficeIcon1
        ' 
        lblOfficeIcon1.BackColor = Color.FromArgb(240, 253, 244)
        lblOfficeIcon1.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeIcon1.Location = New Point(16, 15)
        lblOfficeIcon1.Name = "lblOfficeIcon1"
        lblOfficeIcon1.Size = New Size(32, 32)
        lblOfficeIcon1.TabIndex = 0
        lblOfficeIcon1.Text = "🏢"
        lblOfficeIcon1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlSampleOfficeCard2
        ' 
        pnlSampleOfficeCard2.BackColor = Color.White
        pnlSampleOfficeCard2.BorderStyle = BorderStyle.FixedSingle
        pnlSampleOfficeCard2.Controls.Add(btnAction2)
        pnlSampleOfficeCard2.Controls.Add(lblOfficeDesc2)
        pnlSampleOfficeCard2.Controls.Add(lblOfficeStatusBadge2)
        pnlSampleOfficeCard2.Controls.Add(lblOfficeTitle2)
        pnlSampleOfficeCard2.Controls.Add(lblOfficeIcon2)
        pnlSampleOfficeCard2.Location = New Point(462, 3)
        pnlSampleOfficeCard2.Margin = New Padding(3, 3, 16, 16)
        pnlSampleOfficeCard2.Name = "pnlSampleOfficeCard2"
        pnlSampleOfficeCard2.Padding = New Padding(16)
        pnlSampleOfficeCard2.Size = New Size(440, 205)
        pnlSampleOfficeCard2.TabIndex = 1
        ' 
        ' btnAction2
        ' 
        btnAction2.BackColor = Color.FromArgb(11, 99, 229)
        btnAction2.Cursor = Cursors.Hand
        btnAction2.FlatAppearance.BorderSize = 0
        btnAction2.FlatStyle = FlatStyle.Flat
        btnAction2.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnAction2.ForeColor = Color.White
        btnAction2.Location = New Point(16, 154)
        btnAction2.Name = "btnAction2"
        btnAction2.Size = New Size(406, 36)
        btnAction2.TabIndex = 5
        btnAction2.Text = "⬆ Upload requirement"
        btnAction2.UseVisualStyleBackColor = False
        ' 
        ' lblOfficeDesc2
        ' 
        lblOfficeDesc2.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeDesc2.ForeColor = Color.FromArgb(100, 116, 139)
        lblOfficeDesc2.Location = New Point(16, 62)
        lblOfficeDesc2.Name = "lblOfficeDesc2"
        lblOfficeDesc2.Size = New Size(406, 60)
        lblOfficeDesc2.TabIndex = 3
        lblOfficeDesc2.Text = "Upload the required clearance forms or payment proof to receive approval."
        ' 
        ' lblOfficeStatusBadge2
        ' 
        lblOfficeStatusBadge2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblOfficeStatusBadge2.BackColor = Color.FromArgb(241, 245, 249)
        lblOfficeStatusBadge2.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeStatusBadge2.ForeColor = Color.FromArgb(71, 85, 105)
        lblOfficeStatusBadge2.Location = New Point(320, 18)
        lblOfficeStatusBadge2.Name = "lblOfficeStatusBadge2"
        lblOfficeStatusBadge2.Size = New Size(102, 26)
        lblOfficeStatusBadge2.TabIndex = 2
        lblOfficeStatusBadge2.Text = "Pending"
        lblOfficeStatusBadge2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblOfficeTitle2
        ' 
        lblOfficeTitle2.AutoSize = True
        lblOfficeTitle2.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblOfficeTitle2.ForeColor = Color.FromArgb(15, 23, 42)
        lblOfficeTitle2.Location = New Point(54, 20)
        lblOfficeTitle2.Name = "lblOfficeTitle2"
        lblOfficeTitle2.Size = New Size(95, 20)
        lblOfficeTitle2.TabIndex = 1
        lblOfficeTitle2.Text = "Office Name"
        ' 
        ' lblOfficeIcon2
        ' 
        lblOfficeIcon2.BackColor = Color.FromArgb(254, 243, 199)
        lblOfficeIcon2.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblOfficeIcon2.Location = New Point(16, 15)
        lblOfficeIcon2.Name = "lblOfficeIcon2"
        lblOfficeIcon2.Size = New Size(32, 32)
        lblOfficeIcon2.TabIndex = 0
        lblOfficeIcon2.Text = "🏢"
        lblOfficeIcon2.TextAlign = ContentAlignment.MiddleCenter
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
        cmbFilterOffices.Items.AddRange(New Object() {"All offices", "Pending", "Under Review", "Cleared"})
        cmbFilterOffices.Location = New Point(744, 4)
        cmbFilterOffices.Name = "cmbFilterOffices"
        cmbFilterOffices.Size = New Size(180, 25)
        cmbFilterOffices.TabIndex = 1
        ' 
        ' lblFilterSection
        ' 
        lblFilterSection.AutoSize = True
        lblFilterSection.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblFilterSection.ForeColor = Color.FromArgb(15, 23, 42)
        lblFilterSection.Location = New Point(0, 4)
        lblFilterSection.Name = "lblFilterSection"
        lblFilterSection.Size = New Size(180, 25)
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
        pnlProgressCard.Location = New Point(28, 95)
        pnlProgressCard.Name = "pnlProgressCard"
        pnlProgressCard.Padding = New Padding(20)
        pnlProgressCard.Size = New Size(924, 115)
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
        pnlAttentionBox.Location = New Point(590, 16)
        pnlAttentionBox.Name = "pnlAttentionBox"
        pnlAttentionBox.Size = New Size(316, 80)
        pnlAttentionBox.TabIndex = 4
        ' 
        ' lblAttentionDesc
        ' 
        lblAttentionDesc.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblAttentionDesc.ForeColor = Color.FromArgb(100, 116, 139)
        lblAttentionDesc.Location = New Point(55, 36)
        lblAttentionDesc.Name = "lblAttentionDesc"
        lblAttentionDesc.Size = New Size(250, 34)
        lblAttentionDesc.TabIndex = 2
        lblAttentionDesc.Text = "Complete the remaining requirements to finalize your clearance."
        ' 
        ' lblAttentionTitle
        ' 
        lblAttentionTitle.AutoSize = True
        lblAttentionTitle.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblAttentionTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblAttentionTitle.Location = New Point(55, 16)
        lblAttentionTitle.Name = "lblAttentionTitle"
        lblAttentionTitle.Size = New Size(153, 15)
        lblAttentionTitle.TabIndex = 1
        lblAttentionTitle.Text = "0 offices need your attention"
        ' 
        ' lblAttentionIcon
        ' 
        lblAttentionIcon.BackColor = Color.FromArgb(238, 242, 255)
        lblAttentionIcon.Font = New Font("Segoe UI Emoji", 14.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblAttentionIcon.ForeColor = Color.FromArgb(79, 70, 229)
        lblAttentionIcon.Location = New Point(12, 18)
        lblAttentionIcon.Name = "lblAttentionIcon"
        lblAttentionIcon.Size = New Size(36, 42)
        lblAttentionIcon.TabIndex = 0
        lblAttentionIcon.Text = "📋"
        lblAttentionIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblProgressPercent
        ' 
        lblProgressPercent.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblProgressPercent.AutoSize = True
        lblProgressPercent.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblProgressPercent.ForeColor = Color.FromArgb(15, 23, 42)
        lblProgressPercent.Location = New Point(530, 75)
        lblProgressPercent.Name = "lblProgressPercent"
        lblProgressPercent.Size = New Size(26, 17)
        lblProgressPercent.TabIndex = 3
        lblProgressPercent.Text = "0%"
        ' 
        ' pbOverall
        ' 
        pbOverall.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbOverall.Location = New Point(20, 78)
        pbOverall.Name = "pbOverall"
        pbOverall.Size = New Size(500, 12)
        pbOverall.TabIndex = 2
        ' 
        ' lblProgressSub
        ' 
        lblProgressSub.AutoSize = True
        lblProgressSub.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblProgressSub.ForeColor = Color.FromArgb(100, 116, 139)
        lblProgressSub.Location = New Point(20, 50)
        lblProgressSub.Name = "lblProgressSub"
        lblProgressSub.Size = New Size(116, 15)
        lblProgressSub.TabIndex = 1
        lblProgressSub.Text = "0 of 0 offices cleared"
        ' 
        ' lblProgressTitle
        ' 
        lblProgressTitle.AutoSize = True
        lblProgressTitle.Font = New Font("Segoe UI", 13.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblProgressTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblProgressTitle.Location = New Point(18, 18)
        lblProgressTitle.Name = "lblProgressTitle"
        lblProgressTitle.Size = New Size(181, 25)
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
        pnlHeader.Location = New Point(28, 15)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 65)
        pnlHeader.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BackColor = Color.White
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefresh.ForeColor = Color.FromArgb(51, 65, 85)
        btnRefresh.Location = New Point(824, 14)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(100, 34)
        btnRefresh.TabIndex = 3
        btnRefresh.Text = "🔄 Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' lblTermBadge
        ' 
        lblTermBadge.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTermBadge.BackColor = Color.FromArgb(238, 242, 255)
        lblTermBadge.BorderStyle = BorderStyle.FixedSingle
        lblTermBadge.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblTermBadge.ForeColor = Color.FromArgb(49, 46, 129)
        lblTermBadge.Location = New Point(630, 14)
        lblTermBadge.Name = "lblTermBadge"
        lblTermBadge.Padding = New Padding(6)
        lblTermBadge.Size = New Size(180, 34)
        lblTermBadge.TabIndex = 2
        lblTermBadge.Text = "📅 Current Term"
        lblTermBadge.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblStudentCourseYear
        ' 
        lblStudentCourseYear.AutoSize = True
        lblStudentCourseYear.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblStudentCourseYear.ForeColor = Color.FromArgb(100, 116, 139)
        lblStudentCourseYear.Location = New Point(0, 38)
        lblStudentCourseYear.Name = "lblStudentCourseYear"
        lblStudentCourseYear.Size = New Size(130, 17)
        lblStudentCourseYear.TabIndex = 1
        lblStudentCourseYear.Text = "Course  •  Year Level"
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 0)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(183, 37)
        lblHeaderTitle.TabIndex = 0
        lblHeaderTitle.Text = "My clearance"
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
        pnlSampleOfficeCard1.ResumeLayout(False)
        pnlSampleOfficeCard1.PerformLayout()
        pnlFileAttach1.ResumeLayout(False)
        pnlFileAttach1.PerformLayout()
        pnlSampleOfficeCard2.ResumeLayout(False)
        pnlSampleOfficeCard2.PerformLayout()
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
    Friend WithEvents pnlSampleOfficeCard1 As Panel
    Friend WithEvents lblOfficeIcon1 As Label
    Friend WithEvents lblOfficeTitle1 As Label
    Friend WithEvents lblOfficeStatusBadge1 As Label
    Friend WithEvents lblOfficeDesc1 As Label
    Friend WithEvents pnlFileAttach1 As Panel
    Friend WithEvents lblFileIcon1 As Label
    Friend WithEvents lblFileName1 As Label
    Friend WithEvents lblFileDate1 As Label
    Friend WithEvents btnAction1 As Button
    Friend WithEvents pnlSampleOfficeCard2 As Panel
    Friend WithEvents lblOfficeIcon2 As Label
    Friend WithEvents lblOfficeTitle2 As Label
    Friend WithEvents lblOfficeStatusBadge2 As Label
    Friend WithEvents lblOfficeDesc2 As Label
    Friend WithEvents btnAction2 As Button
    Friend WithEvents pnlPagination As Panel
    Friend WithEvents lblShowingOffices As Label
    Friend WithEvents btnPage1 As Button
    Friend WithEvents btnPage2 As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents pnlViewHost As Panel

End Class
