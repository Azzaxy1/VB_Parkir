Imports System.Data.Odbc

Public Class FormDataGateOut
    Sub KondisiAwal()
        ' Pastikan Anda menghubungkan ke database dengan benar
        KoneksiDb()
        Da = New OdbcDataAdapter("SELECT kode_masuk, tanggal_masuk, jam_masuk, tanggal_keluar, jam_keluar, jenis_kendaraan, no_plat, total_bayar FROM gate_out", conn)
        Ds = New DataSet
        Da.Fill(Ds, "gate_out")
        DataGridViewGateOut.DataSource = Ds.Tables("gate_out")
    End Sub

    Private Sub FormDataGateOut_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub FormDataGateOut_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TutupKoneksi()
    End Sub
End Class