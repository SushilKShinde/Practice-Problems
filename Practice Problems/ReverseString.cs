using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class ReverseString
    {
        public static void FindStringReverse()
        {
            Console.WriteLine("Enter a string.");
            string s = Console.ReadLine();
            Console.WriteLine("Before Reverse: "+s);
            string reverse = "";
            int l = s.Length - 1;
            while (l >= 0)
            {
                reverse = reverse + s[l];
                l--;
            }
            Console.WriteLine("After reverse: "+reverse);
        }
    }
}
