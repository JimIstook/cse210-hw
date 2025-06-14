using System;

public class Product
{
    private string _name;
    private string _productId;
    private double _unitPrice;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _productId = id;
        _unitPrice = price;
        _quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return _unitPrice * _quantity;
    }
    public string GetProductInfo()
    {
        return $"{_name}: {_productId}";
    }
}