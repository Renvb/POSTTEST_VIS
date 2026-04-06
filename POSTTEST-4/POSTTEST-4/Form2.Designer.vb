<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        PictureBoxFoto = New PictureBox()
        Label2 = New Label()
        lblNama = New Label()
        lblID = New Label()
        lblDivisi = New Label()
        lblKontak = New Label()
        lblHobi = New Label()
        lblJenisKelamin = New Label()
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxFoto
        ' 
        PictureBoxFoto.Location = New Point(12, 114)
        PictureBoxFoto.Name = "PictureBoxFoto"
        PictureBoxFoto.Size = New Size(210, 221)
        PictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxFoto.TabIndex = 1
        PictureBoxFoto.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(294, 31)
        Label2.TabIndex = 3
        Label2.Text = "Kartu Anggota TGTV 2026"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(228, 118)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(15, 20)
        lblNama.TabIndex = 8
        lblNama.Text = "-"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Location = New Point(228, 156)
        lblID.Name = "lblID"
        lblID.Size = New Size(15, 20)
        lblID.TabIndex = 9
        lblID.Text = "-"
        ' 
        ' lblDivisi
        ' 
        lblDivisi.AutoSize = True
        lblDivisi.Location = New Point(228, 227)
        lblDivisi.Name = "lblDivisi"
        lblDivisi.Size = New Size(15, 20)
        lblDivisi.TabIndex = 10
        lblDivisi.Text = "-"
        ' 
        ' lblKontak
        ' 
        lblKontak.AutoSize = True
        lblKontak.Location = New Point(228, 268)
        lblKontak.Name = "lblKontak"
        lblKontak.Size = New Size(15, 20)
        lblKontak.TabIndex = 11
        lblKontak.Text = "-"
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(228, 305)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(15, 20)
        lblHobi.TabIndex = 12
        lblHobi.Text = "-"
        ' 
        ' lblJenisKelamin
        ' 
        lblJenisKelamin.AutoSize = True
        lblJenisKelamin.Location = New Point(228, 195)
        lblJenisKelamin.Name = "lblJenisKelamin"
        lblJenisKelamin.Size = New Size(15, 20)
        lblJenisKelamin.TabIndex = 13
        lblJenisKelamin.Text = "-"
        ' 
        ' FormKartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 382)
        Controls.Add(lblJenisKelamin)
        Controls.Add(lblHobi)
        Controls.Add(lblKontak)
        Controls.Add(lblDivisi)
        Controls.Add(lblID)
        Controls.Add(lblNama)
        Controls.Add(Label2)
        Controls.Add(PictureBoxFoto)
        Name = "FormKartu"
        Text = "Form Kartu"
        CType(PictureBoxFoto, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxFoto As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblJenisKelamin As Label
End Class
