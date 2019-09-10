<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IniciarSesion
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbx_ci = New System.Windows.Forms.TextBox()
        Me.txtbx_usuario = New System.Windows.Forms.TextBox()
        Me.btn_ingresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar al Chat"
        '
        'txtbx_ci
        '
        Me.txtbx_ci.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_ci.Location = New System.Drawing.Point(122, 63)
        Me.txtbx_ci.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbx_ci.Name = "txtbx_ci"
        Me.txtbx_ci.Size = New System.Drawing.Size(230, 34)
        Me.txtbx_ci.TabIndex = 1
        '
        'txtbx_usuario
        '
        Me.txtbx_usuario.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_usuario.Location = New System.Drawing.Point(122, 101)
        Me.txtbx_usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbx_usuario.Name = "txtbx_usuario"
        Me.txtbx_usuario.Size = New System.Drawing.Size(230, 34)
        Me.txtbx_usuario.TabIndex = 2
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar.Location = New System.Drawing.Point(96, 162)
        Me.btn_ingresar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(205, 43)
        Me.btn_ingresar.TabIndex = 3
        Me.btn_ingresar.Text = "INGRESAR"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 66)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Configuración"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IniciarSesion
        '
        Me.AcceptButton = Me.btn_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 249)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txtbx_usuario)
        Me.Controls.Add(Me.txtbx_ci)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "IniciarSesion"
        Me.Text = "IniciarSesion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbx_ci As TextBox
    Friend WithEvents txtbx_usuario As TextBox
    Friend WithEvents btn_ingresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
