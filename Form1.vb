Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cn.ConnectionString = "Data Source=AHMED-PC;Initial Catalog=ATM;Persist Security Info=True;User ID=sa;Password=123"
        Cn.Open()

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text


        TextBox1.Select()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "dbo.CustomerStatus"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@AccNo", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@PinCode", TextBox2.Text)
        Dim returnValue As SqlClient.SqlParameter
        returnValue = Cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)
        returnValue.Direction = ParameterDirection.ReturnValue
        Cmd.ExecuteNonQuery()

        Dim H As Integer = returnValue.Value

        If H = 0 Then
            MsgBox(" pinعفوا يوجد خطأ فى رقم الحساب أو رمز ال", MsgBoxStyle.Critical, "Login")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Select()
            Exit Sub
        End If

        If H = 1 Then
            MsgBox("رقم الحساب صحيح ولكن تم إيقافه ", MsgBoxStyle.Critical, "Login")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Select()
            Exit Sub
        End If

        currentacc = TextBox1.Text
        returnValue = Nothing
        Me.Hide()
        Form2.ShowDialog()


    End Sub
End Class
