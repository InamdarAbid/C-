using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    /// <summary>
    /// Static class can be called without object creation 
    /// </summary>
    public static class StaticClass
    {
        static float pi;
        /// <summary>
        /// Static constructor is created only once irrespective  of number of instance or objects you create for that class.    
        /// Static constructor cannot have access modifier because they are used to set static fields and they are called automatically before instance constructors are called.
        /// </summary>
        static StaticClass()
        {
            pi = 3.14f;
            Console.WriteLine("Static class constructor called");
        }

        public static void Area(int radius) 
        {
            float area  = pi * radius * radius;
            Console.WriteLine("Area is {0}", area);
        }

    }
}
