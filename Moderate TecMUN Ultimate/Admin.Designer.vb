<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.SLtime = New System.Windows.Forms.Button()
        Me.ModerateC = New System.Windows.Forms.Button()
        Me.SimpleC = New System.Windows.Forms.Button()
        Me.SL = New System.Windows.Forms.ListBox()
        Me.Warnings = New System.Windows.Forms.ListBox()
        Me.Add = New System.Windows.Forms.ComboBox()
        Me.MinutesB = New System.Windows.Forms.TextBox()
        Me.SecondsB = New System.Windows.Forms.TextBox()
        Me.WarningB = New System.Windows.Forms.Button()
        Me.SpeakersB = New System.Windows.Forms.Button()
        Me.RemoveB = New System.Windows.Forms.Button()
        Me.Seconds = New System.Windows.Forms.Label()
        Me.Dots = New System.Windows.Forms.Label()
        Me.Minutes = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.Rset = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PreferencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CountryListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveStateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TwoScreensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Questions = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.President = New System.Windows.Forms.Label()
        Me.Committee = New System.Windows.Forms.Label()
        Me.Topic = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SLtime
        '
        Me.SLtime.Location = New System.Drawing.Point(19, 276)
        Me.SLtime.Name = "SLtime"
        Me.SLtime.Size = New System.Drawing.Size(121, 76)
        Me.SLtime.TabIndex = 0
        Me.SLtime.Text = "Change SL Time"
        Me.SLtime.UseVisualStyleBackColor = True
        '
        'ModerateC
        '
        Me.ModerateC.Location = New System.Drawing.Point(19, 358)
        Me.ModerateC.Name = "ModerateC"
        Me.ModerateC.Size = New System.Drawing.Size(121, 76)
        Me.ModerateC.TabIndex = 1
        Me.ModerateC.Text = "Moderated Caucus"
        Me.ModerateC.UseVisualStyleBackColor = True
        '
        'SimpleC
        '
        Me.SimpleC.Location = New System.Drawing.Point(19, 440)
        Me.SimpleC.Name = "SimpleC"
        Me.SimpleC.Size = New System.Drawing.Size(121, 76)
        Me.SimpleC.TabIndex = 2
        Me.SimpleC.Text = "Simple Caucus"
        Me.SimpleC.UseVisualStyleBackColor = True
        '
        'SL
        '
        Me.SL.FormattingEnabled = True
        Me.SL.Location = New System.Drawing.Point(162, 251)
        Me.SL.Name = "SL"
        Me.SL.Size = New System.Drawing.Size(176, 316)
        Me.SL.TabIndex = 3
        '
        'Warnings
        '
        Me.Warnings.FormattingEnabled = True
        Me.Warnings.Location = New System.Drawing.Point(482, 251)
        Me.Warnings.Name = "Warnings"
        Me.Warnings.Size = New System.Drawing.Size(176, 316)
        Me.Warnings.TabIndex = 4
        '
        'Add
        '
        Me.Add.FormattingEnabled = True
        Me.Add.Location = New System.Drawing.Point(172, 218)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(486, 21)
        Me.Add.TabIndex = 5
        '
        'MinutesB
        '
        Me.MinutesB.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinutesB.Location = New System.Drawing.Point(19, 216)
        Me.MinutesB.Name = "MinutesB"
        Me.MinutesB.Size = New System.Drawing.Size(59, 53)
        Me.MinutesB.TabIndex = 6
        '
        'SecondsB
        '
        Me.SecondsB.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondsB.Location = New System.Drawing.Point(84, 216)
        Me.SecondsB.Name = "SecondsB"
        Me.SecondsB.Size = New System.Drawing.Size(59, 53)
        Me.SecondsB.TabIndex = 7
        '
        'WarningB
        '
        Me.WarningB.Location = New System.Drawing.Point(348, 358)
        Me.WarningB.Name = "WarningB"
        Me.WarningB.Size = New System.Drawing.Size(122, 76)
        Me.WarningB.TabIndex = 8
        Me.WarningB.Text = "Warning"
        Me.WarningB.UseVisualStyleBackColor = True
        '
        'SpeakersB
        '
        Me.SpeakersB.Location = New System.Drawing.Point(348, 276)
        Me.SpeakersB.Name = "SpeakersB"
        Me.SpeakersB.Size = New System.Drawing.Size(122, 76)
        Me.SpeakersB.TabIndex = 9
        Me.SpeakersB.Text = "Speaker's List"
        Me.SpeakersB.UseVisualStyleBackColor = True
        '
        'RemoveB
        '
        Me.RemoveB.Location = New System.Drawing.Point(348, 440)
        Me.RemoveB.Name = "RemoveB"
        Me.RemoveB.Size = New System.Drawing.Size(122, 76)
        Me.RemoveB.TabIndex = 10
        Me.RemoveB.Text = "Remove"
        Me.RemoveB.UseVisualStyleBackColor = True
        '
        'Seconds
        '
        Me.Seconds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Seconds.AutoSize = True
        Me.Seconds.BackColor = System.Drawing.Color.Transparent
        Me.Seconds.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Seconds.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Seconds.Location = New System.Drawing.Point(119, 117)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(103, 78)
        Me.Seconds.TabIndex = 12
        Me.Seconds.Text = "00"
        '
        'Dots
        '
        Me.Dots.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dots.AutoSize = True
        Me.Dots.BackColor = System.Drawing.Color.Transparent
        Me.Dots.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dots.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Dots.Location = New System.Drawing.Point(92, 117)
        Me.Dots.Name = "Dots"
        Me.Dots.Size = New System.Drawing.Size(51, 78)
        Me.Dots.TabIndex = 13
        Me.Dots.Text = ":"
        '
        'Minutes
        '
        Me.Minutes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minutes.AutoSize = True
        Me.Minutes.BackColor = System.Drawing.Color.Transparent
        Me.Minutes.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Minutes.Location = New System.Drawing.Point(10, 117)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(103, 78)
        Me.Minutes.TabIndex = 11
        Me.Minutes.Text = "00"
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(237, 119)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(121, 76)
        Me.Start.TabIndex = 14
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Rset
        '
        Me.Rset.Location = New System.Drawing.Point(364, 119)
        Me.Rset.Name = "Rset"
        Me.Rset.Size = New System.Drawing.Size(121, 76)
        Me.Rset.TabIndex = 15
        Me.Rset.Text = "Reset"
        Me.Rset.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PreferencesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(794, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PreferencesToolStripMenuItem
        '
        Me.PreferencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem, Me.SaveStateToolStripMenuItem, Me.FullScreenToolStripMenuItem, Me.TwoScreensToolStripMenuItem})
        Me.PreferencesToolStripMenuItem.Image = CType(resources.GetObject("PreferencesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PreferencesToolStripMenuItem.Name = "PreferencesToolStripMenuItem"
        Me.PreferencesToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.PreferencesToolStripMenuItem.Text = "Preferences"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CountryListToolStripMenuItem, Me.TopicsToolStripMenuItem, Me.StateToolStripMenuItem, Me.ImageToolStripMenuItem})
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'CountryListToolStripMenuItem
        '
        Me.CountryListToolStripMenuItem.Name = "CountryListToolStripMenuItem"
        Me.CountryListToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.CountryListToolStripMenuItem.Text = "Country List"
        '
        'TopicsToolStripMenuItem
        '
        Me.TopicsToolStripMenuItem.Name = "TopicsToolStripMenuItem"
        Me.TopicsToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.TopicsToolStripMenuItem.Text = "Topics"
        '
        'StateToolStripMenuItem
        '
        Me.StateToolStripMenuItem.Name = "StateToolStripMenuItem"
        Me.StateToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.StateToolStripMenuItem.Text = "State"
        '
        'ImageToolStripMenuItem
        '
        Me.ImageToolStripMenuItem.Name = "ImageToolStripMenuItem"
        Me.ImageToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ImageToolStripMenuItem.Text = "Background"
        '
        'SaveStateToolStripMenuItem
        '
        Me.SaveStateToolStripMenuItem.Name = "SaveStateToolStripMenuItem"
        Me.SaveStateToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveStateToolStripMenuItem.Text = "Save State"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.FullScreenToolStripMenuItem.Text = "Full Screen"
        '
        'TwoScreensToolStripMenuItem
        '
        Me.TwoScreensToolStripMenuItem.Name = "TwoScreensToolStripMenuItem"
        Me.TwoScreensToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.TwoScreensToolStripMenuItem.Text = "Two Screens"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(333, 583)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(152, 25)
        Me.Button4.TabIndex = 39
        Me.Button4.Text = "Change Topic"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Questions
        '
        Me.Questions.Location = New System.Drawing.Point(19, 522)
        Me.Questions.Name = "Questions"
        Me.Questions.Size = New System.Drawing.Size(121, 76)
        Me.Questions.TabIndex = 40
        Me.Questions.Text = "Extraordinary Session of Questions"
        Me.Questions.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'President
        '
        Me.President.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.President.AutoSize = True
        Me.President.BackColor = System.Drawing.Color.Transparent
        Me.President.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.President.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.President.Location = New System.Drawing.Point(43, 87)
        Me.President.Name = "President"
        Me.President.Size = New System.Drawing.Size(0, 20)
        Me.President.TabIndex = 45
        '
        'Committee
        '
        Me.Committee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Committee.AutoSize = True
        Me.Committee.BackColor = System.Drawing.Color.Transparent
        Me.Committee.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Committee.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Committee.Location = New System.Drawing.Point(26, 30)
        Me.Committee.Name = "Committee"
        Me.Committee.Size = New System.Drawing.Size(0, 24)
        Me.Committee.TabIndex = 44
        '
        'Topic
        '
        Me.Topic.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Topic.AutoSize = True
        Me.Topic.BackColor = System.Drawing.Color.Transparent
        Me.Topic.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Topic.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Topic.Location = New System.Drawing.Point(32, 62)
        Me.Topic.Name = "Topic"
        Me.Topic.Size = New System.Drawing.Size(0, 17)
        Me.Topic.TabIndex = 41
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 612)
        Me.Controls.Add(Me.President)
        Me.Controls.Add(Me.Committee)
        Me.Controls.Add(Me.Topic)
        Me.Controls.Add(Me.Questions)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Rset)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Dots)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.RemoveB)
        Me.Controls.Add(Me.SpeakersB)
        Me.Controls.Add(Me.WarningB)
        Me.Controls.Add(Me.SecondsB)
        Me.Controls.Add(Me.MinutesB)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Warnings)
        Me.Controls.Add(Me.SL)
        Me.Controls.Add(Me.SimpleC)
        Me.Controls.Add(Me.ModerateC)
        Me.Controls.Add(Me.SLtime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SLtime As System.Windows.Forms.Button
    Friend WithEvents ModerateC As System.Windows.Forms.Button
    Friend WithEvents SimpleC As System.Windows.Forms.Button
    Friend WithEvents SL As System.Windows.Forms.ListBox
    Friend WithEvents Warnings As System.Windows.Forms.ListBox
    Friend WithEvents Add As System.Windows.Forms.ComboBox
    Friend WithEvents MinutesB As System.Windows.Forms.TextBox
    Friend WithEvents SecondsB As System.Windows.Forms.TextBox
    Friend WithEvents WarningB As System.Windows.Forms.Button
    Friend WithEvents SpeakersB As System.Windows.Forms.Button
    Friend WithEvents RemoveB As System.Windows.Forms.Button
    Friend WithEvents Seconds As System.Windows.Forms.Label
    Friend WithEvents Dots As System.Windows.Forms.Label
    Friend WithEvents Minutes As System.Windows.Forms.Label
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents Rset As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PreferencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CountryListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveStateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents TopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Questions As System.Windows.Forms.Button
    Friend WithEvents TwoScreensToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents President As Label
    Friend WithEvents Committee As Label
    Friend WithEvents Topic As Label
End Class
