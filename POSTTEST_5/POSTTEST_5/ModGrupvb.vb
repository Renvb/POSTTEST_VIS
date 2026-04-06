Imports MySqlConnector

Module ModGrup
    Public Class GrupModel
        Public Property ID As Integer
        Public Property NamaGrup As String
        Public Property Agensi As String
        Public Property Genre As String
        Public Property Negara As String
        Public Property TahunDebut As Integer
        Public Property JmlMember As Integer
        Public Property LaguPopuler As String
    End Class
    Public Enum FilterKolom
        SemuaKolom
        NamaGrup
        Agensi
        Genre
        Negara
    End Enum
    Public Function TambahGrup(grup As GrupModel) As Integer
        Dim sql As String =
            "INSERT INTO tbl_grup (nama_grup, agensi, genre, negara, tahun_debut, jml_member, lagu_populer) " &
            "VALUES (@namaGrup, @agensi, @genre, @negara, @tahunDebut, @jmlMember, @laguPopuler)"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@namaGrup", grup.NamaGrup)
                cmd.Parameters.AddWithValue("@agensi", grup.Agensi)
                cmd.Parameters.AddWithValue("@genre", grup.Genre)
                cmd.Parameters.AddWithValue("@negara", grup.Negara)
                cmd.Parameters.AddWithValue("@tahunDebut", grup.TahunDebut)
                cmd.Parameters.AddWithValue("@jmlMember", grup.JmlMember)
                cmd.Parameters.AddWithValue("@laguPopuler", grup.LaguPopuler)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function GetSemuaGrup() As DataTable
        Dim sql As String =
            "SELECT id          AS 'ID',
                    nama_grup   AS 'Nama Grup',
                    agensi      AS 'Agensi',
                    genre       AS 'Genre',
                    negara      AS 'Negara Asal',
                    tahun_debut AS 'Tahun Debut',
                    jml_member  AS 'Jml. Member',
                    lagu_populer AS 'Lagu Populer'
             FROM tbl_grup
             ORDER BY nama_grup ASC"

        Return EksekusiQuery(sql)
    End Function
    Public Function GetGrupByID(id As Integer) As GrupModel
        Dim sql As String =
            "SELECT * FROM tbl_grup WHERE id = @id LIMIT 1"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return New GrupModel With {
                            .ID = reader.GetInt32("id"),
                            .NamaGrup = reader.GetString("nama_grup"),
                            .Agensi = reader.GetString("agensi"),
                            .Genre = reader.GetString("genre"),
                            .Negara = reader.GetString("negara"),
                            .TahunDebut = reader.GetInt32("tahun_debut"),
                            .JmlMember = reader.GetInt32("jml_member"),
                            .LaguPopuler = reader.GetString("lagu_populer")
                        }
                    End If
                End Using
            End Using
        End Using

        Return Nothing
    End Function
    Public Function UpdateGrup(grup As GrupModel) As Integer
        Dim sql As String =
            "UPDATE tbl_grup
             SET    nama_grup    = @namaGrup,
                    agensi       = @agensi,
                    genre        = @genre,
                    negara       = @negara,
                    tahun_debut  = @tahunDebut,
                    jml_member   = @jmlMember,
                    lagu_populer = @laguPopuler
             WHERE  id = @id"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", grup.ID)
                cmd.Parameters.AddWithValue("@namaGrup", grup.NamaGrup)
                cmd.Parameters.AddWithValue("@agensi", grup.Agensi)
                cmd.Parameters.AddWithValue("@genre", grup.Genre)
                cmd.Parameters.AddWithValue("@negara", grup.Negara)
                cmd.Parameters.AddWithValue("@tahunDebut", grup.TahunDebut)
                cmd.Parameters.AddWithValue("@jmlMember", grup.JmlMember)
                cmd.Parameters.AddWithValue("@laguPopuler", grup.LaguPopuler)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function HapusGrup(id As Integer) As Integer
        Dim sql As String = "DELETE FROM tbl_grup WHERE id = @id"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function CariGrup(keyword As String, filter As FilterKolom) As DataTable
        If String.IsNullOrWhiteSpace(keyword) Then
            Return GetSemuaGrup()
        End If

        Dim kondisi As String = BuildKondisiSearch(filter)
        Dim sql As String =
            $"SELECT id           AS 'ID',
                     nama_grup    AS 'Nama Grup',
                     agensi       AS 'Agensi',
                     genre        AS 'Genre',
                     negara       AS 'Negara Asal',
                     tahun_debut  AS 'Tahun Debut',
                     jml_member   AS 'Jml. Member',
                     lagu_populer AS 'Lagu Populer'
              FROM   tbl_grup
              WHERE  {kondisi}
              ORDER BY nama_grup ASC"

        Dim param As String = "%" & keyword.Trim() & "%"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                If filter = FilterKolom.SemuaKolom Then
                    cmd.Parameters.AddWithValue("@k1", param)
                    cmd.Parameters.AddWithValue("@k2", param)
                    cmd.Parameters.AddWithValue("@k3", param)
                    cmd.Parameters.AddWithValue("@k4", param)
                Else
                    cmd.Parameters.AddWithValue("@keyword", param)
                End If

                Dim adapter As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                Return dt
            End Using
        End Using
    End Function
    Public Function GetSummary() As Tuple(Of Integer, Integer)
        Dim sql As String =
            "SELECT COUNT(*) AS total_grup, COALESCE(SUM(jml_member), 0) AS total_member FROM tbl_grup"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return Tuple.Create(reader.GetInt32("total_grup"),
                                            reader.GetInt32("total_member"))
                    End If
                End Using
            End Using
        End Using

        Return Tuple.Create(0, 0)
    End Function
    Public Function NamaGrupSudahAda(namaGrup As String,
                                      Optional excludeID As Integer = 0) As Boolean
        Dim sql As String =
            "SELECT COUNT(*) FROM tbl_grup WHERE nama_grup = @namaGrup AND id <> @excludeID"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@namaGrup", namaGrup.Trim())
                cmd.Parameters.AddWithValue("@excludeID", excludeID)
                Return CLng(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function
    Private Function BuildKondisiSearch(filter As FilterKolom) As String
        Select Case filter
            Case FilterKolom.NamaGrup : Return "nama_grup    LIKE @keyword"
            Case FilterKolom.Agensi : Return "agensi       LIKE @keyword"
            Case FilterKolom.Genre : Return "genre        LIKE @keyword"
            Case FilterKolom.Negara : Return "negara       LIKE @keyword"
            Case Else
                Return "(nama_grup LIKE @k1 OR agensi LIKE @k2 OR genre LIKE @k3 OR negara LIKE @k4)"
        End Select
    End Function
    Private Function EksekusiQuery(sql As String) As DataTable
        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    Return dt
                End Using
            End Using
        End Using
    End Function

End Module