using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Title 1", "author 1", 100);
        Video video2 = new Video("Title 2", "Jane Doe", 300);
        Video video3 = new Video("Title 3", "Joe Doe", 600);

        video1.AddComment(new Comment("Frank", "lorem ipsum"));
        video1.AddComment(new Comment("Joe", "Cool"));
        video1.AddComment(new Comment("Mary", "Awesome"));

        video2.AddComment(new Comment("Bob", "lorem ipsum"));
        video2.AddComment(new Comment("Alice", "Great"));
        video2.AddComment(new Comment("Will", "Nice"));

        video3.AddComment(new Comment("Ed","Nice video"));
        video3.AddComment(new Comment("Bill","Super"));
        video3.AddComment(new Comment("Amy","lorem ipsum"));

        List<Video> videos = new List<Video> {video1, video2, video3};

        DisplayVideos(videos);
    }

    public static void DisplayVideos(List<Video> videos)
    {
        foreach (Video video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {video.VideoTitle}");
            Console.WriteLine($"Author: {video.VideoAuthor}");
            Console.WriteLine($"Length: {video.VideoLength} seconds");
            Console.WriteLine($"Number of Comments: {video.CommentNumber()}");
            Console.WriteLine();
            Console.WriteLine($"Comments:");
        
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"{comment.CommentName}: {comment.CommentText}");
            }
        }
    }
}