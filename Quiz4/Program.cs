using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Title of program
            Console.WriteLine("CHECK DUPLICATE");
            //Space for visibility
            Console.WriteLine();
            //Prompts user for string
            Console.Write("Enter a string: ");
            //Converts user input to string variable userInput
            string userInput = Console.ReadLine();

            //Shows user results
            Console.WriteLine("Result:");
            //Foreach loop that checks each character in string
            foreach (char i in userInput)
            {
                Console.WriteLine(userInput.IndexOf(i));
            }
            //Pauses program for user to view
            Console.ReadLine();
        }
    }
}
