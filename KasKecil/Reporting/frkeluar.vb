Imports System.Data.OleDb
Public Class frkeluar
    Sub tampilbulanan()
        cmd = New OleDbCommand("SELECT DISTINCT month(tanggal) FROM pengeluaran", Conn)
        rd = cmd.ExecuteReader
        bulan.Items.Clear()
        Do While rd.Read
            bulan.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub tampiltahunan()
        cmd = New OleDbCommand("SELECT DISTINCT year(tanggal) FROM pengeluaran", Conn)
        rd = cmd.ExecuteReader
        tahunan.Items.Clear()
        tahun.Items.Clear()
        Do While rd.Read
            tahunan.Items.Add(rd.Item(0))
            tahun.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub tampiltanggal()
        cmd = New OleDbCommand("SELECT DISTINCT tanggal FROM pengeluaran", Conn)
        rd = cmd.ExecuteReader
        dari.Items.Clear()
        hingga.Items.Clear()

        Do While rd.Read
            dari.Items.Add(Format(rd.Item(0), "yyyy, MM, dd"))
            hingga.Items.Add(Format(rd.Item(0), "yyyy, MM , dd"))

        Loop
    End Sub

    Private Sub frkeluar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampilbulanan()
        Call tampiltahunan()
        Call tampiltanggal()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If tahunan.Text = "" Then
                MessageBox.Show("Make Sure to Fill All Data", "Confirmation")
                Exit Sub
            Else

                Me.CRV.ReportSource = Nothing
                Me.CRV.RefreshReport()
                'Rptpinjaman.CRV.SelectionFormula = "totext({tb_pembayaran.tgl_pemb}) ='" & bulan.Text & "'"
                Me.CRV.SelectionFormula = "Year({pengeluaran.tanggal}) =" & tahunan.Text
                Me.CRV.ReportSource = "Reportpengeluaran.rpt"
                'Rptpinjaman.CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If bulan.Text = "" Or tahun.Text = "" Then
                MessageBox.Show("Make Sure to Fill All Data", "Confirmation")
                Exit Sub
            Else

                Me.CRV.ReportSource = Nothing
                Me.CRV.RefreshReport()
                'Rptpinjaman.CRV.SelectionFormula = "totext({tb_pembayaran.tgl_pemb}) ='" & bulan.Text & "'"
                Me.CRV.SelectionFormula = "Month({pengeluaran.tanggal}) =" & bulan.Text & " AND Year({pengeluaran.tanggal}) =" & tahun.Text
                Me.CRV.ReportSource = "Reportpengeluaran.rpt"
                'Rptpinjaman.CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If dari.Text = "" Or hingga.Text = "" Then
                MessageBox.Show("Make Sure to Fill All Data", "Confirmation")
                Exit Sub
            Else
                Me.Show()
                Me.CRV.ReportSource = Nothing
                Me.CRV.RefreshReport()
                'Rptpinjaman.CRV.SelectionFormula = "totext({tb_pembayaran.tgl_pemb}) ='" & bulan.Text & "'"
                Me.CRV.SelectionFormula = "{pengeluaran.tanggal} in date (" & dari.Text & ") to date (" & hingga.Text & ")"
                Me.CRV.ReportSource = "Reportpengeluaran.rpt"
                'Rptpinjaman.CRV.RefreshReport()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class