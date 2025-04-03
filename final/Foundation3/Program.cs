using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Lectures l1 = new Lectures("Jim Scott", 150, "On Failure and Learning", "Jim scott will be giving a lecture about failure and learning from that failure.", "15/2/2025", "06:00 PM", "15472887 Knotreal st. Blank, Utahl, Finish");
        Receptions r1 = new Receptions(40, "Jim's Football Reception", "Jim will be having a reception after the football game.", "28/3/2025", "08:00 PM", "17464972 Couldntbe rd. Green, Orvile, Entropic");
        OutdoorGatherings o1 = new OutdoorGatherings("cloud with a chance of meatballs", "Flint Lockwood's party", "Come to the most amazing party here on Swallow Falls", "19/5/2025", "10:00 AM", "55 entertain lp. Swallow Falls");

        r1.RegisterList("Jim Allen");
        r1.RegisterList("Alice Allen");

        l1.DisplayFull();
        r1.DisplayFull();
        o1.DisplayFull();
    }
}