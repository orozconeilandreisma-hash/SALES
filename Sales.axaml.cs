using Avalonia.Controls;
using System.Collections.ObjectModel;

namespace Avalonia_DB_Connection;

public class Sale
{
    public int id { get; set; }
    public string productname { get; set; } = "";
    public string Quantity { get; set; } = "";

    public string Date { get; set; } = "";
    
    public string Time { get; set; } = "";
    
    public string TotalPrice { get; set; } = "";

}

public partial class Sales : UserControl   
{
    public ObservableCollection<Sale> Product { get; } = new();

    public Sales()
    {
        InitializeComponent();

        Product.Add(new Sale { id = 1, productname = "Computer Mouse", Quantity = "2",Date  = "10-09-26", Time = "10:20 AM"});
        Product.Add(new Sale { id = 2, productname = "HeadSet", Quantity = "1",Date  = "10-08-26",Time = "8:30 AM"  });
        Product.Add(new Sale { id = 3, productname = "Keyboard", Quantity = "2",Date  = "10-07-26", Time = "3:30 PM" });
        Product.Add(new Sale { id = 4, productname = "Cooler", Quantity = "1",Date = "10-09-26", Time = "11:00 AM"  });
        Product.Add(new Sale { id = 5, productname = "Gaming Pc", Quantity = "2",Date = "10-10-26", Time = "12:00 AM"  });
        
        MyTable.ItemsSource = Product;
    }
}
