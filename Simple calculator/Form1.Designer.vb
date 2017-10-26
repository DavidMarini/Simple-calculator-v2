<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.Button9 = New System.Windows.Forms.Button()
		Me.Button10 = New System.Windows.Forms.Button()
		Me.Button11 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(68, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(231, 26)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "                              SIMPLE CALCULATOR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                    Please selec" &
	"t an option to proceed"
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(21, 250)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(75, 23)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Addition"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(102, 250)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(75, 23)
		Me.Button3.TabIndex = 3
		Me.Button3.Text = "Subtraction"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(128, 279)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(79, 23)
		Me.Button4.TabIndex = 4
		Me.Button4.Text = "Multiplication"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(213, 279)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(75, 23)
		Me.Button5.TabIndex = 5
		Me.Button5.Text = "Division"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(245, 308)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(75, 23)
		Me.Button6.TabIndex = 6
		Me.Button6.Text = "squaring"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(163, 69)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 8
		Me.TextBox1.Visible = False
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(163, 138)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 20)
		Me.TextBox2.TabIndex = 9
		Me.TextBox2.Visible = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(189, 108)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 13)
		Me.Label2.TabIndex = 10
		Me.Label2.Text = "divided by"
		Me.Label2.Visible = False
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(189, 108)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(51, 13)
		Me.Label3.TabIndex = 11
		Me.Label3.Text = "added by"
		Me.Label3.Visible = False
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(185, 108)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(64, 13)
		Me.Label4.TabIndex = 12
		Me.Label4.Text = "multiplied by"
		Me.Label4.Visible = False
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(178, 108)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(71, 13)
		Me.Label5.TabIndex = 13
		Me.Label5.Text = "subtracted by"
		Me.Label5.Visible = False
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(171, 108)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(78, 13)
		Me.Label6.TabIndex = 14
		Me.Label6.Text = "to the power of"
		Me.Label6.Visible = False
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(163, 108)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(86, 13)
		Me.Label7.TabIndex = 15
		Me.Label7.Text = "square rooted by"
		Me.Label7.Visible = False
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Location = New System.Drawing.Point(205, 190)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(58, 20)
		Me.Label8.TabIndex = 16
		Me.Label8.Text = "Output"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(128, 164)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(160, 23)
		Me.Button1.TabIndex = 17
		Me.Button1.Text = "Solve the addition problem"
		Me.Button1.UseVisualStyleBackColor = True
		Me.Button1.Visible = False
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(127, 164)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(172, 23)
		Me.Button7.TabIndex = 18
		Me.Button7.Text = "Solve the subtraction problem"
		Me.Button7.UseVisualStyleBackColor = True
		Me.Button7.Visible = False
		'
		'Button8
		'
		Me.Button8.Location = New System.Drawing.Point(127, 164)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(172, 23)
		Me.Button8.TabIndex = 19
		Me.Button8.Text = "Solve the multiplication problem"
		Me.Button8.UseVisualStyleBackColor = True
		Me.Button8.Visible = False
		'
		'Button9
		'
		Me.Button9.Location = New System.Drawing.Point(139, 164)
		Me.Button9.Name = "Button9"
		Me.Button9.Size = New System.Drawing.Size(149, 23)
		Me.Button9.TabIndex = 20
		Me.Button9.Text = "Solve the division problem"
		Me.Button9.UseVisualStyleBackColor = True
		Me.Button9.Visible = False
		'
		'Button10
		'
		Me.Button10.Location = New System.Drawing.Point(163, 164)
		Me.Button10.Name = "Button10"
		Me.Button10.Size = New System.Drawing.Size(107, 23)
		Me.Button10.TabIndex = 21
		Me.Button10.Text = "Solve the problem"
		Me.Button10.UseVisualStyleBackColor = True
		Me.Button10.Visible = False
		'
		'Button11
		'
		Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button11.Location = New System.Drawing.Point(352, 301)
		Me.Button11.Name = "Button11"
		Me.Button11.Size = New System.Drawing.Size(78, 35)
		Me.Button11.TabIndex = 22
		Me.Button11.Text = "EXIT"
		Me.Button11.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(442, 343)
		Me.Controls.Add(Me.Button11)
		Me.Controls.Add(Me.Button10)
		Me.Controls.Add(Me.Button9)
		Me.Controls.Add(Me.Button8)
		Me.Controls.Add(Me.Button7)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label8)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button6)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.Button4)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Simple calculator.exe"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label1 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents Button4 As Button
	Friend WithEvents Button5 As Button
	Friend WithEvents Button6 As Button
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button7 As Button
	Friend WithEvents Button8 As Button
	Friend WithEvents Button9 As Button
	Friend WithEvents Button10 As Button
	Friend WithEvents Button11 As Button
End Class
