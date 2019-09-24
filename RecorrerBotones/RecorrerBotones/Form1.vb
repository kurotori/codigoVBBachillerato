Public Class Form1
    Sub RecorrerBotones()
        For Each boton As Control In Me.Controls
            If TypeOf boton Is Button Then
                boton.Text = "Botón"
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RecorrerBotones()
    End Sub
End Class
