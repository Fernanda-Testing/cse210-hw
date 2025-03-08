using System;

class Program
{
    static void Main(string[] args)
    {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            Console.WriteLine(magicNumber);

            int magicNumberGuess = 0;
            int counter = 0;

            while (magicNumber != magicNumberGuess)
            {
                Console.WriteLine("What is your guess? ");
                string userInputGuess = Console.ReadLine();
                magicNumberGuess = int.Parse(userInputGuess);

                if (magicNumberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                counter += 1;
            }
            Console.WriteLine($"You guessed it! You had {counter} attempts.");
        }
    }