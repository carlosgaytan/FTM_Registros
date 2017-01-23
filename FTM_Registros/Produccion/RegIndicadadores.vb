Public Class RegIndicadadores
#Region "Funciones"
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
    Function Flaser()
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
    End Function
    Function FDoblez()
        Dim RegistroDoblez As ProduccionBD.Registros_DoblezRow
        RegistroDoblez = ProduccionBD.Registros_Doblez.NewRegistros_DoblezRow

        'Rellena fila
        RegistroDoblez._OF = OFTXT.Text
        RegistroDoblez.MAQUINA = MaquinaTXT.Text
        RegistroDoblez.FECHA = FechaTXT.Text
        RegistroDoblez.CLIENTE = ClienteTXT.Text
        RegistroDoblez.AREA = AreaTXT.Text
        RegistroDoblez.HP = hpTXT.Text
        RegistroDoblez.HR = hrTXT.Text
        RegistroDoblez.PZA_PROG = ProgTXT.Text
        RegistroDoblez.PZA_PROD = ProdTXT.Text
        RegistroDoblez.PZA_RECHAZADAS = RechazadasTXT.Text
        RegistroDoblez.SCRAP = SCRAPTXT.Text
        RegistroDoblez.SEMANA = SemTXT.Text
        RegistroDoblez.MANTENIMIENTO = MantTXT.Text
        RegistroDoblez.FALTA_DE_TRABAJO = TrabTXT.Text
        RegistroDoblez.LIMPIEZA = LimpTXT.Text
        RegistroDoblez.SET_UP = setupTXT.Text
        RegistroDoblez.AJUSTES = AjusTXT.Text
        RegistroDoblez.FALTA_MATERIAL = MatTXT.Text
        RegistroDoblez.PROGRAMA = ProgramaTXT.Text
        RegistroDoblez.FALTA_ENERGIA = EnerTXT.Text
        RegistroDoblez.CALIDAD = CalTXT.Text
        RegistroDoblez.DESCARGA = DescTXT.Text
        RegistroDoblez.FALTA_OF = FofTXT.Text
        RegistroDoblez.GASES = GasesTXT.Text
        RegistroDoblez.FALLA_MAQUINA = FmaqTXT.Text
        RegistroDoblez.JUNTA_PERSONAL = PersoTXT.Text
        RegistroDoblez.OTRA = OtroTXT.Text
        RegistroDoblez.DURACION_OTRA = DuracTXT.Text
        RegistroDoblez.MES = MonthName(DateTime.Now.Month)
        RegistroDoblez.AÑO = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Registros_Doblez.AddRegistros_DoblezRow(RegistroDoblez)

        'Enviar informacón a la base de datos
        Registros_DoblezTableAdapter.Update(ProduccionBD.Registros_Doblez)

        'Confirma proceso
        MessageBox.Show("Registro guardado", "Registros")

        'Vacia los campos
        Vaciar()
    End Function
    Function FMaquinados()
        Dim RegistroMaquinados As ProduccionBD.Registros_MaquinadosRow
        RegistroMaquinados = ProduccionBD.Registros_Maquinados.NewRegistros_MaquinadosRow

        'Rellena fila
        RegistroMaquinados._OF = OFTXT.Text
        RegistroMaquinados.MAQUINA = MaquinaTXT.Text
        RegistroMaquinados.FECHA = FechaTXT.Text
        RegistroMaquinados.CLIENTE = ClienteTXT.Text
        RegistroMaquinados.AREA = AreaTXT.Text
        RegistroMaquinados.HP = hpTXT.Text
        RegistroMaquinados.HR = hrTXT.Text
        RegistroMaquinados.PZA_PROG = ProgTXT.Text
        RegistroMaquinados.PZA_PROD = ProdTXT.Text
        RegistroMaquinados.PZA_RECHAZADAS = RechazadasTXT.Text
        RegistroMaquinados.SCRAP = SCRAPTXT.Text
        RegistroMaquinados.SEMANA = SemTXT.Text
        RegistroMaquinados.MANTENIMIENTO = MantTXT.Text
        RegistroMaquinados.FALTA_DE_TRABAJO = TrabTXT.Text
        RegistroMaquinados.LIMPIEZA = LimpTXT.Text
        RegistroMaquinados.SET_UP = setupTXT.Text
        RegistroMaquinados.AJUSTES = AjusTXT.Text
        RegistroMaquinados.FALTA_MATERIAL = MatTXT.Text
        RegistroMaquinados.PROGRAMA = ProgramaTXT.Text
        RegistroMaquinados.FALTA_ENERGIA = EnerTXT.Text
        RegistroMaquinados.CALIDAD = CalTXT.Text
        RegistroMaquinados.DESCARGA = DescTXT.Text
        RegistroMaquinados.FALTA_OF = FofTXT.Text
        RegistroMaquinados.GASES = GasesTXT.Text
        RegistroMaquinados.FALLA_MAQUINA = FmaqTXT.Text
        RegistroMaquinados.JUNTA_PERSONAL = PersoTXT.Text
        RegistroMaquinados.OTRA = OtroTXT.Text
        RegistroMaquinados.DURACION_OTRA = DuracTXT.Text
        RegistroMaquinados.MES = MonthName(DateTime.Now.Month)
        RegistroMaquinados.AÑO = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Registros_Maquinados.AddRegistros_MaquinadosRow(RegistroMaquinados)

        'Enviar informacón a la base de datos
        Registros_MaquinadosTableAdapter.Update(ProduccionBD.Registros_Maquinados)

        'Confirma proceso
        MessageBox.Show("Registro guardado", "Registros")

        'Vacia los campos
        Vaciar()

    End Function
    Function FPunzonado()
        Dim RegistroPunzonado As ProduccionBD.Registros_PunzonadoRow
        RegistroPunzonado = ProduccionBD.Registros_Punzonado.NewRegistros_PunzonadoRow

        'Rellena fila
        RegistroPunzonado._OF = OFTXT.Text
        RegistroPunzonado.MAQUINA = MaquinaTXT.Text
        RegistroPunzonado.FECHA = FechaTXT.Text
        RegistroPunzonado.CLIENTE = ClienteTXT.Text
        RegistroPunzonado.AREA = AreaTXT.Text
        RegistroPunzonado.HP = hpTXT.Text
        RegistroPunzonado.HR = hrTXT.Text
        RegistroPunzonado.PZA_PROG = ProgTXT.Text
        RegistroPunzonado.PZA_PROD = ProdTXT.Text
        RegistroPunzonado.PZA_RECHAZADAS = RechazadasTXT.Text
        RegistroPunzonado.SCRAP = SCRAPTXT.Text
        RegistroPunzonado.SEMANA = SemTXT.Text
        RegistroPunzonado.MANTENIMIENTO = MantTXT.Text
        RegistroPunzonado.FALTA_DE_TRABAJO = TrabTXT.Text
        RegistroPunzonado.LIMPIEZA = LimpTXT.Text
        RegistroPunzonado.SET_UP = setupTXT.Text
        RegistroPunzonado.AJUSTES = AjusTXT.Text
        RegistroPunzonado.FALTA_MATERIAL = MatTXT.Text
        RegistroPunzonado.PROGRAMA = ProgramaTXT.Text
        RegistroPunzonado.FALTA_ENERGIA = EnerTXT.Text
        RegistroPunzonado.CALIDAD = CalTXT.Text
        RegistroPunzonado.DESCARGA = DescTXT.Text
        RegistroPunzonado.FALTA_OF = FofTXT.Text
        RegistroPunzonado.GASES = GasesTXT.Text
        RegistroPunzonado.FALLA_MAQUINA = FmaqTXT.Text
        RegistroPunzonado.JUNTA_PERSONAL = PersoTXT.Text
        RegistroPunzonado.OTRA = OtroTXT.Text
        RegistroPunzonado.DURACION_OTRA = DuracTXT.Text
        RegistroPunzonado.MES = MonthName(DateTime.Now.Month)
        RegistroPunzonado.AÑO = DateTime.Now.Year

        'Insertar la fila en la tabla apropiada del DataSet
        ProduccionBD.Registros_Punzonado.AddRegistros_PunzonadoRow(RegistroPunzonado)

        'Enviar informacón a la base de datos
        Registros_PunzonadoTableAdapter.Update(ProduccionBD.Registros_Punzonado)

        'Confirma proceso
        MessageBox.Show("Registro guardado", "Registros")

        'Vacia los campos
        Vaciar()

    End Function
#End Region

    Private Sub RegIndicadadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros_Punzonado' Puede moverla o quitarla según sea necesario.
        Me.Registros_PunzonadoTableAdapter.PunzonadoFill(Me.ProduccionBD.Registros_Punzonado)
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros_Maquinados' Puede moverla o quitarla según sea necesario.
        Me.Registros_MaquinadosTableAdapter.MaquinadosFill(Me.ProduccionBD.Registros_Maquinados)
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros_Doblez' Puede moverla o quitarla según sea necesario.
        Me.Registros_DoblezTableAdapter.DoblezFill(Me.ProduccionBD.Registros_Doblez)
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ProduccionBD.Registros' Puede moverla o quitarla según sea necesario.
        Me.RegistrosTableAdapter.Fill(Me.ProduccionBD.Registros)

        'Obtiene el número de la semana actual
        SemTXT.Text = DatePart(DateInterval.WeekOfYear, Now, FirstDayOfWeek.Monday, FirstWeekOfYear.FirstFullWeek)

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        If AreaTXT.Text = "Láser" Then
            'Registro en tabla Registros (Láser)
            If OFTXT.Text = "" Or MaquinaTXT.Text = "" Or ClienteTXT.Text = "" Or AreaTXT.Text = "" Or hpTXT.Text = "" Or hrTXT.Text = "" Or ProgTXT.Text = "" Or ProdTXT.Text = "" Or
                RechazadasTXT.Text = "" Or SCRAPTXT.Text = "" Or SemTXT.Text = "" Then
                MessageBox.Show("Hay campos vacios en Registro Diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf MantTXT.Text = "" Or TrabTXT.Text = "" Or TrabTXT.Text = "" Or LimpTXT.Text = "" Or
                    setupTXT.Text = "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text = "" Or GasesTXT.Text = "" Or FmaqTXT.Text = "" Or PersoTXT.Text = "" Or OtroTXT.Text = "" Or OtroTXT.Text = "" Or DuracTXT.Text = "" Then
                Dim respuesta = MessageBox.Show("¿Desea continuar sin agregar más Tiempos Muertos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta = DialogResult.Yes Then
                    Flaser()
                End If
            ElseIf OFTXT.Text <> "" Or MaquinaTXT.Text <> "" Or ClienteTXT.Text <> "" Or AreaTXT.Text <> "" Or hpTXT.Text <> "" Or hrTXT.Text <> "" Or ProgTXT.Text <> "" Or ProdTXT.Text <> "" Or
                    RechazadasTXT.Text <> "" Or SCRAPTXT.Text <> "" Or SemTXT.Text <> "" Or MantTXT.Text <> "" Or TrabTXT.Text <> "" Or TrabTXT.Text <> "" Or LimpTXT.Text <> "" Or
                    setupTXT.Text <> "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text <> "" Or GasesTXT.Text <> "" Or FmaqTXT.Text <> "" Or PersoTXT.Text <> "" Or OtroTXT.Text <> "" Or OtroTXT.Text <> "" Or DuracTXT.Text <> "" Then
                Flaser()
            End If
        ElseIf AreaTXT.Text = "Doblez" Then
            'Registro en tabla Registros (Láser)
            If OFTXT.Text = "" Or MaquinaTXT.Text = "" Or ClienteTXT.Text = "" Or AreaTXT.Text = "" Or hpTXT.Text = "" Or hrTXT.Text = "" Or ProgTXT.Text = "" Or ProdTXT.Text = "" Or
                RechazadasTXT.Text = "" Or SCRAPTXT.Text = "" Or SemTXT.Text = "" Then
                MessageBox.Show("Hay campos vacios en Registro Diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf MantTXT.Text = "" Or TrabTXT.Text = "" Or TrabTXT.Text = "" Or LimpTXT.Text = "" Or
                    setupTXT.Text = "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text = "" Or GasesTXT.Text = "" Or FmaqTXT.Text = "" Or PersoTXT.Text = "" Or OtroTXT.Text = "" Or OtroTXT.Text = "" Or DuracTXT.Text = "" Then
                Dim respuesta = MessageBox.Show("¿Desea continuar sin agregar más Tiempos Muertos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta = DialogResult.Yes Then
                    FDoblez()
                End If
            ElseIf OFTXT.Text <> "" Or MaquinaTXT.Text <> "" Or ClienteTXT.Text <> "" Or AreaTXT.Text <> "" Or hpTXT.Text <> "" Or hrTXT.Text <> "" Or ProgTXT.Text <> "" Or ProdTXT.Text <> "" Or
                    RechazadasTXT.Text <> "" Or SCRAPTXT.Text <> "" Or SemTXT.Text <> "" Or MantTXT.Text <> "" Or TrabTXT.Text <> "" Or TrabTXT.Text <> "" Or LimpTXT.Text <> "" Or
                    setupTXT.Text <> "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text <> "" Or GasesTXT.Text <> "" Or FmaqTXT.Text <> "" Or PersoTXT.Text <> "" Or OtroTXT.Text <> "" Or OtroTXT.Text <> "" Or DuracTXT.Text <> "" Then
                FDoblez()
            End If
        ElseIf AreaTXT.Text = "Maquinados" Then
            'Registro en tabla Registros (Láser)
            If OFTXT.Text = "" Or MaquinaTXT.Text = "" Or ClienteTXT.Text = "" Or AreaTXT.Text = "" Or hpTXT.Text = "" Or hrTXT.Text = "" Or ProgTXT.Text = "" Or ProdTXT.Text = "" Or
                RechazadasTXT.Text = "" Or SCRAPTXT.Text = "" Or SemTXT.Text = "" Then
                MessageBox.Show("Hay campos vacios en Registro Diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf MantTXT.Text = "" Or TrabTXT.Text = "" Or TrabTXT.Text = "" Or LimpTXT.Text = "" Or
                    setupTXT.Text = "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text = "" Or GasesTXT.Text = "" Or FmaqTXT.Text = "" Or PersoTXT.Text = "" Or OtroTXT.Text = "" Or OtroTXT.Text = "" Or DuracTXT.Text = "" Then
                Dim respuesta = MessageBox.Show("¿Desea continuar sin agregar más Tiempos Muertos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta = DialogResult.Yes Then
                    FMaquinados()
                End If
            ElseIf OFTXT.Text <> "" Or MaquinaTXT.Text <> "" Or ClienteTXT.Text <> "" Or AreaTXT.Text <> "" Or hpTXT.Text <> "" Or hrTXT.Text <> "" Or ProgTXT.Text <> "" Or ProdTXT.Text <> "" Or
                    RechazadasTXT.Text <> "" Or SCRAPTXT.Text <> "" Or SemTXT.Text <> "" Or MantTXT.Text <> "" Or TrabTXT.Text <> "" Or TrabTXT.Text <> "" Or LimpTXT.Text <> "" Or
                    setupTXT.Text <> "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text <> "" Or GasesTXT.Text <> "" Or FmaqTXT.Text <> "" Or PersoTXT.Text <> "" Or OtroTXT.Text <> "" Or OtroTXT.Text <> "" Or DuracTXT.Text <> "" Then
                FMaquinados()
            End If
        ElseIf AreaTXT.Text = "Punzonado" Then
            'Registro en tabla Registros (Láser)
            If OFTXT.Text = "" Or MaquinaTXT.Text = "" Or ClienteTXT.Text = "" Or AreaTXT.Text = "" Or hpTXT.Text = "" Or hrTXT.Text = "" Or ProgTXT.Text = "" Or ProdTXT.Text = "" Or
                RechazadasTXT.Text = "" Or SCRAPTXT.Text = "" Or SemTXT.Text = "" Then
                MessageBox.Show("Hay campos vacios en Registro Diario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf MantTXT.Text = "" Or TrabTXT.Text = "" Or TrabTXT.Text = "" Or LimpTXT.Text = "" Or
                    setupTXT.Text = "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text = "" Or GasesTXT.Text = "" Or FmaqTXT.Text = "" Or PersoTXT.Text = "" Or OtroTXT.Text = "" Or OtroTXT.Text = "" Or DuracTXT.Text = "" Then
                Dim respuesta = MessageBox.Show("¿Desea continuar sin agregar más Tiempos Muertos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If respuesta = DialogResult.Yes Then
                    FPunzonado()
                End If
            ElseIf OFTXT.Text <> "" Or MaquinaTXT.Text <> "" Or ClienteTXT.Text <> "" Or AreaTXT.Text <> "" Or hpTXT.Text <> "" Or hrTXT.Text <> "" Or ProgTXT.Text <> "" Or ProdTXT.Text <> "" Or
                    RechazadasTXT.Text <> "" Or SCRAPTXT.Text <> "" Or SemTXT.Text <> "" Or MantTXT.Text <> "" Or TrabTXT.Text <> "" Or TrabTXT.Text <> "" Or LimpTXT.Text <> "" Or
                    setupTXT.Text <> "" Or AjusTXT.Text = "" Or MatTXT.Text = "" Or ProgramaTXT.Text = "" Or EnerTXT.Text = "" Or CalTXT.Text = "" Or DescTXT.Text = "" Or
                    FofTXT.Text <> "" Or GasesTXT.Text <> "" Or FmaqTXT.Text <> "" Or PersoTXT.Text <> "" Or OtroTXT.Text <> "" Or OtroTXT.Text <> "" Or DuracTXT.Text <> "" Then
                FPunzonado()
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