<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GHMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        GHDescLabel = New Label()
        GHContinueButton = New Button()
        GHExitButton = New Button()
        PictureBox1 = New PictureBox()
        plusBtn = New Button()
        minusBtn = New Button()
        pCountLbl = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' GHDescLabel
        ' 
        GHDescLabel.AutoSize = True
        GHDescLabel.BorderStyle = BorderStyle.Fixed3D
        GHDescLabel.Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHDescLabel.Location = New Point(41, 306)
        GHDescLabel.Name = "GHDescLabel"
        GHDescLabel.Size = New Size(623, 104)
        GHDescLabel.TabIndex = 3
        GHDescLabel.Text = "Graveyard Tracker" & vbCrLf & vbCrLf & "Select number of players:"
        GHDescLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GHContinueButton
        ' 
        GHContinueButton.BackColor = Color.Black
        GHContinueButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GHContinueButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GHContinueButton.FlatStyle = FlatStyle.Popup
        GHContinueButton.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHContinueButton.ForeColor = Color.Lime
        GHContinueButton.Location = New Point(129, 608)
        GHContinueButton.Name = "GHContinueButton"
        GHContinueButton.Size = New Size(168, 38)
        GHContinueButton.TabIndex = 4
        GHContinueButton.Text = "Continue"
        GHContinueButton.UseVisualStyleBackColor = False
        ' 
        ' GHExitButton
        ' 
        GHExitButton.BackColor = Color.Black
        GHExitButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GHExitButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GHExitButton.FlatStyle = FlatStyle.Popup
        GHExitButton.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHExitButton.ForeColor = Color.Lime
        GHExitButton.Location = New Point(407, 608)
        GHExitButton.Name = "GHExitButton"
        GHExitButton.Size = New Size(168, 38)
        GHExitButton.TabIndex = 5
        GHExitButton.Text = "EXIT"
        GHExitButton.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.gt_icon
        PictureBox1.InitialImage = My.Resources.Resources.gt_icon
        PictureBox1.Location = New Point(224, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(256, 256)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' plusBtn
        ' 
        plusBtn.BackColor = Color.Black
        plusBtn.FlatAppearance.BorderColor = Color.Lime
        plusBtn.FlatAppearance.MouseDownBackColor = Color.DimGray
        plusBtn.FlatAppearance.MouseOverBackColor = Color.Indigo
        plusBtn.FlatStyle = FlatStyle.Popup
        plusBtn.Font = New Font("Engravers MT", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plusBtn.Location = New Point(407, 454)
        plusBtn.Name = "plusBtn"
        plusBtn.Size = New Size(168, 110)
        plusBtn.TabIndex = 9
        plusBtn.Text = "▲"
        plusBtn.UseVisualStyleBackColor = False
        ' 
        ' minusBtn
        ' 
        minusBtn.BackColor = Color.Black
        minusBtn.FlatAppearance.BorderColor = Color.Lime
        minusBtn.FlatAppearance.MouseDownBackColor = Color.DimGray
        minusBtn.FlatAppearance.MouseOverBackColor = Color.Indigo
        minusBtn.FlatStyle = FlatStyle.Popup
        minusBtn.Font = New Font("Engravers MT", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        minusBtn.Location = New Point(129, 454)
        minusBtn.Name = "minusBtn"
        minusBtn.Size = New Size(168, 110)
        minusBtn.TabIndex = 8
        minusBtn.Text = "▼"
        minusBtn.UseVisualStyleBackColor = False
        ' 
        ' pCountLbl
        ' 
        pCountLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pCountLbl.BorderStyle = BorderStyle.Fixed3D
        pCountLbl.Font = New Font("Engravers MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pCountLbl.Location = New Point(310, 487)
        pCountLbl.Name = "pCountLbl"
        pCountLbl.Size = New Size(84, 45)
        pCountLbl.TabIndex = 6
        pCountLbl.Text = "10"
        pCountLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GHMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(704, 681)
        Controls.Add(plusBtn)
        Controls.Add(minusBtn)
        Controls.Add(PictureBox1)
        Controls.Add(pCountLbl)
        Controls.Add(GHExitButton)
        Controls.Add(GHContinueButton)
        Controls.Add(GHDescLabel)
        ForeColor = Color.Lime
        Name = "GHMain"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Graveyard Tracker"
        TransparencyKey = Color.Transparent
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents GHDescLabel As Label
    Friend WithEvents GHContinueButton As Button
    Friend WithEvents GHExitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents plusBtn As Button
    Friend WithEvents minusBtn As Button
    Friend WithEvents pCountLbl As Label
End Class
