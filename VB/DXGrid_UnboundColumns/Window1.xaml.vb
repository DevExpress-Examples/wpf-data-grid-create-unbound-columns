Imports System
Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace DXGrid_UnboundColumns

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New dsProductsTableAdapters.ProductsTableAdapter().GetData()
        End Sub

        Private Sub grid_CustomUnboundColumnData(ByVal sender As Object, ByVal e As GridColumnDataEventArgs)
            If e.IsGetData Then
                Dim price As Integer = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"))
                Dim unitsOnOrder As Integer = Convert.ToInt32(e.GetListSourceFieldValue("UnitsOnOrder"))
                e.Value = price * unitsOnOrder
            End If
        End Sub
    End Class
End Namespace
