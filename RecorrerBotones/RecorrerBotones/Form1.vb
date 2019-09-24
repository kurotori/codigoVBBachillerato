Public Class Form1


    Sub RecorrerBotones(posicion As Integer)
        Dim numero As Integer = 0
        For Each objeto As Control In grupo_1.Controls
            'If TypeOf boton Is Button And Not boton.Name.Equals("btn_Aceptar") Then
            If TypeOf objeto Is Button Then
                numero = objeto.TabIndex

                If numero >= posicion Then
                    objeto.Text = "OK"
                Else
                    objeto.Text = vbNullString
                End If

            End If
        Next
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecorrerBotones(3)
    End Sub
End Class
