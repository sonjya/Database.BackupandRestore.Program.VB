Imports System.IO
Imports MySql.Data.MySqlClient
Module main
    'opening of connections here...
    Public con As New MySqlConnection
    Sub connectdb()
        If con.State = ConnectionState.Closed Then
            con = New MySqlConnection("server=localhost; userid=root; password=; database=;")
            con.Open()
        End If
    End Sub
    'closing of connections here...
    Sub disconnectdb()
        con.Close()
    End Sub
    'showing databases to combox here...
    Public Sub getDatabases()
        Try
            connectdb()
            Dim ds As New DataSet
            Dim sql As String = "show databases"
            Dim da As New MySqlDataAdapter(sql, con)
            da.Fill(ds, "databases")
            For i As Integer = 0 To ds.Tables("databases").Rows.Count - 1
                mainform.cbdatabase.Items.Add(ds.Tables("databases").Rows(i)(0))
            Next
            disconnectdb()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            disconnectdb()
        End Try
    End Sub
    'back-up databasee
    Public Sub backupDatabase(database, path)
        Try
            Dim dt As String = Date.Now.ToString("---MM-dd-yyyy---hh-mm-ss-tt")
            Process.Start("C:\xampp\mysql\bin\mysqldump.exe", "-u root " & database & " -r """ & path & "" & database + dt & ".sql""")
            MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub restoreDatabase(database, path)
        Try
            Dim myProcess As New Process()

            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
            Dim myStreamerReader As StreamReader = myProcess.StandardOutput
            myStreamerWriter.WriteLine("mysql -u root " & database & " < " & path & "")
            myStreamerWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()

            MsgBox("Database Restoration Successfully!", MsgBoxStyle.Information, "Restore")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module


