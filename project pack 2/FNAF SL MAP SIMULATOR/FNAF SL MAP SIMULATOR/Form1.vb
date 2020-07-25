Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.A
                Me.Me1.Left -= 0.8
                Call MotionCheck()
            Case Keys.W
                Me.Me1.Top -= 0.8
                Call MotionCheck()
            Case Keys.D
                Me.Me1.Left += 0.8
                Call MotionCheck()
            Case Keys.S
                Me.Me1.Top += 0.8
                Call MotionCheck()
        End Select
    End Sub

    Sub MotionCheck()
        If Me1.Bounds.IntersectsWith(Motion1.Bounds) And CoolDown1.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Entryway, AudioPlayMode.Background)
            CoolDown1.Start()
            CoolDown1.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion1_Dub.Bounds) And CoolDown1.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Entryway, AudioPlayMode.Background)
            CoolDown1.Start()
            CoolDown1.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion2.Bounds) And CoolDown2.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Ballora, AudioPlayMode.Background)
            CoolDown2.Start()
            CoolDown2.Enabled = True
            Me.Hide()
            Form2.Show()
            Form2.PictureBox1.Image = My.Resources._205
        End If
        If Me1.Bounds.IntersectsWith(Motion3.Bounds) And CoolDown3.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Funtime, AudioPlayMode.Background)
            CoolDown3.Start()
            CoolDown3.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion4.Bounds) And CoolDown4.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Breaker, AudioPlayMode.Background)
            CoolDown4.Start()
            CoolDown4.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion5.Bounds) And CoolDown5.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Parts, AudioPlayMode.Background)
            CoolDown5.Start()
            CoolDown5.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion6.Bounds) And CoolDown6.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Circus, AudioPlayMode.Background)
            CoolDown6.Start()
            CoolDown6.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion6_Dub.Bounds) And CoolDown6.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Circus, AudioPlayMode.Background)
            CoolDown1.Start()
            CoolDown1.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(Motion7.Bounds) And CoolDown7.Enabled = False Then
            My.Computer.Audio.Play(My.Resources.Control, AudioPlayMode.Background)
            CoolDown7.Start()
            CoolDown7.Enabled = True
        End If
        If Me1.Bounds.IntersectsWith(notallow1.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow2.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow3.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow4.Bounds) Then '
            Me1.Location = Me2.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow5.Bounds) Then '
            Me1.Location = Me2.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow6.Bounds) Then '
            Me1.Location = Me2.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow7.Bounds) Then '
            Me1.Location = Me2.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow8.Bounds) Then '
            Me1.Location = Me2.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow9.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow10.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow11.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
        If Me1.Bounds.IntersectsWith(notallow12.Bounds) Then
            Me1.Location = Me3.Location
            Me1.BringToFront()
            My.Computer.Audio.Play(My.Resources.Glass, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Focus()
        notallow1.Visible = False
        notallow2.Visible = False
        notallow3.Visible = False
        notallow4.Visible = False
        notallow5.Visible = False
        notallow6.Visible = False
        notallow7.Visible = False
        notallow8.Visible = False
        notallow9.Visible = False
        notallow10.Visible = False
        notallow11.Visible = False
        notallow12.Visible = False
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub CoolDown1_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown1.Tick
        CoolDown1.Enabled = False
    End Sub

    Private Sub CoolDown2_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown2.Tick
        CoolDown2.Enabled = False
    End Sub

    Private Sub CoolDown3_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown3.Tick
        CoolDown3.Enabled = False
    End Sub

    Private Sub CoolDown4_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown4.Tick
        CoolDown4.Enabled = False
    End Sub

    Private Sub CoolDown5_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown5.Tick
        CoolDown5.Enabled = False
    End Sub

    Private Sub CoolDown6_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown6.Tick
        CoolDown6.Enabled = False
    End Sub

    Private Sub CoolDown7_Tick(sender As System.Object, e As System.EventArgs) Handles CoolDown7.Tick
        CoolDown7.Enabled = False
    End Sub
End Class