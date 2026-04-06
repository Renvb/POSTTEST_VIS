Imports System.IO

Public Class FormUtama
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Pilih Foto Profil"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            FotoPath = OpenFileDialog1.FileName
            picProfil.Image = Image.FromFile(FotoPath)
        End If
    End Sub

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click
        ErrorProvider1.Clear()
        Dim isValid As Boolean = True
        Dim errMsg As String = "Inputan tidak boleh kosong"

        If txtNama.Text.Trim() = "" Then ErrorProvider1.SetError(txtNama, errMsg) : isValid = False
        If txtID.Text.Trim() = "" Then ErrorProvider1.SetError(txtID, errMsg) : isValid = False
        If cbDivisi.SelectedIndex = -1 Then ErrorProvider1.SetError(cbDivisi, errMsg) : isValid = False

        If Not rbLaki.Checked AndAlso Not rbPerempuan.Checked Then
            ErrorProvider1.SetError(rbLaki, errMsg)
            isValid = False
        End If

        If Not mtbNoTelp.MaskCompleted Then
            ErrorProvider1.SetError(mtbNoTelp, "Format telepon harus lengkap!")
            isValid = False
        End If

        Dim hobiTerpilih As String = ""
        Dim isHobiChecked As Boolean = False
        For Each ctrl As Control In gbHobi.Controls
            If TypeOf ctrl Is CheckBox Then
                Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                If chk.Checked Then
                    isHobiChecked = True
                    hobiTerpilih &= chk.Text & ", "
                End If
            End If
        Next

        If Not isHobiChecked Then
            ErrorProvider1.SetError(gbHobi, errMsg)
            isValid = False
        End If

        If Not isValid Then
            MessageBox.Show("Ada inputan yang belum lengkap/salah format!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah Anda yakin data sudah benar dan ingin mencetak kartu?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If hasil = DialogResult.Yes Then
            ModuleData.NamaAnggota = txtNama.Text
            ModuleData.IDAnggota = txtID.Text

            If rbLaki.Checked Then
                ModuleData.JenisKelamin = "Laki-laki"
            Else
                ModuleData.JenisKelamin = "Perempuan"
            End If

            ModuleData.Komunitas = cbDivisi.SelectedItem.ToString()
            ModuleData.Kontak = mtbNoTelp.Text & " | " & txtEmail.Text
            ModuleData.HobiAktifitas = hobiTerpilih.TrimEnd(","c, " "c)

            FormKartu.Show()
        End If
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabControl1.TabPages(0)
    End Sub

    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        FormKartu.Show()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Text File|*.txt"
        SaveFileDialog1.Title = "Simpan Data Anggota"

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim jk As String = If(rbLaki.Checked, "Laki-laki", "Perempuan")

            Dim peran As String = ""
            If rbPJ.Checked Then peran = "PJ"
            If rbKoor.Checked Then peran = "Koor"
            If rbAnggota.Checked Then peran = "Anggota"

            Dim hobiTerpilih As String = ""
            For Each ctrl As Control In gbHobi.Controls
                If TypeOf ctrl Is CheckBox Then
                    Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                    If chk.Checked Then
                        hobiTerpilih &= chk.Text & ", "
                    End If
                End If
            Next
            hobiTerpilih = hobiTerpilih.TrimEnd(","c, " "c)

            Dim konten As String = "Nama: " & txtNama.Text & vbCrLf &
                                 "ID: " & txtID.Text & vbCrLf &
                                 "Gender: " & jk & vbCrLf &
                                 "Divisi: " & cbDivisi.Text & vbCrLf &
                                 "No.Telp: " & mtbNoTelp.Text & vbCrLf &
                                 "Email: " & txtEmail.Text & vbCrLf &
                                 "Alamat: " & txtAlamat.Text & vbCrLf &
                                 "Peran: " & peran & vbCrLf &
                                 "Hobi: " & hobiTerpilih & vbCrLf &
                                 "Foto: " & FotoPath

            File.WriteAllText(SaveFileDialog1.FileName, konten)
            MessageBox.Show("Data berhasil disimpan secara menyeluruh!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Text File|*.txt"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                rbPJ.Checked = False : rbKoor.Checked = False : rbAnggota.Checked = False
                For Each ctrl As Control In gbHobi.Controls
                    If TypeOf ctrl Is CheckBox Then DirectCast(ctrl, CheckBox).Checked = False
                Next
                picProfil.Image = Nothing
                FotoPath = ""

                Dim daftarBaris() As String = File.ReadAllLines(OpenFileDialog1.FileName)

                For Each baris As String In daftarBaris
                    If baris.StartsWith("Nama: ") Then
                        txtNama.Text = baris.Replace("Nama: ", "").Trim()

                    ElseIf baris.StartsWith("ID: ") Then
                        txtID.Text = baris.Replace("ID: ", "").Trim()

                    ElseIf baris.StartsWith("Gender: ") Then
                        Dim jk As String = baris.Replace("Gender: ", "").Trim()
                        If jk = "Laki-laki" Then rbLaki.Checked = True
                        If jk = "Perempuan" Then rbPerempuan.Checked = True

                    ElseIf baris.StartsWith("Divisi: ") Then
                        cbDivisi.Text = baris.Replace("Divisi: ", "").Trim()

                    ElseIf baris.StartsWith("No.Telp: ") Then
                        mtbNoTelp.Text = baris.Replace("No.Telp: ", "").Trim()

                    ElseIf baris.StartsWith("Email: ") Then
                        txtEmail.Text = baris.Replace("Email: ", "").Trim()

                    ElseIf baris.StartsWith("Alamat: ") Then
                        txtAlamat.Text = baris.Replace("Alamat: ", "").Trim()

                    ElseIf baris.StartsWith("Peran: ") Then
                        Dim peran As String = baris.Replace("Peran: ", "").Trim()
                        If peran = "PJ" Then rbPJ.Checked = True
                        If peran = "Koor" Then rbKoor.Checked = True
                        If peran = "Anggota" Then rbAnggota.Checked = True

                    ElseIf baris.StartsWith("Hobi: ") Then
                        Dim hobiStr As String = baris.Replace("Hobi: ", "").Trim()
                        Dim listHobi() As String = hobiStr.Split(","c)

                        For Each h In listHobi
                            Dim hobiBersih As String = h.Trim()
                            For Each ctrl As Control In gbHobi.Controls
                                If TypeOf ctrl Is CheckBox Then
                                    Dim chk As CheckBox = DirectCast(ctrl, CheckBox)
                                    If chk.Text.Equals(hobiBersih, StringComparison.OrdinalIgnoreCase) Then
                                        chk.Checked = True
                                    End If
                                End If
                            Next
                        Next

                    ElseIf baris.StartsWith("Foto: ") Then
                        FotoPath = baris.Replace("Foto: ", "").Trim()
                        If IO.File.Exists(FotoPath) Then
                            picProfil.Image = Image.FromFile(FotoPath)
                        End If

                    End If
                Next

                TabControl1.SelectedTab = TabControl1.TabPages(0)
                MessageBox.Show("Data berhasil dimuat!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As Exception
                MessageBox.Show("Gagal membaca file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasiKeluar As DialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Keluar Aplikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If konfirmasiKeluar = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class