Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Button1.Enabled = False
        Button2.Enabled = True
        Button6.Enabled = True
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True

        Dim Txt As Control
        For Each Txt In GroupBox1.Controls

            If Txt.GetType() Is GetType(TextBox) = True Then Txt.Text = ""

        Next

        Dim Chk As CheckBox
        For Each Chk In GroupBox2.Controls

            Chk.Checked = False

        Next

        TextBox1.Select()

        Label13.Text = GetNewID("Employees")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Then
            MsgBox("من فضلك ادخل الاسم")
            Exit Sub
        End If

        Dim f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18 As String

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
        If CheckBox1.Checked = True Then f12 = "1," Else f12 = "0,"
        If CheckBox2.Checked = True Then f13 = "1," Else f13 = "0,"
        If CheckBox3.Checked = True Then f14 = "1," Else f14 = "0,"
        If CheckBox4.Checked = True Then f15 = "1," Else f15 = "0,"
        If CheckBox5.Checked = True Then f16 = "1," Else f16 = "0,"
        If CheckBox6.Checked = True Then f17 = "1," Else f17 = "0,"
        If CheckBox7.Checked = True Then f18 = "1" Else f18 = "0"
        'f13 = Boolean.Parse(CheckBox2.Checked.ToString()) & ","
        'f14 = Boolean.Parse(CheckBox3.Checked.ToString()) & ","
        'f15 = Boolean.Parse(CheckBox4.Checked.ToString()) & ","
        'f16 = Boolean.Parse(CheckBox5.Checked.ToString()) & ","
        'f17 = Boolean.Parse(CheckBox6.Checked.ToString()) & ","
        'f18 = Boolean.Parse(CheckBox7.Checked.ToString())

        Dim s As String
        Dim H As Integer
        s = "Insert Into Employees(FristName,LastName,jobTitle,BusinessPhone,HomePhone,MobilePhone,City,Email,Street,UserName,PassWord,Status,Admin,CustomersForm,DepositsForm,WithdrawalsForm,NewCustomer,DeleteCustomer) Values (" & f1 & f2 & f3 & f4 & f5 & f6 & f7 & f8 & f9 & f10 & f11 & f12 & f13 & f14 & f15 & f16 & f17 & f18 & " ) "
        Cmd.CommandText = s
        H = Cmd.ExecuteNonQuery()
        MsgBox(H & "  تم حفظ موظف جديد بنجاح", MsgBoxStyle.Information)
        Button2.Enabled = False
        Button1.Enabled = True
        Button3.Enabled = True
    End Sub

    

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Cmd.Connection = Cn
        'Cmd.CommandText = ("Select UserName From Employees")
        'Ad.SelectCommand = Cmd

        'Do While Not   = False
        '    TextBox12.AutoCompleteCustomSource.Add(Rec("UserName").Value)
        '    Tel.MoveNext()
        'Loop

        'Tel.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Button4.Enabled = False

        Dim UID As String = TextBox12.Text
        Cmd.CommandType = CommandType.Text
        Dim s As String = "Select * From Employees Where UserName = '" + UID + "'"

        Cmd.CommandText = s
        Dr = Cmd.ExecuteReader
        Dr.Read()

        If Dr.HasRows = False Then
            MsgBox("عفوا إسم المستخدم غير مسجل", MsgBoxStyle.Critical)
            Dr.Close()
            Exit Sub
        End If

      

        TextBox1.Text = Dr("FristName")
        TextBox2.Text = Dr("LastName")
        TextBox3.Text = Dr("JobTitle")
        TextBox4.Text = Dr("BusinessPhone")
        TextBox5.Text = Dr("HomePhone")
        TextBox6.Text = Dr("MobilePhone")
        TextBox7.Text = Dr("City")
        TextBox8.Text = Dr("Email")
        TextBox9.Text = Dr("Street")
        TextBox10.Text = Dr("UserName")
        TextBox11.Text = Dr("Password")
        CheckBox1.Checked = Dr("Status")
        CheckBox3.Checked = Dr("CustomersForm")
        CheckBox4.Checked = Dr("DepositsForm")
        CheckBox5.Checked = Dr("WithDrawalsForm")
        CheckBox6.Checked = Dr("NewCustomer")
        CheckBox7.Checked = Dr("DeleteCustomer")
        CheckBox2.Checked = Dr("Admin")
        Dr.Close()
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
        Button4.Enabled = True
        Button9.Enabled = True
        Button6.Enabled = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18 As String

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
        If CheckBox1.Checked = True Then f12 = "1," Else f12 = "0,"
        If CheckBox2.Checked = True Then f13 = "1," Else f13 = "0,"
        If CheckBox3.Checked = True Then f14 = "1," Else f14 = "0,"
        If CheckBox4.Checked = True Then f15 = "1," Else f15 = "0,"
        If CheckBox5.Checked = True Then f16 = "1," Else f16 = "0,"
        If CheckBox6.Checked = True Then f17 = "1," Else f17 = "0,"
        If CheckBox7.Checked = True Then f18 = "1" Else f18 = "0"


        'f12 = "'" & CheckBox1.Text & "',"
        'f13 = "'" & CheckBox2.Text & "',"
        'f14 = "'" & CheckBox3.Text & "',"
        'f15 = "'" & CheckBox4.Text & "',"
        'f16 = "'" & CheckBox5.Text & "',"
        'f17 = "'" & CheckBox6.Text & "',"
        'f18 = "'" & CheckBox7.Text & "'"

        Dim s As String

        Dim h As Integer
        s = "update Employees set FristName=" & f1 & ",LastName=" & f2 & ",jobTitle=" & f3 & ",BusinessPhone=" & f4 & ",HomePhoto=" & f5 & ",MobilePhone=" & f6 & ",Email=" & f7 & ",Street=" & f8 & ",City=" & f9 & ",UserName=" & f10 & ",PassWord=" & f11 & ",Status=" & f12 & ",CustomersForm=" & f13 & ",DepositsForm=" & f14 & ",WithDrawalsForm=" & f15 & ",NewCustome=" & f16 & ",DeleteCustomer=" & f17 & ",Admin=" & f18 & "where UserName =" & f10

        Cmd.CommandText = s

        h = Cmd.ExecuteNonQuery()

        MsgBox(h & "تم تحديث بيانات الموظف بنجاح", MsgBoxStyle.Information)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        Dim s As String
        Dim h As Integer

        s = "Delete From Employees Where UserName='" & TextBox12.Text & "'"
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = s
        h = Cmd.ExecuteNonQuery
        MsgBox(h & "تم حذف الموظف بنجاح", MsgBoxStyle.Information, "Delete")

        Dim Txt As Control
        For Each Txt In GroupBox1.Controls

            If Txt.GetType() Is GetType(TextBox) = True Then Txt.Text = ""

        Next

        Dim Chk As CheckBox
        For Each Chk In GroupBox2.Controls

            Chk.Checked = False

        Next




    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        Form3.ShowDialog()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        Button1.Enabled = True
        Button2.Enabled = False
        Button6.Enabled = False
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim H As String = MsgBox("هل تريد الخروج ؟", vbOKCancel)
        If H = vbOK Then
            End
        End If
        Form1.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox11.Text = RSet(System.Guid.NewGuid.ToString, 8)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        If IsNumeric(e.KeyChar) Then
            SendKeys.Send(Chr(8))
        End If

        If (e.KeyChar) = Chr(13) Then
            TextBox2.Select()
        End If

    End Sub

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyUp
        TextBox10.Text = TextBox1.Text & Label13.Text
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If IsNumeric(e.KeyChar) Then
            SendKeys.Send(Chr(8))
        End If

        If (e.KeyChar) = Chr(13) Then
            TextBox3.Select()
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            SendKeys.Send(Chr(8))
        End If

        If (e.KeyChar) = Chr(13) Then
            TextBox5.Select()
        End If
    End Sub

    
    

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            SendKeys.Send(Chr(8))
        End If

        If (e.KeyChar) = Chr(13) Then
            TextBox6.Select()
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            SendKeys.Send(Chr(8))
        End If

        If (e.KeyChar) = Chr(13) Then
            TextBox7.Select()
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If IsNumeric(e.KeyChar) Then
            SendKeys.Send(Chr(8))
        End If

        If (e.KeyChar) = Chr(13) Then
            TextBox8.Select()
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If (e.KeyChar) = Chr(13) Then
            TextBox9.Select()
        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If (e.KeyChar) = Chr(13) Then
            TextBox10.Select()
        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If (e.KeyChar) = Chr(13) Then
            TextBox11.Select()
        End If
    End Sub

    
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class