Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Or TextBox7.Text = Nothing Or TextBox8.Text = Nothing Then
        Else
            ReadOnlyTextBox1.Text = "http://" + TextBox1.Text + TextBox2.Text + TextBox3.Text + TextBox4.Text + TextBox5.Text + TextBox6.Text + TextBox7.Text + TextBox8.Text + ".ann"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox9.Text = Nothing Then
        Else
            ReadOnlyTextBox2.Text = "decrypt 1 " + TextBox9.Text
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox10.Text = Nothing Then
        Else
            ReadOnlyTextBox3.Text = "decrypt 2 " + TextBox10.Text
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox11.Text = Nothing Then
        Else
            ReadOnlyTextBox4.Text = "decrypt 3 " + TextBox11.Text
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If TextBox12.Text = Nothing Then
        Else
            ReadOnlyTextBox5.Text = "decrypt 4 " + TextBox12.Text
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox13.Text = Nothing Then
        Else
            ReadOnlyTextBox6.Text = "decrypt 5 " + TextBox13.Text
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If TextBox14.Text = Nothing Then
        Else
            ReadOnlyTextBox7.Text = "decrypt 6 " + TextBox14.Text
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If TextBox15.Text = Nothing Or TextBox16.Text = Nothing Or TextBox17.Text = Nothing Or TextBox18.Text = Nothing Or TextBox19.Text = Nothing Or TextBox20.Text = Nothing Then
        Else
            ReadOnlyTextBox8.Text = "gatekeeper " + TextBox15.Text + TextBox16.Text + TextBox17.Text + TextBox18.Text + TextBox19.Text + TextBox20.Text
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If TextBox21.Text = Nothing Or TextBox22.Text = Nothing Or TextBox23.Text = Nothing Or TextBox24.Text = Nothing Or TextBox25.Text = Nothing Or TextBox26.Text = Nothing Or TextBox27.Text = Nothing Or TextBox28.Text = Nothing Then
        Else
            ReadOnlyTextBox9.Text = TextBox21.Text + TextBox22.Text + TextBox23.Text + TextBox24.Text + TextBox25.Text + TextBox26.Text + TextBox27.Text + TextBox28.Text
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReadOnlyTextBox1.Copy()
    End Sub
End Class
