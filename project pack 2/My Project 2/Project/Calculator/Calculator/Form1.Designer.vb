<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        Me.Display1 = New System.Windows.Forms.Button()
        Me.Number1 = New System.Windows.Forms.Button()
        Me.Number2 = New System.Windows.Forms.Button()
        Me.Number3 = New System.Windows.Forms.Button()
        Me.Number4 = New System.Windows.Forms.Button()
        Me.Number5 = New System.Windows.Forms.Button()
        Me.Number6 = New System.Windows.Forms.Button()
        Me.Number7 = New System.Windows.Forms.Button()
        Me.Number8 = New System.Windows.Forms.Button()
        Me.Number9 = New System.Windows.Forms.Button()
        Me.Number0 = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Subtract = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.MemoryCell1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Clear = New System.Windows.Forms.Button()
        Me.MemoryCell2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Equal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MemoryCell3 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.MemoryCell1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoryCell2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MemoryCell3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Display1
        '
        Me.Display1.Enabled = False
        Me.Display1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display1.Location = New System.Drawing.Point(109, 10)
        Me.Display1.Name = "Display1"
        Me.Display1.Size = New System.Drawing.Size(234, 90)
        Me.Display1.TabIndex = 0
        Me.Display1.Text = "0"
        Me.Display1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Display1.UseVisualStyleBackColor = True
        '
        'Number1
        '
        Me.Number1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number1.Location = New System.Drawing.Point(9, 106)
        Me.Number1.Name = "Number1"
        Me.Number1.Size = New System.Drawing.Size(64, 64)
        Me.Number1.TabIndex = 1
        Me.Number1.Text = "1"
        Me.Number1.UseVisualStyleBackColor = True
        '
        'Number2
        '
        Me.Number2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number2.Location = New System.Drawing.Point(79, 106)
        Me.Number2.Name = "Number2"
        Me.Number2.Size = New System.Drawing.Size(64, 64)
        Me.Number2.TabIndex = 2
        Me.Number2.Text = "2"
        Me.Number2.UseVisualStyleBackColor = True
        '
        'Number3
        '
        Me.Number3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number3.Location = New System.Drawing.Point(149, 106)
        Me.Number3.Name = "Number3"
        Me.Number3.Size = New System.Drawing.Size(64, 64)
        Me.Number3.TabIndex = 3
        Me.Number3.Text = "3"
        Me.Number3.UseVisualStyleBackColor = True
        '
        'Number4
        '
        Me.Number4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number4.Location = New System.Drawing.Point(9, 176)
        Me.Number4.Name = "Number4"
        Me.Number4.Size = New System.Drawing.Size(64, 64)
        Me.Number4.TabIndex = 4
        Me.Number4.Text = "4"
        Me.Number4.UseVisualStyleBackColor = True
        '
        'Number5
        '
        Me.Number5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number5.Location = New System.Drawing.Point(79, 176)
        Me.Number5.Name = "Number5"
        Me.Number5.Size = New System.Drawing.Size(64, 64)
        Me.Number5.TabIndex = 5
        Me.Number5.Text = "5"
        Me.Number5.UseVisualStyleBackColor = True
        '
        'Number6
        '
        Me.Number6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number6.Location = New System.Drawing.Point(149, 176)
        Me.Number6.Name = "Number6"
        Me.Number6.Size = New System.Drawing.Size(64, 64)
        Me.Number6.TabIndex = 6
        Me.Number6.Text = "6"
        Me.Number6.UseVisualStyleBackColor = True
        '
        'Number7
        '
        Me.Number7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number7.Location = New System.Drawing.Point(9, 246)
        Me.Number7.Name = "Number7"
        Me.Number7.Size = New System.Drawing.Size(64, 64)
        Me.Number7.TabIndex = 7
        Me.Number7.Text = "7"
        Me.Number7.UseVisualStyleBackColor = True
        '
        'Number8
        '
        Me.Number8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number8.Location = New System.Drawing.Point(79, 246)
        Me.Number8.Name = "Number8"
        Me.Number8.Size = New System.Drawing.Size(64, 64)
        Me.Number8.TabIndex = 8
        Me.Number8.Text = "8"
        Me.Number8.UseVisualStyleBackColor = True
        '
        'Number9
        '
        Me.Number9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number9.Location = New System.Drawing.Point(149, 246)
        Me.Number9.Name = "Number9"
        Me.Number9.Size = New System.Drawing.Size(64, 64)
        Me.Number9.TabIndex = 9
        Me.Number9.Text = "9"
        Me.Number9.UseVisualStyleBackColor = True
        '
        'Number0
        '
        Me.Number0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Number0.Location = New System.Drawing.Point(9, 316)
        Me.Number0.Name = "Number0"
        Me.Number0.Size = New System.Drawing.Size(134, 64)
        Me.Number0.TabIndex = 10
        Me.Number0.Text = "0"
        Me.Number0.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add.Location = New System.Drawing.Point(219, 106)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(120, 64)
        Me.Add.TabIndex = 11
        Me.Add.Text = "+"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Subtract
        '
        Me.Subtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtract.Location = New System.Drawing.Point(219, 176)
        Me.Subtract.Name = "Subtract"
        Me.Subtract.Size = New System.Drawing.Size(120, 64)
        Me.Subtract.TabIndex = 12
        Me.Subtract.Text = "-"
        Me.Subtract.UseVisualStyleBackColor = True
        '
        'Multiply
        '
        Me.Multiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiply.Location = New System.Drawing.Point(219, 246)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(120, 64)
        Me.Multiply.TabIndex = 13
        Me.Multiply.Text = "*"
        Me.Multiply.UseVisualStyleBackColor = True
        '
        'Divide
        '
        Me.Divide.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divide.Location = New System.Drawing.Point(219, 316)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(120, 64)
        Me.Divide.TabIndex = 14
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = True
        '
        'MemoryCell1
        '
        Me.MemoryCell1.ContainerControl = Me
        '
        'Clear
        '
        Me.Clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(149, 316)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(64, 64)
        Me.Clear.TabIndex = 15
        Me.Clear.Text = "C"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'MemoryCell2
        '
        Me.MemoryCell2.ContainerControl = Me
        Me.MemoryCell2.DataMember = "0"
        '
        'Equal
        '
        Me.Equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equal.Location = New System.Drawing.Point(9, 10)
        Me.Equal.Name = "Equal"
        Me.Equal.Size = New System.Drawing.Size(94, 90)
        Me.Equal.TabIndex = 16
        Me.Equal.Text = "="
        Me.Equal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(320, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Visible = False
        '
        'MemoryCell3
        '
        Me.MemoryCell3.ContainerControl = Me
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 392)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Equal)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Subtract)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Number0)
        Me.Controls.Add(Me.Number9)
        Me.Controls.Add(Me.Number8)
        Me.Controls.Add(Me.Number7)
        Me.Controls.Add(Me.Number6)
        Me.Controls.Add(Me.Number5)
        Me.Controls.Add(Me.Number4)
        Me.Controls.Add(Me.Number3)
        Me.Controls.Add(Me.Number2)
        Me.Controls.Add(Me.Number1)
        Me.Controls.Add(Me.Display1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        CType(Me.MemoryCell1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoryCell2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MemoryCell3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Display1 As System.Windows.Forms.Button
    Friend WithEvents Number1 As System.Windows.Forms.Button
    Friend WithEvents Number2 As System.Windows.Forms.Button
    Friend WithEvents Number3 As System.Windows.Forms.Button
    Friend WithEvents Number4 As System.Windows.Forms.Button
    Friend WithEvents Number5 As System.Windows.Forms.Button
    Friend WithEvents Number6 As System.Windows.Forms.Button
    Friend WithEvents Number7 As System.Windows.Forms.Button
    Friend WithEvents Number8 As System.Windows.Forms.Button
    Friend WithEvents Number9 As System.Windows.Forms.Button
    Friend WithEvents Number0 As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Subtract As System.Windows.Forms.Button
    Friend WithEvents Multiply As System.Windows.Forms.Button
    Friend WithEvents Divide As System.Windows.Forms.Button
    Friend WithEvents MemoryCell1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents MemoryCell2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Equal As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MemoryCell3 As System.Windows.Forms.ErrorProvider

End Class
