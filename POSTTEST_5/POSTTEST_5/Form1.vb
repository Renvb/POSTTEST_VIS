Public Class frmKpopManagement

    Private _selectedID As Integer = -1
    Private Sub frmKpopManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ModKoneksi.TestKoneksi() Then
            ModHelper.TampilkanError("Tidak dapat terhubung ke database.")
            Me.Close()
            Return
        End If

        MuatComboBoxAgensi()
        RefreshGrid()
        ResetForm()
        cmbFilter.SelectedIndex = 0
        SetStatusBar("Form Grup siap.")
    End Sub
    Private Sub MuatComboBoxAgensi()
        Try
            Dim dt As DataTable = ModAgensi.GetAgensiUntukComboBox()
            cmbAgensi.DataSource = dt
            cmbAgensi.DisplayMember = "nama"
            cmbAgensi.ValueMember = "id"
            cmbAgensi.SelectedIndex = -1
        Catch ex As Exception
            ModHelper.TampilkanError("Gagal memuat data agensi: " & ex.Message)
        End Try
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If cmbAgensi.SelectedIndex = -1 Then
            ModHelper.TampilkanError("Pilih agensi terlebih dahulu.") : Return
        End If

        Dim pesanError As String = ModHelper.ValidasiInput(
            txtNamaGrup.Text, cmbAgensi.Text, txtMember.Text, txtTahun.Text)
        If pesanError <> String.Empty Then
            ModHelper.TampilkanError(pesanError) : Return
        End If

        If ModGrup.NamaGrupSudahAda(txtNamaGrup.Text) Then
            ModHelper.TampilkanError($"Grup '{txtNamaGrup.Text.Trim()}' sudah terdaftar.") : Return
        End If

        Try
            Dim grup As New ModGrup.GrupModel With {
                .NamaGrup = txtNamaGrup.Text.Trim(),
                .AgensiID = CInt(cmbAgensi.SelectedValue),
                .Genre = cmbGenre.Text,
                .Negara = txtNegara.Text.Trim(),
                .TahunDebut = CInt(txtTahun.Text),
                .JmlMember = CInt(txtMember.Text),
                .LaguPopuler = txtLagu.Text.Trim()
            }

            ModGrup.TambahGrup(grup)
            RefreshGrid()
            ResetForm()
            SetStatusBar($"Grup '{grup.NamaGrup}' berhasil ditambahkan.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal menambah data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If _selectedID = -1 Then
            ModHelper.TampilkanError("Pilih data dari tabel terlebih dahulu.") : Return
        End If
        If cmbAgensi.SelectedIndex = -1 Then
            ModHelper.TampilkanError("Pilih agensi terlebih dahulu.") : Return
        End If

        Dim pesanError As String = ModHelper.ValidasiInput(
            txtNamaGrup.Text, cmbAgensi.Text, txtMember.Text, txtTahun.Text)
        If pesanError <> String.Empty Then
            ModHelper.TampilkanError(pesanError) : Return
        End If

        If ModGrup.NamaGrupSudahAda(txtNamaGrup.Text, excludeID:=_selectedID) Then
            ModHelper.TampilkanError($"Nama grup '{txtNamaGrup.Text.Trim()}' sudah digunakan.") : Return
        End If

        If Not ModHelper.Konfirmasi($"Update data grup '{txtNamaGrup.Text.Trim()}'?", "Konfirmasi Update") Then Return

        Try
            Dim grup As New ModGrup.GrupModel With {
                .ID = _selectedID,
                .NamaGrup = txtNamaGrup.Text.Trim(),
                .AgensiID = CInt(cmbAgensi.SelectedValue),
                .Genre = cmbGenre.Text,
                .Negara = txtNegara.Text.Trim(),
                .TahunDebut = CInt(txtTahun.Text),
                .JmlMember = CInt(txtMember.Text),
                .LaguPopuler = txtLagu.Text.Trim()
            }

            ModGrup.UpdateGrup(grup)
            RefreshGrid()
            ResetForm()
            SetStatusBar($"Data grup '{grup.NamaGrup}' berhasil diupdate.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal mengupdate data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If _selectedID = -1 Then
            ModHelper.TampilkanError("Pilih data dari tabel terlebih dahulu.") : Return
        End If

        Dim namaGrup As String = txtNamaGrup.Text.Trim()
        If Not ModHelper.Konfirmasi($"Hapus grup '{namaGrup}'?", "Konfirmasi Hapus") Then Return

        Try
            ModGrup.HapusGrup(_selectedID)
            RefreshGrid()
            ResetForm()
            SetStatusBar($"Grup '{namaGrup}' berhasil dihapus.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal menghapus data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        EksekusiSearch()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        EksekusiSearch()
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        EksekusiSearch()
    End Sub

    Private Sub EksekusiSearch()
        Try
            Dim keyword As String = txtSearch.Text
            Dim filter As ModGrup.FilterKolom = CType(cmbFilter.SelectedIndex, ModGrup.FilterKolom)
            Dim dt As DataTable = ModGrup.CariGrup(keyword, filter)

            dgvGrup.DataSource = dt
            SetStatusBar($"Ditemukan {dt.Rows.Count} grup.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal melakukan pencarian: " & ex.Message)
        End Try
    End Sub

    Private Sub btnResetSearch_Click(sender As Object, e As EventArgs) Handles btnResetSearch.Click
        txtSearch.Text = String.Empty
        cmbFilter.SelectedIndex = 0
        RefreshGrid()
        SetStatusBar("Pencarian direset.")
    End Sub
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        ResetForm()
        SetStatusBar("Form dibersihkan.")
    End Sub
    Private Sub dgvGrup_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGrup.CellClick
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = dgvGrup.Rows(e.RowIndex)
            _selectedID = CInt(row.Cells("ID").Value)

            Dim grup As ModGrup.GrupModel = ModGrup.GetGrupByID(_selectedID)
            If grup Is Nothing Then Return

            txtNamaGrup.Text = grup.NamaGrup
            txtNegara.Text = grup.Negara
            txtMember.Text = grup.JmlMember.ToString()
            txtLagu.Text = grup.LaguPopuler
            txtTahun.Text = grup.TahunDebut.ToString()

            Dim idxGenre As Integer = cmbGenre.Items.IndexOf(grup.Genre)
            cmbGenre.SelectedIndex = If(idxGenre >= 0, idxGenre, 0)

            cmbAgensi.SelectedValue = grup.AgensiID

            SetStatusBar($"Data '{grup.NamaGrup}' dipilih. Siap untuk Update atau Hapus.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal memuat data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnKeAgensi_Click(sender As Object, e As EventArgs) Handles btnKeAgensi.Click
        Dim frm As New frmAgensi()
        frm.Show()
        Me.Close()
    End Sub
    Private Sub RefreshGrid()
        Try
            dgvGrup.DataSource = ModGrup.GetSemuaGrup()
            RefreshSummary()
        Catch ex As Exception
            ModHelper.TampilkanError("Gagal memuat data: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshSummary()
        Dim s As Tuple(Of Integer, Integer) = ModGrup.GetSummary()
        lblTotalGrup.Text = "Total Grup: " & s.Item1
        lblTotalMember.Text = "Total Member: " & s.Item2
    End Sub

    Private Sub ResetForm()
        _selectedID = -1
        txtNamaGrup.Text = String.Empty
        txtNegara.Text = "Korea Selatan"
        txtMember.Text = String.Empty
        txtLagu.Text = String.Empty
        txtTahun.Text = String.Empty
        cmbGenre.SelectedIndex = 0
        cmbAgensi.SelectedIndex = -1
        txtNamaGrup.Focus()
    End Sub

    Private Sub SetStatusBar(pesan As String)
        lblStatus.Text = pesan
    End Sub

End Class