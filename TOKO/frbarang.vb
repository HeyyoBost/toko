Public Class frbarang
    Dim hrgbeli, hrgjual As Long
    Dim startrecord As Integer = 0
    Dim totalrecordperhalaman = 10
    Sub autokode()
        Dim kode, kodebaru As String
        Dim no As Integer
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "select * from barang order by kodebrg DESC limit 1"
        cek = eksekusi.ExecuteReader()
        cek.Read()
        If cek.HasRows Then
            kode = cek.Item("kodebrg")
            no = Val(Microsoft.VisualBasic.Right(kode, 3))
            no = no + 1
            kodebaru = "BRG-" + Format(no, "000")
            tkode.Text = kodebaru
        Else
            tkode.Text = "BRG-" + "001"
        End If
        conn.Close()
        tkode.Enabled = False
        tnama.Focus()
    End Sub
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
        dgv.Columns(1).HeaderText = "Nama Barang "
        dgv.Columns(2).HeaderText = "Satuan "
        dgv.Columns(3).HeaderText = "Harga Beli "
        dgv.Columns(4).HeaderText = "Harga Jual "
        dgv.Columns(5).HeaderText = "Stock "

        dgv.Columns(0).Width = 70
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 50
        dgv.Columns(3).Width = 50
        dgv.Columns(4).Width = 50
        dgv.Columns(5).Width = 40

    End Sub
    Sub clean()
        tkode.Text = ""
        tnama.Text = ""
        cbsatuan.Text = ""
        tbeli.Text = ""
        tjual.Text = ""
        tstok.Text = ""
        bsimpan.Text = "SIMPAN" 'merubah tombol update menjaid simpan
        tkode.Enabled = True
        autokode()

    End Sub

    Private Function getrowscount() As Integer
        tampilkan("select * from barang")
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


    Private Sub frbarang_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgv.Columns.Clear()
        tampilkan("select * from barang")
        aturdatagrid()
        tombol()
        autokode()
    End Sub

    Private Sub frbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.Columns.Clear()
        tampilkan("select * from barang")
        aturdatagrid()
        tombol()
        cekdata()
        autokode()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles tkode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tnama.Focus()
        End Select
    End Sub
    Private Sub tnama_KeyDown(sender As Object, e As KeyEventArgs) Handles tnama.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cbsatuan.Focus()
        End Select
    End Sub
    Private Sub cbsatuan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsatuan.SelectedIndexChanged
        tbeli.Focus()
    End Sub

    Private Sub tbeli_KeyDown(sender As Object, e As KeyEventArgs) Handles tbeli.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tjual.Focus()
        End Select
    End Sub

    Private Sub tbeli_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbeli.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then 'membatasi hanya angka yang di input
            e.KeyChar = Chr(0)
        Else
        End If
    End Sub

    Private Sub tbeli_TextChanged(sender As Object, e As EventArgs) Handles tbeli.TextChanged
        If tbeli.Text = "" Then
            Exit Sub
        Else
            hrgbeli = tbeli.Text
            tbeli.Text = Format(hrgbeli, "##,##0")
            tbeli.SelectionStart = Len(tbeli.Text)
        End If
    End Sub

    Private Sub tjual_KeyDown(sender As Object, e As KeyEventArgs) Handles tjual.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                tstok.Focus()
        End Select
    End Sub

    Private Sub tjual_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tjual.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = Chr(0)
        Else
        End If
    End Sub

    Private Sub tjual_TextChanged(sender As Object, e As EventArgs) Handles tjual.TextChanged
        If tjual.Text = "" Then
            Exit Sub
        Else
            hrgjual = tjual.Text
            tjual.Text = Format(hrgjual, "##,##0")
            tjual.SelectionStart = Len(tjual.Text)
        End If 
    End Sub

    Private Sub tstok_KeyDown(sender As Object, e As KeyEventArgs) Handles tstok.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                bsimpan.Select()
        End Select
    End Sub
    Private Sub tstok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tstok.KeyPress
        If Strings.InStr("0123456789" & Chr(8), e.KeyChar) = 0 Then 'membatasi hanya angka yang di input
            e.KeyChar = Chr(0)
        Else
        End If
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        If tkode.Text = "" Or tnama.Text = "" Then
            MsgBox("lengkapi data")
        ElseIf bsimpan.Text = "SIMPAN" Then
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "insert into barang (kodebrg, namabrg, satuanbrg, hrgbeli,hrgjual, stokbrg) VALUES ('" & tkode.Text & "','" & tnama.Text & "','" & cbsatuan.Text & "','" & hrgbeli & "','" & hrgjual & "','" & tstok.Text & "')"
            eksekusi.ExecuteNonQuery()
            MsgBox("berhasil disimpan", MsgBoxStyle.Information, "sukses")
        Else
            cekkoneksi()
            eksekusi.Connection = conn
            eksekusi.CommandType = CommandType.Text
            eksekusi.CommandText = "update barang set namabrg='" & tnama.Text & "',satuanbrg= '" & cbsatuan.Text & "',hrgbeli='" & hrgbeli & "',hrgjual='" & hrgjual & "',stokbrg= '" & tstok.Text & "' where kodebrg= '" & tkode.Text & "' "
            eksekusi.ExecuteNonQuery()
            MsgBox("UPDATE", MsgBoxStyle.Information, "sukses")
            dgv.Columns.Clear()

        End If
        tampilkan("select * from Barang")
        aturdatagrid()
        clean()
        tombol()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub tkode_TextChanged(sender As Object, e As EventArgs) Handles tkode.TextChanged
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = "select * from barang where kodebrg = '" & tkode.Text & "'"
        cek = eksekusi.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            tnama.Text = cek.Item("namabrg")
            cbsatuan.Text = cek.Item("satuanbrg")
            tbeli.Text = cek.Item("hrgbeli")
            tjual.Text = cek.Item("hrgjual")
            tstok.Text = cek.Item("stokbrg")
            bsimpan.Text = "UPDATE" 'merubah tombol simpan menjadi update
            tkode.Enabled = False 'untuk mendisable textbox saat update
        End If
        conn.Close()

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As String
        Dim kode As String
        i = dgv.CurrentRow.Index
        kode = dgv.Rows.Item(i).Cells(0).Value
        If e.ColumnIndex = 6 Then
            tkode.Text = kode
            tnama.Focus()
        End If
        If e.ColumnIndex = 7 Then
            Dim x As Byte
            i = dgv.CurrentRow.Index
            x = MsgBox("hapus data  barang dengan kode " & kode & " ?", MsgBoxStyle.Critical + vbYesNo, "konfirmasi")
            If x = vbYes Then
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "delete from barang where kodebrg = '" & kode & "'"
                eksekusi.ExecuteNonQuery()
                MsgBox("data berhasil dihapus", MsgBoxStyle.Information, "informasi")
                dgv.Columns.Clear()
                tampilkan("select * from barang")
                aturdatagrid()
                tombol()
            End If
        End If

    End Sub

    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged
        dgv.Columns.Clear()
        tampilkan("select * from barang where kodebrg like '%" & tcari.Text & "%' or namabrg like '%" & tcari.Text & "%' ")
        aturdatagrid()
        tombol()

    End Sub

    Private Sub bprev_Click(sender As Object, e As EventArgs) Handles bprev.Click
        startrecord = startrecord - totalrecordperhalaman
        tampilkan("select * from barang")
        cekdata()

    End Sub

    Private Sub bnext_Click(sender As Object, e As EventArgs) Handles bnext.Click
        startrecord = startrecord + totalrecordperhalaman
        tampilkan("select * from barang")
        cekdata()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clean()
    End Sub
End Class