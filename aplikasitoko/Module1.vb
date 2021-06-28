Imports System.Data.OleDb
Module Module1
    Public cmd As OleDbCommand
    Public conn As OleDbConnection
    Public rd As OleDbDataReader

    Sub koneksi()
        conn = New OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=db_penjualan.mdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        'MsgBox("Koneksi Database Berhasil")
    End Sub
End Module

