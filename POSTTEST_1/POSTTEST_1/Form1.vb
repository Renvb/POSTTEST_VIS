Public Class Form1
    Dim IPS As Double
    Dim IPK As Double
    Dim semester As Integer
    Public Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not Double.TryParse(inputIPS.Text, IPS) Then
            MessageBox.Show("Input harus berupa angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            inputIPS.Text = ""
            inputIPS.Focus()
            Return
        End If

        If IPS < 0 Or IPS > 4 Then
            MessageBox.Show("Input IPS harus diantara 0 sampai 4!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            inputIPS.Text = ""
            inputIPS.Focus()
            Return
        End If

        semester += 1
        IPK = ((IPK * (semester - 1)) + IPS) / semester
        If IPK >= 3.01 And IPK <= 4.0 Then
            lblPredikat.Text = "Predikat : Sangat Memuaskan"
        ElseIf IPK >= 2.76 And IPK <= 3.0 Then
            lblPredikat.Text = "Predikat : Memuaskan"
        ElseIf IPK >= 2.0 And IPK <= 2.75 Then
            lblPredikat.Text = "Predikat : Cukup"
        Else
            lblPredikat.Text = "Predikat : Kurang"
        End If
        inputIPK.Text = IPK.ToString("F2")
        lblSmt.Text = "Semester : " & semester
    End Sub

    Public Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        IPS = 0
        IPK = 0
        semester = 0
        inputIPS.Text = ""
        inputIPK.Text = ""
        lblSmt.Text = "Semester : "
        lblPredikat.Text = "Predikat : "
    End Sub


End Class
