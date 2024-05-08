Public Class frmenu
    Private Sub DataBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataBarangToolStripMenuItem.Click
        frbarang.MdiParent = Me
        frbarang.WindowState = FormWindowState.Maximized
        frbarang.Show()
    End Sub

    Private Sub frmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataSupplierToolStripMenuItem.Click
        frsupplier.MdiParent = Me
        frsupplier.WindowState = FormWindowState.Maximized
        frsupplier.Show()
    End Sub

    Private Sub DataPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPelangganToolStripMenuItem.Click
        frpelanggan.MdiParent = Me
        frpelanggan.WindowState = FormWindowState.Maximized
        frpelanggan.Show()
    End Sub

    Private Sub BarangMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangMasukToolStripMenuItem.Click
        frbarangmasuk.MdiParent = Me
        frbarangmasuk.WindowState = FormWindowState.Maximized
        frbarangmasuk.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        frlogin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class