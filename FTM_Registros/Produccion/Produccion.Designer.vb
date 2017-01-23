<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Produccion
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Produccion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MesBTN = New System.Windows.Forms.Button()
        Me.YearCBX = New System.Windows.Forms.ComboBox()
        Me.MesCBX = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.invmpBTN = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Registros_DoblezBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoblezBD1 = New FTM_Registros.DoblezBD1()
        Me.Registros_DoblezTableAdapter = New FTM_Registros.DoblezBD1TableAdapters.Registros_DoblezTableAdapter()
        Me.TableAdapterManager1 = New FTM_Registros.DoblezBD1TableAdapters.TableAdapterManager()
        Me.RegistrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduccionBD = New FTM_Registros.ProduccionBD()
        Me.RegistrosTableAdapter = New FTM_Registros.ProduccionBDTableAdapters.RegistrosTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProduccionBDTableAdapters.TableAdapterManager()
        Me.RegistrosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.Registros_DoblezBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoblezBD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MesBTN)
        Me.Panel1.Controls.Add(Me.YearCBX)
        Me.Panel1.Controls.Add(Me.MesCBX)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.invmpBTN)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 633)
        Me.Panel1.TabIndex = 0
        '
        'MesBTN
        '
        Me.MesBTN.Location = New System.Drawing.Point(53, 389)
        Me.MesBTN.Name = "MesBTN"
        Me.MesBTN.Size = New System.Drawing.Size(75, 23)
        Me.MesBTN.TabIndex = 2
        Me.MesBTN.Text = "Buscar"
        Me.MesBTN.UseVisualStyleBackColor = True
        '
        'YearCBX
        '
        Me.YearCBX.FormattingEnabled = True
        Me.YearCBX.Location = New System.Drawing.Point(29, 335)
        Me.YearCBX.Name = "YearCBX"
        Me.YearCBX.Size = New System.Drawing.Size(124, 21)
        Me.YearCBX.TabIndex = 3
        '
        'MesCBX
        '
        Me.MesCBX.FormattingEnabled = True
        Me.MesCBX.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesCBX.Location = New System.Drawing.Point(29, 362)
        Me.MesCBX.Name = "MesCBX"
        Me.MesCBX.Size = New System.Drawing.Size(124, 21)
        Me.MesCBX.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.edit_22164
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(53, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 75)
        Me.Button1.TabIndex = 26
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.Button1, "Registro Reportes de Producción")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 54)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Procesos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'invmpBTN
        '
        Me.invmpBTN.BackgroundImage = Global.FTM_Registros.My.Resources.Resources.edit_22164
        Me.invmpBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.invmpBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invmpBTN.ForeColor = System.Drawing.Color.Black
        Me.invmpBTN.Location = New System.Drawing.Point(53, 89)
        Me.invmpBTN.Name = "invmpBTN"
        Me.invmpBTN.Size = New System.Drawing.Size(75, 75)
        Me.invmpBTN.TabIndex = 24
        Me.invmpBTN.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.ToolTip1.SetToolTip(Me.invmpBTN, "Registro Reportes de Producción")
        Me.invmpBTN.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ReportViewer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1170, 583)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Indicadores Semanales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "FTM_Registros.R_Semanal.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.Size = New System.Drawing.Size(1164, 577)
        Me.ReportViewer2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1170, 583)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Indicadores Mensuales"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "LaserBD"
        ReportDataSource1.Value = Me.RegistrosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FTM_Registros.R_Mensual1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 46)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1164, 534)
        Me.ReportViewer1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(186, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1178, 609)
        Me.TabControl1.TabIndex = 1
        '
        'Registros_DoblezBindingSource
        '
        Me.Registros_DoblezBindingSource.DataMember = "Registros_Doblez"
        Me.Registros_DoblezBindingSource.DataSource = Me.DoblezBD1
        '
        'DoblezBD1
        '
        Me.DoblezBD1.DataSetName = "DoblezBD1"
        Me.DoblezBD1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Registros_DoblezTableAdapter
        '
        Me.Registros_DoblezTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Registros_DoblezTableAdapter = Me.Registros_DoblezTableAdapter
        Me.TableAdapterManager1.UpdateOrder = FTM_Registros.DoblezBD1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrosBindingSource
        '
        Me.RegistrosBindingSource.DataMember = "Registros"
        Me.RegistrosBindingSource.DataSource = Me.ProduccionBD
        '
        'ProduccionBD
        '
        Me.ProduccionBD.DataSetName = "ProduccionBD"
        Me.ProduccionBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegistrosTableAdapter
        '
        Me.RegistrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Registros_DoblezTableAdapter = Nothing
        Me.TableAdapterManager.Registros_MaquinadosTableAdapter = Nothing
        Me.TableAdapterManager.Registros_PunzonadoTableAdapter = Nothing
        Me.TableAdapterManager.RegistrosTableAdapter = Me.RegistrosTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.ProduccionBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RegistrosBindingSource1
        '
        Me.RegistrosBindingSource1.DataMember = "Registros"
        Me.RegistrosBindingSource1.DataSource = Me.ProduccionBD
        '
        'Produccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1376, 633)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Produccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Producción"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        CType(Me.Registros_DoblezBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoblezBD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ProduccionBD As ProduccionBD
    Friend WithEvents RegistrosBindingSource As BindingSource
    Friend WithEvents RegistrosTableAdapter As ProduccionBDTableAdapters.RegistrosTableAdapter
    Friend WithEvents TableAdapterManager As ProduccionBDTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As Panel
    Friend WithEvents invmpBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
    Friend WithEvents MesBTN As Button
    Friend WithEvents MesCBX As ComboBox
    Friend WithEvents YearCBX As ComboBox
    Friend WithEvents RegistrosBindingSource1 As BindingSource
    Friend WithEvents DoblezBD1 As DoblezBD1
    Friend WithEvents Registros_DoblezBindingSource As BindingSource
    Friend WithEvents Registros_DoblezTableAdapter As DoblezBD1TableAdapters.Registros_DoblezTableAdapter
    Friend WithEvents TableAdapterManager1 As DoblezBD1TableAdapters.TableAdapterManager
End Class
