using System;

namespace WordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretword = "blue";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretword && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter colour: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("You Win!");
            }

        }
    }
}
