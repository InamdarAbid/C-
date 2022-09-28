using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class ConstructorEg
    {
        //Default constructor 
        //public ConstructorEg()
        //{
        //    Console.WriteLine("Default Constructor called");
        //}

        //Default constructor passing a default parameter to call parameterized constructor 
        public ConstructorEg() : this(45) { }

        public ConstructorEg(int n)
        {
            Console.WriteLine("Parameterised constructor called {0}", n);
        }
    }
}
