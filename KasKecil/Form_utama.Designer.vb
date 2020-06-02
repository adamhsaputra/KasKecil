<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_utama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministrasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasukanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasbonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengeluaranToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PemasukanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasbonToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrasiToolStripMenuItem, Me.ReportToolStripMenuItem, Me.AboutMeToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1043, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministrasiToolStripMenuItem
        '
        Me.AdministrasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengeluaranToolStripMenuItem, Me.PemasukanToolStripMenuItem, Me.KasbonToolStripMenuItem})
        Me.AdministrasiToolStripMenuItem.Name = "AdministrasiToolStripMenuItem"
        Me.AdministrasiToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.AdministrasiToolStripMenuItem.Text = "Administrasi"
        '
        'PengeluaranToolStripMenuItem
        '
        Me.PengeluaranToolStripMenuItem.Name = "PengeluaranToolStripMenuItem"
        Me.PengeluaranToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PengeluaranToolStripMenuItem.Text = "Pengeluaran"
        '
        'PemasukanToolStripMenuItem
        '
        Me.PemasukanToolStripMenuItem.Name = "PemasukanToolStripMenuItem"
        Me.PemasukanToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.PemasukanToolStripMenuItem.Text = "Pemasukan"
        '
        'KasbonToolStripMenuItem
        '
        Me.KasbonToolStripMenuItem.Name = "KasbonToolStripMenuItem"
        Me.KasbonToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.KasbonToolStripMenuItem.Text = "Kasbon"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengeluaranToolStripMenuItem1, Me.PemasukanToolStripMenuItem1, Me.KasbonToolStripMenuItem1})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "Report"
        '
        'PengeluaranToolStripMenuItem1
        '
        Me.PengeluaranToolStripMenuItem1.Name = "PengeluaranToolStripMenuItem1"
        Me.PengeluaranToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.PengeluaranToolStripMenuItem1.Text = "Pengeluaran"
        '
        'PemasukanToolStripMenuItem1
        '
        Me.PemasukanToolStripMenuItem1.Name = "PemasukanToolStripMenuItem1"
        Me.PemasukanToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.PemasukanToolStripMenuItem1.Text = "Pemasukan"
        '
        'KasbonToolStripMenuItem1
        '
        Me.KasbonToolStripMenuItem1.Name = "KasbonToolStripMenuItem1"
        Me.KasbonToolStripMenuItem1.Size = New System.Drawing.Size(140, 22)
        Me.KasbonToolStripMenuItem1.Text = "Kasbon"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'AboutMeToolStripMenuItem
        '
        Me.AboutMeToolStripMenuItem.Name = "AboutMeToolStripMenuItem"
        Me.AboutMeToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.AboutMeToolStripMenuItem.Text = "About Me"
        '
        'Form_utama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1043, 590)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_utama"
        Me.Text = "Menu Utama"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdministrasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengeluaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PemasukanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PengeluaranToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PemasukanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasbonToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasbonToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
