Public Class frmAgensi

    Private _selectedID As Integer = -1
    Private Sub frmAgensi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        ResetForm()
        SetStatusBar("Form Agensi siap.")
    End Sub
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim pesanError As String = ModHelper.ValidasiInputAgensi(
            txtNama.Text, txtNegara.Text, txtTahunBerdiri.Text)
        If pesanError <> String.Empty Then
            ModHelper.TampilkanError(pesanError) : Return
        End If

        If ModAgensi.NamaAgensiSudahAda(txtNama.Text) Then
            ModHelper.TampilkanError($"Agensi '{txtNama.Text.Trim()}' sudah terdaftar.") : Return
        End If

        Try
            Dim agensi As New ModAgensi.AgensiModel With {
                .Nama = txtNama.Text.Trim(),
                .Negara = txtNegara.Text.Trim(),
                .TahunBerdiri = CInt(txtTahunBerdiri.Text)
            }

            ModAgensi.TambahAgensi(agensi)
            RefreshGrid()
            ResetForm()
            SetStatusBar($"Agensi '{agensi.Nama}' berhasil ditambahkan.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal menambah agensi: " & ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If _selectedID = -1 Then
            ModHelper.TampilkanError("Pilih data dari tabel terlebih dahulu.") : Return
        End If

        Dim pesanError As String = ModHelper.ValidasiInputAgensi(
            txtNama.Text, txtNegara.Text, txtTahunBerdiri.Text)
        If pesanError <> String.Empty Then
            ModHelper.TampilkanError(pesanError) : Return
        End If

        If ModAgensi.NamaAgensiSudahAda(txtNama.Text, excludeID:=_selectedID) Then
            ModHelper.TampilkanError($"Nama agensi '{txtNama.Text.Trim()}' sudah digunakan oleh data lain.") : Return
        End If

        If Not ModHelper.Konfirmasi($"Update data agensi '{txtNama.Text.Trim()}'?", "Konfirmasi Update") Then Return

        Try
            Dim agensi As New ModAgensi.AgensiModel With {
                .ID = _selectedID,
                .Nama = txtNama.Text.Trim(),
                .Negara = txtNegara.Text.Trim(),
                .TahunBerdiri = CInt(txtTahunBerdiri.Text)
            }

            ModAgensi.UpdateAgensi(agensi)
            RefreshGrid()
            ResetForm()
            SetStatusBar($"Agensi '{agensi.Nama}' berhasil diupdate.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal mengupdate agensi: " & ex.Message)
        End Try
    End Sub
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If _selectedID = -1 Then
            ModHelper.TampilkanError("Pilih data dari tabel terlebih dahulu.") : Return
        End If

        Dim jumlahGrup As Integer = ModAgensi.GetJumlahGrupByAgensi(_selectedID)
        If jumlahGrup > 0 Then
            ModHelper.TampilkanError(
                $"Agensi '{txtNama.Text.Trim()}' tidak dapat dihapus karena masih menaungi {jumlahGrup} grup.")
            Return
        End If

        If Not ModHelper.Konfirmasi($"Hapus agensi '{txtNama.Text.Trim()}'?", "Konfirmasi Hapus") Then Return

        Try
            ModAgensi.HapusAgensi(_selectedID)
            RefreshGrid()
            ResetForm()
            SetStatusBar($"Agensi '{txtNama.Text.Trim()}' berhasil dihapus.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal menghapus agensi: " & ex.Message)
        End Try
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        EksekusiSearch()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        EksekusiSearch()
    End Sub

    Private Sub EksekusiSearch()
        Try
            Dim keyword As String = txtSearch.Text.Trim()
            Dim dt As DataTable

            If String.IsNullOrEmpty(keyword) Then
                dt = ModAgensi.GetSemuaAgensi()
            Else
                Dim dtSemua As DataTable = ModAgensi.GetSemuaAgensi()
                Dim view As New DataView(dtSemua)
                view.RowFilter = $"[Nama Agensi] LIKE '%{keyword}%' OR [Negara] LIKE '%{keyword}%'"
                dt = view.ToTable()
            End If

            dgvAgensi.DataSource = dt
            SetStatusBar($"Ditemukan {dt.Rows.Count} agensi.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal melakukan pencarian: " & ex.Message)
        End Try
    End Sub

    Private Sub btnResetSearch_Click(sender As Object, e As EventArgs) Handles btnResetSearch.Click
        txtSearch.Text = String.Empty
        RefreshGrid()
        SetStatusBar("Pencarian direset.")
    End Sub
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        ResetForm()
        SetStatusBar("Form dibersihkan.")
    End Sub
    Private Sub dgvAgensi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAgensi.CellClick
        If e.RowIndex < 0 Then Return

        Try
            Dim row As DataGridViewRow = dgvAgensi.Rows(e.RowIndex)
            _selectedID = CInt(row.Cells("ID").Value)

            Dim agensi As ModAgensi.AgensiModel = ModAgensi.GetAgensiByID(_selectedID)
            If agensi Is Nothing Then Return

            txtNama.Text = agensi.Nama
            txtNegara.Text = agensi.Negara
            txtTahunBerdiri.Text = agensi.TahunBerdiri.ToString()

            SetStatusBar($"Agensi '{agensi.Nama}' dipilih. Siap untuk Update atau Hapus.")

        Catch ex As Exception
            ModHelper.TampilkanError("Gagal memuat data: " & ex.Message)
        End Try
    End Sub
    Private Sub btnKeGrup_Click(sender As Object, e As EventArgs) Handles btnKeGrup.Click
        Dim frm As New frmKpopManagement()
        frm.Show()
        Me.Close()
    End Sub
    Private Sub RefreshGrid()
        Try
            dgvAgensi.DataSource = ModAgensi.GetSemuaAgensi()
        Catch ex As Exception
            ModHelper.TampilkanError("Gagal memuat data agensi: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        _selectedID = -1
        txtNama.Text = String.Empty
        txtNegara.Text = "Korea Selatan"
        txtTahunBerdiri.Text = String.Empty
        txtNama.Focus()
    End Sub

    Private Sub SetStatusBar(pesan As String)
        lblStatus.Text = pesan
    End Sub

End Class