<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalidaMP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalidaMP))
        Me.AlmacenBD = New FTM_Registros.AlmacenBD()
        Me.Salidas_MaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalidasMaterialTableAdapter = New FTM_Registros.AlmacenBDTableAdapters.SalidasMaterialTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.AlmacenBDTableAdapters.TableAdapterManager()
        Me.SalidaTXT = New System.Windows.Forms.TextBox()
        Me.ocTXT = New System.Windows.Forms.TextBox()
        Me.piTXT = New System.Windows.Forms.TextBox()
        Me.ofTXT = New System.Windows.Forms.TextBox()
        Me.MaterialTXT = New System.Windows.Forms.TextBox()
        Me.SolicitanteTXT = New System.Windows.Forms.TextBox()
        Me.AutorizaTXT = New System.Windows.Forms.TextBox()
        Me.CantTXT = New System.Windows.Forms.TextBox()
        Me.MaqTXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.FechaTXT = New System.Windows.Forms.DateTimePicker()
        Me.GuardarBTN = New System.Windows.Forms.Button()
        Me.EntradaTXT = New System.Windows.Forms.ComboBox()
        Me.EntradasMaterialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradasMaterialTableAdapter = New FTM_Registros.AlmacenBDTableAdapters.EntradasMaterialTableAdapter()
        CType(Me.AlmacenBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Salidas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasMaterialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AlmacenBD
        '
        Me.AlmacenBD.DataSetName = "AlmacenBD"
        Me.AlmacenBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Base_ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Base_MaterialTableAdapter = Nothing
        Me.TableAdapterManager.BaseEmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EntradasMaterialTableAdapter = Me.EntradasMaterialTableAdapter
        Me.TableAdapterManager.RACKSTableAdapter = Nothing
        Me.TableAdapterManager.SalidasMaterialTableAdapter = Me.SalidasMaterialTableAdapter
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.AlmacenBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalidaTXT
        '
        Me.SalidaTXT.Location = New System.Drawing.Point(105, 39)
        Me.SalidaTXT.Name = "SalidaTXT"
        Me.SalidaTXT.Size = New System.Drawing.Size(121, 20)
        Me.SalidaTXT.TabIndex = 0
        '
        'ocTXT
        '
        Me.ocTXT.Location = New System.Drawing.Point(105, 117)
        Me.ocTXT.Name = "ocTXT"
        Me.ocTXT.Size = New System.Drawing.Size(121, 20)
        Me.ocTXT.TabIndex = 3
        '
        'piTXT
        '
        Me.piTXT.Location = New System.Drawing.Point(105, 143)
        Me.piTXT.Name = "piTXT"
        Me.piTXT.Size = New System.Drawing.Size(121, 20)
        Me.piTXT.TabIndex = 4
        '
        'ofTXT
        '
        Me.ofTXT.Location = New System.Drawing.Point(105, 169)
        Me.ofTXT.Name = "ofTXT"
        Me.ofTXT.Size = New System.Drawing.Size(121, 20)
        Me.ofTXT.TabIndex = 5
        '
        'MaterialTXT
        '
        Me.MaterialTXT.Location = New System.Drawing.Point(105, 195)
        Me.MaterialTXT.Name = "MaterialTXT"
        Me.MaterialTXT.Size = New System.Drawing.Size(121, 20)
        Me.MaterialTXT.TabIndex = 6
        '
        'SolicitanteTXT
        '
        Me.SolicitanteTXT.Location = New System.Drawing.Point(105, 221)
        Me.SolicitanteTXT.Name = "SolicitanteTXT"
        Me.SolicitanteTXT.Size = New System.Drawing.Size(121, 20)
        Me.SolicitanteTXT.TabIndex = 7
        '
        'AutorizaTXT
        '
        Me.AutorizaTXT.Location = New System.Drawing.Point(105, 247)
        Me.AutorizaTXT.Name = "AutorizaTXT"
        Me.AutorizaTXT.Size = New System.Drawing.Size(121, 20)
        Me.AutorizaTXT.TabIndex = 8
        '
        'CantTXT
        '
        Me.CantTXT.Location = New System.Drawing.Point(105, 273)
        Me.CantTXT.Name = "CantTXT"
        Me.CantTXT.Size = New System.Drawing.Size(121, 20)
        Me.CantTXT.TabIndex = 9
        '
        'MaqTXT
        '
        Me.MaqTXT.Location = New System.Drawing.Point(105, 299)
        Me.MaqTXT.Name = "MaqTXT"
        Me.MaqTXT.Size = New System.Drawing.Size(121, 20)
        Me.MaqTXT.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Folio de Salida:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Folio de Entrada:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Orden de compra:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Pedido Interno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Ord. Fabricación:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Material"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Solicitante:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Autoriza:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Cantidad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 302)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Maquina:"
        '
        'FechaTXT
        '
        Me.FechaTXT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaTXT.Location = New System.Drawing.Point(105, 65)
        Me.FechaTXT.Name = "FechaTXT"
        Me.FechaTXT.Size = New System.Drawing.Size(121, 20)
        Me.FechaTXT.TabIndex = 22
        '
        'GuardarBTN
        '
        Me.GuardarBTN.Location = New System.Drawing.Point(447, 243)
        Me.GuardarBTN.Name = "GuardarBTN"
        Me.GuardarBTN.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBTN.TabIndex = 23
        Me.GuardarBTN.Text = "Guardar"
        Me.GuardarBTN.UseVisualStyleBackColor = True
        '
        'EntradaTXT
        '
        Me.EntradaTXT.DataSource = Me.EntradasMaterialBindingSource
        Me.EntradaTXT.DisplayMember = "FOLIO DE ENTRADA"
        Me.EntradaTXT.FormattingEnabled = True
        Me.EntradaTXT.Location = New System.Drawing.Point(105, 91)
        Me.EntradaTXT.Name = "EntradaTXT"
        Me.EntradaTXT.Size = New System.Drawing.Size(121, 21)
        Me.EntradaTXT.TabIndex = 24
        '
        'EntradasMaterialBindingSource
        '
        Me.EntradasMaterialBindingSource.DataMember = "Entradas_Material"
        Me.EntradasMaterialBindingSource.DataSource = Me.AlmacenBD
        '
        'EntradasMaterialTableAdapter
        '
        Me.EntradasMaterialTableAdapter.ClearBeforeFill = True
        '
        'SalidaMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 607)
        Me.Controls.Add(Me.EntradaTXT)
        Me.Controls.Add(Me.GuardarBTN)
        Me.Controls.Add(Me.FechaTXT)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaqTXT)
        Me.Controls.Add(Me.CantTXT)
        Me.Controls.Add(Me.AutorizaTXT)
        Me.Controls.Add(Me.SolicitanteTXT)
        Me.Controls.Add(Me.MaterialTXT)
        Me.Controls.Add(Me.ofTXT)
        Me.Controls.Add(Me.piTXT)
        Me.Controls.Add(Me.ocTXT)
        Me.Controls.Add(Me.SalidaTXT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalidaMP"
        Me.Text = "Salidas de material"
        CType(Me.AlmacenBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Salidas_MaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasMaterialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AlmacenBD As AlmacenBD
    Friend WithEvents Salidas_MaterialBindingSource As BindingSource
    Friend WithEvents SalidasMaterialTableAdapter As AlmacenBDTableAdapters.SalidasMaterialTableAdapter
    Friend WithEvents TableAdapterManager As AlmacenBDTableAdapters.TableAdapterManager
    Friend WithEvents SalidaTXT As TextBox
    Friend WithEvents ocTXT As TextBox
    Friend WithEvents piTXT As TextBox
    Friend WithEvents ofTXT As TextBox
    Friend WithEvents MaterialTXT As TextBox
    Friend WithEvents SolicitanteTXT As TextBox
    Friend WithEvents AutorizaTXT As TextBox
    Friend WithEvents CantTXT As TextBox
    Friend WithEvents MaqTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents FechaTXT As DateTimePicker
    Friend WithEvents GuardarBTN As Button
    Friend WithEvents EntradasMaterialTableAdapter As AlmacenBDTableAdapters.EntradasMaterialTableAdapter
    Friend WithEvents EntradaTXT As ComboBox
    Friend WithEvents EntradasMaterialBindingSource As BindingSource
End Class
