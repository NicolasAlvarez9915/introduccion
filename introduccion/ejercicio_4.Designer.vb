<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio_4
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
        Me.llantas = New System.Windows.Forms.DataGridView()
        Me.can_llantas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.Button()
        Me.resultado = New System.Windows.Forms.TextBox()
        CType(Me.llantas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'llantas
        '
        Me.llantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.llantas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.can_llantas, Me.precio})
        Me.llantas.Location = New System.Drawing.Point(-1, 1)
        Me.llantas.Name = "llantas"
        Me.llantas.Size = New System.Drawing.Size(241, 202)
        Me.llantas.TabIndex = 0
        '
        'can_llantas
        '
        Me.can_llantas.HeaderText = "cantidad de llantas "
        Me.can_llantas.Name = "can_llantas"
        '
        'precio
        '
        Me.precio.HeaderText = "precio por unidad"
        Me.precio.Name = "precio"
        '
        'total
        '
        Me.total.Location = New System.Drawing.Point(-1, 214)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(75, 20)
        Me.total.TabIndex = 1
        Me.total.Text = "total"
        Me.total.UseVisualStyleBackColor = True
        '
        'resultado
        '
        Me.resultado.Location = New System.Drawing.Point(107, 215)
        Me.resultado.Name = "resultado"
        Me.resultado.Size = New System.Drawing.Size(120, 20)
        Me.resultado.TabIndex = 2
        '
        'ejercicio_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 244)
        Me.Controls.Add(Me.resultado)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.llantas)
        Me.Name = "ejercicio_4"
        Me.Text = "ejercicio4"
        CType(Me.llantas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents llantas As System.Windows.Forms.DataGridView
    Friend WithEvents total As System.Windows.Forms.Button
    Friend WithEvents resultado As System.Windows.Forms.TextBox
    Friend WithEvents can_llantas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
