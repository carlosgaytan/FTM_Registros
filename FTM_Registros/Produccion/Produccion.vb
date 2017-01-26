Public Class Produccion
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BuscarAños.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter1.YEARS(Me.BuscarAños.Registros)
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' Puede moverla o quitarla según sea necesario.
        'Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)

        MesCBX.Text = MonthName(DateAndTime.Now.Month)
        YearCBX.Text = DateAndTime.Now.Year

        'Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub invmpBTN_Click(sender As Object, e As EventArgs) Handles invmpBTN.Click
        RegIndicadadores.Show()
    End Sub

    Private Sub MesBTN_Click(sender As Object, e As EventArgs) Handles MesBTN.Click
        ''TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' 
        'Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)
        'Me.RegistrosTableAdapter.LaserFillBy(Me.ProduccionBD.Registros, MesCBX.Text, YearCBX.Text)

        Me.LaserTableAdapter.VerLaser(Me.ReporteLaser.Laser)
        Me.LaserTableAdapter.MostrarLaser(Me.ReporteLaser.Laser, MesCBX.Text, YearCBX.Text)

        Me.DoblezTableAdapter.VerDoblez(Me.ReporteDoblez.Doblez)
        Me.DoblezTableAdapter.MostrarDoblez(Me.ReporteDoblez.Doblez, MesCBX.Text, YearCBX.Text)

        Me.MaquinadosTableAdapter.VerMaqui(Me.ReporteMaquinados.Maquinados)
        Me.MaquinadosTableAdapter.MostrarMaqui(Me.ReporteMaquinados.Maquinados, MesCBX.Text, YearCBX.Text)

        Me.Registros_PunzonadoTableAdapter.VerPunzo(Me.ReportePunzonado.Registros_Punzonado)
        Me.Registros_PunzonadoTableAdapter.MostrarPunzo(Me.ReportePunzonado.Registros_Punzonado, MesCBX.Text, YearCBX.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class