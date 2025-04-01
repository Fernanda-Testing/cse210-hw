using System.Diagnostics.Contracts;

public class WritingAsignment : Assignment
{
    private string _title;

    public WritingAsignment(string title, string studentName, string topic)
         : base(studentName, topic)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;   
    }

    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}