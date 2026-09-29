Public Class LoginForm

    Private ReadOnly db As New DatabaseHelper()


    ' ============================================================
    ' FORM LOAD
    ' ============================================================
    Private Sub LoginForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        txtPassword.UseSystemPasswordChar = True

        txtUsername.Focus()

    End Sub


    ' ============================================================
    ' SHOW / HIDE PASSWORD
    ' ============================================================
    Private Sub chkShowPassword_CheckedChanged(
        sender As Object,
        e As EventArgs
    ) Handles chkShowPassword.CheckedChanged

        txtPassword.UseSystemPasswordChar =
            Not chkShowPassword.Checked

    End Sub


    ' ============================================================
    ' SIGN IN BUTTON
    ' ============================================================
    Private Sub btnSignIn_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnSignIn.Click

        LoginUser()

    End Sub


    ' ============================================================
    ' LOGIN USER
    ' ============================================================
    Private Sub LoginUser()

        Dim username As String =
            txtUsername.Text.Trim()

        Dim password As String =
            txtPassword.Text


        ' --------------------------------------------------------
        ' VALIDATION
        ' --------------------------------------------------------
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

            ' ----------------------------------------------------
            ' IMPORTANT:
            ' USE Password COLUMN, NOT PasswordHash
            ' ----------------------------------------------------
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
                "AND Password = @Password " &
                "AND IsActive = 1 " &
                "LIMIT 1;"


            Dim parameters As New Dictionary(Of String, Object) From {
                {"@Username", username},
                {"@Password", password}
            }


            Dim dt As DataTable =
                db.ExecuteQuery(
                    query,
                    parameters
                )


            ' ----------------------------------------------------
            ' INVALID LOGIN
            ' ----------------------------------------------------
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


            ' ----------------------------------------------------
            ' GET USER
            ' ----------------------------------------------------
            Dim row As DataRow =
                dt.Rows(0)


            ' ----------------------------------------------------
            ' SAVE SESSION
            ' ----------------------------------------------------
            AppSession.UserID =
                Convert.ToInt32(
                    row("UserID")
                )


            AppSession.Username =
                row("Username").ToString()


            AppSession.FullName =
                row("FullName").ToString()


            AppSession.Role =
                row("Role").ToString()


            AppSession.StudentNo = ""

            AppSession.Course = ""

            AppSession.YearLevel = ""

            AppSession.DepartmentID = Nothing


            If Not IsDBNull(
                row("StudentNo")
            ) Then

                AppSession.StudentNo =
                    row("StudentNo").ToString()

            End If


            If Not IsDBNull(
                row("Course")
            ) Then

                AppSession.Course =
                    row("Course").ToString()

            End If


            If Not IsDBNull(
                row("YearLevel")
            ) Then

                AppSession.YearLevel =
                    row("YearLevel").ToString()

            End If


            If Not IsDBNull(
                row("DepartmentID")
            ) Then

                AppSession.DepartmentID =
                    Convert.ToInt32(
                        row("DepartmentID")
                    )

            End If


            ' ----------------------------------------------------
            ' OPEN CORRECT DASHBOARD
            ' ----------------------------------------------------
            OpenDashboard()


        Catch ex As Exception

            MessageBox.Show(
                "Database connection failed." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    ' ============================================================
    ' OPEN DASHBOARD BASED ON ROLE
    ' ============================================================
    Private Sub OpenDashboard()

        Select Case AppSession.Role.Trim().ToLower()

            ' ====================================================
            ' ADMIN
            ' ====================================================
            Case "admin"

                Me.Hide()

                Using frm As New AdminStudentsForm()

                    frm.ShowDialog()

                End Using

                LogoutUser()


            ' ====================================================
            ' STUDENT
            ' ====================================================
            Case "student"

                Me.Hide()

                Using frm As New StudentClearanceForm()

                    frm.ShowDialog()

                End Using

                LogoutUser()


            ' ====================================================
            ' STAFF
            ' ====================================================
            Case "staff"

                MessageBox.Show(
                    "Staff clearance portal will be added next.",
                    "Staff Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )


                ' ====================================================
                ' INVALID ROLE
                ' ====================================================
            Case Else

                MessageBox.Show(
                    "The account has an invalid user role: " &
                    AppSession.Role,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

        End Select

    End Sub


    ' ============================================================
    ' LOGOUT
    ' ============================================================
    Private Sub LogoutUser()

        AppSession.Clear()

        txtUsername.Clear()

        txtPassword.Clear()

        chkShowPassword.Checked =
            False

        Me.Show()

        txtUsername.Focus()

    End Sub


    ' ============================================================
    ' PRESS ENTER TO LOGIN
    ' ============================================================
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