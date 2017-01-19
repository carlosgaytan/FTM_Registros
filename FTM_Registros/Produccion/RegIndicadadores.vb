Public Class RegIndicadadores
    'Vacia los campos
    Function Vaciar()
        OFTXT.Clear()
        hpTXT.Clear()
        hrTXT.Clear()
        ProgTXT.Clear()
        ProdTXT.Clear()
        RechazadasTXT.Clear()
        SCRAPTXT.Clear()
        MantTXT.Clear()
        TrabTXT.Clear()
        LimpTXT.Clear()
        setupTXT.Clear()
        AjusTXT.Clear()
        MatTXT.Clear()
        ProgramaTXT.Clear()
        EnerTXT.Clear()
        CalTXT.Clear()
        DescTXT.Clear()
        FofTXT.Clear()
        GasesTXT.Clear()
        PersoTXT.Clear()
        FmaqTXT.Clear()
        OtroTXT.Clear()
        DuracTXT.Clear()
    End Function
    Private Sub RegIndicadadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)

        'Obtiene el número de la semana actual
        SemTXT.Text = DatePart(DateInterval.WeekOfYear, Now, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        If OFTXT.Text = "" Or MaquinaTXT.Text = "" Or ClienteTXT.Text = "" Or AreaTXT.Text = "" Or hpTXT.Text = "" Or hrTXT.Text = "" Or ProgTXT.Text = "" Or ProdTXT.Text = "" Or
                RechazadasTXT.Text = "" Or SCRAPTXT.Text = "" Or SemTXT.Text = "" Then
            MessageBox.Show("Hay campos vacios en Registro Diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf MantTXT.Text = "" Or TrabTXT.Text = "" Or TrabTXT.Text = "" Or LimpTXT.Text = "" Or
                setupTXT.Text = "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                FofTXT.Text = "" Or GasesTXT.Text = "" Or FmaqTXT.Text = "" Or PersoTXT.Text = "" Or OtroTXT.Text = "" Or OtroTXT.Text = "" Or DuracTXT.Text = "" Then
            Dim respuesta = MessageBox.Show("Desea continuar sin agregar Tiempos Muertos", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If respuesta = DialogResult.Yes Then
                'Crea fila de registro
                Dim NuevoRegistro As ProduccionBD.RegistrosRow
                NuevoRegistro = ProduccionBD.Registros.NewRegistrosRow

                'Rellena fila
                NuevoRegistro._OF = OFTXT.Text
                NuevoRegistro.MAQUINA = MaquinaTXT.Text
                NuevoRegistro.FECHA = FechaTXT.Text
                NuevoRegistro.CLIENTE = ClienteTXT.Text
                NuevoRegistro.AREA = AreaTXT.Text
                NuevoRegistro.HP = hpTXT.Text
                NuevoRegistro.HR = hrTXT.Text
                NuevoRegistro.PZA_PROG = ProgTXT.Text
                NuevoRegistro.PZA_PROD = ProdTXT.Text
                NuevoRegistro.PZA_RECHAZADAS = RechazadasTXT.Text
                NuevoRegistro.SCRAP = SCRAPTXT.Text
                NuevoRegistro.SEMANA = SemTXT.Text
                NuevoRegistro.MANTENIMIENTO = MantTXT.Text
                NuevoRegistro.FALTA_DE_TRABAJO = TrabTXT.Text
                NuevoRegistro.LIMPIEZA = LimpTXT.Text
                NuevoRegistro.SET_UP = setupTXT.Text
                NuevoRegistro.AJUSTES = AjusTXT.Text
                NuevoRegistro.FALTA_MATERIAL = MatTXT.Text
                NuevoRegistro.PROGRAMA = ProgramaTXT.Text
                NuevoRegistro.FALTA_ENERGIA = EnerTXT.Text
                NuevoRegistro.CALIDAD = CalTXT.Text
                NuevoRegistro.DESCARGA = DescTXT.Text
                NuevoRegistro.FALTA_OF = FofTXT.Text
                NuevoRegistro.GASES = GasesTXT.Text
                NuevoRegistro.FALLA_MAQUINA = FmaqTXT.Text
                NuevoRegistro.JUNTA_PERSONAL = PersoTXT.Text
                NuevoRegistro.OTRA = OtroTXT.Text
                NuevoRegistro.DURACION_OTRA = DuracTXT.Text
                NuevoRegistro.MES = MonthName(DateTime.Now.Month)
                NuevoRegistro.AÑO = DateTime.Now.Year

                'Insertar la fila en la tabla apropiada del DataSet
                ProduccionBD.Registros.AddRegistrosRow(NuevoRegistro)

                'Enviar informacón a la base de datos
                RegistrosTableAdapter.Update(ProduccionBD.Registros)

                'Confirma proceso
                MessageBox.Show("Registro guardado", "Registros")

                'Vacia los campos
                Vaciar()
            End If
        End If
    End Sub

    Private Sub AreaTXT_TextChanged(sender As Object, e As EventArgs) Handles AreaTXT.TextChanged, AreaTXT.SelectedValueChanged

        'Establece la máquina según el área seleccionada
        Dim dt As DataTable = New DataTable("Tabla")
        Dim dr As DataRow

        dt.Columns.Add("Codigo")

        If AreaTXT.Text = "Láser" Then
            dr = dt.NewRow()
            dr("Codigo") = "Trumpf"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "Amada"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "Mitsubishi"
            dt.Rows.Add(dr)

        ElseIf AreaTXT.Text = "Doblez" Then
            dr = dt.NewRow()
            dr("Codigo") = "Amada Doblez"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "Toyokoki"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "Trubend"
            dt.Rows.Add(dr)

        ElseIf AreaTXT.Text = "Maquinados" Then
            dr = dt.NewRow()
            dr("Codigo") = "VM3"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "ST30"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "ST10"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Codigo") = "WJ"
            dt.Rows.Add(dr)

        ElseIf AreaTXT.Text = "Punzonado" Then
            dr = dt.NewRow()
            dr("Codigo") = "Punzonadora"
            dt.Rows.Add(dr)
        End If

        MaquinaTXT.DataSource = dt
        MaquinaTXT.ValueMember = "Codigo"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles VaciarBTN.Click
        Dim resVac = MessageBox.Show("¿Desea vaciar los campos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If resVac = DialogResult.Yes Then
            Vaciar()
        End If
    End Sub

    Private Sub RegIndicadadores_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim cerrar = MessageBox.Show("¿Seguro que desea salir?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If cerrar = DialogResult.Yes Then
            e.Cancel = False
        ElseIf cerrar = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class