Module ModHelper
    Public Function ValidasiInput(namaGrup As String,
                                   agensi As String,
                                   member As String) As String
        If String.IsNullOrWhiteSpace(namaGrup) Then
            Return "Nama Grup tidak boleh kosong."
        End If
        If String.IsNullOrWhiteSpace(agensi) Then
            Return "Nama Agensi tidak boleh kosong."
        End If

        Dim jml As Integer
        If String.IsNullOrWhiteSpace(member) OrElse Not Integer.TryParse(member, jml) Then
            Return "Jumlah Member harus berupa angka."
        End If
        If jml <= 0 OrElse jml > 100 Then
            Return "Jumlah Member harus antara 1 sampai 100."
        End If

        Return String.Empty
    End Function
    Public Function SanitasiInput(nilai As String) As String
        If String.IsNullOrEmpty(nilai) Then Return String.Empty
        Return nilai.Trim().Replace("'", "''")
    End Function
    Public Function Konfirmasi(pesan As String, judul As String) As Boolean
        Return MessageBox.Show(pesan, judul,
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) = DialogResult.Yes
    End Function
    Public Sub TampilkanError(pesan As String)
        MessageBox.Show(pesan, "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
    End Sub
    Public Sub TampilkanInfo(pesan As String)
        MessageBox.Show(pesan, "Informasi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)
    End Sub

End Module