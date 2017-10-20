Imports Autodesk.AutoCAD.DatabaseServices
Public Class RN_UCLayoutItem
    Inherits System.Windows.Forms.UserControl

    Private oLayoutID As ObjectId
    Private sLayoutName As String = "Not Set"


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


    Public Function updateItem()
        txtLayoutName.Text = sLayoutName
        Return True
    End Function
End Class
