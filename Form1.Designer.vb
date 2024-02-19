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
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        ComboBox1 = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        CheckBox3 = New CheckBox()
        CheckBox4 = New CheckBox()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(42, 64)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(411, 36)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Sketch figure maintain association"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(42, 151)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(474, 36)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Sketch figure don't maintain association"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"1.0", "2.0", "3.0", "4.0", "5.0", "6.0", "7.0", "8.0", "9.0", "10.0"})
        ComboBox1.Location = New Point(42, 384)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(600, 40)
        ComboBox1.TabIndex = 2
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(588, 80)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(84, 36)
        RadioButton1.TabIndex = 4
        RadioButton1.TabStop = True
        RadioButton1.Text = "Top"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(588, 150)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(85, 36)
        RadioButton2.TabIndex = 5
        RadioButton2.TabStop = True
        RadioButton2.Text = "Left"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(588, 220)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(101, 36)
        RadioButton3.TabIndex = 6
        RadioButton3.TabStop = True
        RadioButton3.Text = "Right"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(588, 285)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(124, 36)
        RadioButton4.TabIndex = 7
        RadioButton4.TabStop = True
        RadioButton4.Text = "Bottom"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(42, 233)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(446, 36)
        CheckBox3.TabIndex = 8
        CheckBox3.Text = "Reference figure maintain association"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(42, 314)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(509, 36)
        CheckBox4.TabIndex = 9
        CheckBox4.Text = "Reference figure don't maintain association"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 449)
        Button1.Name = "Button1"
        Button1.Size = New Size(336, 46)
        Button1.TabIndex = 10
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(490, 449)
        Button2.Name = "Button2"
        Button2.Size = New Size(336, 46)
        Button2.TabIndex = 11
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(838, 507)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(CheckBox4)
        Controls.Add(CheckBox3)
        Controls.Add(RadioButton4)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(ComboBox1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form1"
        Text = "Alibre Control Preset System Demo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button

End Class
