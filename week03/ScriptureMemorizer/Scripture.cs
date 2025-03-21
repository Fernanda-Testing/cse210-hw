public class Scripture
{
    //Attributes
    private Reference reference;
    private List<Word> _words = new List<Word>(); 
   
   //Constructors
    public Scripture(Reference reference, string text)
    {
        this.reference = reference; 

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
          Random random = new Random();
          List<Word> selected = new List<Word>();

          for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count); 
            Word wordToHide = _words[randomIndex];
            if (!selected.Contains(wordToHide)) 
            {
                selected.Add(wordToHide);
                wordToHide.Hide(); 
            }
            else
            {
                i--; 
            }
        }
    }
    public string GetDisplayText()
    {
        string displayText = reference.GetDisplayText();  

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                displayText += " ____";
            }
            else
            {
                displayText += " " + word.GetText(); 
            }
        }

    return displayText;
}

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden()) 
             {
                return false;
             }
        }
        return true; 
    }
}