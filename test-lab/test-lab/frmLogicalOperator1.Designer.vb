<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogicalOperator
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
        Me.cbVerify = New System.Windows.Forms.CheckBox()
        Me.tbA = New System.Windows.Forms.TextBox()
        Me.tbB = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbAge = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 112)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Enter"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cbVerify
        '
        Me.cbVerify.AutoSize = True
        Me.cbVerify.Location = New System.Drawing.Point(19, 89)
        Me.cbVerify.Name = "cbVerify"
        Me.cbVerify.Size = New System.Drawing.Size(52, 17)
        Me.cbVerify.TabIndex = 1
        Me.cbVerify.Text = "Verify"
        Me.cbVerify.UseVisualStyleBackColor = True
        '
        'tbA
        '
        Me.tbA.Location = New System.Drawing.Point(19, 37)
        Me.tbA.Name = "tbA"
        Me.tbA.Size = New System.Drawing.Size(104, 20)
        Me.tbA.TabIndex = 2
        '
        'tbB
        '
        Me.tbB.Location = New System.Drawing.Point(19, 63)
        Me.tbB.Name = "tbB"
        Me.tbB.Size = New System.Drawing.Size(104, 20)
        Me.tbB.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.tbB)
        Me.GroupBox1.Controls.Add(Me.cbVerify)
        Me.GroupBox1.Controls.Add(Me.tbA)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(141, 185)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Test which variable is bigger"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.tbAge)
        Me.GroupBox2.Location = New System.Drawing.Point(175, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(141, 185)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test your age"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.ForestGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(19, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 52)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Enter"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tbAge
        '
        Me.tbAge.Location = New System.Drawing.Point(19, 37)
        Me.tbAge.Name = "tbAge"
        Me.tbAge.Size = New System.Drawing.Size(104, 20)
        Me.tbAge.TabIndex = 2
        '
        'frmLogicalOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 472)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmLogicalOperator"
        Me.Text = "Logical Operator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbVerify As System.Windows.Forms.CheckBox
    Friend WithEvents tbA As System.Windows.Forms.TextBox
    Friend WithEvents tbB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tbAge As System.Windows.Forms.TextBox

End Class
