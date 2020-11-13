Public Class pertanyaan5
    Public Shared a As Integer
    Public Shared b As Integer
    Public Shared c As Integer
    Public Shared d As Integer

    Public Shared soal As Integer

    Public Shared jwb1 As Integer
    Public Shared jwb2 As Integer
    Public Shared jwb3 As Integer
    Public Shared jwb4 As Integer

    Public Shared aaa As String
    Public Shared bbb As String
    Public Shared ccc As String
    Public Shared ddd As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And
           RadioButton4.Checked = False Then
            MsgBox("Pilih dulu jawabannya")
        Else

            a += pertanyaan4.a
            b += pertanyaan4.b
            c += pertanyaan4.c
            d += pertanyaan4.d

            Me.Hide()
            Pertanyaan6.Show()

            Do
                Randomize()
                soal = 10 * Rnd()
            Loop Until soal <> 10 And soal <> pertanyaan4.soal And soal <> Pertanyaan3.soal And
                       soal <> Pertanyaan2.soal And soal <> pertanyaan1.soal And soal <> Form1.soal

            Pertanyaan6.Label1.Text = Form1.q(soal)

            If soal = 0 Then
                aaa = Form1.a1
                bbb = Form1.b1
                ccc = Form1.c1
                ddd = Form1.d1
                Dim ans1() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans1(jwb1)
                Do
                    Randomize()
                    jwb2 = (4 * Rnd())
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans1(jwb2)
                Do
                    Randomize()
                    jwb3 = (4 * Rnd())
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans1(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans1(jwb4)

            ElseIf soal = 1 Then
                aaa = Form1.a2
                bbb = Form1.b2
                ccc = Form1.c2
                ddd = Form1.d2
                Dim ans2() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans2(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans2(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans2(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans2(jwb4)

            ElseIf soal = 2 Then
                aaa = Form1.a3
                bbb = Form1.b3
                ccc = Form1.c3
                ddd = Form1.d3
                Dim ans3() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans3(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans3(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans3(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans3(jwb4)

            ElseIf soal = 3 Then
                aaa = Form1.a4
                bbb = Form1.b4
                ccc = Form1.c4
                ddd = Form1.d4
                Dim ans4() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans4(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans4(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans4(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans4(jwb4)

            ElseIf soal = 4 Then
                aaa = Form1.a5
                bbb = Form1.b5
                ccc = Form1.c5
                ddd = Form1.d5
                Dim ans5() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans5(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans5(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans5(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans5(jwb4)

            ElseIf soal = 5 Then
                aaa = Form1.a6
                bbb = Form1.b6
                ccc = Form1.c6
                ddd = Form1.d6
                Dim ans6() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans6(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans6(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans6(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans6(jwb4)

            ElseIf soal = 6 Then
                aaa = Form1.a7
                bbb = Form1.b7
                ccc = Form1.c7
                ddd = Form1.d7
                Dim ans7() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans7(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans7(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans7(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans7(jwb4)

            ElseIf soal = 7 Then
                aaa = Form1.a8
                bbb = Form1.b8
                ccc = Form1.c8
                ddd = Form1.d8
                Dim ans8() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans8(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans8(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans8(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans8(jwb4)

            ElseIf soal = 8 Then
                aaa = Form1.a9
                bbb = Form1.b9
                ccc = Form1.c9
                ddd = Form1.d9
                Dim ans9() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans9(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans9(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans9(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans9(jwb4)

            Else
                aaa = Form1.a10
                bbb = Form1.b10
                ccc = Form1.c10
                ddd = Form1.d10
                Dim ans10() As String = {aaa, bbb, ccc, ddd}
                Do
                    Randomize()
                    jwb1 = (4 * Rnd())
                Loop Until jwb1 <> 4
                Pertanyaan6.RadioButton1.Text = ans10(jwb1)
                Do
                    Randomize()
                    jwb2 = 4 * Rnd()
                Loop Until jwb2 <> jwb1 And jwb2 <> 4
                Pertanyaan6.RadioButton2.Text = ans10(jwb2)
                Do
                    Randomize()
                    jwb3 = 4 * Rnd()
                Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
                Pertanyaan6.RadioButton3.Text = ans10(jwb3)
                Do
                    Randomize()
                    jwb4 = 4 * Rnd()
                Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
                Pertanyaan6.RadioButton4.Text = ans10(jwb4)
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Text = pertanyaan4.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton1.Text = pertanyaan4.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton1.Text = pertanyaan4.ccc Then
            a = 0
            b = 0
            c = 1
            d = 0
        Else
            a = 0
            b = 0
            c = 0
            d = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Text = pertanyaan4.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton2.Text = pertanyaan4.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton2.Text = pertanyaan4.ccc Then
            a = 0
            b = 0
            c = 1
            d = 0
        Else
            a = 0
            b = 0
            c = 0
            d = 1
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Text = pertanyaan4.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton3.Text = pertanyaan4.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton3.Text = pertanyaan4.ccc Then
            a = 0
            b = 0
            c = 1
            d = 0
        Else
            a = 0
            b = 0
            c = 0
            d = 1
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Text = pertanyaan4.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton4.Text = pertanyaan4.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton4.Text = pertanyaan4.ccc Then
            a = 0
            b = 0
            c = 1
            d = 0
        Else
            a = 0
            b = 0
            c = 0
            d = 1
        End If
    End Sub

End Class
