Public Class FormLogin
    Private Const USERNAME As String = "admin"
    Private Const PASSWORD As String = "admin123"

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Mendapatkan Input dari Pengguna
        Dim InputUsername As String = txtUsername.Text
        Dim InputPassword As String = txtPassword.Text

        ' Verifikasi
        If InputUsername = USERNAME AndAlso InputPassword = PASSWORD Then
            ' Jika berhasil Buka Menu Utama
            Dim menuUtama As New MenuUtama()
            menuUtama.Show()
            Me.Hide()
            txtUsername.Text = ""
            txtPassword.Text = ""
        Else
            ' Jika gagal tampilkan Kesalahan
            MessageBox.Show("Username atau Password Salah", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class