using System;
using System.Collections.Generic;
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
            double userInput = getUserInput();
            int secretNumber = 5;
            int numberOfUserGuesses = 1;
            List<double> userGuesses = new List<double>();

            while (numberOfUserGuesses >= 1 & numberOfUserGuesses <= 4)
            {
                if (userInput == secretNumber)
                {
                    Console.WriteLine("Congrats You Guessed the Secret Number!");
                    break;
                }
                else
                {
                    numberOfUserGuesses++;
                    Console.WriteLine("Wrong guess");
                    userGuesses.Add(userInput);
                    Console.Write("Current Guesses: ");
                    for (int i = 0; i < userGuesses.Count; i++)
                    {
                        Console.Write(userGuesses[i] + " ");
                    }
                    Console.WriteLine();
                    userInput = getUserInput();


                }
            }
            // if (secretNumber == doubleUserGuess)
            // {
            //     Console.WriteLine("Congrats! You guessed the secret number!");

            // }
            // else
            // {
            //     Console.WriteLine("Wrong Guess");
            // }



        }


        static double getUserInput()
        {
            double doubleUserGuess = 0;
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
                else
                {
                    userDataType = double.TryParse(stringUserGuess, out doubleUserGuess);

                }

            }
            return doubleUserGuess;


        }



    }
}
