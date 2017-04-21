<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrubMoneda
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
        Me.URLTXT = New System.Windows.Forms.TextBox()
        Me.NavBTN = New System.Windows.Forms.Button()
        Me.DatosTXT = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'URLTXT
        '
        Me.URLTXT.Location = New System.Drawing.Point(12, 17)
        Me.URLTXT.Name = "URLTXT"
        Me.URLTXT.Size = New System.Drawing.Size(501, 20)
        Me.URLTXT.TabIndex = 0
        Me.URLTXT.Text = "http://www.banxico.org.mx/portal-mercado-cambiario/index.html"
        '
        'NavBTN
        '
        Me.NavBTN.Location = New System.Drawing.Point(529, 15)
        Me.NavBTN.Name = "NavBTN"
        Me.NavBTN.Size = New System.Drawing.Size(75, 23)
        Me.NavBTN.TabIndex = 1
        Me.NavBTN.Text = "Navegar"
        Me.NavBTN.UseVisualStyleBackColor = True
        '
        'DatosTXT
        '
        Me.DatosTXT.Location = New System.Drawing.Point(640, 58)
        Me.DatosTXT.Multiline = True
        Me.DatosTXT.Name = "DatosTXT"
        Me.DatosTXT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DatosTXT.Size = New System.Drawing.Size(307, 516)
        Me.DatosTXT.TabIndex = 3
        '
        'PrubMoneda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 586)
        Me.Controls.Add(Me.DatosTXT)
        Me.Controls.Add(Me.NavBTN)
        Me.Controls.Add(Me.URLTXT)
        Me.Name = "PrubMoneda"
        Me.Text = "PrubMoneda"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents URLTXT As TextBox
    Friend WithEvents NavBTN As Button
    Friend WithEvents DatosTXT As TextBox
End Class
