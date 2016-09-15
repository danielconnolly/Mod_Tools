<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reductions
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblAbsUnitsY = New System.Windows.Forms.Label()
        Me.lblAbsUnitsX = New System.Windows.Forms.Label()
        Me.btnAbsRed = New System.Windows.Forms.Button()
        Me.cboAbsShapes = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAbsY = New System.Windows.Forms.TextBox()
        Me.txtAbsX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblPercentUnitsY = New System.Windows.Forms.Label()
        Me.lblPercentUnitsX = New System.Windows.Forms.Label()
        Me.btnPercentRed = New System.Windows.Forms.Button()
        Me.cboPercentShape = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPercentY = New System.Windows.Forms.TextBox()
        Me.txtPercentX = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cboUnits = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.lblAbsUnitsY)
        Me.Panel1.Controls.Add(Me.lblAbsUnitsX)
        Me.Panel1.Controls.Add(Me.btnAbsRed)
        Me.Panel1.Controls.Add(Me.cboAbsShapes)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAbsY)
        Me.Panel1.Controls.Add(Me.txtAbsX)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 160)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Reduce + Web"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblAbsUnitsY
        '
        Me.lblAbsUnitsY.AutoSize = True
        Me.lblAbsUnitsY.Location = New System.Drawing.Point(94, 54)
        Me.lblAbsUnitsY.Name = "lblAbsUnitsY"
        Me.lblAbsUnitsY.Size = New System.Drawing.Size(41, 13)
        Me.lblAbsUnitsY.TabIndex = 8
        Me.lblAbsUnitsY.Text = " inches"
        '
        'lblAbsUnitsX
        '
        Me.lblAbsUnitsX.AutoSize = True
        Me.lblAbsUnitsX.Location = New System.Drawing.Point(94, 28)
        Me.lblAbsUnitsX.Name = "lblAbsUnitsX"
        Me.lblAbsUnitsX.Size = New System.Drawing.Size(41, 13)
        Me.lblAbsUnitsX.TabIndex = 7
        Me.lblAbsUnitsX.Text = " inches"
        '
        'btnAbsRed
        '
        Me.btnAbsRed.Location = New System.Drawing.Point(7, 104)
        Me.btnAbsRed.Name = "btnAbsRed"
        Me.btnAbsRed.Size = New System.Drawing.Size(126, 23)
        Me.btnAbsRed.TabIndex = 6
        Me.btnAbsRed.Text = "Absolute Reduction"
        Me.btnAbsRed.UseVisualStyleBackColor = True
        '
        'cboAbsShapes
        '
        Me.cboAbsShapes.FormattingEnabled = True
        Me.cboAbsShapes.Items.AddRange(New Object() {"Draw", "Round", "Square", "Rectangle", "Oblong", "Custom"})
        Me.cboAbsShapes.Location = New System.Drawing.Point(7, 77)
        Me.cboAbsShapes.Name = "cboAbsShapes"
        Me.cboAbsShapes.Size = New System.Drawing.Size(128, 21)
        Me.cboAbsShapes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Y:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "X:"
        '
        'txtAbsY
        '
        Me.txtAbsY.Location = New System.Drawing.Point(27, 51)
        Me.txtAbsY.Name = "txtAbsY"
        Me.txtAbsY.Size = New System.Drawing.Size(61, 20)
        Me.txtAbsY.TabIndex = 2
        '
        'txtAbsX
        '
        Me.txtAbsX.Location = New System.Drawing.Point(27, 25)
        Me.txtAbsX.Name = "txtAbsX"
        Me.txtAbsX.Size = New System.Drawing.Size(61, 20)
        Me.txtAbsX.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Absolute"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.lblPercentUnitsY)
        Me.Panel2.Controls.Add(Me.lblPercentUnitsX)
        Me.Panel2.Controls.Add(Me.btnPercentRed)
        Me.Panel2.Controls.Add(Me.cboPercentShape)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtPercentY)
        Me.Panel2.Controls.Add(Me.txtPercentX)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(158, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(140, 160)
        Me.Panel2.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Reduce + Web"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblPercentUnitsY
        '
        Me.lblPercentUnitsY.AutoSize = True
        Me.lblPercentUnitsY.Location = New System.Drawing.Point(94, 54)
        Me.lblPercentUnitsY.Name = "lblPercentUnitsY"
        Me.lblPercentUnitsY.Size = New System.Drawing.Size(15, 13)
        Me.lblPercentUnitsY.TabIndex = 9
        Me.lblPercentUnitsY.Text = "%"
        '
        'lblPercentUnitsX
        '
        Me.lblPercentUnitsX.AutoSize = True
        Me.lblPercentUnitsX.Location = New System.Drawing.Point(94, 28)
        Me.lblPercentUnitsX.Name = "lblPercentUnitsX"
        Me.lblPercentUnitsX.Size = New System.Drawing.Size(15, 13)
        Me.lblPercentUnitsX.TabIndex = 8
        Me.lblPercentUnitsX.Text = "%"
        '
        'btnPercentRed
        '
        Me.btnPercentRed.Location = New System.Drawing.Point(7, 104)
        Me.btnPercentRed.Name = "btnPercentRed"
        Me.btnPercentRed.Size = New System.Drawing.Size(126, 23)
        Me.btnPercentRed.TabIndex = 6
        Me.btnPercentRed.Text = "Percentage Reduction"
        Me.btnPercentRed.UseVisualStyleBackColor = True
        '
        'cboPercentShape
        '
        Me.cboPercentShape.FormattingEnabled = True
        Me.cboPercentShape.Items.AddRange(New Object() {"Draw", "Round", "Square", "Rectangle", "Oblong", "Custom"})
        Me.cboPercentShape.Location = New System.Drawing.Point(7, 77)
        Me.cboPercentShape.Name = "cboPercentShape"
        Me.cboPercentShape.Size = New System.Drawing.Size(128, 21)
        Me.cboPercentShape.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Y:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "X:"
        '
        'txtPercentY
        '
        Me.txtPercentY.Location = New System.Drawing.Point(27, 51)
        Me.txtPercentY.Name = "txtPercentY"
        Me.txtPercentY.Size = New System.Drawing.Size(61, 20)
        Me.txtPercentY.TabIndex = 2
        Me.txtPercentY.Text = "100"
        '
        'txtPercentX
        '
        Me.txtPercentX.Location = New System.Drawing.Point(27, 25)
        Me.txtPercentX.Name = "txtPercentX"
        Me.txtPercentX.Size = New System.Drawing.Size(61, 20)
        Me.txtPercentX.TabIndex = 1
        Me.txtPercentX.Text = "100"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Percentage"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 207)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(283, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cboUnits
        '
        Me.cboUnits.FormattingEnabled = True
        Me.cboUnits.Items.AddRange(New Object() {"mm", "thou", "inches"})
        Me.cboUnits.Location = New System.Drawing.Point(229, 178)
        Me.cboUnits.Name = "cboUnits"
        Me.cboUnits.Size = New System.Drawing.Size(69, 21)
        Me.cboUnits.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(192, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Units"
        '
        'Reductions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 318)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboUnits)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Reductions"
        Me.Text = "Reductions"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboAbsShapes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAbsY As System.Windows.Forms.TextBox
    Friend WithEvents txtAbsX As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAbsRed As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnPercentRed As System.Windows.Forms.Button
    Friend WithEvents cboPercentShape As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPercentY As System.Windows.Forms.TextBox
    Friend WithEvents txtPercentX As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAbsUnitsY As System.Windows.Forms.Label
    Friend WithEvents lblAbsUnitsX As System.Windows.Forms.Label
    Friend WithEvents lblPercentUnitsY As System.Windows.Forms.Label
    Friend WithEvents lblPercentUnitsX As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cboUnits As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
