Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form3.ShowDialog()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim H As String = InputBox("من فضلك أدخل رقم الحساب", "Search")

        If Trim(H) = "" Then Exit Sub


        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = ("Select * From Customers Where AccountNo ='" & H & "'")
        Dr = Cmd.ExecuteReader
        Dr.Read()

        If Dr.HasRows = False Then
            MsgBox("عفوا رقم الحساب غير مسجل", MsgBoxStyle.Critical, "Search")
            Dr.Close()
            Exit Sub
        End If

        Form4.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim x As String = MsgBox("هل تريد الخروج ؟", vbOKCancel, "Exit")

        If x = vbOK Then
            End
        End If

    End Sub
End Class