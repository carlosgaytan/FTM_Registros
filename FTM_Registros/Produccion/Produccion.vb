Public Class Produccion
    Private Sub Produccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Areas.Areas' Puede moverla o quitarla según sea necesario.
        Me.AreasTableAdapter.BuscaArea(Me.Areas._Areas)
        'TODO: esta línea de código carga datos en la tabla 'ReporteLaser.Laser' Puede moverla o quitarla según sea necesario.
        Me.LaserTableAdapter.VerLaser(Me.ReporteLaser.Laser)
        'TODO: esta línea de código carga datos en la tabla 'ReporteMaquinados.Maquinados' Puede moverla o quitarla según sea necesario.
        Me.MaquinadosTableAdapter.VerMaqui(Me.ReporteMaquinados.Maquinados)
        'TODO: esta línea de código carga datos en la tabla 'ReportePunzonado.Registros_Punzonado' Puede moverla o quitarla según sea necesario.
        Me.Registros_PunzonadoTableAdapter.VerPunzo(Me.ReportePunzonado.Registros_Punzonado)
        'TODO: esta línea de código carga datos en la tabla 'ReporteDoblez.Doblez' Puede moverla o quitarla según sea necesario.
        Me.DoblezTableAdapter.VerDoblez(Me.ReporteDoblez.Doblez)
        'TODO: esta línea de código carga datos en la tabla 'BuscarAños.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter1.YEARS(Me.BuscarAños.Registros)

        MesCBX.Text = MonthName(DateAndTime.Now.Month)
        YearCBX.Text = DateAndTime.Now.Year

        'Me.ReportViewer1.RefreshReport()
        'Me.ReportViewer2.RefreshReport()
    End Sub

    Private Sub invmpBTN_Click(sender As Object, e As EventArgs) Handles invmpBTN.Click

        Me.Días_MESTableAdapter.RegHR(Me.ProduccionBD.Días_MES)
        Me.Días_MESTableAdapter.MesRegistro(Me.ProduccionBD.Días_MES, DateAndTime.Now.Year, MonthName(DateAndTime.Now.Month))
        If MesTST.Text = "" Then
            MessageBox.Show("Inicio de mes, registrar horas hábiles del mes", "Nuevo Mes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Registro_MESvb.Show()
        ElseIf MesTST.Text <> "" Then
            RegIndicadadores.Show()
        End If
    End Sub

    Private Sub MesBTN_Click(sender As Object, e As EventArgs) Handles MesBTN.Click

        Me.LaserTableAdapter.VerLaser(Me.ReporteLaser.Laser)
        Me.LaserTableAdapter.MostrarLaser(Me.ReporteLaser.Laser, MesCBX.Text, YearCBX.Text)

        Me.DoblezTableAdapter.VerDoblez(Me.ReporteDoblez.Doblez)
        Me.DoblezTableAdapter.MostrarDoblez(Me.ReporteDoblez.Doblez, MesCBX.Text, YearCBX.Text)

        Me.MaquinadosTableAdapter.VerMaqui(Me.ReporteMaquinados.Maquinados)
        Me.MaquinadosTableAdapter.MostrarMaqui(Me.ReporteMaquinados.Maquinados, MesCBX.Text, YearCBX.Text)

        Me.Registros_PunzonadoTableAdapter.VerPunzo(Me.ReportePunzonado.Registros_Punzonado)
        Me.Registros_PunzonadoTableAdapter.MostrarPunzo(Me.ReportePunzonado.Registros_Punzonado, MesCBX.Text, YearCBX.Text)

        Me.TRUMPFTableAdapter.BuscaTRUMPF(Me.MaqLaser.TRUMPF, MesCBX.Text, YearCBX.Text)
        Me.AMADATableAdapter.BuscaAMADA(Me.MaqLaser.AMADA, MesCBX.Text, YearCBX.Text)
        Me.MITSUTableAdapter.BuscaMitsu(Me.MaqLaser.MITSU, MesCBX.Text, YearCBX.Text)
        Me.AMADA_DOBLEZTableAdapter.BuscaAmaDob(Me.MaqDoblez.AMADA_DOBLEZ, MesCBX.Text, YearCBX.Text)
        Me.TRUBENDTableAdapter.BuscaTRUBEND(Me.MaqDoblez.TRUBEND, MesCBX.Text, YearCBX.Text)
        Me.TOYOKOKITableAdapter.BuscaTOYO(Me.MaqDoblez.TOYOKOKI, MesCBX.Text, YearCBX.Text)
        Me.VM3TableAdapter.BuscaVM3(Me.MaqMaquin.VM3, MesCBX.Text, YearCBX.Text)
        Me.ST30TableAdapter.BuscaST30(Me.MaqMaquin.ST30, MesCBX.Text, YearCBX.Text)
        Me.ST10TableAdapter.BuscaST10(Me.MaqMaquin.ST10, MesCBX.Text, YearCBX.Text)
        Me.WJTableAdapter.BuscaWJ(Me.MaqMaquin.WJ, MesCBX.Text, YearCBX.Text)
        Me.PUNZONADOTableAdapter.BuscaPunz(Me.MaqPunz.PUNZONADO, MesCBX.Text, YearCBX.Text)

        Me.ReportViewer1.RefreshReport()

    End Sub

End Class