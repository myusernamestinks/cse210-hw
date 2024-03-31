using System;

public class Product
{
    private string _name;
    private int _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int productId, double pricePerUnit, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public double TotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public override string ToString()
    {
        return $"Product Name: {_name}\nProduct ID: {_productId}\nPrice Per Unit: ${_pricePerUnit}\nQuantity: {_quantity}";
    }
}
