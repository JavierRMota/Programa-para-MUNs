Public Class Quest
    Dim listaa As Integer
    Private Sub Quest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Main.BackgroundImage
        Main.Question1.Show()
        Main.Question2.Show()
        Main.Question3.Show()
        Main.Question4.Show()
        Main.Question5.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Delegates.Items.Add(Add.Text)
        listaa = Delegates.Items.Count()
        
        If listaa > 0 Then
            Main.Question1.Text = Delegates.Items.Item(0)
        Else : Main.Question1.Text = ""
        End If
        If listaa > 1 Then
            Main.Question2.Text = Delegates.Items.Item(1)
        Else : Main.Question2.Text = ""
        End If
        If listaa > 2 Then
            Main.Question3.Text = Delegates.Items.Item(2)
        Else : Main.Question3.Text = ""
        End If
        If listaa > 3 Then
            Main.Question4.Text = Delegates.Items.Item(3)
        Else : Main.Question4.Text = ""
        End If
        If listaa > 4 Then
            Main.Question5.Text = Delegates.Items.Item(4)
        Else : Main.Question5.Text = ""
        End If

    End Sub

    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
        Delegates.Items.RemoveAt(0)
        listaa = Delegates.Items.Count()
        If listaa > 0 Then
            Main.Question1.Text = Delegates.Items.Item(0)
        Else : Main.Question1.Text = ""
        End If
        If listaa > 1 Then
            Main.Question2.Text = Delegates.Items.Item(1)
        Else : Main.Question2.Text = ""
        End If
        If listaa > 2 Then
            Main.Question3.Text = Delegates.Items.Item(2)
        Else : Main.Question3.Text = ""
        End If
        If listaa > 3 Then
            Main.Question4.Text = Delegates.Items.Item(3)
        Else : Main.Question4.Text = ""
        End If
        If listaa > 4 Then
            Main.Question5.Text = Delegates.Items.Item(4)
        Else : Main.Question5.Text = ""
        End If
    End Sub
End Class