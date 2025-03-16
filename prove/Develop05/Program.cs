using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        string loop = "1";

        List<Goals> goals = new List<Goals>{};

        int point_total = 0;

        Console.WriteLine("In this program you can create goals and earn points by obtaining those goals.");

        while (loop != "0")
        {
            Console.WriteLine();
            Console.WriteLine("1. Goal creation.");
            Console.WriteLine("2. Goal management.");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals (will clear current list of goals)");
            Console.WriteLine("6. Quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Please type the number for which goal you wish to enter.");
                Console.WriteLine("1. Simple goal.");
                Console.WriteLine("2. Eternal goal.");
                Console.WriteLine("3. Checklist goal.");

                string goal_creation = Console.ReadLine();

                if (goal_creation == "1")
                {
                    Console.WriteLine("What is the goals name");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the goals description");
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the goals point amount");
                    int points = int.Parse(Console.ReadLine());
                    bool done = false;
                    Simple simple = new Simple(points, name, desc, done);
                    goals.Add(simple);
                }
                else if (goal_creation == "2")
                {
                    Console.WriteLine("What is the goals name");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the goals description");
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the goals point amount");
                    int points = int.Parse(Console.ReadLine());
                    Eternal eternal = new Eternal(points, name, desc);
                    goals.Add(eternal);
                }
                else if (goal_creation == "3")
                {
                    Console.WriteLine("What is the goals name");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the goals description");
                    string desc = Console.ReadLine();
                    Console.WriteLine("What is the goals point amount");
                    int points = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the goals bonus points");
                    int bonus = int.Parse(Console.ReadLine());
                    Console.WriteLine("What is the goals total times to be done");
                    int timestotal = int.Parse(Console.ReadLine());
                    Checklist checklist = new Checklist(points, name, desc, false, bonus, timestotal, 0);
                    goals.Add(checklist);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("unknown input, please try again");
                    Console.WriteLine();
                }
            }
            else if (choice == "2")
            {
                foreach (Goals goal in goals)
                {
                    goal.Display();
                }
                Console.WriteLine("Please select a goal using 1, or 2, or 3... etc.");
                int goalchoice = int.Parse(Console.ReadLine());
                int goalactual = goalchoice - 1;
                Goals chosengoal = goals[goalactual];
                chosengoal.GoalManage();
                bool iscomplete = chosengoal.IsComplete();
                if (iscomplete == true)
                {
                    point_total = point_total + chosengoal.GetPoints();
                }
                else
                {
                    point_total = point_total + chosengoal.PointReturn();
                }
            }
            else if (choice == "3")
            {
                foreach (Goals goal in goals)
                {
                    goal.Display();
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    outputFile.WriteLine(point_total);
                    foreach (Goals goal in goals)
                    {
                        string saveinfo = goal.GoalSave();
                        outputFile.WriteLine($"{goal}:{saveinfo}");
                    }
                }
            }
            else if (choice == "5")
            {
                goals.Clear();
                
                Console.WriteLine("what is the file name?");
                string fileName = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(fileName);

                point_total = int.Parse(lines[0]);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    string goaltype = parts[0];
                    if (goaltype == "Simple")
                    {
                        string[] data = parts[1].Split(",");
                        int points = int.Parse(data[0]);
                        string name = data[1];
                        string desc = data[2];
                        bool done = bool.Parse(data[3]);
                        Simple savedsimple = new Simple(points, name, desc, done);
                        goals.Add(savedsimple);
                    }
                    else if (goaltype == "Checklist")
                    {
                        string[] data = parts[1].Split(",");
                        int points = int.Parse(data[0]);
                        string name = data[1];
                        string desc = data[2];
                        bool done = bool.Parse(data[3]);
                        int bonus = int.Parse(data[4]);
                        int timestotal = int.Parse(data[5]);
                        int times = int.Parse(data[6]);
                        int prevtimes = int.Parse(data[7]);
                        Checklist savedchecklist = new Checklist(points, name, desc, done, bonus, timestotal, times, prevtimes);
                        goals.Add(savedchecklist);
                    }
                    else if (goaltype == "Eternal")
                    {
                        string[] data = parts[1].Split(",");
                        int points = int.Parse(data[0]);
                        string name = data[1];
                        string desc = data[2];
                        bool done = bool.Parse(data[3]);
                        Eternal savedeternal = new Eternal(points, name, desc, done);
                    }
                    else
                    {
                        Console.WriteLine(goaltype + " hahaha");
                    }
        
                }
            }
            else if (choice == "6")
            {
                loop = "0";
            }
            else
            {
                Console.WriteLine("invalid input please try again.");
            }
        }
    }
}