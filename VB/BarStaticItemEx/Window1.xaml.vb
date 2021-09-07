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

Namespace BarStaticItemEx
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window

		Public Sub New()
			InitializeComponent()
			AddHandler rtfEditor.SelectionChanged, AddressOf rtfEditor_SelectionChanged
		End Sub

		Private Sub rtfEditor_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim line As Integer = 0
			Dim col As Integer = 0
			rtfEditor.CaretPosition.GetLineStartPosition(-100000, line)
			col = rtfEditor.CaretPosition.GetOffsetToPosition(rtfEditor.CaretPosition.GetLineStartPosition(0))
			staticItemLine.Content = "Line: " & (-line).ToString() & "  Position: " & (-col).ToString()
		End Sub
	End Class
End Namespace
