namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize two variables
            int num1 = 10;
            int num2 = 0;

            // Attempt to divide num1 by num2
            int result = num2 / num1;

            // Print the result
            Console.WriteLine($"Result of division: {result}");

            // Display a message indicating the end of the program
            Console.WriteLine("End of program.");
        }
    }
}