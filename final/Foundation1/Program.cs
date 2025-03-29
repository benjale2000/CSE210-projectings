using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        string loop = "1";

        List<Video> videos = new List<Video>{};
        Video v1 = new Video();
        Video v2 = new Video();
        Video v3 = new Video();
        Video v4 = new Video();
        v1.GetVideoInfo("This is a Trickshot", "TrickshotJosh", 300);
        v1.AddCommentVideo("Tony Stank", "Jarvis could do better.");
        v1.AddCommentVideo("Will123319", "Neat Shot.");
        v1.AddCommentVideo("Fantastical", "You should have 3 more people help you out.");
        videos.Add(v1);
        v2.GetVideoInfo("FNAF scare comp", "CJplays", 1200);
        v2.AddCommentVideo("MisterScares", "Hilarious compilation, keep it up.");
        v2.AddCommentVideo("Markiplier", "Good job, however I AM THE KING OF FIVE NIGHTS AT FREDDY'S");
        v2.AddCommentVideo("Joe10375677", "Eh.");
        videos.Add(v2);
        v3.GetVideoInfo("Brisket Cooking Guide", "TheCookingGroup", 600);
        v3.AddCommentVideo("Rachel11288", "Thanks for the guide, really helped for dinner");
        v3.AddCommentVideo("Cinders177", "This wasn't very helpful, still burned it");
        v3.AddCommentVideo("RyanFamily", "Great.");
        videos.Add(v3);
        v4.GetVideoInfo("How creatures looked during (Time Period here)", "TheArcheologists", 2400);
        v4.AddCommentVideo("JoshAlbert198", "This was very informative, thank you");
        v4.AddCommentVideo("ONCETHERE", "This was a fun topic");
        v4.AddCommentVideo("Eh18475", "Not accurate at all.");
        videos.Add(v4);

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}