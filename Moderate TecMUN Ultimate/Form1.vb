Public Class Main
    Dim listaa As Integer
    Dim ll As Integer
    Dim ss As Integer

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        If counterd.Text > 0 Then
            counterd.Text -= 1
            Minutes.Text = Int(counterd.Text / 60)
            Seconds.Text = counterd.Text Mod 60
            Admin.Seconds.Text = Seconds.Text
            Admin.Minutes.Text = Minutes.Text
            If Seconds.Text < 10 Then
                Seconds.Text = "0" & counterd.Text Mod 60
                Admin.Seconds.Text = Seconds.Text
            End If
            If Int(Minutes.Text) < 10 Then
                Minutes.Text = "0" & Int(counterd.Text / 60)
                Admin.Minutes.Text = Minutes.Text
            End If
        End If
        If counterd.Text = 0 Then
            listaa = Admin.SL.Items.Count()
            If listaa > 0 Then
                NS1L.Text = Admin.SL.Items.Item(0)
            Else : NS1L.Text = ""
            End If
            If listaa > 1 Then
                NS2L.Text = Admin.SL.Items.Item(1)
            Else : NS2L.Text = ""
            End If
            If listaa > 2 Then
                NS3L.Text = Admin.SL.Items.Item(2)
            Else : NS3L.Text = ""
            End If
            If listaa > 3 Then
                SO4.Text = Admin.SL.Items.Item(3)
            Else : SO4.Text = ""
            End If
            Admin.Start.Text = "Start"
            State.Text = "Speaker's List"
            NextSpeaker.Show()
            Time.Enabled = False
            counterd.Text = SLT.Text
            Minutes.Text = Int(counterd.Text / 60)
            Seconds.Text = counterd.Text Mod 60
            Admin.Minutes.Text = Int(counterd.Text / 60)
            Admin.Seconds.Text = counterd.Text Mod 60
            NextSpeaker.Show()
            ss = Len(Seconds.Text)
            ll = Len(Minutes.Text)
            If ll < 2 Then
                Admin.Minutes.Text = "0" & Minutes.Text
                Minutes.Text = "0" & Minutes.Text
            End If
            If ss < 2 Then
                Admin.Seconds.Text = "0" & Seconds.Text
                Seconds.Text = "0" & Seconds.Text
            End If
        End If

    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counterd.Hide()
        SLT.Hide()
        Question1.Hide()
        Question2.Hide()
        Question3.Hide()
        Question4.Hide()
        Question5.Hide()
        Question1.Text = ""
        Question2.Text = ""
        Question3.Text = ""
        Question4.Text = ""
        Question5.Text = ""

    End Sub

    Private Sub NextSpeaker_Enter(sender As Object, e As EventArgs) Handles NextSpeaker.Enter

    End Sub
End Class
