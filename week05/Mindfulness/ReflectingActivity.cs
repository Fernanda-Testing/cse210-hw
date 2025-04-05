using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ReflectingActivity : Activity
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

        public ReflectingActivity(string name, string description) : base(name, description, 0)
        {

        }

        public void Run()
        {
            DisplayStartingMessage();          
            
            Console.WriteLine("Consider the following prompt: ");
            DisplayPrompt();
            Console.Write("When you have something in mind, press enter to continue.");       
            Console.ReadLine();

            Console.WriteLine("\nNow ponder in each of the following questions as they related to this experience.");
            Console.Write($"You may begin in: ");
            ShowCountdown(6); 
            Console.WriteLine();   

            int durationOfActivity = _durationOfTheActivity;    
            int questionDuration = 10;
            int maxQuestions = durationOfActivity / questionDuration;
    
            for (int i = 0; i < maxQuestions; i++)
            {
                DisplayQuestions();
                ShowSpinner(questionDuration);  
                durationOfActivity -= questionDuration;    
                Console.WriteLine();  
            }   
            
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_reflectionPrompts.Count);
            return _reflectionPrompts[index];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            int index = random.Next(_relatedQuestions.Count);
            return _relatedQuestions[index];
        }
        
        public void DisplayPrompt()
        {  
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
        }
        
        public void DisplayQuestions()
        {
            Console.WriteLine($"> {GetRandomQuestion()}");      
        }
}