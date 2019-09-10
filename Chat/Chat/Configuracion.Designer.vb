<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Configuracion))
        Me.txt_servidor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_contrasenia = New System.Windows.Forms.TextBox()
        Me.btn_guardar_config = New System.Windows.Forms.Button()
        Me.btn_probar_config = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_servidor
        '
        Me.txt_servidor.Location = New System.Drawing.Point(153, 15)
        Me.txt_servidor.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_servidor.Name = "txt_servidor"
        Me.txt_servidor.Size = New System.Drawing.Size(236, 22)
        Me.txt_servidor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(153, 47)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(236, 22)
        Me.txt_usuario.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'txt_contrasenia
        '
        Me.txt_contrasenia.Location = New System.Drawing.Point(153, 79)
        Me.txt_contrasenia.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_contrasenia.Name = "txt_contrasenia"
        Me.txt_contrasenia.Size = New System.Drawing.Size(236, 22)
        Me.txt_contrasenia.TabIndex = 4
        Me.txt_contrasenia.UseSystemPasswordChar = True
        '
        'btn_guardar_config
        '
        Me.btn_guardar_config.Location = New System.Drawing.Point(92, 111)
        Me.btn_guardar_config.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_guardar_config.Name = "btn_guardar_config"
        Me.btn_guardar_config.Size = New System.Drawing.Size(235, 38)
        Me.btn_guardar_config.TabIndex = 6
        Me.btn_guardar_config.Text = "Guardar Configuración"
        Me.btn_guardar_config.UseVisualStyleBackColor = True
        '
        'btn_probar_config
        '
        Me.btn_probar_config.Location = New System.Drawing.Point(92, 156)
        Me.btn_probar_config.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_probar_config.Name = "btn_probar_config"
        Me.btn_probar_config.Size = New System.Drawing.Size(235, 38)
        Me.btn_probar_config.TabIndex = 7
        Me.btn_probar_config.Text = "Probar Configuración"
        Me.btn_probar_config.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 228)
        Me.Controls.Add(Me.btn_probar_config)
        Me.Controls.Add(Me.btn_guardar_config)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_contrasenia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_servidor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_servidor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_contrasenia As TextBox
    Friend WithEvents btn_guardar_config As Button
    Friend WithEvents btn_probar_config As Button
End Class
