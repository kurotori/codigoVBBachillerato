<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txt_contrasenia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_probarBdD = New System.Windows.Forms.Button()
        Me.btn_guardarEnBdD = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_edad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_datos = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_servidor
        '
        Me.txt_servidor.Location = New System.Drawing.Point(9, 54)
        Me.txt_servidor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_servidor.Name = "txt_servidor"
        Me.txt_servidor.Size = New System.Drawing.Size(116, 20)
        Me.txt_servidor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Usuario"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(9, 95)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(116, 20)
        Me.txt_usuario.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'txt_contrasenia
        '
        Me.txt_contrasenia.Location = New System.Drawing.Point(9, 136)
        Me.txt_contrasenia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_contrasenia.Name = "txt_contrasenia"
        Me.txt_contrasenia.Size = New System.Drawing.Size(116, 20)
        Me.txt_contrasenia.TabIndex = 4
        Me.txt_contrasenia.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Datos del Servidor"
        '
        'btn_probarBdD
        '
        Me.btn_probarBdD.Location = New System.Drawing.Point(11, 171)
        Me.btn_probarBdD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_probarBdD.Name = "btn_probarBdD"
        Me.btn_probarBdD.Size = New System.Drawing.Size(112, 31)
        Me.btn_probarBdD.TabIndex = 7
        Me.btn_probarBdD.Text = "Probar Conexión"
        Me.btn_probarBdD.UseVisualStyleBackColor = True
        '
        'btn_guardarEnBdD
        '
        Me.btn_guardarEnBdD.Location = New System.Drawing.Point(208, 171)
        Me.btn_guardarEnBdD.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_guardarEnBdD.Name = "btn_guardarEnBdD"
        Me.btn_guardarEnBdD.Size = New System.Drawing.Size(112, 31)
        Me.btn_guardarEnBdD.TabIndex = 15
        Me.btn_guardarEnBdD.Text = "Guardar"
        Me.btn_guardarEnBdD.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ingreso de Datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(206, 118)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Edad"
        '
        'txt_edad
        '
        Me.txt_edad.Location = New System.Drawing.Point(206, 136)
        Me.txt_edad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_edad.Name = "txt_edad"
        Me.txt_edad.Size = New System.Drawing.Size(116, 20)
        Me.txt_edad.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 76)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Apellido"
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(206, 95)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(116, 20)
        Me.txt_apellido.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(206, 35)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombre"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(206, 54)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(116, 20)
        Me.txt_nombre.TabIndex = 8
        '
        'txt_datos
        '
        Me.txt_datos.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_datos.Location = New System.Drawing.Point(381, 35)
        Me.txt_datos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_datos.Multiline = True
        Me.txt_datos.Name = "txt_datos"
        Me.txt_datos.Size = New System.Drawing.Size(254, 167)
        Me.txt_datos.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(377, 7)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Datos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 214)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_datos)
        Me.Controls.Add(Me.btn_guardarEnBdD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_edad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_apellido)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.btn_probarBdD)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_contrasenia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_servidor)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_servidor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_contrasenia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_probarBdD As Button
    Friend WithEvents btn_guardarEnBdD As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_edad As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_apellido As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents txt_datos As TextBox
    Friend WithEvents Label9 As Label
End Class
