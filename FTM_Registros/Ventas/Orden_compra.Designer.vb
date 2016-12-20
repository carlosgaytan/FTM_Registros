<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Orden_compra
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
        Dim Fecha_entrega_cotLabel As System.Windows.Forms.Label
        Dim Orden_compraLabel As System.Windows.Forms.Label
        Dim Fecha_OCLabel As System.Windows.Forms.Label
        Dim Fecha_requeridaLabel As System.Windows.Forms.Label
        Dim Orden_ganadaLabel As System.Windows.Forms.Label
        Dim No_ordenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orden_compra))
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.VentasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VentasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_entrega_cotDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Orden_compraTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_OCDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_requeridaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Orden_ganadaCheckBox = New System.Windows.Forms.CheckBox()
        Me.No_ordenTextBox = New System.Windows.Forms.TextBox()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.UltimoIMG = New System.Windows.Forms.PictureBox()
        Me.PrimerIMG = New System.Windows.Forms.PictureBox()
        Me.SiguienteIMG = New System.Windows.Forms.PictureBox()
        Me.AnteriorIMG = New System.Windows.Forms.PictureBox()
        Fecha_entrega_cotLabel = New System.Windows.Forms.Label()
        Orden_compraLabel = New System.Windows.Forms.Label()
        Fecha_OCLabel = New System.Windows.Forms.Label()
        Fecha_requeridaLabel = New System.Windows.Forms.Label()
        Orden_ganadaLabel = New System.Windows.Forms.Label()
        No_ordenLabel = New System.Windows.Forms.Label()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentasBindingNavigator.SuspendLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltimoIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrimerIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiguienteIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnteriorIMG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Fecha_entrega_cotLabel
        '
        Fecha_entrega_cotLabel.AutoSize = True
        Fecha_entrega_cotLabel.Location = New System.Drawing.Point(12, 132)
        Fecha_entrega_cotLabel.Name = "Fecha_entrega_cotLabel"
        Fecha_entrega_cotLabel.Size = New System.Drawing.Size(97, 13)
        Fecha_entrega_cotLabel.TabIndex = 2
        Fecha_entrega_cotLabel.Text = "Fecha entrega cot:"
        '
        'Orden_compraLabel
        '
        Orden_compraLabel.AutoSize = True
        Orden_compraLabel.Location = New System.Drawing.Point(405, 132)
        Orden_compraLabel.Name = "Orden_compraLabel"
        Orden_compraLabel.Size = New System.Drawing.Size(77, 13)
        Orden_compraLabel.TabIndex = 4
        Orden_compraLabel.Text = "Orden compra:"
        '
        'Fecha_OCLabel
        '
        Fecha_OCLabel.AutoSize = True
        Fecha_OCLabel.Location = New System.Drawing.Point(405, 101)
        Fecha_OCLabel.Name = "Fecha_OCLabel"
        Fecha_OCLabel.Size = New System.Drawing.Size(58, 13)
        Fecha_OCLabel.TabIndex = 6
        Fecha_OCLabel.Text = "Fecha OC:"
        '
        'Fecha_requeridaLabel
        '
        Fecha_requeridaLabel.AutoSize = True
        Fecha_requeridaLabel.Location = New System.Drawing.Point(12, 101)
        Fecha_requeridaLabel.Name = "Fecha_requeridaLabel"
        Fecha_requeridaLabel.Size = New System.Drawing.Size(87, 13)
        Fecha_requeridaLabel.TabIndex = 8
        Fecha_requeridaLabel.Text = "Fecha requerida:"
        '
        'Orden_ganadaLabel
        '
        Orden_ganadaLabel.AutoSize = True
        Orden_ganadaLabel.Location = New System.Drawing.Point(195, 67)
        Orden_ganadaLabel.Name = "Orden_ganadaLabel"
        Orden_ganadaLabel.Size = New System.Drawing.Size(78, 13)
        Orden_ganadaLabel.TabIndex = 10
        Orden_ganadaLabel.Text = "Orden ganada:"
        '
        'No_ordenLabel
        '
        No_ordenLabel.AutoSize = True
        No_ordenLabel.Location = New System.Drawing.Point(12, 67)
        No_ordenLabel.Name = "No_ordenLabel"
        No_ordenLabel.Size = New System.Drawing.Size(57, 13)
        No_ordenLabel.TabIndex = 12
        No_ordenLabel.Text = "No. orden:"
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
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CotizacionesTableAdapter = Nothing
        Me.TableAdapterManager.ManufacturaTableAdapter = Nothing
        Me.TableAdapterManager.tblAdministradorTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'VentasBindingNavigator
        '
        Me.VentasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VentasBindingNavigator.BindingSource = Me.VentasBindingSource
        Me.VentasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VentasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VentasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VentasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VentasBindingNavigatorSaveItem})
        Me.VentasBindingNavigator.Location = New System.Drawing.Point(15, 175)
        Me.VentasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VentasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VentasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VentasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VentasBindingNavigator.Name = "VentasBindingNavigator"
        Me.VentasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VentasBindingNavigator.Size = New System.Drawing.Size(280, 25)
        Me.VentasBindingNavigator.TabIndex = 0
        Me.VentasBindingNavigator.Text = "BindingNavigator1"
        Me.VentasBindingNavigator.Visible = False
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
        'VentasBindingNavigatorSaveItem
        '
        Me.VentasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentasBindingNavigatorSaveItem.Image = CType(resources.GetObject("VentasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VentasBindingNavigatorSaveItem.Name = "VentasBindingNavigatorSaveItem"
        Me.VentasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VentasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'VentasDataGridView
        '
        Me.VentasDataGridView.AllowUserToOrderColumns = True
        Me.VentasDataGridView.AutoGenerateColumns = False
        Me.VentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn17, Me.DataGridViewCheckBoxColumn5, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn3})
        Me.VentasDataGridView.DataSource = Me.VentasBindingSource
        Me.VentasDataGridView.Location = New System.Drawing.Point(12, 206)
        Me.VentasDataGridView.Name = "VentasDataGridView"
        Me.VentasDataGridView.Size = New System.Drawing.Size(674, 280)
        Me.VentasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "no_orden"
        Me.DataGridViewTextBoxColumn7.HeaderText = "no orden"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Nombre_contacto"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Contacto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Correo_electrónico"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Correo electrónico"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Fecha_entrega_cot"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Fecha entrega cot"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Fecha_requerida"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Fecha requerida"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewCheckBoxColumn5
        '
        Me.DataGridViewCheckBoxColumn5.DataPropertyName = "Orden_ganada"
        Me.DataGridViewCheckBoxColumn5.HeaderText = "Orden ganada"
        Me.DataGridViewCheckBoxColumn5.Name = "DataGridViewCheckBoxColumn5"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Fecha_OC"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Fecha OC"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Observaciones"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Observaciones"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Fecha_entrega_cotDateTimePicker
        '
        Me.Fecha_entrega_cotDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha_entrega_cot", True))
        Me.Fecha_entrega_cotDateTimePicker.Location = New System.Drawing.Point(115, 128)
        Me.Fecha_entrega_cotDateTimePicker.Name = "Fecha_entrega_cotDateTimePicker"
        Me.Fecha_entrega_cotDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_entrega_cotDateTimePicker.TabIndex = 3
        '
        'Orden_compraTextBox
        '
        Me.Orden_compraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "Orden_compra", True))
        Me.Orden_compraTextBox.Location = New System.Drawing.Point(488, 129)
        Me.Orden_compraTextBox.Name = "Orden_compraTextBox"
        Me.Orden_compraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Orden_compraTextBox.TabIndex = 5
        '
        'Fecha_OCDateTimePicker
        '
        Me.Fecha_OCDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha_OC", True))
        Me.Fecha_OCDateTimePicker.Location = New System.Drawing.Point(469, 97)
        Me.Fecha_OCDateTimePicker.Name = "Fecha_OCDateTimePicker"
        Me.Fecha_OCDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_OCDateTimePicker.TabIndex = 7
        '
        'Fecha_requeridaDateTimePicker
        '
        Me.Fecha_requeridaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "Fecha_requerida", True))
        Me.Fecha_requeridaDateTimePicker.Location = New System.Drawing.Point(105, 97)
        Me.Fecha_requeridaDateTimePicker.Name = "Fecha_requeridaDateTimePicker"
        Me.Fecha_requeridaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_requeridaDateTimePicker.TabIndex = 9
        '
        'Orden_ganadaCheckBox
        '
        Me.Orden_ganadaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VentasBindingSource, "Orden_ganada", True))
        Me.Orden_ganadaCheckBox.Location = New System.Drawing.Point(279, 62)
        Me.Orden_ganadaCheckBox.Name = "Orden_ganadaCheckBox"
        Me.Orden_ganadaCheckBox.Size = New System.Drawing.Size(16, 24)
        Me.Orden_ganadaCheckBox.TabIndex = 11
        Me.Orden_ganadaCheckBox.UseVisualStyleBackColor = True
        '
        'No_ordenTextBox
        '
        Me.No_ordenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "no_orden", True))
        Me.No_ordenTextBox.Location = New System.Drawing.Point(70, 64)
        Me.No_ordenTextBox.Name = "No_ordenTextBox"
        Me.No_ordenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.No_ordenTextBox.TabIndex = 13
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(576, 173)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 14
        Me.GuardarBTN.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.GuardarBTN, "Guarda Registro")
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 37)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Registro Ordenes de Compra"
        '
        'UltimoIMG
        '
        Me.UltimoIMG.Image = Global.FTM_Registros.My.Resources.Resources.Hopstarter_Button_Button_Last
        Me.UltimoIMG.Location = New System.Drawing.Point(254, 171)
        Me.UltimoIMG.Name = "UltimoIMG"
        Me.UltimoIMG.Size = New System.Drawing.Size(25, 25)
        Me.UltimoIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UltimoIMG.TabIndex = 20
        Me.UltimoIMG.TabStop = False
        Me.ToolTip1.SetToolTip(Me.UltimoIMG, "Último registro")
        '
        'PrimerIMG
        '
        Me.PrimerIMG.Image = Global.FTM_Registros.My.Resources.Resources.Hopstarter_Button_Button_First
        Me.PrimerIMG.Location = New System.Drawing.Point(145, 171)
        Me.PrimerIMG.Name = "PrimerIMG"
        Me.PrimerIMG.Size = New System.Drawing.Size(25, 25)
        Me.PrimerIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PrimerIMG.TabIndex = 21
        Me.PrimerIMG.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PrimerIMG, "Primer registro")
        '
        'SiguienteIMG
        '
        Me.SiguienteIMG.Image = Global.FTM_Registros.My.Resources.Resources.Hopstarter_Button_Button_Fast_Forward__1_
        Me.SiguienteIMG.Location = New System.Drawing.Point(220, 171)
        Me.SiguienteIMG.Name = "SiguienteIMG"
        Me.SiguienteIMG.Size = New System.Drawing.Size(25, 25)
        Me.SiguienteIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SiguienteIMG.TabIndex = 22
        Me.SiguienteIMG.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SiguienteIMG, "Registro siguiente")
        '
        'AnteriorIMG
        '
        Me.AnteriorIMG.Image = Global.FTM_Registros.My.Resources.Resources.Hopstarter_Button_Button_Rewind
        Me.AnteriorIMG.Location = New System.Drawing.Point(176, 171)
        Me.AnteriorIMG.Name = "AnteriorIMG"
        Me.AnteriorIMG.Size = New System.Drawing.Size(25, 25)
        Me.AnteriorIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AnteriorIMG.TabIndex = 23
        Me.AnteriorIMG.TabStop = False
        Me.ToolTip1.SetToolTip(Me.AnteriorIMG, "Registro anterior")
        '
        'Orden_compra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 506)
        Me.Controls.Add(Me.AnteriorIMG)
        Me.Controls.Add(Me.SiguienteIMG)
        Me.Controls.Add(Me.PrimerIMG)
        Me.Controls.Add(Me.UltimoIMG)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(No_ordenLabel)
        Me.Controls.Add(Me.No_ordenTextBox)
        Me.Controls.Add(Orden_ganadaLabel)
        Me.Controls.Add(Me.Orden_ganadaCheckBox)
        Me.Controls.Add(Fecha_requeridaLabel)
        Me.Controls.Add(Me.Fecha_requeridaDateTimePicker)
        Me.Controls.Add(Fecha_OCLabel)
        Me.Controls.Add(Me.Fecha_OCDateTimePicker)
        Me.Controls.Add(Orden_compraLabel)
        Me.Controls.Add(Me.Orden_compraTextBox)
        Me.Controls.Add(Fecha_entrega_cotLabel)
        Me.Controls.Add(Me.Fecha_entrega_cotDateTimePicker)
        Me.Controls.Add(Me.VentasDataGridView)
        Me.Controls.Add(Me.VentasBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Orden_compra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro OC"
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentasBindingNavigator.ResumeLayout(False)
        Me.VentasBindingNavigator.PerformLayout()
        CType(Me.VentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltimoIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrimerIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiguienteIMG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnteriorIMG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasBindingNavigator As BindingNavigator
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
    Friend WithEvents VentasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VentasDataGridView As DataGridView
    Friend WithEvents Fecha_entrega_cotDateTimePicker As DateTimePicker
    Friend WithEvents Orden_compraTextBox As TextBox
    Friend WithEvents Fecha_OCDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_requeridaDateTimePicker As DateTimePicker
    Friend WithEvents Orden_ganadaCheckBox As CheckBox
    Friend WithEvents No_ordenTextBox As TextBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn5 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents UltimoIMG As PictureBox
    Friend WithEvents PrimerIMG As PictureBox
    Friend WithEvents SiguienteIMG As PictureBox
    Friend WithEvents AnteriorIMG As PictureBox
End Class
