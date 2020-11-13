Public Class Form1
    Public Shared soal As Integer

    Public Shared jwb1 As Integer
    Public Shared jwb2 As Integer
    Public Shared jwb3 As Integer
    Public Shared jwb4 As Integer

    Public Shared aaa As String
    Public Shared bbb As String
    Public Shared ccc As String
    Public Shared ddd As String

    Public Shared q() As String

    Public Shared a1 As String = "Optimis dan positif"
    Public Shared b1 As String = "Pantang menyerah dan presisten"
    Public Shared c1 As String = "Murah hati dan mau berbagi"
    Public Shared d1 As String = "Disiplin tinggi dan pengendalian diri"

    Public Shared a2 As String = "Independent dan mandiri"
    Public Shared b2 As String = "Senang bersosialisasi dan keramaian"
    Public Shared c2 As String = "Sabar, toleransi terhadap orang lain"
    Public Shared d2 As String = "Cenderung sensitif"

    Public Shared a3 As String = "Senang Petualangan"
    Public Shared b3 As String = "Hangat dan bersahabat"
    Public Shared c3 As String = "Mudah ditemani, enak diajak bersama"
    Public Shared d3 As String = "Dingin dan penuh perhatian"

    Public Shared a4 As String = "Berkemauan keras"
    Public Shared b4 As String = "Gembira, menikmati"
    Public Shared c4 As String = "Senang membantu, ringan tangan"
    Public Shared d4 As String = "Menyukai data dan fakta"

    Public Shared a5 As String = "Berani mengambil resiko"
    Public Shared b5 As String = "Senang bermain, Penuh dengan antusiasme"
    Public Shared c5 As String = "Mengerjakan sesuai dengan perintah"
    Public Shared d5 As String = "Mudah tersinggung, sulit dibuat senang"

    Public Shared a6 As String = "Penantang, mengambil tindakan"
    Public Shared b6 As String = "Mudah dimanfaatkan orang lain"
    Public Shared c6 As String = "Mudah bergaul, dapat diandalkan"
    Public Shared d6 As String = "Pendendam dan mudah cemas"

    Public Shared a7 As String = "Pantang menyerah"
    Public Shared b7 As String = "Menyenangkan"
    Public Shared c7 As String = "Mudah dipimpin, pengikut"
    Public Shared d7 As String = "Perfeksionis"

    Public Shared a8 As String = "Percaya diri"
    Public Shared b8 As String = "Gemar melucu"
    Public Shared c8 As String = "Kalem"
    Public Shared d8 As String = "Suka curiga"

    Public Shared a9 As String = "Tegas dalam membuat keputusan"
    Public Shared b9 As String = "Konvensional, mengerjakan sesuatu seperti biasanya"
    Public Shared c9 As String = "Pandai berbicara, senang mengobrol"
    Public Shared d9 As String = "Rapi dan teratur"

    Public Shared a10 As String = "Argumentatif, suka membantah"
    Public Shared b10 As String = "Fleksible, mudah beradaptasi"
    Public Shared c10 As String = "Terbebas dari rasa khawatir dan tanggung jawab"
    Public Shared d10 As String = "Cuek, berpikir kritis"



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Hide()
        Pertanyaan1.Show()

        Do
            Randomize()
            soal = 10 * Rnd()
        Loop Until soal <> 10
        q = {"Berikut ini mendeskripsikan diri saya",
            "Pernyataan ini mewakili diri saya",
            "Mirip dengan keseharian saya",
            "Hal ini mencerminkan diri saya",
            "Hal ini paling mendekati diri saya",
            "Hal ini mencerminkan diri saya",
            "Pernyataan ini cocok dengan diri saya",
            "Pertanyaan ini serupa dengan saya",
            "Pernyataan ini cocok dengan diri saya",
            "Hal ini paling mendekati diri saya"}

        pertanyaan1.Label1.Text = q(soal)

        If soal = 0 Then
            aaa = a1
            bbb = b1
            ccc = c1
            ddd = d1
            Dim ans1() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans1(jwb1)
            Do
                Randomize()
                jwb2 = (4 * Rnd())
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans1(jwb2)
            Do
                Randomize()
                jwb3 = (4 * Rnd())
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans1(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans1(jwb4)

        ElseIf soal = 1 Then
            aaa = a2
            bbb = b2
            ccc = c2
            ddd = d2
            Dim ans2() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans2(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans2(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans2(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans2(jwb4)

        ElseIf soal = 2 Then
            aaa = a3
            bbb = b3
            ccc = c3
            ddd = d3
            Dim ans3() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans3(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans3(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans3(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans3(jwb4)

        ElseIf soal = 3 Then
            aaa = a4
            bbb = b4
            ccc = c4
            ddd = d4
            Dim ans4() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans4(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans4(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans4(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans4(jwb4)

        ElseIf soal = 4 Then
            aaa = a5
            bbb = b5
            ccc = c5
            ddd = d5
            Dim ans5() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans5(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans5(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans5(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans5(jwb4)

        ElseIf soal = 5 Then
            aaa = a6
            bbb = b6
            ccc = c6
            ddd = d6
            Dim ans6() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans6(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans6(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans6(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans6(jwb4)

        ElseIf soal = 6 Then
            aaa = a6
            bbb = b6
            ccc = c6
            ddd = d6
            Dim ans7() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans7(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans7(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans7(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans7(jwb4)

        ElseIf soal = 7 Then
            aaa = a6
            bbb = b6
            ccc = c6
            ddd = d6
            Dim ans8() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans8(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans8(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans8(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans8(jwb4)

        ElseIf soal = 8 Then
            aaa = a6
            bbb = b6
            ccc = c6
            ddd = d6
            Dim ans9() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans9(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans9(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans9(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans9(jwb4)

        Else
            aaa = a6
            bbb = b6
            ccc = c6
            ddd = d6
            Dim ans10() As String = {aaa, bbb, ccc, ddd}
            Do
                Randomize()
                jwb1 = (4 * Rnd())
            Loop Until jwb1 <> 4
            Pertanyaan1.RadioButton1.Text = ans10(jwb1)
            Do
                Randomize()
                jwb2 = 4 * Rnd()
            Loop Until jwb2 <> jwb1 And jwb2 <> 4
            Pertanyaan1.RadioButton2.Text = ans10(jwb2)
            Do
                Randomize()
                jwb3 = 4 * Rnd()
            Loop Until jwb3 <> jwb1 And jwb3 <> jwb2 And jwb3 <> 4
            Pertanyaan1.RadioButton3.Text = ans10(jwb3)
            Do
                Randomize()
                jwb4 = 4 * Rnd()
            Loop Until jwb4 <> jwb1 And jwb4 <> jwb2 And jwb4 <> jwb3 And jwb4 <> 4
            Pertanyaan1.RadioButton4.Text = ans10(jwb4)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Close()

    End Sub
End Class
