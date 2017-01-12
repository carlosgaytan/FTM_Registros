<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradaMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradaMP))
        Me.LoteTXT = New System.Windows.Forms.TextBox()
        Me.FacturaTXT = New System.Windows.Forms.TextBox()
        Me.OCTXT = New System.Windows.Forms.TextBox()
        Me.CalidadTXT = New System.Windows.Forms.TextBox()
        Me.LargoTXT = New System.Windows.Forms.TextBox()
        Me.AnchoTXT = New System.Windows.Forms.TextBox()
        Me.MaterialTXT = New System.Windows.Forms.TextBox()
        Me.CantidadTXT = New System.Windows.Forms.TextBox()
        Me.UnidadTXT = New System.Windows.Forms.TextBox()
        Me.CostoTXT = New System.Windows.Forms.TextBox()
        Me.CostokgTXT = New System.Windows.Forms.TextBox()
        Me.RackTXT = New System.Windows.Forms.TextBox()
        Me.NivelTXT = New System.Windows.Forms.TextBox()
        Me.ComentarioTXT = New System.Windows.Forms.TextBox()
        Me.noParteTXT = New System.Windows.Forms.TextBox()
        Me.FechaTXT = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.AlmacenBD = New FTM_Registros.AlmacenBD()
        Me.Entradas_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradasMaterialTableAdapter = New FTM_Registros.AlmacenBDTableAdapters.EntradasMaterialTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.AlmacenBDTableAdapters.TableAdapterManager()
        Me.ClienteCMB = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.ClientesTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter()
        Me.CalibreCMX = New System.Windows.Forms.ComboBox()
        CType(Me.AlmacenBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entradas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoteTXT
        '
        Me.LoteTXT.Location = New System.Drawing.Point(455, 173)
        Me.LoteTXT.Name = "LoteTXT"
        Me.LoteTXT.Size = New System.Drawing.Size(145, 20)
        Me.LoteTXT.TabIndex = 1
        '
        'FacturaTXT
        '
        Me.FacturaTXT.BackColor = System.Drawing.Color.White
        Me.FacturaTXT.Location = New System.Drawing.Point(113, 69)
        Me.FacturaTXT.Name = "FacturaTXT"
        Me.FacturaTXT.Size = New System.Drawing.Size(145, 20)
        Me.FacturaTXT.TabIndex = 3
        '
        'OCTXT
        '
        Me.OCTXT.Location = New System.Drawing.Point(113, 95)
        Me.OCTXT.Name = "OCTXT"
        Me.OCTXT.Size = New System.Drawing.Size(145, 20)
        Me.OCTXT.TabIndex = 4
        '
        'CalidadTXT
        '
        Me.CalidadTXT.Location = New System.Drawing.Point(113, 121)
        Me.CalidadTXT.Name = "CalidadTXT"
        Me.CalidadTXT.Size = New System.Drawing.Size(145, 20)
        Me.CalidadTXT.TabIndex = 5
        '
        'LargoTXT
        '
        Me.LargoTXT.Location = New System.Drawing.Point(113, 147)
        Me.LargoTXT.Name = "LargoTXT"
        Me.LargoTXT.Size = New System.Drawing.Size(145, 20)
        Me.LargoTXT.TabIndex = 6
        '
        'AnchoTXT
        '
        Me.AnchoTXT.Location = New System.Drawing.Point(113, 173)
        Me.AnchoTXT.Name = "AnchoTXT"
        Me.AnchoTXT.Size = New System.Drawing.Size(145, 20)
        Me.AnchoTXT.TabIndex = 7
        '
        'MaterialTXT
        '
        Me.MaterialTXT.Location = New System.Drawing.Point(113, 225)
        Me.MaterialTXT.Name = "MaterialTXT"
        Me.MaterialTXT.Size = New System.Drawing.Size(145, 20)
        Me.MaterialTXT.TabIndex = 9
        '
        'CantidadTXT
        '
        Me.CantidadTXT.Location = New System.Drawing.Point(455, 17)
        Me.CantidadTXT.Name = "CantidadTXT"
        Me.CantidadTXT.Size = New System.Drawing.Size(145, 20)
        Me.CantidadTXT.TabIndex = 10
        '
        'UnidadTXT
        '
        Me.UnidadTXT.Location = New System.Drawing.Point(455, 43)
        Me.UnidadTXT.Name = "UnidadTXT"
        Me.UnidadTXT.Size = New System.Drawing.Size(145, 20)
        Me.UnidadTXT.TabIndex = 11
        Me.UnidadTXT.Text = "PZA"
        '
        'CostoTXT
        '
        Me.CostoTXT.Location = New System.Drawing.Point(455, 69)
        Me.CostoTXT.Name = "CostoTXT"
        Me.CostoTXT.Size = New System.Drawing.Size(145, 20)
        Me.CostoTXT.TabIndex = 12
        '
        'CostokgTXT
        '
        Me.CostokgTXT.Location = New System.Drawing.Point(455, 95)
        Me.CostokgTXT.Name = "CostokgTXT"
        Me.CostokgTXT.Size = New System.Drawing.Size(145, 20)
        Me.CostokgTXT.TabIndex = 13
        '
        'RackTXT
        '
        Me.RackTXT.Location = New System.Drawing.Point(455, 121)
        Me.RackTXT.Name = "RackTXT"
        Me.RackTXT.Size = New System.Drawing.Size(145, 20)
        Me.RackTXT.TabIndex = 14
        '
        'NivelTXT
        '
        Me.NivelTXT.Location = New System.Drawing.Point(455, 147)
        Me.NivelTXT.Name = "NivelTXT"
        Me.NivelTXT.Size = New System.Drawing.Size(145, 20)
        Me.NivelTXT.TabIndex = 15
        '
        'ComentarioTXT
        '
        Me.ComentarioTXT.Location = New System.Drawing.Point(455, 229)
        Me.ComentarioTXT.Multiline = True
        Me.ComentarioTXT.Name = "ComentarioTXT"
        Me.ComentarioTXT.Size = New System.Drawing.Size(294, 82)
        Me.ComentarioTXT.TabIndex = 16
        '
        'noParteTXT
        '
        Me.noParteTXT.Location = New System.Drawing.Point(455, 199)
        Me.noParteTXT.Name = "noParteTXT"
        Me.noParteTXT.Size = New System.Drawing.Size(145, 20)
        Me.noParteTXT.TabIndex = 17
        '
        'FechaTXT
        '
        Me.FechaTXT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaTXT.Location = New System.Drawing.Point(113, 17)
        Me.FechaTXT.Name = "FechaTXT"
        Me.FechaTXT.Size = New System.Drawing.Size(145, 20)
        Me.FechaTXT.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Factura o Remisión:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Orden de Compra"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Certificado Calidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Largo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Ancho:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Calibre:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 228)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Material:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(354, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Cantidad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(354, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Unidad:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(354, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Costo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(354, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Costo por KG:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(354, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "RACK:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 150)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Nivel:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(354, 232)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 37
        Me.Label17.Text = "Comentario:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(354, 176)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Lote:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(354, 202)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "No. de parte:"
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(674, 339)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 42
        Me.GuardarBTN.Text = "Guardar"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'AlmacenBD
        '
        Me.AlmacenBD.DataSetName = "AlmacenBD"
        Me.AlmacenBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Entradas_MaterialBindingSource
        '
        Me.Entradas_MaterialBindingSource.DataMember = "Entradas_Material"
        Me.Entradas_MaterialBindingSource.DataSource = Me.AlmacenBD
        '
        'EntradasMaterialTableAdapter
        '
        Me.EntradasMaterialTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Base_ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Base_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.BaseEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EntradasMaterialTableAdapter = Me.EntradasMaterialTableAdapter
        Me.TableAdapterManager.RACKSTableAdapter = Nothing
        Me.TableAdapterManager.SalidasMaterialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.AlmacenBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteCMB
        '
        Me.ClienteCMB.DataSource = Me.ClientesBindingSource
        Me.ClienteCMB.DisplayMember = "Cliente"
        Me.ClienteCMB.FormattingEnabled = True
        Me.ClienteCMB.Location = New System.Drawing.Point(113, 42)
        Me.ClienteCMB.Name = "ClienteCMB"
        Me.ClienteCMB.Size = New System.Drawing.Size(145, 21)
        Me.ClienteCMB.TabIndex = 43
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CalibreCMX
        '
        Me.CalibreCMX.FormattingEnabled = True
        Me.CalibreCMX.Items.AddRange(New Object() {"Cal. 3", "Cal. 4", "Cal. 5", "Cal. 6", "Cal. 7", "Cal. 8", "Cal. 9", "Cal. 10", "Cal. 11", "Cal. 12", "Cal. 13", "Cal. 14", "Cal. 15", "Cal. 16", "Cal. 17", "Cal. 18", "Cal. 19", "Cal. 20", "Cal. 21", "Cal. 22", "Cal. 23", "Cal. 24", "Cal. 25", "Cal. 26", "Cal. 27", "Cal. 28", "Cal. 29", "Cal. 30", "Cal. 31", "Cal. 34", "Cal. 33", "Cal. 34", "1''", "7/8''", "3/4''", "5/8''", "1/2''", "3/8''", "5/16''", "1/4''", "3/16''"})
        Me.CalibreCMX.Location = New System.Drawing.Point(113, 198)
        Me.CalibreCMX.Name = "CalibreCMX"
        Me.CalibreCMX.Size = New System.Drawing.Size(145, 21)
        Me.CalibreCMX.TabIndex = 44
        '
        'EntradaMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 374)
        Me.Controls.Add(Me.CalibreCMX)
        Me.Controls.Add(Me.ClienteCMB)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FechaTXT)
        Me.Controls.Add(Me.noParteTXT)
        Me.Controls.Add(Me.ComentarioTXT)
        Me.Controls.Add(Me.NivelTXT)
        Me.Controls.Add(Me.RackTXT)
        Me.Controls.Add(Me.CostokgTXT)
        Me.Controls.Add(Me.CostoTXT)
        Me.Controls.Add(Me.UnidadTXT)
        Me.Controls.Add(Me.CantidadTXT)
        Me.Controls.Add(Me.MaterialTXT)
        Me.Controls.Add(Me.AnchoTXT)
        Me.Controls.Add(Me.LargoTXT)
        Me.Controls.Add(Me.CalidadTXT)
        Me.Controls.Add(Me.OCTXT)
        Me.Controls.Add(Me.FacturaTXT)
        Me.Controls.Add(Me.LoteTXT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EntradaMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entrada de Materia"
        CType(Me.AlmacenBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entradas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoteTXT As TextBox
    Friend WithEvents FacturaTXT As TextBox
    Friend WithEvents OCTXT As TextBox
    Friend WithEvents CalidadTXT As TextBox
    Friend WithEvents LargoTXT As TextBox
    Friend WithEvents AnchoTXT As TextBox
    Friend WithEvents MaterialTXT As TextBox
    Friend WithEvents CantidadTXT As TextBox
    Friend WithEvents UnidadTXT As TextBox
    Friend WithEvents CostoTXT As TextBox
    Friend WithEvents CostokgTXT As TextBox
    Friend WithEvents RackTXT As TextBox
    Friend WithEvents NivelTXT As TextBox
    Friend WithEvents ComentarioTXT As TextBox
    Friend WithEvents noParteTXT As TextBox
    Friend WithEvents FechaTXT As DateTimePicker
    Friend WithEvents AlmacenBD As AlmacenBD
    Friend WithEvents Entradas_MaterialBindingSource As BindingSource
    Friend WithEvents EntradasMaterialTableAdapter As AlmacenBDTableAdapters.EntradasMaterialTableAdapter
    Friend WithEvents TableAdapterManager As AlmacenBDTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents ClienteCMB As ComboBox
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents CalibreCMX As ComboBox
End Class
