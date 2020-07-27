<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio21
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
        Me.LblMensaje2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChckIngresoExtra = New System.Windows.Forms.CheckBox()
        Me.TxtMeses = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIngresosExtra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LblMensaje2
        '
        Me.LblMensaje2.AutoSize = True
        Me.LblMensaje2.Location = New System.Drawing.Point(49, 121)
        Me.LblMensaje2.Name = "LblMensaje2"
        Me.LblMensaje2.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje2.TabIndex = 62
        Me.LblMensaje2.Text = "."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(82, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(49, 93)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje.TabIndex = 60
        Me.LblMensaje.Text = "."
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(159, 6)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(100, 20)
        Me.TxtSalario.TabIndex = 59
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Salario"
        '
        'ChckIngresoExtra
        '
        Me.ChckIngresoExtra.AutoSize = True
        Me.ChckIngresoExtra.Location = New System.Drawing.Point(15, 61)
        Me.ChckIngresoExtra.Name = "ChckIngresoExtra"
        Me.ChckIngresoExtra.Size = New System.Drawing.Size(138, 17)
        Me.ChckIngresoExtra.TabIndex = 63
        Me.ChckIngresoExtra.Text = "porsentaje ingreso extra"
        Me.ChckIngresoExtra.UseVisualStyleBackColor = True
        '
        'TxtMeses
        '
        Me.TxtMeses.Location = New System.Drawing.Point(159, 32)
        Me.TxtMeses.Name = "TxtMeses"
        Me.TxtMeses.Size = New System.Drawing.Size(100, 20)
        Me.TxtMeses.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Cantidad meses"
        '
        'TxtIngresosExtra
        '
        Me.TxtIngresosExtra.Location = New System.Drawing.Point(159, 58)
        Me.TxtIngresosExtra.Name = "TxtIngresosExtra"
        Me.TxtIngresosExtra.Size = New System.Drawing.Size(100, 20)
        Me.TxtIngresosExtra.TabIndex = 66
        '
        'ejercicio21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtIngresosExtra)
        Me.Controls.Add(Me.TxtMeses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChckIngresoExtra)
        Me.Controls.Add(Me.LblMensaje2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.TxtSalario)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ejercicio21"
        Me.Text = "ejercicio21"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMensaje2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblMensaje As Label
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChckIngresoExtra As CheckBox
    Friend WithEvents TxtMeses As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIngresosExtra As TextBox
End Class
