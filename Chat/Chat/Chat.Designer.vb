<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Me.components = New System.ComponentModel.Container()
        Me.Txtbx_mensajes = New System.Windows.Forms.TextBox()
        Me.Txtbx_mensaje_enviar = New System.Windows.Forms.TextBox()
        Me.Btn_enviar = New System.Windows.Forms.Button()
        Me.Lbl_usuario_rec = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_estado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txtbx_mensajes
        '
        Me.Txtbx_mensajes.BackColor = System.Drawing.Color.White
        Me.Txtbx_mensajes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbx_mensajes.Location = New System.Drawing.Point(25, 57)
        Me.Txtbx_mensajes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtbx_mensajes.Multiline = True
        Me.Txtbx_mensajes.Name = "Txtbx_mensajes"
        Me.Txtbx_mensajes.ReadOnly = True
        Me.Txtbx_mensajes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtbx_mensajes.Size = New System.Drawing.Size(608, 278)
        Me.Txtbx_mensajes.TabIndex = 0
        '
        'Txtbx_mensaje_enviar
        '
        Me.Txtbx_mensaje_enviar.Location = New System.Drawing.Point(25, 343)
        Me.Txtbx_mensaje_enviar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtbx_mensaje_enviar.Multiline = True
        Me.Txtbx_mensaje_enviar.Name = "Txtbx_mensaje_enviar"
        Me.Txtbx_mensaje_enviar.Size = New System.Drawing.Size(473, 106)
        Me.Txtbx_mensaje_enviar.TabIndex = 1
        '
        'Btn_enviar
        '
        Me.Btn_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_enviar.Location = New System.Drawing.Point(508, 343)
        Me.Btn_enviar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_enviar.Name = "Btn_enviar"
        Me.Btn_enviar.Size = New System.Drawing.Size(125, 106)
        Me.Btn_enviar.TabIndex = 2
        Me.Btn_enviar.Text = "Enviar"
        Me.Btn_enviar.UseVisualStyleBackColor = True
        '
        'Lbl_usuario_rec
        '
        Me.Lbl_usuario_rec.AutoSize = True
        Me.Lbl_usuario_rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_usuario_rec.Location = New System.Drawing.Point(17, 11)
        Me.Lbl_usuario_rec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_usuario_rec.Name = "Lbl_usuario_rec"
        Me.Lbl_usuario_rec.Size = New System.Drawing.Size(182, 39)
        Me.Lbl_usuario_rec.TabIndex = 3
        Me.Lbl_usuario_rec.Text = "_Usuario_"
        '
        'Tiempo
        '
        '
        'lbl_estado
        '
        Me.lbl_estado.AutoSize = True
        Me.lbl_estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estado.Location = New System.Drawing.Point(513, 20)
        Me.lbl_estado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_estado.Name = "lbl_estado"
        Me.lbl_estado.Size = New System.Drawing.Size(120, 29)
        Me.lbl_estado.TabIndex = 4
        Me.lbl_estado.Text = "_estado_"
        '
        'Chat
        '
        Me.AcceptButton = Me.Btn_enviar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 465)
        Me.Controls.Add(Me.lbl_estado)
        Me.Controls.Add(Me.Lbl_usuario_rec)
        Me.Controls.Add(Me.Btn_enviar)
        Me.Controls.Add(Me.Txtbx_mensaje_enviar)
        Me.Controls.Add(Me.Txtbx_mensajes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Chat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtbx_mensajes As TextBox
    Friend WithEvents Txtbx_mensaje_enviar As TextBox
    Friend WithEvents Btn_enviar As Button
    Friend WithEvents Lbl_usuario_rec As Label
    Friend WithEvents Tiempo As Timer
    Friend WithEvents lbl_estado As Label
End Class
