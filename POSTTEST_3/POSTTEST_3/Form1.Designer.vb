<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        btnCetakKartu = New Button()
        btnBrowse = New Button()
        grpJenisKelamin = New GroupBox()
        rbPerempuan = New RadioButton()
        rbLakiLaki = New RadioButton()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        dtpTanggalLahir = New DateTimePicker()
        txtTelepon = New TextBox()
        txtUmur = New TextBox()
        txtNama = New TextBox()
        grpHobby = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtAlamat = New TextBox()
        chkSepakBola = New CheckBox()
        chkBasket = New CheckBox()
        chkGambar = New CheckBox()
        chkFotografi = New CheckBox()
        chkMembaca = New CheckBox()
        chkBulu = New CheckBox()
        chkMusik = New CheckBox()
        chkMenulis = New CheckBox()
        chkRenang = New CheckBox()
        chkGaming = New CheckBox()
        chkMasak = New CheckBox()
        chkTenis = New CheckBox()
        GroupBox1.SuspendLayout()
        grpJenisKelamin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        grpHobby.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnCetakKartu)
        GroupBox1.Controls.Add(btnBrowse)
        GroupBox1.Controls.Add(grpJenisKelamin)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 481)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' btnCetakKartu
        ' 
        btnCetakKartu.Location = New Point(79, 433)
        btnCetakKartu.Name = "btnCetakKartu"
        btnCetakKartu.Size = New Size(94, 29)
        btnCetakKartu.TabIndex = 4
        btnCetakKartu.Text = "CETAK"
        btnCetakKartu.UseVisualStyleBackColor = True
        ' 
        ' btnBrowse
        ' 
        btnBrowse.Location = New Point(79, 239)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.Size = New Size(94, 29)
        btnBrowse.TabIndex = 3
        btnBrowse.Text = "Cari Foto"
        btnBrowse.UseVisualStyleBackColor = True
        ' 
        ' grpJenisKelamin
        ' 
        grpJenisKelamin.Controls.Add(rbPerempuan)
        grpJenisKelamin.Controls.Add(rbLakiLaki)
        grpJenisKelamin.Location = New Point(6, 274)
        grpJenisKelamin.Name = "grpJenisKelamin"
        grpJenisKelamin.Size = New Size(238, 137)
        grpJenisKelamin.TabIndex = 2
        grpJenisKelamin.TabStop = False
        grpJenisKelamin.Text = "Jenis Kelamin"
        ' 
        ' rbPerempuan
        ' 
        rbPerempuan.AutoSize = True
        rbPerempuan.Location = New Point(22, 81)
        rbPerempuan.Name = "rbPerempuan"
        rbPerempuan.Size = New Size(104, 24)
        rbPerempuan.TabIndex = 1
        rbPerempuan.TabStop = True
        rbPerempuan.Text = "Perempuan"
        rbPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbLakiLaki
        ' 
        rbLakiLaki.AutoSize = True
        rbLakiLaki.Location = New Point(22, 40)
        rbLakiLaki.Name = "rbLakiLaki"
        rbLakiLaki.Size = New Size(88, 24)
        rbLakiLaki.TabIndex = 0
        rbLakiLaki.TabStop = True
        rbLakiLaki.Text = "Laki-Laki"
        rbLakiLaki.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(62, 65)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(125, 168)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 0
        Label1.Text = "Foto Profil"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtAlamat)
        GroupBox2.Controls.Add(dtpTanggalLahir)
        GroupBox2.Controls.Add(txtTelepon)
        GroupBox2.Controls.Add(txtUmur)
        GroupBox2.Controls.Add(txtNama)
        GroupBox2.Controls.Add(grpHobby)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(268, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(520, 481)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        ' 
        ' dtpTanggalLahir
        ' 
        dtpTanggalLahir.Location = New Point(136, 154)
        dtpTanggalLahir.Name = "dtpTanggalLahir"
        dtpTanggalLahir.Size = New Size(250, 27)
        dtpTanggalLahir.TabIndex = 13
        ' 
        ' txtTelepon
        ' 
        txtTelepon.Location = New Point(136, 107)
        txtTelepon.Name = "txtTelepon"
        txtTelepon.Size = New Size(190, 27)
        txtTelepon.TabIndex = 10
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(136, 65)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(96, 27)
        txtUmur.TabIndex = 9
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(136, 23)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(378, 27)
        txtNama.TabIndex = 8
        ' 
        ' grpHobby
        ' 
        grpHobby.Controls.Add(chkGaming)
        grpHobby.Controls.Add(chkMasak)
        grpHobby.Controls.Add(chkTenis)
        grpHobby.Controls.Add(chkMusik)
        grpHobby.Controls.Add(chkMenulis)
        grpHobby.Controls.Add(chkRenang)
        grpHobby.Controls.Add(chkFotografi)
        grpHobby.Controls.Add(chkMembaca)
        grpHobby.Controls.Add(chkBulu)
        grpHobby.Controls.Add(chkGambar)
        grpHobby.Controls.Add(chkBasket)
        grpHobby.Controls.Add(chkSepakBola)
        grpHobby.Location = New Point(6, 302)
        grpHobby.Name = "grpHobby"
        grpHobby.Size = New Size(508, 160)
        grpHobby.TabIndex = 7
        grpHobby.TabStop = False
        grpHobby.Text = "Hobi (minimal pilih 1)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 199)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 20)
        Label6.TabIndex = 6
        Label6.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 154)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 5
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 4
        Label4.Text = "Nomor Telepon"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 3
        Label3.Text = "Umur"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nama Lengkap"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(136, 206)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(378, 90)
        txtAlamat.TabIndex = 14
        ' 
        ' chkSepakBola
        ' 
        chkSepakBola.AutoSize = True
        chkSepakBola.Location = New Point(37, 38)
        chkSepakBola.Name = "chkSepakBola"
        chkSepakBola.Size = New Size(105, 24)
        chkSepakBola.TabIndex = 0
        chkSepakBola.Text = "Sepak Bola"
        chkSepakBola.UseVisualStyleBackColor = True
        ' 
        ' chkBasket
        ' 
        chkBasket.AutoSize = True
        chkBasket.Location = New Point(37, 68)
        chkBasket.Name = "chkBasket"
        chkBasket.Size = New Size(74, 24)
        chkBasket.TabIndex = 1
        chkBasket.Text = "Basket"
        chkBasket.UseVisualStyleBackColor = True
        ' 
        ' chkGambar
        ' 
        chkGambar.AutoSize = True
        chkGambar.Location = New Point(37, 98)
        chkGambar.Name = "chkGambar"
        chkGambar.Size = New Size(121, 24)
        chkGambar.TabIndex = 2
        chkGambar.Text = "Menggambar"
        chkGambar.UseVisualStyleBackColor = True
        ' 
        ' chkFotografi
        ' 
        chkFotografi.AutoSize = True
        chkFotografi.Location = New Point(162, 98)
        chkFotografi.Name = "chkFotografi"
        chkFotografi.Size = New Size(92, 24)
        chkFotografi.TabIndex = 5
        chkFotografi.Text = "Fotografi"
        chkFotografi.UseVisualStyleBackColor = True
        ' 
        ' chkMembaca
        ' 
        chkMembaca.AutoSize = True
        chkMembaca.Location = New Point(162, 68)
        chkMembaca.Name = "chkMembaca"
        chkMembaca.Size = New Size(97, 24)
        chkMembaca.TabIndex = 4
        chkMembaca.Text = "Membaca"
        chkMembaca.UseVisualStyleBackColor = True
        ' 
        ' chkBulu
        ' 
        chkBulu.AutoSize = True
        chkBulu.Location = New Point(162, 38)
        chkBulu.Name = "chkBulu"
        chkBulu.Size = New Size(112, 24)
        chkBulu.TabIndex = 3
        chkBulu.Text = "Bulu Tangkis"
        chkBulu.UseVisualStyleBackColor = True
        ' 
        ' chkMusik
        ' 
        chkMusik.AutoSize = True
        chkMusik.Location = New Point(278, 98)
        chkMusik.Name = "chkMusik"
        chkMusik.Size = New Size(69, 24)
        chkMusik.TabIndex = 8
        chkMusik.Text = "Musik"
        chkMusik.UseVisualStyleBackColor = True
        ' 
        ' chkMenulis
        ' 
        chkMenulis.AutoSize = True
        chkMenulis.Location = New Point(278, 68)
        chkMenulis.Name = "chkMenulis"
        chkMenulis.Size = New Size(82, 24)
        chkMenulis.TabIndex = 7
        chkMenulis.Text = "Menulis"
        chkMenulis.UseVisualStyleBackColor = True
        ' 
        ' chkRenang
        ' 
        chkRenang.AutoSize = True
        chkRenang.Location = New Point(278, 38)
        chkRenang.Name = "chkRenang"
        chkRenang.Size = New Size(81, 24)
        chkRenang.TabIndex = 6
        chkRenang.Text = "Renang"
        chkRenang.UseVisualStyleBackColor = True
        ' 
        ' chkGaming
        ' 
        chkGaming.AutoSize = True
        chkGaming.Location = New Point(387, 98)
        chkGaming.Name = "chkGaming"
        chkGaming.Size = New Size(83, 24)
        chkGaming.TabIndex = 11
        chkGaming.Text = "Gaming"
        chkGaming.UseVisualStyleBackColor = True
        ' 
        ' chkMasak
        ' 
        chkMasak.AutoSize = True
        chkMasak.Location = New Point(387, 68)
        chkMasak.Name = "chkMasak"
        chkMasak.Size = New Size(94, 24)
        chkMasak.TabIndex = 10
        chkMasak.Text = "Memasak"
        chkMasak.UseVisualStyleBackColor = True
        ' 
        ' chkTenis
        ' 
        chkTenis.AutoSize = True
        chkTenis.Location = New Point(387, 38)
        chkTenis.Name = "chkTenis"
        chkTenis.Size = New Size(64, 24)
        chkTenis.TabIndex = 9
        chkTenis.Text = "Tenis"
        chkTenis.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 512)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form Cetak"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        grpJenisKelamin.ResumeLayout(False)
        grpJenisKelamin.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        grpHobby.ResumeLayout(False)
        grpHobby.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents btnBrowse As Button
    Friend WithEvents grpJenisKelamin As GroupBox
    Friend WithEvents grpHobby As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLakiLaki As RadioButton
    Friend WithEvents txtTelepon As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents dtpTanggalLahir As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkMasak As CheckBox
    Friend WithEvents chkTenis As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkRenang As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkMembaca As CheckBox
    Friend WithEvents chkBulu As CheckBox
    Friend WithEvents chkGambar As CheckBox
    Friend WithEvents chkBasket As CheckBox
    Friend WithEvents chkSepakBola As CheckBox

End Class
