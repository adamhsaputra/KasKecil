Imports System.Data.OleDb
Public Class kasbon
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from kasbon order by 1", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kasbon")
        DGV.DataSource = (ds.Tables("kasbon"))
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
    Sub cari()

        da = New OleDbDataAdapter("SELECT * FROM kasbon WHERE no_kasbon LIKE '%" & tbsearch.Text & "%'", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "kasbon")
        DGV.DataSource = (ds.Tables("kasbon"))
        DGV.ReadOnly = True
        rd.Close()

    End Sub
    Sub struk()
        Try
            formstrukkeluar.Show()
            formstrukkeluar.CRV.ReportSource = Nothing
            formstrukkeluar.CRV.RefreshReport()
            formstrukkeluar.CRV.SelectionFormula = "totext({kasbon.no_kasbon}) ='" & tbno.Text & "'"
            formstrukkeluar.CRV.ReportSource = "strukkasbon.rpt"
        Catch ex As Exception

        End Try
    End Sub
    Sub ID_kasbon()
        Call koneksi()
        cmd = New OleDbCommand("SELECT * FROM kasbon WHERE no_kasbon IN(SELECT MAX(no_kasbon) FROM kasbon)", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = 0 Then
            tbno.Text = "00001"
        End If
        If Not rd.HasRows Then
            tbno.Text = "00001"
        Else
            tbno.Text = Val(Microsoft.VisualBasic.Mid(rd.Item("no_kasbon").ToString, 5, 3)) + 1
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
    Private Sub kasbon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call Tampilkan()
        Call ID_kasbon()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If tbno.Text = "" Or tbpembayaran.Text = "" Or tbkpd.Text = "" Or tbno.Text = "" Or tbnominal.Text = "" Or tbterbilang.Text = "" Or tbkurs.Text = "" Then
            MsgBox("Data Ada Yang Belum Di Isi !")
            Exit Sub
        Else
            cmd = New OleDbCommand("SELECT * FROM kasbon where no_kasbon='" & tbno.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                Dim sqltambah As String = "INSERT INTO kasbon VALUES('" & tbno.Text & "','" & tbkpd.Text & "','" & tbpembayaran.Text & "','" & dtp.Text & "','" & tbnominal.Text & "','" & tbterbilang.Text & "','" & tbkurs.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Ditambah")
                struk()
                kosongkan()
                Tampilkan()
                ID_kasbon()
            Else
                Dim sqledit As String = "Update kasbon set dibayar_kepada='" & tbkpd.Text & "',pengeluaran='" & tbpembayaran.Text & "',tanggal='" & dtp.Text & "', nominal='" & tbnominal.Text & "',terbilang='" & tbterbilang.Text & "', kurs='" & tbkurs.Text & "' where no_kasbon='" & tbno.Text & "'"
                cmd = New OleDbCommand(sqledit, Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil DiRubah !")
                struk()
                kosongkan()
                Tampilkan()
                ID_kasbon()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If tbno.Text = "" Then
            MsgBox("Isi No kasbon terlebih dahulu !!")

            tbno.Focus()
            Exit Sub
        Else
            If MessageBox.Show("Yakin no kasbon akan dihapus..?", "Konfirmasi !", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("DELETE * FROM kasbon WHERE no_kasbon='" & tbno.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Dihapus !")
                Call kosongkan()
                Call Tampilkan()
                Call ID_kasbon()
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
End Class