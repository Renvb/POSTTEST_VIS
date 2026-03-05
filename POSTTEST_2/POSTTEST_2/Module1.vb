Module Module1

    Public Const MAX_BUKU As Integer = 100
    Public arrJudul(MAX_BUKU) As String
    Public arrGenre(MAX_BUKU) As String
    Public jumlahBuku As Integer = 0

    Public Sub TambahBuku(judul As String, genre As String, ByRef count As Integer)
        If count < MAX_BUKU Then
            arrJudul(count) = judul
            arrGenre(count) = genre
            count += 1
        End If
    End Sub

    Public Sub HapusBuku(judulCari As String, ByRef count As Integer)
        Dim indexDitemukan As Integer = CariIndexBuku(judulCari)

        If indexDitemukan >= 0 Then
            For i As Integer = indexDitemukan To count - 2
                arrJudul(i) = arrJudul(i + 1)
                arrGenre(i) = arrGenre(i + 1)
            Next
            arrJudul(count - 1) = ""
            arrGenre(count - 1) = ""
            count -= 1
        End If
    End Sub

    Public Function CariIndexBuku(judulCari As String) As Integer
        For i As Integer = 0 To jumlahBuku - 1
            If arrJudul(i).ToLower() = judulCari.ToLower() Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function IsDuplikat(judul As String) As Boolean
        Return CariIndexBuku(judul) >= 0
    End Function

End Module
