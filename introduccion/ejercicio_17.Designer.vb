<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio_17
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
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtGenero = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Edad = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(46, 85)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje.TabIndex = 48
        Me.LblMensaje.Text = "."
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(76, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtGenero
        '
        Me.TxtGenero.Location = New System.Drawing.Point(136, 41)
        Me.TxtGenero.Name = "TxtGenero"
        Me.TxtGenero.Size = New System.Drawing.Size(100, 20)
        Me.TxtGenero.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Genero. M/F"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(136, 6)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(100, 20)
        Me.TxtEdad.TabIndex = 44
        '
        'Edad
        '
        Me.Edad.AutoSize = True
        Me.Edad.Location = New System.Drawing.Point(12, 9)
        Me.Edad.Name = "Edad"
        Me.Edad.Size = New System.Drawing.Size(32, 13)
        Me.Edad.TabIndex = 43
        Me.Edad.Text = "Edad"
        '
        'ejercicio_17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtGenero)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Edad)
        Me.Name = "ejercicio_17"
        Me.Text = "ejercicio_17"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblMensaje As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtGenero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEdad As TextBox
    Friend WithEvents Edad As Label
End Class
