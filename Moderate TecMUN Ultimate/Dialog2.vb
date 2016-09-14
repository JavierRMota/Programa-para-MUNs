Imports System.Windows.Forms

Public Class Delgt

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Admin.Warnings.Items.Add(Main.NSL.Text)
        Main.counterd.Text = Main.SLT.Text
        Admin.Minutes.Text = Int(Main.counterd.Text / 60)
        Admin.Seconds.Text = Main.counterd.Text Mod 60
        Main.Minutes.Text = Int(Main.counterd.Text / 60)
        Main.Seconds.Text = Main.counterd.Text Mod 60
        Me.Close()
    End Sub

End Class
