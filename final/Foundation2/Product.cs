using System;

public class Product
{
    private List<string> products = new List<string>{};
    private List<string> productids = new List<string>{};
    private List<double> priceperunits = new List<double>{};
    private List<int> quantities = new List<int>{};
    private List<double> totals = new List<double>{};

    public void GetProducts(string product, string productid, double priceperunit, int quantity)
    {
        products.Add(product);
        productids.Add(productid);
        priceperunits.Add(priceperunit);
        quantities.Add(quantity);
        totals.Add(priceperunit * quantity);
    }

    public void Display()
    {
        int index = 0;
        foreach (string product in products)
        {
            Console.WriteLine($"{product}, {productids[index]}, {priceperunits[index]}, {quantities[index]}");
            index = index + 1;
        }
    }

    public double ProductTotal()
    {
        double total = 0;
        foreach (double price in totals)
        {
            total = total + price;
        }
        return total;
    }
}