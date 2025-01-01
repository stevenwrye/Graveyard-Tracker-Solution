Public Module LifeGraveBtnClick
    'Sets the player names in the life tracker and graveyard tracker to the names entered in the player names form the opposite form
    'The player names are originally designated by the PlayerNames form textboxes
    Public Sub Click()
        Dim maxPlayers As Integer = 10
        For i As Integer = 1 To maxPlayers
            LifeTracker.Controls("LblPlayer" & i).Text = PlayerNames.Controls("TextBox" & i).Text
            GraveyardTracker.Controls("LblGravePlayer" & i).Text = PlayerNames.Controls("TextBox" & i).Text
        Next
    End Sub

End Module
