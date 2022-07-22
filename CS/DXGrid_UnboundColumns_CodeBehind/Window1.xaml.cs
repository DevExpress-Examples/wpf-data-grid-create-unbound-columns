using DevExpress.Xpf.Grid;
using System;
using System.Windows;

namespace DXGrid_UnboundColumns_CodeBehind {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = ProductList.GetData();
        }
        void grid_CustomUnboundColumnData(object sender, GridColumnDataEventArgs e) {
            if(e.IsGetData) {
                int price = Convert.ToInt32(e.GetListSourceFieldValue(nameof(Product.UnitPrice)));
                int quantity = Convert.ToInt32(e.GetListSourceFieldValue(nameof(Product.Quantity)));
                e.Value = price * quantity;
            }
        }
    }
}
