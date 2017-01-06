Imports System.IO

Public Class Revision_docs
    Private Sub FileSystemWatcher1_Changed(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Changed

        'Monitorea cambios en los archivos
        ListBox1.Items.Add("Se genero nuevo registro " & e.Name.ToString & " en la fecha: " & DateString.ToString & " a las " & TimeString.ToString)
        NotifyIcon1.ShowBalloonTip(10000, "Aviso", "Se genero nuevo registro", ToolTipIcon.Info)

    End Sub

    Private Sub FileSystemWatcher1_Created(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Created

        'Monitorea la creación de nuevos archivos
        ListBox1.Items.Add("Nuevo archivo creado " & e.Name.ToString & " en la fecha: " & DateString.ToString & " a las " & TimeString.ToString)

    End Sub

    Private Sub FileSystemWatcher1_Deleted(sender As Object, e As FileSystemEventArgs) Handles FileSystemWatcher1.Deleted

        'Monitorea los archivos borrados
        ListBox1.Items.Add("Archivo eliminado " & e.Name.ToString & " en la fecha: " & DateString.ToString & " a las " & TimeString.ToString)

    End Sub

    Private Sub FileSystemWatcher1_Renamed(sender As Object, e As RenamedEventArgs) Handles FileSystemWatcher1.Renamed

        'Monitorea el cambio de nombre de archivos
        ListBox1.Items.Add("Archivo renombrado " & e.Name.ToString & " en la fecha: " & DateString.ToString & " a las " & TimeString.ToString)
    End Sub

End Class