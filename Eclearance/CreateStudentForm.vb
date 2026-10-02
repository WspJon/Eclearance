Imports MySql.Data.MySqlClient

Public Class CreateStudentForm

    Private ReadOnly db As New DatabaseHelper()


    Private Sub CreateStudentForm_Load(
        sender As Object,
        e As EventArgs
    ) Handles MyBase.Load

        LoadCourseOptions()
        LoadYearLevelOptions()
        LoadStudentTypeOptions()

        txtPassword.UseSystemPasswordChar = True

        txtStudentNo.Focus()

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


    Private Sub LoadStudentTypeOptions()

        cmbStudentType.Items.Clear()

        cmbStudentType.Items.Add("New")
        cmbStudentType.Items.Add("Old")
        cmbStudentType.Items.Add("Transferee")

        cmbStudentType.SelectedIndex = -1

    End Sub


    Private Sub cmbCourse_SelectedIndexChanged(
        sender As Object,
        e As EventArgs
    ) Handles cmbCourse.SelectedIndexChanged

        LoadSectionsForCourse()

    End Sub


    Private Sub LoadSectionsForCourse()

        cmbSection.Items.Clear()

        If cmbCourse.SelectedItem Is Nothing Then
            cmbSection.SelectedIndex = -1
            Return
        End If

        Dim selectedCourse As String = cmbCourse.SelectedItem.ToString()

        Try
            Dim query As String =
                "SELECT SectionName FROM Sections WHERE CourseName = @Course AND IsActive = 1 ORDER BY SectionName ASC;"

            Dim dt As DataTable = db.ExecuteQuery(
                query,
                New Dictionary(Of String, Object) From {{"@Course", selectedCourse}}
            )

            For Each row As DataRow In dt.Rows
                cmbSection.Items.Add(row("SectionName").ToString())
            Next
        Catch ex As Exception
            cmbSection.Items.Add(selectedCourse & "-1A")
            cmbSection.Items.Add(selectedCourse & "-2A")
            cmbSection.Items.Add(selectedCourse & "-3A")
            cmbSection.Items.Add(selectedCourse & "-4A")
        End Try

        If cmbSection.Items.Count > 0 Then
            cmbSection.SelectedIndex = 0
        Else
            cmbSection.SelectedIndex = -1
        End If

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

            course =
                cmbCourse.SelectedItem.ToString()

        End If


        If cmbYearLevel.SelectedItem IsNot Nothing Then
            yearLevel = cmbYearLevel.SelectedItem.ToString()
        End If

        Dim section As String = ""
        If cmbSection.SelectedItem IsNot Nothing Then
            section = cmbSection.SelectedItem.ToString()
        End If

        Dim studentType As String = ""
        If cmbStudentType.SelectedItem IsNot Nothing Then
            studentType = cmbStudentType.SelectedItem.ToString()
        End If

        Dim guidanceInfoRequired As Boolean = chkGuidanceInfoRequired.Checked

        If String.IsNullOrWhiteSpace(studentNo) Then
            ShowWarning("Please enter the student number.")
            txtStudentNo.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(firstName) Then
            ShowWarning("Please enter the student's first name.")
            txtFirstName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(lastName) Then
            ShowWarning("Please enter the student's last name.")
            txtLastName.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(course) Then
            ShowWarning("Please select the student's course.")
            cmbCourse.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(yearLevel) Then
            ShowWarning("Please select the student's year level.")
            cmbYearLevel.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(section) Then
            ShowWarning("Please select the student's section.")
            cmbSection.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(studentType) Then
            ShowWarning("Please select the student type.")
            cmbStudentType.Focus()
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


        Try

            If StudentNumberExists(studentNo) Then

                MessageBox.Show(
                    "The student number is already registered.",
                    "Duplicate Student Number",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtStudentNo.Focus()

                Return

            End If


            If UsernameExists(username) Then

                MessageBox.Show(
                    "The username is already being used.",
                    "Duplicate Username",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                txtUsername.Focus()

                Return

            End If


            Dim termID As Integer =
                GetActiveTermID()


            If termID = 0 Then

                MessageBox.Show(
                    "There is no active academic term." &
                    Environment.NewLine &
                    "Please create or activate a term first.",
                    "No Active Term",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

                Return

            End If


            Dim fullName As String =
                firstName & " " & lastName

            ' Confirmation Dialog
            Dim confirmResult As DialogResult = MessageBox.Show(
                "Are you sure the student details are correct?",
                "Confirm Student Details",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            )

            If confirmResult <> DialogResult.Yes Then
                Return
            End If

            Using conn As MySqlConnection =
                db.GetConnection()

                conn.Open()

                Using transaction As MySqlTransaction =
                    conn.BeginTransaction()

                    Try

                        Dim insertStudentQuery As String =
                            "INSERT INTO Users " &
                            "(" &
                            "Username, Password, FullName, FirstName, LastName, " &
                            "Role, StudentNo, Course, Section, YearLevel, StudentType, GuidanceInfoUpdateRequired, EnrolledInNSTP, IsActive" &
                            ") " &
                            "VALUES " &
                            "(" &
                            "@Username, @Password, @FullName, @FirstName, @LastName, " &
                            "'Student', @StudentNo, @Course, @Section, @YearLevel, @StudentType, @GuidanceInfoUpdateRequired, @NSTP, 1" &
                            ");"

                        Dim newStudentID As Integer

                        Using cmd As New MySqlCommand(
                            insertStudentQuery,
                            conn,
                            transaction
                        )

                            cmd.Parameters.AddWithValue(
                                "@Username",
                                username
                            )

                            cmd.Parameters.AddWithValue(
                                "@Password",
                                password
                            )

                            cmd.Parameters.AddWithValue(
                                "@FullName",
                                fullName
                            )

                            cmd.Parameters.AddWithValue(
                                "@FirstName",
                                firstName
                            )

                            cmd.Parameters.AddWithValue(
                                "@LastName",
                                lastName
                            )

                            cmd.Parameters.AddWithValue(
                                "@StudentNo",
                                studentNo
                            )

                            cmd.Parameters.AddWithValue(
                                "@Course",
                                course
                            )

                            cmd.Parameters.AddWithValue(
                                "@Section",
                                section
                            )

                            cmd.Parameters.AddWithValue(
                                "@YearLevel",
                                yearLevel
                            )

                            cmd.Parameters.AddWithValue(
                                "@StudentType",
                                studentType
                            )

                            cmd.Parameters.AddWithValue(
                                "@GuidanceInfoUpdateRequired",
                                If(guidanceInfoRequired, 1, 0)
                            )

                            cmd.Parameters.AddWithValue(
                                "@NSTP",
                                If(chkNSTP.Checked, 1, 0)
                            )

                            cmd.ExecuteNonQuery()

                            newStudentID =
                                Convert.ToInt32(
                                    cmd.LastInsertedId
                                )

                        End Using


                        CreateClearanceRecords(
                            conn,
                            transaction,
                            newStudentID,
                            termID,
                            course,
                            yearLevel,
                            chkNSTP.Checked
                        )


                        transaction.Commit()


                        MessageBox.Show(
                            "Student account created successfully." &
                            Environment.NewLine &
                            Environment.NewLine &
                            "Student No.: " & studentNo &
                            Environment.NewLine &
                            "Name: " & fullName,
                            "Student Created",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        )


                        ClearForm()

                        Me.DialogResult = DialogResult.OK
                        Me.Close()

                    Catch

                        transaction.Rollback()

                        Throw

                    End Try

                End Using

            End Using


        Catch ex As MySqlException

            MessageBox.Show(
                "A database error occurred." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )


        Catch ex As Exception

            MessageBox.Show(
                "The student account could not be created." &
                Environment.NewLine &
                Environment.NewLine &
                ex.Message,
                "Create Student Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        End Try

    End Sub


    Private Sub CreateClearanceRecords(
        conn As MySqlConnection,
        transaction As MySqlTransaction,
        studentID As Integer,
        termID As Integer,
        course As String,
        yearLevel As String,
        enrolledInNSTP As Boolean
    )
        Dim requirementQuery As String =
            "SELECT RequirementID, SequenceOrder, AppliesToCourse, RequiresNSTP, ApplicableCourses, ApplicableYearLevels " &
            "FROM ClearanceRequirements " &
            "WHERE IsActive = 1 " &
            "ORDER BY SequenceOrder ASC;"

        Dim dtReqs As New DataTable()
        Using cmd As New MySqlCommand(requirementQuery, conn, transaction)
            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dtReqs)
            End Using
        End Using

        If dtReqs.Rows.Count = 0 Then
            Throw New Exception("No active clearance requirements were found.")
        End If

        Dim insertRecordQuery As String =
            "INSERT INTO ClearanceRecords (StudentID, RequirementID, TermID, Status) " &
            "VALUES (@StudentID, @RequirementID, @TermID, @Status);"

        For Each row As DataRow In dtReqs.Rows
            Dim reqID As Integer = Convert.ToInt32(row("RequirementID"))
            Dim seqOrder As Integer = Convert.ToInt32(row("SequenceOrder"))
            Dim appliesToCourse As String = If(IsDBNull(row("AppliesToCourse")), "", row("AppliesToCourse").ToString())
            Dim reqNSTP As Boolean = Convert.ToBoolean(row("RequiresNSTP"))
            Dim appCourses As String = If(IsDBNull(row("ApplicableCourses")), "", row("ApplicableCourses").ToString())
            Dim appYears As String = If(IsDBNull(row("ApplicableYearLevels")), "", row("ApplicableYearLevels").ToString())

            Dim isApp As Boolean = ClearanceWorkflowHelper.IsRequirementApplicable(course, yearLevel, appliesToCourse, reqNSTP, appCourses, appYears)
            Dim initStatus As String = "Locked"

            If Not isApp Then
                initStatus = "Not Applicable"
            ElseIf seqOrder >= 1 AndAlso seqOrder <= 5 Then
                initStatus = "Pending"
            Else
                initStatus = "Locked"
            End If

            Using cmd As New MySqlCommand(insertRecordQuery, conn, transaction)
                cmd.Parameters.AddWithValue("@StudentID", studentID)
                cmd.Parameters.AddWithValue("@RequirementID", reqID)
                cmd.Parameters.AddWithValue("@TermID", termID)
                cmd.Parameters.AddWithValue("@Status", initStatus)
                cmd.ExecuteNonQuery()
            End Using
        Next

    End Sub


    Private Function StudentNumberExists(
        studentNo As String
    ) As Boolean

        Dim query As String =
            "SELECT COUNT(*) " &
            "FROM Users " &
            "WHERE StudentNo = @StudentNo;"


        Dim parameters As New Dictionary(Of String, Object) From {
            {"@StudentNo", studentNo}
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


        Dim parameters As New Dictionary(Of String, Object) From {
            {"@Username", username}
        }


        Dim result As Object =
            db.ExecuteScalar(
                query,
                parameters
            )


        Return Convert.ToInt32(result) > 0

    End Function


    Private Function GetActiveTermID() As Integer

        Dim query As String =
            "SELECT TermID " &
            "FROM AcademicTerms " &
            "WHERE IsActive = 1 " &
            "ORDER BY TermID DESC " &
            "LIMIT 1;"


        Dim result As Object =
            db.ExecuteScalar(query)


        If result Is Nothing OrElse
           result Is DBNull.Value Then

            Return 0

        End If


        Return Convert.ToInt32(result)

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

        cmbSection.Items.Clear()
        cmbSection.SelectedIndex = -1

        cmbYearLevel.SelectedIndex = -1

        cmbStudentType.SelectedIndex = -1

        chkNSTP.Checked = False

        chkGuidanceInfoRequired.Checked = False

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


    Private Sub btnClose_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnClose.Click

        Me.DialogResult = DialogResult.Cancel
        Me.Close()

    End Sub


    ' Drag modal window
    Private isDragging As Boolean = False
    Private dragCursorPoint As Point
    Private dragFormPoint As Point

    Private Sub ModalHeader_MouseDown(
        sender As Object,
        e As MouseEventArgs
    ) Handles lblModalTitle.MouseDown, pnlCard.MouseDown

        If e.Button = MouseButtons.Left AndAlso e.Y <= 60 Then
            isDragging = True
            dragCursorPoint = Cursor.Position
            dragFormPoint = Me.Location
        End If

    End Sub

    Private Sub ModalHeader_MouseMove(
        sender As Object,
        e As MouseEventArgs
    ) Handles lblModalTitle.MouseMove, pnlCard.MouseMove

        If isDragging Then
            Dim diff As Point = Point.Subtract(Cursor.Position, New Size(dragCursorPoint))
            Me.Location = Point.Add(dragFormPoint, New Size(diff))
        End If

    End Sub

    Private Sub ModalHeader_MouseUp(
        sender As Object,
        e As MouseEventArgs
    ) Handles lblModalTitle.MouseUp, pnlCard.MouseUp

        isDragging = False

    End Sub

End Class