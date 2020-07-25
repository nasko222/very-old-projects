<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TicX = New System.Windows.Forms.PictureBox()
        Me.TicO = New System.Windows.Forms.PictureBox()
        Me.TurnCell = New System.Windows.Forms.PictureBox()
        Me.Box1 = New System.Windows.Forms.PictureBox()
        Me.Box2 = New System.Windows.Forms.PictureBox()
        Me.Box3 = New System.Windows.Forms.PictureBox()
        Me.Box4 = New System.Windows.Forms.PictureBox()
        Me.Box5 = New System.Windows.Forms.PictureBox()
        Me.Box6 = New System.Windows.Forms.PictureBox()
        Me.Box7 = New System.Windows.Forms.PictureBox()
        Me.Box8 = New System.Windows.Forms.PictureBox()
        Me.Box9 = New System.Windows.Forms.PictureBox()
        Me.Cell1_O = New System.Windows.Forms.CheckBox()
        Me.Cell2_O = New System.Windows.Forms.CheckBox()
        Me.Cell3_O = New System.Windows.Forms.CheckBox()
        Me.Cell4_O = New System.Windows.Forms.CheckBox()
        Me.Cell5_O = New System.Windows.Forms.CheckBox()
        Me.Cell6_O = New System.Windows.Forms.CheckBox()
        Me.Cell7_O = New System.Windows.Forms.CheckBox()
        Me.Cell8_O = New System.Windows.Forms.CheckBox()
        Me.Cell9_O = New System.Windows.Forms.CheckBox()
        Me.Cell9_X = New System.Windows.Forms.CheckBox()
        Me.Cell8_X = New System.Windows.Forms.CheckBox()
        Me.Cell7_X = New System.Windows.Forms.CheckBox()
        Me.Cell6_X = New System.Windows.Forms.CheckBox()
        Me.Cell5_X = New System.Windows.Forms.CheckBox()
        Me.Cell4_X = New System.Windows.Forms.CheckBox()
        Me.Cell3_X = New System.Windows.Forms.CheckBox()
        Me.Cell2_X = New System.Windows.Forms.CheckBox()
        Me.Cell1_X = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Square = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WinsNumberO = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WinsNumberX = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurnCell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Box9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Square, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataMember = "N"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 50)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "New Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TicX
        '
        Me.TicX.BackgroundImage = Global.Tic_Tac_Toe.My.Resources.Resources.post_97990_1260678617
        Me.TicX.Location = New System.Drawing.Point(338, 12)
        Me.TicX.Name = "TicX"
        Me.TicX.Size = New System.Drawing.Size(29, 27)
        Me.TicX.TabIndex = 12
        Me.TicX.TabStop = False
        '
        'TicO
        '
        Me.TicO.BackgroundImage = Global.Tic_Tac_Toe.My.Resources.Resources.post_0_12884151170642
        Me.TicO.Location = New System.Drawing.Point(303, 12)
        Me.TicO.Name = "TicO"
        Me.TicO.Size = New System.Drawing.Size(29, 27)
        Me.TicO.TabIndex = 11
        Me.TicO.TabStop = False
        '
        'TurnCell
        '
        Me.TurnCell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TurnCell.Location = New System.Drawing.Point(220, 12)
        Me.TurnCell.Name = "TurnCell"
        Me.TurnCell.Size = New System.Drawing.Size(50, 50)
        Me.TurnCell.TabIndex = 9
        Me.TurnCell.TabStop = False
        '
        'Box1
        '
        Me.Box1.BackgroundImage = Global.Tic_Tac_Toe.My.Resources.Resources._61cddf9cfe50f4baaa8f472c253d1cb4_basic_square_outline_by_vexels
        Me.Box1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box1.Enabled = False
        Me.Box1.Location = New System.Drawing.Point(16, 81)
        Me.Box1.Name = "Box1"
        Me.Box1.Size = New System.Drawing.Size(70, 65)
        Me.Box1.TabIndex = 0
        Me.Box1.TabStop = False
        '
        'Box2
        '
        Me.Box2.BackgroundImage = CType(resources.GetObject("Box2.BackgroundImage"), System.Drawing.Image)
        Me.Box2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box2.Enabled = False
        Me.Box2.Location = New System.Drawing.Point(108, 81)
        Me.Box2.Name = "Box2"
        Me.Box2.Size = New System.Drawing.Size(70, 65)
        Me.Box2.TabIndex = 1
        Me.Box2.TabStop = False
        '
        'Box3
        '
        Me.Box3.BackgroundImage = CType(resources.GetObject("Box3.BackgroundImage"), System.Drawing.Image)
        Me.Box3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box3.Enabled = False
        Me.Box3.Location = New System.Drawing.Point(200, 81)
        Me.Box3.Name = "Box3"
        Me.Box3.Size = New System.Drawing.Size(70, 65)
        Me.Box3.TabIndex = 2
        Me.Box3.TabStop = False
        '
        'Box4
        '
        Me.Box4.BackgroundImage = CType(resources.GetObject("Box4.BackgroundImage"), System.Drawing.Image)
        Me.Box4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box4.Enabled = False
        Me.Box4.Location = New System.Drawing.Point(16, 165)
        Me.Box4.Name = "Box4"
        Me.Box4.Size = New System.Drawing.Size(70, 65)
        Me.Box4.TabIndex = 3
        Me.Box4.TabStop = False
        '
        'Box5
        '
        Me.Box5.BackgroundImage = CType(resources.GetObject("Box5.BackgroundImage"), System.Drawing.Image)
        Me.Box5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box5.Enabled = False
        Me.Box5.Location = New System.Drawing.Point(108, 165)
        Me.Box5.Name = "Box5"
        Me.Box5.Size = New System.Drawing.Size(70, 65)
        Me.Box5.TabIndex = 4
        Me.Box5.TabStop = False
        '
        'Box6
        '
        Me.Box6.BackgroundImage = CType(resources.GetObject("Box6.BackgroundImage"), System.Drawing.Image)
        Me.Box6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box6.Enabled = False
        Me.Box6.Location = New System.Drawing.Point(200, 165)
        Me.Box6.Name = "Box6"
        Me.Box6.Size = New System.Drawing.Size(70, 65)
        Me.Box6.TabIndex = 5
        Me.Box6.TabStop = False
        '
        'Box7
        '
        Me.Box7.BackgroundImage = CType(resources.GetObject("Box7.BackgroundImage"), System.Drawing.Image)
        Me.Box7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box7.Enabled = False
        Me.Box7.Location = New System.Drawing.Point(16, 249)
        Me.Box7.Name = "Box7"
        Me.Box7.Size = New System.Drawing.Size(70, 65)
        Me.Box7.TabIndex = 6
        Me.Box7.TabStop = False
        '
        'Box8
        '
        Me.Box8.BackgroundImage = CType(resources.GetObject("Box8.BackgroundImage"), System.Drawing.Image)
        Me.Box8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box8.Enabled = False
        Me.Box8.Location = New System.Drawing.Point(108, 249)
        Me.Box8.Name = "Box8"
        Me.Box8.Size = New System.Drawing.Size(70, 65)
        Me.Box8.TabIndex = 7
        Me.Box8.TabStop = False
        '
        'Box9
        '
        Me.Box9.BackgroundImage = CType(resources.GetObject("Box9.BackgroundImage"), System.Drawing.Image)
        Me.Box9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Box9.Enabled = False
        Me.Box9.Location = New System.Drawing.Point(200, 249)
        Me.Box9.Name = "Box9"
        Me.Box9.Size = New System.Drawing.Size(70, 65)
        Me.Box9.TabIndex = 8
        Me.Box9.TabStop = False
        '
        'Cell1_O
        '
        Me.Cell1_O.AutoSize = True
        Me.Cell1_O.Enabled = False
        Me.Cell1_O.Location = New System.Drawing.Point(296, 66)
        Me.Cell1_O.Name = "Cell1_O"
        Me.Cell1_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell1_O.TabIndex = 13
        Me.Cell1_O.UseVisualStyleBackColor = True
        '
        'Cell2_O
        '
        Me.Cell2_O.AutoSize = True
        Me.Cell2_O.Enabled = False
        Me.Cell2_O.Location = New System.Drawing.Point(317, 66)
        Me.Cell2_O.Name = "Cell2_O"
        Me.Cell2_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell2_O.TabIndex = 14
        Me.Cell2_O.UseVisualStyleBackColor = True
        '
        'Cell3_O
        '
        Me.Cell3_O.AutoSize = True
        Me.Cell3_O.Enabled = False
        Me.Cell3_O.Location = New System.Drawing.Point(338, 66)
        Me.Cell3_O.Name = "Cell3_O"
        Me.Cell3_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell3_O.TabIndex = 15
        Me.Cell3_O.UseVisualStyleBackColor = True
        '
        'Cell4_O
        '
        Me.Cell4_O.AutoSize = True
        Me.Cell4_O.Enabled = False
        Me.Cell4_O.Location = New System.Drawing.Point(296, 86)
        Me.Cell4_O.Name = "Cell4_O"
        Me.Cell4_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell4_O.TabIndex = 16
        Me.Cell4_O.UseVisualStyleBackColor = True
        '
        'Cell5_O
        '
        Me.Cell5_O.AutoSize = True
        Me.Cell5_O.Enabled = False
        Me.Cell5_O.Location = New System.Drawing.Point(317, 86)
        Me.Cell5_O.Name = "Cell5_O"
        Me.Cell5_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell5_O.TabIndex = 17
        Me.Cell5_O.UseVisualStyleBackColor = True
        '
        'Cell6_O
        '
        Me.Cell6_O.AutoSize = True
        Me.Cell6_O.Enabled = False
        Me.Cell6_O.Location = New System.Drawing.Point(338, 86)
        Me.Cell6_O.Name = "Cell6_O"
        Me.Cell6_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell6_O.TabIndex = 18
        Me.Cell6_O.UseVisualStyleBackColor = True
        '
        'Cell7_O
        '
        Me.Cell7_O.AutoSize = True
        Me.Cell7_O.Enabled = False
        Me.Cell7_O.Location = New System.Drawing.Point(296, 106)
        Me.Cell7_O.Name = "Cell7_O"
        Me.Cell7_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell7_O.TabIndex = 19
        Me.Cell7_O.UseVisualStyleBackColor = True
        '
        'Cell8_O
        '
        Me.Cell8_O.AutoSize = True
        Me.Cell8_O.Enabled = False
        Me.Cell8_O.Location = New System.Drawing.Point(317, 106)
        Me.Cell8_O.Name = "Cell8_O"
        Me.Cell8_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell8_O.TabIndex = 20
        Me.Cell8_O.UseVisualStyleBackColor = True
        '
        'Cell9_O
        '
        Me.Cell9_O.AutoSize = True
        Me.Cell9_O.Enabled = False
        Me.Cell9_O.Location = New System.Drawing.Point(338, 106)
        Me.Cell9_O.Name = "Cell9_O"
        Me.Cell9_O.Size = New System.Drawing.Size(15, 14)
        Me.Cell9_O.TabIndex = 21
        Me.Cell9_O.UseVisualStyleBackColor = True
        '
        'Cell9_X
        '
        Me.Cell9_X.AutoSize = True
        Me.Cell9_X.Enabled = False
        Me.Cell9_X.Location = New System.Drawing.Point(338, 177)
        Me.Cell9_X.Name = "Cell9_X"
        Me.Cell9_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell9_X.TabIndex = 30
        Me.Cell9_X.UseVisualStyleBackColor = True
        '
        'Cell8_X
        '
        Me.Cell8_X.AutoSize = True
        Me.Cell8_X.Enabled = False
        Me.Cell8_X.Location = New System.Drawing.Point(317, 177)
        Me.Cell8_X.Name = "Cell8_X"
        Me.Cell8_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell8_X.TabIndex = 29
        Me.Cell8_X.UseVisualStyleBackColor = True
        '
        'Cell7_X
        '
        Me.Cell7_X.AutoSize = True
        Me.Cell7_X.Enabled = False
        Me.Cell7_X.Location = New System.Drawing.Point(296, 177)
        Me.Cell7_X.Name = "Cell7_X"
        Me.Cell7_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell7_X.TabIndex = 28
        Me.Cell7_X.UseVisualStyleBackColor = True
        '
        'Cell6_X
        '
        Me.Cell6_X.AutoSize = True
        Me.Cell6_X.Enabled = False
        Me.Cell6_X.Location = New System.Drawing.Point(338, 157)
        Me.Cell6_X.Name = "Cell6_X"
        Me.Cell6_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell6_X.TabIndex = 27
        Me.Cell6_X.UseVisualStyleBackColor = True
        '
        'Cell5_X
        '
        Me.Cell5_X.AutoSize = True
        Me.Cell5_X.Enabled = False
        Me.Cell5_X.Location = New System.Drawing.Point(317, 157)
        Me.Cell5_X.Name = "Cell5_X"
        Me.Cell5_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell5_X.TabIndex = 26
        Me.Cell5_X.UseVisualStyleBackColor = True
        '
        'Cell4_X
        '
        Me.Cell4_X.AutoSize = True
        Me.Cell4_X.Enabled = False
        Me.Cell4_X.Location = New System.Drawing.Point(296, 157)
        Me.Cell4_X.Name = "Cell4_X"
        Me.Cell4_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell4_X.TabIndex = 25
        Me.Cell4_X.UseVisualStyleBackColor = True
        '
        'Cell3_X
        '
        Me.Cell3_X.AutoSize = True
        Me.Cell3_X.Enabled = False
        Me.Cell3_X.Location = New System.Drawing.Point(338, 137)
        Me.Cell3_X.Name = "Cell3_X"
        Me.Cell3_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell3_X.TabIndex = 24
        Me.Cell3_X.UseVisualStyleBackColor = True
        '
        'Cell2_X
        '
        Me.Cell2_X.AutoSize = True
        Me.Cell2_X.Enabled = False
        Me.Cell2_X.Location = New System.Drawing.Point(317, 137)
        Me.Cell2_X.Name = "Cell2_X"
        Me.Cell2_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell2_X.TabIndex = 23
        Me.Cell2_X.UseVisualStyleBackColor = True
        '
        'Cell1_X
        '
        Me.Cell1_X.AutoSize = True
        Me.Cell1_X.Enabled = False
        Me.Cell1_X.Location = New System.Drawing.Point(296, 137)
        Me.Cell1_X.Name = "Cell1_X"
        Me.Cell1_X.Size = New System.Drawing.Size(15, 14)
        Me.Cell1_X.TabIndex = 22
        Me.Cell1_X.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "O"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "X"
        '
        'Square
        '
        Me.Square.BackgroundImage = Global.Tic_Tac_Toe.My.Resources.Resources._61cddf9cfe50f4baaa8f472c253d1cb4_basic_square_outline_by_vexels
        Me.Square.Location = New System.Drawing.Point(335, 197)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(29, 27)
        Me.Square.TabIndex = 33
        Me.Square.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 336)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Wins:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Tic_Tac_Toe.My.Resources.Resources.post_0_12884151170642
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(68, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'WinsNumberO
        '
        Me.WinsNumberO.AutoSize = True
        Me.WinsNumberO.Location = New System.Drawing.Point(97, 339)
        Me.WinsNumberO.Name = "WinsNumberO"
        Me.WinsNumberO.Size = New System.Drawing.Size(13, 13)
        Me.WinsNumberO.TabIndex = 36
        Me.WinsNumberO.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Tic_Tac_Toe.My.Resources.Resources.post_97990_1260678617
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(155, 333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'WinsNumberX
        '
        Me.WinsNumberX.AutoSize = True
        Me.WinsNumberX.Location = New System.Drawing.Point(184, 339)
        Me.WinsNumberX.Name = "WinsNumberX"
        Me.WinsNumberX.Size = New System.Drawing.Size(13, 13)
        Me.WinsNumberX.TabIndex = 38
        Me.WinsNumberX.Text = "0"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(203, 330)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 26)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Who Wins"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 361)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.WinsNumberX)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.WinsNumberO)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Square)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cell9_X)
        Me.Controls.Add(Me.Cell8_X)
        Me.Controls.Add(Me.Cell7_X)
        Me.Controls.Add(Me.Cell6_X)
        Me.Controls.Add(Me.Cell5_X)
        Me.Controls.Add(Me.Cell4_X)
        Me.Controls.Add(Me.Cell3_X)
        Me.Controls.Add(Me.Cell2_X)
        Me.Controls.Add(Me.Cell1_X)
        Me.Controls.Add(Me.Cell9_O)
        Me.Controls.Add(Me.Cell8_O)
        Me.Controls.Add(Me.Cell7_O)
        Me.Controls.Add(Me.Cell6_O)
        Me.Controls.Add(Me.Cell5_O)
        Me.Controls.Add(Me.Cell4_O)
        Me.Controls.Add(Me.Cell3_O)
        Me.Controls.Add(Me.Cell2_O)
        Me.Controls.Add(Me.Cell1_O)
        Me.Controls.Add(Me.TicX)
        Me.Controls.Add(Me.TicO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TurnCell)
        Me.Controls.Add(Me.Box9)
        Me.Controls.Add(Me.Box8)
        Me.Controls.Add(Me.Box7)
        Me.Controls.Add(Me.Box6)
        Me.Controls.Add(Me.Box5)
        Me.Controls.Add(Me.Box4)
        Me.Controls.Add(Me.Box3)
        Me.Controls.Add(Me.Box2)
        Me.Controls.Add(Me.Box1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Tic Tac Toe"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurnCell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Box9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Square, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents TurnCell As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TicX As System.Windows.Forms.PictureBox
    Friend WithEvents TicO As System.Windows.Forms.PictureBox
    Friend WithEvents Box9 As System.Windows.Forms.PictureBox
    Friend WithEvents Box8 As System.Windows.Forms.PictureBox
    Friend WithEvents Box7 As System.Windows.Forms.PictureBox
    Friend WithEvents Box6 As System.Windows.Forms.PictureBox
    Friend WithEvents Box5 As System.Windows.Forms.PictureBox
    Friend WithEvents Box4 As System.Windows.Forms.PictureBox
    Friend WithEvents Box3 As System.Windows.Forms.PictureBox
    Friend WithEvents Box2 As System.Windows.Forms.PictureBox
    Friend WithEvents Box1 As System.Windows.Forms.PictureBox
    Friend WithEvents Cell9_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell8_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell7_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell6_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell5_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell4_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell3_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell2_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell1_O As System.Windows.Forms.CheckBox
    Friend WithEvents Cell9_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell8_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell7_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell6_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell5_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell4_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell3_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell2_X As System.Windows.Forms.CheckBox
    Friend WithEvents Cell1_X As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Square As System.Windows.Forms.PictureBox
    Friend WithEvents WinsNumberX As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents WinsNumberO As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
