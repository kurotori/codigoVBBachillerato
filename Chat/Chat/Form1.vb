Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tiempo.Interval = 5000
        Tiempo.Start()
    End Sub

    Private Sub Recibir_mensajes()
        Dim usuario As String = vbNewLine & "Usuario2"
        Dim mensaje As String = vbNewLine & "bla bla bla"

        Dim marcaDeTiempo As String = vbNewLine & vbTab & "-- " &
            String.Format("{0:dd/MM/yyyy}", DateTime.Now) & " " &
            String.Format("{0:HH:mm:ss}", DateTime.Now) & " --"

        Txtbx_mensajes.AppendText(usuario & ": " & mensaje & marcaDeTiempo)

    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Recibir_mensajes()
    End Sub
End Class
