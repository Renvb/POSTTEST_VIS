Imports MySqlConnector

Module ModAgensi
    Public Class AgensiModel
        Public Property ID As Integer
        Public Property Nama As String
        Public Property Negara As String
        Public Property TahunBerdiri As Integer
    End Class
    Public Function TambahAgensi(agensi As AgensiModel) As Integer
        Dim sql As String =
            "INSERT INTO tbl_agensi (nama, negara, tahun_berdiri)
             VALUES (@nama, @negara, @tahunBerdiri)"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama", agensi.Nama)
                cmd.Parameters.AddWithValue("@negara", agensi.Negara)
                cmd.Parameters.AddWithValue("@tahunBerdiri", agensi.TahunBerdiri)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function GetSemuaAgensi() As DataTable
        Dim sql As String =
            "SELECT  a.id              AS 'ID',
                     a.nama            AS 'Nama Agensi',
                     a.negara          AS 'Negara',
                     a.tahun_berdiri   AS 'Tahun Berdiri',
                     COUNT(g.id)       AS 'Jumlah Grup'
             FROM    tbl_agensi a
             LEFT JOIN tbl_grup g ON g.agensi_id = a.id
             GROUP BY a.id, a.nama, a.negara, a.tahun_berdiri
             ORDER BY a.nama ASC"

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
    Public Function GetAgensiUntukComboBox() As DataTable
        Dim sql As String =
            "SELECT id, nama FROM tbl_agensi ORDER BY nama ASC"

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
    Public Function GetAgensiByID(id As Integer) As AgensiModel
        Dim sql As String =
            "SELECT * FROM tbl_agensi WHERE id = @id LIMIT 1"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Return New AgensiModel With {
                            .ID = reader.GetInt32("id"),
                            .Nama = reader.GetString("nama"),
                            .Negara = reader.GetString("negara"),
                            .TahunBerdiri = reader.GetInt32("tahun_berdiri")
                        }
                    End If
                End Using
            End Using
        End Using

        Return Nothing
    End Function
    Public Function UpdateAgensi(agensi As AgensiModel) As Integer
        Dim sql As String =
            "UPDATE tbl_agensi
             SET    nama          = @nama,
                    negara        = @negara,
                    tahun_berdiri = @tahunBerdiri
             WHERE  id = @id"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", agensi.ID)
                cmd.Parameters.AddWithValue("@nama", agensi.Nama)
                cmd.Parameters.AddWithValue("@negara", agensi.Negara)
                cmd.Parameters.AddWithValue("@tahunBerdiri", agensi.TahunBerdiri)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function HapusAgensi(id As Integer) As Integer
        Dim sql As String = "DELETE FROM tbl_agensi WHERE id = @id"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                Return cmd.ExecuteNonQuery()
            End Using
        End Using
    End Function
    Public Function NamaAgensiSudahAda(nama As String,
                                        Optional excludeID As Integer = 0) As Boolean
        Dim sql As String =
            "SELECT COUNT(*) FROM tbl_agensi WHERE nama = @nama AND id <> @excludeID"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@nama", nama.Trim())
                cmd.Parameters.AddWithValue("@excludeID", excludeID)
                Return CLng(cmd.ExecuteScalar()) > 0
            End Using
        End Using
    End Function
    Public Function GetJumlahGrupByAgensi(agensiID As Integer) As Integer
        Dim sql As String =
            "SELECT COUNT(*) FROM tbl_grup WHERE agensi_id = @agensiID"

        Using conn As MySqlConnection = ModKoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@agensiID", agensiID)
                Return CInt(CLng(cmd.ExecuteScalar()))
            End Using
        End Using
    End Function

End Module