<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Penjualan
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_GrandTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_Kasir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Tanggal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Jam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_NoFaktur = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.txt_Kembalian = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_DiBayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgv_Hasil = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_KodeBarang = New System.Windows.Forms.TextBox()
        Me.txt_NamaBarang = New System.Windows.Forms.TextBox()
        Me.txt_Satuan = New System.Windows.Forms.TextBox()
        Me.txt_JenisBarang = New System.Windows.Forms.TextBox()
        Me.txt_Harga = New System.Windows.Forms.TextBox()
        Me.txt_QTY = New System.Windows.Forms.TextBox()
        Me.txt_TotalHarga = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgv_Hasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1348, 185)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_GrandTotal)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(462, 22)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(883, 160)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grand Total"
        '
        'txt_GrandTotal
        '
        Me.txt_GrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txt_GrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_GrandTotal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt_GrandTotal.Font = New System.Drawing.Font("DS-Digital", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GrandTotal.ForeColor = System.Drawing.Color.GreenYellow
        Me.txt_GrandTotal.Location = New System.Drawing.Point(3, 22)
        Me.txt_GrandTotal.Multiline = True
        Me.txt_GrandTotal.Name = "txt_GrandTotal"
        Me.txt_GrandTotal.ReadOnly = True
        Me.txt_GrandTotal.Size = New System.Drawing.Size(877, 135)
        Me.txt_GrandTotal.TabIndex = 32
        Me.txt_GrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_Kasir)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_Tanggal)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txt_Jam)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_NoFaktur)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 160)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'txt_Kasir
        '
        Me.txt_Kasir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Kasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Kasir.Location = New System.Drawing.Point(241, 118)
        Me.txt_Kasir.Name = "txt_Kasir"
        Me.txt_Kasir.ReadOnly = True
        Me.txt_Kasir.Size = New System.Drawing.Size(179, 26)
        Me.txt_Kasir.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(239, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 18)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Kasir"
        '
        'txt_Tanggal
        '
        Me.txt_Tanggal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Tanggal.Location = New System.Drawing.Point(240, 60)
        Me.txt_Tanggal.Name = "txt_Tanggal"
        Me.txt_Tanggal.ReadOnly = True
        Me.txt_Tanggal.Size = New System.Drawing.Size(179, 26)
        Me.txt_Tanggal.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(238, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tanggal"
        '
        'txt_Jam
        '
        Me.txt_Jam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Jam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Jam.Location = New System.Drawing.Point(14, 118)
        Me.txt_Jam.Name = "txt_Jam"
        Me.txt_Jam.ReadOnly = True
        Me.txt_Jam.Size = New System.Drawing.Size(179, 26)
        Me.txt_Jam.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Jam"
        '
        'txt_NoFaktur
        '
        Me.txt_NoFaktur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NoFaktur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_NoFaktur.Location = New System.Drawing.Point(13, 60)
        Me.txt_NoFaktur.Name = "txt_NoFaktur"
        Me.txt_NoFaktur.ReadOnly = True
        Me.txt_NoFaktur.Size = New System.Drawing.Size(179, 26)
        Me.txt_NoFaktur.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "No Faktur"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_Close)
        Me.GroupBox4.Controls.Add(Me.btn_Clear)
        Me.GroupBox4.Controls.Add(Me.btn_Save)
        Me.GroupBox4.Controls.Add(Me.txt_Kembalian)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txt_DiBayar)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 437)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1348, 113)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pembayaran"
        '
        'btn_Close
        '
        Me.btn_Close.BackColor = System.Drawing.Color.Gray
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.White
        Me.btn_Close.Location = New System.Drawing.Point(1084, 50)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(115, 44)
        Me.btn_Close.TabIndex = 31
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'btn_Clear
        '
        Me.btn_Clear.BackColor = System.Drawing.Color.Gray
        Me.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Clear.ForeColor = System.Drawing.Color.White
        Me.btn_Clear.Location = New System.Drawing.Point(959, 50)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(106, 44)
        Me.btn_Clear.TabIndex = 30
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = False
        '
        'btn_Save
        '
        Me.btn_Save.BackColor = System.Drawing.Color.Gray
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btn_Save.ForeColor = System.Drawing.Color.White
        Me.btn_Save.Location = New System.Drawing.Point(831, 50)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(105, 44)
        Me.btn_Save.TabIndex = 29
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = False
        '
        'txt_Kembalian
        '
        Me.txt_Kembalian.BackColor = System.Drawing.Color.Silver
        Me.txt_Kembalian.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Kembalian.Font = New System.Drawing.Font("DS-Digital", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Kembalian.ForeColor = System.Drawing.Color.Navy
        Me.txt_Kembalian.Location = New System.Drawing.Point(390, 50)
        Me.txt_Kembalian.Name = "txt_Kembalian"
        Me.txt_Kembalian.ReadOnly = True
        Me.txt_Kembalian.Size = New System.Drawing.Size(338, 37)
        Me.txt_Kembalian.TabIndex = 23
        Me.txt_Kembalian.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(387, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 18)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Kembalian"
        '
        'txt_DiBayar
        '
        Me.txt_DiBayar.BackColor = System.Drawing.Color.Silver
        Me.txt_DiBayar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_DiBayar.Font = New System.Drawing.Font("DS-Digital", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DiBayar.ForeColor = System.Drawing.Color.Navy
        Me.txt_DiBayar.Location = New System.Drawing.Point(36, 50)
        Me.txt_DiBayar.Name = "txt_DiBayar"
        Me.txt_DiBayar.Size = New System.Drawing.Size(338, 37)
        Me.txt_DiBayar.TabIndex = 21
        Me.txt_DiBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(34, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Di Bayar"
        '
        'dgv_Hasil
        '
        Me.dgv_Hasil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Hasil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Hasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Hasil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_Hasil.Location = New System.Drawing.Point(12, 258)
        Me.dgv_Hasil.Name = "dgv_Hasil"
        Me.dgv_Hasil.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Hasil.Size = New System.Drawing.Size(1324, 155)
        Me.dgv_Hasil.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 250
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jenis Barang"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "Satuan"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 200
        '
        'Column5
        '
        Me.Column5.HeaderText = "Harga"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 200
        '
        'Column6
        '
        Me.Column6.HeaderText = "QTY"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Total Harga"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 150
        '
        'txt_KodeBarang
        '
        Me.txt_KodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_KodeBarang.Location = New System.Drawing.Point(12, 217)
        Me.txt_KodeBarang.Name = "txt_KodeBarang"
        Me.txt_KodeBarang.Size = New System.Drawing.Size(243, 26)
        Me.txt_KodeBarang.TabIndex = 20
        '
        'txt_NamaBarang
        '
        Me.txt_NamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_NamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_NamaBarang.Location = New System.Drawing.Point(255, 217)
        Me.txt_NamaBarang.Name = "txt_NamaBarang"
        Me.txt_NamaBarang.ReadOnly = True
        Me.txt_NamaBarang.Size = New System.Drawing.Size(250, 26)
        Me.txt_NamaBarang.TabIndex = 21
        '
        'txt_Satuan
        '
        Me.txt_Satuan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Satuan.Location = New System.Drawing.Point(705, 217)
        Me.txt_Satuan.Name = "txt_Satuan"
        Me.txt_Satuan.ReadOnly = True
        Me.txt_Satuan.Size = New System.Drawing.Size(200, 26)
        Me.txt_Satuan.TabIndex = 23
        '
        'txt_JenisBarang
        '
        Me.txt_JenisBarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_JenisBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_JenisBarang.Location = New System.Drawing.Point(505, 217)
        Me.txt_JenisBarang.Name = "txt_JenisBarang"
        Me.txt_JenisBarang.ReadOnly = True
        Me.txt_JenisBarang.Size = New System.Drawing.Size(200, 26)
        Me.txt_JenisBarang.TabIndex = 22
        '
        'txt_Harga
        '
        Me.txt_Harga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Harga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_Harga.Location = New System.Drawing.Point(905, 217)
        Me.txt_Harga.Name = "txt_Harga"
        Me.txt_Harga.ReadOnly = True
        Me.txt_Harga.Size = New System.Drawing.Size(200, 26)
        Me.txt_Harga.TabIndex = 24
        Me.txt_Harga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_QTY
        '
        Me.txt_QTY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_QTY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_QTY.Location = New System.Drawing.Point(1105, 217)
        Me.txt_QTY.Name = "txt_QTY"
        Me.txt_QTY.Size = New System.Drawing.Size(100, 26)
        Me.txt_QTY.TabIndex = 25
        Me.txt_QTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_TotalHarga
        '
        Me.txt_TotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_TotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txt_TotalHarga.Location = New System.Drawing.Point(1205, 217)
        Me.txt_TotalHarga.Name = "txt_TotalHarga"
        Me.txt_TotalHarga.ReadOnly = True
        Me.txt_TotalHarga.Size = New System.Drawing.Size(151, 26)
        Me.txt_TotalHarga.TabIndex = 26
        Me.txt_TotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form_Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 550)
        Me.Controls.Add(Me.txt_TotalHarga)
        Me.Controls.Add(Me.txt_QTY)
        Me.Controls.Add(Me.txt_Harga)
        Me.Controls.Add(Me.txt_Satuan)
        Me.Controls.Add(Me.txt_JenisBarang)
        Me.Controls.Add(Me.txt_NamaBarang)
        Me.Controls.Add(Me.txt_KodeBarang)
        Me.Controls.Add(Me.dgv_Hasil)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Penjualan"
        Me.ShowInTaskbar = False
        Me.Text = "Form_Penjualan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgv_Hasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txt_Kasir As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Tanggal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Jam As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_NoFaktur As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_DiBayar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Kembalian As TextBox
    Friend WithEvents btn_Close As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Save As Button
    Friend WithEvents txt_GrandTotal As TextBox
    Friend WithEvents dgv_Hasil As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txt_KodeBarang As TextBox
    Friend WithEvents txt_NamaBarang As TextBox
    Friend WithEvents txt_Satuan As TextBox
    Friend WithEvents txt_JenisBarang As TextBox
    Friend WithEvents txt_Harga As TextBox
    Friend WithEvents txt_QTY As TextBox
    Friend WithEvents txt_TotalHarga As TextBox
    Friend WithEvents Timer1 As Timer
End Class
