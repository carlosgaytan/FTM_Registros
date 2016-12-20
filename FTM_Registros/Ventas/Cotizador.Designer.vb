<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cotizador
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
        Dim MaterialLabel As System.Windows.Forms.Label
        Dim EspesorLabel As System.Windows.Forms.Label
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
        Dim Y1Label1 As System.Windows.Forms.Label
        Dim X1Label1 As System.Windows.Forms.Label
        Me.CostosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Cotizaciones_1_4DataSet = New FTM_Registros._Cotizaciones_1_4DataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Ventas_1_5DataSet = New FTM_Registros._Ventas_1_5DataSet()
        Me.Ventas15DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.VentasTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CostosTableAdapter = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.CostosTableAdapter()
        Me.Descripciontxt = New System.Windows.Forms.TextBox()
        Me.Dibujotxt = New System.Windows.Forms.TextBox()
        Me.Maquina = New System.Windows.Forms.TextBox()
        Me.Solda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DoblezCbx = New System.Windows.Forms.CheckBox()
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
        Me.MaterialTextBox = New System.Windows.Forms.TextBox()
        Me.EspesorTextBox = New System.Windows.Forms.TextBox()
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
        Me.Nombre_quien_cotizaComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Y1TextBox1 = New System.Windows.Forms.TextBox()
        Me.X1TextBox1 = New System.Windows.Forms.TextBox()
        Me.CostosControlplanosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Control_planosTableAdapter = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.Control_planosTableAdapter()
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
        MaterialLabel = New System.Windows.Forms.Label()
        EspesorLabel = New System.Windows.Forms.Label()
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
        Y1Label1 = New System.Windows.Forms.Label()
        X1Label1 = New System.Windows.Forms.Label()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Ventas_1_5DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ventas15DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostosControlplanosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DescripciónLabel
        '
        DescripciónLabel.AutoSize = True
        DescripciónLabel.Location = New System.Drawing.Point(12, 162)
        DescripciónLabel.Name = "DescripciónLabel"
        DescripciónLabel.Size = New System.Drawing.Size(66, 13)
        DescripciónLabel.TabIndex = 221
        DescripciónLabel.Text = "Descripción:"
        '
        'DibujoLabel
        '
        DibujoLabel.AutoSize = True
        DibujoLabel.Location = New System.Drawing.Point(12, 134)
        DibujoLabel.Name = "DibujoLabel"
        DibujoLabel.Size = New System.Drawing.Size(40, 13)
        DibujoLabel.TabIndex = 219
        DibujoLabel.Text = "Dibujo:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(16, 384)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(58, 13)
        Label5.TabIndex = 162
        Label5.Text = "Soldadura:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(16, 411)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(63, 13)
        Label6.TabIndex = 157
        Label6.Text = "Maquinado:"
        '
        'Precio_MP__MXN_pza_Label
        '
        Precio_MP__MXN_pza_Label.AutoSize = True
        Precio_MP__MXN_pza_Label.Location = New System.Drawing.Point(588, 116)
        Precio_MP__MXN_pza_Label.Name = "Precio_MP__MXN_pza_Label"
        Precio_MP__MXN_pza_Label.Size = New System.Drawing.Size(114, 13)
        Precio_MP__MXN_pza_Label.TabIndex = 124
        Precio_MP__MXN_pza_Label.Text = "Precio MP (MXN/pza):"
        '
        'Precio_doblez__MXN_Pza_Label
        '
        Precio_doblez__MXN_Pza_Label.AutoSize = True
        Precio_doblez__MXN_Pza_Label.Location = New System.Drawing.Point(588, 142)
        Precio_doblez__MXN_Pza_Label.Name = "Precio_doblez__MXN_Pza_Label"
        Precio_doblez__MXN_Pza_Label.Size = New System.Drawing.Size(130, 13)
        Precio_doblez__MXN_Pza_Label.TabIndex = 125
        Precio_doblez__MXN_Pza_Label.Text = "Precio doblez (MXN/Pza):"
        '
        'PinturaLabel
        '
        PinturaLabel.AutoSize = True
        PinturaLabel.Location = New System.Drawing.Point(588, 223)
        PinturaLabel.Name = "PinturaLabel"
        PinturaLabel.Size = New System.Drawing.Size(43, 13)
        PinturaLabel.TabIndex = 126
        PinturaLabel.Text = "Pintura:"
        '
        'GalvanizadoLabel
        '
        GalvanizadoLabel.AutoSize = True
        GalvanizadoLabel.Location = New System.Drawing.Point(588, 249)
        GalvanizadoLabel.Name = "GalvanizadoLabel"
        GalvanizadoLabel.Size = New System.Drawing.Size(69, 13)
        GalvanizadoLabel.TabIndex = 127
        GalvanizadoLabel.Text = "Galvanizado:"
        '
        'TropicalizadoLabel
        '
        TropicalizadoLabel.AutoSize = True
        TropicalizadoLabel.Location = New System.Drawing.Point(588, 275)
        TropicalizadoLabel.Name = "TropicalizadoLabel"
        TropicalizadoLabel.Size = New System.Drawing.Size(73, 13)
        TropicalizadoLabel.TabIndex = 128
        TropicalizadoLabel.Text = "Tropicalizado:"
        '
        'Precio_corte__MXN_Pza_Label
        '
        Precio_corte__MXN_Pza_Label.AutoSize = True
        Precio_corte__MXN_Pza_Label.Location = New System.Drawing.Point(588, 301)
        Precio_corte__MXN_Pza_Label.Name = "Precio_corte__MXN_Pza_Label"
        Precio_corte__MXN_Pza_Label.Size = New System.Drawing.Size(123, 13)
        Precio_corte__MXN_Pza_Label.TabIndex = 129
        Precio_corte__MXN_Pza_Label.Text = "Precio corte (MXN/Pza):"
        '
        'Precio_final__MXN_pza_Label
        '
        Precio_final__MXN_pza_Label.AutoSize = True
        Precio_final__MXN_pza_Label.Location = New System.Drawing.Point(588, 327)
        Precio_final__MXN_pza_Label.Name = "Precio_final__MXN_pza_Label"
        Precio_final__MXN_pza_Label.Size = New System.Drawing.Size(117, 13)
        Precio_final__MXN_pza_Label.TabIndex = 130
        Precio_final__MXN_pza_Label.Text = "Precio final (MXN/pza):"
        '
        'Precio_Total__MXN_Label
        '
        Precio_Total__MXN_Label.AutoSize = True
        Precio_Total__MXN_Label.Location = New System.Drawing.Point(588, 353)
        Precio_Total__MXN_Label.Name = "Precio_Total__MXN_Label"
        Precio_Total__MXN_Label.Size = New System.Drawing.Size(100, 13)
        Precio_Total__MXN_Label.TabIndex = 131
        Precio_Total__MXN_Label.Text = "Precio Total (MXN):"
        '
        '__de_orden_a_cotizarLabel1
        '
        __de_orden_a_cotizarLabel1.AutoSize = True
        __de_orden_a_cotizarLabel1.Location = New System.Drawing.Point(12, 50)
        __de_orden_a_cotizarLabel1.Name = "__de_orden_a_cotizarLabel1"
        __de_orden_a_cotizarLabel1.Size = New System.Drawing.Size(105, 13)
        __de_orden_a_cotizarLabel1.TabIndex = 132
        __de_orden_a_cotizarLabel1.Text = "# de orden a cotizar:"
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Location = New System.Drawing.Point(12, 78)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(42, 13)
        ClienteLabel1.TabIndex = 133
        ClienteLabel1.Text = "Cliente:"
        '
        'Clave_FTMLabel
        '
        Clave_FTMLabel.AutoSize = True
        Clave_FTMLabel.Location = New System.Drawing.Point(12, 105)
        Clave_FTMLabel.Name = "Clave_FTMLabel"
        Clave_FTMLabel.Size = New System.Drawing.Size(62, 13)
        Clave_FTMLabel.TabIndex = 134
        Clave_FTMLabel.Text = "Clave FTM:"
        '
        'P1Label
        '
        P1Label.AutoSize = True
        P1Label.Location = New System.Drawing.Point(160, 195)
        P1Label.Name = "P1Label"
        P1Label.Size = New System.Drawing.Size(23, 13)
        P1Label.TabIndex = 135
        P1Label.Text = "P1:"
        '
        'P2Label
        '
        P2Label.AutoSize = True
        P2Label.Location = New System.Drawing.Point(160, 221)
        P2Label.Name = "P2Label"
        P2Label.Size = New System.Drawing.Size(23, 13)
        P2Label.TabIndex = 136
        P2Label.Text = "P2:"
        '
        'X1Label
        '
        X1Label.AutoSize = True
        X1Label.Location = New System.Drawing.Point(38, 195)
        X1Label.Name = "X1Label"
        X1Label.Size = New System.Drawing.Size(17, 13)
        X1Label.TabIndex = 137
        X1Label.Text = "X:"
        '
        'Y1Label
        '
        Y1Label.AutoSize = True
        Y1Label.Location = New System.Drawing.Point(38, 221)
        Y1Label.Name = "Y1Label"
        Y1Label.Size = New System.Drawing.Size(17, 13)
        Y1Label.TabIndex = 138
        Y1Label.Text = "Y:"
        '
        'Valor_materialLabel
        '
        Valor_materialLabel.AutoSize = True
        Valor_materialLabel.Location = New System.Drawing.Point(309, 78)
        Valor_materialLabel.Name = "Valor_materialLabel"
        Valor_materialLabel.Size = New System.Drawing.Size(87, 13)
        Valor_materialLabel.TabIndex = 139
        Valor_materialLabel.Text = "Peso específico:"
        '
        'Peso_Bruto__kg_pza_Label
        '
        Peso_Bruto__kg_pza_Label.AutoSize = True
        Peso_Bruto__kg_pza_Label.Location = New System.Drawing.Point(48, 254)
        Peso_Bruto__kg_pza_Label.Name = "Peso_Bruto__kg_pza_Label"
        Peso_Bruto__kg_pza_Label.Size = New System.Drawing.Size(107, 13)
        Peso_Bruto__kg_pza_Label.TabIndex = 140
        Peso_Bruto__kg_pza_Label.Text = "Peso/Bruto (kg/pza):"
        '
        'FactorLabel
        '
        FactorLabel.AutoSize = True
        FactorLabel.Location = New System.Drawing.Point(309, 105)
        FactorLabel.Name = "FactorLabel"
        FactorLabel.Size = New System.Drawing.Size(40, 13)
        FactorLabel.TabIndex = 141
        FactorLabel.Text = "Factor:"
        '
        'Costo_MP__MNX_KG_Label
        '
        Costo_MP__MNX_KG_Label.AutoSize = True
        Costo_MP__MNX_KG_Label.Location = New System.Drawing.Point(12, 306)
        Costo_MP__MNX_KG_Label.Name = "Costo_MP__MNX_KG_Label"
        Costo_MP__MNX_KG_Label.Size = New System.Drawing.Size(109, 13)
        Costo_MP__MNX_KG_Label.TabIndex = 142
        Costo_MP__MNX_KG_Label.Text = "Costo MP (MNX/KG):"
        '
        'MaterialLabel
        '
        MaterialLabel.AutoSize = True
        MaterialLabel.Location = New System.Drawing.Point(309, 22)
        MaterialLabel.Name = "MaterialLabel"
        MaterialLabel.Size = New System.Drawing.Size(47, 13)
        MaterialLabel.TabIndex = 143
        MaterialLabel.Text = "Material:"
        '
        'EspesorLabel
        '
        EspesorLabel.AutoSize = True
        EspesorLabel.Location = New System.Drawing.Point(309, 50)
        EspesorLabel.Name = "EspesorLabel"
        EspesorLabel.Size = New System.Drawing.Size(48, 13)
        EspesorLabel.TabIndex = 144
        EspesorLabel.Text = "Espesor:"
        '
        'DoblezLabel
        '
        DoblezLabel.AutoSize = True
        DoblezLabel.Location = New System.Drawing.Point(12, 332)
        DoblezLabel.Name = "DoblezLabel"
        DoblezLabel.Size = New System.Drawing.Size(43, 13)
        DoblezLabel.TabIndex = 145
        DoblezLabel.Text = "Doblez:"
        '
        'Costo_por_doblezLabel
        '
        Costo_por_doblezLabel.AutoSize = True
        Costo_por_doblezLabel.Location = New System.Drawing.Point(12, 358)
        Costo_por_doblezLabel.Name = "Costo_por_doblezLabel"
        Costo_por_doblezLabel.Size = New System.Drawing.Size(89, 13)
        Costo_por_doblezLabel.TabIndex = 146
        Costo_por_doblezLabel.Text = "Costo por doblez:"
        '
        'Costo_pinturaLabel
        '
        Costo_pinturaLabel.AutoSize = True
        Costo_pinturaLabel.Location = New System.Drawing.Point(252, 306)
        Costo_pinturaLabel.Name = "Costo_pinturaLabel"
        Costo_pinturaLabel.Size = New System.Drawing.Size(72, 13)
        Costo_pinturaLabel.TabIndex = 147
        Costo_pinturaLabel.Text = "Costo pintura:"
        '
        'SoldaduraLabel
        '
        SoldaduraLabel.AutoSize = True
        SoldaduraLabel.Location = New System.Drawing.Point(588, 168)
        SoldaduraLabel.Name = "SoldaduraLabel"
        SoldaduraLabel.Size = New System.Drawing.Size(58, 13)
        SoldaduraLabel.TabIndex = 148
        SoldaduraLabel.Text = "Soldadura:"
        '
        'MaquinadoLabel
        '
        MaquinadoLabel.AutoSize = True
        MaquinadoLabel.Location = New System.Drawing.Point(588, 195)
        MaquinadoLabel.Name = "MaquinadoLabel"
        MaquinadoLabel.Size = New System.Drawing.Size(63, 13)
        MaquinadoLabel.TabIndex = 151
        MaquinadoLabel.Text = "Maquinado:"
        '
        'Costo_galvanizadoLabel
        '
        Costo_galvanizadoLabel.AutoSize = True
        Costo_galvanizadoLabel.Location = New System.Drawing.Point(252, 332)
        Costo_galvanizadoLabel.Name = "Costo_galvanizadoLabel"
        Costo_galvanizadoLabel.Size = New System.Drawing.Size(97, 13)
        Costo_galvanizadoLabel.TabIndex = 156
        Costo_galvanizadoLabel.Text = "Costo galvanizado:"
        '
        'Costo_TropicalizadoLabel
        '
        Costo_TropicalizadoLabel.AutoSize = True
        Costo_TropicalizadoLabel.Location = New System.Drawing.Point(252, 358)
        Costo_TropicalizadoLabel.Name = "Costo_TropicalizadoLabel"
        Costo_TropicalizadoLabel.Size = New System.Drawing.Size(103, 13)
        Costo_TropicalizadoLabel.TabIndex = 154
        Costo_TropicalizadoLabel.Text = "Costo Tropicalizado:"
        '
        'Tiempo_de_corteLabel
        '
        Tiempo_de_corteLabel.AutoSize = True
        Tiempo_de_corteLabel.Location = New System.Drawing.Point(252, 384)
        Tiempo_de_corteLabel.Name = "Tiempo_de_corteLabel"
        Tiempo_de_corteLabel.Size = New System.Drawing.Size(87, 13)
        Tiempo_de_corteLabel.TabIndex = 153
        Tiempo_de_corteLabel.Text = "Tiempo de corte:"
        '
        'Costo_por_hr_corte__MXN_Label
        '
        Costo_por_hr_corte__MXN_Label.AutoSize = True
        Costo_por_hr_corte__MXN_Label.Location = New System.Drawing.Point(252, 410)
        Costo_por_hr_corte__MXN_Label.Name = "Costo_por_hr_corte__MXN_Label"
        Costo_por_hr_corte__MXN_Label.Size = New System.Drawing.Size(127, 13)
        Costo_por_hr_corte__MXN_Label.TabIndex = 159
        Costo_por_hr_corte__MXN_Label.Text = "Costo por hr corte (MXN):"
        '
        'CantidadesLabel
        '
        CantidadesLabel.AutoSize = True
        CantidadesLabel.Location = New System.Drawing.Point(306, 162)
        CantidadesLabel.Name = "CantidadesLabel"
        CantidadesLabel.Size = New System.Drawing.Size(63, 13)
        CantidadesLabel.TabIndex = 155
        CantidadesLabel.Text = "Cantidades:"
        '
        'U_mLabel
        '
        U_mLabel.AutoSize = True
        U_mLabel.Location = New System.Drawing.Point(306, 135)
        U_mLabel.Name = "U_mLabel"
        U_mLabel.Size = New System.Drawing.Size(29, 13)
        U_mLabel.TabIndex = 171
        U_mLabel.Text = "u/m:"
        '
        'Nombre_quien_cotizaLabel
        '
        Nombre_quien_cotizaLabel.AutoSize = True
        Nombre_quien_cotizaLabel.Location = New System.Drawing.Point(12, 22)
        Nombre_quien_cotizaLabel.Name = "Nombre_quien_cotizaLabel"
        Nombre_quien_cotizaLabel.Size = New System.Drawing.Size(107, 13)
        Nombre_quien_cotizaLabel.TabIndex = 169
        Nombre_quien_cotizaLabel.Text = "Nombre quien cotiza:"
        '
        'Y1Label1
        '
        Y1Label1.AutoSize = True
        Y1Label1.Location = New System.Drawing.Point(708, 46)
        Y1Label1.Name = "Y1Label1"
        Y1Label1.Size = New System.Drawing.Size(23, 13)
        Y1Label1.TabIndex = 223
        Y1Label1.Text = "Y1:"
        Y1Label1.Visible = False
        '
        'X1Label1
        '
        X1Label1.AutoSize = True
        X1Label1.Location = New System.Drawing.Point(708, 22)
        X1Label1.Name = "X1Label1"
        X1Label1.Size = New System.Drawing.Size(23, 13)
        X1Label1.TabIndex = 225
        X1Label1.Text = "X1:"
        X1Label1.Visible = False
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
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me._Cotizaciones_1_4DataSet
        '
        '_Ventas_1_5DataSet
        '
        Me._Ventas_1_5DataSet.DataSetName = "_Ventas_1_5DataSet"
        Me._Ventas_1_5DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ventas15DataSetBindingSource
        '
        Me.Ventas15DataSetBindingSource.DataSource = Me._Ventas_1_5DataSet
        Me.Ventas15DataSetBindingSource.Position = 0
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(556, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CostosTableAdapter
        '
        Me.CostosTableAdapter.ClearBeforeFill = True
        '
        'Descripciontxt
        '
        Me.Descripciontxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Descripción", True))
        Me.Descripciontxt.Location = New System.Drawing.Point(148, 159)
        Me.Descripciontxt.Name = "Descripciontxt"
        Me.Descripciontxt.Size = New System.Drawing.Size(121, 20)
        Me.Descripciontxt.TabIndex = 222
        '
        'Dibujotxt
        '
        Me.Dibujotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Dibujo", True))
        Me.Dibujotxt.Location = New System.Drawing.Point(148, 131)
        Me.Dibujotxt.Name = "Dibujotxt"
        Me.Dibujotxt.Size = New System.Drawing.Size(121, 20)
        Me.Dibujotxt.TabIndex = 220
        '
        'Maquina
        '
        Me.Maquina.Location = New System.Drawing.Point(134, 408)
        Me.Maquina.Name = "Maquina"
        Me.Maquina.Size = New System.Drawing.Size(76, 20)
        Me.Maquina.TabIndex = 192
        '
        'Solda
        '
        Me.Solda.Location = New System.Drawing.Point(134, 381)
        Me.Solda.Name = "Solda"
        Me.Solda.Size = New System.Drawing.Size(76, 20)
        Me.Solda.TabIndex = 191
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 384)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 411)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "$"
        '
        'DoblezCbx
        '
        Me.DoblezCbx.AutoSize = True
        Me.DoblezCbx.Location = New System.Drawing.Point(216, 332)
        Me.DoblezCbx.Name = "DoblezCbx"
        Me.DoblezCbx.Size = New System.Drawing.Size(15, 14)
        Me.DoblezCbx.TabIndex = 209
        Me.DoblezCbx.UseVisualStyleBackColor = True
        '
        'TropicalizadoCheckBox
        '
        Me.TropicalizadoCheckBox.Location = New System.Drawing.Point(469, 353)
        Me.TropicalizadoCheckBox.Name = "TropicalizadoCheckBox"
        Me.TropicalizadoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.TropicalizadoCheckBox.TabIndex = 214
        Me.TropicalizadoCheckBox.Text = "CheckBox1"
        Me.TropicalizadoCheckBox.UseVisualStyleBackColor = True
        '
        'GalvanizadoCheckBox
        '
        Me.GalvanizadoCheckBox.Location = New System.Drawing.Point(469, 327)
        Me.GalvanizadoCheckBox.Name = "GalvanizadoCheckBox"
        Me.GalvanizadoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.GalvanizadoCheckBox.TabIndex = 213
        Me.GalvanizadoCheckBox.Text = "CheckBox1"
        Me.GalvanizadoCheckBox.UseVisualStyleBackColor = True
        '
        'PinturaCheckBox
        '
        Me.PinturaCheckBox.Location = New System.Drawing.Point(469, 301)
        Me.PinturaCheckBox.Name = "PinturaCheckBox"
        Me.PinturaCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.PinturaCheckBox.TabIndex = 212
        Me.PinturaCheckBox.Text = "CheckBox1"
        Me.PinturaCheckBox.UseVisualStyleBackColor = True
        '
        'SoldaduraCheckBox
        '
        Me.SoldaduraCheckBox.Location = New System.Drawing.Point(216, 379)
        Me.SoldaduraCheckBox.Name = "SoldaduraCheckBox"
        Me.SoldaduraCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.SoldaduraCheckBox.TabIndex = 210
        Me.SoldaduraCheckBox.Text = "CheckBox1"
        Me.SoldaduraCheckBox.UseVisualStyleBackColor = True
        '
        'PunzonadoCheckBox
        '
        Me.PunzonadoCheckBox.Location = New System.Drawing.Point(469, 439)
        Me.PunzonadoCheckBox.Name = "PunzonadoCheckBox"
        Me.PunzonadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.PunzonadoCheckBox.TabIndex = 218
        Me.PunzonadoCheckBox.Text = "Punzonado"
        Me.PunzonadoCheckBox.UseVisualStyleBackColor = True
        '
        'MaquinadoCheckBox
        '
        Me.MaquinadoCheckBox.Location = New System.Drawing.Point(216, 405)
        Me.MaquinadoCheckBox.Name = "MaquinadoCheckBox"
        Me.MaquinadoCheckBox.Size = New System.Drawing.Size(13, 24)
        Me.MaquinadoCheckBox.TabIndex = 211
        Me.MaquinadoCheckBox.Text = "CheckBox1"
        Me.MaquinadoCheckBox.UseVisualStyleBackColor = True
        '
        'SierraCheckBox
        '
        Me.SierraCheckBox.Location = New System.Drawing.Point(469, 419)
        Me.SierraCheckBox.Name = "SierraCheckBox"
        Me.SierraCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.SierraCheckBox.TabIndex = 217
        Me.SierraCheckBox.Text = "Sierra"
        Me.SierraCheckBox.UseVisualStyleBackColor = True
        '
        'WJCheckBox
        '
        Me.WJCheckBox.Location = New System.Drawing.Point(469, 399)
        Me.WJCheckBox.Name = "WJCheckBox"
        Me.WJCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.WJCheckBox.TabIndex = 216
        Me.WJCheckBox.Text = "WJ"
        Me.WJCheckBox.UseVisualStyleBackColor = True
        '
        'LaserCheckBox
        '
        Me.LaserCheckBox.Location = New System.Drawing.Point(469, 379)
        Me.LaserCheckBox.Name = "LaserCheckBox"
        Me.LaserCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.LaserCheckBox.TabIndex = 215
        Me.LaserCheckBox.Text = "Láser"
        Me.LaserCheckBox.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(380, 332)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(13, 13)
        Me.Label25.TabIndex = 158
        Me.Label25.Text = "$"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(380, 358)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 13)
        Me.Label24.TabIndex = 160
        Me.Label24.Text = "$"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(718, 168)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 13)
        Me.Label22.TabIndex = 166
        Me.Label22.Text = "$"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(120, 358)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(13, 13)
        Me.Label21.TabIndex = 172
        Me.Label21.Text = "$"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(120, 306)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 170
        Me.Label19.Text = "$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(718, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 173
        Me.Label18.Text = "$"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(718, 142)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 167
        Me.Label17.Text = "$"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(718, 223)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 165
        Me.Label16.Text = "$"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(718, 247)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(13, 13)
        Me.Label15.TabIndex = 164
        Me.Label15.Text = "$"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(718, 275)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(718, 301)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 168
        Me.Label13.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(718, 327)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 150
        Me.Label12.Text = "$"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(718, 353)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 149
        Me.Label11.Text = "$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(718, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "$"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "$"
        '
        'PrecioMPTextBox
        '
        Me.PrecioMPTextBox.Location = New System.Drawing.Point(731, 113)
        Me.PrecioMPTextBox.Name = "PrecioMPTextBox"
        Me.PrecioMPTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioMPTextBox.TabIndex = 198
        Me.PrecioMPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioDoblezTextBox
        '
        Me.PrecioDoblezTextBox.Location = New System.Drawing.Point(731, 139)
        Me.PrecioDoblezTextBox.Name = "PrecioDoblezTextBox"
        Me.PrecioDoblezTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioDoblezTextBox.TabIndex = 199
        Me.PrecioDoblezTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PinturaTextBox
        '
        Me.PinturaTextBox.Location = New System.Drawing.Point(731, 220)
        Me.PinturaTextBox.Name = "PinturaTextBox"
        Me.PinturaTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PinturaTextBox.TabIndex = 202
        Me.PinturaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GalvanizadoTextBox
        '
        Me.GalvanizadoTextBox.Location = New System.Drawing.Point(731, 246)
        Me.GalvanizadoTextBox.Name = "GalvanizadoTextBox"
        Me.GalvanizadoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.GalvanizadoTextBox.TabIndex = 203
        Me.GalvanizadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TropicalizadoTextBox
        '
        Me.TropicalizadoTextBox.Location = New System.Drawing.Point(731, 272)
        Me.TropicalizadoTextBox.Name = "TropicalizadoTextBox"
        Me.TropicalizadoTextBox.Size = New System.Drawing.Size(97, 20)
        Me.TropicalizadoTextBox.TabIndex = 204
        Me.TropicalizadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioCorteTextBox
        '
        Me.PrecioCorteTextBox.Location = New System.Drawing.Point(731, 298)
        Me.PrecioCorteTextBox.Name = "PrecioCorteTextBox"
        Me.PrecioCorteTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioCorteTextBox.TabIndex = 205
        Me.PrecioCorteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioFinalTextBox
        '
        Me.PrecioFinalTextBox.Location = New System.Drawing.Point(731, 324)
        Me.PrecioFinalTextBox.Name = "PrecioFinalTextBox"
        Me.PrecioFinalTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioFinalTextBox.TabIndex = 206
        Me.PrecioFinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PrecioTotalTextBox
        '
        Me.PrecioTotalTextBox.Location = New System.Drawing.Point(731, 350)
        Me.PrecioTotalTextBox.Name = "PrecioTotalTextBox"
        Me.PrecioTotalTextBox.Size = New System.Drawing.Size(97, 20)
        Me.PrecioTotalTextBox.TabIndex = 207
        Me.PrecioTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ordenComboBox1
        '
        Me.ordenComboBox1.DataSource = Me.CostosBindingSource
        Me.ordenComboBox1.DisplayMember = "no_orden"
        Me.ordenComboBox1.FormattingEnabled = True
        Me.ordenComboBox1.Location = New System.Drawing.Point(148, 47)
        Me.ordenComboBox1.Name = "ordenComboBox1"
        Me.ordenComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ordenComboBox1.TabIndex = 175
        Me.ordenComboBox1.ValueMember = "no_orden"
        '
        'ClienteTextBox1
        '
        Me.ClienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Cliente", True))
        Me.ClienteTextBox1.Location = New System.Drawing.Point(148, 75)
        Me.ClienteTextBox1.Name = "ClienteTextBox1"
        Me.ClienteTextBox1.Size = New System.Drawing.Size(121, 20)
        Me.ClienteTextBox1.TabIndex = 176
        '
        'Clave_FTMComboBox
        '
        Me.Clave_FTMComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CostosBindingSource, "Clave_FTM", True))
        Me.Clave_FTMComboBox.DataSource = Me.CostosBindingSource
        Me.Clave_FTMComboBox.DisplayMember = "Clave_FTM"
        Me.Clave_FTMComboBox.FormattingEnabled = True
        Me.Clave_FTMComboBox.Location = New System.Drawing.Point(148, 102)
        Me.Clave_FTMComboBox.Name = "Clave_FTMComboBox"
        Me.Clave_FTMComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Clave_FTMComboBox.TabIndex = 177
        '
        'P1TextBox
        '
        Me.P1TextBox.Location = New System.Drawing.Point(184, 192)
        Me.P1TextBox.Name = "P1TextBox"
        Me.P1TextBox.Size = New System.Drawing.Size(53, 20)
        Me.P1TextBox.TabIndex = 180
        '
        'P2TextBox
        '
        Me.P2TextBox.Location = New System.Drawing.Point(184, 218)
        Me.P2TextBox.Name = "P2TextBox"
        Me.P2TextBox.Size = New System.Drawing.Size(53, 20)
        Me.P2TextBox.TabIndex = 181
        '
        'X1TextBox
        '
        Me.X1TextBox.Location = New System.Drawing.Point(62, 192)
        Me.X1TextBox.Name = "X1TextBox"
        Me.X1TextBox.Size = New System.Drawing.Size(53, 20)
        Me.X1TextBox.TabIndex = 178
        '
        'Y1TextBox
        '
        Me.Y1TextBox.Location = New System.Drawing.Point(62, 218)
        Me.Y1TextBox.Name = "Y1TextBox"
        Me.Y1TextBox.Size = New System.Drawing.Size(53, 20)
        Me.Y1TextBox.TabIndex = 179
        '
        'ValorMaterial
        '
        Me.ValorMaterial.Location = New System.Drawing.Point(399, 75)
        Me.ValorMaterial.Name = "ValorMaterial"
        Me.ValorMaterial.Size = New System.Drawing.Size(121, 20)
        Me.ValorMaterial.TabIndex = 184
        '
        'PesoBruto
        '
        Me.PesoBruto.Location = New System.Drawing.Point(161, 251)
        Me.PesoBruto.Name = "PesoBruto"
        Me.PesoBruto.Size = New System.Drawing.Size(67, 20)
        Me.PesoBruto.TabIndex = 208
        '
        'FactorComboBox
        '
        Me.FactorComboBox.FormattingEnabled = True
        Me.FactorComboBox.Items.AddRange(New Object() {"1.55", "1.5", "1.45", "1.4", "1.35", "1.3", "1.25", "1.2", "1.15", "1.1", "1"})
        Me.FactorComboBox.Location = New System.Drawing.Point(399, 102)
        Me.FactorComboBox.Name = "FactorComboBox"
        Me.FactorComboBox.Size = New System.Drawing.Size(63, 21)
        Me.FactorComboBox.TabIndex = 185
        Me.FactorComboBox.Text = "1.55"
        '
        'CostoMP
        '
        Me.CostoMP.Location = New System.Drawing.Point(134, 303)
        Me.CostoMP.Name = "CostoMP"
        Me.CostoMP.Size = New System.Drawing.Size(76, 20)
        Me.CostoMP.TabIndex = 188
        '
        'MaterialTextBox
        '
        Me.MaterialTextBox.Location = New System.Drawing.Point(399, 19)
        Me.MaterialTextBox.Name = "MaterialTextBox"
        Me.MaterialTextBox.Size = New System.Drawing.Size(121, 20)
        Me.MaterialTextBox.TabIndex = 182
        '
        'EspesorTextBox
        '
        Me.EspesorTextBox.Location = New System.Drawing.Point(399, 47)
        Me.EspesorTextBox.Name = "EspesorTextBox"
        Me.EspesorTextBox.Size = New System.Drawing.Size(121, 20)
        Me.EspesorTextBox.TabIndex = 183
        '
        'DoblezTextBox
        '
        Me.DoblezTextBox.Location = New System.Drawing.Point(134, 329)
        Me.DoblezTextBox.Name = "DoblezTextBox"
        Me.DoblezTextBox.Size = New System.Drawing.Size(76, 20)
        Me.DoblezTextBox.TabIndex = 189
        '
        'CostoDoblez
        '
        Me.CostoDoblez.Location = New System.Drawing.Point(134, 355)
        Me.CostoDoblez.Name = "CostoDoblez"
        Me.CostoDoblez.Size = New System.Drawing.Size(76, 20)
        Me.CostoDoblez.TabIndex = 190
        '
        'CostoPintura
        '
        Me.CostoPintura.Location = New System.Drawing.Point(394, 303)
        Me.CostoPintura.Name = "CostoPintura"
        Me.CostoPintura.Size = New System.Drawing.Size(69, 20)
        Me.CostoPintura.TabIndex = 193
        '
        'SoldaduraTextBox
        '
        Me.SoldaduraTextBox.Location = New System.Drawing.Point(732, 165)
        Me.SoldaduraTextBox.Name = "SoldaduraTextBox"
        Me.SoldaduraTextBox.Size = New System.Drawing.Size(96, 20)
        Me.SoldaduraTextBox.TabIndex = 200
        Me.SoldaduraTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaquinadoTextBox
        '
        Me.MaquinadoTextBox.Location = New System.Drawing.Point(732, 192)
        Me.MaquinadoTextBox.Name = "MaquinadoTextBox"
        Me.MaquinadoTextBox.Size = New System.Drawing.Size(96, 20)
        Me.MaquinadoTextBox.TabIndex = 201
        Me.MaquinadoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CostoGalvanizado
        '
        Me.CostoGalvanizado.Location = New System.Drawing.Point(394, 329)
        Me.CostoGalvanizado.Name = "CostoGalvanizado"
        Me.CostoGalvanizado.Size = New System.Drawing.Size(69, 20)
        Me.CostoGalvanizado.TabIndex = 194
        '
        'CostoTropicalizado
        '
        Me.CostoTropicalizado.Location = New System.Drawing.Point(394, 355)
        Me.CostoTropicalizado.Name = "CostoTropicalizado"
        Me.CostoTropicalizado.Size = New System.Drawing.Size(69, 20)
        Me.CostoTropicalizado.TabIndex = 195
        '
        'TiempoCorte
        '
        Me.TiempoCorte.Location = New System.Drawing.Point(394, 381)
        Me.TiempoCorte.Name = "TiempoCorte"
        Me.TiempoCorte.Size = New System.Drawing.Size(69, 20)
        Me.TiempoCorte.TabIndex = 196
        '
        'CostoHR
        '
        Me.CostoHR.Location = New System.Drawing.Point(394, 407)
        Me.CostoHR.Name = "CostoHR"
        Me.CostoHR.Size = New System.Drawing.Size(69, 20)
        Me.CostoHR.TabIndex = 197
        '
        'CantidadesTextBox
        '
        Me.CantidadesTextBox.Location = New System.Drawing.Point(396, 159)
        Me.CantidadesTextBox.Name = "CantidadesTextBox"
        Me.CantidadesTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CantidadesTextBox.TabIndex = 187
        '
        'U_mTextBox
        '
        Me.U_mTextBox.Location = New System.Drawing.Point(396, 132)
        Me.U_mTextBox.Name = "U_mTextBox"
        Me.U_mTextBox.Size = New System.Drawing.Size(121, 20)
        Me.U_mTextBox.TabIndex = 186
        Me.U_mTextBox.Text = "PZA"
        '
        'Nombre_quien_cotizaComboBox
        '
        Me.Nombre_quien_cotizaComboBox.FormattingEnabled = True
        Me.Nombre_quien_cotizaComboBox.Location = New System.Drawing.Point(148, 19)
        Me.Nombre_quien_cotizaComboBox.Name = "Nombre_quien_cotizaComboBox"
        Me.Nombre_quien_cotizaComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Nombre_quien_cotizaComboBox.TabIndex = 174
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox1.Location = New System.Drawing.Point(579, 91)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(259, 299)
        Me.TextBox1.TabIndex = 121
        '
        'Y1TextBox1
        '
        Me.Y1TextBox1.Location = New System.Drawing.Point(737, 43)
        Me.Y1TextBox1.Name = "Y1TextBox1"
        Me.Y1TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.Y1TextBox1.TabIndex = 224
        Me.Y1TextBox1.Visible = False
        '
        'X1TextBox1
        '
        Me.X1TextBox1.Location = New System.Drawing.Point(737, 19)
        Me.X1TextBox1.Name = "X1TextBox1"
        Me.X1TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.X1TextBox1.TabIndex = 226
        Me.X1TextBox1.Visible = False
        '
        'CostosControlplanosBindingSource
        '
        Me.CostosControlplanosBindingSource.DataMember = "CostosControl_planos"
        Me.CostosControlplanosBindingSource.DataSource = Me.CostosBindingSource
        '
        'Control_planosTableAdapter
        '
        Me.Control_planosTableAdapter.ClearBeforeFill = True
        '
        'Cotizador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 483)
        Me.Controls.Add(Y1Label1)
        Me.Controls.Add(Me.Y1TextBox1)
        Me.Controls.Add(X1Label1)
        Me.Controls.Add(Me.X1TextBox1)
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
        Me.Controls.Add(Me.DoblezCbx)
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
        Me.Controls.Add(Costo_MP__MNX_KG_Label)
        Me.Controls.Add(Me.CostoMP)
        Me.Controls.Add(MaterialLabel)
        Me.Controls.Add(Me.MaterialTextBox)
        Me.Controls.Add(EspesorLabel)
        Me.Controls.Add(Me.EspesorTextBox)
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
        Me.Controls.Add(Me.Nombre_quien_cotizaComboBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Cotizador"
        Me.Text = "Cotizador"
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Ventas_1_5DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ventas15DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostosControlplanosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ventas15DataSetBindingSource As BindingSource
    Friend WithEvents _Ventas_1_5DataSet As _Ventas_1_5DataSet
    Friend WithEvents _Cotizaciones_1_4DataSet As _Cotizaciones_1_4DataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _Cotizaciones_1_4DataSetTableAdapters.VentasTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents CostosBindingSource As BindingSource
    Friend WithEvents CostosTableAdapter As _Cotizaciones_1_4DataSetTableAdapters.CostosTableAdapter
    Friend WithEvents Descripciontxt As TextBox
    Friend WithEvents Dibujotxt As TextBox
    Friend WithEvents Maquina As TextBox
    Friend WithEvents Solda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DoblezCbx As CheckBox
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
    Friend WithEvents MaterialTextBox As TextBox
    Friend WithEvents EspesorTextBox As TextBox
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
    Friend WithEvents Nombre_quien_cotizaComboBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Y1TextBox1 As TextBox
    Friend WithEvents X1TextBox1 As TextBox
    Friend WithEvents CostosControlplanosBindingSource As BindingSource
    Friend WithEvents Control_planosTableAdapter As _Cotizaciones_1_4DataSetTableAdapters.Control_planosTableAdapter
End Class
