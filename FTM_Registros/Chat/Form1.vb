Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Threading

Public Class Form1

    Dim Cliente As TcpClient
    Dim Cliente1 As TcpClient
    Dim Servidor As TcpListener
    Dim Cadenas As String = Nothing
    Dim Getfile As String = Nothing
    Dim Filer As TcpListener
    Dim fileName As String = Nothing
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
    Dim LocalFiles As String = "\ArchivosTemporales3R\"


#Region "Botones"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try

            If RemoteIP.Text = "" Or Remoteport.Text = "" Then
                MsgBox("ERROR: Dirección o puerto remotos ekivokados..XD")
            Else
                If TextBox1.Text <> "" Then
                    Write(Format(Now, "yyyy.MM.dd:mm:ss") & "< ENVIADO >: " & TextBox1.Text & Environment.NewLine)
                    SendText(TextBox1.Text)
                    TextBox1.Clear()
                End If
            End If


        Catch ex As Exception
            Write("ERROR:" & ex.Message & Environment.NewLine)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            If TextBox2.Text = "" Or TextBox3.Text = "" Then
                Write("Error : Escribe una dirección y un puerto correctos." & Environment.NewLine)
            Else

                RichTextBox1.Clear()
                Dim Puerto As Int32 = CInt(TextBox3.Text)
                Dim IPlocal As IPAddress = IPAddress.Parse(TextBox2.Text)
                Servidor = New TcpListener(IPlocal, Puerto)
                Dim Hilo As New Thread(New ThreadStart(AddressOf Proceso))
                Hilo.Start()
                Button3.Enabled = False
                Button4.Enabled = True
                TextBox2.Enabled = False
                TextBox3.Enabled = False

                For Each _IPAddress As System.Net.IPAddress In GetLocalIPList()
                    Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "::< SERVIDOR LOCAL CONECTADO: " & _IPAddress.ToString() & " PUERTO: " & Puerto & " >:: " & Environment.NewLine)
                Next _IPAddress
            End If
        Catch ex As Exception
            Write(ex.Message & Environment.NewLine)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            Write("DESCONECTADO..." & Environment.NewLine)
            Button3.Enabled = True
            TextBox2.Enabled = True
            TextBox3.Enabled = True
            Servidor.Stop()
        Catch ex As Exception
            Write(ex.Message & Environment.NewLine)
        End Try
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try

            If TextBox4.Text = "" Then
                MsgBox("Escoge la dirección del archivo...")
            Else
                SendText(":FILE:" & fileName)
                Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< ENVIANDO ARCHIVO... >: " & Environment.NewLine)
            End If
        Catch ex As Exception
            Write(ex.Message & Environment.NewLine)
        End Try
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim ofd As New OpenFileDialog
        ofd.ShowDialog()
        TextBox4.Text = ofd.FileName
        fileName = Mid(ofd.FileName, InStrRev(ofd.FileName, "\") + 1, Len(ofd.FileName))
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath <> "" Then
            TextBox5.Text = FolderBrowserDialog1.SelectedPath

            Getfile = FolderBrowserDialog1.SelectedPath
            If Mid(Getfile, 1) <> "\" Then
                Getfile = Getfile & "\"
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            Try

                If RemoteIP.Text = "" Or Remoteport.Text = "" Then
                    MsgBox("ERROR: Dirección o puerto remotos ekivokados..XD")
                Else
                    If TextBox1.Text <> "" Then
                        Write(Format(Now, "yyyy.MM.dd:mm:ss") & "< ENVIADO >: " & TextBox1.Text & Environment.NewLine)
                        SendText(TextBox1.Text)
                        TextBox1.Clear()
                    End If
                End If


            Catch ex As Exception
                Write("ERROR:" & ex.Message & Environment.NewLine)
            End Try

        End If
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Process.Start("explorer.exe", TextBox5.Text)
    End Sub
#End Region

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Cliente Is Nothing Then
            End
        Else
            If Cliente.Connected = True Then
                If MsgBox("Cliente/Servidor está conectado ¿Cerrar?", MsgBoxStyle.YesNo, "Cerrar") = MsgBoxResult.Yes Then
                    Servidor.Stop()
                    End
                Else
                    e.Cancel = True
                End If
            Else
                End
            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Obtiene la ip del sistema
        Dim miip As Net.Dns
        Dim nombre_host As String = Net.Dns.GetHostName
        Dim este_host As Net.IPHostEntry = Net.Dns.GetHostByName(nombre_host)
        Dim direccion_ip As String = este_host.AddressList(0).ToString
        TextBox2.Text = direccion_ip
        '-------------------------------------------

        My.Settings.CarpetaLocal = path.ToString & LocalFiles
        TextBox5.Text = My.Settings.CarpetaLocal
        Getfile = My.Settings.CarpetaLocal
        If Not My.Computer.FileSystem.DirectoryExists(Getfile) Then
            System.IO.Directory.CreateDirectory(Getfile)
        End If
    End Sub

    Private Sub SendText(ByVal Texto As String)
        Try
            Cliente = New TcpClient(RemoteIP.Text, Remoteport.Text)
            Cliente1 = New TcpClient(RemoteIP1.Text, Remoteport1.Text)
            Dim writer As New StreamWriter(Cliente.GetStream())
            Dim writer1 As New StreamWriter(Cliente1.GetStream())
            writer.Write(Texto)
            writer1.Write(Texto)
            writer1.Flush()
            writer.Flush()
            Cliente.Close()
            Cliente1.Close()
            TextBox1.Clear()

        Catch ex As Exception
            RichTextBox1.AppendText(ex.Message & Environment.NewLine)
            RichTextBox1.SelectionStart = RichTextBox1.TextLength
            RichTextBox1.ScrollToCaret()
        End Try
    End Sub


    Public Function GetLocalIPList() As System.Net.IPAddress()
        Dim _IPHostEntry As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
        Return _IPHostEntry.AddressList
    End Function
    Private Sub Proceso()
        Servidor.Start()
        Try
            While True
                Thread.Sleep(1000)

                If Servidor.Pending = True Then
                    Cadenas = ""
                    Cliente = Servidor.AcceptTcpClient()
                    Cliente1 = Servidor.AcceptTcpClient()
                    Dim reader As New StreamReader(Cliente.GetStream)
                    Dim reader1 As New StreamReader(Cliente1.GetStream)
                    While reader.Peek > -1
                        Cadenas = Cadenas + Convert.ToChar(reader.Read()).ToString
                    End While
                    While reader1.Peek > -1
                        Cadenas = Cadenas + Convert.ToChar(reader1.Read()).ToString
                    End While
                    ProcesarCadena(Cadenas)
                End If
            End While
            Thread.ResetAbort()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub ProcesarCadena(ByVal Cadenas1 As String)

        If Cadenas1.Contains(":FILE:") Then
            If Mid(Cadenas1, 1, 6) = ":FILE:" Then

                If MsgBox("Tu contacto ha enviado un arhivo ¿Aceptar?", MsgBoxStyle.YesNo, "Transferencia de Archivos") = MsgBoxResult.Yes Then
                    fileName = Mid(Cadenas1, InStrRev(Cadenas1, ":") + 1, Len(Cadenas1))
                    Filer = New TcpListener(IPAddress.Parse(TextBox2.Text), "6666")
                    Dim Hilo2 As New Thread(New ThreadStart(AddressOf ProcesoArchivo))
                    Hilo2.Start()
                    SendText(":ACEPTADO:")
                    Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< ARCHIVO ACEPTADO COMENZANDO DESCARGA... >: " & Environment.NewLine)
                Else
                    SendText(":DENEGADO:")
                    Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< ARCHIVO DENEGADO... >: " & Environment.NewLine)
                End If

            End If
        ElseIf Cadenas1.Contains(":ACEPTADO:") Then


            If TextBox4.Text = "" Then
            Else
                Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< ARCHIVO ACEPTADO, ENVIANDO... >: " & Environment.NewLine)
                Archivo()
            End If
        ElseIf Cadenas1.Contains(":DENEGADO:") Then
            Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< ARCHIVO RECHAZADO... >: " & Environment.NewLine)
        Else
            Write(Format(Now, "yyyy.MM.dd:mm:ss") & "< RECIBIDO >: " & Cadenas1 & Environment.NewLine)

            NotifyIcon1.ShowBalloonTip(10000, "Aviso", Cadenas1 & Environment.NewLine, ToolTipIcon.Info)
        End If

    End Sub

    Public Delegate Sub Write_Richtextbox_Invoker(ByVal Text As String)
    Sub Write(ByVal Text As String)
        Try
            If InvokeRequired Then
                Invoke(New Write_Richtextbox_Invoker(AddressOf Write), Text)
                Exit Sub
            End If

            RichTextBox1.SelectionStart = RichTextBox1.TextLength
            RichTextBox1.AppendText(Text)
            RichTextBox1.ScrollToCaret()

        Catch ex As Exception
            Write("Error :: " & ex.Message)
        End Try
    End Sub

    Public Sub Archivo()
        Try

            Cliente = New TcpClient(TextBox2.Text, "6666")
            Dim nstm As Stream = Cliente.GetStream()
            Dim fstm As Stream = New FileStream(TextBox4.Text, FileMode.Open, FileAccess.Read)
            Dim buffer(1024 - 1) As Byte
            Do While True
                Dim bytesRead As Integer = fstm.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then Exit Do
                nstm.Write(buffer, 0, bytesRead)
                nstm.Flush()
            Loop
            Cliente.Close()
            nstm.Close()
            fstm.Close()
            Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< ENVIO FINALIZADO... >: " & Environment.NewLine)
        Catch ex As Exception
            Write(ex.Message)
        End Try

    End Sub

    Private Sub ProcesoArchivo()
        Filer.Start()
        While True
            Thread.Sleep(1000)
            Try
                If Filer.Pending = True Then
                    Dim n As String = Getfile & fileName
                    Cliente = Filer.AcceptTcpClient()
                    Dim s As NetworkStream = Cliente.GetStream
                    FileOpen(1, n, OpenMode.Binary)
                    Dim buffer(1024 - 1) As Byte
                    Do While True
                        Dim bytesRead As Integer = s.Read(buffer, 0, buffer.Length)
                        If bytesRead = 0 Then Exit Do
                        FilePut(1, buffer)

                    Loop
                    FileClose(1)
                    Write(Format(Now, "yyyy.MM.dd.hh:mm:ss") & "< DESCARGA COMPLETA >: " & Environment.NewLine)
                    Filer.Stop()

                End If
                Thread.ResetAbort()
            Catch ex As Exception

            End Try
        End While
    End Sub

    Private Function StrToByteArray(ByVal text As String) As Byte()
        Dim encoding As New System.Text.UTF8Encoding()
        StrToByteArray = encoding.GetBytes(text)
    End Function

End Class
