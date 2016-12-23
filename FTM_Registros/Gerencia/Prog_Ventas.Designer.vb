<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prog_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prog_Ventas))
        Me.ProgresoVentas = New FTM_Registros.ProgresoVentas()
        Me.BuscaVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscaVentasTableAdapter = New FTM_Registros.ProgresoVentasTableAdapters.BuscaVentasTableAdapter()
        Me.TableAdapterManager = New FTM_Registros.ProgresoVentasTableAdapters.TableAdapterManager()
        Me.BuscaVentasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BuscaVentasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BuscaMesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.MesToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.MesToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BuscaMesToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.BuscaVentasDataGridView = New System.Windows.Forms.DataGridView()
        Me.MesLTB = New System.Windows.Forms.ComboBox()
        Me.BuscarBTN = New System.Windows.Forms.Button()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.no_orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_solicitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_requerida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden_ganada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Fecha_entrega_cot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden_compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_OC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscaVentasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BuscaVentasBindingNavigator.SuspendLayout()
        Me.BuscaMesToolStrip.SuspendLayout()
        CType(Me.BuscaVentasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgresoVentas
        '
        Me.ProgresoVentas.DataSetName = "ProgresoVentas"
        Me.ProgresoVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscaVentasBindingSource
        '
        Me.BuscaVentasBindingSource.DataMember = "BuscaVentas"
        Me.BuscaVentasBindingSource.DataSource = Me.ProgresoVentas
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
        'BuscaVentasBindingNavigator
        '
        Me.BuscaVentasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BuscaVentasBindingNavigator.BindingSource = Me.BuscaVentasBindingSource
        Me.BuscaVentasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BuscaVentasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BuscaVentasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BuscaVentasBindingNavigatorSaveItem})
        Me.BuscaVentasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BuscaVentasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BuscaVentasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BuscaVentasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BuscaVentasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BuscaVentasBindingNavigator.Name = "BuscaVentasBindingNavigator"
        Me.BuscaVentasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BuscaVentasBindingNavigator.Size = New System.Drawing.Size(780, 25)
        Me.BuscaVentasBindingNavigator.TabIndex = 0
        Me.BuscaVentasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BuscaVentasBindingNavigatorSaveItem
        '
        Me.BuscaVentasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BuscaVentasBindingNavigatorSaveItem.Image = CType(resources.GetObject("BuscaVentasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BuscaVentasBindingNavigatorSaveItem.Name = "BuscaVentasBindingNavigatorSaveItem"
        Me.BuscaVentasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BuscaVentasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BuscaMesToolStrip
        '
        Me.BuscaMesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MesToolStripLabel, Me.MesToolStripTextBox, Me.BuscaMesToolStripButton})
        Me.BuscaMesToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.BuscaMesToolStrip.Name = "BuscaMesToolStrip"
        Me.BuscaMesToolStrip.Size = New System.Drawing.Size(780, 25)
        Me.BuscaMesToolStrip.TabIndex = 1
        Me.BuscaMesToolStrip.Text = "BuscaMesToolStrip"
        '
        'MesToolStripLabel
        '
        Me.MesToolStripLabel.Name = "MesToolStripLabel"
        Me.MesToolStripLabel.Size = New System.Drawing.Size(32, 22)
        Me.MesToolStripLabel.Text = "Mes:"
        '
        'MesToolStripTextBox
        '
        Me.MesToolStripTextBox.Name = "MesToolStripTextBox"
        Me.MesToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'BuscaMesToolStripButton
        '
        Me.BuscaMesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BuscaMesToolStripButton.Name = "BuscaMesToolStripButton"
        Me.BuscaMesToolStripButton.Size = New System.Drawing.Size(96, 22)
        Me.BuscaMesToolStripButton.Text = "Seleccionar mes"
        '
        'BuscaVentasDataGridView
        '
        Me.BuscaVentasDataGridView.AutoGenerateColumns = False
        Me.BuscaVentasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuscaVentasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cliente, Me.no_orden, Me.Fecha_solicitud, Me.Fecha_requerida, Me.Mes, Me.Orden_ganada, Me.Fecha_entrega_cot, Me.Orden_compra, Me.Fecha_OC})
        Me.BuscaVentasDataGridView.DataSource = Me.BuscaVentasBindingSource
        Me.BuscaVentasDataGridView.Location = New System.Drawing.Point(12, 198)
        Me.BuscaVentasDataGridView.Name = "BuscaVentasDataGridView"
        Me.BuscaVentasDataGridView.Size = New System.Drawing.Size(748, 220)
        Me.BuscaVentasDataGridView.TabIndex = 2
        '
        'MesLTB
        '
        Me.MesLTB.FormattingEnabled = True
        Me.MesLTB.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.MesLTB.Location = New System.Drawing.Point(12, 66)
        Me.MesLTB.Name = "MesLTB"
        Me.MesLTB.Size = New System.Drawing.Size(121, 21)
        Me.MesLTB.TabIndex = 3
        '
        'BuscarBTN
        '
        Me.BuscarBTN.Location = New System.Drawing.Point(155, 64)
        Me.BuscarBTN.Name = "BuscarBTN"
        Me.BuscarBTN.Size = New System.Drawing.Size(75, 23)
        Me.BuscarBTN.TabIndex = 4
        Me.BuscarBTN.Text = "Buscar"
        Me.BuscarBTN.UseVisualStyleBackColor = True
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'no_orden
        '
        Me.no_orden.DataPropertyName = "no_orden"
        Me.no_orden.HeaderText = "No. orden"
        Me.no_orden.Name = "no_orden"
        '
        'Fecha_solicitud
        '
        Me.Fecha_solicitud.DataPropertyName = "Fecha_solicitud"
        Me.Fecha_solicitud.HeaderText = "Fecha de registro"
        Me.Fecha_solicitud.Name = "Fecha_solicitud"
        '
        'Fecha_requerida
        '
        Me.Fecha_requerida.DataPropertyName = "Fecha_requerida"
        Me.Fecha_requerida.HeaderText = "Fecha requerida"
        Me.Fecha_requerida.Name = "Fecha_requerida"
        '
        'Mes
        '
        Me.Mes.DataPropertyName = "Mes"
        Me.Mes.HeaderText = "Mes"
        Me.Mes.Name = "Mes"
        Me.Mes.Visible = False
        '
        'Orden_ganada
        '
        Me.Orden_ganada.DataPropertyName = "Orden_ganada"
        Me.Orden_ganada.HeaderText = "Orden ganada"
        Me.Orden_ganada.Name = "Orden_ganada"
        '
        'Fecha_entrega_cot
        '
        Me.Fecha_entrega_cot.DataPropertyName = "Fecha_entrega_cot"
        Me.Fecha_entrega_cot.HeaderText = "Fecha entrega cot"
        Me.Fecha_entrega_cot.Name = "Fecha_entrega_cot"
        '
        'Orden_compra
        '
        Me.Orden_compra.DataPropertyName = "Orden_compra"
        Me.Orden_compra.HeaderText = "Orden compra"
        Me.Orden_compra.Name = "Orden_compra"
        '
        'Fecha_OC
        '
        Me.Fecha_OC.DataPropertyName = "Fecha_OC"
        Me.Fecha_OC.HeaderText = "Fecha OC"
        Me.Fecha_OC.Name = "Fecha_OC"
        '
        'Prog_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 497)
        Me.Controls.Add(Me.BuscarBTN)
        Me.Controls.Add(Me.MesLTB)
        Me.Controls.Add(Me.BuscaVentasDataGridView)
        Me.Controls.Add(Me.BuscaMesToolStrip)
        Me.Controls.Add(Me.BuscaVentasBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prog_Ventas"
        Me.Text = "Prrog_Ventas"
        CType(Me.ProgresoVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscaVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscaVentasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BuscaVentasBindingNavigator.ResumeLayout(False)
        Me.BuscaVentasBindingNavigator.PerformLayout()
        Me.BuscaMesToolStrip.ResumeLayout(False)
        Me.BuscaMesToolStrip.PerformLayout()
        CType(Me.BuscaVentasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgresoVentas As ProgresoVentas
    Friend WithEvents BuscaVentasBindingSource As BindingSource
    Friend WithEvents BuscaVentasTableAdapter As ProgresoVentasTableAdapters.BuscaVentasTableAdapter
    Friend WithEvents TableAdapterManager As ProgresoVentasTableAdapters.TableAdapterManager
    Friend WithEvents BuscaVentasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BuscaVentasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BuscaMesToolStrip As ToolStrip
    Friend WithEvents MesToolStripLabel As ToolStripLabel
    Friend WithEvents MesToolStripTextBox As ToolStripTextBox
    Friend WithEvents BuscaMesToolStripButton As ToolStripButton
    Friend WithEvents BuscaVentasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents MesLTB As ComboBox
    Friend WithEvents BuscarBTN As Button
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents no_orden As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_solicitud As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_requerida As DataGridViewTextBoxColumn
    Friend WithEvents Mes As DataGridViewTextBoxColumn
    Friend WithEvents Orden_ganada As DataGridViewCheckBoxColumn
    Friend WithEvents Fecha_entrega_cot As DataGridViewTextBoxColumn
    Friend WithEvents Orden_compra As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_OC As DataGridViewTextBoxColumn
End Class
