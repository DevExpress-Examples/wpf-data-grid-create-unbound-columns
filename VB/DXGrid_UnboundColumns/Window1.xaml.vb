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

Namespace DXGrid_UnboundColumns
	#Region "#1 Window1 class"
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = New dsProductsTableAdapters.ProductsTableAdapter().GetData()
		End Sub

		Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, _
				ByVal e As DevExpress.Xpf.Grid.GridColumnDataEventArgs)
			If e.IsGetData Then
				Dim price As Integer = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"))
				Dim unitsOnOrder As Integer = _
					Convert.ToInt32(e.GetListSourceFieldValue("UnitsOnOrder"))
				e.Value = price * unitsOnOrder
			End If
		End Sub
	End Class
	#End Region ' #1
End Namespace
