Public Class Reporte_Cotizar
    Private Sub Reporte_Cotizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BuscarCBX.Ventas' 
        Me.BuscarVentasTableAdapter.LlenaCBXCosto(Me.BuscarCBX.Ventas)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        'TODO: esta línea de código carga datos en la tabla 'ReporteCotizar.Cotizaciones' 
        Me.CotizacionesTableAdapter.VerCotizacion(Me.ReporteCotizar.Cotizaciones)
        'TODO: esta línea de código carga datos en la tabla 'ReporteCotizar1.Costos' 
        Me.CostosTableAdapter.VerCostos(Me.ReporteCotizar1.Costos)
        'TODO: esta línea de código carga datos en la tabla 'ReporteCotizar2.Venta' 
        Me.VentaTableAdapter.VerVentas(Me.ReporteCotizar2.Venta)


        Me.CotizacionesTableAdapter.MostrarCotizacion(Me.ReporteCotizar.Cotizaciones, BuscarOrden.Text)
        Me.CostosTableAdapter.MostrarCostos(Me.ReporteCotizar1.Costos, BuscarOrden.Text)
        Me.VentaTableAdapter.MostrarVentas(Me.ReporteCotizar2.Venta, BuscarOrden.Text)
        ReportViewer1.Visible = True

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class