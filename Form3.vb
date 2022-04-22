Imports System.Data.SqlClient
Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ad As New SqlDataAdapter
        Dim ds As New DataSet

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = "Select * From Employees"

        ad.SelectCommand = Cmd
        ad.Fill(Ds, "Employees")
        DataGridView1.DataSource = ds.Tables("Employees")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub
End Class