using System;

namespace Guess_A_Number
{
    internal class GuessANumberByMartin
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.Write("Guess a number (1 - 100): ");

                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (computerNumber == playerNumber)
                    {
                        Console.WriteLine("You guessed it !");
                        break;
                    }
                    else if (computerNumber > playerNumber)
                    {
                        Console.WriteLine("Too Low");
                    }
                    else
                    {
                        Console.WriteLine("Too High");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }
    }
}