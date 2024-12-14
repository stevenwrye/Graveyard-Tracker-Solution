Imports System.CodeDom
Imports System.Security.Cryptography.X509Certificates




Public Class GHMain
    'GH stands for GraveyardHome because I am too lazy for typing that shit out every time I make a new statement.

    Private Sub GHMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pCountLbl.Text = 1
    End Sub

    Private Sub GHExitButton_Click(sender As Object, e As EventArgs) Handles GHExitButton.Click
        'Exits application
        Application.Exit()
    End Sub
    Private Sub GHContinueButton_Click(sender As Object, e As EventArgs) Handles GHContinueButton.Click
        'Attempts to open PlayerNames page for user to enter names of players in their game based on number selected in the NumbBox
        GraveyardStats.Show()
        Hide()

    End Sub

    Private Sub PlusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click
        If pCountLbl.Text < 10 Then
            pCountLbl.Text = CDec(pCountLbl.Text + 1)
        ElseIf pCountLbl.Text = 10 Then
            pCountLbl.Text = CDec(pCountLbl.Text)
        End If

    End Sub

    Private Sub MinusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        If pCountLbl.Text > 1 Then
            pCountLbl.Text = CDec(pCountLbl.Text - 1)
        ElseIf pCountLbl.Text = 1 Then
            pCountLbl.Text = CDec(pCountLbl.Text)
        End If
    End Sub
End Class