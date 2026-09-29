Imports MySql.Data.MySqlClient

Public Class CreateStudentForm

    Private ReadOnly db As New DatabaseHelper()


    Private Sub CreateStudentForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadCourseOptions()
        LoadYearLevelOptions()

        txtPassword.UseSystemPasswordChar = True

    End Sub

    Private Sub LoadCourseOptions()

        cmbCourse.Items.Clear()

        cmbCourse.Items.Add("BSIT")
        cmbCourse.Items.Add("BSBA")
        cmbCourse.Items.Add("BSA")
        cmbCourse.Items.Add("BSTM")
        cmbCourse.Items.Add("BSCpE")
        cmbCourse.Items.Add("BSHM")
        cmbCourse.Items.Add("CTHM")

        cmbCourse.SelectedIndex = -1

    End Sub


    Private Sub LoadYearLevelOptions()

        cmbYearLevel.Items.Clear()

        cmbYearLevel.Items.Add("1st Year")
        cmbYearLevel.Items.Add("2nd Year")
        cmbYearLevel.Items.Add("3rd Year")
        cmbYearLevel.Items.Add("4th Year")

        cmbYearLevel.SelectedIndex = -1

    End Sub


    Private Sub btnCreateAccount_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnCreateAccount.Click

        CreateStudent()

    End Sub

    Private Sub CreateStudent()

        Dim studentNo As String =
            txtStudentNo.Text.Trim()

        Dim firstName As String =
            txtFirstName.Text.Trim()

        Dim lastName As String =
            txtLastName.Text.Trim()

        Dim username As String =
            txtUsername.Text.Trim()

        Dim password As String =
            txtPassword.Text

        Dim course As String = ""

        Dim yearLevel As String = ""


        If cmbCourse.SelectedItem IsNot Nothing Then
            course = cmbCourse.SelectedItem.ToString()
        End If


        If cmbYearLevel.SelectedItem IsNot Nothing Then
            yearLevel = cmbYearLevel.SelectedItem.ToString()
        End If


        If String.IsNullOrWhiteSpace(studentNo) Then

            ShowWarning(
                "Please enter the student number."
            )

            txtStudentNo.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(firstName) Then

            ShowWarning(
                "Please enter the student's first name."
            )

            txtFirstName.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(lastName) Then

            ShowWarning(
                "Please enter the student's last name."
            )

            txtLastName.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(course) Then

            ShowWarning(
                "Please select a course."
            )

            cmbCourse.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(yearLevel) Then

            ShowWarning(
                "Please select a year level."
            )

            cmbYearLevel.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(username) Then

            ShowWarning(
                "Please enter a username."
            )

            txtUsername.Focus()
            Return

        End If


        If username.Length < 4 Then

            ShowWarning(
                "Username must contain at least 4 characters."
            )

            txtUsername.Focus()
            Return

        End If


        If String.IsNullOrWhiteSpace(password) Then

            ShowWarning(
                "Please enter a password."
            )

            txtPassword.Focus()
            Return

        End If


        If password.Length < 6 Then

            ShowWarning(
                "Password must contain at least 6 characters."
            )

            txtPassword.Focus()
            Return

        End If


        Try


            If StudentNumberExists(studentNo) Then

                MessageBox.Show(
                    "The student number '" &
                    studentNo &
                    "' is already registered.",
                    "Duplicate Student Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtStudentNo.Focus()
                Return

            End If


            If UsernameExists(username) Then

                MessageBox.Show(
                    "The username '" &
                    username &
                    "' is already being used.",
                    "Duplicate Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtUsername.Focus()
                Return

            End If


            Dim fullName As String =
                firstName & " " & lastName


            Dim query As String =
                "INSERT INTO Users " &
                "(" &
                "Username, " &
                "Password, " &
                "FullName, " &
                "FirstName, " &
                "LastName, " &
                "Role, " &
                "StudentNo, " &
                "Course, " &
                "YearLevel, " &
                "EnrolledInNSTP, " &
                "IsActive" &
                ") " &
                "VALUES " &
                "(" &
                "@Username, " &
                "@Password, " &
                "@FullName, " &
                "@FirstName, " &
                "@LastName, " &
                "'Student', " &
                "@StudentNo, " &
                "@Course, " &
                "@YearLevel, " &
                "@NSTP, " &
                "1" &
                ");"


            Dim parameters As New Dictionary(
                Of String,
                Object
            ) From {

                {
                    "@Username",
                    username
                },
                {
                    "@Password",
                    password
                },
                {
                    "@FullName",
                    fullName
                },
                {
                    "@FirstName",
                    firstName
                },
                {
                    "@LastName",
                    lastName
                },
                {
                    "@StudentNo",
                    studentNo
                },
                {
                    "@Course",
                    course
                },
                {
                    "@YearLevel",
                    yearLevel
                },
                {
                    "@NSTP",
                    If(chkNSTP.Checked, 1, 0)
                }

            }


            Dim result As Integer =
                db.ExecuteNonQuery(
                    query,
                    parameters
                )


            If result > 0 Then

                MessageBox.Show(
                    "Student account created successfully." &
                    Environment.NewLine &
                    Environment.NewLine &
                    "Student No.: " &
                    studentNo &
                    Environment.NewLine &
                    "Name: " &
                    fullName,
                    "Student Created",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

                ClearForm()

            Else

                MessageBox.Show(
                    "The student account could not be created.",
                    "Create Student",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                )

            End If


        Catch ex As MySqlException

            MessageBox.Show(
                "A database error occurred while creating the student." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As Exception

            MessageBox.Show(
                "An unexpected error occurred." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Function StudentNumberExists(
        studentNo As String
    ) As Boolean

        Dim query As String =
            "SELECT COUNT(*) " &
            "FROM Users " &
            "WHERE StudentNo = @StudentNo;"


        Dim parameters As New Dictionary(
            Of String,
            Object
        ) From {

            {
                "@StudentNo",
                studentNo
            }

        }


        Dim result As Object =
            db.ExecuteScalar(
                query,
                parameters
            )


        Return Convert.ToInt32(result) > 0

    End Function


    Private Function UsernameExists(
        username As String
    ) As Boolean

        Dim query As String =
            "SELECT COUNT(*) " &
            "FROM Users " &
            "WHERE Username = @Username;"


        Dim parameters As New Dictionary(
            Of String,
            Object
        ) From {

            {
                "@Username",
                username
            }

        }


        Dim result As Object =
            db.ExecuteScalar(
                query,
                parameters
            )


        Return Convert.ToInt32(result) > 0

    End Function



    Private Sub btnClearForm_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClearForm.Click

        Dim answer As DialogResult =
            MessageBox.Show(
                "Clear all entered information?",
                "Clear Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

        If answer = DialogResult.Yes Then
            ClearForm()
        End If

    End Sub


    Private Sub ClearForm()

        txtStudentNo.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()

        cmbCourse.SelectedIndex = -1
        cmbYearLevel.SelectedIndex = -1

        chkNSTP.Checked = False

        txtUsername.Clear()
        txtPassword.Clear()

        txtStudentNo.Focus()

    End Sub

    Private Sub ShowWarning(
        message As String
    )

        MessageBox.Show(
            message,
            "Required Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

    End Sub

End Class
