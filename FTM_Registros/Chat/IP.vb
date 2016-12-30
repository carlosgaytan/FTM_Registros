Public Class IP
    Private Sub ipBTN_Click(sender As Object, e As EventArgs) Handles ipBTN.Click
        Dim miip As Net.Dns
        Dim nombre_host As String = Net.Dns.GetHostName
        Dim este_host As Net.IPHostEntry = Net.Dns.GetHostByName(nombre_host)
        Dim direccion_ip As String = este_host.AddressList(0).ToString
        ipTXT.Text = direccion_ip

    End Sub

End Class