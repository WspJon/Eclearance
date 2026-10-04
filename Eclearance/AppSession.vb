Public Module AppSession

    Public UserID As Integer = 0

    Public StudentID As Integer = 0

    Public StaffID As Integer = 0

    Public Username As String = ""

    Public FullName As String = ""

    Public Role As String = ""

    Public DepartmentID As Integer? = Nothing

    Public StudentNo As String = ""

    Public Course As String = ""

    Public Section As String = ""

    Public YearLevel As String = ""

    Public StudentType As String = ""
 
    Public Sub Clear()

        UserID = 0

        StudentID = 0

        StaffID = 0

        Username = ""

        FullName = ""

        Role = ""

        DepartmentID = Nothing

        StudentNo = ""

        Course = ""

        Section = ""

        YearLevel = ""

        StudentType = ""

    End Sub

    Private _schoolLogo As Image = Nothing

    Public Function GetSchoolLogo() As Image
        If _schoolLogo IsNot Nothing Then Return _schoolLogo
        Try
            Dim path1 As String = IO.Path.Combine(Application.StartupPath, "Resources", "loa_logo.png")
            If IO.File.Exists(path1) Then
                _schoolLogo = Image.FromFile(path1)
                Return _schoolLogo
            End If
            ' fallback: search up to project root dir
            Dim dir As String = Application.StartupPath
            For i As Integer = 1 To 4
                Dim checkPath As String = IO.Path.Combine(dir, "Resources", "loa_logo.png")
                If IO.File.Exists(checkPath) Then
                    _schoolLogo = Image.FromFile(checkPath)
                    Return _schoolLogo
                End If
                Dim p = IO.Directory.GetParent(dir)
                If p Is Nothing Then Exit For
                dir = p.FullName
            Next
        Catch ex As Exception
        End Try
        Return Nothing
    End Function

    Public Sub ApplySchoolLogo(pic As PictureBox)
        If pic Is Nothing Then Return
        Dim logo = GetSchoolLogo()
        If logo IsNot Nothing Then
            pic.Image = logo
            pic.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

End Module