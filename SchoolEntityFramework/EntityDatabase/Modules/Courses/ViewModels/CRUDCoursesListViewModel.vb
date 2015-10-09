Imports BusinessLogic.Helpers
Imports Infrastructure.Helpers
Imports BusinessObjects.Helpers
Imports System.Collections.ObjectModel
Imports BusinessLogic.Services.Interfaces

Namespace Modules.Courses.ViewModels
    Public Class CRUDCoursesListViewModel
        Inherits ViewModelBase
        Public _window As CRUDCoursesListView
        Private _course As New Course
        Private _departments As ObservableCollection(Of Department)
        Private _showD As Department
        Private dataAccess As IDepartmentService
        Public _accept As ICommand
        Public _cancel As ICommand

        Public ReadOnly Property Accept As ICommand
            Get
                If Me._accept Is Nothing Then
                    Me._accept = New RelayCommand(AddressOf Aprove)
                End If
                Return Me._accept
            End Get
        End Property

        Public ReadOnly Property Cancel As ICommand
            Get
                If Me._cancel Is Nothing Then
                    Me._cancel = New RelayCommand(AddressOf Deny)
                End If
                Return Me._cancel
            End Get
        End Property
        Public Property Title As String
            Get
                Return Me._course.Title
            End Get
            Set(value As String)
                Me._course.Title = value
                OnPropertyChanged("Title")
            End Set
        End Property

        Public Property Credits As String
            Get
                Return Me._course.Credits
            End Get
            Set(value As String)
                Me._course.Credits = value
                OnPropertyChanged("Credits")
            End Set
        End Property

        Public Property ShowD As Department
            Get
                Return _showD
            End Get
            Set(value As Department)
                _course.Department = value
                OnPropertyChanged("ShowD")
            End Set
        End Property

        Public Property Departments As ObservableCollection(Of Department)
            Get
                Return _departments
            End Get
            Set(value As ObservableCollection(Of Department))
                _departments = value
                OnPropertyChanged("Departments")
            End Set
        End Property
        Sub Aprove()
            Try
                Dim courses As IQueryable(Of Course) = DataContext.DBEntities.Courses
                For Each element In courses
                    _course.CourseID = Integer.Parse(element.CourseID.ToString) + 1
                Next
                DataContext.DBEntities.Courses.Add(_course)
                DataContext.DBEntities.SaveChanges()
                _window.Close()
            Catch ex As Exception
                MessageBox.Show("Error, no se ha ingresado el curso", MsgBoxStyle.Critical)
            End Try
        End Sub

        Sub Deny()
            _window.Close()
        End Sub

        Sub New(ByRef view As CRUDCoursesListView)
            _departments = New ObservableCollection(Of Department)
            Dim departments As IQueryable(Of Department) = DataContext.DBEntities.Departments
            For Each elemet In departments
                _departments.Add(elemet)
            Next
            Me._window = view
        End Sub
    End Class
End Namespace