Imports MySql.Data.MySqlClient

Public Class StaffOfficesForm

    Private ReadOnly db As New DatabaseHelper()

    Private Sub StaffOfficesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaff()
    End Sub

    Public Sub LoadStaff(Optional search As String = "")
        Try
            dgvStaff.Rows.Clear()
            ClearSelectionDetails()

            Dim query As String =
                "SELECT u.UserID, u.FullName, IFNULL(d.DepartmentName, 'No Office Assigned') AS AssignedOffice, " &
                "u.Username, u.Role, " &
                "CASE WHEN u.IsActive = 1 THEN 'Active' ELSE 'Inactive' END AS StatusText " &
                "FROM Users u " &
                "LEFT JOIN Departments d ON u.DepartmentID = d.DepartmentID " &
                "WHERE u.Role IN ('Staff', 'Admin', 'Administrator') "

            Dim parameters As New Dictionary(Of String, Object)()

            If Not String.IsNullOrWhiteSpace(search) Then
                query &= "AND (u.FullName LIKE @Search OR u.Username LIKE @Search OR d.DepartmentName LIKE @Search) "
                parameters.Add("@Search", "%" & search.Trim() & "%")
            End If

            query &= "ORDER BY u.FullName ASC;"

            Dim table As DataTable = db.ExecuteQuery(query, parameters)

            For Each row As DataRow In table.Rows
                Dim rowIndex As Integer = dgvStaff.Rows.Add(
                    row("FullName").ToString(),
                    row("AssignedOffice").ToString(),
                    row("Username").ToString(),
                    row("Role").ToString(),
                    row("StatusText").ToString()
                )
                dgvStaff.Rows(rowIndex).Tag = Convert.ToInt32(row("UserID"))
            Next

            If dgvStaff.Rows.Count > 0 Then
                dgvStaff.ClearSelection()
                dgvStaff.Rows(0).Selected = True
                UpdateSelectedDetails()
            End If

        Catch ex As Exception
            MessageBox.Show(
                "Unable to load staff members." & Environment.NewLine & Environment.NewLine & ex.Message,
                "Staff Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub ClearSelectionDetails()
        lblSelectedStaffVal.Text = "--"
        lblSelectedUsernameVal.Text = "--"
        lblSelectedOfficeVal.Text = "--"
    End Sub

    Private Sub UpdateSelectedDetails()
        If dgvStaff.SelectedRows.Count = 0 Then
            ClearSelectionDetails()
            Return
        End If

        Dim row As DataGridViewRow = dgvStaff.SelectedRows(0)
        lblSelectedStaffVal.Text = If(row.Cells(colStaffName.Index).Value IsNot Nothing, row.Cells(colStaffName.Index).Value.ToString(), "--")
        lblSelectedOfficeVal.Text = If(row.Cells(colAssignedOffice.Index).Value IsNot Nothing, row.Cells(colAssignedOffice.Index).Value.ToString(), "--")
        lblSelectedUsernameVal.Text = If(row.Cells(colUsername.Index).Value IsNot Nothing, row.Cells(colUsername.Index).Value.ToString(), "--")
    End Sub

    Private Sub dgvStaff_SelectionChanged(sender As Object, e As EventArgs) Handles dgvStaff.SelectionChanged
        UpdateSelectedDetails()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        LoadStaff(txtSearch.Text.Trim())
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        txtSearch.Clear()
        LoadStaff()
    End Sub

    Private Sub btnAddStaff_Click(sender As Object, e As EventArgs) Handles btnAddStaff.Click
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

            Using frm As New CreateStaffForm()
                If frm.ShowDialog(modalBackdrop) = DialogResult.OK Then
                    LoadStaff()
                End If
            End Using
        Finally
            modalBackdrop.Dispose()
        End Try
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If dgvStaff.SelectedRows.Count = 0 OrElse dgvStaff.SelectedRows(0).Tag Is Nothing Then
            MessageBox.Show("Please select a staff member first.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim staffID As Integer = Convert.ToInt32(dgvStaff.SelectedRows(0).Tag)
        Dim staffName As String = dgvStaff.SelectedRows(0).Cells(colStaffName.Index).Value.ToString()

        Dim answer As DialogResult = MessageBox.Show(
            "Are you sure you want to reset the password for " & staffName & " to default (password123)?",
            "Reset Staff Password",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If answer <> DialogResult.Yes Then Return

        Try
            Dim query As String = "UPDATE Users SET Password = 'password123' WHERE UserID = @UserID;"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@UserID", staffID}
            }
            db.ExecuteNonQuery(query, parameters)

            MessageBox.Show(
                "Password for " & staffName & " has been reset to: password123",
                "Password Reset",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
        Catch ex As Exception
            MessageBox.Show(
                "Unable to reset password." & Environment.NewLine & Environment.NewLine & ex.Message,
                "Reset Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnEditStaff_Click(sender As Object, e As EventArgs) Handles btnEditStaff.Click
        If dgvStaff.SelectedRows.Count = 0 OrElse dgvStaff.SelectedRows(0).Tag Is Nothing Then
            MessageBox.Show("Please select a staff member first.", "Edit Staff", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim staffID As Integer = Convert.ToInt32(dgvStaff.SelectedRows(0).Tag)
        Dim staffName As String = dgvStaff.SelectedRows(0).Cells(colStaffName.Index).Value.ToString()
        Dim currentStatus As String = dgvStaff.SelectedRows(0).Cells(colStatus.Index).Value.ToString()
        Dim newStatus As Integer = If(currentStatus.Equals("Active", StringComparison.OrdinalIgnoreCase), 0, 1)
        Dim newStatusText As String = If(newStatus = 1, "Active", "Inactive")

        Dim answer As DialogResult = MessageBox.Show(
            "Change status of " & staffName & " to " & newStatusText & "?",
            "Toggle Staff Status",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If answer <> DialogResult.Yes Then Return

        Try
            Dim query As String = "UPDATE Users SET IsActive = @Status WHERE UserID = @UserID;"
            Dim parameters As New Dictionary(Of String, Object) From {
                {"@Status", newStatus},
                {"@UserID", staffID}
            }
            db.ExecuteNonQuery(query, parameters)

            MessageBox.Show(staffName & " status is now " & newStatusText & ".", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadStaff(txtSearch.Text.Trim())
        Catch ex As Exception
            MessageBox.Show("Unable to update staff status." & Environment.NewLine & ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
