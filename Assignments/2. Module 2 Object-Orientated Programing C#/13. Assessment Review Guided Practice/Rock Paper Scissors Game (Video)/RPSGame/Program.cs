namespace VRPSGame
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Rock, paper, Scissors Game

            /* Purpose: Create an application that allows users to play the classic game of Rock, Paper, Scissors
             * The Program will run in a loop, allowing the user to play multiple rounds
             * It will present the user with a menu to choose between rock, paper, and scissors
             * The computer will randomly choose one of these options as well.
             * After each round, the program will determine the winner and display the results.
             */



            //Task 1: Create a loop that continues as long as the user wants to play more rounds

            string continuegame = "Y";
            Console.WriteLine("Let's play rock, paper, scissors Y/N?");
            continuegame = Console.ReadLine();
            Random random = new Random();

            while (continuegame.ToUpper() == "Y")
            {
                Console.WriteLine("Player Choice: enter the number (1. Rock, 2. Paper, 3. Scissors)");
                int choice = Convert.ToInt32(Console.ReadLine());
                int computerChoice = random.Next(1, 3);

                if (computerChoice == 1)
                {
                    Rock(choice);
                }
                else if (computerChoice == 2)
                {
                    Paper(choice);
                } 
                else if (computerChoice == 3)
                {
                    Scissors(choice);
                }

                Console.WriteLine("Would you like to play again? Y/N");
                continuegame = Console.ReadLine();

                if (continuegame.ToUpper() == "Y")
                {
                    Console.Clear();
                }
                else
                {
                    return;
                }
            }


            // Task 2: Create functions for playing individual rounds


            // SubTask 1: Display a menu to the user to choose between Rock, Paper, and Scissors.
            // SubTask 2: Generate a random choice for the computer (Rock, paper, or Scissors)
            // SubTask 3: Compare the user's choice with the computer's choice using if statements to determine the winner.
            // SubTask 4: Display the results of the round (win, lose, or draw.)
            // Task 3: End the loop when the user no longer wants to play more rounds.

        }
        public static void Rock(int num)
        {
            Console.WriteLine("Computer has chosen Rock");

            if (num == 1)
            {
                Console.WriteLine("It's a Draw");
            }
            else if (num == 2)
            {
                Console.WriteLine("Paper covers rock! You Win!");
            }
            else if (num == 3)
            {
                Console.WriteLine("Rock breaks Scissors! You Lose!");
            }
        }
        public static void Paper(int num)
        {
            Console.WriteLine("Computer has choosen paper");
            if (num == 2)
            {
                Console.WriteLine("It's a Draw");
            }
            else if (num == 3)
            {
                Console.WriteLine("Scissors cut Paper! You Win!");
            }
            else if (num == 1)
            {
                Console.WriteLine("Paper covers Rock! You Lose!");
            }
        }
        public static void Scissors(int num)
        {
            Console.WriteLine("Computer has choosen Scissors");
        if (num == 3)
            {
                Console.WriteLine("It's a Draw");
            }
        else if (num == 1)
            {
                Console.WriteLine("Rock smashes Scissors! You Win!");
            }
        else if (num == 2)
            {
                Console.WriteLine("Scissors cut Paper! You Win");
            }
        }

         
        }

    }
