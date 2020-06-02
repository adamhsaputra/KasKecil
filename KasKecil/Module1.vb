Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader
    Public str As String

    Public Sub koneksi()
        str = "provider=microsoft.ace.oledb.12.0;data source=kas.accdb"
        conn = New OleDbConnection(str)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

End Module
