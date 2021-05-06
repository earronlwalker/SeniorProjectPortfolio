Option Strict On
Public Class Student
    Protected _strStudentID As String
    Protected _strStudentName As String
    Protected _strMajor As String
    Protected _intUnits As Integer
    Protected _decCost As Decimal
    Protected _decCostPerUnit As Decimal = 450D

    Dim objStudentCostsFile As StudentCostsFile

    Sub New(ByVal strStudentID As String, ByVal strStudentName As String, ByVal strMajor As String, ByVal intUnits As String)
        _strStudentID = strStudentID
        _strStudentName = strStudentName
        _strMajor = strMajor
        _intUnits = Convert.ToInt32(intUnits)
    End Sub

    Overridable Function ComputeCosts() As Decimal
        _decCost = _intUnits * _decCostPerUnit

        objStudentCostsFile = New StudentCostsFile(_strStudentID, _strStudentName, _strMajor, _decCost)
        objStudentCostsFile.WriteRecord()

        Return _decCost
    End Function
End Class
