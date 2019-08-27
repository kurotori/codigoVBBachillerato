Public Class Form1

    Dim usuario As String = "Yo"
    Dim usuario2 As String = "Usuario2"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tiempo.Interval = 5000
        Tiempo.Start()
    End Sub

    Function MarcaDeTiempo() As String
        Dim marca As String = vbNewLine & vbTab & "-- " &
            String.Format("{0:dd/MM/yyyy}", DateTime.Now) & " " &
            String.Format("{0:HH:mm:ss}", DateTime.Now) & " --"

        Return marca
    End Function

    Private Sub Recibir_mensajes()
        Dim mensaje As String = "bla bla bla"

        Dim tiempo As String = MarcaDeTiempo()

        Txtbx_mensajes.AppendText(vbNewLine & usuario2 & ": " & vbNewLine &
                                  mensaje & vbNewLine & tiempo)

    End Sub

    Private Sub Enviar_mensajes()
        Dim mensaje As String = Txtbx_mensaje_enviar.Text
        Txtbx_mensaje_enviar.Text = vbNullString

        Dim tiempo As String = MarcaDeTiempo()

        Txtbx_mensajes.AppendText(vbNewLine & usuario & ": " & vbNewLine &
                                  mensaje & vbNewLine & tiempo)
    End Sub


    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Recibir_mensajes()
    End Sub

    Private Sub Btn_enviar_Click(sender As Object, e As EventArgs) Handles Btn_enviar.Click
        Enviar_mensajes()
    End Sub
End Class
