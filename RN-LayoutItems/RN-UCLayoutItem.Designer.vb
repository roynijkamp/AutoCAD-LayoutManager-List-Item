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
        Me.cmdView = New System.Windows.Forms.Button()
        Me.txtLayoutName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdView
        '
        Me.cmdView.Location = New System.Drawing.Point(3, 3)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(41, 22)
        Me.cmdView.TabIndex = 0
        Me.cmdView.Text = "View"
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'txtLayoutName
        '
        Me.txtLayoutName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLayoutName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLayoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLayoutName.Location = New System.Drawing.Point(50, 6)
        Me.txtLayoutName.Margin = New System.Windows.Forms.Padding(3, 3, 8, 3)
        Me.txtLayoutName.Name = "txtLayoutName"
        Me.txtLayoutName.Size = New System.Drawing.Size(340, 15)
        Me.txtLayoutName.TabIndex = 1
        Me.txtLayoutName.Text = "txtLayoutName"
        '
        'RN_UCLayoutItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.txtLayoutName)
        Me.Controls.Add(Me.cmdView)
        Me.MaximumSize = New System.Drawing.Size(0, 30)
        Me.MinimumSize = New System.Drawing.Size(0, 30)
        Me.Name = "RN_UCLayoutItem"
        Me.Size = New System.Drawing.Size(398, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdView As Windows.Forms.Button
    Friend WithEvents txtLayoutName As Windows.Forms.TextBox
End Class
