Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "dbo.EmployeeStatus"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@UserName", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@Password", TextBox2.Text)
        Dim returnValue As SqlClient.SqlParameter
        returnValue = Cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)
        returnValue.Direction = ParameterDirection.ReturnValue
        Cmd.ExecuteNonQuery()
        Dim I As Integer = returnValue.Value

        If I = 0 Then
            MsgBox("عفوا يوجد خطأ فى إسم المستخدم أو كلمة المرور", MsgBoxStyle.Critical, "Login")
            TextBox1.Text = " "
            TextBox2.Text = " "
            Exit Sub
        End If

        If I = 1 Then
            MsgBox("إسم المستخدم صحيح ولكن تم إيقافه مؤقتا", MsgBoxStyle.Critical, "Login")
            TextBox1.Text = " "
            TextBox2.Text = " "
            Exit Sub
        End If

        EmpUser = TextBox1.Text
        returnValue = Nothing
        Me.Hide()
        Form2.ShowDialog()
        TextBox1.Select()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cn.ConnectionString = Con
        Cn.Open()

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text

        TextBox1.Select()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        WindowState = FormWindowState.Minimized

    End Sub
End Class
