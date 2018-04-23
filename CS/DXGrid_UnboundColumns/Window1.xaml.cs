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
    #region #1 Window1 class
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = new dsProductsTableAdapters.ProductsTableAdapter().GetData();
        }

        private void grid_CustomUnboundColumnData(object sender, GridColumnDataEventArgs e) {
            if (e.IsGetData) {
                int price = Convert.ToInt32(e.GetListSourceFieldValue("UnitPrice"));
                int unitsOnOrder = Convert.ToInt32(e.GetListSourceFieldValue("UnitsOnOrder"));
                e.Value = price * unitsOnOrder;
            }
        }
    }
    #endregion #1
}
