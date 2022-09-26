using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    /// <summary>
    /// This class contain example of if , if else and if else if statements and difference between & and && operator 
    /// </summary>
    public class IfStatements
    {
        public static void IfElseExample()
        {
            //If statement 
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 ==  0)
            {
                Console.WriteLine("Even number");
            }
            if(number % 2 == 1)
            {
                Console.WriteLine("Odd number"); 
            }

            //If else statement 
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }

            //If else if statement 
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number % 3 == 0)
            {
                Console.WriteLine("DIvisible by 3");
            }
            else if (number % 3 == 1)
            {
                Console.WriteLine("Remainder 1");
            }
            else
            {
                Console.WriteLine("Remainder 2"); 
            }

            /* & operator do bitwise AND operation and && does comparision operation. 
               We can use && and & in if statement if we use & it compare both side of & and if we use && and first condition is false then second condition is ignored.
             */
            if((number != 1 )&& (number != 2))
            {
                Console.WriteLine("Number is not 1 nor 2");
            }
            if ((number != 3) & (number != 4))
            {
                Console.WriteLine("Number is not 3 nor 4");
            }
        }
    }
}
