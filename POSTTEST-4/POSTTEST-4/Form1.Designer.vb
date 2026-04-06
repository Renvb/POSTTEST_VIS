<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip1 = New MenuStrip()
        InputDataToolStripMenuItem = New ToolStripMenuItem()
        LihatKartuToolStripMenuItem = New ToolStripMenuItem()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        TabControl1 = New TabControl()
        tabDataUtama = New TabPage()
        cbDivisi = New ComboBox()
        Label7 = New Label()
        rbPerempuan = New RadioButton()
        rbLaki = New RadioButton()
        Label6 = New Label()
        dtpTanggalLahir = New DateTimePicker()
        Label5 = New Label()
        txtID = New TextBox()
        Label4 = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        tabKontak = New TabPage()
        Label9 = New Label()
        txtAlamat = New TextBox()
        Label8 = New Label()
        txtEmail = New TextBox()
        mtbNoTelp = New MaskedTextBox()
        Label3 = New Label()
        tabProfil = New TabPage()
        btnSimpanCetak = New Button()
        gbHobi = New GroupBox()
        chk8 = New CheckBox()
        chk7 = New CheckBox()
        chk6 = New CheckBox()
        chk5 = New CheckBox()
        chk4 = New CheckBox()
        chk3 = New CheckBox()
        chk2 = New CheckBox()
        chk1 = New CheckBox()
        GroupBox1 = New GroupBox()
        rbAnggota = New RadioButton()
        rbKoor = New RadioButton()
        rbPJ = New RadioButton()
        btnBrowse = New Button()
        picProfil = New PictureBox()
        ErrorProvider1 = New ErrorProvider(components)
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label1 = New Label()
        MenuStrip1.SuspendLayout()
        TabControl1.SuspendLayout()
        tabDataUtama.SuspendLayout()
        tabKontak.SuspendLayout()
        tabProfil.SuspendLayout()
        gbHobi.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InputDataToolStripMenuItem, LihatKartuToolStripMenuItem, SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(721, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InputDataToolStripMenuItem
        ' 
        InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        InputDataToolStripMenuItem.Size = New Size(93, 24)
        InputDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' LihatKartuToolStripMenuItem
        ' 
        LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        LihatKartuToolStripMenuItem.Size = New Size(94, 24)
        LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(109, 24)
        SimpanDataToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(91, 24)
        BukaDataToolStripMenuItem.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(65, 24)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(tabDataUtama)
        TabControl1.Controls.Add(tabKontak)
        TabControl1.Controls.Add(tabProfil)
        TabControl1.Location = New Point(12, 103)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(517, 380)
        TabControl1.TabIndex = 1
        ' 
        ' tabDataUtama
        ' 
        tabDataUtama.Controls.Add(cbDivisi)
        tabDataUtama.Controls.Add(Label7)
        tabDataUtama.Controls.Add(rbPerempuan)
        tabDataUtama.Controls.Add(rbLaki)
        tabDataUtama.Controls.Add(Label6)
        tabDataUtama.Controls.Add(dtpTanggalLahir)
        tabDataUtama.Controls.Add(Label5)
        tabDataUtama.Controls.Add(txtID)
        tabDataUtama.Controls.Add(Label4)
        tabDataUtama.Controls.Add(txtNama)
        tabDataUtama.Controls.Add(Label2)
        tabDataUtama.Location = New Point(4, 29)
        tabDataUtama.Name = "tabDataUtama"
        tabDataUtama.Padding = New Padding(3)
        tabDataUtama.Size = New Size(509, 347)
        tabDataUtama.TabIndex = 0
        tabDataUtama.Text = "Data Utama"
        tabDataUtama.UseVisualStyleBackColor = True
        ' 
        ' cbDivisi
        ' 
        cbDivisi.DropDownStyle = ComboBoxStyle.DropDownList
        cbDivisi.FormattingEnabled = True
        cbDivisi.Items.AddRange(New Object() {"Ristek", "Perkab", "Keamanan", "Acara", "Media", "Humdan", "Kestari", "Konsumsi"})
        cbDivisi.Location = New Point(147, 280)
        cbDivisi.Name = "cbDivisi"
        cbDivisi.Size = New Size(250, 28)
        cbDivisi.TabIndex = 12
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 288)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 20)
        Label7.TabIndex = 11
        Label7.Text = "Divisi"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(293, 219)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 10
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLaki
        ' 
        rbLaki.AutoSize = True
        rbLaki.Location = New Point(147, 221)
        rbLaki.Name = "rbLaki"
        rbLaki.Size = New Size(88, 24)
        rbLaki.TabIndex = 9
        rbLaki.TabStop = True
        rbLaki.Text = "Laki-Laki"
        rbLaki.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 221)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 8
        Label6.Text = "Jenis Kelamin"
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(147, 155)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 155)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 6
        Label5.Text = "Tanggal Lahir"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(147, 87)
        txtID.Name = "txtID"
        txtID.Size = New Size(250, 27)
        txtID.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 90)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 20)
        Label4.TabIndex = 4
        Label4.Text = "ID"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(147, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(250, 27)
        txtNama.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 20)
        Label2.TabIndex = 0
        Label2.Text = "Nama"
        ' 
        ' tabKontak
        ' 
        tabKontak.Controls.Add(Label9)
        tabKontak.Controls.Add(txtAlamat)
        tabKontak.Controls.Add(Label8)
        tabKontak.Controls.Add(txtEmail)
        tabKontak.Controls.Add(mtbNoTelp)
        tabKontak.Controls.Add(Label3)
        tabKontak.Location = New Point(4, 29)
        tabKontak.Name = "tabKontak"
        tabKontak.Padding = New Padding(3)
        tabKontak.Size = New Size(509, 347)
        tabKontak.TabIndex = 1
        tabKontak.Text = "Kontak"
        tabKontak.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 199)
        Label9.Name = "Label9"
        Label9.Size = New Size(57, 20)
        Label9.TabIndex = 5
        Label9.Text = "Alamat"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(148, 192)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(248, 137)
        txtAlamat.TabIndex = 4
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 112)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 20)
        Label8.TabIndex = 3
        Label8.Text = "Email"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(148, 105)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(248, 27)
        txtEmail.TabIndex = 2
        ' 
        ' mtbNoTelp
        ' 
        mtbNoTelp.Location = New Point(148, 25)
        mtbNoTelp.Mask = "0000-0000-0000"
        mtbNoTelp.Name = "mtbNoTelp"
        mtbNoTelp.Size = New Size(248, 27)
        mtbNoTelp.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 28)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 0
        Label3.Text = "Nomor Telepon"
        ' 
        ' tabProfil
        ' 
        tabProfil.Controls.Add(btnSimpanCetak)
        tabProfil.Controls.Add(gbHobi)
        tabProfil.Controls.Add(GroupBox1)
        tabProfil.Controls.Add(btnBrowse)
        tabProfil.Controls.Add(picProfil)
        tabProfil.Location = New Point(4, 29)
        tabProfil.Name = "tabProfil"
        tabProfil.Padding = New Padding(3)
        tabProfil.Size = New Size(509, 347)
        tabProfil.TabIndex = 2
        tabProfil.Text = "Profil"
        tabProfil.UseVisualStyleBackColor = True
        ' 
        ' btnSimpanCetak
        ' 
        btnSimpanCetak.Location = New Point(6, 264)
        btnSimpanCetak.Name = "btnSimpanCetak"
        btnSimpanCetak.Size = New Size(438, 46)
        btnSimpanCetak.TabIndex = 5
        btnSimpanCetak.Text = "Simpan dan Cetak Kartu"
        btnSimpanCetak.UseVisualStyleBackColor = True
        ' 
        ' gbHobi
        ' 
        gbHobi.Controls.Add(chk8)
        gbHobi.Controls.Add(chk7)
        gbHobi.Controls.Add(chk6)
        gbHobi.Controls.Add(chk5)
        gbHobi.Controls.Add(chk4)
        gbHobi.Controls.Add(chk3)
        gbHobi.Controls.Add(chk2)
        gbHobi.Controls.Add(chk1)
        gbHobi.Location = New Point(222, 25)
        gbHobi.Name = "gbHobi"
        gbHobi.Size = New Size(222, 161)
        gbHobi.TabIndex = 4
        gbHobi.TabStop = False
        gbHobi.Text = "Hobi"
        ' 
        ' chk8
        ' 
        chk8.AutoSize = True
        chk8.Location = New Point(109, 116)
        chk8.Name = "chk8"
        chk8.Size = New Size(92, 24)
        chk8.TabIndex = 7
        chk8.Text = "Olahraga"
        chk8.UseVisualStyleBackColor = True
        ' 
        ' chk7
        ' 
        chk7.AutoSize = True
        chk7.Location = New Point(109, 86)
        chk7.Name = "chk7"
        chk7.Size = New Size(92, 24)
        chk7.TabIndex = 6
        chk7.Text = "Fotografi"
        chk7.UseVisualStyleBackColor = True
        ' 
        ' chk6
        ' 
        chk6.AutoSize = True
        chk6.Location = New Point(109, 56)
        chk6.Name = "chk6"
        chk6.Size = New Size(69, 24)
        chk6.TabIndex = 5
        chk6.Text = "Musik"
        chk6.UseVisualStyleBackColor = True
        ' 
        ' chk5
        ' 
        chk5.AutoSize = True
        chk5.Location = New Point(109, 26)
        chk5.Name = "chk5"
        chk5.Size = New Size(83, 24)
        chk5.TabIndex = 4
        chk5.Text = "Gaming"
        chk5.UseVisualStyleBackColor = True
        ' 
        ' chk4
        ' 
        chk4.AutoSize = True
        chk4.Location = New Point(6, 116)
        chk4.Name = "chk4"
        chk4.Size = New Size(82, 24)
        chk4.TabIndex = 3
        chk4.Text = "Menulis"
        chk4.UseVisualStyleBackColor = True
        ' 
        ' chk3
        ' 
        chk3.AutoSize = True
        chk3.Location = New Point(6, 86)
        chk3.Name = "chk3"
        chk3.Size = New Size(76, 24)
        chk3.TabIndex = 2
        chk3.Text = "Desain"
        chk3.UseVisualStyleBackColor = True
        ' 
        ' chk2
        ' 
        chk2.AutoSize = True
        chk2.Location = New Point(6, 56)
        chk2.Name = "chk2"
        chk2.Size = New Size(79, 24)
        chk2.TabIndex = 1
        chk2.Text = "Coding"
        chk2.UseVisualStyleBackColor = True
        ' 
        ' chk1
        ' 
        chk1.AutoSize = True
        chk1.Location = New Point(6, 26)
        chk1.Name = "chk1"
        chk1.Size = New Size(97, 24)
        chk1.TabIndex = 0
        chk1.Text = "Membaca"
        chk1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbAnggota)
        GroupBox1.Controls.Add(rbKoor)
        GroupBox1.Controls.Add(rbPJ)
        GroupBox1.Location = New Point(222, 192)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(222, 66)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jabatan"
        ' 
        ' rbAnggota
        ' 
        rbAnggota.AutoSize = True
        rbAnggota.Location = New Point(122, 26)
        rbAnggota.Name = "rbAnggota"
        rbAnggota.Size = New Size(88, 24)
        rbAnggota.TabIndex = 4
        rbAnggota.TabStop = True
        rbAnggota.Text = "Anggota"
        rbAnggota.UseVisualStyleBackColor = True
        ' 
        ' rbKoor
        ' 
        rbKoor.AutoSize = True
        rbKoor.Location = New Point(54, 26)
        rbKoor.Name = "rbKoor"
        rbKoor.Size = New Size(62, 24)
        rbKoor.TabIndex = 3
        rbKoor.TabStop = True
        rbKoor.Text = "Koor"
        rbKoor.UseVisualStyleBackColor = True
        ' 
        ' rbPJ
        ' 
        rbPJ.AutoSize = True
        rbPJ.Location = New Point(6, 26)
        rbPJ.Name = "rbPJ"
        rbPJ.Size = New Size(42, 24)
        rbPJ.TabIndex = 2
        rbPJ.TabStop = True
        rbPJ.Text = "PJ"
        rbPJ.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(6, 192)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(210, 66)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Pilih Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' picProfil
        ' 
        picProfil.BackColor = Color.DarkGray
        picProfil.Location = New Point(6, 25)
        picProfil.Name = "picProfil"
        picProfil.Size = New Size(210, 161)
        picProfil.SizeMode = PictureBoxSizeMode.Zoom
        picProfil.TabIndex = 0
        picProfil.TabStop = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(16, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(513, 31)
        Label1.TabIndex = 2
        Label1.Text = "Aplikasi Pembuatan Kartu Anggota TGTV 2026"
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(721, 504)
        Controls.Add(Label1)
        Controls.Add(TabControl1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        Text = "Form Utama"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        TabControl1.ResumeLayout(False)
        tabDataUtama.ResumeLayout(False)
        tabDataUtama.PerformLayout()
        tabKontak.ResumeLayout(False)
        tabKontak.PerformLayout()
        tabProfil.ResumeLayout(False)
        gbHobi.ResumeLayout(False)
        gbHobi.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabDataUtama As TabPage
    Friend WithEvents tabKontak As TabPage
    Friend WithEvents tabProfil As TabPage
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents cbDivisi As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtbNoTelp As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents picProfil As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents gbHobi As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents rbKoor As RadioButton
    Friend WithEvents rbPJ As RadioButton
    Friend WithEvents chk4 As CheckBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents btnSimpanCetak As Button
    Friend WithEvents chk8 As CheckBox
    Friend WithEvents chk7 As CheckBox
    Friend WithEvents chk6 As CheckBox
    Friend WithEvents chk5 As CheckBox

End Class
