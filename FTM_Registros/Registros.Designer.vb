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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Publicar = New System.Windows.Forms.Button()
        Me._Base_de_datos_1_4_beDataSet = New FTM_Registros._Base_de_datos_1_4_beDataSet()
        Me.TblUsuarioActivoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblUsuarioActivoTableAdapter = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter()
        Me.TableAdapterManager = New FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager()
        Me.Iniciobtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.company_22169
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(51, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 107)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Gerencia"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button1, "Información Gerencia")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.coins_icon_31839
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(51, 172)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 107)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ventas"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Herramientas de Ventas")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(51, 344)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 107)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Ingeniería"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Herramientas de Ingeniería")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Everflux_icon_icons_com_53727
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(51, 530)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 107)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Planeación"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Herramientas de Planeación")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(574, 120)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(513, 63)
        Me.RichTextBox1.TabIndex = 5
        Me.RichTextBox1.Text = ""
        '
        'ListBox1
        '
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(574, 241)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(513, 368)
        Me.ListBox1.TabIndex = 6
        '
        'Publicar
        '
        Me.Publicar.Location = New System.Drawing.Point(1023, 189)
        Me.Publicar.Name = "Publicar"
        Me.Publicar.Size = New System.Drawing.Size(64, 25)
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
        Me.Iniciobtn.Location = New System.Drawing.Point(1023, 12)
        Me.Iniciobtn.Name = "Iniciobtn"
        Me.Iniciobtn.Size = New System.Drawing.Size(67, 55)
        Me.Iniciobtn.TabIndex = 10
        Me.Iniciobtn.Text = "Cambiar Usuario"
        Me.Iniciobtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Iniciobtn, "Cambiar de usuario")
        Me.Iniciobtn.UseVisualStyleBackColor = True
        '
        'Registros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1110, 661)
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
        Me.Name = "Registros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FTM Registros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblUsuarioActivoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Public WithEvents ListBox1 As ListBox
    Friend WithEvents Publicar As Button
    Friend WithEvents _Base_de_datos_1_4_beDataSet As _Base_de_datos_1_4_beDataSet
    Friend WithEvents TblUsuarioActivoBindingSource As BindingSource
    Friend WithEvents TblUsuarioActivoTableAdapter As _Base_de_datos_1_4_beDataSetTableAdapters.tblUsuarioActivoTableAdapter
    Friend WithEvents TableAdapterManager As _Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Iniciobtn As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
