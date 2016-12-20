Public Class Registros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gerencia.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ventas.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Cotizaciones.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Manufactura.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Planeacion.Show()
    End Sub
    Private Sub Iniciobtn_Click(sender As Object, e As EventArgs) Handles Iniciobtn.Click
        Inicio.Show()
        Gerencia.Hide()
        Ventas.Hide()
        Cotizaciones.Hide()
        Manufactura.Hide()
        Planeacion.Hide()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Busqueda.Show()

    End Sub

    Private Sub Registros_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Gerencia.Close()
        Ventas.Close()
        Cotizaciones.Close()
        Manufactura.Close()
        Planeacion.Close()

        If MessageBox.Show("¿Seguro que desea salir?", "Salida",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
        = DialogResult.Yes Then
            Gerencia.Close()
            Ventas.Close()
            Cotizaciones.Close()
            Manufactura.Close()
            Planeacion.Close()
            End
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub
End Class
