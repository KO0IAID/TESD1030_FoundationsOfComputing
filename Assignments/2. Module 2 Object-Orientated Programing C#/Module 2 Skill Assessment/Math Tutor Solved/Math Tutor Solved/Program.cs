using System;

namespace Math_Tutor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Elementary Math Tutor
            /* 
               Purpose: Create an application that helps elementary students practice basic math problems, specifically addition and subtraction.
               The program should run in a loop, asking the user if they want to solve an addition or subtraction problem. It should then present
               the problem, allowing the student to input their answer. If the correct answer is given, it should respond with "Correct, good work!"
               If the answer is incorrect, it should respond with "Nice try, but that's incorrect." 
               (Stretch goal: Allow students to continue working on incorrect answers until they get them right). 
               The application should then prompt if they want to solve another question, starting the process over again. 
               If the students are finished, the program should thank them and exit.
            */

            // Task 1: Create a loop that continues as long as students want to see more questions

            int continueon;
            Console.WriteLine("Would you like to continue? 1. Yes, 2. No");
            continueon = Convert.ToInt32(Console.ReadLine());
            while (continueon == 1)
            {
                // SubTask 1: Ask the user which problem they want to try (addition or subtraction)
                Console.WriteLine("Would you like to try addition or subtraction?");
                string addorsub;
                addorsub = Console.ReadLine();


                if (addorsub == "Addition" || addorsub == "addition")
                {
                    // Task 2: Create functions for addition
                    int addanswer;
                    int adduseranswer;
                    // SubTask 1: Create the problem for the user to solve (use random numbers for both sides of the equation, between 1 and 100)
                    Random random1 = new Random();
                    Random random2 = new Random();
                    int rand1 = random1.Next(1, 100);
                    int rand2 = random2.Next(1, 100);
                    addanswer = rand1 + rand2;

                    Console.WriteLine($"What is {rand1} + {rand2} =");

                    // SubTask 2: Allow the user to input the answer
                    adduseranswer = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < 2; ++i)
                    {
                        if (adduseranswer == addanswer)
                        {
                            Console.WriteLine($"Good Job! {adduseranswer} is correct.");
                            i = 2;
                        }
                        else if (adduseranswer != addanswer)
                        {
                            Console.WriteLine("That is incorrect. Please try again.");
                            adduseranswer = Convert.ToInt32(Console.ReadLine());
                            i = 0;
                        }
                    }
                }
                else if (addorsub == "Subtraction" || addorsub == "subtraction")
                {
                    // Task 2: Create functions for subtraction
                    int subanswer;
                    int subuseranswer;
                    // SubTask 1: Create the problem for the user to solve (use random numbers for both sides of the equation, between 1 and 100)
                    Random random3 = new Random();
                    Random random4 = new Random();
                    int rand3 = random3.Next(1, 100);
                    int rand4 = random4.Next(1, 100);
                    subanswer = rand3 - rand4;

                    Console.WriteLine($"What is {rand3} - {rand4} =");
                    // SubTask 2: Allow the user to input the answer
                    subuseranswer = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < 2; ++i)
                    {
                        if (subuseranswer == subanswer)
                        {
                            Console.WriteLine($"Good Job! {subuseranswer} is correct.");
                            i = 2;
                        }
                        else if (subuseranswer != subanswer)
                        {
                            Console.WriteLine("That is incorrect. Please try again.");
                            subuseranswer = Convert.ToInt32(Console.ReadLine());
                            i = 0;
                        }
                    }
                }
                Console.WriteLine("Would you like to continue? 1. Yes, 2. No");
                continueon = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Okay. Thank you!");




            // SubTask 1: Create the problem for the user to solve (use random numbers for both sides of the equation, between 1 and 100)
            // SubTask 2: Allow the user to input the answer
            // SubTask 3: Check if the answer is correct, and if so, give the appropriate response. If incorrect, provide encouragement to try again.
            // Optional SubTask: Allow students to try to solve until the correct answer is given.
            // SubTask 4: Return to the main loop, allowing students to continue with more problems if desired.

            // Task 3: End the loop when students no longer want to continue with the quiz.
        }
    }
}