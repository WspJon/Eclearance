Imports System.Data
Imports MySql.Data.MySqlClient

Public Class StaffHistoryForm

    Private ReadOnly db As New DatabaseHelper()
    Private _historyTable As DataTable

    Private Sub StaffHistoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySchoolLogo(picSchoolLogo)
        InitializeUserData()
        cmbDateFilter.SelectedIndex = 0
        cmbStatusFilter.SelectedIndex = 0
        LoadSummaryCounts()
        LoadHistoryData()
    End Sub

    Private Sub InitializeUserData()
        lblStaffName.Text = If(String.IsNullOrWhiteSpace(AppSession.FullName), "Staff Member", AppSession.FullName)
        lblDateTimeBadge.Text = "📅 " & DateTime.Now.ToString("dddd, MMM dd, yyyy")

        If AppSession.DepartmentID.HasValue Then
            Try
                Dim deptDt As DataTable = db.ExecuteQuery(
                    "SELECT DepartmentName FROM Departments WHERE DepartmentID = @DeptID LIMIT 1;",
                    New Dictionary(Of String, Object) From {{"@DeptID", AppSession.DepartmentID.Value}}
                )
                If deptDt.Rows.Count > 0 Then
                    lblOfficeName.Text = deptDt.Rows(0)("DepartmentName").ToString()
                Else
                    lblOfficeName.Text = "Department #" & AppSession.DepartmentID.Value.ToString()
                End If
            Catch ex As Exception
                lblOfficeName.Text = "Assigned Office"
            End Try
        Else
            lblOfficeName.Text = "Assigned Office"
        End If
    End Sub

    Public Sub LoadSummaryCounts()
        If Not AppSession.DepartmentID.HasValue Then Return

        Try
            Dim query As String = "SELECT " &
                "COUNT(h.HistoryID) AS TotalReviewed, " &
                "SUM(CASE WHEN h.NewStatus = 'Cleared' THEN 1 ELSE 0 END) AS ApprovedCount, " &
                "SUM(CASE WHEN h.NewStatus = 'Rejected' THEN 1 ELSE 0 END) AS RejectedCount " &
                "FROM ClearanceHistory h " &
                "INNER JOIN ClearanceRecords r ON h.RecordID = r.RecordID " &
                "INNER JOIN ClearanceRequirements req ON r.RequirementID = req.RequirementID " &
                "WHERE req.DepartmentID = @DeptID"

            Dim dt As DataTable = db.ExecuteQuery(
                query,
                New Dictionary(Of String, Object) From {{"@DeptID", AppSession.DepartmentID.Value}}
            )

            If dt.Rows.Count > 0 Then
                Dim row As DataRow = dt.Rows(0)
                lblReviewedCount.Text = Convert.ToInt32(If(DBNull.Value.Equals(row("TotalReviewed")), 0, row("TotalReviewed"))).ToString()
                lblApprovedCount.Text = Convert.ToInt32(If(DBNull.Value.Equals(row("ApprovedCount")), 0, row("ApprovedCount"))).ToString()
                lblRejectedCount.Text = Convert.ToInt32(If(DBNull.Value.Equals(row("RejectedCount")), 0, row("RejectedCount"))).ToString()
            End If
        Catch ex As Exception
            lblReviewedCount.Text = "0"
            lblApprovedCount.Text = "0"
            lblRejectedCount.Text = "0"
        End Try
    End Sub

    Public Sub LoadHistoryData()
        If Not AppSession.DepartmentID.HasValue Then Return

        Try
            Dim queryBuilder As New System.Text.StringBuilder()
            Dim params As New Dictionary(Of String, Object)

            queryBuilder.Append("SELECT ")
            queryBuilder.Append("h.HistoryID, ")
            queryBuilder.Append("h.RecordID, ")
            queryBuilder.Append("h.ActionAt, ")
            queryBuilder.Append("COALESCE(s.StudentNo, u.StudentNo, '') AS StudentNo, ")
            queryBuilder.Append("u.FullName AS StudentName, ")
            queryBuilder.Append("COALESCE(s.Course, u.Course, 'N/A') AS Course, ")
            queryBuilder.Append("COALESCE(s.YearLevel, u.YearLevel, 'N/A') AS YearLevel, ")
            queryBuilder.Append("req.RequirementName, ")
            queryBuilder.Append("h.ActionType, ")
            queryBuilder.Append("h.NewStatus, ")
            queryBuilder.Append("COALESCE(h.Remarks, '') AS Remarks ")
            queryBuilder.Append("FROM ClearanceHistory h ")
            queryBuilder.Append("INNER JOIN ClearanceRecords r ON h.RecordID = r.RecordID ")
            queryBuilder.Append("INNER JOIN ClearanceRequirements req ON r.RequirementID = req.RequirementID ")
            queryBuilder.Append("INNER JOIN Users u ON r.StudentID = u.UserID ")
            queryBuilder.Append("LEFT JOIN Students s ON s.UserID = u.UserID ")
            queryBuilder.Append("WHERE req.DepartmentID = @DeptID ")

            params.Add("@DeptID", AppSession.DepartmentID.Value)

            Dim searchText As String = txtSearch.Text.Trim()
            If Not String.IsNullOrEmpty(searchText) Then
                queryBuilder.Append("AND (u.FullName LIKE @Search OR COALESCE(s.StudentNo, u.StudentNo) LIKE @Search OR req.RequirementName LIKE @Search) ")
                params.Add("@Search", "%" & searchText & "%")
            End If

            If cmbStatusFilter.SelectedIndex = 1 Then
                queryBuilder.Append("AND h.NewStatus = 'Cleared' ")
            ElseIf cmbStatusFilter.SelectedIndex = 2 Then
                queryBuilder.Append("AND h.NewStatus = 'Rejected' ")
            ElseIf cmbStatusFilter.SelectedIndex = 3 Then
                queryBuilder.Append("AND h.NewStatus = 'Under Review' ")
            End If

            If cmbDateFilter.SelectedIndex = 1 Then
                queryBuilder.Append("AND DATE(h.ActionAt) = CURDATE() ")
            ElseIf cmbDateFilter.SelectedIndex = 2 Then
                queryBuilder.Append("AND h.ActionAt >= DATE_SUB(CURDATE(), INTERVAL 7 DAY) ")
            ElseIf cmbDateFilter.SelectedIndex = 3 Then
                queryBuilder.Append("AND h.ActionAt >= DATE_SUB(CURDATE(), INTERVAL 30 DAY) ")
            End If

            queryBuilder.Append("ORDER BY h.ActionAt DESC LIMIT 200")

            _historyTable = db.ExecuteQuery(queryBuilder.ToString(), params)
            PopulateHistoryGrid()

        Catch ex As Exception
            MessageBox.Show("Error loading history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateHistoryGrid()
        dgvHistory.Rows.Clear()

        If _historyTable Is Nothing OrElse _historyTable.Rows.Count = 0 Then
            lblRecordCount.Text = "Showing 0 of 0 records"
            ClearDetailCard()
            Return
        End If

        lblRecordCount.Text = $"Showing {_historyTable.Rows.Count} of {_historyTable.Rows.Count} records"

        Dim rowIndex As Integer = 1
        Dim lastRecordID As Integer = -1
        Dim lastActionType As String = ""
        Dim lastNewStatus As String = ""

        For Each row As DataRow In _historyTable.Rows
            Dim recID As Integer = Convert.ToInt32(row("RecordID"))
            Dim actType As String = row("ActionType").ToString()
            Dim st As String = row("NewStatus").ToString()

            ' Skip consecutive duplicates for the same record
            If recID = lastRecordID AndAlso actType.Equals(lastActionType, StringComparison.OrdinalIgnoreCase) AndAlso st.Equals(lastNewStatus, StringComparison.OrdinalIgnoreCase) Then
                Continue For
            End If

            lastRecordID = recID
            lastActionType = actType
            lastNewStatus = st

            Dim dtStr As String = ""
            If Not DBNull.Value.Equals(row("ActionAt")) Then
                dtStr = Convert.ToDateTime(row("ActionAt")).ToString("yyyy-MM-dd HH:mm")
            End If

            Dim newIndex As Integer = dgvHistory.Rows.Add(
                rowIndex.ToString(),
                row("HistoryID"),
                row("RecordID"),
                dtStr,
                row("StudentNo").ToString(),
                row("StudentName").ToString(),
                row("RequirementName").ToString(),
                row("ActionType").ToString(),
                row("NewStatus").ToString(),
                row("Remarks").ToString()
            )



            rowIndex += 1
        Next

        If dgvHistory.Rows.Count > 0 Then
            dgvHistory.Rows(0).Selected = True
            ShowDetailForSelectedRow()
        End If
    End Sub

    Private Sub dgvHistory_SelectionChanged(sender As Object, e As EventArgs) Handles dgvHistory.SelectionChanged
        ShowDetailForSelectedRow()
    End Sub

    Private Sub ShowDetailForSelectedRow()
        If dgvHistory.SelectedRows.Count = 0 Then
            ClearDetailCard()
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvHistory.SelectedRows(0)
        Dim selectedHistoryId As Object = selectedRow.Cells("colHistoryID").Value
        If selectedHistoryId Is Nothing Then
            ClearDetailCard()
            Return
        End If

        Dim matchRows() As DataRow = _historyTable.Select("HistoryID = " & selectedHistoryId.ToString())
        If matchRows.Length > 0 Then
            Dim r As DataRow = matchRows(0)
            lblDetailStudentNoVal.Text = r("StudentNo").ToString()
            lblDetailNameVal.Text = r("StudentName").ToString()
            lblDetailCourseVal.Text = r("Course").ToString()
            lblDetailYearVal.Text = r("YearLevel").ToString()
            lblDetailReqVal.Text = r("RequirementName").ToString()
            If Not DBNull.Value.Equals(r("ActionAt")) Then
                lblDetailDateVal.Text = Convert.ToDateTime(r("ActionAt")).ToString("yyyy-MM-dd HH:mm")
            Else
                lblDetailDateVal.Text = "-"
            End If
            lblDetailActionVal.Text = r("ActionType").ToString()

            Dim status As String = r("NewStatus").ToString()
            lblDetailStatusVal.Text = status

            Dim remarks As String = r("Remarks").ToString()
            lblDetailRemarksVal.Text = If(String.IsNullOrWhiteSpace(remarks), "No remarks provided.", remarks)
            btnReReview.Enabled = True
        Else
            ClearDetailCard()
        End If
    End Sub

    Private Sub ClearDetailCard()
        lblDetailStudentNoVal.Text = "-"
        lblDetailNameVal.Text = "-"
        lblDetailCourseVal.Text = "-"
        lblDetailYearVal.Text = "-"
        lblDetailReqVal.Text = "-"
        lblDetailDateVal.Text = "-"
        lblDetailActionVal.Text = "-"
        lblDetailStatusVal.Text = "-"
        lblDetailRemarksVal.Text = "Select a row from the history table to view details."
        btnReReview.Enabled = False
    End Sub

    Private Sub btnReReview_Click(sender As Object, e As EventArgs) Handles btnReReview.Click
        If dgvHistory.SelectedRows.Count = 0 Then Return
        Dim recordIdObj As Object = dgvHistory.SelectedRows(0).Cells("colRecordID").Value
        If recordIdObj IsNot Nothing AndAlso Not DBNull.Value.Equals(recordIdObj) Then
            Dim recId As Integer = Convert.ToInt32(recordIdObj)
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
                    reviewForm.TargetRecordID = recId
                    reviewForm.ShowDialog(modalBackdrop)
                End Using

                LoadSummaryCounts()
                LoadHistoryData()
            Finally
                modalBackdrop.Dispose()
            End Try
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadHistoryData()
    End Sub

    Private Sub cmbDateFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDateFilter.SelectedIndexChanged
        LoadHistoryData()
    End Sub

    Private Sub cmbStatusFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStatusFilter.SelectedIndexChanged
        LoadHistoryData()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSummaryCounts()
        LoadHistoryData()
    End Sub

    Private Sub pnlCardReviewed_Click(sender As Object, e As EventArgs) Handles pnlCardReviewed.Click, lblReviewedTitle.Click, lblReviewedCount.Click, lblReviewedIcon.Click
        cmbStatusFilter.SelectedIndex = 0
    End Sub

    Private Sub pnlCardApproved_Click(sender As Object, e As EventArgs) Handles pnlCardApproved.Click, lblApprovedTitle.Click, lblApprovedCount.Click, lblApprovedIcon.Click
        cmbStatusFilter.SelectedIndex = 1
    End Sub

    Private Sub pnlCardRejected_Click(sender As Object, e As EventArgs) Handles pnlCardRejected.Click, lblRejectedTitle.Click, lblRejectedCount.Click, lblRejectedIcon.Click
        cmbStatusFilter.SelectedIndex = 2
    End Sub

    Private Sub btnNavDashboard_Click(sender As Object, e As EventArgs) Handles btnNavDashboard.Click
        Dim parentDashboard As StaffDashboardForm = TryCast(Me.FindForm(), StaffDashboardForm)
        If parentDashboard IsNot Nothing Then
            parentDashboard.ShowDashboardView()
        Else
            Dim dashboard As New StaffDashboardForm()
            dashboard.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNavRequests_Click(sender As Object, e As EventArgs) Handles btnNavRequests.Click
        Dim parentDashboard As StaffDashboardForm = TryCast(Me.FindForm(), StaffDashboardForm)
        If parentDashboard IsNot Nothing Then
            parentDashboard.ShowRequestsView()
        Else
            Dim requestsForm As New StaffRequestsForm()
            requestsForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnNavLogout_Click(sender As Object, e As EventArgs) Handles btnNavLogout.Click
        Dim parentDashboard As StaffDashboardForm = TryCast(Me.FindForm(), StaffDashboardForm)
        Dim confirm = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            AppSession.Clear()
            If parentDashboard IsNot Nothing Then
                parentDashboard.Close()
            Else
                Me.Close()
            End If
        End If
    End Sub

End Class
