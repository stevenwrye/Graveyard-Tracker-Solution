<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LifeTracker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LblPlayerHead = New Label()
        LblPlayer10 = New Label()
        LblPlayer2 = New Label()
        LblPlayer3 = New Label()
        LblPlayer4 = New Label()
        LblPlayer5 = New Label()
        LblPlayer6 = New Label()
        LblPlayer7 = New Label()
        LblPlayer8 = New Label()
        LblPlayer9 = New Label()
        LblPlayer1 = New Label()
        PnlLifeTracker = New TableLayoutPanel()
        GSExitButton = New Button()
        GSBackButton = New Button()
        BtnGrave = New Button()
        BtnResetLife = New Button()
        btnCommanderLife = New Button()
        btnStandardLife = New Button()
        SuspendLayout()
        ' 
        ' LblPlayerHead
        ' 
        LblPlayerHead.AutoSize = True
        LblPlayerHead.Location = New Point(290, 144)
        LblPlayerHead.Name = "LblPlayerHead"
        LblPlayerHead.Size = New Size(140, 25)
        LblPlayerHead.TabIndex = 10
        LblPlayerHead.Text = "Player:"
        LblPlayerHead.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LblPlayer10
        ' 
        LblPlayer10.Location = New Point(230, 544)
        LblPlayer10.Name = "LblPlayer10"
        LblPlayer10.Size = New Size(260, 41)
        LblPlayer10.TabIndex = 9
        LblPlayer10.Text = "Player 10"
        LblPlayer10.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer10.Visible = False
        ' 
        ' LblPlayer2
        ' 
        LblPlayer2.Location = New Point(230, 216)
        LblPlayer2.Name = "LblPlayer2"
        LblPlayer2.Size = New Size(260, 41)
        LblPlayer2.TabIndex = 1
        LblPlayer2.Text = "Player 2"
        LblPlayer2.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer2.Visible = False
        ' 
        ' LblPlayer3
        ' 
        LblPlayer3.Location = New Point(230, 257)
        LblPlayer3.Name = "LblPlayer3"
        LblPlayer3.Size = New Size(260, 41)
        LblPlayer3.TabIndex = 2
        LblPlayer3.Text = "Player 3"
        LblPlayer3.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer3.Visible = False
        ' 
        ' LblPlayer4
        ' 
        LblPlayer4.Location = New Point(230, 298)
        LblPlayer4.Name = "LblPlayer4"
        LblPlayer4.Size = New Size(260, 41)
        LblPlayer4.TabIndex = 3
        LblPlayer4.Text = "Player 4"
        LblPlayer4.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer4.Visible = False
        ' 
        ' LblPlayer5
        ' 
        LblPlayer5.Location = New Point(230, 339)
        LblPlayer5.Name = "LblPlayer5"
        LblPlayer5.Size = New Size(260, 41)
        LblPlayer5.TabIndex = 4
        LblPlayer5.Text = "Player 5"
        LblPlayer5.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer5.Visible = False
        ' 
        ' LblPlayer6
        ' 
        LblPlayer6.Location = New Point(230, 380)
        LblPlayer6.Name = "LblPlayer6"
        LblPlayer6.Size = New Size(260, 41)
        LblPlayer6.TabIndex = 5
        LblPlayer6.Text = "Player 6"
        LblPlayer6.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer6.Visible = False
        ' 
        ' LblPlayer7
        ' 
        LblPlayer7.Location = New Point(230, 421)
        LblPlayer7.Name = "LblPlayer7"
        LblPlayer7.Size = New Size(260, 41)
        LblPlayer7.TabIndex = 6
        LblPlayer7.Text = "Player 7"
        LblPlayer7.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer7.Visible = False
        ' 
        ' LblPlayer8
        ' 
        LblPlayer8.Location = New Point(230, 462)
        LblPlayer8.Name = "LblPlayer8"
        LblPlayer8.Size = New Size(260, 41)
        LblPlayer8.TabIndex = 7
        LblPlayer8.Text = "Player 8"
        LblPlayer8.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer8.Visible = False
        ' 
        ' LblPlayer9
        ' 
        LblPlayer9.Location = New Point(230, 503)
        LblPlayer9.Name = "LblPlayer9"
        LblPlayer9.Size = New Size(260, 41)
        LblPlayer9.TabIndex = 8
        LblPlayer9.Text = "Player 9"
        LblPlayer9.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer9.Visible = False
        ' 
        ' LblPlayer1
        ' 
        LblPlayer1.Location = New Point(230, 175)
        LblPlayer1.Name = "LblPlayer1"
        LblPlayer1.Size = New Size(260, 41)
        LblPlayer1.TabIndex = 0
        LblPlayer1.Text = "Player 1"
        LblPlayer1.TextAlign = ContentAlignment.MiddleCenter
        LblPlayer1.Visible = False
        ' 
        ' PnlLifeTracker
        ' 
        PnlLifeTracker.ColumnCount = 3
        PnlLifeTracker.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        PnlLifeTracker.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        PnlLifeTracker.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        PnlLifeTracker.Location = New Point(498, 175)
        PnlLifeTracker.Name = "PnlLifeTracker"
        PnlLifeTracker.RowCount = 10
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        PnlLifeTracker.Size = New Size(280, 410)
        PnlLifeTracker.TabIndex = 11
        ' 
        ' GSExitButton
        ' 
        GSExitButton.BackColor = Color.Transparent
        GSExitButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GSExitButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GSExitButton.FlatStyle = FlatStyle.Popup
        GSExitButton.Font = New Font("Engravers MT", 13.8F, FontStyle.Bold)
        GSExitButton.ForeColor = Color.Lime
        GSExitButton.Location = New Point(689, 829)
        GSExitButton.Margin = New Padding(2)
        GSExitButton.Name = "GSExitButton"
        GSExitButton.Size = New Size(200, 50)
        GSExitButton.TabIndex = 39
        GSExitButton.Text = "Exit"
        GSExitButton.UseVisualStyleBackColor = False
        ' 
        ' GSBackButton
        ' 
        GSBackButton.BackColor = Color.Transparent
        GSBackButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GSBackButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GSBackButton.FlatStyle = FlatStyle.Popup
        GSBackButton.Font = New Font("Engravers MT", 13.8F, FontStyle.Bold)
        GSBackButton.ForeColor = Color.Lime
        GSBackButton.Location = New Point(93, 829)
        GSBackButton.Margin = New Padding(2)
        GSBackButton.Name = "GSBackButton"
        GSBackButton.Size = New Size(200, 50)
        GSBackButton.TabIndex = 38
        GSBackButton.Text = "Back"
        GSBackButton.UseVisualStyleBackColor = False
        ' 
        ' BtnGrave
        ' 
        BtnGrave.FlatStyle = FlatStyle.Popup
        BtnGrave.Font = New Font("Engravers MT", 13.8F, FontStyle.Bold)
        BtnGrave.Location = New Point(391, 829)
        BtnGrave.Name = "BtnGrave"
        BtnGrave.Size = New Size(200, 50)
        BtnGrave.TabIndex = 40
        BtnGrave.Text = "GRAVE"
        BtnGrave.UseVisualStyleBackColor = True
        ' 
        ' BtnResetLife
        ' 
        BtnResetLife.FlatStyle = FlatStyle.Popup
        BtnResetLife.Location = New Point(538, 119)
        BtnResetLife.Name = "BtnResetLife"
        BtnResetLife.Size = New Size(200, 50)
        BtnResetLife.TabIndex = 41
        BtnResetLife.Text = "RESET LIFE"
        BtnResetLife.UseVisualStyleBackColor = True
        ' 
        ' btnCommanderLife
        ' 
        btnCommanderLife.FlatStyle = FlatStyle.Popup
        btnCommanderLife.Location = New Point(391, 28)
        btnCommanderLife.Name = "btnCommanderLife"
        btnCommanderLife.Size = New Size(211, 50)
        btnCommanderLife.TabIndex = 42
        btnCommanderLife.Text = "COMMANDER"
        btnCommanderLife.UseVisualStyleBackColor = True
        ' 
        ' btnStandardLife
        ' 
        btnStandardLife.FlatStyle = FlatStyle.Popup
        btnStandardLife.Location = New Point(689, 28)
        btnStandardLife.Name = "btnStandardLife"
        btnStandardLife.Size = New Size(200, 50)
        btnStandardLife.TabIndex = 43
        btnStandardLife.Text = "STANDARD"
        btnStandardLife.UseVisualStyleBackColor = True
        ' 
        ' LifeTracker
        ' 
        AutoScaleDimensions = New SizeF(20F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(982, 953)
        Controls.Add(btnStandardLife)
        Controls.Add(btnCommanderLife)
        Controls.Add(BtnResetLife)
        Controls.Add(BtnGrave)
        Controls.Add(GSExitButton)
        Controls.Add(GSBackButton)
        Controls.Add(PnlLifeTracker)
        Controls.Add(LblPlayerHead)
        Controls.Add(LblPlayer10)
        Controls.Add(LblPlayer9)
        Controls.Add(LblPlayer8)
        Controls.Add(LblPlayer7)
        Controls.Add(LblPlayer6)
        Controls.Add(LblPlayer5)
        Controls.Add(LblPlayer4)
        Controls.Add(LblPlayer3)
        Controls.Add(LblPlayer2)
        Controls.Add(LblPlayer1)
        Font = New Font("Engravers MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Lime
        Margin = New Padding(9, 5, 9, 5)
        Name = "LifeTracker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Graveyard Tracker"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Public WithEvents LblPlayerHead As Label
    Public WithEvents GSExitButton As Button
    Public WithEvents GSBackButton As Button
    Public WithEvents BtnGrave As Button
    Public WithEvents LblPlayer1 As Label
    Public WithEvents LblPlayer2 As Label
    Public WithEvents LblPlayer3 As Label
    Public WithEvents LblPlayer4 As Label
    Public WithEvents LblPlayer5 As Label
    Public WithEvents LblPlayer6 As Label
    Public WithEvents LblPlayer7 As Label
    Public WithEvents LblPlayer8 As Label
    Public WithEvents LblPlayer9 As Label
    Public WithEvents LblPlayer10 As Label
    Friend WithEvents BtnResetLife As Button
    Friend WithEvents btnCommanderLife As Button
    Friend WithEvents btnStandardLife As Button
    Friend WithEvents PnlLifeTracker As TableLayoutPanel
End Class
