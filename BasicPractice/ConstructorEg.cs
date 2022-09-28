using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class ConstructorEg
    {
        public ConstructorEg()
        {
            Console.WriteLine("Default Constructor called");
        }

        public ConstructorEg(int n)
        {
            Console.WriteLine("Parameterised constructor called {0}", n);
        }
    }
}
