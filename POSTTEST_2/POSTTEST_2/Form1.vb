Public Class Form1

    Public Sub RefreshListBox()
        lstDaftarBuku.Items.Clear()
        For i As Integer = 0 To jumlahBuku - 1
            lstDaftarBuku.Items.Add(arrJudul(i) & " (" & arrGenre(i) & ")")
        Next
    End Sub

    Public Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim judul As String = txtTambahJudul.Text.Trim()
        Dim genre As String = txtTambahGenre.Text.Trim()

        If judul = "" Or genre = "" Then
            MessageBox.Show("Judul dan Genre tidak boleh kosong!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If IsDuplikat(judul) Then
            MessageBox.Show("Buku '" & judul & "' sudah ada dalam daftar!",
                            "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        TambahBuku(judul, genre, jumlahBuku)
        RefreshListBox()

        txtTambahJudul.Text = ""
        txtTambahGenre.Text = ""
        txtTambahJudul.Focus()

        MessageBox.Show("Buku '" & judul & "' berhasil ditambahkan!", "Sukses",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Dim judulCari As String = txtHapusJudul.Text.Trim()

        If judulCari = "" Then
            MessageBox.Show("Masukkan judul buku yang ingin dihapus!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim idx As Integer = CariIndexBuku(judulCari)

        If idx = -1 Then
            MessageBox.Show("Buku '" & judulCari & "' tidak ditemukan!", "Tidak Ditemukan",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim konfirmasi As DialogResult = MessageBox.Show(
                "Apakah Anda yakin ingin menghapus buku '" & arrJudul(idx) & "'?",
                "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If konfirmasi = DialogResult.Yes Then
                HapusBuku(judulCari, jumlahBuku)
                RefreshListBox()
                txtHapusJudul.Text = ""
                MessageBox.Show("Buku berhasil dihapus!", "Sukses",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class
