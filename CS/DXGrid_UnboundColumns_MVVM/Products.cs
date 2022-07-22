using System.Collections.ObjectModel;

namespace DXGrid_UnboundColumns_MVVM {
    public class Product {
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
    public class ProductList {
        static public ObservableCollection<Product> GetData() {
            ObservableCollection<Product> list = new ObservableCollection<Product>();
            list.Add(new Product() {
                CompanyName = "Island Trading",
                Country = "UK",
                City = "Cowes",
                UnitPrice = 19,
                Quantity = 10
            });
            list.Add(new Product() {
                CompanyName = "Reggiani Caseifici",
                Country = "Italy",
                City = "Reggio Emilia",
                UnitPrice = 12.5,
                Quantity = 16
            });
            list.Add(new Product() {
                CompanyName = "Ricardo Adocicados",
                Country = "Brazil",
                City = "Rio de Janeiro",
                UnitPrice = 19,
                Quantity = 12
            });
            list.Add(new Product() {
                CompanyName = "QUICK-Stop",
                Country = "Germany",
                City = "QUICK-Stop",
                UnitPrice = 22,
                Quantity = 50
            });
            list.Add(new Product() {
                CompanyName = "Split Rail Beer & Ale",
                Country = "USA",
                City = "Reggio Emilia",
                UnitPrice = 18,
                Quantity = 20
            });
            list.Add(new Product() {
                CompanyName = "Ernst Handel",
                Country = "Austria",
                City = "Graz",
                UnitPrice = 21,
                Quantity = 52
            });
            list.Add(new Product() {
                CompanyName = "Save-a-lot Markets",
                Country = "USA",
                City = "Boise",
                UnitPrice = 7.75,
                Quantity = 120
            });
            list.Add(new Product() {
                CompanyName = "Tortuga Restaurante",
                Country = "Mexico",
                City = "México D.F.",
                UnitPrice = 21,
                Quantity = 15
            });
            list.Add(new Product() {
                CompanyName = "Bottom-Dollar Markets",
                Country = "Canada",
                City = "Tsawwassen",
                UnitPrice = 44,
                Quantity = 16
            });
            return list;
        }
    }
}
