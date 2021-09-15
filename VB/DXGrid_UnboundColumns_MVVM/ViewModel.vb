Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System.Data
Imports DXGrid_UnboundColumns_MVVM.dsProducts

Namespace DXGrid_UnboundColumns_MVVM
	Public Class ViewModel
		Inherits ViewModelBase

		Public Property Items() As ProductsDataTable

		Public Sub New()
			Items = (New dsProductsTableAdapters.ProductsTableAdapter()).GetData()
		End Sub

		<Command>
		Public Sub UnboundColumnDataCommand(ByVal args As UnboundColumnRowArgs)
			If args.IsGetData Then
				Dim item = DirectCast(DirectCast(args.Item, DataRowView).Row, ProductsRow)
				args.Value = item.UnitPrice * item.UnitsOnOrder
			End If
		End Sub
	End Class
End Namespace
