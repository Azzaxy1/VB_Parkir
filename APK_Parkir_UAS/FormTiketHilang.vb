Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FormTiketHilang
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim jamKeluar As String
    Dim dendaHilangTiket As Integer

    Private Sub FormTiketHilang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksiDb()

        'Set tanggal dan jam keluar
        TextBoxTanggalKeluar.Text = DateTime.Now.ToString("yyyy-MM-dd")
        TextBoxJamKeluar.Text = DateTime.Now.ToString("HH:mm:ss")

        TimerJam.Interval = 1000
        TimerJam.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerJam.Tick
        TextBoxJamKeluar.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub ButtonTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTutup.Click
        End
    End Sub

    Private Sub FormTiketHilang_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TutupKoneksi()
    End Sub

    Private Sub ButtonCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCari.Click
        ' Cari kendaraan berdasarkan No Plat
        Dim noPlat As String = TextBoxNoPlat.Text
        Dim query As String = "SELECT * FROM gate_in WHERE no_plat = '" & noPlat & "'"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.Read() Then
            TextBoxKodeMasuk.Text = rd("kode_masuk").ToString()
            TextBoxJenisKendaraan.Text = rd("jenis_kendaraan").ToString()
            TextBoxTanggalMasuk.Text = DateTime.Parse(rd("tanggal").ToString()).ToString("yyyy-MM-dd")
            TextBoxJamMasuk.Text = rd("jam").ToString()

            'Set tanggal dan jam keluar
            TextBoxTanggalKeluar.Text = DateTime.Now.ToString("yyyy-MM-dd")
            TextBoxJamKeluar.Text = DateTime.Now.ToString("HH:mm:ss")

            ' Hitung durasi parkir
            Dim jamMasuk As DateTime = DateTime.Parse(TextBoxJamMasuk.Text)
            Dim JamKeluar As DateTime = DateTime.Parse(TextBoxJamKeluar.Text)
            Dim durasiParkir As TimeSpan = JamKeluar.Subtract(jamMasuk)

            ' Hitung total harga
            Dim tarifPerJam As Integer
            If TextBoxJenisKendaraan.Text.ToLower() = "motor" Then
                tarifPerJam = 3000
            ElseIf TextBoxJenisKendaraan.Text.ToLower() = "mobil" Then
                tarifPerJam = 5000
            End If

            dendaHilangTiket = 20000
            Dim totalHargaParkir As Integer = Math.Ceiling(durasiParkir.TotalHours) * tarifPerJam
            Dim totalDenda As Integer = dendaHilangTiket + totalHargaParkir
            TextBoxTotalDenda.Text = totalDenda.ToString()
            TextBoxTarif.Text = totalHargaParkir.ToString()
            TextBoxDenda.Text = dendaHilangTiket.ToString()
        Else
            MessageBox.Show("Data tidak ditemukan!")
        End If
        rd.Close()
    End Sub

    Private Sub ButtonHitungTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHitungTotal.Click
        Dim totalHarga As Integer = Integer.Parse(TextBoxTotalDenda.Text)
        Dim InputHarga As Integer = Integer.Parse(TextBoxInputHarga.Text)
        Dim kembalian As Integer = InputHarga - totalHarga
        TextBoxKembalian.Text = kembalian.ToString()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        Dim noPlat As String = TextBoxNoPlat.Text
        Dim jenisKendaraan As String = TextBoxJenisKendaraan.Text
        Dim tanggalMasuk As String = TextBoxTanggalMasuk.Text
        Dim jamMasuk As String = TextBoxJamMasuk.Text
        Dim tanggalKeluar As String = DateTime.Now.ToString("yyyy-MM-dd")
        jamKeluar = DateTime.Now.ToString("HH:mm:ss")
        Dim totalDenda As Decimal = Decimal.Parse(TextBoxTotalDenda.Text)

        ' Query untuk menyimpan data denda ke database
        Dim query As String = "INSERT INTO denda_parkir (no_plat, jenis_kendaraan, tanggal_masuk, jam_masuk, tanggal_keluar, jam_keluar, total_denda) VALUES ('" & noPlat & "', '" & jenisKendaraan & "', '" & tanggalMasuk & "', '" & jamMasuk & "', '" & tanggalKeluar & "', '" & jamKeluar & "', " & totalDenda & ")"
        cmd = New OdbcCommand(query, conn)
        cmd.ExecuteNonQuery()

        ' Mencetak Struk
        PPD.Document = PD
        PPD.ShowDialog()

        MessageBox.Show("Data berhasil disimpan")
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 300, 300)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
        Dim teksTitle As New Font("Times New Roman", 14, FontStyle.Bold)
        Dim teksBody As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim teksBodyBold As New Font("Times New Roman", 10, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim marginmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim teksTengah As New StringFormat
        Dim teksKanan As New StringFormat
        teksTengah.Alignment = StringAlignment.Center
        teksKanan.Alignment = StringAlignment.Far

        Dim garis As String
        garis = "----------------------------------------------------------"

        ' Isi dengan kode untuk mencetak struk masuk
        e.Graphics.DrawString("TIKET PARKIR", teksTitle, Brushes.Black, centermargin, 5, teksTengah)
        e.Graphics.DrawString("UNIVERSITAS BANTEN JAYA", teksBodyBold, Brushes.Black, centermargin, 25, teksTengah)
        e.Graphics.DrawString("Jl. Syech Nawawi Albantani", teksBody, Brushes.Black, centermargin, 40, teksTengah)
        e.Graphics.DrawString(garis, teksBody, Brushes.Black, 10, 60)

        e.Graphics.DrawString("Kendaraan", teksBody, Brushes.Black, 10, 85)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 100, 85)
        e.Graphics.DrawString(TextBoxJenisKendaraan.Text, teksBody, Brushes.Black, 105, 85)

        e.Graphics.DrawString("No Plat", teksBody, Brushes.Black, 10, 100)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 100, 100)
        e.Graphics.DrawString(TextBoxNoPlat.Text, teksBody, Brushes.Black, 105, 100)

        e.Graphics.DrawString("Jam Keluar", teksBody, Brushes.Black, 10, 115)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 100, 115)
        e.Graphics.DrawString(DateTime.Now.ToString("HH:mm:ss"), teksBody, Brushes.Black, 105, 115)

        e.Graphics.DrawString("Denda", teksBody, Brushes.Black, 10, 130)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 100, 130)
        e.Graphics.DrawString("Rp. " & dendaHilangTiket, teksBody, Brushes.Black, 105, 130)

        e.Graphics.DrawString("Total Harga", teksBody, Brushes.Black, centermargin, 165, teksTengah)
        e.Graphics.DrawString("Rp. " & TextBoxTotalDenda.Text, teksBodyBold, Brushes.Black, centermargin, 185, teksTengah)

        e.Graphics.DrawString(garis, teksBody, Brushes.Black, 10, 200)
        e.Graphics.DrawString("Terimakasih", teksBody, Brushes.Black, centermargin, 215, teksTengah)
        e.Graphics.DrawString("Atas Kunjungan Anda", teksBody, Brushes.Black, centermargin, 235, teksTengah)
        e.Graphics.DrawString("~ UNIVERSITAS BANTEN JAYA ~", teksBody, Brushes.Black, centermargin, 255, teksTengah)
    End Sub

    
End Class