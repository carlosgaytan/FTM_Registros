Imports System.IO

Public Class Registros
    Private Sub Registros_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.UsuariosPermisos' Puede moverla o quitarla según sea necesario.
        Me.UsuariosPermisosTableAdapter.PermisosUser(Me._Base_de_datos_1_4_beDataSet.UsuariosPermisos)
        'Registra al usuario Logueado
        ComboBox1.Text = Control_Accesos.Usuario

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GerenciaBTN.Click

        If GerenciaCHBX.CheckState = CheckState.Checked Then
            Gerencia.Show()
        ElseIf GerenciaCHBX.CheckState = CheckState.Unchecked Then
            MessageBox.Show("No cuenta con los permisos para ingresar, consulte con el Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles VentasBTN.Click
        If VentasCHBX.CheckState = CheckState.Checked Then
            Ventas.Show()
        ElseIf VentasCHBX.CheckState = CheckState.Unchecked Then
            MessageBox.Show("No cuenta con los permisos para ingresar, consulte con el Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles IngenieriaBTN.Click
        If IngenieriaCHBX.CheckState = CheckState.Checked Then
            Ingenieria.Show()
        ElseIf IngenieriaCHBX.CheckState = CheckState.Unchecked Then
            MessageBox.Show("No cuenta con los permisos para ingresar, consulte con el Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles PlaneacionBTN.Click
        If PlaneacionCHBX.CheckState = CheckState.Checked Then
            Planeacion.Show()
        ElseIf PlaneacionCHBX.CheckState = CheckState.Unchecked Then
            MessageBox.Show("No cuenta con los permisos para ingresar, consulte con el Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Sub ContProyectBTN_Click(sender As Object, e As EventArgs) Handles ContProyectBTN.Click
        If ControlCHBX.CheckState = CheckState.Checked Then
            Control_Proyectos.Show()
        ElseIf ControlCHBX.CheckState = CheckState.Unchecked Then
            MessageBox.Show("No cuenta con los permisos para ingresar, consulte con el Administrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

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

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles GerenciaBTN.MouseHover
        InfoGerencia.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles GerenciaBTN.MouseLeave
        InfoGerencia.Visible = False
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles VentasBTN.MouseHover
        InfoVentas.Visible = True
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles VentasBTN.MouseLeave
        InfoVentas.Visible = False
    End Sub

    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles IngenieriaBTN.MouseHover
        InfoIngenieria.Visible = True
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles IngenieriaBTN.MouseLeave
        InfoIngenieria.Visible = False
    End Sub

    Private Sub Button5_MouseHover(sender As Object, e As EventArgs) Handles PlaneacionBTN.MouseHover
        InfoPlaneacion.Visible = True
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs) Handles PlaneacionBTN.MouseLeave
        InfoPlaneacion.Visible = False
    End Sub

    Private Sub ContProyectBTN_MouseHover(sender As Object, e As EventArgs) Handles ContProyectBTN.MouseHover
        InfoControl.Visible = True
    End Sub

    Private Sub ContProyectBTN_MouseLeave(sender As Object, e As EventArgs) Handles ContProyectBTN.MouseLeave
        InfoControl.Visible = False
    End Sub

    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed
        NotifyIcon1.ShowBalloonTip(10000, "Aviso", "Se genero nuevo registro", ToolTipIcon.Info)

    End Sub
End Class
