Imports System.Data.OleDb
Public Class Form_Penjualan
    Sub no_faktur()
        cmd = New OleDbCommand("select * from tbl_jual where faktur_jual in(select max(faktur_jual) from tbl_jual) order by faktur_jual DESC", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            txt_NoFaktur.Text = Format(Now, "yymmdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yymmdd") Then
                txt_NoFaktur.Text = Format(Now, "yymmdd") + "0001"
            Else
                txt_NoFaktur.Text = rd.Item("faktur_jual") + 1
            End If
        End If
    End Sub

    Sub grand_total()
        Dim jumlah As Decimal = 0
        For i As Integer = 0 To dgv_Hasil.Rows.Count - 1
            jumlah = jumlah + dgv_Hasil.Rows(i).Cells(6).Value
            txt_GrandTotal.Text = jumlah
        Next
        If txt_GrandTotal.Text = "" Then
            txt_GrandTotal.Text = "0"
        End If
    End Sub

    Private Sub btn_Close_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub
    Private Sub Form_Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call no_faktur()
        txt_KodeBarang.Focus()
        txt_DiBayar.Text = "0"
        txt_Kembalian.Text = "0"
        Call grand_total()
        txt_Kasir.Text = FormMenuUtama.lblNama.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txt_Tanggal.Text = Format(Now, "MM/dd/yyyy")
        txt_Jam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub txt_KodeBarang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_KodeBarang.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * From tbl_barang where kode_barang='" & txt_KodeBarang.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                txt_NamaBarang.Text = rd.Item("nama_barang")
                txt_Satuan.Text = rd.Item("satuan_barang")
                txt_JenisBarang.Text = rd.Item("jenis_barang")
                txt_Harga.Text = rd.Item("harga_jual")
                txt_QTY.Focus()
            Else
                txt_NamaBarang.Text = ""
                txt_Satuan.Text = ""
                txt_JenisBarang.Text = ""
                txt_Harga.Text = ""
                txt_KodeBarang.Focus()
                MsgBox("Barang Tidak Ditemukan / Tidak Terdaftar di Database")
            End If
        End If
    End Sub

    Sub bersih_barang()
        txt_KodeBarang.Text = ""
        txt_NamaBarang.Text = ""
        txt_Satuan.Text = ""
        txt_JenisBarang.Text = ""
        txt_Harga.Text = ""
        txt_QTY.Text = ""
        txt_KodeBarang.Focus()
    End Sub
    Private Sub txt_QTY_TextChanged(sender As Object, e As EventArgs) Handles txt_QTY.TextChanged
        Try
            txt_TotalHarga.Text = Val(txt_Harga.Text) * Val(txt_QTY.Text)
        Catch ex As Exception
            txt_TotalHarga.Text = ""
        End Try
    End Sub

    Private Sub txt_QTY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_QTY.KeyPress
        If e.KeyChar = Chr(13) Then
            dgv_Hasil.Rows.Add(txt_KodeBarang.Text, txt_NamaBarang.Text, txt_JenisBarang.Text, txt_Satuan.Text, txt_Harga.Text, txt_QTY.Text, txt_TotalHarga.Text)
            Call bersih_barang()
            Call grand_total()
        End If
    End Sub

    Private Sub txt_DiBayar_TextChanged(sender As Object, e As EventArgs) Handles txt_DiBayar.TextChanged
        Try
            txt_Kembalian.Text = Val(txt_DiBayar.Text) - Val(txt_GrandTotal.Text)
        Catch ex As Exception
            txt_Kembalian.Text = "0"
        End Try
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_GrandTotal.Text = "0" Then
            MsgBox("Belum ada barang yang di inputkan!!")
        ElseIf Val(txt_DiBayar.Text) < Val(txt_GrandTotal.Text) Then
            MsgBox("Pembayaran masih kurang!!")
        Else
            'simpan data ke tabel barang
            Call koneksi()
            cmd = New OleDbCommand("insert into tbl_jual(faktur_jual,tgl_jual,jam,grand_total,dibayar,kembalian,kasir)values('" & txt_NoFaktur.Text &
                                   "','" & txt_Tanggal.Text &
                                   "','" & txt_Jam.Text &
                                   "','" & txt_GrandTotal.Text &
                                   "','" & txt_DiBayar.Text &
                                   "','" & txt_Kembalian.Text &
                                   "','" & txt_Kasir.Text &
                                   "')", conn)
            cmd.ExecuteNonQuery()
            'simpan rincian barang dari data grid view ke tbl rinci barang
            For baris As Integer = 0 To dgv_Hasil.Rows.Count - 2
                cmd = New OleDbCommand("insert into tbl_rinci_jual values('" & txt_NoFaktur.Text &
                                       "','" & dgv_Hasil.Rows(baris).Cells(0).Value &
                                       "','" & dgv_Hasil.Rows(baris).Cells(5).Value &
                                       "','" & dgv_Hasil.Rows(baris).Cells(6).Value &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                'pengurangan stok
                cmd = New OleDbCommand("select * from tbl_barang where kode_barang='" & dgv_Hasil.Rows(baris).Cells(0).Value & "'", conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    cmd = New OleDbCommand("update tbl_barang set stok='" & rd.Item("stok") - Val(dgv_Hasil.Rows(baris).Cells(5).Value) &
                                           "'where kode_barang='" & dgv_Hasil.Rows(baris).Cells(0).Value & "'", conn)
                    cmd.ExecuteNonQuery()
                End If
            Next
            'memberihkan data transaksi
            MsgBox("Transaksi penjualan berhasil di simpan!!")
            dgv_Hasil.Rows.Clear()
            txt_GrandTotal.Text = "0"
            txt_DiBayar.Text = "0"
            txt_Kembalian.Text = "0"
            Call no_faktur()
            Call bersih_barang()
        End If
    End Sub

    Private Sub dgv_Hasil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgv_Hasil.KeyPress
        If e.KeyChar = Chr(27) Then
            Dim baris As Integer
            baris = dgv_Hasil.CurrentCell.RowIndex
            Try
                dgv_Hasil.Rows.RemoveAt(baris)
                Call grand_total()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class