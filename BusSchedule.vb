Public Class BusSchedule
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub BusSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Kuala Lumpur")
        ListBox1.Items.Add("Selangor")
        ListBox1.Items.Add("Ipoh")
        ListBox1.Items.Add("Penang")
        ListBox1.Items.Add("Perlis")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm5 As New AboutUS
        MyForm5.Show()
        Me.Hide()
    End Sub
End Class