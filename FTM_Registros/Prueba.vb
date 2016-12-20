Public Class Prueba
    Private Sub Prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReporteCotizar1.Costos' Puede moverla o quitarla según sea necesario.
        Me.CostosTableAdapter.VerCostos(Me.ReporteCotizar1.Costos)

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click
        Me.CostosTableAdapter.MostrarCostos(Me.ReporteCotizar1.Costos, BuscarOrden.Text)
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Me.Validate()
        Me.CostosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReporteCotizar1)
    End Sub

    Private Sub MostrarCostosToolStripButton_Click(sender As Object, e As EventArgs) Handles MostrarCostosToolStripButton.Click
        Try
            Me.CostosTableAdapter.MostrarCostos(Me.ReporteCotizar1.Costos, New System.Nullable(Of Integer)(CType(No_ordenToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        ReporteCotizar1.Costos.AcceptChanges()
    End Sub

End Class