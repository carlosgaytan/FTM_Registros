<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufactura
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
        Dim __de_orden_a_cotizarLabel As System.Windows.Forms.Label
        Dim FactibilidadLabel As System.Windows.Forms.Label
        Dim Observaciones_de_no_factibilidadLabel As System.Windows.Forms.Label
        Dim ClienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ClienteLabel1 As System.Windows.Forms.Label
        Dim Clave_FTMLabel As System.Windows.Forms.Label
        Dim DibujoLabel As System.Windows.Forms.Label
        Dim DescripciónLabel As System.Windows.Forms.Label
        Dim MILIMETROSLabel As System.Windows.Forms.Label
        Dim MaterialLabel As System.Windows.Forms.Label
        Dim Cantidad_PiezasLabel As System.Windows.Forms.Label
        Dim Corte_LáserLabel As System.Windows.Forms.Label
        Dim Tiempo_corteLabel As System.Windows.Forms.Label
        Dim Corte_WJLabel As System.Windows.Forms.Label
        Dim Corte_SierraLabel As System.Windows.Forms.Label
        Dim __DoblezLabel As System.Windows.Forms.Label
        Dim Tiempos_doblezLabel As System.Windows.Forms.Label
        Dim MaquinadoLabel As System.Windows.Forms.Label
        Dim Tiempo_maquinadoLabel As System.Windows.Forms.Label
        Dim PunzonadoLabel As System.Windows.Forms.Label
        Dim SoldaduraLabel As System.Windows.Forms.Label
        Dim PinturaLabel As System.Windows.Forms.Label
        Dim GalvanizadoLabel As System.Windows.Forms.Label
        Dim TropicalizadoLabel As System.Windows.Forms.Label
        Dim Otro_procesoLabel As System.Windows.Forms.Label
        Dim HerramentalLabel As System.Windows.Forms.Label
        Dim Espesor__mm_Label1 As System.Windows.Forms.Label
        Dim OrdenLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manufactura))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ManufacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
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
        Me.__de_orden_a_cotizarComboBox = New System.Windows.Forms.ComboBox()
        Me.FactibilidadCheckBox = New System.Windows.Forms.CheckBox()
        Me.Observaciones_de_no_factibilidadTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.Busca = New System.Windows.Forms.TextBox()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.OrdenComboBox = New System.Windows.Forms.ComboBox()
        Me.Pza_Control_de_planosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Manufactura_1_5DataSet = New FTM_Registros._Manufactura_1_5DataSet()
        Me.Segundos_corteTextBox = New System.Windows.Forms.TextBox()
        Me.Segundos_doblezTextBox = New System.Windows.Forms.TextBox()
        Me.Segundos_maqTextBox = New System.Windows.Forms.TextBox()
        Me.Minutos_doblezTextBox = New System.Windows.Forms.TextBox()
        Me.Minutos_maqTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Minutos_corteTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Horas_doblezTextBox = New System.Windows.Forms.TextBox()
        Me.Horas_maqTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Horas_corteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uno = New System.Windows.Forms.TextBox()
        Me.in_mm = New System.Windows.Forms.Label()
        Me.MM = New System.Windows.Forms.TextBox()
        Me.Espesor2TextBox = New System.Windows.Forms.TextBox()
        Me.Espesor1TextBox = New System.Windows.Forms.TextBox()
        Me.EspesorMM = New System.Windows.Forms.TextBox()
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
        Me.GuardarToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ClienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Clave_FTMComboBox = New System.Windows.Forms.ComboBox()
        Me.DibujoComboBox = New System.Windows.Forms.ComboBox()
        Me.DescripciónComboBox = New System.Windows.Forms.ComboBox()
        Me.MILIMETROSCheckBox = New System.Windows.Forms.CheckBox()
        Me.MaterialComboBox = New System.Windows.Forms.ComboBox()
        Me.Cantidad_PiezasTextBox = New System.Windows.Forms.TextBox()
        Me.Corte_LáserCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tiempo_corteTextBox = New System.Windows.Forms.TextBox()
        Me.Corte_WJCheckBox = New System.Windows.Forms.CheckBox()
        Me.Corte_SierraCheckBox = New System.Windows.Forms.CheckBox()
        Me.__DoblezTextBox = New System.Windows.Forms.TextBox()
        Me.Tiempos_doblezTextBox = New System.Windows.Forms.TextBox()
        Me.MaquinadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Tiempo_maquinadoTextBox = New System.Windows.Forms.TextBox()
        Me.PunzonadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.SoldaduraCheckBox = New System.Windows.Forms.CheckBox()
        Me.PinturaCheckBox = New System.Windows.Forms.CheckBox()
        Me.GalvanizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.TropicalizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Otro_procesoTextBox = New System.Windows.Forms.TextBox()
        Me.HerramentalTextBox = New System.Windows.Forms.TextBox()
        Me.fraccion = New System.Windows.Forms.Label()
        Me.MILI = New System.Windows.Forms.TextBox()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManufacturaTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.ManufacturaTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.Pza_Control_de_planosTableAdapter = New FTM_Registros._Manufactura_1_5DataSetTableAdapters.Pza_Control_de_planosTableAdapter()
        Me.TableAdapterManager1 = New FTM_Registros._Manufactura_1_5DataSetTableAdapters.TableAdapterManager()
        Me.VentasTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter()
        __de_orden_a_cotizarLabel = New System.Windows.Forms.Label()
        FactibilidadLabel = New System.Windows.Forms.Label()
        Observaciones_de_no_factibilidadLabel = New System.Windows.Forms.Label()
        ClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ClienteLabel1 = New System.Windows.Forms.Label()
        Clave_FTMLabel = New System.Windows.Forms.Label()
        DibujoLabel = New System.Windows.Forms.Label()
        DescripciónLabel = New System.Windows.Forms.Label()
        MILIMETROSLabel = New System.Windows.Forms.Label()
        MaterialLabel = New System.Windows.Forms.Label()
        Cantidad_PiezasLabel = New System.Windows.Forms.Label()
        Corte_LáserLabel = New System.Windows.Forms.Label()
        Tiempo_corteLabel = New System.Windows.Forms.Label()
        Corte_WJLabel = New System.Windows.Forms.Label()
        Corte_SierraLabel = New System.Windows.Forms.Label()
        __DoblezLabel = New System.Windows.Forms.Label()
        Tiempos_doblezLabel = New System.Windows.Forms.Label()
        MaquinadoLabel = New System.Windows.Forms.Label()
        Tiempo_maquinadoLabel = New System.Windows.Forms.Label()
        PunzonadoLabel = New System.Windows.Forms.Label()
        SoldaduraLabel = New System.Windows.Forms.Label()
        PinturaLabel = New System.Windows.Forms.Label()
        GalvanizadoLabel = New System.Windows.Forms.Label()
        TropicalizadoLabel = New System.Windows.Forms.Label()
        Otro_procesoLabel = New System.Windows.Forms.Label()
        HerramentalLabel = New System.Windows.Forms.Label()
        Espesor__mm_Label1 = New System.Windows.Forms.Label()
        OrdenLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.ManufacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pza_Control_de_planosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Manufactura_1_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '__de_orden_a_cotizarLabel
        '
        __de_orden_a_cotizarLabel.AutoSize = True
        __de_orden_a_cotizarLabel.Location = New System.Drawing.Point(44, 43)
        __de_orden_a_cotizarLabel.Name = "__de_orden_a_cotizarLabel"
        __de_orden_a_cotizarLabel.Size = New System.Drawing.Size(105, 13)
        __de_orden_a_cotizarLabel.TabIndex = 0
        __de_orden_a_cotizarLabel.Text = "# de orden a cotizar:"
        '
        'FactibilidadLabel
        '
        FactibilidadLabel.AutoSize = True
        FactibilidadLabel.Location = New System.Drawing.Point(44, 72)
        FactibilidadLabel.Name = "FactibilidadLabel"
        FactibilidadLabel.Size = New System.Drawing.Size(63, 13)
        FactibilidadLabel.TabIndex = 2
        FactibilidadLabel.Text = "Factibilidad:"
        '
        'Observaciones_de_no_factibilidadLabel
        '
        Observaciones_de_no_factibilidadLabel.AutoSize = True
        Observaciones_de_no_factibilidadLabel.Location = New System.Drawing.Point(44, 100)
        Observaciones_de_no_factibilidadLabel.Name = "Observaciones_de_no_factibilidadLabel"
        Observaciones_de_no_factibilidadLabel.Size = New System.Drawing.Size(164, 13)
        Observaciones_de_no_factibilidadLabel.TabIndex = 4
        Observaciones_de_no_factibilidadLabel.Text = "Observaciones de no factibilidad:"
        '
        'ClienteLabel
        '
        ClienteLabel.AutoSize = True
        ClienteLabel.Location = New System.Drawing.Point(44, 126)
        ClienteLabel.Name = "ClienteLabel"
        ClienteLabel.Size = New System.Drawing.Size(42, 13)
        ClienteLabel.TabIndex = 6
        ClienteLabel.Text = "Cliente:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(44, 153)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 8
        FechaLabel.Text = "Fecha:"
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Location = New System.Drawing.Point(15, 45)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(42, 13)
        ClienteLabel1.TabIndex = 5
        ClienteLabel1.Text = "Cliente:"
        '
        'Clave_FTMLabel
        '
        Clave_FTMLabel.AutoSize = True
        Clave_FTMLabel.Location = New System.Drawing.Point(15, 72)
        Clave_FTMLabel.Name = "Clave_FTMLabel"
        Clave_FTMLabel.Size = New System.Drawing.Size(62, 13)
        Clave_FTMLabel.TabIndex = 7
        Clave_FTMLabel.Text = "Clave FTM:"
        '
        'DibujoLabel
        '
        DibujoLabel.AutoSize = True
        DibujoLabel.Location = New System.Drawing.Point(15, 99)
        DibujoLabel.Name = "DibujoLabel"
        DibujoLabel.Size = New System.Drawing.Size(40, 13)
        DibujoLabel.TabIndex = 9
        DibujoLabel.Text = "Dibujo:"
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.Location = New System.Drawing.Point(15, 126)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(66, 13)
        DescripciónLabel.TabIndex = 11
        DescripciónLabel.Text = "Descripción:"
        '
        'MILIMETROSLabel
        '
        MILIMETROSLabel.AutoSize = True
        MILIMETROSLabel.Location = New System.Drawing.Point(15, 152)
        MILIMETROSLabel.Name = "MILIMETROSLabel"
        MILIMETROSLabel.Size = New System.Drawing.Size(77, 13)
        MILIMETROSLabel.TabIndex = 19
        MILIMETROSLabel.Text = "MILIMETROS:"
        '
        'MaterialLabel
        '
        MaterialLabel.AutoSize = True
        MaterialLabel.Location = New System.Drawing.Point(189, 177)
        MaterialLabel.Name = "MaterialLabel"
        MaterialLabel.Size = New System.Drawing.Size(47, 13)
        MaterialLabel.TabIndex = 23
        MaterialLabel.Text = "Material:"
        '
        'Cantidad_PiezasLabel
        '
        Cantidad_PiezasLabel.AutoSize = True
        Cantidad_PiezasLabel.Location = New System.Drawing.Point(20, 216)
        Cantidad_PiezasLabel.Name = "Cantidad_PiezasLabel"
        Cantidad_PiezasLabel.Size = New System.Drawing.Size(86, 13)
        Cantidad_PiezasLabel.TabIndex = 25
        Cantidad_PiezasLabel.Text = "Cantidad Piezas:"
        '
        'Corte_LáserLabel
        '
        Corte_LáserLabel.AutoSize = True
        Corte_LáserLabel.Location = New System.Drawing.Point(445, 22)
        Corte_LáserLabel.Name = "Corte_LáserLabel"
        Corte_LáserLabel.Size = New System.Drawing.Size(64, 13)
        Corte_LáserLabel.TabIndex = 27
        Corte_LáserLabel.Text = "Corte Láser:"
        '
        'Tiempo_corteLabel
        '
        Tiempo_corteLabel.AutoSize = True
        Tiempo_corteLabel.Location = New System.Drawing.Point(48, 259)
        Tiempo_corteLabel.Name = "Tiempo_corteLabel"
        Tiempo_corteLabel.Size = New System.Drawing.Size(72, 13)
        Tiempo_corteLabel.TabIndex = 35
        Tiempo_corteLabel.Text = "Tiempo corte:"
        Tiempo_corteLabel.Visible = False
        '
        'Corte_WJLabel
        '
        Corte_WJLabel.AutoSize = True
        Corte_WJLabel.Location = New System.Drawing.Point(445, 45)
        Corte_WJLabel.Name = "Corte_WJLabel"
        Corte_WJLabel.Size = New System.Drawing.Size(54, 13)
        Corte_WJLabel.TabIndex = 37
        Corte_WJLabel.Text = "Corte WJ:"
        '
        'Corte_SierraLabel
        '
        Corte_SierraLabel.AutoSize = True
        Corte_SierraLabel.Location = New System.Drawing.Point(445, 69)
        Corte_SierraLabel.Name = "Corte_SierraLabel"
        Corte_SierraLabel.Size = New System.Drawing.Size(65, 13)
        Corte_SierraLabel.TabIndex = 39
        Corte_SierraLabel.Text = "Corte Sierra:"
        '
        '__DoblezLabel
        '
        __DoblezLabel.AutoSize = True
        __DoblezLabel.Location = New System.Drawing.Point(445, 97)
        __DoblezLabel.Name = "__DoblezLabel"
        __DoblezLabel.Size = New System.Drawing.Size(53, 13)
        __DoblezLabel.TabIndex = 41
        __DoblezLabel.Text = "# Doblez:"
        '
        'Tiempos_doblezLabel
        '
        Tiempos_doblezLabel.AutoSize = True
        Tiempos_doblezLabel.Location = New System.Drawing.Point(36, 285)
        Tiempos_doblezLabel.Name = "Tiempos_doblezLabel"
        Tiempos_doblezLabel.Size = New System.Drawing.Size(84, 13)
        Tiempos_doblezLabel.TabIndex = 49
        Tiempos_doblezLabel.Text = "Tiempos doblez:"
        Tiempos_doblezLabel.Visible = False
        '
        'MaquinadoLabel
        '
        MaquinadoLabel.AutoSize = True
        MaquinadoLabel.Location = New System.Drawing.Point(445, 125)
        MaquinadoLabel.Name = "MaquinadoLabel"
        MaquinadoLabel.Size = New System.Drawing.Size(63, 13)
        MaquinadoLabel.TabIndex = 51
        MaquinadoLabel.Text = "Maquinado:"
        '
        'Tiempo_maquinadoLabel
        '
        Tiempo_maquinadoLabel.AutoSize = True
        Tiempo_maquinadoLabel.Location = New System.Drawing.Point(20, 312)
        Tiempo_maquinadoLabel.Name = "Tiempo_maquinadoLabel"
        Tiempo_maquinadoLabel.Size = New System.Drawing.Size(100, 13)
        Tiempo_maquinadoLabel.TabIndex = 59
        Tiempo_maquinadoLabel.Text = "Tiempo maquinado:"
        Tiempo_maquinadoLabel.Visible = False
        '
        'PunzonadoLabel
        '
        PunzonadoLabel.AutoSize = True
        PunzonadoLabel.Location = New System.Drawing.Point(445, 150)
        PunzonadoLabel.Name = "PunzonadoLabel"
        PunzonadoLabel.Size = New System.Drawing.Size(64, 13)
        PunzonadoLabel.TabIndex = 61
        PunzonadoLabel.Text = "Punzonado:"
        '
        'SoldaduraLabel
        '
        SoldaduraLabel.AutoSize = True
        SoldaduraLabel.Location = New System.Drawing.Point(445, 174)
        SoldaduraLabel.Name = "SoldaduraLabel"
        SoldaduraLabel.Size = New System.Drawing.Size(58, 13)
        SoldaduraLabel.TabIndex = 63
        SoldaduraLabel.Text = "Soldadura:"
        '
        'PinturaLabel
        '
        PinturaLabel.AutoSize = True
        PinturaLabel.Location = New System.Drawing.Point(601, 22)
        PinturaLabel.Name = "PinturaLabel"
        PinturaLabel.Size = New System.Drawing.Size(43, 13)
        PinturaLabel.TabIndex = 65
        PinturaLabel.Text = "Pintura:"
        '
        'GalvanizadoLabel
        '
        GalvanizadoLabel.AutoSize = True
        GalvanizadoLabel.Location = New System.Drawing.Point(601, 46)
        GalvanizadoLabel.Name = "GalvanizadoLabel"
        GalvanizadoLabel.Size = New System.Drawing.Size(69, 13)
        GalvanizadoLabel.TabIndex = 67
        GalvanizadoLabel.Text = "Galvanizado:"
        '
        'TropicalizadoLabel
        '
        TropicalizadoLabel.AutoSize = True
        TropicalizadoLabel.Location = New System.Drawing.Point(601, 74)
        TropicalizadoLabel.Name = "TropicalizadoLabel"
        TropicalizadoLabel.Size = New System.Drawing.Size(73, 13)
        TropicalizadoLabel.TabIndex = 69
        TropicalizadoLabel.Text = "Tropicalizado:"
        '
        'Otro_procesoLabel
        '
        Otro_procesoLabel.AutoSize = True
        Otro_procesoLabel.Location = New System.Drawing.Point(601, 102)
        Otro_procesoLabel.Name = "Otro_procesoLabel"
        Otro_procesoLabel.Size = New System.Drawing.Size(71, 13)
        Otro_procesoLabel.TabIndex = 71
        Otro_procesoLabel.Text = "Otro proceso:"
        '
        'HerramentalLabel
        '
        HerramentalLabel.AutoSize = True
        HerramentalLabel.Location = New System.Drawing.Point(601, 152)
        HerramentalLabel.Name = "HerramentalLabel"
        HerramentalLabel.Size = New System.Drawing.Size(67, 13)
        HerramentalLabel.TabIndex = 73
        HerramentalLabel.Text = "Herramental:"
        '
        'Espesor__mm_Label1
        '
        Espesor__mm_Label1.AutoSize = True
        Espesor__mm_Label1.Location = New System.Drawing.Point(163, 152)
        Espesor__mm_Label1.Name = "Espesor__mm_Label1"
        Espesor__mm_Label1.Size = New System.Drawing.Size(73, 13)
        Espesor__mm_Label1.TabIndex = 75
        Espesor__mm_Label1.Text = "Espesor (mm):"
        '
        'OrdenLabel
        '
        OrdenLabel.AutoSize = True
        OrdenLabel.Location = New System.Drawing.Point(18, 18)
        OrdenLabel.Name = "OrdenLabel"
        OrdenLabel.Size = New System.Drawing.Size(39, 13)
        OrdenLabel.TabIndex = 91
        OrdenLabel.Text = "Orden:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(841, 471)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BindingNavigator2)
        Me.TabPage1.Controls.Add(__de_orden_a_cotizarLabel)
        Me.TabPage1.Controls.Add(Me.__de_orden_a_cotizarComboBox)
        Me.TabPage1.Controls.Add(FactibilidadLabel)
        Me.TabPage1.Controls.Add(Me.FactibilidadCheckBox)
        Me.TabPage1.Controls.Add(Observaciones_de_no_factibilidadLabel)
        Me.TabPage1.Controls.Add(Me.Observaciones_de_no_factibilidadTextBox)
        Me.TabPage1.Controls.Add(ClienteLabel)
        Me.TabPage1.Controls.Add(Me.ClienteTextBox)
        Me.TabPage1.Controls.Add(FechaLabel)
        Me.TabPage1.Controls.Add(Me.FechaDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(833, 445)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Manufactura"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator2.BindingSource = Me.ManufacturaBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GuardarToolStripButton})
        Me.BindingNavigator2.Location = New System.Drawing.Point(47, 181)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator2.Size = New System.Drawing.Size(311, 25)
        Me.BindingNavigator2.TabIndex = 10
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
        'ManufacturaBindingSource
        '
        Me.ManufacturaBindingSource.DataMember = "Manufactura"
        Me.ManufacturaBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        '__de_orden_a_cotizarComboBox
        '
        Me.__de_orden_a_cotizarComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManufacturaBindingSource, "# de orden a cotizar", True))
        Me.__de_orden_a_cotizarComboBox.FormattingEnabled = True
        Me.__de_orden_a_cotizarComboBox.Location = New System.Drawing.Point(214, 40)
        Me.__de_orden_a_cotizarComboBox.Name = "__de_orden_a_cotizarComboBox"
        Me.__de_orden_a_cotizarComboBox.Size = New System.Drawing.Size(200, 21)
        Me.__de_orden_a_cotizarComboBox.TabIndex = 1
        '
        'FactibilidadCheckBox
        '
        Me.FactibilidadCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ManufacturaBindingSource, "Factibilidad", True))
        Me.FactibilidadCheckBox.Location = New System.Drawing.Point(214, 67)
        Me.FactibilidadCheckBox.Name = "FactibilidadCheckBox"
        Me.FactibilidadCheckBox.Size = New System.Drawing.Size(16, 24)
        Me.FactibilidadCheckBox.TabIndex = 3
        Me.FactibilidadCheckBox.Text = "CheckBox1"
        Me.FactibilidadCheckBox.UseVisualStyleBackColor = True
        '
        'Observaciones_de_no_factibilidadTextBox
        '
        Me.Observaciones_de_no_factibilidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManufacturaBindingSource, "Observaciones de no factibilidad", True))
        Me.Observaciones_de_no_factibilidadTextBox.Location = New System.Drawing.Point(214, 97)
        Me.Observaciones_de_no_factibilidadTextBox.Name = "Observaciones_de_no_factibilidadTextBox"
        Me.Observaciones_de_no_factibilidadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Observaciones_de_no_factibilidadTextBox.TabIndex = 5
        '
        'ClienteTextBox
        '
        Me.ClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ManufacturaBindingSource, "Cliente", True))
        Me.ClienteTextBox.Location = New System.Drawing.Point(214, 123)
        Me.ClienteTextBox.Name = "ClienteTextBox"
        Me.ClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ClienteTextBox.TabIndex = 7
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ManufacturaBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(214, 149)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.Buscar)
        Me.TabPage2.Controls.Add(Me.Busca)
        Me.TabPage2.Controls.Add(Me.Tabla)
        Me.TabPage2.Controls.Add(OrdenLabel)
        Me.TabPage2.Controls.Add(Me.OrdenComboBox)
        Me.TabPage2.Controls.Add(Me.Segundos_corteTextBox)
        Me.TabPage2.Controls.Add(Me.Segundos_doblezTextBox)
        Me.TabPage2.Controls.Add(Me.Segundos_maqTextBox)
        Me.TabPage2.Controls.Add(Me.Minutos_doblezTextBox)
        Me.TabPage2.Controls.Add(Me.Minutos_maqTextBox)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Minutos_corteTextBox)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Horas_doblezTextBox)
        Me.TabPage2.Controls.Add(Me.Horas_maqTextBox)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Horas_corteTextBox)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.uno)
        Me.TabPage2.Controls.Add(Me.in_mm)
        Me.TabPage2.Controls.Add(Me.MM)
        Me.TabPage2.Controls.Add(Me.Espesor2TextBox)
        Me.TabPage2.Controls.Add(Me.Espesor1TextBox)
        Me.TabPage2.Controls.Add(Espesor__mm_Label1)
        Me.TabPage2.Controls.Add(Me.EspesorMM)
        Me.TabPage2.Controls.Add(Me.BindingNavigator1)
        Me.TabPage2.Controls.Add(ClienteLabel1)
        Me.TabPage2.Controls.Add(Me.ClienteTextBox1)
        Me.TabPage2.Controls.Add(Clave_FTMLabel)
        Me.TabPage2.Controls.Add(Me.Clave_FTMComboBox)
        Me.TabPage2.Controls.Add(DibujoLabel)
        Me.TabPage2.Controls.Add(Me.DibujoComboBox)
        Me.TabPage2.Controls.Add(DescripciónLabel)
        Me.TabPage2.Controls.Add(Me.DescripciónComboBox)
        Me.TabPage2.Controls.Add(MILIMETROSLabel)
        Me.TabPage2.Controls.Add(Me.MILIMETROSCheckBox)
        Me.TabPage2.Controls.Add(MaterialLabel)
        Me.TabPage2.Controls.Add(Me.MaterialComboBox)
        Me.TabPage2.Controls.Add(Cantidad_PiezasLabel)
        Me.TabPage2.Controls.Add(Me.Cantidad_PiezasTextBox)
        Me.TabPage2.Controls.Add(Corte_LáserLabel)
        Me.TabPage2.Controls.Add(Me.Corte_LáserCheckBox)
        Me.TabPage2.Controls.Add(Tiempo_corteLabel)
        Me.TabPage2.Controls.Add(Me.Tiempo_corteTextBox)
        Me.TabPage2.Controls.Add(Corte_WJLabel)
        Me.TabPage2.Controls.Add(Me.Corte_WJCheckBox)
        Me.TabPage2.Controls.Add(Corte_SierraLabel)
        Me.TabPage2.Controls.Add(Me.Corte_SierraCheckBox)
        Me.TabPage2.Controls.Add(__DoblezLabel)
        Me.TabPage2.Controls.Add(Me.__DoblezTextBox)
        Me.TabPage2.Controls.Add(Tiempos_doblezLabel)
        Me.TabPage2.Controls.Add(Me.Tiempos_doblezTextBox)
        Me.TabPage2.Controls.Add(MaquinadoLabel)
        Me.TabPage2.Controls.Add(Me.MaquinadoCheckBox)
        Me.TabPage2.Controls.Add(Tiempo_maquinadoLabel)
        Me.TabPage2.Controls.Add(Me.Tiempo_maquinadoTextBox)
        Me.TabPage2.Controls.Add(PunzonadoLabel)
        Me.TabPage2.Controls.Add(Me.PunzonadoCheckBox)
        Me.TabPage2.Controls.Add(SoldaduraLabel)
        Me.TabPage2.Controls.Add(Me.SoldaduraCheckBox)
        Me.TabPage2.Controls.Add(PinturaLabel)
        Me.TabPage2.Controls.Add(Me.PinturaCheckBox)
        Me.TabPage2.Controls.Add(GalvanizadoLabel)
        Me.TabPage2.Controls.Add(Me.GalvanizadoCheckBox)
        Me.TabPage2.Controls.Add(TropicalizadoLabel)
        Me.TabPage2.Controls.Add(Me.TropicalizadoCheckBox)
        Me.TabPage2.Controls.Add(Otro_procesoLabel)
        Me.TabPage2.Controls.Add(Me.Otro_procesoTextBox)
        Me.TabPage2.Controls.Add(HerramentalLabel)
        Me.TabPage2.Controls.Add(Me.HerramentalTextBox)
        Me.TabPage2.Controls.Add(Me.fraccion)
        Me.TabPage2.Controls.Add(Me.MILI)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(833, 445)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registro piezas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Buscar
        '
        Me.Buscar.Location = New System.Drawing.Point(666, 391)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(75, 23)
        Me.Buscar.TabIndex = 95
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'Busca
        '
        Me.Busca.Location = New System.Drawing.Point(532, 394)
        Me.Busca.Name = "Busca"
        Me.Busca.Size = New System.Drawing.Size(100, 20)
        Me.Busca.TabIndex = 94
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Location = New System.Drawing.Point(462, 224)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(240, 150)
        Me.Tabla.TabIndex = 93
        '
        'OrdenComboBox
        '
        Me.OrdenComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Orden", True))
        Me.OrdenComboBox.FormattingEnabled = True
        Me.OrdenComboBox.Location = New System.Drawing.Point(126, 15)
        Me.OrdenComboBox.Name = "OrdenComboBox"
        Me.OrdenComboBox.Size = New System.Drawing.Size(235, 21)
        Me.OrdenComboBox.TabIndex = 92
        '
        'Pza_Control_de_planosBindingSource
        '
        Me.Pza_Control_de_planosBindingSource.DataMember = "Pza Control de planos"
        Me.Pza_Control_de_planosBindingSource.DataSource = Me._Manufactura_1_5DataSet
        '
        '_Manufactura_1_5DataSet
        '
        Me._Manufactura_1_5DataSet.DataSetName = "_Manufactura_1_5DataSet"
        Me._Manufactura_1_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Segundos_corteTextBox
        '
        Me.Segundos_corteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Segundos corte", True))
        Me.Segundos_corteTextBox.Location = New System.Drawing.Point(215, 256)
        Me.Segundos_corteTextBox.Name = "Segundos_corteTextBox"
        Me.Segundos_corteTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Segundos_corteTextBox.TabIndex = 34
        '
        'Segundos_doblezTextBox
        '
        Me.Segundos_doblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Segundos doblez", True))
        Me.Segundos_doblezTextBox.Location = New System.Drawing.Point(215, 282)
        Me.Segundos_doblezTextBox.Name = "Segundos_doblezTextBox"
        Me.Segundos_doblezTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Segundos_doblezTextBox.TabIndex = 48
        '
        'Segundos_maqTextBox
        '
        Me.Segundos_maqTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Segundos maq", True))
        Me.Segundos_maqTextBox.Location = New System.Drawing.Point(215, 309)
        Me.Segundos_maqTextBox.Name = "Segundos_maqTextBox"
        Me.Segundos_maqTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Segundos_maqTextBox.TabIndex = 58
        '
        'Minutos_doblezTextBox
        '
        Me.Minutos_doblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Minutos doblez", True))
        Me.Minutos_doblezTextBox.Location = New System.Drawing.Point(172, 282)
        Me.Minutos_doblezTextBox.Name = "Minutos_doblezTextBox"
        Me.Minutos_doblezTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Minutos_doblezTextBox.TabIndex = 46
        '
        'Minutos_maqTextBox
        '
        Me.Minutos_maqTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Minutos maq", True))
        Me.Minutos_maqTextBox.Location = New System.Drawing.Point(172, 309)
        Me.Minutos_maqTextBox.Name = "Minutos_maqTextBox"
        Me.Minutos_maqTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Minutos_maqTextBox.TabIndex = 56
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(203, 307)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 20)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 20)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = ":"
        '
        'Minutos_corteTextBox
        '
        Me.Minutos_corteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Minutos corte", True))
        Me.Minutos_corteTextBox.Location = New System.Drawing.Point(172, 256)
        Me.Minutos_corteTextBox.Name = "Minutos_corteTextBox"
        Me.Minutos_corteTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Minutos_corteTextBox.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 20)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = ":"
        '
        'Horas_doblezTextBox
        '
        Me.Horas_doblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Horas doblez", True))
        Me.Horas_doblezTextBox.Location = New System.Drawing.Point(129, 282)
        Me.Horas_doblezTextBox.Name = "Horas_doblezTextBox"
        Me.Horas_doblezTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Horas_doblezTextBox.TabIndex = 44
        '
        'Horas_maqTextBox
        '
        Me.Horas_maqTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Horas maq", True))
        Me.Horas_maqTextBox.Location = New System.Drawing.Point(129, 309)
        Me.Horas_maqTextBox.Name = "Horas_maqTextBox"
        Me.Horas_maqTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Horas_maqTextBox.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(160, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 20)
        Me.Label3.TabIndex = 86
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(160, 280)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 20)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = ":"
        '
        'Horas_corteTextBox
        '
        Me.Horas_corteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Horas corte", True))
        Me.Horas_corteTextBox.Location = New System.Drawing.Point(129, 256)
        Me.Horas_corteTextBox.Name = "Horas_corteTextBox"
        Me.Horas_corteTextBox.Size = New System.Drawing.Size(32, 20)
        Me.Horas_corteTextBox.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(160, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = ":"
        '
        'uno
        '
        Me.uno.Location = New System.Drawing.Point(287, 201)
        Me.uno.Name = "uno"
        Me.uno.Size = New System.Drawing.Size(14, 20)
        Me.uno.TabIndex = 82
        Me.uno.Text = "1"
        Me.uno.Visible = False
        '
        'in_mm
        '
        Me.in_mm.AutoSize = True
        Me.in_mm.Location = New System.Drawing.Point(16, 178)
        Me.in_mm.Name = "in_mm"
        Me.in_mm.Size = New System.Drawing.Size(39, 13)
        Me.in_mm.TabIndex = 80
        Me.in_mm.Text = "Label1"
        '
        'MM
        '
        Me.MM.Location = New System.Drawing.Point(287, 224)
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(29, 20)
        Me.MM.TabIndex = 79
        Me.MM.Text = "25.4"
        Me.MM.Visible = False
        '
        'Espesor2TextBox
        '
        Me.Espesor2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Espesor2", True))
        Me.Espesor2TextBox.Location = New System.Drawing.Point(134, 175)
        Me.Espesor2TextBox.Name = "Espesor2TextBox"
        Me.Espesor2TextBox.Size = New System.Drawing.Size(38, 20)
        Me.Espesor2TextBox.TabIndex = 78
        '
        'Espesor1TextBox
        '
        Me.Espesor1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Espesor1", True))
        Me.Espesor1TextBox.Location = New System.Drawing.Point(83, 175)
        Me.Espesor1TextBox.Name = "Espesor1TextBox"
        Me.Espesor1TextBox.Size = New System.Drawing.Size(39, 20)
        Me.Espesor1TextBox.TabIndex = 77
        '
        'EspesorMM
        '
        Me.EspesorMM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Espesor (mm)", True))
        Me.EspesorMM.Location = New System.Drawing.Point(242, 149)
        Me.EspesorMM.Name = "EspesorMM"
        Me.EspesorMM.Size = New System.Drawing.Size(100, 20)
        Me.EspesorMM.TabIndex = 76
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.Pza_Control_de_planosBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1, Me.GuardarToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(18, 417)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator1.Size = New System.Drawing.Size(280, 25)
        Me.BindingNavigator1.TabIndex = 75
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'GuardarToolStripButton1
        '
        Me.GuardarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuardarToolStripButton1.Image = CType(resources.GetObject("GuardarToolStripButton1.Image"), System.Drawing.Image)
        Me.GuardarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GuardarToolStripButton1.Name = "GuardarToolStripButton1"
        Me.GuardarToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.GuardarToolStripButton1.Text = "&Guardar"
        '
        'ClienteTextBox1
        '
        Me.ClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Cliente", True))
        Me.ClienteTextBox1.Location = New System.Drawing.Point(126, 42)
        Me.ClienteTextBox1.Name = "ClienteTextBox1"
        Me.ClienteTextBox1.Size = New System.Drawing.Size(235, 20)
        Me.ClienteTextBox1.TabIndex = 6
        '
        'Clave_FTMComboBox
        '
        Me.Clave_FTMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Clave FTM", True))
        Me.Clave_FTMComboBox.FormattingEnabled = True
        Me.Clave_FTMComboBox.Location = New System.Drawing.Point(126, 69)
        Me.Clave_FTMComboBox.Name = "Clave_FTMComboBox"
        Me.Clave_FTMComboBox.Size = New System.Drawing.Size(235, 21)
        Me.Clave_FTMComboBox.TabIndex = 8
        '
        'DibujoComboBox
        '
        Me.DibujoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Dibujo", True))
        Me.DibujoComboBox.FormattingEnabled = True
        Me.DibujoComboBox.Location = New System.Drawing.Point(126, 96)
        Me.DibujoComboBox.Name = "DibujoComboBox"
        Me.DibujoComboBox.Size = New System.Drawing.Size(235, 21)
        Me.DibujoComboBox.TabIndex = 10
        '
        'DescripciónComboBox
        '
        Me.DescripciónComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Descripción", True))
        Me.DescripciónComboBox.FormattingEnabled = True
        Me.DescripciónComboBox.Location = New System.Drawing.Point(126, 123)
        Me.DescripciónComboBox.Name = "DescripciónComboBox"
        Me.DescripciónComboBox.Size = New System.Drawing.Size(235, 21)
        Me.DescripciónComboBox.TabIndex = 12
        '
        'MILIMETROSCheckBox
        '
        Me.MILIMETROSCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "MILIMETROS", True))
        Me.MILIMETROSCheckBox.Location = New System.Drawing.Point(126, 147)
        Me.MILIMETROSCheckBox.Name = "MILIMETROSCheckBox"
        Me.MILIMETROSCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.MILIMETROSCheckBox.TabIndex = 20
        Me.MILIMETROSCheckBox.Text = "CheckBox1"
        Me.MILIMETROSCheckBox.UseVisualStyleBackColor = True
        '
        'MaterialComboBox
        '
        Me.MaterialComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Material", True))
        Me.MaterialComboBox.FormattingEnabled = True
        Me.MaterialComboBox.Location = New System.Drawing.Point(238, 174)
        Me.MaterialComboBox.Name = "MaterialComboBox"
        Me.MaterialComboBox.Size = New System.Drawing.Size(116, 21)
        Me.MaterialComboBox.TabIndex = 24
        '
        'Cantidad_PiezasTextBox
        '
        Me.Cantidad_PiezasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Cantidad Piezas", True))
        Me.Cantidad_PiezasTextBox.Location = New System.Drawing.Point(131, 213)
        Me.Cantidad_PiezasTextBox.Name = "Cantidad_PiezasTextBox"
        Me.Cantidad_PiezasTextBox.Size = New System.Drawing.Size(121, 20)
        Me.Cantidad_PiezasTextBox.TabIndex = 26
        '
        'Corte_LáserCheckBox
        '
        Me.Corte_LáserCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Corte Láser", True))
        Me.Corte_LáserCheckBox.Location = New System.Drawing.Point(514, 17)
        Me.Corte_LáserCheckBox.Name = "Corte_LáserCheckBox"
        Me.Corte_LáserCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Corte_LáserCheckBox.TabIndex = 28
        Me.Corte_LáserCheckBox.Text = "CheckBox1"
        Me.Corte_LáserCheckBox.UseVisualStyleBackColor = True
        '
        'Tiempo_corteTextBox
        '
        Me.Tiempo_corteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Tiempo corte", True))
        Me.Tiempo_corteTextBox.Location = New System.Drawing.Point(261, 256)
        Me.Tiempo_corteTextBox.Name = "Tiempo_corteTextBox"
        Me.Tiempo_corteTextBox.Size = New System.Drawing.Size(55, 20)
        Me.Tiempo_corteTextBox.TabIndex = 36
        Me.Tiempo_corteTextBox.Visible = False
        '
        'Corte_WJCheckBox
        '
        Me.Corte_WJCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Corte WJ", True))
        Me.Corte_WJCheckBox.Location = New System.Drawing.Point(514, 40)
        Me.Corte_WJCheckBox.Name = "Corte_WJCheckBox"
        Me.Corte_WJCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Corte_WJCheckBox.TabIndex = 38
        Me.Corte_WJCheckBox.Text = "CheckBox1"
        Me.Corte_WJCheckBox.UseVisualStyleBackColor = True
        '
        'Corte_SierraCheckBox
        '
        Me.Corte_SierraCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Corte Sierra", True))
        Me.Corte_SierraCheckBox.Location = New System.Drawing.Point(514, 64)
        Me.Corte_SierraCheckBox.Name = "Corte_SierraCheckBox"
        Me.Corte_SierraCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Corte_SierraCheckBox.TabIndex = 40
        Me.Corte_SierraCheckBox.Text = "CheckBox1"
        Me.Corte_SierraCheckBox.UseVisualStyleBackColor = True
        '
        '__DoblezTextBox
        '
        Me.__DoblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "# Doblez", True))
        Me.__DoblezTextBox.Location = New System.Drawing.Point(514, 94)
        Me.__DoblezTextBox.Name = "__DoblezTextBox"
        Me.__DoblezTextBox.Size = New System.Drawing.Size(55, 20)
        Me.__DoblezTextBox.TabIndex = 42
        '
        'Tiempos_doblezTextBox
        '
        Me.Tiempos_doblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Tiempos doblez", True))
        Me.Tiempos_doblezTextBox.Location = New System.Drawing.Point(261, 282)
        Me.Tiempos_doblezTextBox.Name = "Tiempos_doblezTextBox"
        Me.Tiempos_doblezTextBox.Size = New System.Drawing.Size(55, 20)
        Me.Tiempos_doblezTextBox.TabIndex = 50
        Me.Tiempos_doblezTextBox.Visible = False
        '
        'MaquinadoCheckBox
        '
        Me.MaquinadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Maquinado", True))
        Me.MaquinadoCheckBox.Location = New System.Drawing.Point(514, 120)
        Me.MaquinadoCheckBox.Name = "MaquinadoCheckBox"
        Me.MaquinadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.MaquinadoCheckBox.TabIndex = 52
        Me.MaquinadoCheckBox.Text = "CheckBox1"
        Me.MaquinadoCheckBox.UseVisualStyleBackColor = True
        '
        'Tiempo_maquinadoTextBox
        '
        Me.Tiempo_maquinadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Tiempo maquinado", True))
        Me.Tiempo_maquinadoTextBox.Location = New System.Drawing.Point(261, 309)
        Me.Tiempo_maquinadoTextBox.Name = "Tiempo_maquinadoTextBox"
        Me.Tiempo_maquinadoTextBox.Size = New System.Drawing.Size(55, 20)
        Me.Tiempo_maquinadoTextBox.TabIndex = 60
        Me.Tiempo_maquinadoTextBox.Visible = False
        '
        'PunzonadoCheckBox
        '
        Me.PunzonadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Punzonado", True))
        Me.PunzonadoCheckBox.Location = New System.Drawing.Point(514, 145)
        Me.PunzonadoCheckBox.Name = "PunzonadoCheckBox"
        Me.PunzonadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.PunzonadoCheckBox.TabIndex = 62
        Me.PunzonadoCheckBox.Text = "CheckBox1"
        Me.PunzonadoCheckBox.UseVisualStyleBackColor = True
        '
        'SoldaduraCheckBox
        '
        Me.SoldaduraCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Soldadura", True))
        Me.SoldaduraCheckBox.Location = New System.Drawing.Point(514, 169)
        Me.SoldaduraCheckBox.Name = "SoldaduraCheckBox"
        Me.SoldaduraCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.SoldaduraCheckBox.TabIndex = 64
        Me.SoldaduraCheckBox.Text = "CheckBox1"
        Me.SoldaduraCheckBox.UseVisualStyleBackColor = True
        '
        'PinturaCheckBox
        '
        Me.PinturaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Pintura", True))
        Me.PinturaCheckBox.Location = New System.Drawing.Point(677, 18)
        Me.PinturaCheckBox.Name = "PinturaCheckBox"
        Me.PinturaCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.PinturaCheckBox.TabIndex = 66
        Me.PinturaCheckBox.Text = "CheckBox1"
        Me.PinturaCheckBox.UseVisualStyleBackColor = True
        '
        'GalvanizadoCheckBox
        '
        Me.GalvanizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Galvanizado", True))
        Me.GalvanizadoCheckBox.Location = New System.Drawing.Point(677, 42)
        Me.GalvanizadoCheckBox.Name = "GalvanizadoCheckBox"
        Me.GalvanizadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.GalvanizadoCheckBox.TabIndex = 68
        Me.GalvanizadoCheckBox.Text = "CheckBox1"
        Me.GalvanizadoCheckBox.UseVisualStyleBackColor = True
        '
        'TropicalizadoCheckBox
        '
        Me.TropicalizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Pza_Control_de_planosBindingSource, "Tropicalizado", True))
        Me.TropicalizadoCheckBox.Location = New System.Drawing.Point(677, 69)
        Me.TropicalizadoCheckBox.Name = "TropicalizadoCheckBox"
        Me.TropicalizadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.TropicalizadoCheckBox.TabIndex = 70
        Me.TropicalizadoCheckBox.Text = "CheckBox1"
        Me.TropicalizadoCheckBox.UseVisualStyleBackColor = True
        '
        'Otro_procesoTextBox
        '
        Me.Otro_procesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Otro proceso", True))
        Me.Otro_procesoTextBox.Location = New System.Drawing.Point(677, 99)
        Me.Otro_procesoTextBox.Multiline = True
        Me.Otro_procesoTextBox.Name = "Otro_procesoTextBox"
        Me.Otro_procesoTextBox.Size = New System.Drawing.Size(141, 45)
        Me.Otro_procesoTextBox.TabIndex = 72
        '
        'HerramentalTextBox
        '
        Me.HerramentalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Pza_Control_de_planosBindingSource, "Herramental", True))
        Me.HerramentalTextBox.Location = New System.Drawing.Point(677, 150)
        Me.HerramentalTextBox.Multiline = True
        Me.HerramentalTextBox.Name = "HerramentalTextBox"
        Me.HerramentalTextBox.Size = New System.Drawing.Size(141, 37)
        Me.HerramentalTextBox.TabIndex = 74
        '
        'fraccion
        '
        Me.fraccion.AutoSize = True
        Me.fraccion.Location = New System.Drawing.Point(123, 178)
        Me.fraccion.Name = "fraccion"
        Me.fraccion.Size = New System.Drawing.Size(39, 13)
        Me.fraccion.TabIndex = 81
        Me.fraccion.Text = "Label1"
        '
        'MILI
        '
        Me.MILI.Location = New System.Drawing.Point(83, 175)
        Me.MILI.Name = "MILI"
        Me.MILI.Size = New System.Drawing.Size(39, 20)
        Me.MILI.TabIndex = 83
        Me.MILI.Visible = False
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'ManufacturaTableAdapter
        '
        Me.ManufacturaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CotizacionesTableAdapter = Nothing
        Me.TableAdapterManager.ManufacturaTableAdapter = Me.ManufacturaTableAdapter
        Me.TableAdapterManager.tblAdministradorTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Pza_Control_de_planosTableAdapter
        '
        Me.Pza_Control_de_planosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Control_planosTableAdapter = Nothing
        Me.TableAdapterManager1.Cotrol_de_planosTableAdapter = Nothing
        Me.TableAdapterManager1.ManufacturaTableAdapter = Nothing
        Me.TableAdapterManager1.Pza_Control_de_planosTableAdapter = Me.Pza_Control_de_planosTableAdapter
        Me.TableAdapterManager1.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager1.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager1.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FTM_Registros._Manufactura_1_5DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VentasTableAdapter = Nothing
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'Manufactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(865, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manufactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manufactura"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.ManufacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pza_Control_de_planosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Manufactura_1_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents ManufacturaBindingSource As BindingSource
    Friend WithEvents ManufacturaTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.ManufacturaTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents __de_orden_a_cotizarComboBox As ComboBox
    Friend WithEvents FactibilidadCheckBox As CheckBox
    Friend WithEvents Observaciones_de_no_factibilidadTextBox As TextBox
    Friend WithEvents ClienteTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents _Manufactura_1_5DataSet As _Manufactura_1_5DataSet
    Friend WithEvents Pza_Control_de_planosBindingSource As BindingSource
    Friend WithEvents Pza_Control_de_planosTableAdapter As _Manufactura_1_5DataSetTableAdapters.Pza_Control_de_planosTableAdapter
    Friend WithEvents TableAdapterManager1 As _Manufactura_1_5DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteTextBox1 As TextBox
    Friend WithEvents Clave_FTMComboBox As ComboBox
    Friend WithEvents DibujoComboBox As ComboBox
    Friend WithEvents DescripciónComboBox As ComboBox
    Friend WithEvents MILIMETROSCheckBox As CheckBox
    Friend WithEvents MaterialComboBox As ComboBox
    Friend WithEvents Cantidad_PiezasTextBox As TextBox
    Friend WithEvents Corte_LáserCheckBox As CheckBox
    Friend WithEvents Horas_corteTextBox As TextBox
    Friend WithEvents Minutos_corteTextBox As TextBox
    Friend WithEvents Segundos_corteTextBox As TextBox
    Friend WithEvents Tiempo_corteTextBox As TextBox
    Friend WithEvents Corte_WJCheckBox As CheckBox
    Friend WithEvents Corte_SierraCheckBox As CheckBox
    Friend WithEvents __DoblezTextBox As TextBox
    Friend WithEvents Horas_doblezTextBox As TextBox
    Friend WithEvents Minutos_doblezTextBox As TextBox
    Friend WithEvents Segundos_doblezTextBox As TextBox
    Friend WithEvents Tiempos_doblezTextBox As TextBox
    Friend WithEvents MaquinadoCheckBox As CheckBox
    Friend WithEvents Horas_maqTextBox As TextBox
    Friend WithEvents Minutos_maqTextBox As TextBox
    Friend WithEvents Segundos_maqTextBox As TextBox
    Friend WithEvents Tiempo_maquinadoTextBox As TextBox
    Friend WithEvents PunzonadoCheckBox As CheckBox
    Friend WithEvents SoldaduraCheckBox As CheckBox
    Friend WithEvents PinturaCheckBox As CheckBox
    Friend WithEvents GalvanizadoCheckBox As CheckBox
    Friend WithEvents TropicalizadoCheckBox As CheckBox
    Friend WithEvents Otro_procesoTextBox As TextBox
    Friend WithEvents HerramentalTextBox As TextBox
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
    Friend WithEvents GuardarToolStripButton As ToolStripButton
    Friend WithEvents GuardarToolStripButton1 As ToolStripButton
    Friend WithEvents EspesorMM As TextBox
    Friend WithEvents Espesor2TextBox As TextBox
    Friend WithEvents Espesor1TextBox As TextBox
    Friend WithEvents MM As TextBox
    Friend WithEvents in_mm As Label
    Friend WithEvents fraccion As Label
    Friend WithEvents uno As TextBox
    Friend WithEvents MILI As TextBox
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OrdenComboBox As ComboBox
    Friend WithEvents Buscar As Button
    Friend WithEvents Busca As TextBox
    Friend WithEvents Tabla As DataGridView
End Class
