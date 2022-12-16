Imports System.Windows
Imports System.Windows.Controls

Namespace BarStaticItemEx

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            AddHandler Me.rtfEditor.SelectionChanged, New RoutedEventHandler(AddressOf rtfEditor_SelectionChanged)
        End Sub

        Private Sub rtfEditor_SelectionChanged(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim line As Integer = 0
            Dim col As Integer = 0
            Me.rtfEditor.CaretPosition.GetLineStartPosition(-100000, line)
            col = Me.rtfEditor.CaretPosition.GetOffsetToPosition(Me.rtfEditor.CaretPosition.GetLineStartPosition(0))
            Me.staticItemLine.Content = "Line: " & (-line).ToString() & "  Position: " & (-col).ToString()
        End Sub
    End Class
End Namespace
