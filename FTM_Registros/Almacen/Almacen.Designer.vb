<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Almacen
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Almacen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.invmpBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EntradasBTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.EntradasBTN)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.invmpBTN)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 615)
        Me.Panel1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 54)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Procesos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Almacén"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'invmpBTN
        '
        Me.invmpBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.packaging_22140
        Me.invmpBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invmpBTN.ForeColor = System.Drawing.Color.Black
        Me.invmpBTN.Location = New System.Drawing.Point(49, 88)
        Me.invmpBTN.Name = "invmpBTN"
        Me.invmpBTN.Size = New System.Drawing.Size(75, 75)
        Me.invmpBTN.TabIndex = 23
        Me.invmpBTN.Text = "Inventario MP"
        Me.invmpBTN.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.invmpBTN, "Muestra el inventario de Materia Prima ")
        Me.invmpBTN.UseVisualStyleBackColor = True
        '
        'EntradasBTN
        '
        Me.EntradasBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.packaging_22140
        Me.EntradasBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntradasBTN.ForeColor = System.Drawing.Color.Black
        Me.EntradasBTN.Location = New System.Drawing.Point(49, 195)
        Me.EntradasBTN.Name = "EntradasBTN"
        Me.EntradasBTN.Size = New System.Drawing.Size(75, 75)
        Me.EntradasBTN.TabIndex = 25
        Me.EntradasBTN.Text = "Entradas Material"
        Me.EntradasBTN.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.EntradasBTN, "Muestra el inventario de Materia Prima ")
        Me.EntradasBTN.UseVisualStyleBackColor = True
        '
        'Almacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1127, 615)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Almacen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Almacén"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents invmpBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents EntradasBTN As Button
End Class
