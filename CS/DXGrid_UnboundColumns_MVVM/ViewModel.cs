using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Xpf;
using System.Collections.ObjectModel;

namespace DXGrid_UnboundColumns_MVVM {
    public class ViewModel : ViewModelBase {
        public ObservableCollection<Product> Items { get; set; }
        public ViewModel() {
            Items = ProductList.GetData();
        }

        [Command]
        public void UnboundColumnData(UnboundColumnRowArgs args) {
            if(args.IsGetData) {
                var item = (Product)args.Item;
                args.Value = item.UnitPrice * item.Quantity;
            }
        }
    }
}
