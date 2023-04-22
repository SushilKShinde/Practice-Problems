using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Pattern6
    {
        public static void PrintPattern()
        {
            Console.WriteLine("Enter the number of rows");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());

            for (int row = numberOfRows; row>=1; row--)
            {
                for (int column = row; column<= numberOfRows; column++)
                {
                    Console.Write(column + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
