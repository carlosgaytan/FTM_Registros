Public Class Gerencia
    Private Sub BuscaMesToolStripButton_Click(sender As Object, e As EventArgs) Handles BuscarBTN.Click
        Try
            Me.BuscaVentasTableAdapter.BuscaMes(Me.ProgresoVentas.BuscaVentas, MesLTB.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Gerencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Oculta las tablas del TabControl
        Me.TabPage1.Parent = Nothing
        Me.TabPage2.Parent = Nothing
        Me.TabPage3.Parent = Nothing

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Muestra la tabla Ventas
        Me.TabPage1.Parent = Me.TabControl1
        Me.TabControl1.SelectedTab = TabPage1

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        'Muestra la tabla Ingeniería
        Me.TabPage2.Parent = Me.TabControl1
        Me.TabControl1.SelectedTab = TabPage2

    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        'Muestra la tabla Planeación/Control de proyectos
        Me.TabPage3.Parent = Me.TabControl1
        Me.TabControl1.SelectedTab = TabPage3

    End Sub
    Private Sub XventasBTN_Click(sender As Object, e As EventArgs) Handles XventasBTN.Click
        'Oculta tabla Ventas
        Me.TabPage1.Parent = Nothing
    End Sub

    Private Sub XingenieriaBTN_Click(sender As Object, e As EventArgs) Handles XingenieriaBTN.Click
        'Oculta tabla Ingeniería
        Me.TabPage2.Parent = Nothing
    End Sub

    Private Sub XplanBTN_Click(sender As Object, e As EventArgs) Handles XplanBTN.Click
        'Oculata Tabla Planeación/Control de proyectos
        Me.TabPage3.Parent = Nothing
    End Sub
End Class