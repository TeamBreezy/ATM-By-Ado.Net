Imports System.Data.SqlClient
Module Module1

    Public Cn As New SqlConnection
    Public Cmd As New SqlCommand
    Public Dr As SqlDataReader
    Public dr1 As SqlDataReader
    Public ad As New SqlDataAdapter
    Public Ds As New DataSet

    Public Con As String = "Data Source=AHMED-PC;Initial Catalog=ATM;Persist Security Info=True;User ID=sa;Password=123"

    Public EmpUser As String

End Module
