Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "GetBalance"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@AccNo", Form1.TextBox1.Text)
        Dim returnValue As SqlClient.SqlParameter
        returnValue = Cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)
        returnValue.Direction = ParameterDirection.ReturnValue
        Cmd.Connection = Cn
        Cmd.ExecuteNonQuery()
        Dr = Cmd.ExecuteReader
        Dr.Read()

        TextBox1.Text = returnValue.Value

        Dr.Close()

        'Cmd.CommandText = "select dbo.GetBalance('" & Form1.TextBox1.Text & "') "
        'Dr = Cmd.ExecuteReader
        'Dr.Read()
        'TextBox1.Text = Dr(0)
        'Dr.Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Me.Dispose()

    End Sub
End Class