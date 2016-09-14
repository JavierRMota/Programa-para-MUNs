Imports System.Windows.Forms

Public Class TimeDSL
    Dim ll As Integer
    Dim ss As Integer
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delegt.Click
        Delgt.ShowDialog()
        If Delgt.DialogResult = Windows.Forms.DialogResult.OK Then
            Main.State.Text = "Time Yielded to a Delegate"
            Main.Time.Enabled = True
        End If
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chair.Click
        Me.Close()
        Main.counterd.Text = Main.SLT.Text
        Admin.Minutes.Text = Int(Main.counterd.Text / 60)
        Admin.Seconds.Text = Main.counterd.Text Mod 60
        Main.Minutes.Text = Int(Main.counterd.Text / 60)
        Main.Seconds.Text = Main.counterd.Text Mod 60
        ss = Len(Admin.Seconds.Text)
        ll = Len(Admin.Minutes.Text)
        If ll < 2 Then
            Main.Minutes.Text = "0" & Admin.Minutes.Text
            Admin.Minutes.Text = "0" & Admin.Minutes.Text
        End If
        If ss < 2 Then
            Main.Seconds.Text = "0" & Admin.Seconds.Text
            Admin.Seconds.Text = "0" & Admin.Seconds.Text
        End If
       
    End Sub

    Private Sub Questions_Click(sender As Object, e As EventArgs) Handles Questions.Click
        Main.State.Text = "Time Yielded to Questions"
        Main.Time.Enabled = True
        Me.Close()
    End Sub

    Private Sub Coments_Click(sender As Object, e As EventArgs) Handles Coments.Click
        Main.State.Text = "Time Yielded to Coments"
        Main.Time.Enabled = True
        Me.Close()
    End Sub

End Class
