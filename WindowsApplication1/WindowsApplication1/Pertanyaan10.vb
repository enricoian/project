Public Class Pertanyaan10
    Public Shared a As Integer
    Public Shared b As Integer
    Public Shared c As Integer
    Public Shared d As Integer

    Public Shared soal As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And
           RadioButton4.Checked = False Then
            MsgBox("Pilih dulu jawabannya")
        Else

            a += Pertanyaan9.a
            b += Pertanyaan9.b
            c += Pertanyaan9.c
            d += Pertanyaan9.d

            Dim s As Integer = (a + b + c + d)
            Dim aa As Double = (a * 100 / s)
            Dim bb As Double = (b * 100 / s)
            Dim cc As Double = (c * 100 / s)
            Dim dd As Double = (d * 100 / s)

            Hide()
            Hasil.Show()
            Hasil.koleris.Text = aa & "%"
            Hasil.sanguinis.Text = bb & "%"
            Hasil.plegmatis.Text = cc & "%"
            Hasil.melankolis.Text = dd & "%"

            If (a > d And b > d And c > d And a = b And b = c) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Text = "Sanguinis"
                Hasil.LinkLabel3.Text = "Plegmatis"
            ElseIf (a > c And b > c And d > c And a = b And b = d) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Text = "Sanguinis"
                Hasil.LinkLabel3.Text = "Melankolis"
            ElseIf (a > b And c > b And d > b And a = c And c = d) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Text = "Plegmatis"
                Hasil.LinkLabel3.Text = "Melankolis"
            ElseIf (b > a And c > a And d > a And b = c And c = d) Then
                Hasil.LinkLabel1.Text = "Sanguinis"
                Hasil.LinkLabel2.Text = "Plegmatis"
                Hasil.LinkLabel3.Text = "Melankolis"
            ElseIf (a > c And a > d And b > c And b > d And a = b And b = a) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Text = "Sanguinis"
                Hasil.LinkLabel3.Hide()
                Hasil.Label6.Hide()
            ElseIf (a > b And a > d And c > b And c > d And a = c And c = a) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Text = "Plegmatis"
                Hasil.LinkLabel3.Hide()
                Hasil.Label6.Hide()
            ElseIf (a > b And a > c And d > b And d > c And a = d And d = a) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Text = "Melankolis"
                Hasil.LinkLabel3.Hide()
                Hasil.Label6.Hide()
            ElseIf (b > a And b > d And c > a And c > d And b = c And c = b) Then
                Hasil.LinkLabel1.Text = "Sanguinis"
                Hasil.LinkLabel2.Text = "Plegmatis"
                Hasil.LinkLabel3.Hide()
                Hasil.Label6.Hide()
            ElseIf (b > a And b > c And d > a And d > c And b = d And d = b) Then
                Hasil.LinkLabel1.Text = "Sanguinis"
                Hasil.LinkLabel2.Text = "Melankolis"
                Hasil.LinkLabel3.Hide()
                Hasil.Label6.Hide()
            ElseIf (c > a And c > b And d > a And d > b And c = d And d = c) Then
                Hasil.LinkLabel1.Text = "Plegmatis"
                Hasil.LinkLabel2.Text = "Melankolis"
                Hasil.LinkLabel3.Hide()
                Hasil.Label6.Hide()
            ElseIf (a > b And a > c And a > d) Then
                Hasil.LinkLabel1.Text = "Koleris"
                Hasil.LinkLabel2.Hide()
                Hasil.LinkLabel3.Hide()
                Hasil.Label5.Hide()
                Hasil.Label6.Hide()
            ElseIf (b > a And b > c And b > d) Then
                Hasil.LinkLabel1.Text = "Sanguinis"
                Hasil.LinkLabel2.Hide()
                Hasil.LinkLabel3.Hide()
                Hasil.Label5.Hide()
                Hasil.Label6.Hide()
            ElseIf (c > a And c > b And c > d) Then
                Hasil.LinkLabel1.Text = "Plegmatis"
                Hasil.LinkLabel2.Hide()
                Hasil.LinkLabel3.Hide()
                Hasil.Label5.Hide()
                Hasil.Label6.Hide()
            Else
                Hasil.LinkLabel1.Text = "Melankolis"
                Hasil.LinkLabel2.Hide()
                Hasil.LinkLabel3.Hide()
                Hasil.Label5.Hide()
                Hasil.Label6.Hide()
            End If

        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        If RadioButton1.Text = Pertanyaan9.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton1.Text = Pertanyaan9.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton1.Text = Pertanyaan9.ccc Then
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
        If RadioButton2.Text = Pertanyaan9.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton2.Text = Pertanyaan9.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton2.Text = Pertanyaan9.ccc Then
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
        If RadioButton3.Text = Pertanyaan9.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton3.Text = Pertanyaan9.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton3.Text = Pertanyaan9.ccc Then
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
        If RadioButton4.Text = Pertanyaan9.aaa Then
            a = 1
            b = 0
            c = 0
            d = 0
        ElseIf RadioButton4.Text = Pertanyaan9.bbb Then
            a = 0
            b = 1
            c = 0
            d = 0
        ElseIf RadioButton4.Text = Pertanyaan9.ccc Then
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
