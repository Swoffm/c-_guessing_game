using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            guessGame();
        }

        static void guessGame()
        {
            double doubleUserGuess = 0;
            int secretNumber = 5;
            bool userDataType = false;

            while (!userDataType)
            {
                Console.WriteLine("Guess a secret number");
                Console.Write("Enter a number: ");
                string stringUserGuess = Console.ReadLine();

                if (stringUserGuess.ToLower() == "x")
                {
                    Console.WriteLine("Thanks for Playing");
                    break;
                }

                userDataType = double.TryParse(stringUserGuess, out doubleUserGuess);

            }

            if (secretNumber == doubleUserGuess)
            {
                Console.WriteLine("Congrats! You guessed the secret number!");

            }
            else
            {
                Console.WriteLine("Wrong Guess");
            }



        }



    }
}
