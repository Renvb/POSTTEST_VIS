Imports MySqlConnector

Module ModKoneksi
    Private Const SERVER As String = "localhost"
    Private Const PORT As String = "3306"
    Private Const DATABASE As String = "db_kpop"
    Private Const USERNAME As String = "root"
    Private Const PASSWORD As String = ""

    Private ReadOnly ConnString As String =
        $"Server={SERVER};Port={PORT};Database={DATABASE};Uid={USERNAME};Pwd={PASSWORD};CharSet=utf8mb4;"
    Public Function BukaKoneksi() As MySqlConnection
        Dim conn As New MySqlConnection(ConnString)
        Try
            conn.Open()
        Catch ex As MySqlException
            Throw New Exception("Gagal terhubung ke database: " & ex.Message)
        End Try
        Return conn
    End Function
    Public Function TestKoneksi() As Boolean
        Try
            Using conn As MySqlConnection = BukaKoneksi()
                Return conn.State = ConnectionState.Open
            End Using
        Catch
            Return False
        End Try
    End Function

End Module