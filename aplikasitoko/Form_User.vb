Imports System.Data.OleDb
Public Class Form_User
    Sub tampil_user()
        cmd = New OleDbCommand("select * from tbl_user", conn)
        rd = cmd.ExecuteReader
        dgv_DataUser.Rows.Clear()
        Do While rd.Read = True
            dgv_DataUser.Rows.Add(rd(0), rd(1), rd(2), rd(3), rd(4))
        Loop
    End Sub

    Sub bersih()
        txt_KodeUser.Clear()
        txt_NamaUser.Clear()
        txt_Password.Clear()
        txt_Username.Clear()
        cd_Level.Text = ""
        txt_KodeUser.Focus()
    End Sub

    Private Sub Form_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampil_user()
        Call bersih()
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()
    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click
        Call bersih()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If txt_KodeUser.Text = "" Or txt_NamaUser.Text = "" Or txt_Username.Text = "" Or txt_Password.Text = "" Or cd_Level.Text = "" Then
            MsgBox("Semua Data Wajib di Isi!!!")
        Else
            'melakukan pengecekan data user antara ada atau tidak nya
            cmd = New OleDbCommand("select * from tbl_user where kode_user='" & txt_KodeUser.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = False Then
                'melakukan penyimpanan data ke dalam database
                Call koneksi()
                cmd = New OleDbCommand("insert into tbl_user values('" & txt_KodeUser.Text &
                                       "','" & txt_NamaUser.Text &
                                       "','" & txt_Password.Text &
                                       "','" & txt_Username.Text &
                                       "','" & cd_Level.Text &
                                       "')", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Tambahkan!")
                Call bersih()
                Call Form_Barang.tampil_barang()
            Else
                'melakukan edit data user berdasarkan kode user yang dipanggil
                Call koneksi()
                cmd = New OleDbCommand("update tbl_user set nama_user = '" & txt_NamaUser.Text &
                                       "', user_name='" & txt_Username.Text &
                                       "', pwd='" & txt_Password.Text &
                                       "', lvl='" & cd_Level.Text &
                                        "' where kode_user = '" & txt_KodeUser.Text & "'", conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil Di Simpan!!")
                Call bersih()
                Call tampil_user()
            End If
        End If
    End Sub

    Private Sub txt_KodeUser_TextChanged(sender As Object, e As EventArgs) Handles txt_KodeUser.TextChanged
        'Memanggil data berdasarkan kode barang
        cmd = New OleDbCommand("select * from tbl_user where kode_user='" & txt_KodeUser.Text & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            txt_NamaUser.Text = rd(1)
            txt_Username.Text = rd(2)
            txt_Password.Text = rd(3)
            cd_Level.Text = rd(4)

        Else
            txt_NamaUser.Clear()
            txt_Username.Clear()
            txt_Password.Clear()
            cd_Level.Text = ""
        End If
    End Sub

    Private Sub btn_Delete_Click(sender As Object, e As EventArgs) Handles btn_Delete.Click
        If MsgBox("Apakah data akan di hapus..?") Then
            cmd = New OleDbCommand("delete from tbl_user where kode_user = '" & txt_KodeUser.Text & "' ", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil di delete !!!")
            Call bersih()
            Call tampil_user()
        End If
    End Sub
End Class