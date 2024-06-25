<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649520/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1503)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Create Unbound Columns

This example shows how to add an unbound column to the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl). This column should display the total price, calculated as follows: **UnitPrice * Quantity**.

![image](https://user-images.githubusercontent.com/65009440/180465144-f19d5406-684e-47ed-b772-7d951f28ebb1.png)

<!-- default file list -->

## Files to Look At

### Code Behind Technique

- [MainWindow.xaml](./CS/DXGrid_UnboundColumns_CodeBehind/Window1.xaml) ([MainWindow.xaml](./VB/DXGrid_UnboundColumns_CodeBehind/Window1.xaml))
- [MainWindow.xaml.cs](./CS/DXGrid_UnboundColumns_CodeBehind/Window1.xaml.cs#L12-L18) ([MainWindow.xaml.vb](./VB/DXGrid_UnboundColumns_CodeBehind/Window1.xaml.vb#L15-L21))

### MVVM Technique

- [MainWindow.xaml](./CS/DXGrid_UnboundColumns_MVVM/MainWindow.xaml) ([MainWindow.xaml](./VB/DXGrid_UnboundColumns_MVVM/MainWindow.xaml))
- [MainViewModel.cs](./CS/DXGrid_UnboundColumns_MVVM/ViewModel.cs#L15-L21) ([MainViewModel.vb](./VB/DXGrid_UnboundColumns_MVVM/ViewModel.vb#L18-L24))

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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-create-unbound-columns&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-create-unbound-columns&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
