Imports MySql.Data.MySqlClient

Public Class ChangePasswordModalForm

    Private ReadOnly db As New DatabaseHelper()

    Private Sub ChangePasswordModalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCurrentPassword.Focus()
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        Dim hideText As Boolean = Not chkShowPassword.Checked
        txtCurrentPassword.UseSystemPasswordChar = hideText
        txtNewPassword.UseSystemPasswordChar = hideText
        txtConfirmPassword.UseSystemPasswordChar = hideText
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim currentPwd As String = txtCurrentPassword.Text
        Dim newPwd As String = txtNewPassword.Text
        Dim confirmPwd As String = txtConfirmPassword.Text

        If String.IsNullOrWhiteSpace(currentPwd) Then
            MessageBox.Show("Please enter your current password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCurrentPassword.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(newPwd) Then
            MessageBox.Show("Please enter your new password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPassword.Focus()
            Return
        End If

        If newPwd.Length < 6 Then
            MessageBox.Show("New password must be at least 6 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNewPassword.Focus()
            Return
        End If

        If newPwd <> confirmPwd Then
            MessageBox.Show("New password and confirmation do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtConfirmPassword.Focus()
            Return
        End If

        Try
            ' Verify current password against database
            Dim checkQuery As String = "SELECT Password FROM Users WHERE UserID = @UserID LIMIT 1;"
            Dim dt As DataTable = db.ExecuteQuery(checkQuery, New Dictionary(Of String, Object) From {{"@UserID", AppSession.UserID}})

            If dt.Rows.Count = 0 Then
                MessageBox.Show("User account not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim dbPwd As String = dt.Rows(0)("Password").ToString()
            If dbPwd <> currentPwd Then
                MessageBox.Show("The current password you entered is incorrect.", "Incorrect Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtCurrentPassword.SelectAll()
                txtCurrentPassword.Focus()
                Return
            End If

            If currentPwd = newPwd Then
                MessageBox.Show("New password cannot be the same as your current password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNewPassword.Focus()
                Return
            End If

            ' Update password in database
            Dim updateQuery As String = "UPDATE Users SET Password = @NewPassword WHERE UserID = @UserID;"
            db.ExecuteNonQuery(updateQuery, New Dictionary(Of String, Object) From {
                {"@NewPassword", newPwd},
                {"@UserID", AppSession.UserID}
            })

            MessageBox.Show("Your password has been changed successfully.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error updating password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
