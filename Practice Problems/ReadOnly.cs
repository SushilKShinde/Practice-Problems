using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Problems
{
    internal class ReadOnly
    {
        // readonly variables declaired with the keyword Readonly
        //only initialized in the constructor or method or outside the method but inside the class

        public readonly int id;

        // Constructor without parameters
        public ReadOnly()
        {
            this.id = 40;
        }

        //constructor with parameters
        public ReadOnly(int id)
        {
            this.id = id;
        }
    }
}
