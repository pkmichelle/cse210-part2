using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video v1 = new Video("Rewiring","Fantom Media", 7);
        v1.AddComment("Paige", "This is the best video I've ever seen");
        v1.AddComment("Thomas", "I saw a little too much toe stop action tbh");

        Video v2 = new Video("Dog Water", "Megan Shaffer", 12);
        v2.AddComment("Jordan", "This is epic!");
        v2.AddComment("Chris", "I feel like Ive seen this before…");
        v2.AddComment("Taylor", "That was unexpected!");

        Video v3 = new Video("Shell Shock", "Lazo Party", 41);
        v3.AddComment("Morgan", "Soundtrack was on point.");
        v3.AddComment("Dylan", "This video deserves more views!");
        v3.AddComment("Casey", "Where was this filmed?");
        v3.AddComment("Sam", "Love the editing style!");

        _videos.Add(v1);
        _videos.Add(v2);
        _videos.Add(v3);
    
        foreach(Video video in _videos)
        {
            {
                video.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}