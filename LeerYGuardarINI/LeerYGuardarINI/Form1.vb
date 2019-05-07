Public Class Form1
    Dim secc_dp As String = "datos_personales"
    Dim secc_bd As String = "base_de_datos"
    Dim param_nombre As String = "nombre"
    Dim param_apellido As String = "apellido"
    Dim param_ip As String = "ip"
    Dim param_nombdd As String = "nombre_base"


    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        UsarINI.GuardarEnIni(secc_dp, param_nombre, txtbx_nombre.Text)
        UsarINI.GuardarEnIni(secc_dp, param_apellido, txtbx_apellido.Text)
        UsarINI.GuardarEnIni(secc_bd, param_ip, txtbx_ip.Text)
        UsarINI.GuardarEnIni(secc_bd, param_nombdd, txtbx_bdd.Text)
    End Sub

    Private Sub btn_leer_Click(sender As Object, e As EventArgs) Handles btn_leer.Click
        txtbx_nombre.Text = UsarINI.LeerDeIni(secc_dp, param_nombre, "")
        txtbx_apellido.Text = UsarINI.LeerDeIni(secc_dp, param_apellido, "")
        txtbx_ip.Text = UsarINI.LeerDeIni(secc_bd, param_ip, "")
        txtbx_bdd.Text = UsarINI.LeerDeIni(secc_bd, param_nombdd, "")
    End Sub
End Class
