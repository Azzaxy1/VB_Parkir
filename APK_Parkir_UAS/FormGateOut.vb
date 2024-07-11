Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FormGateOut
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim tanggalKeluar As String
    Dim jamKeluar As String
    Dim totalHarga As Integer

    Private Sub FormGateOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KoneksiDb()

        'Set tanggal dan jam keluar
        TextBoxTanggalKeluar.Text = DateTime.Now.ToString("yyyy-MM-dd")
        TextBoxJamKeluar.Text = DateTime.Now.ToString("HH:mm:ss")

        TimerJam.Interval = 1000
        TimerJam.Enabled = True
    End Sub

    Private Sub TimerJam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerJam.Tick
        TextBoxJamKeluar.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub FormGateOut_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TutupKoneksi()
    End Sub

    Private Sub ButtonTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTutup.Click
        End
    End Sub

    Private Sub ButtonCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCari.Click
        ' Cari kendaraan berdasarkan Kode Masuk
        Dim kodeMasuk As String = TextBoxKodeMasuk.Text
        Dim query As String = "SELECT * FROM gate_in WHERE kode_masuk = '" & kodeMasuk & "'"
        cmd = New OdbcCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.Read() Then
            TextBoxNoPlat.Text = rd("no_plat").ToString()
            TextBoxJenisKendaraan.Text = rd("jenis_kendaraan").ToString()
            TextBoxTanggalMasuk.Text = DateTime.Parse(rd("tanggal").ToString()).ToString("yyyy-MM-dd")
            TextBoxJamMasuk.Text = rd("jam").ToString()

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

            totalHarga = Math.Ceiling(durasiParkir.TotalHours) * tarifPerJam
            TextBoxTotalHarga.Text = totalHarga.ToString()
        Else
            MessageBox.Show("Data tidak ditemukan!")
        End If
        rd.Close()
    End Sub

    Private Sub ButtonHitungTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonHitungTotal.Click
        Dim totalHarga As Integer = Integer.Parse(TextBoxTotalHarga.Text)
        Dim InputHarga As Integer = Integer.Parse(TextBoxInputHarga.Text)
        Dim kembalian As Integer = InputHarga - totalHarga
        TextBoxKembalian.Text = kembalian.ToString()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        ' Ambil nilai dari komponen-komponen yang diperlukan
        tanggalKeluar = DateTime.Now.ToString("yyyy-MM-dd")
        jamKeluar = DateTime.Now.ToString("HH:mm:ss")
        Dim kodeMasuk As String = TextBoxKodeMasuk.Text
        Dim noPlat As String = TextBoxNoPlat.Text
        Dim jenisKendaraan As String = TextBoxJenisKendaraan.Text
        Dim tanggalMasuk As String = TextBoxTanggalMasuk.Text
        Dim jamMasuk As String = TextBoxJamMasuk.Text
        Dim totalHarga As Integer = Integer.Parse(TextBoxTotalHarga.Text)

        'Query untuk menyimpan data keluar ke database
        Dim query As String = "INSERT INTO gate_out (kode_masuk, tanggal_masuk, jam_masuk, tanggal_keluar, jam_keluar, jenis_kendaraan, no_plat, total_bayar) VALUES ('" & kodeMasuk & "', '" & tanggalMasuk & "', '" & jamMasuk & "', '" & tanggalKeluar & "', '" & jamKeluar & "', '" & jenisKendaraan & "', '" & noPlat & "', '" & totalHarga & "')"
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

    Private Sub PD_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PD.PrintPage
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
        e.Graphics.DrawString(jamKeluar, teksBody, Brushes.Black, 105, 115)

        e.Graphics.DrawString("Tanggal Keluar", teksBody, Brushes.Black, 10, 130)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 100, 130)
        e.Graphics.DrawString(tanggalKeluar, teksBody, Brushes.Black, 105, 130)

        e.Graphics.DrawString("Total Bayar", teksBody, Brushes.Black, centermargin, 165, teksTengah)
        e.Graphics.DrawString("Rp. " & totalHarga, teksBodyBold, Brushes.Black, centermargin, 185, teksTengah)

        e.Graphics.DrawString(garis, teksBody, Brushes.Black, 10, 200)
        e.Graphics.DrawString("Terimakasih", teksBody, Brushes.Black, centermargin, 215, teksTengah)
        e.Graphics.DrawString("Atas Kunjungan Anda", teksBody, Brushes.Black, centermargin, 235, teksTengah)
        e.Graphics.DrawString("~ UNIVERSITAS BANTEN JAYA ~", teksBody, Brushes.Black, centermargin, 255, teksTengah)
    End Sub
End Class