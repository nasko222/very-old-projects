Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MaximizeBox = False
    End Sub

    Private Sub Reset()
        TurnCell.BackgroundImage = Nothing
        ErrorProvider1.DataMember = "N" 'Reset
        Box1.Enabled = True
        Box2.Enabled = True
        Box3.Enabled = True
        Box4.Enabled = True
        Box5.Enabled = True
        Box6.Enabled = True
        Box7.Enabled = True
        Box8.Enabled = True
        Box9.Enabled = True
        Box1.BackgroundImage = Square.BackgroundImage
        Box2.BackgroundImage = Square.BackgroundImage
        Box3.BackgroundImage = Square.BackgroundImage
        Box4.BackgroundImage = Square.BackgroundImage
        Box5.BackgroundImage = Square.BackgroundImage
        Box6.BackgroundImage = Square.BackgroundImage
        Box7.BackgroundImage = Square.BackgroundImage
        Box8.BackgroundImage = Square.BackgroundImage
        Box9.BackgroundImage = Square.BackgroundImage
        Cell1_O.Checked = False
        Cell1_X.Checked = False
        Cell2_O.Checked = False
        Cell2_X.Checked = False
        Cell3_O.Checked = False
        Cell3_X.Checked = False
        Cell4_O.Checked = False
        Cell4_X.Checked = False
        Cell5_O.Checked = False
        Cell5_X.Checked = False
        Cell6_O.Checked = False
        Cell6_X.Checked = False
        Cell7_O.Checked = False
        Cell7_X.Checked = False
        Cell8_O.Checked = False
        Cell8_X.Checked = False
        Cell9_O.Checked = False
        Cell9_X.Checked = False
    End Sub

    Private Sub Box1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box1.Click
        If ErrorProvider1.DataMember = "O" Then
            Box1.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box1.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell1_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box1.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box1.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage()
            Cell1_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box2.Click
        If ErrorProvider1.DataMember = "O" Then
            Box2.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box2.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell2_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box2.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box2.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell2_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box3.Click
        If ErrorProvider1.DataMember = "O" Then
            Box3.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box3.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell3_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box3.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box3.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell3_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box4.Click
        If ErrorProvider1.DataMember = "O" Then
            Box4.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box4.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell4_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box4.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box4.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell4_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box5.Click
        If ErrorProvider1.DataMember = "O" Then
            Box5.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box5.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell5_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box5.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box5.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell5_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box6.Click
        If ErrorProvider1.DataMember = "O" Then
            Box6.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box6.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell6_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box6.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box6.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell6_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box7.Click
        If ErrorProvider1.DataMember = "O" Then
            Box7.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box7.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell7_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box7.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box7.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell7_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box8.Click
        If ErrorProvider1.DataMember = "O" Then
            Box8.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box8.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell8_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box8.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box8.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell8_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub Box9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Box9.Click
        If ErrorProvider1.DataMember = "O" Then
            Box9.BackgroundImage = TicO.BackgroundImage
            ErrorProvider1.DataMember = "X"
            Box9.Enabled = False
            TurnCell.BackgroundImage = TicX.BackgroundImage
            Cell9_O.Checked = True
        ElseIf ErrorProvider1.DataMember = "X" Then
            Box9.BackgroundImage = TicX.BackgroundImage
            ErrorProvider1.DataMember = "O"
            Box9.Enabled = False
            TurnCell.BackgroundImage = TicO.BackgroundImage
            Cell9_X.Checked = True
        End If
        Call Draw()
    End Sub

    Private Sub TurnCell_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnCell.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TurnCell.BackgroundImage = TicO.BackgroundImage
        ErrorProvider1.DataMember = "O" 'Turn of O
        Box1.Enabled = True
        Box2.Enabled = True
        Box3.Enabled = True
        Box4.Enabled = True
        Box5.Enabled = True
        Box6.Enabled = True
        Box7.Enabled = True
        Box8.Enabled = True
        Box9.Enabled = True
        Box1.BackgroundImage = Square.BackgroundImage
        Box2.BackgroundImage = Square.BackgroundImage
        Box3.BackgroundImage = Square.BackgroundImage
        Box4.BackgroundImage = Square.BackgroundImage
        Box5.BackgroundImage = Square.BackgroundImage
        Box6.BackgroundImage = Square.BackgroundImage
        Box7.BackgroundImage = Square.BackgroundImage
        Box8.BackgroundImage = Square.BackgroundImage
        Box9.BackgroundImage = Square.BackgroundImage
        Cell1_O.Checked = False
        Cell1_X.Checked = False
        Cell2_O.Checked = False
        Cell2_X.Checked = False
        Cell3_O.Checked = False
        Cell3_X.Checked = False
        Cell4_O.Checked = False
        Cell4_X.Checked = False
        Cell5_O.Checked = False
        Cell5_X.Checked = False
        Cell6_O.Checked = False
        Cell6_X.Checked = False
        Cell7_O.Checked = False
        Cell7_X.Checked = False
        Cell8_O.Checked = False
        Cell8_X.Checked = False
        Cell9_O.Checked = False
        Cell9_X.Checked = False
    End Sub

    Private Sub WinningX()
        '1,4,7 #1
        '2,5,8 #2
        '3,6,9 #3
        '1,2,3 #4
        '4,5,6 #5
        '7,8,9 #6
        '1,5,9 #7
        '3,5,7 #8
        'Winning conditions (CellX)
        If Cell1_X.Checked = True And Cell4_X.Checked = True And Cell7_X.Checked = True Then '#1
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell2_X.Checked = True And Cell5_X.Checked = True And Cell8_X.Checked = True Then '#2
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell3_X.Checked = True And Cell6_X.Checked = True And Cell9_X.Checked = True Then '#3
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell1_X.Checked = True And Cell2_X.Checked = True And Cell3_X.Checked = True Then '#4
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell4_X.Checked = True And Cell5_X.Checked = True And Cell6_X.Checked = True Then '#5
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell7_X.Checked = True And Cell8_X.Checked = True And Cell9_X.Checked = True Then '#6
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell1_X.Checked = True And Cell5_X.Checked = True And Cell9_X.Checked = True Then '#7
            MessageBox.Show("X Win!")
            Call Reset()
        End If
        If Cell3_X.Checked = True And Cell5_X.Checked = True And Cell7_X.Checked = True Then '#8
            MessageBox.Show("X Win!")
            Call Reset()
        End If
    End Sub

    Private Sub WinningO()
        '1,4,7 #1
        '2,5,8 #2
        '3,6,9 #3
        '1,2,3 #4
        '4,5,6 #5
        '7,8,9 #6
        '1,5,9 #7
        '3,5,7 #8
        'Winning conditions (CellO)
        If Cell1_O.Checked = True And Cell4_O.Checked = True And Cell7_O.Checked = True Then '#1
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell2_O.Checked = True And Cell5_O.Checked = True And Cell8_O.Checked = True Then '#2
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell3_O.Checked = True And Cell6_O.Checked = True And Cell9_O.Checked = True Then '#3
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell1_O.Checked = True And Cell2_O.Checked = True And Cell3_O.Checked = True Then '#4
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell4_O.Checked = True And Cell5_O.Checked = True And Cell6_O.Checked = True Then '#5
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell7_O.Checked = True And Cell8_O.Checked = True And Cell9_O.Checked = True Then '#6
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell1_O.Checked = True And Cell5_O.Checked = True And Cell9_O.Checked = True Then '#7
            MessageBox.Show("O Win!")
            Call Reset()
        End If
        If Cell3_O.Checked = True And Cell5_O.Checked = True And Cell7_O.Checked = True Then '#8
            MessageBox.Show("O Win!")
            Call Reset()
        End If
    End Sub

    Private Sub Draw()
        If Box1.Enabled = False And Box2.Enabled = False And Box3.Enabled = False And Box4.Enabled = False And Box5.Enabled = False And Box6.Enabled = False And Box7.Enabled = False And Box8.Enabled = False And Box9.Enabled = False Then
            MessageBox.Show("Draw!")
            Call Reset()
        End If
    End Sub

    Private Sub Cell1_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell1_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell2_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell2_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell3_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell3_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell4_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell4_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell5_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell5_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell6_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell6_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell7_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell7_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell8_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell8_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell9_O_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell9_O.CheckedChanged
        Call WinningO()
    End Sub

    Private Sub Cell1_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell1_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell2_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell2_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell3_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell3_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell4_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell4_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell5_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell5_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell6_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell6_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell7_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell7_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell8_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell8_X.CheckedChanged
        Call WinningX()
    End Sub

    Private Sub Cell9_X_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cell9_X.CheckedChanged
        Call WinningX()
    End Sub
End Class