<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTiketHilang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTiketHilang))
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxJamKeluar = New System.Windows.Forms.TextBox()
        Me.TextBoxTanggalKeluar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxJamMasuk = New System.Windows.Forms.TextBox()
        Me.TextBoxTanggalMasuk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonCari = New System.Windows.Forms.Button()
        Me.TextBoxJenisKendaraan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxNoPlat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxKodeMasuk = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBoxTarif = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalDenda = New System.Windows.Forms.TextBox()
        Me.TextBoxDenda = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.ButtonTutup = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ButtonHitungTotal = New System.Windows.Forms.Button()
        Me.TextBoxInputHarga = New System.Windows.Forms.TextBox()
        Me.TextBoxKembalian = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TimerJam = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(589, 437)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.LightCoral
        Me.RectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.RectangleShape1.BorderColor = System.Drawing.Color.White
        Me.RectangleShape1.Location = New System.Drawing.Point(0, 1)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(588, 43)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCoral
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(209, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "TIKET HILANG"
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
        Me.Panel1.Location = New System.Drawing.Point(341, 74)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 133)
        Me.Panel1.TabIndex = 3
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
        'TextBoxJamKeluar
        '
        Me.TextBoxJamKeluar.Enabled = False
        Me.TextBoxJamKeluar.Location = New System.Drawing.Point(81, 96)
        Me.TextBoxJamKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxJamKeluar.Name = "TextBoxJamKeluar"
        Me.TextBoxJamKeluar.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxJamKeluar.TabIndex = 7
        '
        'TextBoxTanggalKeluar
        '
        Me.TextBoxTanggalKeluar.Enabled = False
        Me.TextBoxTanggalKeluar.Location = New System.Drawing.Point(81, 68)
        Me.TextBoxTanggalKeluar.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTanggalKeluar.Name = "TextBoxTanggalKeluar"
        Me.TextBoxTanggalKeluar.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxTanggalKeluar.TabIndex = 6
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
        'TextBoxJamMasuk
        '
        Me.TextBoxJamMasuk.Enabled = False
        Me.TextBoxJamMasuk.Location = New System.Drawing.Point(81, 40)
        Me.TextBoxJamMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxJamMasuk.Name = "TextBoxJamMasuk"
        Me.TextBoxJamMasuk.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxJamMasuk.TabIndex = 4
        '
        'TextBoxTanggalMasuk
        '
        Me.TextBoxTanggalMasuk.Enabled = False
        Me.TextBoxTanggalMasuk.Location = New System.Drawing.Point(81, 10)
        Me.TextBoxTanggalMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxTanggalMasuk.Name = "TextBoxTanggalMasuk"
        Me.TextBoxTanggalMasuk.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxTanggalMasuk.TabIndex = 3
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
        Me.Panel2.Location = New System.Drawing.Point(31, 74)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(279, 159)
        Me.Panel2.TabIndex = 4
        '
        'ButtonCari
        '
        Me.ButtonCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCari.ForeColor = System.Drawing.Color.Black
        Me.ButtonCari.Location = New System.Drawing.Point(97, 88)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(158, 25)
        Me.ButtonCari.TabIndex = 21
        Me.ButtonCari.Text = "Cari "
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'TextBoxJenisKendaraan
        '
        Me.TextBoxJenisKendaraan.Enabled = False
        Me.TextBoxJenisKendaraan.Location = New System.Drawing.Point(97, 120)
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
        Me.Label6.Location = New System.Drawing.Point(6, 121)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Jenis Kendaraan"
        '
        'TextBoxNoPlat
        '
        Me.TextBoxNoPlat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNoPlat.Location = New System.Drawing.Point(97, 41)
        Me.TextBoxNoPlat.Multiline = True
        Me.TextBoxNoPlat.Name = "TextBoxNoPlat"
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
        Me.TextBoxKodeMasuk.Enabled = False
        Me.TextBoxKodeMasuk.Location = New System.Drawing.Point(97, 10)
        Me.TextBoxKodeMasuk.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxKodeMasuk.Name = "TextBoxKodeMasuk"
        Me.TextBoxKodeMasuk.Size = New System.Drawing.Size(158, 20)
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
        Me.Panel3.Controls.Add(Me.TextBoxTarif)
        Me.Panel3.Controls.Add(Me.TextBoxTotalDenda)
        Me.Panel3.Controls.Add(Me.TextBoxDenda)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Location = New System.Drawing.Point(57, 264)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(231, 125)
        Me.Panel3.TabIndex = 5
        '
        'TextBoxTarif
        '
        Me.TextBoxTarif.Enabled = False
        Me.TextBoxTarif.Location = New System.Drawing.Point(92, 14)
        Me.TextBoxTarif.Name = "TextBoxTarif"
        Me.TextBoxTarif.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxTarif.TabIndex = 5
        '
        'TextBoxTotalDenda
        '
        Me.TextBoxTotalDenda.Enabled = False
        Me.TextBoxTotalDenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalDenda.Location = New System.Drawing.Point(91, 74)
        Me.TextBoxTotalDenda.Multiline = True
        Me.TextBoxTotalDenda.Name = "TextBoxTotalDenda"
        Me.TextBoxTotalDenda.Size = New System.Drawing.Size(123, 31)
        Me.TextBoxTotalDenda.TabIndex = 4
        '
        'TextBoxDenda
        '
        Me.TextBoxDenda.Enabled = False
        Me.TextBoxDenda.Location = New System.Drawing.Point(92, 44)
        Me.TextBoxDenda.Name = "TextBoxDenda"
        Me.TextBoxDenda.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxDenda.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Padding = New System.Windows.Forms.Padding(10, 8, 20, 8)
        Me.Label11.Size = New System.Drawing.Size(63, 31)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(16, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Padding = New System.Windows.Forms.Padding(0, 2, 20, 2)
        Me.Label10.Size = New System.Drawing.Size(61, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Denda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(0, 2, 30, 2)
        Me.Label7.Size = New System.Drawing.Size(60, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tarif"
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.BackgroundImage = CType(resources.GetObject("ButtonSimpan.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSimpan.Location = New System.Drawing.Point(366, 350)
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
        Me.ButtonTutup.Location = New System.Drawing.Point(465, 350)
        Me.ButtonTutup.Name = "ButtonTutup"
        Me.ButtonTutup.Size = New System.Drawing.Size(47, 55)
        Me.ButtonTutup.TabIndex = 38
        Me.ButtonTutup.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.ButtonHitungTotal)
        Me.Panel4.Controls.Add(Me.TextBoxInputHarga)
        Me.Panel4.Controls.Add(Me.TextBoxKembalian)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Location = New System.Drawing.Point(341, 223)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(224, 106)
        Me.Panel4.TabIndex = 39
        '
        'ButtonHitungTotal
        '
        Me.ButtonHitungTotal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHitungTotal.Location = New System.Drawing.Point(85, 67)
        Me.ButtonHitungTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonHitungTotal.Name = "ButtonHitungTotal"
        Me.ButtonHitungTotal.Size = New System.Drawing.Size(124, 28)
        Me.ButtonHitungTotal.TabIndex = 25
        Me.ButtonHitungTotal.Text = "Hitung Jumlah"
        Me.ButtonHitungTotal.UseVisualStyleBackColor = True
        '
        'TextBoxInputHarga
        '
        Me.TextBoxInputHarga.Location = New System.Drawing.Point(86, 14)
        Me.TextBoxInputHarga.Name = "TextBoxInputHarga"
        Me.TextBoxInputHarga.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxInputHarga.TabIndex = 9
        '
        'TextBoxKembalian
        '
        Me.TextBoxKembalian.Enabled = False
        Me.TextBoxKembalian.Location = New System.Drawing.Point(86, 42)
        Me.TextBoxKembalian.Name = "TextBoxKembalian"
        Me.TextBoxKembalian.Size = New System.Drawing.Size(123, 20)
        Me.TextBoxKembalian.TabIndex = 8
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(14, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Padding = New System.Windows.Forms.Padding(0, 2, 10, 2)
        Me.Label12.Size = New System.Drawing.Size(56, 19)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Kembali"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(14, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Padding = New System.Windows.Forms.Padding(0, 2, 20, 2)
        Me.Label13.Size = New System.Drawing.Size(56, 19)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Bayar"
        '
        'TimerJam
        '
        Me.TimerJam.Enabled = True
        Me.TimerJam.Interval = 1000
        '
        'FormTiketHilang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(589, 437)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.ButtonTutup)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FormTiketHilang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiket Hilang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJamKeluar As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTanggalKeluar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJamMasuk As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTanggalMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxJenisKendaraan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNoPlat As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKodeMasuk As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTarif As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalDenda As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDenda As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonTutup As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TextBoxInputHarga As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxKembalian As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ButtonHitungTotal As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents TimerJam As System.Windows.Forms.Timer
End Class
