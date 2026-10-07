Imports MySql.Data.MySqlClient

Public Class EditStaffForm

    Private ReadOnly db As New DatabaseHelper()
    Private ReadOnly _targetUserID As Integer
    Private ReadOnly officeDict As New Dictionary(Of String, Integer)()
    Private _currentDeptID As Integer = 0

    Public Sub New(targetUserID As Integer)
        InitializeComponent()
        _targetUserID = targetUserID
    End Sub

    Private Sub EditStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficeOptions()
        LoadStaffData()
    End Sub

    Private Sub LoadOfficeOptions()
        Try
            cmbAssignedOffice.Items.Clear()
            officeDict.Clear()

            Dim query As String = "SELECT DepartmentID, DepartmentName FROM Departments WHERE IsActive = 1 ORDER BY DepartmentName ASC;"
            Dim table As DataTable = db.ExecuteQuery(query)

            For Each row As DataRow In table.Rows
                Dim id As Integer = Convert.ToInt32(row("DepartmentID"))
                Dim name As String = row("DepartmentName").ToString()
                cmbAssignedOffice.Items.Add(name)
                officeDict(name) = id
            Next
        Catch ex As Exception
            MessageBox.Show("Unable to load offices." & Environment.NewLine & ex.Message, "Office Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LoadStaffData()
        Try
            Dim query As String =
                "SELECT u.UserID, u.FullName, u.Username, st.DepartmentID, IFNULL(d.DepartmentName, '') AS DepartmentName " &
                "FROM Users u " &
                "LEFT JOIN Staff st ON u.UserID = st.UserID " &
                "LEFT JOIN Departments d ON st.DepartmentID = d.DepartmentID " &
                "WHERE u.UserID = @UserID LIMIT 1;"

            Dim dt As DataTable = db.ExecuteQuery(query, New Dictionary(Of String, Object) From {{"@UserID", _targetUserID}})

            If dt.Rows.Count = 0 Then
                MessageBox.Show("Selected staff account was not found.", "Staff Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.DialogResult = DialogResult.Cancel
                Me.Close()
                Return
            End If

            Dim row As DataRow = dt.Rows(0)
            txtFullName.Text = row("FullName").ToString()
            txtUsername.Text = row("Username").ToString()

            If Not IsDBNull(row("DepartmentID")) Then
                _currentDeptID = Convert.ToInt32(row("DepartmentID"))
                Dim deptName As String = row("DepartmentName").ToString()
                If Not String.IsNullOrWhiteSpace(deptName) AndAlso cmbAssignedOffice.Items.Contains(deptName) Then
                    cmbAssignedOffice.SelectedItem = deptName
                End If
            End If

            If cmbAssignedOffice.SelectedIndex = -1 AndAlso cmbAssignedOffice.Items.Count > 0 Then
                cmbAssignedOffice.SelectedIndex = 0
            End If

            txtFullName.Focus()

        Catch ex As Exception
            MessageBox.Show("Unable to load staff information." & Environment.NewLine & ex.Message, "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel
            Me.Close()
        End Try
    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim officeName As String = If(cmbAssignedOffice.SelectedItem IsNot Nothing, cmbAssignedOffice.SelectedItem.ToString(), "")

        If String.IsNullOrWhiteSpace(fullName) Then
            ShowWarning("Please enter staff full name.")
            txtFullName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(officeName) OrElse Not officeDict.ContainsKey(officeName) Then
            ShowWarning("Please select an assigned office.")
            cmbAssignedOffice.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(username) Then
            ShowWarning("Please enter a username.")
            txtUsername.Focus()
            Return
        End If

        If username.Length < 3 Then
            ShowWarning("Username must contain at least 3 characters.")
            txtUsername.Focus()
            Return
        End If

        Try
            ' Validate username uniqueness against OTHER users
            Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND UserID <> @UserID;"
            Dim checkParams As New Dictionary(Of String, Object) From {
                {"@Username", username},
                {"@UserID", _targetUserID}
            }
            Dim count As Integer = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams))

            If count > 0 Then
                ShowWarning("The username '" & username & "' is already taken by another account. Please choose another.")
                txtUsername.Focus()
                Return
            End If

            Dim newDeptID As Integer = officeDict(officeName)

            Using conn As MySqlConnection = db.GetConnection()
                conn.Open()
                Using transaction As MySqlTransaction = conn.BeginTransaction()
                    Try
                        ' Update Users table
                        Dim updateUserSql As String =
                            "UPDATE Users " &
                            "SET FullName = @FullName, Username = @Username " &
                            "WHERE UserID = @UserID;"

                        Using cmdUser As New MySqlCommand(updateUserSql, conn, transaction)
                            cmdUser.Parameters.AddWithValue("@FullName", fullName)
                            cmdUser.Parameters.AddWithValue("@Username", username)
                            cmdUser.Parameters.AddWithValue("@UserID", _targetUserID)
                            cmdUser.ExecuteNonQuery()
                        End Using

                        ' Update or insert in Staff table
                        Dim checkStaffSql As String = "SELECT COUNT(*) FROM Staff WHERE UserID = @UserID;"
                        Dim staffCount As Integer = 0
                        Using cmdCheck As New MySqlCommand(checkStaffSql, conn, transaction)
                            cmdCheck.Parameters.AddWithValue("@UserID", _targetUserID)
                            staffCount = Convert.ToInt32(cmdCheck.ExecuteScalar())
                        End Using

                        If staffCount > 0 Then
                            Dim updateStaffSql As String = "UPDATE Staff SET DepartmentID = @DeptID WHERE UserID = @UserID;"
                            Using cmdStaff As New MySqlCommand(updateStaffSql, conn, transaction)
                                cmdStaff.Parameters.AddWithValue("@DeptID", newDeptID)
                                cmdStaff.Parameters.AddWithValue("@UserID", _targetUserID)
                                cmdStaff.ExecuteNonQuery()
                            End Using
                        Else
                            Dim insertStaffSql As String = "INSERT INTO Staff (UserID, DepartmentID, IsActive) VALUES (@UserID, @DeptID, 1);"
                            Using cmdStaff As New MySqlCommand(insertStaffSql, conn, transaction)
                                cmdStaff.Parameters.AddWithValue("@UserID", _targetUserID)
                                cmdStaff.Parameters.AddWithValue("@DeptID", newDeptID)
                                cmdStaff.ExecuteNonQuery()
                            End Using
                        End If

                        transaction.Commit()
                    Catch
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using

            MessageBox.Show(
                "Staff account updated successfully.",
                "Staff Updated",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As MySqlException
            MessageBox.Show(
                "A database error occurred while updating the staff account." & Environment.NewLine & Environment.NewLine & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        Catch ex As Exception
            MessageBox.Show(
                "Unable to update staff account." & Environment.NewLine & Environment.NewLine & ex.Message,
                "Update Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click, btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowWarning(message As String)
        MessageBox.Show(message, "Validation Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

End Class
