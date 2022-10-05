using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class Exceptionhandling
    {
        public static void ExceptionhandlingExample()
        {
            StreamReader str = null;
            try
            {
                str = new StreamReader(@"D:\Abid\Visual Studio Projects\Basic\Basic\Sample.txt");
                Console.WriteLine(str.ReadToEnd());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (str != null)
                    str.Close();
                Console.WriteLine("Finally block hit");
            }

        }
    }
}
