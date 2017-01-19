<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegIndicadadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegIndicadadores))
        Me.AreaTXT = New System.Windows.Forms.ComboBox()
        Me.ClienteTXT = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.FechaTXT = New System.Windows.Forms.DateTimePicker()
        Me.MaquinaTXT = New System.Windows.Forms.ComboBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MantTXT = New System.Windows.Forms.TextBox()
        Me.DuracTXT = New System.Windows.Forms.TextBox()
        Me.OtroTXT = New System.Windows.Forms.TextBox()
        Me.PersoTXT = New System.Windows.Forms.TextBox()
        Me.FmaqTXT = New System.Windows.Forms.TextBox()
        Me.GasesTXT = New System.Windows.Forms.TextBox()
        Me.FofTXT = New System.Windows.Forms.TextBox()
        Me.DescTXT = New System.Windows.Forms.TextBox()
        Me.CalTXT = New System.Windows.Forms.TextBox()
        Me.EnerTXT = New System.Windows.Forms.TextBox()
        Me.ProgramaTXT = New System.Windows.Forms.TextBox()
        Me.MatTXT = New System.Windows.Forms.TextBox()
        Me.AjusTXT = New System.Windows.Forms.TextBox()
        Me.setupTXT = New System.Windows.Forms.TextBox()
        Me.LimpTXT = New System.Windows.Forms.TextBox()
        Me.TrabTXT = New System.Windows.Forms.TextBox()
        Me.SemTXT = New System.Windows.Forms.TextBox()
        Me.SCRAPTXT = New System.Windows.Forms.TextBox()
        Me.RechazadasTXT = New System.Windows.Forms.TextBox()
        Me.ProdTXT = New System.Windows.Forms.TextBox()
        Me.ProgTXT = New System.Windows.Forms.TextBox()
        Me.hrTXT = New System.Windows.Forms.TextBox()
        Me.hpTXT = New System.Windows.Forms.TextBox()
        Me.OFTXT = New System.Windows.Forms.TextBox()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.ProduccionBD = New FTM_Registros.ProduccionBD()
        Me.RegistrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegistrosTableAdapter = New FTM_Registros.ProduccionBDTableAdapters.RegistrosTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProduccionBDTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ClientesTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter()
        Me.VaciarBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'AreaTXT
        '
        Me.AreaTXT.FormattingEnabled = True
        Me.AreaTXT.Items.AddRange(New Object() {"Láser", "Doblez", "Maquinados", "Punzonado"})
        Me.AreaTXT.Location = New System.Drawing.Point(183, 29)
        Me.AreaTXT.Name = "AreaTXT"
        Me.AreaTXT.Size = New System.Drawing.Size(121, 21)
        Me.AreaTXT.TabIndex = 2
        '
        'ClienteTXT
        '
        Me.ClienteTXT.DataSource = Me.ClientesBindingSource
        Me.ClienteTXT.DisplayMember = "Cliente"
        Me.ClienteTXT.FormattingEnabled = True
        Me.ClienteTXT.Location = New System.Drawing.Point(54, 63)
        Me.ClienteTXT.Name = "ClienteTXT"
        Me.ClienteTXT.Size = New System.Drawing.Size(121, 21)
        Me.ClienteTXT.TabIndex = 5
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
        'FechaTXT
        '
        Me.FechaTXT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaTXT.Location = New System.Drawing.Point(377, 29)
        Me.FechaTXT.Name = "FechaTXT"
        Me.FechaTXT.Size = New System.Drawing.Size(121, 20)
        Me.FechaTXT.TabIndex = 3
        '
        'MaquinaTXT
        '
        Me.MaquinaTXT.FormattingEnabled = True
        Me.MaquinaTXT.Location = New System.Drawing.Point(266, 63)
        Me.MaquinaTXT.Name = "MaquinaTXT"
        Me.MaquinaTXT.Size = New System.Drawing.Size(121, 21)
        Me.MaquinaTXT.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(15, 31)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 13)
        Me.Label29.TabIndex = 117
        Me.Label29.Text = "Mantenimiento:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(227, 213)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 115
        Me.Label27.Text = "Duración:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(227, 187)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(30, 13)
        Me.Label26.TabIndex = 114
        Me.Label26.Text = "Otro:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(227, 161)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(80, 13)
        Me.Label25.TabIndex = 113
        Me.Label25.Text = "Junta Personal:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(227, 135)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(76, 13)
        Me.Label24.TabIndex = 112
        Me.Label24.Text = "Falla Máquina:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(227, 109)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(40, 13)
        Me.Label23.TabIndex = 111
        Me.Label23.Text = "Gases:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(227, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(50, 13)
        Me.Label22.TabIndex = 110
        Me.Label22.Text = "Falta OF:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(227, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 13)
        Me.Label21.TabIndex = 109
        Me.Label21.Text = "Descarga:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(227, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 108
        Me.Label20.Text = "Calidad:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(15, 213)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 107
        Me.Label19.Text = "Falta de Energía:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 187)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 13)
        Me.Label18.TabIndex = 106
        Me.Label18.Text = "Programa:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 161)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Falta de Material:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(15, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(44, 13)
        Me.Label16.TabIndex = 104
        Me.Label16.Text = "Ajustes:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Set Up:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 102
        Me.Label14.Text = "Limpieza:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "Falta de trabajo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(519, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 13)
        Me.Label12.TabIndex = 100
        Me.Label12.Text = "Semana:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(453, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 99
        Me.Label11.Text = "SCRAP:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(453, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 98
        Me.Label10.Text = "Pza. Rechazadas:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Pza. Producidas:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(208, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Pza. Programados:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "H. Real:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "H. Prog:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(145, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Área:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(209, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Máquina:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "OF:"
        '
        'MantTXT
        '
        Me.MantTXT.Location = New System.Drawing.Point(110, 28)
        Me.MantTXT.Name = "MantTXT"
        Me.MantTXT.Size = New System.Drawing.Size(100, 20)
        Me.MantTXT.TabIndex = 13
        '
        'DuracTXT
        '
        Me.DuracTXT.Location = New System.Drawing.Point(320, 210)
        Me.DuracTXT.Name = "DuracTXT"
        Me.DuracTXT.Size = New System.Drawing.Size(100, 20)
        Me.DuracTXT.TabIndex = 28
        '
        'OtroTXT
        '
        Me.OtroTXT.Location = New System.Drawing.Point(320, 184)
        Me.OtroTXT.Name = "OtroTXT"
        Me.OtroTXT.Size = New System.Drawing.Size(100, 20)
        Me.OtroTXT.TabIndex = 27
        '
        'PersoTXT
        '
        Me.PersoTXT.Location = New System.Drawing.Point(320, 158)
        Me.PersoTXT.Name = "PersoTXT"
        Me.PersoTXT.Size = New System.Drawing.Size(100, 20)
        Me.PersoTXT.TabIndex = 26
        '
        'FmaqTXT
        '
        Me.FmaqTXT.Location = New System.Drawing.Point(320, 132)
        Me.FmaqTXT.Name = "FmaqTXT"
        Me.FmaqTXT.Size = New System.Drawing.Size(100, 20)
        Me.FmaqTXT.TabIndex = 25
        '
        'GasesTXT
        '
        Me.GasesTXT.Location = New System.Drawing.Point(320, 106)
        Me.GasesTXT.Name = "GasesTXT"
        Me.GasesTXT.Size = New System.Drawing.Size(100, 20)
        Me.GasesTXT.TabIndex = 24
        '
        'FofTXT
        '
        Me.FofTXT.Location = New System.Drawing.Point(320, 80)
        Me.FofTXT.Name = "FofTXT"
        Me.FofTXT.Size = New System.Drawing.Size(100, 20)
        Me.FofTXT.TabIndex = 23
        '
        'DescTXT
        '
        Me.DescTXT.Location = New System.Drawing.Point(320, 54)
        Me.DescTXT.Name = "DescTXT"
        Me.DescTXT.Size = New System.Drawing.Size(100, 20)
        Me.DescTXT.TabIndex = 22
        '
        'CalTXT
        '
        Me.CalTXT.Location = New System.Drawing.Point(320, 28)
        Me.CalTXT.Name = "CalTXT"
        Me.CalTXT.Size = New System.Drawing.Size(100, 20)
        Me.CalTXT.TabIndex = 21
        '
        'EnerTXT
        '
        Me.EnerTXT.Location = New System.Drawing.Point(108, 210)
        Me.EnerTXT.Name = "EnerTXT"
        Me.EnerTXT.Size = New System.Drawing.Size(100, 20)
        Me.EnerTXT.TabIndex = 20
        '
        'ProgramaTXT
        '
        Me.ProgramaTXT.Location = New System.Drawing.Point(108, 184)
        Me.ProgramaTXT.Name = "ProgramaTXT"
        Me.ProgramaTXT.Size = New System.Drawing.Size(100, 20)
        Me.ProgramaTXT.TabIndex = 19
        '
        'MatTXT
        '
        Me.MatTXT.Location = New System.Drawing.Point(108, 158)
        Me.MatTXT.Name = "MatTXT"
        Me.MatTXT.Size = New System.Drawing.Size(100, 20)
        Me.MatTXT.TabIndex = 18
        '
        'AjusTXT
        '
        Me.AjusTXT.Location = New System.Drawing.Point(108, 132)
        Me.AjusTXT.Name = "AjusTXT"
        Me.AjusTXT.Size = New System.Drawing.Size(100, 20)
        Me.AjusTXT.TabIndex = 17
        '
        'setupTXT
        '
        Me.setupTXT.Location = New System.Drawing.Point(110, 106)
        Me.setupTXT.Name = "setupTXT"
        Me.setupTXT.Size = New System.Drawing.Size(100, 20)
        Me.setupTXT.TabIndex = 16
        '
        'LimpTXT
        '
        Me.LimpTXT.Location = New System.Drawing.Point(110, 80)
        Me.LimpTXT.Name = "LimpTXT"
        Me.LimpTXT.Size = New System.Drawing.Size(100, 20)
        Me.LimpTXT.TabIndex = 15
        '
        'TrabTXT
        '
        Me.TrabTXT.Location = New System.Drawing.Point(110, 54)
        Me.TrabTXT.Name = "TrabTXT"
        Me.TrabTXT.Size = New System.Drawing.Size(100, 20)
        Me.TrabTXT.TabIndex = 14
        '
        'SemTXT
        '
        Me.SemTXT.Location = New System.Drawing.Point(574, 29)
        Me.SemTXT.Name = "SemTXT"
        Me.SemTXT.Size = New System.Drawing.Size(60, 20)
        Me.SemTXT.TabIndex = 4
        '
        'SCRAPTXT
        '
        Me.SCRAPTXT.Location = New System.Drawing.Point(548, 122)
        Me.SCRAPTXT.Name = "SCRAPTXT"
        Me.SCRAPTXT.Size = New System.Drawing.Size(100, 20)
        Me.SCRAPTXT.TabIndex = 12
        '
        'RechazadasTXT
        '
        Me.RechazadasTXT.Location = New System.Drawing.Point(548, 96)
        Me.RechazadasTXT.Name = "RechazadasTXT"
        Me.RechazadasTXT.Size = New System.Drawing.Size(100, 20)
        Me.RechazadasTXT.TabIndex = 11
        '
        'ProdTXT
        '
        Me.ProdTXT.Location = New System.Drawing.Point(310, 122)
        Me.ProdTXT.Name = "ProdTXT"
        Me.ProdTXT.Size = New System.Drawing.Size(100, 20)
        Me.ProdTXT.TabIndex = 10
        '
        'ProgTXT
        '
        Me.ProgTXT.Location = New System.Drawing.Point(310, 96)
        Me.ProgTXT.Name = "ProgTXT"
        Me.ProgTXT.Size = New System.Drawing.Size(100, 20)
        Me.ProgTXT.TabIndex = 9
        '
        'hrTXT
        '
        Me.hrTXT.Location = New System.Drawing.Point(58, 122)
        Me.hrTXT.Name = "hrTXT"
        Me.hrTXT.Size = New System.Drawing.Size(100, 20)
        Me.hrTXT.TabIndex = 8
        '
        'hpTXT
        '
        Me.hpTXT.Location = New System.Drawing.Point(58, 96)
        Me.hpTXT.Name = "hpTXT"
        Me.hpTXT.Size = New System.Drawing.Size(100, 20)
        Me.hpTXT.TabIndex = 7
        '
        'OFTXT
        '
        Me.OFTXT.Location = New System.Drawing.Point(36, 29)
        Me.OFTXT.Name = "OFTXT"
        Me.OFTXT.Size = New System.Drawing.Size(77, 20)
        Me.OFTXT.TabIndex = 1
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(593, 438)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 29
        Me.GuardarBTN.Text = "Guardar"
        Me.ToolTip1.SetToolTip(Me.GuardarBTN, "Guarda el registro actual")
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'ProduccionBD
        '
        Me.ProduccionBD.DataSetName = "ProduccionBD"
        Me.ProduccionBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrosBindingSource
        '
        Me.RegistrosBindingSource.DataMember = "Registros"
        Me.RegistrosBindingSource.DataSource = Me.ProduccionBD
        '
        'RegistrosTableAdapter
        '
        Me.RegistrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.RegistrosTableAdapter = Me.RegistrosTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.ProduccionBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OFTXT)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MaquinaTXT)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.hpTXT)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.hrTXT)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.AreaTXT)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ProgTXT)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ClienteTXT)
        Me.GroupBox1.Controls.Add(Me.SemTXT)
        Me.GroupBox1.Controls.Add(Me.ProdTXT)
        Me.GroupBox1.Controls.Add(Me.SCRAPTXT)
        Me.GroupBox1.Controls.Add(Me.FechaTXT)
        Me.GroupBox1.Controls.Add(Me.RechazadasTXT)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(659, 162)
        Me.GroupBox1.TabIndex = 125
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Diario"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.TrabTXT)
        Me.GroupBox2.Controls.Add(Me.LimpTXT)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.setupTXT)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.AjusTXT)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.MatTXT)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.ProgramaTXT)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.EnerTXT)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.CalTXT)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.DescTXT)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.FofTXT)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.GasesTXT)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.FmaqTXT)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.PersoTXT)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.OtroTXT)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.DuracTXT)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.MantTXT)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(470, 285)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tiempos Muertos"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'VaciarBTN
        '
        Me.VaciarBTN.Location = New System.Drawing.Point(593, 394)
        Me.VaciarBTN.Name = "VaciarBTN"
        Me.VaciarBTN.Size = New System.Drawing.Size(75, 23)
        Me.VaciarBTN.TabIndex = 127
        Me.VaciarBTN.Text = "Vaciar"
        Me.ToolTip1.SetToolTip(Me.VaciarBTN, "Vacia todos los campos")
        Me.VaciarBTN.UseVisualStyleBackColor = True
        '
        'RegIndicadadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 481)
        Me.Controls.Add(Me.VaciarBTN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegIndicadadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro Reportes de Producción"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AreaTXT As ComboBox
    Friend WithEvents ClienteTXT As ComboBox
    Friend WithEvents FechaTXT As DateTimePicker
    Friend WithEvents MaquinaTXT As ComboBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MantTXT As TextBox
    Friend WithEvents DuracTXT As TextBox
    Friend WithEvents OtroTXT As TextBox
    Friend WithEvents PersoTXT As TextBox
    Friend WithEvents FmaqTXT As TextBox
    Friend WithEvents GasesTXT As TextBox
    Friend WithEvents FofTXT As TextBox
    Friend WithEvents DescTXT As TextBox
    Friend WithEvents CalTXT As TextBox
    Friend WithEvents EnerTXT As TextBox
    Friend WithEvents ProgramaTXT As TextBox
    Friend WithEvents MatTXT As TextBox
    Friend WithEvents AjusTXT As TextBox
    Friend WithEvents setupTXT As TextBox
    Friend WithEvents LimpTXT As TextBox
    Friend WithEvents TrabTXT As TextBox
    Friend WithEvents SemTXT As TextBox
    Friend WithEvents SCRAPTXT As TextBox
    Friend WithEvents RechazadasTXT As TextBox
    Friend WithEvents ProdTXT As TextBox
    Friend WithEvents ProgTXT As TextBox
    Friend WithEvents hrTXT As TextBox
    Friend WithEvents hpTXT As TextBox
    Friend WithEvents OFTXT As TextBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents ProduccionBD As ProduccionBD
    Friend WithEvents RegistrosBindingSource As BindingSource
    Friend WithEvents RegistrosTableAdapter As ProduccionBDTableAdapters.RegistrosTableAdapter
    Friend WithEvents TableAdapterManager As ProduccionBDTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents VaciarBTN As Button
End Class
