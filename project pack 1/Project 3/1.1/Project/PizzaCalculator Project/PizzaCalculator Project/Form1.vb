Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Hide()
        Label3.Hide()
        TextBox1.Hide()
        TextBox2.Hide()
        Button2.Hide()
        MaximizeBox = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Display1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display1.TextChanged

    End Sub

    Private Sub PizzaCalculation()
        Dim Pizza As String = 4
        If RadioButton1.Checked = True Then
            Pizza = Pizza
        End If
        If RadioButton2.Checked = True Then
            Pizza = Pizza * 1.5
        End If
        If RadioButton3.Checked = True Then
            Pizza = Pizza * 2
        End If
        If CheckBox1.Checked = True Then
            Pizza = Pizza + 1.2
        End If
        If CheckBox2.Checked = True Then
            Pizza = Pizza + 0.4
        End If
        If CheckBox3.Checked = True Then
            Pizza = Pizza + 0.8
        End If
        If CheckBox4.Checked = True Then
            Pizza = Pizza + 0.6
        End If
        If CheckBox5.Checked = True Then
            Pizza = Pizza + 0.2
        End If
        If CheckBox6.Checked = True Then
            Pizza = Pizza + 0.5
        End If
        If CheckBox7.Checked = True Then
            Pizza = Pizza + 1
        End If
        If CheckBox8.Checked = True Then
            Pizza = Pizza + 0.7
        End If
        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True And CheckBox5.Checked = True And CheckBox6.Checked = True And CheckBox7.Checked = True And CheckBox8.Checked = True Then
            Pizza = Pizza - 0.9
        End If
        Display1.Text = FormatCurrency(Pizza)
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        Call PizzaCalculation()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False And CheckBox4.Checked = False And CheckBox5.Checked = False And CheckBox6.Checked = False And CheckBox7.Checked = False And CheckBox8.Checked = False Then
            MessageBox.Show("Моля изберете нещо за пицата!")
        Else
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            RadioButton1.Enabled = False
            RadioButton2.Enabled = False
            RadioButton3.Enabled = False
            Label2.Show()
            Label3.Show()
            TextBox1.Show()
            TextBox2.Show()
            Button1.Hide()
            Button2.Show()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MessageBox.Show("Има празни полета!")
        Else
            CheckBox1.Hide()
            CheckBox2.Hide()
            CheckBox3.Hide()
            CheckBox4.Hide()
            CheckBox5.Hide()
            CheckBox6.Hide()
            CheckBox7.Hide()
            CheckBox8.Hide()
            RadioButton1.Hide()
            RadioButton2.Hide()
            RadioButton3.Hide()
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Button2.Hide()
            TextBox1.Hide()
            TextBox2.Hide()
            MsgBox("Поръчана пица в град " + TextBox1.Text + " на улица " + TextBox2.Text, vbInformation, "PIZZA")
            End
        End If
    End Sub
End Class