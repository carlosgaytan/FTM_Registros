Public Class Manufactura
    Dim ESP1, ESP2 As Object
    Private Sub Manufactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Manufactura' Puede moverla o quitarla según sea necesario.
        Me.ManufacturaTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Manufactura)
        'TODO: esta línea de código carga datos en la tabla '_Manufactura_1_5DataSet.Pza_Control_de_planos' Puede moverla o quitarla según sea necesario.
        Me.Pza_Control_de_planosTableAdapter.Fill(Me._Manufactura_1_5DataSet.Pza_Control_de_planos)
        'TODO: esta línea de código carga datos en la tabla '_Base_de_datos_1_4_beDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.Fill(Me._Base_de_datos_1_4_beDataSet.Ventas)

    End Sub
    Private Sub Espesor1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Espesor1TextBox.TextChanged, Espesor2TextBox.TextChanged, MILIMETROSCheckBox.CheckedChanged, MILI.TextChanged

        'Convierte in a mm y viceversa
        If MILIMETROSCheckBox.CheckState = CheckState.Checked Then
            EspesorMM.Text = MILI.Text
        ElseIf Espesor2TextBox.Text > uno.Text Then
            ESP1 = (Val(Espesor1TextBox.Text) / Val(Espesor2TextBox.Text)) * MM.Text
            EspesorMM.Text = ESP1
        ElseIf Espesor2TextBox.Text <= uno.Text Then
            ESP2 = Val(Espesor1TextBox.Text) * MM.Text
            EspesorMM.Text = ESP2
        End If
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Enter
        in_mm.Text = "Espesor in:"
        fraccion.Text = "/"
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        'Muestra si el espesor son in
        Espesor2TextBox.Show()
        fraccion.Show()
        in_mm.Text = "Espesor in:"
        fraccion.Text = "/"
        MILI.Clear()

    End Sub

    Private Sub GuardarToolStripButton1_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton1.Click
        Me.Validate()
        Me.Pza_Control_de_planosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)

    End Sub

    Private Sub GuardarToolStripButton_Click(sender As Object, e As EventArgs) Handles GuardarToolStripButton.Click
        Me.Validate()
        Me.ManufacturaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._Base_de_datos_1_4_beDataSet)

    End Sub

    Private Sub MILIMETROSCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles MILIMETROSCheckBox.CheckedChanged

        'Muestra u oculta recuadro in
        If MILIMETROSCheckBox.CheckState = CheckState.Checked Then
            MILI.Show()
            Espesor1TextBox.Hide()
            Espesor2TextBox.Hide()
            fraccion.Hide()
            in_mm.Text = "Espesor mm:"
        ElseIf MILIMETROSCheckBox.CheckState = CheckState.Unchecked Then
            MILI.Hide()
            Espesor1TextBox.Show()
            Espesor2TextBox.Show()
            fraccion.Show()
            in_mm.Text = "Espesor in:"
            fraccion.Text = "/"
        End If

    End Sub

End Class