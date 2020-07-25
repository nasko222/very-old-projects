Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
        ComboBox1.SelectedItem = "Единична Стая"
        DateTimePicker1.Value = Date.Today
        DateTimePicker2.Value = Date.Today
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not ComboBox1.SelectedItem = "Единична Стая" And Not ComboBox1.SelectedItem = "Двойна Стая" And Not ComboBox1.SelectedItem = "Спалня" And Not ComboBox1.SelectedItem = "Апартамент" Then
            MessageBox.Show("Моля изберете вид стая!")
        ElseIf TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Then
            MessageBox.Show("Има празни полета!")
        ElseIf DateTimePicker1.Value = DateTimePicker2.Value Or DateTimePicker1.Value > DateTimePicker2.Value Or DateTimePicker1.Value < Date.Today Or DateTimePicker2.Value < DateAndTime.Today Then
            MessageBox.Show("Моля изберете валидна дата")
        Else
            Call Calculation()
            Display1.Text = FormatCurrency(Price)
            Display1.Enabled = True
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            DateTimePicker1.Enabled = False
            DateTimePicker2.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            ComboBox1.Enabled = False
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Calculation()
        Price = 0.0
        If ComboBox1.SelectedItem = "Единична Стая" Then
            Price = 35.0
        End If
        If ComboBox1.SelectedItem = "Двойна Стая" Then
            Price = 45.0
        End If
        If ComboBox1.SelectedItem = "Спалня" Then
            Price = 40.5
        End If
        If ComboBox1.SelectedItem = "Апартамент" Then
            Price = 55.9
        End If
        If CheckBox1.Checked = True Then
            Price = Price + 20.3
        End If
        If CheckBox2.Checked = True Then
            Price = Price + 3.8
        End If
        If CheckBox3.Checked = True Then
            Price = Price + 9.7
        End If
    End Sub

    Private Sub Display1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display1.Click
        MessageBox.Show("Направена резервация на името на " + TextBox1.Text + " " + TextBox2.Text + " за дата " + DateTimePicker1.Value + " до " + DateTimePicker2.Value)
        MessageBox.Show("Вашият телефонен номер : " + TextBox4.Text)
        MessageBox.Show("Вашият адрес : " + TextBox3.Text)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        End
    End Sub
End Class
Module Module1
    Public Price As Integer
End Module