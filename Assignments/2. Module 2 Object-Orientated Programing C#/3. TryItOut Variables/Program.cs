namespace TryItOut_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration of the three strings, and assigning their values
            string start = "Hello there, I sure hope";
            string middle = " you are having a great day";
            string end = " see you later!";

            // Declaring a blank string variable
            string complete = ("");

            // Combining start, middle, end all into "complete" 
            complete = ($"{start},{middle},{end}");

            // Printing all the combined product to the console
            Console.WriteLine(complete);

        }
    }
}