Public Class Form1
    Dim rutaArchivo As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Try
            'SaveFileDialog1.ShowDialog()
            dlg_guardArch.ShowDialog()
            rutaArchivo = dlg_guardArch.FileName
            Archivo.AgregarDatosArchivo(txtbx_texto.Text, rutaArchivo)
        Catch excepcion As Exception
            Console.WriteLine("Excepcion: {0}", excepcion)
            MsgBox("Error: " + excepcion.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            dlg_abrirArch.ShowDialog()
            rutaArchivo = dlg_abrirArch.FileName
            txtbx_texto.Text = Archivo.LeerDatosArchivo(rutaArchivo)
        Catch excepcion As Exception
            Console.WriteLine("Excepcion: {0}", excepcion)
        End Try
    End Sub
End Class
