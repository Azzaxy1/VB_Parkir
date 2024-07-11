Imports System.Data.Odbc

Module Koneksi
    Public conn As OdbcConnection
    Public cmd As OdbcCommand
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public rd As OdbcDataReader

    ' Method untuk membuka koneksi ke database
    Public Sub KoneksiDb()
        Try
            conn = New OdbcConnection("DSN=parkiran_db;UID=root;")
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi ke database gagal: " & ex.Message)
        End Try
    End Sub

    ' Method untuk menutup koneksi ke database
    Public Sub TutupKoneksi()
        If conn IsNot Nothing AndAlso conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Module

