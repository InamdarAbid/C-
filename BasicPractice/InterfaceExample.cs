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


    //Multiple inheritance using interface
    interface BaseOne
    {
        public void printHello();
    }

    interface BaseTwo
    {
        public void PrintHelloI2();
    }

    public class ChildClass : BaseOne, BaseTwo
    {
        public void printHello()
        {
            Console.WriteLine("Hello world from Base One");
        }

        public void PrintHelloI2()
        {
            Console.WriteLine("Hello world from Base two");
        }
    }

}
