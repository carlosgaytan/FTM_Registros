Public Class PrubMoneda
    Dim WebBrowser1 As New WebBrowser
    Private Sub NavBTN_Click(sender As Object, e As EventArgs) Handles NavBTN.Click

        WebBrowser1.Navigate("http://www.banxico.org.mx/tipcamb/llenarTiposCambioAction.do?idioma=sp")
        ESPERA(3000)

        DatosTXT.Text = WebBrowser1.Document.GetElementById("FIX_DATO").InnerText
        DatosTXT.Text = WebBrowser1.Document.GetElementById("EURO_DATO").InnerText
        DatosTXT.Text = WebBrowser1.Document.GetElementById("YEN_DATO").InnerText
        DatosTXT.Text = WebBrowser1.Document.GetElementById("LIBRA_DATO").InnerText


    End Sub

    Public Sub ESPERA(ByVal INTERVALO As Integer)
        Dim PARADA As New Stopwatch
        PARADA.Start()
        Do While PARADA.ElapsedMilliseconds < INTERVALO
            Application.DoEvents()
        Loop
        PARADA.Stop()
    End Sub

End Class