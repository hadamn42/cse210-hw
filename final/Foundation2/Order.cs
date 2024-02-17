public class Order{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer){
        _customer = customer;
    }

    public string TotalCost(){
        float total = 0;
        foreach(Product product in _products){
            total += product.ProdTotalPrice();
        }
        if (_customer.InUS() == true){
            total += 5;
        }
        else{
            total += 35;
        }
        string totalCost = $"\nTotal Cost: {total:C2}\n";
        return totalCost;
    }

    public string PackingLabel(){
        string label = "\nPacking Label:";
        foreach(Product product in _products){
            label += $"\n{product.GetLabel()}";
        }
        return label;
    }

    public string ShipAddressThing(){
        return _customer.AddressLabel();
    }

    public void AddToOrder(Product product, int quantity){
        _products.Add(product);
        _products[_products.Count() - 1].SetQuant(quantity);
        
    }
}