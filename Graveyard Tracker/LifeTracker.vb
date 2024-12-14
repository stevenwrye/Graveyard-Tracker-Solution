Public Class LifeTracker1
    Private Sub Life1PlusBtn_Click(sender As Object, e As EventArgs) Handles life1PlusBtn.Click
        Life1Lbl.Text = CDec(Life1Lbl.Text + 1)
    End Sub

    Private Sub Life1minusBtn_Click(sender As Object, e As EventArgs) Handles life1minusBtn.Click
        If Life1Lbl.Text >= 0 Then
            Life1Lbl.Text = CDec(Life1Lbl.Text - 1)
        End If
    End Sub
End Class