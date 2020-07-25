Class Class1

    Sub Main() Handles Me.Load

        Label1.Text = "Hello World"
        Label1.Top = 10
        Label1.Left = 10


        TextBox1.Top = 120
        TextBox1.Left = 10
        TextBox1.Text = Nothing
        TextBox1.Multiline = True
        TextBox1.Size = New Size(465, 400)


        Button1.Top = 40
        Button1.Left = 10
        Button1.Size = New Size(465, 75)
        Button1.Text = "PRESS"


        Me.Text = "Hello World"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.Size = New Size(500, 500)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Me.Controls.Add(Label1)
        Me.Controls.Add(Button1)
        Me.Controls.Add(TextBox1)


        Button2.Text = "Class2"
        Button2.Left = 80
        Button2.Top = 5
    End Sub

    Sub Button1_ClickEvent() Handles Button1.Click

        If Not TextBox1.Text = Nothing Then
            MessageBox.Show(TextBox1.Text)
        End If

    End Sub

    Sub Button2_ClickEvent() Handles Button2.Click

        Class2.Show()
        Me.Close()

        MessageBox.Show("Hi")

    End Sub

End Class