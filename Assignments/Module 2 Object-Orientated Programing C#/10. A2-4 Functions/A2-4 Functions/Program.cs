using System;

namespace A2_4_Functions
{
    internal class Program
    {
        //Declaring Global Variables.
        static char[] studentgrades = new char[5];
        static int[] studentscores = new int[5];
        
        static void Main(string[] args)
        {
            //Decalre Variables
            string[] studentnames = new string[5];
            int ClassAverage = 0;

            //Loop to get 5 Students names, and 5 Grades.
            for (int i = 0; i < 5; i++)
            {
                studentnames[i] = GetStudentName();
                studentscores[i] = GetStudentScore();   
            }
            //Use information collected above and function to calculate a grade for each student based upon score.
            GetStudentGrade();

            //Calculate the whole classes score with the function below
            ClassAverage= CalculateAverage(studentscores);

            //Display a header
            Console.WriteLine("Here are the students names, scores, and grades");
            Console.WriteLine("_______________________________________________");

            //Display each students name, grade, and score based upon current loop itteration.
            for (int i = 0; i < 5; i++)
                Console.WriteLine($"{studentnames[i]}: {studentscores[i]} = {studentgrades[i]}");

            //Display the class average score
            Console.WriteLine($"Class Average: {ClassAverage}");

            //Finally display the classaverage and range values.
            if (ClassAverage >= 90 && ClassAverage <= 100)
            {
                Console.WriteLine("The Class got a A 90 - 100");
            }
            else if (ClassAverage >= 80 && ClassAverage <= 89)
            {
                Console.WriteLine("The Class got a B 80 - 89");
            }
            else if (ClassAverage >= 70 && ClassAverage <= 79)
            {
                Console.WriteLine("The Class got a C 70 - 79");
            }
            else if (ClassAverage >= 60 && ClassAverage <= 69)
            {
                Console.WriteLine("The Class got a D 60 - 69");
            }
            else if (ClassAverage == 0 || ClassAverage <= 59)
            {
                Console.WriteLine("The Class got a F 0 - 59");
            }

        }
        static string GetStudentName() //Function to obtain student names
        {
            //Prompts for student name, takes input, then stores the value into the global variable
            Console.WriteLine($"What is the Student's name?");
            string StudentName = Console.ReadLine();
            return StudentName;
        }
        static int GetStudentScore() //Function to obtain Student Scores
        {
            //Declaring a variable for their scores
            int studentscores = 0;

            //Runs a loop to check if it is valid
            for (int i = 0; i < 2; ++i)

            {
                Console.WriteLine("What is the Student's grade?");
                studentscores = Convert.ToInt32(Console.ReadLine());

                //If valid, it will end.
                if (studentscores >= 0 && studentscores <= 100)
                {
                    break;
                }
                //if Not valid, it resets the loop
                else if (studentscores <= -1 || studentscores >= 101)
                {
                    Console.WriteLine("Invalid number, please input a number between 0-100");
                    i = 0;
                }
            }
            //Stores the value obtainted into student scores
            return studentscores;
        }
        static void GetStudentGrade() //Function to assign a grade letter bassed upon studentgrades
        {
            //Loop created so I can use the i variable to check every studentscore
            for (int i = 0; i < studentscores.Length; ++i)
            {
                //if statments for all the outcomes of studentscore, it will then give studentgrade a value
                if (studentscores[i] >= 90 && studentscores[i] <= 100)
                {
                    studentgrades[i] = 'A';
                }
                else if (studentscores[i] >= 80 && studentscores[i] <= 89)
                {
                    studentgrades[i] = 'B';
                }
                else if (studentscores[i] >= 70 && studentscores[i] <= 79)
                {
                    studentgrades[i] = 'C';
                }
                else if (studentscores[i] >= 60 && studentscores[i] <= 69)
                {
                    studentgrades[i] = 'D';
                }
                else if (studentscores[i] == 0 || studentscores[i] <= 59)
                {
                    studentgrades[i] = 'F';
                }

            }
        }
        static int CalculateAverage(int[] studentscores) //Function to calculate whole class average score, using information and size of studentscores
        {
            //Initiallizing some variables needed to average a number sum, average
            int sum = 0;
            int average = 0;

            //Loop to use add studentscores up, by the size of the array
            for (int i = 0; i < studentscores.Length; ++i)
            {
                sum += studentscores[i];
            }

            //Calculate average by the size of the array
            average = sum / studentscores.Length;
      
            return average;
        }
        
    }
}