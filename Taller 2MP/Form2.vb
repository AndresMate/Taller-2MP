Public Class Form2

    Dim posInicialXPuntero, posIniciaYPuntero As Integer
    Dim coordenadaInicialXBaseball, coordenadaInicialYBaseball As Integer
    Dim v0x, v0y, X, Y, t, x0, y0, g, vx, vy As Double
    Dim deltaCooX, deltaCooY As Integer
    Dim contador As Integer = 0
    Dim rebotes As Integer = 0
    Const maxRebotes As Integer = 2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        coordenadaInicialXBaseball = Baseball.Location.X
        coordenadaInicialYBaseball = Baseball.Location.Y
        g = 9.81
        t = 0
        Suelo.Location = Form1.Suelo.Location
        Suelo.Size = Form1.Suelo.Size
        Torre.Location = Form1.Torre.Location
        Torre.Size = Form1.Torre.Size
        Guante.Location = Form1.Guante.Location
        Guante.Size = Form1.Guante.Size

        Form3.Show()
        Form3.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' Muestra las variables si es necesario.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        Form3.Close()
        Form1.Show()
    End Sub

    Private Sub Baseball_MouseDown(sender As Object, e As MouseEventArgs) Handles Baseball.MouseDown
        If e.Button = MouseButtons.Left Then
            posInicialXPuntero = e.X
            posIniciaYPuntero = e.Y
        End If
    End Sub

    Private Sub Baseball_MouseMove(sender As Object, e As MouseEventArgs) Handles Baseball.MouseMove
        Dim nuevaCooX, nuevaCooY As Integer
        If e.Button = MouseButtons.Left Then
            nuevaCooX = Baseball.Location.X + e.X - posInicialXPuntero
            nuevaCooY = Baseball.Location.Y + e.Y - posIniciaYPuntero
            Baseball.Location = New Point(nuevaCooX, nuevaCooY)
            deltaCooX = Baseball.Location.X - coordenadaInicialXBaseball
            deltaCooY = coordenadaInicialYBaseball - Baseball.Location.Y
        End If
    End Sub

    Private Sub Baseball_MouseUp(sender As Object, e As MouseEventArgs) Handles Baseball.MouseUp
        If e.Button = MouseButtons.Left Then
            ' Ajustar las coordenadas iniciales para que reflejen la posición desde donde se suelta la pelota.
            x0 = 0 ' Comenzamos desde el punto de lanzamiento en x.
            y0 = Suelo.Location.Y - Baseball.Location.Y - Baseball.Height ' Altura relativa al suelo.
            v0x = deltaCooX
            v0y = deltaCooY

            ' Desactivar el temporizador de arrastre y activar el movimiento.
            Timer2.Enabled = False
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        contador += 1
        ' Cálculo de la nueva posición usando las ecuaciones de movimiento.
        Y = -0.5 * t ^ 2 * g + v0y * t + y0
        X = v0x * t + x0
        vx = v0x
        vy = -g * t + v0y

        ' Actualiza la posición de la pelota.
        Baseball.Location = New Point(X + coordenadaInicialXBaseball, Suelo.Location.Y - Y - Baseball.Height)

        ' Actualización de gráficos y tabla de datos.
        Form3.DataGridView1.Rows.Add(contador, Math.Round(t, 1), Math.Round(X, 2), Math.Round(Y, 2),
                                     "(" & Math.Round(X, 2) & "," & Math.Round(Y, 2) & ")",
                                     Math.Round(vx, 2), Math.Round(vy, 2))
        Form3.Chart1.Series(0).Points.AddXY(t, Y)
        Form3.Chart1.Series(1).Points.AddXY(t, vy)
        Form3.Chart2.Series(0).Points.AddXY(t, X)
        Form3.Chart2.Series(1).Points.AddXY(t, vx)
        Form3.Chart3.Series(0).Points.AddXY(X, Y)

        t += 0.1

        ' Verificar colisión con el suelo para los rebotes.
        If Baseball.Bounds.IntersectsWith(Suelo.Bounds) Then
            ' Asegurar que la pelota no atraviese el suelo.
            Baseball.Location = New Point(Baseball.Location.X, Suelo.Location.Y - Baseball.Height)

            If rebotes < maxRebotes Then
                ' Invertir la velocidad vertical y reducirla para el rebote.
                v0y = Math.Abs(vy * 0.8) ' Usa el valor absoluto para asegurar que la velocidad sea positiva hacia arriba.
                v0x *= 0.8 ' Reduce la velocidad horizontal a un 80%.

                ' Ajustar la posición inicial para continuar desde la altura actual.
                y0 = 0 ' El nuevo rebote comienza desde el suelo.
                x0 = Baseball.Location.X - coordenadaInicialXBaseball ' Actualizar x0 a la posición actual.
                t = 0
                rebotes += 1
            Else
                ' Detener el movimiento después de los rebotes permitidos.
                MensajeLabel.Text = "La pelota ha terminado su movimiento"
                Timer1.Enabled = False
            End If
        End If

        ' Verificar colisión con la torre y el guante.
        If Baseball.Bounds.IntersectsWith(Torre.Bounds) Then
            MensajeLabel.Text = "La atrapó el equipo rival"
            Timer1.Enabled = False
        End If

        If Baseball.Bounds.IntersectsWith(Guante.Bounds) Then
            MensajeLabel.Text = "¡Atrapada!"
            Explosion.Location = Baseball.Location
            Baseball.Visible = False
            Explosion.Visible = True
            Timer1.Enabled = False
        End If
    End Sub


End Class
