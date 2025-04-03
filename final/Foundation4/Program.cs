using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> a1 = new List<Activity>{};
        Running r1 = new Running(5, "05/03/2025", 30);
        a1.Add(r1);
        Swimming s1 = new Swimming(30, "09/07/2025", 20);
        a1.Add(s1);
        Cycling c1 = new Cycling(30, "07/03/2025", 30);
        a1.Add(c1);

        foreach (Activity item in a1)
        {
            item.GetSummary();
        }
    }
}