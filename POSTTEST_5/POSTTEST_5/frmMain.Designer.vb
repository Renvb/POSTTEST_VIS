<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Label4 = New Label()
        btnBukaAgensi = New Button()
        btnBukaGrup = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Lucida Sans", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(12, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(591, 32)
        Label4.TabIndex = 21
        Label4.Text = "SISTEM MANAJEMEN DATA GRUP K-POP"
        ' 
        ' btnBukaAgensi
        ' 
        btnBukaAgensi.BackColor = Color.Gray
        btnBukaAgensi.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBukaAgensi.ForeColor = SystemColors.Control
        btnBukaAgensi.Location = New Point(21, 57)
        btnBukaAgensi.Name = "btnBukaAgensi"
        btnBukaAgensi.Size = New Size(186, 29)
        btnBukaAgensi.TabIndex = 22
        btnBukaAgensi.Text = "Buka Form Agensi"
        btnBukaAgensi.UseVisualStyleBackColor = False
        ' 
        ' btnBukaGrup
        ' 
        btnBukaGrup.BackColor = Color.Gray
        btnBukaGrup.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBukaGrup.ForeColor = SystemColors.Control
        btnBukaGrup.Location = New Point(213, 57)
        btnBukaGrup.Name = "btnBukaGrup"
        btnBukaGrup.Size = New Size(186, 29)
        btnBukaGrup.TabIndex = 23
        btnBukaGrup.Text = "Buka Form Grup"
        btnBukaGrup.UseVisualStyleBackColor = False
        ' 
        ' btnKeluar
        ' 
        btnKeluar.BackColor = Color.Gray
        btnKeluar.Font = New Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.ForeColor = SystemColors.Control
        btnKeluar.Location = New Point(405, 57)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(186, 29)
        btnKeluar.TabIndex = 24
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = False
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gray
        ClientSize = New Size(613, 110)
        Controls.Add(btnKeluar)
        Controls.Add(btnBukaGrup)
        Controls.Add(btnBukaAgensi)
        Controls.Add(Label4)
        Name = "frmMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistem Manajemen Data Grup K-Pop"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnBukaAgensi As Button
    Friend WithEvents btnBukaGrup As Button
    Friend WithEvents btnKeluar As Button
End Class
