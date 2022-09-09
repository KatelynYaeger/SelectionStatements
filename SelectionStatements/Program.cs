using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi friend! What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine($"Hi {userName}! Can you guess my favorite number?");

            int favoriteNumber = 3;
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess > favoriteNumber)
            {
                Console.WriteLine("Too high!");
            }

            else if (userGuess < favoriteNumber)
            {
                Console.WriteLine("Too low!");
            }

            else 
                    {
                Console.WriteLine("Nevermind, you're no fun.");
            }
        }
    }
}

