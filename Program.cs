using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            phaseOne();
        }

        static void phaseOne()
        {
            Console.WriteLine("Guess a secret number");
            Console.Write("Enter a number: ");
            string userGuess = Console.ReadLine();
            Console.WriteLine($"Your Guess is, {userGuess}");

        }


    }
}
