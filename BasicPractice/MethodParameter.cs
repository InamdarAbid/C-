using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicPractice
{
    public class MethodParameter
    {
        public static void CallingMethod()
        {
            int i = 0;
            int j = 0;
            Console.WriteLine("Before calling method i = {0}, j = {1} ", i,j);
            CallByValue(i);
            Console.WriteLine("After call by value {0} ", i);
            CallByReference(ref i);
            Console.WriteLine("After call by reference {0} ", i);
            OutParameter(i, out j);
            Console.WriteLine("After calling with out parameter i = {0}, j = {1} ",i,j);
        }

        public static void CallByValue(int i)
        {
            i = 2;
            Console.WriteLine("Inside call by value {0}", i);
        }

        public static void CallByReference(ref int i)
        {
            i = 3;
            Console.WriteLine("Inside call by reference {0}", i);
        }

        public static void OutParameter(int i,out int j)
        {
            j = i+1;
        }
    }
}
