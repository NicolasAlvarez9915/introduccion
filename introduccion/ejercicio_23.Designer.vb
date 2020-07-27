<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejercicio_23
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
        Me.TxtP3 = New System.Windows.Forms.TextBox()
        Me.TxtP2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblMensaje = New System.Windows.Forms.Label()
        Me.TxtP1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtP4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtGanancia = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblMensaje2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtP3
        '
        Me.TxtP3.Location = New System.Drawing.Point(118, 71)
        Me.TxtP3.Name = "TxtP3"
        Me.TxtP3.Size = New System.Drawing.Size(100, 20)
        Me.TxtP3.TabIndex = 72
        '
        'TxtP2
        '
        Me.TxtP2.Location = New System.Drawing.Point(118, 36)
        Me.TxtP2.Name = "TxtP2"
        Me.TxtP2.Size = New System.Drawing.Size(100, 20)
        Me.TxtP2.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Puntos del dia 2"
        '
        'LblMensaje
        '
        Me.LblMensaje.AutoSize = True
        Me.LblMensaje.Location = New System.Drawing.Point(12, 157)
        Me.LblMensaje.Name = "LblMensaje"
        Me.LblMensaje.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje.TabIndex = 68
        Me.LblMensaje.Text = "."
        '
        'TxtP1
        '
        Me.TxtP1.Location = New System.Drawing.Point(118, 6)
        Me.TxtP1.Name = "TxtP1"
        Me.TxtP1.Size = New System.Drawing.Size(100, 20)
        Me.TxtP1.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Puntos del dia 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Puntos del dia 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Puntos del dia 4"
        '
        'TxtP4
        '
        Me.TxtP4.Location = New System.Drawing.Point(118, 103)
        Me.TxtP4.Name = "TxtP4"
        Me.TxtP4.Size = New System.Drawing.Size(100, 20)
        Me.TxtP4.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Ganancias por dias"
        '
        'TxtGanancia
        '
        Me.TxtGanancia.Location = New System.Drawing.Point(118, 131)
        Me.TxtGanancia.Name = "TxtGanancia"
        Me.TxtGanancia.Size = New System.Drawing.Size(100, 20)
        Me.TxtGanancia.TabIndex = 76
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(118, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 78
        Me.Button2.Text = "Consultar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LblMensaje2
        '
        Me.LblMensaje2.AutoSize = True
        Me.LblMensaje2.Location = New System.Drawing.Point(12, 204)
        Me.LblMensaje2.Name = "LblMensaje2"
        Me.LblMensaje2.Size = New System.Drawing.Size(10, 13)
        Me.LblMensaje2.TabIndex = 79
        Me.LblMensaje2.Text = "."
        '
        'ejercicio_23
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 302)
        Me.Controls.Add(Me.LblMensaje2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtGanancia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtP4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtP3)
        Me.Controls.Add(Me.TxtP2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblMensaje)
        Me.Controls.Add(Me.TxtP1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ejercicio_23"
        Me.Text = "ejercicio_23"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtP3 As TextBox
    Friend WithEvents TxtP2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblMensaje As Label
    Friend WithEvents TxtP1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtP4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtGanancia As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LblMensaje2 As Label
End Class
