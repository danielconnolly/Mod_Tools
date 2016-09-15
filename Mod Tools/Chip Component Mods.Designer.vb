<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chip_Component_Mods
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
        Me.Arrow33 = New System.Windows.Forms.Button()
        Me.Arrow50 = New System.Windows.Forms.Button()
        Me.Invert25 = New System.Windows.Forms.Button()
        Me.Invert50 = New System.Windows.Forms.Button()
        Me.Wendy50 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Scan = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Arrow33
        '
        Me.Arrow33.Image = Global.Mod_Tool.My.Resources.Resources.arrow33_
        Me.Arrow33.Location = New System.Drawing.Point(12, 12)
        Me.Arrow33.Name = "Arrow33"
        Me.Arrow33.Size = New System.Drawing.Size(90, 90)
        Me.Arrow33.TabIndex = 0
        Me.Arrow33.UseVisualStyleBackColor = True
        '
        'Arrow50
        '
        Me.Arrow50.Image = Global.Mod_Tool.My.Resources.Resources.arrow50_
        Me.Arrow50.Location = New System.Drawing.Point(108, 12)
        Me.Arrow50.Name = "Arrow50"
        Me.Arrow50.Size = New System.Drawing.Size(90, 90)
        Me.Arrow50.TabIndex = 1
        Me.Arrow50.UseVisualStyleBackColor = True
        '
        'Invert25
        '
        Me.Invert25.Image = Global.Mod_Tool.My.Resources.Resources.Invert25_
        Me.Invert25.Location = New System.Drawing.Point(12, 108)
        Me.Invert25.Name = "Invert25"
        Me.Invert25.Size = New System.Drawing.Size(90, 90)
        Me.Invert25.TabIndex = 2
        Me.Invert25.UseVisualStyleBackColor = True
        '
        'Invert50
        '
        Me.Invert50.Image = Global.Mod_Tool.My.Resources.Resources.Invert50_
        Me.Invert50.Location = New System.Drawing.Point(108, 108)
        Me.Invert50.Name = "Invert50"
        Me.Invert50.Size = New System.Drawing.Size(90, 90)
        Me.Invert50.TabIndex = 3
        Me.Invert50.UseVisualStyleBackColor = True
        '
        'Wendy50
        '
        Me.Wendy50.Image = Global.Mod_Tool.My.Resources.Resources.wendy50_
        Me.Wendy50.Location = New System.Drawing.Point(204, 12)
        Me.Wendy50.Name = "Wendy50"
        Me.Wendy50.Size = New System.Drawing.Size(90, 90)
        Me.Wendy50.TabIndex = 4
        Me.Wendy50.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(204, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 67)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Scan
        '
        Me.Scan.AutoSize = True
        Me.Scan.Checked = True
        Me.Scan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Scan.Location = New System.Drawing.Point(204, 181)
        Me.Scan.Name = "Scan"
        Me.Scan.Size = New System.Drawing.Size(80, 17)
        Me.Scan.TabIndex = 6
        Me.Scan.Text = "Scan Layer"
        Me.Scan.UseVisualStyleBackColor = True
        '
        'Chip_Component_Mods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 208)
        Me.Controls.Add(Me.Scan)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Wendy50)
        Me.Controls.Add(Me.Invert50)
        Me.Controls.Add(Me.Invert25)
        Me.Controls.Add(Me.Arrow50)
        Me.Controls.Add(Me.Arrow33)
        Me.Name = "Chip_Component_Mods"
        Me.Text = "Chip Component Mods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Arrow33 As System.Windows.Forms.Button
    Friend WithEvents Arrow50 As System.Windows.Forms.Button
    Friend WithEvents Invert25 As System.Windows.Forms.Button
    Friend WithEvents Invert50 As System.Windows.Forms.Button
    Friend WithEvents Wendy50 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Scan As System.Windows.Forms.CheckBox
End Class
