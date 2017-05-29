<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reg_NoCot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reg_NoCot))
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.CotizacionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CotizacionesTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.CotizacionesTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.no_ordenCBX = New System.Windows.Forms.ComboBox()
        Me.VentasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._Cotizaciones_1_4DataSet = New FTM_Registros._Cotizaciones_1_4DataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ClienteTXT = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.no_cotizacionTXT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.T_FabTXT = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MesTXT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Proc_CotTXT = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RecotizaciónCHBX = New System.Windows.Forms.CheckBox()
        Me.FECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Otro_procTXT = New System.Windows.Forms.TextBox()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.CancelarBTN = New System.Windows.Forms.Button()
        Me.Basededatos14beDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CotizacionesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter()
        Me.CotizacionesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CotizacionesTableAdapter1 = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.CotizacionesTableAdapter()
        Me.VentasTableAdapter1 = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.VentasTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.PorcientoEMB = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NoordenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClaveFTMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.X1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Y1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValormaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PesoBrutoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FactorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioMPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspesorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DoblezDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostodoblezDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciodoblezDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostopinturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldaduraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaquinadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostogalvanizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GalvanizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostoTropicalizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TropicalizadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TiempocorteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostohrcorteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciocorteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciofinalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CotizadorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DibujoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspesorINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esp1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Esp2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspesorCalibreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MilímetrosDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PulgadaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CalibreDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Espesor1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EspcalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LlaveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SoldaduraCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaquinadoCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PinturaCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GalvanizadoCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TropicalizadoCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LaserCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.WJCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.SierraCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PunzonadoCHBXDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CostosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CostosTableAdapter = New FTM_Registros._Cotizaciones_1_4DataSetTableAdapters.CostosTableAdapter()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.No_ordenToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.No_ordenToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.PRUB = New System.Windows.Forms.TextBox()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Basededatos14beDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CotizacionesBindingSource
        '
        Me.CotizacionesBindingSource.DataMember = "Cotizaciones"
        Me.CotizacionesBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'CotizacionesTableAdapter
        '
        Me.CotizacionesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CotizacionesTableAdapter = Me.CotizacionesTableAdapter
        Me.TableAdapterManager.ManufacturaTableAdapter = Nothing
        Me.TableAdapterManager.MATERIALESTableAdapter = Nothing
        Me.TableAdapterManager.tblAdministradorTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asignar Número de Cotización"
        '
        'no_ordenCBX
        '
        Me.no_ordenCBX.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.no_ordenCBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.no_ordenCBX.DataSource = Me.VentasBindingSource1
        Me.no_ordenCBX.DisplayMember = "no_orden"
        Me.no_ordenCBX.FormattingEnabled = True
        Me.no_ordenCBX.Location = New System.Drawing.Point(88, 53)
        Me.no_ordenCBX.Name = "no_ordenCBX"
        Me.no_ordenCBX.Size = New System.Drawing.Size(132, 21)
        Me.no_ordenCBX.TabIndex = 1
        '
        'VentasBindingSource1
        '
        Me.VentasBindingSource1.DataMember = "Ventas"
        Me.VentasBindingSource1.DataSource = Me._Cotizaciones_1_4DataSet
        '
        '_Cotizaciones_1_4DataSet
        '
        Me._Cotizaciones_1_4DataSet.DataSetName = "_Cotizaciones_1_4DataSet"
        Me._Cotizaciones_1_4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. de orden"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliente"
        '
        'ClienteTXT
        '
        Me.ClienteTXT.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource1, "Cliente", True))
        Me.ClienteTXT.Location = New System.Drawing.Point(88, 80)
        Me.ClienteTXT.Name = "ClienteTXT"
        Me.ClienteTXT.Size = New System.Drawing.Size(132, 20)
        Me.ClienteTXT.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mes"
        Me.Label4.Visible = False
        '
        'no_cotizacionTXT
        '
        Me.no_cotizacionTXT.Location = New System.Drawing.Point(88, 106)
        Me.no_cotizacionTXT.Name = "no_cotizacionTXT"
        Me.no_cotizacionTXT.Size = New System.Drawing.Size(132, 20)
        Me.no_cotizacionTXT.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No. Cotización"
        '
        'T_FabTXT
        '
        Me.T_FabTXT.Location = New System.Drawing.Point(358, 132)
        Me.T_FabTXT.Name = "T_FabTXT"
        Me.T_FabTXT.Size = New System.Drawing.Size(175, 20)
        Me.T_FabTXT.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Recotización"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Fecha registro"
        '
        'MesTXT
        '
        Me.MesTXT.Location = New System.Drawing.Point(404, 14)
        Me.MesTXT.Name = "MesTXT"
        Me.MesTXT.Size = New System.Drawing.Size(100, 20)
        Me.MesTXT.TabIndex = 14
        Me.MesTXT.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Tiempo Fabricación"
        '
        'Proc_CotTXT
        '
        Me.Proc_CotTXT.Location = New System.Drawing.Point(358, 83)
        Me.Proc_CotTXT.Multiline = True
        Me.Proc_CotTXT.Name = "Proc_CotTXT"
        Me.Proc_CotTXT.Size = New System.Drawing.Size(175, 42)
        Me.Proc_CotTXT.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(253, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Procesos cotizados"
        '
        'RecotizaciónCHBX
        '
        Me.RecotizaciónCHBX.AutoSize = True
        Me.RecotizaciónCHBX.Location = New System.Drawing.Point(88, 135)
        Me.RecotizaciónCHBX.Name = "RecotizaciónCHBX"
        Me.RecotizaciónCHBX.Size = New System.Drawing.Size(15, 14)
        Me.RecotizaciónCHBX.TabIndex = 17
        Me.RecotizaciónCHBX.UseVisualStyleBackColor = True
        '
        'FECHA
        '
        Me.FECHA.Location = New System.Drawing.Point(333, 56)
        Me.FECHA.Name = "FECHA"
        Me.FECHA.Size = New System.Drawing.Size(200, 20)
        Me.FECHA.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 26)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Puntos a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "considerar"
        '
        'Otro_procTXT
        '
        Me.Otro_procTXT.Location = New System.Drawing.Point(88, 158)
        Me.Otro_procTXT.Multiline = True
        Me.Otro_procTXT.Name = "Otro_procTXT"
        Me.Otro_procTXT.Size = New System.Drawing.Size(310, 75)
        Me.Otro_procTXT.TabIndex = 21
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(471, 181)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 22
        Me.GuardarBTN.Text = "Guardar"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'CancelarBTN
        '
        Me.CancelarBTN.Location = New System.Drawing.Point(471, 210)
        Me.CancelarBTN.Name = "CancelarBTN"
        Me.CancelarBTN.Size = New System.Drawing.Size(75, 23)
        Me.CancelarBTN.TabIndex = 23
        Me.CancelarBTN.Text = "Cancelar"
        Me.CancelarBTN.UseVisualStyleBackColor = True
        '
        'Basededatos14beDataSetBindingSource
        '
        Me.Basededatos14beDataSetBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        Me.Basededatos14beDataSetBindingSource.Position = 0
        '
        'CotizacionesBindingSource1
        '
        Me.CotizacionesBindingSource1.DataMember = "Cotizaciones"
        Me.CotizacionesBindingSource1.DataSource = Me.Basededatos14beDataSetBindingSource
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
        'CotizacionesBindingSource2
        '
        Me.CotizacionesBindingSource2.DataMember = "Cotizaciones"
        Me.CotizacionesBindingSource2.DataSource = Me._Cotizaciones_1_4DataSet
        '
        'CotizacionesTableAdapter1
        '
        Me.CotizacionesTableAdapter1.ClearBeforeFill = True
        '
        'VentasTableAdapter1
        '
        Me.VentasTableAdapter1.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.PorcientoEMB)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 289)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(207, 152)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Embalaje"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(12, 126)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(34, 13)
        Me.Label31.TabIndex = 9
        Me.Label31.Text = "Total:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(12, 22)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(61, 13)
        Me.Label30.TabIndex = 7
        Me.Label30.Text = "Porcentaje:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(12, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(68, 13)
        Me.Label29.TabIndex = 6
        Me.Label29.Text = "Costo tarima:"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Location = New System.Drawing.Point(89, 123)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 8
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 74)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 13)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Pzas./Tarima:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(76, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Estiba max kg:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(89, 97)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(89, 71)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(89, 45)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 1
        '
        'PorcientoEMB
        '
        Me.PorcientoEMB.BackColor = System.Drawing.Color.White
        Me.PorcientoEMB.Location = New System.Drawing.Point(89, 19)
        Me.PorcientoEMB.Name = "PorcientoEMB"
        Me.PorcientoEMB.Size = New System.Drawing.Size(100, 20)
        Me.PorcientoEMB.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Location = New System.Drawing.Point(244, 289)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(207, 152)
        Me.GroupBox2.TabIndex = 148
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Herramentales"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Costo inicial:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Total:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "% herramienta:"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Location = New System.Drawing.Point(89, 71)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 2
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Location = New System.Drawing.Point(89, 45)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 1
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Location = New System.Drawing.Point(89, 19)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NoordenDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.ClaveFTMDataGridViewTextBoxColumn, Me.P1DataGridViewTextBoxColumn, Me.XDataGridViewTextBoxColumn, Me.YDataGridViewTextBoxColumn, Me.P2DataGridViewTextBoxColumn, Me.X1DataGridViewTextBoxColumn, Me.Y1DataGridViewTextBoxColumn, Me.ValormaterialDataGridViewTextBoxColumn, Me.PesoBrutoDataGridViewTextBoxColumn, Me.FactorDataGridViewTextBoxColumn, Me.CostoMPDataGridViewTextBoxColumn, Me.PrecioMPDataGridViewTextBoxColumn, Me.MaterialDataGridViewTextBoxColumn, Me.EspesorDataGridViewTextBoxColumn, Me.DoblezDataGridViewTextBoxColumn, Me.CostodoblezDataGridViewTextBoxColumn, Me.PreciodoblezDataGridViewTextBoxColumn, Me.CostopinturaDataGridViewTextBoxColumn, Me.PinturaDataGridViewTextBoxColumn, Me.SoldaduraDataGridViewTextBoxColumn, Me.MaquinadoDataGridViewTextBoxColumn, Me.CostogalvanizadoDataGridViewTextBoxColumn, Me.GalvanizadoDataGridViewTextBoxColumn, Me.CostoTropicalizadoDataGridViewTextBoxColumn, Me.TropicalizadoDataGridViewTextBoxColumn, Me.TiempocorteDataGridViewTextBoxColumn, Me.CostohrcorteDataGridViewTextBoxColumn, Me.PreciocorteDataGridViewTextBoxColumn, Me.CantidadesDataGridViewTextBoxColumn, Me.UmDataGridViewTextBoxColumn, Me.PreciofinalDataGridViewTextBoxColumn, Me.PrecioTotalDataGridViewTextBoxColumn, Me.CotizadorDataGridViewTextBoxColumn, Me.DibujoDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.EspesorINDataGridViewTextBoxColumn, Me.Esp1DataGridViewTextBoxColumn, Me.Esp2DataGridViewTextBoxColumn, Me.EspesorCalibreDataGridViewTextBoxColumn, Me.MilímetrosDataGridViewCheckBoxColumn, Me.PulgadaDataGridViewCheckBoxColumn, Me.CalibreDataGridViewCheckBoxColumn, Me.Espesor1DataGridViewTextBoxColumn, Me.EspcalDataGridViewTextBoxColumn, Me.LlaveDataGridViewTextBoxColumn, Me.SoldaduraCHBXDataGridViewCheckBoxColumn, Me.MaquinadoCHBXDataGridViewCheckBoxColumn, Me.PinturaCHBXDataGridViewCheckBoxColumn, Me.GalvanizadoCHBXDataGridViewCheckBoxColumn, Me.TropicalizadoCHBXDataGridViewCheckBoxColumn, Me.LaserCHBXDataGridViewCheckBoxColumn, Me.WJCHBXDataGridViewCheckBoxColumn, Me.SierraCHBXDataGridViewCheckBoxColumn, Me.PunzonadoCHBXDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.CostosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(579, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(574, 406)
        Me.DataGridView1.TabIndex = 149
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
        'P1DataGridViewTextBoxColumn
        '
        Me.P1DataGridViewTextBoxColumn.DataPropertyName = "P1"
        Me.P1DataGridViewTextBoxColumn.HeaderText = "P1"
        Me.P1DataGridViewTextBoxColumn.Name = "P1DataGridViewTextBoxColumn"
        '
        'XDataGridViewTextBoxColumn
        '
        Me.XDataGridViewTextBoxColumn.DataPropertyName = "X"
        Me.XDataGridViewTextBoxColumn.HeaderText = "X"
        Me.XDataGridViewTextBoxColumn.Name = "XDataGridViewTextBoxColumn"
        '
        'YDataGridViewTextBoxColumn
        '
        Me.YDataGridViewTextBoxColumn.DataPropertyName = "Y"
        Me.YDataGridViewTextBoxColumn.HeaderText = "Y"
        Me.YDataGridViewTextBoxColumn.Name = "YDataGridViewTextBoxColumn"
        '
        'P2DataGridViewTextBoxColumn
        '
        Me.P2DataGridViewTextBoxColumn.DataPropertyName = "P2"
        Me.P2DataGridViewTextBoxColumn.HeaderText = "P2"
        Me.P2DataGridViewTextBoxColumn.Name = "P2DataGridViewTextBoxColumn"
        '
        'X1DataGridViewTextBoxColumn
        '
        Me.X1DataGridViewTextBoxColumn.DataPropertyName = "X1"
        Me.X1DataGridViewTextBoxColumn.HeaderText = "X1"
        Me.X1DataGridViewTextBoxColumn.Name = "X1DataGridViewTextBoxColumn"
        '
        'Y1DataGridViewTextBoxColumn
        '
        Me.Y1DataGridViewTextBoxColumn.DataPropertyName = "Y1"
        Me.Y1DataGridViewTextBoxColumn.HeaderText = "Y1"
        Me.Y1DataGridViewTextBoxColumn.Name = "Y1DataGridViewTextBoxColumn"
        '
        'ValormaterialDataGridViewTextBoxColumn
        '
        Me.ValormaterialDataGridViewTextBoxColumn.DataPropertyName = "Valor_material"
        Me.ValormaterialDataGridViewTextBoxColumn.HeaderText = "Valor_material"
        Me.ValormaterialDataGridViewTextBoxColumn.Name = "ValormaterialDataGridViewTextBoxColumn"
        '
        'PesoBrutoDataGridViewTextBoxColumn
        '
        Me.PesoBrutoDataGridViewTextBoxColumn.DataPropertyName = "Peso_Bruto"
        Me.PesoBrutoDataGridViewTextBoxColumn.HeaderText = "Peso_Bruto"
        Me.PesoBrutoDataGridViewTextBoxColumn.Name = "PesoBrutoDataGridViewTextBoxColumn"
        '
        'FactorDataGridViewTextBoxColumn
        '
        Me.FactorDataGridViewTextBoxColumn.DataPropertyName = "Factor"
        Me.FactorDataGridViewTextBoxColumn.HeaderText = "Factor"
        Me.FactorDataGridViewTextBoxColumn.Name = "FactorDataGridViewTextBoxColumn"
        '
        'CostoMPDataGridViewTextBoxColumn
        '
        Me.CostoMPDataGridViewTextBoxColumn.DataPropertyName = "Costo_MP"
        Me.CostoMPDataGridViewTextBoxColumn.HeaderText = "Costo_MP"
        Me.CostoMPDataGridViewTextBoxColumn.Name = "CostoMPDataGridViewTextBoxColumn"
        '
        'PrecioMPDataGridViewTextBoxColumn
        '
        Me.PrecioMPDataGridViewTextBoxColumn.DataPropertyName = "Precio_MP"
        Me.PrecioMPDataGridViewTextBoxColumn.HeaderText = "Precio_MP"
        Me.PrecioMPDataGridViewTextBoxColumn.Name = "PrecioMPDataGridViewTextBoxColumn"
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
        'DoblezDataGridViewTextBoxColumn
        '
        Me.DoblezDataGridViewTextBoxColumn.DataPropertyName = "Doblez"
        Me.DoblezDataGridViewTextBoxColumn.HeaderText = "Doblez"
        Me.DoblezDataGridViewTextBoxColumn.Name = "DoblezDataGridViewTextBoxColumn"
        '
        'CostodoblezDataGridViewTextBoxColumn
        '
        Me.CostodoblezDataGridViewTextBoxColumn.DataPropertyName = "Costo_doblez"
        Me.CostodoblezDataGridViewTextBoxColumn.HeaderText = "Costo_doblez"
        Me.CostodoblezDataGridViewTextBoxColumn.Name = "CostodoblezDataGridViewTextBoxColumn"
        '
        'PreciodoblezDataGridViewTextBoxColumn
        '
        Me.PreciodoblezDataGridViewTextBoxColumn.DataPropertyName = "Precio_doblez"
        Me.PreciodoblezDataGridViewTextBoxColumn.HeaderText = "Precio_doblez"
        Me.PreciodoblezDataGridViewTextBoxColumn.Name = "PreciodoblezDataGridViewTextBoxColumn"
        '
        'CostopinturaDataGridViewTextBoxColumn
        '
        Me.CostopinturaDataGridViewTextBoxColumn.DataPropertyName = "Costo_pintura"
        Me.CostopinturaDataGridViewTextBoxColumn.HeaderText = "Costo_pintura"
        Me.CostopinturaDataGridViewTextBoxColumn.Name = "CostopinturaDataGridViewTextBoxColumn"
        '
        'PinturaDataGridViewTextBoxColumn
        '
        Me.PinturaDataGridViewTextBoxColumn.DataPropertyName = "Pintura"
        Me.PinturaDataGridViewTextBoxColumn.HeaderText = "Pintura"
        Me.PinturaDataGridViewTextBoxColumn.Name = "PinturaDataGridViewTextBoxColumn"
        '
        'SoldaduraDataGridViewTextBoxColumn
        '
        Me.SoldaduraDataGridViewTextBoxColumn.DataPropertyName = "Soldadura"
        Me.SoldaduraDataGridViewTextBoxColumn.HeaderText = "Soldadura"
        Me.SoldaduraDataGridViewTextBoxColumn.Name = "SoldaduraDataGridViewTextBoxColumn"
        '
        'MaquinadoDataGridViewTextBoxColumn
        '
        Me.MaquinadoDataGridViewTextBoxColumn.DataPropertyName = "Maquinado"
        Me.MaquinadoDataGridViewTextBoxColumn.HeaderText = "Maquinado"
        Me.MaquinadoDataGridViewTextBoxColumn.Name = "MaquinadoDataGridViewTextBoxColumn"
        '
        'CostogalvanizadoDataGridViewTextBoxColumn
        '
        Me.CostogalvanizadoDataGridViewTextBoxColumn.DataPropertyName = "Costo_galvanizado"
        Me.CostogalvanizadoDataGridViewTextBoxColumn.HeaderText = "Costo_galvanizado"
        Me.CostogalvanizadoDataGridViewTextBoxColumn.Name = "CostogalvanizadoDataGridViewTextBoxColumn"
        '
        'GalvanizadoDataGridViewTextBoxColumn
        '
        Me.GalvanizadoDataGridViewTextBoxColumn.DataPropertyName = "Galvanizado"
        Me.GalvanizadoDataGridViewTextBoxColumn.HeaderText = "Galvanizado"
        Me.GalvanizadoDataGridViewTextBoxColumn.Name = "GalvanizadoDataGridViewTextBoxColumn"
        '
        'CostoTropicalizadoDataGridViewTextBoxColumn
        '
        Me.CostoTropicalizadoDataGridViewTextBoxColumn.DataPropertyName = "Costo_Tropicalizado"
        Me.CostoTropicalizadoDataGridViewTextBoxColumn.HeaderText = "Costo_Tropicalizado"
        Me.CostoTropicalizadoDataGridViewTextBoxColumn.Name = "CostoTropicalizadoDataGridViewTextBoxColumn"
        '
        'TropicalizadoDataGridViewTextBoxColumn
        '
        Me.TropicalizadoDataGridViewTextBoxColumn.DataPropertyName = "Tropicalizado"
        Me.TropicalizadoDataGridViewTextBoxColumn.HeaderText = "Tropicalizado"
        Me.TropicalizadoDataGridViewTextBoxColumn.Name = "TropicalizadoDataGridViewTextBoxColumn"
        '
        'TiempocorteDataGridViewTextBoxColumn
        '
        Me.TiempocorteDataGridViewTextBoxColumn.DataPropertyName = "Tiempo_corte"
        Me.TiempocorteDataGridViewTextBoxColumn.HeaderText = "Tiempo_corte"
        Me.TiempocorteDataGridViewTextBoxColumn.Name = "TiempocorteDataGridViewTextBoxColumn"
        '
        'CostohrcorteDataGridViewTextBoxColumn
        '
        Me.CostohrcorteDataGridViewTextBoxColumn.DataPropertyName = "Costo_hr_corte"
        Me.CostohrcorteDataGridViewTextBoxColumn.HeaderText = "Costo_hr_corte"
        Me.CostohrcorteDataGridViewTextBoxColumn.Name = "CostohrcorteDataGridViewTextBoxColumn"
        '
        'PreciocorteDataGridViewTextBoxColumn
        '
        Me.PreciocorteDataGridViewTextBoxColumn.DataPropertyName = "Precio_corte"
        Me.PreciocorteDataGridViewTextBoxColumn.HeaderText = "Precio_corte"
        Me.PreciocorteDataGridViewTextBoxColumn.Name = "PreciocorteDataGridViewTextBoxColumn"
        '
        'CantidadesDataGridViewTextBoxColumn
        '
        Me.CantidadesDataGridViewTextBoxColumn.DataPropertyName = "Cantidades"
        Me.CantidadesDataGridViewTextBoxColumn.HeaderText = "Cantidades"
        Me.CantidadesDataGridViewTextBoxColumn.Name = "CantidadesDataGridViewTextBoxColumn"
        '
        'UmDataGridViewTextBoxColumn
        '
        Me.UmDataGridViewTextBoxColumn.DataPropertyName = "um"
        Me.UmDataGridViewTextBoxColumn.HeaderText = "um"
        Me.UmDataGridViewTextBoxColumn.Name = "UmDataGridViewTextBoxColumn"
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
        'EspesorINDataGridViewTextBoxColumn
        '
        Me.EspesorINDataGridViewTextBoxColumn.DataPropertyName = "Espesor_IN"
        Me.EspesorINDataGridViewTextBoxColumn.HeaderText = "Espesor_IN"
        Me.EspesorINDataGridViewTextBoxColumn.Name = "EspesorINDataGridViewTextBoxColumn"
        '
        'Esp1DataGridViewTextBoxColumn
        '
        Me.Esp1DataGridViewTextBoxColumn.DataPropertyName = "Esp_1"
        Me.Esp1DataGridViewTextBoxColumn.HeaderText = "Esp_1"
        Me.Esp1DataGridViewTextBoxColumn.Name = "Esp1DataGridViewTextBoxColumn"
        '
        'Esp2DataGridViewTextBoxColumn
        '
        Me.Esp2DataGridViewTextBoxColumn.DataPropertyName = "Esp_2"
        Me.Esp2DataGridViewTextBoxColumn.HeaderText = "Esp_2"
        Me.Esp2DataGridViewTextBoxColumn.Name = "Esp2DataGridViewTextBoxColumn"
        '
        'EspesorCalibreDataGridViewTextBoxColumn
        '
        Me.EspesorCalibreDataGridViewTextBoxColumn.DataPropertyName = "Espesor_Calibre"
        Me.EspesorCalibreDataGridViewTextBoxColumn.HeaderText = "Espesor_Calibre"
        Me.EspesorCalibreDataGridViewTextBoxColumn.Name = "EspesorCalibreDataGridViewTextBoxColumn"
        '
        'MilímetrosDataGridViewCheckBoxColumn
        '
        Me.MilímetrosDataGridViewCheckBoxColumn.DataPropertyName = "Milímetros"
        Me.MilímetrosDataGridViewCheckBoxColumn.HeaderText = "Milímetros"
        Me.MilímetrosDataGridViewCheckBoxColumn.Name = "MilímetrosDataGridViewCheckBoxColumn"
        '
        'PulgadaDataGridViewCheckBoxColumn
        '
        Me.PulgadaDataGridViewCheckBoxColumn.DataPropertyName = "Pulgada"
        Me.PulgadaDataGridViewCheckBoxColumn.HeaderText = "Pulgada"
        Me.PulgadaDataGridViewCheckBoxColumn.Name = "PulgadaDataGridViewCheckBoxColumn"
        '
        'CalibreDataGridViewCheckBoxColumn
        '
        Me.CalibreDataGridViewCheckBoxColumn.DataPropertyName = "Calibre"
        Me.CalibreDataGridViewCheckBoxColumn.HeaderText = "Calibre"
        Me.CalibreDataGridViewCheckBoxColumn.Name = "CalibreDataGridViewCheckBoxColumn"
        '
        'Espesor1DataGridViewTextBoxColumn
        '
        Me.Espesor1DataGridViewTextBoxColumn.DataPropertyName = "Espesor1"
        Me.Espesor1DataGridViewTextBoxColumn.HeaderText = "Espesor1"
        Me.Espesor1DataGridViewTextBoxColumn.Name = "Espesor1DataGridViewTextBoxColumn"
        '
        'EspcalDataGridViewTextBoxColumn
        '
        Me.EspcalDataGridViewTextBoxColumn.DataPropertyName = "Esp_cal"
        Me.EspcalDataGridViewTextBoxColumn.HeaderText = "Esp_cal"
        Me.EspcalDataGridViewTextBoxColumn.Name = "EspcalDataGridViewTextBoxColumn"
        '
        'LlaveDataGridViewTextBoxColumn
        '
        Me.LlaveDataGridViewTextBoxColumn.DataPropertyName = "Llave"
        Me.LlaveDataGridViewTextBoxColumn.HeaderText = "Llave"
        Me.LlaveDataGridViewTextBoxColumn.Name = "LlaveDataGridViewTextBoxColumn"
        '
        'SoldaduraCHBXDataGridViewCheckBoxColumn
        '
        Me.SoldaduraCHBXDataGridViewCheckBoxColumn.DataPropertyName = "SoldaduraCHBX"
        Me.SoldaduraCHBXDataGridViewCheckBoxColumn.HeaderText = "SoldaduraCHBX"
        Me.SoldaduraCHBXDataGridViewCheckBoxColumn.Name = "SoldaduraCHBXDataGridViewCheckBoxColumn"
        '
        'MaquinadoCHBXDataGridViewCheckBoxColumn
        '
        Me.MaquinadoCHBXDataGridViewCheckBoxColumn.DataPropertyName = "MaquinadoCHBX"
        Me.MaquinadoCHBXDataGridViewCheckBoxColumn.HeaderText = "MaquinadoCHBX"
        Me.MaquinadoCHBXDataGridViewCheckBoxColumn.Name = "MaquinadoCHBXDataGridViewCheckBoxColumn"
        '
        'PinturaCHBXDataGridViewCheckBoxColumn
        '
        Me.PinturaCHBXDataGridViewCheckBoxColumn.DataPropertyName = "PinturaCHBX"
        Me.PinturaCHBXDataGridViewCheckBoxColumn.HeaderText = "PinturaCHBX"
        Me.PinturaCHBXDataGridViewCheckBoxColumn.Name = "PinturaCHBXDataGridViewCheckBoxColumn"
        '
        'GalvanizadoCHBXDataGridViewCheckBoxColumn
        '
        Me.GalvanizadoCHBXDataGridViewCheckBoxColumn.DataPropertyName = "GalvanizadoCHBX"
        Me.GalvanizadoCHBXDataGridViewCheckBoxColumn.HeaderText = "GalvanizadoCHBX"
        Me.GalvanizadoCHBXDataGridViewCheckBoxColumn.Name = "GalvanizadoCHBXDataGridViewCheckBoxColumn"
        '
        'TropicalizadoCHBXDataGridViewCheckBoxColumn
        '
        Me.TropicalizadoCHBXDataGridViewCheckBoxColumn.DataPropertyName = "TropicalizadoCHBX"
        Me.TropicalizadoCHBXDataGridViewCheckBoxColumn.HeaderText = "TropicalizadoCHBX"
        Me.TropicalizadoCHBXDataGridViewCheckBoxColumn.Name = "TropicalizadoCHBXDataGridViewCheckBoxColumn"
        '
        'LaserCHBXDataGridViewCheckBoxColumn
        '
        Me.LaserCHBXDataGridViewCheckBoxColumn.DataPropertyName = "LaserCHBX"
        Me.LaserCHBXDataGridViewCheckBoxColumn.HeaderText = "LaserCHBX"
        Me.LaserCHBXDataGridViewCheckBoxColumn.Name = "LaserCHBXDataGridViewCheckBoxColumn"
        '
        'WJCHBXDataGridViewCheckBoxColumn
        '
        Me.WJCHBXDataGridViewCheckBoxColumn.DataPropertyName = "WJCHBX"
        Me.WJCHBXDataGridViewCheckBoxColumn.HeaderText = "WJCHBX"
        Me.WJCHBXDataGridViewCheckBoxColumn.Name = "WJCHBXDataGridViewCheckBoxColumn"
        '
        'SierraCHBXDataGridViewCheckBoxColumn
        '
        Me.SierraCHBXDataGridViewCheckBoxColumn.DataPropertyName = "SierraCHBX"
        Me.SierraCHBXDataGridViewCheckBoxColumn.HeaderText = "SierraCHBX"
        Me.SierraCHBXDataGridViewCheckBoxColumn.Name = "SierraCHBXDataGridViewCheckBoxColumn"
        '
        'PunzonadoCHBXDataGridViewCheckBoxColumn
        '
        Me.PunzonadoCHBXDataGridViewCheckBoxColumn.DataPropertyName = "PunzonadoCHBX"
        Me.PunzonadoCHBXDataGridViewCheckBoxColumn.HeaderText = "PunzonadoCHBX"
        Me.PunzonadoCHBXDataGridViewCheckBoxColumn.Name = "PunzonadoCHBXDataGridViewCheckBoxColumn"
        '
        'CostosBindingSource
        '
        Me.CostosBindingSource.DataMember = "Costos"
        Me.CostosBindingSource.DataSource = Me._Cotizaciones_1_4DataSet
        '
        'CostosTableAdapter
        '
        Me.CostosTableAdapter.ClearBeforeFill = True
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(1173, 25)
        Me.FillByToolStrip.TabIndex = 150
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.No_ordenToolStripLabel, Me.No_ordenToolStripTextBox, Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(579, 6)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(219, 25)
        Me.FillBy1ToolStrip.TabIndex = 151
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
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
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(45, 22)
        Me.FillBy1ToolStripButton.Text = "FillBy1"
        '
        'PRUB
        '
        Me.PRUB.Location = New System.Drawing.Point(368, 257)
        Me.PRUB.Name = "PRUB"
        Me.PRUB.Size = New System.Drawing.Size(100, 20)
        Me.PRUB.TabIndex = 152
        '
        'Reg_NoCot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 461)
        Me.Controls.Add(Me.PRUB)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CancelarBTN)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.Otro_procTXT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FECHA)
        Me.Controls.Add(Me.RecotizaciónCHBX)
        Me.Controls.Add(Me.Proc_CotTXT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MesTXT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.T_FabTXT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.no_cotizacionTXT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ClienteTXT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.no_ordenCBX)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reg_NoCot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Cotización"
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Basededatos14beDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CostosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents CotizacionesBindingSource As BindingSource
    Friend WithEvents CotizacionesTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.CotizacionesTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label1 As Label
    Friend WithEvents no_ordenCBX As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ClienteTXT As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents no_cotizacionTXT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents T_FabTXT As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MesTXT As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Proc_CotTXT As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RecotizaciónCHBX As CheckBox
    Friend WithEvents FECHA As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Otro_procTXT As TextBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents CancelarBTN As Button
    Friend WithEvents CotizacionesBindingSource1 As BindingSource
    Friend WithEvents Basededatos14beDataSetBindingSource As BindingSource
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents _Cotizaciones_1_4DataSet As _Cotizaciones_1_4DataSet
    Friend WithEvents CotizacionesBindingSource2 As BindingSource
    Friend WithEvents CotizacionesTableAdapter1 As _Cotizaciones_1_4DataSetTableAdapters.CotizacionesTableAdapter
    Friend WithEvents VentasBindingSource1 As BindingSource
    Friend WithEvents VentasTableAdapter1 As _Cotizaciones_1_4DataSetTableAdapters.VentasTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PorcientoEMB As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CostosBindingSource As BindingSource
    Friend WithEvents CostosTableAdapter As _Cotizaciones_1_4DataSetTableAdapters.CostosTableAdapter
    Friend WithEvents NoordenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClaveFTMDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents P1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents XDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents P2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents X1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Y1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValormaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PesoBrutoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FactorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioMPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaterialDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspesorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DoblezDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostodoblezDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciodoblezDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostopinturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PinturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldaduraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaquinadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostogalvanizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GalvanizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostoTropicalizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TropicalizadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TiempocorteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CostohrcorteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciocorteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UmDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PreciofinalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioTotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CotizadorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DibujoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspesorINDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Esp1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Esp2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspesorCalibreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MilímetrosDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PulgadaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CalibreDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents Espesor1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EspcalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LlaveDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SoldaduraCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MaquinadoCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PinturaCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GalvanizadoCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TropicalizadoCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LaserCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents WJCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SierraCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PunzonadoCHBXDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents FillBy1ToolStrip As ToolStrip
    Friend WithEvents No_ordenToolStripLabel As ToolStripLabel
    Friend WithEvents No_ordenToolStripTextBox As ToolStripTextBox
    Friend WithEvents FillBy1ToolStripButton As ToolStripButton
    Friend WithEvents PRUB As TextBox
End Class
