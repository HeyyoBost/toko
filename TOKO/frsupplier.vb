Public Class frsupplier
    Dim startrecord As Integer = 0
    Dim totalrecordperhalaman = 10
    Sub tampilkan(ByVal sql As String)
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = sql
        mda.SelectCommand = eksekusi
        ds.Tables.Clear()
        mda.Fill(ds, startrecord, totalrecordperhalaman, "data")
        dgv.DataSource = (ds.Tables("data"))
        conn.Close()

    End Sub
    Sub aturdatagrid()
        dgv.Columns(0).HeaderText = "Kode Barang / Barcode "
        dgv.Columns(1).HeaderText = "Nama Supplier "
        dgv.Columns(2).HeaderText = "Email  "
        dgv.Columns(3).HeaderText = "Alamat "
        dgv.Columns(4).HeaderText = "No HP "


        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 130
        dgv.Columns(3).Width = 300
        dgv.Columns(4).Width = 100
    End Sub

    Private Function getrowscount() As Integer
        tampilkan("select * from supplier")
        ds = New DataSet
        mda.Fill(ds)
        Return ds.Tables(0).Rows.Count

    End Function

    Sub cekdata()
        Dim endrecord As Integer = getrowscount() / totalrecordperhalaman
        If startrecord = 0 Then
            bprev.Enabled = False
        ElseIf startrecord / totalrecordperhalaman + 1 = endrecord Then
            bnext.Enabled = False
        Else
            bprev.Enabled = True
            bnext.Enabled = True
        End If
    End Sub
    Sub tombol()
        Dim bedit As New DataGridViewButtonColumn
        Dim bhapus As New DataGridViewButtonColumn

        bedit.Name = "bedit"
        bedit.HeaderText = ""
        bedit.FlatStyle = FlatStyle.Popup
        bedit.DefaultCellStyle.ForeColor = Color.Green
        bedit.Text = "Edit"
        bedit.Width = "50"
        bedit.UseColumnTextForButtonValue = True
        dgv.Columns.Add(bedit)

        bhapus.Name = "bhapus"
        bhapus.HeaderText = ""
        bhapus.FlatStyle = FlatStyle.Popup
        bhapus.DefaultCellStyle.ForeColor = Color.Green
        bhapus.Text = "Hapus"
        bhapus.Width = "50"
        bhapus.UseColumnTextForButtonValue = True
        dgv.Columns.Add(bhapus)

    End Sub
    Sub clean()
        tkode.Text = ""
        tnama.Text = ""
        temail.Text = ""
        talamat.Text = ""
        tnomer.Text = ""
        bsimpan.Text = "SIMPAN" 'merubah tombol update menjaid simpan
        tkode.Enabled = True
        autokode()

    End Sub
    Sub autokode()
        Dim kode, kodebaru As String
        Dim no As Integer
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "select * from supplier order by kodesup DESC limit 1"
        cek = eksekusi.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("kodesup")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            kodebaru = "SUP-" + Format(no, "000")
            tkode.Text = kodebaru
        Else
            tkode.Text = "SUP-" + "001"
        End If
        conn.Close()
        tkode.Enabled = False
        tnama.Focus()
    End Sub

    Private Sub frsupplier_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgv.Columns.Clear()
        tampilkan("select * from supplier")
        aturdatagrid()
        tombol()
        autokode()

    End Sub

    Private Sub frsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.Columns.Clear()
        tampilkan("select * from supplier")
        aturdatagrid()
        tombol()
        autokode()

    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        If tkode.Text = "" Or tnama.Text = "" Then
            MsgBox("lengkapi data")
        ElseIf bsimpan.Text = "SIMPAN" Then
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "insert into supplier (kodesup, namasup, emailsup, alamatsup,telp) VALUES ('" & tkode.Text & "','" & tnama.Text & "','" & temail.Text & "','" & talamat.Text & "','" & tnomer.Text & "')"
            eksekusi.ExecuteNonQuery()
            MsgBox("berhasil disimpan", MsgBoxStyle.Information, "sukses")
        Else
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "update supplier set namasup= '" & tnama.Text & "',emailsup= '" & temail.Text & "',alamatsup='" & talamat.Text & "',telp='" & tnomer.Text & "' where kodesup= '" & tkode.Text & "' "
            eksekusi.ExecuteNonQuery()
            MsgBox("Update", MsgBoxStyle.Information, "sukses")
        End If
        dgv.Columns.Clear()
        tampilkan("select * from supplier")
        aturdatagrid()
        clean()
        tombol()
    End Sub

    Private Sub tkode_KeyDown(sender As Object, e As KeyEventArgs) Handles tkode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tnama.Focus()
        End Select
    End Sub


    Private Sub tnama_KeyDown(sender As Object, e As KeyEventArgs) Handles tnama.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                temail.Focus()
        End Select
    End Sub


    Private Sub temail_KeyDown(sender As Object, e As KeyEventArgs) Handles temail.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                talamat.Focus()
        End Select
    End Sub

    Private Sub talamat_KeyDown(sender As Object, e As KeyEventArgs) Handles talamat.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tnomer.Focus()
        End Select
    End Sub


    Private Sub tnomer_KeyDown(sender As Object, e As KeyEventArgs) Handles tnomer.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                bsimpan_Click(e, AcceptButton)
        End Select
    End Sub

    Private Sub tnomer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnomer.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then 'membatasi hanya angka yang di input
            e.KeyChar = Chr(0)
        Else
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clean()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As String
        Dim kode As String
        i = dgv.CurrentRow.Index
        kode = dgv.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 5 Then
            tkode.Text = kode
            tnama.Focus()
        End If
        If e.ColumnIndex = 6 Then
            Dim x As Byte
            i = dgv.CurrentRow.Index
            x = MsgBox("hapus data  supplier dengan kode " & kode & " ?", MsgBoxStyle.Critical + vbYesNo, "konfirmasi")
            If x = vbYes Then
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "delete from supplier where kodesupp = '" & kode & "'"
                eksekusi.ExecuteNonQuery()
                MsgBox("data berhasil dihapus", MsgBoxStyle.Information, "informasi")
                dgv.Columns.Clear()
                tampilkan("select * from supplier")
                aturdatagrid()
                tombol()
            End If
        End If

    End Sub

    Private Sub tkode_TextChanged(sender As Object, e As EventArgs) Handles tkode.TextChanged
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "select * from supplier where kodesup = '" & tkode.Text & "'"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            tnama.Text = cek.Item("namasup")
            temail.Text = cek.Item("emailsup")
            talamat.Text = cek.Item("alamatsup")
            tnomer.Text = cek.Item("telp")
            bsimpan.Text = "UPDATE" 'merubah tombol simpan menjadi update
            tkode.Enabled = False 'untuk mendisable textbox saat update
        End If
        conn.Close()
    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged
        dgv.Columns.Clear()
        tampilkan("select * from supplier where kodesup like '%" & tcari.Text & "%' or namasup like '%" & tcari.Text & "%' ")
        aturdatagrid()
        tombol()
    End Sub

    Private Sub bprev_Click(sender As Object, e As EventArgs) Handles bprev.Click
        startrecord = startrecord - totalrecordperhalaman
        tampilkan("select * from supplier")
        cekdata()
    End Sub

    Private Sub bnext_Click(sender As Object, e As EventArgs) Handles bnext.Click
        startrecord = startrecord + totalrecordperhalaman
        tampilkan("select * from supplier")
        cekdata()
    End Sub
End Class