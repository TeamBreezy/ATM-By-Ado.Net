Imports System.Data.SqlClient
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cn.ConnectionString = Con
        Cn.Open()

        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        TextBox1.Select()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Cmd.CommandType = CommandType.StoredProcedure
        Cmd.CommandText = "IsAdmin"
        Cmd.Parameters.Clear()
        Cmd.Parameters.AddWithValue("@Uid", TextBox1.Text)
        Cmd.Parameters.AddWithValue("@Pwd", TextBox2.Text)
        Dim returnValue As SqlClient.SqlParameter
        returnValue = Cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int)
        returnValue.Direction = ParameterDirection.ReturnValue
        Cmd.Connection = Cn

        Cmd.ExecuteNonQuery()
        Dim I As Integer = returnValue.Value

        If I = 0 Then
            MsgBox("عفوا المستخدم غير مسجل", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If I = 1 Then
            MsgBox("عفوا ليس لك صلاحيات الدخول هنا", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If I = 2 Then
            MsgBox("عفوا الحساب متوقف مؤقتا", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Me.Hide()
        Form2.Show()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (e.KeyChar) = Chr(13) Then
            TextBox2.Select()
        End If
    End Sub


End Class
