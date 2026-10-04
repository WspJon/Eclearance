Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class StaffRequestsForm

    Private ReadOnly db As New DatabaseHelper()
    Private currentDepartmentName As String = "Assigned Office"
    Private currentFilterStatus As String = "All"
    Private allRequestsTable As DataTable = Nothing

    Private Sub StaffRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySchoolLogo(picSchoolLogo)
        InitializeStaffInfo()
        UpdateFilterButtonsUI(btnFilterAll)
        LayoutFilterBar()
        LoadRequestsData()
    End Sub

    Private Sub pnlFilterBar_Resize(sender As Object, e As EventArgs) Handles pnlFilterBar.Resize
        LayoutFilterBar()
    End Sub

    Private Sub LayoutFilterBar()
        If pnlFilterBar Is Nothing OrElse txtSearch Is Nothing OrElse btnFilterAll Is Nothing Then Return

        Dim barWidth As Integer = pnlFilterBar.ClientSize.Width
        Dim refreshWidth As Integer = If(btnRefresh IsNot Nothing, btnRefresh.Width, 88)
        Dim btnGap As Integer = 6

        Dim allBtnWidth As Integer = btnFilterAll.Width + btnFilterPending.Width + btnFilterReview.Width + btnFilterCleared.Width + btnFilterRejected.Width + (btnGap * 4)

        Dim maxSearchWidth As Integer = Math.Max(300, barWidth - allBtnWidth - refreshWidth - 50)
        Dim targetSearchWidth As Integer = 320

        If barWidth >= 1100 Then
            targetSearchWidth = Math.Min(400, maxSearchWidth)
        ElseIf barWidth >= 900 Then
            targetSearchWidth = Math.Min(340, maxSearchWidth)
        Else
            targetSearchWidth = Math.Min(300, maxSearchWidth)
        End If

        txtSearch.Width = targetSearchWidth
        Dim curX As Integer = txtSearch.Left + txtSearch.Width + 12

        btnFilterAll.Left = curX
        curX += btnFilterAll.Width + btnGap

        btnFilterPending.Left = curX
        curX += btnFilterPending.Width + btnGap

        btnFilterReview.Left = curX
        curX += btnFilterReview.Width + btnGap

        btnFilterCleared.Left = curX
        curX += btnFilterCleared.Width + btnGap

        btnFilterRejected.Left = curX

        If btnRefresh IsNot Nothing Then
            btnRefresh.Left = barWidth - btnRefresh.Width - 14
        End If
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

    Public Sub LoadRequestsData()

        If Not AppSession.DepartmentID.HasValue Then
            Return
        End If

        Dim deptID As Integer = AppSession.DepartmentID.Value

        Dim activeTermID As Integer = 0

        Try
            Dim dtTerm As DataTable =
            db.ExecuteQuery(
                "SELECT TermID " &
                "FROM AcademicTerms " &
                "WHERE IsActive = 1 " &
                "ORDER BY TermID DESC " &
                "LIMIT 1;"
            )

            If dtTerm.Rows.Count > 0 Then
                activeTermID =
                Convert.ToInt32(
                    dtTerm.Rows(0)("TermID")
                )
            End If

        Catch
        End Try

        Try

            Dim countQuery As String =
            "SELECT " &
            "COUNT(*) AS TotalCount, " &
            "SUM(" &
            "CASE " &
            "WHEN cr.Status = 'Under Review' THEN 1 " &
            "ELSE 0 " &
            "END" &
            ") AS PendingReviewCount " &
            "FROM ClearanceRecords cr " &
            "INNER JOIN ClearanceRequirements r " &
            "ON cr.RequirementID = r.RequirementID " &
            "WHERE r.DepartmentID = @DeptID " &
            "AND (@TermID = 0 OR cr.TermID = @TermID) " &
            "AND cr.Status <> 'Not Applicable' " &
            "AND (" &
            "     cr.SubmittedAt IS NOT NULL " &
            "     OR cr.Status IN ('Under Review', 'Cleared', 'Rejected')" &
            ");"

            Dim dtCounts As DataTable =
            db.ExecuteQuery(
                countQuery,
                New Dictionary(Of String, Object) From {
                    {"@DeptID", deptID},
                    {"@TermID", activeTermID}
                }
            )

            If dtCounts.Rows.Count > 0 Then

                Dim row As DataRow =
                dtCounts.Rows(0)

                lblTotalCount.Text =
                If(
                    IsDBNull(row("TotalCount")),
                    "0",
                    row("TotalCount").ToString()
                )

                lblPendingCount.Text =
                If(
                    IsDBNull(row("PendingReviewCount")),
                    "0",
                    row("PendingReviewCount").ToString()
                )

            End If

        Catch ex As Exception

            lblTotalCount.Text = "0"
            lblPendingCount.Text = "0"

        End Try

        Try

            Dim query As String =
            "SELECT " &
            "cr.RecordID, " &
            "COALESCE(s.StudentNo, u.StudentNo, '') AS StudentNo, " &
            "u.FullName AS StudentName, " &
            "r.RequirementName, " &
            "cr.SubmittedAt, " &
            "cr.Status " &
            "FROM ClearanceRecords cr " &
            "INNER JOIN ClearanceRequirements r " &
            "ON cr.RequirementID = r.RequirementID " &
            "INNER JOIN Users u " &
            "ON cr.StudentID = u.UserID " &
            "LEFT JOIN Students s " &
            "ON s.UserID = u.UserID " &
            "WHERE r.DepartmentID = @DeptID " &
            "AND (@TermID = 0 OR cr.TermID = @TermID) " &
            "AND cr.Status <> 'Not Applicable' " &
            "AND (" &
            "     cr.SubmittedAt IS NOT NULL " &
            "     OR cr.Status IN ('Under Review', 'Cleared', 'Rejected')" &
            ") " &
            "ORDER BY " &
            "COALESCE(cr.SubmittedAt, cr.CreatedAt) DESC;"

            allRequestsTable =
            db.ExecuteQuery(
                query,
                New Dictionary(Of String, Object) From {
                    {"@DeptID", deptID},
                    {"@TermID", activeTermID}
                }
            )

            ApplyFilters()

        Catch ex As Exception

            MessageBox.Show(
            "Failed to load requests: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    Private Sub ApplyFilters()
        If allRequestsTable Is Nothing Then Return

        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        Dim filteredRows = allRequestsTable.AsEnumerable()

        ' Status filter
        If Not currentFilterStatus.Equals("All", StringComparison.OrdinalIgnoreCase) Then
            filteredRows = filteredRows.Where(Function(r) r("Status").ToString().Equals(currentFilterStatus, StringComparison.OrdinalIgnoreCase))
        End If

        ' Search filter
        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            filteredRows = filteredRows.Where(Function(r) r("StudentName").ToString().ToLower().Contains(searchTerm) OrElse r("StudentNo").ToString().ToLower().Contains(searchTerm))
        End If

        dgvRequests.Rows.Clear()
        Dim num As Integer = 1
        For Each row In filteredRows
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

            ' Action button rules:
            ' Pending -> Review, Under Review -> Open, Cleared -> View, Rejected -> View
            Dim actionText As String = "Review"
            If status.Equals("Under Review", StringComparison.OrdinalIgnoreCase) Then
                actionText = "Open"
            ElseIf status.Equals("Cleared", StringComparison.OrdinalIgnoreCase) OrElse status.Equals("Rejected", StringComparison.OrdinalIgnoreCase) Then
                actionText = "View"
            End If

            Dim rowIndex As Integer = dgvRequests.Rows.Add(num, recordID, studentNo, studentName, requirement, submittedAtText, status, actionText)
            dgvRequests.Rows(rowIndex).Tag = recordID
            num += 1
        Next

        lblRecordCount.Text = "Showing " & dgvRequests.Rows.Count.ToString() & " requests"
    End Sub

    ' Search event
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    ' Filter buttons styling
    Private Sub UpdateFilterButtonsUI(activeBtn As Button)
        Dim buttons = {btnFilterAll, btnFilterPending, btnFilterReview, btnFilterCleared, btnFilterRejected}
        For Each btn In buttons
            If btn Is activeBtn Then
                btn.BackColor = Color.FromArgb(11, 99, 229)
                btn.ForeColor = Color.White
                btn.FlatAppearance.BorderSize = 0
                btn.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
            Else
                btn.BackColor = Color.White
                btn.ForeColor = Color.FromArgb(51, 65, 85)
                btn.FlatAppearance.BorderColor = Color.FromArgb(226, 232, 240)
                btn.FlatAppearance.BorderSize = 1
                btn.Font = New Font("Segoe UI Semibold", 8.5F, FontStyle.Regular)
            End If
        Next
    End Sub

    ' Filter click events
    Private Sub btnFilterAll_Click(sender As Object, e As EventArgs) Handles btnFilterAll.Click
        currentFilterStatus = "All"
        UpdateFilterButtonsUI(btnFilterAll)
        ApplyFilters()
    End Sub

    Private Sub btnFilterPending_Click(sender As Object, e As EventArgs) Handles btnFilterPending.Click
        currentFilterStatus = "Pending"
        UpdateFilterButtonsUI(btnFilterPending)
        ApplyFilters()
    End Sub

    Private Sub btnFilterReview_Click(sender As Object, e As EventArgs) Handles btnFilterReview.Click
        currentFilterStatus = "Under Review"
        UpdateFilterButtonsUI(btnFilterReview)
        ApplyFilters()
    End Sub

    Private Sub btnFilterCleared_Click(sender As Object, e As EventArgs) Handles btnFilterCleared.Click
        currentFilterStatus = "Cleared"
        UpdateFilterButtonsUI(btnFilterCleared)
        ApplyFilters()
    End Sub

    Private Sub btnFilterRejected_Click(sender As Object, e As EventArgs) Handles btnFilterRejected.Click
        currentFilterStatus = "Rejected"
        UpdateFilterButtonsUI(btnFilterRejected)
        ApplyFilters()
    End Sub

    Private Sub pnlSummaryTotal_Click(sender As Object, e As EventArgs) Handles pnlSummaryTotal.Click, lblTotalCount.Click, lblTotalTitle.Click, lblTotalSub.Click, lblTotalIcon.Click, lblTotalArrow.Click
        currentFilterStatus = "All"
        UpdateFilterButtonsUI(btnFilterAll)
        ApplyFilters()
    End Sub

    Private Sub pnlSummaryPending_Click(sender As Object, e As EventArgs) Handles pnlSummaryPending.Click, lblPendingCount.Click, lblPendingTitle.Click, lblPendingSub.Click, lblPendingIcon.Click, lblPendingArrow.Click
        currentFilterStatus = "Pending"
        UpdateFilterButtonsUI(btnFilterPending)
        ApplyFilters()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click, btnQuickRefresh.Click
        LoadRequestsData()
    End Sub

    ' Review Next Pending Action
    Private Sub btnQuickReviewNext_Click(sender As Object, e As EventArgs) Handles btnQuickReviewNext.Click
        ReviewNextPending()
    End Sub

    Private Sub ReviewNextPending()

        If Not AppSession.DepartmentID.HasValue Then
            Return
        End If

        Try

            Dim activeTermID As Integer = 0

            Dim dtTerm As DataTable =
            db.ExecuteQuery(
                "SELECT TermID " &
                "FROM AcademicTerms " &
                "WHERE IsActive = 1 " &
                "ORDER BY TermID DESC " &
                "LIMIT 1;"
            )

            If dtTerm.Rows.Count > 0 Then
                activeTermID =
                Convert.ToInt32(
                    dtTerm.Rows(0)("TermID")
                )
            End If


            Dim query As String =
            "SELECT cr.RecordID " &
            "FROM ClearanceRecords cr " &
            "INNER JOIN ClearanceRequirements r " &
            "ON cr.RequirementID = r.RequirementID " &
            "WHERE r.DepartmentID = @DeptID " &
            "AND (@TermID = 0 OR cr.TermID = @TermID) " &
            "AND cr.Status = 'Under Review' " &
            "AND cr.SubmittedAt IS NOT NULL " &
            "ORDER BY cr.SubmittedAt ASC " &
            "LIMIT 1;"

            Dim dt As DataTable =
            db.ExecuteQuery(
                query,
                New Dictionary(Of String, Object) From {
                    {
                        "@DeptID",
                        AppSession.DepartmentID.Value
                    },
                    {
                        "@TermID",
                        activeTermID
                    }
                }
            )


            If dt.Rows.Count > 0 Then

                Dim recordID As Integer =
                Convert.ToInt32(
                    dt.Rows(0)("RecordID")
                )

                ShowReviewView(recordID)

            Else

                MessageBox.Show(
                "No submitted requests are waiting for review.",
                "No Requests",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            End If

        Catch ex As Exception

            MessageBox.Show(
            "Unable to load the next review request: " &
            ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub

    ' Table row click
    Private Sub dgvRequests_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = colReqAction.Index Then
            Dim row = dgvRequests.Rows(e.RowIndex)
            Dim recordID As Integer = Convert.ToInt32(row.Cells(colReqRecordID.Index).Value)
            ShowReviewView(recordID)
        End If
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

            LoadRequestsData()
        Finally
            modalBackdrop.Dispose()
        End Try
    End Sub

    ' ============================================================
    ' CUSTOM CELL PAINTING: STATUS PILL & ACTION BUTTON
    ' ============================================================
    Private Sub dgvRequests_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvRequests.CellPainting
        If e.RowIndex < 0 Then Return

        ' 1. Status Column: Render rounded pill badge
        If e.ColumnIndex = colReqStatus.Index Then
            e.PaintBackground(e.CellBounds, True)

            Dim statusText As String = If(e.Value IsNot Nothing, e.Value.ToString().Trim(), "")
            If Not String.IsNullOrWhiteSpace(statusText) Then
                Dim pillBg As Color
                Dim pillFg As Color
                Dim displayBadgeText As String = statusText

                Select Case statusText.ToLowerInvariant()
                    Case "under review"
                        pillBg = Color.FromArgb(219, 234, 254)
                        pillFg = Color.FromArgb(37, 99, 235)
                        displayBadgeText = "Under Review"
                    Case "cleared"
                        pillBg = Color.FromArgb(220, 252, 231)
                        pillFg = Color.FromArgb(22, 163, 74)
                        displayBadgeText = "Approved"
                    Case "rejected"
                        pillBg = Color.FromArgb(254, 226, 226)
                        pillFg = Color.FromArgb(220, 38, 38)
                        displayBadgeText = "Rejected"
                    Case Else ' Pending
                        pillBg = Color.FromArgb(254, 243, 199)
                        pillFg = Color.FromArgb(217, 119, 6)
                        displayBadgeText = "Pending"
                End Select

                Using pillFont As New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
                    Dim textSize As Size = TextRenderer.MeasureText(e.Graphics, displayBadgeText, pillFont)
                    Dim pillWidth As Integer = Math.Max(textSize.Width + 18, 88)
                    If pillWidth > e.CellBounds.Width - 8 Then pillWidth = e.CellBounds.Width - 8
                    Dim pillHeight As Integer = 24
                    Dim pillX As Integer = e.CellBounds.X + (e.CellBounds.Width - pillWidth) \ 2
                    Dim pillY As Integer = e.CellBounds.Y + (e.CellBounds.Height - pillHeight) \ 2
                    Dim pillRect As New Rectangle(pillX, pillY, pillWidth, pillHeight)

                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                    Using path As GraphicsPath = CreatePillPath(pillRect)
                        Using brush As New SolidBrush(pillBg)
                            e.Graphics.FillPath(brush, path)
                        End Using
                    End Using

                    TextRenderer.DrawText(
                        e.Graphics,
                        displayBadgeText,
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

        ' 2. Action Column: Render rounded outline action button (Review / Open / View)
        If e.ColumnIndex = colReqAction.Index Then
            e.PaintBackground(e.CellBounds, True)

            Dim btnWidth As Integer = Math.Min(78, e.CellBounds.Width - 8)
            Dim btnHeight As Integer = 26
            Dim btnX As Integer = e.CellBounds.X + (e.CellBounds.Width - btnWidth) \ 2
            Dim btnY As Integer = e.CellBounds.Y + (e.CellBounds.Height - btnHeight) \ 2
            Dim btnRect As New Rectangle(btnX, btnY, btnWidth, btnHeight)

            Using btnFont As New Font("Segoe UI Semibold", 8.5F, FontStyle.Bold)
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
                Using path As GraphicsPath = CreatePillPath(btnRect)
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

    Private Function CreatePillPath(rect As Rectangle) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim radius As Integer = rect.Height \ 2
        Dim d As Integer = radius * 2

        path.AddArc(rect.X, rect.Y, d, d, 180, 90)
        path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90)
        path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90)
        path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub dgvRequests_CellMouseMove(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvRequests.CellMouseMove
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = colReqAction.Index Then
            dgvRequests.Cursor = Cursors.Hand
        Else
            dgvRequests.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub dgvRequests_MouseLeave(sender As Object, e As EventArgs) Handles dgvRequests.MouseLeave
        dgvRequests.Cursor = Cursors.Default
    End Sub

    ' Navigations
    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        Dim parentDashboard As StaffDashboardForm = TryCast(Me.FindForm(), StaffDashboardForm)
        If parentDashboard IsNot Nothing Then
            parentDashboard.ShowDashboardView()
        Else
            Dim dashForm As New StaffDashboardForm()
            dashForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNavHistory_Click(sender As Object, e As EventArgs) Handles btnNavHistory.Click, btnQuickHistory.Click
        Dim parentDashboard As StaffDashboardForm = TryCast(Me.FindForm(), StaffDashboardForm)
        If parentDashboard IsNot Nothing Then
            parentDashboard.ShowHistoryView()
        Else
            Dim histForm As New StaffHistoryForm()
            histForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNavLogout_Click(sender As Object, e As EventArgs) Handles btnNavLogout.Click
        Dim parentDashboard As StaffDashboardForm = TryCast(Me.FindForm(), StaffDashboardForm)
        Dim result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            AppSession.Clear()
            If parentDashboard IsNot Nothing Then
                parentDashboard.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub

    Private Sub dgvRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellContentClick

    End Sub
End Class
