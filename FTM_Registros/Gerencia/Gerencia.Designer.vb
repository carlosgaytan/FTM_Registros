<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Gerencia
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerencia))
        Me.BuscaVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgresoVentas = New FTM_Registros.ProgresoVentas()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MesLTB = New System.Windows.Forms.ComboBox()
        Me.BuscarBTN = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BuscaVentasTableAdapter = New FTM_Registros.ProgresoVentasTableAdapters.BuscaVentasTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProgresoVentasTableAdapters.TableAdapterManager()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.XventasBTN = New System.Windows.Forms.Button()
        Me.XingenieriaBTN = New System.Windows.Forms.Button()
        Me.XplanBTN = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BuscaVentasBindingSource
        '
        Me.BuscaVentasBindingSource.DataMember = "BuscaVentas"
        Me.BuscaVentasBindingSource.DataSource = Me.ProgresoVentas
        '
        'ProgresoVentas
        '
        Me.ProgresoVentas.DataSetName = "ProgresoVentas"
        Me.ProgresoVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 617)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(149, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(967, 594)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.XventasBTN)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Controls.Add(Me.MesLTB)
        Me.TabPage1.Controls.Add(Me.BuscarBTN)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(959, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource3.Name = "ProgVentas"
        ReportDataSource3.Value = Me.BuscaVentasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FTM_Registros.ProgVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(947, 529)
        Me.ReportViewer1.TabIndex = 7
        '
        'MesLTB
        '
        Me.MesLTB.FormattingEnabled = True
        Me.MesLTB.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesLTB.Location = New System.Drawing.Point(6, 6)
        Me.MesLTB.Name = "MesLTB"
        Me.MesLTB.Size = New System.Drawing.Size(121, 21)
        Me.MesLTB.TabIndex = 5
        '
        'BuscarBTN
        '
        Me.BuscarBTN.Location = New System.Drawing.Point(149, 4)
        Me.BuscarBTN.Name = "BuscarBTN"
        Me.BuscarBTN.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBTN.TabIndex = 6
        Me.BuscarBTN.Text = "Buscar"
        Me.ToolTip1.SetToolTip(Me.BuscarBTN, "Busca registros según mes seleccionado")
        Me.BuscarBTN.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.XingenieriaBTN)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(959, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ingeniería"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BuscaVentasTableAdapter
        '
        Me.BuscaVentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BuscaVentasTableAdapter = Me.BuscaVentasTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.ProgresoVentasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.XplanBTN)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(959, 568)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Planeación/Cont. Proyect."
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.Everflux_icon_icons_com_53727
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(30, 448)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 75)
        Me.Button5.TabIndex = 7
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button5, "Progreso Planeación/Control de Proyectos")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(30, 285)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 75)
        Me.Button4.TabIndex = 6
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button4, "Progreso Ingeniería")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.coins_icon_31839
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(30, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 75)
        Me.Button2.TabIndex = 5
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.Button2, "Progreso Ventas")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Ventas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Ingeniería"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 526)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Planeación" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control de Proyectos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'XventasBTN
        '
        Me.XventasBTN.BackgroundImage = CType(resources.GetObject("XventasBTN.BackgroundImage"), System.Drawing.Image)
        Me.XventasBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.XventasBTN.Location = New System.Drawing.Point(931, 3)
        Me.XventasBTN.Name = "XventasBTN"
        Me.XventasBTN.Size = New System.Drawing.Size(25, 25)
        Me.XventasBTN.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.XventasBTN, "Cerrar Tabla")
        Me.XventasBTN.UseVisualStyleBackColor = True
        '
        'XingenieriaBTN
        '
        Me.XingenieriaBTN.BackgroundImage = CType(resources.GetObject("XingenieriaBTN.BackgroundImage"), System.Drawing.Image)
        Me.XingenieriaBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.XingenieriaBTN.Location = New System.Drawing.Point(931, 3)
        Me.XingenieriaBTN.Name = "XingenieriaBTN"
        Me.XingenieriaBTN.Size = New System.Drawing.Size(25, 25)
        Me.XingenieriaBTN.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.XingenieriaBTN, "Cerrar Tabla")
        Me.XingenieriaBTN.UseVisualStyleBackColor = True
        '
        'XplanBTN
        '
        Me.XplanBTN.BackgroundImage = CType(resources.GetObject("XplanBTN.BackgroundImage"), System.Drawing.Image)
        Me.XplanBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.XplanBTN.Location = New System.Drawing.Point(931, 3)
        Me.XplanBTN.Name = "XplanBTN"
        Me.XplanBTN.Size = New System.Drawing.Size(25, 25)
        Me.XplanBTN.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.XplanBTN, "Cerrar Tabla")
        Me.XplanBTN.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 64)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Progreso" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "áreas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Gerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1127, 618)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1143, 656)
        Me.MinimumSize = New System.Drawing.Size(1143, 656)
        Me.Name = "Gerencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerencia"
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MesLTB As ComboBox
    Friend WithEvents BuscarBTN As Button
    Friend WithEvents ProgresoVentas As ProgresoVentas
    Friend WithEvents BuscaVentasBindingSource As BindingSource
    Friend WithEvents BuscaVentasTableAdapter As ProgresoVentasTableAdapters.BuscaVentasTableAdapter
    Friend WithEvents TableAdapterManager As ProgresoVentasTableAdapters.TableAdapterManager
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents XventasBTN As Button
    Friend WithEvents XingenieriaBTN As Button
    Friend WithEvents XplanBTN As Button
    Friend WithEvents Label4 As Label
End Class
