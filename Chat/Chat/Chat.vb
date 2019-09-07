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
        Recibir_mensajes()
        ActualizarEstado()
        Me.ActiveControl = Txtbx_mensaje_enviar
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        Recibir_mensajes()
        ActualizarEstado()
    End Sub

    Private Sub Btn_enviar_Click(sender As Object, e As EventArgs) Handles Btn_enviar.Click
        Enviar_mensajes()
    End Sub

    Private Sub Txtbx_mensaje_enviar_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtbx_mensaje_enviar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Enviar_mensajes()
        End If
    End Sub

    Private Sub ActualizarEstado()
        Dim estado As String = VerEstado(ci_usuario2)
        lbl_estado.Text = estado
        Select Case estado
            Case "activo"
                lbl_estado.ForeColor = Color.Green
            Case "inactivo"
                lbl_estado.ForeColor = Color.Gray
            Case "ocupado"
                lbl_estado.ForeColor = Color.Red
            Case Else

        End Select

    End Sub

    Function MarcaDeTiempo() As String
        Dim marca As String = vbNewLine & vbTab & "-- " &
            String.Format("{0:dd/MM/yyyy}", DateTime.Now) & " " &
            String.Format("{0:HH:mm:ss}", DateTime.Now) & " --"

        Return marca
    End Function

    Private Sub Recibir_mensajes()
        Txtbx_mensajes.Text = vbNullString
        Dim mensajes As String = RecibirMensajesDeUsuario(ci_usuario1, ci_usuario2, usuario2)
        Txtbx_mensajes.AppendText(mensajes)
        MarcarMensajesDeUsuario(ci_usuario1, ci_usuario2)
    End Sub

    Private Sub Enviar_mensajes()
        Dim mensaje As String = Txtbx_mensaje_enviar.Text
        Dim longTexto As Integer = Txtbx_mensaje_enviar.Text.Length

        If longTexto > 0 Then
            If EnviarMensajeAUsuario(ci_usuario1, ci_usuario2, mensaje) Then
                Txtbx_mensaje_enviar.Text = vbNullString
                Recibir_mensajes()
            Else
                MsgBox("El mensaje no pudo ser enviado. Intente Nuevamente")
            End If
        End If
    End Sub




End Class
