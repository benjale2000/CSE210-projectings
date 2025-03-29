using System;

public class Order
{
    private int _shipcost = 5;
    private int _foreignshipcost = 35;
    private double _totalshippingcost = 0;

    Customer c1 = new Customer();
    Product p1 = new Product();

    public void GetOrderInfo(string fname, string lname, string street, string city, string state, string country, bool foreign)
    {
        c1.GetCustomerInfo(fname, lname);
        c1.GetAddress(street, city, state, country, foreign);
        string loop = "1";
        while (loop != "0")
        {
            Console.WriteLine("please enter the product:");
            string product = Console.ReadLine();
            Console.WriteLine("please enter the product id:");
            string productid = Console.ReadLine();
            Console.WriteLine("please enter the price per unit of the product:");
            double priceperunit = double.Parse(Console.ReadLine());
            Console.WriteLine("please enter the quantity of the product:");
            int quantity = int.Parse(Console.ReadLine());
            
            p1.GetProducts(product, productid, priceperunit, quantity);

            Console.WriteLine("Are you finished? Please andswer with either Y or N");
            string endloop = Console.ReadLine();
            if (endloop == "Y")
            {
                loop = "0";
            }
            else if (endloop == "N")
            {
                Console.WriteLine("continuing next set");
            }
            else
            {
                Console.WriteLine("unknown variable, continuing next set.");
            }
        }
    }

    public void GetCustomer(string fname, string lname, string street, string city, string state, string country, bool foreign)
    {
        c1.GetCustomerInfo(fname, lname);
        c1.GetAddress(street, city, state, country, foreign);
    }

    public void GetProduct(string product, string productid, double priceperunit, int quantity)
    {
        p1.GetProducts(product, productid, priceperunit, quantity);
    }

    public void GetShippingTotal()
    {
        double basetotal = p1.ProductTotal();
        bool isforeign = c1.ReturningForeign();
        if (isforeign == false)
        {
            _totalshippingcost = basetotal + _shipcost;
        }
        else if (isforeign == true)
        {
            _totalshippingcost = basetotal + _foreignshipcost;
        }
    }

    public void Display()
    {
        c1.Display();
        p1.Display();
        Console.WriteLine($"the total cost to ship the order is: {_totalshippingcost}");
    }
}