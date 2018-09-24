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
        Me.components = New System.ComponentModel.Container()
        Me.txtLayoutName = New System.Windows.Forms.TextBox()
        Me.lblLayoutName = New System.Windows.Forms.Label()
        Me.chkPlot = New System.Windows.Forms.CheckBox()
        Me.cmdPlot = New System.Windows.Forms.Button()
        Me.cmdView = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pcbTransparency = New System.Windows.Forms.PictureBox()
        Me.lblPlotStyle = New System.Windows.Forms.Label()
        Me.lblPlotdevice = New System.Windows.Forms.Label()
        Me.cmdCollapse = New System.Windows.Forms.Button()
        Me.chkPlotStyles = New System.Windows.Forms.CheckBox()
        Me.radioPortrait = New System.Windows.Forms.RadioButton()
        Me.radioLandscape = New System.Windows.Forms.RadioButton()
        Me.cmbPapersize = New System.Windows.Forms.ComboBox()
        Me.cmdChangeMediaSize = New System.Windows.Forms.Button()
        CType(Me.pcbTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLayoutName
        '
        Me.txtLayoutName.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtLayoutName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLayoutName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLayoutName.Location = New System.Drawing.Point(118, 3)
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
        Me.lblLayoutName.Location = New System.Drawing.Point(118, 3)
        Me.lblLayoutName.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.lblLayoutName.Name = "lblLayoutName"
        Me.lblLayoutName.Size = New System.Drawing.Size(99, 16)
        Me.lblLayoutName.TabIndex = 2
        Me.lblLayoutName.Text = "lblLayoutName"
        Me.ToolTip1.SetToolTip(Me.lblLayoutName, "Dubbelklik om de naam te wijzigen")
        '
        'chkPlot
        '
        Me.chkPlot.AutoSize = True
        Me.chkPlot.Location = New System.Drawing.Point(98, 7)
        Me.chkPlot.Name = "chkPlot"
        Me.chkPlot.Size = New System.Drawing.Size(15, 14)
        Me.chkPlot.TabIndex = 4
        Me.chkPlot.UseVisualStyleBackColor = True
        '
        'cmdPlot
        '
        Me.cmdPlot.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_print
        Me.cmdPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdPlot.Location = New System.Drawing.Point(70, 5)
        Me.cmdPlot.Name = "cmdPlot"
        Me.cmdPlot.Size = New System.Drawing.Size(22, 22)
        Me.cmdPlot.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.cmdPlot, "Layout afdrukken")
        Me.cmdPlot.UseVisualStyleBackColor = True
        '
        'cmdView
        '
        Me.cmdView.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_view
        Me.cmdView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdView.Location = New System.Drawing.Point(45, 5)
        Me.cmdView.Name = "cmdView"
        Me.cmdView.Size = New System.Drawing.Size(22, 22)
        Me.cmdView.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cmdView, "Overschakelen naar deze layout")
        Me.cmdView.UseVisualStyleBackColor = True
        '
        'pcbTransparency
        '
        Me.pcbTransparency.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_transparency_off
        Me.pcbTransparency.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pcbTransparency.Location = New System.Drawing.Point(124, 18)
        Me.pcbTransparency.Margin = New System.Windows.Forms.Padding(0)
        Me.pcbTransparency.Name = "pcbTransparency"
        Me.pcbTransparency.Size = New System.Drawing.Size(12, 12)
        Me.pcbTransparency.TabIndex = 6
        Me.pcbTransparency.TabStop = False
        Me.ToolTip1.SetToolTip(Me.pcbTransparency, "Plot met Transparatie is uitgeschakeld" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Klik om het afdrukken met Transparatie in" &
        " te schakelen")
        '
        'lblPlotStyle
        '
        Me.lblPlotStyle.AutoSize = True
        Me.lblPlotStyle.BackColor = System.Drawing.Color.Transparent
        Me.lblPlotStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlotStyle.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPlotStyle.Location = New System.Drawing.Point(141, 17)
        Me.lblPlotStyle.Name = "lblPlotStyle"
        Me.lblPlotStyle.Size = New System.Drawing.Size(58, 13)
        Me.lblPlotStyle.TabIndex = 5
        Me.lblPlotStyle.Text = "lblPlotStyle"
        '
        'lblPlotdevice
        '
        Me.lblPlotdevice.AutoSize = True
        Me.lblPlotdevice.BackColor = System.Drawing.Color.Transparent
        Me.lblPlotdevice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlotdevice.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPlotdevice.Location = New System.Drawing.Point(205, 17)
        Me.lblPlotdevice.Margin = New System.Windows.Forms.Padding(8, 0, 3, 0)
        Me.lblPlotdevice.Name = "lblPlotdevice"
        Me.lblPlotdevice.Size = New System.Drawing.Size(67, 13)
        Me.lblPlotdevice.TabIndex = 5
        Me.lblPlotdevice.Text = "lblPlotdevice"
        '
        'cmdCollapse
        '
        Me.cmdCollapse.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_collapse
        Me.cmdCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdCollapse.Location = New System.Drawing.Point(20, 5)
        Me.cmdCollapse.Name = "cmdCollapse"
        Me.cmdCollapse.Size = New System.Drawing.Size(22, 22)
        Me.cmdCollapse.TabIndex = 7
        Me.cmdCollapse.UseVisualStyleBackColor = True
        '
        'chkPlotStyles
        '
        Me.chkPlotStyles.AutoSize = True
        Me.chkPlotStyles.Location = New System.Drawing.Point(3, 41)
        Me.chkPlotStyles.Name = "chkPlotStyles"
        Me.chkPlotStyles.Size = New System.Drawing.Size(111, 17)
        Me.chkPlotStyles.TabIndex = 8
        Me.chkPlotStyles.Text = "Display plot Styles"
        Me.chkPlotStyles.UseVisualStyleBackColor = True
        '
        'radioPortrait
        '
        Me.radioPortrait.AutoSize = True
        Me.radioPortrait.Location = New System.Drawing.Point(3, 64)
        Me.radioPortrait.Name = "radioPortrait"
        Me.radioPortrait.Size = New System.Drawing.Size(58, 17)
        Me.radioPortrait.TabIndex = 9
        Me.radioPortrait.TabStop = True
        Me.radioPortrait.Text = "Portrait"
        Me.radioPortrait.UseVisualStyleBackColor = True
        '
        'radioLandscape
        '
        Me.radioLandscape.AutoSize = True
        Me.radioLandscape.Location = New System.Drawing.Point(57, 64)
        Me.radioLandscape.Name = "radioLandscape"
        Me.radioLandscape.Size = New System.Drawing.Size(78, 17)
        Me.radioLandscape.TabIndex = 10
        Me.radioLandscape.TabStop = True
        Me.radioLandscape.Text = "Landscape"
        Me.radioLandscape.UseVisualStyleBackColor = True
        '
        'cmbPapersize
        '
        Me.cmbPapersize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPapersize.FormattingEnabled = True
        Me.cmbPapersize.Location = New System.Drawing.Point(141, 60)
        Me.cmbPapersize.Name = "cmbPapersize"
        Me.cmbPapersize.Size = New System.Drawing.Size(189, 21)
        Me.cmbPapersize.TabIndex = 11
        '
        'cmdChangeMediaSize
        '
        Me.cmdChangeMediaSize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdChangeMediaSize.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_page_size
        Me.cmdChangeMediaSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdChangeMediaSize.Location = New System.Drawing.Point(332, 59)
        Me.cmdChangeMediaSize.Name = "cmdChangeMediaSize"
        Me.cmdChangeMediaSize.Size = New System.Drawing.Size(22, 22)
        Me.cmdChangeMediaSize.TabIndex = 12
        Me.cmdChangeMediaSize.UseVisualStyleBackColor = True
        '
        'RN_UCLayoutItem
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.RN_LayoutItems.My.Resources.Resources.icon_drag_32x15
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me.cmdChangeMediaSize)
        Me.Controls.Add(Me.cmbPapersize)
        Me.Controls.Add(Me.radioLandscape)
        Me.Controls.Add(Me.radioPortrait)
        Me.Controls.Add(Me.chkPlotStyles)
        Me.Controls.Add(Me.cmdCollapse)
        Me.Controls.Add(Me.pcbTransparency)
        Me.Controls.Add(Me.lblPlotdevice)
        Me.Controls.Add(Me.lblPlotStyle)
        Me.Controls.Add(Me.chkPlot)
        Me.Controls.Add(Me.cmdPlot)
        Me.Controls.Add(Me.lblLayoutName)
        Me.Controls.Add(Me.txtLayoutName)
        Me.Controls.Add(Me.cmdView)
        Me.Name = "RN_UCLayoutItem"
        Me.Size = New System.Drawing.Size(360, 95)
        Me.ToolTip1.SetToolTip(Me, "Item verslepen")
        CType(Me.pcbTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdView As Windows.Forms.Button
    Friend WithEvents txtLayoutName As Windows.Forms.TextBox
    Friend WithEvents lblLayoutName As Windows.Forms.Label
    Friend WithEvents cmdPlot As Windows.Forms.Button
    Friend WithEvents chkPlot As Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents lblPlotStyle As Windows.Forms.Label
    Friend WithEvents pcbTransparency As Windows.Forms.PictureBox
    Friend WithEvents lblPlotdevice As Windows.Forms.Label
    Friend WithEvents cmdCollapse As Windows.Forms.Button
    Friend WithEvents chkPlotStyles As Windows.Forms.CheckBox
    Friend WithEvents radioPortrait As Windows.Forms.RadioButton
    Friend WithEvents radioLandscape As Windows.Forms.RadioButton
    Friend WithEvents cmbPapersize As Windows.Forms.ComboBox
    Friend WithEvents cmdChangeMediaSize As Windows.Forms.Button
End Class
