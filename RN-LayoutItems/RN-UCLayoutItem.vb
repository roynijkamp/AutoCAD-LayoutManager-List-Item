﻿Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.DatabaseServices
Public Class RN_UCLayoutItem
    Inherits System.Windows.Forms.UserControl

    Private oLayoutID As ObjectId
    Private sLayoutHandle As String
    Private sLayoutName As String = "Not Set"
    Private sLayoutNameOld As String = "" 'Old value before edit
    Private bIsEdit As Boolean = False
    Private bIsModel As Boolean = False
    Private bCheckState As Boolean = False
    Private bGetDragged As Boolean = False
    Private bIsCurrent As Boolean = False
    Private sPlotStyle As String = "Not Set"
    Private sPlotDevice As String = "Not Set"
    Private bPlotTransparency As Boolean = False


    Public Property LayoutID() As ObjectId
        Get
            Return oLayoutID
        End Get
        Set(value As ObjectId)
            oLayoutID = value
        End Set
    End Property

    Public Property LayoutHandle As String
        Get
            Return sLayoutHandle
        End Get
        Set(value As String)
            sLayoutHandle = value
        End Set
    End Property

    Public Property LayoutName As String
        Get
            Return sLayoutName
        End Get
        Set(value As String)
            sLayoutName = value
        End Set
    End Property

    Public Property LayoutNameOld As String
        Get
            Return sLayoutNameOld
        End Get
        Set(value As String)
            sLayoutNameOld = value
        End Set
    End Property

    Public Property CheckState As Boolean
        Get
            Return bCheckState
        End Get
        Set(value As Boolean)
            bCheckState = value
        End Set
    End Property

    Public Property GetDragged As Boolean
        Get
            Return bGetDragged
        End Get
        Set(value As Boolean)
            bGetDragged = value
        End Set
    End Property

    Public Property IsCurrent As Boolean
        Get
            Return bIsCurrent
        End Get
        Set(value As Boolean)
            bIsCurrent = value
        End Set
    End Property

    Public Property IsModel As Boolean
        Get
            Return bIsModel
        End Get
        Set(value As Boolean)
            bIsModel = value
        End Set
    End Property

    Public Property PlotStyle As String
        Get
            Return sPlotStyle
        End Get
        Set(value As String)
            sPlotStyle = value
        End Set
    End Property

    Public Property PlotDevice As String
        Get
            Return sPlotDevice
        End Get
        Set(value As String)
            sPlotDevice = value
        End Set
    End Property

    Public Property PlotTransparency As Boolean
        Get
            Return bPlotTransparency
        End Get
        Set(value As Boolean)
            bPlotTransparency = value
        End Set
    End Property

    ''' <summary>
    ''' 'Function to update contents of control
    ''' </summary>
    ''' <returns>true</returns>

    Public Function updateItem()
        txtLayoutName.Text = sLayoutName
        txtLayoutName.Visible = bIsEdit
        If bIsEdit Then 'set focus to textbox
            txtLayoutName.Focus()
        End If
        lblLayoutName.Text = sLayoutName
        lblLayoutName.Visible = Not bIsEdit
        lblPlotStyle.Text = sPlotStyle
        lblPlotStyle.Visible = Not bIsEdit
        lblPlotdevice.Text = sPlotDevice
        lblPlotdevice.Visible = Not bIsEdit
        If bPlotTransparency Then
            pcbTransparency.BackgroundImage = My.Resources.icon_transparency_on
            ToolTip1.SetToolTip(pcbTransparency, "Plot met Transparatie is ingeschakeld" & vbCrLf & "Klik om het afdrukken met Transparatie uit te schakelen")
        Else
            pcbTransparency.BackgroundImage = My.Resources.icon_transparency_off
            ToolTip1.SetToolTip(pcbTransparency, "Plot met Transparatie is uitgeschakeld" & vbCrLf & "Klik om het afdrukken met Transparatie in te schakelen")
        End If
        If Not bIsModel Then
            pcbTransparency.Visible = Not bIsEdit
        End If
        'scale width based on largest label
        Dim dItemWidth As Double = 350
        If lblLayoutName.Width > lblPlotStyle.Width Then
            If lblLayoutName.Width > 350 Then
                dItemWidth = lblLayoutName.Width + 20
            End If
        ElseIf lblPlotStyle.Width > lblPlotStyle.Width Then
            If lblPlotStyle.Width > 350 Then
                dItemWidth = lblPlotStyle.Width + 20
            End If
        End If
        lblPlotdevice.Left = lblPlotStyle.Left + lblPlotStyle.Width
        'set width
        Me.Width = dItemWidth
        'redraw
        Me.Update()
        Return True
    End Function

    Public Function hideButtons()
        cmdPlot.Visible = False
        chkPlot.Visible = False
        pcbTransparency.Visible = False
        Return True
    End Function

    Public Function isDragged()
        If bGetDragged Then
            Me.BackColor = SystemColors.ActiveCaption
        Else
            Me.BackColor = SystemColors.Control
        End If
        Return True
    End Function

    Public Function isCurrentLayout()
        If bIsCurrent Then
            Me.BackColor = SystemColors.Info
        Else
            Me.BackColor = SystemColors.Control
        End If
        Return True
    End Function

    Public Function SetCheckState(ByVal bChecked As Boolean)
        chkPlot.Checked = bChecked
        bCheckState = chkPlot.Checked
        Return True
    End Function

    ''' <summary>
    ''' 'Function to update name with contents of textbox
    ''' </summary>
    ''' <returns>true</returns>
    Public Function updateName()
        If bIsEdit Then
            sLayoutName = txtLayoutName.Text
            bIsEdit = False
        End If
        updateItem()
        Return True
    End Function
    ''' <summary>
    ''' 'Public event to detect click on view button
    ''' </summary>
    ''' <param name="sender">control</param>
    ''' <param name="e"></param>
    Public Event View_Click(sender As Object, e As EventArgs)
    ''' <summary>
    ''' 'click event on view button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdView_Click(sender As Object, e As EventArgs) Handles cmdView.Click
        RaiseEvent View_Click(Me, e)
    End Sub

    Public Event LayoutName_DoubleClick(sender As Object, e As EventArgs)

    Private Sub lblLayoutName_DoubleClick(sender As Object, e As EventArgs) Handles lblLayoutName.DoubleClick
        bIsEdit = True
        sLayoutNameOld = sLayoutName
        updateItem()
        RaiseEvent LayoutName_DoubleClick(Me, e)
    End Sub

    Private Sub txtLayoutName_Validating(sender As Object, e As CancelEventArgs) Handles txtLayoutName.Validating
        'wijzigingen verwerken bij het verlaten van de textbox
        updateName()
    End Sub

    Public Event LayoutNameEdit_KeyDown(sender As Object, e As EventArgs)

    Private Sub txtLayoutName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLayoutName.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Return Or e.KeyCode = Keys.Tab Then
            'wijzigingen verwerken bij enter in textbox
            updateName()
            RaiseEvent LayoutNameEdit_KeyDown(Me, e)
        End If
    End Sub

    Public Event plotTransparency_Click(sender As Object, e As EventArgs)

    Private Sub pcbTransparency_Click(sender As Object, e As EventArgs) Handles pcbTransparency.Click
        RaiseEvent plotTransparency_Click(Me, e)
    End Sub


    Public Event Plot_Click(sender As Object, e As EventArgs)

    Private Sub cmdPlot_Click(sender As Object, e As EventArgs) Handles cmdPlot.Click
        RaiseEvent Plot_Click(Me, e)
    End Sub

    Public Event Plot_CheckedChanged(sender As Object, e As EventArgs)

    Private Sub chkPlot_CheckStateChanged(sender As Object, e As EventArgs) Handles chkPlot.CheckStateChanged
        bCheckState = chkPlot.Checked
        RaiseEvent Plot_CheckedChanged(Me, e)
    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs)
        updateName()
        RaiseEvent LayoutNameEdit_KeyDown(Me, e)
    End Sub

    Private Sub txtLayoutName_LostFocus(sender As Object, e As EventArgs) Handles txtLayoutName.LostFocus
        'wijzigingen verwerken bij focus verlies
        If bIsEdit Then
            updateName()
            RaiseEvent LayoutNameEdit_KeyDown(Me, e)
        End If
    End Sub


End Class
