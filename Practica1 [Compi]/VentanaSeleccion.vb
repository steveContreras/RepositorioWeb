Public Class VentanaSeleccion


    Dim index As Integer = 0


    Public Sub MostrarPrimero()

        Dim ruta0 As String
        ruta0 = listaNavImagen.Item(0)
        'Picture.Image = Image.FromFile("C:\Users\estudiante\Pictures\CarpetaPractica\img.jpg")

        Dim exists As Boolean
        exists = IO.File.Exists(ruta0)

        If exists Then
            Picture.SizeMode = PictureBoxSizeMode.StretchImage
            Picture.Image = Image.FromFile(ruta0)
        Else
            MsgBox("No se encuentra la imagen 0 de nave")
        End If
    End Sub


    Public Sub MostrarSiguienteNave(ByVal inext As Integer)

        Dim ruta As String = ""

        Picture.SizeMode = PictureBoxSizeMode.StretchImage

        If inext <= listaNavImagen.Count - 1 Then
            ruta = listaNavImagen.Item(inext)
            'MsgBox(ruta)

            Dim exists As Boolean
            exists = IO.File.Exists(ruta)

            If exists Then
                Picture.SizeMode = PictureBoxSizeMode.StretchImage
                Picture.Image = Image.FromFile(ruta)
            Else
                MsgBox("No se encuentra la imagen de nave")
            End If

        Else
            index = 0
            MostrarSiguienteNave(index)

        End If

    End Sub


    Public Sub MostrarAnteriorNave(ByVal ianterior)

        Dim ruta As String = ""
        Picture.SizeMode = PictureBoxSizeMode.StretchImage

        If ianterior >= 0 Then
            ruta = listaNavImagen.Item(ianterior)
            'MsgBox(ruta)

            Dim exists As Boolean
            exists = IO.File.Exists(ruta)

            If exists Then
                Picture.SizeMode = PictureBoxSizeMode.StretchImage
                Picture.Image = Image.FromFile(ruta)
            Else
                MsgBox("No se encuentra la imagen de nave")
            End If

        Else
            index = listaNavImagen.Count - 1
            MostrarAnteriorNave(index)

        End If
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        index = index + 1
        MostrarSiguienteNave(index)
    End Sub


    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        index = index - 1
        MostrarAnteriorNave(index)
    End Sub


    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click

        Dim ventanaEscenario As New VentanaElegirEscenario()
        ventanaEscenario.Show()
        ventanaEscenario.MostrarPrimero(index)
        Me.Close()


    End Sub

    Private Sub VentanaSeleccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class