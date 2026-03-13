Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpTanggalLahir.Value = New DateTime(2000, 1, 1)
        dtpTanggalLahir.MaxDate = DateTime.Today

        PictureBox1.BackColor = Color.LightGray
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog()
        ofd.Title = "Pilih Foto Profil"
        ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image = Image.FromFile(ofd.FileName)
            Catch ex As Exception
                MessageBox.Show("Gagal memuat gambar: " & ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelepon.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse
                (e.KeyChar = "+"c AndAlso txtTelepon.Text.Length = 0) OrElse
                Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click

        Dim errors As New List(Of String)()

        If PictureBox1.Image Is Nothing Then
            errors.Add("• Foto profil belum dipilih")
        End If

        If String.IsNullOrWhiteSpace(txtNama.Text) Then
            errors.Add("• Nama lengkap tidak boleh kosong")
        End If

        If String.IsNullOrWhiteSpace(txtUmur.Text) Then
            errors.Add("• Umur tidak boleh kosong")
        ElseIf CInt(txtUmur.Text) <= 0 OrElse CInt(txtUmur.Text) > 150 Then
            errors.Add("• Umur tidak valid (1-150)")
        End If

        If String.IsNullOrWhiteSpace(txtTelepon.Text) Then
            errors.Add("• Nomor telepon tidak boleh kosong")
        ElseIf txtTelepon.Text.Length < 8 Then
            errors.Add("• Nomor telepon minimal 8 digit")
        End If

        If dtpTanggalLahir.Value.Date > DateTime.Today Then
            errors.Add("• Tanggal lahir tidak boleh melebihi hari ini")
        End If

        If String.IsNullOrWhiteSpace(txtAlamat.Text) Then
            errors.Add("• Alamat tidak boleh kosong")
        End If

        If Not rbLakiLaki.Checked AndAlso Not rbPerempuan.Checked Then
            errors.Add("• Jenis kelamin belum dipilih")
        End If

        Dim hobbyList As New List(Of String)()
        For Each ctrl As Control In grpHobby.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = CType(ctrl, CheckBox)
                If chk.Checked Then
                    Dim hobbyText As String = chk.Text
                    Dim spaceIdx As Integer = hobbyText.IndexOf(" ")
                    If spaceIdx >= 0 Then
                        hobbyList.Add(hobbyText.Substring(spaceIdx + 1).Trim())
                    Else
                        hobbyList.Add(hobbyText.Trim())
                    End If
                End If
            End If
        Next

        If hobbyList.Count = 0 Then
            errors.Add("• Hobby belum dipilih (pilih minimal 1)")
        End If

        If errors.Count > 0 Then
            Dim pesanError As String = "Inputan tidak boleh kosong!" & Environment.NewLine & Environment.NewLine &
                                       "Detail:" & Environment.NewLine &
                                       String.Join(Environment.NewLine, errors)
            MessageBox.Show(pesanError, "Validasi Gagal",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim jenisKelamin As String = If(rbLakiLaki.Checked, "Laki-Laki", "Perempuan")
        Dim hobbyStr As String = String.Join(", ", hobbyList)
        Dim tglLahir As String = dtpTanggalLahir.Value.ToString("dd MMMM yyyy")

        Dim frm2 As New Form2()
        frm2.SetData(
            PictureBox1.Image,
            txtNama.Text.Trim(),
            txtUmur.Text.Trim(),
            txtTelepon.Text.Trim(),
            jenisKelamin,
            tglLahir,
            txtAlamat.Text.Trim(),
            hobbyStr
        )
        frm2.ShowDialog()
    End Sub

End Class
