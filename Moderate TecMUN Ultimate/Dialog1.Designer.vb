<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeDSL
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimeDSL))
        Me.delegt = New System.Windows.Forms.Button()
        Me.Chair = New System.Windows.Forms.Button()
        Me.Questions = New System.Windows.Forms.Button()
        Me.Coments = New System.Windows.Forms.Button()
        Me.Logo = New System.Windows.Forms.PictureBox()
        Me.Message = New System.Windows.Forms.Label()
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'delegt
        '
        Me.delegt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.delegt.Location = New System.Drawing.Point(24, 79)
        Me.delegt.Name = "delegt"
        Me.delegt.Size = New System.Drawing.Size(89, 59)
        Me.delegt.TabIndex = 0
        Me.delegt.Text = "Delegate"
        '
        'Chair
        '
        Me.Chair.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Chair.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Chair.Location = New System.Drawing.Point(119, 79)
        Me.Chair.Name = "Chair"
        Me.Chair.Size = New System.Drawing.Size(89, 59)
        Me.Chair.TabIndex = 1
        Me.Chair.Text = "Chair"
        '
        'Questions
        '
        Me.Questions.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Questions.Location = New System.Drawing.Point(312, 80)
        Me.Questions.Name = "Questions"
        Me.Questions.Size = New System.Drawing.Size(92, 58)
        Me.Questions.TabIndex = 2
        Me.Questions.Text = "Questions"
        '
        'Coments
        '
        Me.Coments.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Coments.Location = New System.Drawing.Point(214, 79)
        Me.Coments.Name = "Coments"
        Me.Coments.Size = New System.Drawing.Size(92, 58)
        Me.Coments.TabIndex = 3
        Me.Coments.Text = "Coments"
        '
        'Logo
        '
        Me.Logo.BackgroundImage = CType(resources.GetObject("Logo.BackgroundImage"), System.Drawing.Image)
        Me.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Logo.Location = New System.Drawing.Point(410, 77)
        Me.Logo.Name = "Logo"
        Me.Logo.Size = New System.Drawing.Size(79, 75)
        Me.Logo.TabIndex = 4
        Me.Logo.TabStop = False
        '
        'Message
        '
        Me.Message.AutoSize = True
        Me.Message.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Message.Location = New System.Drawing.Point(18, 23)
        Me.Message.Name = "Message"
        Me.Message.Size = New System.Drawing.Size(345, 33)
        Me.Message.TabIndex = 5
        Me.Message.Text = "There is time remaining"
        '
        'TimeDSL
        '
        Me.AcceptButton = Me.delegt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.Chair
        Me.ClientSize = New System.Drawing.Size(489, 150)
        Me.Controls.Add(Me.Message)
        Me.Controls.Add(Me.Logo)
        Me.Controls.Add(Me.Coments)
        Me.Controls.Add(Me.Questions)
        Me.Controls.Add(Me.Chair)
        Me.Controls.Add(Me.delegt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TimeDSL"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Time Remaining"
        CType(Me.Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents delegt As System.Windows.Forms.Button
    Friend WithEvents Chair As System.Windows.Forms.Button
    Friend WithEvents Questions As System.Windows.Forms.Button
    Friend WithEvents Coments As System.Windows.Forms.Button
    Friend WithEvents Logo As System.Windows.Forms.PictureBox
    Friend WithEvents Message As System.Windows.Forms.Label

End Class
