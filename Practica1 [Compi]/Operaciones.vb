
Public Class Operaciones

    Public lis_vidas_nave As New List(Of Object)
    Public lis_ataque_nave As New List(Of Object)
    Dim lis_proteccion_nave As New List(Of Object)
    Dim lis_vida_enemigo As New List(Of Object)
    Dim lis_ataque_enemigo As New List(Of Object)
    Dim lis_frecuencia_enemigo As New List(Of Object)
    Dim lis_velocidad_enemigo As New List(Of Object)
    Dim lis_punteo_enemigo As New List(Of Object)

    Public Sub SepararAtributos()

        Dim tipo As String
        Dim valor As Object

        For i As Integer = 0 To listaValores.Count - 1

            tipo = listaTipos.Item(i)
            valor = listaValores.Item(i)

            If tipo.Equals("vidaNave") Then
                lis_vidas_nave.Add(valor)

            ElseIf tipo.Equals("ataqueNave") Then
                lis_ataque_nave.Add(valor)

            ElseIf tipo.Equals("proteccionDefensa") Then
                lis_proteccion_nave.Add(valor)

            ElseIf tipo.Equals("vidaEnemigo") Then
                lis_vida_enemigo.Add(valor)

            ElseIf tipo.Equals("ataqueEnemigo") Then
                lis_ataque_enemigo.Add(valor)

            ElseIf tipo.Equals("frecuenciaEnemigo") Then
                lis_frecuencia_enemigo.Add(valor)

            ElseIf tipo.Equals("velocidadEnemigo") Then
                lis_velocidad_enemigo.Add(valor)

            ElseIf tipo.Equals("punteoEnemigo") Then
                lis_punteo_enemigo.Add(valor)

            Else
                MsgBox("No se reconoce un tipo")

            End If

        Next

    End Sub




End Class
