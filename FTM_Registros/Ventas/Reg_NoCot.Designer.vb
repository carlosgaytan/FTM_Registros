﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        CType(Me._Base_de_datos_1_4_beDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._Cotizaciones_1_4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Basededatos14beDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CotizacionesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.tblAdministradorTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuarioActivoTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosPermisosTableAdapter = Nothing
        Me.TableAdapterManager.tblUsuariosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros._Base_de_datos_1_4_beDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'Reg_NoCot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 245)
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
End Class