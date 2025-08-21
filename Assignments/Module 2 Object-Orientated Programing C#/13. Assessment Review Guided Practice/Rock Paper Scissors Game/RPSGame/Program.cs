namespace RPSGame
{
    internal class Program
    {
        static bool boolcontinueplaying;
        static int wins;
        static int losses;
        
        
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

            continueplaying();

            if (boolcontinueplaying == true)
            {
                Menu();
                
            }
            else if (boolcontinueplaying == false)
            {
                
            }



            // Task 2: Create functions for playing individual rounds
            // SubTask 1: Display a menu to the user to choose between Rock, Paper, and Scissors.
            // SubTask 2: Generate a random choice for the computer (Rock, paper, or Scissors)
            // SubTask 3: Compare the user's choice with the computer's choice using if statements to determine the winner.
            // SubTask 4: Display the results of the round (win, lose, or draw.)

            // Task 3: End the loop when the user no longer wants to play more rounds.

        }

        static void winlosecount()
        {
            int wins;
            int losses;
            Console.WriteLine("Current wins:{wins} Current Losses: {losses}");
        }
        static void Menu()
        {
            Console.WriteLine("Choose: Rock, Paper, Or Scissors?");

        }
        static void Userschoice()
        {

        }
        static void Displayresults()
        {
        }
        static bool continueplaying()
        {
            string continueplaying;
            bool boolcontinueplaying = true;

            Console.WriteLine("Want to play rock, paper, scissors Y/N?");
            continueplaying = Console.ReadLine();
            continueplaying = continueplaying.ToUpper();
            
                if (continueplaying == "Y")
                {
                    boolcontinueplaying = true;
                    Console.WriteLine("Great!");
                    
                }
                else if (continueplaying == "N")
                {
                    boolcontinueplaying =  false;
                    Console.WriteLine("Okay bye!");
                   
                }               
           
            return boolcontinueplaying;

        }

    }
}