<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formstrukmasuk
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
        Me.strukmasuk1 = New KasKecil.strukmasuk()
        Me.strukmasuk2 = New KasKecil.strukmasuk()
        Me.SuspendLayout()
        '
        'CRV
        '
        Me.CRV.ActiveViewIndex = 0
        Me.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRV.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRV.Location = New System.Drawing.Point(0, 0)
        Me.CRV.Name = "CRV"
        Me.CRV.ReportSource = "D:\Adam\KasKecil\KasKecil\bin\Debug\strukmasuk.rpt"
        Me.CRV.Size = New System.Drawing.Size(837, 379)
        Me.CRV.TabIndex = 0
        Me.CRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'formstrukmasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 379)
        Me.Controls.Add(Me.CRV)
        Me.Name = "formstrukmasuk"
        Me.Text = "formstrukmasuk"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CRV As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents strukmasuk2 As KasKecil.strukmasuk
    Friend WithEvents strukmasuk1 As KasKecil.strukmasuk
End Class
