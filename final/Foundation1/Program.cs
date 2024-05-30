using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create video instances
        Video video1 = new Video("Learning C#", "Tech Guru", 600);
        Video video2 = new Video("Cooking Pasta", "Chef John", 900);
        Video video3 = new Video("Yoga for Beginners", "Yoga with Emma", 1200);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Great video! Very informative."));
        video1.AddComment(new Comment("Bob", "Thanks for the tutorial!"));
        video1.AddComment(new Comment("Charlie", "Helped me a lot, thanks!"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "Delicious recipe!"));
        video2.AddComment(new Comment("Eve", "Made this for dinner, everyone loved it!"));
        video2.AddComment(new Comment("Frank", "Easy to follow instructions."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "Perfect for beginners."));
        video3.AddComment(new Comment("Hannah", "Loved the session, very relaxing."));
        video3.AddComment(new Comment("Ivy", "Can't wait for the next video!"));

        // Add videos to the list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}