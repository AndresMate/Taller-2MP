<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Torre = New System.Windows.Forms.PictureBox()
        Me.Guante = New System.Windows.Forms.PictureBox()
        Me.Explosion = New System.Windows.Forms.PictureBox()
        Me.Baseball = New System.Windows.Forms.PictureBox()
        Me.Suelo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MensajeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Baseball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Torre
        '
        Me.Torre.Image = CType(resources.GetObject("Torre.Image"), System.Drawing.Image)
        Me.Torre.Location = New System.Drawing.Point(457, 275)
        Me.Torre.Margin = New System.Windows.Forms.Padding(2)
        Me.Torre.Name = "Torre"
        Me.Torre.Size = New System.Drawing.Size(93, 133)
        Me.Torre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Torre.TabIndex = 0
        Me.Torre.TabStop = False
        '
        'Guante
        '
        Me.Guante.Image = CType(resources.GetObject("Guante.Image"), System.Drawing.Image)
        Me.Guante.Location = New System.Drawing.Point(815, 131)
        Me.Guante.Margin = New System.Windows.Forms.Padding(2)
        Me.Guante.Name = "Guante"
        Me.Guante.Size = New System.Drawing.Size(77, 99)
        Me.Guante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guante.TabIndex = 1
        Me.Guante.TabStop = False
        '
        'Explosion
        '
        Me.Explosion.Image = CType(resources.GetObject("Explosion.Image"), System.Drawing.Image)
        Me.Explosion.Location = New System.Drawing.Point(1017, 209)
        Me.Explosion.Margin = New System.Windows.Forms.Padding(2)
        Me.Explosion.Name = "Explosion"
        Me.Explosion.Size = New System.Drawing.Size(106, 111)
        Me.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Explosion.TabIndex = 2
        Me.Explosion.TabStop = False
        '
        'Baseball
        '
        Me.Baseball.Image = CType(resources.GetObject("Baseball.Image"), System.Drawing.Image)
        Me.Baseball.Location = New System.Drawing.Point(150, 225)
        Me.Baseball.Margin = New System.Windows.Forms.Padding(2)
        Me.Baseball.Name = "Baseball"
        Me.Baseball.Size = New System.Drawing.Size(33, 37)
        Me.Baseball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Baseball.TabIndex = 3
        Me.Baseball.TabStop = False
        '
        'Suelo
        '
        Me.Suelo.Location = New System.Drawing.Point(333, 479)
        Me.Suelo.Margin = New System.Windows.Forms.Padding(2)
        Me.Suelo.Name = "Suelo"
        Me.Suelo.Size = New System.Drawing.Size(159, 50)
        Me.Suelo.TabIndex = 4
        Me.Suelo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(939, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 38)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Reiniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MensajeLabel
        '
        Me.MensajeLabel.AutoSize = True
        Me.MensajeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MensajeLabel.Location = New System.Drawing.Point(145, 32)
        Me.MensajeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MensajeLabel.Name = "MensajeLabel"
        Me.MensajeLabel.Size = New System.Drawing.Size(71, 25)
        Me.MensajeLabel.TabIndex = 6
        Me.MensajeLabel.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(452, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Andres Mateus Dilan Bohorquez"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1155, 629)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MensajeLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Suelo)
        Me.Controls.Add(Me.Baseball)
        Me.Controls.Add(Me.Explosion)
        Me.Controls.Add(Me.Guante)
        Me.Controls.Add(Me.Torre)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Baseball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Torre As PictureBox
    Friend WithEvents Guante As PictureBox
    Friend WithEvents Explosion As PictureBox
    Friend WithEvents Baseball As PictureBox
    Friend WithEvents Suelo As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents MensajeLabel As Label
    Friend WithEvents Label1 As Label
End Class
