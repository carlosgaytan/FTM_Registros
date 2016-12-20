<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reporte_Cotizar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Cotizar))
        Me.CotizacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCotizar = New FTM_Registros.ReporteCotizar()
        Me.CostosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCotizar1 = New FTM_Registros.ReporteCotizar1()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCotizar2 = New FTM_Registros.ReporteCotizar2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarOrden = New System.Windows.Forms.ComboBox()
        Me.VentasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarCBXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarCBX = New FTM_Registros.BuscarCBX()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarVentasTableAdapter = New FTM_Registros.BuscarCBXTableAdapters.BuscarVentasTableAdapter()
        Me.CotizacionesTableAdapter = New FTM_Registros.ReporteCotizarTableAdapters.CotizacionesTableAdapter()
        Me.CostosTableAdapter = New FTM_Registros.ReporteCotizar1TableAdapters.CostosTableAdapter()
        Me.VentaTableAdapter = New FTM_Registros.ReporteCotizar2TableAdapters.VentaTableAdapter()
        Me.Buscar = New System.Windows.Forms.Button()
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter()
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCotizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCotizar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCotizar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarCBXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarCBX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CotizacionesBindingSource
        '
        Me.CotizacionesBindingSource.DataMember = "Cotizaciones"
        Me.CotizacionesBindingSource.DataSource = Me.ReporteCotizar
        '
        'ReporteCotizar
        '
        Me.ReporteCotizar.DataSetName = "ReporteCotizar"
        Me.ReporteCotizar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostosBindingSource
        '
        Me.CostosBindingSource.DataMember = "Costos"
        Me.CostosBindingSource.DataSource = Me.ReporteCotizar1
        '
        'ReporteCotizar1
        '
        Me.ReporteCotizar1.DataSetName = "ReporteCotizar1"
        Me.ReporteCotizar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.ReporteCotizar2
        '
        'ReporteCotizar2
        '
        Me.ReporteCotizar2.DataSetName = "ReporteCotizar2"
        Me.ReporteCotizar2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Cotizaciones"
        ReportDataSource1.Value = Me.CotizacionesBindingSource
        ReportDataSource2.Name = "Costos"
        ReportDataSource2.Value = Me.CostosBindingSource
        ReportDataSource3.Name = "Ventas"
        ReportDataSource3.Value = Me.VentaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FTM_Registros.Reporte_Cotizar.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(974, 525)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuscarOrden
        '
        Me.BuscarOrden.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BuscarOrden.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BuscarOrden.DataSource = Me.VentasBindingSource2
        Me.BuscarOrden.DisplayMember = "no_orden"
        Me.BuscarOrden.FormattingEnabled = True
        Me.BuscarOrden.Location = New System.Drawing.Point(13, 2)
        Me.BuscarOrden.Name = "BuscarOrden"
        Me.BuscarOrden.Size = New System.Drawing.Size(121, 21)
        Me.BuscarOrden.TabIndex = 2
        Me.BuscarOrden.ValueMember = "no_orden"
        '
        'VentasBindingSource2
        '
        Me.VentasBindingSource2.DataMember = "Ventas"
        Me.VentasBindingSource2.DataSource = Me.BuscarCBXBindingSource
        '
        'BuscarCBXBindingSource
        '
        Me.BuscarCBXBindingSource.DataSource = Me.BuscarCBX
        Me.BuscarCBXBindingSource.Position = 0
        '
        'BuscarCBX
        '
        Me.BuscarCBX.DataSetName = "BuscarCBX"
        Me.BuscarCBX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.BuscarCBX
        '
        'BuscarVentasTableAdapter
        '
        Me.BuscarVentasTableAdapter.ClearBeforeFill = True
        '
        'CotizacionesTableAdapter
        '
        Me.CotizacionesTableAdapter.ClearBeforeFill = True
        '
        'CostosTableAdapter
        '
        Me.CostosTableAdapter.ClearBeforeFill = True
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(151, 0)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 3
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "Ventas"
        Me.VentasBindingSource1.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'Reporte_Cotizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 549)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.BuscarOrden)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Reporte_Cotizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Cotizaciones"
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCotizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCotizar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCotizar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarCBXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarCBX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BuscarOrden As ComboBox
    Friend WithEvents BuscarCBX As BuscarCBX
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents BuscarVentasTableAdapter As BuscarCBXTableAdapters.BuscarVentasTableAdapter
    Friend WithEvents CotizacionesBindingSource As BindingSource
    Friend WithEvents ReporteCotizar As ReporteCotizar
    Friend WithEvents CostosBindingSource As BindingSource
    Friend WithEvents ReporteCotizar1 As ReporteCotizar1
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents ReporteCotizar2 As ReporteCotizar2
    Friend WithEvents CotizacionesTableAdapter As ReporteCotizarTableAdapters.CotizacionesTableAdapter
    Friend WithEvents CostosTableAdapter As ReporteCotizar1TableAdapters.CostosTableAdapter
    Friend WithEvents VentaTableAdapter As ReporteCotizar2TableAdapters.VentaTableAdapter
    Friend WithEvents Buscar As Button
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents VentasBindingSource1 As BindingSource
    Friend WithEvents VentasTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents VentasBindingSource2 As BindingSource
    Friend WithEvents BuscarCBXBindingSource As BindingSource
End Class
