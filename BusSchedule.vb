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


        ListBox2.Items.Add("Kuala Lumpur")
        ListBox2.Items.Add("Selangor")
        ListBox2.Items.Add("Ipoh")
        ListBox2.Items.Add("Penang")
        ListBox2.Items.Add("Perlis")


        ListBox3.Items.Add("ALISAN")
        ListBox3.Items.Add("ARWAN")
        ListBox3.Items.Add("BILLION STAR")
        ListBox3.Items.Add("CITY EXPRESS")
        ListBox3.Items.Add("FIVE STAR")


        ListBox4.Items.Add("8:00AM")
        ListBox4.Items.Add("10:00AM")
        ListBox4.Items.Add("11:30AM")
        ListBox4.Items.Add("3:00PM")
        ListBox4.Items.Add("6:00PM")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim MyForm5 As New AboutUS
        MyForm5.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyForm5 As New Result
        MyForm5.Show()
        Me.Hide()
    End Sub
End Class