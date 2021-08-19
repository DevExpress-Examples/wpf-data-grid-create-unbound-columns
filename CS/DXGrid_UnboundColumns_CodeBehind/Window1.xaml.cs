using DevExpress.Xpf.Grid;
using System;
using System.Windows;

namespace DXGrid_UnboundColumns_CodeBehind {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = new dsProductsTableAdapters.ProductsTableAdapter().GetData();
        }

        private void grid_CustomUnboundColumnData(object sender, GridColumnDataEventArgs e) {
            if(e.IsGetData) {
                int price = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"));
                int unitsOnOrder = Convert.ToInt32(e.GetListSourceFieldValue("UnitsOnOrder"));
                e.Value = price * unitsOnOrder;
            }
        }
    }
}
