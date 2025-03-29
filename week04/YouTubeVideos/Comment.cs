using System.Runtime.CompilerServices;

public class Comment
{
    private string _name;
    private string _textOfTheComment;

    public Comment(string name, string text)
    {
        _name = name;
        _textOfTheComment = text;
    }
    public string GetDisplayComment()
    {
        return $"{_name}: {_textOfTheComment}";
    }
}