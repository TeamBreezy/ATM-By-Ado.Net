Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim UID As String = Form1.TextBox1.Text
        Dim f1 As String = TextBox2.Text

        Dim S As String

        S = "UPDATE Customers SET PinCode =" & f1 & "where AccountNo =" & UID

        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = S



        Dim h As Integer

        h = Cmd.ExecuteNonQuery()

        If TextBox2.Text <> TextBox1.Text Then
            Dr.Close()
            MsgBox("عفوا يوجد خطأ فى كتابة الرمز من فضلك أعد الكتابة", MsgBoxStyle.Critical)
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox1.Select()
            Exit Sub
        End If
       

        MsgBox(h & "بنجاح pin تم تغيير رمز ال", MsgBoxStyle.Information, "Update")
        Me.Dispose()

    End Sub
End Class