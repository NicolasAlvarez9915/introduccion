<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio19
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
        Me.TxtCantMateria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtValPorMateria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProemdio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 168)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(50, 140)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje.TabIndex = 55
        Me.LblMensaje.Text = "."
        '
        'TxtCantMateria
        '
        Me.TxtCantMateria.Location = New System.Drawing.Point(136, 6)
        Me.TxtCantMateria.Name = "TxtCantMateria"
        Me.TxtCantMateria.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantMateria.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Cantidad de materias"
        '
        'TxtValPorMateria
        '
        Me.TxtValPorMateria.Location = New System.Drawing.Point(136, 34)
        Me.TxtValPorMateria.Name = "TxtValPorMateria"
        Me.TxtValPorMateria.Size = New System.Drawing.Size(100, 20)
        Me.TxtValPorMateria.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Valor por materia"
        '
        'TxtProemdio
        '
        Me.TxtProemdio.Location = New System.Drawing.Point(136, 65)
        Me.TxtProemdio.Name = "TxtProemdio"
        Me.TxtProemdio.Size = New System.Drawing.Size(100, 20)
        Me.TxtProemdio.TabIndex = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Promedio"
        '
        'ejercicio19
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtProemdio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtValPorMateria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.TxtCantMateria)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ejercicio19"
        Me.Text = "ejercicio19"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents LblMensaje As Label
    Friend WithEvents TxtCantMateria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtValPorMateria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProemdio As TextBox
    Friend WithEvents Label3 As Label
End Class
