Public Class VentanaDeJuego

    Dim Derecha As Boolean
    Dim Izquierda As Boolean
    Dim enemigos(150) As PictureBox
    Dim direccionEnemigo As Integer = 3
    'Dim enemigos((listaEneImagen.Count)) As PictureBox



    Public Sub RecibirDatos(ByVal ifondo As Integer, ByVal inave As Integer)

        Dim RutaNave As String = listaNavImagen.Item(inave).ToString()
        'MsgBox("ruta nave " + RutaNave)
        Dim rutaFondo As String = listaEscFondo.Item(ifondo).ToString
        Dim sonidoFondo As String = listaEscSonido.Item(ifondo).ToString

        Me.BackgroundImage = Image.FromFile(rutaFondo)
        Me.BackgroundImageLayout = ImageLayout.Stretch

        ReproducirMusicaDeFondo(sonidoFondo)

        imgNave.Image = Image.FromFile(RutaNave)
        imgNave.SizeMode = PictureBoxSizeMode.StretchImage
        imgNave.BringToFront()

        MostrarEnemigos()

        MoverNave.Enabled = True
        MoverNave.Start()





    End Sub


    Private Sub MoverNave_Tick(sender As Object, e As EventArgs) Handles MoverNave.Tick
        If Izquierda = True Then
            imgNave.Left = imgNave.Left - 10
        End If
        If Derecha = True Then
            imgNave.Left = imgNave.Left + 10
        End If
        MoverEnemigos()
    End Sub


    Private Sub MoverEnemigos()

        For i As Integer = 0 To 5
            enemigos(i).Left = enemigos(i).Left + direccionEnemigo
        Next
        If enemigos(5).Left > Me.Width - enemigos(5).Width Then
            direccionEnemigo = direccionEnemigo * -1
            For j As Integer = 0 To 5
                enemigos(j).Top = enemigos(j).Top + 30
            Next
        End If
        If enemigos(0).Left < 0 Then
            direccionEnemigo = direccionEnemigo * -1
            For l As Integer = 0 To 5
                enemigos(l).Top = enemigos(l).Top + 30
            Next
        End If


    End Sub

    Private Sub MostrarEnemigos()
        Dim x As Integer = 30
        Dim y As Integer = 50
        Dim pos As Integer

        Dim listRdm As New List(Of Integer)

        listRdm = ListaAleatoria()

        Try
            For i As Integer = 0 To 5
                enemigos(i) = New PictureBox
                pos = listRdm(i)
                enemigos(i).Image = Image.FromFile(listaEneImagen.Item(pos))
                enemigos(i).Size = New Size(50, 50)
                enemigos(i).SizeMode = PictureBoxSizeMode.StretchImage
                enemigos(i).Location = New Point(x, y)
                enemigos(i).BringToFront()

                Me.Controls.Add(enemigos(i))
                x = x + 100

                If x > 600 Then
                    x = 30
                    y = y + 100
                End If
            Next
        Catch ex As Exception
            MsgBox("No se encontro la imagen de un enemigo")
        End Try



    End Sub

    Private Function ListaAleatoria() As List(Of Integer)
        Dim lista As New List(Of Integer)

        Dim datoRandom, datos As Integer
        datos = listaEneImagen.Count - 1
        Dim numAleatorio As New Random()
        For k As Integer = 0 To 5
            datoRandom = numAleatorio.Next(0, datos)
            lista.Add(datoRandom)
        Next
        'MsgBox("mis aleatorios " + lista(0).ToString + " " + lista(1).ToString + " " + lista(2).ToString + " " + lista(3).ToString + " " + lista(4).ToString + " " + lista(5).ToString)
        Return lista
    End Function


    Private Sub MoverJugador(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.Left Then
            Izquierda = True
        End If
        If e.KeyValue = Keys.Right Then
            Derecha = True
        End If
    End Sub

    Private Sub PararMovimiento(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Left Then
            Izquierda = False
        End If
        If e.KeyValue = Keys.Right Then
            Derecha = False
        End If
    End Sub


    Sub ReproducirMusicaDeFondo(ByVal sonidoruta As String)
        My.Computer.Audio.Play(sonidoruta, AudioPlayMode.Background)
    End Sub

    Sub PararMusicaDeFondo()
        My.Computer.Audio.Stop()
    End Sub



End Class