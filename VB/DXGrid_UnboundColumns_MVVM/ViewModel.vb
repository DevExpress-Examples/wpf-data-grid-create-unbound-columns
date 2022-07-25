Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System.Collections.ObjectModel

Namespace DXGrid_UnboundColumns_MVVM

    Public Class ViewModel
        Inherits ViewModelBase

        Public Property Items As ObservableCollection(Of Product)

        Public Sub New()
            Items = ProductList.GetData()
        End Sub

        <Command>
        Public Sub UnboundColumnData(ByVal args As UnboundColumnRowArgs)
            If args.IsGetData Then
                Dim item = CType(args.Item, Product)
                args.Value = item.UnitPrice * item.Quantity
            End If
        End Sub
    End Class
End Namespace
