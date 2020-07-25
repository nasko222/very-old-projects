Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        MsgBox("Hey! ti me klikna az obicham tova :D", vbOKOnly + vbQuestion, "I am happy")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        MsgBox("Hello World!!!", vbOKOnly + vbInformation, "I am ok")
        MsgBox("Hello World!!!", vbOKOnly + vbInformation, "I am ok")
        MsgBox("Hello World!!!", vbOKOnly + vbInformation, "I am ok")
        MsgBox("Hello World!!!", vbOKCancel + vbInformation, "I am ok")
        MsgBox("Hello World!!!", vbOKCancel + vbInformation, "I am ok")
        MsgBox("Hello World!!!", vbAbortRetryIgnore + vbCritical, "I am ok")
        MsgBox("Just Kidding :) It's OK", vbOKOnly + vbInformation, "I am ok")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        MsgBox("ne cukai varhu men we :@", vbOKOnly + 16, "I am sad")
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            PictureBox1.Visible = True
            Label1.Visible = True
        End If
        If Not RadioButton2.Checked = True Then
            PictureBox1.Visible = False
            Label1.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            PictureBox2.Visible = True
            Label2.Visible = True
        End If
        If Not RadioButton3.Checked = True Then
            PictureBox2.Visible = False
            Label2.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            PictureBox3.Visible = True
            Label3.Visible = True
        End If
        If Not RadioButton4.Checked = True Then
            PictureBox3.Visible = False
            Label3.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Good Bye :)")
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MsgBox("Version 1.0.9 RELEASED", 0 + vbInformation, "About Info")
        MsgBox("Created by nasko222", 0 + vbInformation, "About Info")
        MsgBox("gospojo ako ne mi pishete 6 she vi se razvali kompa", vbAbortRetryIgnore + 16, "GRE6KA 404")
    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ProgressBar1.Value = 69
    End Sub
End Class
