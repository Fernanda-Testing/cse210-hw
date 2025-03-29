using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

public class Video
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>(); 
    
    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public double GetLength()
    {
        return _length;
    }
    public void SaveInListOfComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public string DisplayListOfComments()
    {
        string result = "";
        foreach (Comment comment in _comments)
        {
            result += $"{comment.GetDisplayComment()}\n";
        }
        return result;
    }
}