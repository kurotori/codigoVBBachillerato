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
        Me.txtbx_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpbx_datosp = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbx_apellido = New System.Windows.Forms.TextBox()
        Me.grpbx_datosserv = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbx_bdd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbx_ip = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_leer = New System.Windows.Forms.Button()
        Me.grpbx_datosp.SuspendLayout()
        Me.grpbx_datosserv.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtbx_nombre
        '
        Me.txtbx_nombre.Location = New System.Drawing.Point(201, 44)
        Me.txtbx_nombre.Name = "txtbx_nombre"
        Me.txtbx_nombre.Size = New System.Drawing.Size(287, 30)
        Me.txtbx_nombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-2, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'grpbx_datosp
        '
        Me.grpbx_datosp.Controls.Add(Me.Label2)
        Me.grpbx_datosp.Controls.Add(Me.txtbx_apellido)
        Me.grpbx_datosp.Controls.Add(Me.Label1)
        Me.grpbx_datosp.Controls.Add(Me.txtbx_nombre)
        Me.grpbx_datosp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_datosp.Location = New System.Drawing.Point(14, 12)
        Me.grpbx_datosp.Name = "grpbx_datosp"
        Me.grpbx_datosp.Size = New System.Drawing.Size(557, 142)
        Me.grpbx_datosp.TabIndex = 2
        Me.grpbx_datosp.TabStop = False
        Me.grpbx_datosp.Text = "Datos Personales"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-2, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido"
        '
        'txtbx_apellido
        '
        Me.txtbx_apellido.Location = New System.Drawing.Point(201, 80)
        Me.txtbx_apellido.Name = "txtbx_apellido"
        Me.txtbx_apellido.Size = New System.Drawing.Size(287, 30)
        Me.txtbx_apellido.TabIndex = 2
        '
        'grpbx_datosserv
        '
        Me.grpbx_datosserv.Controls.Add(Me.Label3)
        Me.grpbx_datosserv.Controls.Add(Me.txtbx_bdd)
        Me.grpbx_datosserv.Controls.Add(Me.Label4)
        Me.grpbx_datosserv.Controls.Add(Me.txtbx_ip)
        Me.grpbx_datosserv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbx_datosserv.Location = New System.Drawing.Point(14, 160)
        Me.grpbx_datosserv.Name = "grpbx_datosserv"
        Me.grpbx_datosserv.Size = New System.Drawing.Size(557, 142)
        Me.grpbx_datosserv.TabIndex = 4
        Me.grpbx_datosserv.TabStop = False
        Me.grpbx_datosserv.Text = "Datos del Servidor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-2, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Base de Datos"
        '
        'txtbx_bdd
        '
        Me.txtbx_bdd.Location = New System.Drawing.Point(201, 80)
        Me.txtbx_bdd.Name = "txtbx_bdd"
        Me.txtbx_bdd.Size = New System.Drawing.Size(287, 30)
        Me.txtbx_bdd.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-2, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 25)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "IP"
        '
        'txtbx_ip
        '
        Me.txtbx_ip.Location = New System.Drawing.Point(201, 44)
        Me.txtbx_ip.Name = "txtbx_ip"
        Me.txtbx_ip.Size = New System.Drawing.Size(287, 30)
        Me.txtbx_ip.TabIndex = 0
        '
        'btn_guardar
        '
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(14, 358)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(186, 66)
        Me.btn_guardar.TabIndex = 5
        Me.btn_guardar.Text = "Guardar Datos"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_leer
        '
        Me.btn_leer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_leer.Location = New System.Drawing.Point(385, 358)
        Me.btn_leer.Name = "btn_leer"
        Me.btn_leer.Size = New System.Drawing.Size(186, 66)
        Me.btn_leer.TabIndex = 6
        Me.btn_leer.Text = "Leer Datos"
        Me.btn_leer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 511)
        Me.Controls.Add(Me.btn_leer)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.grpbx_datosserv)
        Me.Controls.Add(Me.grpbx_datosp)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpbx_datosp.ResumeLayout(False)
        Me.grpbx_datosp.PerformLayout()
        Me.grpbx_datosserv.ResumeLayout(False)
        Me.grpbx_datosserv.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtbx_nombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpbx_datosp As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbx_apellido As TextBox
    Friend WithEvents grpbx_datosserv As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbx_bdd As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbx_ip As TextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_leer As Button
End Class
