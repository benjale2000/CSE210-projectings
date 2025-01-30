using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();


    public void SaveToFile(string stuff1, string stuff2, string stuff3)
    {
        string fileName = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{stuff1}~{stuff2}~{stuff3}");
        }
    }

    public void LoadFromFile()
    {
        string fileName = "Journal.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            Entry entryloaded = new Entry();

            entryloaded._date = parts[0];
            entryloaded._promptText = parts[1];
            entryloaded._entryText = parts[2];

            Console.WriteLine(entryloaded);
        }
    }
}