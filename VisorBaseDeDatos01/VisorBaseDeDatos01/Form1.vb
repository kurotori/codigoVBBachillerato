Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim servidor As String = txtbx_servidor.Text
        Dim usuario As String = txtbx_usuario.Text
        Dim contrasenia As String = txtbx_constrasenia.Text

        If ConectarAServidor(servidor, usuario, contrasenia) Then
            MsgBox("Conexión Exitosa")
            Dim bases As String() = VerBasesDeServidor(servidor, usuario, contrasenia)

            For Each base As String In bases
                ComboBox1.Items.Add(base)
            Next

        End If


    End Sub
End Class
