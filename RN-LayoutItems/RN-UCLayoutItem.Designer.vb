<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RN_UCLayoutItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.txtLayoutName = New System.Windows.Forms.TextBox()
        Me.lblLayoutName = New System.Windows.Forms.Label()
        Me.cmdPlot = New System.Windows.Forms.Button()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtLayoutName
        '
        Me.txtLayoutName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLayoutName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLayoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLayoutName.Location = New System.Drawing.Point(79, 6)
        Me.txtLayoutName.Margin = New System.Windows.Forms.Padding(3, 3, 8, 3)
        Me.txtLayoutName.Name = "txtLayoutName"
        Me.txtLayoutName.Size = New System.Drawing.Size(237, 22)
        Me.txtLayoutName.TabIndex = 1
        Me.txtLayoutName.Text = "txtLayoutName"
        Me.txtLayoutName.Visible = False
        '
        'lblLayoutName
        '
        Me.lblLayoutName.AutoSize = True
        Me.lblLayoutName.BackColor = System.Drawing.Color.Transparent
        Me.lblLayoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLayoutName.Location = New System.Drawing.Point(79, 8)
        Me.lblLayoutName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblLayoutName.Name = "lblLayoutName"
        Me.lblLayoutName.Size = New System.Drawing.Size(99, 16)
        Me.lblLayoutName.TabIndex = 2
        Me.lblLayoutName.Text = "lblLayoutName"
        '
        'cmdPlot
        '
        Me.cmdPlot.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_print
        Me.cmdPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdPlot.Location = New System.Drawing.Point(31, 6)
        Me.cmdPlot.Name = "cmdPlot"
        Me.cmdPlot.Size = New System.Drawing.Size(22, 22)
        Me.cmdPlot.TabIndex = 3
        Me.cmdPlot.UseVisualStyleBackColor = True
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(59, 10)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(15, 14)
        Me.chkPlot.TabIndex = 4
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_view
        Me.cmdView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdView.Location = New System.Drawing.Point(3, 6)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(22, 22)
        Me.cmdView.TabIndex = 0
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'RN_UCLayoutItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.chkPlot)
        Me.Controls.Add(Me.cmdPlot)
        Me.Controls.Add(Me.lblLayoutName)
        Me.Controls.Add(Me.txtLayoutName)
        Me.Controls.Add(Me.cmdView)
        Me.MaximumSize = New System.Drawing.Size(0, 30)
        Me.MinimumSize = New System.Drawing.Size(350, 30)
        Me.Name = "RN_UCLayoutItem"
        Me.Size = New System.Drawing.Size(350, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdView As Windows.Forms.Button
    Friend WithEvents txtLayoutName As Windows.Forms.TextBox
    Friend WithEvents lblLayoutName As Windows.Forms.Label
    Friend WithEvents cmdPlot As Windows.Forms.Button
    Friend WithEvents chkPlot As Windows.Forms.CheckBox
End Class
