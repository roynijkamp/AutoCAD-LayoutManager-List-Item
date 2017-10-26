Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Autodesk.AutoCAD.DatabaseServices
Public Class RN_UCLayoutItem
    Inherits System.Windows.Forms.UserControl

    Private oLayoutID As ObjectId
    Private sLayoutName As String = "Not Set"
    Private sLayoutNameOld As String = "" 'Old value before edit
    Private bIsEdit As Boolean = False
    Private bCheckState As Boolean = False
    Private bGetDragged As Boolean = False


    Public Property LayoutID() As ObjectId
        Get
            Return oLayoutID
        End Get
        Set(value As ObjectId)
            oLayoutID = value
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
        Return True
    End Function

    Public Function hideButtons()
        cmdPlot.Visible = False
        chkPlot.Visible = False
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
        If e.KeyCode = Keys.Enter Then
            'wijzigingen verwerken bij enter in textbox
            updateName()
            RaiseEvent LayoutNameEdit_KeyDown(Me, e)
        End If
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
End Class
