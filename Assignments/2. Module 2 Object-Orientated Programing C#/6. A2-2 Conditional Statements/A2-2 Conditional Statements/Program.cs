namespace A2_2_Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare global variables
            int num1;
            int num2;
            string operation;
            int sum = 0;       //Had to set to 0 as it won't compile without a value

            Console.WriteLine("Please Input a number:");    // Write to Console Prompting for input for num1   
            num1 = Convert.ToInt32(Console.ReadLine());     // Take input for num1 and convert it to a int to fit in num1
            if (num1 > 0)                                   //Check if input was a valid numberic value greater than 0
            {
                Console.WriteLine("Please Input a second number:"); //Successful input message
            }
            else if (num1 < 0)
            {
                Console.WriteLine("Error: Invalid Input");          //Non-Successful input error message
            }

            num2 = Convert.ToInt32(Console.ReadLine());     // Take input for num2 and convert it to a int to fit in num2
            if (num2 <= 0)                                  //Check if input 2 was an invalid number using < 
            {
                Console.WriteLine("Error: Invalid Input");          //Non-Successful input error message
            }

            Console.WriteLine("Please choose an operation: Add, Subtract, Multiply, Divide (Case Sensative)");  //Take input for operator
            operation = Console.ReadLine();                                                                     //Assign to operation

            if (operation == "Add")                     //Check if input was Add
            {
                sum = num1 + num2;                          //Add numbers together and store value in sum
            }
            else if (operation == "Subtract")           //Check if input was Subtract
            {
                sum = num1 - num2;                          //Subtract numbers together and store value in sum
            }
            else if (operation == "Multiply")           //Check if input was Multiply
            {
                sum = num1 * num2;                          //Multiply numbers together and store value in sum
            }
            else if (operation == "Divide")             //Check if input was Divide
            {
                sum = num1 / num2;                          //Divide numbers together and store value in sum
            }

                else                                   //Create error situation if none of the above apply 
                {
                Console.WriteLine("Error Invalid Input");
                }

            
            Console.WriteLine($"Result: {sum}");       //Output the result
           
        
        }
    }
}