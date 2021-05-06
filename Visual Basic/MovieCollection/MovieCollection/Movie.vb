
Public Class Movie
    Protected _title As String
    Protected _genre As String
    Protected _year As Integer
    Protected _runTime As Decimal
    Protected _rating As String

    Dim objMovieLibraryFile As MovieLibraryFile

    Sub New(ByVal title As String, ByVal genre As String, ByVal year As String, ByVal runTime As String, ByVal rating As String)
        _title = title
        _genre = genre
        _year = Convert.ToInt32(year)
        _runTime = Convert.ToDecimal(runTime)
        _rating = rating
    End Sub
    Sub Writefile()
        objMovieLibraryFile = New MovieLibraryFile(_title, _genre, _year, _runTime, _rating)
        objMovieLibraryFile.WritetoLibrary()
    End Sub

End Class
