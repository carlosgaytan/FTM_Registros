Public Class Reg_NoCot

    Private Sub Reg_NoCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Cotizaciones_1_4DataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter1.Fill(Me._Cotizaciones_1_4DataSet.Ventas)
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Cotizaciones' Puede moverla o quitarla según sea necesario.
        Me.CotizacionesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Cotizaciones)

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        'Crea fila
        Dim NuevaCotizacion As _Base_de_datos_1_4_beDataSet.CotizacionesRow
        NuevaCotizacion = _Base_de_datos_1_4_beDataSet.Cotizaciones.NewCotizacionesRow

        'Rellena fila
        NuevaCotizacion.no_orden = no_ordenCBX.Text
        NuevaCotizacion.Cliente = ClienteTXT.Text
        NuevaCotizacion.no_cotización = no_cotizacionTXT.Text
        NuevaCotizacion.Recotización = RecotizaciónCHBX.CheckState
        NuevaCotizacion.Fecha = FECHA.Text
        NuevaCotizacion.Meses = MesTXT.Text
        NuevaCotizacion.Procesos_cotizar = Proc_CotTXT.Text
        NuevaCotizacion.Tiempo_Fabricacion = T_FabTXT.Text
        NuevaCotizacion.Otros_procesos = Otro_procTXT.Text

        'Insertar la fila en la tabla apropiada del DataSet
        _Base_de_datos_1_4_beDataSet.Cotizaciones.AddCotizacionesRow(NuevaCotizacion)

        'Enviar información a la base de datos
        CotizacionesTableAdapter.Update(_Base_de_datos_1_4_beDataSet)
        MessageBox.Show("No. de Cotización registrado", "Aviso")
        Reporte_Cotizar.Show()

        'Limpia los TXT y CHBX
        ClienteTXT.Clear()
        no_cotizacionTXT.Clear()
        RecotizaciónCHBX.CheckState = CheckState.Unchecked
        MesTXT.Clear()
        Proc_CotTXT.Clear()
        T_FabTXT.Clear()
        Otro_procTXT.Clear()


        Me.Hide()

    End Sub

    Private Sub CancelarBTN_Click(sender As Object, e As EventArgs) Handles CancelarBTN.Click

        'Confirma salida
        If MessageBox.Show("¿Seguro que desea salir?", "Aviso",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
            = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class