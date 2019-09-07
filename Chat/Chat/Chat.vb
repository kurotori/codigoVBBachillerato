Public Class Chat

    Dim usuario1 As String = "Yo"
    Dim usuario2 As String = "Usuario2"
    Dim ci_usuario1 As String
    Dim ci_usuario2 As String

    Public Sub New(ci_usuario1 As String, ci_usuario2 As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.ci_usuario1 = ci_usuario1
        Me.ci_usuario2 = ci_usuario2

        usuario2 = VerNombre(ci_usuario2)
        Lbl_usuario_rec.Text = usuario2
    End Sub

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

        Txtbx_mensajes.AppendText(vbNewLine & usuario1 & ": " & vbNewLine &
                                  mensaje & vbNewLine & tiempo)
    End Sub


    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Recibir_mensajes()
    End Sub

    Private Sub Btn_enviar_Click(sender As Object, e As EventArgs) Handles Btn_enviar.Click
        Dim longTexto As Integer = Txtbx_mensaje_enviar.Text.Length

        If longTexto > 0 Then
            Enviar_mensajes()
        End If

    End Sub

    Private Sub Txtbx_mensaje_enviar_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtbx_mensaje_enviar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim longTexto As Integer = Txtbx_mensaje_enviar.Text.Length

            If longTexto > 0 Then
                Enviar_mensajes()
            End If
        End If
    End Sub
End Class
