Public Class Asignar_noCot
    Private Sub CotizacionesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CotizacionesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CotizacionesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)

    End Sub

    Private Sub Asignar_noCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Cotizaciones' Puede moverla o quitarla según sea necesario.
        Me.CotizacionesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Cotizaciones)

    End Sub
End Class