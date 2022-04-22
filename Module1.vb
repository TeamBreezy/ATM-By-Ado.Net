
Imports System.Data.SqlClient

Module Module1

    Public Cn As New SqlConnection
    Public Cmd As New SqlCommand
    Public Dr As SqlDataReader
    Public dr1 As SqlDataReader
    Public ad As New SqlDataAdapter
    Public Ds As New DataSet

    Public Con As String = "Data Source=(LOCAL);Initial Catalog=ATM;Integrated Security=True"

    Public Function GetNewID(ByVal TableName As String) As Integer

        Dim s As String

        s = ("Select Ident_current ('" & TableName & "') +1 AS [ID]")
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = s
        Dr = Cmd.ExecuteReader
        Dr.Read()
        GetNewID = Dr(0).ToString
        Dr.Close()

    End Function

End Module
