﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registros))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Publicar = New System.Windows.Forms.Button()
        Me.Iniciobtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GerenciaBTN = New System.Windows.Forms.Button()
        Me.VentasBTN = New System.Windows.Forms.Button()
        Me.IngenieriaBTN = New System.Windows.Forms.Button()
        Me.PlaneacionBTN = New System.Windows.Forms.Button()
        Me.ContProyectBTN = New System.Windows.Forms.Button()
        Me.AlmacenBTN = New System.Windows.Forms.Button()
        Me.ProducBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.InfoGerencia = New System.Windows.Forms.TextBox()
        Me.InfoVentas = New System.Windows.Forms.TextBox()
        Me.InfoIngenieria = New System.Windows.Forms.TextBox()
        Me.InfoPlaneacion = New System.Windows.Forms.TextBox()
        Me.InfoControl = New System.Windows.Forms.TextBox()
        Me.GerenciaCHBX = New System.Windows.Forms.CheckBox()
        Me.UsuariosPermisosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.VentasCHBX = New System.Windows.Forms.CheckBox()
        Me.IngenieriaCHBX = New System.Windows.Forms.CheckBox()
        Me.ControlCHBX = New System.Windows.Forms.CheckBox()
        Me.PlaneacionCHBX = New System.Windows.Forms.CheckBox()
        Me.RegistrosCHBX = New System.Windows.Forms.CheckBox()
        Me.UsuariosPermisosTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.UsuariosPermisosTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.baseFSW = New System.IO.FileSystemWatcher()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.CotizacionesFSW = New System.IO.FileSystemWatcher()
        Me.InfoAlmacen = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AlmacenCBX = New System.Windows.Forms.CheckBox()
        Me.InfoPorduc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProduccionCHBX = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.UsuariosPermisosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baseFSW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesFSW, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(681, 79)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(687, 53)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(681, 169)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(687, 316)
        Me.ListBox1.TabIndex = 6
        '
        'Publicar
        '
        Me.Publicar.Location = New System.Drawing.Point(1289, 138)
        Me.Publicar.Name = "Publicar"
        Me.Publicar.Size = New System.Drawing.Size(79, 25)
        Me.Publicar.TabIndex = 7
        Me.Publicar.Text = "Publicar"
        Me.Publicar.UseVisualStyleBackColor = True
        '
        'Iniciobtn
        '
        Me.Iniciobtn.BackgroundImage = CType(resources.GetObject("Iniciobtn.BackgroundImage"), System.Drawing.Image)
        Me.Iniciobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Iniciobtn.Image = CType(resources.GetObject("Iniciobtn.Image"), System.Drawing.Image)
        Me.Iniciobtn.Location = New System.Drawing.Point(1525, 12)
        Me.Iniciobtn.Name = "Iniciobtn"
        Me.Iniciobtn.Size = New System.Drawing.Size(60, 60)
        Me.Iniciobtn.TabIndex = 10
        Me.Iniciobtn.Text = "Cerrar sesión"
        Me.Iniciobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Iniciobtn, "Cambiar de usuario")
        Me.Iniciobtn.UseVisualStyleBackColor = True
        '
        'GerenciaBTN
        '
        Me.GerenciaBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.company_22169
        Me.GerenciaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GerenciaBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GerenciaBTN.Location = New System.Drawing.Point(26, 44)
        Me.GerenciaBTN.Name = "GerenciaBTN"
        Me.GerenciaBTN.Size = New System.Drawing.Size(90, 90)
        Me.GerenciaBTN.TabIndex = 0
        Me.GerenciaBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.GerenciaBTN, "Gerencia")
        Me.GerenciaBTN.UseVisualStyleBackColor = True
        '
        'VentasBTN
        '
        Me.VentasBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.coins_icon_31839
        Me.VentasBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VentasBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VentasBTN.Location = New System.Drawing.Point(26, 164)
        Me.VentasBTN.Name = "VentasBTN"
        Me.VentasBTN.Size = New System.Drawing.Size(90, 90)
        Me.VentasBTN.TabIndex = 1
        Me.VentasBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.VentasBTN, "Ventas")
        Me.VentasBTN.UseVisualStyleBackColor = True
        '
        'IngenieriaBTN
        '
        Me.IngenieriaBTN.BackgroundImage = CType(resources.GetObject("IngenieriaBTN.BackgroundImage"), System.Drawing.Image)
        Me.IngenieriaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IngenieriaBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.IngenieriaBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IngenieriaBTN.Location = New System.Drawing.Point(26, 286)
        Me.IngenieriaBTN.Name = "IngenieriaBTN"
        Me.IngenieriaBTN.Size = New System.Drawing.Size(90, 90)
        Me.IngenieriaBTN.TabIndex = 3
        Me.IngenieriaBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.IngenieriaBTN, "Ingeniería")
        Me.IngenieriaBTN.UseVisualStyleBackColor = True
        '
        'PlaneacionBTN
        '
        Me.PlaneacionBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Everflux_icon_icons_com_53727
        Me.PlaneacionBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PlaneacionBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaneacionBTN.Location = New System.Drawing.Point(26, 409)
        Me.PlaneacionBTN.Name = "PlaneacionBTN"
        Me.PlaneacionBTN.Size = New System.Drawing.Size(90, 90)
        Me.PlaneacionBTN.TabIndex = 4
        Me.PlaneacionBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.PlaneacionBTN, "Planeación")
        Me.PlaneacionBTN.UseVisualStyleBackColor = True
        '
        'ContProyectBTN
        '
        Me.ContProyectBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Inbound_Link_icon_icons_com_53738
        Me.ContProyectBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContProyectBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContProyectBTN.Location = New System.Drawing.Point(26, 531)
        Me.ContProyectBTN.Name = "ContProyectBTN"
        Me.ContProyectBTN.Size = New System.Drawing.Size(90, 90)
        Me.ContProyectBTN.TabIndex = 11
        Me.ContProyectBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.ContProyectBTN, "Control de Proyectos")
        Me.ContProyectBTN.UseVisualStyleBackColor = True
        '
        'AlmacenBTN
        '
        Me.AlmacenBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.shipping_products_22121
        Me.AlmacenBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AlmacenBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmacenBTN.Location = New System.Drawing.Point(359, 163)
        Me.AlmacenBTN.Name = "AlmacenBTN"
        Me.AlmacenBTN.Size = New System.Drawing.Size(90, 90)
        Me.AlmacenBTN.TabIndex = 30
        Me.AlmacenBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.AlmacenBTN, "Almacén")
        Me.AlmacenBTN.UseVisualStyleBackColor = True
        '
        'ProducBTN
        '
        Me.ProducBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.production_22132
        Me.ProducBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProducBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProducBTN.Location = New System.Drawing.Point(359, 43)
        Me.ProducBTN.Name = "ProducBTN"
        Me.ProducBTN.Size = New System.Drawing.Size(90, 90)
        Me.ProducBTN.TabIndex = 34
        Me.ProducBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.ProducBTN, "Producción")
        Me.ProducBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Gerencia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Ventas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(29, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Ingeniería"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 500)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Planeación"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(28, 622)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 38)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Contol" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Proyectos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InfoGerencia
        '
        Me.InfoGerencia.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoGerencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoGerencia.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoGerencia.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGerencia.ForeColor = System.Drawing.Color.Black
        Me.InfoGerencia.Location = New System.Drawing.Point(114, 45)
        Me.InfoGerencia.Multiline = True
        Me.InfoGerencia.Name = "InfoGerencia"
        Me.InfoGerencia.ReadOnly = True
        Me.InfoGerencia.Size = New System.Drawing.Size(190, 88)
        Me.InfoGerencia.TabIndex = 17
        Me.InfoGerencia.Text = "Herramientas para control y/o seguimiento de áreas Productivas y Administrativas " &
    "en FTM"
        Me.InfoGerencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoGerencia.Visible = False
        '
        'InfoVentas
        '
        Me.InfoVentas.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoVentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoVentas.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoVentas.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoVentas.ForeColor = System.Drawing.Color.Black
        Me.InfoVentas.Location = New System.Drawing.Point(114, 165)
        Me.InfoVentas.Multiline = True
        Me.InfoVentas.Name = "InfoVentas"
        Me.InfoVentas.ReadOnly = True
        Me.InfoVentas.Size = New System.Drawing.Size(190, 88)
        Me.InfoVentas.TabIndex = 18
        Me.InfoVentas.Text = "Herramientas correspondientes al área: Control de clientes, Generador de ordenes " &
    "a cotizar, Cotizador, Generador de cotizaciones."
        Me.InfoVentas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoVentas.Visible = False
        '
        'InfoIngenieria
        '
        Me.InfoIngenieria.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoIngenieria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoIngenieria.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoIngenieria.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoIngenieria.ForeColor = System.Drawing.Color.Black
        Me.InfoIngenieria.Location = New System.Drawing.Point(114, 287)
        Me.InfoIngenieria.Multiline = True
        Me.InfoIngenieria.Name = "InfoIngenieria"
        Me.InfoIngenieria.ReadOnly = True
        Me.InfoIngenieria.Size = New System.Drawing.Size(190, 88)
        Me.InfoIngenieria.TabIndex = 19
        Me.InfoIngenieria.Text = "Herramientas área de ingeniería: Generador de control de planos"
        Me.InfoIngenieria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoIngenieria.Visible = False
        '
        'InfoPlaneacion
        '
        Me.InfoPlaneacion.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoPlaneacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoPlaneacion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoPlaneacion.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoPlaneacion.ForeColor = System.Drawing.Color.Black
        Me.InfoPlaneacion.Location = New System.Drawing.Point(114, 410)
        Me.InfoPlaneacion.Multiline = True
        Me.InfoPlaneacion.Name = "InfoPlaneacion"
        Me.InfoPlaneacion.ReadOnly = True
        Me.InfoPlaneacion.Size = New System.Drawing.Size(190, 88)
        Me.InfoPlaneacion.TabIndex = 20
        Me.InfoPlaneacion.Text = "Herramientas área de Planeación:"
        Me.InfoPlaneacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoPlaneacion.Visible = False
        '
        'InfoControl
        '
        Me.InfoControl.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoControl.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoControl.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoControl.ForeColor = System.Drawing.Color.Black
        Me.InfoControl.Location = New System.Drawing.Point(114, 532)
        Me.InfoControl.Multiline = True
        Me.InfoControl.Name = "InfoControl"
        Me.InfoControl.ReadOnly = True
        Me.InfoControl.Size = New System.Drawing.Size(190, 88)
        Me.InfoControl.TabIndex = 21
        Me.InfoControl.Text = "Herramientas área de control de proyectos:"
        Me.InfoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoControl.Visible = False
        '
        'GerenciaCHBX
        '
        Me.GerenciaCHBX.AutoSize = True
        Me.GerenciaCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Gerencia", True))
        Me.GerenciaCHBX.Location = New System.Drawing.Point(728, 208)
        Me.GerenciaCHBX.Name = "GerenciaCHBX"
        Me.GerenciaCHBX.Size = New System.Drawing.Size(69, 17)
        Me.GerenciaCHBX.TabIndex = 23
        Me.GerenciaCHBX.Text = "Gerencia"
        Me.GerenciaCHBX.UseVisualStyleBackColor = True
        '
        'UsuariosPermisosBindingSource
        '
        Me.UsuariosPermisosBindingSource.DataMember = "UsuariosPermisos"
        Me.UsuariosPermisosBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasCHBX
        '
        Me.VentasCHBX.AutoSize = True
        Me.VentasCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Ventas", True))
        Me.VentasCHBX.Location = New System.Drawing.Point(728, 231)
        Me.VentasCHBX.Name = "VentasCHBX"
        Me.VentasCHBX.Size = New System.Drawing.Size(59, 17)
        Me.VentasCHBX.TabIndex = 24
        Me.VentasCHBX.Text = "Ventas"
        Me.VentasCHBX.UseVisualStyleBackColor = True
        '
        'IngenieriaCHBX
        '
        Me.IngenieriaCHBX.AutoSize = True
        Me.IngenieriaCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Ingenieria", True))
        Me.IngenieriaCHBX.Location = New System.Drawing.Point(728, 254)
        Me.IngenieriaCHBX.Name = "IngenieriaCHBX"
        Me.IngenieriaCHBX.Size = New System.Drawing.Size(74, 17)
        Me.IngenieriaCHBX.TabIndex = 25
        Me.IngenieriaCHBX.Text = "Ingeniería"
        Me.IngenieriaCHBX.UseVisualStyleBackColor = True
        '
        'ControlCHBX
        '
        Me.ControlCHBX.AutoSize = True
        Me.ControlCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "ContProyect", True))
        Me.ControlCHBX.Location = New System.Drawing.Point(728, 277)
        Me.ControlCHBX.Name = "ControlCHBX"
        Me.ControlCHBX.Size = New System.Drawing.Size(124, 17)
        Me.ControlCHBX.TabIndex = 26
        Me.ControlCHBX.Text = "Control de Proyectos"
        Me.ControlCHBX.UseVisualStyleBackColor = True
        '
        'PlaneacionCHBX
        '
        Me.PlaneacionCHBX.AutoSize = True
        Me.PlaneacionCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Planeacion", True))
        Me.PlaneacionCHBX.Location = New System.Drawing.Point(728, 300)
        Me.PlaneacionCHBX.Name = "PlaneacionCHBX"
        Me.PlaneacionCHBX.Size = New System.Drawing.Size(79, 17)
        Me.PlaneacionCHBX.TabIndex = 27
        Me.PlaneacionCHBX.Text = "Planeación"
        Me.PlaneacionCHBX.UseVisualStyleBackColor = True
        '
        'RegistrosCHBX
        '
        Me.RegistrosCHBX.AutoSize = True
        Me.RegistrosCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Registros", True))
        Me.RegistrosCHBX.Location = New System.Drawing.Point(728, 323)
        Me.RegistrosCHBX.Name = "RegistrosCHBX"
        Me.RegistrosCHBX.Size = New System.Drawing.Size(70, 17)
        Me.RegistrosCHBX.TabIndex = 28
        Me.RegistrosCHBX.Text = "Registros"
        Me.RegistrosCHBX.UseVisualStyleBackColor = True
        '
        'UsuariosPermisosTableAdapter
        '
        Me.UsuariosPermisosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.UsuariosPermisosTableAdapter = Me.UsuariosPermisosTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UsuariosPermisosBindingSource
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(728, 181)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 29
        '
        'baseFSW
        '
        Me.baseFSW.EnableRaisingEvents = True
        Me.baseFSW.Filter = "*.accdb"
        Me.baseFSW.NotifyFilter = CType((((System.IO.NotifyFilters.FileName Or System.IO.NotifyFilters.DirectoryName) _
            Or System.IO.NotifyFilters.Size) _
            Or System.IO.NotifyFilters.LastWrite), System.IO.NotifyFilters)
        Me.baseFSW.Path = "S:\Base de datos\Base"
        Me.baseFSW.SynchronizingObject = Me
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'CotizacionesFSW
        '
        Me.CotizacionesFSW.EnableRaisingEvents = True
        Me.CotizacionesFSW.Path = "S:\Base de datos\Cotizaciones"
        Me.CotizacionesFSW.SynchronizingObject = Me
        '
        'InfoAlmacen
        '
        Me.InfoAlmacen.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoAlmacen.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoAlmacen.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoAlmacen.ForeColor = System.Drawing.Color.Black
        Me.InfoAlmacen.Location = New System.Drawing.Point(447, 164)
        Me.InfoAlmacen.Multiline = True
        Me.InfoAlmacen.Name = "InfoAlmacen"
        Me.InfoAlmacen.ReadOnly = True
        Me.InfoAlmacen.Size = New System.Drawing.Size(190, 88)
        Me.InfoAlmacen.TabIndex = 32
        Me.InfoAlmacen.Text = "Herramientas correspondientes al área de Almacen: Control de personal y Control d" &
    "e inventarios"
        Me.InfoAlmacen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoAlmacen.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(365, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Almacén"
        '
        'AlmacenCBX
        '
        Me.AlmacenCBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Almacen", True))
        Me.AlmacenCBX.Location = New System.Drawing.Point(728, 372)
        Me.AlmacenCBX.Name = "AlmacenCBX"
        Me.AlmacenCBX.Size = New System.Drawing.Size(104, 24)
        Me.AlmacenCBX.TabIndex = 33
        Me.AlmacenCBX.Text = "Almacén"
        Me.AlmacenCBX.UseVisualStyleBackColor = True
        '
        'InfoPorduc
        '
        Me.InfoPorduc.BackColor = System.Drawing.Color.Gainsboro
        Me.InfoPorduc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InfoPorduc.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.InfoPorduc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoPorduc.ForeColor = System.Drawing.Color.Black
        Me.InfoPorduc.Location = New System.Drawing.Point(447, 44)
        Me.InfoPorduc.Multiline = True
        Me.InfoPorduc.Name = "InfoPorduc"
        Me.InfoPorduc.ReadOnly = True
        Me.InfoPorduc.Size = New System.Drawing.Size(190, 88)
        Me.InfoPorduc.TabIndex = 36
        Me.InfoPorduc.Text = "Herramientas correspondientes al área de Producción: Indicadores producción."
        Me.InfoPorduc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoPorduc.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(355, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Producción"
        '
        'ProduccionCHBX
        '
        Me.ProduccionCHBX.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.UsuariosPermisosBindingSource, "Almacen", True))
        Me.ProduccionCHBX.Location = New System.Drawing.Point(728, 342)
        Me.ProduccionCHBX.Name = "ProduccionCHBX"
        Me.ProduccionCHBX.Size = New System.Drawing.Size(104, 24)
        Me.ProduccionCHBX.TabIndex = 37
        Me.ProduccionCHBX.Text = "Producción"
        Me.ProduccionCHBX.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(1416, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(176, 119)
        Me.Panel1.TabIndex = 38
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Tipo de cambio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Dolar (USD):"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Euro (EUR):"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Yen (YPN):"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(90, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Label13"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(90, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Label14"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(90, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Label15"
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ProduccionCHBX)
        Me.Controls.Add(Me.InfoPorduc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProducBTN)
        Me.Controls.Add(Me.AlmacenCBX)
        Me.Controls.Add(Me.InfoAlmacen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AlmacenBTN)
        Me.Controls.Add(Me.InfoControl)
        Me.Controls.Add(Me.InfoPlaneacion)
        Me.Controls.Add(Me.InfoIngenieria)
        Me.Controls.Add(Me.InfoVentas)
        Me.Controls.Add(Me.InfoGerencia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ContProyectBTN)
        Me.Controls.Add(Me.Iniciobtn)
        Me.Controls.Add(Me.Publicar)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.PlaneacionBTN)
        Me.Controls.Add(Me.IngenieriaBTN)
        Me.Controls.Add(Me.VentasBTN)
        Me.Controls.Add(Me.GerenciaBTN)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RegistrosCHBX)
        Me.Controls.Add(Me.PlaneacionCHBX)
        Me.Controls.Add(Me.ControlCHBX)
        Me.Controls.Add(Me.IngenieriaCHBX)
        Me.Controls.Add(Me.VentasCHBX)
        Me.Controls.Add(Me.GerenciaCHBX)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1598, 858)
        Me.Name = "Registros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTM Registros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UsuariosPermisosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baseFSW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CotizacionesFSW, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Public WithEvents ListBox1 As ListBox
    Friend WithEvents Publicar As Button
    Friend WithEvents Iniciobtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents GerenciaBTN As Button
    Friend WithEvents VentasBTN As Button
    Friend WithEvents IngenieriaBTN As Button
    Friend WithEvents PlaneacionBTN As Button
    Friend WithEvents ContProyectBTN As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents InfoGerencia As TextBox
    Friend WithEvents InfoVentas As TextBox
    Friend WithEvents InfoIngenieria As TextBox
    Friend WithEvents InfoPlaneacion As TextBox
    Friend WithEvents InfoControl As TextBox
    Friend WithEvents GerenciaCHBX As CheckBox
    Friend WithEvents VentasCHBX As CheckBox
    Friend WithEvents IngenieriaCHBX As CheckBox
    Friend WithEvents ControlCHBX As CheckBox
    Friend WithEvents PlaneacionCHBX As CheckBox
    Friend WithEvents RegistrosCHBX As CheckBox
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents UsuariosPermisosBindingSource As BindingSource
    Friend WithEvents UsuariosPermisosTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.UsuariosPermisosTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents baseFSW As IO.FileSystemWatcher
    Friend WithEvents CotizacionesFSW As IO.FileSystemWatcher
    Friend WithEvents InfoAlmacen As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents AlmacenBTN As Button
    Friend WithEvents AlmacenCBX As CheckBox
    Friend WithEvents InfoPorduc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ProducBTN As Button
    Friend WithEvents ProduccionCHBX As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
