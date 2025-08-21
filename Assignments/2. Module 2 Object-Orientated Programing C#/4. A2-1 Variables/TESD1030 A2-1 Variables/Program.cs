namespace TESD1030_A2_1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Declaring string variables and assigning a blank value
            string name = ("");
            string greeting = ("");

            //Recieve user input and assign to name
            Console.WriteLine("What is your name?");
            name = (Console.ReadLine());

            //Recieve user input and assign to greeting
            Console.WriteLine("What would you like your greeting to be?");
            greeting = (Console.ReadLine());

            //Create and consolidate name + greeting into this new variable
            string message = (name + ", " + greeting);

            //Display the consolidated message
            Console.WriteLine(message);


            
        }
    }
}