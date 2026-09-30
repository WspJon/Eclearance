Public Class ClearanceWorkflowHelper

    Public Class ClearanceItemInfo
        Public Property RecordID As Integer
        Public Property RequirementID As Integer
        Public Property DepartmentID As Integer
        Public Property DepartmentName As String
        Public Property RequirementName As String
        Public Property Instructions As String
        Public Property RequirementLink As String
        Public Property RequiresFile As Boolean
        Public Property SequenceOrder As Integer
        Public Property AppliesToCourse As String
        Public Property RequiresNSTP As Boolean
        Public Property ApplicableCourses As String
        Public Property ApplicableYearLevels As String
        Public Property DBStatus As String
        Public Property EffectiveStatus As String ' Cleared, Under Review, Rejected, Pending, Locked, Not Applicable
        Public Property Remarks As String
        Public Property SubmittedFilePath As String
        Public Property SubmittedFileName As String
        Public Property SubmittedAt As Object
        Public Property IsApplicable As Boolean
        Public Property CanSubmit As Boolean
        Public Property FileCount As Integer = 0
    End Class

    ''' <summary>
    ''' Determines if a requirement is applicable to the student based on Course and Year Level.
    ''' CTHM Stock Room is only applicable to CTHM/Hospitality/Tourism programs.
    ''' NSTP is strictly applicable only to first-year students.
    ''' </summary>
    Public Shared Function IsRequirementApplicable(
        studentCourse As String,
        studentYearLevel As String,
        appliesToCourse As String,
        requiresNSTP As Boolean,
        applicableCourses As String,
        applicableYearLevels As String
    ) As Boolean

        Dim course As String = If(studentCourse, "").Trim().ToUpperInvariant()
        Dim yearLevel As String = If(studentYearLevel, "").Trim().ToLowerInvariant()

        ' 1. Check NSTP year-level applicability
        If requiresNSTP OrElse Not String.IsNullOrWhiteSpace(applicableYearLevels) Then
            Dim isFirstYear As Boolean =
                yearLevel.Contains("1st") OrElse
                yearLevel.Contains("first") OrElse
                yearLevel.StartsWith("1") OrElse
                yearLevel.Equals("1")

            If Not isFirstYear Then
                ' Non-first-year students skip NSTP
                Return False
            End If
        End If

        ' 2. Check Course applicability (e.g. CTHM Stock Room)
        Dim courseFilter As String = ""
        If Not String.IsNullOrWhiteSpace(applicableCourses) Then
            courseFilter = applicableCourses
        ElseIf Not String.IsNullOrWhiteSpace(appliesToCourse) Then
            courseFilter = appliesToCourse
        End If

        If Not String.IsNullOrWhiteSpace(courseFilter) Then
            Dim allowedCourses = courseFilter.Split(New Char() {","c, ";"c, "|"c}, StringSplitOptions.RemoveEmptyEntries)
            Dim isCourseMatched As Boolean = False

            For Each allowed In allowedCourses
                Dim cleanAllowed = allowed.Trim().ToUpperInvariant()
                If Not String.IsNullOrWhiteSpace(cleanAllowed) Then
                    If course.Contains(cleanAllowed) OrElse cleanAllowed.Contains(course) Then
                        isCourseMatched = True
                        Exit For
                    End If
                End If
            Next

            If Not isCourseMatched Then
                ' Course does not match (e.g. BSIT student skipping CTHM)
                Return False
            End If
        End If

        Return True
    End Function

    ''' <summary>
    ''' Evaluates the sequential clearance workflow for a list of items ordered by SequenceOrder.
    ''' Sets EffectiveStatus to: Cleared, Under Review, Rejected, Pending, Locked, or Not Applicable.
    ''' </summary>
    Public Shared Sub EvaluateSequentialWorkflow(
        items As List(Of ClearanceItemInfo),
        studentCourse As String,
        studentYearLevel As String
    )
        If items Is Nothing Then Return

        ' Sort by SequenceOrder ascending
        Dim sorted = items.OrderBy(Function(i) i.SequenceOrder).ToList()
        Dim allPrecedingCleared As Boolean = True

        For Each item In sorted
            ' Determine applicability
            item.IsApplicable = IsRequirementApplicable(
                studentCourse,
                studentYearLevel,
                item.AppliesToCourse,
                item.RequiresNSTP,
                item.ApplicableCourses,
                item.ApplicableYearLevels
            )

            If Not item.IsApplicable Then
                item.EffectiveStatus = "Not Applicable"
                item.CanSubmit = False
                ' Skipping non-applicable requirement does NOT block next steps!
            Else
                Dim dbStat As String = If(String.IsNullOrWhiteSpace(item.DBStatus), "Pending", item.DBStatus.Trim())

                If dbStat.Equals("Cleared", StringComparison.OrdinalIgnoreCase) Then
                    item.EffectiveStatus = "Cleared"
                    item.CanSubmit = False
                    ' Preceding cleared remains True
                Else
                    If allPrecedingCleared Then
                        ' This is the CURRENT available step!
                        item.EffectiveStatus = dbStat ' "Pending", "Under Review", or "Rejected"
                        item.CanSubmit = (dbStat.Equals("Pending", StringComparison.OrdinalIgnoreCase) OrElse
                                          dbStat.Equals("Rejected", StringComparison.OrdinalIgnoreCase))
                        ' All future applicable steps must be locked!
                        allPrecedingCleared = False
                    Else
                        ' Previous applicable step is not cleared yet
                        item.EffectiveStatus = "Locked"
                        item.CanSubmit = False
                    End If
                End If
            End If
        Next
    End Sub

End Class
