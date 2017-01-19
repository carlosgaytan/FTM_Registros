Public Class Produccion
    Private Sub RegistrosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RegistrosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProduccionBD)

    End Sub

    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)

    End Sub
End Class