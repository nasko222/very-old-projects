Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
        Label1.Text = "Напитка"
        TextBox1.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Напитка"
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox1.BackColor = Color.Empty
        TextBox2.BackColor = Color.Empty
        TextBox3.BackColor = Color.Empty
        TextBox4.BackColor = Color.Empty
        TextBox5.BackColor = Color.Empty
        TextBox6.BackColor = Color.Empty
        TextBox7.BackColor = Color.Empty
        TextBox8.BackColor = Color.Empty
        TextBox9.BackColor = Color.Empty
        TextBox10.BackColor = Color.Empty
        TextBox11.BackColor = Color.Empty
        TextBox12.BackColor = Color.Empty
        TextBox1.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Домашен любимец"
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = True
        TextBox6.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = False
        TextBox11.Enabled = False
        TextBox12.Enabled = False
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox1.BackColor = Color.Empty
        TextBox2.BackColor = Color.Empty
        TextBox3.BackColor = Color.Empty
        TextBox4.BackColor = Color.Empty
        TextBox5.BackColor = Color.Empty
        TextBox6.BackColor = Color.Empty
        TextBox7.BackColor = Color.Empty
        TextBox8.BackColor = Color.Empty
        TextBox9.BackColor = Color.Empty
        TextBox10.BackColor = Color.Empty
        TextBox11.BackColor = Color.Empty
        TextBox12.BackColor = Color.Empty
        TextBox5.Focus()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Label1.Text = "Сетиво"
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        TextBox12.Enabled = True
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox1.BackColor = Color.Empty
        TextBox2.BackColor = Color.Empty
        TextBox3.BackColor = Color.Empty
        TextBox4.BackColor = Color.Empty
        TextBox5.BackColor = Color.Empty
        TextBox6.BackColor = Color.Empty
        TextBox7.BackColor = Color.Empty
        TextBox8.BackColor = Color.Empty
        TextBox9.BackColor = Color.Empty
        TextBox10.BackColor = Color.Empty
        TextBox11.BackColor = Color.Empty
        TextBox12.BackColor = Color.Empty
        TextBox10.Focus()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Label1.Text = "Вид музика"
        TextBox1.Enabled = False
        TextBox2.Enabled = True
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = True
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox11.Enabled = True
        TextBox12.Enabled = False
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
        TextBox10.Text = Nothing
        TextBox11.Text = Nothing
        TextBox12.Text = Nothing
        TextBox1.BackColor = Color.Empty
        TextBox2.BackColor = Color.Empty
        TextBox3.BackColor = Color.Empty
        TextBox4.BackColor = Color.Empty
        TextBox5.BackColor = Color.Empty
        TextBox6.BackColor = Color.Empty
        TextBox7.BackColor = Color.Empty
        TextBox8.BackColor = Color.Empty
        TextBox9.BackColor = Color.Empty
        TextBox10.BackColor = Color.Empty
        TextBox11.BackColor = Color.Empty
        TextBox12.BackColor = Color.Empty
        TextBox2.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox2.Focus()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If RadioButton1.Checked = True Then
            TextBox3.Focus()
        ElseIf RadioButton4.Checked = True Then
            TextBox6.Focus()
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        TextBox4.Focus()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Button1.Focus()
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        TextBox6.Focus()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        If RadioButton2.Checked = True Then
            TextBox7.Focus()
        ElseIf RadioButton4.Checked = True Then
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        TextBox8.Focus()
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        TextBox9.Focus()
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Button1.Focus()
    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged
        TextBox11.Focus()
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        If RadioButton3.Checked = True Then
            TextBox12.Focus()
        ElseIf RadioButton4.Checked = True Then
            Button1.Focus()
        End If
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Button1.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            If TextBox1.Text = "К" And TextBox2.Text = "о" And TextBox3.Text = "л" And TextBox4.Text = "а" Then
                TextBox1.BackColor = Color.Green
                TextBox2.BackColor = Color.Green
                TextBox3.BackColor = Color.Green
                TextBox4.BackColor = Color.Green
            Else
                TextBox1.BackColor = Color.Red
                TextBox2.BackColor = Color.Red
                TextBox3.BackColor = Color.Red
                TextBox4.BackColor = Color.Red
                TextBox1.Text = "К"
                TextBox2.Text = "о"
                TextBox3.Text = "л"
                TextBox4.Text = "а"
            End If
        End If
        If RadioButton2.Checked = True Then
            If TextBox5.Text = "К" And TextBox6.Text = "о" And TextBox7.Text = "т" And TextBox8.Text = "к" And TextBox9.Text = "а" Then
                TextBox5.BackColor = Color.Green
                TextBox6.BackColor = Color.Green
                TextBox7.BackColor = Color.Green
                TextBox8.BackColor = Color.Green
                TextBox9.BackColor = Color.Green
            Else
                TextBox5.BackColor = Color.Red
                TextBox6.BackColor = Color.Red
                TextBox7.BackColor = Color.Red
                TextBox8.BackColor = Color.Red
                TextBox9.BackColor = Color.Red
                TextBox5.Text = "К"
                TextBox6.Text = "о"
                TextBox7.Text = "т"
                TextBox8.Text = "к"
                TextBox9.Text = "а"
            End If
        End If
        If RadioButton3.Checked = True Then
            If TextBox10.Text = "Н" And TextBox11.Text = "о" And TextBox12.Text = "с" Then
                TextBox10.BackColor = Color.Green
                TextBox11.BackColor = Color.Green
                TextBox12.BackColor = Color.Green
            Else
                TextBox10.BackColor = Color.Red
                TextBox11.BackColor = Color.Red
                TextBox12.BackColor = Color.Red
                TextBox10.Text = "Н"
                TextBox11.Text = "о"
                TextBox12.Text = "с"
            End If
        End If
        If RadioButton4.Checked = True Then
            If TextBox2.Text = "Р" And TextBox6.Text = "а" And TextBox11.Text = "п" Then
                TextBox2.BackColor = Color.Green
                TextBox6.BackColor = Color.Green
                TextBox11.BackColor = Color.Green
            Else
                TextBox2.BackColor = Color.Red
                TextBox6.BackColor = Color.Red
                TextBox11.BackColor = Color.Red
                TextBox2.Text = "Р"
                TextBox6.Text = "а"
                TextBox11.Text = "п"
            End If
        End If
    End Sub

    Private Sub BackEvent1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub BackEvent2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If RadioButton1.Checked = True Then
                TextBox1.Focus()
            ElseIf RadioButton4.Checked = True Then
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub BackEvent3(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub BackEvent4(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub BackEvent5(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub BackEvent6(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If RadioButton1.Checked = True Then
                TextBox5.Focus()
            ElseIf RadioButton4.Checked = True Then
                TextBox2.Focus()
            End If
        End If
    End Sub

    Private Sub BackEvent7(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox6.Focus()
        End If
    End Sub

    Private Sub BackEvent8(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox7.Focus()
        End If
    End Sub

    Private Sub BackEvent9(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox8.Focus()
        End If
    End Sub

    Private Sub BackEvent10(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox9.Focus()
        End If
    End Sub

    Private Sub BackEvent11(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If RadioButton1.Checked = True Then
                TextBox10.Focus()
            ElseIf RadioButton4.Checked = True Then
                TextBox6.Focus()
            End If
        End If
    End Sub

    Private Sub BackEvent12(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox12.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            TextBox11.Focus()
        End If
    End Sub
End Class