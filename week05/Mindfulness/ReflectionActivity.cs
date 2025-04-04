using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ReflectionActivity : Activity
{
        private List<string> _reflectionPrompts = new List<string>()

         {
            "Think of a time when you stood up for someone else. ",
            "Think of a time when you did something really difficult. ",
            "Think of a time when you helped someone in need. ",
            "Think of a time when you did something truly selfless. "
        };

        private List<string> _relatedQuestions = new List<string>()
        {
         "Why was this experience meaningful to you? ",
         "Have you ever done anything like this before? ",
         "How did you get started? ",
         "How did you feel when it was complete? ",
         "What made this time different than other times when you were not as successful? ",
         "What is your favorite thing about this experience? ",
         "What could you learn from this experience that applies to other situations? ",
         "What did you learn about yourself through this experience? ",
         "How can you keep this experience in mind in the future? "
        };

        public ReflectionActivity(List<string> reflectionPrompts, List<string> relatedQuestions, string name, string description, int duration) : base(name, description, duration)
        {
        _activityName = "Reflection";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _durationOfTheActivity = 30;
         }

        public void Run()
        {
        }
        public string GetRandomPrompt()
        {
        Random random = new Random();
        // Generate a random index within the range of the list
        int index = random.Next(_reflectionPrompts.Count);
        return _reflectionPrompts[index];
        }
        public string GetRandomQuestion()
        {
        Random random = new Random();
        // Generate a random index within the range of the list
        int index = random.Next(_relatedQuestions.Count);
        return _relatedQuestions[index];
        }
        public void DisplayPrompt()
        { 
        }
        public void DisplayQuestions()
        {
        }
}