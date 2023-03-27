using System;

namespace Guess_A_Number
{
    internal class GuessANumberByMartin
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i+=100)
            {


                Random randomNumber = new Random();
                int computerNumber = randomNumber.Next(1, i);

                while (true)
                {
                    Console.Write($"Guess a number lv - {i/100} (1 - {i}): ");

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
            Console.WriteLine(" You are WINER");
        }
    }
}