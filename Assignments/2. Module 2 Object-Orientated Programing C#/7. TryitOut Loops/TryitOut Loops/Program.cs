using System;

namespace TryitOut_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computerNumber = 0;
            int myGuess = 0;
            bool continueGame = true;
            Random Rand = new Random();


            Console.WriteLine("Hello! The Computer will choose a random number between 1 and 100");
            Console.WriteLine("Please input your guess:");
            myGuess = Convert.ToInt32(Console.ReadLine());

            computerNumber =Rand.Next(0, 101);

            if (continueGame == true)

                for (int i = 0; i < 100; ++i)
                {
                    if (myGuess < computerNumber)
                    {
                        Console.WriteLine("Your number is lower than the number.");
                        Console.WriteLine("Please guess again:");
                        myGuess = Convert.ToInt32(Console.ReadLine());
                        continueGame = true;
                    }
                        else if (myGuess > computerNumber)
                        {
                        Console.WriteLine("Your number is higher than the number.");
                        Console.WriteLine("Please guess again:");
                        myGuess = Convert.ToInt32(Console.ReadLine());
                        continueGame = true;
                        }

                        else if (myGuess == computerNumber)
                        {
                        Console.WriteLine("Congratulations! You guessed correctly!.");
                        continueGame = false;
                        i = 100;
                        }
                }
        }
    }
}