Option Strict On
Public Class StudentCostsFile
    Private _strStudentID As String
    Private _strStudentNAme As String
    Private _strMajor As String
    Private _decStudentCosts As Decimal

    Sub New(ByVal StudentID As String, ByVal StudentName As String, ByVal Major As String, ByVal Costs As Decimal)

        _strStudentID = StudentID
        _strStudentNAme = StudentName
        _strMajor = Major
        _decStudentCosts = Costs

    End Sub

    Sub WriteRecord()
        Dim strNameandLocationFile As String = "D:\StudentCosts.txt"
        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationFile)

            objWriter.Write(_strStudentID & ",")
            objWriter.Write(_strStudentNAme & ",")
            objWriter.Write(_strMajor & ",")
            objWriter.Write(_decStudentCosts & ",")
            objWriter.Close()

        Catch ex As Exception
            MsgBox("No device available - program aborted", , "Error")
        End Try
    End Sub
End Class
