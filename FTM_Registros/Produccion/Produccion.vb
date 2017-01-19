Public Class Produccion
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)

    End Sub

    Private Sub invmpBTN_Click(sender As Object, e As EventArgs) Handles invmpBTN.Click
        RegIndicadadores.Show()
    End Sub
End Class