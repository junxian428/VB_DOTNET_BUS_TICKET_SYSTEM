Public Class Result
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm5 As New BusSchedule
        MyForm5.Show()
        Me.Hide()
    End Sub
End Class