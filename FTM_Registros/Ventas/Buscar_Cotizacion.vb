Public Class Buscar_Cotizacion
    Dim conexion As New OleDb.OleDbConnection
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet
    Private Sub Buscar_Cotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'verdad
            conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & "S:\Base de datos\Cotizaciones\Cotizaciones 1.4.accdb")
            conexion.Open()
            MsgBox("Conexión exitosa", vbInformation, "Conectado")
        Catch ex As Exception
            'falso
            MsgBox("Error de conexión", vbExclamation, "Error")

        End Try
    End Sub
    Private Sub Limpiar()

        'Limpia cuadros de busqueda
        ClienteTextBox1.Clear()
        Dibujotxt.Clear()
        Descripciontxt.Clear()
        P1TextBox.Clear()
        X1TextBox.Clear()
        Y1TextBox.Clear()
        P2TextBox.Clear()
        X1TextBox1.Clear()
        Y1TextBox1.Clear()
        ValorMaterial.Clear()
        PesoBruto.Clear()
        CostoMP.Clear()
        PrecioMPTextBox.Clear()
        MaterialTextBox.Clear()
        EspesorTextBox.Clear()
        DoblezTextBox.Clear()
        CostoDoblez.Clear()
        PrecioDoblezTextBox.Clear()
        CostoPintura.Clear()
        PinturaTextBox.Clear()
        SoldaduraTextBox.Clear()
        MaquinadoTextBox.Clear()
        CostoGalvanizado.Clear()
        GalvanizadoTextBox.Clear()
        CostoTropicalizado.Clear()
        TropicalizadoTextBox.Clear()
        TiempoCorte.Clear()
        CostoHR.Clear()
        PrecioCorteTextBox.Clear()
        CantidadesTextBox.Clear()
        U_mTextBox.Clear()
        PrecioFinalTextBox.Clear()
        PrecioTotalTextBox.Clear()

    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        'Busca el elemento escrito en txt Busca
        Dim consulta As String
        Dim lista As Byte

        If Busca.Text <> "" Then
            consulta = "SELECT * FROM Costos WHERE no_orden = " & Busca.Text & ""
            adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
            registro = New DataSet
            adaptador.Fill(registro, "Costos")
            lista = registro.Tables("Costos").Rows.Count
        Else
            MsgBox("Debe ingresar un número", vbExclamation, "Campo vacío")
        End If

        If lista <> 0 Then
            Tabla.DataSource = registro
            Tabla.DataMember = "Costos"
            Busca.Text = registro.Tables("Costos").Rows(0).Item("no_orden")
            ClienteTextBox1.Text = registro.Tables("Costos").Rows(0).Item("Cliente")
            Clave_FTMComboBox.Text = registro.Tables("Costos").Rows(0).Item("Clave_FTM")
            Dibujotxt.Text = registro.Tables("Costos").Rows(0).Item("Dibujo")
            Descripciontxt.Text = registro.Tables("Costos").Rows(0).Item("Descripción")
            P1TextBox.Text = registro.Tables("Costos").Rows(0).Item("P1")
            X1TextBox.Text = registro.Tables("Costos").Rows(0).Item("X")
            Y1TextBox.Text = registro.Tables("Costos").Rows(0).Item("Y")
            P2TextBox.Text = registro.Tables("Costos").Rows(0).Item("P2")
            X1TextBox1.Text = registro.Tables("Costos").Rows(0).Item("X1")
            Y1TextBox1.Text = registro.Tables("Costos").Rows(0).Item("Y1")
            ValorMaterial.Text = registro.Tables("Costos").Rows(0).Item("Valor_material")
            PesoBruto.Text = registro.Tables("Costos").Rows(0).Item("Peso_Bruto")
            FactorComboBox.Text = registro.Tables("Costos").Rows(0).Item("Factor")
            CostoMP.Text = registro.Tables("Costos").Rows(0).Item("Costo_MP")
            PrecioMPTextBox.Text = registro.Tables("Costos").Rows(0).Item("Precio_MP")
            MaterialTextBox.Text = registro.Tables("Costos").Rows(0).Item("Material")
            EspesorTextBox.Text = registro.Tables("Costos").Rows(0).Item("Espesor")
            DoblezTextBox.Text = registro.Tables("Costos").Rows(0).Item("Doblez")
            CostoDoblez.Text = registro.Tables("Costos").Rows(0).Item("Costo_doblez")
            PrecioDoblezTextBox.Text = registro.Tables("Costos").Rows(0).Item("Pecio_doblez")
            CostoPintura.Text = registro.Tables("Costos").Rows(0).Item("Costo_pintura")
            PinturaTextBox.Text = registro.Tables("Costos").Rows(0).Item("Pintura")
            SoldaduraTextBox.Text = registro.Tables("Costos").Rows(0).Item("Soldadura")
            MaquinadoTextBox.Text = registro.Tables("Costos").Rows(0).Item("Maquinado")
            CostoGalvanizado.Text = registro.Tables("Costos").Rows(0).Item("Costo_galvanizado")
            GalvanizadoTextBox.Text = registro.Tables("Costos").Rows(0).Item("Galvanizado")
            CostoTropicalizado.Text = registro.Tables("Costos").Rows(0).Item("Costo_Tropicalizado")
            TropicalizadoTextBox.Text = registro.Tables("Costos").Rows(0).Item("Tropicalizado")
            TiempoCorte.Text = registro.Tables("Costos").Rows(0).Item("Tiempo_corte")
            CostoHR.Text = registro.Tables("Costos").Rows(0).Item("Costo_hr_corte")
            PrecioCorteTextBox.Text = registro.Tables("Costos").Rows(0).Item("Precio_corte")
            CantidadesTextBox.Text = registro.Tables("Costos").Rows(0).Item("Cantidades")
            U_mTextBox.Text = registro.Tables("Costos").Rows(0).Item("um")
            PrecioFinalTextBox.Text = registro.Tables("Costos").Rows(0).Item("Precio_final")
            PrecioTotalTextBox.Text = registro.Tables("Costos").Rows(0).Item("Precio_Total")
            Nombre_quien_cotizaComboBox.Text = registro.Tables("Costos").Rows(0).Item("Cotizador")

        Else
            'Ejecuta función de limpiar cuadros
            MsgBox("No hay registros", vbInformation, "Atención")
            Limpiar()
        End If

    End Sub

    Dim comandos As New OleDb.OleDbCommand
    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click

        'Actuliza base de datos
        Dim actualizar As String
        actualizar = "UPDATE Costos SET Cliente = '" & Busca.Text &
            "' , Clave_FTM = '" & Clave_FTMComboBox.Text &
            "' , Dibujo = '" & Dibujotxt.Text &
            "' , Descripción = '" & Descripciontxt.Text &
            "' , P1 = '" & P1TextBox.Text &
            "' , X = '" & X1TextBox.Text &
            "' , Y = '" & Y1TextBox.Text &
            "' , P2 = '" & P2TextBox.Text &
            "' , X1 = '" & X1TextBox1.Text &
            "' , Y1 = '" & Y1TextBox1.Text &
            "' , Valor_material = '" & ValorMaterial.Text &
            "' , Peso_Bruto = '" & PesoBruto.Text &
            "' , Factor = '" & FactorComboBox.Text &
            "' , Costo_MP = '" & CostoMP.Text &
            "' , Precio_MP = '" & PrecioMPTextBox.Text &
            "' , Material = '" & MaterialTextBox.Text &
            "' , Espesor = '" & EspesorTextBox.Text &
            "' , Doblez = '" & DoblezTextBox.Text &
            "' , Costo_doblez = '" & CostoDoblez.Text &
            "' , Pecio_doblez = '" & PrecioDoblezTextBox.Text &
            "' , Costo_pintura = '" & CostoPintura.Text &
            "' , Pintura = '" & PinturaTextBox.Text &
            "' , Soldadura = '" & SoldaduraTextBox.Text &
            "' , Maquinado = '" & MaquinadoTextBox.Text &
            "' , Costo_galvanizado = '" & CostoGalvanizado.Text &
            "' , Galvanizado = '" & GalvanizadoTextBox.Text &
            "' , Costo_Tropicalizado = '" & CostoTropicalizado.Text &
            "' , Tropicalizado = '" & TropicalizadoTextBox.Text &
            "' , Tiempo_corte = '" & TiempoCorte.Text &
            "' , Costo_hr_corte = '" & CostoHR.Text &
            "' , Precio_corte = '" & PrecioCorteTextBox.Text &
            "' , Cantidades = '" & CantidadesTextBox.Text &
            "' , um = '" & U_mTextBox.Text &
            "' , Precio_final = '" & PrecioFinalTextBox.Text &
            "' , Precio_Total = '" & PrecioTotalTextBox.Text &
            "' , Cotizador = '" & Nombre_quien_cotizaComboBox.Text &
            "' WHERE no_orden = '" & Busca.Text & "'"
        comandos = New OleDb.OleDbCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Registro actualizado", vbInformation, "Actualizar")
        Limpiar()


    End Sub

End Class