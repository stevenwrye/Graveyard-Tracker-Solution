<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraveyardStats
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
        GSBackButton = New Button()
        GSExitButton = New Button()
        GSCheckedList = New CheckedListBox()
        GSPNLabel = New Label()
        GSCreaturesLabel = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        Creature1MinusBtn = New Button()
        Creature1PlusBtn = New Button()
        creatureLbl1 = New Label()
        creatureLbl2 = New Label()
        creature2PlusBtn = New Button()
        creature2MinusBtn = New Button()
        creatureLbl3 = New Label()
        Creature3PlusBtn = New Button()
        creature3MinusBtn = New Button()
        creatureLbl4 = New Label()
        creature4PlusBtn = New Button()
        creature4MinusBtn = New Button()
        creatureLbl5 = New Label()
        creature5PlusBtn = New Button()
        creature5MinusBtn = New Button()
        creatureLbl6 = New Label()
        creature6PlusBtn = New Button()
        creature6MinusBtn = New Button()
        creatureLbl7 = New Label()
        creature7PlusBtn = New Button()
        creature7MinusBtn = New Button()
        creatureLbl8 = New Label()
        creature8PlusBtn = New Button()
        creature8MinusBtn = New Button()
        creatureLbl9 = New Label()
        creature9PlusBtn = New Button()
        creature9MinusBtn = New Button()
        creatureLbl10 = New Label()
        creature10PlusBtn = New Button()
        creature10MinusBtn = New Button()
        totalLbl10 = New Label()
        total10PlusBtn = New Button()
        total10MinusBtn = New Button()
        totalLbl9 = New Label()
        total9PlusBtn = New Button()
        total9MinusBtn = New Button()
        totalLbl8 = New Label()
        total8PlusBtn = New Button()
        total8MinusBtn = New Button()
        totalLbl7 = New Label()
        total7PlusBtn = New Button()
        total7MinusBtn = New Button()
        totalLbl6 = New Label()
        total6PlusBtn = New Button()
        total6MinusBtn = New Button()
        totalLbl5 = New Label()
        total5PlusBtn = New Button()
        total5MinusBtn = New Button()
        totalLbl4 = New Label()
        total4PlusBtn = New Button()
        total4MinusBtn = New Button()
        totalLbl3 = New Label()
        total3PlusBtn = New Button()
        total3MinusBtn = New Button()
        totalLbl2 = New Label()
        total2PlusBtn = New Button()
        total2MinusBtn = New Button()
        totalLbl1 = New Label()
        total1PlusBtn = New Button()
        total1MinusBtn = New Button()
        SuspendLayout()
        ' 
        ' GSBackButton
        ' 
        GSBackButton.BackColor = Color.Transparent
        GSBackButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GSBackButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GSBackButton.FlatStyle = FlatStyle.Popup
        GSBackButton.ForeColor = Color.Lime
        GSBackButton.Location = New Point(150, 607)
        GSBackButton.Margin = New Padding(2)
        GSBackButton.Name = "GSBackButton"
        GSBackButton.Size = New Size(135, 45)
        GSBackButton.TabIndex = 0
        GSBackButton.Text = "Back"
        GSBackButton.UseVisualStyleBackColor = False
        ' 
        ' GSExitButton
        ' 
        GSExitButton.BackColor = Color.Transparent
        GSExitButton.FlatAppearance.MouseDownBackColor = Color.DimGray
        GSExitButton.FlatAppearance.MouseOverBackColor = Color.Indigo
        GSExitButton.FlatStyle = FlatStyle.Popup
        GSExitButton.ForeColor = Color.Lime
        GSExitButton.Location = New Point(465, 607)
        GSExitButton.Margin = New Padding(2)
        GSExitButton.Name = "GSExitButton"
        GSExitButton.Size = New Size(123, 45)
        GSExitButton.TabIndex = 1
        GSExitButton.Text = "Exit"
        GSExitButton.UseVisualStyleBackColor = False
        ' 
        ' GSCheckedList
        ' 
        GSCheckedList.Anchor = AnchorStyles.None
        GSCheckedList.BackColor = Color.Black
        GSCheckedList.CheckOnClick = True
        GSCheckedList.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GSCheckedList.ForeColor = Color.Lime
        GSCheckedList.FormattingEnabled = True
        GSCheckedList.Items.AddRange(New Object() {"Artifact", "Battle", "Creature", "Enchantment", "Instant", "Land", "Planeswalker", "Sorcery"})
        GSCheckedList.Location = New Point(243, 385)
        GSCheckedList.Margin = New Padding(2)
        GSCheckedList.Name = "GSCheckedList"
        GSCheckedList.Size = New Size(259, 179)
        GSCheckedList.TabIndex = 2
        GSCheckedList.ThreeDCheckBoxes = True
        ' 
        ' GSPNLabel
        ' 
        GSPNLabel.AutoSize = True
        GSPNLabel.BorderStyle = BorderStyle.Fixed3D
        GSPNLabel.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        GSPNLabel.Location = New Point(52, 9)
        GSPNLabel.Margin = New Padding(2, 0, 2, 0)
        GSPNLabel.Name = "GSPNLabel"
        GSPNLabel.Size = New Size(185, 27)
        GSPNLabel.TabIndex = 4
        GSPNLabel.Text = "Opponent:"
        ' 
        ' GSCreaturesLabel
        ' 
        GSCreaturesLabel.AutoSize = True
        GSCreaturesLabel.BorderStyle = BorderStyle.Fixed3D
        GSCreaturesLabel.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        GSCreaturesLabel.Location = New Point(268, 9)
        GSCreaturesLabel.Margin = New Padding(2, 0, 2, 0)
        GSCreaturesLabel.Name = "GSCreaturesLabel"
        GSCreaturesLabel.Size = New Size(200, 27)
        GSCreaturesLabel.TabIndex = 5
        GSCreaturesLabel.Text = "Creatures:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Engravers MT", 15.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(519, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 27)
        Label1.TabIndex = 6
        Label1.Text = "Total:"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.Indigo
        TextBox1.BorderStyle = BorderStyle.FixedSingle
        TextBox1.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        TextBox1.ForeColor = Color.Lime
        TextBox1.Location = New Point(41, 39)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(208, 30)
        TextBox1.TabIndex = 26
        TextBox1.Visible = False
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.DimGray
        TextBox2.BorderStyle = BorderStyle.FixedSingle
        TextBox2.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        TextBox2.ForeColor = Color.Lime
        TextBox2.Location = New Point(41, 72)
        TextBox2.Margin = New Padding(2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(208, 30)
        TextBox2.TabIndex = 27
        TextBox2.Visible = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.Indigo
        TextBox3.BorderStyle = BorderStyle.FixedSingle
        TextBox3.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox3.ForeColor = Color.Lime
        TextBox3.Location = New Point(41, 105)
        TextBox3.Margin = New Padding(2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(208, 30)
        TextBox3.TabIndex = 28
        TextBox3.Visible = False
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.DimGray
        TextBox4.BorderStyle = BorderStyle.FixedSingle
        TextBox4.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox4.ForeColor = Color.Lime
        TextBox4.Location = New Point(41, 138)
        TextBox4.Margin = New Padding(2)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(208, 30)
        TextBox4.TabIndex = 29
        TextBox4.Visible = False
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.Indigo
        TextBox5.BorderStyle = BorderStyle.FixedSingle
        TextBox5.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox5.ForeColor = Color.Lime
        TextBox5.Location = New Point(41, 171)
        TextBox5.Margin = New Padding(2)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(208, 30)
        TextBox5.TabIndex = 30
        TextBox5.Visible = False
        ' 
        ' TextBox6
        ' 
        TextBox6.BackColor = Color.DimGray
        TextBox6.BorderStyle = BorderStyle.FixedSingle
        TextBox6.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox6.ForeColor = Color.Lime
        TextBox6.Location = New Point(41, 204)
        TextBox6.Margin = New Padding(2)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(208, 30)
        TextBox6.TabIndex = 31
        TextBox6.Visible = False
        ' 
        ' TextBox7
        ' 
        TextBox7.BackColor = Color.Indigo
        TextBox7.BorderStyle = BorderStyle.FixedSingle
        TextBox7.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox7.ForeColor = Color.Lime
        TextBox7.Location = New Point(41, 237)
        TextBox7.Margin = New Padding(2)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(208, 30)
        TextBox7.TabIndex = 32
        TextBox7.Visible = False
        ' 
        ' TextBox8
        ' 
        TextBox8.BackColor = Color.DimGray
        TextBox8.BorderStyle = BorderStyle.FixedSingle
        TextBox8.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox8.ForeColor = Color.Lime
        TextBox8.Location = New Point(41, 270)
        TextBox8.Margin = New Padding(2)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(208, 30)
        TextBox8.TabIndex = 33
        TextBox8.Visible = False
        ' 
        ' TextBox9
        ' 
        TextBox9.BackColor = Color.Indigo
        TextBox9.BorderStyle = BorderStyle.FixedSingle
        TextBox9.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox9.ForeColor = Color.Lime
        TextBox9.Location = New Point(41, 303)
        TextBox9.Margin = New Padding(2)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(208, 30)
        TextBox9.TabIndex = 34
        TextBox9.Visible = False
        ' 
        ' TextBox10
        ' 
        TextBox10.BackColor = Color.DimGray
        TextBox10.BorderStyle = BorderStyle.FixedSingle
        TextBox10.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox10.ForeColor = Color.Lime
        TextBox10.Location = New Point(41, 336)
        TextBox10.Margin = New Padding(2)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(208, 30)
        TextBox10.TabIndex = 35
        TextBox10.Visible = False
        ' 
        ' Creature1MinusBtn
        ' 
        Creature1MinusBtn.BackColor = Color.Indigo
        Creature1MinusBtn.FlatStyle = FlatStyle.Popup
        Creature1MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        Creature1MinusBtn.Location = New Point(278, 37)
        Creature1MinusBtn.Margin = New Padding(2)
        Creature1MinusBtn.Name = "Creature1MinusBtn"
        Creature1MinusBtn.Size = New Size(58, 32)
        Creature1MinusBtn.TabIndex = 36
        Creature1MinusBtn.Text = "▼"
        Creature1MinusBtn.UseVisualStyleBackColor = False
        Creature1MinusBtn.Visible = False
        ' 
        ' Creature1PlusBtn
        ' 
        Creature1PlusBtn.BackColor = Color.Indigo
        Creature1PlusBtn.FlatStyle = FlatStyle.Popup
        Creature1PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        Creature1PlusBtn.Location = New Point(399, 37)
        Creature1PlusBtn.Margin = New Padding(2)
        Creature1PlusBtn.Name = "Creature1PlusBtn"
        Creature1PlusBtn.Size = New Size(58, 32)
        Creature1PlusBtn.TabIndex = 37
        Creature1PlusBtn.Text = "▲"
        Creature1PlusBtn.UseVisualStyleBackColor = False
        Creature1PlusBtn.Visible = False
        ' 
        ' creatureLbl1
        ' 
        creatureLbl1.BackColor = Color.Indigo
        creatureLbl1.FlatStyle = FlatStyle.Popup
        creatureLbl1.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl1.Location = New Point(337, 37)
        creatureLbl1.Margin = New Padding(2, 0, 2, 0)
        creatureLbl1.Name = "creatureLbl1"
        creatureLbl1.Size = New Size(58, 32)
        creatureLbl1.TabIndex = 38
        creatureLbl1.Text = "0"
        creatureLbl1.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl1.Visible = False
        ' 
        ' creatureLbl2
        ' 
        creatureLbl2.BackColor = Color.DimGray
        creatureLbl2.FlatStyle = FlatStyle.Popup
        creatureLbl2.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl2.Location = New Point(337, 70)
        creatureLbl2.Margin = New Padding(2, 0, 2, 0)
        creatureLbl2.Name = "creatureLbl2"
        creatureLbl2.Size = New Size(58, 32)
        creatureLbl2.TabIndex = 41
        creatureLbl2.Text = "0"
        creatureLbl2.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl2.Visible = False
        ' 
        ' creature2PlusBtn
        ' 
        creature2PlusBtn.BackColor = Color.DimGray
        creature2PlusBtn.FlatStyle = FlatStyle.Popup
        creature2PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature2PlusBtn.Location = New Point(399, 70)
        creature2PlusBtn.Margin = New Padding(2)
        creature2PlusBtn.Name = "creature2PlusBtn"
        creature2PlusBtn.Size = New Size(58, 32)
        creature2PlusBtn.TabIndex = 40
        creature2PlusBtn.Text = "▲"
        creature2PlusBtn.UseVisualStyleBackColor = False
        creature2PlusBtn.Visible = False
        ' 
        ' creature2MinusBtn
        ' 
        creature2MinusBtn.BackColor = Color.DimGray
        creature2MinusBtn.FlatStyle = FlatStyle.Popup
        creature2MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature2MinusBtn.Location = New Point(278, 70)
        creature2MinusBtn.Margin = New Padding(2)
        creature2MinusBtn.Name = "creature2MinusBtn"
        creature2MinusBtn.Size = New Size(58, 32)
        creature2MinusBtn.TabIndex = 39
        creature2MinusBtn.Text = "▼"
        creature2MinusBtn.UseVisualStyleBackColor = False
        creature2MinusBtn.Visible = False
        ' 
        ' creatureLbl3
        ' 
        creatureLbl3.BackColor = Color.Indigo
        creatureLbl3.FlatStyle = FlatStyle.Popup
        creatureLbl3.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl3.Location = New Point(337, 103)
        creatureLbl3.Margin = New Padding(2, 0, 2, 0)
        creatureLbl3.Name = "creatureLbl3"
        creatureLbl3.Size = New Size(58, 32)
        creatureLbl3.TabIndex = 44
        creatureLbl3.Text = "0"
        creatureLbl3.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl3.Visible = False
        ' 
        ' Creature3PlusBtn
        ' 
        Creature3PlusBtn.BackColor = Color.Indigo
        Creature3PlusBtn.FlatStyle = FlatStyle.Popup
        Creature3PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        Creature3PlusBtn.Location = New Point(399, 103)
        Creature3PlusBtn.Margin = New Padding(2)
        Creature3PlusBtn.Name = "Creature3PlusBtn"
        Creature3PlusBtn.Size = New Size(58, 32)
        Creature3PlusBtn.TabIndex = 43
        Creature3PlusBtn.Text = "▲"
        Creature3PlusBtn.UseVisualStyleBackColor = False
        Creature3PlusBtn.Visible = False
        ' 
        ' creature3MinusBtn
        ' 
        creature3MinusBtn.BackColor = Color.Indigo
        creature3MinusBtn.FlatStyle = FlatStyle.Popup
        creature3MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature3MinusBtn.Location = New Point(278, 103)
        creature3MinusBtn.Margin = New Padding(2)
        creature3MinusBtn.Name = "creature3MinusBtn"
        creature3MinusBtn.Size = New Size(58, 32)
        creature3MinusBtn.TabIndex = 42
        creature3MinusBtn.Text = "▼"
        creature3MinusBtn.UseVisualStyleBackColor = False
        creature3MinusBtn.Visible = False
        ' 
        ' creatureLbl4
        ' 
        creatureLbl4.BackColor = Color.DimGray
        creatureLbl4.FlatStyle = FlatStyle.Popup
        creatureLbl4.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl4.Location = New Point(337, 136)
        creatureLbl4.Margin = New Padding(2, 0, 2, 0)
        creatureLbl4.Name = "creatureLbl4"
        creatureLbl4.Size = New Size(58, 32)
        creatureLbl4.TabIndex = 47
        creatureLbl4.Text = "0"
        creatureLbl4.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl4.Visible = False
        ' 
        ' creature4PlusBtn
        ' 
        creature4PlusBtn.BackColor = Color.DimGray
        creature4PlusBtn.FlatStyle = FlatStyle.Popup
        creature4PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature4PlusBtn.Location = New Point(399, 136)
        creature4PlusBtn.Margin = New Padding(2)
        creature4PlusBtn.Name = "creature4PlusBtn"
        creature4PlusBtn.Size = New Size(58, 32)
        creature4PlusBtn.TabIndex = 46
        creature4PlusBtn.Text = "▲"
        creature4PlusBtn.UseVisualStyleBackColor = False
        creature4PlusBtn.Visible = False
        ' 
        ' creature4MinusBtn
        ' 
        creature4MinusBtn.BackColor = Color.DimGray
        creature4MinusBtn.FlatStyle = FlatStyle.Popup
        creature4MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature4MinusBtn.Location = New Point(278, 136)
        creature4MinusBtn.Margin = New Padding(2)
        creature4MinusBtn.Name = "creature4MinusBtn"
        creature4MinusBtn.Size = New Size(58, 32)
        creature4MinusBtn.TabIndex = 45
        creature4MinusBtn.Text = "▼"
        creature4MinusBtn.UseVisualStyleBackColor = False
        creature4MinusBtn.Visible = False
        ' 
        ' creatureLbl5
        ' 
        creatureLbl5.BackColor = Color.Indigo
        creatureLbl5.FlatStyle = FlatStyle.Popup
        creatureLbl5.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl5.Location = New Point(337, 169)
        creatureLbl5.Margin = New Padding(2, 0, 2, 0)
        creatureLbl5.Name = "creatureLbl5"
        creatureLbl5.Size = New Size(58, 32)
        creatureLbl5.TabIndex = 50
        creatureLbl5.Text = "0"
        creatureLbl5.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl5.Visible = False
        ' 
        ' creature5PlusBtn
        ' 
        creature5PlusBtn.BackColor = Color.Indigo
        creature5PlusBtn.FlatStyle = FlatStyle.Popup
        creature5PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature5PlusBtn.Location = New Point(399, 169)
        creature5PlusBtn.Margin = New Padding(2)
        creature5PlusBtn.Name = "creature5PlusBtn"
        creature5PlusBtn.Size = New Size(58, 32)
        creature5PlusBtn.TabIndex = 49
        creature5PlusBtn.Text = "▲"
        creature5PlusBtn.UseVisualStyleBackColor = False
        creature5PlusBtn.Visible = False
        ' 
        ' creature5MinusBtn
        ' 
        creature5MinusBtn.BackColor = Color.Indigo
        creature5MinusBtn.FlatStyle = FlatStyle.Popup
        creature5MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature5MinusBtn.Location = New Point(278, 169)
        creature5MinusBtn.Margin = New Padding(2)
        creature5MinusBtn.Name = "creature5MinusBtn"
        creature5MinusBtn.Size = New Size(58, 32)
        creature5MinusBtn.TabIndex = 48
        creature5MinusBtn.Text = "▼"
        creature5MinusBtn.UseVisualStyleBackColor = False
        creature5MinusBtn.Visible = False
        ' 
        ' creatureLbl6
        ' 
        creatureLbl6.BackColor = Color.DimGray
        creatureLbl6.FlatStyle = FlatStyle.Popup
        creatureLbl6.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl6.Location = New Point(337, 202)
        creatureLbl6.Margin = New Padding(2, 0, 2, 0)
        creatureLbl6.Name = "creatureLbl6"
        creatureLbl6.Size = New Size(58, 32)
        creatureLbl6.TabIndex = 53
        creatureLbl6.Text = "0"
        creatureLbl6.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl6.Visible = False
        ' 
        ' creature6PlusBtn
        ' 
        creature6PlusBtn.BackColor = Color.DimGray
        creature6PlusBtn.FlatStyle = FlatStyle.Popup
        creature6PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature6PlusBtn.Location = New Point(399, 202)
        creature6PlusBtn.Margin = New Padding(2)
        creature6PlusBtn.Name = "creature6PlusBtn"
        creature6PlusBtn.Size = New Size(58, 32)
        creature6PlusBtn.TabIndex = 52
        creature6PlusBtn.Text = "▲"
        creature6PlusBtn.UseVisualStyleBackColor = False
        creature6PlusBtn.Visible = False
        ' 
        ' creature6MinusBtn
        ' 
        creature6MinusBtn.BackColor = Color.DimGray
        creature6MinusBtn.FlatStyle = FlatStyle.Popup
        creature6MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature6MinusBtn.Location = New Point(278, 202)
        creature6MinusBtn.Margin = New Padding(2)
        creature6MinusBtn.Name = "creature6MinusBtn"
        creature6MinusBtn.Size = New Size(58, 32)
        creature6MinusBtn.TabIndex = 51
        creature6MinusBtn.Text = "▼"
        creature6MinusBtn.UseVisualStyleBackColor = False
        creature6MinusBtn.Visible = False
        ' 
        ' creatureLbl7
        ' 
        creatureLbl7.BackColor = Color.Indigo
        creatureLbl7.FlatStyle = FlatStyle.Popup
        creatureLbl7.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl7.Location = New Point(337, 235)
        creatureLbl7.Margin = New Padding(2, 0, 2, 0)
        creatureLbl7.Name = "creatureLbl7"
        creatureLbl7.Size = New Size(58, 32)
        creatureLbl7.TabIndex = 56
        creatureLbl7.Text = "0"
        creatureLbl7.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl7.Visible = False
        ' 
        ' creature7PlusBtn
        ' 
        creature7PlusBtn.BackColor = Color.Indigo
        creature7PlusBtn.FlatStyle = FlatStyle.Popup
        creature7PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature7PlusBtn.Location = New Point(399, 235)
        creature7PlusBtn.Margin = New Padding(2)
        creature7PlusBtn.Name = "creature7PlusBtn"
        creature7PlusBtn.Size = New Size(58, 32)
        creature7PlusBtn.TabIndex = 55
        creature7PlusBtn.Text = "▲"
        creature7PlusBtn.UseVisualStyleBackColor = False
        creature7PlusBtn.Visible = False
        ' 
        ' creature7MinusBtn
        ' 
        creature7MinusBtn.BackColor = Color.Indigo
        creature7MinusBtn.FlatStyle = FlatStyle.Popup
        creature7MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature7MinusBtn.Location = New Point(278, 235)
        creature7MinusBtn.Margin = New Padding(2)
        creature7MinusBtn.Name = "creature7MinusBtn"
        creature7MinusBtn.Size = New Size(58, 32)
        creature7MinusBtn.TabIndex = 54
        creature7MinusBtn.Text = "▼"
        creature7MinusBtn.UseVisualStyleBackColor = False
        creature7MinusBtn.Visible = False
        ' 
        ' creatureLbl8
        ' 
        creatureLbl8.BackColor = Color.DimGray
        creatureLbl8.FlatStyle = FlatStyle.Popup
        creatureLbl8.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl8.Location = New Point(337, 268)
        creatureLbl8.Margin = New Padding(2, 0, 2, 0)
        creatureLbl8.Name = "creatureLbl8"
        creatureLbl8.Size = New Size(58, 32)
        creatureLbl8.TabIndex = 59
        creatureLbl8.Text = "0"
        creatureLbl8.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl8.Visible = False
        ' 
        ' creature8PlusBtn
        ' 
        creature8PlusBtn.BackColor = Color.DimGray
        creature8PlusBtn.FlatStyle = FlatStyle.Popup
        creature8PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature8PlusBtn.Location = New Point(399, 268)
        creature8PlusBtn.Margin = New Padding(2)
        creature8PlusBtn.Name = "creature8PlusBtn"
        creature8PlusBtn.Size = New Size(58, 32)
        creature8PlusBtn.TabIndex = 58
        creature8PlusBtn.Text = "▲"
        creature8PlusBtn.UseVisualStyleBackColor = False
        creature8PlusBtn.Visible = False
        ' 
        ' creature8MinusBtn
        ' 
        creature8MinusBtn.BackColor = Color.DimGray
        creature8MinusBtn.FlatStyle = FlatStyle.Popup
        creature8MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature8MinusBtn.Location = New Point(278, 268)
        creature8MinusBtn.Margin = New Padding(2)
        creature8MinusBtn.Name = "creature8MinusBtn"
        creature8MinusBtn.Size = New Size(58, 32)
        creature8MinusBtn.TabIndex = 57
        creature8MinusBtn.Text = "▼"
        creature8MinusBtn.UseVisualStyleBackColor = False
        creature8MinusBtn.Visible = False
        ' 
        ' creatureLbl9
        ' 
        creatureLbl9.BackColor = Color.Indigo
        creatureLbl9.FlatStyle = FlatStyle.Popup
        creatureLbl9.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl9.Location = New Point(337, 301)
        creatureLbl9.Margin = New Padding(2, 0, 2, 0)
        creatureLbl9.Name = "creatureLbl9"
        creatureLbl9.Size = New Size(58, 32)
        creatureLbl9.TabIndex = 62
        creatureLbl9.Text = "0"
        creatureLbl9.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl9.Visible = False
        ' 
        ' creature9PlusBtn
        ' 
        creature9PlusBtn.BackColor = Color.Indigo
        creature9PlusBtn.FlatStyle = FlatStyle.Popup
        creature9PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature9PlusBtn.Location = New Point(399, 301)
        creature9PlusBtn.Margin = New Padding(2)
        creature9PlusBtn.Name = "creature9PlusBtn"
        creature9PlusBtn.Size = New Size(58, 32)
        creature9PlusBtn.TabIndex = 61
        creature9PlusBtn.Text = "▲"
        creature9PlusBtn.UseVisualStyleBackColor = False
        creature9PlusBtn.Visible = False
        ' 
        ' creature9MinusBtn
        ' 
        creature9MinusBtn.BackColor = Color.Indigo
        creature9MinusBtn.FlatStyle = FlatStyle.Popup
        creature9MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature9MinusBtn.Location = New Point(278, 301)
        creature9MinusBtn.Margin = New Padding(2)
        creature9MinusBtn.Name = "creature9MinusBtn"
        creature9MinusBtn.Size = New Size(58, 32)
        creature9MinusBtn.TabIndex = 60
        creature9MinusBtn.Text = "▼"
        creature9MinusBtn.UseVisualStyleBackColor = False
        creature9MinusBtn.Visible = False
        ' 
        ' creatureLbl10
        ' 
        creatureLbl10.BackColor = Color.DimGray
        creatureLbl10.FlatStyle = FlatStyle.Popup
        creatureLbl10.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        creatureLbl10.Location = New Point(337, 334)
        creatureLbl10.Margin = New Padding(2, 0, 2, 0)
        creatureLbl10.Name = "creatureLbl10"
        creatureLbl10.Size = New Size(58, 32)
        creatureLbl10.TabIndex = 65
        creatureLbl10.Text = "0"
        creatureLbl10.TextAlign = ContentAlignment.MiddleCenter
        creatureLbl10.Visible = False
        ' 
        ' creature10PlusBtn
        ' 
        creature10PlusBtn.BackColor = Color.DimGray
        creature10PlusBtn.FlatStyle = FlatStyle.Popup
        creature10PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature10PlusBtn.Location = New Point(399, 334)
        creature10PlusBtn.Margin = New Padding(2)
        creature10PlusBtn.Name = "creature10PlusBtn"
        creature10PlusBtn.Size = New Size(58, 32)
        creature10PlusBtn.TabIndex = 64
        creature10PlusBtn.Text = "▲"
        creature10PlusBtn.UseVisualStyleBackColor = False
        creature10PlusBtn.Visible = False
        ' 
        ' creature10MinusBtn
        ' 
        creature10MinusBtn.BackColor = Color.DimGray
        creature10MinusBtn.FlatStyle = FlatStyle.Popup
        creature10MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        creature10MinusBtn.Location = New Point(278, 334)
        creature10MinusBtn.Margin = New Padding(2)
        creature10MinusBtn.Name = "creature10MinusBtn"
        creature10MinusBtn.Size = New Size(58, 32)
        creature10MinusBtn.TabIndex = 63
        creature10MinusBtn.Text = "▼"
        creature10MinusBtn.UseVisualStyleBackColor = False
        creature10MinusBtn.Visible = False
        ' 
        ' totalLbl10
        ' 
        totalLbl10.BackColor = Color.DimGray
        totalLbl10.FlatStyle = FlatStyle.Popup
        totalLbl10.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl10.Location = New Point(546, 334)
        totalLbl10.Margin = New Padding(2, 0, 2, 0)
        totalLbl10.Name = "totalLbl10"
        totalLbl10.Size = New Size(58, 32)
        totalLbl10.TabIndex = 95
        totalLbl10.Text = "0"
        totalLbl10.TextAlign = ContentAlignment.MiddleCenter
        totalLbl10.Visible = False
        ' 
        ' total10PlusBtn
        ' 
        total10PlusBtn.BackColor = Color.DimGray
        total10PlusBtn.FlatStyle = FlatStyle.Popup
        total10PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total10PlusBtn.Location = New Point(606, 334)
        total10PlusBtn.Margin = New Padding(2)
        total10PlusBtn.Name = "total10PlusBtn"
        total10PlusBtn.Size = New Size(58, 32)
        total10PlusBtn.TabIndex = 94
        total10PlusBtn.Text = "▲"
        total10PlusBtn.UseVisualStyleBackColor = False
        total10PlusBtn.Visible = False
        ' 
        ' total10MinusBtn
        ' 
        total10MinusBtn.BackColor = Color.DimGray
        total10MinusBtn.FlatStyle = FlatStyle.Popup
        total10MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total10MinusBtn.Location = New Point(486, 334)
        total10MinusBtn.Margin = New Padding(2)
        total10MinusBtn.Name = "total10MinusBtn"
        total10MinusBtn.Size = New Size(58, 32)
        total10MinusBtn.TabIndex = 93
        total10MinusBtn.Text = "▼"
        total10MinusBtn.UseVisualStyleBackColor = False
        total10MinusBtn.Visible = False
        ' 
        ' totalLbl9
        ' 
        totalLbl9.BackColor = Color.Indigo
        totalLbl9.FlatStyle = FlatStyle.Popup
        totalLbl9.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl9.Location = New Point(546, 301)
        totalLbl9.Margin = New Padding(2, 0, 2, 0)
        totalLbl9.Name = "totalLbl9"
        totalLbl9.Size = New Size(58, 32)
        totalLbl9.TabIndex = 92
        totalLbl9.Text = "0"
        totalLbl9.TextAlign = ContentAlignment.MiddleCenter
        totalLbl9.Visible = False
        ' 
        ' total9PlusBtn
        ' 
        total9PlusBtn.BackColor = Color.Indigo
        total9PlusBtn.FlatStyle = FlatStyle.Popup
        total9PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total9PlusBtn.Location = New Point(606, 301)
        total9PlusBtn.Margin = New Padding(2)
        total9PlusBtn.Name = "total9PlusBtn"
        total9PlusBtn.Size = New Size(58, 32)
        total9PlusBtn.TabIndex = 91
        total9PlusBtn.Text = "▲"
        total9PlusBtn.UseVisualStyleBackColor = False
        total9PlusBtn.Visible = False
        ' 
        ' total9MinusBtn
        ' 
        total9MinusBtn.BackColor = Color.Indigo
        total9MinusBtn.FlatStyle = FlatStyle.Popup
        total9MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total9MinusBtn.Location = New Point(486, 301)
        total9MinusBtn.Margin = New Padding(2)
        total9MinusBtn.Name = "total9MinusBtn"
        total9MinusBtn.Size = New Size(58, 32)
        total9MinusBtn.TabIndex = 90
        total9MinusBtn.Text = "▼"
        total9MinusBtn.UseVisualStyleBackColor = False
        total9MinusBtn.Visible = False
        ' 
        ' totalLbl8
        ' 
        totalLbl8.BackColor = Color.DimGray
        totalLbl8.FlatStyle = FlatStyle.Popup
        totalLbl8.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl8.Location = New Point(546, 268)
        totalLbl8.Margin = New Padding(2, 0, 2, 0)
        totalLbl8.Name = "totalLbl8"
        totalLbl8.Size = New Size(58, 32)
        totalLbl8.TabIndex = 89
        totalLbl8.Text = "0"
        totalLbl8.TextAlign = ContentAlignment.MiddleCenter
        totalLbl8.Visible = False
        ' 
        ' total8PlusBtn
        ' 
        total8PlusBtn.BackColor = Color.DimGray
        total8PlusBtn.FlatStyle = FlatStyle.Popup
        total8PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total8PlusBtn.Location = New Point(606, 268)
        total8PlusBtn.Margin = New Padding(2)
        total8PlusBtn.Name = "total8PlusBtn"
        total8PlusBtn.Size = New Size(58, 32)
        total8PlusBtn.TabIndex = 88
        total8PlusBtn.Text = "▲"
        total8PlusBtn.UseVisualStyleBackColor = False
        total8PlusBtn.Visible = False
        ' 
        ' total8MinusBtn
        ' 
        total8MinusBtn.BackColor = Color.DimGray
        total8MinusBtn.FlatStyle = FlatStyle.Popup
        total8MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total8MinusBtn.Location = New Point(486, 268)
        total8MinusBtn.Margin = New Padding(2)
        total8MinusBtn.Name = "total8MinusBtn"
        total8MinusBtn.Size = New Size(58, 32)
        total8MinusBtn.TabIndex = 87
        total8MinusBtn.Text = "▼"
        total8MinusBtn.UseVisualStyleBackColor = False
        total8MinusBtn.Visible = False
        ' 
        ' totalLbl7
        ' 
        totalLbl7.BackColor = Color.Indigo
        totalLbl7.FlatStyle = FlatStyle.Popup
        totalLbl7.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl7.Location = New Point(546, 235)
        totalLbl7.Margin = New Padding(2, 0, 2, 0)
        totalLbl7.Name = "totalLbl7"
        totalLbl7.Size = New Size(58, 32)
        totalLbl7.TabIndex = 86
        totalLbl7.Text = "0"
        totalLbl7.TextAlign = ContentAlignment.MiddleCenter
        totalLbl7.Visible = False
        ' 
        ' total7PlusBtn
        ' 
        total7PlusBtn.BackColor = Color.Indigo
        total7PlusBtn.FlatStyle = FlatStyle.Popup
        total7PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total7PlusBtn.Location = New Point(606, 235)
        total7PlusBtn.Margin = New Padding(2)
        total7PlusBtn.Name = "total7PlusBtn"
        total7PlusBtn.Size = New Size(58, 32)
        total7PlusBtn.TabIndex = 85
        total7PlusBtn.Text = "▲"
        total7PlusBtn.UseVisualStyleBackColor = False
        total7PlusBtn.Visible = False
        ' 
        ' total7MinusBtn
        ' 
        total7MinusBtn.BackColor = Color.Indigo
        total7MinusBtn.FlatStyle = FlatStyle.Popup
        total7MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total7MinusBtn.Location = New Point(486, 235)
        total7MinusBtn.Margin = New Padding(2)
        total7MinusBtn.Name = "total7MinusBtn"
        total7MinusBtn.Size = New Size(58, 32)
        total7MinusBtn.TabIndex = 84
        total7MinusBtn.Text = "▼"
        total7MinusBtn.UseVisualStyleBackColor = False
        total7MinusBtn.Visible = False
        ' 
        ' totalLbl6
        ' 
        totalLbl6.BackColor = Color.DimGray
        totalLbl6.FlatStyle = FlatStyle.Popup
        totalLbl6.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl6.Location = New Point(546, 202)
        totalLbl6.Margin = New Padding(2, 0, 2, 0)
        totalLbl6.Name = "totalLbl6"
        totalLbl6.Size = New Size(58, 32)
        totalLbl6.TabIndex = 83
        totalLbl6.Text = "0"
        totalLbl6.TextAlign = ContentAlignment.MiddleCenter
        totalLbl6.Visible = False
        ' 
        ' total6PlusBtn
        ' 
        total6PlusBtn.BackColor = Color.DimGray
        total6PlusBtn.FlatStyle = FlatStyle.Popup
        total6PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total6PlusBtn.Location = New Point(606, 202)
        total6PlusBtn.Margin = New Padding(2)
        total6PlusBtn.Name = "total6PlusBtn"
        total6PlusBtn.Size = New Size(58, 32)
        total6PlusBtn.TabIndex = 82
        total6PlusBtn.Text = "▲"
        total6PlusBtn.UseVisualStyleBackColor = False
        total6PlusBtn.Visible = False
        ' 
        ' total6MinusBtn
        ' 
        total6MinusBtn.BackColor = Color.DimGray
        total6MinusBtn.FlatStyle = FlatStyle.Popup
        total6MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total6MinusBtn.Location = New Point(486, 202)
        total6MinusBtn.Margin = New Padding(2)
        total6MinusBtn.Name = "total6MinusBtn"
        total6MinusBtn.Size = New Size(58, 32)
        total6MinusBtn.TabIndex = 81
        total6MinusBtn.Text = "▼"
        total6MinusBtn.UseVisualStyleBackColor = False
        total6MinusBtn.Visible = False
        ' 
        ' totalLbl5
        ' 
        totalLbl5.BackColor = Color.Indigo
        totalLbl5.FlatStyle = FlatStyle.Popup
        totalLbl5.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl5.Location = New Point(546, 169)
        totalLbl5.Margin = New Padding(2, 0, 2, 0)
        totalLbl5.Name = "totalLbl5"
        totalLbl5.Size = New Size(58, 32)
        totalLbl5.TabIndex = 80
        totalLbl5.Text = "0"
        totalLbl5.TextAlign = ContentAlignment.MiddleCenter
        totalLbl5.Visible = False
        ' 
        ' total5PlusBtn
        ' 
        total5PlusBtn.BackColor = Color.Indigo
        total5PlusBtn.FlatStyle = FlatStyle.Popup
        total5PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total5PlusBtn.Location = New Point(606, 169)
        total5PlusBtn.Margin = New Padding(2)
        total5PlusBtn.Name = "total5PlusBtn"
        total5PlusBtn.Size = New Size(58, 32)
        total5PlusBtn.TabIndex = 79
        total5PlusBtn.Text = "▲"
        total5PlusBtn.UseVisualStyleBackColor = False
        total5PlusBtn.Visible = False
        ' 
        ' total5MinusBtn
        ' 
        total5MinusBtn.BackColor = Color.Indigo
        total5MinusBtn.FlatStyle = FlatStyle.Popup
        total5MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total5MinusBtn.Location = New Point(486, 169)
        total5MinusBtn.Margin = New Padding(2)
        total5MinusBtn.Name = "total5MinusBtn"
        total5MinusBtn.Size = New Size(58, 32)
        total5MinusBtn.TabIndex = 78
        total5MinusBtn.Text = "▼"
        total5MinusBtn.UseVisualStyleBackColor = False
        total5MinusBtn.Visible = False
        ' 
        ' totalLbl4
        ' 
        totalLbl4.BackColor = Color.DimGray
        totalLbl4.FlatStyle = FlatStyle.Popup
        totalLbl4.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl4.Location = New Point(546, 136)
        totalLbl4.Margin = New Padding(2, 0, 2, 0)
        totalLbl4.Name = "totalLbl4"
        totalLbl4.Size = New Size(58, 32)
        totalLbl4.TabIndex = 77
        totalLbl4.Text = "0"
        totalLbl4.TextAlign = ContentAlignment.MiddleCenter
        totalLbl4.Visible = False
        ' 
        ' total4PlusBtn
        ' 
        total4PlusBtn.BackColor = Color.DimGray
        total4PlusBtn.FlatStyle = FlatStyle.Popup
        total4PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total4PlusBtn.Location = New Point(606, 136)
        total4PlusBtn.Margin = New Padding(2)
        total4PlusBtn.Name = "total4PlusBtn"
        total4PlusBtn.Size = New Size(58, 32)
        total4PlusBtn.TabIndex = 76
        total4PlusBtn.Text = "▲"
        total4PlusBtn.UseVisualStyleBackColor = False
        total4PlusBtn.Visible = False
        ' 
        ' total4MinusBtn
        ' 
        total4MinusBtn.BackColor = Color.DimGray
        total4MinusBtn.FlatStyle = FlatStyle.Popup
        total4MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total4MinusBtn.Location = New Point(486, 136)
        total4MinusBtn.Margin = New Padding(2)
        total4MinusBtn.Name = "total4MinusBtn"
        total4MinusBtn.Size = New Size(58, 32)
        total4MinusBtn.TabIndex = 75
        total4MinusBtn.Text = "▼"
        total4MinusBtn.UseVisualStyleBackColor = False
        total4MinusBtn.Visible = False
        ' 
        ' totalLbl3
        ' 
        totalLbl3.BackColor = Color.Indigo
        totalLbl3.FlatStyle = FlatStyle.Popup
        totalLbl3.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl3.Location = New Point(546, 103)
        totalLbl3.Margin = New Padding(2, 0, 2, 0)
        totalLbl3.Name = "totalLbl3"
        totalLbl3.Size = New Size(58, 32)
        totalLbl3.TabIndex = 74
        totalLbl3.Text = "0"
        totalLbl3.TextAlign = ContentAlignment.MiddleCenter
        totalLbl3.Visible = False
        ' 
        ' total3PlusBtn
        ' 
        total3PlusBtn.BackColor = Color.Indigo
        total3PlusBtn.FlatStyle = FlatStyle.Popup
        total3PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total3PlusBtn.Location = New Point(606, 103)
        total3PlusBtn.Margin = New Padding(2)
        total3PlusBtn.Name = "total3PlusBtn"
        total3PlusBtn.Size = New Size(58, 32)
        total3PlusBtn.TabIndex = 73
        total3PlusBtn.Text = "▲"
        total3PlusBtn.UseVisualStyleBackColor = False
        total3PlusBtn.Visible = False
        ' 
        ' total3MinusBtn
        ' 
        total3MinusBtn.BackColor = Color.Indigo
        total3MinusBtn.FlatStyle = FlatStyle.Popup
        total3MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total3MinusBtn.Location = New Point(486, 103)
        total3MinusBtn.Margin = New Padding(2)
        total3MinusBtn.Name = "total3MinusBtn"
        total3MinusBtn.Size = New Size(58, 32)
        total3MinusBtn.TabIndex = 72
        total3MinusBtn.Text = "▼"
        total3MinusBtn.UseVisualStyleBackColor = False
        total3MinusBtn.Visible = False
        ' 
        ' totalLbl2
        ' 
        totalLbl2.BackColor = Color.DimGray
        totalLbl2.FlatStyle = FlatStyle.Popup
        totalLbl2.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl2.Location = New Point(546, 70)
        totalLbl2.Margin = New Padding(2, 0, 2, 0)
        totalLbl2.Name = "totalLbl2"
        totalLbl2.Size = New Size(58, 32)
        totalLbl2.TabIndex = 71
        totalLbl2.Text = "0"
        totalLbl2.TextAlign = ContentAlignment.MiddleCenter
        totalLbl2.Visible = False
        ' 
        ' total2PlusBtn
        ' 
        total2PlusBtn.BackColor = Color.DimGray
        total2PlusBtn.FlatStyle = FlatStyle.Popup
        total2PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total2PlusBtn.Location = New Point(606, 70)
        total2PlusBtn.Margin = New Padding(2)
        total2PlusBtn.Name = "total2PlusBtn"
        total2PlusBtn.Size = New Size(58, 32)
        total2PlusBtn.TabIndex = 70
        total2PlusBtn.Text = "▲"
        total2PlusBtn.UseVisualStyleBackColor = False
        total2PlusBtn.Visible = False
        ' 
        ' total2MinusBtn
        ' 
        total2MinusBtn.BackColor = Color.DimGray
        total2MinusBtn.FlatStyle = FlatStyle.Popup
        total2MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total2MinusBtn.Location = New Point(486, 70)
        total2MinusBtn.Margin = New Padding(2)
        total2MinusBtn.Name = "total2MinusBtn"
        total2MinusBtn.Size = New Size(58, 32)
        total2MinusBtn.TabIndex = 69
        total2MinusBtn.Text = "▼"
        total2MinusBtn.UseVisualStyleBackColor = False
        total2MinusBtn.Visible = False
        ' 
        ' totalLbl1
        ' 
        totalLbl1.BackColor = Color.Indigo
        totalLbl1.FlatStyle = FlatStyle.Popup
        totalLbl1.Font = New Font("Engravers MT", 18F, FontStyle.Bold)
        totalLbl1.Location = New Point(546, 37)
        totalLbl1.Margin = New Padding(2, 0, 2, 0)
        totalLbl1.Name = "totalLbl1"
        totalLbl1.Size = New Size(58, 32)
        totalLbl1.TabIndex = 68
        totalLbl1.Text = "0"
        totalLbl1.TextAlign = ContentAlignment.MiddleCenter
        totalLbl1.Visible = False
        ' 
        ' total1PlusBtn
        ' 
        total1PlusBtn.BackColor = Color.Indigo
        total1PlusBtn.FlatStyle = FlatStyle.Popup
        total1PlusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total1PlusBtn.Location = New Point(606, 37)
        total1PlusBtn.Margin = New Padding(2)
        total1PlusBtn.Name = "total1PlusBtn"
        total1PlusBtn.Size = New Size(58, 32)
        total1PlusBtn.TabIndex = 67
        total1PlusBtn.Text = "▲"
        total1PlusBtn.UseVisualStyleBackColor = False
        total1PlusBtn.Visible = False
        ' 
        ' total1MinusBtn
        ' 
        total1MinusBtn.BackColor = Color.Indigo
        total1MinusBtn.FlatStyle = FlatStyle.Popup
        total1MinusBtn.Font = New Font("Engravers MT", 14.25F, FontStyle.Bold)
        total1MinusBtn.Location = New Point(486, 37)
        total1MinusBtn.Margin = New Padding(2)
        total1MinusBtn.Name = "total1MinusBtn"
        total1MinusBtn.Size = New Size(58, 32)
        total1MinusBtn.TabIndex = 66
        total1MinusBtn.Text = "▼"
        total1MinusBtn.UseVisualStyleBackColor = False
        total1MinusBtn.Visible = False
        ' 
        ' GraveyardStats
        ' 
        AutoScaleDimensions = New SizeF(27F, 34F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Black
        ClientSize = New Size(704, 680)
        Controls.Add(totalLbl10)
        Controls.Add(total10PlusBtn)
        Controls.Add(total10MinusBtn)
        Controls.Add(totalLbl9)
        Controls.Add(total9PlusBtn)
        Controls.Add(total9MinusBtn)
        Controls.Add(totalLbl8)
        Controls.Add(total8PlusBtn)
        Controls.Add(total8MinusBtn)
        Controls.Add(totalLbl7)
        Controls.Add(total7PlusBtn)
        Controls.Add(total7MinusBtn)
        Controls.Add(totalLbl6)
        Controls.Add(total6PlusBtn)
        Controls.Add(total6MinusBtn)
        Controls.Add(totalLbl5)
        Controls.Add(total5PlusBtn)
        Controls.Add(total5MinusBtn)
        Controls.Add(totalLbl4)
        Controls.Add(total4PlusBtn)
        Controls.Add(total4MinusBtn)
        Controls.Add(totalLbl3)
        Controls.Add(total3PlusBtn)
        Controls.Add(total3MinusBtn)
        Controls.Add(totalLbl2)
        Controls.Add(total2PlusBtn)
        Controls.Add(total2MinusBtn)
        Controls.Add(totalLbl1)
        Controls.Add(total1PlusBtn)
        Controls.Add(total1MinusBtn)
        Controls.Add(creatureLbl10)
        Controls.Add(creature10PlusBtn)
        Controls.Add(creature10MinusBtn)
        Controls.Add(creatureLbl9)
        Controls.Add(creature9PlusBtn)
        Controls.Add(creature9MinusBtn)
        Controls.Add(creatureLbl8)
        Controls.Add(creature8PlusBtn)
        Controls.Add(creature8MinusBtn)
        Controls.Add(creatureLbl7)
        Controls.Add(creature7PlusBtn)
        Controls.Add(creature7MinusBtn)
        Controls.Add(creatureLbl6)
        Controls.Add(creature6PlusBtn)
        Controls.Add(creature6MinusBtn)
        Controls.Add(creatureLbl5)
        Controls.Add(creature5PlusBtn)
        Controls.Add(creature5MinusBtn)
        Controls.Add(creatureLbl4)
        Controls.Add(creature4PlusBtn)
        Controls.Add(creature4MinusBtn)
        Controls.Add(creatureLbl3)
        Controls.Add(Creature3PlusBtn)
        Controls.Add(creature3MinusBtn)
        Controls.Add(creatureLbl2)
        Controls.Add(creature2PlusBtn)
        Controls.Add(creature2MinusBtn)
        Controls.Add(creatureLbl1)
        Controls.Add(Creature1PlusBtn)
        Controls.Add(Creature1MinusBtn)
        Controls.Add(TextBox10)
        Controls.Add(TextBox9)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(GSCreaturesLabel)
        Controls.Add(GSPNLabel)
        Controls.Add(GSCheckedList)
        Controls.Add(GSExitButton)
        Controls.Add(GSBackButton)
        Font = New Font("Engravers MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.Lime
        Margin = New Padding(12, 7, 12, 7)
        Name = "GraveyardStats"
        StartPosition = FormStartPosition.CenterParent
        Text = "GraveyardStats"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GSBackButton As Button
    Friend WithEvents GSExitButton As Button
    Friend WithEvents GSCheckedList As CheckedListBox
    Friend WithEvents GSPNLabel As Label
    Friend WithEvents GSCreaturesLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Creature1MinusBtn As Button
    Friend WithEvents Creature1PlusBtn As Button
    Friend WithEvents creatureLbl1 As Label
    Friend WithEvents creatureLbl2 As Label
    Friend WithEvents creature2PlusBtn As Button
    Friend WithEvents creature2MinusBtn As Button
    Friend WithEvents creatureLbl3 As Label
    Friend WithEvents Creature3PlusBtn As Button
    Friend WithEvents creature3MinusBtn As Button
    Friend WithEvents creatureLbl4 As Label
    Friend WithEvents creature4PlusBtn As Button
    Friend WithEvents creature4MinusBtn As Button
    Friend WithEvents creatureLbl5 As Label
    Friend WithEvents creature5PlusBtn As Button
    Friend WithEvents creature5MinusBtn As Button
    Friend WithEvents creatureLbl6 As Label
    Friend WithEvents creature6PlusBtn As Button
    Friend WithEvents creature6MinusBtn As Button
    Friend WithEvents creatureLbl7 As Label
    Friend WithEvents creature7PlusBtn As Button
    Friend WithEvents creature7MinusBtn As Button
    Friend WithEvents creatureLbl8 As Label
    Friend WithEvents creature8PlusBtn As Button
    Friend WithEvents creature8MinusBtn As Button
    Friend WithEvents creatureLbl9 As Label
    Friend WithEvents creature9PlusBtn As Button
    Friend WithEvents creature9MinusBtn As Button
    Friend WithEvents creatureLbl10 As Label
    Friend WithEvents creature10PlusBtn As Button
    Friend WithEvents creature10MinusBtn As Button
    Friend WithEvents totalLbl10 As Label
    Friend WithEvents total10PlusBtn As Button
    Friend WithEvents total10MinusBtn As Button
    Friend WithEvents totalLbl9 As Label
    Friend WithEvents total9PlusBtn As Button
    Friend WithEvents total9MinusBtn As Button
    Friend WithEvents totalLbl8 As Label
    Friend WithEvents total8PlusBtn As Button
    Friend WithEvents total8MinusBtn As Button
    Friend WithEvents totalLbl7 As Label
    Friend WithEvents total7PlusBtn As Button
    Friend WithEvents total7MinusBtn As Button
    Friend WithEvents totalLbl6 As Label
    Friend WithEvents total6PlusBtn As Button
    Friend WithEvents total6MinusBtn As Button
    Friend WithEvents totalLbl5 As Label
    Friend WithEvents total5PlusBtn As Button
    Friend WithEvents total5MinusBtn As Button
    Friend WithEvents totalLbl4 As Label
    Friend WithEvents total4PlusBtn As Button
    Friend WithEvents total4MinusBtn As Button
    Friend WithEvents totalLbl3 As Label
    Friend WithEvents total3PlusBtn As Button
    Friend WithEvents total3MinusBtn As Button
    Friend WithEvents totalLbl2 As Label
    Friend WithEvents total2PlusBtn As Button
    Friend WithEvents total2MinusBtn As Button
    Friend WithEvents totalLbl1 As Label
    Friend WithEvents total1PlusBtn As Button
    Friend WithEvents total1MinusBtn As Button
End Class
