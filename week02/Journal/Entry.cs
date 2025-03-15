public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _promptMotivation;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}.\nQUOTE OF THE DAY FOR YOU: {_promptMotivation}\n");
    }
}