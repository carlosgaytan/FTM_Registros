<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro_MESvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_MESvb))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dlText = New System.Windows.Forms.TextBox()
        Me.ddText = New System.Windows.Forms.TextBox()
        Me.dmText = New System.Windows.Forms.TextBox()
        Me.hlText = New System.Windows.Forms.TextBox()
        Me.hdText = New System.Windows.Forms.TextBox()
        Me.hmText = New System.Windows.Forms.TextBox()
        Me.nlText = New System.Windows.Forms.TextBox()
        Me.ndText = New System.Windows.Forms.TextBox()
        Me.nmText = New System.Windows.Forms.TextBox()
        Me.tlText = New System.Windows.Forms.TextBox()
        Me.tdText = New System.Windows.Forms.TextBox()
        Me.tmText = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GuardarLaser = New System.Windows.Forms.Button()
        Me.GuardarDoblez = New System.Windows.Forms.Button()
        Me.GuardarMaq = New System.Windows.Forms.Button()
        Me.GuardarPunz = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.dpText = New System.Windows.Forms.TextBox()
        Me.hpText = New System.Windows.Forms.TextBox()
        Me.npText = New System.Windows.Forms.TextBox()
        Me.tpText = New System.Windows.Forms.TextBox()
        Me.ProduccionBD = New FTM_Registros.ProduccionBD()
        Me.Días_MESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Días_MESTableAdapter = New FTM_Registros.ProduccionBDTableAdapters.Días_MESTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProduccionBDTableAdapters.TableAdapterManager()
        Me.TerminarBTN = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduccionBD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Días_MESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Láser"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Doblez"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Maquinados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Punzonado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Días Hábiles"
        '
        'dlText
        '
        Me.dlText.Location = New System.Drawing.Point(79, 32)
        Me.dlText.Name = "dlText"
        Me.dlText.Size = New System.Drawing.Size(100, 20)
        Me.dlText.TabIndex = 1
        '
        'ddText
        '
        Me.ddText.Location = New System.Drawing.Point(79, 58)
        Me.ddText.Name = "ddText"
        Me.ddText.Size = New System.Drawing.Size(100, 20)
        Me.ddText.TabIndex = 6
        '
        'dmText
        '
        Me.dmText.Location = New System.Drawing.Point(79, 84)
        Me.dmText.Name = "dmText"
        Me.dmText.Size = New System.Drawing.Size(100, 20)
        Me.dmText.TabIndex = 11
        '
        'hlText
        '
        Me.hlText.Location = New System.Drawing.Point(185, 32)
        Me.hlText.Name = "hlText"
        Me.hlText.Size = New System.Drawing.Size(100, 20)
        Me.hlText.TabIndex = 2
        '
        'hdText
        '
        Me.hdText.Location = New System.Drawing.Point(185, 58)
        Me.hdText.Name = "hdText"
        Me.hdText.Size = New System.Drawing.Size(100, 20)
        Me.hdText.TabIndex = 7
        '
        'hmText
        '
        Me.hmText.Location = New System.Drawing.Point(185, 84)
        Me.hmText.Name = "hmText"
        Me.hmText.Size = New System.Drawing.Size(100, 20)
        Me.hmText.TabIndex = 12
        '
        'nlText
        '
        Me.nlText.Location = New System.Drawing.Point(291, 32)
        Me.nlText.Name = "nlText"
        Me.nlText.Size = New System.Drawing.Size(100, 20)
        Me.nlText.TabIndex = 3
        '
        'ndText
        '
        Me.ndText.Location = New System.Drawing.Point(291, 58)
        Me.ndText.Name = "ndText"
        Me.ndText.Size = New System.Drawing.Size(100, 20)
        Me.ndText.TabIndex = 8
        '
        'nmText
        '
        Me.nmText.Location = New System.Drawing.Point(291, 84)
        Me.nmText.Name = "nmText"
        Me.nmText.Size = New System.Drawing.Size(100, 20)
        Me.nmText.TabIndex = 13
        '
        'tlText
        '
        Me.tlText.Location = New System.Drawing.Point(397, 32)
        Me.tlText.Name = "tlText"
        Me.tlText.Size = New System.Drawing.Size(100, 20)
        Me.tlText.TabIndex = 5
        '
        'tdText
        '
        Me.tdText.Location = New System.Drawing.Point(397, 58)
        Me.tdText.Name = "tdText"
        Me.tdText.Size = New System.Drawing.Size(100, 20)
        Me.tdText.TabIndex = 9
        '
        'tmText
        '
        Me.tmText.Location = New System.Drawing.Point(397, 84)
        Me.tmText.Name = "tmText"
        Me.tmText.Size = New System.Drawing.Size(100, 20)
        Me.tmText.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Horas libres"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(305, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "No. de turnos"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(398, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Duración de turnos"
        '
        'GuardarLaser
        '
        Me.GuardarLaser.Location = New System.Drawing.Point(503, 30)
        Me.GuardarLaser.Name = "GuardarLaser"
        Me.GuardarLaser.Size = New System.Drawing.Size(75, 23)
        Me.GuardarLaser.TabIndex = 32
        Me.GuardarLaser.Text = "Guardar"
        Me.GuardarLaser.UseVisualStyleBackColor = True
        '
        'GuardarDoblez
        '
        Me.GuardarDoblez.Location = New System.Drawing.Point(503, 56)
        Me.GuardarDoblez.Name = "GuardarDoblez"
        Me.GuardarDoblez.Size = New System.Drawing.Size(75, 23)
        Me.GuardarDoblez.TabIndex = 10
        Me.GuardarDoblez.Text = "Guardar"
        Me.GuardarDoblez.UseVisualStyleBackColor = True
        '
        'GuardarMaq
        '
        Me.GuardarMaq.Location = New System.Drawing.Point(503, 82)
        Me.GuardarMaq.Name = "GuardarMaq"
        Me.GuardarMaq.Size = New System.Drawing.Size(75, 23)
        Me.GuardarMaq.TabIndex = 15
        Me.GuardarMaq.Text = "Guardar"
        Me.GuardarMaq.UseVisualStyleBackColor = True
        '
        'GuardarPunz
        '
        Me.GuardarPunz.Location = New System.Drawing.Point(503, 108)
        Me.GuardarPunz.Name = "GuardarPunz"
        Me.GuardarPunz.Size = New System.Drawing.Size(75, 23)
        Me.GuardarPunz.TabIndex = 20
        Me.GuardarPunz.Text = "Guardar"
        Me.GuardarPunz.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Green
        Me.Label13.Location = New System.Drawing.Point(602, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Guardado"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Green
        Me.Label14.Location = New System.Drawing.Point(602, 61)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "Guardado"
        Me.Label14.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Green
        Me.Label15.Location = New System.Drawing.Point(602, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Guardado"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Green
        Me.Label16.Location = New System.Drawing.Point(602, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Guardado"
        Me.Label16.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Tick
        Me.PictureBox1.Location = New System.Drawing.Point(587, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Tick
        Me.PictureBox2.Location = New System.Drawing.Point(587, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Tick
        Me.PictureBox3.Location = New System.Drawing.Point(587, 87)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Tick
        Me.PictureBox4.Location = New System.Drawing.Point(587, 113)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 40
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'dpText
        '
        Me.dpText.Location = New System.Drawing.Point(79, 110)
        Me.dpText.Name = "dpText"
        Me.dpText.Size = New System.Drawing.Size(100, 20)
        Me.dpText.TabIndex = 16
        '
        'hpText
        '
        Me.hpText.Location = New System.Drawing.Point(185, 110)
        Me.hpText.Name = "hpText"
        Me.hpText.Size = New System.Drawing.Size(100, 20)
        Me.hpText.TabIndex = 17
        '
        'npText
        '
        Me.npText.Location = New System.Drawing.Point(291, 110)
        Me.npText.Name = "npText"
        Me.npText.Size = New System.Drawing.Size(100, 20)
        Me.npText.TabIndex = 18
        '
        'tpText
        '
        Me.tpText.Location = New System.Drawing.Point(397, 110)
        Me.tpText.Name = "tpText"
        Me.tpText.Size = New System.Drawing.Size(100, 20)
        Me.tpText.TabIndex = 19
        '
        'ProduccionBD
        '
        Me.ProduccionBD.DataSetName = "ProduccionBD"
        Me.ProduccionBD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Días_MESBindingSource
        '
        Me.Días_MESBindingSource.DataMember = "Días_MES"
        Me.Días_MESBindingSource.DataSource = Me.ProduccionBD
        '
        'Días_MESTableAdapter
        '
        Me.Días_MESTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Días_MESTableAdapter = Me.Días_MESTableAdapter
        Me.TableAdapterManager.Registros_DoblezTableAdapter = Nothing
        Me.TableAdapterManager.Registros_MaquinadosTableAdapter = Nothing
        Me.TableAdapterManager.Registros_PunzonadoTableAdapter = Nothing
        Me.TableAdapterManager.RegistrosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FTM_Registros.ProduccionBDTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TerminarBTN
        '
        Me.TerminarBTN.Location = New System.Drawing.Point(616, 145)
        Me.TerminarBTN.Name = "TerminarBTN"
        Me.TerminarBTN.Size = New System.Drawing.Size(75, 23)
        Me.TerminarBTN.TabIndex = 41
        Me.TerminarBTN.Text = "Terminar"
        Me.TerminarBTN.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(602, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "¡Campos vacios!"
        Me.Label9.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Delete
        Me.PictureBox5.Location = New System.Drawing.Point(587, 35)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 43
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Delete
        Me.PictureBox6.Location = New System.Drawing.Point(587, 61)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 45
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(602, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "¡Campos vacios!"
        Me.Label10.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Delete
        Me.PictureBox7.Location = New System.Drawing.Point(587, 87)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 47
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(602, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "¡Campos vacios!"
        Me.Label11.Visible = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.FTM_Registros.My.Resources.Resources.Pixelmixer_Basic_Delete
        Me.PictureBox8.Location = New System.Drawing.Point(587, 113)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(15, 15)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 49
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(602, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "¡Campos vacios!"
        Me.Label12.Visible = False
        '
        'Registro_MESvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 180)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TerminarBTN)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GuardarPunz)
        Me.Controls.Add(Me.GuardarMaq)
        Me.Controls.Add(Me.GuardarDoblez)
        Me.Controls.Add(Me.GuardarLaser)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.tpText)
        Me.Controls.Add(Me.tmText)
        Me.Controls.Add(Me.tdText)
        Me.Controls.Add(Me.tlText)
        Me.Controls.Add(Me.npText)
        Me.Controls.Add(Me.nmText)
        Me.Controls.Add(Me.ndText)
        Me.Controls.Add(Me.nlText)
        Me.Controls.Add(Me.hpText)
        Me.Controls.Add(Me.hmText)
        Me.Controls.Add(Me.hdText)
        Me.Controls.Add(Me.hlText)
        Me.Controls.Add(Me.dpText)
        Me.Controls.Add(Me.dmText)
        Me.Controls.Add(Me.ddText)
        Me.Controls.Add(Me.dlText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_MESvb"
        Me.Text = "Registro HR Mensuales"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduccionBD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Días_MESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dlText As TextBox
    Friend WithEvents ddText As TextBox
    Friend WithEvents dmText As TextBox
    Friend WithEvents hlText As TextBox
    Friend WithEvents hdText As TextBox
    Friend WithEvents hmText As TextBox
    Friend WithEvents nlText As TextBox
    Friend WithEvents ndText As TextBox
    Friend WithEvents nmText As TextBox
    Friend WithEvents tlText As TextBox
    Friend WithEvents tdText As TextBox
    Friend WithEvents tmText As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GuardarLaser As Button
    Friend WithEvents GuardarDoblez As Button
    Friend WithEvents GuardarMaq As Button
    Friend WithEvents GuardarPunz As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ProduccionBD As ProduccionBD
    Friend WithEvents Días_MESBindingSource As BindingSource
    Friend WithEvents Días_MESTableAdapter As ProduccionBDTableAdapters.Días_MESTableAdapter
    Friend WithEvents TableAdapterManager As ProduccionBDTableAdapters.TableAdapterManager
    Friend WithEvents dpText As TextBox
    Friend WithEvents hpText As TextBox
    Friend WithEvents npText As TextBox
    Friend WithEvents tpText As TextBox
    Friend WithEvents TerminarBTN As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label12 As Label
End Class
