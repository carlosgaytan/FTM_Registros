<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IP
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
        Me.ipBTN = New System.Windows.Forms.Button()
        Me.ipTXT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ipBTN
        '
        Me.ipBTN.Location = New System.Drawing.Point(71, 38)
        Me.ipBTN.Name = "ipBTN"
        Me.ipBTN.Size = New System.Drawing.Size(75, 23)
        Me.ipBTN.TabIndex = 0
        Me.ipBTN.Text = "IP"
        Me.ipBTN.UseVisualStyleBackColor = True
        '
        'ipTXT
        '
        Me.ipTXT.Location = New System.Drawing.Point(12, 12)
        Me.ipTXT.Name = "ipTXT"
        Me.ipTXT.Size = New System.Drawing.Size(199, 20)
        Me.ipTXT.TabIndex = 1
        '
        'IP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(223, 73)
        Me.Controls.Add(Me.ipTXT)
        Me.Controls.Add(Me.ipBTN)
        Me.Name = "IP"
        Me.Text = "IP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ipBTN As Button
    Friend WithEvents ipTXT As TextBox
End Class
