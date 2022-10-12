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

            //Before removing any item
            Console.WriteLine("Before removing any item {0}",names.Count);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-----------------------");
            //Remove() method to remove an item 
            names.Remove("Peter");
            Console.WriteLine("Afer removing an item");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("-----------------------");

            //After removing everything
            names.Clear();
            Console.WriteLine("After clear() {0}", names.Count);

            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            HashSet<string> list = new HashSet<string>();
            list.Add("C++");
            list.Add("C#");
            list.Add("Java");
            list.Add("Peter");
            list.Add("Irfan");

            Console.WriteLine("-----------------------");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-----------------------");

            //A.Unionwith(B) to union two different hashset (A union B)
            names.UnionWith(list);
            Console.WriteLine("After unionwith() method : ");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-----------------------");
            //A.Intersectwith(B) return A intersect B
            names.IntersectWith(list);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-----------------------");
            //A.ExceptWith(B) return what has in A but not in B
            names.Clear();
            names.Add("Sonoo");
            names.Add("Ankit");
            names.Add("Peter");
            names.Add("Irfan");
            names.Add("Ankit");//will not be added  

            names.ExceptWith(list);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

        }
    }
}
