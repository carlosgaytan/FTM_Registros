<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Dim Nombre_de_contactoLabel As System.Windows.Forms.Label
        Dim TeléfonoLabel As System.Windows.Forms.Label
        Dim CountryRegionLabel As System.Windows.Forms.Label
        Dim ZIPPostalLabel As System.Windows.Forms.Label
        Dim Correo_electrónicoLabel As System.Windows.Forms.Label
        Dim StateProvinceLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim Dirección1Label As System.Windows.Forms.Label
        Dim __de_clienteLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.VentasTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GuardarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.__de_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Dirección1TextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_electrónicoTextBox = New System.Windows.Forms.TextBox()
        Me.ZIPPostalTextBox = New System.Windows.Forms.TextBox()
        Me.CountryRegionTextBox = New System.Windows.Forms.TextBox()
        Me.TeléfonoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_de_contactoTextBox = New System.Windows.Forms.TextBox()
        Me.StateProvinceComboBox = New System.Windows.Forms.ComboBox()
        Me.TblUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TblUsuariosTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.tblUsuariosTableAdapter()
        Me.TblUsuarioActivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuarioActivoTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Reporte = New System.Windows.Forms.Button()
        Me.Corregir = New System.Windows.Forms.Button()
        Me.Cotizador = New System.Windows.Forms.Button()
        Me.Registros = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Nombre_de_contactoLabel = New System.Windows.Forms.Label()
        TeléfonoLabel = New System.Windows.Forms.Label()
        CountryRegionLabel = New System.Windows.Forms.Label()
        ZIPPostalLabel = New System.Windows.Forms.Label()
        Correo_electrónicoLabel = New System.Windows.Forms.Label()
        StateProvinceLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        Dirección1Label = New System.Windows.Forms.Label()
        __de_clienteLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.TblUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nombre_de_contactoLabel
        '
        Nombre_de_contactoLabel.AutoSize = True
        Nombre_de_contactoLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_de_contactoLabel.Location = New System.Drawing.Point(18, 87)
        Nombre_de_contactoLabel.Name = "Nombre_de_contactoLabel"
        Nombre_de_contactoLabel.Size = New System.Drawing.Size(120, 15)
        Nombre_de_contactoLabel.TabIndex = 18
        Nombre_de_contactoLabel.Text = "Nombre de contacto:"
        '
        'TeléfonoLabel
        '
        TeléfonoLabel.AutoSize = True
        TeléfonoLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TeléfonoLabel.Location = New System.Drawing.Point(18, 291)
        TeléfonoLabel.Name = "TeléfonoLabel"
        TeléfonoLabel.Size = New System.Drawing.Size(56, 15)
        TeléfonoLabel.TabIndex = 16
        TeléfonoLabel.Text = "Teléfono:"
        '
        'CountryRegionLabel
        '
        CountryRegionLabel.AutoSize = True
        CountryRegionLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryRegionLabel.Location = New System.Drawing.Point(18, 230)
        CountryRegionLabel.Name = "CountryRegionLabel"
        CountryRegionLabel.Size = New System.Drawing.Size(83, 15)
        CountryRegionLabel.TabIndex = 14
        CountryRegionLabel.Text = "País o Región:"
        '
        'ZIPPostalLabel
        '
        ZIPPostalLabel.AutoSize = True
        ZIPPostalLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZIPPostalLabel.Location = New System.Drawing.Point(18, 261)
        ZIPPostalLabel.Name = "ZIPPostalLabel"
        ZIPPostalLabel.Size = New System.Drawing.Size(62, 15)
        ZIPPostalLabel.TabIndex = 12
        ZIPPostalLabel.Text = "ZIPPostal:"
        '
        'Correo_electrónicoLabel
        '
        Correo_electrónicoLabel.AutoSize = True
        Correo_electrónicoLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_electrónicoLabel.Location = New System.Drawing.Point(18, 322)
        Correo_electrónicoLabel.Name = "Correo_electrónicoLabel"
        Correo_electrónicoLabel.Size = New System.Drawing.Size(112, 15)
        Correo_electrónicoLabel.TabIndex = 10
        Correo_electrónicoLabel.Text = "Correo electrónico:"
        '
        'StateProvinceLabel
        '
        StateProvinceLabel.AutoSize = True
        StateProvinceLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateProvinceLabel.Location = New System.Drawing.Point(18, 199)
        StateProvinceLabel.Name = "StateProvinceLabel"
        StateProvinceLabel.Size = New System.Drawing.Size(113, 15)
        StateProvinceLabel.TabIndex = 8
        StateProvinceLabel.Text = "Estado o Provincia:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadLabel.Location = New System.Drawing.Point(18, 169)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(49, 15)
        CiudadLabel.TabIndex = 6
        CiudadLabel.Text = "Ciudad:"
        '
        'Dirección1Label
        '
        Dirección1Label.AutoSize = True
        Dirección1Label.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dirección1Label.Location = New System.Drawing.Point(18, 117)
        Dirección1Label.Name = "Dirección1Label"
        Dirección1Label.Size = New System.Drawing.Size(63, 15)
        Dirección1Label.TabIndex = 4
        Dirección1Label.Text = "Dirección:"
        '
        '__de_clienteLabel
        '
        __de_clienteLabel.AutoSize = True
        __de_clienteLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        __de_clienteLabel.Location = New System.Drawing.Point(200, 30)
        __de_clienteLabel.Name = "__de_clienteLabel"
        __de_clienteLabel.Size = New System.Drawing.Size(72, 15)
        __de_clienteLabel.TabIndex = 2
        __de_clienteLabel.Text = "# de cliente:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel.Location = New System.Drawing.Point(18, 30)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(114, 15)
        ClienteLabel.TabIndex = 0
        ClienteLabel.Text = "Nombre del Cliente:"
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
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.CotizacionesTableAdapter = Nothing
        Me.TableAdapterManager.ManufacturaTableAdapter = Nothing
        Me.TableAdapterManager.tblAdministradorTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ClientesDataGridView)
        Me.TabPage1.Controls.Add(Me.BindingNavigator2)
        Me.TabPage1.Controls.Add(ClienteLabel)
        Me.TabPage1.Controls.Add(Me.ClienteTextBox)
        Me.TabPage1.Controls.Add(Me.__de_clienteTextBox)
        Me.TabPage1.Controls.Add(Me.Dirección1TextBox)
        Me.TabPage1.Controls.Add(Me.CiudadTextBox)
        Me.TabPage1.Controls.Add(Me.Correo_electrónicoTextBox)
        Me.TabPage1.Controls.Add(Me.ZIPPostalTextBox)
        Me.TabPage1.Controls.Add(Me.CountryRegionTextBox)
        Me.TabPage1.Controls.Add(Me.TeléfonoTextBox)
        Me.TabPage1.Controls.Add(Me.Nombre_de_contactoTextBox)
        Me.TabPage1.Controls.Add(__de_clienteLabel)
        Me.TabPage1.Controls.Add(Dirección1Label)
        Me.TabPage1.Controls.Add(CiudadLabel)
        Me.TabPage1.Controls.Add(StateProvinceLabel)
        Me.TabPage1.Controls.Add(Me.StateProvinceComboBox)
        Me.TabPage1.Controls.Add(Correo_electrónicoLabel)
        Me.TabPage1.Controls.Add(ZIPPostalLabel)
        Me.TabPage1.Controls.Add(CountryRegionLabel)
        Me.TabPage1.Controls.Add(TeléfonoLabel)
        Me.TabPage1.Controls.Add(Nombre_de_contactoLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(815, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn7})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(419, 46)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(390, 291)
        Me.ClientesDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "# de cliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "# de cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Nombre de contacto"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Teléfono"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Teléfono"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Correo electrónico"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Correo electrónico"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dirección1"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dirección"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ciudad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "StateProvince"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "CountryRegion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "País"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ZIPPostal"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ZIPPostal"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.ClientesBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GuardarToolStripButton, Me.toolStripSeparator})
        Me.BindingNavigator2.Location = New System.Drawing.Point(220, 404)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(286, 25)
        Me.BindingNavigator2.TabIndex = 20
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Cliente", True))
        Me.ClienteTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteTextBox.Location = New System.Drawing.Point(21, 46)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(150, 23)
        Me.ClienteTextBox.TabIndex = 1
        '
        '__de_clienteTextBox
        '
        Me.__de_clienteTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.__de_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "# de cliente", True))
        Me.__de_clienteTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.__de_clienteTextBox.Location = New System.Drawing.Point(203, 46)
        Me.__de_clienteTextBox.Name = "__de_clienteTextBox"
        Me.__de_clienteTextBox.Size = New System.Drawing.Size(63, 23)
        Me.__de_clienteTextBox.TabIndex = 3
        '
        'Dirección1TextBox
        '
        Me.Dirección1TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Dirección1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Dirección1", True))
        Me.Dirección1TextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dirección1TextBox.Location = New System.Drawing.Point(144, 114)
        Me.Dirección1TextBox.Multiline = True
        Me.Dirección1TextBox.Name = "Dirección1TextBox"
        Me.Dirección1TextBox.Size = New System.Drawing.Size(240, 43)
        Me.Dirección1TextBox.TabIndex = 5
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Ciudad", True))
        Me.CiudadTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadTextBox.Location = New System.Drawing.Point(144, 166)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(240, 23)
        Me.CiudadTextBox.TabIndex = 7
        '
        'Correo_electrónicoTextBox
        '
        Me.Correo_electrónicoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Correo_electrónicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Correo electrónico", True))
        Me.Correo_electrónicoTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correo_electrónicoTextBox.Location = New System.Drawing.Point(144, 319)
        Me.Correo_electrónicoTextBox.Name = "Correo_electrónicoTextBox"
        Me.Correo_electrónicoTextBox.Size = New System.Drawing.Size(240, 23)
        Me.Correo_electrónicoTextBox.TabIndex = 11
        '
        'ZIPPostalTextBox
        '
        Me.ZIPPostalTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ZIPPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ZIPPostal", True))
        Me.ZIPPostalTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPPostalTextBox.Location = New System.Drawing.Point(144, 258)
        Me.ZIPPostalTextBox.Name = "ZIPPostalTextBox"
        Me.ZIPPostalTextBox.Size = New System.Drawing.Size(122, 23)
        Me.ZIPPostalTextBox.TabIndex = 13
        '
        'CountryRegionTextBox
        '
        Me.CountryRegionTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CountryRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CountryRegion", True))
        Me.CountryRegionTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryRegionTextBox.Location = New System.Drawing.Point(144, 227)
        Me.CountryRegionTextBox.Name = "CountryRegionTextBox"
        Me.CountryRegionTextBox.Size = New System.Drawing.Size(240, 23)
        Me.CountryRegionTextBox.TabIndex = 15
        '
        'TeléfonoTextBox
        '
        Me.TeléfonoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.TeléfonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Teléfono", True))
        Me.TeléfonoTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TeléfonoTextBox.Location = New System.Drawing.Point(144, 288)
        Me.TeléfonoTextBox.Name = "TeléfonoTextBox"
        Me.TeléfonoTextBox.Size = New System.Drawing.Size(240, 23)
        Me.TeléfonoTextBox.TabIndex = 17
        '
        'Nombre_de_contactoTextBox
        '
        Me.Nombre_de_contactoTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.Nombre_de_contactoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre de contacto", True))
        Me.Nombre_de_contactoTextBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_de_contactoTextBox.Location = New System.Drawing.Point(144, 84)
        Me.Nombre_de_contactoTextBox.Name = "Nombre_de_contactoTextBox"
        Me.Nombre_de_contactoTextBox.Size = New System.Drawing.Size(240, 23)
        Me.Nombre_de_contactoTextBox.TabIndex = 19
        '
        'StateProvinceComboBox
        '
        Me.StateProvinceComboBox.BackColor = System.Drawing.SystemColors.Window
        Me.StateProvinceComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "StateProvince", True))
        Me.StateProvinceComboBox.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateProvinceComboBox.FormattingEnabled = True
        Me.StateProvinceComboBox.Items.AddRange(New Object() {"Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Ciudad de México", "Coahuila", "Colima", "Durango", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "México", "Michoacán", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz", "Yucatán", "Zacatecas"})
        Me.StateProvinceComboBox.Location = New System.Drawing.Point(144, 196)
        Me.StateProvinceComboBox.Name = "StateProvinceComboBox"
        Me.StateProvinceComboBox.Size = New System.Drawing.Size(240, 23)
        Me.StateProvinceComboBox.TabIndex = 9
        '
        'TblUsuariosBindingSource
        '
        Me.TblUsuariosBindingSource.DataMember = "tblUsuarios"
        Me.TblUsuariosBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(152, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(823, 531)
        Me.TabControl1.TabIndex = 0
        '
        'TblUsuariosTableAdapter
        '
        Me.TblUsuariosTableAdapter.ClearBeforeFill = True
        '
        'TblUsuarioActivoBindingSource
        '
        Me.TblUsuarioActivoBindingSource.DataMember = "tblUsuarioActivo"
        Me.TblUsuarioActivoBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'TblUsuarioActivoTableAdapter
        '
        Me.TblUsuarioActivoTableAdapter.ClearBeforeFill = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Reporte)
        Me.Panel1.Controls.Add(Me.Corregir)
        Me.Panel1.Controls.Add(Me.Cotizador)
        Me.Panel1.Controls.Add(Me.Registros)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(134, 556)
        Me.Panel1.TabIndex = 22
        '
        'Reporte
        '
        Me.Reporte.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.document_icon_icons_com_66534
        Me.Reporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reporte.Location = New System.Drawing.Point(26, 425)
        Me.Reporte.Name = "Reporte"
        Me.Reporte.Size = New System.Drawing.Size(83, 79)
        Me.Reporte.TabIndex = 25
        Me.Reporte.Text = "Generar cotización"
        Me.Reporte.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Reporte.UseVisualStyleBackColor = True
        '
        'Corregir
        '
        Me.Corregir.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Ban_icon_icons_com_53710
        Me.Corregir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corregir.Location = New System.Drawing.Point(26, 319)
        Me.Corregir.Name = "Corregir"
        Me.Corregir.Size = New System.Drawing.Size(83, 79)
        Me.Corregir.TabIndex = 24
        Me.Corregir.Text = "Corregir costos"
        Me.Corregir.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Corregir.UseVisualStyleBackColor = True
        '
        'Cotizador
        '
        Me.Cotizador.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Affiliate_Marketing_icon_icons_com_53702
        Me.Cotizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cotizador.Location = New System.Drawing.Point(26, 215)
        Me.Cotizador.Name = "Cotizador"
        Me.Cotizador.Size = New System.Drawing.Size(83, 79)
        Me.Cotizador.TabIndex = 23
        Me.Cotizador.Text = "Cotizador"
        Me.Cotizador.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Cotizador.UseVisualStyleBackColor = True
        '
        'Registros
        '
        Me.Registros.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Blog_icon_icons_com_53707
        Me.Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registros.ForeColor = System.Drawing.Color.Black
        Me.Registros.Location = New System.Drawing.Point(26, 116)
        Me.Registros.Name = "Registros"
        Me.Registros.Size = New System.Drawing.Size(83, 79)
        Me.Registros.TabIndex = 22
        Me.Registros.Text = "Registro " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ordenes"
        Me.Registros.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Registros.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 54)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Procesos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ventas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(993, 555)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.TblUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents __de_clienteTextBox As TextBox
    Friend WithEvents Dirección1TextBox As TextBox
    Friend WithEvents CiudadTextBox As TextBox
    Friend WithEvents Correo_electrónicoTextBox As TextBox
    Friend WithEvents ZIPPostalTextBox As TextBox
    Friend WithEvents CountryRegionTextBox As TextBox
    Friend WithEvents TeléfonoTextBox As TextBox
    Friend WithEvents Nombre_de_contactoTextBox As TextBox
    Friend WithEvents StateProvinceComboBox As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TblUsuariosBindingSource As BindingSource
    Friend WithEvents TblUsuariosTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.tblUsuariosTableAdapter
    Friend WithEvents TblUsuarioActivoBindingSource As BindingSource
    Friend WithEvents TblUsuarioActivoTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Reporte As Button
    Friend WithEvents Corregir As Button
    Friend WithEvents Cotizador As Button
    Friend WithEvents Registros As Button
End Class
