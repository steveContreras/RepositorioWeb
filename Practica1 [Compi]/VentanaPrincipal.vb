Imports System.IO

Public Class VentanaPrincipal

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click

    End Sub

    Private Sub btnAnalizar_Click(sender As Object, e As EventArgs) Handles btnAnalizar.Click

    End Sub

    Private Sub BotonAnlizar_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub


    Private Sub BotonCargar_Click(sender As Object, e As EventArgs) Handles BotonJugar.Click
        listaValores.Clear()
        Setup()
        Dim sinError As Boolean = False
        sinError = Parse(New StringReader(Me.RTB1.Text))

        If sinError Then
            Dim operar As New Operaciones()
            operar.SepararAtributos()

            LimpiarCadenas()

            Dim seleccion As New VentanaSeleccion()
            seleccion.Show()
            seleccion.MostrarPrimero()
            Me.WindowState = FormWindowState.Minimized

            'Dim escenario As New VentanaDeJuego()
            'escenario.Show()

        End If

    End Sub


    Private Sub botCargar_Click(sender As Object, e As EventArgs) Handles botCargar.Click
        Try
            Dim OpenFileDialog1 As New OpenFileDialog
            Dim archivo As String = ""

            OpenFileDialog1.Filter = "Archivos .TXT|*.txt"
            OpenFileDialog1.Title = "Cargar archivo.txt"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                archivo = OpenFileDialog1.FileName()
                RTB1.Text = ""
                RTB1.LoadFile(archivo, RichTextBoxStreamType.PlainText)
            End If

        Catch ex As Exception
            MsgBox("No se pudo cargar el achivo .txt")
        End Try

    End Sub

End Class
