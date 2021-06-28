Public Class FormMenuUtama
    Private Sub btn_Close_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btn_Barang_Click(sender As Object, e As EventArgs) Handles btn_Barang.Click
        Form_Barang.ShowDialog()
    End Sub

    Private Sub btn_Penjualan_Click(sender As Object, e As EventArgs) Handles btn_Penjualan.Click
        Form_Penjualan.ShowDialog()
    End Sub

    Private Sub btn_User_Click(sender As Object, e As EventArgs) Handles btn_User.Click
        Form_User.ShowDialog()
    End Sub

    Private Sub FormMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblLevel.Text = "Kasir" Then
            btn_Barang.Enabled = False
            btn_User.Enabled = False
            btn_LaporanPenjualan.Enabled = False
            btn_Tentang.Enabled = False
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btn_LaporanPenjualan_Click(sender As Object, e As EventArgs) Handles btn_LaporanPenjualan.Click
        Form_Laporan.ShowDialog()
    End Sub

    Private Sub btn_Tentang_Click(sender As Object, e As EventArgs) Handles btn_Tentang.Click
        Form_Tentang.ShowDialog()
    End Sub

    Private Sub bt_Logout_Click(sender As Object, e As EventArgs) Handles bt_Logout.Click
        Dim keluar As String

        '' Tampil peringatan
        keluar = MsgBox("Yakin Anda ingin keluar..?", vbQuestion + vbYesNo, "Konfirmasi")
        If keluar = vbYes Then
            Me.Close()
        ElseIf keluar = vbNo Then
            Exit Sub
        End If
        Form_Login.ShowDialog()
    End Sub
End Class