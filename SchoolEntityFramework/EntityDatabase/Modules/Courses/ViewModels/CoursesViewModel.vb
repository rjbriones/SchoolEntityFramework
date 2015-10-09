﻿Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel
Imports Infrastructure.Helpers
Imports BusinessObjects.Helpers

Namespace Modules.Courses.ViewModels
    Public Class CoursesViewModel
        Inherits ViewModelBase

        Public Shadows _course As CRUDCoursesListView
        Private _delete As ICommand
        Private _insert As ICommand
        Private _selected As Course
        Private _courses As ObservableCollection(Of Course)
        Private dataAccess As ICourseService

        Public Property Courses As ObservableCollection(Of Course)
            Get
                Return Me._courses
            End Get
            Set(value As ObservableCollection(Of Course))
                Me._courses = value
                OnPropertyChanged("Courses")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllCourses() As IQueryable(Of Course)
            Return Me.dataAccess.GetAllCourses
        End Function

        Public Property DeleteCommand As ICommand
            Get
                If _delete Is Nothing Then
                    _delete = New RelayCommand(AddressOf DeleteDB)
                End If
                Return _delete
            End Get
            Set(value As ICommand)
                _delete = value
            End Set
        End Property

        Sub DeleteDB()
            If Selected IsNot Nothing Then
                DataContext.DBEntities.Courses.Remove((From item In DataContext.DBEntities.Courses
                                 Where Selected.CourseID = item.CourseID
                                 Select item).FirstOrDefault)
                DataContext.DBEntities.SaveChanges()
                Refresh()
            End If
        End Sub

        Public Property Selected As Course
            Get
                Return _selected
            End Get
            Set(value As Course)
                _selected = value
            End Set
        End Property

        Public Property AddCommand As ICommand
            Get
                If Me._insert Is Nothing Then
                    Me._insert = New RelayCommand(AddressOf AddDepartmentToDB)
                End If
                Return Me._insert
            End Get
            Set(value As ICommand)
                _insert = value
            End Set
        End Property
        Sub AddDepartmentToDB()
            Using school As New SchoolEntities
                _course = New CRUDCoursesListView
                _course.ShowDialog()
                Refresh()
            End Using
        End Sub

        Sub Refresh()
            'Initialize property variable of departments
            Me.Courses.Clear()
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of ICourseService)(New CourseService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of ICourseService)()
            ' Populate departments property variable  
            For Each element In Me.GetAllCourses
                Me._courses.Add(element)
            Next
        End Sub

        Sub New()
            Me.Courses = New ObservableCollection(Of Course)
            Refresh()
        End Sub

    End Class
End Namespace

