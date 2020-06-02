<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmasuk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CRV = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tahunan = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tahun = New System.Windows.Forms.ComboBox()
        Me.bulan = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.hingga = New System.Windows.Forms.ComboBox()
        Me.dari = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Location = New System.Drawing.Point(202, 1)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = "D:\Adam\KasKecil\KasKecil\bin\Debug\Reportpemasukan.rpt"
        Me.CRV.Size = New System.Drawing.Size(855, 498)
        Me.CRV.TabIndex = 0
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tahunan)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 149)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tahunan"
        '
        'tahunan
        '
        Me.tahunan.FormattingEnabled = True
        Me.tahunan.Location = New System.Drawing.Point(27, 30)
        Me.tahunan.Name = "tahunan"
        Me.tahunan.Size = New System.Drawing.Size(121, 21)
        Me.tahunan.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 115)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.tahun)
        Me.GroupBox2.Controls.Add(Me.bulan)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 149)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bulanan"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(103, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Tampilkan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tahun
        '
        Me.tahun.FormattingEnabled = True
        Me.tahun.Location = New System.Drawing.Point(28, 77)
        Me.tahun.Name = "tahun"
        Me.tahun.Size = New System.Drawing.Size(121, 21)
        Me.tahun.TabIndex = 1
        '
        'bulan
        '
        Me.bulan.FormattingEnabled = True
        Me.bulan.Location = New System.Drawing.Point(28, 50)
        Me.bulan.Name = "bulan"
        Me.bulan.Size = New System.Drawing.Size(121, 21)
        Me.bulan.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.hingga)
        Me.GroupBox3.Controls.Add(Me.dari)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(183, 149)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pertanggal"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(102, 115)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Tampilkan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'hingga
        '
        Me.hingga.FormattingEnabled = True
        Me.hingga.Location = New System.Drawing.Point(27, 64)
        Me.hingga.Name = "hingga"
        Me.hingga.Size = New System.Drawing.Size(121, 21)
        Me.hingga.TabIndex = 1
        '
        'dari
        '
        Me.dari.FormattingEnabled = True
        Me.dari.Location = New System.Drawing.Point(27, 37)
        Me.dari.Name = "dari"
        Me.dari.Size = New System.Drawing.Size(121, 21)
        Me.dari.TabIndex = 0
        '
        'frmasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1055, 502)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CRV)
        Me.Name = "frmasuk"
        Me.Text = "Report Pemasukan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tahunan As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tahun As System.Windows.Forms.ComboBox
    Friend WithEvents bulan As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents hingga As System.Windows.Forms.ComboBox
    Friend WithEvents dari As System.Windows.Forms.ComboBox
End Class
