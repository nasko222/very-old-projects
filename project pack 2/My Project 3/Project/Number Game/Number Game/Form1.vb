Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 13 And Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) <> 46 And Not IsNumeric(e.KeyChar) Then
            e.Handled = True
            Beep()
        End If
        TextBox1.MaxLength = 3
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim random As New Random
        If MemoryCell1.DataMember = Nothing Then
            MemoryCell1.DataMember = random.Next(999)
            Button1.Visible = False
            Button2.Visible = True
            Label1.Text = Nothing
            If MemoryCell1.DataMember = "0" Then
                random.Next(999)
            End If
        End If
        TextBox1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim number As Integer
        If Not TextBox1.Text = Nothing Then
            number = TextBox1.Text
        Else
            MessageBox.Show("Enter Number!")
        End If
        If number < MemoryCell1.DataMember Then
            If TextBox1.Text = Nothing Then
                Label1.Text = Nothing
            Else
                Label1.Text = "Higher"
            End If
        End If
        If number > MemoryCell1.DataMember Then
            If TextBox1.Text = Nothing Then
                Label1.Text = Nothing
            Else
                Label1.Text = "Lower"
            End If
        End If
        If number = MemoryCell1.DataMember Then
            MessageBox.Show("Good Game :)")
            Label1.Text = "Higher <-> Lower"
            MemoryCell1.DataMember = Nothing
            TextBox1.Text = Nothing
            TextBox1.Enabled = False
            Button1.Visible = True
            Button2.Visible = False
        End If
    End Sub
End Class