Option Strict On

Public Class frmCollege
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmCollege_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMajor.SelectedIndexChanged

    End Sub

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim objStudent As Student
        Dim objOnCampusStudent As OnCampusStudent
        Dim InputError As Boolean = False

        If txtStudentID.MaskFull = False Then
            MsgBox("Enter your Student ID in the Student ID box", , "Error")
            txtStudentID.Clear()
            txtStudentID.Focus()
            InputError = True
        ElseIf txtStudentName.TextLength < 1 Or txtStudentName.Text < "A" Then
            MsgBox("Enter your name in the Student Name box", , "Error")
            txtStudentName.Clear()
            txtStudentName.Focus()
            InputError = True
        ElseIf Not IsNumeric(txtNumberOfUnits.Text) Then
            MsgBox("Enter the units in the Number of Units box", , "Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True
        ElseIf Convert.ToInt32(txtNumberOfUnits.Text) < 1 Or Convert.ToInt32(txtNumberOfUnits.Text) > 24 Then
            MsgBox("Units must be 1 - 24", , "Error")
            txtNumberOfUnits.Clear()
            txtNumberOfUnits.Focus()
            InputError = True
        ElseIf cboMajor.SelectedIndex < 0 Then
            MsgBox("Please select a Major", , "Error")
            txtStudentName.Clear()
            txtStudentName.Focus()
            InputError = True
        End If
        If Not InputError Then
            If rdbOffCampus.Checked Then
                objStudent = New Student(txtStudentID.Text, txtStudentName.Text, Convert.ToString(cboMajor.SelectedItem), txtNumberOfUnits.Text)
                lblCost.Visible = True
                lblCost.Text = "Total Semester Costs Are: " & (objStudent.ComputeCosts()).ToString("C2")
            Else
                objOnCampusStudent = New OnCampusStudent(txtStudentID.Text, txtStudentName.Text, Convert.ToString(cboMajor.SelectedItem), txtNumberOfUnits.Text, rdbCooperDorm.Checked, rdbCraigHall.Checked, rdbJulianSultes.Checked)
                lblCost.Visible = True
                lblCost.Text = "Total Semester costs are: " & (objOnCampusStudent.ComputeCosts()).ToString("C2")
            End If
        End If
    End Sub

    Private Sub rdbOffCampus_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOffCampus.CheckedChanged
        grpHousingBoard.Visible = False
    End Sub

    Private Sub rdbOnCampus_CheckedChanged(sender As Object, e As EventArgs) Handles rdbOnCampus.CheckedChanged
        grpHousingBoard.Visible = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentID.Clear()
        txtNumberOfUnits.Clear()
        txtStudentName.Clear()
        cboMajor.SelectedIndex = -1
        cboMajor.Text = " Select a Major"
        rdbOffCampus.Checked = True
        rdbCooperDorm.Checked = True
        grpCAmpus.Visible = True
        txtStudentID.Focus()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpHousingBoard.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rdbCraigHall.CheckedChanged

    End Sub

    Private Sub grpCAmpus_Enter(sender As Object, e As EventArgs) Handles grpCAmpus.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtStudentName.TextChanged

    End Sub
End Class
