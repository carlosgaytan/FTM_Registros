<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.TblUsuarioActivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuarioActivoTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.Iniciobtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ContProyectBTN = New System.Windows.Forms.Button()
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
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(716, 81)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(687, 53)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(716, 171)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(687, 316)
        Me.ListBox1.TabIndex = 6
        '
        'Publicar
        '
        Me.Publicar.Location = New System.Drawing.Point(1324, 140)
        Me.Publicar.Name = "Publicar"
        Me.Publicar.Size = New System.Drawing.Size(79, 25)
        Me.Publicar.TabIndex = 7
        Me.Publicar.Text = "Publicar"
        Me.Publicar.UseVisualStyleBackColor = True
        '
        '_Base_de_datos_1_4_beDataSet
        '
        Me._Base_de_datos_1_4_beDataSet.DataSetName = "_Base_de_datos_1_4_beDataSet"
        Me._Base_de_datos_1_4_beDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblUsuarioActivoBindingSource
        '
        Me.TblUsuarioActivoBindingSource.DataMember = "tblUsuarioActivo"
        Me.TblUsuarioActivoBindingSource.DataSource = Me._Base_de_datos_1_4_beDataSet
        '
        'TblUsuarioActivoTableAdapter
        '
        Me.TblUsuarioActivoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.CotizacionesTableAdapter = Nothing
        Me.TableAdapterManager.ManufacturaTableAdapter = Nothing
        Me.TableAdapterManager.tblAdministradorTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuarioActivoTableAdapter = Me.TblUsuarioActivoTableAdapter
        Me.TableAdapterManager.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Nothing
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
        'Button1
        '
        Me.Button1.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.company_22169
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(117, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Información Gerencia")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.coins_icon_31839
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(117, 148)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 90)
        Me.Button2.TabIndex = 1
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Ventas")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(117, 270)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 90)
        Me.Button4.TabIndex = 3
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Ingeniería")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Everflux_icon_icons_com_53727
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(117, 393)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 90)
        Me.Button5.TabIndex = 4
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Planeación")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ContProyectBTN
        '
        Me.ContProyectBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Inbound_Link_icon_icons_com_53738
        Me.ContProyectBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContProyectBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContProyectBTN.Location = New System.Drawing.Point(117, 515)
        Me.ContProyectBTN.Name = "ContProyectBTN"
        Me.ContProyectBTN.Size = New System.Drawing.Size(90, 90)
        Me.ContProyectBTN.TabIndex = 11
        Me.ContProyectBTN.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.ContProyectBTN, "Control de Proyectos")
        Me.ContProyectBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 119)
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
        Me.Label2.Location = New System.Drawing.Point(133, 239)
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
        Me.Label3.Location = New System.Drawing.Point(120, 361)
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
        Me.Label4.Location = New System.Drawing.Point(115, 484)
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
        Me.Label5.Location = New System.Drawing.Point(119, 606)
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
        Me.InfoGerencia.Location = New System.Drawing.Point(205, 29)
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
        Me.InfoVentas.Location = New System.Drawing.Point(205, 149)
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
        Me.InfoIngenieria.Location = New System.Drawing.Point(205, 271)
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
        Me.InfoPlaneacion.Location = New System.Drawing.Point(205, 394)
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
        Me.InfoControl.Location = New System.Drawing.Point(205, 516)
        Me.InfoControl.Multiline = True
        Me.InfoControl.Name = "InfoControl"
        Me.InfoControl.ReadOnly = True
        Me.InfoControl.Size = New System.Drawing.Size(190, 88)
        Me.InfoControl.TabIndex = 21
        Me.InfoControl.Text = "Herramientas área de control de proyectos:"
        Me.InfoControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.InfoControl.Visible = False
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1604, 882)
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
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1598, 858)
        Me.Name = "Registros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTM Registros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As RichTextBox
    Public WithEvents ListBox1 As ListBox
    Friend WithEvents Publicar As Button
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents TblUsuarioActivoBindingSource As BindingSource
    Friend WithEvents TblUsuarioActivoTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Iniciobtn As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
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
End Class
