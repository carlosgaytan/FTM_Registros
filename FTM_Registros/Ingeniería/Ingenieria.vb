﻿Public Class Ingenieria
    Private Sub Ingenieria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DescarcarNumCor.NumCot' Puede moverla o quitarla según sea necesario.
        Me.NumCotTableAdapter.NumCot(Me.DescarcarNumCor.NumCot)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BuscarBTN_Click(sender As Object, e As EventArgs) Handles BuscarBTN.Click
        'TODO: esta línea de código carga datos en la tabla 'Control_Planos.BuscarCot' Puede moverla o quitarla según sea necesario.
        'Me.BuscarCotTableAdapter.BuscaCotizaciones(Me.Control_Planos.BuscarCot)

        Me.BuscarCotTableAdapter.BuscaCotizaciones(Me.Control_Planos.BuscarCot, BuscCotCNBX.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class