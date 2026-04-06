<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmKpopManagement
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
        txtNamaGrup = New TextBox()
        txtAgensi = New TextBox()
        txtNegara = New TextBox()
        txtMember = New TextBox()
        txtLagu = New TextBox()
        txtSearch = New TextBox()
        cmbGenre = New ComboBox()
        cmbFilter = New ComboBox()
        nudTahun = New NumericUpDown()
        btnTambah = New Button()
        btnUpdate = New Button()
        btnHapus = New Button()
        btnBersihkan = New Button()
        btnSearch = New Button()
        btnResetSearch = New Button()
        dgvGrup = New DataGridView()
        lblStatus = New Label()
        gbDataGrup = New GroupBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        gbCari = New GroupBox()
        lblTotalMember = New Label()
        lblTotalGrup = New Label()
        Label1 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        CType(nudTahun, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvGrup, ComponentModel.ISupportInitialize).BeginInit()
        gbDataGrup.SuspendLayout()
        gbCari.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNamaGrup
        ' 
        txtNamaGrup.BackColor = Color.Gray
        txtNamaGrup.Font = New Font("Lucida Sans", 10.2F)
        txtNamaGrup.ForeColor = SystemColors.Control
        txtNamaGrup.Location = New Point(10, 52)
        txtNamaGrup.Name = "txtNamaGrup"
        txtNamaGrup.Size = New Size(159, 28)
        txtNamaGrup.TabIndex = 0
        ' 
        ' txtAgensi
        ' 
        txtAgensi.BackColor = Color.Gray
        txtAgensi.Font = New Font("Lucida Sans", 10.2F)
        txtAgensi.ForeColor = SystemColors.Control
        txtAgensi.Location = New Point(175, 52)
        txtAgensi.Name = "txtAgensi"
        txtAgensi.Size = New Size(159, 28)
        txtAgensi.TabIndex = 1
        ' 
        ' txtNegara
        ' 
        txtNegara.BackColor = Color.Gray
        txtNegara.Font = New Font("Lucida Sans", 10.2F)
        txtNegara.ForeColor = SystemColors.Control
        txtNegara.Location = New Point(175, 108)
        txtNegara.Name = "txtNegara"
        txtNegara.Size = New Size(159, 28)
        txtNegara.TabIndex = 2
        ' 
        ' txtMember
        ' 
        txtMember.BackColor = Color.Gray
        txtMember.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMember.ForeColor = SystemColors.Control
        txtMember.Location = New Point(175, 167)
        txtMember.Name = "txtMember"
        txtMember.Size = New Size(159, 28)
        txtMember.TabIndex = 3
        ' 
        ' txtLagu
        ' 
        txtLagu.BackColor = Color.Gray
        txtLagu.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLagu.ForeColor = SystemColors.Control
        txtLagu.Location = New Point(10, 223)
        txtLagu.Name = "txtLagu"
        txtLagu.Size = New Size(324, 28)
        txtLagu.TabIndex = 4
        ' 
        ' txtSearch
        ' 
        txtSearch.BackColor = Color.Gray
        txtSearch.Font = New Font("Lucida Sans", 10.2F)
        txtSearch.ForeColor = SystemColors.Control
        txtSearch.Location = New Point(11, 51)
        txtSearch.Name = "txtSearch"
        txtSearch.PlaceholderText = "Cari..."
        txtSearch.Size = New Size(205, 28)
        txtSearch.TabIndex = 5
        ' 
        ' cmbGenre
        ' 
        cmbGenre.BackColor = Color.Gray
        cmbGenre.Font = New Font("Lucida Sans", 10.2F)
        cmbGenre.ForeColor = SystemColors.Control
        cmbGenre.FormattingEnabled = True
        cmbGenre.Items.AddRange(New Object() {"Pop", "R&B", "Hip-Hop", "Ballad", "Dance"})
        cmbGenre.Location = New Point(10, 108)
        cmbGenre.Name = "cmbGenre"
        cmbGenre.Size = New Size(159, 27)
        cmbGenre.TabIndex = 6
        ' 
        ' cmbFilter
        ' 
        cmbFilter.BackColor = SystemColors.Control
        cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList
        cmbFilter.Font = New Font("Lucida Sans", 10.2F)
        cmbFilter.FormattingEnabled = True
        cmbFilter.Items.AddRange(New Object() {"Semua", "Nama Grup", "Agensi", "Genre", "Negara"})
        cmbFilter.Location = New Point(11, 108)
        cmbFilter.Name = "cmbFilter"
        cmbFilter.Size = New Size(205, 27)
        cmbFilter.TabIndex = 7
        ' 
        ' nudTahun
        ' 
        nudTahun.BackColor = Color.Gray
        nudTahun.Font = New Font("Lucida Sans", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudTahun.ForeColor = SystemColors.Control
        nudTahun.InterceptArrowKeys = False
        nudTahun.Location = New Point(10, 167)
        nudTahun.Maximum = New Decimal(New Integer() {2030, 0, 0, 0})
        nudTahun.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        nudTahun.Name = "nudTahun"
        nudTahun.Size = New Size(159, 28)
        nudTahun.TabIndex = 8
        nudTahun.Value = New Decimal(New Integer() {1990, 0, 0, 0})
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Gray
        btnTambah.Location = New Point(10, 257)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(159, 29)
        btnTambah.TabIndex = 9
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gray
        btnUpdate.Location = New Point(175, 257)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(159, 29)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Gray
        btnHapus.Location = New Point(10, 292)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(159, 29)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.BackColor = Color.Gray
        btnBersihkan.Location = New Point(175, 292)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(159, 29)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Gray
        btnSearch.Location = New Point(11, 141)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(205, 29)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnResetSearch
        ' 
        btnResetSearch.BackColor = Color.Gray
        btnResetSearch.Location = New Point(11, 176)
        btnResetSearch.Name = "btnResetSearch"
        btnResetSearch.Size = New Size(205, 29)
        btnResetSearch.TabIndex = 14
        btnResetSearch.Text = "Reset"
        btnResetSearch.UseVisualStyleBackColor = False
        ' 
        ' dgvGrup
        ' 
        dgvGrup.BackgroundColor = Color.Silver
        dgvGrup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvGrup.Location = New Point(12, 420)
        dgvGrup.MultiSelect = False
        dgvGrup.Name = "dgvGrup"
        dgvGrup.ReadOnly = True
        dgvGrup.RowHeadersWidth = 51
        dgvGrup.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGrup.Size = New Size(1055, 285)
        dgvGrup.TabIndex = 15
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Lucida Sans", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.Control
        lblStatus.Location = New Point(22, 708)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.TabIndex = 16
        lblStatus.Text = "Siap"
        ' 
        ' gbDataGrup
        ' 
        gbDataGrup.Controls.Add(Label11)
        gbDataGrup.Controls.Add(Label10)
        gbDataGrup.Controls.Add(Label9)
        gbDataGrup.Controls.Add(Label8)
        gbDataGrup.Controls.Add(Label7)
        gbDataGrup.Controls.Add(Label6)
        gbDataGrup.Controls.Add(Label5)
        gbDataGrup.Controls.Add(btnBersihkan)
        gbDataGrup.Controls.Add(txtAgensi)
        gbDataGrup.Controls.Add(btnHapus)
        gbDataGrup.Controls.Add(cmbGenre)
        gbDataGrup.Controls.Add(btnUpdate)
        gbDataGrup.Controls.Add(txtNegara)
        gbDataGrup.Controls.Add(btnTambah)
        gbDataGrup.Controls.Add(nudTahun)
        gbDataGrup.Controls.Add(txtMember)
        gbDataGrup.Controls.Add(txtLagu)
        gbDataGrup.Controls.Add(txtNamaGrup)
        gbDataGrup.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbDataGrup.ForeColor = SystemColors.Control
        gbDataGrup.Location = New Point(12, 72)
        gbDataGrup.Name = "gbDataGrup"
        gbDataGrup.Size = New Size(351, 342)
        gbDataGrup.TabIndex = 19
        gbDataGrup.TabStop = False
        gbDataGrup.Text = "Data Grup"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(10, 205)
        Label11.Name = "Label11"
        Label11.Size = New Size(94, 15)
        Label11.TabIndex = 27
        Label11.Text = "Lagu Populer"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(175, 149)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 15)
        Label10.TabIndex = 26
        Label10.Text = "Jumlah Member"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(10, 149)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 15)
        Label9.TabIndex = 25
        Label9.Text = "Tahun Debut"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(175, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 15)
        Label8.TabIndex = 24
        Label8.Text = "Negara Asal"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(10, 90)
        Label7.Name = "Label7"
        Label7.Size = New Size(47, 15)
        Label7.TabIndex = 23
        Label7.Text = "Genre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(175, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 22
        Label6.Text = "Agensi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(10, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 15)
        Label5.TabIndex = 21
        Label5.Text = "Nama Grup"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(12, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(591, 32)
        Label4.TabIndex = 20
        Label4.Text = "SISTEM MANAJEMEN DATA GRUP K-POP"
        ' 
        ' gbCari
        ' 
        gbCari.Controls.Add(lblTotalMember)
        gbCari.Controls.Add(lblTotalGrup)
        gbCari.Controls.Add(Label1)
        gbCari.Controls.Add(Label13)
        gbCari.Controls.Add(Label12)
        gbCari.Controls.Add(txtSearch)
        gbCari.Controls.Add(cmbFilter)
        gbCari.Controls.Add(btnSearch)
        gbCari.Controls.Add(btnResetSearch)
        gbCari.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbCari.ForeColor = SystemColors.Control
        gbCari.Location = New Point(369, 72)
        gbCari.Name = "gbCari"
        gbCari.Size = New Size(234, 342)
        gbCari.TabIndex = 21
        gbCari.TabStop = False
        gbCari.Text = "Pencarian"
        ' 
        ' lblTotalMember
        ' 
        lblTotalMember.AutoSize = True
        lblTotalMember.Location = New Point(11, 292)
        lblTotalMember.Name = "lblTotalMember"
        lblTotalMember.Size = New Size(14, 19)
        lblTotalMember.TabIndex = 27
        lblTotalMember.Text = "-"
        ' 
        ' lblTotalGrup
        ' 
        lblTotalGrup.AutoSize = True
        lblTotalGrup.Location = New Point(11, 257)
        lblTotalGrup.Name = "lblTotalGrup"
        lblTotalGrup.Size = New Size(14, 19)
        lblTotalGrup.TabIndex = 25
        lblTotalGrup.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(11, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 15)
        Label1.TabIndex = 24
        Label1.Text = "Ringkasan"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(11, 90)
        Label13.Name = "Label13"
        Label13.Size = New Size(43, 15)
        Label13.TabIndex = 23
        Label13.Text = "Filter"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(11, 33)
        Label12.Name = "Label12"
        Label12.Size = New Size(34, 15)
        Label12.TabIndex = 22
        Label12.Text = "Cari"
        ' 
        ' frmKpopManagement
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(1077, 764)
        Controls.Add(gbCari)
        Controls.Add(Label4)
        Controls.Add(gbDataGrup)
        Controls.Add(lblStatus)
        Controls.Add(dgvGrup)
        Name = "frmKpopManagement"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Data Grup K-Pop"
        CType(nudTahun, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvGrup, ComponentModel.ISupportInitialize).EndInit()
        gbDataGrup.ResumeLayout(False)
        gbDataGrup.PerformLayout()
        gbCari.ResumeLayout(False)
        gbCari.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNamaGrup As TextBox
    Friend WithEvents txtAgensi As TextBox
    Friend WithEvents txtNegara As TextBox
    Friend WithEvents txtMember As TextBox
    Friend WithEvents txtLagu As TextBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents cmbGenre As ComboBox
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents nudTahun As NumericUpDown
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnResetSearch As Button
    Friend WithEvents dgvGrup As DataGridView
    Friend WithEvents lblStatus As Label
    Friend WithEvents gbDataGrup As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gbCari As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblTotalGrup As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalMember As Label

End Class
