Public Class Form2
    Public Sub SetData(foto As Image,
                       nama As String,
                       umur As String,
                       telepon As String,
                       jenisKelamin As String,
                       tanggalLahir As String,
                       alamat As String,
                       hobby As String)

        pbFoto.Image = foto
        lblNamaVal.Text = nama
        lblUmurVal.Text = umur & " Tahun"
        lblTeleponVal.Text = telepon
        lblJKVal.Text = jenisKelamin
        lblTglLahirVal.Text = tanggalLahir
        lblAlamatVal.Text = alamat
        lblHobbyVal.Text = hobby

    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub

End Class
