Module Module1

    'varavble para recorrer filas 
    Public fila = 0


    'vectores
    Public NIT(7) As Integer
    Public Nombre(7) As String
    Public CantidadH(7) As Integer
    Public Recargo(7) As Integer
    Public Habitacion(7) As String
    Public Pago(7) As String
    Public subtotal(7) As Double

    Public Total(7) As Double


    Public Sub AGREGARNUEVOREGISTRO()
        'Proceso que realiza el ingreso, cálculo y almacenar los datos en los vectores
        If (fila < 7) Then
            Nombre(fila) = Form1.TBnombre.Text
            NIT(fila) = Val(Form1.TBnit.Text)
            CantidadH(fila) = Val(Form1.TBcantidad.Text)
            Habitacion(fila) = Form1.CBhabitacion.Text
            Recargo(fila) = 0

            Select Case Form1.CBhabitacion.SelectedItem

                Case "Estandar"
                    Pago(fila) = 250

                Case "A/C"
                    Pago(fila) = 290

                Case "Jacuzzi"
                    Pago(fila) = 370

            End Select


            If CantidadH(fila) > 4 Then
                Recargo(fila) = (CantidadH(fila) - 4) * 60
            End If
            Total(fila) = Pago(fila) + Recargo(fila)

            If fila = 7 Then
                MsgBox("Llego al limite de usuarios registrados  ", MsgBoxStyle.Information, "ADVERTENCIA")
            Else
                fila = fila + 1

                Limpiezatext()
                MsgBox("Ingreso exitoso", vbInformation, "REGISTRO")

            End If



        End If

    End Sub


    Public Sub Limpiezatext()
        Form1.TBcantidad.Clear()
        Form1.TBnombre.Clear()
        Form1.TBnit.Clear()
        Form1.TextBox5.Clear()
        Form1.CBhabitacion.SelectedIndex = -1

    End Sub

End Module
