Public Class AboutUS
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm3 As New BusOperator
        MyForm3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MyForm5 As New TicketBookingvb
        MyForm5.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm4 As New BusSchedule
        MyForm4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim MyForm6 As New ContactUs
        MyForm6.Show()
        Me.Hide()
    End Sub
End Class