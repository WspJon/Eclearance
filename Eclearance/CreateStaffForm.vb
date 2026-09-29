Imports MySql.Data.MySqlClient

Public Class CreateStaffForm

    Private ReadOnly db As New DatabaseHelper()
    Private officeDict As New Dictionary(Of String, Integer)()

    Private Sub CreateStaffForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOfficeOptions()
        txtPassword.UseSystemPasswordChar = True
        txtFullName.Focus()
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

            If cmbAssignedOffice.Items.Count > 0 Then
                cmbAssignedOffice.SelectedIndex = 0
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to load offices." & Environment.NewLine & ex.Message, "Office Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        Dim fullName As String = txtFullName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text
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

        If String.IsNullOrWhiteSpace(password) Then
            ShowWarning("Please enter a password.")
            txtPassword.Focus()
            Return
        End If

        Try
            Dim checkQuery As String = "SELECT COUNT(*) FROM Users WHERE Username = @Username;"
            Dim checkParams As New Dictionary(Of String, Object) From {{"@Username", username}}
            Dim count As Integer = Convert.ToInt32(db.ExecuteScalar(checkQuery, checkParams))

            If count > 0 Then
                ShowWarning("This username is already taken. Please choose another.")
                txtUsername.Focus()
                Return
            End If

            Dim deptID As Integer = officeDict(officeName)

            Dim insertQuery As String =
                "INSERT INTO Users (Username, Password, FullName, Role, DepartmentID, IsActive) " &
                "VALUES (@Username, @Password, @FullName, 'Staff', @DepartmentID, 1);"

            Dim insertParams As New Dictionary(Of String, Object) From {
                {"@Username", username},
                {"@Password", password},
                {"@FullName", fullName},
                {"@DepartmentID", deptID}
            }

            db.ExecuteNonQuery(insertQuery, insertParams)

            MessageBox.Show(
                "Staff account created successfully." & Environment.NewLine & Environment.NewLine &
                "Name: " & fullName & Environment.NewLine &
                "Office: " & officeName & Environment.NewLine &
                "Username: " & username,
                "Staff Created",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Failed to create staff account." & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtFullName.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        If cmbAssignedOffice.Items.Count > 0 Then cmbAssignedOffice.SelectedIndex = 0
        txtFullName.Focus()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ShowWarning(message As String)
        MessageBox.Show(
            message,
            "Required Information",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )
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
