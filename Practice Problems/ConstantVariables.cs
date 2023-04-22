using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class ConstantVariables
    {
        //constant variables are declaired using keyword const
        // they must be initialized at the time of declaration
        //the value of constant variables can't be changed  
        const int phone = 451263;

        public static void Employee()
        {
            Console.WriteLine(phone);
            const string name = "Sushil";
            Console.WriteLine(name);
        }
    }
}
