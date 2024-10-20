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
        Me.Torre.Location = New System.Drawing.Point(250, 225)
        Me.Torre.Name = "Torre"
        Me.Torre.Size = New System.Drawing.Size(124, 164)
        Me.Torre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Torre.TabIndex = 0
        Me.Torre.TabStop = False
        '
        'Guante
        '
        Me.Guante.Image = CType(resources.GetObject("Guante.Image"), System.Drawing.Image)
        Me.Guante.Location = New System.Drawing.Point(1017, 310)
        Me.Guante.Name = "Guante"
        Me.Guante.Size = New System.Drawing.Size(103, 122)
        Me.Guante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guante.TabIndex = 1
        Me.Guante.TabStop = False
        '
        'Explosion
        '
        Me.Explosion.Image = CType(resources.GetObject("Explosion.Image"), System.Drawing.Image)
        Me.Explosion.Location = New System.Drawing.Point(786, 84)
        Me.Explosion.Name = "Explosion"
        Me.Explosion.Size = New System.Drawing.Size(142, 137)
        Me.Explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Explosion.TabIndex = 2
        Me.Explosion.TabStop = False
        '
        'Baseball
        '
        Me.Baseball.Image = CType(resources.GetObject("Baseball.Image"), System.Drawing.Image)
        Me.Baseball.Location = New System.Drawing.Point(489, 84)
        Me.Baseball.Name = "Baseball"
        Me.Baseball.Size = New System.Drawing.Size(139, 133)
        Me.Baseball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Baseball.TabIndex = 3
        Me.Baseball.TabStop = False
        '
        'Suelo
        '
        Me.Suelo.Location = New System.Drawing.Point(508, 451)
        Me.Suelo.Name = "Suelo"
        Me.Suelo.Size = New System.Drawing.Size(212, 61)
        Me.Suelo.TabIndex = 4
        Me.Suelo.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1252, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Reiniciar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1547, 774)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Suelo)
        Me.Controls.Add(Me.Baseball)
        Me.Controls.Add(Me.Explosion)
        Me.Controls.Add(Me.Guante)
        Me.Controls.Add(Me.Torre)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Explosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Baseball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Torre As PictureBox
    Friend WithEvents Guante As PictureBox
    Friend WithEvents Explosion As PictureBox
    Friend WithEvents Baseball As PictureBox
    Friend WithEvents Suelo As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
End Class
