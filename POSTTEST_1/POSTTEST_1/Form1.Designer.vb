<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblIPS = New Label()
        lblIPK = New Label()
        inputIPS = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        lblPredikat = New Label()
        inputIPK = New TextBox()
        lblSmt = New Label()
        SuspendLayout()
        ' 
        ' lblIPS
        ' 
        lblIPS.AutoSize = True
        lblIPS.Location = New Point(19, 28)
        lblIPS.Name = "lblIPS"
        lblIPS.Size = New Size(86, 20)
        lblIPS.TabIndex = 0
        lblIPS.Text = "IP Semester"
        ' 
        ' lblIPK
        ' 
        lblIPK.AutoSize = True
        lblIPK.Location = New Point(16, 104)
        lblIPK.Name = "lblIPK"
        lblIPK.Size = New Size(89, 20)
        lblIPK.TabIndex = 1
        lblIPK.Text = "IP Kumulatif"
        ' 
        ' inputIPS
        ' 
        inputIPS.Location = New Point(123, 21)
        inputIPS.Name = "inputIPS"
        inputIPS.Size = New Size(146, 27)
        inputIPS.TabIndex = 2
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(123, 54)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(77, 29)
        btnTambah.TabIndex = 4
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(206, 54)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(63, 29)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(195, 145)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(74, 20)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "Predikat : "
        ' 
        ' inputIPK
        ' 
        inputIPK.Location = New Point(123, 97)
        inputIPK.Name = "inputIPK"
        inputIPK.ReadOnly = True
        inputIPK.Size = New Size(146, 27)
        inputIPK.TabIndex = 3
        ' 
        ' lblSmt
        ' 
        lblSmt.AutoSize = True
        lblSmt.Location = New Point(19, 145)
        lblSmt.Name = "lblSmt"
        lblSmt.Size = New Size(81, 20)
        lblSmt.TabIndex = 7
        lblSmt.Text = "Semester : "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(474, 195)
        Controls.Add(lblSmt)
        Controls.Add(lblPredikat)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(inputIPK)
        Controls.Add(inputIPS)
        Controls.Add(lblIPK)
        Controls.Add(lblIPS)
        Name = "Form1"
        Text = "Post Test 1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblIPS As Label
    Friend WithEvents lblIPK As Label
    Friend WithEvents inputIPS As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblPredikat As Label
    Friend WithEvents inputIPK As TextBox
    Friend WithEvents lblSmt As Label

End Class
