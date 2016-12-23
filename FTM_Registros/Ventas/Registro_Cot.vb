Public Class Registro_Cot

    Private Sub Registro_Cot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Ventas)

    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click

        'Crea fila
        Dim NuevoRegistro As _Base_de_datos_1_4_beDataSet.VentasRow
        NuevoRegistro = _Base_de_datos_1_4_beDataSet.Ventas.NewVentasRow

        'Rellena Fila
        NuevoRegistro.Cliente = ClienteComboBox.Text
        NuevoRegistro.no_orden = no_ordenTextBox.Text
        NuevoRegistro.Nombre_contacto = ClienteComboBox.Text
        NuevoRegistro.Correo_electrónico = Correotxt.Text
        NuevoRegistro.Fecha_solicitud = Fecha_solicitudDateTimePicker.Text
        NuevoRegistro.Mes = MesTextBox.Text
        NuevoRegistro.Forma_pago = Forma_pagoTextBox.Text
        NuevoRegistro.Tipo_empaque = Tipo_de_empaqueTextBox.Text
        NuevoRegistro.Observaciones = ObservacionesTextBox.Text
        NuevoRegistro.Fecha_requerida = Fecha_requeridaDateTimePicker.Text
        NuevoRegistro.Moneda = MonedaComboBox.Text
        NuevoRegistro.Acabado = AcabadoTextBox.Text
        NuevoRegistro.Incotems = IncotemsTextBox.Text
        NuevoRegistro.Suministro_material = Suministro_del_materialCheckBox.CheckState
        NuevoRegistro.Espesor1 = Espesor_1TextBox.Text
        NuevoRegistro.Material2 = Material_2TextBox.Text
        NuevoRegistro.Espesor2 = Espesor_2TextBox.Text
        NuevoRegistro.Material1 = Material_1TextBox.Text
        NuevoRegistro.Material3 = Material_3TextBox.Text
        NuevoRegistro.Espesor3 = Espesor_3TextBox.Text
        NuevoRegistro.Corte_Láser = Corte_LáserCheckBox.CheckState
        NuevoRegistro.Doblez = DoblezCheckBox.CheckState
        NuevoRegistro.Maquinado = MaquinadoCheckBox.CheckState
        NuevoRegistro.Corte_WJ = Corte_WJCheckBox.CheckState
        NuevoRegistro.Corte_Sierra = Corte_SierraCheckBox.CheckState
        NuevoRegistro.Rolado = RoladoCheckBox.CheckState
        NuevoRegistro.Soldar = SoldarCheckBox.CheckState
        NuevoRegistro.Item_soldado = Item_soldadoCheckBox.CheckState
        NuevoRegistro.Otro_proceso = Otro_procesoTextBox.Text

        'Insertar la fila en la tabla apropiada del DataSet
        _Base_de_datos_1_4_beDataSet.Ventas.AddVentasRow(NuevoRegistro)

        'Enviar informacón a la base de datos
        VentasTableAdapter.Update(_Base_de_datos_1_4_beDataSet.Ventas)

        MessageBox.Show("Orden guardada", "Registro exitoso")

        'Limpia los TXT y CHBX
        no_ordenTextBox.Clear()
        Correotxt.Clear()
        MesTextBox.Clear()
        Forma_pagoTextBox.Clear()
        Tipo_de_empaqueTextBox.Clear()
        ObservacionesTextBox.Clear()
        AcabadoTextBox.Clear()
        IncotemsTextBox.Clear()
        Espesor_1TextBox.Clear()
        Material_2TextBox.Clear()
        Espesor_2TextBox.Clear()
        Material_1TextBox.Clear()
        Material_3TextBox.Clear()
        Espesor_3TextBox.Clear()
        Otro_procesoTextBox.Clear()
        MesTextBox.Clear()
        Corte_LáserCheckBox.CheckState = CheckState.Unchecked
        DoblezCheckBox.CheckState = CheckState.Unchecked
        MaquinadoCheckBox.CheckState = CheckState.Unchecked
        Corte_WJCheckBox.CheckState = CheckState.Unchecked
        Corte_SierraCheckBox.CheckState = CheckState.Unchecked
        RoladoCheckBox.CheckState = CheckState.Unchecked
        SoldarCheckBox.CheckState = CheckState.Unchecked
        Item_soldadoCheckBox.CheckState = CheckState.Unchecked
        Suministro_del_materialCheckBox.CheckState = CheckState.Unchecked

    End Sub

    Private Sub Fecha_requeridaDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Fecha_requeridaDateTimePicker.ValueChanged
        Dim fecha As String
        fecha = DateAndTime.Now
        MesTextBox.Text = MonthName(Month(fecha))
    End Sub
End Class