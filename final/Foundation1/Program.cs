using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>
        { 
            new Video("Rewiring","Fantom Media", 7),
            new Video("Dog Water", "Megan Shaffer", 12),
            new Video("Shell Shock", "Lazo Party", 41),
        };
    
        List<Comment> allComments = new List<Comment>
        {
            new Comment("Paige", "This is the best video I've ever seen"),
            new Comment("Thomas", "I saw a little too much toe stop action tbh"),
            new Comment("Sam", "Love the editing style!"),
            new Comment("Jordan", "This is epic!"),
            new Comment("Chris", "I feel like I’ve seen this before…"),
            new Comment("Taylor", "That was unexpected!"),
            new Comment("Alex", "Crazy effects!"),
            new Comment("Morgan", "Soundtrack was on point."),
            new Comment("Jamie", "Can’t stop watching this."),
            new Comment("Dylan", "This video deserves more views!"),
            new Comment("Casey", "Where was this filmed?"),
            new Comment("Blake", "I showed this to my friends and they loved it!"),
        };

        for(int i = 0; i < _videos.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                int index = i * 3 + j;
                if(index < allComments.Count)
                {
                    _videos[i].AddToList(allComments[index]);
                }
            }
        }
    
        foreach(Video video in _videos)
        {
            {
                Console.WriteLine("\n        --------");
                Console.WriteLine($"Video Title: {video._title}");
                Console.WriteLine($"Video Author: {video._author}");
                Console.WriteLine($"Video Length: {video._length}");
                video.DisplayComments();
            }
        }
        
    }
}