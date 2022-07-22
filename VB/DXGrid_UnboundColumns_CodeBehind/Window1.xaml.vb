Imports DevExpress.Xpf.Grid
Imports System
Imports System.Windows

Namespace DXGrid_UnboundColumns_CodeBehind

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = ProductList.GetData()
        End Sub

        Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As GridColumnDataEventArgs)
            If e.IsGetData Then
                Dim price As Integer = Convert.ToInt32(e.GetListSourceFieldValue(NameOf(Product.UnitPrice)))
                Dim quantity As Integer = Convert.ToInt32(e.GetListSourceFieldValue(NameOf(Product.Quantity)))
                e.Value = price * quantity
            End If
        End Sub
    End Class
End Namespace
