Public Class VentanaElegirEscenario

    Dim index As Integer = 0
    Dim iNave As Integer = 0


    Public Sub MostrarPrimero(ByVal i As Integer)

        iNave = i
        Dim ruta0 As String
        ruta0 = listaEscFondo.Item(0)
        'MsgBox(ruta0)
        'Picture.Image = Image.FromFile("C:\Users\estudiante\Pictures\CarpetaPractica\img.jpg")

        Dim exists As Boolean
        exists = IO.File.Exists(ruta0)

        If exists Then
            Picture.SizeMode = PictureBoxSizeMode.StretchImage
            Picture.Image = Image.FromFile(ruta0)
        Else
            MsgBox("No se encuentra la imagen 0 de escenario")
        End If

    End Sub

    Public Sub MostrarSiguienteEscenario(ByVal inext As Integer)

        Dim ruta As String = ""

        Picture.SizeMode = PictureBoxSizeMode.StretchImage

        If inext <= listaEscFondo.Count - 1 Then
            ruta = listaEscFondo.Item(inext)

            'MsgBox(ruta)

            Dim exists As Boolean
            exists = IO.File.Exists(ruta)

            If exists Then
                Picture.SizeMode = PictureBoxSizeMode.StretchImage
                Picture.Image = Image.FromFile(ruta)
            Else
                MsgBox("No se encuentra la imagen de escenario")
            End If

        Else
            index = 0
            MostrarSiguienteEscenario(index)

        End If

    End Sub

    Public Sub MostrarAnteriorEscenario(ByVal ianterior)

        Dim ruta As String = ""
        Picture.SizeMode = PictureBoxSizeMode.StretchImage

        If ianterior >= 0 Then
            ruta = listaEscFondo.Item(ianterior)
            'MsgBox(ruta)

            Dim exists As Boolean
            exists = IO.File.Exists(ruta)

            If exists Then
                Picture.SizeMode = PictureBoxSizeMode.StretchImage
                Picture.Image = Image.FromFile(ruta)
            Else
                MsgBox("No se encuentra la imagen de escenario")
            End If

        Else
            index = listaEscFondo.Count - 1
            MostrarAnteriorEscenario(index)

        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        index = index + 1
        MostrarSiguienteEscenario(index)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        index = index - 1
        MostrarAnteriorEscenario(index)
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        'MsgBox("nave " + iNave.ToString() + " escenario " + index.ToString())
        Dim ventanaJuego As New VentanaDeJuego()
        ventanaJuego.Show()
        ventanaJuego.RecibirDatos(index, iNave)
        Me.Close()


    End Sub
End Class