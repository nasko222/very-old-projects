Public Class Form1

    Sub OnlyNumbers(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cell11.KeyPress, Cell12.KeyPress, Cell13.KeyPress, Cell14.KeyPress, Cell15.KeyPress, Cell16.KeyPress, Cell17.KeyPress, Cell18.KeyPress, Cell19.KeyPress, Cell21.KeyPress, Cell22.KeyPress, Cell23.KeyPress, Cell24.KeyPress, Cell25.KeyPress, Cell26.KeyPress, Cell27.KeyPress, Cell28.KeyPress, Cell29.KeyPress, Cell31.KeyPress, Cell32.KeyPress, Cell33.KeyPress, Cell34.KeyPress, Cell35.KeyPress, Cell36.KeyPress, Cell37.KeyPress, Cell38.KeyPress, Cell39.KeyPress, Cell41.KeyPress, Cell42.KeyPress, Cell43.KeyPress, Cell44.KeyPress, Cell45.KeyPress, Cell46.KeyPress, Cell47.KeyPress, Cell48.KeyPress, Cell49.KeyPress, Cell51.KeyPress, Cell52.KeyPress, Cell53.KeyPress, Cell54.KeyPress, Cell55.KeyPress, Cell56.KeyPress, Cell57.KeyPress, Cell58.KeyPress, Cell59.KeyPress, Cell61.KeyPress, Cell62.KeyPress, Cell63.KeyPress, Cell64.KeyPress, Cell65.KeyPress, Cell66.KeyPress, Cell67.KeyPress, Cell68.KeyPress, Cell69.KeyPress, Cell71.KeyPress, Cell72.KeyPress, Cell73.KeyPress, Cell74.KeyPress, Cell75.KeyPress, Cell76.KeyPress, Cell77.KeyPress, Cell78.KeyPress, Cell79.KeyPress, Cell81.KeyPress, Cell82.KeyPress, Cell83.KeyPress, Cell84.KeyPress, Cell85.KeyPress, Cell86.KeyPress, Cell87.KeyPress, Cell88.KeyPress, Cell89.KeyPress, Cell91.KeyPress, Cell92.KeyPress, Cell93.KeyPress, Cell94.KeyPress, Cell95.KeyPress, Cell96.KeyPress, Cell97.KeyPress, Cell98.KeyPress, Cell99.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '11 12 13   21 22 23    31 32 33 REM
        '14 15 16   24 25 26    34 35 36 REM
        '17 18 19   27 28 29    37 38 39 REM

        '41 42 43   51 52 53    61 62 63 REM
        '44 45 46   54 55 56    64 65 66 REM
        '47 48 49   57 58 59    67 68 69 REM

        '71 72 73   81 82 83    91 92 93 REM
        '74 75 76   84 85 86    94 95 96 REM
        '77 78 79   87 88 89    97 98 99 REM
        'R  'R 'R   'R 'R 'R    'R 'R 'R
        ' + Cells

    End Sub
End Class
