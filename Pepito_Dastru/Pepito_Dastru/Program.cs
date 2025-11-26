using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_Dastru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gian Marty Pepito
            //IT401A
            //Problem: Using control structure

            Console.WriteLine("This program will determine what type of number and display its range.");

            Console.WriteLine("");
            Console.Write("Please enter a number: ");
            double range;
            range = Convert.ToDouble(Console.ReadLine());


            if (range == 10)
            {
                Console.WriteLine("10 is an even number");
                Console.WriteLine("");
                Console.WriteLine("This is the range of numbers based from the number entered.");
                Console.WriteLine("10 8 6 4 2");
            }
            else if (range == 8)
            {
                Console.WriteLine("8 is an even number");
                Console.WriteLine("");
                Console.WriteLine("This is the range of numbers based from the number entered.");
                Console.WriteLine("10 8 6 4 2");
            }
            else if (range == 6)
            {
                Console.WriteLine("6 is an even number");
                Console.WriteLine("");
                Console.WriteLine("This is the range of numbers based from the number entered.");
                Console.WriteLine("10 8 6 4 2");
            }
            else if (range == 4)
            {
                Console.WriteLine("4 is an even number");
                Console.WriteLine("");
                Console.WriteLine("This is the range of numbers based from the number entered.");
                Console.WriteLine("10 8 6 4 2");
            }
            else if (range == 2)
            {
                Console.WriteLine("2 is an even number");
                Console.WriteLine("");
                Console.WriteLine("This is the range of numbers based from the number entered.");
                Console.WriteLine("10 8 6 4 2");
            }
            else if (range == )
            {
                Console.WriteLine("Please re-try to enter a numeric value.");
            }
            else
            {
                Console.WriteLine("Sorry, I cannot provide the range of numbers based from the number  you entered.");
            }
            Console.WriteLine("");
            Console.WriteLine("Do you want to try again? (y/n)");
            char Letter;
            Letter = Console.ReadLine();

            if (Letter == "y")
            {
                
            }
        }
    }
}
