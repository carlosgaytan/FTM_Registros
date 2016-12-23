Public Class Registros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gerencia.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ventas.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Cotizaciones.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ingenieria.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Planeacion.Show()
    End Sub
    Private Sub Iniciobtn_Click(sender As Object, e As EventArgs) Handles Iniciobtn.Click
        Inicio.Show()
        Gerencia.Hide()
        Ventas.Hide()
        Cotizaciones.Hide()
        Ingenieria.Hide()
        Planeacion.Hide()
        Me.Hide()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Busqueda.Show()

    End Sub

    Private Sub Registros_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Gerencia.Close()
        Ventas.Close()
        Cotizaciones.Close()
        Ingenieria.Close()
        Planeacion.Close()

        If MessageBox.Show("¿Seguro que desea salir?", "Salida",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
        = DialogResult.Yes Then
            Gerencia.Close()
            Ventas.Close()
            Cotizaciones.Close()
            Ingenieria.Close()
            Planeacion.Close()
            End
        Else
            e.Cancel = True
        End If

    End Sub

End Class
