﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Pattern2
    {
        public static void PrintPattern()
        {
            Console.WriteLine("Enter the number of rows");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());

            for (int row = 1; row <= numberOfRows; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    Console.Write(column+ " ");
                }
                Console.WriteLine();
            }

        }
    }
}
