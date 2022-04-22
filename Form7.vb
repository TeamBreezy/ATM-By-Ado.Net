Imports System.Data.SqlClient
Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       Dim ad As New SqlDataAdapter
        Dim ds As New DataSet

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "Select * From Customers"

        ad.SelectCommand = Cmd
        ad.Fill(ds, "Customers")
        DataGridView1.DataSource = ds.Tables("Customers")


    End Sub
End Class