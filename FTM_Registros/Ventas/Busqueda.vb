Public Class Busqueda
    Dim conexion As New OleDb.OleDbConnection
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet
    Private Sub Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'verdad
            conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & "S:\Base de datos\Manufactura\Manufactura 1.5.accdb")
            conexion.Open()
            MsgBox("Conexión exitosa", vbInformation, "Conectado")
        Catch ex As Exception
            'falso
            MsgBox("Error de conexión", vbExclamation, "Error")

        End Try
    End Sub
    Private Sub Limpiar()

        'Limpia cuadros de busqueda
        Busca.Clear()
        ClaveFTM.Clear()
        Dibujo.Clear()
        Descripcion.Clear()
        Material.Clear()
    End Sub

    Private Sub Buscar_Click(sender As Object, e As EventArgs) Handles Buscar.Click

        'Busca el elemento escrito en txt Busca
        Dim consulta As String
        Dim lista As Byte

        If Busca.Text <> "" Then
            consulta = "SELECT * FROM Orden_pza WHERE Orden = " & Busca.Text & ""
            adaptador = New OleDb.OleDbDataAdapter(consulta, conexion)
            registro = New DataSet
            adaptador.Fill(registro, "Orden_pza")
            lista = registro.Tables("Orden_pza").Rows.Count
        Else
            MsgBox("Debe ingresar un número", vbExclamation, "Campo vacío")
        End If

        If lista <> 0 Then
            Tabla.DataSource = registro
            Tabla.DataMember = "Orden_pza"
            Busca.Text = registro.Tables("Orden_pza").Rows(0).Item("Orden")
            ClaveFTM.Text = registro.Tables("Orden_pza").Rows(0).Item("Clave FTM")
            Dibujo.Text = registro.Tables("Orden_pza").Rows(0).Item("Dibujo")
            Descripcion.Text = registro.Tables("Orden_pza").Rows(0).Item("Descripción")
            Material.Text = registro.Tables("Orden_pza").Rows(0).Item("Material")
        Else
            'Ejecuta función de limpiar cuadros
            MsgBox("No hay registros", vbInformation, "Atención")
            Limpiar()
        End If
    End Sub

    Private Sub Modificar_Click(sender As Object, e As EventArgs) Handles Modificar.Click
        Busca.Enabled = False
        ClaveFTM.Enabled = True
        Dibujo.Enabled = True
        Descripcion.Enabled = True
        Material.Enabled = True
        ClaveFTM.Focus()

    End Sub

    Dim comandos As New OleDb.OleDbCommand

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        Dim actualizar As String
        actualizar = "UPDATE Orden_pza SET Clave FTM = '" & Busca.Text &
            "' , Dibujo = '" & Dibujo.Text &
            "' , Descripción = '" & Descripcion.Text &
            "' , Material = '" & Material.Text &
            "' WHERE Orden = '" & Busca.Text & "'"
        comandos = New OleDb.OleDbCommand(actualizar, conexion)
        comandos.ExecuteNonQuery()
        MsgBox("Registro actualizado", vbInformation, "Actualizar")
        Limpiar()
        Busca.Enabled = True
        ClaveFTM.Enabled = False
        Dibujo.Enabled = False
        Descripcion.Enabled = False
        Material.Enabled = False
        ClaveFTM.Focus()


    End Sub
End Class