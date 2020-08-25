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

            int numberOfUserGuesses = 0;

            string userDifficulty = getDifficulty();
            if (userDifficulty == "easy")
            {
                numberOfUserGuesses = 8;

            }
            else if (userDifficulty == "medium")
            {
                numberOfUserGuesses = 6;

            }
            else if (userDifficulty == "hard")
            {
                numberOfUserGuesses = 4;

            }
            else if (userDifficulty == "cheater")
            {
                numberOfUserGuesses = -5;
            }


            int secretNumber = new Random().Next(1, 100);
            List<double> userGuesses = new List<double>();
            double userInput = getUserInput(numberOfUserGuesses);

            while (numberOfUserGuesses > 1 || numberOfUserGuesses < -3)
            {


                if (userInput == secretNumber)
                {
                    Console.WriteLine("Congrats You Guessed the Secret Number!");
                    break;
                }


                else if (secretNumber > userInput)
                {
                    Console.WriteLine("User Guess is to low");
                }
                else
                {
                    Console.WriteLine("Your Guess is to high");
                }
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

            Console.WriteLine($"Thanks for playing, the secret number was {secretNumber}");



        }


        static double getUserInput(int currentGuess)
        {
            double doubleUserGuess = 0;
            bool userDataType = false;

            while (!userDataType)
            {
                Console.WriteLine("Guess a secret number");
                if (currentGuess > 0)
                {
                    Console.Write($"Enter a number ({currentGuess}): ");
                }
                else
                {
                    Console.Write($"Enter a number: ");
                }
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

        static string getDifficulty()
        {
            string userDifficulty = "";
            while (userDifficulty.ToLower() != "easy" || userDifficulty.ToLower() != "medium" || userDifficulty.ToLower() != "hard")
            {

                Console.Write("Select Difficulty Level: Easy, Medium, Hard, Cheater: ");
                userDifficulty = Console.ReadLine();

                if (userDifficulty.ToLower() == "easy" || userDifficulty.ToLower() == "medium" || userDifficulty.ToLower() == "hard" || userDifficulty.ToLower() == "cheater")
                {
                    break;
                }

            }
            return userDifficulty.ToLower();
        }



    }
}
