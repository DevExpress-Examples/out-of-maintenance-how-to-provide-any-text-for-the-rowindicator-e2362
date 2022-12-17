Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Core

Namespace DXSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class GridViewModel
        Inherits ViewModelBase

        Public Property Items As ObservableCollection(Of ItemViewModel)
            Get
                Return GetProperty(Function() Me.Items)
            End Get

            Set(ByVal value As ObservableCollection(Of ItemViewModel))
                SetProperty(Function() Items, value)
            End Set
        End Property

        Public Sub New()
            Items = New ObservableCollection(Of ItemViewModel)()
            For i As Integer = 0 To 50 - 1
                Items.Add(New ItemViewModel() With {.Number = i, .Text = "Text" & i})
            Next
        End Sub
    End Class

    Public Class ItemViewModel
        Inherits ViewModelBase

        Public Property Text As String
            Get
                Return GetProperty(Function() Me.Text)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() Text, value)
            End Set
        End Property

        Public Property Number As Integer
            Get
                Return GetProperty(Function() Me.Number)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() Number, value)
            End Set
        End Property
    End Class
End Namespace
