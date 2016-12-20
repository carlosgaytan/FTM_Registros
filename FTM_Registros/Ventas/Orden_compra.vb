Public Class Orden_compra
    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VentasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)

    End Sub

    Private Sub Orden_compra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Ventas)

    End Sub

    Private Sub GuardarBTN_Click(sender As Object, e As EventArgs) Handles GuardarBTN.Click

        'Actualiza datos de OC
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)

        MessageBox.Show("Datos guardados", "Registro exitoso")
    End Sub

    Private Sub SiguienteBTN_Click(sender As Object, e As EventArgs) Handles SiguienteIMG.Click
        Me.VentasBindingSource.MoveNext()
    End Sub

    Private Sub AnteriorBTN_Click(sender As Object, e As EventArgs) Handles AnteriorIMG.Click
        Me.VentasBindingSource.MovePrevious()
    End Sub

    Private Sub PrimerBTN_Click(sender As Object, e As EventArgs) Handles PrimerIMG.Click
        Me.VentasBindingSource.MoveFirst()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles UltimoIMG.Click
        Me.VentasBindingSource.MoveLast()
    End Sub
    Private Sub PrimerIMG_MouseHover(sender As Object, e As EventArgs) Handles PrimerIMG.MouseHover
        PrimerIMG.Size = New Size(28, 28)
    End Sub
    Private Sub PrimerIMG_MouseLeave(sender As Object, e As EventArgs) Handles PrimerIMG.MouseLeave
        PrimerIMG.Size = New Size(25, 25)
    End Sub
    Private Sub AnteriorIMG_MouseHover(sender As Object, e As EventArgs) Handles AnteriorIMG.MouseHover
        AnteriorIMG.Size = New Size(28, 28)
    End Sub
    Private Sub AnteriorIMG_MouseLeave(sender As Object, e As EventArgs) Handles AnteriorIMG.MouseLeave
        AnteriorIMG.Size = New Size(25, 25)
    End Sub
    Private Sub SiguienteIMG_MouseHover(sender As Object, e As EventArgs) Handles SiguienteIMG.MouseHover
        SiguienteIMG.Size = New Size(28, 28)
    End Sub
    Private Sub SiguienteIMG_MouseLeave(sender As Object, e As EventArgs) Handles PrimerIMG.MouseLeave, AnteriorIMG.MouseLeave, SiguienteIMG.MouseLeave, UltimoIMG.MouseLeave
        SiguienteIMG.Size = New Size(25, 25)
    End Sub
    Private Sub UltimoIMG_MouseHover(sender As Object, e As EventArgs) Handles UltimoIMG.MouseHover
        UltimoIMG.Size = New Size(28, 28)
    End Sub
    Private Sub UltimoIMG_MouseLeave(sender As Object, e As EventArgs) Handles UltimoIMG.MouseLeave
        UltimoIMG.Size = New Size(25, 25)
    End Sub

End Class