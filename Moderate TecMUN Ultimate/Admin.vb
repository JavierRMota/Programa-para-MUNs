Imports System
Imports System.Xml

Public Class Admin
    Dim ll As Integer
    Dim ss As Integer
    Dim listaa As Integer
    Private Sub SLtime_Click(sender As Object, e As EventArgs) Handles SLtime.Click
        If SecondsB.Text = "" Then
            SecondsB.Text = "0"
        End If
        If MinutesB.Text = "" Then
            MinutesB.Text = "0"
        End If
        Main.Seconds.Text = SecondsB.Text
        Main.Minutes.Text = MinutesB.Text
        Main.counterd.Text = MinutesB.Text * 60 + SecondsB.Text
        Main.SLT.Text = MinutesB.Text * 60 + SecondsB.Text
        Seconds.Text = SecondsB.Text
        Minutes.Text = MinutesB.Text

        ss = Len(SecondsB.Text)
        ll = Len(MinutesB.Text)
        If ll < 2 Then
            Main.Minutes.Text = "0" & MinutesB.Text
            Minutes.Text = "0" & MinutesB.Text
        End If
        If ss < 2 Then
            Main.Seconds.Text = "0" & SecondsB.Text
            Seconds.Text = "0" & SecondsB.Text
        End If
    End Sub


    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Main.Time.Enabled = False Then
            Start.Text = "Stop"
            Main.Time.Enabled = True
            Main.NowSpeaking.Show()
            listaa = SL.Items.Count()
            If listaa > 0 Then
                Main.NSL.Text = SL.Items.Item(0)
                Main.flag.BackgroundImage = Main.Flags.Images(Main.NSL.Text & ".png")
                Main.flag.BackgroundImageLayout = ImageLayout.Center
            Else : Main.NSL.Text = ""
            End If
            listaa = SL.Items.Count()
            If listaa > 0 Then
                Main.NS1L.Text = SL.Items.Item(0)
            Else : Main.NS1L.Text = ""
            End If
            If listaa > 1 Then
                Main.NS2L.Text = SL.Items.Item(1)
            Else : Main.NS2L.Text = ""
            End If
            If listaa > 2 Then
                Main.NS3L.Text = SL.Items.Item(2)
            Else : Main.NS3L.Text = ""
            End If

        ElseIf Main.Time.Enabled = True Then
            Main.Time.Enabled = False
            Start.Text = "Start"
            Main.NowSpeaking.Hide()
            TimeDSL.ShowDialog()
        End If


    End Sub

    Private Sub Stp_Click(sender As Object, e As EventArgs) Handles Rset.Click
        Main.counterd.Text = Main.SLT.Text
        Minutes.Text = Int(Main.SLT.Text / 60)
        Seconds.Text = Main.SLT.Text Mod 60
        Main.Minutes.Text = Int(Main.SLT.Text / 60)
        Main.Seconds.Text = Main.SLT.Text Mod 60
        Main.NextSpeaker.Show()
        Main.Minutes.Show()
        Main.Seconds.Show()
        Main.Dots.Show()
        Main.Question1.Hide()
        Main.Question2.Hide()
        Main.Question3.Hide()
        Main.Question4.Hide()
        Main.Question5.Hide()
        Main.Question1.Text = ""
        Main.Question2.Text = ""
        Main.Question3.Text = ""
        Main.Question4.Text = ""
        Main.Question5.Text = ""
        listaa = SL.Items.Count()
        If listaa > 0 Then
            Main.NS1L.Text = SL.Items.Item(0)
        Else : Main.NS1L.Text = ""
        End If
        If listaa > 1 Then
            Main.NS2L.Text = SL.Items.Item(1)
        Else : Main.NS2L.Text = ""
        End If
        If listaa > 2 Then
            Main.NS3L.Text = SL.Items.Item(2)
        Else : Main.NS3L.Text = ""
        End If


        ss = Len(Seconds.Text)
        ll = Len(Minutes.Text)
        If ll < 2 Then
            Main.Minutes.Text = "0" & Minutes.Text
            Minutes.Text = "0" & Minutes.Text
        End If
        If ss < 2 Then
            Main.Seconds.Text = "0" & Seconds.Text
            Seconds.Text = "0" & Seconds.Text
        End If
        Main.State.Text = "Speaker's List"
        Start.Enabled = True
        Main.Time.Enabled = False
    End Sub

    Private Sub ModerateC_Click(sender As Object, e As EventArgs) Handles ModerateC.Click
        If SecondsB.Text = "" Then
            SecondsB.Text = "0"
        End If
        If MinutesB.Text = "" Then
            MinutesB.Text = "0"
        End If
        Main.State.Text = "Moderated Caucus"
        Main.Seconds.Text = SecondsB.Text
        Main.Minutes.Text = MinutesB.Text
        Main.counterd.Text = MinutesB.Text * 60 + SecondsB.Text
        Seconds.Text = SecondsB.Text
        Minutes.Text = MinutesB.Text
        Main.NowSpeaking.Hide()
        Main.NextSpeaker.Hide()
        Main.Question1.Hide()
        Main.Question2.Hide()
        Main.Question3.Hide()
        Main.Question4.Hide()
        Main.Question5.Hide()
        Main.Question1.Text = ""
        Main.Question2.Text = ""
        Main.Question3.Text = ""
        Main.Question4.Text = ""
        Main.Question5.Text = ""

        ss = Len(SecondsB.Text)
        ll = Len(MinutesB.Text)
        If ll < 2 Then
            Main.Minutes.Text = "0" & MinutesB.Text
            Minutes.Text = "0" & MinutesB.Text
        End If
        If ss < 2 Then
            Main.Seconds.Text = "0" & SecondsB.Text
            Seconds.Text = "0" & SecondsB.Text
        End If
        Main.Time.Enabled = True
        Start.Enabled = False
    End Sub

    Private Sub SimpleC_Click(sender As Object, e As EventArgs) Handles SimpleC.Click
        If SecondsB.Text = "" Then
            SecondsB.Text = "0"
        End If
        If MinutesB.Text = "" Then
            MinutesB.Text = "0"
        End If
        Main.State.Text = "Simple Caucus"
        Main.Seconds.Text = SecondsB.Text
        Main.Minutes.Text = MinutesB.Text
        Main.counterd.Text = MinutesB.Text * 60 + SecondsB.Text
        Main.NowSpeaking.Hide()
        Main.NextSpeaker.Hide()
        Main.Question1.Hide()
        Main.Question2.Hide()
        Main.Question3.Hide()
        Main.Question4.Hide()
        Main.Question5.Hide()
        Main.Question1.Text = ""
        Main.Question2.Text = ""
        Main.Question3.Text = ""
        Main.Question4.Text = ""
        Main.Question5.Text = ""
        Seconds.Text = SecondsB.Text
        Minutes.Text = MinutesB.Text

        ss = Len(SecondsB.Text)
        ll = Len(MinutesB.Text)
        If ll < 2 Then
            Main.Minutes.Text = "0" & MinutesB.Text
            Minutes.Text = "0" & MinutesB.Text
        End If
        If ss < 2 Then
            Main.Seconds.Text = "0" & SecondsB.Text
            Seconds.Text = "0" & SecondsB.Text
        End If
        Main.Time.Enabled = True
        Start.Enabled = False
    End Sub


    Private Sub SpeakersB_Click(sender As Object, e As EventArgs) Handles SpeakersB.Click
        SL.Items.Add(Add.Text)
        listaa = SL.Items.Count()
        If listaa > 0 Then
            Main.NS1L.Text = SL.Items.Item(0)
        Else : Main.NS1L.Text = ""
        End If
        If listaa > 1 Then
            Main.NS2L.Text = SL.Items.Item(1)
        Else : Main.NS2L.Text = ""
        End If
        If listaa > 2 Then
            Main.NS3L.Text = SL.Items.Item(2)
        Else : Main.NS3L.Text = ""
        End If
    End Sub

    Private Sub WarningB_Click(sender As Object, e As EventArgs) Handles WarningB.Click
        Warnings.Items.Add(Add.Text)
    End Sub

    Private Sub RemoveB_Click(sender As Object, e As EventArgs) Handles RemoveB.Click
        SL.Items.Remove(SL.SelectedItem)
        Warnings.Items.Remove(Warnings.SelectedItem)
        listaa = SL.Items.Count()
        If listaa > 0 Then
            Main.NS1L.Text = SL.Items.Item(0)
        Else : Main.NS1L.Text = ""
        End If
        If listaa > 1 Then
            Main.NS2L.Text = SL.Items.Item(1)
        Else : Main.NS2L.Text = ""
        End If
        If listaa > 2 Then
            Main.NS3L.Text = SL.Items.Item(2)
        Else : Main.NS3L.Text = ""
        End If
    End Sub

    Private Sub SaveStateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveStateToolStripMenuItem.Click
        My.Settings.info = Main.SLT.Text()
        My.Settings.info5 = Main.Committee.Text
        My.Settings.info2 = Info.TextBox2.Text
        My.Settings.info3 = Info.TextBox4.Text
        My.Settings.info4 = Info.TextBox3.Text
        My.Settings.SP = New ArrayList(SL.Items)
        My.Settings.WA = New ArrayList(Warnings.Items)
        My.Settings.Countries = New ArrayList(Countries.ListBox1.Items)
        My.Settings.Save()
    End Sub

    Private Sub CountryListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CountryListToolStripMenuItem.Click
        Countries.Show()
    End Sub

    Private Sub StateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StateToolStripMenuItem.Click
        Me.SL.Items.AddRange(My.Settings.SP.ToArray())
        Me.Warnings.Items.AddRange(My.Settings.WA.ToArray())
        Countries.ListBox1.Items.AddRange(My.Settings.Countries.ToArray())
        Me.Add.Items.AddRange(My.Settings.Countries.ToArray())
        Quest.Add.Items.AddRange(My.Settings.Countries.ToArray())
        Main.Committee.Text = My.Settings.info5
        Main.Topic.Text = "Topic: " & My.Settings.info2
        Main.President.Text = "President: " & My.Settings.info3
        Info.TextBox1.Text = My.Settings.info5
        Info.TextBox2.Text = My.Settings.info2
        Info.TextBox3.Text = My.Settings.info4
        Info.TextBox4.Text = My.Settings.info3
        Main.SLT.Text = My.Settings.info
        listaa = SL.Items.Count()
        If listaa > 0 Then
            Main.NS1L.Text = SL.Items.Item(0)
        Else : Main.NS1L.Text = ""
        End If
        If listaa > 1 Then
            Main.NS2L.Text = SL.Items.Item(1)
        Else : Main.NS2L.Text = ""
        End If
        If listaa > 2 Then
            Main.NS3L.Text = SL.Items.Item(2)
        Else : Main.NS3L.Text = ""
        End If
        If listaa > 3 Then
            Main.SO4.Text = SL.Items.Item(3)
        Else : Main.SO4.Text = ""
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Main.Topic.Text = "Topic: " & Info.TextBox2.Text Then
            Main.Topic.Text = "Topic: " & Info.TextBox3.Text
        ElseIf Main.Topic.Text = "Topic: " & Info.TextBox3.Text Then
            Main.Topic.Text = "Topic: " & Info.TextBox2.Text
        End If
        If Topic.Text = "Topic: " & Info.TextBox2.Text Then
            Topic.Text = "Topic: " & Info.TextBox3.Text
        ElseIf Topic.Text = "Topic: " & Info.TextBox3.Text Then
            Topic.Text = "Topic: " & Info.TextBox2.Text
        End If
    End Sub

    Private Sub TopicsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopicsToolStripMenuItem.Click
        Info.Show()

    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click
        If Main.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Else
            Main.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Main.WindowState = FormWindowState.Maximized
        End If
        
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutMOTA.Show()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Main.BackgroundImage

    End Sub

    Private Sub Questions_Click(sender As Object, e As EventArgs) Handles Questions.Click
        Main.State.Text = "Extraordinary Session of Questions"
        Main.NowSpeaking.Hide()
        Main.NextSpeaker.Hide()
        Main.Minutes.Hide()
        Main.Seconds.Hide()
        Main.Dots.Hide()
        Quest.Show()
    End Sub

    Private Sub TwoScreensToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TwoScreensToolStripMenuItem.Click
        Main.Show()

    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        Else
            Main.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)

        End If
        Main.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackgroundImage = Main.BackgroundImage
    End Sub


End Class