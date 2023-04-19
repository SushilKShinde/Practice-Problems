using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the practice problems");
            Console.WriteLine("Choose the option from below.\n");
            Console.WriteLine("1. Reverse a string\n ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    ReverseString.FindStringReverse();
                    break;
                default:
                    Console.WriteLine("Please choose the valid option");
                    break;
            }    
        }
    }
}
