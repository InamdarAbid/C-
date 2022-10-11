using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class HashSetEg
    {
        public static void HashSetExample()
        {
            var names = new HashSet<string>();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            // Iterate HashSet elements using foreach loop  
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
