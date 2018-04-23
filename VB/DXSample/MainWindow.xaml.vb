Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Core

Namespace DXSample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits DXWindow

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    Public Class GridViewModel
        Inherits ViewModelBase

        Public Property Items() As ObservableCollection(Of ItemViewModel)
            Get
                Return GetProperty(Function() Items)
            End Get
            Set(ByVal value As ObservableCollection(Of ItemViewModel))
                SetProperty(Function() Items, value)
            End Set
        End Property
        Public Sub New()
            Items = New ObservableCollection(Of ItemViewModel)()
            For i As Integer = 0 To 49
                Items.Add(New ItemViewModel() With { _
                    .Number = i, _
                    .Text = "Text" & i _
                })
            Next i
        End Sub

    End Class
    Public Class ItemViewModel
        Inherits ViewModelBase

        Public Property Text() As String
            Get
                Return GetProperty(Function() Text)
            End Get
            Set(ByVal value As String)
                SetProperty(Function() Text, value)
            End Set
        End Property
        Public Property Number() As Integer
            Get
                Return GetProperty(Function() Number)
            End Get
            Set(ByVal value As Integer)
                SetProperty(Function() Number, value)
            End Set
        End Property
    End Class
End Namespace
