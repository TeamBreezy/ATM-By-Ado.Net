Public Class Form6

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim AccNo As Integer = Form4.TextBox10.Text

        Dim Amount As Decimal = TextBox1.Text

        Dim Details As String = "'" & TextBox2.Text & "'"

        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "AddWithDrawals"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@AccNo", AccNo)
        Cmd.Parameters.AddWithValue("@Amount", Amount)
        Cmd.Parameters.AddWithValue("@Details", Details)
        Cmd.Parameters.AddWithValue("@UserName", EmpUser)

        Dim rv As SqlClient.SqlParameter
        rv = Cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)
        rv.Direction = ParameterDirection.ReturnValue
        Cmd.Connection = Cn


        Dim h As Integer
        h = Cmd.ExecuteNonQuery()

        MsgBox(h & " تم الحفظ بنجاح", MsgBoxStyle.Information)

    End Sub
End Class