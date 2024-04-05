using System;
using System.Collections.Generic;

public class Video
{
    public string title;
    private string author;
    private int length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();

    }

    public void AddComment(string commenters_name, string text)
    {
        comments.Add(new Comment(commenters_name, text));

    }
    public int GetNumComments()
    {
        return comments.Count;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumComments()}");

        Console.WriteLine("Comments:");
        foreach (var comment in comments)
        {
            Console.WriteLine(comment.ToString());
        }
        Console.WriteLine();
    }
}