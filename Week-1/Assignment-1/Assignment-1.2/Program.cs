// See https://aka.ms/new-console-template for more information

using System; 

namespace INPUT_INFORMATION
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to type first name.
            Console.WriteLine("What is your first name?");

            //Takes user's input string and saves it to variable for first name.
            string firstName = Console.ReadLine();

            //Asks user to type last name.
            Console.WriteLine("What is your last name?");

            //Takes user's input string and saves it to variable for last name.
            string lastName = Console.ReadLine();

            //Asks user to type age. 
            Console.WriteLine("What is your age?");

            //Takes user's input int and saves it to variable for age. 
            int age = Convert.ToInt32(Console.ReadLine());

            //Asks user to type favorite color.
            Console.WriteLine("WHat is your favorite color?");

            //Takes user's input string and saves it to variable for favorite color. 
            string favColor = Console.ReadLine();

            //Conbines user's inputs together in a sentence and prints.
            Console.WriteLine("Hello " + firstName + " " + lastName + "! " + "You are " + age + " years old and your favorite color is " + favColor + ".");
        }
    }
}


//First name
//Last name
// age
//favorite color
//prints out sentence with user information plugged in. 