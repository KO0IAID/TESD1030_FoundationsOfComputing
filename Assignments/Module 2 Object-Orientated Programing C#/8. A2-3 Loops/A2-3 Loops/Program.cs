namespace A2_3_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring global variables
            //Had to look up how to make an array, and set it to 6 so it wouldn't overflow and crash
            int[] num = new int[6];
            int average;

            //Create loop to run 5x and take input from user
            for (int i = 1; i < 6; i++)
            {
                //Writeline that uses loop itteration variable to keep track
                Console.WriteLine($"please input a number #{i}");
                //Take input for each number having the number equal the current loop itteration 
                num[i] = Convert.ToInt32(Console.ReadLine());

                //Check if number is even dividing it by 2 and seeing if it doesn't have a remainder 
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                    //Check if number is odd and has a remainder
                    else if (num[i] % 2 != 0)
                    {
                    Console.WriteLine("Odd");
                    }
                
            }

            //Getting average of numbers and using parentheses for proper mathmatics
            average = (num[1] + num[2] + num[3] + num[4] + num[5]) / 5;

            //Display the average
            Console.WriteLine($"The average of your numbers is: {average}");         
        }
    }
}