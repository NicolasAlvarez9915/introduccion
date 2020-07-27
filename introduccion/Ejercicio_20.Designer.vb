<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejercicio_20
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.TxtIngresos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblMensaje2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(46, 50)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje.TabIndex = 55
        Me.LblMensaje.Text = "."
        '
        'TxtIngresos
        '
        Me.TxtIngresos.Location = New System.Drawing.Point(136, 6)
        Me.TxtIngresos.Name = "TxtIngresos"
        Me.TxtIngresos.Size = New System.Drawing.Size(100, 20)
        Me.TxtIngresos.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Ingresos"
        '
        'LblMensaje2
        '
        Me.LblMensaje2.AutoSize = True
        Me.LblMensaje2.Location = New System.Drawing.Point(46, 78)
        Me.LblMensaje2.Name = "LblMensaje2"
        Me.LblMensaje2.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje2.TabIndex = 57
        Me.LblMensaje2.Text = "."
        '
        'Ejercicio_20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 188)
        Me.Controls.Add(Me.LblMensaje2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.TxtIngresos)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Ejercicio_20"
        Me.Text = "Ejercicio_20"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LblMensaje As Label
    Friend WithEvents TxtIngresos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblMensaje2 As Label
End Class
