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
        Me.txt_servidor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.btn_guardar_config = New System.Windows.Forms.Button()
        Me.btn_probar_config = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_servidor
        '
        Me.txt_servidor.Location = New System.Drawing.Point(115, 12)
        Me.txt_servidor.Name = "txt_servidor"
        Me.txt_servidor.Size = New System.Drawing.Size(178, 20)
        Me.txt_servidor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(115, 38)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(178, 20)
        Me.txt_usuario.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(115, 64)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(178, 20)
        Me.TextBox3.TabIndex = 4
        '
        'btn_guardar_config
        '
        Me.btn_guardar_config.Location = New System.Drawing.Point(69, 90)
        Me.btn_guardar_config.Name = "btn_guardar_config"
        Me.btn_guardar_config.Size = New System.Drawing.Size(176, 31)
        Me.btn_guardar_config.TabIndex = 6
        Me.btn_guardar_config.Text = "Guardar Configuración"
        Me.btn_guardar_config.UseVisualStyleBackColor = True
        '
        'btn_probar_config
        '
        Me.btn_probar_config.Location = New System.Drawing.Point(69, 127)
        Me.btn_probar_config.Name = "btn_probar_config"
        Me.btn_probar_config.Size = New System.Drawing.Size(176, 31)
        Me.btn_probar_config.TabIndex = 7
        Me.btn_probar_config.Text = "Probar Configuración"
        Me.btn_probar_config.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 185)
        Me.Controls.Add(Me.btn_probar_config)
        Me.Controls.Add(Me.btn_guardar_config)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_servidor)
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents btn_guardar_config As Button
    Friend WithEvents btn_probar_config As Button
End Class
