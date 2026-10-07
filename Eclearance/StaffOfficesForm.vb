Imports MySql.Data.MySqlClient

Public Class StaffOfficesForm

    Private ReadOnly db As New DatabaseHelper()

    Private Sub StaffOfficesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySchoolLogo(picSchoolLogo)
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
                "LEFT JOIN Staff st ON u.UserID = st.UserID " &
                "LEFT JOIN Departments d ON st.DepartmentID = d.DepartmentID " &
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
        btnRemoveStaff.Text = "Deactivate Staff"
        btnRemoveStaff.BackColor = Color.FromArgb(220, 38, 38)
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

        Dim statusText As String = If(row.Cells(colStatus.Index).Value IsNot Nothing, row.Cells(colStatus.Index).Value.ToString(), "Active")
        If statusText.Equals("Inactive", StringComparison.OrdinalIgnoreCase) Then
            btnRemoveStaff.Text = "Reactivate Staff"
            btnRemoveStaff.BackColor = Color.FromArgb(16, 185, 129)
        Else
            btnRemoveStaff.Text = "Deactivate Staff"
            btnRemoveStaff.BackColor = Color.FromArgb(220, 38, 38)
        End If
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

            Using frm As New EditStaffForm(staffID)
                If frm.ShowDialog(modalBackdrop) = DialogResult.OK Then
                    LoadStaff(txtSearch.Text.Trim())
                End If
            End Using
        Finally
            modalBackdrop.Dispose()
        End Try
    End Sub

    Private Sub btnRemoveStaff_Click(sender As Object, e As EventArgs) Handles btnRemoveStaff.Click
        If dgvStaff.SelectedRows.Count = 0 OrElse dgvStaff.SelectedRows(0).Tag Is Nothing Then
            MessageBox.Show("Please select a staff member first.", "Staff Action", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim row As DataGridViewRow = dgvStaff.SelectedRows(0)
        Dim staffID As Integer = Convert.ToInt32(row.Tag)
        Dim staffName As String = If(row.Cells(colStaffName.Index).Value IsNot Nothing, row.Cells(colStaffName.Index).Value.ToString(), "")
        Dim role As String = If(row.Cells(colRole.Index).Value IsNot Nothing, row.Cells(colRole.Index).Value.ToString(), "")
        Dim currentStatus As String = If(row.Cells(colStatus.Index).Value IsNot Nothing, row.Cells(colStatus.Index).Value.ToString(), "")
        Dim isInactive As Boolean = currentStatus.Equals("Inactive", StringComparison.OrdinalIgnoreCase)

        ' Safeguard: Do NOT allow deactivating Administrator accounts
        If (role.Equals("Admin", StringComparison.OrdinalIgnoreCase) OrElse role.Equals("Administrator", StringComparison.OrdinalIgnoreCase)) AndAlso Not isInactive Then
            MessageBox.Show(
                "Administrator accounts cannot be deactivated from this screen.",
                "Action Not Allowed",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        If isInactive Then
            ' Reactivate account
            Dim confirmMsg As String =
                "Reactivate " & staffName & "?" & Environment.NewLine & Environment.NewLine &
                "This will restore access and allow the staff member to log in."

            Dim answer As DialogResult = MessageBox.Show(
                confirmMsg,
                "Confirm Reactivate Staff",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If answer <> DialogResult.Yes Then Return

            Try
                Using conn As MySqlConnection = db.GetConnection()
                    conn.Open()
                    Using transaction As MySqlTransaction = conn.BeginTransaction()
                        Try
                            Dim userSql As String = "UPDATE Users SET IsActive = 1 WHERE UserID = @UserID;"
                            Using cmdUser As New MySqlCommand(userSql, conn, transaction)
                                cmdUser.Parameters.AddWithValue("@UserID", staffID)
                                cmdUser.ExecuteNonQuery()
                            End Using

                            Dim staffSql As String = "UPDATE Staff SET IsActive = 1 WHERE UserID = @UserID;"
                            Using cmdStaff As New MySqlCommand(staffSql, conn, transaction)
                                cmdStaff.Parameters.AddWithValue("@UserID", staffID)
                                cmdStaff.ExecuteNonQuery()
                            End Using

                            transaction.Commit()
                        Catch
                            transaction.Rollback()
                            Throw
                        End Try
                    End Using
                End Using

                MessageBox.Show(
                    staffName & " has been successfully reactivated.",
                    "Staff Reactivated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                LoadStaff(txtSearch.Text.Trim())

            Catch ex As Exception
                MessageBox.Show(
                    "Unable to reactivate staff member." & Environment.NewLine & Environment.NewLine & ex.Message,
                    "Reactivate Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End Try

        Else
            ' Deactivate account
            Dim confirmMsg As String =
                "Deactivate " & staffName & "?" & Environment.NewLine & Environment.NewLine &
                "This will disable the account and prevent login." & Environment.NewLine &
                "Previous clearance actions and history will be preserved."

            Dim answer As DialogResult = MessageBox.Show(
                confirmMsg,
                "Confirm Deactivate Staff",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            )

            If answer <> DialogResult.Yes Then Return

            Try
                Using conn As MySqlConnection = db.GetConnection()
                    conn.Open()
                    Using transaction As MySqlTransaction = conn.BeginTransaction()
                        Try
                            Dim userSql As String = "UPDATE Users SET IsActive = 0 WHERE UserID = @UserID;"
                            Using cmdUser As New MySqlCommand(userSql, conn, transaction)
                                cmdUser.Parameters.AddWithValue("@UserID", staffID)
                                cmdUser.ExecuteNonQuery()
                            End Using

                            Dim staffSql As String = "UPDATE Staff SET IsActive = 0 WHERE UserID = @UserID;"
                            Using cmdStaff As New MySqlCommand(staffSql, conn, transaction)
                                cmdStaff.Parameters.AddWithValue("@UserID", staffID)
                                cmdStaff.ExecuteNonQuery()
                            End Using

                            transaction.Commit()
                        Catch
                            transaction.Rollback()
                            Throw
                        End Try
                    End Using
                End Using

                MessageBox.Show(
                    staffName & " has been successfully deactivated.",
                    "Staff Deactivated",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                LoadStaff(txtSearch.Text.Trim())

            Catch ex As Exception
                MessageBox.Show(
                    "Unable to deactivate staff member." & Environment.NewLine & Environment.NewLine & ex.Message,
                    "Deactivate Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )
            End Try

        End If
    End Sub

End Class
