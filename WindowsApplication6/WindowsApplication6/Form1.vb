Public Class Form1
    Dim awal As Integer
    Dim konversi As Integer
    Dim perbedaan As Double


    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        TextBox1.Text = ""
        TextBox2.Text = 0
        ComboBox1.ResetText()
        ComboBox2.ResetText()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        perbedaan = 1
        If ComboBox1.SelectedIndex = 6 Then
            awal = 1
        ElseIf ComboBox1.SelectedIndex = 5 Then
            awal = 2
        ElseIf ComboBox1.SelectedIndex = 4 Then
            awal = 3
        ElseIf ComboBox1.SelectedIndex = 3 Then
            awal = 4
        ElseIf ComboBox1.SelectedIndex = 2 Then
            awal = 5
        ElseIf ComboBox1.SelectedIndex = 1 Then
            awal = 6
        ElseIf ComboBox1.SelectedIndex = 0 Then
            awal = 7
        End If
        ok()
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        perbedaan = 1
        If ComboBox2.SelectedIndex = 6 Then
            konversi = 1
        ElseIf ComboBox2.SelectedIndex = 5 Then
            konversi = 2
        ElseIf ComboBox2.SelectedIndex = 4 Then
            konversi = 3
        ElseIf ComboBox2.SelectedIndex = 3 Then
            konversi = 4
        ElseIf ComboBox2.SelectedIndex = 2 Then
            konversi = 5
        ElseIf ComboBox2.SelectedIndex = 1 Then
            konversi = 6
        ElseIf ComboBox2.SelectedIndex = 0 Then
            konversi = 7
        End If
        ok()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        ok()
    End Sub
    Private Sub ok()
        perbedaan = 1
        If awal >= konversi Then
            perbedaan = 10 ^ (awal - konversi)
        ElseIf awal < konversi Then
            perbedaan = 1 / 10 ^ (konversi - awal)
        End If
        If TextBox1.Text = "" Then
            TextBox2.Text = 0 * perbedaan
        Else : TextBox2.Text = Convert.ToDouble(Convert.ToDouble(TextBox1.Text) * perbedaan)
        End If
        perbedaan = 1
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        perbedaan = 1
    End Sub

    
End Class
