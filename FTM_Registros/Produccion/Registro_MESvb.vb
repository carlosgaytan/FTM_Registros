Public Class Registro_MESvb
    Dim DL, DD, DM, DP As Object
    Private Sub Registro_MESvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Días_MES' Puede moverla o quitarla según sea necesario.
        Me.Días_MESTableAdapter.RegHR(Me.ProduccionBD.Días_MES)
        Me.Días_MESBindingSource.MoveLast()

    End Sub

#Region "Botones de Guardado"

    Private Sub GuatdarLaser_Click(sender As Object, e As EventArgs) Handles GuardarLaser.Click
        If dlText.Text = "" Or nlText.Text = "" Or tlText.Text = "" Then
            Label9.Visible = True
            PictureBox5.Visible = True
        ElseIf dlText.Text <> "" And nlText.Text <> "" And tlText.Text <> "" Then
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
            Label9.Visible = False
            PictureBox5.Visible = False
        End If
    End Sub
    Private Sub GuardarDoblez_Click(sender As Object, e As EventArgs) Handles GuardarDoblez.Click

        If ddText.Text = "" Or ndText.Text = "" Or tdText.Text = "" Then
            Label10.Visible = True
            PictureBox6.Visible = True
        ElseIf ddText.Text <> "" And ndText.Text <> "" And tdText.Text <> "" Then
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
            Label10.Visible = False
            PictureBox6.Visible = False
        End If
    End Sub
    Private Sub GuardarMaq_Click(sender As Object, e As EventArgs) Handles GuardarMaq.Click
        If dmText.Text = "" Or nmText.Text = "" Or tmText.Text = "" Then
            Label11.Visible = True
            PictureBox7.Visible = True
        ElseIf dmText.Text <> "" And nmText.Text <> "" And tmText.Text <> "" Then
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
            Label11.Visible = False
            PictureBox7.Visible = False
        End If
    End Sub
    Private Sub GuardarPunz_Click(sender As Object, e As EventArgs) Handles GuardarPunz.Click
        If dpText.Text = "" Or npText.Text = "" Or tpText.Text = "" Then
            Label12.Visible = True
            PictureBox8.Visible = True
        ElseIf dpText.Text <> "" And npText.Text <> "" And tpText.Text <> "" Then
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
            Label12.Visible = False
            PictureBox8.Visible = False
        End If
    End Sub
#End Region

    Private Sub dlText_TextChanged(sender As Object, e As EventArgs) Handles dlText.TextChanged, hlText.TextChanged, nlText.TextChanged, tlText.TextChanged
        'Calculo de días hábiles en Láser
        DL = (Val(dlText.Text) * (Val(nlText.Text) * Val(tlText.Text)) - Val(hlText.Text))
    End Sub
    Private Sub ddText_TextChanged(sender As Object, e As EventArgs) Handles ddText.TextChanged, hdText.TextChanged, ndText.TextChanged, tdText.TextChanged
        'Calculo de días hábiles en Doblez
        DD = (Val(ddText.Text) * (Val(ndText.Text) * Val(tdText.Text)) - Val(hdText.Text))
    End Sub
    Private Sub dmText_TextChanged(sender As Object, e As EventArgs) Handles dmText.TextChanged, hmText.TextChanged, nmText.TextChanged, tmText.TextChanged
        'Calculo de días hábiles en Maquinados
        DM = (Val(dmText.Text) * (Val(nmText.Text) * Val(tmText.Text)) - Val(hmText.Text))
    End Sub
    Private Sub dpText_TextChanged(sender As Object, e As EventArgs) Handles dpText.TextChanged, hpText.TextChanged, npText.TextChanged, tpText.TextChanged
        'Calculo de días hábiles en Punzonado
        DP = (Val(dpText.Text) * (Val(npText.Text) * Val(tpText.Text)) - Val(hpText.Text))
    End Sub
    Private Sub TerminarBTN_Click(sender As Object, e As EventArgs) Handles TerminarBTN.Click
        'Mensaje de confirmación o error para nuevo mes
        If Label13.Visible = True And Label14.Visible = True And Label15.Visible = True And Label16.Visible = True Then
            RegIndicadadores.Show()
        ElseIf Label13.Visible = False Or Label14.Visible = False Or Label15.Visible = False Or Label16.Visible = False Then
            MessageBox.Show("¡Llenar todos los campos!", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If Label13.Visible = False Then
                Label9.Visible = True
                PictureBox5.Visible = True
            End If
            If Label14.Visible = False Then
                Label10.Visible = True
                PictureBox6.Visible = True
            End If
            If Label15.Visible = False Then
                Label11.Visible = True
                PictureBox7.Visible = True
            End If
            If Label16.Visible = False Then
                Label12.Visible = True
                PictureBox8.Visible = True
            End If
        End If
    End Sub
End Class