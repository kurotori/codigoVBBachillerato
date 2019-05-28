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
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtbx_texto = New System.Windows.Forms.TextBox()
        Me.dlg_abrirArch = New System.Windows.Forms.OpenFileDialog()
        Me.dlg_guardArch = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'bt_guardar
        '
        Me.bt_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_guardar.Location = New System.Drawing.Point(9, 323)
        Me.bt_guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(122, 32)
        Me.bt_guardar.TabIndex = 0
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(329, 323)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Abrir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtbx_texto
        '
        Me.txtbx_texto.Location = New System.Drawing.Point(9, 10)
        Me.txtbx_texto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbx_texto.Multiline = True
        Me.txtbx_texto.Name = "txtbx_texto"
        Me.txtbx_texto.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbx_texto.Size = New System.Drawing.Size(443, 310)
        Me.txtbx_texto.TabIndex = 2
        '
        'dlg_abrirArch
        '
        Me.dlg_abrirArch.FileName = "OpenFileDialog1"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 366)
        Me.Controls.Add(Me.txtbx_texto)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.bt_guardar)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_guardar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtbx_texto As TextBox
    Friend WithEvents dlg_abrirArch As OpenFileDialog
    Friend WithEvents dlg_guardArch As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
