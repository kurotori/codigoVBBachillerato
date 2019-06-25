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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtbx_nombre = New System.Windows.Forms.TextBox()
        Me.txtbx_apellido = New System.Windows.Forms.TextBox()
        Me.txtbx_ci = New System.Windows.Forms.TextBox()
        Me.txtbx_telefono = New System.Windows.Forms.TextBox()
        Me.txtbx_direccion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(345, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 65)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtbx_nombre
        '
        Me.txtbx_nombre.Location = New System.Drawing.Point(117, 102)
        Me.txtbx_nombre.Name = "txtbx_nombre"
        Me.txtbx_nombre.Size = New System.Drawing.Size(292, 20)
        Me.txtbx_nombre.TabIndex = 2
        '
        'txtbx_apellido
        '
        Me.txtbx_apellido.Location = New System.Drawing.Point(118, 128)
        Me.txtbx_apellido.Name = "txtbx_apellido"
        Me.txtbx_apellido.Size = New System.Drawing.Size(292, 20)
        Me.txtbx_apellido.TabIndex = 3
        '
        'txtbx_ci
        '
        Me.txtbx_ci.Location = New System.Drawing.Point(118, 154)
        Me.txtbx_ci.Name = "txtbx_ci"
        Me.txtbx_ci.Size = New System.Drawing.Size(292, 20)
        Me.txtbx_ci.TabIndex = 4
        '
        'txtbx_telefono
        '
        Me.txtbx_telefono.Location = New System.Drawing.Point(117, 206)
        Me.txtbx_telefono.Name = "txtbx_telefono"
        Me.txtbx_telefono.Size = New System.Drawing.Size(292, 20)
        Me.txtbx_telefono.TabIndex = 6
        '
        'txtbx_direccion
        '
        Me.txtbx_direccion.Location = New System.Drawing.Point(117, 180)
        Me.txtbx_direccion.Name = "txtbx_direccion"
        Me.txtbx_direccion.Size = New System.Drawing.Size(292, 20)
        Me.txtbx_direccion.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "CI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direcciòn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Teléfono"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 249)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbx_telefono)
        Me.Controls.Add(Me.txtbx_direccion)
        Me.Controls.Add(Me.txtbx_ci)
        Me.Controls.Add(Me.txtbx_apellido)
        Me.Controls.Add(Me.txtbx_nombre)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtbx_nombre As TextBox
    Friend WithEvents txtbx_apellido As TextBox
    Friend WithEvents txtbx_ci As TextBox
    Friend WithEvents txtbx_telefono As TextBox
    Friend WithEvents txtbx_direccion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
