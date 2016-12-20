<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_Cot
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
        Dim ClienteLabel1 As System.Windows.Forms.Label
        Dim __de_orden_a_cotizarLabel As System.Windows.Forms.Label
        Dim Nombre_de_contactoLabel1 As System.Windows.Forms.Label
        Dim Correo_electrónicoLabel1 As System.Windows.Forms.Label
        Dim Fecha_de_solicitudLabel As System.Windows.Forms.Label
        Dim MesLabel As System.Windows.Forms.Label
        Dim Forma_de_pagoLabel As System.Windows.Forms.Label
        Dim Tipo_de_empaqueLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Fecha_requeridaLabel As System.Windows.Forms.Label
        Dim MonedaLabel As System.Windows.Forms.Label
        Dim AcabadoLabel As System.Windows.Forms.Label
        Dim IncotemsLabel As System.Windows.Forms.Label
        Dim Suministro_del_materialLabel As System.Windows.Forms.Label
        Dim Espesor_1Label As System.Windows.Forms.Label
        Dim Material_2Label As System.Windows.Forms.Label
        Dim Espesor_2Label As System.Windows.Forms.Label
        Dim Material_1Label As System.Windows.Forms.Label
        Dim Material_3Label As System.Windows.Forms.Label
        Dim Espesor_3Label As System.Windows.Forms.Label
        Dim Campo1Label As System.Windows.Forms.Label
        Dim Corte_LáserLabel As System.Windows.Forms.Label
        Dim DoblezLabel As System.Windows.Forms.Label
        Dim MaquinadoLabel As System.Windows.Forms.Label
        Dim Corte_WJLabel As System.Windows.Forms.Label
        Dim Corte_SierraLabel As System.Windows.Forms.Label
        Dim RoladoLabel As System.Windows.Forms.Label
        Dim SoldarLabel As System.Windows.Forms.Label
        Dim Item_soldadoLabel As System.Windows.Forms.Label
        Dim Otro_procesoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Cot))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.no_ordenTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.ContactoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Correotxt = New System.Windows.Forms.TextBox()
        Me.MesTextBox = New System.Windows.Forms.TextBox()
        Me.Forma_pagoTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_empaqueTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.AcabadoTextBox = New System.Windows.Forms.TextBox()
        Me.IncotemsTextBox = New System.Windows.Forms.TextBox()
        Me.Espesor_1TextBox = New System.Windows.Forms.TextBox()
        Me.Material_2TextBox = New System.Windows.Forms.TextBox()
        Me.Espesor_2TextBox = New System.Windows.Forms.TextBox()
        Me.Material_1TextBox = New System.Windows.Forms.TextBox()
        Me.Material_3TextBox = New System.Windows.Forms.TextBox()
        Me.Espesor_3TextBox = New System.Windows.Forms.TextBox()
        Me.Campo1TextBox = New System.Windows.Forms.TextBox()
        Me.Otro_procesoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_solicitudDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_requeridaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.MonedaComboBox = New System.Windows.Forms.ComboBox()
        Me.Suministro_del_materialCheckBox = New System.Windows.Forms.CheckBox()
        Me.Corte_LáserCheckBox = New System.Windows.Forms.CheckBox()
        Me.DoblezCheckBox = New System.Windows.Forms.CheckBox()
        Me.MaquinadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Corte_WJCheckBox = New System.Windows.Forms.CheckBox()
        Me.Corte_SierraCheckBox = New System.Windows.Forms.CheckBox()
        Me.RoladoCheckBox = New System.Windows.Forms.CheckBox()
        Me.SoldarCheckBox = New System.Windows.Forms.CheckBox()
        Me.Item_soldadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter()
        ClienteLabel1 = New System.Windows.Forms.Label()
        __de_orden_a_cotizarLabel = New System.Windows.Forms.Label()
        Nombre_de_contactoLabel1 = New System.Windows.Forms.Label()
        Correo_electrónicoLabel1 = New System.Windows.Forms.Label()
        Fecha_de_solicitudLabel = New System.Windows.Forms.Label()
        MesLabel = New System.Windows.Forms.Label()
        Forma_de_pagoLabel = New System.Windows.Forms.Label()
        Tipo_de_empaqueLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Fecha_requeridaLabel = New System.Windows.Forms.Label()
        MonedaLabel = New System.Windows.Forms.Label()
        AcabadoLabel = New System.Windows.Forms.Label()
        IncotemsLabel = New System.Windows.Forms.Label()
        Suministro_del_materialLabel = New System.Windows.Forms.Label()
        Espesor_1Label = New System.Windows.Forms.Label()
        Material_2Label = New System.Windows.Forms.Label()
        Espesor_2Label = New System.Windows.Forms.Label()
        Material_1Label = New System.Windows.Forms.Label()
        Material_3Label = New System.Windows.Forms.Label()
        Espesor_3Label = New System.Windows.Forms.Label()
        Campo1Label = New System.Windows.Forms.Label()
        Corte_LáserLabel = New System.Windows.Forms.Label()
        DoblezLabel = New System.Windows.Forms.Label()
        MaquinadoLabel = New System.Windows.Forms.Label()
        Corte_WJLabel = New System.Windows.Forms.Label()
        Corte_SierraLabel = New System.Windows.Forms.Label()
        RoladoLabel = New System.Windows.Forms.Label()
        SoldarLabel = New System.Windows.Forms.Label()
        Item_soldadoLabel = New System.Windows.Forms.Label()
        Otro_procesoLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClienteLabel1
        '
        ClienteLabel1.AutoSize = True
        ClienteLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClienteLabel1.Location = New System.Drawing.Point(9, 46)
        ClienteLabel1.Name = "ClienteLabel1"
        ClienteLabel1.Size = New System.Drawing.Size(49, 14)
        ClienteLabel1.TabIndex = 76
        ClienteLabel1.Text = "Cliente:"
        '
        '__de_orden_a_cotizarLabel
        '
        __de_orden_a_cotizarLabel.AutoSize = True
        __de_orden_a_cotizarLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        __de_orden_a_cotizarLabel.Location = New System.Drawing.Point(9, 134)
        __de_orden_a_cotizarLabel.Name = "__de_orden_a_cotizarLabel"
        __de_orden_a_cotizarLabel.Size = New System.Drawing.Size(116, 14)
        __de_orden_a_cotizarLabel.TabIndex = 78
        __de_orden_a_cotizarLabel.Text = "# de orden a cotizar:"
        '
        'Nombre_de_contactoLabel1
        '
        Nombre_de_contactoLabel1.AutoSize = True
        Nombre_de_contactoLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_de_contactoLabel1.Location = New System.Drawing.Point(9, 76)
        Nombre_de_contactoLabel1.Name = "Nombre_de_contactoLabel1"
        Nombre_de_contactoLabel1.Size = New System.Drawing.Size(57, 14)
        Nombre_de_contactoLabel1.TabIndex = 79
        Nombre_de_contactoLabel1.Text = "Contacto:"
        '
        'Correo_electrónicoLabel1
        '
        Correo_electrónicoLabel1.AutoSize = True
        Correo_electrónicoLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Correo_electrónicoLabel1.Location = New System.Drawing.Point(9, 106)
        Correo_electrónicoLabel1.Name = "Correo_electrónicoLabel1"
        Correo_electrónicoLabel1.Size = New System.Drawing.Size(109, 14)
        Correo_electrónicoLabel1.TabIndex = 81
        Correo_electrónicoLabel1.Text = "Correo electrónico:"
        '
        'Fecha_de_solicitudLabel
        '
        Fecha_de_solicitudLabel.AutoSize = True
        Fecha_de_solicitudLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_de_solicitudLabel.Location = New System.Drawing.Point(9, 190)
        Fecha_de_solicitudLabel.Name = "Fecha_de_solicitudLabel"
        Fecha_de_solicitudLabel.Size = New System.Drawing.Size(110, 14)
        Fecha_de_solicitudLabel.TabIndex = 83
        Fecha_de_solicitudLabel.Text = "Fecha de solicitud:"
        '
        'MesLabel
        '
        MesLabel.AutoSize = True
        MesLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MesLabel.Location = New System.Drawing.Point(384, 435)
        MesLabel.Name = "MesLabel"
        MesLabel.Size = New System.Drawing.Size(33, 14)
        MesLabel.TabIndex = 85
        MesLabel.Text = "Mes:"
        MesLabel.Visible = False
        '
        'Forma_de_pagoLabel
        '
        Forma_de_pagoLabel.AutoSize = True
        Forma_de_pagoLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Forma_de_pagoLabel.Location = New System.Drawing.Point(9, 246)
        Forma_de_pagoLabel.Name = "Forma_de_pagoLabel"
        Forma_de_pagoLabel.Size = New System.Drawing.Size(91, 14)
        Forma_de_pagoLabel.TabIndex = 87
        Forma_de_pagoLabel.Text = "Forma de pago:"
        '
        'Tipo_de_empaqueLabel
        '
        Tipo_de_empaqueLabel.AutoSize = True
        Tipo_de_empaqueLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Tipo_de_empaqueLabel.Location = New System.Drawing.Point(384, 240)
        Tipo_de_empaqueLabel.Name = "Tipo_de_empaqueLabel"
        Tipo_de_empaqueLabel.Size = New System.Drawing.Size(106, 14)
        Tipo_de_empaqueLabel.TabIndex = 89
        Tipo_de_empaqueLabel.Text = "Tipo de empaque:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObservacionesLabel.Location = New System.Drawing.Point(384, 306)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(90, 14)
        ObservacionesLabel.TabIndex = 91
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Fecha_requeridaLabel
        '
        Fecha_requeridaLabel.AutoSize = True
        Fecha_requeridaLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_requeridaLabel.Location = New System.Drawing.Point(9, 162)
        Fecha_requeridaLabel.Name = "Fecha_requeridaLabel"
        Fecha_requeridaLabel.Size = New System.Drawing.Size(99, 14)
        Fecha_requeridaLabel.TabIndex = 93
        Fecha_requeridaLabel.Text = "Fecha requerida:"
        '
        'MonedaLabel
        '
        MonedaLabel.AutoSize = True
        MonedaLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MonedaLabel.Location = New System.Drawing.Point(9, 217)
        MonedaLabel.Name = "MonedaLabel"
        MonedaLabel.Size = New System.Drawing.Size(55, 14)
        MonedaLabel.TabIndex = 95
        MonedaLabel.Text = "Moneda:"
        '
        'AcabadoLabel
        '
        AcabadoLabel.AutoSize = True
        AcabadoLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcabadoLabel.Location = New System.Drawing.Point(384, 156)
        AcabadoLabel.Name = "AcabadoLabel"
        AcabadoLabel.Size = New System.Drawing.Size(57, 14)
        AcabadoLabel.TabIndex = 97
        AcabadoLabel.Text = "Acabado:"
        '
        'IncotemsLabel
        '
        IncotemsLabel.AutoSize = True
        IncotemsLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IncotemsLabel.Location = New System.Drawing.Point(384, 184)
        IncotemsLabel.Name = "IncotemsLabel"
        IncotemsLabel.Size = New System.Drawing.Size(64, 14)
        IncotemsLabel.TabIndex = 99
        IncotemsLabel.Text = "Incoterms:"
        '
        'Suministro_del_materialLabel
        '
        Suministro_del_materialLabel.AutoSize = True
        Suministro_del_materialLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Suministro_del_materialLabel.Location = New System.Drawing.Point(384, 46)
        Suministro_del_materialLabel.Name = "Suministro_del_materialLabel"
        Suministro_del_materialLabel.Size = New System.Drawing.Size(140, 14)
        Suministro_del_materialLabel.TabIndex = 101
        Suministro_del_materialLabel.Text = "Suministro del material:"
        '
        'Espesor_1Label
        '
        Espesor_1Label.AutoSize = True
        Espesor_1Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Espesor_1Label.Location = New System.Drawing.Point(571, 74)
        Espesor_1Label.Name = "Espesor_1Label"
        Espesor_1Label.Size = New System.Drawing.Size(53, 14)
        Espesor_1Label.TabIndex = 103
        Espesor_1Label.Text = "Espesor:"
        '
        'Material_2Label
        '
        Material_2Label.AutoSize = True
        Material_2Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Material_2Label.Location = New System.Drawing.Point(384, 101)
        Material_2Label.Name = "Material_2Label"
        Material_2Label.Size = New System.Drawing.Size(57, 14)
        Material_2Label.TabIndex = 105
        Material_2Label.Text = "Material:"
        '
        'Espesor_2Label
        '
        Espesor_2Label.AutoSize = True
        Espesor_2Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Espesor_2Label.Location = New System.Drawing.Point(571, 101)
        Espesor_2Label.Name = "Espesor_2Label"
        Espesor_2Label.Size = New System.Drawing.Size(53, 14)
        Espesor_2Label.TabIndex = 107
        Espesor_2Label.Text = "Espesor:"
        '
        'Material_1Label
        '
        Material_1Label.AutoSize = True
        Material_1Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Material_1Label.Location = New System.Drawing.Point(384, 74)
        Material_1Label.Name = "Material_1Label"
        Material_1Label.Size = New System.Drawing.Size(57, 14)
        Material_1Label.TabIndex = 109
        Material_1Label.Text = "Material:"
        '
        'Material_3Label
        '
        Material_3Label.AutoSize = True
        Material_3Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Material_3Label.Location = New System.Drawing.Point(384, 127)
        Material_3Label.Name = "Material_3Label"
        Material_3Label.Size = New System.Drawing.Size(57, 14)
        Material_3Label.TabIndex = 111
        Material_3Label.Text = "Material:"
        '
        'Espesor_3Label
        '
        Espesor_3Label.AutoSize = True
        Espesor_3Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Espesor_3Label.Location = New System.Drawing.Point(571, 127)
        Espesor_3Label.Name = "Espesor_3Label"
        Espesor_3Label.Size = New System.Drawing.Size(53, 14)
        Espesor_3Label.TabIndex = 113
        Espesor_3Label.Text = "Espesor:"
        '
        'Campo1Label
        '
        Campo1Label.AutoSize = True
        Campo1Label.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Campo1Label.Location = New System.Drawing.Point(145, 217)
        Campo1Label.Name = "Campo1Label"
        Campo1Label.Size = New System.Drawing.Size(94, 14)
        Campo1Label.TabIndex = 115
        Campo1Label.Text = "Insertar planos:"
        '
        'Corte_LáserLabel
        '
        Corte_LáserLabel.AutoSize = True
        Corte_LáserLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Corte_LáserLabel.Location = New System.Drawing.Point(8, 327)
        Corte_LáserLabel.Name = "Corte_LáserLabel"
        Corte_LáserLabel.Size = New System.Drawing.Size(70, 14)
        Corte_LáserLabel.TabIndex = 117
        Corte_LáserLabel.Text = "Corte Láser:"
        '
        'DoblezLabel
        '
        DoblezLabel.AutoSize = True
        DoblezLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DoblezLabel.Location = New System.Drawing.Point(8, 406)
        DoblezLabel.Name = "DoblezLabel"
        DoblezLabel.Size = New System.Drawing.Size(48, 14)
        DoblezLabel.TabIndex = 119
        DoblezLabel.Text = "Doblez:"
        '
        'MaquinadoLabel
        '
        MaquinadoLabel.AutoSize = True
        MaquinadoLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MaquinadoLabel.Location = New System.Drawing.Point(9, 429)
        MaquinadoLabel.Name = "MaquinadoLabel"
        MaquinadoLabel.Size = New System.Drawing.Size(73, 14)
        MaquinadoLabel.TabIndex = 121
        MaquinadoLabel.Text = "Maquinado:"
        '
        'Corte_WJLabel
        '
        Corte_WJLabel.AutoSize = True
        Corte_WJLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Corte_WJLabel.Location = New System.Drawing.Point(8, 354)
        Corte_WJLabel.Name = "Corte_WJLabel"
        Corte_WJLabel.Size = New System.Drawing.Size(55, 14)
        Corte_WJLabel.TabIndex = 123
        Corte_WJLabel.Text = "Corte WJ:"
        '
        'Corte_SierraLabel
        '
        Corte_SierraLabel.AutoSize = True
        Corte_SierraLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Corte_SierraLabel.Location = New System.Drawing.Point(9, 380)
        Corte_SierraLabel.Name = "Corte_SierraLabel"
        Corte_SierraLabel.Size = New System.Drawing.Size(73, 14)
        Corte_SierraLabel.TabIndex = 125
        Corte_SierraLabel.Text = "Corte Sierra:"
        '
        'RoladoLabel
        '
        RoladoLabel.AutoSize = True
        RoladoLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RoladoLabel.Location = New System.Drawing.Point(172, 327)
        RoladoLabel.Name = "RoladoLabel"
        RoladoLabel.Size = New System.Drawing.Size(49, 14)
        RoladoLabel.TabIndex = 127
        RoladoLabel.Text = "Rolado:"
        '
        'SoldarLabel
        '
        SoldarLabel.AutoSize = True
        SoldarLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SoldarLabel.Location = New System.Drawing.Point(172, 354)
        SoldarLabel.Name = "SoldarLabel"
        SoldarLabel.Size = New System.Drawing.Size(45, 14)
        SoldarLabel.TabIndex = 129
        SoldarLabel.Text = "Soldar:"
        '
        'Item_soldadoLabel
        '
        Item_soldadoLabel.AutoSize = True
        Item_soldadoLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_soldadoLabel.Location = New System.Drawing.Point(172, 380)
        Item_soldadoLabel.Name = "Item_soldadoLabel"
        Item_soldadoLabel.Size = New System.Drawing.Size(83, 14)
        Item_soldadoLabel.TabIndex = 131
        Item_soldadoLabel.Text = "Item soldado:"
        '
        'Otro_procesoLabel
        '
        Otro_procesoLabel.AutoSize = True
        Otro_procesoLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Otro_procesoLabel.Location = New System.Drawing.Point(172, 406)
        Otro_procesoLabel.Name = "Otro_procesoLabel"
        Otro_procesoLabel.Size = New System.Drawing.Size(79, 14)
        Otro_procesoLabel.TabIndex = 133
        Otro_procesoLabel.Text = "Otro proceso:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 516)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Guardar)
        Me.TabPage1.Controls.Add(Me.no_ordenTextBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(ClienteLabel1)
        Me.TabPage1.Controls.Add(Me.ClienteComboBox)
        Me.TabPage1.Controls.Add(__de_orden_a_cotizarLabel)
        Me.TabPage1.Controls.Add(Nombre_de_contactoLabel1)
        Me.TabPage1.Controls.Add(Me.ContactoTextBox1)
        Me.TabPage1.Controls.Add(Me.Correotxt)
        Me.TabPage1.Controls.Add(Me.MesTextBox)
        Me.TabPage1.Controls.Add(Me.Forma_pagoTextBox)
        Me.TabPage1.Controls.Add(Me.Tipo_de_empaqueTextBox)
        Me.TabPage1.Controls.Add(Me.ObservacionesTextBox)
        Me.TabPage1.Controls.Add(Me.AcabadoTextBox)
        Me.TabPage1.Controls.Add(Me.IncotemsTextBox)
        Me.TabPage1.Controls.Add(Me.Espesor_1TextBox)
        Me.TabPage1.Controls.Add(Me.Material_2TextBox)
        Me.TabPage1.Controls.Add(Me.Espesor_2TextBox)
        Me.TabPage1.Controls.Add(Me.Material_1TextBox)
        Me.TabPage1.Controls.Add(Me.Material_3TextBox)
        Me.TabPage1.Controls.Add(Me.Espesor_3TextBox)
        Me.TabPage1.Controls.Add(Me.Campo1TextBox)
        Me.TabPage1.Controls.Add(Me.Otro_procesoTextBox)
        Me.TabPage1.Controls.Add(Correo_electrónicoLabel1)
        Me.TabPage1.Controls.Add(Fecha_de_solicitudLabel)
        Me.TabPage1.Controls.Add(Me.Fecha_solicitudDateTimePicker)
        Me.TabPage1.Controls.Add(MesLabel)
        Me.TabPage1.Controls.Add(Forma_de_pagoLabel)
        Me.TabPage1.Controls.Add(Tipo_de_empaqueLabel)
        Me.TabPage1.Controls.Add(ObservacionesLabel)
        Me.TabPage1.Controls.Add(Fecha_requeridaLabel)
        Me.TabPage1.Controls.Add(Me.Fecha_requeridaDateTimePicker)
        Me.TabPage1.Controls.Add(MonedaLabel)
        Me.TabPage1.Controls.Add(Me.MonedaComboBox)
        Me.TabPage1.Controls.Add(AcabadoLabel)
        Me.TabPage1.Controls.Add(IncotemsLabel)
        Me.TabPage1.Controls.Add(Suministro_del_materialLabel)
        Me.TabPage1.Controls.Add(Me.Suministro_del_materialCheckBox)
        Me.TabPage1.Controls.Add(Espesor_1Label)
        Me.TabPage1.Controls.Add(Material_2Label)
        Me.TabPage1.Controls.Add(Espesor_2Label)
        Me.TabPage1.Controls.Add(Material_1Label)
        Me.TabPage1.Controls.Add(Material_3Label)
        Me.TabPage1.Controls.Add(Espesor_3Label)
        Me.TabPage1.Controls.Add(Campo1Label)
        Me.TabPage1.Controls.Add(Corte_LáserLabel)
        Me.TabPage1.Controls.Add(Me.Corte_LáserCheckBox)
        Me.TabPage1.Controls.Add(DoblezLabel)
        Me.TabPage1.Controls.Add(Me.DoblezCheckBox)
        Me.TabPage1.Controls.Add(MaquinadoLabel)
        Me.TabPage1.Controls.Add(Me.MaquinadoCheckBox)
        Me.TabPage1.Controls.Add(Corte_WJLabel)
        Me.TabPage1.Controls.Add(Me.Corte_WJCheckBox)
        Me.TabPage1.Controls.Add(Corte_SierraLabel)
        Me.TabPage1.Controls.Add(Me.Corte_SierraCheckBox)
        Me.TabPage1.Controls.Add(RoladoLabel)
        Me.TabPage1.Controls.Add(Me.RoladoCheckBox)
        Me.TabPage1.Controls.Add(SoldarLabel)
        Me.TabPage1.Controls.Add(Me.SoldarCheckBox)
        Me.TabPage1.Controls.Add(Item_soldadoLabel)
        Me.TabPage1.Controls.Add(Me.Item_soldadoCheckBox)
        Me.TabPage1.Controls.Add(Otro_procesoLabel)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(742, 490)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registro Cotizaciones"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Guardar
        '
        Me.Guardar.Location = New System.Drawing.Point(546, 404)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(75, 23)
        Me.Guardar.TabIndex = 140
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'no_ordenTextBox
        '
        Me.no_ordenTextBox.Location = New System.Drawing.Point(131, 131)
        Me.no_ordenTextBox.Name = "no_ordenTextBox"
        Me.no_ordenTextBox.Size = New System.Drawing.Size(190, 20)
        Me.no_ordenTextBox.TabIndex = 139
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(381, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 33)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Material"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(242, 33)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Procesos necesarios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 33)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Datos del cliente"
        '
        'ClienteComboBox
        '
        Me.ClienteComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ClienteComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClienteComboBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.ClienteComboBox.DataSource = Me.ClientesBindingSource
        Me.ClienteComboBox.DisplayMember = "Cliente"
        Me.ClienteComboBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClienteComboBox.FormattingEnabled = True
        Me.ClienteComboBox.Location = New System.Drawing.Point(69, 43)
        Me.ClienteComboBox.Name = "ClienteComboBox"
        Me.ClienteComboBox.Size = New System.Drawing.Size(131, 22)
        Me.ClienteComboBox.TabIndex = 77
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
        'ContactoTextBox1
        '
        Me.ContactoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre de contacto", True))
        Me.ContactoTextBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoTextBox1.Location = New System.Drawing.Point(71, 73)
        Me.ContactoTextBox1.Name = "ContactoTextBox1"
        Me.ContactoTextBox1.Size = New System.Drawing.Size(250, 22)
        Me.ContactoTextBox1.TabIndex = 80
        '
        'Correotxt
        '
        Me.Correotxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Correo electrónico", True))
        Me.Correotxt.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Correotxt.Location = New System.Drawing.Point(131, 103)
        Me.Correotxt.Name = "Correotxt"
        Me.Correotxt.Size = New System.Drawing.Size(190, 22)
        Me.Correotxt.TabIndex = 82
        '
        'MesTextBox
        '
        Me.MesTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesTextBox.Location = New System.Drawing.Point(424, 432)
        Me.MesTextBox.Name = "MesTextBox"
        Me.MesTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MesTextBox.TabIndex = 86
        Me.MesTextBox.Visible = False
        '
        'Forma_pagoTextBox
        '
        Me.Forma_pagoTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forma_pagoTextBox.Location = New System.Drawing.Point(107, 243)
        Me.Forma_pagoTextBox.Name = "Forma_pagoTextBox"
        Me.Forma_pagoTextBox.Size = New System.Drawing.Size(214, 22)
        Me.Forma_pagoTextBox.TabIndex = 88
        '
        'Tipo_de_empaqueTextBox
        '
        Me.Tipo_de_empaqueTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tipo_de_empaqueTextBox.Location = New System.Drawing.Point(491, 237)
        Me.Tipo_de_empaqueTextBox.Multiline = True
        Me.Tipo_de_empaqueTextBox.Name = "Tipo_de_empaqueTextBox"
        Me.Tipo_de_empaqueTextBox.Size = New System.Drawing.Size(233, 57)
        Me.Tipo_de_empaqueTextBox.TabIndex = 90
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(481, 303)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(244, 58)
        Me.ObservacionesTextBox.TabIndex = 92
        '
        'AcabadoTextBox
        '
        Me.AcabadoTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AcabadoTextBox.Location = New System.Drawing.Point(450, 152)
        Me.AcabadoTextBox.Name = "AcabadoTextBox"
        Me.AcabadoTextBox.Size = New System.Drawing.Size(275, 22)
        Me.AcabadoTextBox.TabIndex = 98
        '
        'IncotemsTextBox
        '
        Me.IncotemsTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncotemsTextBox.Location = New System.Drawing.Point(450, 181)
        Me.IncotemsTextBox.Multiline = True
        Me.IncotemsTextBox.Name = "IncotemsTextBox"
        Me.IncotemsTextBox.Size = New System.Drawing.Size(275, 47)
        Me.IncotemsTextBox.TabIndex = 100
        '
        'Espesor_1TextBox
        '
        Me.Espesor_1TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Espesor_1TextBox.Location = New System.Drawing.Point(628, 71)
        Me.Espesor_1TextBox.Name = "Espesor_1TextBox"
        Me.Espesor_1TextBox.Size = New System.Drawing.Size(96, 22)
        Me.Espesor_1TextBox.TabIndex = 104
        '
        'Material_2TextBox
        '
        Me.Material_2TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_2TextBox.Location = New System.Drawing.Point(443, 98)
        Me.Material_2TextBox.Name = "Material_2TextBox"
        Me.Material_2TextBox.Size = New System.Drawing.Size(118, 22)
        Me.Material_2TextBox.TabIndex = 106
        '
        'Espesor_2TextBox
        '
        Me.Espesor_2TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Espesor_2TextBox.Location = New System.Drawing.Point(628, 98)
        Me.Espesor_2TextBox.Name = "Espesor_2TextBox"
        Me.Espesor_2TextBox.Size = New System.Drawing.Size(96, 22)
        Me.Espesor_2TextBox.TabIndex = 108
        '
        'Material_1TextBox
        '
        Me.Material_1TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_1TextBox.Location = New System.Drawing.Point(443, 71)
        Me.Material_1TextBox.Name = "Material_1TextBox"
        Me.Material_1TextBox.Size = New System.Drawing.Size(118, 22)
        Me.Material_1TextBox.TabIndex = 110
        '
        'Material_3TextBox
        '
        Me.Material_3TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Material_3TextBox.Location = New System.Drawing.Point(443, 124)
        Me.Material_3TextBox.Name = "Material_3TextBox"
        Me.Material_3TextBox.Size = New System.Drawing.Size(118, 22)
        Me.Material_3TextBox.TabIndex = 112
        '
        'Espesor_3TextBox
        '
        Me.Espesor_3TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Espesor_3TextBox.Location = New System.Drawing.Point(628, 124)
        Me.Espesor_3TextBox.Name = "Espesor_3TextBox"
        Me.Espesor_3TextBox.Size = New System.Drawing.Size(96, 22)
        Me.Espesor_3TextBox.TabIndex = 114
        '
        'Campo1TextBox
        '
        Me.Campo1TextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Campo1TextBox.Location = New System.Drawing.Point(239, 214)
        Me.Campo1TextBox.Multiline = True
        Me.Campo1TextBox.Name = "Campo1TextBox"
        Me.Campo1TextBox.Size = New System.Drawing.Size(82, 20)
        Me.Campo1TextBox.TabIndex = 116
        '
        'Otro_procesoTextBox
        '
        Me.Otro_procesoTextBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Otro_procesoTextBox.Location = New System.Drawing.Point(175, 423)
        Me.Otro_procesoTextBox.Multiline = True
        Me.Otro_procesoTextBox.Name = "Otro_procesoTextBox"
        Me.Otro_procesoTextBox.Size = New System.Drawing.Size(146, 54)
        Me.Otro_procesoTextBox.TabIndex = 134
        '
        'Fecha_solicitudDateTimePicker
        '
        Me.Fecha_solicitudDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_solicitudDateTimePicker.Location = New System.Drawing.Point(131, 186)
        Me.Fecha_solicitudDateTimePicker.Name = "Fecha_solicitudDateTimePicker"
        Me.Fecha_solicitudDateTimePicker.Size = New System.Drawing.Size(190, 22)
        Me.Fecha_solicitudDateTimePicker.TabIndex = 84
        '
        'Fecha_requeridaDateTimePicker
        '
        Me.Fecha_requeridaDateTimePicker.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha_requeridaDateTimePicker.Location = New System.Drawing.Point(131, 158)
        Me.Fecha_requeridaDateTimePicker.Name = "Fecha_requeridaDateTimePicker"
        Me.Fecha_requeridaDateTimePicker.Size = New System.Drawing.Size(190, 22)
        Me.Fecha_requeridaDateTimePicker.TabIndex = 94
        '
        'MonedaComboBox
        '
        Me.MonedaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.MonedaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MonedaComboBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonedaComboBox.FormattingEnabled = True
        Me.MonedaComboBox.Items.AddRange(New Object() {"MXN", "USD", "EUR"})
        Me.MonedaComboBox.Location = New System.Drawing.Point(63, 214)
        Me.MonedaComboBox.Name = "MonedaComboBox"
        Me.MonedaComboBox.Size = New System.Drawing.Size(65, 22)
        Me.MonedaComboBox.TabIndex = 96
        '
        'Suministro_del_materialCheckBox
        '
        Me.Suministro_del_materialCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Suministro_del_materialCheckBox.Location = New System.Drawing.Point(527, 41)
        Me.Suministro_del_materialCheckBox.Name = "Suministro_del_materialCheckBox"
        Me.Suministro_del_materialCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Suministro_del_materialCheckBox.TabIndex = 102
        Me.Suministro_del_materialCheckBox.Text = "CheckBox1"
        Me.Suministro_del_materialCheckBox.UseVisualStyleBackColor = True
        '
        'Corte_LáserCheckBox
        '
        Me.Corte_LáserCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte_LáserCheckBox.Location = New System.Drawing.Point(87, 323)
        Me.Corte_LáserCheckBox.Name = "Corte_LáserCheckBox"
        Me.Corte_LáserCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Corte_LáserCheckBox.TabIndex = 118
        Me.Corte_LáserCheckBox.Text = "CheckBox1"
        Me.Corte_LáserCheckBox.UseVisualStyleBackColor = True
        '
        'DoblezCheckBox
        '
        Me.DoblezCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoblezCheckBox.Location = New System.Drawing.Point(87, 402)
        Me.DoblezCheckBox.Name = "DoblezCheckBox"
        Me.DoblezCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.DoblezCheckBox.TabIndex = 120
        Me.DoblezCheckBox.Text = "CheckBox1"
        Me.DoblezCheckBox.UseVisualStyleBackColor = True
        '
        'MaquinadoCheckBox
        '
        Me.MaquinadoCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaquinadoCheckBox.Location = New System.Drawing.Point(87, 425)
        Me.MaquinadoCheckBox.Name = "MaquinadoCheckBox"
        Me.MaquinadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.MaquinadoCheckBox.TabIndex = 122
        Me.MaquinadoCheckBox.Text = "CheckBox1"
        Me.MaquinadoCheckBox.UseVisualStyleBackColor = True
        '
        'Corte_WJCheckBox
        '
        Me.Corte_WJCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte_WJCheckBox.Location = New System.Drawing.Point(87, 350)
        Me.Corte_WJCheckBox.Name = "Corte_WJCheckBox"
        Me.Corte_WJCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Corte_WJCheckBox.TabIndex = 124
        Me.Corte_WJCheckBox.Text = "CheckBox1"
        Me.Corte_WJCheckBox.UseVisualStyleBackColor = True
        '
        'Corte_SierraCheckBox
        '
        Me.Corte_SierraCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Corte_SierraCheckBox.Location = New System.Drawing.Point(87, 377)
        Me.Corte_SierraCheckBox.Name = "Corte_SierraCheckBox"
        Me.Corte_SierraCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Corte_SierraCheckBox.TabIndex = 126
        Me.Corte_SierraCheckBox.Text = "CheckBox1"
        Me.Corte_SierraCheckBox.UseVisualStyleBackColor = True
        '
        'RoladoCheckBox
        '
        Me.RoladoCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RoladoCheckBox.Location = New System.Drawing.Point(257, 322)
        Me.RoladoCheckBox.Name = "RoladoCheckBox"
        Me.RoladoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.RoladoCheckBox.TabIndex = 128
        Me.RoladoCheckBox.Text = "CheckBox1"
        Me.RoladoCheckBox.UseVisualStyleBackColor = True
        '
        'SoldarCheckBox
        '
        Me.SoldarCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoldarCheckBox.Location = New System.Drawing.Point(257, 350)
        Me.SoldarCheckBox.Name = "SoldarCheckBox"
        Me.SoldarCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.SoldarCheckBox.TabIndex = 130
        Me.SoldarCheckBox.Text = "CheckBox1"
        Me.SoldarCheckBox.UseVisualStyleBackColor = True
        '
        'Item_soldadoCheckBox
        '
        Me.Item_soldadoCheckBox.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_soldadoCheckBox.Location = New System.Drawing.Point(257, 376)
        Me.Item_soldadoCheckBox.Name = "Item_soldadoCheckBox"
        Me.Item_soldadoCheckBox.Size = New System.Drawing.Size(15, 24)
        Me.Item_soldadoCheckBox.TabIndex = 132
        Me.Item_soldadoCheckBox.Text = "CheckBox1"
        Me.Item_soldadoCheckBox.UseVisualStyleBackColor = True
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
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "Ventas"
        Me.VentasBindingSource1.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Registro_Cot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(777, 534)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Cot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Ordenes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents no_ordenTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ClienteComboBox As ComboBox
    Friend WithEvents ContactoTextBox1 As TextBox
    Friend WithEvents Correotxt As TextBox
    Friend WithEvents MesTextBox As TextBox
    Friend WithEvents Forma_pagoTextBox As TextBox
    Friend WithEvents Tipo_de_empaqueTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents AcabadoTextBox As TextBox
    Friend WithEvents IncotemsTextBox As TextBox
    Friend WithEvents Espesor_1TextBox As TextBox
    Friend WithEvents Material_2TextBox As TextBox
    Friend WithEvents Espesor_2TextBox As TextBox
    Friend WithEvents Material_1TextBox As TextBox
    Friend WithEvents Material_3TextBox As TextBox
    Friend WithEvents Espesor_3TextBox As TextBox
    Friend WithEvents Campo1TextBox As TextBox
    Friend WithEvents Otro_procesoTextBox As TextBox
    Friend WithEvents Fecha_solicitudDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_requeridaDateTimePicker As DateTimePicker
    Friend WithEvents MonedaComboBox As ComboBox
    Friend WithEvents Suministro_del_materialCheckBox As CheckBox
    Friend WithEvents Corte_LáserCheckBox As CheckBox
    Friend WithEvents DoblezCheckBox As CheckBox
    Friend WithEvents MaquinadoCheckBox As CheckBox
    Friend WithEvents Corte_WJCheckBox As CheckBox
    Friend WithEvents Corte_SierraCheckBox As CheckBox
    Friend WithEvents RoladoCheckBox As CheckBox
    Friend WithEvents SoldarCheckBox As CheckBox
    Friend WithEvents Item_soldadoCheckBox As CheckBox
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Guardar As Button
    Friend WithEvents VentasBindingSource1 As BindingSource
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter
End Class
