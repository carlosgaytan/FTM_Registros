<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingenieria
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingenieria))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Control_Planos = New FTM_Registros.Control_Planos()
        Me.BuscarCotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarCotTableAdapter = New FTM_Registros.Control_PlanosTableAdapters.BuscarCotTableAdapter()
        Me.BuscCotCNBX = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BuscarBTN = New System.Windows.Forms.Button()
        Me.DescarcarNumCor = New FTM_Registros.DescarcarNumCor()
        Me.NumCotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NumCotTableAdapter = New FTM_Registros.DescarcarNumCorTableAdapters.NumCotTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.Control_Planos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarCotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DescarcarNumCor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumCotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(175, 642)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procesos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingeniería"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Control_Planos
        '
        Me.Control_Planos.DataSetName = "Control_Planos"
        Me.Control_Planos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarCotBindingSource
        '
        Me.BuscarCotBindingSource.DataMember = "BuscarCot"
        Me.BuscarCotBindingSource.DataSource = Me.Control_Planos
        '
        'BuscarCotTableAdapter
        '
        Me.BuscarCotTableAdapter.ClearBeforeFill = True
        '
        'BuscCotCNBX
        '
        Me.BuscCotCNBX.BackColor = System.Drawing.SystemColors.Control
        Me.BuscCotCNBX.DataSource = Me.NumCotBindingSource
        Me.BuscCotCNBX.DisplayMember = "no_cotización"
        Me.BuscCotCNBX.FormattingEnabled = True
        Me.BuscCotCNBX.Location = New System.Drawing.Point(6, 6)
        Me.BuscCotCNBX.Name = "BuscCotCNBX"
        Me.BuscCotCNBX.Size = New System.Drawing.Size(121, 21)
        Me.BuscCotCNBX.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(183, 9)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(973, 622)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BuscarBTN)
        Me.TabPage1.Controls.Add(Me.ReportViewer1)
        Me.TabPage1.Controls.Add(Me.BuscCotCNBX)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(965, 596)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Generar control de planos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Control_De_Planos"
        ReportDataSource1.Value = Me.BuscarCotBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FTM_Registros.Reporte_ControlPlanos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(6, 33)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(956, 560)
        Me.ReportViewer1.TabIndex = 4
        '
        'BuscarBTN
        '
        Me.BuscarBTN.Location = New System.Drawing.Point(133, 4)
        Me.BuscarBTN.Name = "BuscarBTN"
        Me.BuscarBTN.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBTN.TabIndex = 5
        Me.BuscarBTN.Text = "Generar"
        Me.BuscarBTN.UseVisualStyleBackColor = True
        '
        'DescarcarNumCor
        '
        Me.DescarcarNumCor.DataSetName = "DescarcarNumCor"
        Me.DescarcarNumCor.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumCotBindingSource
        '
        Me.NumCotBindingSource.DataMember = "NumCot"
        Me.NumCotBindingSource.DataSource = Me.DescarcarNumCor
        '
        'NumCotTableAdapter
        '
        Me.NumCotTableAdapter.ClearBeforeFill = True
        '
        'Ingenieria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1168, 643)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ingenieria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingeniería"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Control_Planos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarCotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DescarcarNumCor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumCotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BuscarCotBindingSource As BindingSource
    Friend WithEvents Control_Planos As Control_Planos
    Friend WithEvents BuscarCotTableAdapter As Control_PlanosTableAdapters.BuscarCotTableAdapter
    Friend WithEvents BuscCotCNBX As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BuscarBTN As Button
    Friend WithEvents DescarcarNumCor As DescarcarNumCor
    Friend WithEvents NumCotBindingSource As BindingSource
    Friend WithEvents NumCotTableAdapter As DescarcarNumCorTableAdapters.NumCotTableAdapter
End Class
