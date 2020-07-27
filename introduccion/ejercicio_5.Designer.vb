<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio_5
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.estereo = New System.Windows.Forms.DataGridView()
        Me.total = New System.Windows.Forms.Button()
        Me.nproducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.estereo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(357, 219)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 20)
        Me.TextBox1.TabIndex = 0
        '
        'estereo
        '
        Me.estereo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.estereo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nproducto, Me.marca, Me.precio, Me.descuento})
        Me.estereo.Location = New System.Drawing.Point(2, 12)
        Me.estereo.Name = "estereo"
        Me.estereo.Size = New System.Drawing.Size(595, 200)
        Me.estereo.TabIndex = 1
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(258, 219)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(75, 20)
        Me.total.TabIndex = 2
        Me.total.Text = "total"
        Me.total.UseVisualStyleBackColor = True
        '
        'nproducto
        '
        Me.nproducto.HeaderText = "nombre del producto"
        Me.nproducto.Name = "nproducto"
        Me.nproducto.Width = 250
        '
        'marca
        '
        Me.marca.HeaderText = "marca"
        Me.marca.Items.AddRange(New Object() {"NOSY"})
        Me.marca.Name = "marca"
        '
        'precio
        '
        Me.precio.HeaderText = "precio"
        Me.precio.Name = "precio"
        '
        'descuento
        '
        Me.descuento.HeaderText = "descuento"
        Me.descuento.Name = "descuento"
        '
        'ejercicio_5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 252)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.estereo)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "ejercicio_5"
        Me.Text = "ejercicio_5"
        CType(Me.estereo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents estereo As System.Windows.Forms.DataGridView
    Friend WithEvents total As System.Windows.Forms.Button
    Friend WithEvents nproducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents marca As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descuento As System.Windows.Forms.DataGridViewButtonColumn
End Class
