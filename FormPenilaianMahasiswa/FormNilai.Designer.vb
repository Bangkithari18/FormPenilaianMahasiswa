<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_hitung = New System.Windows.Forms.Button()
        Me.nama = New System.Windows.Forms.TextBox()
        Me.jml_presensi = New System.Windows.Forms.TextBox()
        Me.uas = New System.Windows.Forms.TextBox()
        Me.tugas = New System.Windows.Forms.TextBox()
        Me.uts = New System.Windows.Forms.TextBox()
        Me.nim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lab_nilai = New System.Windows.Forms.Label()
        Me.lab_hasil = New System.Windows.Forms.Label()
        Me.lab_nama = New System.Windows.Forms.Label()
        Me.lab_nim = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_hitung)
        Me.GroupBox1.Controls.Add(Me.nama)
        Me.GroupBox1.Controls.Add(Me.jml_presensi)
        Me.GroupBox1.Controls.Add(Me.uas)
        Me.GroupBox1.Controls.Add(Me.tugas)
        Me.GroupBox1.Controls.Add(Me.uts)
        Me.GroupBox1.Controls.Add(Me.nim)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(455, 558)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'btn_hitung
        '
        Me.btn_hitung.Location = New System.Drawing.Point(211, 420)
        Me.btn_hitung.Name = "btn_hitung"
        Me.btn_hitung.Size = New System.Drawing.Size(150, 34)
        Me.btn_hitung.TabIndex = 12
        Me.btn_hitung.Text = "Hitung"
        Me.btn_hitung.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(211, 119)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(150, 31)
        Me.nama.TabIndex = 11
        '
        'jml_presensi
        '
        Me.jml_presensi.Location = New System.Drawing.Point(211, 177)
        Me.jml_presensi.MaxLength = 20
        Me.jml_presensi.Name = "jml_presensi"
        Me.jml_presensi.Size = New System.Drawing.Size(150, 31)
        Me.jml_presensi.TabIndex = 10
        '
        'uas
        '
        Me.uas.Location = New System.Drawing.Point(211, 338)
        Me.uas.MaxLength = 100
        Me.uas.Name = "uas"
        Me.uas.Size = New System.Drawing.Size(150, 31)
        Me.uas.TabIndex = 9
        '
        'tugas
        '
        Me.tugas.Location = New System.Drawing.Point(211, 235)
        Me.tugas.MaxLength = 100
        Me.tugas.Name = "tugas"
        Me.tugas.Size = New System.Drawing.Size(150, 31)
        Me.tugas.TabIndex = 8
        '
        'uts
        '
        Me.uts.Location = New System.Drawing.Point(211, 288)
        Me.uts.MaxLength = 100
        Me.uts.Name = "uts"
        Me.uts.Size = New System.Drawing.Size(150, 31)
        Me.uts.TabIndex = 6
        '
        'nim
        '
        Me.nim.Location = New System.Drawing.Point(211, 52)
        Me.nim.MaxLength = 12
        Me.nim.Name = "nim"
        Me.nim.Size = New System.Drawing.Size(150, 31)
        Me.nim.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jumlah Presensi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UTS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIM"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lab_nilai)
        Me.GroupBox2.Controls.Add(Me.lab_hasil)
        Me.GroupBox2.Controls.Add(Me.lab_nama)
        Me.GroupBox2.Controls.Add(Me.lab_nim)
        Me.GroupBox2.Location = New System.Drawing.Point(489, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 558)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hasil"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(59, 235)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 25)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Hasil :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(55, 183)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Total NIlai :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(55, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Nama :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "NIM :"
        '
        'lab_nilai
        '
        Me.lab_nilai.AutoSize = True
        Me.lab_nilai.Location = New System.Drawing.Point(167, 180)
        Me.lab_nilai.Name = "lab_nilai"
        Me.lab_nilai.Size = New System.Drawing.Size(0, 25)
        Me.lab_nilai.TabIndex = 10
        '
        'lab_hasil
        '
        Me.lab_hasil.AutoSize = True
        Me.lab_hasil.Location = New System.Drawing.Point(176, 234)
        Me.lab_hasil.Name = "lab_hasil"
        Me.lab_hasil.Size = New System.Drawing.Size(0, 25)
        Me.lab_hasil.TabIndex = 9
        '
        'lab_nama
        '
        Me.lab_nama.AutoSize = True
        Me.lab_nama.Location = New System.Drawing.Point(167, 128)
        Me.lab_nama.Name = "lab_nama"
        Me.lab_nama.Size = New System.Drawing.Size(0, 25)
        Me.lab_nama.TabIndex = 7
        '
        'lab_nim
        '
        Me.lab_nim.AutoSize = True
        Me.lab_nim.Location = New System.Drawing.Point(167, 67)
        Me.lab_nim.Name = "lab_nim"
        Me.lab_nim.Size = New System.Drawing.Size(0, 25)
        Me.lab_nim.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(308, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(347, 45)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Form Perhitungan Nilai"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 677)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form Nilai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_hitung As Button
    Friend WithEvents nama As TextBox
    Friend WithEvents jml_presensi As TextBox
    Friend WithEvents uas As TextBox
    Friend WithEvents tugas As TextBox
    Friend WithEvents uts As TextBox
    Friend WithEvents nim As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lab_nama As Label
    Friend WithEvents lab_nim As Label
    Friend WithEvents lab_nilai As Label
    Friend WithEvents lab_hasil As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
End Class
