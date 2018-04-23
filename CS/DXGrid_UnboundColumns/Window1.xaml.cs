// Developer Express Code Central Example:
// How to create unbound columns
// 
// This example shows how to add an unbound column to the DXGrid control. This
// column should display the total price, calculated as follows: UnitPrice *
// UnitsOnOrder.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1503

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid;

namespace DXGrid_UnboundColumns {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.ItemsSource = new dsProductsTableAdapters.ProductsTableAdapter().GetData();
        }

        private void grid_CustomUnboundColumnData(object sender, GridColumnDataEventArgs e) {
            if (e.IsGetData) {
                int price = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"));
                int unitsOnOrder = Convert.ToInt32(e.GetListSourceFieldValue("UnitsOnOrder"));
                e.Value = price * unitsOnOrder;
            }
        }
    }


}
