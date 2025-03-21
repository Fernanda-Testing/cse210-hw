public class Scripture
{

    //Attributes
    private Reference reference;
    private List<Word> _words = new List<Word>(); 
   
   //Constructors
    public Scripture(Reference reference, string text)
    {
        this.reference = reference; // Asigns the object Reference

        // Divides the text in words and creates Word objects
        string[] wordsArray = text.Split(' '); // Separates word by space
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word)); // Create and add Word object to the list
        }
    }

    //Methods

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden(){
        return true;
    }
}