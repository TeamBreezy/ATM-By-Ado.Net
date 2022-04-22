Public Class Form4

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = Dr("FristName")
        TextBox2.Text = Dr("LastName")
        TextBox3.Text = Dr("Company")
        TextBox4.Text = Dr("JobTitle")
        TextBox5.Text = Dr("BusinessPhone")
        TextBox6.Text = Dr("HomePhone")
        TextBox7.Text = Dr("Email")
        TextBox8.Text = Dr("City")
        TextBox9.Text = Dr("Street")
        TextBox10.Text = Dr("AccountNo")
        TextBox11.Text = Dr("PinCode")
        TextBox12.Text = Dr("MobilePhone")
        CheckBox1.Checked = Dr("Status")

        Dr.Close()

        'TextBox1.Select()
        'Cmd.CommandText = "Select dbo.GetBalance('" & TextBox10.Text & "') "
        'TextBox13.Text = Dr(0)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14 As String

        f1 = "'" & TextBox1.Text & "'"
        f2 = "'" & TextBox2.Text & "'"
        f3 = "'" & TextBox3.Text & "'"
        f4 = "'" & TextBox4.Text & "'"
        f5 = "'" & TextBox5.Text & "'"
        f6 = "'" & TextBox6.Text & "'"
        f7 = "'" & TextBox7.Text & "'"
        f8 = "'" & TextBox8.Text & "'"
        f9 = "'" & TextBox9.Text & "'"
        f10 = "'" & TextBox10.Text & "'"
        f11 = "'" & TextBox11.Text & "'"
        f12 = "'" & TextBox12.Text & "'"

        f14 = "'" & CheckBox1.Text & "'"


        Dim s As String
        Dim u As String = "Select AccountNo From Customers"
        s = "update Customers set FristName=" & f1 & ",LastName=" & f2 & ",Company=" & f3 & ",JobTitle=" & f4 & ",BusinessPhone=" & f5 & ",HomePhone=" & f6 & ",Email=" & f7 & ",City=" & f8 & ",Street=" & f9 & ",AccountNo=" & f10 & ",PinCode=" & f11 & ",Status=" & f14 & ",Balance=" & f13 & ",MobilePhone=" & f12 & "where AccountNo =" & f10

        Cmd.CommandText = s
        Dim h As Integer

        h = Cmd.ExecuteNonQuery()

        MsgBox(H & "تم تحديث بيانات العميل بنجاح", MsgBoxStyle.Information, "Update")


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

       Dim s As String
        Dim h As Integer

        s = "Delete From Customers Where AccountNo ='" & TextBox10.Text & "'"
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = s
        h = Cmd.ExecuteNonQuery
        MsgBox(h & "تم حذف الموظف بنجاح", MsgBoxStyle.Information, "Delete")

            Dim Txt As Control
            For Each Txt In GroupBox1.Controls

                If Txt.GetType() Is GetType(TextBox) = True Then Txt.Text = ""

            Next

            CheckBox1.Checked = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Form5.ShowDialog()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Form6.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Form7.ShowDialog()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        TextBox11.Text = RSet(System.Guid.NewGuid.ToString, 8)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        Dim x As String = MsgBox("هل تريد الخروج ؟", vbOKCancel, "Exit")

        If x = vbOK Then
            End
        End If

    End Sub
End Class