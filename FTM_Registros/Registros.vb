Public Class Registros
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gerencia.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Ventas.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ingenieria.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Planeacion.Show()
    End Sub
    Private Sub ContProyectBTN_Click(sender As Object, e As EventArgs) Handles ContProyectBTN.Click
        Control_Proyectos.Show()
    End Sub
    Private Sub Iniciobtn_Click(sender As Object, e As EventArgs) Handles Iniciobtn.Click

        'Oculta formas para cambiar de sesión
        Inicio.Show()
        Gerencia.Hide()
        Ventas.Hide()
        Cotizaciones.Hide()
        Ingenieria.Hide()
        Planeacion.Hide()
        Control_Proyectos.Hide()
        Me.Hide()

    End Sub
    Private Sub Registros_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing

        'Confirmación de cierre
        If MessageBox.Show("¿Seguro que desea salir?", "Salida",
        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) _
        = DialogResult.Yes Then
            Gerencia.Close()
            Ventas.Close()
            Cotizaciones.Close()
            Ingenieria.Close()
            Planeacion.Close()
            Control_Proyectos.Close()
            End
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        InfoGerencia.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        InfoGerencia.Visible = False
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        InfoVentas.Visible = True
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        InfoVentas.Visible = False
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        InfoIngenieria.Visible = True
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        InfoIngenieria.Visible = False
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles Button5.MouseHover
        InfoPlaneacion.Visible = True
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles Button5.MouseLeave
        InfoPlaneacion.Visible = False
    End Sub

    Private Sub ContProyectBTN_MouseHover(sender As Object, e As EventArgs) Handles ContProyectBTN.MouseHover
        InfoControl.Visible = True
    End Sub

    Private Sub ContProyectBTN_MouseLeave(sender As Object, e As EventArgs) Handles ContProyectBTN.MouseLeave
        InfoControl.Visible = False
    End Sub
End Class
