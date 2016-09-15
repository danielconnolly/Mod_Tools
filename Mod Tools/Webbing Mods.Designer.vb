<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Webbing_Mods
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
        Me.lblDimX = New System.Windows.Forms.Label()
        Me.lblDimY = New System.Windows.Forms.Label()
        Me.txtWebX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtWebY = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGap = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.chkScan = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lblDimX
        '
        Me.lblDimX.AutoSize = True
        Me.lblDimX.Location = New System.Drawing.Point(12, 9)
        Me.lblDimX.Name = "lblDimX"
        Me.lblDimX.Size = New System.Drawing.Size(62, 13)
        Me.lblDimX.TabIndex = 0
        Me.lblDimX.Text = "X: x.xxx mm"
        '
        'lblDimY
        '
        Me.lblDimY.AutoSize = True
        Me.lblDimY.Location = New System.Drawing.Point(106, 9)
        Me.lblDimY.Name = "lblDimY"
        Me.lblDimY.Size = New System.Drawing.Size(62, 13)
        Me.lblDimY.TabIndex = 1
        Me.lblDimY.Text = "Y: x.xxx mm"
        '
        'txtWebX
        '
        Me.txtWebX.Location = New System.Drawing.Point(51, 38)
        Me.txtWebX.Name = "txtWebX"
        Me.txtWebX.Size = New System.Drawing.Size(35, 20)
        Me.txtWebX.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Web:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(92, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "x"
        '
        'txtWebY
        '
        Me.txtWebY.Location = New System.Drawing.Point(110, 38)
        Me.txtWebY.Name = "txtWebY"
        Me.txtWebY.Size = New System.Drawing.Size(35, 20)
        Me.txtWebY.TabIndex = 5
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 125)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(93, 125)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bar Width:"
        '
        'txtGap
        '
        Me.txtGap.Location = New System.Drawing.Point(75, 64)
        Me.txtGap.Name = "txtGap"
        Me.txtGap.Size = New System.Drawing.Size(42, 20)
        Me.txtGap.TabIndex = 10
        Me.txtGap.Text = "0.5"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(123, 67)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(23, 13)
        Me.lblUnits.TabIndex = 11
        Me.lblUnits.Text = "mm"
        '
        'chkScan
        '
        Me.chkScan.AutoSize = True
        Me.chkScan.Checked = True
        Me.chkScan.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkScan.Location = New System.Drawing.Point(15, 90)
        Me.chkScan.Name = "chkScan"
        Me.chkScan.Size = New System.Drawing.Size(80, 17)
        Me.chkScan.TabIndex = 12
        Me.chkScan.Text = "Scan Layer"
        Me.chkScan.UseVisualStyleBackColor = True
        '
        'Webbing_Mods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(183, 155)
        Me.Controls.Add(Me.chkScan)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtGap)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtWebY)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtWebX)
        Me.Controls.Add(Me.lblDimY)
        Me.Controls.Add(Me.lblDimX)
        Me.Name = "Webbing_Mods"
        Me.Text = "Webbing Mods"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDimX As System.Windows.Forms.Label
    Friend WithEvents lblDimY As System.Windows.Forms.Label
    Friend WithEvents txtWebX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtWebY As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGap As System.Windows.Forms.TextBox
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents chkScan As System.Windows.Forms.CheckBox
End Class
