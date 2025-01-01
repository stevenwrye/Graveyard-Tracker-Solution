Imports System.ComponentModel

Public Class PlayerNames


    Private Sub GSBackButton_Click(sender As Object, e As EventArgs) Handles GSBackButton.Click
        GHMain.Show()
        Hide()
    End Sub

    Private Sub GSExitButton_Click(sender As Object, e As EventArgs) Handles GSExitButton.Click
        Application.Exit()
    End Sub
    'Calls the LifeGraveClick module to set the player names in the life tracker and graveyard tracker to the names entered in the player names form
    'as the reference for the player names
    Private Sub BtnLife_Click(sender As Object, e As EventArgs) Handles BtnLife.Click
        LifeTracker.Show()
        Hide()
        LifeGraveBtnClick.Click()

    End Sub
    'Calls the LifeGraveClick module to set the player names in the life tracker and graveyard tracker to the names entered in the player names form by using the opposite form
    'as the reference for the player names
    Private Sub BtnGrave_Click(sender As Object, e As EventArgs) Handles BtnGrave.Click
        GraveyardTracker.Show()
        Hide()
        LifeGraveBtnClick.Click()
    End Sub

    Private Sub PlayerNames_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




End Class