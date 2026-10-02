Imports System.Data
Imports MySql.Data.MySqlClient

Public Class StaffDashboardForm

    Private ReadOnly db As New DatabaseHelper()
    Private currentDepartmentName As String = "Assigned Office"


    Private Sub StaffDashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySchoolLogo(picSchoolLogo)
        InitializeStaffInfo()
        LoadDashboardData()
    End Sub

    Private Sub InitializeStaffInfo()
        lblStaffName.Text = If(String.IsNullOrWhiteSpace(AppSession.FullName), "Staff Officer", AppSession.FullName)
        lblDateTimeBadge.Text = "📅 " & DateTime.Now.ToString("dddd, MMM dd, yyyy")

        If AppSession.DepartmentID.HasValue Then
            Try
                Dim dtDept As DataTable = db.ExecuteQuery(
                    "SELECT DepartmentName FROM Departments WHERE DepartmentID = @DeptID LIMIT 1;",
                    New Dictionary(Of String, Object) From {{"@DeptID", AppSession.DepartmentID.Value}}
                )
                If dtDept.Rows.Count > 0 Then
                    currentDepartmentName = dtDept.Rows(0)("DepartmentName").ToString()
                End If
            Catch ex As Exception
                ' Keep fallback
            End Try
        End If

        lblOfficeName.Text = currentDepartmentName
        lblMyOfficeTitle.Text = currentDepartmentName
    End Sub

    Public Sub LoadDashboardData()
        If Not AppSession.DepartmentID.HasValue Then
            MessageBox.Show(
                "Your account is not assigned to any specific office. Please contact the administrator.",
                "Office Assignment Required",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim deptID As Integer = AppSession.DepartmentID.Value

        ' 1. Load Count Cards
        Try
            Dim countQuery As String =
                "SELECT " &
                "  SUM(CASE WHEN cr.Status = 'Pending' THEN 1 ELSE 0 END) AS PendingCount, " &
                "  SUM(CASE WHEN cr.Status = 'Under Review' THEN 1 ELSE 0 END) AS ReviewCount, " &
                "  SUM(CASE WHEN cr.Status = 'Cleared' AND DATE(cr.ReviewedAt) = CURDATE() THEN 1 ELSE 0 END) AS ApprovedToday, " &
                "  SUM(CASE WHEN cr.Status = 'Rejected' AND DATE(cr.ReviewedAt) = CURDATE() THEN 1 ELSE 0 END) AS RejectedToday " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "WHERE r.DepartmentID = @DeptID;"

            Dim dtCounts As DataTable = db.ExecuteQuery(countQuery, New Dictionary(Of String, Object) From {{"@DeptID", deptID}})
            If dtCounts.Rows.Count > 0 Then
                Dim row = dtCounts.Rows(0)
                lblPendingCount.Text = If(IsDBNull(row("PendingCount")), "0", row("PendingCount").ToString())
                lblReviewCount.Text = If(IsDBNull(row("ReviewCount")), "0", row("ReviewCount").ToString())
                lblApprovedCount.Text = If(IsDBNull(row("ApprovedToday")), "0", row("ApprovedToday").ToString())
                lblRejectedCount.Text = If(IsDBNull(row("RejectedToday")), "0", row("RejectedToday").ToString())
            End If
        Catch ex As Exception
            lblPendingCount.Text = "0"
            lblReviewCount.Text = "0"
            lblApprovedCount.Text = "0"
            lblRejectedCount.Text = "0"
        End Try

        ' 2. Load Recent Submissions
        Try
            Dim recentQuery As String =
                "SELECT " &
                "  cr.RecordID, " &
                "  u.StudentNo, " &
                "  u.FullName AS StudentName, " &
                "  r.RequirementName, " &
                "  cr.SubmittedAt, " &
                "  cr.Status " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "INNER JOIN Users u ON cr.StudentID = u.UserID " &
                "WHERE r.DepartmentID = @DeptID " &
                "ORDER BY COALESCE(cr.SubmittedAt, cr.CreatedAt) DESC " &
                "LIMIT 10;"

            Dim dtRecent As DataTable = db.ExecuteQuery(recentQuery, New Dictionary(Of String, Object) From {{"@DeptID", deptID}})
            dgvRecent.Rows.Clear()

            Dim num As Integer = 1
            For Each row As DataRow In dtRecent.Rows
                Dim recordID As Integer = Convert.ToInt32(row("RecordID"))
                Dim studentNo As String = row("StudentNo").ToString()
                Dim studentName As String = row("StudentName").ToString()
                Dim requirement As String = row("RequirementName").ToString()
                Dim status As String = row("Status").ToString()
                Dim submittedAtText As String = "Not submitted"

                If Not IsDBNull(row("SubmittedAt")) Then
                    Dim subDate As DateTime = Convert.ToDateTime(row("SubmittedAt"))
                    submittedAtText = subDate.ToString("MMM dd, yyyy hh:mm tt")
                End If

                Dim rowIndex As Integer = dgvRecent.Rows.Add(num, recordID, studentNo, studentName, requirement, submittedAtText, status, "Review")
                dgvRecent.Rows(rowIndex).Tag = recordID
                num += 1
            Next
        Catch ex As Exception
            MessageBox.Show("Failed to load recent submissions: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ============================================================
    ' SPA VIEW SWITCHING (SINGLE PAGE ARCHITECTURE)
    ' ============================================================


    Public Sub ShowDashboardView()
        SetActiveNavButton(btnNavDashboard)
        If pnlViewHost IsNot Nothing Then
            pnlViewHost.Visible = False
            pnlViewHost.Controls.Clear()
        End If
        pnlMain.Visible = True
        pnlMain.BringToFront()
        LoadDashboardData()
    End Sub

    Public Sub ShowRequestsView()
        SetActiveNavButton(btnNavRequests)
        Dim reqForm As New StaffRequestsForm()
        LoadChildFormView(reqForm)
    End Sub

    Public Sub ShowHistoryView()
        SetActiveNavButton(btnNavHistory)
        Dim histForm As New StaffHistoryForm()
        LoadChildFormView(histForm)
    End Sub

    Public Sub ShowReviewView(recordID As Integer)
        Dim topForm As Form = Me.FindForm()
        If topForm Is Nothing Then topForm = Me

        Dim modalBackdrop As New Form()
        Try
            modalBackdrop.FormBorderStyle = FormBorderStyle.None
            modalBackdrop.BackColor = Color.Black
            modalBackdrop.Opacity = 0.45R
            modalBackdrop.ShowInTaskbar = False
            modalBackdrop.StartPosition = FormStartPosition.Manual
            modalBackdrop.Location = topForm.PointToScreen(Point.Empty)
            modalBackdrop.Size = topForm.ClientSize
            modalBackdrop.Owner = topForm
            modalBackdrop.Show()

            Using reviewForm As New ReviewClearanceForm()
                reviewForm.TargetRecordID = recordID
                reviewForm.ShowDialog(modalBackdrop)
            End Using

            LoadDashboardData()
        Finally
            modalBackdrop.Dispose()
        End Try
    End Sub

    Private Sub LoadChildFormView(childForm As Form)
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.MinimumSize = Size.Empty
        childForm.Dock = DockStyle.Fill

        Dim childSidebar As Control = childForm.Controls("pnlSidebar")
        If childSidebar IsNot Nothing Then
            childSidebar.Visible = False
        End If

        pnlViewHost.Controls.Clear()
        pnlViewHost.Controls.Add(childForm)
        pnlMain.Visible = False
        pnlViewHost.Visible = True
        pnlViewHost.BringToFront()
        childForm.Show()
    End Sub

    Private Sub SetActiveNavButton(activeBtn As Button)
        If pnlNavIndicator IsNot Nothing AndAlso activeBtn IsNot Nothing Then
            pnlNavIndicator.Top = activeBtn.Top
            pnlNavIndicator.Height = activeBtn.Height
            pnlNavIndicator.BringToFront()
        End If
    End Sub

    ' ============================================================
    ' ACTIONS IN DATAGRIDVIEW
    ' ============================================================
    Private Sub dgvRecent_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecent.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = colAction.Index Then
            Dim row = dgvRecent.Rows(e.RowIndex)
            Dim recordID As Integer = Convert.ToInt32(row.Cells(colRecordID.Index).Value)
            ShowReviewView(recordID)
        End If
    End Sub

    ' ============================================================
    ' CUSTOM CELL PAINTING: STATUS PILL & REVIEW BUTTON
    ' ============================================================
    Private Sub dgvRecent_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvRecent.CellPainting
        If e.RowIndex < 0 Then Return

        ' 1. Status Column: Render rounded pill badge
        If e.ColumnIndex = colStatus.Index Then
            e.PaintBackground(e.CellBounds, True)

            Dim statusText As String = If(e.Value IsNot Nothing, e.Value.ToString().Trim(), "")
            If Not String.IsNullOrWhiteSpace(statusText) Then
                Dim pillBg As Color
                Dim pillFg As Color

                Select Case statusText.ToLowerInvariant()
                    Case "under review"
                        pillBg = Color.FromArgb(219, 234, 254)
                        pillFg = Color.FromArgb(37, 99, 235)
                    Case "cleared"
                        pillBg = Color.FromArgb(220, 252, 231)
                        pillFg = Color.FromArgb(21, 128, 61)
                    Case "rejected"
                        pillBg = Color.FromArgb(254, 226, 226)
                        pillFg = Color.FromArgb(185, 28, 28)
                    Case Else ' Pending
                        pillBg = Color.FromArgb(254, 243, 199)
                        pillFg = Color.FromArgb(180, 83, 9)
                End Select

                Using pillFont As New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
                    Dim textSize As Size = TextRenderer.MeasureText(e.Graphics, statusText, pillFont)
                    Dim pillWidth As Integer = Math.Max(textSize.Width + 18, 92)
                    If pillWidth > e.CellBounds.Width - 8 Then pillWidth = e.CellBounds.Width - 8
                    Dim pillHeight As Integer = 24
                    Dim pillX As Integer = e.CellBounds.X + (e.CellBounds.Width - pillWidth) \ 2
                    Dim pillY As Integer = e.CellBounds.Y + (e.CellBounds.Height - pillHeight) \ 2
                    Dim pillRect As New Rectangle(pillX, pillY, pillWidth, pillHeight)

                    e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                    Using path As Drawing2D.GraphicsPath = CreatePillPath(pillRect)
                        Using brush As New SolidBrush(pillBg)
                            e.Graphics.FillPath(brush, path)
                        End Using
                    End Using

                    TextRenderer.DrawText(
                        e.Graphics,
                        statusText,
                        pillFont,
                        pillRect,
                        pillFg,
                        TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.SingleLine
                    )
                End Using
            End If

            e.Handled = True
            Return
        End If

        ' 2. Action Column: Render rounded outline Review button
        If e.ColumnIndex = colAction.Index Then
            e.PaintBackground(e.CellBounds, True)

            Dim btnWidth As Integer = Math.Min(82, e.CellBounds.Width - 8)
            Dim btnHeight As Integer = 26
            Dim btnX As Integer = e.CellBounds.X + (e.CellBounds.Width - btnWidth) \ 2
            Dim btnY As Integer = e.CellBounds.Y + (e.CellBounds.Height - btnHeight) \ 2
            Dim btnRect As New Rectangle(btnX, btnY, btnWidth, btnHeight)

            Using btnFont As New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
                e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
                Using path As Drawing2D.GraphicsPath = CreatePillPath(btnRect)
                    Using fillBrush As New SolidBrush(Color.White)
                        e.Graphics.FillPath(fillBrush, path)
                    End Using
                    Using borderPen As New Pen(Color.FromArgb(59, 130, 246), 1.2F)
                        e.Graphics.DrawPath(borderPen, path)
                    End Using
                End Using

                Dim actionText As String = If(e.FormattedValue IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(e.FormattedValue.ToString()), e.FormattedValue.ToString(), "Review")
                TextRenderer.DrawText(
                    e.Graphics,
                    actionText,
                    btnFont,
                    btnRect,
                    Color.FromArgb(37, 99, 235),
                    TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.SingleLine
                )
            End Using

            e.Handled = True
            Return
        End If
    End Sub

    Private Function CreatePillPath(rect As Rectangle) As Drawing2D.GraphicsPath
        Dim path As New Drawing2D.GraphicsPath()
        Dim radius As Integer = rect.Height \ 2
        Dim d As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub dgvRecent_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRecent.CellMouseMove
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = colAction.Index Then
            dgvRecent.Cursor = Cursors.Hand
        Else
            dgvRecent.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dgvRecent_MouseLeave(sender As Object, e As EventArgs) Handles dgvRecent.MouseLeave
        dgvRecent.Cursor = Cursors.Default
    End Sub

    ' Navigation Click Events
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        ShowDashboardView()
    End Sub

    Private Sub btnNavRequests_Click(sender As Object, e As EventArgs) Handles btnNavRequests.Click, btnViewAll.Click, btnQuickRequests.Click
        ShowRequestsView()
    End Sub

    Private Sub btnNavHistory_Click(sender As Object, e As EventArgs) Handles btnNavHistory.Click, btnQuickHistory.Click
        ShowHistoryView()
    End Sub

    Private Sub btnQuickReview_Click(sender As Object, e As EventArgs) Handles btnQuickReview.Click
        If dgvRecent.Rows.Count > 0 Then
            Dim recordID As Integer = Convert.ToInt32(dgvRecent.Rows(0).Cells(colRecordID.Index).Value)
            ShowReviewView(recordID)
        Else
            MessageBox.Show("There are no recent submissions to review.", "No Submissions", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnNavLogout_Click(sender As Object, e As EventArgs) Handles btnNavLogout.Click
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            AppSession.Clear()
            Me.Close()
        End If
    End Sub

End Class
