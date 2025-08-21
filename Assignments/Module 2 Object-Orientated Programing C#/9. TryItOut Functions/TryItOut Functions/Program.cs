using System;

namespace TryItOut_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Global Varriables
            string UserChoice1;
            string UserChoice2;
            string UserChoice3;
            string UserChoice4;
            bool VirusCheck = false;
            bool Reinstall = false;
            bool TuneUp = false;
            bool OptionalParts = false;
            bool Tax = false;

            Decimal VirusCheckAmount = 0;
            Decimal ReinstallAmount = 0;
            Decimal TuneUpAmount = 0;
            Decimal OptionalPartsAmount = 0;
            Decimal TaxAmount = 0;
            Decimal GrandTotalAmount = 0;

            //Virus Check Service
            Console.WriteLine("Would you Like a Virus Check? Y/N");
            UserChoice1 = Console.ReadLine();
            if (UserChoice1 == "Y")
            {
                VirusCheck = true;
                Tax = true;
            }
                else if (UserChoice1 == "N")
                {
                VirusCheck = false;
                }

            //Reinstall Service
            Console.WriteLine("Would you Like a Reinstall? Y/N");
            UserChoice2 = Console.ReadLine();
            if (UserChoice2 == "Y")
            {
                Reinstall = true;
                Tax = true;
            }
                else if (UserChoice2 == "N")
                {
                Reinstall = false;
                }

            //Tune Up Service
            Console.WriteLine("Would you Like a Tune Up? Y/N");
            UserChoice3 = Console.ReadLine();
            if (UserChoice3 == "Y")
            {
                TuneUp = true;
                Tax = true;
            }
                else if (UserChoice3 == "N")
                {
                    TuneUp = false;
                }

            //Additional Parts Service
            Console.WriteLine("Would you like additional parts? Y/N ");
            UserChoice4 = Console.ReadLine();
            if (UserChoice4 == "Y")
            {
                OptionalParts = true;
                Tax = true;
                Console.WriteLine("How much do the parts cost?");
                OptionalPartsAmount = Convert.ToDecimal(Console.ReadLine());
            }
                else if (UserChoice2 == "N")
                {
                OptionalParts = false;
                }
            
            //Assign Cost to item if true
            if (VirusCheck == true)
            {
                VirusCheckAmount = 50M;
            }
            if (Reinstall == true)
            {
                ReinstallAmount = 10M;
            }
            if (TuneUp == true)
            {
                TuneUpAmount = 75M;
            }
            if (Tax == true)
            {
                TaxAmount = 6.75M;
            }
           
            //Take total of all variables
            GrandTotalAmount = (VirusCheckAmount + ReinstallAmount + TuneUpAmount + OptionalPartsAmount + TaxAmount);

            //Output Reciept
            Console.WriteLine("");
            Console.WriteLine("Here is your Receipt:");
            Console.WriteLine("________________________________________");
            Console.WriteLine($"Virus Check:    ${VirusCheckAmount}");
            Console.WriteLine($"Reinstall:      ${ReinstallAmount}");
            Console.WriteLine($"Tune Up:        ${TuneUpAmount}");
            Console.WriteLine($"Optional Parts: ${OptionalPartsAmount}");
            Console.WriteLine($"Tax:            ${TaxAmount}");
            Console.WriteLine("________________________________________");
            Console.WriteLine($"Grand Total:    ${GrandTotalAmount}");

        }  
    }
}

   
 