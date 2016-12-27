<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prog_Ventas
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
        Me.ProgresoVentas = New FTM_Registros.ProgresoVentas()
        Me.BuscaVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscaVentasTableAdapter = New FTM_Registros.ProgresoVentasTableAdapters.BuscaVentasTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProgresoVentasTableAdapters.TableAdapterManager()
        Me.BuscaVentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_requerida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden_ganada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fecha_entrega_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_OC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesLTB = New System.Windows.Forms.ComboBox()
        Me.BuscarBTN = New System.Windows.Forms.Button()
        Me.LlaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoordenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechasolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FecharequeridaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdenganadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FechaentregacotDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdencompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaOCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscaVentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProgresoVentas
        '
        Me.ProgresoVentas.DataSetName = "ProgresoVentas"
        Me.ProgresoVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscaVentasBindingSource
        '
        Me.BuscaVentasBindingSource.DataMember = "BuscaVentas"
        Me.BuscaVentasBindingSource.DataSource = Me.ProgresoVentas
        '
        'BuscaVentasTableAdapter
        '
        Me.BuscaVentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuscaVentasTableAdapter = Me.BuscaVentasTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.ProgresoVentasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuscaVentasDataGridView
        '
        Me.BuscaVentasDataGridView.AutoGenerateColumns = False
        Me.BuscaVentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuscaVentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.no_orden, Me.Fecha_solicitud, Me.Fecha_requerida, Me.Mes, Me.Orden_ganada, Me.Fecha_entrega_cot, Me.Orden_compra, Me.Fecha_OC, Me.LlaveDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.NoordenDataGridViewTextBoxColumn, Me.FechasolicitudDataGridViewTextBoxColumn, Me.FecharequeridaDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.OrdenganadaDataGridViewCheckBoxColumn, Me.FechaentregacotDataGridViewTextBoxColumn, Me.OrdencompraDataGridViewTextBoxColumn, Me.FechaOCDataGridViewTextBoxColumn})
        Me.BuscaVentasDataGridView.DataSource = Me.BuscaVentasBindingSource
        Me.BuscaVentasDataGridView.Location = New System.Drawing.Point(6, 33)
        Me.BuscaVentasDataGridView.Name = "BuscaVentasDataGridView"
        Me.BuscaVentasDataGridView.Size = New System.Drawing.Size(763, 420)
        Me.BuscaVentasDataGridView.TabIndex = 2
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'no_orden
        '
        Me.no_orden.DataPropertyName = "no_orden"
        Me.no_orden.HeaderText = "No. orden"
        Me.no_orden.Name = "no_orden"
        '
        'Fecha_solicitud
        '
        Me.Fecha_solicitud.DataPropertyName = "Fecha_solicitud"
        Me.Fecha_solicitud.HeaderText = "Fecha de registro"
        Me.Fecha_solicitud.Name = "Fecha_solicitud"
        '
        'Fecha_requerida
        '
        Me.Fecha_requerida.DataPropertyName = "Fecha_requerida"
        Me.Fecha_requerida.HeaderText = "Fecha requerida"
        Me.Fecha_requerida.Name = "Fecha_requerida"
        '
        'Mes
        '
        Me.Mes.DataPropertyName = "Mes"
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Name = "Mes"
        Me.Mes.Visible = False
        '
        'Orden_ganada
        '
        Me.Orden_ganada.DataPropertyName = "Orden_ganada"
        Me.Orden_ganada.HeaderText = "Orden ganada"
        Me.Orden_ganada.Name = "Orden_ganada"
        '
        'Fecha_entrega_cot
        '
        Me.Fecha_entrega_cot.DataPropertyName = "Fecha_entrega_cot"
        Me.Fecha_entrega_cot.HeaderText = "Fecha entrega cot"
        Me.Fecha_entrega_cot.Name = "Fecha_entrega_cot"
        '
        'Orden_compra
        '
        Me.Orden_compra.DataPropertyName = "Orden_compra"
        Me.Orden_compra.HeaderText = "Orden compra"
        Me.Orden_compra.Name = "Orden_compra"
        '
        'Fecha_OC
        '
        Me.Fecha_OC.DataPropertyName = "Fecha_OC"
        Me.Fecha_OC.HeaderText = "Fecha OC"
        Me.Fecha_OC.Name = "Fecha_OC"
        '
        'MesLTB
        '
        Me.MesLTB.FormattingEnabled = True
        Me.MesLTB.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesLTB.Location = New System.Drawing.Point(3, 6)
        Me.MesLTB.Name = "MesLTB"
        Me.MesLTB.Size = New System.Drawing.Size(121, 21)
        Me.MesLTB.TabIndex = 3
        '
        'BuscarBTN
        '
        Me.BuscarBTN.Location = New System.Drawing.Point(146, 4)
        Me.BuscarBTN.Name = "BuscarBTN"
        Me.BuscarBTN.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBTN.TabIndex = 4
        Me.BuscarBTN.Text = "Buscar"
        Me.BuscarBTN.UseVisualStyleBackColor = True
        '
        'LlaveDataGridViewTextBoxColumn
        '
        Me.LlaveDataGridViewTextBoxColumn.DataPropertyName = "Llave"
        Me.LlaveDataGridViewTextBoxColumn.HeaderText = "Llave"
        Me.LlaveDataGridViewTextBoxColumn.Name = "LlaveDataGridViewTextBoxColumn"
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        '
        'NoordenDataGridViewTextBoxColumn
        '
        Me.NoordenDataGridViewTextBoxColumn.DataPropertyName = "no_orden"
        Me.NoordenDataGridViewTextBoxColumn.HeaderText = "no_orden"
        Me.NoordenDataGridViewTextBoxColumn.Name = "NoordenDataGridViewTextBoxColumn"
        '
        'FechasolicitudDataGridViewTextBoxColumn
        '
        Me.FechasolicitudDataGridViewTextBoxColumn.DataPropertyName = "Fecha_solicitud"
        Me.FechasolicitudDataGridViewTextBoxColumn.HeaderText = "Fecha_solicitud"
        Me.FechasolicitudDataGridViewTextBoxColumn.Name = "FechasolicitudDataGridViewTextBoxColumn"
        '
        'FecharequeridaDataGridViewTextBoxColumn
        '
        Me.FecharequeridaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_requerida"
        Me.FecharequeridaDataGridViewTextBoxColumn.HeaderText = "Fecha_requerida"
        Me.FecharequeridaDataGridViewTextBoxColumn.Name = "FecharequeridaDataGridViewTextBoxColumn"
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        '
        'OrdenganadaDataGridViewCheckBoxColumn
        '
        Me.OrdenganadaDataGridViewCheckBoxColumn.DataPropertyName = "Orden_ganada"
        Me.OrdenganadaDataGridViewCheckBoxColumn.HeaderText = "Orden_ganada"
        Me.OrdenganadaDataGridViewCheckBoxColumn.Name = "OrdenganadaDataGridViewCheckBoxColumn"
        '
        'FechaentregacotDataGridViewTextBoxColumn
        '
        Me.FechaentregacotDataGridViewTextBoxColumn.DataPropertyName = "Fecha_entrega_cot"
        Me.FechaentregacotDataGridViewTextBoxColumn.HeaderText = "Fecha_entrega_cot"
        Me.FechaentregacotDataGridViewTextBoxColumn.Name = "FechaentregacotDataGridViewTextBoxColumn"
        '
        'OrdencompraDataGridViewTextBoxColumn
        '
        Me.OrdencompraDataGridViewTextBoxColumn.DataPropertyName = "Orden_compra"
        Me.OrdencompraDataGridViewTextBoxColumn.HeaderText = "Orden_compra"
        Me.OrdencompraDataGridViewTextBoxColumn.Name = "OrdencompraDataGridViewTextBoxColumn"
        '
        'FechaOCDataGridViewTextBoxColumn
        '
        Me.FechaOCDataGridViewTextBoxColumn.DataPropertyName = "Fecha_OC"
        Me.FechaOCDataGridViewTextBoxColumn.HeaderText = "Fecha_OC"
        Me.FechaOCDataGridViewTextBoxColumn.Name = "FechaOCDataGridViewTextBoxColumn"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(783, 485)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MesLTB)
        Me.TabPage1.Controls.Add(Me.BuscaVentasDataGridView)
        Me.TabPage1.Controls.Add(Me.BuscarBTN)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(775, 459)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Progreso ventas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Prog_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 497)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(450, 147)
        Me.Name = "Prog_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Prrog_Ventas"
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscaVentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProgresoVentas As ProgresoVentas
    Friend WithEvents BuscaVentasBindingSource As BindingSource
    Friend WithEvents BuscaVentasTableAdapter As ProgresoVentasTableAdapters.BuscaVentasTableAdapter
    Friend WithEvents TableAdapterManager As ProgresoVentasTableAdapters.TableAdapterManager
    Friend WithEvents BuscaVentasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents MesLTB As ComboBox
    Friend WithEvents BuscarBTN As Button
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents no_orden As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_solicitud As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_requerida As DataGridViewTextBoxColumn
    Friend WithEvents Mes As DataGridViewTextBoxColumn
    Friend WithEvents Orden_ganada As DataGridViewCheckBoxColumn
    Friend WithEvents Fecha_entrega_cot As DataGridViewTextBoxColumn
    Friend WithEvents Orden_compra As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_OC As DataGridViewTextBoxColumn
    Friend WithEvents LlaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoordenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechasolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FecharequeridaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdenganadaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FechaentregacotDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrdencompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaOCDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
End Class
