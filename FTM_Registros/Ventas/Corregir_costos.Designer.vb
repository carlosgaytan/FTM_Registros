<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Corregir_costos
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
        Dim DescripciónLabel As System.Windows.Forms.Label
        Dim DibujoLabel As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Precio_MP__MXN_pza_Label As System.Windows.Forms.Label
        Dim Precio_doblez__MXN_Pza_Label As System.Windows.Forms.Label
        Dim PinturaLabel As System.Windows.Forms.Label
        Dim GalvanizadoLabel As System.Windows.Forms.Label
        Dim TropicalizadoLabel As System.Windows.Forms.Label
        Dim Precio_corte__MXN_Pza_Label As System.Windows.Forms.Label
        Dim Precio_final__MXN_pza_Label As System.Windows.Forms.Label
        Dim Precio_Total__MXN_Label As System.Windows.Forms.Label
        Dim __de_orden_a_cotizarLabel1 As System.Windows.Forms.Label
        Dim ClienteLabel1 As System.Windows.Forms.Label
        Dim Clave_FTMLabel As System.Windows.Forms.Label
        Dim P1Label As System.Windows.Forms.Label
        Dim P2Label As System.Windows.Forms.Label
        Dim X1Label As System.Windows.Forms.Label
        Dim Y1Label As System.Windows.Forms.Label
        Dim Valor_materialLabel As System.Windows.Forms.Label
        Dim Peso_Bruto__kg_pza_Label As System.Windows.Forms.Label
        Dim FactorLabel As System.Windows.Forms.Label
        Dim Costo_MP__MNX_KG_Label As System.Windows.Forms.Label
        Dim DoblezLabel As System.Windows.Forms.Label
        Dim Costo_por_doblezLabel As System.Windows.Forms.Label
        Dim Costo_pinturaLabel As System.Windows.Forms.Label
        Dim SoldaduraLabel As System.Windows.Forms.Label
        Dim MaquinadoLabel As System.Windows.Forms.Label
        Dim Costo_galvanizadoLabel As System.Windows.Forms.Label
        Dim Costo_TropicalizadoLabel As System.Windows.Forms.Label
        Dim Tiempo_de_corteLabel As System.Windows.Forms.Label
        Dim Costo_por_hr_corte__MXN_Label As System.Windows.Forms.Label
        Dim CantidadesLabel As System.Windows.Forms.Label
        Dim U_mLabel As System.Windows.Forms.Label
        Dim Nombre_quien_cotizaLabel As System.Windows.Forms.Label
        Dim Label27 As System.Windows.Forms.Label
        Dim Label23 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Y1Label1 As System.Windows.Forms.Label
        Dim X1Label1 As System.Windows.Forms.Label
        Dim MaterialLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corregir_costos))
        Me.CostosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Cotizaciones_1_4DataSet = New FTM_Registros._Cotizaciones_1_4DataSet()
        Me.BuscandoOrdenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscaOrden = New FTM_Registros.BuscaOrden()
        Me.Descripciontxt = New System.Windows.Forms.TextBox()
        Me.Dibujotxt = New System.Windows.Forms.TextBox()
        Me.Maquina = New System.Windows.Forms.TextBox()
        Me.Solda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TropicalizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.GalvanizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.PinturaCheckBox = New System.Windows.Forms.CheckBox()
        Me.SoldaduraCheckBox = New System.Windows.Forms.CheckBox()
        Me.PunzonadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.MaquinadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.SierraCheckBox = New System.Windows.Forms.CheckBox()
        Me.WJCheckBox = New System.Windows.Forms.CheckBox()
        Me.LaserCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrecioMPTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioDoblezTextBox = New System.Windows.Forms.TextBox()
        Me.PinturaTextBox = New System.Windows.Forms.TextBox()
        Me.GalvanizadoTextBox = New System.Windows.Forms.TextBox()
        Me.TropicalizadoTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioCorteTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioFinalTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTotalTextBox = New System.Windows.Forms.TextBox()
        Me.ordenComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteCotizar2 = New FTM_Registros.ReporteCotizar2()
        Me.ClienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Clave_FTMComboBox = New System.Windows.Forms.ComboBox()
        Me.P1TextBox = New System.Windows.Forms.TextBox()
        Me.P2TextBox = New System.Windows.Forms.TextBox()
        Me.X1TextBox = New System.Windows.Forms.TextBox()
        Me.Y1TextBox = New System.Windows.Forms.TextBox()
        Me.ValorMaterial = New System.Windows.Forms.TextBox()
        Me.PesoBruto = New System.Windows.Forms.TextBox()
        Me.FactorComboBox = New System.Windows.Forms.ComboBox()
        Me.CostoMP = New System.Windows.Forms.TextBox()
        Me.DoblezTextBox = New System.Windows.Forms.TextBox()
        Me.CostoDoblez = New System.Windows.Forms.TextBox()
        Me.CostoPintura = New System.Windows.Forms.TextBox()
        Me.SoldaduraTextBox = New System.Windows.Forms.TextBox()
        Me.MaquinadoTextBox = New System.Windows.Forms.TextBox()
        Me.CostoGalvanizado = New System.Windows.Forms.TextBox()
        Me.CostoTropicalizado = New System.Windows.Forms.TextBox()
        Me.TiempoCorte = New System.Windows.Forms.TextBox()
        Me.CostoHR = New System.Windows.Forms.TextBox()
        Me.CantidadesTextBox = New System.Windows.Forms.TextBox()
        Me.U_mTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BuscandoOrdenTableAdapter = New FTM_Registros.BuscaOrdenTableAdapters.BuscandoOrdenTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.BuscaOrdenTableAdapters.TableAdapterManager()
        Me.VentaTableAdapter = New FTM_Registros.ReporteCotizar2TableAdapters.VentaTableAdapter()
        Me.Buscarbtn = New System.Windows.Forms.Button()
        Me.Guardarbtn = New System.Windows.Forms.Button()
        Me.CostosTableAdapter = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.CostosTableAdapter()
        Me.TableAdapterManager1 = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.TableAdapterManager()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.CalibreCBX = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.inRBT = New System.Windows.Forms.RadioButton()
        Me.calRBT = New System.Windows.Forms.RadioButton()
        Me.mmRBT = New System.Windows.Forms.RadioButton()
        Me.Esp2TXT = New System.Windows.Forms.TextBox()
        Me.Esp1TXT = New System.Windows.Forms.TextBox()
        Me.CERO2 = New System.Windows.Forms.TextBox()
        Me.CERO = New System.Windows.Forms.TextBox()
        Me.Millon = New System.Windows.Forms.TextBox()
        Me.Prueba = New System.Windows.Forms.TextBox()
        Me.Y1TextBox1 = New System.Windows.Forms.TextBox()
        Me.X1TextBox1 = New System.Windows.Forms.TextBox()
        Me.MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.EspesorTextBox = New System.Windows.Forms.TextBox()
        Me.EspRepTXT = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Nombre_quien_cotizaComboBox = New System.Windows.Forms.TextBox()
        Me.Notificacion = New System.Windows.Forms.NotifyIcon(Me.components)
        DescripciónLabel = New System.Windows.Forms.Label()
        DibujoLabel = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Precio_MP__MXN_pza_Label = New System.Windows.Forms.Label()
        Precio_doblez__MXN_Pza_Label = New System.Windows.Forms.Label()
        PinturaLabel = New System.Windows.Forms.Label()
        GalvanizadoLabel = New System.Windows.Forms.Label()
        TropicalizadoLabel = New System.Windows.Forms.Label()
        Precio_corte__MXN_Pza_Label = New System.Windows.Forms.Label()
        Precio_final__MXN_pza_Label = New System.Windows.Forms.Label()
        Precio_Total__MXN_Label = New System.Windows.Forms.Label()
        __de_orden_a_cotizarLabel1 = New System.Windows.Forms.Label()
        ClienteLabel1 = New System.Windows.Forms.Label()
        Clave_FTMLabel = New System.Windows.Forms.Label()
        P1Label = New System.Windows.Forms.Label()
        P2Label = New System.Windows.Forms.Label()
        X1Label = New System.Windows.Forms.Label()
        Y1Label = New System.Windows.Forms.Label()
        Valor_materialLabel = New System.Windows.Forms.Label()
        Peso_Bruto__kg_pza_Label = New System.Windows.Forms.Label()
        FactorLabel = New System.Windows.Forms.Label()
        Costo_MP__MNX_KG_Label = New System.Windows.Forms.Label()
        DoblezLabel = New System.Windows.Forms.Label()
        Costo_por_doblezLabel = New System.Windows.Forms.Label()
        Costo_pinturaLabel = New System.Windows.Forms.Label()
        SoldaduraLabel = New System.Windows.Forms.Label()
        MaquinadoLabel = New System.Windows.Forms.Label()
        Costo_galvanizadoLabel = New System.Windows.Forms.Label()
        Costo_TropicalizadoLabel = New System.Windows.Forms.Label()
        Tiempo_de_corteLabel = New System.Windows.Forms.Label()
        Costo_por_hr_corte__MXN_Label = New System.Windows.Forms.Label()
        CantidadesLabel = New System.Windows.Forms.Label()
        U_mLabel = New System.Windows.Forms.Label()
        Nombre_quien_cotizaLabel = New System.Windows.Forms.Label()
        Label27 = New System.Windows.Forms.Label()
        Label23 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Y1Label1 = New System.Windows.Forms.Label()
        X1Label1 = New System.Windows.Forms.Label()
        MaterialLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscandoOrdenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscaOrden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteCotizar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.BackColor = System.Drawing.Color.White
        DescripciónLabel.Location = New System.Drawing.Point(23, 199)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(66, 13)
        DescripciónLabel.TabIndex = 328
        DescripciónLabel.Text = "Descripción:"
        '
        'DibujoLabel
        '
        DibujoLabel.AutoSize = True
        DibujoLabel.BackColor = System.Drawing.Color.White
        DibujoLabel.Location = New System.Drawing.Point(23, 171)
        DibujoLabel.Name = "DibujoLabel"
        DibujoLabel.Size = New System.Drawing.Size(40, 13)
        DibujoLabel.TabIndex = 326
        DibujoLabel.Text = "Dibujo:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.White
        Label5.Location = New System.Drawing.Point(27, 442)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 13)
        Label5.TabIndex = 269
        Label5.Text = "Soldadura:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.BackColor = System.Drawing.Color.White
        Label6.Location = New System.Drawing.Point(27, 469)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(63, 13)
        Label6.TabIndex = 264
        Label6.Text = "Maquinado:"
        '
        'Precio_MP__MXN_pza_Label
        '
        Precio_MP__MXN_pza_Label.AutoSize = True
        Precio_MP__MXN_pza_Label.BackColor = System.Drawing.SystemColors.Control
        Precio_MP__MXN_pza_Label.Location = New System.Drawing.Point(586, 149)
        Precio_MP__MXN_pza_Label.Name = "Precio_MP__MXN_pza_Label"
        Precio_MP__MXN_pza_Label.Size = New System.Drawing.Size(114, 13)
        Precio_MP__MXN_pza_Label.TabIndex = 231
        Precio_MP__MXN_pza_Label.Text = "Precio MP (MXN/pza):"
        '
        'Precio_doblez__MXN_Pza_Label
        '
        Precio_doblez__MXN_Pza_Label.AutoSize = True
        Precio_doblez__MXN_Pza_Label.BackColor = System.Drawing.SystemColors.Control
        Precio_doblez__MXN_Pza_Label.Location = New System.Drawing.Point(586, 175)
        Precio_doblez__MXN_Pza_Label.Name = "Precio_doblez__MXN_Pza_Label"
        Precio_doblez__MXN_Pza_Label.Size = New System.Drawing.Size(130, 13)
        Precio_doblez__MXN_Pza_Label.TabIndex = 232
        Precio_doblez__MXN_Pza_Label.Text = "Precio doblez (MXN/Pza):"
        '
        'PinturaLabel
        '
        PinturaLabel.AutoSize = True
        PinturaLabel.BackColor = System.Drawing.SystemColors.Control
        PinturaLabel.Location = New System.Drawing.Point(586, 256)
        PinturaLabel.Name = "PinturaLabel"
        PinturaLabel.Size = New System.Drawing.Size(43, 13)
        PinturaLabel.TabIndex = 233
        PinturaLabel.Text = "Pintura:"
        '
        'GalvanizadoLabel
        '
        GalvanizadoLabel.AutoSize = True
        GalvanizadoLabel.BackColor = System.Drawing.SystemColors.Control
        GalvanizadoLabel.Location = New System.Drawing.Point(586, 282)
        GalvanizadoLabel.Name = "GalvanizadoLabel"
        GalvanizadoLabel.Size = New System.Drawing.Size(69, 13)
        GalvanizadoLabel.TabIndex = 234
        GalvanizadoLabel.Text = "Galvanizado:"
        '
        'TropicalizadoLabel
        '
        TropicalizadoLabel.AutoSize = True
        TropicalizadoLabel.BackColor = System.Drawing.SystemColors.Control
        TropicalizadoLabel.Location = New System.Drawing.Point(586, 308)
        TropicalizadoLabel.Name = "TropicalizadoLabel"
        TropicalizadoLabel.Size = New System.Drawing.Size(73, 13)
        TropicalizadoLabel.TabIndex = 235
        TropicalizadoLabel.Text = "Tropicalizado:"
        '
        'Precio_corte__MXN_Pza_Label
        '
        Precio_corte__MXN_Pza_Label.AutoSize = True
        Precio_corte__MXN_Pza_Label.BackColor = System.Drawing.SystemColors.Control
        Precio_corte__MXN_Pza_Label.Location = New System.Drawing.Point(586, 334)
        Precio_corte__MXN_Pza_Label.Name = "Precio_corte__MXN_Pza_Label"
        Precio_corte__MXN_Pza_Label.Size = New System.Drawing.Size(123, 13)
        Precio_corte__MXN_Pza_Label.TabIndex = 236
        Precio_corte__MXN_Pza_Label.Text = "Precio corte (MXN/Pza):"
        '
        'Precio_final__MXN_pza_Label
        '
        Precio_final__MXN_pza_Label.AutoSize = True
        Precio_final__MXN_pza_Label.BackColor = System.Drawing.SystemColors.Control
        Precio_final__MXN_pza_Label.Location = New System.Drawing.Point(586, 360)
        Precio_final__MXN_pza_Label.Name = "Precio_final__MXN_pza_Label"
        Precio_final__MXN_pza_Label.Size = New System.Drawing.Size(117, 13)
        Precio_final__MXN_pza_Label.TabIndex = 237
        Precio_final__MXN_pza_Label.Text = "Precio final (MXN/pza):"
        '
        'Precio_Total__MXN_Label
        '
        Precio_Total__MXN_Label.AutoSize = True
        Precio_Total__MXN_Label.BackColor = System.Drawing.SystemColors.Control
        Precio_Total__MXN_Label.Location = New System.Drawing.Point(586, 386)
        Precio_Total__MXN_Label.Name = "Precio_Total__MXN_Label"
        Precio_Total__MXN_Label.Size = New System.Drawing.Size(100, 13)
        Precio_Total__MXN_Label.TabIndex = 238
        Precio_Total__MXN_Label.Text = "Precio Total (MXN):"
        '
        '__de_orden_a_cotizarLabel1
        '
        __de_orden_a_cotizarLabel1.AutoSize = True
        __de_orden_a_cotizarLabel1.BackColor = System.Drawing.Color.White
        __de_orden_a_cotizarLabel1.Location = New System.Drawing.Point(23, 48)
        __de_orden_a_cotizarLabel1.Name = "__de_orden_a_cotizarLabel1"
        __de_orden_a_cotizarLabel1.Size = New System.Drawing.Size(72, 13)
        __de_orden_a_cotizarLabel1.TabIndex = 239
        __de_orden_a_cotizarLabel1.Text = "No. de orden:"
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.BackColor = System.Drawing.Color.White
        ClienteLabel1.Location = New System.Drawing.Point(23, 115)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(42, 13)
        ClienteLabel1.TabIndex = 240
        ClienteLabel1.Text = "Cliente:"
        '
        'Clave_FTMLabel
        '
        Clave_FTMLabel.AutoSize = True
        Clave_FTMLabel.BackColor = System.Drawing.Color.White
        Clave_FTMLabel.Location = New System.Drawing.Point(23, 142)
        Clave_FTMLabel.Name = "Clave_FTMLabel"
        Clave_FTMLabel.Size = New System.Drawing.Size(62, 13)
        Clave_FTMLabel.TabIndex = 241
        Clave_FTMLabel.Text = "Clave FTM:"
        '
        'P1Label
        '
        P1Label.AutoSize = True
        P1Label.BackColor = System.Drawing.Color.White
        P1Label.Location = New System.Drawing.Point(171, 232)
        P1Label.Name = "P1Label"
        P1Label.Size = New System.Drawing.Size(23, 13)
        P1Label.TabIndex = 242
        P1Label.Text = "P1:"
        '
        'P2Label
        '
        P2Label.AutoSize = True
        P2Label.BackColor = System.Drawing.Color.White
        P2Label.Location = New System.Drawing.Point(171, 258)
        P2Label.Name = "P2Label"
        P2Label.Size = New System.Drawing.Size(23, 13)
        P2Label.TabIndex = 243
        P2Label.Text = "P2:"
        '
        'X1Label
        '
        X1Label.AutoSize = True
        X1Label.BackColor = System.Drawing.Color.White
        X1Label.Location = New System.Drawing.Point(49, 232)
        X1Label.Name = "X1Label"
        X1Label.Size = New System.Drawing.Size(17, 13)
        X1Label.TabIndex = 244
        X1Label.Text = "X:"
        '
        'Y1Label
        '
        Y1Label.AutoSize = True
        Y1Label.BackColor = System.Drawing.Color.White
        Y1Label.Location = New System.Drawing.Point(49, 258)
        Y1Label.Name = "Y1Label"
        Y1Label.Size = New System.Drawing.Size(17, 13)
        Y1Label.TabIndex = 245
        Y1Label.Text = "Y:"
        '
        'Valor_materialLabel
        '
        Valor_materialLabel.AutoSize = True
        Valor_materialLabel.BackColor = System.Drawing.Color.White
        Valor_materialLabel.Location = New System.Drawing.Point(317, 173)
        Valor_materialLabel.Name = "Valor_materialLabel"
        Valor_materialLabel.Size = New System.Drawing.Size(87, 13)
        Valor_materialLabel.TabIndex = 246
        Valor_materialLabel.Text = "Peso específico:"
        '
        'Peso_Bruto__kg_pza_Label
        '
        Peso_Bruto__kg_pza_Label.AutoSize = True
        Peso_Bruto__kg_pza_Label.BackColor = System.Drawing.Color.White
        Peso_Bruto__kg_pza_Label.Location = New System.Drawing.Point(59, 291)
        Peso_Bruto__kg_pza_Label.Name = "Peso_Bruto__kg_pza_Label"
        Peso_Bruto__kg_pza_Label.Size = New System.Drawing.Size(107, 13)
        Peso_Bruto__kg_pza_Label.TabIndex = 247
        Peso_Bruto__kg_pza_Label.Text = "Peso/Bruto (kg/pza):"
        '
        'FactorLabel
        '
        FactorLabel.AutoSize = True
        FactorLabel.BackColor = System.Drawing.Color.White
        FactorLabel.Location = New System.Drawing.Point(317, 200)
        FactorLabel.Name = "FactorLabel"
        FactorLabel.Size = New System.Drawing.Size(40, 13)
        FactorLabel.TabIndex = 248
        FactorLabel.Text = "Factor:"
        '
        'Costo_MP__MNX_KG_Label
        '
        Costo_MP__MNX_KG_Label.AutoSize = True
        Costo_MP__MNX_KG_Label.BackColor = System.Drawing.Color.White
        Costo_MP__MNX_KG_Label.Location = New System.Drawing.Point(23, 364)
        Costo_MP__MNX_KG_Label.Name = "Costo_MP__MNX_KG_Label"
        Costo_MP__MNX_KG_Label.Size = New System.Drawing.Size(109, 13)
        Costo_MP__MNX_KG_Label.TabIndex = 249
        Costo_MP__MNX_KG_Label.Text = "Costo MP (MNX/KG):"
        '
        'DoblezLabel
        '
        DoblezLabel.AutoSize = True
        DoblezLabel.BackColor = System.Drawing.Color.White
        DoblezLabel.Location = New System.Drawing.Point(23, 390)
        DoblezLabel.Name = "DoblezLabel"
        DoblezLabel.Size = New System.Drawing.Size(43, 13)
        DoblezLabel.TabIndex = 252
        DoblezLabel.Text = "Doblez:"
        '
        'Costo_por_doblezLabel
        '
        Costo_por_doblezLabel.AutoSize = True
        Costo_por_doblezLabel.BackColor = System.Drawing.Color.White
        Costo_por_doblezLabel.Location = New System.Drawing.Point(23, 416)
        Costo_por_doblezLabel.Name = "Costo_por_doblezLabel"
        Costo_por_doblezLabel.Size = New System.Drawing.Size(89, 13)
        Costo_por_doblezLabel.TabIndex = 253
        Costo_por_doblezLabel.Text = "Costo por doblez:"
        '
        'Costo_pinturaLabel
        '
        Costo_pinturaLabel.AutoSize = True
        Costo_pinturaLabel.BackColor = System.Drawing.Color.White
        Costo_pinturaLabel.Location = New System.Drawing.Point(263, 364)
        Costo_pinturaLabel.Name = "Costo_pinturaLabel"
        Costo_pinturaLabel.Size = New System.Drawing.Size(72, 13)
        Costo_pinturaLabel.TabIndex = 254
        Costo_pinturaLabel.Text = "Costo pintura:"
        '
        'SoldaduraLabel
        '
        SoldaduraLabel.AutoSize = True
        SoldaduraLabel.BackColor = System.Drawing.SystemColors.Control
        SoldaduraLabel.Location = New System.Drawing.Point(586, 201)
        SoldaduraLabel.Name = "SoldaduraLabel"
        SoldaduraLabel.Size = New System.Drawing.Size(58, 13)
        SoldaduraLabel.TabIndex = 255
        SoldaduraLabel.Text = "Soldadura:"
        '
        'MaquinadoLabel
        '
        MaquinadoLabel.AutoSize = True
        MaquinadoLabel.BackColor = System.Drawing.SystemColors.Control
        MaquinadoLabel.Location = New System.Drawing.Point(586, 228)
        MaquinadoLabel.Name = "MaquinadoLabel"
        MaquinadoLabel.Size = New System.Drawing.Size(63, 13)
        MaquinadoLabel.TabIndex = 258
        MaquinadoLabel.Text = "Maquinado:"
        '
        'Costo_galvanizadoLabel
        '
        Costo_galvanizadoLabel.AutoSize = True
        Costo_galvanizadoLabel.BackColor = System.Drawing.Color.White
        Costo_galvanizadoLabel.Location = New System.Drawing.Point(263, 390)
        Costo_galvanizadoLabel.Name = "Costo_galvanizadoLabel"
        Costo_galvanizadoLabel.Size = New System.Drawing.Size(97, 13)
        Costo_galvanizadoLabel.TabIndex = 263
        Costo_galvanizadoLabel.Text = "Costo galvanizado:"
        '
        'Costo_TropicalizadoLabel
        '
        Costo_TropicalizadoLabel.AutoSize = True
        Costo_TropicalizadoLabel.BackColor = System.Drawing.Color.White
        Costo_TropicalizadoLabel.Location = New System.Drawing.Point(263, 416)
        Costo_TropicalizadoLabel.Name = "Costo_TropicalizadoLabel"
        Costo_TropicalizadoLabel.Size = New System.Drawing.Size(103, 13)
        Costo_TropicalizadoLabel.TabIndex = 261
        Costo_TropicalizadoLabel.Text = "Costo Tropicalizado:"
        '
        'Tiempo_de_corteLabel
        '
        Tiempo_de_corteLabel.AutoSize = True
        Tiempo_de_corteLabel.BackColor = System.Drawing.Color.White
        Tiempo_de_corteLabel.Location = New System.Drawing.Point(263, 442)
        Tiempo_de_corteLabel.Name = "Tiempo_de_corteLabel"
        Tiempo_de_corteLabel.Size = New System.Drawing.Size(87, 13)
        Tiempo_de_corteLabel.TabIndex = 260
        Tiempo_de_corteLabel.Text = "Tiempo de corte:"
        '
        'Costo_por_hr_corte__MXN_Label
        '
        Costo_por_hr_corte__MXN_Label.AutoSize = True
        Costo_por_hr_corte__MXN_Label.BackColor = System.Drawing.Color.White
        Costo_por_hr_corte__MXN_Label.Location = New System.Drawing.Point(263, 468)
        Costo_por_hr_corte__MXN_Label.Name = "Costo_por_hr_corte__MXN_Label"
        Costo_por_hr_corte__MXN_Label.Size = New System.Drawing.Size(127, 13)
        Costo_por_hr_corte__MXN_Label.TabIndex = 266
        Costo_por_hr_corte__MXN_Label.Text = "Costo por hr corte (MXN):"
        '
        'CantidadesLabel
        '
        CantidadesLabel.AutoSize = True
        CantidadesLabel.BackColor = System.Drawing.Color.White
        CantidadesLabel.Location = New System.Drawing.Point(317, 257)
        CantidadesLabel.Name = "CantidadesLabel"
        CantidadesLabel.Size = New System.Drawing.Size(63, 13)
        CantidadesLabel.TabIndex = 262
        CantidadesLabel.Text = "Cantidades:"
        '
        'U_mLabel
        '
        U_mLabel.AutoSize = True
        U_mLabel.BackColor = System.Drawing.Color.White
        U_mLabel.Location = New System.Drawing.Point(317, 230)
        U_mLabel.Name = "U_mLabel"
        U_mLabel.Size = New System.Drawing.Size(29, 13)
        U_mLabel.TabIndex = 278
        U_mLabel.Text = "u/m:"
        '
        'Nombre_quien_cotizaLabel
        '
        Nombre_quien_cotizaLabel.AutoSize = True
        Nombre_quien_cotizaLabel.BackColor = System.Drawing.Color.White
        Nombre_quien_cotizaLabel.Location = New System.Drawing.Point(23, 82)
        Nombre_quien_cotizaLabel.Name = "Nombre_quien_cotizaLabel"
        Nombre_quien_cotizaLabel.Size = New System.Drawing.Size(54, 13)
        Nombre_quien_cotizaLabel.TabIndex = 276
        Nombre_quien_cotizaLabel.Text = "Cotizador:"
        '
        'Label27
        '
        Label27.AutoSize = True
        Label27.BackColor = System.Drawing.Color.White
        Label27.Location = New System.Drawing.Point(635, 101)
        Label27.Name = "Label27"
        Label27.Size = New System.Drawing.Size(69, 13)
        Label27.TabIndex = 359
        Label27.Text = "Espesor MM:"
        Label27.Visible = False
        '
        'Label23
        '
        Label23.AutoSize = True
        Label23.BackColor = System.Drawing.Color.White
        Label23.Location = New System.Drawing.Point(317, 115)
        Label23.Name = "Label23"
        Label23.Size = New System.Drawing.Size(49, 13)
        Label23.TabIndex = 356
        Label23.Text = "Pulgada:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.BackColor = System.Drawing.Color.White
        Label10.Location = New System.Drawing.Point(399, 115)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(42, 13)
        Label10.TabIndex = 352
        Label10.Text = "Calibre:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.BackColor = System.Drawing.Color.White
        Label7.Location = New System.Drawing.Point(469, 115)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(58, 13)
        Label7.TabIndex = 349
        Label7.Text = "Milímetros:"
        '
        'Y1Label1
        '
        Y1Label1.AutoSize = True
        Y1Label1.BackColor = System.Drawing.Color.White
        Y1Label1.Location = New System.Drawing.Point(669, 75)
        Y1Label1.Name = "Y1Label1"
        Y1Label1.Size = New System.Drawing.Size(23, 13)
        Y1Label1.TabIndex = 340
        Y1Label1.Text = "Y1:"
        Y1Label1.Visible = False
        '
        'X1Label1
        '
        X1Label1.AutoSize = True
        X1Label1.BackColor = System.Drawing.Color.White
        X1Label1.Location = New System.Drawing.Point(669, 51)
        X1Label1.Name = "X1Label1"
        X1Label1.Size = New System.Drawing.Size(23, 13)
        X1Label1.TabIndex = 338
        X1Label1.Text = "X1:"
        X1Label1.Visible = False
        '
        'MaterialLabel
        '
        MaterialLabel.AutoSize = True
        MaterialLabel.BackColor = System.Drawing.Color.White
        MaterialLabel.Location = New System.Drawing.Point(317, 82)
        MaterialLabel.Name = "MaterialLabel"
        MaterialLabel.Size = New System.Drawing.Size(47, 13)
        MaterialLabel.TabIndex = 336
        MaterialLabel.Text = "Material:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(363, 308)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(48, 13)
        Label8.TabIndex = 362
        Label8.Text = "Espesor:"
        Label8.Visible = False
        '
        'CostosBindingSource
        '
        Me.CostosBindingSource.DataMember = "Costos"
        Me.CostosBindingSource.DataSource = Me._Cotizaciones_1_4DataSet
        '
        '_Cotizaciones_1_4DataSet
        '
        Me._Cotizaciones_1_4DataSet.DataSetName = "_Cotizaciones_1_4DataSet"
        Me._Cotizaciones_1_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscandoOrdenBindingSource
        '
        Me.BuscandoOrdenBindingSource.DataMember = "BuscandoOrden"
        Me.BuscandoOrdenBindingSource.DataSource = Me.BuscaOrden
        '
        'BuscaOrden
        '
        Me.BuscaOrden.DataSetName = "BuscaOrden"
        Me.BuscaOrden.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Descripciontxt
        '
        Me.Descripciontxt.BackColor = System.Drawing.SystemColors.Control
        Me.Descripciontxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Descripción", True))
        Me.Descripciontxt.Location = New System.Drawing.Point(159, 196)
        Me.Descripciontxt.Name = "Descripciontxt"
        Me.Descripciontxt.Size = New System.Drawing.Size(121, 20)
        Me.Descripciontxt.TabIndex = 329
        Me.Descripciontxt.Visible = False
        '
        'Dibujotxt
        '
        Me.Dibujotxt.BackColor = System.Drawing.SystemColors.Control
        Me.Dibujotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Dibujo", True))
        Me.Dibujotxt.Location = New System.Drawing.Point(159, 168)
        Me.Dibujotxt.Name = "Dibujotxt"
        Me.Dibujotxt.Size = New System.Drawing.Size(121, 20)
        Me.Dibujotxt.TabIndex = 327
        Me.Dibujotxt.Visible = False
        '
        'Maquina
        '
        Me.Maquina.BackColor = System.Drawing.SystemColors.Control
        Me.Maquina.Location = New System.Drawing.Point(145, 466)
        Me.Maquina.Name = "Maquina"
        Me.Maquina.Size = New System.Drawing.Size(76, 20)
        Me.Maquina.TabIndex = 299
        Me.Maquina.Visible = False
        '
        'Solda
        '
        Me.Solda.BackColor = System.Drawing.SystemColors.Control
        Me.Solda.Location = New System.Drawing.Point(145, 439)
        Me.Solda.Name = "Solda"
        Me.Solda.Size = New System.Drawing.Size(76, 20)
        Me.Solda.TabIndex = 298
        Me.Solda.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(131, 442)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 270
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(131, 469)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 268
        Me.Label4.Text = "$"
        '
        'TropicalizadoCheckBox
        '
        Me.TropicalizadoCheckBox.BackColor = System.Drawing.Color.White
        Me.TropicalizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "TropicalizadoCHBX", True))
        Me.TropicalizadoCheckBox.Location = New System.Drawing.Point(480, 411)
        Me.TropicalizadoCheckBox.Name = "TropicalizadoCheckBox"
        Me.TropicalizadoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.TropicalizadoCheckBox.TabIndex = 321
        Me.TropicalizadoCheckBox.Text = "CheckBox1"
        Me.TropicalizadoCheckBox.UseVisualStyleBackColor = False
        '
        'GalvanizadoCheckBox
        '
        Me.GalvanizadoCheckBox.BackColor = System.Drawing.Color.White
        Me.GalvanizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "GalvanizadoCHBX", True))
        Me.GalvanizadoCheckBox.Location = New System.Drawing.Point(480, 385)
        Me.GalvanizadoCheckBox.Name = "GalvanizadoCheckBox"
        Me.GalvanizadoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.GalvanizadoCheckBox.TabIndex = 320
        Me.GalvanizadoCheckBox.Text = "CheckBox1"
        Me.GalvanizadoCheckBox.UseVisualStyleBackColor = False
        '
        'PinturaCheckBox
        '
        Me.PinturaCheckBox.BackColor = System.Drawing.Color.White
        Me.PinturaCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "PinturaCHBX", True))
        Me.PinturaCheckBox.Location = New System.Drawing.Point(480, 359)
        Me.PinturaCheckBox.Name = "PinturaCheckBox"
        Me.PinturaCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.PinturaCheckBox.TabIndex = 319
        Me.PinturaCheckBox.Text = "CheckBox1"
        Me.PinturaCheckBox.UseVisualStyleBackColor = False
        '
        'SoldaduraCheckBox
        '
        Me.SoldaduraCheckBox.BackColor = System.Drawing.Color.White
        Me.SoldaduraCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "SoldaduraCHBX", True))
        Me.SoldaduraCheckBox.Location = New System.Drawing.Point(227, 437)
        Me.SoldaduraCheckBox.Name = "SoldaduraCheckBox"
        Me.SoldaduraCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.SoldaduraCheckBox.TabIndex = 317
        Me.SoldaduraCheckBox.Text = "CheckBox1"
        Me.SoldaduraCheckBox.UseVisualStyleBackColor = False
        '
        'PunzonadoCheckBox
        '
        Me.PunzonadoCheckBox.BackColor = System.Drawing.Color.White
        Me.PunzonadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "PunzonadoCHBX", True))
        Me.PunzonadoCheckBox.Location = New System.Drawing.Point(480, 497)
        Me.PunzonadoCheckBox.Name = "PunzonadoCheckBox"
        Me.PunzonadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PunzonadoCheckBox.TabIndex = 325
        Me.PunzonadoCheckBox.Text = "Punzonado"
        Me.PunzonadoCheckBox.UseVisualStyleBackColor = False
        '
        'MaquinadoCheckBox
        '
        Me.MaquinadoCheckBox.BackColor = System.Drawing.Color.White
        Me.MaquinadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "MaquinadoCHBX", True))
        Me.MaquinadoCheckBox.Location = New System.Drawing.Point(227, 463)
        Me.MaquinadoCheckBox.Name = "MaquinadoCheckBox"
        Me.MaquinadoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.MaquinadoCheckBox.TabIndex = 318
        Me.MaquinadoCheckBox.Text = "CheckBox1"
        Me.MaquinadoCheckBox.UseVisualStyleBackColor = False
        '
        'SierraCheckBox
        '
        Me.SierraCheckBox.BackColor = System.Drawing.Color.White
        Me.SierraCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "SierraCHBX", True))
        Me.SierraCheckBox.Location = New System.Drawing.Point(480, 477)
        Me.SierraCheckBox.Name = "SierraCheckBox"
        Me.SierraCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SierraCheckBox.TabIndex = 324
        Me.SierraCheckBox.Text = "Sierra"
        Me.SierraCheckBox.UseVisualStyleBackColor = False
        '
        'WJCheckBox
        '
        Me.WJCheckBox.BackColor = System.Drawing.Color.White
        Me.WJCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "WJCHBX", True))
        Me.WJCheckBox.Location = New System.Drawing.Point(480, 457)
        Me.WJCheckBox.Name = "WJCheckBox"
        Me.WJCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.WJCheckBox.TabIndex = 323
        Me.WJCheckBox.Text = "WJ"
        Me.WJCheckBox.UseVisualStyleBackColor = False
        '
        'LaserCheckBox
        '
        Me.LaserCheckBox.BackColor = System.Drawing.Color.White
        Me.LaserCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "LaserCHBX", True))
        Me.LaserCheckBox.Location = New System.Drawing.Point(480, 437)
        Me.LaserCheckBox.Name = "LaserCheckBox"
        Me.LaserCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.LaserCheckBox.TabIndex = 322
        Me.LaserCheckBox.Text = "Láser"
        Me.LaserCheckBox.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(391, 390)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 265
        Me.Label25.Text = "$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(391, 416)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 267
        Me.Label24.Text = "$"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(716, 201)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 273
        Me.Label22.Text = "$"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(131, 416)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 279
        Me.Label21.Text = "$"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(131, 364)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 277
        Me.Label19.Text = "$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(716, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 280
        Me.Label18.Text = "$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(716, 175)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 274
        Me.Label17.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(716, 256)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 272
        Me.Label16.Text = "$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(716, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 271
        Me.Label15.Text = "$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(716, 308)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 259
        Me.Label14.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(716, 334)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 275
        Me.Label13.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(716, 360)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 257
        Me.Label12.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(716, 386)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 256
        Me.Label11.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(716, 228)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(391, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 230
        Me.Label1.Text = "$"
        '
        'PrecioMPTextBox
        '
        Me.PrecioMPTextBox.BackColor = System.Drawing.Color.White
        Me.PrecioMPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Precio_MP", True))
        Me.PrecioMPTextBox.Location = New System.Drawing.Point(729, 146)
        Me.PrecioMPTextBox.Name = "PrecioMPTextBox"
        Me.PrecioMPTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioMPTextBox.TabIndex = 305
        Me.PrecioMPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioMPTextBox.Visible = False
        '
        'PrecioDoblezTextBox
        '
        Me.PrecioDoblezTextBox.BackColor = System.Drawing.Color.White
        Me.PrecioDoblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Precio_doblez", True))
        Me.PrecioDoblezTextBox.Location = New System.Drawing.Point(729, 172)
        Me.PrecioDoblezTextBox.Name = "PrecioDoblezTextBox"
        Me.PrecioDoblezTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioDoblezTextBox.TabIndex = 306
        Me.PrecioDoblezTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioDoblezTextBox.Visible = False
        '
        'PinturaTextBox
        '
        Me.PinturaTextBox.BackColor = System.Drawing.Color.White
        Me.PinturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Pintura", True))
        Me.PinturaTextBox.Location = New System.Drawing.Point(729, 253)
        Me.PinturaTextBox.Name = "PinturaTextBox"
        Me.PinturaTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PinturaTextBox.TabIndex = 309
        Me.PinturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PinturaTextBox.Visible = False
        '
        'GalvanizadoTextBox
        '
        Me.GalvanizadoTextBox.BackColor = System.Drawing.Color.White
        Me.GalvanizadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Galvanizado", True))
        Me.GalvanizadoTextBox.Location = New System.Drawing.Point(729, 279)
        Me.GalvanizadoTextBox.Name = "GalvanizadoTextBox"
        Me.GalvanizadoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.GalvanizadoTextBox.TabIndex = 310
        Me.GalvanizadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.GalvanizadoTextBox.Visible = False
        '
        'TropicalizadoTextBox
        '
        Me.TropicalizadoTextBox.BackColor = System.Drawing.Color.White
        Me.TropicalizadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Tropicalizado", True))
        Me.TropicalizadoTextBox.Location = New System.Drawing.Point(729, 305)
        Me.TropicalizadoTextBox.Name = "TropicalizadoTextBox"
        Me.TropicalizadoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TropicalizadoTextBox.TabIndex = 311
        Me.TropicalizadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TropicalizadoTextBox.Visible = False
        '
        'PrecioCorteTextBox
        '
        Me.PrecioCorteTextBox.BackColor = System.Drawing.Color.White
        Me.PrecioCorteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Precio_corte", True))
        Me.PrecioCorteTextBox.Location = New System.Drawing.Point(729, 331)
        Me.PrecioCorteTextBox.Name = "PrecioCorteTextBox"
        Me.PrecioCorteTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioCorteTextBox.TabIndex = 312
        Me.PrecioCorteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioCorteTextBox.Visible = False
        '
        'PrecioFinalTextBox
        '
        Me.PrecioFinalTextBox.BackColor = System.Drawing.Color.White
        Me.PrecioFinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Precio_final", True))
        Me.PrecioFinalTextBox.Location = New System.Drawing.Point(729, 357)
        Me.PrecioFinalTextBox.Name = "PrecioFinalTextBox"
        Me.PrecioFinalTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioFinalTextBox.TabIndex = 313
        Me.PrecioFinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioFinalTextBox.Visible = False
        '
        'PrecioTotalTextBox
        '
        Me.PrecioTotalTextBox.BackColor = System.Drawing.Color.White
        Me.PrecioTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Precio_Total", True))
        Me.PrecioTotalTextBox.Location = New System.Drawing.Point(729, 383)
        Me.PrecioTotalTextBox.Name = "PrecioTotalTextBox"
        Me.PrecioTotalTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioTotalTextBox.TabIndex = 314
        Me.PrecioTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.PrecioTotalTextBox.Visible = False
        '
        'ordenComboBox1
        '
        Me.ordenComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ordenComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ordenComboBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ordenComboBox1.DataSource = Me.VentaBindingSource
        Me.ordenComboBox1.DisplayMember = "no_orden"
        Me.ordenComboBox1.FormattingEnabled = True
        Me.ordenComboBox1.Location = New System.Drawing.Point(159, 45)
        Me.ordenComboBox1.Name = "ordenComboBox1"
        Me.ordenComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ordenComboBox1.TabIndex = 282
        Me.ordenComboBox1.ValueMember = "no_orden"
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
        'ClienteTextBox1
        '
        Me.ClienteTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Cliente", True))
        Me.ClienteTextBox1.Location = New System.Drawing.Point(159, 112)
        Me.ClienteTextBox1.Name = "ClienteTextBox1"
        Me.ClienteTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.ClienteTextBox1.TabIndex = 283
        Me.ClienteTextBox1.Visible = False
        '
        'Clave_FTMComboBox
        '
        Me.Clave_FTMComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Clave_FTMComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Clave_FTMComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.Clave_FTMComboBox.DataSource = Me.CostosBindingSource
        Me.Clave_FTMComboBox.DisplayMember = "Clave_FTM"
        Me.Clave_FTMComboBox.FormattingEnabled = True
        Me.Clave_FTMComboBox.Location = New System.Drawing.Point(159, 139)
        Me.Clave_FTMComboBox.Name = "Clave_FTMComboBox"
        Me.Clave_FTMComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Clave_FTMComboBox.TabIndex = 284
        Me.Clave_FTMComboBox.Visible = False
        '
        'P1TextBox
        '
        Me.P1TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.P1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "P1", True))
        Me.P1TextBox.Location = New System.Drawing.Point(195, 229)
        Me.P1TextBox.Name = "P1TextBox"
        Me.P1TextBox.Size = New System.Drawing.Size(53, 20)
        Me.P1TextBox.TabIndex = 287
        Me.P1TextBox.Visible = False
        '
        'P2TextBox
        '
        Me.P2TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.P2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "P2", True))
        Me.P2TextBox.Location = New System.Drawing.Point(195, 255)
        Me.P2TextBox.Name = "P2TextBox"
        Me.P2TextBox.Size = New System.Drawing.Size(53, 20)
        Me.P2TextBox.TabIndex = 288
        Me.P2TextBox.Visible = False
        '
        'X1TextBox
        '
        Me.X1TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.X1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "X", True))
        Me.X1TextBox.Location = New System.Drawing.Point(73, 229)
        Me.X1TextBox.Name = "X1TextBox"
        Me.X1TextBox.Size = New System.Drawing.Size(53, 20)
        Me.X1TextBox.TabIndex = 285
        Me.X1TextBox.Visible = False
        '
        'Y1TextBox
        '
        Me.Y1TextBox.BackColor = System.Drawing.SystemColors.Control
        Me.Y1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Y", True))
        Me.Y1TextBox.Location = New System.Drawing.Point(73, 255)
        Me.Y1TextBox.Name = "Y1TextBox"
        Me.Y1TextBox.Size = New System.Drawing.Size(53, 20)
        Me.Y1TextBox.TabIndex = 286
        Me.Y1TextBox.Visible = False
        '
        'ValorMaterial
        '
        Me.ValorMaterial.BackColor = System.Drawing.SystemColors.Control
        Me.ValorMaterial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Valor_material", True))
        Me.ValorMaterial.Location = New System.Drawing.Point(407, 170)
        Me.ValorMaterial.Name = "ValorMaterial"
        Me.ValorMaterial.Size = New System.Drawing.Size(121, 20)
        Me.ValorMaterial.TabIndex = 291
        Me.ValorMaterial.Visible = False
        '
        'PesoBruto
        '
        Me.PesoBruto.BackColor = System.Drawing.SystemColors.Control
        Me.PesoBruto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Peso_Bruto", True))
        Me.PesoBruto.Location = New System.Drawing.Point(172, 288)
        Me.PesoBruto.Name = "PesoBruto"
        Me.PesoBruto.Size = New System.Drawing.Size(67, 20)
        Me.PesoBruto.TabIndex = 315
        Me.PesoBruto.Visible = False
        '
        'FactorComboBox
        '
        Me.FactorComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.FactorComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Factor", True))
        Me.FactorComboBox.FormattingEnabled = True
        Me.FactorComboBox.Items.AddRange(New Object() {"1.55", "1.5", "1.45", "1.4", "1.35", "1.3", "1.25", "1.2", "1.15", "1.1", "1"})
        Me.FactorComboBox.Location = New System.Drawing.Point(407, 197)
        Me.FactorComboBox.Name = "FactorComboBox"
        Me.FactorComboBox.Size = New System.Drawing.Size(63, 21)
        Me.FactorComboBox.TabIndex = 292
        Me.FactorComboBox.Text = "1.55"
        Me.FactorComboBox.Visible = False
        '
        'CostoMP
        '
        Me.CostoMP.BackColor = System.Drawing.SystemColors.Control
        Me.CostoMP.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Costo_MP", True))
        Me.CostoMP.Location = New System.Drawing.Point(145, 361)
        Me.CostoMP.Name = "CostoMP"
        Me.CostoMP.Size = New System.Drawing.Size(76, 20)
        Me.CostoMP.TabIndex = 295
        Me.CostoMP.Visible = False
        '
        'DoblezTextBox
        '
        Me.DoblezTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.DoblezTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Doblez", True))
        Me.DoblezTextBox.Location = New System.Drawing.Point(145, 387)
        Me.DoblezTextBox.Name = "DoblezTextBox"
        Me.DoblezTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DoblezTextBox.TabIndex = 296
        Me.DoblezTextBox.Visible = False
        '
        'CostoDoblez
        '
        Me.CostoDoblez.BackColor = System.Drawing.SystemColors.Control
        Me.CostoDoblez.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Costo_doblez", True))
        Me.CostoDoblez.Location = New System.Drawing.Point(145, 413)
        Me.CostoDoblez.Name = "CostoDoblez"
        Me.CostoDoblez.Size = New System.Drawing.Size(76, 20)
        Me.CostoDoblez.TabIndex = 297
        Me.CostoDoblez.Visible = False
        '
        'CostoPintura
        '
        Me.CostoPintura.BackColor = System.Drawing.SystemColors.Control
        Me.CostoPintura.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Costo_pintura", True))
        Me.CostoPintura.Location = New System.Drawing.Point(405, 361)
        Me.CostoPintura.Name = "CostoPintura"
        Me.CostoPintura.Size = New System.Drawing.Size(69, 20)
        Me.CostoPintura.TabIndex = 300
        Me.CostoPintura.Visible = False
        '
        'SoldaduraTextBox
        '
        Me.SoldaduraTextBox.BackColor = System.Drawing.Color.White
        Me.SoldaduraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Soldadura", True))
        Me.SoldaduraTextBox.Location = New System.Drawing.Point(730, 198)
        Me.SoldaduraTextBox.Name = "SoldaduraTextBox"
        Me.SoldaduraTextBox.Size = New System.Drawing.Size(96, 20)
        Me.SoldaduraTextBox.TabIndex = 307
        Me.SoldaduraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.SoldaduraTextBox.Visible = False
        '
        'MaquinadoTextBox
        '
        Me.MaquinadoTextBox.BackColor = System.Drawing.Color.White
        Me.MaquinadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Maquinado", True))
        Me.MaquinadoTextBox.Location = New System.Drawing.Point(730, 225)
        Me.MaquinadoTextBox.Name = "MaquinadoTextBox"
        Me.MaquinadoTextBox.Size = New System.Drawing.Size(96, 20)
        Me.MaquinadoTextBox.TabIndex = 308
        Me.MaquinadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MaquinadoTextBox.Visible = False
        '
        'CostoGalvanizado
        '
        Me.CostoGalvanizado.BackColor = System.Drawing.SystemColors.Control
        Me.CostoGalvanizado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Costo_galvanizado", True))
        Me.CostoGalvanizado.Location = New System.Drawing.Point(405, 387)
        Me.CostoGalvanizado.Name = "CostoGalvanizado"
        Me.CostoGalvanizado.Size = New System.Drawing.Size(69, 20)
        Me.CostoGalvanizado.TabIndex = 301
        Me.CostoGalvanizado.Visible = False
        '
        'CostoTropicalizado
        '
        Me.CostoTropicalizado.BackColor = System.Drawing.SystemColors.Control
        Me.CostoTropicalizado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Costo_Tropicalizado", True))
        Me.CostoTropicalizado.Location = New System.Drawing.Point(405, 413)
        Me.CostoTropicalizado.Name = "CostoTropicalizado"
        Me.CostoTropicalizado.Size = New System.Drawing.Size(69, 20)
        Me.CostoTropicalizado.TabIndex = 302
        Me.CostoTropicalizado.Visible = False
        '
        'TiempoCorte
        '
        Me.TiempoCorte.BackColor = System.Drawing.SystemColors.Control
        Me.TiempoCorte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Tiempo_corte", True))
        Me.TiempoCorte.Location = New System.Drawing.Point(405, 439)
        Me.TiempoCorte.Name = "TiempoCorte"
        Me.TiempoCorte.Size = New System.Drawing.Size(69, 20)
        Me.TiempoCorte.TabIndex = 303
        Me.TiempoCorte.Visible = False
        '
        'CostoHR
        '
        Me.CostoHR.BackColor = System.Drawing.SystemColors.Control
        Me.CostoHR.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Costo_hr_corte", True))
        Me.CostoHR.Location = New System.Drawing.Point(405, 465)
        Me.CostoHR.Name = "CostoHR"
        Me.CostoHR.Size = New System.Drawing.Size(69, 20)
        Me.CostoHR.TabIndex = 304
        Me.CostoHR.Visible = False
        '
        'CantidadesTextBox
        '
        Me.CantidadesTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.CantidadesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Cantidades", True))
        Me.CantidadesTextBox.Location = New System.Drawing.Point(404, 254)
        Me.CantidadesTextBox.Name = "CantidadesTextBox"
        Me.CantidadesTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CantidadesTextBox.TabIndex = 294
        Me.CantidadesTextBox.Visible = False
        '
        'U_mTextBox
        '
        Me.U_mTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.U_mTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "um", True))
        Me.U_mTextBox.Location = New System.Drawing.Point(404, 227)
        Me.U_mTextBox.Name = "U_mTextBox"
        Me.U_mTextBox.Size = New System.Drawing.Size(121, 20)
        Me.U_mTextBox.TabIndex = 293
        Me.U_mTextBox.Text = "PZA"
        Me.U_mTextBox.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(577, 124)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 299)
        Me.TextBox1.TabIndex = 228
        '
        'BuscandoOrdenTableAdapter
        '
        Me.BuscandoOrdenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.BuscaOrdenTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'Buscarbtn
        '
        Me.Buscarbtn.Location = New System.Drawing.Point(293, 43)
        Me.Buscarbtn.Name = "Buscarbtn"
        Me.Buscarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Buscarbtn.TabIndex = 334
        Me.Buscarbtn.Text = "Buscar"
        Me.Buscarbtn.UseVisualStyleBackColor = True
        '
        'Guardarbtn
        '
        Me.Guardarbtn.Location = New System.Drawing.Point(374, 43)
        Me.Guardarbtn.Name = "Guardarbtn"
        Me.Guardarbtn.Size = New System.Drawing.Size(75, 23)
        Me.Guardarbtn.TabIndex = 335
        Me.Guardarbtn.Text = "Guardar"
        Me.Guardarbtn.UseVisualStyleBackColor = True
        '
        'CostosTableAdapter
        '
        Me.CostosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Control_planosTableAdapter = Nothing
        Me.TableAdapterManager1.Costos_VentasTableAdapter = Nothing
        Me.TableAdapterManager1.CostosTableAdapter = Me.CostosTableAdapter
        Me.TableAdapterManager1.CotizacionesTableAdapter = Nothing
        Me.TableAdapterManager1.Pza_Control_de_planosTableAdapter = Nothing
        Me.TableAdapterManager1.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager1.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager1.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.VentasTableAdapter = Nothing
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(317, 143)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 13)
        Me.Label28.TabIndex = 360
        Me.Label28.Text = "Espesor:"
        '
        'CalibreCBX
        '
        Me.CalibreCBX.BackColor = System.Drawing.SystemColors.Control
        Me.CalibreCBX.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Esp_cal", True))
        Me.CalibreCBX.FormattingEnabled = True
        Me.CalibreCBX.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "34", "33", "34"})
        Me.CalibreCBX.Location = New System.Drawing.Point(404, 106)
        Me.CalibreCBX.Name = "CalibreCBX"
        Me.CalibreCBX.Size = New System.Drawing.Size(39, 21)
        Me.CalibreCBX.TabIndex = 358
        Me.CalibreCBX.Text = "3"
        Me.CalibreCBX.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(447, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 13)
        Me.Label9.TabIndex = 357
        Me.Label9.Text = "/"
        Me.Label9.Visible = False
        '
        'inRBT
        '
        Me.inRBT.AutoSize = True
        Me.inRBT.BackColor = System.Drawing.Color.White
        Me.inRBT.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "Pulgada", True))
        Me.inRBT.Location = New System.Drawing.Point(366, 115)
        Me.inRBT.Name = "inRBT"
        Me.inRBT.Size = New System.Drawing.Size(14, 13)
        Me.inRBT.TabIndex = 355
        Me.inRBT.TabStop = True
        Me.inRBT.UseVisualStyleBackColor = False
        '
        'calRBT
        '
        Me.calRBT.AutoSize = True
        Me.calRBT.BackColor = System.Drawing.Color.White
        Me.calRBT.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "Calibre", True))
        Me.calRBT.Location = New System.Drawing.Point(440, 115)
        Me.calRBT.Name = "calRBT"
        Me.calRBT.Size = New System.Drawing.Size(14, 13)
        Me.calRBT.TabIndex = 354
        Me.calRBT.TabStop = True
        Me.calRBT.UseVisualStyleBackColor = False
        '
        'mmRBT
        '
        Me.mmRBT.AutoSize = True
        Me.mmRBT.BackColor = System.Drawing.Color.White
        Me.mmRBT.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CostosBindingSource, "Milímetros", True))
        Me.mmRBT.Location = New System.Drawing.Point(526, 115)
        Me.mmRBT.Name = "mmRBT"
        Me.mmRBT.Size = New System.Drawing.Size(14, 13)
        Me.mmRBT.TabIndex = 353
        Me.mmRBT.TabStop = True
        Me.mmRBT.UseVisualStyleBackColor = False
        '
        'Esp2TXT
        '
        Me.Esp2TXT.BackColor = System.Drawing.SystemColors.Control
        Me.Esp2TXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Esp_2", True))
        Me.Esp2TXT.Location = New System.Drawing.Point(459, 140)
        Me.Esp2TXT.Name = "Esp2TXT"
        Me.Esp2TXT.Size = New System.Drawing.Size(39, 20)
        Me.Esp2TXT.TabIndex = 351
        Me.Esp2TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Esp2TXT.Visible = False
        '
        'Esp1TXT
        '
        Me.Esp1TXT.BackColor = System.Drawing.SystemColors.Control
        Me.Esp1TXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Esp_1", True))
        Me.Esp1TXT.Location = New System.Drawing.Point(407, 140)
        Me.Esp1TXT.Name = "Esp1TXT"
        Me.Esp1TXT.Size = New System.Drawing.Size(39, 20)
        Me.Esp1TXT.TabIndex = 350
        Me.Esp1TXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Esp1TXT.Visible = False
        '
        'CERO2
        '
        Me.CERO2.BackColor = System.Drawing.SystemColors.Control
        Me.CERO2.Location = New System.Drawing.Point(777, 75)
        Me.CERO2.Name = "CERO2"
        Me.CERO2.Size = New System.Drawing.Size(20, 20)
        Me.CERO2.TabIndex = 344
        Me.CERO2.Text = "0.0000"
        Me.CERO2.Visible = False
        '
        'CERO
        '
        Me.CERO.BackColor = System.Drawing.SystemColors.Control
        Me.CERO.Location = New System.Drawing.Point(777, 48)
        Me.CERO.Name = "CERO"
        Me.CERO.Size = New System.Drawing.Size(20, 20)
        Me.CERO.TabIndex = 343
        Me.CERO.Text = "0"
        Me.CERO.Visible = False
        '
        'Millon
        '
        Me.Millon.BackColor = System.Drawing.SystemColors.Control
        Me.Millon.Location = New System.Drawing.Point(777, 98)
        Me.Millon.Name = "Millon"
        Me.Millon.Size = New System.Drawing.Size(51, 20)
        Me.Millon.TabIndex = 342
        Me.Millon.Text = "1000000"
        Me.Millon.Visible = False
        '
        'Prueba
        '
        Me.Prueba.BackColor = System.Drawing.SystemColors.Control
        Me.Prueba.Location = New System.Drawing.Point(807, 48)
        Me.Prueba.Name = "Prueba"
        Me.Prueba.Size = New System.Drawing.Size(21, 20)
        Me.Prueba.TabIndex = 341
        Me.Prueba.Text = "10"
        Me.Prueba.Visible = False
        '
        'Y1TextBox1
        '
        Me.Y1TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.Y1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Y1", True))
        Me.Y1TextBox1.Location = New System.Drawing.Point(698, 72)
        Me.Y1TextBox1.Name = "Y1TextBox1"
        Me.Y1TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.Y1TextBox1.TabIndex = 339
        Me.Y1TextBox1.Visible = False
        '
        'X1TextBox1
        '
        Me.X1TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.X1TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "X1", True))
        Me.X1TextBox1.Location = New System.Drawing.Point(698, 48)
        Me.X1TextBox1.Name = "X1TextBox1"
        Me.X1TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.X1TextBox1.TabIndex = 337
        Me.X1TextBox1.Visible = False
        '
        'MaterialTextBox
        '
        Me.MaterialTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.MaterialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Material", True))
        Me.MaterialTextBox.Location = New System.Drawing.Point(407, 79)
        Me.MaterialTextBox.Name = "MaterialTextBox"
        Me.MaterialTextBox.Size = New System.Drawing.Size(121, 20)
        Me.MaterialTextBox.TabIndex = 345
        Me.MaterialTextBox.Visible = False
        '
        'EspesorTextBox
        '
        Me.EspesorTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.EspesorTextBox.Location = New System.Drawing.Point(713, 98)
        Me.EspesorTextBox.Name = "EspesorTextBox"
        Me.EspesorTextBox.Size = New System.Drawing.Size(39, 20)
        Me.EspesorTextBox.TabIndex = 346
        Me.EspesorTextBox.Visible = False
        '
        'EspRepTXT
        '
        Me.EspRepTXT.BackColor = System.Drawing.SystemColors.Control
        Me.EspRepTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Espesor1", True))
        Me.EspRepTXT.Location = New System.Drawing.Point(417, 303)
        Me.EspRepTXT.Name = "EspRepTXT"
        Me.EspRepTXT.Size = New System.Drawing.Size(39, 20)
        Me.EspRepTXT.TabIndex = 361
        Me.EspRepTXT.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(830, 527)
        Me.TabControl1.TabIndex = 363
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Nombre_quien_cotizaComboBox)
        Me.TabPage1.Controls.Add(Me.CalibreCBX)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(822, 501)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Correciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Nombre_quien_cotizaComboBox
        '
        Me.Nombre_quien_cotizaComboBox.BackColor = System.Drawing.SystemColors.Control
        Me.Nombre_quien_cotizaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Cotizador", True))
        Me.Nombre_quien_cotizaComboBox.Enabled = False
        Me.Nombre_quien_cotizaComboBox.Location = New System.Drawing.Point(143, 45)
        Me.Nombre_quien_cotizaComboBox.Name = "Nombre_quien_cotizaComboBox"
        Me.Nombre_quien_cotizaComboBox.Size = New System.Drawing.Size(121, 20)
        Me.Nombre_quien_cotizaComboBox.TabIndex = 359
        Me.Nombre_quien_cotizaComboBox.Visible = False
        '
        'Notificacion
        '
        Me.Notificacion.Icon = CType(resources.GetObject("Notificacion.Icon"), System.Drawing.Icon)
        Me.Notificacion.Text = "FTM Registros"
        Me.Notificacion.Visible = True
        '
        'Corregir_costos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(854, 541)
        Me.Controls.Add(Label8)
        Me.Controls.Add(Me.EspRepTXT)
        Me.Controls.Add(Costo_MP__MNX_KG_Label)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Label27)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Label23)
        Me.Controls.Add(Me.inRBT)
        Me.Controls.Add(Me.calRBT)
        Me.Controls.Add(Me.mmRBT)
        Me.Controls.Add(Label10)
        Me.Controls.Add(Me.Esp2TXT)
        Me.Controls.Add(Me.Esp1TXT)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.CERO2)
        Me.Controls.Add(Me.CERO)
        Me.Controls.Add(Me.Millon)
        Me.Controls.Add(Me.Prueba)
        Me.Controls.Add(Y1Label1)
        Me.Controls.Add(Me.Y1TextBox1)
        Me.Controls.Add(X1Label1)
        Me.Controls.Add(Me.X1TextBox1)
        Me.Controls.Add(MaterialLabel)
        Me.Controls.Add(Me.MaterialTextBox)
        Me.Controls.Add(Me.EspesorTextBox)
        Me.Controls.Add(Me.Guardarbtn)
        Me.Controls.Add(Me.Buscarbtn)
        Me.Controls.Add(DescripciónLabel)
        Me.Controls.Add(Me.Descripciontxt)
        Me.Controls.Add(DibujoLabel)
        Me.Controls.Add(Me.Dibujotxt)
        Me.Controls.Add(Me.Maquina)
        Me.Controls.Add(Me.Solda)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.TropicalizadoCheckBox)
        Me.Controls.Add(Me.GalvanizadoCheckBox)
        Me.Controls.Add(Me.PinturaCheckBox)
        Me.Controls.Add(Me.SoldaduraCheckBox)
        Me.Controls.Add(Me.PunzonadoCheckBox)
        Me.Controls.Add(Me.MaquinadoCheckBox)
        Me.Controls.Add(Me.SierraCheckBox)
        Me.Controls.Add(Me.WJCheckBox)
        Me.Controls.Add(Me.LaserCheckBox)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Precio_MP__MXN_pza_Label)
        Me.Controls.Add(Me.PrecioMPTextBox)
        Me.Controls.Add(Precio_doblez__MXN_Pza_Label)
        Me.Controls.Add(Me.PrecioDoblezTextBox)
        Me.Controls.Add(PinturaLabel)
        Me.Controls.Add(Me.PinturaTextBox)
        Me.Controls.Add(GalvanizadoLabel)
        Me.Controls.Add(Me.GalvanizadoTextBox)
        Me.Controls.Add(TropicalizadoLabel)
        Me.Controls.Add(Me.TropicalizadoTextBox)
        Me.Controls.Add(Precio_corte__MXN_Pza_Label)
        Me.Controls.Add(Me.PrecioCorteTextBox)
        Me.Controls.Add(Precio_final__MXN_pza_Label)
        Me.Controls.Add(Me.PrecioFinalTextBox)
        Me.Controls.Add(Precio_Total__MXN_Label)
        Me.Controls.Add(Me.PrecioTotalTextBox)
        Me.Controls.Add(__de_orden_a_cotizarLabel1)
        Me.Controls.Add(Me.ordenComboBox1)
        Me.Controls.Add(ClienteLabel1)
        Me.Controls.Add(Me.ClienteTextBox1)
        Me.Controls.Add(Clave_FTMLabel)
        Me.Controls.Add(Me.Clave_FTMComboBox)
        Me.Controls.Add(P1Label)
        Me.Controls.Add(Me.P1TextBox)
        Me.Controls.Add(P2Label)
        Me.Controls.Add(Me.P2TextBox)
        Me.Controls.Add(X1Label)
        Me.Controls.Add(Me.X1TextBox)
        Me.Controls.Add(Y1Label)
        Me.Controls.Add(Me.Y1TextBox)
        Me.Controls.Add(Valor_materialLabel)
        Me.Controls.Add(Me.ValorMaterial)
        Me.Controls.Add(Peso_Bruto__kg_pza_Label)
        Me.Controls.Add(Me.PesoBruto)
        Me.Controls.Add(FactorLabel)
        Me.Controls.Add(Me.FactorComboBox)
        Me.Controls.Add(Me.CostoMP)
        Me.Controls.Add(DoblezLabel)
        Me.Controls.Add(Me.DoblezTextBox)
        Me.Controls.Add(Costo_por_doblezLabel)
        Me.Controls.Add(Me.CostoDoblez)
        Me.Controls.Add(Costo_pinturaLabel)
        Me.Controls.Add(Me.CostoPintura)
        Me.Controls.Add(SoldaduraLabel)
        Me.Controls.Add(Me.SoldaduraTextBox)
        Me.Controls.Add(MaquinadoLabel)
        Me.Controls.Add(Me.MaquinadoTextBox)
        Me.Controls.Add(Costo_galvanizadoLabel)
        Me.Controls.Add(Me.CostoGalvanizado)
        Me.Controls.Add(Costo_TropicalizadoLabel)
        Me.Controls.Add(Me.CostoTropicalizado)
        Me.Controls.Add(Tiempo_de_corteLabel)
        Me.Controls.Add(Me.TiempoCorte)
        Me.Controls.Add(Costo_por_hr_corte__MXN_Label)
        Me.Controls.Add(Me.CostoHR)
        Me.Controls.Add(CantidadesLabel)
        Me.Controls.Add(Me.CantidadesTextBox)
        Me.Controls.Add(U_mLabel)
        Me.Controls.Add(Me.U_mTextBox)
        Me.Controls.Add(Nombre_quien_cotizaLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Corregir_costos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corregir_costos"
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscandoOrdenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscaOrden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteCotizar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Descripciontxt As TextBox
    Friend WithEvents Dibujotxt As TextBox
    Friend WithEvents Maquina As TextBox
    Friend WithEvents Solda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TropicalizadoCheckBox As CheckBox
    Friend WithEvents GalvanizadoCheckBox As CheckBox
    Friend WithEvents PinturaCheckBox As CheckBox
    Friend WithEvents SoldaduraCheckBox As CheckBox
    Friend WithEvents PunzonadoCheckBox As CheckBox
    Friend WithEvents MaquinadoCheckBox As CheckBox
    Friend WithEvents SierraCheckBox As CheckBox
    Friend WithEvents WJCheckBox As CheckBox
    Friend WithEvents LaserCheckBox As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PrecioMPTextBox As TextBox
    Friend WithEvents PrecioDoblezTextBox As TextBox
    Friend WithEvents PinturaTextBox As TextBox
    Friend WithEvents GalvanizadoTextBox As TextBox
    Friend WithEvents TropicalizadoTextBox As TextBox
    Friend WithEvents PrecioCorteTextBox As TextBox
    Friend WithEvents PrecioFinalTextBox As TextBox
    Friend WithEvents PrecioTotalTextBox As TextBox
    Friend WithEvents ordenComboBox1 As ComboBox
    Friend WithEvents ClienteTextBox1 As TextBox
    Friend WithEvents Clave_FTMComboBox As ComboBox
    Friend WithEvents P1TextBox As TextBox
    Friend WithEvents P2TextBox As TextBox
    Friend WithEvents X1TextBox As TextBox
    Friend WithEvents Y1TextBox As TextBox
    Friend WithEvents ValorMaterial As TextBox
    Friend WithEvents PesoBruto As TextBox
    Friend WithEvents FactorComboBox As ComboBox
    Friend WithEvents CostoMP As TextBox
    Friend WithEvents DoblezTextBox As TextBox
    Friend WithEvents CostoDoblez As TextBox
    Friend WithEvents CostoPintura As TextBox
    Friend WithEvents SoldaduraTextBox As TextBox
    Friend WithEvents MaquinadoTextBox As TextBox
    Friend WithEvents CostoGalvanizado As TextBox
    Friend WithEvents CostoTropicalizado As TextBox
    Friend WithEvents TiempoCorte As TextBox
    Friend WithEvents CostoHR As TextBox
    Friend WithEvents CantidadesTextBox As TextBox
    Friend WithEvents U_mTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BuscaOrden As BuscaOrden
    Friend WithEvents BuscandoOrdenBindingSource As BindingSource
    Friend WithEvents BuscandoOrdenTableAdapter As BuscaOrdenTableAdapters.BuscandoOrdenTableAdapter
    Friend WithEvents TableAdapterManager As BuscaOrdenTableAdapters.TableAdapterManager
    Friend WithEvents ReporteCotizar2 As ReporteCotizar2
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As ReporteCotizar2TableAdapters.VentaTableAdapter
    Friend WithEvents Buscarbtn As Button
    Friend WithEvents Guardarbtn As Button
    Friend WithEvents _Cotizaciones_1_4DataSet As _Cotizaciones_1_4DataSet
    Friend WithEvents CostosBindingSource As BindingSource
    Friend WithEvents CostosTableAdapter As _Cotizaciones_1_4DataSetTableAdapters.CostosTableAdapter
    Friend WithEvents TableAdapterManager1 As _Cotizaciones_1_4DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label28 As Label
    Friend WithEvents CalibreCBX As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents inRBT As RadioButton
    Friend WithEvents calRBT As RadioButton
    Friend WithEvents mmRBT As RadioButton
    Friend WithEvents Esp2TXT As TextBox
    Friend WithEvents Esp1TXT As TextBox
    Friend WithEvents CERO2 As TextBox
    Friend WithEvents CERO As TextBox
    Friend WithEvents Millon As TextBox
    Friend WithEvents Prueba As TextBox
    Friend WithEvents Y1TextBox1 As TextBox
    Friend WithEvents X1TextBox1 As TextBox
    Friend WithEvents MaterialTextBox As TextBox
    Friend WithEvents EspesorTextBox As TextBox
    Friend WithEvents EspRepTXT As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Nombre_quien_cotizaComboBox As TextBox
    Friend WithEvents Notificacion As NotifyIcon
End Class
