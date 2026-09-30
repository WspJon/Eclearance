Imports System.Data
Imports MySql.Data.MySqlClient

Public Class StaffRequestsForm

    Private ReadOnly db As New DatabaseHelper()
    Private currentDepartmentName As String = "Assigned Office"
    Private currentFilterStatus As String = "Active"
    Private allRequestsTable As DataTable = Nothing

    Private Sub StaffRequestsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeStaffInfo()
        LoadRequestsData()
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
    End Sub

    Public Sub LoadRequestsData()
        If Not AppSession.DepartmentID.HasValue Then
            Return
        End If

        Dim deptID As Integer = AppSession.DepartmentID.Value

        ' 1. Load Count Cards
        Try
            Dim countQuery As String =
                "SELECT " &
                "  COUNT(*) AS TotalCount, " &
                "  SUM(CASE WHEN cr.Status IN ('Pending', 'Under Review') THEN 1 ELSE 0 END) AS PendingReviewCount " &
                "FROM ClearanceRecords cr " &
                "INNER JOIN ClearanceRequirements r ON cr.RequirementID = r.RequirementID " &
                "WHERE r.DepartmentID = @DeptID;"

            Dim dtCounts As DataTable = db.ExecuteQuery(countQuery, New Dictionary(Of String, Object) From {{"@DeptID", deptID}})
            If dtCounts.Rows.Count > 0 Then
                Dim row = dtCounts.Rows(0)
                lblTotalCount.Text = If(IsDBNull(row("TotalCount")), "0", row("TotalCount").ToString())
                lblPendingCount.Text = If(IsDBNull(row("PendingReviewCount")), "0", row("PendingReviewCount").ToString())
            End If
        Catch ex As Exception
            lblTotalCount.Text = "0"
            lblPendingCount.Text = "0"
        End Try

        ' 2. Load Table
        Try
            Dim query As String =
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
                "ORDER BY COALESCE(cr.SubmittedAt, cr.CreatedAt) DESC;"

            allRequestsTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {{"@DeptID", deptID}})
            ApplyFilters()
        Catch ex As Exception
            MessageBox.Show("Failed to load requests: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ApplyFilters()
        If allRequestsTable Is Nothing Then Return

        Dim searchTerm As String = txtSearch.Text.Trim().ToLower()
        Dim filteredRows = allRequestsTable.AsEnumerable()

        ' Status filter
        If currentFilterStatus.Equals("Active", StringComparison.OrdinalIgnoreCase) Then
            filteredRows = filteredRows.Where(Function(r) r("Status").ToString().Equals("Pending", StringComparison.OrdinalIgnoreCase) OrElse r("Status").ToString().Equals("Under Review", StringComparison.OrdinalIgnoreCase))
        ElseIf Not currentFilterStatus.Equals("All", StringComparison.OrdinalIgnoreCase) Then
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

        lblRecordCount.Text = "Showing " & dgvRequests.Rows.Count.ToString() & " of " & allRequestsTable.Rows.Count.ToString() & " records" & If(currentFilterStatus.Equals("Active", StringComparison.OrdinalIgnoreCase), " (Active: Pending & Under Review)", "")
    End Sub

    ' Search and filter events
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplyFilters()
    End Sub

    Private Sub btnFilterAll_Click(sender As Object, e As EventArgs) Handles btnFilterAll.Click
        If currentFilterStatus.Equals("All", StringComparison.OrdinalIgnoreCase) Then
            currentFilterStatus = "Active"
        Else
            currentFilterStatus = "All"
        End If
        ApplyFilters()
    End Sub

    Private Sub btnFilterPending_Click(sender As Object, e As EventArgs) Handles btnFilterPending.Click
        currentFilterStatus = "Pending"
        ApplyFilters()
    End Sub

    Private Sub btnFilterReview_Click(sender As Object, e As EventArgs) Handles btnFilterReview.Click
        currentFilterStatus = "Under Review"
        ApplyFilters()
    End Sub

    Private Sub btnFilterCleared_Click(sender As Object, e As EventArgs) Handles btnFilterCleared.Click
        currentFilterStatus = "Cleared"
        ApplyFilters()
    End Sub

    Private Sub btnFilterRejected_Click(sender As Object, e As EventArgs) Handles btnFilterRejected.Click
        currentFilterStatus = "Rejected"
        ApplyFilters()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRequestsData()
    End Sub

    ' Table action button click
    Private Sub dgvRequests_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequests.CellContentClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = colReqAction.Index Then
            Dim row = dgvRequests.Rows(e.RowIndex)
            Dim recordID As Integer = Convert.ToInt32(row.Cells(colReqRecordID.Index).Value)

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
        End If
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

    Private Sub btnNavHistory_Click(sender As Object, e As EventArgs) Handles btnNavHistory.Click
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

End Class
