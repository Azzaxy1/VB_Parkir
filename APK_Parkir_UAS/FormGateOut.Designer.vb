<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGateOut
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormGateOut))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTanggalMasuk = New System.Windows.Forms.TextBox()
        Me.TextBoxJamMasuk = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTanggalKeluar = New System.Windows.Forms.TextBox()
        Me.TextBoxJamKeluar = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.TextBoxJenisKendaraan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNoPlat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxKodeMasuk = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ButtonHitungTotal = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxKembalian = New System.Windows.Forms.TextBox()
        Me.TextBoxInputHarga = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonTutup = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(198, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TIKET KELUAR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(7, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tgl Masuk"
        '
        'TextBoxTanggalMasuk
        '
        Me.TextBoxTanggalMasuk.Enabled = False
        Me.TextBoxTanggalMasuk.Location = New System.Drawing.Point(81, 10)
        Me.TextBoxTanggalMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTanggalMasuk.Name = "TextBoxTanggalMasuk"
        Me.TextBoxTanggalMasuk.ReadOnly = True
        Me.TextBoxTanggalMasuk.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxTanggalMasuk.TabIndex = 3
        '
        'TextBoxJamMasuk
        '
        Me.TextBoxJamMasuk.Enabled = False
        Me.TextBoxJamMasuk.Location = New System.Drawing.Point(81, 40)
        Me.TextBoxJamMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxJamMasuk.Name = "TextBoxJamMasuk"
        Me.TextBoxJamMasuk.ReadOnly = True
        Me.TextBoxJamMasuk.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxJamMasuk.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(7, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Jam Masuk"
        '
        'TextBoxTanggalKeluar
        '
        Me.TextBoxTanggalKeluar.Enabled = False
        Me.TextBoxTanggalKeluar.Location = New System.Drawing.Point(81, 68)
        Me.TextBoxTanggalKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTanggalKeluar.Name = "TextBoxTanggalKeluar"
        Me.TextBoxTanggalKeluar.ReadOnly = True
        Me.TextBoxTanggalKeluar.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxTanggalKeluar.TabIndex = 6
        '
        'TextBoxJamKeluar
        '
        Me.TextBoxJamKeluar.Enabled = False
        Me.TextBoxJamKeluar.Location = New System.Drawing.Point(81, 96)
        Me.TextBoxJamKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxJamKeluar.Name = "TextBoxJamKeluar"
        Me.TextBoxJamKeluar.ReadOnly = True
        Me.TextBoxJamKeluar.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxJamKeluar.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(7, 69)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tgl Keluar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(7, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jam Keluar"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxJamKeluar)
        Me.Panel1.Controls.Add(Me.TextBoxTanggalKeluar)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxJamMasuk)
        Me.Panel1.Controls.Add(Me.TextBoxTanggalMasuk)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(27, 66)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 133)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.ButtonCari)
        Me.Panel2.Controls.Add(Me.TextBoxJenisKendaraan)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.TextBoxNoPlat)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.TextBoxKodeMasuk)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(264, 67)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 132)
        Me.Panel2.TabIndex = 3
        '
        'ButtonCari
        '
        Me.ButtonCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCari.ForeColor = System.Drawing.Color.Black
        Me.ButtonCari.Location = New System.Drawing.Point(206, 9)
        Me.ButtonCari.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(50, 21)
        Me.ButtonCari.TabIndex = 40
        Me.ButtonCari.Text = "Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'TextBoxJenisKendaraan
        '
        Me.TextBoxJenisKendaraan.Enabled = False
        Me.TextBoxJenisKendaraan.Location = New System.Drawing.Point(97, 94)
        Me.TextBoxJenisKendaraan.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxJenisKendaraan.Name = "TextBoxJenisKendaraan"
        Me.TextBoxJenisKendaraan.ReadOnly = True
        Me.TextBoxJenisKendaraan.Size = New System.Drawing.Size(158, 20)
        Me.TextBoxJenisKendaraan.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Jenis Kendaraan"
        '
        'TextBoxNoPlat
        '
        Me.TextBoxNoPlat.Enabled = False
        Me.TextBoxNoPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNoPlat.Location = New System.Drawing.Point(97, 41)
        Me.TextBoxNoPlat.Multiline = True
        Me.TextBoxNoPlat.Name = "TextBoxNoPlat"
        Me.TextBoxNoPlat.ReadOnly = True
        Me.TextBoxNoPlat.Size = New System.Drawing.Size(158, 40)
        Me.TextBoxNoPlat.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(7, 52)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "No Kendaraan"
        '
        'TextBoxKodeMasuk
        '
        Me.TextBoxKodeMasuk.Location = New System.Drawing.Point(97, 10)
        Me.TextBoxKodeMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxKodeMasuk.Name = "TextBoxKodeMasuk"
        Me.TextBoxKodeMasuk.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxKodeMasuk.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(7, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Kode Masuk"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.ButtonHitungTotal)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.TextBoxKembalian)
        Me.Panel3.Controls.Add(Me.TextBoxInputHarga)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TextBoxTotalHarga)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(27, 217)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(284, 118)
        Me.Panel3.TabIndex = 4
        '
        'ButtonHitungTotal
        '
        Me.ButtonHitungTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHitungTotal.Location = New System.Drawing.Point(217, 12)
        Me.ButtonHitungTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHitungTotal.Name = "ButtonHitungTotal"
        Me.ButtonHitungTotal.Size = New System.Drawing.Size(50, 88)
        Me.ButtonHitungTotal.TabIndex = 24
        Me.ButtonHitungTotal.Text = "Hitung Jumlah"
        Me.ButtonHitungTotal.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 84)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Kembali"
        '
        'TextBoxKembalian
        '
        Me.TextBoxKembalian.Enabled = False
        Me.TextBoxKembalian.Location = New System.Drawing.Point(82, 83)
        Me.TextBoxKembalian.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxKembalian.Name = "TextBoxKembalian"
        Me.TextBoxKembalian.ReadOnly = True
        Me.TextBoxKembalian.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxKembalian.TabIndex = 22
        '
        'TextBoxInputHarga
        '
        Me.TextBoxInputHarga.Location = New System.Drawing.Point(82, 59)
        Me.TextBoxInputHarga.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxInputHarga.Name = "TextBoxInputHarga"
        Me.TextBoxInputHarga.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxInputHarga.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(12, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Bayar"
        '
        'TextBoxTotalHarga
        '
        Me.TextBoxTotalHarga.Enabled = False
        Me.TextBoxTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalHarga.Location = New System.Drawing.Point(82, 12)
        Me.TextBoxTotalHarga.Multiline = True
        Me.TextBoxTotalHarga.Name = "TextBoxTotalHarga"
        Me.TextBoxTotalHarga.Size = New System.Drawing.Size(123, 40)
        Me.TextBoxTotalHarga.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 26)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "TOTAL"
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackgroundImage = CType(resources.GetObject("ButtonSimpan.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSimpan.Location = New System.Drawing.Point(367, 245)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(47, 55)
        Me.ButtonSimpan.TabIndex = 37
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonTutup
        '
        Me.ButtonTutup.BackgroundImage = CType(resources.GetObject("ButtonTutup.BackgroundImage"), System.Drawing.Image)
        Me.ButtonTutup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonTutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTutup.Location = New System.Drawing.Point(447, 246)
        Me.ButtonTutup.Name = "ButtonTutup"
        Me.ButtonTutup.Size = New System.Drawing.Size(47, 55)
        Me.ButtonTutup.TabIndex = 38
        Me.ButtonTutup.UseVisualStyleBackColor = True
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = True
        Me.TimerJam.Interval = 1000
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.Location = New System.Drawing.Point(-1, 0)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(572, 43)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(572, 360)
        Me.ShapeContainer1.TabIndex = 39
        Me.ShapeContainer1.TabStop = False
        '
        'FormGateOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(572, 360)
        Me.Controls.Add(Me.ButtonTutup)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormGateOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gate Out"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTanggalMasuk As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJamMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTanggalKeluar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJamKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNoPlat As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJenisKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKodeMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxKembalian As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxInputHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonTutup As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents ButtonHitungTotal As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
End Class
