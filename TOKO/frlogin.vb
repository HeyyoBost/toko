Public Class frlogin
    Dim userlogin, namauser, level As String
 
    Private Sub txuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txuser.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txpass.Focus()
        End Select
    End Sub

    Private Sub txpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txpass.KeyPress
        If (e.KeyChar = Chr(13)) Then
            bsingin.Select()
        End If
    End Sub

    Private Sub frlogin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.autologin = True Then
            ckautologin.Checked = True
            txuser.Text = My.Settings.username
            txpass.Text = My.Settings.password
        Else
            ckautologin.Checked = True
            My.Settings.username = ""
            My.Settings.password = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If lihatpw.Checked = True Then
            txpass.PasswordChar = ""
        Else
            txpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ckautologin.Checked = True Then 'jika auto login di cek
            My.Settings.username = txuser.Text 'maka simpan ke mysetting
            My.Settings.password = txpass.Text ''maka simpan ke mysetting
            My.Settings.autologin = True 'jika data sudah disi, maka value dari autologin - true
            My.Settings.Save() ' lalu simpan
            My.Settings.Reload() 'lalu reload
        Else
            My.Settings.autologin = False 'kalau di atidak menyimpan
        End If
        conn.Close() ' tutup koneksi dulu
        conn.Open() ' lalu buka lagi
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "select * from user where username = '" & txuser.Text & "' and pass = '" & txpass.Text & "' and useraktif = 1" 'jika user aktifnya 0 beratik dia tidak bisa login
        cek = eksekusi.ExecuteReader 'melakukan cek ke database
        cek.Read() 'jika ada data
        If cek.HasRows Then 'jika ditemuka
            userlogin = txuser.Text 'data di cek
            namauser = cek.Item("nama") 'apakah ada nam
            level = cek.Item("level") 'apakah ada level
            If level = 1 Then 'jika levelnya 1 makan
                frmenu.Show() ' tampilkan form menu
            ElseIf level = 2 Then 'jika levelnya2
                frmenu.Show() 'tampilkan form menu
                frmenu.MasterToolStripMenuItem.Visible = False 'ini tidak tampil
                frmenu.DataBarangToolStripMenuItem.Visible = False 'ini tidak tampil
                frmenu.LaporaToolStripMenuItem.Visible = False 'ini tidak tampil
            Else
                frmenu.Show()
                frmenu.MasterToolStripMenuItem.Visible = False
                frmenu.DataBarangToolStripMenuItem.Visible = False
                'frmenu.LaporaToolStripMenuItem.Visible = False
                frmenu.TransaksiToolStripMenuItem.Visible = False
                frmenu.AccoutToolStripMenuItem.Visible = False
            End If
            frmenu.namauser.Text = namauser '
        Else
            MsgBox("username / password salah", MsgBoxStyle.Critical, "informasi") 'jika tidak tampilkan ini
            txuser.Text = "" 'kosongkan
            txpass.Text = "" 'kososngkan
        End If
    End Sub
 
End Class