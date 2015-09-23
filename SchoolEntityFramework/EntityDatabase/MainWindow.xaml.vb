Imports Modules.OfficeAssignments.ViewModels
Imports Modules.Persons.ViewModels
Imports Modules.Courses.ViewModels
Imports Modules.Departments.ViewModels
Imports Modules.OnlineCourses.ViewModels
Imports Modules.OnsiteCourses.ViewModels
Imports Modules.StudentGrades.ViewModels

Class MainWindow

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.OfficeAssignmentsUserControl.MainGrid.DataContext = New OfficeAssignmentsViewModel()
        Me.PersonsUserControl.MainGrid.DataContext = New PersonsViewModel()
        Me.CoursesUserControl.MainGrid.DataContext = New CoursesViewModel()
        Me.DepartmentsUserControl.MainGrid.DataContext = New DepartmentsViewModel()
        Me.OnlineCoursesUserControl.MainGrid.DataContext = New OnlineCoursesViewModel()
        Me.OnsiteCoursesUserControl.MainGrid.DataContext = New OnsiteCoursesViewModel()
        Me.StudentGradesUserControl.MainGrid.DataContext = New StudentGradesViewModel()


    End Sub
End Class
