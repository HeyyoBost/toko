Public Class frcarisupplier
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


        dgv.Columns(0).Width = 100
        dgv.Columns(1).Width = 150
        dgv.Columns(2).Width = 50
        dgv.Columns(3).Width = 150
        dgv.Columns(4).Width = 100


    End Sub

    Private Function getrowscount() As Integer
        tampilkan("select * from supplier")
        ds = New DataSet
        mda.Fill(ds)
        Return ds.Tables(0).Rows.Count

    End Function
    Sub tombol()
        Dim bpilih As New DataGridViewButtonColumn

        bpilih.Name = "bedit"
        bpilih.HeaderText = ""
        bpilih.FlatStyle = FlatStyle.Popup
        bpilih.DefaultCellStyle.ForeColor = Color.Green
        bpilih.Text = "Pilih"
        bpilih.Width = "50"
        bpilih.UseColumnTextForButtonValue = True
        dgv.Columns.Add(bpilih)



    End Sub

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
    Private Sub tcari_TextChanged(sender As Object, e As EventArgs) Handles tcari.TextChanged
        dgv.Columns.Clear()
        tampilkan("select * from supplier where kodesup like '%" & tcari.Text & "%' or namasup like '%" & tcari.Text & "%' ")
        aturdatagrid()
        tombol()
    End Sub

    Private Sub frcarisupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.Columns.Clear()
        tampilkan("select * from supplier")
        aturdatagrid()
        tombol()
    End Sub

    Private Sub bprev_Click(sender As Object, e As EventArgs)
        startrecord = startrecord - totalrecordperhalaman
        tampilkan("select * from supplier")
        cekdata()
    End Sub

    Private Sub bnext_Click(sender As Object, e As EventArgs)
        startrecord = startrecord + totalrecordperhalaman
        tampilkan("select * from supplier")
        cekdata()
    End Sub

    Private Sub bnext_Click_1(sender As Object, e As EventArgs) Handles bnext.Click
        startrecord = startrecord + totalrecordperhalaman
        tampilkan("select * from supplier")
        cekdata()
    End Sub

    Private Sub bprev_Click_1(sender As Object, e As EventArgs) Handles bprev.Click
        startrecord = startrecord - totalrecordperhalaman
        tampilkan("select * from supplier")
        cekdata()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
        Dim i As String
        Dim kode, nama As String
        i = dgv.CurrentRow.Index
        kode = dgv.Rows.Item(i).Cells(0).Value
        nama = dgv.Rows.Item(i).Cells(1).Value
        If e.ColumnIndex = 5 Then
            frbarangmasuk.tkosup.Text = kode
            frbarangmasuk.tnasup.Text = nama

        End If
        Me.Close()
    End Sub
End Class