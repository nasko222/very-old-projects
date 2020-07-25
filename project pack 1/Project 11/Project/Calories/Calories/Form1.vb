Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If TextBox1.Text = "0" Then
                e.Handled = True
            Else
                If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                    e.Handled = True
                End If
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "Футбол" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 6.183
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез футбол вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез футбол вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
        If ComboBox1.SelectedItem = "Баскетбол" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 7.466
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез баскетбол вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез баскетбол вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
        If ComboBox1.SelectedItem = "Тенис" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 9.986
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез тенис вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез тенис вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
        If ComboBox1.SelectedItem = "Лека атлетика" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 5.783
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез лека атлетика вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез лека атлетика вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
        If ComboBox1.SelectedItem = "Волейбол" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 6.533
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез волейбол вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез волейбол вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
        If ComboBox1.SelectedItem = "Фитнес" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 7.467
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез фитнес вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез фитнес вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
        If ComboBox1.SelectedItem = "Плуване" Then
            Dim cal As Integer
            If IsNumeric(TextBox1.Text) Then
                cal = TextBox1.Text
            End If
            cal = cal * 7.916
            Member1.Text = cal
            If TextBox1.Text = Nothing Or TextBox1.Text = 0 Then
                MessageBox.Show("Моля въведете време")
            ElseIf TextBox1.Text = 1 Then
                MessageBox.Show("Чрез плуване вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минута")
            Else
                MessageBox.Show("Чрез плуване вие ще изгорите " + Member1.Text + " калории за " + TextBox1.Text + " минути")
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ComboBox1.Text = Nothing
        TextBox1.Text = Nothing
    End Sub
End Class
