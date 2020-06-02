Imports System.Data.OleDb
Public Class KasKeluar
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from pengeluaran order by 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengeluaran")
        DGV.DataSource = (ds.Tables("pengeluaran"))
        DGV.ReadOnly = True
    End Sub
    Sub kosongkan()
        tbpembayaran.Text = ""
        tbkpd.Text = ""
        tbnominal.Text = ""
        tbterbilang.Text = ""
        tbsearch.Text = ""
        tbkurs.Text = ""
        tbno.Focus()
    End Sub
    Sub ID_pengeluaran()
        Call koneksi()
        cmd = New OleDbCommand("SELECT * FROM pengeluaran WHERE no_pengeluaran IN(SELECT MAX(no_pengeluaran) FROM pengeluaran)", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = 0 Then
            tbno.Text = "00001"
        End If
        If Not rd.HasRows Then
            tbno.Text = "00001"
        Else
            tbno.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("no_pengeluaran").ToString, 5, 3)) + 1
            If Len(tbno.Text) = 1 Then
                tbno.Text = "0000" & tbno.Text & ""
            ElseIf Len(tbno.Text) = 2 Then
                tbno.Text = "000" & tbno.Text & ""
            ElseIf Len(tbno.Text) = 3 Then
                tbno.Text = "00" & tbno.Text & ""
            ElseIf Len(tbno.Text) = 4 Then
                tbno.Text = "0" & tbno.Text & ""
            End If
            rd.Close()
        End If
    End Sub
    Sub cari()

        da = New OleDbDataAdapter("SELECT * FROM pengeluaran WHERE no_pengeluaran LIKE '%" & tbsearch.Text & "%'", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pengeluaran")
        DGV.DataSource = (ds.Tables("pengeluaran"))
        DGV.ReadOnly = True
        rd.Close()

    End Sub
    Sub struk()
        Try
            formstrukkeluar.Show()
            formstrukkeluar.CRV.ReportSource = Nothing
            formstrukkeluar.CRV.RefreshReport()
            formstrukkeluar.CRV.SelectionFormula = "totext({pengeluaran.no_pengeluaran}) ='" & tbno.Text & "'"
            formstrukkeluar.CRV.ReportSource = "strukkeluar.rpt"
        Catch ex As Exception

        End Try
    End Sub
    Private Sub KasKeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilkan()
        Call ID_pengeluaran()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tbno.Text = "" Or tbpembayaran.Text = "" Or tbkpd.Text = "" Or tbno.Text = "" Or tbnominal.Text = "" Or tbterbilang.Text = "" Or tbkurs.Text = "" Then
            MsgBox("Data Ada Yang Belum Di Isi !")
            Exit Sub
        Else
            cmd = New OleDbCommand("SELECT * FROM pengeluaran where no_pengeluaran='" & tbno.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "INSERT INTO pengeluaran VALUES('" & tbno.Text & "','" & tbkpd.Text & "','" & tbpembayaran.Text & "','" & dtp.Text & "','" & tbnominal.Text & "','" & tbterbilang.Text & "','" & tbkurs.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah")
                struk()
                kosongkan()
                Tampilkan()
                ID_pengeluaran()
            Else
                Dim sqledit As String = "Update pengeluaran set dibayar_kepada='" & tbkpd.Text & "',pengeluaran='" & tbpembayaran.Text & "',tanggal='" & dtp.Text & "', nominal='" & tbnominal.Text & "',terbilang='" & tbterbilang.Text & "', kurs='" & tbkurs.Text & "' where no_pengeluaran='" & tbno.Text & "'"
                cmd = New OleDbCommand(sqledit, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil DiRubah !")
                struk()
                kosongkan()
                Tampilkan()
                ID_pengeluaran()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tbno.Text = "" Then
            MsgBox("Isi No pengeluaran terlebih dahulu !!")

            tbno.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin no pengeluaran akan dihapus..?", "Konfirmasi !", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE * FROM pengeluaran WHERE no_pengeluaran='" & tbno.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus !")
                Call kosongkan()
                Call Tampilkan()
                Call ID_pengeluaran()
            Else
                Call kosongkan()

            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Call kosongkan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        Call cari()
    End Sub

    Private Sub tbno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbno.KeyPress
        tbno.MaxLength = 6
        If e.KeyChar = Chr(11) Or e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("Select * From pengeluaran WHERE no_pengeluaran='" & tbno.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                tbkpd.Text = rd.Item(1)
                tbpembayaran.Text = rd.Item(2)
                dtp.Text = rd.Item(3)
                tbnominal.Text = rd.Item(4)
                tbterbilang.Text = rd.Item(5)
                tbkurs.Text = rd.Item(6)
            End If
        End If
    End Sub

    Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick

    End Sub

   
End Class