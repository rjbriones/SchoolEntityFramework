Imports Modules.Courses.ViewModels
Public Class CRUDCoursesListView
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Grid.DataContext = New CRUDCoursesListViewModel(Me)
    End Sub
End Class
