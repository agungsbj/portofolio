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
        path = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\klinikmedika.accdb"
        cnn = New OleDbConnection(path)
        If cnn.State = ConnectionState.Closed Then
            cnn.Open()
        End If
    End Sub

    Public Enum AnimateWindowFlags
        AW_HOR_POSITIVE = &H1
        AW_HOR_NEGATIVE = &H2
        AW_VER_POSITIVE = &H4
        AW_VER_NEGATIVE = &H8
        AW_CENTER = &H10
        AW_HIDE = &H10000
        AW_ACTIVATE = &H20000
        AW_SLIDE = &H40000
        AW_BLEND = &H80000
    End Enum

    Public Declare Auto Function AnimateWindow Lib "user32" (ByVal hwnd As IntPtr, ByVal time As Integer, ByVal flags As AnimateWindowFlags) As Boolean

    Sub animasikanan(ByVal frmToAnimate As Form, ByVal showform As Boolean)
        If showform Then
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_HOR_POSITIVE Or AnimateWindowFlags.AW_SLIDE)
        End If
    End Sub
    Sub animasikiri(ByVal frmToAnimate As Form, ByVal showform As Boolean)
        If showform Then
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_HOR_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_HOR_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        End If
    End Sub
    Sub animasiatas(ByVal frmToAnimate As Form, ByVal showform As Boolean)
        If showform Then
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_VER_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_VER_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        End If
    End Sub
    Sub animasibawah(ByVal frmToAnimate As Form, ByVal showform As Boolean)
        If showform Then
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_VER_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        Else
            AnimateWindow(frmToAnimate.Handle, 400, AnimateWindowFlags.AW_VER_NEGATIVE Or AnimateWindowFlags.AW_SLIDE)
        End If
    End Sub
End Module
