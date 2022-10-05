using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class Delegateeg
    {

        public delegate void PrintOnScreen(string data);

        public static void HelloWorldMethod(string data)
        {
            Console.WriteLine(data);
        }
        public static void DelegateExample()
        {
            //Calling Below HelloWorldMethod using delegate
            PrintOnScreen poc = new PrintOnScreen(HelloWorldMethod); //Setting delegate 
            poc("Hello World! I am back!");//Invoking method using delegate
        }
    }
}
