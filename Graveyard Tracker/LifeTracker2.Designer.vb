<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LifeTracker2
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
        SuspendLayout()
        ' 
        ' LifeTracker2
        ' 
        AutoScaleDimensions = New SizeF(18F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(704, 681)
        Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Lime
        Margin = New Padding(8, 4, 8, 4)
        Name = "LifeTracker2"
        StartPosition = FormStartPosition.CenterParent
        Text = "Graveyard Tracker"
        ResumeLayout(False)
    End Sub
End Class
