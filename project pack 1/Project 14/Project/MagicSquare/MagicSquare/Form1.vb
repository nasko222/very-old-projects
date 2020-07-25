Public Class Form1
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox5.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 49 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.Text = Nothing Or TextBox4.Text = Nothing Or TextBox5.Text = Nothing Or TextBox6.Text = Nothing Or TextBox7.Text = Nothing Then
            MsgBox("Има празни полета", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox2.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox3.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox4.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox5.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox6.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox7.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox1.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox3.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox4.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox5.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox6.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox7.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox2.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox3.Text = TextBox4.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox3.Text = TextBox5.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox3.Text = TextBox6.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox3.Text = TextBox7.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox3.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox3.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox4.Text = TextBox5.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox4.Text = TextBox6.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox4.Text = TextBox7.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox4.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox4.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox5.Text = TextBox6.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox5.Text = TextBox7.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox5.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox5.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox6.Text = TextBox7.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox6.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox6.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox7.Text = TextBox8.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox7.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        ElseIf TextBox8.Text = TextBox9.Text Then
            MsgBox("Неможе да са еднакви числата", 0 + 16, "Error")
        Else
            '1 = 1,2,3
            '2 = 4,5,6
            '3 = 7,8,9
            '4 = 1,4,7
            '5 = 2,5,8
            '6 = 3,6,9
            '7 = 1,5,9
            '8 = 3,5,7
            Dim number1 As Integer
            number1 = TextBox1.Text * 1 + TextBox2.Text * 1 + TextBox3.Text * 1
            number1 = number1 * 1
            Dim number2 As Integer
            number2 = TextBox4.Text * 1 + TextBox5.Text * 1 + TextBox6.Text * 1
            number2 = number2 * 1
            Dim number3 As Integer
            number3 = TextBox7.Text * 1 + TextBox8.Text * 1 + TextBox9.Text * 1
            number3 = number3 * 1
            Dim number4 As Integer
            number4 = TextBox1.Text * 1 + TextBox4.Text * 1 + TextBox7.Text * 1
            number4 = number4 * 1
            Dim number5 As Integer
            number5 = TextBox2.Text * 1 + TextBox5.Text * 1 + TextBox8.Text * 1
            number5 = number5 * 1
            Dim number6 As Integer
            number6 = TextBox3.Text * 1 + TextBox6.Text * 1 + TextBox9.Text * 1
            number6 = number6 * 1
            Dim number7 As Integer
            number7 = TextBox1.Text * 1 + TextBox5.Text * 1 + TextBox9.Text * 1
            number7 = number7 * 1
            Dim number8 As Integer
            number8 = TextBox3.Text * 1 + TextBox5.Text * 1 + TextBox7.Text * 1
            number8 = number8 * 1
            Label1.Text = Format(number1)
            Label2.Text = Format(number2)
            Label3.Text = Format(number3)
            Label4.Text = Format(number4)
            Label5.Text = Format(number5)
            Label6.Text = Format(number6)
            Label7.Text = Format(number7)
            Label8.Text = Format(number8)
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        If Label1.Text = 15 And Label2.Text = 15 And Label3.Text = 15 And Label4.Text = 15 And Label5.Text = 15 And Label6.Text = 15 And Label7.Text = 15 And Label8.Text = 15 Then
            MessageBox.Show("Ти успя!")
        Else
            MessageBox.Show("Опитай пак!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label1.Text = Nothing
        Label2.Text = Nothing
        Label3.Text = Nothing
        Label4.Text = Nothing
        Label5.Text = Nothing
        Label6.Text = Nothing
        Label7.Text = Nothing
        Label8.Text = Nothing
        TextBox1.Text = Nothing
        TextBox2.Text = Nothing
        TextBox3.Text = Nothing
        TextBox4.Text = Nothing
        TextBox5.Text = Nothing
        TextBox6.Text = Nothing
        TextBox7.Text = Nothing
        TextBox8.Text = Nothing
        TextBox9.Text = Nothing
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub
End Class
