Public Class Form3

    Private Sub Form3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Leave

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CheckBox1.Checked = True Then
            MsgBox("CheckBox 1 is Checked", 0 + vbInformation, "Check Mode")
        End If
        If CheckBox2.Checked = True Then
            MsgBox("CheckBox 2 is Checked", 0 + vbInformation, "Check Mode")
        End If
        If CheckBox3.Checked = True Then
            MsgBox("CheckBox 3 is Checked", 0 + vbInformation, "Check Mode")
        End If
        If CheckBox4.Checked = True Then
            MsgBox("CheckBox 4 is Checked", 0 + vbInformation, "Check Mode")
        End If
        If CheckBox1.Checked = True Then
            If CheckBox2.Checked = True Then
                If CheckBox3.Checked = True Then
                    If CheckBox4.Checked = True Then
                        MsgBox("Everything is CHECKED")
                    End If
                End If
            End If
        End If
    End Sub
End Class