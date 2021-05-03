Option Strict On
Public Class Main
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtYear_TextChanged(sender As Object, e As EventArgs) Handles txtYear.TextChanged

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged

    End Sub

    Private Sub txtRuntime_TextChanged(sender As Object, e As EventArgs) Handles txtRuntime.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim objMovie As Movie
        Dim InputError As Boolean = False

        If txtTitle.TextLength < 1 Or txtTitle.Text < "A" Then
            MsgBox("Please enter the tile ", , "Error")
            txtTitle.Clear()
            txtTitle.Focus()
            InputError = True
        ElseIf cbGenre.SelectedIndex < 0 Then
            MsgBox("Please select a Genre", , "Error")
            cbGenre.SelectedIndex = 0
            cbGenre.Focus()
            InputError = True
        ElseIf Not IsNumeric(txtYear.Text) Then
            MsgBox("Please enter the release year", , "Error")
            txtYear.Clear()
            txtYear.Focus()
            InputError = True
        ElseIf Not IsNumeric(txtRuntime.Text) Then
            MsgBox("Please enter the release year", , "Error")
            txtRuntime.Clear()
            txtRuntime.Focus()
            InputError = True
        ElseIf cbRating.SelectedIndex < 0 Then
            MsgBox("Please select a Genre", , "Error")
            cbRating.SelectedIndex = 0
            cbRating.Focus()
            InputError = True
        End If
        If Not InputError Then
            objMovie = New Movie(txtTitle.Text, Convert.ToString(cbGenre.SelectedItem), txtYear.Text, txtRuntime.Text, Convert.ToString(cbRating.SelectedItem))
            objMovie.Writefile()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbGenre.SelectedIndexChanged

    End Sub

    Private Sub cbRating_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRating.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Collection.Show()
        Me.Hide()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Application.Exit()
    End Sub
End Class
