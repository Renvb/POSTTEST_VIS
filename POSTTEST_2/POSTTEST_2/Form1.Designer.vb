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
        btnTambah = New Button()
        txtTambahJudul = New TextBox()
        txtTambahGenre = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        btnHapus = New Button()
        txtHapusJudul = New TextBox()
        Label4 = New Label()
        lstDaftarBuku = New ListBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTambah)
        GroupBox1.Controls.Add(txtTambahJudul)
        GroupBox1.Controls.Add(txtTambahGenre)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(389, 209)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(256, 146)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(94, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' txtTambahJudul
        ' 
        txtTambahJudul.Location = New Point(149, 41)
        txtTambahJudul.Name = "txtTambahJudul"
        txtTambahJudul.Size = New Size(201, 31)
        txtTambahJudul.TabIndex = 3
        ' 
        ' txtTambahGenre
        ' 
        txtTambahGenre.Location = New Point(149, 88)
        txtTambahGenre.Name = "txtTambahGenre"
        txtTambahGenre.Size = New Size(201, 31)
        txtTambahGenre.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 24)
        Label2.TabIndex = 1
        Label2.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 24)
        Label1.TabIndex = 0
        Label1.Text = "Judul Buku"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnHapus)
        GroupBox2.Controls.Add(txtHapusJudul)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.Location = New Point(408, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(389, 209)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(256, 146)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 5
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' txtHapusJudul
        ' 
        txtHapusJudul.Location = New Point(149, 41)
        txtHapusJudul.Name = "txtHapusJudul"
        txtHapusJudul.Size = New Size(201, 31)
        txtHapusJudul.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 44)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 24)
        Label4.TabIndex = 0
        Label4.Text = "Judul Buku"
        ' 
        ' lstDaftarBuku
        ' 
        lstDaftarBuku.Font = New Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstDaftarBuku.FormattingEnabled = True
        lstDaftarBuku.Location = New Point(12, 244)
        lstDaftarBuku.Name = "lstDaftarBuku"
        lstDaftarBuku.Size = New Size(785, 172)
        lstDaftarBuku.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(809, 450)
        Controls.Add(lstDaftarBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Post Test 2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTambahJudul As TextBox
    Friend WithEvents txtTambahGenre As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtHapusJudul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lstDaftarBuku As ListBox

End Class
