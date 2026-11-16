
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // First video
        Video video1 = new Video("Learning C# for Beginners", "Code Academy", 600);

        video1.AddComment(new Comment("John", "This video helped me understand C#."));
        video1.AddComment(new Comment("Mary", "Very helpful lesson."));
        video1.AddComment(new Comment("David", "I learned something new today."));

        // Second video
        Video video2 = new Video("How to Build a Website", "Web Developer", 850);

        video2.AddComment(new Comment("Peter", "I enjoyed this tutorial."));
        video2.AddComment(new Comment("Sarah", "The explanation was easy to follow."));
        video2.AddComment(new Comment("James", "Please make more videos like this."));

        // Third video
        Video video3 = new Video("Introduction to Python", "Programming World", 720);

        video3.AddComment(new Comment("Grace", "Python looks interesting."));
        video3.AddComment(new Comment("Paul", "This was a good introduction."));
        video3.AddComment(new Comment("Michael", "Thanks for sharing this lesson."));
        video3.AddComment(new Comment("Faith", "I will practice what I learned."));

        // Fourth video
        Video video4 = new Video("Understanding HTML and CSS", "Tech Tutorials", 900);

        video4.AddComment(new Comment("Daniel", "This helped me with my assignment."));
        video4.AddComment(new Comment("Ruth", "I like the examples."));
        video4.AddComment(new Comment("Samuel", "Very clear explanation."));

        // Put all videos in a list
        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Video Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLength() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.GetCommenterName() + ": " + comment.GetText());
            }

            Console.WriteLine("------------------------------");
        }
    }
}
