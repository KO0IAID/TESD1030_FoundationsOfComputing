namespace A2_4_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            double firstsum;

            firstsum = AddNumbers(10.7, 20.32);
            Console.WriteLine(firstsum);

        }

        public static double AddNumbers(double firstnumber, double secondNumber) => firstnumber + secondNumber;





    }
}