using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    interface Base
    {
        public void Print();
    }

    interface Child : Base
    {
        public void Print2();
    }

    public class InterfaceExample : Child
    {
        public void Print()
        {
            Console.WriteLine("Base Interface implemented");
        }

        public void Print2()
        {
            Console.WriteLine("Child Interface implemented");
        }
    }
}
