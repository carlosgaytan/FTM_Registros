Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblUsuarioActivoTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.tblUsuarioActivo)
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.tblUsuarios' Puede moverla o quitarla según sea necesario.
        Me.TblUsuariosTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.tblUsuarios)
        'Mostrar Fecha y Hora
        Fecha.Text = DateTime.Now.ToLongDateString()
        Hora.Text = DateTime.Now.ToLongTimeString()
        Me.Validate()
        Me.TblUsuarioActivoBindingSource.AddNew()
        GUARDARCHBX.CheckState = CheckState.Unchecked

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Actualiza el reloj en tiempo real
        Hora.Text = DateTime.Now.ToLongTimeString
    End Sub

    'Ingreso usuario/contraseña
    Private Sub Entrar_Click(sender As Object, e As EventArgs) Handles Entrar.Click

        If UsuarioTextBox.Text = IdUsuarioListBox.Text And txtContraseña.Text = PasswordTXT.Text Then
            GUARDARCHBX.CheckState = CheckState.Checked

            MsgBox("Bienvenid@ " & NameTXT.Text & ", puede ingresar al sistema", Title:="FTM Registros")
            LblIncorrecto.Hide()
            txtContraseña.Clear()
            TxtIdUsuario.Clear()
            Control_Accesos.Usuario = NameTXT.Text
            Dim F2 As New Registros()
            Registros.Show()
            Me.Hide()

        ElseIf UsuarioTextBox.Text <> IdUsuarioListBox.Text Or txtContraseña.Text <> PasswordTXT.Text Then
            LblIncorrecto.Show()
            LblIncorrecto.Text = "Usuario y/o contraseña incorrectos"
        End If

    End Sub
    Private Sub TxtIdUsuario_TextChanged(sender As Object, e As EventArgs) Handles UsuarioTextBox.TextChanged
        IdUsuarioListBox.Text = UsuarioTextBox.Text
        IdUsuarioListBox.Refresh()
        HoraTextBox.Text = Hora.Text
        DiaTextBox.Text = Fecha.Text

    End Sub

    Private Sub GUARDARCHBX_CheckedChanged(sender As Object, e As EventArgs) Handles GUARDARCHBX.CheckedChanged
        If GUARDARCHBX.CheckState = CheckState.Checked Then
            Me.Validate()
            Me.TblUsuarioActivoBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)

        End If
    End Sub

    Private Sub txtContraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If UsuarioTextBox.Text = IdUsuarioListBox.Text And txtContraseña.Text = PasswordTXT.Text Then
                GUARDARCHBX.CheckState = CheckState.Checked

                MsgBox("Bienvenid@ " & NameTXT.Text & ", puede ingresar al sistema", Title:="FTM Registros")
                LblIncorrecto.Hide()
                txtContraseña.Clear()
                TxtIdUsuario.Clear()
                Control_Accesos.Usuario = NameTXT.Text
                Dim F2 As New Registros()
                Registros.Show()
                Me.Hide()

            ElseIf UsuarioTextBox.Text <> IdUsuarioListBox.Text Or txtContraseña.Text <> PasswordTXT.Text Then
                LblIncorrecto.Show()
                LblIncorrecto.Text = "Usuario y/o contraseña incorrectos"
            End If
        End If
    End Sub
End Class
