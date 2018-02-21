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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.depth_TextBox = New System.Windows.Forms.TextBox()
        Me.depth_Button = New System.Windows.Forms.Button()
        Me.check_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Generate Similar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(12, 164)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "English Flag"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 51)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(253, 107)
        Me.TextBox1.TabIndex = 2
        '
        'depth_TextBox
        '
        Me.depth_TextBox.Location = New System.Drawing.Point(12, 25)
        Me.depth_TextBox.Name = "depth_TextBox"
        Me.depth_TextBox.Size = New System.Drawing.Size(100, 20)
        Me.depth_TextBox.TabIndex = 3
        '
        'depth_Button
        '
        Me.depth_Button.Location = New System.Drawing.Point(118, 23)
        Me.depth_Button.Name = "depth_Button"
        Me.depth_Button.Size = New System.Drawing.Size(75, 23)
        Me.depth_Button.TabIndex = 4
        Me.depth_Button.Text = "Set Depth"
        Me.depth_Button.UseVisualStyleBackColor = True
        '
        'check_Button
        '
        Me.check_Button.Location = New System.Drawing.Point(190, 193)
        Me.check_Button.Name = "check_Button"
        Me.check_Button.Size = New System.Drawing.Size(75, 23)
        Me.check_Button.TabIndex = 5
        Me.check_Button.Text = "Check DB "
        Me.check_Button.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 249)
        Me.Controls.Add(Me.check_Button)
        Me.Controls.Add(Me.depth_Button)
        Me.Controls.Add(Me.depth_TextBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents depth_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents depth_Button As System.Windows.Forms.Button
    Friend WithEvents check_Button As System.Windows.Forms.Button

End Class
