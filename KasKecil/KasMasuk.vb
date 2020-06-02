Imports System.Data.OleDb
Public Class KasMasuk
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from pemasukan order by 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pemasukan")
        DGV.DataSource = (ds.Tables("pemasukan"))
        DGV.ReadOnly = True
    End Sub
    Sub kosongkan()
        tbac.Text = ""
        tbdari.Text = ""
        tbkeperluan.Text = ""
        tbnominal.Text = ""
        tbterbilang.Text = ""
        tbsearch.Text = ""
        tbkurs.Text = ""
        tbdari.Focus()
    End Sub
    Sub ID_pemasukan()
        Call koneksi()
        cmd = New OleDbCommand("SELECT * FROM pemasukan WHERE no_pemasukan IN(SELECT MAX(no_pemasukan) FROM pemasukan)", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = 0 Then
            tbno.Text = "00001"
        End If
        If Not rd.HasRows Then
            tbno.Text = "00001"
        Else
            tbno.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("no_pemasukan").ToString, 5, 3)) + 1
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

        da = New OleDbDataAdapter("SELECT * FROM pemasukan WHERE no_pemasukan LIKE '%" & tbsearch.Text & "%'", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "pemasukan")
        DGV.DataSource = (ds.Tables("pemasukan"))
        DGV.ReadOnly = True
        rd.Close()

    End Sub
    Sub struk()
        Try
            formstrukmasuk.Show()
            formstrukmasuk.CRV.ReportSource = Nothing
            formstrukmasuk.CRV.RefreshReport()
            formstrukmasuk.CRV.SelectionFormula = "totext({pemasukan.no_pemasukan}) ='" & tbno.Text & "'"
            formstrukmasuk.CRV.ReportSource = "strukmasuk.rpt"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub KasMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilkan()
        Call ID_pemasukan()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tbac.Text = "" Or tbdari.Text = "" Or tbkeperluan.Text = "" Or tbno.Text = "" Or tbnominal.Text = "" Or tbterbilang.Text = "" Or tbkurs.Text = "" Then
            MsgBox("Data Ada Yang Belum Di Isi !")
            Exit Sub
        Else
            cmd = New OleDbCommand("SELECT * FROM pemasukan where no_pemasukan='" & tbno.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "INSERT INTO pemasukan VALUES('" & tbno.Text & "','" & tbdari.Text & "','" & tbac.Text & "','" & dtp.Text & "','" & tbkeperluan.Text & "', '" & tbnominal.Text & "','" & tbterbilang.Text & "','" & tbkurs.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah")
                struk()
                kosongkan()
                Tampilkan()
                ID_pemasukan()
            Else
                Dim sqledit As String = "Update pemasukan set terima_dari='" & tbdari.Text & "',ac='" & tbac.Text & "',tgl_msk='" & dtp.Text & "',keperluan ='" & tbkeperluan.Text & "', nominal='" & tbnominal.Text & "',terbilang='" & tbterbilang.Text & "', kurs='" & tbkurs.Text & "' where no_pemasukan='" & tbno.Text & "'"
                cmd = New OleDbCommand(sqledit, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil DiRubah !")
                struk()
                kosongkan()
                Tampilkan()
                ID_pemasukan()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tbno.Text = "" Then
            MsgBox("Isi No Pemasukan terlebih dahulu !!")

            tbno.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin no Pemasukan akan dihapus..?", "Konfirmasi !", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE * FROM pemasukan WHERE no_pemasukan='" & tbno.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus !")
                Call kosongkan()
                Call Tampilkan()
                Call ID_pemasukan()
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
            cmd = New OleDbCommand("Select * From pemasukan WHERE no_pemasukan='" & tbno.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                tbdari.Text = rd.Item(1)
                tbac.Text = rd.Item(2)
                dtp.Text = rd.Item(3)
                tbkeperluan.Text = rd.Item(4)
                tbnominal.Text = rd.Item(5)
                tbterbilang.Text = rd.Item(6)
                tbkurs.Text = rd.Item(7)
            End If
        End If
    End Sub
End Class
