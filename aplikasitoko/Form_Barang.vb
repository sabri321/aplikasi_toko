Imports System.Data.OleDb
Public Class Form_Barang
    Sub tampil_barang()
        cmd = New OleDbCommand("select * from tbl_barang", conn)
        rd = cmd.ExecuteReader
        dgv_Barang.Rows.Clear()
        Do While rd.Read = True
            dgv_Barang.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Form_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_barang()
    End Sub

    Private Sub txt_Cari_TextChanged(sender As Object, e As EventArgs) Handles txt_Cari.TextChanged
        cmd = New OleDbCommand("select * from tbl_barang where nama_barang like '%" & txt_Cari.Text & "%'", conn)
        rd = cmd.ExecuteReader
        dgv_Barang.Rows.Clear()
        Do While rd.Read = True
            dgv_Barang.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4), rd(5), rd(6))
        Loop
    End Sub

    Private Sub btn_Tambah_Click(sender As Object, e As EventArgs) Handles btn_Tambah.Click
        Form_Input_Barang.ShowDialog()
    End Sub
End Class