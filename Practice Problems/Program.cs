﻿using System;
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
            Console.WriteLine("1.Reverse a string\n2.Check for Palindrom Number\n3.ReadOnly variable\n4.Constant Variables" +
                "\n5.Pattern 1\n6.Pattern 2\n7.Floyd's triangle\n8.Pattern 3\n9.Pattern 4\n10Pattern 5\n11.Pattern 6");
            int option = Convert.ToInt32(Console.ReadLine());

            switch(option)
            {
                case 1:
                    ReverseString.FindStringReverse();
                    break;
                case 2:
                    PalindromNumber.CheckForPalindrom();
                    break;
                case 3:
                    //Console.WriteLine("Enter the integer");
                    ReadOnly Variables = new ReadOnly();
                    //Variables.id = 45; ;
                    Console.WriteLine(Variables.id); // o/p = 40
                    break;
                case 4:
                    ConstantVariables.Employee();
                    break;
                case 5:
                    Pattern1.PrintPattern();
                    //1
                    //2 2
                    //3 3 3
                    //4 4 4 4
                    //5 5 5 5 5
                    break;
                case 6:
                    //1
                    //1 2
                    //1 2 3
                    //1 2 3 4
                    //1 2 3 4 5
                    Pattern2.PrintPattern();
                    break;
                case 7:
                    //1
                    //2 3
                    //4 5 6
                    //7 8 9 10
                    //11 12 13 14 15
                    Floyd_sTriangle.PrintFloydTriangle();
                    break;
                case 8:
                    //1
                    //1 1
                    //1 1 1
                    //1 1 1 1
                    //1 1 1 1 1
                    Pattern3.PrintPattern3();
                    break;
                case 9:
                    //1
                    //2 1
                    //3 2 1
                    //4 3 2 1
                    //5 4 3 2 1
                    Pattern4.PrintPattern();
                    break;
                case 10:
                    //5 5 5 5 5
                    //4 4 4 4
                    //3 3 3
                    //2 2
                    //1
                    Pattern5.PrintPattern();
                    break;
                case 11:
                    //5
                    //4 5
                    //3 4 5
                    //2 3 4 5
                    //1 2 3 4 5
                    Pattern6.PrintPattern();
                    break;
                default:
                    Console.WriteLine("Please choose the valid option");
                    break;
            }    
        }
    }
}
