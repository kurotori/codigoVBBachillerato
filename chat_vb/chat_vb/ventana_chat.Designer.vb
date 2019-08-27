<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventana_chat
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Txtbx_mensajes = New System.Windows.Forms.TextBox()
        Me.Txtbx_enviar = New System.Windows.Forms.TextBox()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Txtbx_mensajes
        '
        Me.Txtbx_mensajes.Location = New System.Drawing.Point(14, 65)
        Me.Txtbx_mensajes.Multiline = True
        Me.Txtbx_mensajes.Name = "Txtbx_mensajes"
        Me.Txtbx_mensajes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txtbx_mensajes.Size = New System.Drawing.Size(688, 256)
        Me.Txtbx_mensajes.TabIndex = 0
        '
        'Txtbx_enviar
        '
        Me.Txtbx_enviar.Location = New System.Drawing.Point(14, 327)
        Me.Txtbx_enviar.Multiline = True
        Me.Txtbx_enviar.Name = "Txtbx_enviar"
        Me.Txtbx_enviar.Size = New System.Drawing.Size(587, 60)
        Me.Txtbx_enviar.TabIndex = 1
        '
        'btn_enviar
        '
        Me.btn_enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enviar.Location = New System.Drawing.Point(607, 327)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(95, 60)
        Me.btn_enviar.TabIndex = 2
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "_Usuario_"
        '
        'Tiempo
        '
        '
        'Ventana_chat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 409)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.Txtbx_enviar)
        Me.Controls.Add(Me.Txtbx_mensajes)
        Me.Name = "Ventana_chat"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtbx_mensajes As TextBox
    Friend WithEvents Txtbx_enviar As TextBox
    Friend WithEvents btn_enviar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Tiempo As Timer
End Class
