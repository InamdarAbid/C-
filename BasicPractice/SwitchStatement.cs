using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class SwitchStatement
    {
        public static void SwitchEg()
        {
            Console.Write("Enter marks out of 10 : ");
            int marks  = int.Parse(Console.ReadLine());
            switch (marks)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    {
                        Console.WriteLine("Grade F");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Grade E");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Grade D");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Grade C");
                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Grade B");
                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Grade A");
                        break;
                    }
                case 10:
                    {
                        Console.WriteLine("Grade O");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }
            }

        }
    }
}
