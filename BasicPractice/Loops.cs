using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Loops
    {
        public static void WhileLoop()
        {
            Console.Write("Enter number : ");
            int i = int.Parse(Console.ReadLine());
            int num = 0;
            while (num < i)
            {
                Console.WriteLine(num);
                num++;
            }

        }

        public static void DoWhileLoop()
        {
            
            string choice = "N";
            do
            {
                int i = 0;
                Console.Write("Enter number : ");
                int num = int.Parse(Console.ReadLine());
                while (i < num )
                {
                    Console.WriteLine(i);
                    i++;
                }
                Console.Write("Do you want to continue ? (Y/N)");
                choice = Console.ReadLine();

            } while (choice.ToUpper() != "N");

        }

        public static void ForLoop()
        {
            Console.Write("Enter number : ");
            int num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine(i);
            } 

        }

    }
}
