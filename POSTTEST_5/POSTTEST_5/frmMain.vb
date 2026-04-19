Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not ModKoneksi.TestKoneksi() Then
            ModHelper.TampilkanError("Tidak dapat terhubung ke database. Periksa konfigurasi koneksi.")
            Me.Close()
            Return
        End If
    End Sub

    Private Sub btnBukaGrup_Click(sender As Object, e As EventArgs) Handles btnBukaGrup.Click
        Dim frm As New frmKpopManagement
        frm.Show()
    End Sub

    Private Sub btnBukaAgensi_Click(sender As Object, e As EventArgs) Handles btnBukaAgensi.Click
        Dim frm As New frmAgensi()
        frm.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        If ModHelper.Konfirmasi("Keluar dari aplikasi?", "Konfirmasi") Then
            Application.Exit()
        End If
    End Sub

End Class