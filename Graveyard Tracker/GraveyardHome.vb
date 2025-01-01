Imports System.CodeDom
Imports System.Security.Cryptography.X509Certificates




Public Class GHMain

    'GH stands for GraveyardHome because I am too lazy for typing that shit out every time I make a new statement.
    Private Sub GHMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Sets the Minus Life button on the LifeTracker page to subtract life until the label LblLife numbered up to the selected number of current players hits zero. It then displays an error message coded in module ErrorText. 
    Protected Sub BtnMinusLife_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim playerIndex As Integer = Integer.Parse(button.Name.Replace("BtnMinusLife", ""))
        Dim lifeLabel As Label = TryCast(LifeTracker.PnlLifeTracker.Controls("LblLife" & playerIndex.ToString()), Label)

        If lifeLabel IsNot Nothing Then
            Dim currentLife As Integer
            If Integer.TryParse(lifeLabel.Text, currentLife) Then
                currentLife -= 1
                lifeLabel.Text = currentLife.ToString()
            End If
            If lifeLabel.Text < 0 Then
                lifeLabel.Text = 0
                MsgBox("This player has unfortunately lost.")

            End If

        End If
    End Sub
    'Sets the Plus Life button on the LifeTracker page to add life to the label LblLife(numbered up to the selected number of current players).
    Protected Sub BtnPlusLife_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim playerIndex As Integer = Integer.Parse(button.Name.Replace("BtnPlusLife", ""))
        Dim lifeLabel As Label = TryCast(LifeTracker.PnlLifeTracker.Controls("LblLife" & playerIndex.ToString()), Label)

        If lifeLabel IsNot Nothing Then
            Dim currentLife As Integer
            If Integer.TryParse(lifeLabel.Text, currentLife) Then
                currentLife += 1
                lifeLabel.Text = currentLife.ToString()
            End If
        End If
    End Sub
    'Sets the Minus Creature button on the GraveTracker page to subtract creature count until the label LblCreature(numbered to match the selected number of current players) hits zero. It then displays an error message.
    Protected Sub BtnMinusCrtr_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim playerIndex As Integer = Integer.Parse(button.Name.Replace("BtnMinusCrtr", ""))
        Dim crtrLabel As Label = TryCast(GraveyardTracker.TLPGrave.Controls("LblCrtr" & playerIndex.ToString()), Label)

        If crtrLabel IsNot Nothing Then
            Dim currentCrtr As Integer
            If Integer.TryParse(crtrLabel.Text, currentCrtr) Then
                currentCrtr -= 1
                crtrLabel.Text = currentCrtr.ToString()
            End If
            If crtrLabel.Text < 0 Then
                crtrLabel.Text = 0
                MsgBox("You cannot have a negative number of creatures!")
            End If
        End If
    End Sub
    'Sets the Plus Creature button on the GraveTracker page to add creature count to label LblCreature(numbered up to the selected number of current players).
    Protected Sub BtnPlusCrtr_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim playerIndex As Integer = Integer.Parse(button.Name.Replace("BtnPlusCrtr", ""))
        Dim crtrLabel As Label = TryCast(GraveyardTracker.TLPGrave.Controls("LblCrtr" & playerIndex.ToString()), Label)

        If crtrLabel IsNot Nothing Then
            Dim currentCrtr As Integer
            If Integer.TryParse(crtrLabel.Text, currentCrtr) Then
                currentCrtr += 1
                crtrLabel.Text = currentCrtr.ToString()
            End If
        End If
    End Sub
    'Sets the Minus Total button on the GraveTracker page to subtract total card count until the label LblTotal(numbered to match the selected number of current players hits zero). It then displays an error message.
    Protected Sub BtnMinusTotal_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim playerIndex As Integer = Integer.Parse(button.Name.Replace("BtnMinusTotal", ""))
        Dim totalLabel As Label = TryCast(GraveyardTracker.TLPGrave.Controls("LblTotal" & playerIndex.ToString()), Label)
        If totalLabel IsNot Nothing Then
            Dim currentTotal As Integer
            If Integer.TryParse(totalLabel.Text, currentTotal) Then
                currentTotal -= 1
                totalLabel.Text = currentTotal.ToString()
            End If
            If totalLabel.Text < 0 Then
                totalLabel.Text = 0
                MsgBox("You cannot have a negative number of cards!")
            End If
        End If
    End Sub
    'Sets the Plus Total button on the GraveTracker page to add total count to label LblTotal(numbered up to the selected number of current players).
    Protected Sub BtnPlusTotal_Click(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim playerIndex As Integer = Integer.Parse(button.Name.Replace("BtnPlusTotal", ""))
        Dim totalLabel As Label = TryCast(GraveyardTracker.TLPGrave.Controls("LblTotal" & playerIndex.ToString()), Label)
        If totalLabel IsNot Nothing Then
            Dim currentTotal As Integer
            If Integer.TryParse(totalLabel.Text, currentTotal) Then
                currentTotal += 1
                totalLabel.Text = currentTotal.ToString()
            End If
        End If
    End Sub


    'Sets the Plus button to add players to the game up to a maximum of 10 players. It then creates textboxes, labels, and buttons for each player added.
    Private Sub plusBtn_Click(sender As Object, e As EventArgs) Handles plusBtn.Click
        Dim maxPlayers = 10
        Dim currentCount As Integer

        'Parse the label's text to an integer
        If Integer.TryParse(pCountLbl.Text, currentCount) AndAlso currentCount < maxPlayers Then
            'Increment player count and update label
            currentCount += 1
            pCountLbl.Text = currentCount.ToString

            'Make textboxes, labels, and buttons visible up to the new player count
            For index = 1 To maxPlayers

                'Update TextBox visibility
                Dim txtBox = TryCast(PlayerNames.Controls("TextBox" & index.ToString), TextBox)
                If txtBox IsNot Nothing Then txtBox.Visible = index <= currentCount

                'Update Label visibility
                Dim playerLabel = TryCast(LifeTracker.Controls("LblPlayer" & index.ToString), Label)
                If playerLabel IsNot Nothing Then playerLabel.Visible = index <= currentCount

                Dim gravePlayerLabel = TryCast(GraveyardTracker.Controls("LblGravePlayer" & index.ToString), Label)
                If gravePlayerLabel IsNot Nothing Then gravePlayerLabel.Visible = index <= currentCount

                'Creates and formats a new life addition button for the life tracker based on the number of players selected and places it in the table layout panel
                Dim lifePlusButton = TryCast(LifeTracker.PnlLifeTracker.Controls("BtnPlusLife" & index.ToString), Button)
                If lifePlusButton IsNot Nothing Then
                    lifePlusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new + button for the current player
                    Dim newPlusButton As New Button With {
                    .Name = "BtnPlusLife" & index.ToString,
                    .Text = "+",
                    .Size = New Size(40, 40)
                }

                    'Add the button to the specified cell in the TableLayoutPanel
                    LifeTracker.PnlLifeTracker.Controls.Add(newPlusButton)
                    LifeTracker.PnlLifeTracker.SetCellPosition(newPlusButton, New TableLayoutPanelCellPosition(2, index - 1))

                    AddHandler newPlusButton.Click, AddressOf BtnPlusLife_Click
                End If

                'Creates and formats a new life subtraction button for the life tracker based on the number of players selected and places it in the table layout panel
                Dim lifeMinusButton = TryCast(LifeTracker.PnlLifeTracker.Controls("BtnMinusLife" & index.ToString), Button)
                If lifeMinusButton IsNot Nothing Then
                    lifeMinusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    Dim newMinusButton As New Button With {
                        .Name = "BtnMinusLife" & index.ToString,
                        .Text = "-",
                        .Size = New Size(40, 40)
                    }


                    LifeTracker.PnlLifeTracker.Controls.Add(newMinusButton)
                    LifeTracker.PnlLifeTracker.SetCellPosition(newMinusButton, New TableLayoutPanelCellPosition(0, index - 1))

                    AddHandler newMinusButton.Click, AddressOf BtnMinusLife_Click
                End If

                'Creates and formats a new life label for the life tracker based on the number of players selected and places it in the table layout panel
                Dim lifeLabel = TryCast(LifeTracker.PnlLifeTracker.Controls("LblLife" & index.ToString), Label)
                If lifeLabel IsNot Nothing Then
                    lifeLabel.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    Dim newLifeLabel As New Label With {
                        .Name = "LblLife" & index.ToString,
                        .Text = "40",
                        .Size = New Size(40, 40),
                        .Font = New Font("Engravers, MT", 12, FontStyle.Bold),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                    LifeTracker.PnlLifeTracker.Controls.Add(newLifeLabel)
                    LifeTracker.PnlLifeTracker.SetCellPosition(newLifeLabel, New TableLayoutPanelCellPosition(1, index - 1))


                End If


                'Creates and formats a new creature subtraction button for the graveyard tracker based on the number of players selected and places it in the table layout panel
                Dim crtrMinusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnMinusCrtr" & index.ToString), Button)
                If crtrMinusButton IsNot Nothing Then
                    'Update button visibility
                    crtrMinusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newMinusButtons As New Button With {
                        .Name = "BtnMinusCrtr" & index.ToString,
                        .Text = "-",
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newMinusButtons)
                    GraveyardTracker.TLPGrave.SetCellPosition(newMinusButtons, New TableLayoutPanelCellPosition(0, index - 1))
                    AddHandler newMinusButtons.Click, AddressOf BtnMinusCrtr_Click
                End If

                'Creates and formats a new creature card addition button for the graveyard tracker based on the number of players selected and places it in the table layout panel
                Dim crtrPlusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnPlusCrtr" & index.ToString), Button)
                If crtrPlusButton IsNot Nothing Then
                    'Update button visibility
                    crtrPlusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newPlusButtons As New Button With {
                        .Name = "BtnPlusCrtr" & index.ToString,
                        .Text = "+",
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newPlusButtons)
                    GraveyardTracker.TLPGrave.SetCellPosition(newPlusButtons, New TableLayoutPanelCellPosition(2, index - 1))
                    AddHandler newPlusButtons.Click, AddressOf BtnPlusCrtr_Click
                End If

                'Creates and formats a new creature label for the graveyard tracker based on the number of players selected and places it in the table layout panel
                Dim crtrLabel = TryCast(GraveyardTracker.TLPGrave.Controls("LblCrtr" & index.ToString), Label)
                If crtrLabel IsNot Nothing Then
                    'Update label visibility
                    crtrLabel.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new label based on the number of players selected
                    Dim newCrtrLabel As New Label With {
                        .Name = "LblCrtr" & index.ToString,
                        .Text = "0",
                        .Size = New Size(40, 40),
                        .Font = New Font("Engravers, MT", 12, FontStyle.Bold),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newCrtrLabel)
                    GraveyardTracker.TLPGrave.SetCellPosition(newCrtrLabel, New TableLayoutPanelCellPosition(1, index - 1))
                End If

                'Creates and formats a new total card subtraction button for the graveyard tracker based on the number of players selected and places it in the table layout panel
                Dim totalMinusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnMinusTotal" & index.ToString), Button)
                If totalMinusButton IsNot Nothing Then
                    'Update button visibility
                    totalMinusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newTotalMinusButton As New Button With {
                        .Name = "BtnMinusTotal" & index.ToString,
                        .Text = "-",
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newTotalMinusButton)
                    GraveyardTracker.TLPGrave.SetCellPosition(newTotalMinusButton, New TableLayoutPanelCellPosition(3, index - 1))
                    AddHandler newTotalMinusButton.Click, AddressOf BtnMinusTotal_Click
                End If

                'Creates and formats a new total card addition button for the graveyard tracker based on the number of players selected and places it in the table layout panel
                Dim totalPlusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnPlusTotal" & index.ToString), Button)
                If totalPlusButton IsNot Nothing Then
                    'Update button visibility
                    totalPlusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newTotalPlusButton As New Button With {
                        .Name = "BtnPlusTotal" & index.ToString,
                        .Text = "+",
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newTotalPlusButton)
                    GraveyardTracker.TLPGrave.SetCellPosition(newTotalPlusButton, New TableLayoutPanelCellPosition(5, index - 1))
                    AddHandler newTotalPlusButton.Click, AddressOf BtnPlusTotal_Click
                End If

                Dim totalLabel = TryCast(GraveyardTracker.TLPGrave.Controls("LblTotal" & index.ToString), Label)
                If totalLabel IsNot Nothing Then
                    'Update label visibility
                    totalLabel.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new label based on the number of players selected
                    Dim newTotalLabel As New Label With {
                        .Name = "LblTotal" & index.ToString,
                        .Text = "0",
                        .Size = New Size(40, 40),
                        .Font = New Font("Engravers, MT", 12, FontStyle.Bold),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newTotalLabel)
                    GraveyardTracker.TLPGrave.SetCellPosition(newTotalLabel, New TableLayoutPanelCellPosition(4, index - 1))
                End If
            Next
        End If

    End Sub


    'Sets the minus button to remove players from the game down to a minimum of zero players. It then removes textboxes, labels, and buttons for each player removed.
    'If the count reaches zero and the minusBtnClick input is given it will display an error message coded in the ErrorText.vb Module.
    Private Sub minusBtn_Click(sender As Object, e As EventArgs) Handles minusBtn.Click
        Dim maxPlayers = 10
        Dim currentCount As Integer

        If Integer.TryParse(pCountLbl.Text, currentCount) AndAlso currentCount >= 0 Then
            ' Decrement player count and update label
            currentCount -= 1
            pCountLbl.Text = currentCount.ToString

            'Make textboxes, labels, and buttons invisible above the new count
            For index = 1 To maxPlayers
                ' Update TextBox visibility
                Dim txtBox = TryCast(PlayerNames.Controls("TextBox" & index.ToString), TextBox)
                If txtBox IsNot Nothing Then txtBox.Visible = index <= currentCount

                ' Update Label visibility
                Dim playerLabel = TryCast(LifeTracker.Controls("LblPlayer" & index.ToString), Label)
                If playerLabel IsNot Nothing Then playerLabel.Visible = index <= currentCount


                Dim gravePlayerLabel = TryCast(GraveyardTracker.Controls("LblGravePlayer" & index.ToString), Label)
                If gravePlayerLabel IsNot Nothing Then gravePlayerLabel.Visible = index <= currentCount

                'LIFE TRACKER BUTTONS AND LABELS------------------------------------------------------------------------------------------------------------------------------
                Dim lifePlusButton = TryCast(LifeTracker.PnlLifeTracker.Controls("BtnPlusLife" & index.ToString), Button)
                If lifePlusButton IsNot Nothing Then
                    lifePlusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    ' Create a new + button for the current player
                    Dim newPlusButton As New Button With {
                    .Name = "BtnPlusLife" & index.ToString,
                    .Text = "+",
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(40, 40)
                }

                    ' Add the button to the specified cell in the TableLayoutPanel
                    LifeTracker.PnlLifeTracker.Controls.Add(newPlusButton)
                    LifeTracker.PnlLifeTracker.SetCellPosition(newPlusButton, New TableLayoutPanelCellPosition(2, index - 1))

                    AddHandler newPlusButton.Click, AddressOf BtnPlusLife_Click
                End If

                Dim lifeMinusButton = TryCast(LifeTracker.PnlLifeTracker.Controls("BtnMinusLife" & index.ToString), Button)
                If lifeMinusButton IsNot Nothing Then


                    lifeMinusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    Dim newMinusButton As New Button With {
                    .Name = "BtnMinusLife" & index.ToString,
                    .Text = "-",
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Size = New Size(40, 40)
                }


                    LifeTracker.PnlLifeTracker.Controls.Add(newMinusButton)
                    LifeTracker.PnlLifeTracker.SetCellPosition(newMinusButton, New TableLayoutPanelCellPosition(0, index - 1))
                    AddHandler newMinusButton.Click, AddressOf BtnMinusLife_Click
                End If

                Dim lifeLabel = TryCast(LifeTracker.PnlLifeTracker.Controls("LblLife" & index.ToString), Label)
                If lifeLabel IsNot Nothing Then
                    lifeLabel.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    Dim newLifeLabel As New Label With {
                        .Name = "LblLife" & index.ToString,
                        .Text = "40",
                        .Size = New Size(40, 40),
                        .Font = New Font("Engravers, MT", 12, FontStyle.Bold),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                    LifeTracker.PnlLifeTracker.Controls.Add(newLifeLabel)
                    LifeTracker.PnlLifeTracker.SetCellPosition(newLifeLabel, New TableLayoutPanelCellPosition(1, index - 1))
                End If





                'GRAVE TRACKER BUTTONS AND LABELS------------------------------------------------------------------------------------------------------------------------------
                Dim crtrMinusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnMinusCrtr" & index.ToString), Button)
                If crtrMinusButton IsNot Nothing Then
                    'Update button visibility
                    crtrMinusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newMinusButtons As New Button With {
                        .Name = "BtnMinusCrtr" & index.ToString,
                        .Text = "-",
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newMinusButtons)
                    GraveyardTracker.TLPGrave.SetCellPosition(newMinusButtons, New TableLayoutPanelCellPosition(0, index - 1))
                    AddHandler newMinusButtons.Click, AddressOf BtnMinusCrtr_Click
                End If

                Dim crtrPlusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnPlusCrtr" & index.ToString), Button)
                If crtrPlusButton IsNot Nothing Then
                    'Update button visibility
                    crtrPlusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newPlusButtons As New Button With {
                        .Name = "BtnPlusCrtr" & index.ToString,
                        .Text = "+",
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newPlusButtons)
                    GraveyardTracker.TLPGrave.SetCellPosition(newPlusButtons, New TableLayoutPanelCellPosition(2, index - 1))
                    AddHandler newPlusButtons.Click, AddressOf BtnPlusCrtr_Click
                End If

                Dim crtrLabel = TryCast(GraveyardTracker.TLPGrave.Controls("LblCrtr" & index.ToString), Label)
                If crtrLabel IsNot Nothing Then
                    'Update label visibility
                    crtrLabel.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new label based on the number of players selected
                    Dim newCrtrLabel As New Label With {
                        .Name = "LblCrtr" & index.ToString,
                        .Text = "0",
                        .Size = New Size(40, 40),
                        .Font = New Font("Engravers, MT", 12, FontStyle.Bold),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newCrtrLabel)
                    GraveyardTracker.TLPGrave.SetCellPosition(newCrtrLabel, New TableLayoutPanelCellPosition(1, index - 1))
                End If

                Dim totalMinusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnMinusTotal" & index.ToString), Button)
                If totalMinusButton IsNot Nothing Then
                    'Update button visibility
                    totalMinusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newTotalMinusButton As New Button With {
                        .Name = "BtnMinusTotal" & index.ToString,
                        .Text = "-",
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newTotalMinusButton)
                    GraveyardTracker.TLPGrave.SetCellPosition(newTotalMinusButton, New TableLayoutPanelCellPosition(3, index - 1))
                    AddHandler newTotalMinusButton.Click, AddressOf BtnMinusTotal_Click
                End If

                Dim totalPlusButton = TryCast(GraveyardTracker.TLPGrave.Controls("BtnPlusTotal" & index.ToString), Button)
                If totalPlusButton IsNot Nothing Then
                    'Update button visibility
                    totalPlusButton.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new button based on the number of players selected
                    Dim newTotalPlusButton As New Button With {
                        .Name = "BtnPlusTotal" & index.ToString,
                        .Text = "+",
                        .TextAlign = ContentAlignment.MiddleCenter,
                        .Size = New Size(40, 40)
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newTotalPlusButton)
                    GraveyardTracker.TLPGrave.SetCellPosition(newTotalPlusButton, New TableLayoutPanelCellPosition(5, index - 1))
                    AddHandler newTotalPlusButton.Click, AddressOf BtnPlusTotal_Click
                End If

                Dim totalLabel = TryCast(GraveyardTracker.TLPGrave.Controls("LblTotal" & index.ToString), Label)
                If totalLabel IsNot Nothing Then
                    'Update label visibility
                    totalLabel.Visible = index <= currentCount
                ElseIf index = currentCount Then
                    'Create a new label based on the number of players selected
                    Dim newTotalLabel As New Label With {
                        .Name = "LblTotal" & index.ToString,
                        .Text = "0",
                        .Size = New Size(40, 40),
                        .Font = New Font("Engravers, MT", 12, FontStyle.Bold),
                        .TextAlign = ContentAlignment.MiddleCenter
                    }
                    GraveyardTracker.TLPGrave.Controls.Add(newTotalLabel)
                    GraveyardTracker.TLPGrave.SetCellPosition(newTotalLabel, New TableLayoutPanelCellPosition(4, index - 1))
                End If
            Next

            If currentCount < 0 Then
                pCountLbl.Text = 0
                MsgBox(PlayerCountError)

            End If
        End If
    End Sub

    Private Sub GHContinueButton_Click(sender As Object, e As EventArgs) Handles GHContinueButton.Click
        'Attempts to open PlayerNames page for user to enter names of players in their game based on number selected in the NumbBox
        PlayerNames.Show()
        Hide()

    End Sub

    Private Sub GHExitButton_Click(sender As Object, e As EventArgs) Handles GHExitButton.Click
        'Exits application
        Application.Exit()
    End Sub


End Class