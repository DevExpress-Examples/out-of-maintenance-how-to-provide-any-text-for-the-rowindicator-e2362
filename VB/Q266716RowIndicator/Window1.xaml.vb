Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace Q266716RowIndicator
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Private list As New List(Of TestData)()
		Public Sub New()
			InitializeComponent()

			For i As Integer = 0 To 99
				list.Add(New TestData() With {.Text = "Row" & i, .Number = i})
			Next i
			gridControl.DataSource = list

		End Sub

		Private Sub GridControl_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.Wpf.Grid.GridColumnDataEventArgs)
			If e.Column.FieldName = "RowNumber" Then
				e.Value = gridControl.GetRowVisibleIndexByHandle(gridControl.GetRowHandleByListIndex(e.ListSourceRowIndex))
				'e.Value = e.ListSourceRowIndex;
			End If
		End Sub
	End Class

	Public Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
	End Class
End Namespace
