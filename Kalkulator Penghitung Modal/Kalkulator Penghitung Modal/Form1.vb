Public Class Form1
    Public Shared Value As Double
    Public Shared Batas As Double
    Public Shared Data As Array
    Public Shared Index As Integer = 1
    Public Shared b_pake As Double
    Public Shared b_ambil As Double
    Public Shared b_harga As Double
    Public Shared Total As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Hide()
        Button3.Hide()
        Label8.Hide()
        TextBox6.Hide()
        Button5.Hide()
        Panel2.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Value = Val(TextBox1.Text)
        Batas = Value

        If Value <= 0 Then
            MsgBox("Nilai Banyak Bahan Salah!")
        Else
            Data = New Double(Value - 1) {}
            Label2.Text = Index
            Panel2.Show()
            If Batas = 1 Then
                Button2.Text = "Selesai"
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Masukkan Nilai Terlebih Dahulu")
        End If

        If Batas > 1 Then
            b_pake = Val(TextBox2.Text)
            b_ambil = Val(TextBox3.Text)
            b_harga = Val(TextBox4.Text)

            Select Case ComboBox1.Text
                Case "Kg", "L"
                    b_pake = b_pake * 1000
                Case "Ons"
                    b_pake = b_pake * 100
            End Select

            Select Case ComboBox2.Text
                Case "Kg", "L"
                    b_ambil = b_ambil * 1000
                Case "Ons"
                    b_ambil = b_ambil * 100
            End Select

            If b_pake > b_ambil Then
                MsgBox("Nilai Tidak Memungkinkan/Satuan Salah")
                TextBox2.Text = ""
                TextBox3.Text = ""
            Else
                Data(Index - 1) = b_harga / b_ambil * b_pake
                Total += Data(Index - 1)
                Index += 1
                Batas -= 1
                Label2.Text = Index
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""

                If Button2.Text = "Lanjut" Then
                    ComboBox1.SelectedIndex = -1
                    ComboBox2.SelectedIndex = -1
                End If

                If Batas = 1 Then
                    Button2.Text = "Selesai"
                End If

            End If

        ElseIf Batas = 1 Then
            b_pake = Val(TextBox2.Text)
            b_ambil = Val(TextBox3.Text)
            b_harga = Val(TextBox4.Text)

            Select Case ComboBox1.Text
                Case "Kg", "L"
                    b_pake = b_pake * 1000
                Case "Ons"
                    b_pake = b_pake * 100
            End Select

            Select Case ComboBox2.Text
                Case "Kg", "L"
                    b_ambil = b_ambil * 1000
                Case "Ons"
                    b_ambil = b_ambil * 100
            End Select

            If b_pake > b_ambil Then
                MsgBox("Nilai Tidak Memungkinkan/Satuan Salah")
                TextBox2.Text = ""
                TextBox3.Text = ""
            Else
                Data(Index - 1) = b_harga / b_ambil * b_pake
                Total += Data(Index - 1)
                Index += 1
                Batas -= 1

                TextBox5.Text = Total
                Label7.Show()
                Button3.Show()
            End If

        Else
            MsgBox("Sudah Batas")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label7.Hide()
        Button3.Hide()
        Label8.Show()
        TextBox6.Show()
        Button5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Label8.Hide()
        TextBox6.Hide()
        Button5.Hide()

        Total = Total / Val(TextBox6.Text)

        TextBox5.Text = Total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Value = 0
        Index = 1
        Data = New Double(Value - 1) {}
        b_pake = 0
        b_ambil = 0
        b_harga = 0
        Total = 0
        Batas = 0
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Panel2.Hide()
        Button2.Text = "Lanjut"
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1

    End Sub
End Class
