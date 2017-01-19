Public Class Almacen
    Private Sub invmpBTN_Click(sender As Object, e As EventArgs) Handles invmpBTN.Click
        Inventario_MP.Show()
    End Sub

    Private Sub EntradasBTN_Click(sender As Object, e As EventArgs) Handles EntradasBTN.Click
        EntradasSalidas.Show()
    End Sub

    Private Sub SalidasBTN_Click(sender As Object, e As EventArgs) Handles SalidasBTN.Click
        SalidaMP.Show()
    End Sub

    Private Sub Almacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class