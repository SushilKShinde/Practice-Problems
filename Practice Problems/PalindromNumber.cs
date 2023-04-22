using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class PalindromNumber
    {
        // number is a palindrom if its reverse is equal to the original number 
        public static void CheckForPalindrom()
        {
            Console.WriteLine("Enter the number");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int reverse;
            int temp = n;

            while(n>0)
            {
                reverse = n % 10;
                sum = (sum * 10) + reverse;
                n = n / 10;
            }

            if (sum == temp)
            {
                Console.WriteLine("{0} is palindrom", temp);
            }
            else
            {
                Console.WriteLine("{0} is not palindrom", temp);
            }

        }
    }
}
