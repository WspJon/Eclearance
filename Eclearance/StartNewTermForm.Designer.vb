<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StartNewTermForm
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
        lblNoteOnce = New Label()
        pnlTermModalCard = New Panel()
        btnStartTerm = New Button()
        btnCancel = New Button()
        pnlWillDoBox = New Panel()
        lblCheck3 = New Label()
        lblCheck2 = New Label()
        lblCheck1 = New Label()
        lblWillDoTitle = New Label()
        lblWillDoIcon = New Label()
        cmbSemester = New ComboBox()
        lblSemester = New Label()
        lblFormatHelp = New Label()
        txtSchoolYear = New TextBox()
        lblSchoolYear = New Label()
        pnlCalendarIconWrap = New Panel()
        lblCalendarIcon = New Label()
        pnlHeader = New Panel()
        lblSubHeader = New Label()
        lblHeaderTitle = New Label()
        lblBreadcrumb = New Label()
        pnlSidebar.SuspendLayout()
        pnlLogo.SuspendLayout()
        pnlMain.SuspendLayout()
        pnlTermModalCard.SuspendLayout()
        pnlWillDoBox.SuspendLayout()
        pnlCalendarIconWrap.SuspendLayout()
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
        btnNavHistory.BackColor = Color.FromArgb(15, 39, 74)
        btnNavHistory.FlatAppearance.BorderSize = 0
        btnNavHistory.FlatStyle = FlatStyle.Flat
        btnNavHistory.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        btnNavHistory.ForeColor = Color.FromArgb(160, 180, 208)
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
        btnNavStartTerm.BackColor = Color.FromArgb(28, 91, 184)
        btnNavStartTerm.FlatAppearance.BorderSize = 0
        btnNavStartTerm.FlatStyle = FlatStyle.Flat
        btnNavStartTerm.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnNavStartTerm.ForeColor = Color.White
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
        pnlMain.Controls.Add(lblNoteOnce)
        pnlMain.Controls.Add(pnlTermModalCard)
        pnlMain.Controls.Add(pnlHeader)
        pnlMain.Dock = DockStyle.Fill
        pnlMain.Location = New Point(220, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Padding = New Padding(28, 16, 28, 20)
        pnlMain.Size = New Size(980, 800)
        pnlMain.TabIndex = 1
        ' 
        ' lblNoteOnce
        ' 
        lblNoteOnce.Anchor = AnchorStyles.Bottom
        lblNoteOnce.AutoSize = True
        lblNoteOnce.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblNoteOnce.ForeColor = Color.FromArgb(148, 163, 184)
        lblNoteOnce.Location = New Point(360, 765)
        lblNoteOnce.Name = "lblNoteOnce"
        lblNoteOnce.Size = New Size(280, 15)
        lblNoteOnce.TabIndex = 2
        lblNoteOnce.Text = "Each school year and semester can be created only once."
        ' 
        ' pnlTermModalCard
        ' 
        pnlTermModalCard.Anchor = AnchorStyles.None
        pnlTermModalCard.BackColor = Color.White
        pnlTermModalCard.BorderStyle = BorderStyle.FixedSingle
        pnlTermModalCard.Controls.Add(btnStartTerm)
        pnlTermModalCard.Controls.Add(btnCancel)
        pnlTermModalCard.Controls.Add(pnlWillDoBox)
        pnlTermModalCard.Controls.Add(cmbSemester)
        pnlTermModalCard.Controls.Add(lblSemester)
        pnlTermModalCard.Controls.Add(lblFormatHelp)
        pnlTermModalCard.Controls.Add(txtSchoolYear)
        pnlTermModalCard.Controls.Add(lblSchoolYear)
        pnlTermModalCard.Controls.Add(pnlCalendarIconWrap)
        pnlTermModalCard.Location = New Point(220, 110)
        pnlTermModalCard.Name = "pnlTermModalCard"
        pnlTermModalCard.Padding = New Padding(32)
        pnlTermModalCard.Size = New Size(540, 620)
        pnlTermModalCard.TabIndex = 1
        ' 
        ' btnStartTerm
        ' 
        btnStartTerm.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnStartTerm.BackColor = Color.FromArgb(11, 99, 229)
        btnStartTerm.Cursor = Cursors.Hand
        btnStartTerm.FlatAppearance.BorderSize = 0
        btnStartTerm.FlatStyle = FlatStyle.Flat
        btnStartTerm.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        btnStartTerm.ForeColor = Color.White
        btnStartTerm.Location = New Point(390, 552)
        btnStartTerm.Name = "btnStartTerm"
        btnStartTerm.Size = New Size(116, 38)
        btnStartTerm.TabIndex = 8
        btnStartTerm.Text = "Start term"
        btnStartTerm.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnCancel.BackColor = Color.White
        btnCancel.Cursor = Cursors.Hand
        btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225)
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.FromArgb(71, 85, 105)
        btnCancel.Location = New Point(32, 552)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(95, 38)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' pnlWillDoBox
        ' 
        pnlWillDoBox.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlWillDoBox.BackColor = Color.FromArgb(240, 246, 255)
        pnlWillDoBox.BorderStyle = BorderStyle.FixedSingle
        pnlWillDoBox.Controls.Add(lblCheck3)
        pnlWillDoBox.Controls.Add(lblCheck2)
        pnlWillDoBox.Controls.Add(lblCheck1)
        pnlWillDoBox.Controls.Add(lblWillDoTitle)
        pnlWillDoBox.Controls.Add(lblWillDoIcon)
        pnlWillDoBox.Location = New Point(32, 335)
        pnlWillDoBox.Name = "pnlWillDoBox"
        pnlWillDoBox.Padding = New Padding(16)
        pnlWillDoBox.Size = New Size(474, 185)
        pnlWillDoBox.TabIndex = 6
        ' 
        ' lblCheck3
        ' 
        lblCheck3.AutoSize = True
        lblCheck3.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblCheck3.ForeColor = Color.FromArgb(30, 41, 59)
        lblCheck3.Location = New Point(50, 135)
        lblCheck3.Name = "lblCheck3"
        lblCheck3.Size = New Size(302, 15)
        lblCheck3.TabIndex = 4
        lblCheck3.Text = "✔  Keep previous terms and submissions in History"
        ' 
        ' lblCheck2
        ' 
        lblCheck2.AutoSize = True
        lblCheck2.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblCheck2.ForeColor = Color.FromArgb(30, 41, 59)
        lblCheck2.Location = New Point(50, 95)
        lblCheck2.Name = "lblCheck2"
        lblCheck2.Size = New Size(260, 15)
        lblCheck2.TabIndex = 3
        lblCheck2.Text = "✔  Use current course and NSTP assignments"
        ' 
        ' lblCheck1
        ' 
        lblCheck1.AutoSize = True
        lblCheck1.Font = New Font("Segoe UI", 8.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblCheck1.ForeColor = Color.FromArgb(30, 41, 59)
        lblCheck1.Location = New Point(50, 55)
        lblCheck1.Name = "lblCheck1"
        lblCheck1.Size = New Size(270, 15)
        lblCheck1.TabIndex = 2
        lblCheck1.Text = "✔  Create pending requirements for all students"
        ' 
        ' lblWillDoTitle
        ' 
        lblWillDoTitle.AutoSize = True
        lblWillDoTitle.Font = New Font("Segoe UI Semibold", 9.5F, FontStyle.Bold, GraphicsUnit.Point)
        lblWillDoTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblWillDoTitle.Location = New Point(50, 18)
        lblWillDoTitle.Name = "lblWillDoTitle"
        lblWillDoTitle.Size = New Size(111, 17)
        lblWillDoTitle.TabIndex = 1
        lblWillDoTitle.Text = "What this will do"
        ' 
        ' lblWillDoIcon
        ' 
        lblWillDoIcon.BackColor = Color.FromArgb(219, 234, 254)
        lblWillDoIcon.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblWillDoIcon.ForeColor = Color.FromArgb(29, 78, 216)
        lblWillDoIcon.Location = New Point(18, 16)
        lblWillDoIcon.Name = "lblWillDoIcon"
        lblWillDoIcon.Size = New Size(22, 22)
        lblWillDoIcon.TabIndex = 0
        lblWillDoIcon.Text = "ℹ"
        lblWillDoIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cmbSemester
        ' 
        cmbSemester.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cmbSemester.DropDownStyle = ComboBoxStyle.DropDown
        cmbSemester.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        cmbSemester.FormattingEnabled = True
        cmbSemester.Items.AddRange(New Object() {"1st Semester", "2nd Semester", "Summer Term", "Term 1", "Term 2", "Term 3", "Term 4"})
        cmbSemester.Location = New Point(32, 265)
        cmbSemester.Name = "cmbSemester"
        cmbSemester.Size = New Size(474, 24)
        cmbSemester.TabIndex = 5
        ' 
        ' lblSemester
        ' 
        lblSemester.AutoSize = True
        lblSemester.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSemester.ForeColor = Color.FromArgb(51, 65, 85)
        lblSemester.Location = New Point(32, 245)
        lblSemester.Name = "lblSemester"
        lblSemester.Size = New Size(57, 15)
        lblSemester.TabIndex = 4
        lblSemester.Text = "Semester"
        ' 
        ' lblFormatHelp
        ' 
        lblFormatHelp.AutoSize = True
        lblFormatHelp.Font = New Font("Segoe UI", 8.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFormatHelp.ForeColor = Color.FromArgb(148, 163, 184)
        lblFormatHelp.Location = New Point(32, 205)
        lblFormatHelp.Name = "lblFormatHelp"
        lblFormatHelp.Size = New Size(107, 13)
        lblFormatHelp.TabIndex = 3
        lblFormatHelp.Text = "Format: YYYY-YYYY"
        ' 
        ' txtSchoolYear
        ' 
        txtSchoolYear.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSchoolYear.BorderStyle = BorderStyle.FixedSingle
        txtSchoolYear.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        txtSchoolYear.Location = New Point(32, 175)
        txtSchoolYear.Name = "txtSchoolYear"
        txtSchoolYear.Size = New Size(474, 24)
        txtSchoolYear.TabIndex = 2
        ' 
        ' lblSchoolYear
        ' 
        lblSchoolYear.AutoSize = True
        lblSchoolYear.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSchoolYear.ForeColor = Color.FromArgb(51, 65, 85)
        lblSchoolYear.Location = New Point(32, 150)
        lblSchoolYear.Name = "lblSchoolYear"
        lblSchoolYear.Size = New Size(69, 15)
        lblSchoolYear.TabIndex = 1
        lblSchoolYear.Text = "School year"
        ' 
        ' pnlCalendarIconWrap
        ' 
        pnlCalendarIconWrap.Anchor = AnchorStyles.Top
        pnlCalendarIconWrap.BackColor = Color.FromArgb(238, 242, 255)
        pnlCalendarIconWrap.Controls.Add(lblCalendarIcon)
        pnlCalendarIconWrap.Location = New Point(235, 40)
        pnlCalendarIconWrap.Name = "pnlCalendarIconWrap"
        pnlCalendarIconWrap.Size = New Size(70, 70)
        pnlCalendarIconWrap.TabIndex = 0
        ' 
        ' lblCalendarIcon
        ' 
        lblCalendarIcon.Dock = DockStyle.Fill
        lblCalendarIcon.Font = New Font("Segoe UI Emoji", 26.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblCalendarIcon.ForeColor = Color.FromArgb(37, 99, 235)
        lblCalendarIcon.Location = New Point(0, 0)
        lblCalendarIcon.Name = "lblCalendarIcon"
        lblCalendarIcon.Size = New Size(70, 70)
        lblCalendarIcon.TabIndex = 0
        lblCalendarIcon.Text = "📅"
        lblCalendarIcon.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' pnlHeader
        ' 
        pnlHeader.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pnlHeader.Controls.Add(lblSubHeader)
        pnlHeader.Controls.Add(lblHeaderTitle)
        pnlHeader.Controls.Add(lblBreadcrumb)
        pnlHeader.Location = New Point(28, 12)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.Size = New Size(924, 85)
        pnlHeader.TabIndex = 0
        ' 
        ' lblSubHeader
        ' 
        lblSubHeader.AutoSize = True
        lblSubHeader.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point)
        lblSubHeader.ForeColor = Color.FromArgb(100, 116, 139)
        lblSubHeader.Location = New Point(0, 58)
        lblSubHeader.Name = "lblSubHeader"
        lblSubHeader.Size = New Size(264, 17)
        lblSubHeader.TabIndex = 2
        lblSubHeader.Text = "Set up a fresh clearance cycle for your students."
        ' 
        ' lblHeaderTitle
        ' 
        lblHeaderTitle.AutoSize = True
        lblHeaderTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42)
        lblHeaderTitle.Location = New Point(-3, 20)
        lblHeaderTitle.Name = "lblHeaderTitle"
        lblHeaderTitle.Size = New Size(307, 37)
        lblHeaderTitle.TabIndex = 1
        lblHeaderTitle.Text = "Start a new school term"
        ' 
        ' lblBreadcrumb
        ' 
        lblBreadcrumb.AutoSize = True
        lblBreadcrumb.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblBreadcrumb.ForeColor = Color.FromArgb(100, 116, 139)
        lblBreadcrumb.Location = New Point(0, 0)
        lblBreadcrumb.Name = "lblBreadcrumb"
        lblBreadcrumb.Size = New Size(160, 15)
        lblBreadcrumb.TabIndex = 0
        lblBreadcrumb.Text = "Administration  /  School terms"
        ' 
        ' StartNewTermForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(244, 247, 251)
        ClientSize = New Size(1200, 800)
        Controls.Add(pnlMain)
        Controls.Add(pnlSidebar)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        MinimumSize = New Size(1100, 750)
        Name = "StartNewTermForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "School Clearance - Start New School Term"
        pnlSidebar.ResumeLayout(False)
        pnlSidebar.PerformLayout()
        pnlLogo.ResumeLayout(False)
        pnlLogo.PerformLayout()
        pnlMain.ResumeLayout(False)
        pnlMain.PerformLayout()
        pnlTermModalCard.ResumeLayout(False)
        pnlTermModalCard.PerformLayout()
        pnlWillDoBox.ResumeLayout(False)
        pnlWillDoBox.PerformLayout()
        pnlCalendarIconWrap.ResumeLayout(False)
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
    Friend WithEvents lblBreadcrumb As Label
    Friend WithEvents lblHeaderTitle As Label
    Friend WithEvents lblSubHeader As Label
    Friend WithEvents pnlTermModalCard As Panel
    Friend WithEvents pnlCalendarIconWrap As Panel
    Friend WithEvents lblCalendarIcon As Label
    Friend WithEvents lblSchoolYear As Label
    Friend WithEvents txtSchoolYear As TextBox
    Friend WithEvents lblFormatHelp As Label
    Friend WithEvents lblSemester As Label
    Friend WithEvents cmbSemester As ComboBox
    Friend WithEvents pnlWillDoBox As Panel
    Friend WithEvents lblWillDoIcon As Label
    Friend WithEvents lblWillDoTitle As Label
    Friend WithEvents lblCheck1 As Label
    Friend WithEvents lblCheck2 As Label
    Friend WithEvents lblCheck3 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnStartTerm As Button
    Friend WithEvents lblNoteOnce As Label

End Class
