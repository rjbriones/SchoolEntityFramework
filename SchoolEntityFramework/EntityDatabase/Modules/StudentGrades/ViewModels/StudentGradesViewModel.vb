﻿Imports BusinessLogic.Helpers
Imports BusinessLogic.Services.Implementations
Imports BusinessLogic.Services.Interfaces
Imports System.Collections.ObjectModel

Namespace Modules.StudentGrades.ViewModels
    Public Class StudentGradesViewModel
        Inherits ViewModelBase

        Private _studentgrades As ObservableCollection(Of StudentGrade)
        Private dataAccess As IStudentGradeService

        Public Property StudentGrades As ObservableCollection(Of StudentGrade)
            Get
                Return Me._studentgrades
            End Get
            Set(value As ObservableCollection(Of StudentGrade))
                Me._studentgrades = value
                OnPropertyChanged("StudentGrade")
            End Set
        End Property

        ' Function to get all departments from service
        Private Function GetAllStudentGrades() As IQueryable(Of StudentGrade)
            Return Me.dataAccess.GetAllStudentGrades
        End Function

        Sub New()
            'Initialize property variable of departments
            Me._studentgrades = New ObservableCollection(Of StudentGrade)
            ' Register service with ServiceLocator
            ServiceLocator.RegisterService(Of IStudentGradeService)(New StudentGradeService)
            ' Initialize dataAccess from service
            Me.dataAccess = GetService(Of IStudentGradeService)()
            ' Populate departments property variable 
            For Each element In Me.GetAllStudentGrades
                Me._studentgrades.Add(element)
            Next
        End Sub
    End Class
End Namespace

