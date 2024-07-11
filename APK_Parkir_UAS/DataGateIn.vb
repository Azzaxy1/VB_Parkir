Imports System.Data.Odbc

Public Class DataGateIn
    Private Sub DataGateIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pastikan Anda menghubungkan ke database dengan benar
        KoneksiDb()
        Da = New OdbcDataAdapter("SELECT kode_masuk, jenis_kendaraan, no_plat, tanggal, jam FROM gate_in", conn)
        Ds = New DataSet
        Da.Fill(Ds, "gate_in")
        DataGridViewGateIn.DataSource = Ds.Tables("gate_in")
    End Sub

    Private Sub DataGateIn_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        TutupKoneksi()
    End Sub
End Class