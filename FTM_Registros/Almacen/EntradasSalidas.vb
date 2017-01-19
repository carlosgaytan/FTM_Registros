Public Class EntradasSalidas
    Private Sub EntradasSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'AlmacenBD.Entradas_Material' Puede moverla o quitarla según sea necesario.
        Me.EntradasMaterialTableAdapter.Fill(Me.AlmacenBD.Entradas_Material)
        'TODO: esta línea de código carga datos en la tabla 'AlmacenBD.Salidas_Material' Puede moverla o quitarla según sea necesario.
        Me.SalidasMaterialTableAdapter.Fill(Me.AlmacenBD.Salidas_Material)
        Label30.Text = DateTime.Now.ToShortDateString & " " & DateTime.Now.ToLongTimeString
    End Sub

#Region "Registro Entradas"
    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        'Genera registro
        If ClienteCMB.Text = "" Or FacturaTXT.Text = "" Or OCTXT.Text = "" Or CalidadTXT.Text = "" Or LargoTXT.Text = "" Or AnchoTXT.Text = "" Or CalibreCMX.Text = "" Or MaterialTXT.Text = "" Or UnidadTXT.Text = "" Or CostoTXT.Text = "" Or CostokgTXT.Text = "" Or RackTXT.Text = "" Or NivelTXT.Text = "" Then
            MessageBox.Show("Hay campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Cambia color de los campos vacios o llenos
            If FacturaTXT.Text = "" Then
                FacturaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                FacturaTXT.BackColor = System.Drawing.Color.White
            End If
            If OCTXT.Text = "" Then
                OCTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                OCTXT.BackColor = System.Drawing.Color.White
            End If
            If CalidadTXT.Text = "" Then
                CalidadTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                CalidadTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If LargoTXT.Text = "" Then
                LargoTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                LargoTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If AnchoTXT.Text = "" Then
                AnchoTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                AnchoTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If CalibreCMX.Text = "" Then
                CalibreCMX.BackColor = System.Drawing.Color.LightCoral
            Else
                CalibreCMX.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If MaterialTXT.Text = "" Then
                MaterialTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                MaterialTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If UnidadTXT.Text = "" Then
                UnidadTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                UnidadTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If CostoTXT.Text = "" Then
                CostoTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                CostoTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If CostokgTXT.Text = "" Then
                CostokgTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                CostokgTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If RackTXT.Text = "" Then
                RackTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                RackTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If NivelTXT.Text = "" Then
                NivelTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                NivelTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------

        Else
            'Crea fila de registro
            Dim NuevoRegistro As AlmacenBD.Entradas_MaterialRow
            NuevoRegistro = AlmacenBD.Entradas_Material.NewEntradas_MaterialRow

            'Rellena fila
            NuevoRegistro.FECHA = Label30.Text
            NuevoRegistro.CLIENTE = ClienteCMB.Text
            NuevoRegistro.FACTURA_O_REMISION = FacturaTXT.Text
            NuevoRegistro.ORDEN_DE_COMPRA = OCTXT.Text
            NuevoRegistro.CERTIFICADO_DE_CALIDAD = CalidadTXT.Text
            NuevoRegistro.LARGO = LargoTXT.Text
            NuevoRegistro.ANCHO = AnchoTXT.Text
            NuevoRegistro.CALIBRE = CalibreCMX.Text
            NuevoRegistro.MATERIAL = MaterialTXT.Text
            NuevoRegistro.UNIDAD = UnidadTXT.Text
            NuevoRegistro.COSTO = CostoTXT.Text
            NuevoRegistro.COSTO_KG = CostokgTXT.Text
            NuevoRegistro.RACK = RackTXT.Text
            NuevoRegistro.NIVEL = NivelTXT.Text
            NuevoRegistro.COMENTARIO = ComentarioTXT.Text
            NuevoRegistro.LOTE = LoteTXT.Text
            NuevoRegistro.NUMERO_DE_PARTE = noParteTXT.Text
            NuevoRegistro.EMPLEADO = Control_Accesos.Usuario
            NuevoRegistro.AÑO = DateTime.Now.Year

            'Insertar la fila en la tabla apropiada del DataSet
            AlmacenBD.Entradas_Material.AddEntradas_MaterialRow(NuevoRegistro)

            'Enviar informacón a la base de datos
            EntradasMaterialTableAdapter.Update(AlmacenBD.Entradas_Material)

            'Confirma proceso
            MessageBox.Show("Registro guardado", "Registros")
        End If
    End Sub
#End Region
    '---------------------------------------------------------------------------------------
#Region "Registro Salidas"
    Private Sub Guardar2BTN_Click(sender As Object, e As EventArgs) Handles Guardar2BTN.Click

        'Genera registro
        If SalidaTXT.Text = "" Or Fecha2TXT.Text = "" Or EntradaTXT.Text = "" Or ofTXT.Text = "" Or oc2TXT.Text = "" Or piTXT.Text = "" Or MatTXT.Text = "" Or SolicitanteTXT.Text = "" Or AutorizaTXT.Text = "" Or CantTXT.Text = "" Or MaqTXT.Text = "" Then
            MessageBox.Show("Hay campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Cambia color de los campos vacios o llenos
            If SalidaTXT.Text = "" Then
                SalidaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                SalidaTXT.BackColor = System.Drawing.Color.White
            End If
            If Fecha2TXT.Text = "" Then
                Fecha2TXT.BackColor = System.Drawing.Color.LightCoral
            Else
                Fecha2TXT.BackColor = System.Drawing.Color.White
            End If
            If EntradaTXT.Text = "" Then
                EntradaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                EntradaTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If ofTXT.Text = "" Then
                ofTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                ofTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If piTXT.Text = "" Then
                piTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                piTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If oc2TXT.Text = "" Then
                oc2TXT.BackColor = System.Drawing.Color.LightCoral
            Else
                oc2TXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If MaterialTXT.Text = "" Then
                MaterialTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                MaterialTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If SolicitanteTXT.Text = "" Then
                SolicitanteTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                SolicitanteTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If AutorizaTXT.Text = "" Then
                AutorizaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                AutorizaTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If CantTXT.Text = "" Then
                CantTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                CantTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If MaqTXT.Text = "" Then
                MaqTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                MaqTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------

        Else

            'Crea fila de registro
            Dim NuevaSalida As AlmacenBD.Salidas_MaterialRow

            NuevaSalida = AlmacenBD.Salidas_Material.NewSalidas_MaterialRow

            'Rellena fila
            NuevaSalida.FOLIO_DE_SALIDA = SalidaTXT.Text
            NuevaSalida.FECHA = Fecha2TXT.Text
            NuevaSalida.FOLIO_DE_ENTRADA = EntradaTXT.Text
            NuevaSalida.OC = oc2TXT.Text
            NuevaSalida.PEDIDO_INTERNO = piTXT.Text
            NuevaSalida.ORDEN_DE_FABRICACION = ofTXT.Text
            NuevaSalida.MATERIAL = MatTXT.Text
            NuevaSalida.SOLICITANTE = SolicitanteTXT.Text
            NuevaSalida.AUTORIZACION = AutorizaTXT.Text
            NuevaSalida.CANTIDAD = CantTXT.Text
            NuevaSalida.MAQUINA = MaqTXT.Text

            'Insertar la fila en la tabla apropiada del DataSet
            AlmacenBD.Salidas_Material.AddSalidas_MaterialRow(NuevaSalida)

            'Enviar informacón a la base de datos
            SalidasMaterialTableAdapter.Update(AlmacenBD.Salidas_Material)

            'Confirma proceso
            MessageBox.Show("Registro guardado", "Registros")
        End If
    End Sub

#End Region

    Private Sub EntradasSalidas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'Confirmación de cierre
        If MessageBox.Show("¿Seguro que desea salir?", "Salida",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
        = DialogResult.Yes Then
            Me.Close()
            End
        Else
            e.Cancel = True
        End If

    End Sub

End Class