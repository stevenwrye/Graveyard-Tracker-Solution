Imports System.Reflection.Emit
Imports System.Security.Cryptography.X509Certificates

Public Class LifeTracker
    Public LifeType As String = ""
    Private Sub LifeTracker_Load(sender As Object, e As EventArgs)
        For Each ctrl As Control In Me.Controls
            Debug.WriteLine(ctrl.Name)
        Next
    End Sub

    Private Sub GSBackButton_Click(sender As Object, e As EventArgs) Handles GSBackButton.Click
        PlayerNames.Show()
        Hide()
    End Sub

    Private Sub GSExitButton_Click(sender As Object, e As EventArgs) Handles GSExitButton.Click
        Application.Exit()
    End Sub

    Private Sub BtnGrave_Click(sender As Object, e As EventArgs) Handles BtnGrave.Click
        GraveyardTracker.Show()
        Hide()
    End Sub

    Private Sub BtnCommanderLife_Click(sender As Object, e As EventArgs) Handles btnCommanderLife.Click
        For index As Integer = 1 To 10
            If LifeType = "Standard" Or PnlLifeTracker.Controls("LblLife" & index.ToString).Text IsNot Nothing Then
                PnlLifeTracker.Controls("LblLife" & index.ToString).Text = "40"
                LifeType = "Commander"
            End If
        Next
    End Sub

    Private Sub BtnStandardLife_Click(sender As Object, e As EventArgs) Handles btnStandardLife.Click
        For index As Integer = 1 To 10
            If LifeType = "Commander" Or PnlLifeTracker.Controls("LblLife" & index.ToString).Text IsNot Nothing Then
                PnlLifeTracker.Controls("LblLife" & index.ToString).Text = "20"
                LifeType = "Standard"
            End If
        Next
    End Sub

    Private Sub BtnResetLife_Click(sender As Object, e As EventArgs) Handles BtnResetLife.Click
        For index As Integer = 1 To 10
            If LifeType = "Standard" And PnlLifeTracker.Controls("LblLife" & index.ToString).Text IsNot Nothing Then
                PnlLifeTracker.Controls("LblLife" & index.ToString).Text = "20"
                LifeType = "Standard"
            ElseIf LifeType = "Commander" And PnlLifeTracker.Controls("LblLife" & index.ToString).Text IsNot Nothing Then
                PnlLifeTracker.Controls("LblLife" & index.ToString).Text = "40"
                LifeType = "Commander"
            ElseIf LifeType = "" And PnlLifeTracker.Controls("LblLife" & index.ToString).Text IsNot Nothing Then
                PnlLifeTracker.Controls("LblLife" & index.ToString).Text = "40"
            End If

        Next
    End Sub
End Class