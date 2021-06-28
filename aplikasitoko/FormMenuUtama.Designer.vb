<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bt_Logout = New System.Windows.Forms.Button()
        Me.btn_LaporanPenjualan = New System.Windows.Forms.Button()
        Me.btn_Tentang = New System.Windows.Forms.Button()
        Me.btn_User = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Penjualan = New System.Windows.Forms.Button()
        Me.btn_Barang = New System.Windows.Forms.Button()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 60)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SELAMAT DATANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bt_Logout)
        Me.Panel1.Controls.Add(Me.btn_LaporanPenjualan)
        Me.Panel1.Controls.Add(Me.btn_Tentang)
        Me.Panel1.Controls.Add(Me.btn_User)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btn_Penjualan)
        Me.Panel1.Controls.Add(Me.btn_Barang)
        Me.Panel1.Controls.Add(Me.lblLevel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 60)
        Me.Panel1.TabIndex = 14
        '
        'bt_Logout
        '
        Me.bt_Logout.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bt_Logout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.bt_Logout.FlatAppearance.BorderSize = 0
        Me.bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_Logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.bt_Logout.ForeColor = System.Drawing.Color.White
        Me.bt_Logout.Location = New System.Drawing.Point(1213, 15)
        Me.bt_Logout.Name = "bt_Logout"
        Me.bt_Logout.Size = New System.Drawing.Size(82, 30)
        Me.bt_Logout.TabIndex = 8
        Me.bt_Logout.Text = "Logout"
        Me.bt_Logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bt_Logout.UseVisualStyleBackColor = False
        '
        'btn_LaporanPenjualan
        '
        Me.btn_LaporanPenjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_LaporanPenjualan.FlatAppearance.BorderSize = 0
        Me.btn_LaporanPenjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_LaporanPenjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_LaporanPenjualan.ForeColor = System.Drawing.Color.White
        Me.btn_LaporanPenjualan.Location = New System.Drawing.Point(837, 15)
        Me.btn_LaporanPenjualan.Name = "btn_LaporanPenjualan"
        Me.btn_LaporanPenjualan.Size = New System.Drawing.Size(169, 30)
        Me.btn_LaporanPenjualan.TabIndex = 2
        Me.btn_LaporanPenjualan.Text = "Laporan Penjualan"
        Me.btn_LaporanPenjualan.UseVisualStyleBackColor = False
        '
        'btn_Tentang
        '
        Me.btn_Tentang.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Tentang.FlatAppearance.BorderSize = 0
        Me.btn_Tentang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Tentang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Tentang.ForeColor = System.Drawing.Color.White
        Me.btn_Tentang.Location = New System.Drawing.Point(1008, 15)
        Me.btn_Tentang.Name = "btn_Tentang"
        Me.btn_Tentang.Size = New System.Drawing.Size(100, 30)
        Me.btn_Tentang.TabIndex = 13
        Me.btn_Tentang.Text = "Tentang"
        Me.btn_Tentang.UseVisualStyleBackColor = False
        '
        'btn_User
        '
        Me.btn_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_User.FlatAppearance.BorderSize = 0
        Me.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_User.ForeColor = System.Drawing.Color.White
        Me.btn_User.Location = New System.Drawing.Point(578, 15)
        Me.btn_User.Name = "btn_User"
        Me.btn_User.Size = New System.Drawing.Size(72, 30)
        Me.btn_User.TabIndex = 5
        Me.btn_User.Text = "User"
        Me.btn_User.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(287, 31)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(180, 2)
        Me.Panel5.TabIndex = 14
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(282, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(2, 60)
        Me.Panel3.TabIndex = 13
        '
        'btn_Penjualan
        '
        Me.btn_Penjualan.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Penjualan.FlatAppearance.BorderSize = 0
        Me.btn_Penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Penjualan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Penjualan.ForeColor = System.Drawing.Color.White
        Me.btn_Penjualan.Location = New System.Drawing.Point(735, 15)
        Me.btn_Penjualan.Name = "btn_Penjualan"
        Me.btn_Penjualan.Size = New System.Drawing.Size(100, 30)
        Me.btn_Penjualan.TabIndex = 1
        Me.btn_Penjualan.Text = "Penjualan"
        Me.btn_Penjualan.UseVisualStyleBackColor = False
        '
        'btn_Barang
        '
        Me.btn_Barang.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_Barang.FlatAppearance.BorderSize = 0
        Me.btn_Barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Barang.ForeColor = System.Drawing.Color.White
        Me.btn_Barang.Location = New System.Drawing.Point(652, 15)
        Me.btn_Barang.Name = "btn_Barang"
        Me.btn_Barang.Size = New System.Drawing.Size(81, 30)
        Me.btn_Barang.TabIndex = 0
        Me.btn_Barang.Text = "Barang"
        Me.btn_Barang.UseVisualStyleBackColor = False
        '
        'lblLevel
        '
        Me.lblLevel.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblLevel.ForeColor = System.Drawing.Color.White
        Me.lblLevel.Location = New System.Drawing.Point(291, 38)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(115, 19)
        Me.lblLevel.TabIndex = 12
        Me.lblLevel.Text = "Kasir"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNama
        '
        Me.lblNama.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNama.ForeColor = System.Drawing.Color.White
        Me.lblNama.Location = New System.Drawing.Point(291, 9)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(162, 19)
        Me.lblNama.TabIndex = 11
        Me.lblNama.Text = "M. Wahid Romid Aki"
        Me.lblNama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1300, 37)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "@copyright Kelompok 3 UAS VB.Net UNU-NTB 2021"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 527)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1300, 42)
        Me.Panel2.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = Global.aplikasitoko.My.Resources.Resources.maasterrr
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 60)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1300, 467)
        Me.Panel4.TabIndex = 18
        '
        'FormMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1300, 569)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Utama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblLevel As Label
    Friend WithEvents btn_Tentang As Button
    Friend WithEvents bt_Logout As Button
    Friend WithEvents btn_LaporanPenjualan As Button
    Friend WithEvents btn_Penjualan As Button
    Friend WithEvents btn_Barang As Button
    Friend WithEvents btn_User As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
End Class
