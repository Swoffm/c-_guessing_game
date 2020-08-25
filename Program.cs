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


            int secretNumber = new Random().Next(1, 100);
            int numberOfUserGuesses = 5;
            List<double> userGuesses = new List<double>();
            double userInput = getUserInput(numberOfUserGuesses);

            while (numberOfUserGuesses > 1 & numberOfUserGuesses <= 5)
            {


                if (userInput == secretNumber)
                {
                    Console.WriteLine("Congrats You Guessed the Secret Number!");
                    break;
                }
                else
                {
                    numberOfUserGuesses--;
                    Console.WriteLine("Wrong guess");
                    userGuesses.Add(userInput);
                    Console.Write("Current Guesses: ");
                    for (int i = 0; i < userGuesses.Count; i++)
                    {
                        Console.Write(userGuesses[i] + " ");
                    }
                    Console.WriteLine();
                    userInput = getUserInput(numberOfUserGuesses);


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


        static double getUserInput(int currentGuess)
        {
            double doubleUserGuess = 0;
            bool userDataType = false;

            while (!userDataType)
            {
                Console.WriteLine("Guess a secret number");
                Console.Write($"Enter a number ({currentGuess}): ");
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
