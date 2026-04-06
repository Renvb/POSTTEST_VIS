Public Class FormKartu

    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = "Nama: " & ModuleData.NamaAnggota
        lblID.Text = "ID Anggota: " & ModuleData.IDAnggota
        lblJenisKelamin.Text = "Gender: " & ModuleData.JenisKelamin
        lblDivisi.Text = "Divisi: " & ModuleData.Komunitas
        lblKontak.Text = "Kontak: " & ModuleData.Kontak
        lblHobi.Text = "Hobi: " & ModuleData.HobiAktifitas

        If Not String.IsNullOrEmpty(ModuleData.FotoPath) AndAlso IO.File.Exists(ModuleData.FotoPath) Then
            PictureBoxFoto.Image = Image.FromFile(ModuleData.FotoPath)
        End If
    End Sub

End Class