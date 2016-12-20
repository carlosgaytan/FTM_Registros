Public Class Cotizador
    Private Sub Cotizador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cotizaciones_1_4DataSet.Control_planos' Puede moverla o quitarla según sea necesario.
        Me.Control_planosTableAdapter.ControlPlanos(Me._Cotizaciones_1_4DataSet.Control_planos)
        'TODO: esta línea de código carga datos en la tabla '_Cotizaciones_1_4DataSet.Costos' Puede moverla o quitarla según sea necesario.
        Me.CostosTableAdapter.Fill(Me._Cotizaciones_1_4DataSet.Costos)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Crea fila
        Dim NuevaPieza As _Cotizaciones_1_4DataSet.CostosRow
        NuevaPieza = _Cotizaciones_1_4DataSet.Costos.NewCostosRow

        'Rellena la fila
        NuevaPieza.no_orden = ordenComboBox1.Text
        NuevaPieza.Cliente = ClienteTextBox1.Text
        NuevaPieza.Clave_FTM = Clave_FTMComboBox.Text
        NuevaPieza.Dibujo = Dibujotxt.Text
        NuevaPieza.Descripción = Descripciontxt.Text
        NuevaPieza.P1 = P1TextBox.Text
        NuevaPieza.X = X1TextBox.Text
        NuevaPieza.Y = Y1TextBox.Text
        NuevaPieza.P2 = P2TextBox.Text
        NuevaPieza.X1 = X1TextBox1.Text
        NuevaPieza.Y1 = Y1TextBox1.Text
        NuevaPieza.Valor_material = ValorMaterial.Text
        NuevaPieza.Peso_Bruto = PesoBruto.Text
        NuevaPieza.Factor = FactorComboBox.Text
        NuevaPieza.Costo_MP = CostoMP.Text
        NuevaPieza.Precio_MP = PrecioMPTextBox.Text
        NuevaPieza.Material = MaterialTextBox.Text
        NuevaPieza.Espesor = EspesorTextBox.Text
        NuevaPieza.Doblez = DoblezTextBox.Text
        NuevaPieza.Costo_doblez = CostoDoblez.Text
        NuevaPieza.Precio_doblez = PrecioDoblezTextBox.Text
        NuevaPieza.Costo_pintura = CostoPintura.Text
        NuevaPieza.Pintura = PinturaTextBox.Text
        NuevaPieza.Soldadura = SoldaduraTextBox.Text
        NuevaPieza.Maquinado = MaquinadoTextBox.Text
        NuevaPieza.Costo_galvanizado = CostoGalvanizado.Text
        NuevaPieza.Galvanizado = GalvanizadoTextBox.Text
        NuevaPieza.Costo_Tropicalizado = CostoTropicalizado.Text
        NuevaPieza.Tropicalizado = TropicalizadoTextBox.Text
        NuevaPieza.Tiempo_corte = TiempoCorte.Text
        NuevaPieza.Costo_hr_corte = CostoHR.Text
        NuevaPieza.Precio_corte = PrecioCorteTextBox.Text
        NuevaPieza.Cantidades = CantidadesTextBox.Text
        NuevaPieza.um = U_mTextBox.Text
        NuevaPieza.Precio_final = PrecioFinalTextBox.Text
        NuevaPieza.Precio_Total = PrecioTotalTextBox.Text
        NuevaPieza.Cotizador = Nombre_quien_cotizaComboBox.Text

        'Insertar la fila en la tabla apropiada del DataSet
        _Cotizaciones_1_4DataSet.Costos.AddCostosRow(NuevaPieza)

        'Enviar informacón a la base de datos
        CostosTableAdapter.Update(_Cotizaciones_1_4DataSet.Costos)

    End Sub
End Class