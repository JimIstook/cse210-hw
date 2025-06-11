using System;
using System.Net;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = new List<Comment>();

    public Video()
    {
        _author = "Unknown";
        _title = "Video Title";
        _seconds = 0;
    }
    public Video(string title, string author, int seconds)
    {
        _author = author;
        _title = title;
        _seconds = seconds;
    }

    public void AddComment(string author, string text)
    {
        Comment newComent = new Comment(author, text);
        _comments.Add(newComent);
    }
    public int CountComments()
    {
        int count = _comments.Count();
        return count;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"{_title} by {_author} is {_seconds} seconds long.");
        ShowComments();
    }
    private void ShowComments()
    {
        int count = CountComments();
        if (count == 0)
        {
            Console.WriteLine("There are no comments on this video.");
        }
        else
        {
            Console.WriteLine($"There are {count} comments on this video");
            foreach (Comment comment in _comments)
            {
                string info = comment.GetComment();
                string[] split = info.Split("||");
                Console.WriteLine($"{split[0]}: {split[1]}");
            }
        }
        
    }

}