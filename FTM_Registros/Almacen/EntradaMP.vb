
Public Class EntradaMP
    Private Sub EntradaMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'AlmacenBD.Entradas_Material' Puede moverla o quitarla según sea necesario.
        Me.EntradasMaterialTableAdapter.Fill(Me.AlmacenBD.Entradas_Material)
    End Sub
#Region "Generar registro"
    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        'Genera registro
        If FechaTXT.Text = "" Or ClienteCMB.Text = "" Or FacturaTXT.Text = "" Or OCTXT.Text = "" Or CalidadTXT.Text = "" Or LargoTXT.Text = "" Or AnchoTXT.Text = "" Or CalibreCMX.Text = "" Or MaterialTXT.Text = "" Or CantidadTXT.Text = "" Or UnidadTXT.Text = "" Or CostoTXT.Text = "" Or CostokgTXT.Text = "" Or RackTXT.Text = "" Or NivelTXT.Text = "" Then
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
            If CantidadTXT.Text = "" Then
                CantidadTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                CantidadTXT.BackColor = System.Drawing.Color.White
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
            NuevoRegistro.FECHA = FechaTXT.Text
            NuevoRegistro.CLIENTE = ClienteCMB.Text
            NuevoRegistro.FACTURA_O_REMISION = FacturaTXT.Text
            NuevoRegistro.ORDEN_DE_COMPRA = OCTXT.Text
            NuevoRegistro.CERTIFICADO_DE_CALIDAD = CalidadTXT.Text
            NuevoRegistro.LARGO = LargoTXT.Text
            NuevoRegistro.ANCHO = AnchoTXT.Text
            NuevoRegistro.CALIBRE = CalibreCMX.Text
            NuevoRegistro.MATERIAL = MaterialTXT.Text
            NuevoRegistro.CANTIDAD = CantidadTXT.Text
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
End Class