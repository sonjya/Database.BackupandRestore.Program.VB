Public Class mainform
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDatabases()
    End Sub

    Private Sub btnbackup_Click(sender As Object, e As EventArgs) Handles btnbackup.Click
        If cbdatabase.SelectedItem = "" Then
            MsgBox("NO DATABASE SELECTED")
        Else
            FolderBrowserDialog1.ShowDialog()
            Dim path As String = FolderBrowserDialog1.SelectedPath.ToString() + "\"
            backupDatabase(cbdatabase.SelectedItem, path)
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim restorepath As String = OpenFileDialog1.FileName.ToString()
        restoreDatabase(cbdatabase.SelectedItem, restorepath)
    End Sub

    Private Sub btnrestore_Click(sender As Object, e As EventArgs) Handles btnrestore.Click
        If cbdatabase.SelectedItem = "" Then
            MsgBox("NO DATABASE SELECTED")
        Else
            OpenFileDialog1.Title = "Please Select a File"
            OpenFileDialog1.InitialDirectory = "D:"
            OpenFileDialog1.ShowDialog()
        End If
    End Sub
End Class
