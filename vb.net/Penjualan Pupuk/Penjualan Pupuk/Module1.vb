Imports System.Data.Odbc
Imports System.Data
Imports System.Data.OleDb
Module Module1
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public cnn As OleDbConnection
    Public ds As DataSet
    Public dt As DataTable
    Public path As String

    Public Sub koneksi()
        path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\db.accdb"
        cnn = New OleDbConnection(path)
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
    End Sub
End Module
