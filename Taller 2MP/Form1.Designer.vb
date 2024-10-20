<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Torre = New System.Windows.Forms.PictureBox()
        Me.Guante = New System.Windows.Forms.PictureBox()
        Me.Suelo = New System.Windows.Forms.PictureBox()
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guante, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Torre
        '
        Me.Torre.Image = CType(resources.GetObject("Torre.Image"), System.Drawing.Image)
        Me.Torre.Location = New System.Drawing.Point(468, 438)
        Me.Torre.Name = "Torre"
        Me.Torre.Size = New System.Drawing.Size(95, 126)
        Me.Torre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Torre.TabIndex = 0
        Me.Torre.TabStop = False
        '
        'Guante
        '
        Me.Guante.AccessibleName = ""
        Me.Guante.Image = CType(resources.GetObject("Guante.Image"), System.Drawing.Image)
        Me.Guante.Location = New System.Drawing.Point(795, 451)
        Me.Guante.Name = "Guante"
        Me.Guante.Size = New System.Drawing.Size(75, 81)
        Me.Guante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guante.TabIndex = 1
        Me.Guante.TabStop = False
        '
        'Suelo
        '
        Me.Suelo.Location = New System.Drawing.Point(-38, 583)
        Me.Suelo.Name = "Suelo"
        Me.Suelo.Size = New System.Drawing.Size(1181, 50)
        Me.Suelo.TabIndex = 2
        Me.Suelo.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(988, 629)
        Me.Controls.Add(Me.Suelo)
        Me.Controls.Add(Me.Guante)
        Me.Controls.Add(Me.Torre)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Torre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guante, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Suelo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Torre As PictureBox
    Friend WithEvents Guante As PictureBox
    Friend WithEvents Suelo As PictureBox
End Class
