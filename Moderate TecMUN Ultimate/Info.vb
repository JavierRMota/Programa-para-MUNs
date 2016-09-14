Public Class Info

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        Main.President.Text = "President: " & TextBox4.Text
        Main.Committee.Text = TextBox1.Text
        Main.Topic.Text = "Topic: " & TextBox2.Text
        Admin.President.Text = "President: " & TextBox4.Text
        Admin.Committee.Text = TextBox1.Text
        Admin.Topic.Text = "Topic: " & TextBox2.Text
        Me.Hide()
    End Sub

    Private Sub Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Main.BackgroundImage

    End Sub
End Class