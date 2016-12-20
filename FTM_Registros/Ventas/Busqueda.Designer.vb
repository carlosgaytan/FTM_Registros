<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busqueda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busqueda))
        Me.Busca = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.ClaveFTM = New System.Windows.Forms.TextBox()
        Me.Dibujo = New System.Windows.Forms.TextBox()
        Me.Descripcion = New System.Windows.Forms.TextBox()
        Me.Material = New System.Windows.Forms.TextBox()
        Me.LaserChbx = New System.Windows.Forms.CheckBox()
        Me.Modificar = New System.Windows.Forms.Button()
        Me.Actualizar = New System.Windows.Forms.Button()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Busca
        '
        Me.Busca.Location = New System.Drawing.Point(30, 12)
        Me.Busca.Name = "Busca"
        Me.Busca.Size = New System.Drawing.Size(299, 20)
        Me.Busca.TabIndex = 0
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(425, 50)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 1
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(411, 157)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(349, 246)
        Me.Tabla.TabIndex = 2
        '
        'ClaveFTM
        '
        Me.ClaveFTM.Location = New System.Drawing.Point(30, 53)
        Me.ClaveFTM.Name = "ClaveFTM"
        Me.ClaveFTM.Size = New System.Drawing.Size(100, 20)
        Me.ClaveFTM.TabIndex = 3
        '
        'Dibujo
        '
        Me.Dibujo.Location = New System.Drawing.Point(30, 95)
        Me.Dibujo.Name = "Dibujo"
        Me.Dibujo.Size = New System.Drawing.Size(100, 20)
        Me.Dibujo.TabIndex = 4
        '
        'Descripcion
        '
        Me.Descripcion.Location = New System.Drawing.Point(30, 137)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(100, 20)
        Me.Descripcion.TabIndex = 5
        '
        'Material
        '
        Me.Material.Location = New System.Drawing.Point(30, 188)
        Me.Material.Name = "Material"
        Me.Material.Size = New System.Drawing.Size(100, 20)
        Me.Material.TabIndex = 6
        '
        'LaserChbx
        '
        Me.LaserChbx.AutoSize = True
        Me.LaserChbx.Location = New System.Drawing.Point(30, 235)
        Me.LaserChbx.Name = "LaserChbx"
        Me.LaserChbx.Size = New System.Drawing.Size(81, 17)
        Me.LaserChbx.TabIndex = 7
        Me.LaserChbx.Text = "CheckBox1"
        Me.LaserChbx.UseVisualStyleBackColor = True
        '
        'Modificar
        '
        Me.Modificar.Location = New System.Drawing.Point(525, 50)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Size = New System.Drawing.Size(75, 23)
        Me.Modificar.TabIndex = 8
        Me.Modificar.Text = "Modificar"
        Me.Modificar.UseVisualStyleBackColor = True
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(627, 51)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.Actualizar.TabIndex = 9
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Busqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 415)
        Me.Controls.Add(Me.Actualizar)
        Me.Controls.Add(Me.Modificar)
        Me.Controls.Add(Me.LaserChbx)
        Me.Controls.Add(Me.Material)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.Dibujo)
        Me.Controls.Add(Me.ClaveFTM)
        Me.Controls.Add(Me.Tabla)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Busca)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Busqueda"
        Me.Text = "Manufactura"
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Busca As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents ClaveFTM As TextBox
    Friend WithEvents Dibujo As TextBox
    Friend WithEvents Descripcion As TextBox
    Friend WithEvents Material As TextBox
    Friend WithEvents LaserChbx As CheckBox
    Friend WithEvents Modificar As Button
    Friend WithEvents Actualizar As Button
End Class
