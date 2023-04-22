using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class Floyd_sTriangle
    {
        public static void PrintFloydTriangle()
        {
            Console.WriteLine("Enter the number of rows");
            int numberOfRows = Convert.ToInt32(Console.ReadLine());
            int counter = 1;

            for(int row = 1; row <= numberOfRows; row++)
            {
                for (int column = 1; column <=row; column++)
                {
                    Console.Write(counter + " ");
                    counter++;
                }
                Console.WriteLine();
            }
        }
    }
}
