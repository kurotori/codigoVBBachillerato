Module LeerYGuardarINI

    Private Declare Unicode Function EscribirDatosINI Lib "kernel32" _
                Alias "WritePrivateProfileStringW" _
                                       (NombreSeccion As String,
                                        NombreClave As String,
                                        ValorClave As String,
                                        ArchivoINI As String) As Int32

    Private Declare Unicode Function LeerDatosINI Lib "kernel32" _
           Alias "GetPrivateProfileStringW" _
                                   (NombreSeccion As String,
                                    NombreClave As String,
                                    ValorPorDescarte As String,
                                    StringRetorno As String,
                                    TamanioDatos As Int32,
                                    NombreArchivo As String) As Int32

    Public Sub GuardarEnIni(Archivo As String,
                            Seccion As String,
                            NombreParam As String,
                            ValorParam As String)
        EscribirDatosINI(Seccion, NombreParam, ValorParam, Archivo)
        MessageBox.Show("Configuración Guardada")
    End Sub

    Public Function LeerDeIni(Archivo As String,
                              Seccion As String,
                              NombreParam As String,
                              ValorPorDescarte As String) As String
        Dim resultado As String
        Dim ValorParam As String = Space(1024)

        Dim CaracteresValorParam As Integer = 0
        CaracteresValorParam = LeerDatosINI(Seccion, NombreParam, ValorPorDescarte, ValorParam, Len(ValorParam), Archivo)

        resultado = Left(ValorParam, CaracteresValorParam)
        Return resultado
    End Function

End Module
