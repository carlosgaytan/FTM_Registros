<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Entrar = New System.Windows.Forms.Button()
        Me.TxtIdUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.TblUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuariosTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.tblUsuariosTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblUsuariosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblUsuariosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.IdUsuarioListBox = New System.Windows.Forms.ListBox()
        Me.TblUsuariosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuariosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuariosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblIncorrecto = New System.Windows.Forms.Label()
        Me.TblUsuarioActivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HoraTextBox = New System.Windows.Forms.TextBox()
        Me.DiaTextBox = New System.Windows.Forms.TextBox()
        Me.Basededatos14beDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuarioActivoTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuarioTextBox = New System.Windows.Forms.TextBox()
        Me.GUARDARCHBX = New System.Windows.Forms.CheckBox()
        Me.NameTXT = New System.Windows.Forms.TextBox()
        Me.PasswordTXT = New System.Windows.Forms.TextBox()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblUsuariosBindingNavigator.SuspendLayout()
        CType(Me.TblUsuariosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuariosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuariosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Basededatos14beDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Entrar
        '
        Me.Entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Entrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Entrar.Location = New System.Drawing.Point(173, 324)
        Me.Entrar.Name = "Entrar"
        Me.Entrar.Size = New System.Drawing.Size(106, 32)
        Me.Entrar.TabIndex = 3
        Me.Entrar.Text = "Entrar"
        Me.Entrar.UseVisualStyleBackColor = True
        '
        'TxtIdUsuario
        '
        Me.TxtIdUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtIdUsuario.Cursor = System.Windows.Forms.Cursors.Default
        Me.TxtIdUsuario.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdUsuario.Location = New System.Drawing.Point(345, 318)
        Me.TxtIdUsuario.Name = "TxtIdUsuario"
        Me.TxtIdUsuario.Size = New System.Drawing.Size(71, 20)
        Me.TxtIdUsuario.TabIndex = 0
        Me.TxtIdUsuario.Visible = False
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtContraseña.Location = New System.Drawing.Point(130, 270)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(196, 20)
        Me.txtContraseña.TabIndex = 2
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.Transparent
        Me.Fecha.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(126, 404)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(62, 26)
        Me.Fecha.TabIndex = 4
        Me.Fecha.Text = "Fecha"
        '
        'Hora
        '
        Me.Hora.AutoSize = True
        Me.Hora.BackColor = System.Drawing.Color.Transparent
        Me.Hora.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hora.Location = New System.Drawing.Point(320, 378)
        Me.Hora.Name = "Hora"
        Me.Hora.Size = New System.Drawing.Size(53, 26)
        Me.Hora.TabIndex = 5
        Me.Hora.Text = "Hora"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblUsuariosBindingSource
        '
        Me.TblUsuariosBindingSource.DataMember = "tblUsuarios"
        Me.TblUsuariosBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'TblUsuariosTableAdapter
        '
        Me.TblUsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tblUsuariosTableAdapter = Me.TblUsuariosTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'TblUsuariosBindingNavigatorSaveItem
        '
        Me.TblUsuariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblUsuariosBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblUsuariosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblUsuariosBindingNavigatorSaveItem.Name = "TblUsuariosBindingNavigatorSaveItem"
        Me.TblUsuariosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblUsuariosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'TblUsuariosBindingNavigator
        '
        Me.TblUsuariosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblUsuariosBindingNavigator.BindingSource = Me.TblUsuariosBindingSource
        Me.TblUsuariosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblUsuariosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblUsuariosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TblUsuariosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TblUsuariosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblUsuariosBindingNavigatorSaveItem})
        Me.TblUsuariosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblUsuariosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblUsuariosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblUsuariosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblUsuariosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblUsuariosBindingNavigator.Name = "TblUsuariosBindingNavigator"
        Me.TblUsuariosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblUsuariosBindingNavigator.Size = New System.Drawing.Size(271, 25)
        Me.TblUsuariosBindingNavigator.TabIndex = 6
        Me.TblUsuariosBindingNavigator.Text = "BindingNavigator1"
        Me.TblUsuariosBindingNavigator.Visible = False
        '
        'IdUsuarioListBox
        '
        Me.IdUsuarioListBox.DataSource = Me.TblUsuariosBindingSource3
        Me.IdUsuarioListBox.DisplayMember = "IdUsuario"
        Me.IdUsuarioListBox.FormattingEnabled = True
        Me.IdUsuarioListBox.Location = New System.Drawing.Point(12, 74)
        Me.IdUsuarioListBox.Name = "IdUsuarioListBox"
        Me.IdUsuarioListBox.Size = New System.Drawing.Size(74, 95)
        Me.IdUsuarioListBox.TabIndex = 8
        Me.IdUsuarioListBox.Visible = False
        '
        'TblUsuariosBindingSource3
        '
        Me.TblUsuariosBindingSource3.DataMember = "tblUsuarios"
        Me.TblUsuariosBindingSource3.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'TblUsuariosBindingSource2
        '
        Me.TblUsuariosBindingSource2.DataMember = "tblUsuarios"
        Me.TblUsuariosBindingSource2.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'TblUsuariosBindingSource1
        '
        Me.TblUsuariosBindingSource1.DataMember = "tblUsuarios"
        Me.TblUsuariosBindingSource1.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'LblIncorrecto
        '
        Me.LblIncorrecto.AutoSize = True
        Me.LblIncorrecto.BackColor = System.Drawing.Color.Transparent
        Me.LblIncorrecto.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblIncorrecto.ForeColor = System.Drawing.Color.Red
        Me.LblIncorrecto.Location = New System.Drawing.Point(116, 296)
        Me.LblIncorrecto.Name = "LblIncorrecto"
        Me.LblIncorrecto.Size = New System.Drawing.Size(48, 18)
        Me.LblIncorrecto.TabIndex = 13
        Me.LblIncorrecto.Text = "Label1"
        Me.LblIncorrecto.Visible = False
        '
        'TblUsuarioActivoBindingSource
        '
        Me.TblUsuarioActivoBindingSource.DataMember = "tblUsuarioActivo"
        Me.TblUsuarioActivoBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'HoraTextBox
        '
        Me.HoraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuarioActivoBindingSource, "Hora", True))
        Me.HoraTextBox.Location = New System.Drawing.Point(345, 195)
        Me.HoraTextBox.Name = "HoraTextBox"
        Me.HoraTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HoraTextBox.TabIndex = 16
        Me.HoraTextBox.Visible = False
        '
        'DiaTextBox
        '
        Me.DiaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuarioActivoBindingSource, "Día", True))
        Me.DiaTextBox.Location = New System.Drawing.Point(345, 221)
        Me.DiaTextBox.Name = "DiaTextBox"
        Me.DiaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DiaTextBox.TabIndex = 18
        Me.DiaTextBox.Visible = False
        '
        'Basededatos14beDataSetBindingSource
        '
        Me.Basededatos14beDataSetBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        Me.Basededatos14beDataSetBindingSource.Position = 0
        '
        'TblUsuarioActivoTableAdapter
        '
        Me.TblUsuarioActivoTableAdapter.ClearBeforeFill = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.TblUsuarioActivoBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(110, 138)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(257, 25)
        Me.BindingNavigator1.TabIndex = 20
        Me.BindingNavigator1.Text = "BindingNavigator1"
        Me.BindingNavigator1.Visible = False
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem1.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem1.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Mover último"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UsuarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuarioActivoBindingSource, "IdUsuario", True))
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.Location = New System.Drawing.Point(131, 218)
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(195, 20)
        Me.UsuarioTextBox.TabIndex = 1
        '
        'GUARDARCHBX
        '
        Me.GUARDARCHBX.AutoSize = True
        Me.GUARDARCHBX.Location = New System.Drawing.Point(298, 324)
        Me.GUARDARCHBX.Name = "GUARDARCHBX"
        Me.GUARDARCHBX.Size = New System.Drawing.Size(15, 14)
        Me.GUARDARCHBX.TabIndex = 22
        Me.GUARDARCHBX.UseVisualStyleBackColor = True
        Me.GUARDARCHBX.Visible = False
        '
        'NameTXT
        '
        Me.NameTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuariosBindingSource3, "Nombre", True))
        Me.NameTXT.Location = New System.Drawing.Point(12, 175)
        Me.NameTXT.Name = "NameTXT"
        Me.NameTXT.Size = New System.Drawing.Size(100, 20)
        Me.NameTXT.TabIndex = 23
        Me.NameTXT.Visible = False
        '
        'PasswordTXT
        '
        Me.PasswordTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblUsuariosBindingSource3, "Contraseña", True))
        Me.PasswordTXT.Location = New System.Drawing.Point(12, 201)
        Me.PasswordTXT.Name = "PasswordTXT"
        Me.PasswordTXT.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTXT.TabIndex = 24
        Me.PasswordTXT.Visible = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(458, 436)
        Me.Controls.Add(Me.PasswordTXT)
        Me.Controls.Add(Me.NameTXT)
        Me.Controls.Add(Me.GUARDARCHBX)
        Me.Controls.Add(Me.UsuarioTextBox)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.HoraTextBox)
        Me.Controls.Add(Me.DiaTextBox)
        Me.Controls.Add(Me.LblIncorrecto)
        Me.Controls.Add(Me.IdUsuarioListBox)
        Me.Controls.Add(Me.TblUsuariosBindingNavigator)
        Me.Controls.Add(Me.Hora)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.TxtIdUsuario)
        Me.Controls.Add(Me.Entrar)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuariosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblUsuariosBindingNavigator.ResumeLayout(False)
        Me.TblUsuariosBindingNavigator.PerformLayout()
        CType(Me.TblUsuariosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuariosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuariosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Basededatos14beDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Entrar As Button
    Friend WithEvents TxtIdUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Fecha As Label
    Friend WithEvents Hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents TblUsuariosBindingSource As BindingSource
    Friend WithEvents TblUsuariosTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.tblUsuariosTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents TblUsuariosBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblUsuariosBindingNavigator As BindingNavigator
    Friend WithEvents IdUsuarioListBox As ListBox
    Friend WithEvents TblUsuariosBindingSource2 As BindingSource
    Friend WithEvents TblUsuariosBindingSource3 As BindingSource
    Friend WithEvents TblUsuariosBindingSource1 As BindingSource
    Friend WithEvents LblIncorrecto As Label
    Friend WithEvents TblUsuarioActivoBindingSource As BindingSource
    Friend WithEvents HoraTextBox As TextBox
    Friend WithEvents DiaTextBox As TextBox
    Friend WithEvents Basededatos14beDataSetBindingSource As BindingSource
    Friend WithEvents TblUsuarioActivoTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents UsuarioTextBox As TextBox
    Friend WithEvents GUARDARCHBX As CheckBox
    Friend WithEvents NameTXT As TextBox
    Friend WithEvents PasswordTXT As TextBox
End Class
