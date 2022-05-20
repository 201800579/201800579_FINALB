Public Class Form1
    Private Sub TScalculo_Click(sender As Object, e As EventArgs) Handles TScalculo.Click
        AGREGARNUEVOREGISTRO()
    End Sub

    Private Sub TSmostrar_Click(sender As Object, e As EventArgs) Handles TSmostrar.Click
        DTresultados.Rows.Clear()
        For I = 0 To 4
            'Con el siguiente IF se verifica que los vectores no estén vacíos, porque si están vacíos
            'y se trata de accesar a dicha posición, indicará un error de que se está tratando de 
            'mostrar algo que es Nulo o No existe
            'Se toma el primer vector para hacer la verificación, porque los demás estarán igual de llenos o vacíos
            If (NIT(I) <> Nothing) Then
                DTresultados.Rows.Add(Nombre(I), NIT(I), CantidadH(I), Habitacion(I), Pago(I), Recargo(I), Total(I))
            Else
                'Si están vacíos, se realiza una salida forzada del ciclo For con la siguiente instrucción
                Exit For
            End If
        Next I
    End Sub

    Private Sub TSlimpiar_Click(sender As Object, e As EventArgs) Handles TSlimpiar.Click
        Limpiezatext()

    End Sub

    Private Sub TSvectores_Click(sender As Object, e As EventArgs) Handles TSvectores.Click
        Dim j As Integer
        For j = 0 To 5
            NIT(j) = Nothing
            Nombre(j) = Nothing


            Total(j) = Nothing
            CantidadH(j) = Nothing
            Habitacion(j) = Nothing
            Pago(j) = Nothing
            Recargo(j) = Nothing




        Next
        fila = 0

        DTresultados.Rows.Clear()
    End Sub
End Class
