Public Class Form1
    Private Sub nim_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nim.KeyPress
        Dim keyasci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyasci = Keys.Back) Then
        Else
            e.Handled = CBool(keyasci)
        End If
    End Sub

    Private Sub nama_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles nama.KeyPress
        Dim keyasci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[a-z, A-Z]" _
            OrElse keyasci = Keys.Back _
            OrElse keyasci = Keys.Space _
            OrElse keyasci = Keys.Return _
            OrElse keyasci = Keys.Delete) Then
        Else
            e.Handled = CBool(keyasci)
        End If
    End Sub

    Private Sub jml_presensi_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles jml_presensi.KeyPress
        Dim keyasci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyasci = Keys.Back) Then
        Else
            e.Handled = CBool(keyasci)
        End If
    End Sub
    Private Sub tugas_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles tugas.KeyPress
        Dim keyasci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyasci = Keys.Back) Then
        Else
            e.Handled = CBool(keyasci)
        End If
    End Sub

    Private Sub uts_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles uts.KeyPress
        Dim keyasci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyasci = Keys.Back) Then
        Else
            e.Handled = CBool(keyasci)
        End If
    End Sub

    Private Sub uas_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles uas.KeyPress
        Dim keyasci As Short = Asc(e.KeyChar)
        If (e.KeyChar Like "[0-9]" OrElse keyasci = Keys.Back) Then
        Else
            e.Handled = CBool(keyasci)
        End If
    End Sub

    Private Sub btn_hitung_Click(sender As Object, e As EventArgs) Handles btn_hitung.Click
        Dim getNim, getPresen, getTugas, getUAS, getUTS, total As Decimal
        Dim getNama, getNilai As String

        getNim = nim.Text
        getPresen = jml_presensi.Text
        getTugas = tugas.Text
        getUAS = uas.Text
        getUTS = uts.Text
        getNama = nama.Text

        total = (getPresen * 0.1) + (getTugas * 0.2) + (getUTS * 0.3) + (getUAS * 0.4)
        getNilai = CalculateNilai(total)
        lab_nim.Text = getNim
        lab_nama.Text = getNama
        lab_nilai.Text = getNilai
        lab_hasil.Text = total

    End Sub
    Function CalculateNilai(ByVal params As Decimal) As String
        Dim response As String
        If params >= 85 Then
            response = "A"
        ElseIf params >= 75 And params <= 85 Then
            response = "B"
        ElseIf params >= 60 And params <= 75 Then
            response = "C"
        ElseIf params >= 50 And params <= 60 Then
            response = "D"
        ElseIf params >= 40 And params <= 50 Then
            response = "E"
        Else
            response = "E"
        End If
        Return response
    End Function

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
