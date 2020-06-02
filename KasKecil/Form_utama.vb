Public Class Form_utama

    Private Sub PengeluaranToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengeluaranToolStripMenuItem.Click
        KasKeluar.Show()
        KasKeluar.MdiParent = Me
    End Sub

    Private Sub PemasukanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemasukanToolStripMenuItem.Click
        KasMasuk.Show()
        KasMasuk.MdiParent = Me
    End Sub

    Private Sub PemasukanToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PemasukanToolStripMenuItem1.Click
        frmasuk.Show()
        frmasuk.MdiParent = Me
    End Sub

    Private Sub PengeluaranToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PengeluaranToolStripMenuItem1.Click
        frkeluar.Show()
        frkeluar.MdiParent = Me
    End Sub

    Private Sub KasbonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasbonToolStripMenuItem.Click
        kasbon.Show()
        kasbon.MdiParent = Me
    End Sub

    Private Sub KasbonToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasbonToolStripMenuItem1.Click
        frkasbon.Show()
        frkasbon.MdiParent = Me
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutMeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutMeToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub
End Class