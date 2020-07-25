Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

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
        TextBox1.Text = FormatCurrency(Pizza)
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
End Class
