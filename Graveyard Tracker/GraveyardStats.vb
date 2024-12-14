Imports System.ComponentModel

Public Class GraveyardStats

    Private Sub GraveyardStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim playerCount As Integer = Convert.ToInt32(GHMain.pCountLbl.Text)



        ' Grouping controls into arrays
        Dim creatureMinusButtonsVisible() As Button = {Creature1MinusBtn, creature2MinusBtn, creature3MinusBtn, creature4MinusBtn,
                                     creature5MinusBtn, creature6MinusBtn, creature7MinusBtn, creature8MinusBtn,
                                     creature9MinusBtn, creature10MinusBtn}
        Dim creaturePlusButtonsVisible() As Button = {Creature1PlusBtn, creature2PlusBtn, Creature3PlusBtn, creature4PlusBtn,
                                    creature5PlusBtn, creature6PlusBtn, creature7PlusBtn, creature8PlusBtn,
                                    creature9PlusBtn, creature10PlusBtn}
        Dim totalMinusButtonsVisible() As Button = {total1MinusBtn, total2MinusBtn, total3MinusBtn, total4MinusBtn,
                                    total5MinusBtn, total6MinusBtn, total7MinusBtn, total8MinusBtn,
                                    total9MinusBtn, total10MinusBtn}
        Dim totalPlusButtonsVisible() As Button = {total1PlusBtn, total2PlusBtn, total3PlusBtn, total4PlusBtn,
                                    total5PlusBtn, total6PlusBtn, total7PlusBtn, total8PlusBtn,
                                    total9PlusBtn, total10PlusBtn}
        Dim textboxesVisible() As TextBox = {TextBox1, TextBox2, TextBox3, TextBox4, TextBox5, TextBox6, TextBox7, TextBox8, TextBox9, TextBox10}
        Dim creatureLabelsVisible() As Label = {creatureLbl1, creatureLbl2, creatureLbl3, creatureLbl4, creatureLbl5, creatureLbl6, creatureLbl7, creatureLbl8, creatureLbl9, creatureLbl10}
        Dim totalLabelsVisible() As Label = {totalLbl1, totalLbl2, totalLbl3, totalLbl4, totalLbl5, totalLbl6, totalLbl7, totalLbl8, totalLbl9, totalLbl10}
        Dim creatureMinusButtonsAction() As Button = {Creature1MinusBtn, creature2MinusBtn, creature3MinusBtn, creature4MinusBtn,
                                     creature5MinusBtn, creature6MinusBtn, creature7MinusBtn, creature8MinusBtn,
                                     creature9MinusBtn, creature10MinusBtn}

        ' Iterate through the controls based on player count
        For i As Integer = 0 To creatureMinusButtonsVisible.Length - 1
            Dim visible As Boolean = (i < playerCount) ' Controls are visible if their index is less than player count
            creatureMinusButtonsVisible(i).Visible = visible
            creaturePlusButtonsVisible(i).Visible = visible
            totalMinusButtonsVisible(i).Visible = visible
            totalPlusButtonsVisible(i).Visible = visible
            textboxesVisible(i).Visible = visible
            creatureLabelsVisible(i).Visible = visible
            totalLabelsVisible(i).Visible = visible
        Next



        ' Grouping controls into arrays
        Dim creatureMinusButtons() As Button = {Creature1MinusBtn, creature2MinusBtn, creature3MinusBtn, creature4MinusBtn,
                                                 creature5MinusBtn, creature6MinusBtn, creature7MinusBtn, creature8MinusBtn,
                                                 creature9MinusBtn, creature10MinusBtn}
        Dim creaturePlusButtons() As Button = {Creature1PlusBtn, creature2PlusBtn, Creature3PlusBtn, creature4PlusBtn,
                                                creature5PlusBtn, creature6PlusBtn, creature7PlusBtn, creature8PlusBtn,
                                                creature9PlusBtn, creature10PlusBtn}
        Dim totalMinusButtons() As Button = {total1MinusBtn, total2MinusBtn, total3MinusBtn, total4MinusBtn,
                                              total5MinusBtn, total6MinusBtn, total7MinusBtn, total8MinusBtn,
                                              total9MinusBtn, total10MinusBtn}
        Dim totalPlusButtons() As Button = {total1PlusBtn, total2PlusBtn, total3PlusBtn, total4PlusBtn,
                                             total5PlusBtn, total6PlusBtn, total7PlusBtn, total8PlusBtn,
                                             total9PlusBtn, total10PlusBtn}
        Dim creatureLabels() As Label = {creatureLbl1, creatureLbl2, creatureLbl3, creatureLbl4, creatureLbl5,
                                          creatureLbl6, creatureLbl7, creatureLbl8, creatureLbl9, creatureLbl10}
        Dim totalLabels() As Label = {totalLbl1, totalLbl2, totalLbl3, totalLbl4, totalLbl5, totalLbl6,
                                       totalLbl7, totalLbl8, totalLbl9, totalLbl10}

        ' Assign shared event handlers and set Tag for buttons
        For i As Integer = 0 To playerCount - 1
            creatureMinusButtons(i).Tag = New Tuple(Of Integer, String)(i, "creatureMinus")
            AddHandler creatureMinusButtons(i).Click, AddressOf ButtonClickHandler

            creaturePlusButtons(i).Tag = New Tuple(Of Integer, String)(i, "creaturePlus")
            AddHandler creaturePlusButtons(i).Click, AddressOf ButtonClickHandler

            totalMinusButtons(i).Tag = New Tuple(Of Integer, String)(i, "totalMinus")
            AddHandler totalMinusButtons(i).Click, AddressOf ButtonClickHandler

            totalPlusButtons(i).Tag = New Tuple(Of Integer, String)(i, "totalPlus")
            AddHandler totalPlusButtons(i).Click, AddressOf ButtonClickHandler
        Next

        ' Initialize labels
        For Each lbl As Label In creatureLabels
            lbl.Text = "0"
        Next
        For Each lbl As Label In totalLabels
            lbl.Text = "0"
        Next
    End Sub

    Private Sub ButtonClickHandler(sender As Object, e As EventArgs)
        Dim button As Button = DirectCast(sender, Button)
        Dim tagInfo As Tuple(Of Integer, String) = DirectCast(button.Tag, Tuple(Of Integer, String))
        Dim index As Integer = tagInfo.Item1
        Dim action As String = tagInfo.Item2

        ' Access corresponding labels
        Dim creatureLabels() As Label = {creatureLbl1, creatureLbl2, creatureLbl3, creatureLbl4, creatureLbl5,
                                          creatureLbl6, creatureLbl7, creatureLbl8, creatureLbl9, creatureLbl10}
        Dim totalLabels() As Label = {totalLbl1, totalLbl2, totalLbl3, totalLbl4, totalLbl5, totalLbl6,
                                       totalLbl7, totalLbl8, totalLbl9, totalLbl10}

        Select Case action
            Case "creatureMinus"
                Dim currentValue As Integer = Convert.ToInt32(creatureLabels(index).Text)
                If currentValue > 0 Then
                    creatureLabels(index).Text = (currentValue - 1).ToString()
                End If
            Case "creaturePlus"
                creatureLabels(index).Text = (Convert.ToInt32(creatureLabels(index).Text) + 1).ToString()
            Case "totalMinus"
                Dim currentValue As Integer = Convert.ToInt32(totalLabels(index).Text)
                If currentValue > 0 Then
                    totalLabels(index).Text = (currentValue - 1).ToString()
                End If
            Case "totalPlus"
                totalLabels(index).Text = (Convert.ToInt32(totalLabels(index).Text) + 1).ToString()
        End Select
    End Sub



    Private Sub GSBackButton_Click(sender As Object, e As EventArgs) Handles GSBackButton.Click
        GHMain.Visible = True
        Close()
    End Sub

    Private Sub GSExitButton_Click(sender As Object, e As EventArgs) Handles GSExitButton.Click
        Application.Exit()
    End Sub


End Class