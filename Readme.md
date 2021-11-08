<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649520/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1503)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - How to Create Unbound Columns

This example shows how to add an unbound column to the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl). This column should display the total price, calculated as follows: **UnitPrice * UnitsOnOrder**.

![](https://docs.devexpress.com/WPF/images/GridControl_CustomUnboundColumnDataCommand.png?v=21.2) 

<!-- default file list -->

## Files to Look At

### Code Behind Technique

- [MainWindow.xaml](./CS/DXGrid_UnboundColumns_CodeBehind/Window1.xaml) ([MainWindow.xaml](./VB/DXGrid_UnboundColumns_CodeBehind/Window1.xaml))
- [MainWindow.xaml.cs](./CS/DXGrid_UnboundColumns_CodeBehind/Window1.xaml.cs#L12-L18) ([MainWindow.xaml.vb](./VB/DXGrid_UnboundColumns_CodeBehind/Window1.xaml.vb#L14-L20))

### MVVM Technique

- [MainWindow.xaml](./CS/DXGrid_UnboundColumns_MVVM/MainWindow.xaml) ([MainWindow.xaml](./VB/DXGrid_UnboundColumns_MVVM/MainWindow.xaml))
- [MainViewModel.cs](./CS/DXGrid_UnboundColumns_MVVM/ViewModel.cs#L15-L21) ([MainViewModel.vb](./VB/DXGrid_UnboundColumns_MVVM/ViewModel.vb#L17-L23))

<!-- default file list end -->

## Documentation

- [Unbound Columns](https://docs.devexpress.com/WPF/6124/controls-and-libraries/data-grid/grid-view-data-layout/columns-and-card-fields/unbound-columns)
- [GridControl.CustomUnboundColumnData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnData)
- [TreeListView.CustomUnboundColumnData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomUnboundColumnData)
- [GridControl.CustomUnboundColumnDataCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl.CustomUnboundColumnDataCommand)
- [TreeListView.CustomUnboundColumnDataCommand](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TreeListView.CustomUnboundColumnDataCommand)

## More Examples

- [How to Display an Icon in an Unbound Column Based on the Value in a Bound Column](https://github.com/DevExpress-Examples/how-to-display-an-icon-in-an-unbound-column-based-on-the-value-stored-in-a-bound-column-e1266)
- [How to Bind the WPF GridControl to Conditional Formatting Rules Specified in ViewModel](https://github.com/DevExpress-Examples/wpf-mvvm-how-to-bind-the-gridcontrol-to-conditional-formatting-rules-specified-in-viewmodel)
