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
        expression_history = New Label()
        input_field = New TextBox()
        multiplication = New Button()
        num_0 = New Button()
        num_5 = New Button()
        division = New Button()
        num_6 = New Button()
        period = New Button()
        num_4 = New Button()
        parentheses_end = New Button()
        subtraction = New Button()
        backspace = New Button()
        addition = New Button()
        clear = New Button()
        num_7 = New Button()
        equals = New Button()
        num_3 = New Button()
        num_8 = New Button()
        num_1 = New Button()
        num_2 = New Button()
        num_9 = New Button()
        parenthesis_start = New Button()
        SuspendLayout()
        ' 
        ' expression_history
        ' 
        expression_history.Anchor = AnchorStyles.None
        expression_history.AutoSize = True
        expression_history.BackColor = Color.White
        expression_history.Font = New Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        expression_history.Location = New Point(32, 58)
        expression_history.Name = "expression_history"
        expression_history.Size = New Size(16, 28)
        expression_history.TabIndex = 43
        expression_history.Text = " "
        expression_history.TextAlign = ContentAlignment.TopRight
        ' 
        ' input_field
        ' 
        input_field.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        input_field.BorderStyle = BorderStyle.None
        input_field.Font = New Font("Poppins", 72F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        input_field.Location = New Point(20, 45)
        input_field.Name = "input_field"
        input_field.ScrollBars = ScrollBars.Both
        input_field.Size = New Size(408, 144)
        input_field.TabIndex = 23
        input_field.TextAlign = HorizontalAlignment.Right
        ' 
        ' multiplication
        ' 
        multiplication.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        multiplication.Font = New Font("Poppins", 36F)
        multiplication.Location = New Point(327, 320)
        multiplication.Name = "multiplication"
        multiplication.Size = New Size(101, 102)
        multiplication.TabIndex = 39
        multiplication.Text = "×"
        multiplication.UseVisualStyleBackColor = True
        ' 
        ' num_0
        ' 
        num_0.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_0.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_0.Location = New Point(18, 644)
        num_0.Name = "num_0"
        num_0.Size = New Size(99, 102)
        num_0.TabIndex = 24
        num_0.Text = "0"
        num_0.UseVisualStyleBackColor = True
        ' 
        ' num_5
        ' 
        num_5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_5.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_5.Location = New Point(119, 428)
        num_5.Name = "num_5"
        num_5.Size = New Size(101, 102)
        num_5.TabIndex = 33
        num_5.Text = "5"
        num_5.UseVisualStyleBackColor = True
        ' 
        ' division
        ' 
        division.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        division.Font = New Font("Poppins", 36F)
        division.Location = New Point(327, 212)
        division.Name = "division"
        division.Size = New Size(101, 102)
        division.TabIndex = 42
        division.Text = "÷"
        division.UseVisualStyleBackColor = True
        ' 
        ' num_6
        ' 
        num_6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_6.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_6.Location = New Point(222, 428)
        num_6.Name = "num_6"
        num_6.Size = New Size(101, 102)
        num_6.TabIndex = 34
        num_6.Text = "6"
        num_6.UseVisualStyleBackColor = True
        ' 
        ' period
        ' 
        period.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        period.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        period.Location = New Point(121, 644)
        period.Name = "period"
        period.Size = New Size(99, 102)
        period.TabIndex = 25
        period.Text = "."
        period.UseVisualStyleBackColor = True
        ' 
        ' num_4
        ' 
        num_4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_4.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_4.Location = New Point(18, 428)
        num_4.Name = "num_4"
        num_4.Size = New Size(99, 102)
        num_4.TabIndex = 32
        num_4.Text = "4"
        num_4.UseVisualStyleBackColor = True
        ' 
        ' parentheses_end
        ' 
        parentheses_end.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        parentheses_end.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        parentheses_end.Location = New Point(222, 212)
        parentheses_end.Name = "parentheses_end"
        parentheses_end.Size = New Size(101, 102)
        parentheses_end.TabIndex = 41
        parentheses_end.Text = ")"
        parentheses_end.UseVisualStyleBackColor = True
        ' 
        ' subtraction
        ' 
        subtraction.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        subtraction.Font = New Font("Poppins", 36F)
        subtraction.Location = New Point(327, 428)
        subtraction.Name = "subtraction"
        subtraction.Size = New Size(101, 102)
        subtraction.TabIndex = 35
        subtraction.Text = "-"
        subtraction.UseVisualStyleBackColor = True
        ' 
        ' backspace
        ' 
        backspace.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        backspace.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        backspace.Location = New Point(222, 644)
        backspace.Name = "backspace"
        backspace.Size = New Size(101, 102)
        backspace.TabIndex = 26
        backspace.Text = "<-"
        backspace.UseVisualStyleBackColor = True
        ' 
        ' addition
        ' 
        addition.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        addition.Font = New Font("Poppins", 36F)
        addition.Location = New Point(327, 536)
        addition.Name = "addition"
        addition.Size = New Size(101, 102)
        addition.TabIndex = 31
        addition.Text = "+"
        addition.UseVisualStyleBackColor = True
        ' 
        ' clear
        ' 
        clear.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        clear.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        clear.Location = New Point(18, 212)
        clear.Name = "clear"
        clear.Size = New Size(99, 102)
        clear.TabIndex = 40
        clear.Text = "AC"
        clear.UseVisualStyleBackColor = True
        ' 
        ' num_7
        ' 
        num_7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_7.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_7.Location = New Point(18, 320)
        num_7.Name = "num_7"
        num_7.Size = New Size(99, 102)
        num_7.TabIndex = 36
        num_7.Text = "7"
        num_7.UseVisualStyleBackColor = True
        ' 
        ' equals
        ' 
        equals.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        equals.Font = New Font("Poppins", 36F)
        equals.Location = New Point(327, 644)
        equals.Name = "equals"
        equals.Size = New Size(101, 102)
        equals.TabIndex = 27
        equals.Text = "="
        equals.UseVisualStyleBackColor = True
        ' 
        ' num_3
        ' 
        num_3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_3.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_3.Location = New Point(222, 536)
        num_3.Name = "num_3"
        num_3.Size = New Size(101, 102)
        num_3.TabIndex = 30
        num_3.Text = "3"
        num_3.UseVisualStyleBackColor = True
        ' 
        ' num_8
        ' 
        num_8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_8.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_8.Location = New Point(121, 320)
        num_8.Name = "num_8"
        num_8.Size = New Size(99, 102)
        num_8.TabIndex = 37
        num_8.Text = "8"
        num_8.UseVisualStyleBackColor = True
        ' 
        ' num_1
        ' 
        num_1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_1.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_1.Location = New Point(18, 536)
        num_1.Name = "num_1"
        num_1.Size = New Size(99, 102)
        num_1.TabIndex = 28
        num_1.Text = "1"
        num_1.UseVisualStyleBackColor = True
        ' 
        ' num_2
        ' 
        num_2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_2.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_2.Location = New Point(119, 536)
        num_2.Name = "num_2"
        num_2.Size = New Size(101, 102)
        num_2.TabIndex = 29
        num_2.Text = "2"
        num_2.UseVisualStyleBackColor = True
        ' 
        ' num_9
        ' 
        num_9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        num_9.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        num_9.Location = New Point(222, 320)
        num_9.Name = "num_9"
        num_9.Size = New Size(101, 102)
        num_9.TabIndex = 38
        num_9.Text = "9"
        num_9.UseVisualStyleBackColor = True
        ' 
        ' parenthesis_start
        ' 
        parenthesis_start.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        parenthesis_start.Font = New Font("Poppins", 27.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        parenthesis_start.Location = New Point(119, 212)
        parenthesis_start.Name = "parenthesis_start"
        parenthesis_start.Size = New Size(101, 102)
        parenthesis_start.TabIndex = 44
        parenthesis_start.Text = "("
        parenthesis_start.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(446, 790)
        Controls.Add(parenthesis_start)
        Controls.Add(expression_history)
        Controls.Add(input_field)
        Controls.Add(multiplication)
        Controls.Add(num_0)
        Controls.Add(num_5)
        Controls.Add(division)
        Controls.Add(num_6)
        Controls.Add(period)
        Controls.Add(num_4)
        Controls.Add(parentheses_end)
        Controls.Add(subtraction)
        Controls.Add(backspace)
        Controls.Add(addition)
        Controls.Add(clear)
        Controls.Add(num_7)
        Controls.Add(equals)
        Controls.Add(num_3)
        Controls.Add(num_8)
        Controls.Add(num_1)
        Controls.Add(num_2)
        Controls.Add(num_9)
        ForeColor = SystemColors.ControlText
        Name = "Form1"
        Text = "Calculator"
        WindowState = FormWindowState.Minimized
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents expression_history As Label
    Friend WithEvents input_field As TextBox
    Friend WithEvents multiplication As Button
    Friend WithEvents num_0 As Button
    Friend WithEvents num_5 As Button
    Friend WithEvents division As Button
    Friend WithEvents num_6 As Button
    Friend WithEvents period As Button
    Friend WithEvents num_4 As Button
    Friend WithEvents parentheses_end As Button
    Friend WithEvents subtraction As Button
    Friend WithEvents backspace As Button
    Friend WithEvents addition As Button
    Friend WithEvents clear As Button
    Friend WithEvents num_7 As Button
    Friend WithEvents equals As Button
    Friend WithEvents num_3 As Button
    Friend WithEvents num_8 As Button
    Friend WithEvents num_1 As Button
    Friend WithEvents num_2 As Button
    Friend WithEvents num_9 As Button
    Friend WithEvents parenthesis_start As Button

End Class
