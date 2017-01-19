<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntradasSalidas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EntradasSalidas))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CalibreCMX = New System.Windows.Forms.ComboBox()
        Me.ClienteCMB = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.noParteTXT = New System.Windows.Forms.TextBox()
        Me.ComentarioTXT = New System.Windows.Forms.TextBox()
        Me.NivelTXT = New System.Windows.Forms.TextBox()
        Me.RackTXT = New System.Windows.Forms.TextBox()
        Me.CostokgTXT = New System.Windows.Forms.TextBox()
        Me.CostoTXT = New System.Windows.Forms.TextBox()
        Me.UnidadTXT = New System.Windows.Forms.TextBox()
        Me.AnchoTXT = New System.Windows.Forms.TextBox()
        Me.LargoTXT = New System.Windows.Forms.TextBox()
        Me.CalidadTXT = New System.Windows.Forms.TextBox()
        Me.OCTXT = New System.Windows.Forms.TextBox()
        Me.FacturaTXT = New System.Windows.Forms.TextBox()
        Me.LoteTXT = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.EntradaTXT = New System.Windows.Forms.ComboBox()
        Me.Entradas_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlmacenBD = New FTM_Registros.AlmacenBD()
        Me.Guardar2BTN = New System.Windows.Forms.Button()
        Me.Fecha2TXT = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.MaqTXT = New System.Windows.Forms.TextBox()
        Me.CantTXT = New System.Windows.Forms.TextBox()
        Me.AutorizaTXT = New System.Windows.Forms.TextBox()
        Me.SolicitanteTXT = New System.Windows.Forms.TextBox()
        Me.MatTXT = New System.Windows.Forms.TextBox()
        Me.ofTXT = New System.Windows.Forms.TextBox()
        Me.piTXT = New System.Windows.Forms.TextBox()
        Me.oc2TXT = New System.Windows.Forms.TextBox()
        Me.SalidaTXT = New System.Windows.Forms.TextBox()
        Me.EntradasMaterialTableAdapter = New FTM_Registros.AlmacenBDTableAdapters.EntradasMaterialTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.AlmacenBDTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter()
        Me.Salidas_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalidasMaterialTableAdapter = New FTM_Registros.AlmacenBDTableAdapters.SalidasMaterialTableAdapter()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.MaterialTXT = New System.Windows.Forms.ComboBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Entradas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlmacenBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salidas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(538, 350)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.MaterialTXT)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.CalibreCMX)
        Me.TabPage1.Controls.Add(Me.ClienteCMB)
        Me.TabPage1.Controls.Add(Me.GuardarBTN)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.noParteTXT)
        Me.TabPage1.Controls.Add(Me.ComentarioTXT)
        Me.TabPage1.Controls.Add(Me.NivelTXT)
        Me.TabPage1.Controls.Add(Me.RackTXT)
        Me.TabPage1.Controls.Add(Me.CostokgTXT)
        Me.TabPage1.Controls.Add(Me.CostoTXT)
        Me.TabPage1.Controls.Add(Me.UnidadTXT)
        Me.TabPage1.Controls.Add(Me.AnchoTXT)
        Me.TabPage1.Controls.Add(Me.LargoTXT)
        Me.TabPage1.Controls.Add(Me.CalidadTXT)
        Me.TabPage1.Controls.Add(Me.OCTXT)
        Me.TabPage1.Controls.Add(Me.FacturaTXT)
        Me.TabPage1.Controls.Add(Me.LoteTXT)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(530, 324)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Entradas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FTM_Registros.My.Resources.Resources.Jonas_Rask_Danish_Royalty_Free_New_archive
        Me.PictureBox1.Location = New System.Drawing.Point(489, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 82
        Me.PictureBox1.TabStop = False
        '
        'CalibreCMX
        '
        Me.CalibreCMX.BackColor = System.Drawing.SystemColors.Control
        Me.CalibreCMX.FormattingEnabled = True
        Me.CalibreCMX.Items.AddRange(New Object() {"Cal. 3", "Cal. 4", "Cal. 5", "Cal. 6", "Cal. 7", "Cal. 8", "Cal. 9", "Cal. 10", "Cal. 11", "Cal. 12", "Cal. 13", "Cal. 14", "Cal. 15", "Cal. 16", "Cal. 17", "Cal. 18", "Cal. 19", "Cal. 20", "Cal. 21", "Cal. 22", "Cal. 23", "Cal. 24", "Cal. 25", "Cal. 26", "Cal. 27", "Cal. 28", "Cal. 29", "Cal. 30", "Cal. 31", "Cal. 34", "Cal. 33", "Cal. 34", "1''", "7/8''", "3/4''", "5/8''", "1/2''", "3/8''", "5/16''", "1/4''", "3/16''"})
        Me.CalibreCMX.Location = New System.Drawing.Point(107, 197)
        Me.CalibreCMX.Name = "CalibreCMX"
        Me.CalibreCMX.Size = New System.Drawing.Size(115, 21)
        Me.CalibreCMX.TabIndex = 8
        '
        'ClienteCMB
        '
        Me.ClienteCMB.BackColor = System.Drawing.SystemColors.Control
        Me.ClienteCMB.DataSource = Me.ClientesBindingSource
        Me.ClienteCMB.DisplayMember = "Cliente"
        Me.ClienteCMB.FormattingEnabled = True
        Me.ClienteCMB.Location = New System.Drawing.Point(107, 41)
        Me.ClienteCMB.Name = "ClienteCMB"
        Me.ClienteCMB.Size = New System.Drawing.Size(115, 21)
        Me.ClienteCMB.TabIndex = 2
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
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(446, 290)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 18
        Me.GuardarBTN.Text = "Guardar"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(242, 175)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 13)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "No. de parte:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(242, 149)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 77
        Me.Label18.Text = "Lote:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(242, 205)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Comentario:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(242, 123)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 75
        Me.Label16.Text = "Nivel:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(242, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "RACK:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(242, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Costo por KG:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(242, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Costo:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(242, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Unidad:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Material:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Calibre:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Ancho:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 66
        Me.Label7.Text = "Largo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Certificado Calidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Orden de Compra"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Factura o Remisión:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Fecha:"
        '
        'noParteTXT
        '
        Me.noParteTXT.BackColor = System.Drawing.SystemColors.Control
        Me.noParteTXT.Location = New System.Drawing.Point(315, 172)
        Me.noParteTXT.Name = "noParteTXT"
        Me.noParteTXT.Size = New System.Drawing.Size(115, 20)
        Me.noParteTXT.TabIndex = 16
        '
        'ComentarioTXT
        '
        Me.ComentarioTXT.BackColor = System.Drawing.SystemColors.Control
        Me.ComentarioTXT.Location = New System.Drawing.Point(315, 202)
        Me.ComentarioTXT.Multiline = True
        Me.ComentarioTXT.Name = "ComentarioTXT"
        Me.ComentarioTXT.Size = New System.Drawing.Size(206, 82)
        Me.ComentarioTXT.TabIndex = 17
        '
        'NivelTXT
        '
        Me.NivelTXT.BackColor = System.Drawing.SystemColors.Control
        Me.NivelTXT.Location = New System.Drawing.Point(315, 120)
        Me.NivelTXT.Name = "NivelTXT"
        Me.NivelTXT.Size = New System.Drawing.Size(115, 20)
        Me.NivelTXT.TabIndex = 14
        '
        'RackTXT
        '
        Me.RackTXT.BackColor = System.Drawing.SystemColors.Control
        Me.RackTXT.Location = New System.Drawing.Point(315, 94)
        Me.RackTXT.Name = "RackTXT"
        Me.RackTXT.Size = New System.Drawing.Size(115, 20)
        Me.RackTXT.TabIndex = 13
        '
        'CostokgTXT
        '
        Me.CostokgTXT.BackColor = System.Drawing.SystemColors.Control
        Me.CostokgTXT.Location = New System.Drawing.Point(315, 68)
        Me.CostokgTXT.Name = "CostokgTXT"
        Me.CostokgTXT.Size = New System.Drawing.Size(115, 20)
        Me.CostokgTXT.TabIndex = 12
        '
        'CostoTXT
        '
        Me.CostoTXT.BackColor = System.Drawing.SystemColors.Control
        Me.CostoTXT.Location = New System.Drawing.Point(315, 42)
        Me.CostoTXT.Name = "CostoTXT"
        Me.CostoTXT.Size = New System.Drawing.Size(115, 20)
        Me.CostoTXT.TabIndex = 11
        '
        'UnidadTXT
        '
        Me.UnidadTXT.BackColor = System.Drawing.SystemColors.Control
        Me.UnidadTXT.Location = New System.Drawing.Point(315, 18)
        Me.UnidadTXT.Name = "UnidadTXT"
        Me.UnidadTXT.Size = New System.Drawing.Size(115, 20)
        Me.UnidadTXT.TabIndex = 10
        Me.UnidadTXT.Text = "PZA"
        '
        'AnchoTXT
        '
        Me.AnchoTXT.BackColor = System.Drawing.SystemColors.Control
        Me.AnchoTXT.Location = New System.Drawing.Point(107, 172)
        Me.AnchoTXT.Name = "AnchoTXT"
        Me.AnchoTXT.Size = New System.Drawing.Size(115, 20)
        Me.AnchoTXT.TabIndex = 7
        '
        'LargoTXT
        '
        Me.LargoTXT.BackColor = System.Drawing.SystemColors.Control
        Me.LargoTXT.Location = New System.Drawing.Point(107, 146)
        Me.LargoTXT.Name = "LargoTXT"
        Me.LargoTXT.Size = New System.Drawing.Size(115, 20)
        Me.LargoTXT.TabIndex = 6
        '
        'CalidadTXT
        '
        Me.CalidadTXT.BackColor = System.Drawing.SystemColors.Control
        Me.CalidadTXT.Location = New System.Drawing.Point(107, 120)
        Me.CalidadTXT.Name = "CalidadTXT"
        Me.CalidadTXT.Size = New System.Drawing.Size(115, 20)
        Me.CalidadTXT.TabIndex = 5
        '
        'OCTXT
        '
        Me.OCTXT.BackColor = System.Drawing.SystemColors.Control
        Me.OCTXT.Location = New System.Drawing.Point(107, 94)
        Me.OCTXT.Name = "OCTXT"
        Me.OCTXT.Size = New System.Drawing.Size(115, 20)
        Me.OCTXT.TabIndex = 4
        '
        'FacturaTXT
        '
        Me.FacturaTXT.BackColor = System.Drawing.SystemColors.Control
        Me.FacturaTXT.Location = New System.Drawing.Point(107, 68)
        Me.FacturaTXT.Name = "FacturaTXT"
        Me.FacturaTXT.Size = New System.Drawing.Size(115, 20)
        Me.FacturaTXT.TabIndex = 3
        '
        'LoteTXT
        '
        Me.LoteTXT.BackColor = System.Drawing.SystemColors.Control
        Me.LoteTXT.Location = New System.Drawing.Point(315, 146)
        Me.LoteTXT.Name = "LoteTXT"
        Me.LoteTXT.Size = New System.Drawing.Size(115, 20)
        Me.LoteTXT.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Controls.Add(Me.EntradaTXT)
        Me.TabPage2.Controls.Add(Me.Guardar2BTN)
        Me.TabPage2.Controls.Add(Me.Fecha2TXT)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.Label27)
        Me.TabPage2.Controls.Add(Me.Label28)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.MaqTXT)
        Me.TabPage2.Controls.Add(Me.CantTXT)
        Me.TabPage2.Controls.Add(Me.AutorizaTXT)
        Me.TabPage2.Controls.Add(Me.SolicitanteTXT)
        Me.TabPage2.Controls.Add(Me.MatTXT)
        Me.TabPage2.Controls.Add(Me.ofTXT)
        Me.TabPage2.Controls.Add(Me.piTXT)
        Me.TabPage2.Controls.Add(Me.oc2TXT)
        Me.TabPage2.Controls.Add(Me.SalidaTXT)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(530, 324)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Salidas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FTM_Registros.My.Resources.Resources.Jonas_Rask_Danish_Royalty_Free_Delete_archive
        Me.PictureBox2.Location = New System.Drawing.Point(489, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 83
        Me.PictureBox2.TabStop = False
        '
        'EntradaTXT
        '
        Me.EntradaTXT.BackColor = System.Drawing.SystemColors.Control
        Me.EntradaTXT.DataSource = Me.Entradas_MaterialBindingSource
        Me.EntradaTXT.DisplayMember = "FOLIO DE ENTRADA"
        Me.EntradaTXT.FormattingEnabled = True
        Me.EntradaTXT.Location = New System.Drawing.Point(99, 86)
        Me.EntradaTXT.Name = "EntradaTXT"
        Me.EntradaTXT.Size = New System.Drawing.Size(121, 21)
        Me.EntradaTXT.TabIndex = 3
        '
        'Entradas_MaterialBindingSource
        '
        Me.Entradas_MaterialBindingSource.DataMember = "Entradas_Material"
        Me.Entradas_MaterialBindingSource.DataSource = Me.AlmacenBD
        '
        'AlmacenBD
        '
        Me.AlmacenBD.DataSetName = "AlmacenBD"
        Me.AlmacenBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Guardar2BTN
        '
        Me.Guardar2BTN.Location = New System.Drawing.Point(378, 249)
        Me.Guardar2BTN.Name = "Guardar2BTN"
        Me.Guardar2BTN.Size = New System.Drawing.Size(75, 23)
        Me.Guardar2BTN.TabIndex = 12
        Me.Guardar2BTN.Text = "Guardar"
        Me.Guardar2BTN.UseVisualStyleBackColor = True
        '
        'Fecha2TXT
        '
        Me.Fecha2TXT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Fecha2TXT.Location = New System.Drawing.Point(99, 54)
        Me.Fecha2TXT.Name = "Fecha2TXT"
        Me.Fecha2TXT.Size = New System.Drawing.Size(121, 20)
        Me.Fecha2TXT.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Maquina:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(268, 155)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Cantidad:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(268, 121)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 13)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Autoriza:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(268, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(59, 13)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Solicitante:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(268, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(44, 13)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "Material"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 191)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 13)
        Me.Label24.TabIndex = 39
        Me.Label24.Text = "Ord. Fabricación:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 156)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(79, 13)
        Me.Label25.TabIndex = 38
        Me.Label25.Text = "Pedido Interno:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 123)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 13)
        Me.Label26.TabIndex = 37
        Me.Label26.Text = "Orden de compra:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 89)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 13)
        Me.Label27.TabIndex = 36
        Me.Label27.Text = "Folio de Entrada:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 57)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(40, 13)
        Me.Label28.TabIndex = 35
        Me.Label28.Text = "Fecha:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 25)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(79, 13)
        Me.Label29.TabIndex = 34
        Me.Label29.Text = "Folio de Salida:"
        '
        'MaqTXT
        '
        Me.MaqTXT.BackColor = System.Drawing.SystemColors.Control
        Me.MaqTXT.Location = New System.Drawing.Point(333, 185)
        Me.MaqTXT.Name = "MaqTXT"
        Me.MaqTXT.Size = New System.Drawing.Size(121, 20)
        Me.MaqTXT.TabIndex = 11
        '
        'CantTXT
        '
        Me.CantTXT.BackColor = System.Drawing.SystemColors.Control
        Me.CantTXT.Location = New System.Drawing.Point(332, 152)
        Me.CantTXT.Name = "CantTXT"
        Me.CantTXT.Size = New System.Drawing.Size(121, 20)
        Me.CantTXT.TabIndex = 10
        '
        'AutorizaTXT
        '
        Me.AutorizaTXT.BackColor = System.Drawing.SystemColors.Control
        Me.AutorizaTXT.Location = New System.Drawing.Point(332, 118)
        Me.AutorizaTXT.Name = "AutorizaTXT"
        Me.AutorizaTXT.Size = New System.Drawing.Size(121, 20)
        Me.AutorizaTXT.TabIndex = 9
        '
        'SolicitanteTXT
        '
        Me.SolicitanteTXT.BackColor = System.Drawing.SystemColors.Control
        Me.SolicitanteTXT.Location = New System.Drawing.Point(332, 86)
        Me.SolicitanteTXT.Name = "SolicitanteTXT"
        Me.SolicitanteTXT.Size = New System.Drawing.Size(121, 20)
        Me.SolicitanteTXT.TabIndex = 8
        '
        'MatTXT
        '
        Me.MatTXT.BackColor = System.Drawing.SystemColors.Control
        Me.MatTXT.Location = New System.Drawing.Point(332, 54)
        Me.MatTXT.Name = "MatTXT"
        Me.MatTXT.Size = New System.Drawing.Size(121, 20)
        Me.MatTXT.TabIndex = 7
        '
        'ofTXT
        '
        Me.ofTXT.BackColor = System.Drawing.SystemColors.Control
        Me.ofTXT.Location = New System.Drawing.Point(99, 188)
        Me.ofTXT.Name = "ofTXT"
        Me.ofTXT.Size = New System.Drawing.Size(121, 20)
        Me.ofTXT.TabIndex = 6
        '
        'piTXT
        '
        Me.piTXT.BackColor = System.Drawing.SystemColors.Control
        Me.piTXT.Location = New System.Drawing.Point(99, 153)
        Me.piTXT.Name = "piTXT"
        Me.piTXT.Size = New System.Drawing.Size(121, 20)
        Me.piTXT.TabIndex = 5
        '
        'oc2TXT
        '
        Me.oc2TXT.BackColor = System.Drawing.SystemColors.Control
        Me.oc2TXT.Location = New System.Drawing.Point(99, 120)
        Me.oc2TXT.Name = "oc2TXT"
        Me.oc2TXT.Size = New System.Drawing.Size(121, 20)
        Me.oc2TXT.TabIndex = 4
        '
        'SalidaTXT
        '
        Me.SalidaTXT.BackColor = System.Drawing.SystemColors.Control
        Me.SalidaTXT.Location = New System.Drawing.Point(99, 22)
        Me.SalidaTXT.Name = "SalidaTXT"
        Me.SalidaTXT.Size = New System.Drawing.Size(121, 20)
        Me.SalidaTXT.TabIndex = 1
        '
        'EntradasMaterialTableAdapter
        '
        Me.EntradasMaterialTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Base_ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Base_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.BaseEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EntradasMaterialTableAdapter = Me.EntradasMaterialTableAdapter
        Me.TableAdapterManager.RACKSTableAdapter = Nothing
        Me.TableAdapterManager.SalidasMaterialTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.AlmacenBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'Salidas_MaterialBindingSource
        '
        Me.Salidas_MaterialBindingSource.DataMember = "Salidas_Material"
        Me.Salidas_MaterialBindingSource.DataSource = Me.AlmacenBD
        '
        'SalidasMaterialTableAdapter
        '
        Me.SalidasMaterialTableAdapter.ClearBeforeFill = True
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(52, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(46, 13)
        Me.Label30.TabIndex = 83
        Me.Label30.Text = "Fecha:"
        '
        'MaterialTXT
        '
        Me.MaterialTXT.BackColor = System.Drawing.SystemColors.Control
        Me.MaterialTXT.FormattingEnabled = True
        Me.MaterialTXT.Items.AddRange(New Object() {"ACERO/CARBÓN", "ACERO/GALV.", "ACERO/ALUMINIO", "ACERO/GRANALLADO", "ACERO/DECAPADO", "INOX 304", "INOX 316", "INOX 403", "ALUMINIO"})
        Me.MaterialTXT.Location = New System.Drawing.Point(107, 224)
        Me.MaterialTXT.Name = "MaterialTXT"
        Me.MaterialTXT.Size = New System.Drawing.Size(115, 21)
        Me.MaterialTXT.TabIndex = 84
        '
        'EntradasSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(564, 374)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EntradasSalidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradas y Salidas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Entradas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlmacenBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salidas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CalibreCMX As ComboBox
    Friend WithEvents ClienteCMB As ComboBox
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents noParteTXT As TextBox
    Friend WithEvents ComentarioTXT As TextBox
    Friend WithEvents NivelTXT As TextBox
    Friend WithEvents RackTXT As TextBox
    Friend WithEvents CostokgTXT As TextBox
    Friend WithEvents CostoTXT As TextBox
    Friend WithEvents UnidadTXT As TextBox
    Friend WithEvents AnchoTXT As TextBox
    Friend WithEvents LargoTXT As TextBox
    Friend WithEvents CalidadTXT As TextBox
    Friend WithEvents OCTXT As TextBox
    Friend WithEvents FacturaTXT As TextBox
    Friend WithEvents LoteTXT As TextBox
    Friend WithEvents EntradaTXT As ComboBox
    Friend WithEvents Guardar2BTN As Button
    Friend WithEvents Fecha2TXT As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents MaqTXT As TextBox
    Friend WithEvents CantTXT As TextBox
    Friend WithEvents AutorizaTXT As TextBox
    Friend WithEvents SolicitanteTXT As TextBox
    Friend WithEvents MatTXT As TextBox
    Friend WithEvents ofTXT As TextBox
    Friend WithEvents piTXT As TextBox
    Friend WithEvents oc2TXT As TextBox
    Friend WithEvents SalidaTXT As TextBox
    Friend WithEvents AlmacenBD As AlmacenBD
    Friend WithEvents Entradas_MaterialBindingSource As BindingSource
    Friend WithEvents EntradasMaterialTableAdapter As AlmacenBDTableAdapters.EntradasMaterialTableAdapter
    Friend WithEvents TableAdapterManager As AlmacenBDTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents ClientesTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents Salidas_MaterialBindingSource As BindingSource
    Friend WithEvents SalidasMaterialTableAdapter As AlmacenBDTableAdapters.SalidasMaterialTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label30 As Label
    Friend WithEvents MaterialTXT As ComboBox
End Class
