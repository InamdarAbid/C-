using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{ 
    /// <summary>
    /// This Class has code for basic String types in C#
    /// </summary>
    public class StringTypes
    {
        public static void PrintStrings()
        {
            string Name = "Abid";
            Name = "\"Abid"; //Use / as escape character  
            Console.WriteLine(Name);
            Name = @"C:\Windows\System32\cmd.exe"; //If you use @ at the  start you don't have to use escape chatacters at the begining
            Console.WriteLine(Name);
            Console.WriteLine(" 1 \n 2 \n 3");
        }

    }
}
