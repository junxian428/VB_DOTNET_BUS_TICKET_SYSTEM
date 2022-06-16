Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text
        'MessageBox.Show(s)
        Dim password = TextBox2.Text
        'MessageBox.Show(password)

        If (username = "admin" And password = "admin") Then
            MessageBox.Show("Password correct")
            Dim MyForm4 As New AboutUS
            MyForm4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Either Username or Password is incorrect")
        End If


    End Sub
End Class