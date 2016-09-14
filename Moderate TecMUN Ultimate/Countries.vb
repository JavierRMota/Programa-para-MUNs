Public Class Countries

    Private Sub Countries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Main.BackgroundImage
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub
    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        Dim RM As String
        RM = ListBox1.SelectedItem.ToString
        Admin.Add.Items.Remove(RM)
        Quest.Add.Items.Remove(RM)
        ListBox1.Items.Remove(ListBox1.SelectedItem)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(ComboBox1.Text)
        Admin.Add.Items.Add(ComboBox1.Text)
        Quest.Add.Items.Add(ComboBox1.Text)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class