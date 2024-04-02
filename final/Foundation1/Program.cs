using System;
using System.Reflection.PortableExecutable;
using System.Transactions;
namespace foundation1;

class Program
{
    static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {
        videos.Add(new Video("hitting the griddy", "kyle", 25));
        videos[0].AddComment("user1", "good form");
        videos[0].AddComment("user2", "cool");
        videos[0].AddComment("user3", "first");

        videos.Add(new Video("slime", "charleston", 564));
        videos[1].AddComment("user4", "commentless man");
        videos[1].AddComment("user5", "beans");
        videos[1].AddComment("grant", "better than taco bell");

        videos.Add(new Video("montage", "montageMaker", 256));
        videos[2].AddComment("user6", "cool edits");
        videos[2].AddComment("user7", "looks cool");
        videos[2].AddComment("user8", "nice");

        foreach (Video video in videos)
        {
            video.Display();
        }
    }

}