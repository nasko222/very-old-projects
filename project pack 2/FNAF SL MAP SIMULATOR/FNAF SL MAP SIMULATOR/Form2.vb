Public Class Form2

    Private Sub Form2_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Space
                If Timer2.Enabled = False Then
                    PictureBox1.Visible = True
                    PictureBox1.Top = PictureBox1.Top - 10
                    PictureBox1.Left = PictureBox1.Left - 5
                    PictureBox1.Width = PictureBox1.Width + 10
                    PictureBox1.Height = PictureBox1.Height + 10
                    Timer1.Start()
                    My.Computer.Audio.Play(My.Resources.Flash_Beacon, AudioPlayMode.Background)
                    Timer2.Start()
                    Timer2.Enabled = True
                End If
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub
End Class