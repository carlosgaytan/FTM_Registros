Public Class Produccion
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DoblezBD1.Registros_Doblez' Puede moverla o quitarla según sea necesario.
        Me.Registros_DoblezTableAdapter.Doblez(Me.DoblezBD1.Registros_Doblez)
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)

        'Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub invmpBTN_Click(sender As Object, e As EventArgs) Handles invmpBTN.Click
        RegIndicadadores.Show()
    End Sub

    Private Sub MesBTN_Click(sender As Object, e As EventArgs) Handles MesBTN.Click
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' 
        Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)
        Me.RegistrosTableAdapter.LaserFillBy(Me.ProduccionBD.Registros, MesCBX.Text, YearCBX.Text)

        Me.Registros_DoblezTableAdapter.Doblez(Me.DoblezBD1.Registros_Doblez)
        Me.Registros_DoblezTableAdapter.DoblezFill(Me.DoblezBD1.Registros_Doblez, MesCBX.Text, YearCBX.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class