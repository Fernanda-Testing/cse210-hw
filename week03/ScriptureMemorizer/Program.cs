using System;

class Program
{
    static void Main(string[] args)
    {
        string entry = "";
        
        Reference ref1 = new Reference("2 Nephi", 24, 26);

        Word word1 = new Word("O then, if I have seen so great things, " + 
                              "if the Lord in his condescension unto the children of men hath visited men in so much mercy, " +
                              "why should my heart weep and my soul linger in the valley of sorrow, and my flesh waste away, "+ 
                              "and my strength slacken, because of mine afflictions?");
        
        string word1Text = word1.GetDisplayText();

        Scripture scripture1 = new Scripture(ref1, word1Text); 
        
        while (entry != "quit" && !scripture1.IsCompletelyHidden())  
        {
            Console.WriteLine(scripture1.GetDisplayText());  
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            entry = Console.ReadLine();
            
            if (entry != "quit")  
            {
                scripture1.HideRandomWords(5);  
            }

            Console.Clear();  
        }
    }
}