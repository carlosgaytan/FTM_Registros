<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prueba
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prueba))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoordenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveFTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DibujoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspesorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciofinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CotizadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCotizar1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCotizar1 = New FTM_Registros.ReporteCotizar1()
        Me.CostosTableAdapter = New FTM_Registros.ReporteCotizar1TableAdapters.CostosTableAdapter()
        Me.BuscarOrden = New System.Windows.Forms.TextBox()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.CostosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FTM_Registros.ReporteCotizar1TableAdapters.TableAdapterManager()
        Me.MostrarCostosToolStrip = New System.Windows.Forms.ToolStrip()
        Me.No_ordenToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.No_ordenToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.MostrarCostosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCotizar1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCotizar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MostrarCostosToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoordenDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.ClaveFTMDataGridViewTextBoxColumn, Me.DibujoDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.EspesorDataGridViewTextBoxColumn, Me.PreciofinalDataGridViewTextBoxColumn, Me.PrecioTotalDataGridViewTextBoxColumn, Me.CotizadorDataGridViewTextBoxColumn, Me.UmDataGridViewTextBoxColumn, Me.CantidadesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CostosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(56, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(871, 419)
        Me.DataGridView1.TabIndex = 0
        '
        'NoordenDataGridViewTextBoxColumn
        '
        Me.NoordenDataGridViewTextBoxColumn.DataPropertyName = "no_orden"
        Me.NoordenDataGridViewTextBoxColumn.HeaderText = "no_orden"
        Me.NoordenDataGridViewTextBoxColumn.Name = "NoordenDataGridViewTextBoxColumn"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        '
        'ClaveFTMDataGridViewTextBoxColumn
        '
        Me.ClaveFTMDataGridViewTextBoxColumn.DataPropertyName = "Clave_FTM"
        Me.ClaveFTMDataGridViewTextBoxColumn.HeaderText = "Clave_FTM"
        Me.ClaveFTMDataGridViewTextBoxColumn.Name = "ClaveFTMDataGridViewTextBoxColumn"
        '
        'DibujoDataGridViewTextBoxColumn
        '
        Me.DibujoDataGridViewTextBoxColumn.DataPropertyName = "Dibujo"
        Me.DibujoDataGridViewTextBoxColumn.HeaderText = "Dibujo"
        Me.DibujoDataGridViewTextBoxColumn.Name = "DibujoDataGridViewTextBoxColumn"
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        '
        'MaterialDataGridViewTextBoxColumn
        '
        Me.MaterialDataGridViewTextBoxColumn.DataPropertyName = "Material"
        Me.MaterialDataGridViewTextBoxColumn.HeaderText = "Material"
        Me.MaterialDataGridViewTextBoxColumn.Name = "MaterialDataGridViewTextBoxColumn"
        '
        'EspesorDataGridViewTextBoxColumn
        '
        Me.EspesorDataGridViewTextBoxColumn.DataPropertyName = "Espesor"
        Me.EspesorDataGridViewTextBoxColumn.HeaderText = "Espesor"
        Me.EspesorDataGridViewTextBoxColumn.Name = "EspesorDataGridViewTextBoxColumn"
        '
        'PreciofinalDataGridViewTextBoxColumn
        '
        Me.PreciofinalDataGridViewTextBoxColumn.DataPropertyName = "Precio_final"
        Me.PreciofinalDataGridViewTextBoxColumn.HeaderText = "Precio_final"
        Me.PreciofinalDataGridViewTextBoxColumn.Name = "PreciofinalDataGridViewTextBoxColumn"
        '
        'PrecioTotalDataGridViewTextBoxColumn
        '
        Me.PrecioTotalDataGridViewTextBoxColumn.DataPropertyName = "Precio_Total"
        Me.PrecioTotalDataGridViewTextBoxColumn.HeaderText = "Precio_Total"
        Me.PrecioTotalDataGridViewTextBoxColumn.Name = "PrecioTotalDataGridViewTextBoxColumn"
        '
        'CotizadorDataGridViewTextBoxColumn
        '
        Me.CotizadorDataGridViewTextBoxColumn.DataPropertyName = "Cotizador"
        Me.CotizadorDataGridViewTextBoxColumn.HeaderText = "Cotizador"
        Me.CotizadorDataGridViewTextBoxColumn.Name = "CotizadorDataGridViewTextBoxColumn"
        '
        'UmDataGridViewTextBoxColumn
        '
        Me.UmDataGridViewTextBoxColumn.DataPropertyName = "um"
        Me.UmDataGridViewTextBoxColumn.HeaderText = "um"
        Me.UmDataGridViewTextBoxColumn.Name = "UmDataGridViewTextBoxColumn"
        '
        'CantidadesDataGridViewTextBoxColumn
        '
        Me.CantidadesDataGridViewTextBoxColumn.DataPropertyName = "Cantidades"
        Me.CantidadesDataGridViewTextBoxColumn.HeaderText = "Cantidades"
        Me.CantidadesDataGridViewTextBoxColumn.Name = "CantidadesDataGridViewTextBoxColumn"
        '
        'CostosBindingSource
        '
        Me.CostosBindingSource.DataMember = "Costos"
        Me.CostosBindingSource.DataSource = Me.ReporteCotizar1BindingSource
        '
        'ReporteCotizar1BindingSource
        '
        Me.ReporteCotizar1BindingSource.DataSource = Me.ReporteCotizar1
        Me.ReporteCotizar1BindingSource.Position = 0
        '
        'ReporteCotizar1
        '
        Me.ReporteCotizar1.DataSetName = "ReporteCotizar1"
        Me.ReporteCotizar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CostosTableAdapter
        '
        Me.CostosTableAdapter.ClearBeforeFill = True
        '
        'BuscarOrden
        '
        Me.BuscarOrden.Location = New System.Drawing.Point(56, 35)
        Me.BuscarOrden.Name = "BuscarOrden"
        Me.BuscarOrden.Size = New System.Drawing.Size(100, 20)
        Me.BuscarOrden.TabIndex = 1
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(173, 32)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 2
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(173, 61)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 3
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'CostosBindingSource1
        '
        Me.CostosBindingSource1.DataMember = "Costos"
        Me.CostosBindingSource1.DataSource = Me.ReporteCotizar1
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CostosTableAdapter = Me.CostosTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.ReporteCotizar1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MostrarCostosToolStrip
        '
        Me.MostrarCostosToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.No_ordenToolStripLabel, Me.No_ordenToolStripTextBox, Me.MostrarCostosToolStripButton, Me.GuardarToolStripButton})
        Me.MostrarCostosToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.MostrarCostosToolStrip.Name = "MostrarCostosToolStrip"
        Me.MostrarCostosToolStrip.Size = New System.Drawing.Size(970, 25)
        Me.MostrarCostosToolStrip.TabIndex = 4
        Me.MostrarCostosToolStrip.Text = "MostrarCostosToolStrip"
        '
        'No_ordenToolStripLabel
        '
        Me.No_ordenToolStripLabel.Name = "No_ordenToolStripLabel"
        Me.No_ordenToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.No_ordenToolStripLabel.Text = "no_orden:"
        '
        'No_ordenToolStripTextBox
        '
        Me.No_ordenToolStripTextBox.Name = "No_ordenToolStripTextBox"
        Me.No_ordenToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'MostrarCostosToolStripButton
        '
        Me.MostrarCostosToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.MostrarCostosToolStripButton.Name = "MostrarCostosToolStripButton"
        Me.MostrarCostosToolStripButton.Size = New System.Drawing.Size(88, 22)
        Me.MostrarCostosToolStripButton.Text = "MostrarCostos"
        '
        'GuardarToolStripButton
        '
        Me.GuardarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton.Image = CType(resources.GetObject("GuardarToolStripButton.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton.Name = "GuardarToolStripButton"
        Me.GuardarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton.Text = "&Guardar"
        '
        'Prueba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 624)
        Me.Controls.Add(Me.MostrarCostosToolStrip)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.BuscarOrden)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Prueba"
        Me.Text = "Prueba"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCotizar1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCotizar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MostrarCostosToolStrip.ResumeLayout(False)
        Me.MostrarCostosToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReporteCotizar1BindingSource As BindingSource
    Friend WithEvents ReporteCotizar1 As ReporteCotizar1
    Friend WithEvents CostosBindingSource As BindingSource
    Friend WithEvents CostosTableAdapter As ReporteCotizar1TableAdapters.CostosTableAdapter
    Friend WithEvents BuscarOrden As TextBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Guardar As Button
    Friend WithEvents NoordenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveFTMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DibujoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspesorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciofinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CotizadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostosBindingSource1 As BindingSource
    Friend WithEvents TableAdapterManager As ReporteCotizar1TableAdapters.TableAdapterManager
    Friend WithEvents MostrarCostosToolStrip As ToolStrip
    Friend WithEvents No_ordenToolStripLabel As ToolStripLabel
    Friend WithEvents No_ordenToolStripTextBox As ToolStripTextBox
    Friend WithEvents MostrarCostosToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton As ToolStripButton
End Class
