Imports System.Data.OleDb
Public Class Form_Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username atau Password Masih Kosong!!")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from tbl_user where user_name='" & txtUsername.Text & "' and pwd='" & txtPassword.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                FormMenuUtama.lblLevel.Text = rd.Item("lvl")
                FormMenuUtama.lblNama.Text = rd.Item("nama_user")
                Me.Hide()
                FormMenuUtama.Show()
            Else
                MsgBox("Password atau Username Salah")
            End If
        End If
    End Sub

    Private Sub Form_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class