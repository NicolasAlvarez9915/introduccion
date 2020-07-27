<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio_2
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
        Me.dtcopia = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_copia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.escanear = New System.Windows.Forms.Button()
        CType(Me.dtcopia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtcopia
        '
        Me.dtcopia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtcopia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cantidad, Me.tipo_copia, Me.observacion})
        Me.dtcopia.Location = New System.Drawing.Point(1, 29)
        Me.dtcopia.Name = "dtcopia"
        Me.dtcopia.Size = New System.Drawing.Size(684, 233)
        Me.dtcopia.TabIndex = 0
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "cantidad"
        Me.cantidad.Name = "cantidad"
        '
        'tipo_copia
        '
        Me.tipo_copia.HeaderText = "tipo de copia"
        Me.tipo_copia.Items.AddRange(New Object() {"offset", "estándar"})
        Me.tipo_copia.Name = "tipo_copia"
        '
        'observacion
        '
        Me.observacion.HeaderText = "observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.Width = 200
        '
        'escanear
        '
        Me.escanear.Location = New System.Drawing.Point(442, 29)
        Me.escanear.Name = "escanear"
        Me.escanear.Size = New System.Drawing.Size(75, 23)
        Me.escanear.TabIndex = 1
        Me.escanear.Text = "escanear"
        Me.escanear.UseVisualStyleBackColor = True
        '
        'ejercicio_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 261)
        Me.Controls.Add(Me.escanear)
        Me.Controls.Add(Me.dtcopia)
        Me.Name = "ejercicio_2"
        Me.Text = "ejercicio2"
        CType(Me.dtcopia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtcopia As System.Windows.Forms.DataGridView
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_copia As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents escanear As System.Windows.Forms.Button
End Class
