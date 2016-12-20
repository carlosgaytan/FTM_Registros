Public Class Ventas

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Clientes)

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        'Guarda registros
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)
    End Sub

    Private Sub Registros_Click(sender As Object, e As EventArgs) Handles Registros.Click
        Registro_Cot.Show()
    End Sub

    Private Sub Cotizador_Click(sender As Object, e As EventArgs) Handles Cotizador.Click
        Cotizaciones.Show()
    End Sub

    Private Sub Corregir_Click(sender As Object, e As EventArgs) Handles Corregir.Click
        Corregir_costos.Show()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Orden_compra.Show()
    End Sub
    Private Sub Reporte_Click(sender As Object, e As EventArgs) Handles Reporte.Click

        'Confirma proceso para generación de cotización
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim respuesta As MsgBoxResult

        msg = "¿El registro tiene No. de Cotización ó Es una recotización?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel
        title = "Aviso"
        respuesta = MsgBox(msg, style, title)

        If respuesta = MsgBoxResult.Yes Then
            Reg_NoCot.Show()
        ElseIf respuesta = MsgBoxResult.No Then
            Reporte_Cotizar.Show()

        End If
    End Sub

End Class