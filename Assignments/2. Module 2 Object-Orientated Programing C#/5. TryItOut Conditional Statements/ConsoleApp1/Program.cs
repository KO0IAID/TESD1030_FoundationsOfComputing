namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string language = ("");
            string greeting = ("");

            Console.WriteLine("Spanish or English?");

            language = Console.ReadLine();

            if (language == "Spanish")
            {
                    greeting = "Hola, bienvenido a mi programa!";
                    Console.WriteLine(greeting);
            } 
            else
            {
                    greeting = "Hello, welcome to my program!";
                    Console.WriteLine(greeting);
            }  
        }
    }
}