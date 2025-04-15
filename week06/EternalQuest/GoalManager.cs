using System.Formats.Asn1;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _nextGoalId = 1;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;        
    }
    public void Start()
    {
        int option = 0;
        while (option != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();
            try
            {
                option = int.Parse(choice);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 6.");
                continue;
            }
            if (option == 1)
            {
                CreateGoal();
            }
            else if (option == 2)
            {
                ListGoalDetails();
            }
            else if (option == 3)
            {
                SaveGoals();
            }
            else if (option == 4)
            {
                LoadGoals();
            }
            else if (option == 5)
            {
                ListGoalNames();
                RecordEvent();
            }
            else if (option == 6)
            {
                break;
            }
            else
            {
                Console.WriteLine("**Incorrect option** \nPlease enter a number between 1 and 6.");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        //Displays the players current score.
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames()
    {
        //Lists the names of each of the goals.
        Console.WriteLine("The goals are: ");
        foreach(Goal g in _goals)
        {
            Console.WriteLine($"{g.GetId()}. {g.GetShortName()}");
        }
    } 

    public void ListGoalDetails()
    {
        //Lists the details of each goal (including the checkbox of whether it is complete).
        Console.WriteLine("The goals are: ");
        foreach(Goal g in _goals)
        {
            Console.WriteLine(g.GetDetailsString());
        }
    } 
    public void CreateGoal()
    {
        //Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.WriteLine("The types of Goals are: ");

        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Overcome a Bad Habit");
        Console.Write("\nWich type of goal would you like to create? ");

        string choice = Console.ReadLine();
        int option;
        try
        {
            option = int.Parse(choice);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
            return;
        }

        Console.Write("\nWhat is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("\nWhat is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("\nWhat is the amount of points associated with this goal? ");
        int points;    

        try
        {
            points = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number for points.");
            return;
        }

        Goal goal = null; 

        if (option == 1)
        {
            goal = new SimpleGoal(_nextGoalId, name, description, points);
        }
        else if (option == 2)
        {
            goal = new EternalGoal(_nextGoalId, name, description, points);
        }
        else if (option == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target;
            try
            {
                target = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid number for target.");
                return;
            }

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus;
            try
            {
                bonus = int.Parse(Console.ReadLine());  
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid number for bonus");
                return;
            }     

            goal = new ChecklistGoal(_nextGoalId, name, description, points, target, bonus);                
        }
        else if (option == 4)
        {
        Console.Write("What is the negative points if you fail to overcome the habit? ");
        int negativePoints;
        try
        {
            negativePoints = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Please enter a valid number for negative points.");
            return;
        }
            goal = new OvercomeBadHabit(_nextGoalId, name, description, points, negativePoints);
        }
        else
        {
            Console.WriteLine("**Incorrect option** \nPlease enter a number between 1 and 4.");
            return;
        }     

        _goals.Add(goal);
        _nextGoalId++;
        } 
        

        public void RecordEvent()
        {
            Console.Write("Which goal did you accomplish? ");
            if (!int.TryParse(Console.ReadLine(), out int entry))
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            Goal selectedGoal = _goals.FirstOrDefault(g => g.GetId() == entry);

            if (selectedGoal == null)
            {
                Console.WriteLine("Goal not found.");
                return;
            }

            bool wasAlreadyComplete = selectedGoal.IsComplete();

            selectedGoal.RecordEvent(); 

            int pointsEarned = selectedGoal.GetPoints();


            if (selectedGoal is OvercomeBadHabit badHabit)
            {
                if (badHabit.IsComplete())
                {
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    _score += pointsEarned;
                }
                else if (pointsEarned < 0)
                {
                Console.WriteLine($"Oops! You lost {-pointsEarned} points.");
                _score += pointsEarned;
                }
                else
                {
                    Console.WriteLine("No points awarded.");
                }
            }
            else
            {
                if (!wasAlreadyComplete)
                {
                    Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                    _score += pointsEarned;
                }
                else
                {
                    Console.WriteLine("No points awarded because the goal was already completed.");
                }
            }

            Console.WriteLine($"You now have {_score} points.");
        }
    
    public void SaveGoals()
    {
        //Saves the list of goals to a file.

        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Goals saved to {filename} successfully!"); 
    } 

    public void LoadGoals()
    {
        // Loads the list of goals from a file.
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        if (!System.IO.File.Exists(filename))
        {
            Console.WriteLine("Error: The file does not exist.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);

        _goals.Clear(); 

        if (lines.Length == 0) return;

            _score = int.Parse(lines[0]);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] typeAndData = line.Split(':');
                string goalType = typeAndData[0];
                string[] parts = typeAndData[1].Split(',');

                Goal goal = null;

                if (goalType == "Simple Goal")
                {
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = bool.Parse(parts[4]);

                    goal = new SimpleGoal(id, name, desc, points, isComplete);
                }
                else if (goalType == "Eternal Goal")
                {
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);

                    goal = new EternalGoal(id, name, desc, points);
                }
                else if (goalType == "Checklist Goal")
                {
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int completed = int.Parse(parts[6]);

                    goal = new ChecklistGoal(id, name, desc, points, target, bonus, completed);
                }
                else if (goalType == "Bad Habit")
                {
                    int id = int.Parse(parts[0]);
                    string name = parts[1];
                    string desc = parts[2];
                    int points = int.Parse(parts[3]);
                    int negativePoints = int.Parse(parts[4]);
                    bool isComplete = bool.Parse(parts[5]);

                    var badHabit = new OvercomeBadHabit(id, name, desc, points, negativePoints);

                    badHabit.SetComplete(isComplete);
                    goal = badHabit;
                }

                if (goal != null)
                {
                    _goals.Add(goal);
                    _nextGoalId++;
                }

                if (_goals.Count > 0)
                {
                    _nextGoalId = _goals.Max(g => g.GetId()) + 1;
                }
                else
                {
                    _nextGoalId = 1; 
                }
            }
            
            Console.WriteLine("Goals loaded successfully!");
    }
}