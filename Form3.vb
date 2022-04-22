Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Then
            MsgBox("من فضلك ادخل الاسم")
            Exit Sub
        End If
        Dim f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13 As String

        f1 = "'" & TextBox1.Text & "',"
        f2 = "'" & TextBox2.Text & "',"
        f3 = "'" & TextBox3.Text & "',"
        f4 = "'" & TextBox4.Text & "',"
        f5 = "'" & TextBox5.Text & "',"
        f6 = "'" & TextBox6.Text & "',"
        f7 = "'" & TextBox7.Text & "',"
        f8 = "'" & TextBox8.Text & "',"
        f9 = "'" & TextBox9.Text & "',"
        f10 = "'" & TextBox10.Text & "',"
        f11 = "'" & TextBox11.Text & "',"
        f12 = "'" & TextBox12.Text & "',"
        If CheckBox1.Checked = True Then f13 = "1" Else f13 = "0"

        Dim s As String


        s = "Insert Into Customers(FristName,LastName,Company,JobTitle,BusinessPhone,HomePhone,Email,City,Street,AccountNo,PinCode,MobilePhone,Status) Values (" & f1 & f2 & f3 & f4 & f5 & f6 & f7 & f8 & f9 & f10 & f11 & f12 & f13 & ")"


        Dim h As Integer
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = s
        h = Cmd.ExecuteNonQuery()
        MsgBox(h & "تم حفظ بيانات العميل بنجاح", MsgBoxStyle.Information, "عميل جديد")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class