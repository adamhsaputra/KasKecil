<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KasKeluar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbkpd = New System.Windows.Forms.TextBox()
        Me.tbterbilang = New System.Windows.Forms.TextBox()
        Me.tbpembayaran = New System.Windows.Forms.TextBox()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.tbnominal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbkurs = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.sisa = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No Kas Keluar"
        '
        'tbno
        '
        Me.tbno.Location = New System.Drawing.Point(93, 21)
        Me.tbno.Name = "tbno"
        Me.tbno.Size = New System.Drawing.Size(100, 20)
        Me.tbno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Di Bayar Kepada"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nominal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Rp."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(323, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Terbilang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Pada Tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Untuk Pembayaran"
        '
        'tbkpd
        '
        Me.tbkpd.Location = New System.Drawing.Point(123, 19)
        Me.tbkpd.Name = "tbkpd"
        Me.tbkpd.Size = New System.Drawing.Size(130, 20)
        Me.tbkpd.TabIndex = 2
        '
        'tbterbilang
        '
        Me.tbterbilang.Location = New System.Drawing.Point(420, 47)
        Me.tbterbilang.Name = "tbterbilang"
        Me.tbterbilang.Size = New System.Drawing.Size(135, 20)
        Me.tbterbilang.TabIndex = 6
        '
        'tbpembayaran
        '
        Me.tbpembayaran.Location = New System.Drawing.Point(128, 79)
        Me.tbpembayaran.Name = "tbpembayaran"
        Me.tbpembayaran.Size = New System.Drawing.Size(130, 20)
        Me.tbpembayaran.TabIndex = 4
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(128, 46)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(161, 20)
        Me.dtp.TabIndex = 3
        '
        'tbnominal
        '
        Me.tbnominal.Location = New System.Drawing.Point(448, 16)
        Me.tbnominal.Name = "tbnominal"
        Me.tbnominal.Size = New System.Drawing.Size(107, 20)
        Me.tbnominal.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(323, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Kurs"
        '
        'tbkurs
        '
        Me.tbkurs.Location = New System.Drawing.Point(420, 81)
        Me.tbkurs.Name = "tbkurs"
        Me.tbkurs.Size = New System.Drawing.Size(107, 20)
        Me.tbkurs.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbkurs)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tbnominal)
        Me.GroupBox1.Controls.Add(Me.dtp)
        Me.GroupBox1.Controls.Add(Me.tbpembayaran)
        Me.GroupBox1.Controls.Add(Me.tbterbilang)
        Me.GroupBox1.Controls.Add(Me.tbkpd)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 128)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pengeluaran"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(11, 247)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(575, 202)
        Me.DGV.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 467)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Search By No."
        '
        'tbsearch
        '
        Me.tbsearch.Location = New System.Drawing.Point(93, 464)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(100, 20)
        Me.tbsearch.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 217)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(105, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Hapus"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(410, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Kosongkan"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(491, 217)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "Keluar"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'sisa
        '
        Me.sisa.AutoSize = True
        Me.sisa.Location = New System.Drawing.Point(428, 183)
        Me.sisa.Name = "sisa"
        Me.sisa.Size = New System.Drawing.Size(0, 13)
        Me.sisa.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(474, 471)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "©AdamHsaputra 2015"
        '
        'KasKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 493)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.sisa)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbsearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tbno)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KasKeluar"
        Me.Text = "KasKeluar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbno As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbkpd As System.Windows.Forms.TextBox
    Friend WithEvents tbterbilang As System.Windows.Forms.TextBox
    Friend WithEvents tbpembayaran As System.Windows.Forms.TextBox
    Friend WithEvents dtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbnominal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbkurs As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents sisa As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
