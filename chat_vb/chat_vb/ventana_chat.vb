Public Class Ventana_chat

    Private Sub Ventana_chat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tiempo.Interval = 5000
        Tiempo.Start()
    End Sub

    Private Sub Actualizar_mensajes()
        Dim Usuario As String = "_Usuario_"
        Dim mensaje_nuevo As String = vbNewLine & Usuario & ": bla bla bla bla"

        Dim marca_Tiempo As String = vbNewLine & "-- " &
            String.Format("{0:dd-MM-yyyy}", DateTime.Now) & " " &
            String.Format("{0:HH:mm:ss}", DateTime.Now)

        Txtbx_mensajes.AppendText(mensaje_nuevo & marca_Tiempo)
    End Sub



    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Actualizar_mensajes()
    End Sub
End Class
