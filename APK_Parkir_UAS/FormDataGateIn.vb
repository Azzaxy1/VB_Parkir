Imports System.Data.Odbc

Public Class FormDataGateIn
    Sub KondisiAwal()
        ' Pastikan Anda menghubungkan ke database dengan benar
        KoneksiDb()
        Da = New OdbcDataAdapter("SELECT kode_masuk, jenis_kendaraan, no_plat, tanggal, jam FROM gate_in", conn)
        Ds = New DataSet
        Da.Fill(Ds, "gate_in")
        DataGridViewGateIn.DataSource = Ds.Tables("gate_in")
    End Sub

    Private Sub FormDataGateIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub FormDataGateIn_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TutupKoneksi()
    End Sub
End Class
