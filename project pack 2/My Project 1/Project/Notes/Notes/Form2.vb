Public Class Form2

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox1.Text = "Enter Location Here" Then
            MsgBox("Select Location", 0 + 16, "Error")
        Else
            Form1.Label1.Text = Me.TextBox1.Text
            Form1.Label1.Visible = True
            My.Computer.FileSystem.WriteAllText(Form1.Label1.Text + "\Notes.txt", Form1.TextBox1.Text, True)
            End
        End If
    End Sub
End Class