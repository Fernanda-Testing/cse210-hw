public class Assignment
{
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentName;
    }

    public void SetStudentName(string name)
    {
        _studentName = name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"Student's name: {_studentName} - Topic: {_topic}";
    }
}