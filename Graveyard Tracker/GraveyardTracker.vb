Public Class GraveyardTracker

    Private Sub GraveyardTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GSBackButton_Click(sender As Object, e As EventArgs) Handles GSBackButton.Click
        PlayerNames.Show()
        Hide()
    End Sub


    Private Sub BtnLife_Click(sender As Object, e As EventArgs) Handles BtnLife.Click
        LifeTracker.Show()
        Hide()
    End Sub

    Private Sub GSExitButton_Click(sender As Object, e As EventArgs) Handles GSExitButton.Click
        Application.Exit()
    End Sub

    Private Sub BtnResetCrtr_Click(sender As Object, e As EventArgs) Handles BtnResetCrtr.Click
        For index As Integer = 1 To 10
            If TLPGrave.Controls("LblCrtr" & index.ToString) IsNot Nothing Then
                TLPGrave.Controls("LblCrtr" & index.ToString).Text = "0"
            End If
        Next
    End Sub

    Private Sub BtnResetTotal_Click(sender As Object, e As EventArgs) Handles BtnResetTotal.Click
        For index As Integer = 1 To 10
            If TLPGrave.Controls("LblTotal" & index.ToString) IsNot Nothing Then
                TLPGrave.Controls("LblTotal" & index.ToString).Text = "0"
            End If
        Next
    End Sub
End Class