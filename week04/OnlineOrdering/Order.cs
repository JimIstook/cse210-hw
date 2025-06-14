using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _totalPrice;

    public Order(string name, string address, string city, string state, string country)
    {
        _customer = new Customer(name, address, city, state, country);
        _totalPrice = 0;
    }

    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product newProduct = new Product(name, id, price, quantity);
        _products.Add(newProduct);
    }

    public double GetTotalPrice()
    {
        _totalPrice = 0;
        foreach (Product product in _products)
        {
            _totalPrice += product.GetTotalPrice();
        }
        if (_customer.IsLocal())
        {
            _totalPrice += 5;
        }
        else
        {
            _totalPrice += 35;
        }
        return _totalPrice;
    }
    public string DisplayPackingLabel()
    {
        string label = "";
        foreach (Product item in _products)
        {
            string itemInfo = item.GetProductInfo();
            label += $"{itemInfo}\n";
        }
        return label;
    }
    public string DisplayShippingLabel()
    {
        string label = $"{_customer.GetName()}\n{_customer.DisplayAddress()}";
        return label;
    }

}