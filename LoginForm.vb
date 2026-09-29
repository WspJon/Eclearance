Public Class LoginForm

    Private ReadOnly db As New DatabaseHelper()


    Private Sub LoginForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True

    End Sub


    Private Sub chkShowPassword_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar =
            Not chkShowPassword.Checked

    End Sub


    Private Sub btnSignIn_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSignIn.Click

        LoginUser()

    End Sub


    Private Sub LoginUser()

        Dim username As String =
            txtUsername.Text.Trim()

        Dim password As String =
            txtPassword.Text


        ' ================================
        ' VALIDATION
        ' ================================

        If String.IsNullOrWhiteSpace(username) Then

            MessageBox.Show(
                "Please enter your username.",
                "Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtUsername.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(password) Then

            MessageBox.Show(
                "Please enter your password.",
                "Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtPassword.Focus()
            Return

        End If


        Try

            Dim query As String =
                "SELECT " &
                "UserID, " &
                "Username, " &
                "FullName, " &
                "Role, " &
                "StudentNo, " &
                "Course, " &
                "YearLevel, " &
                "DepartmentID " &
                "FROM Users " &
                "WHERE Username = @Username " &
                "AND PasswordHash = SHA2(@Password, 256) " &
                "AND IsActive = 1 " &
                "LIMIT 1;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@Username", username},
                {"@Password", password}
            }


            Dim dt As DataTable =
                db.ExecuteQuery(query, parameters)


            If dt.Rows.Count = 0 Then

                MessageBox.Show(
                    "Invalid username or password.",
                    "Login Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

                txtPassword.Clear()
                txtPassword.Focus()

                Return

            End If


            Dim row As DataRow = dt.Rows(0)


            ' ================================
            ' SAVE LOGIN SESSION
            ' ================================

            AppSession.UserID =
                Convert.ToInt32(row("UserID"))

            AppSession.Username =
                row("Username").ToString()

            AppSession.FullName =
                row("FullName").ToString()

            AppSession.Role =
                row("Role").ToString()


            If Not IsDBNull(row("StudentNo")) Then
                AppSession.StudentNo =
                    row("StudentNo").ToString()
            End If


            If Not IsDBNull(row("Course")) Then
                AppSession.Course =
                    row("Course").ToString()
            End If


            If Not IsDBNull(row("YearLevel")) Then
                AppSession.YearLevel =
                    row("YearLevel").ToString()
            End If


            If Not IsDBNull(row("DepartmentID")) Then

                AppSession.DepartmentID =
                    Convert.ToInt32(
                        row("DepartmentID")
                    )

            End If


            ' ================================
            ' OPEN CORRECT FORM
            ' ================================

            OpenDashboard()


        Catch ex As Exception

            MessageBox.Show(
                "Unable to connect to the database." &
                Environment.NewLine &
                Environment.NewLine &
                "Please make sure MySQL is running.",
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub OpenDashboard()

        Select Case AppSession.Role.ToLower()

            Case "admin"

                Me.Hide()

                Using frm As New AdminStudentsForm()
                    frm.ShowDialog()
                End Using

                LogoutUser()


            Case "student"

                Me.Hide()

                Using frm As New StudentClearanceForm()
                    frm.ShowDialog()
                End Using

                LogoutUser()


            Case "staff"

                ' Wala pa tayong Staff Dashboard
                ' sa updated forms ninyo.

                MessageBox.Show(
                    "Staff portal will be added next.",
                    "Staff Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


            Case Else

                MessageBox.Show(
                    "Invalid user role.",
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

        End Select

    End Sub


    Private Sub LogoutUser()

        AppSession.Clear()

        txtUsername.Clear()
        txtPassword.Clear()

        Me.Show()

        txtUsername.Focus()

    End Sub


    Private Sub txtPassword_KeyDown(
        sender As Object,
        e As KeyEventArgs
    ) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            LoginUser()

        End If

    End Sub

End Class
