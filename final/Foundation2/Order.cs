using System;
using System.Collections.Generic;

public class Order
{
    private const double SHIPPING_USA = 5.0;
    private const double SHIPPING_INTL = 35.0;

    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double TotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.TotalCost();
        }

        double shippingCost = _customer.IsInUSA() ? SHIPPING_USA : SHIPPING_INTL;
        totalCost += shippingCost;

        return totalCost;
    }

    public string PackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.ToString()}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"Shipping Label:\n{_customer.ToString()}";
    }
}
