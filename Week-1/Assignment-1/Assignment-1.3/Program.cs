// See https://aka.ms/new-console-template for more information

using System;

namespace InterestCalcProg
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for loan amount.
            Console.WriteLine("What is the principal amount of the loan in dollars?");

            //Takes user's input and stores as int.
            int loanAmt = Convert.ToInt32(Console.ReadLine());

            //Asks user for interest rate.
            Console.WriteLine("What is the interest rate (input 0.05 for 5%)?");

            //Takes user's input and stores as double.
            double interestRate = Convert.ToDouble(Console.ReadLine());

            //Asks user how many years for loan period. 
            Console.WriteLine("What is the period of loan in years?");

            //Takes user's input and stores as int. 
            int years = Convert.ToInt32(Console.ReadLine());

            //Calculates total interst. 
            double totalInterest = Convert.ToDouble(loanAmt) * interestRate * Convert.ToDouble(years);

            //Prints out the calculation for total interst.
            Console.WriteLine("Total interest of loan: $" + totalInterest + " dollars.");
        }
    }
}
