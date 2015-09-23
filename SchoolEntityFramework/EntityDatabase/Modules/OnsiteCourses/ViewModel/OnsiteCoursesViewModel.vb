Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.OnsiteCourses.ViewModels
    Public Class OnsiteCoursesViewModel
        Inherits ViewModelBase

        Private _onsitecourses As ObservableCollection(Of OnsiteCourse)
        Private dataAccess As IOnsiteCourseService

        Public Property OnsiteCourses As ObservableCollection(Of OnsiteCourse)
            Get
                Return Me._onsitecourses
            End Get
            Set(value As ObservableCollection(Of OnsiteCourse))
                Me._onsitecourses = value
                OnPropertyChanged("OnsiteCourses")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllOnsiteCourses() As IQueryable(Of OnsiteCourse)
            Return Me.dataAccess.GetAllOnsiteCourses
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._onsitecourses = New ObservableCollection(Of OnsiteCourse)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IOnsiteCourseService)(New OnsiteCourseService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IOnsiteCourseService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllOnsiteCourses
                Me._onsitecourses.Add(element)
            Next
        End Sub
    End Class
End Namespace
