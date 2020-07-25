Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Location = New Point(12, 174) Then 'Final
            Button1.Enabled = False
            Button2.Visible = True
            Button2.Location = New Point(12, 12)
        End If
        If Button1.Location = New Point(12, 120) Then '#3
            Button1.Location = New Point(12, 174)
        End If
        If Button1.Location = New Point(12, 66) Then '#2
            Button1.Location = New Point(12, 120)
        End If
        If Button1.Location = New Point(12, 12) Then '#1
            Button1.Location = New Point(12, 66)
        End If
        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Button2.Location = New Point(12, 120) And Not Button1.Location = New Point(12, 174) Then '#3
            Button2.Enabled = False
            Button2.Location = New Point(12, 174)
            Button3.Location = New Point(12, 12)
            Button3.Visible = True
        ElseIf Button2.Location = New Point(12, 120) Then
            Button2.Enabled = False
            Button3.Location = New Point(12, 12)
            Button3.Visible = True
        End If
        If Button2.Location = New Point(12, 66) Then '#2
            Button2.Location = New Point(12, 120)
        End If
        If Button2.Location = New Point(12, 12) Then '#1
            Button2.Location = New Point(12, 66)
        End If
        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Button3.Location = New Point(12, 66) And Button2.Location = New Point(12, 120) Then 'Final
            Button3.Enabled = False
            Button4.Location = New Point(12, 12)
            Button4.Visible = True
        ElseIf Not Button2.Location = New Point(12, 120) Then
            Button3.Enabled = False
            Button3.Location = New Point(12, 120) '#2 Boolean
            Button4.Location = New Point(12, 12)
            Button4.Visible = True
        End If
        If Button3.Location = New Point(12, 12) Then '#1
            Button3.Location = New Point(12, 66)
        End If
        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Timer1.Start()
        Timer2.Stop()
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button1.Location = New Point(12, 12)
        Button2.Location = Panel1.Location
        Button3.Location = Panel1.Location
        Button4.Location = Panel1.Location
        Timer1.Stop()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Timer2.Stop()
        MessageBox.Show("Game Over")
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button1.Location = New Point(12, 12)
        Button2.Location = Panel1.Location
        Button3.Location = Panel1.Location
        Button4.Location = Panel1.Location
        Button1.Enabled = False
        Button5.Enabled = True
        Button5.Text = "Start"
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RadioButton3.Enabled = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Timer2.Interval = 2000
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Timer2.Interval = 1000
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Timer2.Interval = 500
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Timer2.Start()
        Button1.Enabled = True
        Button5.Enabled = False
        Button5.Text = "Started..."
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RadioButton3.Enabled = False
    End Sub
End Class