Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public rd As OleDbDataReader


    Public lokasiDB, sql As String

    Public Sub koneksi()
        lokasiDB = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Randy-Kun\Desktop\RandOS\osdatabase.mdb"
        conn = New OleDbConnection(lokasiDB)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
