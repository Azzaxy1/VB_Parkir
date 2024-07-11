Imports System.Data.Odbc
Imports System.Drawing.Printing

Public Class FormGateIn
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog

    Dim kodeMasuk As String
    Dim tanggal As String
    Dim jam As String
    Dim jenisKendaraan As String
    Dim noPlat As String

    Sub KondisiAwal()
        KoneksiDb()
        Da = New OdbcDataAdapter("SELECT kode_masuk, jenis_kendaraan, no_plat, tanggal, jam FROM gate_in", conn)
        Ds = New DataSet
        Da.Fill(Ds, "gate_in")
    End Sub

    Private Sub FormGateIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Panggil database saat form dibuka
        Call KondisiAwal()

        ' Agar jam berjalan
        TextBoxTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy")
        TextBoxJam.Text = DateTime.Now.ToString("HH:mm:ss")
        TimerJam.Interval = 1000
        TimerJam.Enabled = True
    End Sub

    Private Sub TimerJam_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerJam.Tick
        TextBoxJam.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub FormGateIn_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TutupKoneksi()
    End Sub

    Private Sub ButtonSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSimpan.Click
        ' Ambil nilai dari komponen-komponen yang diperlukan
        kodeMasuk = DateTime.Now.ToString("yyMMddHHmmss")
        tanggal = DateTime.Now.ToString("yyyy-MM-dd")
        jam = DateTime.Now.ToString("HH:mm:ss")
        jenisKendaraan = ComboBoxJenisKendaraan.SelectedItem.ToString()
        noPlat = TextBoxNoPlat.Text

        ' Tampilkan nilai-nilai di label
        TextBoxKodeMasuk.Text = kodeMasuk

        ' Query untuk menyimpan data masuk ke database
        Dim query As String = "INSERT INTO gate_in (kode_masuk, tanggal, jam, jenis_kendaraan, no_plat) VALUES ('" & kodeMasuk & "','" & tanggal & "','" & jam & "','" & jenisKendaraan & "','" & noPlat & "')"
        cmd = New OdbcCommand(query, conn)
        cmd.ExecuteNonQuery()

        ' Mencetak Struk
        PPD.Document = PD
        PPD.ShowDialog()

        MessageBox.Show("Data berhasil disimpan!")
        Call KondisiAwal()
    End Sub

    Private Sub ButtonTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTutup.Click
        End
    End Sub

    Private Sub PD_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PD.BeginPrint
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
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 75, 85)
        e.Graphics.DrawString(jenisKendaraan, teksBody, Brushes.Black, 85, 85)

        e.Graphics.DrawString("No Plat", teksBody, Brushes.Black, 10, 100)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 75, 100)
        e.Graphics.DrawString(noPlat, teksBody, Brushes.Black, 85, 100)

        e.Graphics.DrawString("Jam", teksBody, Brushes.Black, 10, 115)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 75, 115)
        e.Graphics.DrawString(jam, teksBody, Brushes.Black, 85, 115)

        e.Graphics.DrawString("Tanggal", teksBody, Brushes.Black, 10, 130)
        e.Graphics.DrawString(":", teksBody, Brushes.Black, 75, 130)
        e.Graphics.DrawString(DateTime.Now.ToString("dd-MM-yyyy"), teksBody, Brushes.Black, 85, 130)

        e.Graphics.DrawString("Kode masuk anda :", teksBody, Brushes.Black, centermargin, 165, teksTengah)
        e.Graphics.DrawString(kodeMasuk, teksBodyBold, Brushes.Black, centermargin, 185, teksTengah)

        e.Graphics.DrawString(garis, teksBody, Brushes.Black, 10, 200)
        e.Graphics.DrawString("Jangan Meninggalkan Tiket dan Barang", teksBody, Brushes.Black, centermargin, 215, teksTengah)
        e.Graphics.DrawString("Berharga di Dalam Kendaraan", teksBody, Brushes.Black, centermargin, 235, teksTengah)
        e.Graphics.DrawString("~ UNIVERSITAS BANTEN JAYA ~", teksBody, Brushes.Black, centermargin, 255, teksTengah)
    End Sub
End Class
