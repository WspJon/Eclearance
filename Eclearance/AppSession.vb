Public Module AppSession

    Public UserID As Integer
    Public Username As String = ""
    Public FullName As String = ""
    Public Role As String = ""

    Public DepartmentID As Integer? = Nothing

    Public StudentNo As String = ""
    Public Course As String = ""
    Public YearLevel As String = ""

    Public Sub Clear()

        UserID = 0
        Username = ""
        FullName = ""
        Role = ""

        DepartmentID = Nothing

        StudentNo = ""
        Course = ""
        YearLevel = ""

    End Sub

End Module
