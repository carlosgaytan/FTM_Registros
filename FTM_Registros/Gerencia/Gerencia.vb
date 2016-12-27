Public Class Gerencia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ventas.Click
        Me.TabPage2.Parent = Me.TabControl1
        Me.TabControl1.SelectedTab = TabPage2

    End Sub
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
        Me.TabPage2.Parent = Nothing

    End Sub
End Class