Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 10 Then
            Dim year As String
            Dim month As Integer
            Dim data As Integer
            year = TextBox1.Text.Substring(0, 2)
            month = TextBox1.Text.Substring(2, 2)
            data = TextBox1.Text.Substring(4, 2)
            If month > 12 Then
                month = month - 40
            End If
            Dim now
            now = Date.Today.Year
            now = now - 2000
            If year > now Then
                year = year + 1900
            Else
                year = year + 2000
            End If
            DateLabel.Text = Format(data)
            MonthLabel.Text = Format(month)
            YearLabel.Text = Format(year)
        End If
    End Sub
End Class
