<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.cbdatabase = New System.Windows.Forms.ComboBox()
        Me.btnbackup = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnrestore = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnexit)
        Me.Panel1.Location = New System.Drawing.Point(-14, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 66)
        Me.Panel1.TabIndex = 1
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Transparent
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Century", 8.25!)
        Me.btnexit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnexit.Location = New System.Drawing.Point(391, 5)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(29, 25)
        Me.btnexit.TabIndex = 4
        Me.btnexit.Text = "X"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'cbdatabase
        '
        Me.cbdatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbdatabase.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbdatabase.FormattingEnabled = True
        Me.cbdatabase.Location = New System.Drawing.Point(115, 76)
        Me.cbdatabase.Name = "cbdatabase"
        Me.cbdatabase.Size = New System.Drawing.Size(281, 31)
        Me.cbdatabase.TabIndex = 2
        '
        'btnbackup
        '
        Me.btnbackup.BackColor = System.Drawing.Color.Transparent
        Me.btnbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbackup.Font = New System.Drawing.Font("Century", 8.25!)
        Me.btnbackup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnbackup.Location = New System.Drawing.Point(276, 113)
        Me.btnbackup.Name = "btnbackup"
        Me.btnbackup.Size = New System.Drawing.Size(120, 30)
        Me.btnbackup.TabIndex = 3
        Me.btnbackup.Text = "BACK-UP"
        Me.btnbackup.UseVisualStyleBackColor = False
        '
        'btnrestore
        '
        Me.btnrestore.BackColor = System.Drawing.Color.Transparent
        Me.btnrestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrestore.Font = New System.Drawing.Font("Century", 8.25!)
        Me.btnrestore.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnrestore.Location = New System.Drawing.Point(276, 149)
        Me.btnrestore.Name = "btnrestore"
        Me.btnrestore.Size = New System.Drawing.Size(120, 30)
        Me.btnrestore.TabIndex = 4
        Me.btnrestore.Text = "RESTORE"
        Me.btnrestore.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(366, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DATABASE BACK-UP AND RESTORE"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 188)
        Me.Controls.Add(Me.btnrestore)
        Me.Controls.Add(Me.btnbackup)
        Me.Controls.Add(Me.cbdatabase)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbdatabase As ComboBox
    Friend WithEvents btnbackup As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents btnrestore As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label2 As Label
End Class
