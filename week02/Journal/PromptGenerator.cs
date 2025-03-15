using System.Collections.Generic;

public class PromptGenerator
{
     public List<string> _prompts = new List<string>
    {
        "What was your favorite part of your day? ",
        "What was the worst part of your day? ",
        "What was a blessing today? ",
        "Who was the most interesting person I interacted with today? ",
        "What was the most delicious thing I ate today? ",
        "What do you think gave you energy today? ",
        "If you could change something about today, what would it be? "
    };

         public List<string> _motivationPrompts = new List<string>
    {
        "One step at a time is progress. ",
        "Today is a new opportunity to grow. ",
        "My thoughts create my reality. ",
        "Small changes make big differences. ",
        "There's always something to be thankful for. ",
        "Success begins with the decision to try. ",
        "Every day is a new opportunity to reinvent myself. "
    };
    public string GetRandomPrompt()
    {
         Random random = new Random();
         // Generate a random index within the range of the list
         int index = random.Next(_prompts.Count);
         return _prompts[index];
    }

    public string GetRandomPromptMotivation()
    {
         Random random = new Random();
         // Generate a random index within the range of the list
         int index = random.Next(_motivationPrompts.Count);
         return _motivationPrompts[index];
    }
}