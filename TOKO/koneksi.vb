Imports MySql.Data.MySqlClient
Module ModuleKoneksiMySQL

    Dim connection As String = "server=localhost;user=root;password=1234;database=kasir;allow user variables=true"
    Public conn As New MySqlConnection(connection)
    Public eksekusi As New MySqlCommand
    Public cek As MySqlDataReader 'untuk variabel ke database
    Public mda As New MySqlDataAdapter
    Public ds As New DataSet

    Public Sub cekkoneksi()
        Try
            conn = New MySqlConnection(connection)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            Else
                conn.Close()

            End If
        Catch ex As Exception
            MsgBox("koneksi ke server terputus", MsgBoxStyle.Information)
            End
            Exit Sub
        End Try
    End Sub

End Module