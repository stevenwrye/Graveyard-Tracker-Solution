<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LifeTracker1
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
        Life1Lbl = New Label()
        life1minusBtn = New Button()
        life1PlusBtn = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Life1Lbl
        ' 
        Life1Lbl.AutoSize = True
        Life1Lbl.Font = New Font("Engravers MT", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Life1Lbl.Location = New Point(322, 322)
        Life1Lbl.Name = "Life1Lbl"
        Life1Lbl.Size = New Size(61, 37)
        Life1Lbl.TabIndex = 0
        Life1Lbl.Text = "40"
        ' 
        ' life1minusBtn
        ' 
        life1minusBtn.FlatStyle = FlatStyle.Popup
        life1minusBtn.Font = New Font("Engravers MT", 24F, FontStyle.Bold)
        life1minusBtn.Location = New Point(183, 317)
        life1minusBtn.Name = "life1minusBtn"
        life1minusBtn.Size = New Size(75, 47)
        life1minusBtn.TabIndex = 1
        life1minusBtn.Text = "-"
        life1minusBtn.UseVisualStyleBackColor = True
        ' 
        ' life1PlusBtn
        ' 
        life1PlusBtn.FlatStyle = FlatStyle.Popup
        life1PlusBtn.Font = New Font("Engravers MT", 24F, FontStyle.Bold)
        life1PlusBtn.Location = New Point(447, 317)
        life1PlusBtn.Name = "life1PlusBtn"
        life1PlusBtn.Size = New Size(75, 47)
        life1PlusBtn.TabIndex = 2
        life1PlusBtn.Text = "+"
        life1PlusBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Engravers MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(222, 178)
        Label1.Name = "Label1"
        Label1.Size = New Size(260, 43)
        Label1.TabIndex = 3
        Label1.Text = "Player 1"
        ' 
        ' LifeTracker1
        ' 
        AutoScaleDimensions = New SizeF(20F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(704, 681)
        Controls.Add(Label1)
        Controls.Add(life1PlusBtn)
        Controls.Add(life1minusBtn)
        Controls.Add(Life1Lbl)
        Font = New Font("Engravers MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Lime
        Margin = New Padding(9, 5, 9, 5)
        Name = "LifeTracker1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Graveyard Tracker"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Life1Lbl As Label
    Friend WithEvents life1minusBtn As Button
    Friend WithEvents life1PlusBtn As Button
    Friend WithEvents Label1 As Label
End Class
