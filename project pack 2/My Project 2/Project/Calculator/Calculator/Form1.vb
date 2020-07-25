Public Class Calculator

    Private Sub Calculator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MinimizeBox = False
        MaximizeBox = False
    End Sub

    Private Sub Display1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Display1.Click

    End Sub
    Private Sub NumberSelect()
        If MemoryCell1.DataMember = Nothing Then
            If Not Display1.Text = "0" Then 'Anti 0 repeation
                Display1.Text = Display1.Text + clicked
            Else
                Display1.Text = clicked
            End If
        Else
            Display1.Text = Display1.Text + clicked 'display control
            MemoryCell3.DataMember = MemoryCell3.DataMember + clicked
        End If
    End Sub

    Private Sub Number1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number1.Click 'NumberSelection
        clicked = 1
        Call NumberSelect()
    End Sub

    Private Sub Number2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number2.Click
        clicked = 2
        Call NumberSelect()
    End Sub

    Private Sub Number3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number3.Click
        clicked = 3
        Call NumberSelect()
    End Sub

    Private Sub Number4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number4.Click
        clicked = 4
        Call NumberSelect()
    End Sub

    Private Sub Number5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number5.Click
        clicked = 5
        Call NumberSelect()
    End Sub

    Private Sub Number6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number6.Click
        clicked = 6
        Call NumberSelect()
    End Sub

    Private Sub Number7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number7.Click
        clicked = 7
        Call NumberSelect()
    End Sub

    Private Sub Number8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number8.Click
        clicked = 8
        Call NumberSelect()
    End Sub

    Private Sub Number9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number9.Click
        clicked = 9
        Call NumberSelect()
    End Sub

    Private Sub Number0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Number0.Click
        clicked = 0
        Call NumberSelect()
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click 'If MC2=1 Then +-*/ allowed
        If Not MemoryCell2.DataMember = 1 Then
            MemoryCell1.DataMember = "+"
            Label1.Text = Display1.Text
            Display1.Text = Display1.Text + "+"
            MemoryCell2.DataMember = 1
            Number0.Enabled = False
        Else
        End If
    End Sub

    Private Sub Subtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subtract.Click
        If Not MemoryCell2.DataMember = 1 Then
            MemoryCell1.DataMember = "-"
            Label1.Text = Display1.Text
            Display1.Text = Display1.Text + "-"
            MemoryCell2.DataMember = 1
            Number0.Enabled = False
        Else
        End If
    End Sub

    Private Sub Multiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Multiply.Click
        If Not MemoryCell2.DataMember = 1 Then
            MemoryCell1.DataMember = "*"
            Label1.Text = Display1.Text
            Display1.Text = Display1.Text + "*"
            MemoryCell2.DataMember = 1
            Number0.Enabled = False
        Else
        End If
    End Sub

    Private Sub Divide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Divide.Click
        If Not MemoryCell2.DataMember = 1 Then
            MemoryCell1.DataMember = "/"
            Label1.Text = Display1.Text
            Display1.Text = Display1.Text + "/"
            MemoryCell2.DataMember = 1
            Number0.Enabled = False
        Else
        End If
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click 'reset
        Display1.Text = "0"
        MemoryCell1.DataMember = Nothing
        MemoryCell2.DataMember = 0
        MemoryCell3.DataMember = Nothing
        Number0.Enabled = True
        Label1.Text = Nothing
        Label2.Text = Nothing
        Number1.Enabled = True
        Number2.Enabled = True
        Number3.Enabled = True
        Number4.Enabled = True
        Number5.Enabled = True
        Number6.Enabled = True
        Number7.Enabled = True
        Number8.Enabled = True
        Number9.Enabled = True
        Equal.Enabled = True
        Add.Enabled = True
        Subtract.Enabled = True
        Multiply.Enabled = True
        Divide.Enabled = True
    End Sub

    Private Sub Equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Equal.Click 'Done
        Label2.Text = MemoryCell3.DataMember
        Dim a As Integer = 0
        a = Label1.Text
        Dim b As Integer = 0
        b = Label2.Text
        Dim c
        c = MemoryCell1.DataMember
        Dim d As String = 0
        If c = "+" Then
            d = a + b
            Display1.Text = d
        End If
        If c = "-" Then
            d = a - b
            Display1.Text = d
        End If
        If c = "*" Then
            d = a * b
            Display1.Text = d
        End If
        If c = "/" Then
            d = a / b
            Display1.Text = d
        End If
        Number1.Enabled = False
        Number2.Enabled = False
        Number3.Enabled = False
        Number4.Enabled = False
        Number5.Enabled = False
        Number6.Enabled = False
        Number7.Enabled = False
        Number8.Enabled = False
        Number9.Enabled = False
        Number0.Enabled = False
        Equal.Enabled = False
        Add.Enabled = False
        Subtract.Enabled = False
        Multiply.Enabled = False
        Divide.Enabled = False
    End Sub
End Class
Module Module1
    Public clicked As String 'For Output As #1
End Module