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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gerencia))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Ventas = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BuscaVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProgresoVentas = New FTM_Registros.ProgresoVentas()
        Me.MesLTB = New System.Windows.Forms.ComboBox()
        Me.BuscarBTN = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BuscaVentasTableAdapter = New FTM_Registros.ProgresoVentasTableAdapters.BuscaVentasTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProgresoVentasTableAdapters.TableAdapterManager()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Ventas)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 617)
        Me.Panel1.TabIndex = 0
        '
        'Ventas
        '
        Me.Ventas.Location = New System.Drawing.Point(27, 55)
        Me.Ventas.Name = "Ventas"
        Me.Ventas.Size = New System.Drawing.Size(75, 23)
        Me.Ventas.TabIndex = 0
        Me.Ventas.Text = "Ventas"
        Me.Ventas.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(148, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(854, 594)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Controls.Add(Me.MesLTB)
        Me.TabPage1.Controls.Add(Me.BuscarBTN)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(846, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
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
        Me.BuscarBTN.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(846, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "ProgVentas"
        ReportDataSource1.Value = Me.BuscaVentasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FTM_Registros.ProgVentas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(834, 529)
        Me.ReportViewer1.TabIndex = 7
        '
        'Gerencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1014, 618)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gerencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gerencia"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Ventas As Button
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
End Class
