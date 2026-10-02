Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DatabaseHelper

    Private ReadOnly connectionString As String =
        "Server=127.0.0.1;" &
        "Port=3306;" &
        "Database=loa_eclearance_latest;" &
        "Uid=root;" &
        "Pwd=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function


    Public Function ExecuteQuery(
        query As String,
        Optional parameters As Dictionary(Of String, Object) = Nothing
    ) As DataTable

        Dim table As New DataTable()

        Using conn As MySqlConnection = GetConnection()

            Using cmd As New MySqlCommand(query, conn)

                AddParameters(cmd, parameters)

                conn.Open()

                Using adapter As New MySqlDataAdapter(cmd)

                    adapter.Fill(table)

                End Using

            End Using

        End Using

        Return table

    End Function


    Public Function ExecuteNonQuery(
        query As String,
        Optional parameters As Dictionary(Of String, Object) = Nothing
    ) As Integer

        Using conn As MySqlConnection = GetConnection()

            Using cmd As New MySqlCommand(query, conn)

                AddParameters(cmd, parameters)

                conn.Open()

                Return cmd.ExecuteNonQuery()

            End Using

        End Using

    End Function


    Public Function ExecuteScalar(
        query As String,
        Optional parameters As Dictionary(Of String, Object) = Nothing
    ) As Object

        Using conn As MySqlConnection = GetConnection()

            Using cmd As New MySqlCommand(query, conn)

                AddParameters(cmd, parameters)

                conn.Open()

                Return cmd.ExecuteScalar()

            End Using

        End Using

    End Function


    Private Sub AddParameters(
        cmd As MySqlCommand,
        parameters As Dictionary(Of String, Object)
    )

        If parameters Is Nothing Then
            Return
        End If

        For Each parameter In parameters

            Dim value As Object =
                parameter.Value

            If value Is Nothing Then
                value = DBNull.Value
            End If

            cmd.Parameters.AddWithValue(
                parameter.Key,
                value
            )

        Next

    End Sub

End Class