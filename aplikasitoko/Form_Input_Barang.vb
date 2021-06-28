Imports System.Data.OleDb
Public Class Form_Input_Barang
    Sub clear()
        txt_HargaBeli.Clear()
        txt_HargaJual.Clear()
        txt_KodeBarang.Clear()
        txt_NamaBarang.Clear()
        txt_StokBarang.Clear()
        cb_JenisBarang.Text = ""
        cb_Satuan.Text = ""
        txt_KodeBarang.Focus()
    End Sub
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Call clear()
    End Sub

    Private Sub Form_Input_Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call clear()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_KodeBarang.Text = "" Or txt_NamaBarang.Text = "" Or txt_HargaBeli.Text = "" Or txt_HargaJual.Text = "" Or txt_StokBarang.Text = "" Or cb_JenisBarang.Text = "" Or cb_Satuan.Text = "" Then
            MsgBox("Semua Data Wajib di Isi!!!")
        Else
            'melakukan pengecekan data barang antara ada atau tidak nya
            cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & txt_KodeBarang.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                'melakukan penyimpanan data ke dalam database
                cmd = New OleDbCommand("insert into tbl_barang values('" & txt_KodeBarang.Text &
                                       "','" & txt_NamaBarang.Text &
                                       "','" & cb_JenisBarang.Text &
                                       "','" & cb_Satuan.Text &
                                       "','" & txt_HargaBeli.Text &
                                       "','" & txt_HargaJual.Text &
                                       "','" & txt_StokBarang.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Tambahkan!")
                Call clear()
                Call Form_Barang.tampil_barang()
            Else
                'melakukan edit data barang berdasarkan kode barang yang dipanggil
                cmd = New OleDbCommand("update tbl_barang set nama_barang = '" & txt_NamaBarang.Text &
                                       "',jenis_barang='" & cb_JenisBarang.Text &
                                       "',satuan_barang='" & cb_Satuan.Text &
                                       "',harga_beli='" & txt_HargaBeli.Text &
                                       "',harga_jual='" & txt_HargaJual.Text &
                                       "',stok='" & txt_StokBarang.Text &
                                        "' where kode_barang = '" & txt_KodeBarang.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan!!")
                Call clear()
                Call Form_Barang.tampil_barang()


            End If
        End If
    End Sub

    Private Sub txt_KodeBarang_TextChanged(sender As Object, e As EventArgs) Handles txt_KodeBarang.TextChanged
        'Memanggil data berdasarkan kode barang
        cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & txt_KodeBarang.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_NamaBarang.Text = rd(1)
            cb_JenisBarang.Text = rd(2)
            cb_Satuan.Text = rd(3)
            txt_HargaBeli.Text = rd(4)
            txt_HargaJual.Text = rd(5)
            txt_StokBarang.Text = rd(6)
        Else
            txt_HargaBeli.Clear()
            txt_HargaJual.Clear()
            txt_NamaBarang.Clear()
            txt_StokBarang.Clear()
            cb_JenisBarang.Text = ""
            cb_Satuan.Text = ""
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            cmd = New OleDbCommand("delete from tbl_barang where kode_barang = '" & txt_KodeBarang.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call clear()
            Call Form_Barang.tampil_barang()
        End If
    End Sub
End Class