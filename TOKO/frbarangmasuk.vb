Public Class frbarangmasuk

    Sub tampil(ByVal sql As String)
        cekkoneksi()
        eksekusi.Connection = conn
        eksekusi.CommandType = CommandType.Text
        eksekusi.CommandText = sql
        mda.SelectCommand = eksekusi
        ds.Tables.Clear()
        mda.Fill(ds, "data")
        dgv.DataSource = (ds.Tables("data"))
        jumlahitem.Text = dgv.RowCount
        conn.Close()

    End Sub
    Sub aturdatagrid()
        dgv.Columns(0).HeaderText = "Kode Barang "
        dgv.Columns(1).HeaderText = "Nama Barang "
        dgv.Columns(2).HeaderText = "Quantity  "

        dgv.Columns(0).Width = 50
        dgv.Columns(1).Width = 200
        dgv.Columns(2).Width = 50
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

    Private Sub frbarangmasuk_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgv.Columns.Clear()
        tampil("select barang,nama,jumlah from temp where kode = '" & tno.Text & "'")
        aturdatagrid()
        tombol()
    End Sub

    Private Sub frbarangmasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.Columns.Clear()
        tampil("select barang,nama,jumlah from temp where kode = '" & tno.Text & "'")
        aturdatagrid()
        tombol()
    End Sub

    Private Sub bcari_Click(sender As Object, e As EventArgs) Handles bcari.Click
        frcarisupplier.Show()
    End Sub

    Private Sub tkode_KeyDown(sender As Object, e As KeyEventArgs) Handles tkode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "select * from barang where kodebrg = '" & tkode.Text & "'"
                cek = eksekusi.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    lbarang.Text = cek.Item("namabrg")
                    tjumlah.Focus()
                Else
                    frbarang.MdiParent = frmenu
                    frbarang.WindowState = FormWindowState.Maximized
                    frbarang.Show()
                End If
        End Select
    End Sub

    Private Sub tkode_TextChanged(sender As Object, e As EventArgs) Handles tkode.TextChanged

    End Sub

    Private Sub bplus_Click(sender As Object, e As EventArgs) Handles bplus.Click
        If tno.Text = "" Or tjumlah.Text = "" Then
            MsgBox(" lengkapi input data ", , MsgBoxStyle.Information)
        Else
            If bplus.Text = ">" Then
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "insert into temp values('" & tno.Text & "','" & tkode.Text & "','" & lbarang.Text & "','" & tjumlah.Text & "')"
                eksekusi.ExecuteNonQuery()
            Else
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "update temp set nama ='" & lbarang.Text & "',jumlah='" & tjumlah.Text & "'where barang = '" & tkode.Text & "' and kode = '" & tno.Text & "'"
                eksekusi.ExecuteNonQuery()
                bplus.Text = ">"

            End If
            dgv.Columns.Clear()
            tampil("select barang,nama,jumlah from temp where kode = '" & tno.Text & "'")
            aturdatagrid()
            tombol()
            tkode.Text = ""
            lbarang.Text = "Nama Barang"
            tjumlah.Text = ""
            tkode.Focus()
        End If
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As Integer
        Dim barang, nama, jumlah As String
        i = dgv.CurrentRow.Index
        barang = dgv.Rows.Item(i).Cells(0).Value
        nama = dgv.Rows.Item(i).Cells(1).Value
        jumlah = dgv.Rows.Item(i).Cells(2).Value
        If e.ColumnIndex = 3 Then
            tkode.Text = barang
            lbarang.Text = nama
            tjumlah.Text = jumlah
            bplus.Text = ">>"

        End If
        If e.ColumnIndex = 4 Then
            Dim konfirmasi As Byte
            konfirmasi = MsgBox("Hapus item ini ? ", MsgBoxStyle.Critical + vbYesNo, "konfirmasi")
            If konfirmasi = vbYes Then
                cekkoneksi()
                eksekusi.Connection = conn
                eksekusi.CommandType = CommandType.Text
                eksekusi.CommandText = "delete from temp where barang = '" & barang & "' and kode = '" & tno.Text & "'"
                eksekusi.ExecuteNonQuery()
                dgv.Columns.Clear()
                tampil("select barang,nama,jumlah from temp where kode = '" & tno.Text & "'")
                aturdatagrid()
                tombol()

            End If
        End If
    End Sub
End Class