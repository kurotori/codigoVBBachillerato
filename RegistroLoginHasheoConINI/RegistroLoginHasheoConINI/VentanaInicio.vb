﻿Public Class VentanaInicio

    Public servidor As String = ""
    Public usuario As String = ""
    Public contraseña As String = ""



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        DatosBdD.ShowDialog()
        Login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        DatosBdD.ShowDialog()
        CrearNuevoUsuario.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        servidor = LeerDeIni("BaseDeDatos", "servidor", "")
        usuario = LeerDeIni("BaseDeDatos", "usuario", "")
    End Sub
End Class