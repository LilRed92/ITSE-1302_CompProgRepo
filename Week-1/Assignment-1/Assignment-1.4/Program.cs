// See https://aka.ms/new-console-template for more information

using System;

namespace RectangleAreaPerim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for the length of rectangle
            Console.WriteLine("Enter the length of the rectangle: ");

            //Stores user's input to int variable. 
            int length = Convert.ToInt32(Console.ReadLine());

            //Asks user for the width of rectangle.
            Console.WriteLine("Enter the width of the rectangle: ");

           //Stores user's input to in variable. 
           int width = Convert.ToInt32(Console.ReadLine());

            //Calculates perimeter.
            int perimeter = 2 * (length + width);

            //Calculates area.
            int area = length * width;

            //Prints results of perimeter and area.
            Console.WriteLine("Results:");
            Console.WriteLine("Area of the rectangle: " + area);
            Console.WriteLine("Perimeter of the rectangle: " + perimeter);

        }
    }
}
