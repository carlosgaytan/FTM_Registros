Public Class Prog_Ventas
    'Private Sub BuscaVentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    '    Me.Validate()
    '    Me.BuscaVentasBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.ProgresoVentas)

    'End Sub

    Private Sub BuscaMesToolStripButton_Click(sender As Object, e As EventArgs) Handles BuscarBTN.Click
        Try
            Me.BuscaVentasTableAdapter.BuscaMes(Me.ProgresoVentas.BuscaVentas, MesLTB.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BuscarBTN_Click(sender As Object, e As EventArgs) Handles BuscarBTN.Click
        Me.BuscaVentasTableAdapter.BuscaMes(Me.ProgresoVentas.BuscaVentas, MesLTB.Text)
    End Sub
End Class