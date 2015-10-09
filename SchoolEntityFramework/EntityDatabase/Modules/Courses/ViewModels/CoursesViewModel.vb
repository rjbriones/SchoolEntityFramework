Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Imports Infrastructure.Helpers
Imports BusinessObjects.Helpers

Namespace Modules.Courses.ViewModels
    Public Class CoursesViewModel
        Inherits ViewModelBase

        Public Shadows _course As CRUDCoursesListView
        Private data As ICourseService
        Private _show As Course
        Private _courses As ObservableCollection(Of Course)
        Private _delete As ICommand
        Private _insert As ICommand

        Public Property Add As ICommand
            Get
                If Me._insert Is Nothing Then
                    Me._insert = New RelayCommand(AddressOf DatabaseDepartment)
                End If
                Return Me._insert
            End Get
            Set(value As ICommand)
                _insert = value
            End Set
        End Property
        Sub DatabaseDepartment()
            Using school As New SchoolEntities
                _course = New CRUDCoursesListView
                _course.ShowDialog()
                Charge()
            End Using
        End Sub
        Public Property Delete As ICommand
            Get
                If _delete Is Nothing Then
                    _delete = New RelayCommand(AddressOf DatabaseDelete)
                End If
                Return _delete
            End Get
            Set(value As ICommand)
                _delete = value
            End Set
        End Property

        Sub DatabaseDelete()
            If Show IsNot Nothing Then
                DataContext.DBEntities.Courses.Remove((From item In DataContext.DBEntities.Courses
                                 Where Show.CourseID = item.CourseID
                                 Select item).FirstOrDefault)
                DataContext.DBEntities.SaveChanges()
                Charge()
            End If
        End Sub

        Public Property Courses As ObservableCollection(Of Course)
            Get
                Return Me._courses
            End Get
            Set(value As ObservableCollection(Of Course))
                Me._courses = value
                OnPropertyChanged("Courses")
            End Set
        End Property

        Private Function GetCourses() As IQueryable(Of Course)
            Return Me.data.GetAllCourses
        End Function
        

        Public Property Show As Course
            Get
                Return _show
            End Get
            Set(value As Course)
                _show = value
            End Set
        End Property

        Sub Charge()
            Me.Courses.Clear()
            ServiceLocator.RegisterService(Of ICourseService)(New CourseService)
            Me.data = GetService(Of ICourseService)()
            For Each element In Me.GetCourses
                Me._courses.Add(element)
            Next
        End Sub

        Sub New()
            Me.Courses = New ObservableCollection(Of Course)
            Charge()
        End Sub
    End Class
End Namespace

