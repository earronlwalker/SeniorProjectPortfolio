Public Class Collection
    Private Sub Collection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim isName As Boolean

        Using sr As New IO.StreamReader("D:\MovieLibrary.txt")
            Do Until sr.EndOfStream
                isName = Not isName
                Dim line As String = sr.ReadLine()
                ListBox1.Items.Add(line)
            Loop
        End Using
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Main.Show()
        Me.Close()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
End Class