<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercico_1
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
        Me.dtproducto = New System.Windows.Forms.DataGridView()
        Me.cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.val_unitit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.etiqueta = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txttotal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtproducto
        '
        Me.dtproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtproducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cant, Me.descriccion, Me.val_unitit, Me.etiqueta, Me.descuento, Me.total})
        Me.dtproducto.Location = New System.Drawing.Point(-4, 0)
        Me.dtproducto.Name = "dtproducto"
        Me.dtproducto.Size = New System.Drawing.Size(640, 183)
        Me.dtproducto.TabIndex = 11
        '
        'cant
        '
        Me.cant.HeaderText = "cant"
        Me.cant.Name = "cant"
        '
        'descriccion
        '
        Me.descriccion.HeaderText = "descriccion "
        Me.descriccion.Name = "descriccion"
        '
        'val_unitit
        '
        Me.val_unitit.HeaderText = "valor unitario"
        Me.val_unitit.Name = "val_unitit"
        '
        'etiqueta
        '
        Me.etiqueta.HeaderText = "etiqueta"
        Me.etiqueta.Items.AddRange(New Object() {"seleccionar", "roja"})
        Me.etiqueta.Name = "etiqueta"
        '
        'descuento
        '
        Me.descuento.HeaderText = "descuento"
        Me.descuento.Name = "descuento"
        '
        'total
        '
        Me.total.HeaderText = "total"
        Me.total.Name = "total"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "total"
        '
        'Txttotal
        '
        Me.Txttotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttotal.Location = New System.Drawing.Point(404, 202)
        Me.Txttotal.Name = "Txttotal"
        Me.Txttotal.Size = New System.Drawing.Size(232, 20)
        Me.Txttotal.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "resultado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ejercico_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 271)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txttotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtproducto)
        Me.Name = "ejercico_1"
        Me.Text = "ejercico_1"
        CType(Me.dtproducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtproducto As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descriccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents val_unitit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents etiqueta As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
