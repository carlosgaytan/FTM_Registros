Public Class SalidaMP

    Private Sub SalidaMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AlmacenBD.Entradas_Material' Puede moverla o quitarla según sea necesario.
        Me.EntradasMaterialTableAdapter.Fill(Me.AlmacenBD.Entradas_Material)
        'TODO: esta línea de código carga datos en la tabla 'AlmacenBD.Salidas_Material' Puede moverla o quitarla según sea necesario.
        Me.SalidasMaterialTableAdapter.Fill(Me.AlmacenBD.Salidas_Material)

    End Sub
#Region "Generar registro"
    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        'Genera registro
        If SalidaTXT.Text = "" Or FechaTXT.Text = "" Or EntradaTXT.Text = "" Or ocTXT.Text = "" Or piTXT.Text = "" Or ocTXT.Text = "" Or MaterialTXT.Text = "" Or SolicitanteTXT.Text = "" Or AutorizaTXT.Text = "" Or CantTXT.Text = "" Or MaqTXT.Text = "" Then
            MessageBox.Show("Hay campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

            'Cambia color de los campos vacios o llenos
            If SalidaTXT.Text = "" Then
                SalidaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                SalidaTXT.BackColor = System.Drawing.Color.White
            End If
            If FechaTXT.Text = "" Then
                FechaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                FechaTXT.BackColor = System.Drawing.Color.White
            End If
            If EntradaTXT.Text = "" Then
                EntradaTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                EntradaTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If ocTXT.Text = "" Then
                ocTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                ocTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If piTXT.Text = "" Then
                piTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                piTXT.BackColor = System.Drawing.Color.White
            End If
            '----------------
            If ocTXT.Text = "" Then
                ocTXT.BackColor = System.Drawing.Color.LightCoral
            Else
                ocTXT.BackColor = System.Drawing.Color.White
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
            NuevaSalida.FECHA = FechaTXT.Text
            NuevaSalida.FOLIO_DE_ENTRADA = EntradaTXT.Text
            NuevaSalida.OC = ocTXT.Text
            NuevaSalida.PEDIDO_INTERNO = piTXT.Text
            NuevaSalida.ORDEN_DE_FABRICACION = ocTXT.Text
            NuevaSalida.MATERIAL = MaterialTXT.Text
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
End Class