Public Class Form2

    Dim posInicialXPuntero, posIniciaYPuntero As Integer
    Dim coordenadaInicialXBaseball, coordenadaInicialYBaseball As Integer
    Dim v0x, v0y, X, Y, t, x0, y0, g, vx, vy As Double
    Dim deltaCooX, deltaCooY As Integer
    Dim contador As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Close()
        Form4.Close()
        Form2.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        TablaVariables.Rows.Clear()
        TablaVariables.Rows.Add("posInicialXPuntero", posInicialXPuntero)
        TablaVariables.Rows.Add("posIniciaYPuntero", posIniciaYPuntero)
        TablaVariables.Rows.Add("coordenadaInicialXTejo", coordenadaInicialXBaseball)
        TablaVariables.Rows.Add("coordenadaInicialYTejo", coordenadaInicialYBaseball)
        TablaVariables.Rows.Add("x0", x0)
        TablaVariables.Rows.Add("y0", y0)
        TablaVariables.Rows.Add("v0x", v0x)
        TablaVariables.Rows.Add("v0y", v0y)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador += 1
        Y = -0.5 * t ^ 2 * g + v0y * t + y0
        X = v0x * t + x0
        vx = v0x
        vy = -g * t + v0y
        Baseball.Location = New Point(X + coordenadaInicialXBaseball,
                           coordenadaInicialYBaseball - Y)
        Form4.DataGridView1.Rows.Add(contador, Math.Round(t, 1), Math.Round(X, 2), Math.Round(Y, 2),
                                     "(" & Math.Round(X, 2) & "," & Math.Round(Y, 2) & ")",
                                     Math.Round(vx, 2), Math.Round(vy, 2))
        Form4.Chart1.Series(0).Points.AddXY(t, Y)
        Form4.Chart1.Series(1).Points.AddXY(t, vy)
        Form4.Chart2.Series(0).Points.AddXY(t, X)
        Form4.Chart2.Series(1).Points.AddXY(t, vx)
        Form4.Chart3.Series(0).Points.AddXY(X, Y)
        t += 0.1
        If Baseball.Bounds.IntersectsWith(Suelo.Bounds) Then
            MensajeLabel.Text = "Pendejo, le dió al suelo"
            Timer1.Enabled = False
        End If
        If Baseball.Bounds.IntersectsWith(Torre.Bounds) Then
            MensajeLabel.Text = "Sonso, le dió a la torre"
            Timer1.Enabled = False
        End If
        If Baseball.Bounds.IntersectsWith(Baseball.Bounds) Then
            MensajeLabel.Text = "Mecha!!!!!"
            Explosion.Location = Baseball.Location
            Baseball.Visible = False
            Explosion.Visible = True
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coordenadaInicialXBaseball = Baseball.Location.X
        coordenadaInicialYBaseball = Baseball.Location.Y
        g = 9.81
        t = 0
        Suelo.Location = Form2.Suelo.Location
        Suelo.Size = Form2.Suelo.Size
        Torre.Location = Form2.Torre.Location
        Torre.Size = Form2.Torre.Size
        Baseball.Location = Form2.Baseball.Location
        Baseball.Size = Form2.Baseball.Size

        Form4.Show()
        Form4.WindowState = FormWindowState.Minimized

        Timer2.Enabled = True
    End Sub
End Class