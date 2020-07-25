Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Register1.Text And TextBox2.Text = Register2.Text Then
            MsgBox("Успешно влизане", vbOKOnly + vbInformation, "Карта на съквовища")
            TextBox1.Text = Nothing
            TextBox2.Text = Nothing
            TextBox1.Hide()
            TextBox2.Hide()
            Label1.Hide()
            Label2.Hide()
            Button1.Hide()
            Button2Done.Hide()
            CheckBox1.Hide()
            Button3.Visible = True
            Label3.Visible = True
            Me.BackgroundImage = PictureBox2.Image
        Else
            MsgBox("Грешно потребителско име или парола", vbOKOnly + vbCritical, "Карта на съквовища")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        TextBox2.PasswordChar = Nothing
        If CheckBox1.Checked = False Then
            TextBox2.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        Button2Done.Visible = True
        Button2.Hide()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Register1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register1.Click

    End Sub

    Private Sub Register2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register2.Click

    End Sub

    Private Sub Button2Done_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2Done.Click
        MsgBox("Вече имаш регистрация", vbOKOnly + vbExclamation, "Карта на съкровища")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Show()
        TextBox2.Show()
        Label1.Show()
        Label2.Show()
        Button1.Show()
        Button2Done.Show()
        CheckBox1.Show()
        Button3.Visible = False
        Label3.Visible = False
        Me.BackgroundImage = PictureBox1.Image
        CheckBox1.Checked = False
    End Sub
End Class
