﻿#ExternalChecksum("..\..\..\..\..\Modules\OnlineCourses\Views\OnlineCoursesList.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","F16C8E4248333DF0925779B9415E1667")
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell

Namespace Modules.OnlineCourses.Views
    
    '''<summary>
    '''OnlineCoursesList
    '''</summary>
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Public Class OnlineCoursesList
        Inherits System.Windows.Controls.UserControl
        Implements System.Windows.Markup.IComponentConnector
        
        
        #ExternalSource("..\..\..\..\..\Modules\OnlineCourses\Views\OnlineCoursesList.xaml",8)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents MainGrid As System.Windows.Controls.Grid
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\..\..\Modules\OnlineCourses\Views\OnlineCoursesList.xaml",13)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents CourseIDColumn As System.Windows.Controls.DataGridTextColumn
        
        #End ExternalSource
        
        
        #ExternalSource("..\..\..\..\..\Modules\OnlineCourses\Views\OnlineCoursesList.xaml",14)
        <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
        Friend WithEvents URLColumn As System.Windows.Controls.DataGridTextColumn
        
        #End ExternalSource
        
        Private _contentLoaded As Boolean
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
        Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true
            Dim resourceLocater As System.Uri = New System.Uri("/EntityDatabase;component/modules/onlinecourses/views/onlinecourseslist.xaml", System.UriKind.Relative)
            
            #ExternalSource("..\..\..\..\..\Modules\OnlineCourses\Views\OnlineCoursesList.xaml",1)
            System.Windows.Application.LoadComponent(Me, resourceLocater)
            
            #End ExternalSource
        End Sub
        
        <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
         System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
         System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
        Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
            If (connectionId = 1) Then
                Me.MainGrid = CType(target,System.Windows.Controls.Grid)
                Return
            End If
            If (connectionId = 2) Then
                Me.CourseIDColumn = CType(target,System.Windows.Controls.DataGridTextColumn)
                Return
            End If
            If (connectionId = 3) Then
                Me.URLColumn = CType(target,System.Windows.Controls.DataGridTextColumn)
                Return
            End If
            Me._contentLoaded = true
        End Sub
    End Class
End Namespace

