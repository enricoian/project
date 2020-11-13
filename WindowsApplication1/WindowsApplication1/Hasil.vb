Public Class Hasil

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Pertanyaan1.RadioButton1.Checked = False
        Pertanyaan1.RadioButton2.Checked = False
        Pertanyaan1.RadioButton3.Checked = False
        Pertanyaan1.RadioButton4.Checked = False

        Pertanyaan2.RadioButton1.Checked = False
        Pertanyaan2.RadioButton2.Checked = False
        Pertanyaan2.RadioButton3.Checked = False
        Pertanyaan2.RadioButton4.Checked = False
        Pertanyaan2.a = 0
        Pertanyaan2.b = 0
        Pertanyaan2.c = 0
        Pertanyaan2.d = 0

        Pertanyaan3.RadioButton1.Checked = False
        Pertanyaan3.RadioButton2.Checked = False
        Pertanyaan3.RadioButton3.Checked = False
        Pertanyaan3.RadioButton4.Checked = False
        Pertanyaan3.a = 0
        Pertanyaan3.b = 0
        Pertanyaan3.c = 0
        Pertanyaan3.d = 0

        Pertanyaan4.RadioButton1.Checked = False
        Pertanyaan4.RadioButton2.Checked = False
        Pertanyaan4.RadioButton3.Checked = False
        Pertanyaan4.RadioButton4.Checked = False
        Pertanyaan4.a = 0
        Pertanyaan4.b = 0
        Pertanyaan4.c = 0
        Pertanyaan4.d = 0

        Pertanyaan5.RadioButton1.Checked = False
        Pertanyaan5.RadioButton2.Checked = False
        Pertanyaan5.RadioButton3.Checked = False
        Pertanyaan5.RadioButton4.Checked = False
        Pertanyaan5.a = 0
        Pertanyaan5.b = 0
        Pertanyaan5.c = 0
        Pertanyaan5.d = 0

        Pertanyaan6.RadioButton1.Checked = False
        Pertanyaan6.RadioButton2.Checked = False
        Pertanyaan6.RadioButton3.Checked = False
        Pertanyaan6.RadioButton4.Checked = False
        Pertanyaan6.a = 0
        Pertanyaan6.b = 0
        Pertanyaan6.c = 0
        Pertanyaan6.d = 0

        Pertanyaan7.RadioButton1.Checked = False
        Pertanyaan7.RadioButton2.Checked = False
        Pertanyaan7.RadioButton3.Checked = False
        Pertanyaan7.RadioButton4.Checked = False
        Pertanyaan7.a = 0
        Pertanyaan7.b = 0
        Pertanyaan7.c = 0
        Pertanyaan7.d = 0

        Pertanyaan8.RadioButton1.Checked = False
        Pertanyaan8.RadioButton2.Checked = False
        Pertanyaan8.RadioButton3.Checked = False
        Pertanyaan8.RadioButton4.Checked = False
        Pertanyaan8.a = 0
        Pertanyaan8.b = 0
        Pertanyaan8.c = 0
        Pertanyaan8.d = 0

        Pertanyaan9.RadioButton1.Checked = False
        Pertanyaan9.RadioButton2.Checked = False
        Pertanyaan9.RadioButton3.Checked = False
        Pertanyaan9.RadioButton4.Checked = False
        Pertanyaan9.a = 0
        Pertanyaan9.b = 0
        Pertanyaan9.c = 0
        Pertanyaan9.d = 0

        Pertanyaan10.RadioButton1.Checked = False
        Pertanyaan10.RadioButton2.Checked = False
        Pertanyaan10.RadioButton3.Checked = False
        Pertanyaan10.RadioButton4.Checked = False
        Pertanyaan10.a = 0
        Pertanyaan10.b = 0
        Pertanyaan10.c = 0
        Pertanyaan10.d = 0

        Hide()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        If LinkLabel1.Text = "Koleris" Then
            info1.Show()
        ElseIf LinkLabel1.Text = "Sanguinis"
            info2.Show()
        ElseIf LinkLabel1.Text = "Plegmatis"
            info3.Show()
        ElseIf LinkLabel1.Text = "Melankolis"
            info4.Show()
        End If

    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked

        If LinkLabel2.Text = "Sanguinis" Then
            info2.Show()
        ElseIf LinkLabel2.Text = "Plegmatis"
            info3.Show()
        ElseIf LinkLabel2.Text = "Melankolis"
            info4.Show()
        End If

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        If LinkLabel3.Text = "Plegmatis" Then
            info3.Show()
        ElseIf LinkLabel3.Text = "Melankolis"
            info4.Show()
        End If

    End Sub
End Class