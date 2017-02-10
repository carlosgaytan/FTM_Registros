Public Class Registro_MESvb
    Dim DL, DD, DM, DP As Object
    Private Sub Registro_MESvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Días_MES' Puede moverla o quitarla según sea necesario.
        Me.Días_MESTableAdapter.RegHR(Me.ProduccionBD.Días_MES)

        Me.Días_MESBindingSource.MoveLast()


    End Sub

#Region "Botones de Guardado"

    Private Sub GuatdarLaser_Click(sender As Object, e As EventArgs) Handles GuardarLaser.Click, hlText.TextChanged
        'Crea fila de registro
        Dim NuevoRegistro As ProduccionBD.Días_MESRow
        NuevoRegistro = ProduccionBD.Días_MES.NewDías_MESRow

        'Rellena fila
        NuevoRegistro.Área = "Láser"
        NuevoRegistro.Días_hábiles = dlText.Text
        NuevoRegistro.Horas_Libres = hlText.Text
        NuevoRegistro.No_Turnos = nlText.Text
        NuevoRegistro.Duración_turnos = tlText.Text
        NuevoRegistro.Total_HR_Mensuales = DL
        NuevoRegistro.Mes = MonthName(DateTime.Now.Month)
        NuevoRegistro.YEARS = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Días_MES.AddDías_MESRow(NuevoRegistro)

        'Enviar informacón a la base de datos
        Días_MESTableAdapter.Update(ProduccionBD.Días_MES)

        'Confirma proceso
        Label13.Visible = True
        PictureBox1.Visible = True

    End Sub
    Private Sub GuardarDoblez_Click(sender As Object, e As EventArgs) Handles GuardarDoblez.Click
        'Crea fila de registro
        Dim NuevoRegistro As ProduccionBD.Días_MESRow
        NuevoRegistro = ProduccionBD.Días_MES.NewDías_MESRow

        'Rellena fila
        NuevoRegistro.Área = "Doblez"
        NuevoRegistro.Días_hábiles = ddText.Text
        NuevoRegistro.Horas_Libres = hdText.Text
        NuevoRegistro.No_Turnos = ndText.Text
        NuevoRegistro.Duración_turnos = tdText.Text
        NuevoRegistro.Total_HR_Mensuales = DD
        NuevoRegistro.Mes = MonthName(DateTime.Now.Month)
        NuevoRegistro.YEARS = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Días_MES.AddDías_MESRow(NuevoRegistro)

        'Enviar informacón a la base de datos
        Días_MESTableAdapter.Update(ProduccionBD.Días_MES)

        'Confirma proceso
        Label14.Visible = True
        PictureBox2.Visible = True
    End Sub
    Private Sub GuardarMaq_Click(sender As Object, e As EventArgs) Handles GuardarMaq.Click
        'Crea fila de registro
        Dim NuevoRegistro As ProduccionBD.Días_MESRow
        NuevoRegistro = ProduccionBD.Días_MES.NewDías_MESRow

        'Rellena fila
        NuevoRegistro.Área = "Maquinados"
        NuevoRegistro.Días_hábiles = dmText.Text
        NuevoRegistro.Horas_Libres = hmText.Text
        NuevoRegistro.No_Turnos = nmText.Text
        NuevoRegistro.Duración_turnos = tmText.Text
        NuevoRegistro.Total_HR_Mensuales = DM
        NuevoRegistro.Mes = MonthName(DateTime.Now.Month)
        NuevoRegistro.YEARS = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Días_MES.AddDías_MESRow(NuevoRegistro)

        'Enviar informacón a la base de datos
        Días_MESTableAdapter.Update(ProduccionBD.Días_MES)

        'Confirma proceso
        Label15.Visible = True
        PictureBox3.Visible = True
    End Sub
    Private Sub GuardarPunz_Click(sender As Object, e As EventArgs) Handles GuardarPunz.Click
        'Crea fila de registro
        Dim NuevoRegistro As ProduccionBD.Días_MESRow
        NuevoRegistro = ProduccionBD.Días_MES.NewDías_MESRow

        'Rellena fila
        NuevoRegistro.Área = "Punzonado"
        NuevoRegistro.Días_hábiles = dpText.Text
        NuevoRegistro.Horas_Libres = hpText.Text
        NuevoRegistro.No_Turnos = npText.Text
        NuevoRegistro.Duración_turnos = tpText.Text
        NuevoRegistro.Total_HR_Mensuales = DP
        NuevoRegistro.Mes = MonthName(DateTime.Now.Month)
        NuevoRegistro.YEARS = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Días_MES.AddDías_MESRow(NuevoRegistro)

        'Enviar informacón a la base de datos
        Días_MESTableAdapter.Update(ProduccionBD.Días_MES)

        'Confirma proceso
        Label16.Visible = True
        PictureBox4.Visible = True
    End Sub
#End Region

    Private Sub dlText_TextChanged(sender As Object, e As EventArgs) Handles dlText.TextChanged, hlText.TextChanged, nlText.TextChanged, tlText.TextChanged
        DL = (Val(dlText.Text) * (Val(nlText.Text) * Val(tlText.Text)) - Val(hlText.Text))
    End Sub
    Private Sub ddText_TextChanged(sender As Object, e As EventArgs) Handles ddText.TextChanged, hdText.TextChanged, ndText.TextChanged, tdText.TextChanged
        DD = (Val(ddText.Text) * (Val(ndText.Text) * Val(tdText.Text)) - Val(hdText.Text))
    End Sub
    Private Sub dmText_TextChanged(sender As Object, e As EventArgs) Handles dmText.TextChanged, hmText.TextChanged, nmText.TextChanged, tmText.TextChanged
        DM = (Val(dmText.Text) * (Val(nmText.Text) * Val(tmText.Text)) - Val(hmText.Text))
    End Sub
    Private Sub dpText_TextChanged(sender As Object, e As EventArgs) Handles dpText.TextChanged, hpText.TextChanged, npText.TextChanged, tpText.TextChanged
        DP = (Val(dpText.Text) * (Val(npText.Text) * Val(tpText.Text)) - Val(hpText.Text))
    End Sub

End Class