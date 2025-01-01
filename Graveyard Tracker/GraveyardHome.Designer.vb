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
        plusBtn = New Button()
        minusBtn = New Button()
        PictureBox1 = New PictureBox()
        pCountLbl = New Label()
        GHExitButton = New Button()
        GHContinueButton = New Button()
        GHDescLabel = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(20, 20)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' plusBtn
        ' 
        plusBtn.BackColor = Color.Black
        plusBtn.FlatAppearance.BorderColor = Color.Lime
        plusBtn.FlatAppearance.MouseDownBackColor = Color.DimGray
        plusBtn.FlatAppearance.MouseOverBackColor = Color.Indigo
        plusBtn.FlatStyle = FlatStyle.Popup
        plusBtn.Font = New Font("Engravers MT", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plusBtn.Location = New Point(636, 559)
        plusBtn.Name = "plusBtn"
        plusBtn.Size = New Size(168, 110)
        plusBtn.TabIndex = 16
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
        minusBtn.Location = New Point(181, 559)
        minusBtn.Name = "minusBtn"
        minusBtn.Size = New Size(168, 110)
        minusBtn.TabIndex = 15
        minusBtn.Text = "▼"
        minusBtn.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = My.Resources.Resources.gt_icon
        PictureBox1.InitialImage = My.Resources.Resources.gt_icon
        PictureBox1.Location = New Point(376, 118)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(256, 256)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' pCountLbl
        ' 
        pCountLbl.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pCountLbl.BorderStyle = BorderStyle.Fixed3D
        pCountLbl.Font = New Font("Engravers MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pCountLbl.Location = New Point(408, 559)
        pCountLbl.Name = "pCountLbl"
        pCountLbl.Size = New Size(168, 110)
        pCountLbl.TabIndex = 13
        pCountLbl.Text = "0"
        pCountLbl.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' GHExitButton
        ' 
        GHExitButton.BackColor = Color.Black
        GHExitButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GHExitButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GHExitButton.FlatStyle = FlatStyle.Popup
        GHExitButton.Font = New Font("Engravers MT", 13.8F, FontStyle.Bold)
        GHExitButton.ForeColor = Color.Lime
        GHExitButton.Location = New Point(629, 876)
        GHExitButton.Name = "GHExitButton"
        GHExitButton.Size = New Size(175, 38)
        GHExitButton.TabIndex = 12
        GHExitButton.Text = "EXIT"
        GHExitButton.UseVisualStyleBackColor = False
        ' 
        ' GHContinueButton
        ' 
        GHContinueButton.BackColor = Color.Black
        GHContinueButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GHContinueButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GHContinueButton.FlatStyle = FlatStyle.Popup
        GHContinueButton.Font = New Font("Engravers MT", 13.8F, FontStyle.Bold)
        GHContinueButton.ForeColor = Color.Lime
        GHContinueButton.Location = New Point(181, 876)
        GHContinueButton.Name = "GHContinueButton"
        GHContinueButton.Size = New Size(175, 38)
        GHContinueButton.TabIndex = 11
        GHContinueButton.Text = "Continue"
        GHContinueButton.UseVisualStyleBackColor = False
        ' 
        ' GHDescLabel
        ' 
        GHDescLabel.AutoSize = True
        GHDescLabel.BorderStyle = BorderStyle.Fixed3D
        GHDescLabel.Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GHDescLabel.Location = New Point(181, 377)
        GHDescLabel.Name = "GHDescLabel"
        GHDescLabel.Size = New Size(623, 104)
        GHDescLabel.TabIndex = 10
        GHDescLabel.Text = "Graveyard Tracker" & vbCrLf & vbCrLf & "Select number of players:"
        GHDescLabel.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GHMain
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Desktop
        ClientSize = New Size(984, 961)
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
    Friend WithEvents plusBtn As Button
    Friend WithEvents minusBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pCountLbl As Label
    Friend WithEvents GHExitButton As Button
    Friend WithEvents GHContinueButton As Button
    Friend WithEvents GHDescLabel As Label
End Class
