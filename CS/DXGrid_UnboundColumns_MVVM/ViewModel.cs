using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System.Data;
using static DXGrid_UnboundColumns_MVVM.dsProducts;

namespace DXGrid_UnboundColumns_MVVM {
    public class ViewModel : ViewModelBase {
        public ProductsDataTable Items { get; set; }

        public ViewModel() {
            Items = new dsProductsTableAdapters.ProductsTableAdapter().GetData();
        }

        [Command]
        public void UnboundColumnDataCommand(UnboundColumnRowArgs args) {
            if(args.IsGetData) {
                var item = (ProductsRow)((DataRowView)args.Item).Row;
                args.Value = item.UnitPrice * item.UnitsOnOrder;
            }
        }
    }
}
