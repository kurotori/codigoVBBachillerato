<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaConectados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListaConectados))
        Me.Tiempo = New System.Windows.Forms.Timer(Me.components)
        Me.dgv_tabla_conectados = New System.Windows.Forms.DataGridView()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.cmbx_estado = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_tabla_conectados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tiempo
        '
        '
        'dgv_tabla_conectados
        '
        Me.dgv_tabla_conectados.AllowUserToAddRows = False
        Me.dgv_tabla_conectados.AllowUserToDeleteRows = False
        Me.dgv_tabla_conectados.AllowUserToResizeColumns = False
        Me.dgv_tabla_conectados.AllowUserToResizeRows = False
        Me.dgv_tabla_conectados.BackgroundColor = System.Drawing.Color.White
        Me.dgv_tabla_conectados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_tabla_conectados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgv_tabla_conectados.Location = New System.Drawing.Point(12, 79)
        Me.dgv_tabla_conectados.Name = "dgv_tabla_conectados"
        Me.dgv_tabla_conectados.ReadOnly = True
        Me.dgv_tabla_conectados.RowTemplate.Height = 24
        Me.dgv_tabla_conectados.Size = New System.Drawing.Size(489, 408)
        Me.dgv_tabla_conectados.TabIndex = 0
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Calibri", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(12, 9)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(99, 37)
        Me.lbl_usuario.TabIndex = 1
        Me.lbl_usuario.Text = "Label1"
        '
        'cmbx_estado
        '
        Me.cmbx_estado.FormattingEnabled = True
        Me.cmbx_estado.Items.AddRange(New Object() {"ACTIVO", "OCUPADO", "INACTIVO"})
        Me.cmbx_estado.Location = New System.Drawing.Point(12, 49)
        Me.cmbx_estado.Name = "cmbx_estado"
        Me.cmbx_estado.Size = New System.Drawing.Size(208, 24)
        Me.cmbx_estado.TabIndex = 2
        '
        'ListaConectados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 499)
        Me.Controls.Add(Me.cmbx_estado)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.dgv_tabla_conectados)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ListaConectados"
        Me.Text = "ListaConectados"
        CType(Me.dgv_tabla_conectados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tiempo As Timer
    Friend WithEvents dgv_tabla_conectados As DataGridView
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents cmbx_estado As ComboBox
End Class
