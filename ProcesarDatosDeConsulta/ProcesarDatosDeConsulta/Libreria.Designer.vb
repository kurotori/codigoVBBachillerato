<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Libreria
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
        Me.combo_nombre_autor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.List_libros = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_fecha_dec = New System.Windows.Forms.Label()
        Me.lbl_fecha_nac = New System.Windows.Forms.Label()
        Me.lbl_nacionalidad = New System.Windows.Forms.Label()
        Me.lbl_doc = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'combo_nombre_autor
        '
        Me.combo_nombre_autor.FormattingEnabled = True
        Me.combo_nombre_autor.Location = New System.Drawing.Point(12, 40)
        Me.combo_nombre_autor.Name = "combo_nombre_autor"
        Me.combo_nombre_autor.Size = New System.Drawing.Size(243, 24)
        Me.combo_nombre_autor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Autor"
        '
        'List_libros
        '
        Me.List_libros.FormattingEnabled = True
        Me.List_libros.ItemHeight = 16
        Me.List_libros.Location = New System.Drawing.Point(12, 87)
        Me.List_libros.Name = "List_libros"
        Me.List_libros.Size = New System.Drawing.Size(243, 244)
        Me.List_libros.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Libros"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Location = New System.Drawing.Point(261, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 152)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Libro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(174, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "______________________"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(174, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(184, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "______________________"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(174, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "______________________"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(74, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Documento:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 17)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Fecha de Nacimiento:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(61, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 17)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Nacionalidad:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_fecha_dec)
        Me.GroupBox2.Controls.Add(Me.lbl_fecha_nac)
        Me.GroupBox2.Controls.Add(Me.lbl_nacionalidad)
        Me.GroupBox2.Controls.Add(Me.lbl_doc)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(261, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(368, 136)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Autor"
        '
        'lbl_fecha_dec
        '
        Me.lbl_fecha_dec.AutoSize = True
        Me.lbl_fecha_dec.Location = New System.Drawing.Point(174, 83)
        Me.lbl_fecha_dec.Name = "lbl_fecha_dec"
        Me.lbl_fecha_dec.Size = New System.Drawing.Size(184, 17)
        Me.lbl_fecha_dec.TabIndex = 7
        Me.lbl_fecha_dec.Text = "______________________"
        Me.lbl_fecha_dec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_fecha_nac
        '
        Me.lbl_fecha_nac.AutoSize = True
        Me.lbl_fecha_nac.Location = New System.Drawing.Point(174, 63)
        Me.lbl_fecha_nac.Name = "lbl_fecha_nac"
        Me.lbl_fecha_nac.Size = New System.Drawing.Size(184, 17)
        Me.lbl_fecha_nac.TabIndex = 6
        Me.lbl_fecha_nac.Text = "______________________"
        Me.lbl_fecha_nac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_nacionalidad
        '
        Me.lbl_nacionalidad.AutoSize = True
        Me.lbl_nacionalidad.Location = New System.Drawing.Point(174, 43)
        Me.lbl_nacionalidad.Name = "lbl_nacionalidad"
        Me.lbl_nacionalidad.Size = New System.Drawing.Size(184, 17)
        Me.lbl_nacionalidad.TabIndex = 5
        Me.lbl_nacionalidad.Text = "______________________"
        Me.lbl_nacionalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_doc
        '
        Me.lbl_doc.AutoSize = True
        Me.lbl_doc.Location = New System.Drawing.Point(174, 23)
        Me.lbl_doc.Name = "lbl_doc"
        Me.lbl_doc.Size = New System.Drawing.Size(184, 17)
        Me.lbl_doc.TabIndex = 4
        Me.lbl_doc.Text = "______________________"
        Me.lbl_doc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Fecha de Deceso:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nacionalidad:"
        '
        'Libreria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 353)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.List_libros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combo_nombre_autor)
        Me.Name = "Libreria"
        Me.Text = "Listado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents combo_nombre_autor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents List_libros As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_fecha_dec As Label
    Friend WithEvents lbl_fecha_nac As Label
    Friend WithEvents lbl_nacionalidad As Label
    Friend WithEvents lbl_doc As Label
End Class
