Public Class ListaConectados

    Private usuario As String
    Private ci As String
    Private estado As String
    Private ventana_ini As IniciarSesion
    Private tablaUsuarios As New DataTable

    Public Sub New(usuario As String, ci As String,
                   estado As String, ventana_ini As IniciarSesion)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Me.usuario = usuario
        Me.ci = ci
        Me.estado = estado
        Me.ventana_ini = ventana_ini

        lbl_usuario.Text = Me.usuario


        Select Case estado
            Case "activo"
                cmbx_estado.SelectedIndex = 0
            Case "inactivo"
                cmbx_estado.SelectedIndex = 2
            Case "ocupado"
                cmbx_estado.SelectedIndex = 1
            Case Else
        End Select


    End Sub

    Sub CrearTablaUsuarios()
        tablaUsuarios = VerUsuariosConectados(ci)
        dgv_tabla_conectados.DataSource = ExtraerUsuarios(tablaUsuarios)
    End Sub

    Private Sub ListaConectados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tiempo.Interval = 5000
        Tiempo.Start()
        CrearTablaUsuarios()
    End Sub

    Private Sub Tiempo_Tick(sender As Object, e As EventArgs) Handles Tiempo.Tick
        CrearTablaUsuarios()
    End Sub

    Private Sub cmbx_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbx_estado.SelectedIndexChanged
        Dim estado As Integer = cmbx_estado.SelectedIndex

        Select Case estado
            Case 0
                CambiarEstado(ci, "activo")
            Case 1
                CambiarEstado(ci, "ocupado")
            Case 2
                CambiarEstado(ci, "inactivo")
            Case Else

        End Select

    End Sub

    Private Sub ListaConectados_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CambiarEstado(ci, "inactivo")
        ventana_ini.Show()
    End Sub

    Private Sub dgv_tabla_conectados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_tabla_conectados.CellDoubleClick

        Dim seleccionado As Integer = dgv_tabla_conectados.SelectedCells.Item(0).RowIndex
        Dim ci_usuario2 As String = tablaUsuarios.Rows.Item(seleccionado)(0)

        If Not ci_usuario2.Equals(ci) Then
            Dim nuevoChat As New Chat(ci, ci_usuario2)
            nuevoChat.Show()
        End If

    End Sub
End Class