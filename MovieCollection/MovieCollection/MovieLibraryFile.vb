Option Strict On
Public Class MovieLibraryFile
    Private _title As String
    Private _genre As String
    Private _year As Integer
    Private _runTime As Decimal
    Private _rating As String

    Sub New(ByVal strTitle As String, ByVal strGenre As String, ByVal intYear As Integer, ByVal decRunTime As Decimal, ByVal strRating As String)
        _title = strTitle
        _genre = strGenre
        _year = intYear
        _runTime = decRunTime
        _rating = strRating
    End Sub
    Sub WritetoLibrary()
        Dim strNameandLocationFile As String = "D:\MovieLibrary.txt"
        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationFile)

            objWriter.Write(_title & ", ")
            objWriter.Write(_genre & ", ")
            objWriter.Write(_year & ", ")
            objWriter.Write(_runTime & ", ")
            objWriter.Write(_rating & "," & vbCrLf)
            objWriter.Close()

        Catch ex As Exception
            MsgBox("No device available - program aborted", , "Error")
        End Try
    End Sub
End Class
