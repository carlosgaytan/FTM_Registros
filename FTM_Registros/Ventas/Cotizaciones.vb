Public Class Cotizaciones
    Dim X1, X2, Pbruto, PMP, PDoblez, Ppintura, Pgalv, Ptrop, Pcorte, Pfinal, Ptotal, ESPIN As Object
    Private Sub ClienteTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ClienteTextBox1.TextChanged
        'TODO: esta línea de código carga datos en la tabla '_Cotizaciones_1_4DataSet.Costos' Puede moverla o quitarla según sea necesario.
        Me.CostosTableAdapter.Fill(Me._Cotizaciones_1_4DataSet.Costos)

        'Busca las piezas según cliente
        Me.CostosTableAdapter1.BuscaClaveFTM(Me.AgregarClaveFTM.Costos, ClienteTextBox1.Text)

    End Sub

    Private Sub Cotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cotizaciones_1_4DataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me._Cotizaciones_1_4DataSet.Ventas)

    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click

        'Confirma proceso para generación de cotización
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim respuesta As MsgBoxResult

        msg = "¿El registro es una nueva Cotización o Recotización?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel
        title = "Aviso"
        respuesta = MsgBox(msg, style, title)

        If respuesta = MsgBoxResult.Yes Then
            Reg_NoCot.Show()
        ElseIf respuesta = MsgBoxResult.No Then
            Reporte_Cotizar.Show()

        End If

    End Sub
    Private Sub Siguientebtn_Click_1(sender As Object, e As EventArgs) Handles Siguientebtn.Click

        'Anade un nuevo registro
        CostosBindingSource.AddNew()

        Solda.Clear()
        Maquina.Clear()
        LaserCheckBox.CheckState = CheckState.Unchecked
        WJCheckBox.CheckState = CheckState.Unchecked
        SierraCheckBox.CheckState = CheckState.Unchecked
        PunzonadoCheckBox.CheckState = CheckState.Unchecked

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Borrarbtn.Click
        ClienteTextBox1.Clear()
        Dibujotxt.Clear()
        Descripciontxt.Clear()
        P1TextBox.Clear()
        X1TextBox.Clear()
        Y1TextBox.Clear()
        P2TextBox.Clear()
        X1TextBox1.Clear()
        Y1TextBox1.Clear()
        ValorMaterial.Clear()
        PesoBruto.Clear()
        CostoMP.Clear()
        PrecioMPTextBox.Clear()
        MaterialTextBox.Clear()
        EspesorTextBox.Clear()
        DoblezTextBox.Clear()
        CostoDoblez.Clear()
        PrecioDoblezTextBox.Clear()
        CostoPintura.Clear()
        PinturaTextBox.Clear()
        SoldaduraTextBox.Clear()
        MaquinadoTextBox.Clear()
        CostoGalvanizado.Clear()
        GalvanizadoTextBox.Clear()
        CostoTropicalizado.Clear()
        TropicalizadoTextBox.Clear()
        TiempoCorte.Clear()
        CostoHR.Clear()
        PrecioCorteTextBox.Clear()
        CantidadesTextBox.Clear()
        U_mTextBox.Clear()
        PrecioFinalTextBox.Clear()
        PrecioTotalTextBox.Clear()
    End Sub

    Private Sub NuevoBtn_Click(sender As Object, e As EventArgs) Handles NuevoBtn.Click
        '**************************************************************
        'Añade un nuevo registro
        If CostoHR.Text > CERO.Text And LaserCheckBox.CheckState = CheckState.Unchecked And WJCheckBox.CheckState = CheckState.Unchecked And SierraCheckBox.CheckState = CheckState.Unchecked And PunzonadoCheckBox.CheckState = CheckState.Unchecked Then
            MessageBox.Show("Seleccionar proceso de Corte: Láser, WJ, Sierra o Punzonadora")
        ElseIf CostoHR.Text > CERO.Text And LaserCheckBox.CheckState = CheckState.Checked Or CostoHR.Text > CERO.Text And WJCheckBox.CheckState = CheckState.Checked Or CostoHR.Text > CERO.Text And SierraCheckBox.CheckState = CheckState.Checked Or CostoHR.Text > CERO.Text And PunzonadoCheckBox.CheckState = CheckState.Checked Then

            '-----------------------------------------------------------------------------------------------
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
            NuevaPieza.Esp_1 = Esp1TXT.Text
            NuevaPieza.Esp_2 = Esp2TXT.Text
            NuevaPieza.Esp_cal = CalibreCBX.Text
            NuevaPieza.Milímetros = mmRBT.Checked
            NuevaPieza.Espesor1 = EspRepTXT.Text
            NuevaPieza.Pulgada = inRBT.Checked
            NuevaPieza.Calibre = calRBT.Checked
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
            NuevaPieza.SoldaduraCHBX = SoldaduraCheckBox.Checked
            NuevaPieza.MaquinadoCHBX = MaquinadoCheckBox.Checked
            NuevaPieza.PinturaCHBX = PinturaCheckBox.Checked
            NuevaPieza.GalvanizadoCHBX = GalvanizadoCheckBox.Checked
            NuevaPieza.TropicalizadoCHBX = TropicalizadoCheckBox.Checked
            NuevaPieza.LaserCHBX = LaserCheckBox.Checked
            NuevaPieza.WJCHBX = WJCheckBox.Checked
            NuevaPieza.SierraCHBX = SierraCheckBox.Checked
            NuevaPieza.PunzonadoCHBX = PunzonadoCheckBox.Checked

            'Insertar la fila en la tabla apropiada del DataSet
            _Cotizaciones_1_4DataSet.Costos.AddCostosRow(NuevaPieza)

            'Enviar informacón a la base de datos
            CostosTableAdapter.Update(_Cotizaciones_1_4DataSet.Costos)
            '-----------------------------------------------------------------------------------------------

            'Confirma proceso
            MessageBox.Show("Registro guardado", "Registros")

            'Desmarca los checks de los procesos y vacía textbox
            LaserCheckBox.CheckState = CheckState.Unchecked
            WJCheckBox.CheckState = CheckState.Unchecked
            SierraCheckBox.CheckState = CheckState.Unchecked
            PunzonadoCheckBox.CheckState = CheckState.Unchecked
            MaquinadoCheckBox.CheckState = CheckState.Unchecked
            SoldaduraCheckBox.CheckState = CheckState.Unchecked
            PinturaCheckBox.CheckState = CheckState.Unchecked
            GalvanizadoCheckBox.CheckState = CheckState.Unchecked
            TropicalizadoCheckBox.CheckState = CheckState.Unchecked
            CostoMP.Text = CERO.Text
            DoblezTextBox.Text = CERO.Text
            CostoDoblez.Text = CERO.Text
            Solda.Text = CERO.Text
            Maquina.Text = CERO.Text
            CostoPintura.Text = CERO.Text
            CostoGalvanizado.Text = CERO.Text
            CostoTropicalizado.Text = CERO.Text
            TiempoCorte.Text = CERO.Text
            CostoHR.Text = CERO.Text
            X1TextBox.Text = CERO.Text
            Y1TextBox.Text = CERO.Text

        End If
    End Sub
    Private Sub Y1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Y1TextBox.TextChanged, X1TextBox.TextChanged, ValorMaterial.TextChanged, EspesorTextBox.TextChanged, CostoPintura.TextChanged, CostoGalvanizado.TextChanged, CostoTropicalizado.TextChanged, Solda.TextChanged, Maquina.TextChanged, TiempoCorte.TextChanged, CostoHR.TextChanged, CantidadesTextBox.TextChanged, FactorComboBox.TextChanged, EspesorTextBox.TextChanged, ValorMaterial.TextChanged

        ' Calcula el valor de X1
        X1 = Val(X1TextBox.Text) + Val(Prueba.Text)
        X1TextBox1.Text = X1

        'Calcula el valor de Y1
        X2 = Val(Y1TextBox.Text) + Val(Prueba.Text)
        Y1TextBox1.Text = X2

        'Calcula el valor del Peso Bruto
        Pbruto = (Val(X1TextBox1.Text) * Val(Y1TextBox1.Text) * Val(ValorMaterial.Text) * Val(EspesorTextBox.Text)) / Val(Millon.Text)
        PesoBruto.Text = Pbruto

        'Copia precio de Soldadura
        SoldaduraTextBox.Text = Solda.Text
        If Solda.Text > CERO.Text Then
            SoldaduraCheckBox.CheckState = CheckState.Checked
        ElseIf Solda.Text <= CERO.Text Or Solda.Text <= CERO2.Text Then
            SoldaduraCheckBox.CheckState = CheckState.Unchecked
        End If

        'Copia precio de Maquinado
        MaquinadoTextBox.Text = Maquina.Text
        If Maquina.Text > CERO.Text Then
            MaquinadoCheckBox.CheckState = CheckState.Checked
        ElseIf Maquina.Text <= CERO.Text Or Maquina.Text <= CERO2.Text Then
            MaquinadoCheckBox.CheckState = CheckState.Unchecked
        End If

        'Calcula precio de Pintura
        Ppintura = (Val(X1TextBox.Text) * Val(Y1TextBox.Text) * Val(EspesorTextBox.Text) * Val(ValorMaterial.Text) / Val(Millon.Text)) * Val(CostoPintura.Text)
        PinturaTextBox.Text = Ppintura
        If CostoPintura.Text > CERO.Text Then
            PinturaCheckBox.CheckState = CheckState.Checked
        ElseIf CostoPintura.Text <= CERO.Text Or CostoPintura.Text <= CERO2.Text Then
            PinturaCheckBox.CheckState = CheckState.Unchecked
        End If

        'Calcula precio de Galvanizado
        Pgalv = (Val(X1TextBox.Text) * Val(Y1TextBox.Text) * Val(EspesorTextBox.Text) * Val(ValorMaterial.Text) / Val(Millon.Text)) * Val(CostoGalvanizado.Text)
        GalvanizadoTextBox.Text = Pgalv
        If CostoGalvanizado.Text > CERO.Text Then
            GalvanizadoCheckBox.CheckState = CheckState.Checked
        ElseIf CostoGalvanizado.Text <= CERO.Text Or CostoGalvanizado.Text <= CERO2.Text Then
            GalvanizadoCheckBox.CheckState = CheckState.Unchecked
        End If

        'Calcula precio Tropicalizado
        Ptrop = (Val(X1TextBox.Text) * Val(Y1TextBox.Text) * Val(EspesorTextBox.Text) * Val(ValorMaterial.Text) / Val(Millon.Text)) * Val(CostoTropicalizado.Text)
        TropicalizadoTextBox.Text = Ptrop
        If CostoTropicalizado.Text > CERO.Text Then
            TropicalizadoCheckBox.CheckState = CheckState.Checked
        ElseIf CostoTropicalizado.Text <= CERO.Text Or CostoTropicalizado.Text <= CERO2.Text Then
            TropicalizadoCheckBox.CheckState = CheckState.Unchecked
        End If

        'Calcula precio Corte
        Pcorte = Val(TiempoCorte.Text) * Val(CostoHR.Text)
        PrecioCorteTextBox.Text = Pcorte

    End Sub

    'Calcula el precio de la materia prima por pieza
    Private Sub PesoBruto_TextChanged(sender As Object, e As EventArgs) Handles PesoBruto.TextChanged, FactorComboBox.TextChanged, CostoMP.TextChanged
        PMP = Val(PesoBruto.Text) * Val(FactorComboBox.Text) * Val(CostoMP.Text)
        PrecioMPTextBox.Text = PMP
    End Sub
    Private Sub DoblezTextBox_TextChanged(sender As Object, e As EventArgs) Handles DoblezTextBox.TextChanged, CostoDoblez.TextChanged

        'Calcula el precio de doblez
        PDoblez = Val(DoblezTextBox.Text) * Val(CostoDoblez.Text)
        PrecioDoblezTextBox.Text = PDoblez

    End Sub
    Private Sub PrecioMPTextBox_TextChanged(sender As Object, e As EventArgs) Handles PrecioMPTextBox.TextChanged, PrecioDoblezTextBox.TextChanged, PinturaTextBox.TextChanged, SoldaduraTextBox.TextChanged, MaquinadoTextBox.TextChanged, GalvanizadoTextBox.TextChanged, TropicalizadoTextBox.TextChanged, PrecioCorteTextBox.TextChanged, PrecioFinalTextBox.TextChanged, CantidadesTextBox.TextChanged, PrecioFinalTextBox.TextChanged

        'Calcula precio Final
        Pfinal = Val(PrecioMPTextBox.Text) + Val(PrecioDoblezTextBox.Text) + Val(PinturaTextBox.Text) + Val(SoldaduraTextBox.Text) + Val(MaquinadoTextBox.Text) + Val(GalvanizadoTextBox.Text) + Val(TropicalizadoTextBox.Text) + Val(PrecioCorteTextBox.Text)
        PrecioFinalTextBox.Text = Pfinal

        'Calcula precio Total
        Ptotal = Val(PrecioFinalTextBox.Text) * Val(CantidadesTextBox.Text)
        PrecioTotalTextBox.Text = Ptotal

    End Sub
    Private Sub mmRBT_CheckedChanged(sender As Object, e As EventArgs) Handles mmRBT.CheckedChanged, calRBT.CheckedChanged, inRBT.CheckedChanged, Esp1TXT.TextChanged, Esp2TXT.TextChanged, CalibreCBX.TextChanged
        Const quote As String = """"

        'Establece el tipo de espesor registrado
        If mmRBT.Checked = True Then
            'Milímetros
            Esp1TXT.Visible = True
            Label9.Visible = False
            Esp2TXT.Visible = False
            CalibreCBX.Visible = False
            Esp2TXT.Text = CERO.Text
            Label28.Text = "Espesor (mm)"
            EspesorTextBox.Text = Esp1TXT.Text
            EspRepTXT.Text = EspesorTextBox.Text & "MM"
        ElseIf calRBT.Checked = True Then
            'Calibres
            Esp1TXT.Visible = False
            Label9.Visible = False
            Esp2TXT.Visible = False
            CalibreCBX.Visible = True
            Esp1TXT.Text = CERO.Text
            Esp2TXT.Text = CERO.Text
            Label28.Text = "Espesor (C. 3 a 34)"
            If CalibreCBX.Text = 3 Then
                EspesorTextBox.Text = 6.07
            ElseIf CalibreCBX.Text = 4 Then
                EspesorTextBox.Text = 5.69
            ElseIf CalibreCBX.Text = 5 Then
                EspesorTextBox.Text = 5.31
            ElseIf CalibreCBX.Text = 6 Then
                EspesorTextBox.Text = 4.94
            ElseIf CalibreCBX.Text = 7 Then
                EspesorTextBox.Text = 4.55
            ElseIf CalibreCBX.Text = 8 Then
                EspesorTextBox.Text = 4.18
            ElseIf CalibreCBX.Text = 9 Then
                EspesorTextBox.Text = 3.8
            ElseIf CalibreCBX.Text = 10 Then
                EspesorTextBox.Text = 3.42
            ElseIf CalibreCBX.Text = 11 Then
                EspesorTextBox.Text = 3.04
            ElseIf CalibreCBX.Text = 12 Then
                EspesorTextBox.Text = 2.66
            ElseIf CalibreCBX.Text = 13 Then
                EspesorTextBox.Text = 2.28
            ElseIf CalibreCBX.Text = 14 Then
                EspesorTextBox.Text = 1.9
            ElseIf CalibreCBX.Text = 15 Then
                EspesorTextBox.Text = 1.71
            ElseIf CalibreCBX.Text = 16 Then
                EspesorTextBox.Text = 1.52
            ElseIf CalibreCBX.Text = 17 Then
                EspesorTextBox.Text = 1.37
            ElseIf CalibreCBX.Text = 18 Then
                EspesorTextBox.Text = 1.21
            ElseIf CalibreCBX.Text = 19 Then
                EspesorTextBox.Text = 1.06
            ElseIf CalibreCBX.Text = 20 Then
                EspesorTextBox.Text = 0.91
            ElseIf CalibreCBX.Text = 21 Then
                EspesorTextBox.Text = 0.84
            ElseIf CalibreCBX.Text = 22 Then
                EspesorTextBox.Text = 0.76
            ElseIf CalibreCBX.Text = 23 Then
                EspesorTextBox.Text = 0.68
            ElseIf CalibreCBX.Text = 24 Then
                EspesorTextBox.Text = 0.61
            ElseIf CalibreCBX.Text = 25 Then
                EspesorTextBox.Text = 0.53
            ElseIf CalibreCBX.Text = 26 Then
                EspesorTextBox.Text = 0.45
            ElseIf CalibreCBX.Text = 27 Then
                EspesorTextBox.Text = 0.42
            ElseIf CalibreCBX.Text = 28 Then
                EspesorTextBox.Text = 0.38
            ElseIf CalibreCBX.Text = 29 Then
                EspesorTextBox.Text = 0.34
            ElseIf CalibreCBX.Text = 30 Then
                EspesorTextBox.Text = 0.3
            ElseIf CalibreCBX.Text = 31 Then
                EspesorTextBox.Text = 0.27
            ElseIf CalibreCBX.Text = 32 Then
                EspesorTextBox.Text = 0.25
            ElseIf CalibreCBX.Text = 33 Then
                EspesorTextBox.Text = 0.23
            ElseIf CalibreCBX.Text = 34 Then
                EspesorTextBox.Text = 0.21
            End If

            EspRepTXT.Text = "C." & CalibreCBX.Text

        ElseIf inRBT.Checked = True Then
            'Pulgadas
            Esp1TXT.Visible = True
            Label9.Visible = True
            Esp2TXT.Visible = True
            CalibreCBX.Visible = False
            Label28.Text = "Espesor (in)"
            If Esp1TXT.Text > CERO.Text And Esp2TXT.Text <= CERO.Text Then
                ESPIN = Val(Esp1TXT.Text) * 25.4
                EspesorTextBox.Text = ESPIN
                EspRepTXT.Text = Esp1TXT.Text & quote
            ElseIf Esp1TXT.Text > CERO.Text And Esp2TXT.Text > CERO.Text Then
                ESPIN = Val(Esp1TXT.Text) / Val(Esp2TXT.Text) * 25.4
                EspesorTextBox.Text = ESPIN
                EspRepTXT.Text = Esp1TXT.Text & "/" & Esp2TXT.Text & quote
            End If
        End If
    End Sub

End Class