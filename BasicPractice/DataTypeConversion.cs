using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class DataTypeConversion
    {
        /// <summary>
        /// THis class covers Inplicit and Explicit conversion of datatypes and difference between parse and Tryparse method
        /// </summary>
        public static void ImplicitExplicit()
        {
            int i = 100;
            float f = i;
            Console.WriteLine("Inplicit conversion from higer to lower type {0}",f);
            f = 100.1245f;
            i = (int)f; //Explicit conversion from higer to lower type some data may lost 
            Console.WriteLine("Explicit conversion from higer to lower type {0}",i);
            //Option 2 
            i = Convert.ToInt32(f);
            //use convert to higher to lower value type and Parse to extract numbers from string
            string number = "241512";
            i = int.Parse(number);
            Console.WriteLine("Using parse {0}", i);
            number = "12sdfs";//here parse will throw error so use tryparse method
            if(int.TryParse(number,out i))
            {
                Console.WriteLine("Parsed string {0}", i);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            //TryParse maethod to avoid exception



        }
    }
}
