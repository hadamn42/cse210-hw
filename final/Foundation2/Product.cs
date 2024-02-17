public class Product{
    private string _name;
    private string _prodID;
    private float _price;
    private int _quantity;

    public Product(string name, string prodID, float price){
        _name = name;
        _prodID = prodID;
        _price = price;
    }

    public void SetQuant (int quantity){
        _quantity = quantity;
    }

    public float ProdTotalPrice(){
        return _price * _quantity;
    }

    public string GetLabel(){
        return $"{_name} ({_prodID}): {_quantity}";
    }
}