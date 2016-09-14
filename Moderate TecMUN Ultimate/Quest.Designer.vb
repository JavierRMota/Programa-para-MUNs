<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quest))
        Me.Add = New System.Windows.Forms.ComboBox()
        Me.Delegates = New System.Windows.Forms.ListBox()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Add
        '
        Me.Add.FormattingEnabled = True
        Me.Add.Location = New System.Drawing.Point(12, 17)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(398, 21)
        Me.Add.TabIndex = 7
        '
        'Delegates
        '
        Me.Delegates.FormattingEnabled = True
        Me.Delegates.Location = New System.Drawing.Point(12, 47)
        Me.Delegates.Name = "Delegates"
        Me.Delegates.Size = New System.Drawing.Size(398, 147)
        Me.Delegates.TabIndex = 6
        '
        'Remove
        '
        Me.Remove.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Remove.Location = New System.Drawing.Point(416, 47)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(24, 147)
        Me.Remove.TabIndex = 15
        Me.Remove.Text = "-"
        Me.Remove.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(416, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(26, 24)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Quest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 225)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Delegates)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Quest"
        Me.Text = "Extraordinary Session of Questions"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Add As System.Windows.Forms.ComboBox
    Friend WithEvents Delegates As System.Windows.Forms.ListBox
    Friend WithEvents Remove As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
