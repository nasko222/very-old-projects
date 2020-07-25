Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Euro" And ListBox2.SelectedItem = "Euro" Then
            TextBox2.Text = FormatNumber(TextBox1.Text)
            TextBox2.Text = "€" + TextBox2.Text
            Label1.Text = "€"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Euro" And ListBox2.SelectedItem = "Dollar" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 1.23)
            TextBox2.Text = "$" + TextBox2.Text
            Label1.Text = "€"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Euro" And ListBox2.SelectedItem = "Rubles" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 70.84)
            TextBox2.Text = TextBox2.Text + " руб"
            Label1.Text = "€"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Euro" And ListBox2.SelectedItem = "Leva" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 1.95)
            TextBox2.Text = TextBox2.Text + " лв"
            Label1.Text = "€"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Dollar" And ListBox2.SelectedItem = "Euro" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 0.81)
            TextBox2.Text = "€" + TextBox2.Text
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Dollar" And ListBox2.SelectedItem = "Dollar" Then
            TextBox2.Text = FormatNumber(TextBox1.Text)
            TextBox2.Text = "$" + TextBox2.Text
            Label1.Text = "$"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Dollar" And ListBox2.SelectedItem = "Rubles" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 57.504)
            TextBox2.Text = TextBox2.Text + " руб"
            Label1.Text = "$"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Dollar" And ListBox2.SelectedItem = "Leva" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 1.58)
            TextBox2.Text = TextBox2.Text + " лв"
            Label1.Text = "$"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Rubles" And ListBox2.SelectedItem = "Euro" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 0.014)
            TextBox2.Text = "€" + TextBox2.Text
            Label1.Text = "руб"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Rubles" And ListBox2.SelectedItem = "Dollar" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 0.017)
            TextBox2.Text = "$" + TextBox2.Text
            Label1.Text = "руб"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Rubles" And ListBox2.SelectedItem = "Rubles" Then
            TextBox2.Text = FormatNumber(TextBox1.Text)
            TextBox2.Text = TextBox2.Text + " руб"
            Label1.Text = "руб"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Rubles" And ListBox2.SelectedItem = "Leva" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 0.027)
            TextBox2.Text = TextBox2.Text + " лв"
            Label1.Text = "руб"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Leva" And ListBox2.SelectedItem = "Euro" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 0.511)
            TextBox2.Text = "€" + TextBox2.Text
            Label1.Text = "лв"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Leva" And ListBox2.SelectedItem = "Dollar" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 0.63)
            TextBox2.Text = "$" + TextBox2.Text
            Label1.Text = "лв"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Leva" And ListBox2.SelectedItem = "Rubles" Then
            TextBox2.Text = FormatNumber(TextBox1.Text * 36.236)
            TextBox2.Text = TextBox2.Text + " руб"
            Label1.Text = "лв"
        End If
        If Not TextBox1.Text = Nothing And ListBox1.SelectedItem = "Leva" And ListBox2.SelectedItem = "Leva" Then
            TextBox2.Text = FormatNumber(TextBox1.Text)
            TextBox2.Text = TextBox2.Text + " лв"
            Label1.Text = "лв"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers
        '8 = Backspace
        '46, 47 = ,./

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 44 Or Asc(e.KeyChar) > 57 Or Asc(e.KeyChar) = 47 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
