Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Label1.Text = "Level 1" Then
            MessageBox.Show("1/10")
        End If
        If Label1.Text = "Level 2" Then
            MessageBox.Show("2/10")
        End If
        If Label1.Text = "Level 3" Then
            MessageBox.Show("3/10")
        End If
        If Label1.Text = "Level 4" Then
            MessageBox.Show("4/10")
        End If
        If Label1.Text = "Level 5" Then
            MessageBox.Show("5/10")
        End If
        If Label1.Text = "Level 6" Then
            MessageBox.Show("6/10")
        End If
        If Label1.Text = "Level 7" Then
            MessageBox.Show("7/10")
        End If
        If Label1.Text = "Level 8" Then
            MessageBox.Show("8/10")
        End If
        If Label1.Text = "Level 9" Then 'not
            MessageBox.Show("9/10")
        End If
        If Label1.Text = "Last Level" Then 'notnot
            MessageBox.Show("10/10")
        End If
    End Sub

    Private Sub Door1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Door1.Click
        If Label1.Text = "Last Level" Then 'more
            'something
        End If
        If Label1.Text = "Level 9" Then 'more
            MessageBox.Show("More levels soon...")
            End
        End If
        If Label1.Text = "Level 8" And MiniButton1.Enabled = False Then
            MessageBox.Show("You have finished this level!")
            Label1.Text = "Level 9"
            MiniButton1.Hide()
        ElseIf MiniButton1.Enabled = True And Not MiniButton1.Location = New Point(136, 291) Then
            MessageBox.Show("No Button!")
        End If
        If Label1.Text = "Level 7" And PictureBox2.Enabled = False And TextBox2.Text = "2018" Then
            MessageBox.Show("You have finished this level!")
            TextBox2.Hide()
            MiniButton1.Visible = True
            Label1.Text = "Level 8"
        ElseIf PictureBox2.Enabled = True And PictureBox2.Visible = True Then
            MessageBox.Show("Broken!")
        ElseIf Not TextBox2.Text = "2018" And PictureBox2.Enabled = False Then
            MessageBox.Show("Invalid Numbers! (try year)")
        End If
        If Label1.Text = "Level 6" And TrackBar1.Value >= 3 And TrackBar1.Value <= 7 And TrackBar2.Value >= 5 And TrackBar2.Value <= 8 And TrackBar3.Value >= 9 Then
            MessageBox.Show("You have finished this level!")
            TrackBar1.Hide()
            TrackBar2.Hide()
            TrackBar3.Hide()
            TrackBar1.Enabled = False
            PictureBox2.Visible = True
            TextBox2.Visible = True
            Label1.Text = "Level 7"
        ElseIf TrackBar1.Value < 3 Or TrackBar1.Value > 7 Or TrackBar2.Value < 5 Or TrackBar2.Value > 8 Or TrackBar3.Value < 9 Then
            If TrackBar1.Enabled = True Then
                MessageBox.Show("Invalid Settings!")
            End If
        End If
        If Label1.Text = "Level 5" And TextBox1.Enabled = True Then
            MessageBox.Show("Error!")
        ElseIf TextBox1.Enabled = False Then
            MessageBox.Show("You have finished this level!")
            TextBox1.Hide()
            CodeNumber1.Hide()
            CodeNumber2.Hide()
            CodeNumber3.Hide()
            CodeNumber4.Hide()
            CodeNumber5.Hide()
            CodeNumber6.Hide()
            CodeNumber7.Hide()
            CodeNumber8.Hide()
            CodeNumber9.Hide()
            CodeNumber10.Hide()
            CodeNumber11.Hide()
            CodeNumber12.Hide()
            TextBox1.Enabled = True
            TextBox1.Clear()
            TrackBar1.Visible = True
            TrackBar2.Visible = True
            TrackBar3.Visible = True
            TrackBar1.Enabled = True
            Label1.Text = "Level 6"
        End If
        If Label1.Text = "Level 4" And Code1.Checked = True And Code2.Checked = False And Code3.Checked = True And Code1.Enabled = True And Code2.Enabled = True And Code3.Enabled = True Then
            MessageBox.Show("You have finished this level!")
            Code1.Checked = False
            Code1.Enabled = False
            Code1.Hide()
            Code2.Checked = False
            Code2.Enabled = False
            Code2.Hide()
            Code3.Checked = False
            Code3.Enabled = False
            Code3.Hide()
            TextBox1.Visible = True
            CodeNumber1.Visible = True
            CodeNumber2.Visible = True
            CodeNumber3.Visible = True
            CodeNumber4.Visible = True
            CodeNumber5.Visible = True
            CodeNumber6.Visible = True
            CodeNumber7.Visible = True
            CodeNumber8.Visible = True
            CodeNumber9.Visible = True
            CodeNumber10.Visible = True
            CodeNumber11.Visible = True
            CodeNumber12.Visible = True
            Label1.Text = "Level 5"
        ElseIf Code1.Checked = False Or Code2.Checked = True Or Code3.Checked = False Then
            If Code1.Enabled = True And Code2.Enabled = True And Code3.Enabled = True Then
                MessageBox.Show("Wrong Code!")
            End If
        End If
        If Label1.Text = "Level 3" And ProgressBar1.Value <= 98 Then
            MessageBox.Show("No Energy!")
        ElseIf ProgressBar1.Value > 98 Then
            MessageBox.Show("You have finished this level!")
            Label1.Text = "Level 4"
            ProgressBar1.Visible = False
            Button1.Visible = False
            ProgressBar1.Value = 0
            Code1.Visible = True
            Code2.Visible = True
            Code3.Visible = True
            Code1.Enabled = True
            Code2.Enabled = True
            Code3.Enabled = True
        End If
        If Label1.Text = "Level 2" And PictureBox1.Enabled = True Then
            MessageBox.Show("Locked!")
        ElseIf PictureBox1.Enabled = False Then
            MessageBox.Show("You have finished this level!")
            Label1.Text = "Level 3"
            Button1.Visible = True
            ProgressBar1.Visible = True
            PictureBox1.Enabled = True
        End If
        If Label1.Text = "Level 1" Then
            MessageBox.Show("You have finished this level!")
            Label1.Text = "Level 2"
            PictureBox1.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        PictureBox1.Enabled = False
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        If ProgressBar1.Value > 98 Then
            Button1.AllowDrop = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.AllowDrop = False Then
            ProgressBar1.Increment(+2)
        End If
    End Sub

    Private Sub CodeNumber1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber1.Click

    End Sub

    Private Sub CodeNumber2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber2.Click

    End Sub

    Private Sub CodeNumber3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber3.Click

    End Sub

    Private Sub CodeNumber4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber4.Click

    End Sub

    Private Sub CodeNumber5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber5.Click

    End Sub

    Private Sub CodeNumber6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber6.Click

    End Sub

    Private Sub CodeNumber7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber7.Click

    End Sub

    Private Sub CodeNumber8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber8.Click

    End Sub

    Private Sub CodeNumber9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber9.Click

    End Sub

    Private Sub CodeNumber10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber10.Click

    End Sub

    Private Sub CodeNumber11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber11.Click

    End Sub

    Private Sub CodeNumber12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodeNumber12.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "497851" Then
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub TrackBar2_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar2.Scroll

    End Sub

    Private Sub TrackBar3_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar3.Scroll

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        PictureBox2.Enabled = False
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If Not PictureBox2.Enabled = False Then
            TextBox2.Clear()
        End If
        If TextBox2.Text = "2018" Then
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub MiniButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiniButton1.Click
        '136 291
        '203 234
        '202 131
        '172 52
        '116 22
        '57 142
        '87 167
        If MiniButton1.Location = New Point(87, 167) Then
            MiniButton1.Enabled = False
        End If
        If MiniButton1.Location = New Point(57, 142) Then
            MiniButton1.Location = New Point(87, 167)
        End If
        If MiniButton1.Location = New Point(116, 22) Then
            MiniButton1.Location = New Point(57, 142)
        End If
        If MiniButton1.Location = New Point(172, 52) Then
            MiniButton1.Location = New Point(116, 22)
        End If
        If MiniButton1.Location = New Point(202, 131) Then
            MiniButton1.Location = New Point(172, 52)
        End If
        If MiniButton1.Location = New Point(203, 234) Then
            MiniButton1.Location = New Point(202, 131)
        End If
        If MiniButton1.Location = New Point(136, 291) Then
            MiniButton1.Location = New Point(203, 234)
        End If
    End Sub
End Class