<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgensi
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
        btnKeGrup = New Button()
        gbCari = New GroupBox()
        Label12 = New Label()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnResetSearch = New Button()
        Label4 = New Label()
        gbDataGrup = New GroupBox()
        txtTahunBerdiri = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label5 = New Label()
        btnBersihkan = New Button()
        btnHapus = New Button()
        btnUpdate = New Button()
        txtNegara = New TextBox()
        btnTambah = New Button()
        txtNama = New TextBox()
        lblStatus = New Label()
        dgvAgensi = New DataGridView()
        gbCari.SuspendLayout()
        gbDataGrup.SuspendLayout()
        CType(dgvAgensi, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnKeGrup
        ' 
        btnKeGrup.BackColor = Color.Gray
        btnKeGrup.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeGrup.ForeColor = SystemColors.Control
        btnKeGrup.Location = New Point(11, 161)
        btnKeGrup.Name = "btnKeGrup"
        btnKeGrup.Size = New Size(205, 29)
        btnKeGrup.TabIndex = 28
        btnKeGrup.Text = "Buka Form Grup"
        btnKeGrup.UseVisualStyleBackColor = False
        ' 
        ' gbCari
        ' 
        gbCari.Controls.Add(btnKeGrup)
        gbCari.Controls.Add(Label12)
        gbCari.Controls.Add(txtSearch)
        gbCari.Controls.Add(btnSearch)
        gbCari.Controls.Add(btnResetSearch)
        gbCari.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbCari.ForeColor = SystemColors.Control
        gbCari.Location = New Point(369, 65)
        gbCari.Name = "gbCari"
        gbCari.Size = New Size(234, 237)
        gbCari.TabIndex = 27
        gbCari.TabStop = False
        gbCari.Text = "Pencarian"
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
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Gray
        btnSearch.Location = New Point(11, 91)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(205, 29)
        btnSearch.TabIndex = 13
        btnSearch.Text = "Cari"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnResetSearch
        ' 
        btnResetSearch.BackColor = Color.Gray
        btnResetSearch.Location = New Point(11, 126)
        btnResetSearch.Name = "btnResetSearch"
        btnResetSearch.Size = New Size(205, 29)
        btnResetSearch.TabIndex = 14
        btnResetSearch.Text = "Reset"
        btnResetSearch.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(591, 32)
        Label4.TabIndex = 26
        Label4.Text = "SISTEM MANAJEMEN DATA GRUP K-POP"
        ' 
        ' gbDataGrup
        ' 
        gbDataGrup.Controls.Add(txtTahunBerdiri)
        gbDataGrup.Controls.Add(Label9)
        gbDataGrup.Controls.Add(Label8)
        gbDataGrup.Controls.Add(Label5)
        gbDataGrup.Controls.Add(btnBersihkan)
        gbDataGrup.Controls.Add(btnHapus)
        gbDataGrup.Controls.Add(btnUpdate)
        gbDataGrup.Controls.Add(txtNegara)
        gbDataGrup.Controls.Add(btnTambah)
        gbDataGrup.Controls.Add(txtNama)
        gbDataGrup.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        gbDataGrup.ForeColor = SystemColors.Control
        gbDataGrup.Location = New Point(12, 65)
        gbDataGrup.Name = "gbDataGrup"
        gbDataGrup.Size = New Size(351, 237)
        gbDataGrup.TabIndex = 25
        gbDataGrup.TabStop = False
        gbDataGrup.Text = "Data Agensi"
        ' 
        ' txtTahunBerdiri
        ' 
        txtTahunBerdiri.BackColor = Color.Gray
        txtTahunBerdiri.Font = New Font("Lucida Sans", 10.2F)
        txtTahunBerdiri.ForeColor = SystemColors.Control
        txtTahunBerdiri.Location = New Point(10, 107)
        txtTahunBerdiri.Name = "txtTahunBerdiri"
        txtTahunBerdiri.Size = New Size(159, 28)
        txtTahunBerdiri.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(10, 91)
        Label9.Name = "Label9"
        Label9.Size = New Size(96, 15)
        Label9.TabIndex = 25
        Label9.Text = "Tahun Berdiri"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(175, 90)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 15)
        Label8.TabIndex = 24
        Label8.Text = "Negara"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Lucida Sans", 7.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(10, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(94, 15)
        Label5.TabIndex = 21
        Label5.Text = "Nama Agensi"
        ' 
        ' btnBersihkan
        ' 
        btnBersihkan.BackColor = Color.Gray
        btnBersihkan.Location = New Point(175, 188)
        btnBersihkan.Name = "btnBersihkan"
        btnBersihkan.Size = New Size(159, 29)
        btnBersihkan.TabIndex = 12
        btnBersihkan.Text = "Bersihkan"
        btnBersihkan.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Gray
        btnHapus.Location = New Point(10, 188)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(159, 29)
        btnHapus.TabIndex = 11
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Gray
        btnUpdate.Location = New Point(175, 153)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(159, 29)
        btnUpdate.TabIndex = 10
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
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
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.Gray
        btnTambah.Location = New Point(10, 153)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(159, 29)
        btnTambah.TabIndex = 9
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.Gray
        txtNama.Font = New Font("Lucida Sans", 10.2F)
        txtNama.ForeColor = SystemColors.Control
        txtNama.Location = New Point(10, 52)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(324, 28)
        txtNama.TabIndex = 0
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Lucida Sans", 9F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = SystemColors.Control
        lblStatus.Location = New Point(22, 596)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(39, 17)
        lblStatus.TabIndex = 24
        lblStatus.Text = "Siap"
        ' 
        ' dgvAgensi
        ' 
        dgvAgensi.BackgroundColor = Color.Silver
        dgvAgensi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvAgensi.Location = New Point(12, 308)
        dgvAgensi.MultiSelect = False
        dgvAgensi.Name = "dgvAgensi"
        dgvAgensi.ReadOnly = True
        dgvAgensi.RowHeadersWidth = 51
        dgvAgensi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAgensi.Size = New Size(727, 285)
        dgvAgensi.TabIndex = 23
        ' 
        ' frmAgensi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(769, 640)
        Controls.Add(gbCari)
        Controls.Add(Label4)
        Controls.Add(gbDataGrup)
        Controls.Add(lblStatus)
        Controls.Add(dgvAgensi)
        Name = "frmAgensi"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Agensi"
        gbCari.ResumeLayout(False)
        gbCari.PerformLayout()
        gbDataGrup.ResumeLayout(False)
        gbDataGrup.PerformLayout()
        CType(dgvAgensi, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnKeGrup As Button
    Friend WithEvents gbCari As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnResetSearch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents gbDataGrup As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtNegara As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents dgvAgensi As DataGridView
    Friend WithEvents txtTahunBerdiri As TextBox
End Class
