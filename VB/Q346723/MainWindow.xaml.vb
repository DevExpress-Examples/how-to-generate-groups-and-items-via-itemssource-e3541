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
Imports DevExpress.Xpf.NavBar

Namespace Q346723
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			DataContext = Groups.Create()
			InitializeComponent()
		End Sub
	End Class
	Public Class Groups
		Inherits List(Of Group)
		Public Shared Function Create() As Groups
			Dim res As New Groups()
			For i As Integer = 0 To 4
				Dim gr As New Group() With {.Header = "Group " & i.ToString()}
				gr.Items = Items.Create(gr.Header)
				res.Add(gr)
			Next i
			Return res
		End Function
	End Class
	Public Class Group
		Private privateHeader As String
		Public Property Header() As String
			Get
				Return privateHeader
			End Get
			Set(ByVal value As String)
				privateHeader = value
			End Set
		End Property
		Private privateItems As Items
		Public Property Items() As Items
			Get
				Return privateItems
			End Get
			Set(ByVal value As Items)
				privateItems = value
			End Set
		End Property
	End Class
	Public Class Items
		Inherits List(Of Item)
		Public Shared Function Create(ByVal groupName As String) As Items
			Dim res As New Items()
			For i As Integer = 0 To 9
				Dim item As New Item() With {.Header = groupName & ", Header " & i.ToString()}
				res.Add(item)
			Next i
			Return res
		End Function
	End Class
	Public Class Item
		Private privateHeader As String
		Public Property Header() As String
			Get
				Return privateHeader
			End Get
			Set(ByVal value As String)
				privateHeader = value
			End Set
		End Property
	End Class
End Namespace
