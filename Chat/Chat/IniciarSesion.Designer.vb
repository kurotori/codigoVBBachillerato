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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingresar al Chat"
        '
        'txtbx_ci
        '
        Me.txtbx_ci.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_ci.Location = New System.Drawing.Point(162, 78)
        Me.txtbx_ci.Name = "txtbx_ci"
        Me.txtbx_ci.Size = New System.Drawing.Size(306, 40)
        Me.txtbx_ci.TabIndex = 1
        '
        'txtbx_usuario
        '
        Me.txtbx_usuario.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_usuario.Location = New System.Drawing.Point(162, 124)
        Me.txtbx_usuario.Name = "txtbx_usuario"
        Me.txtbx_usuario.Size = New System.Drawing.Size(306, 40)
        Me.txtbx_usuario.TabIndex = 2
        '
        'btn_ingresar
        '
        Me.btn_ingresar.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ingresar.Location = New System.Drawing.Point(124, 187)
        Me.btn_ingresar.Name = "btn_ingresar"
        Me.btn_ingresar.Size = New System.Drawing.Size(273, 53)
        Me.btn_ingresar.TabIndex = 3
        Me.btn_ingresar.Text = "INGRESAR"
        Me.btn_ingresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 35)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 35)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario"
        '
        'IniciarSesion
        '
        Me.AcceptButton = Me.btn_ingresar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 262)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_ingresar)
        Me.Controls.Add(Me.txtbx_usuario)
        Me.Controls.Add(Me.txtbx_ci)
        Me.Controls.Add(Me.Label1)
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
End Class
