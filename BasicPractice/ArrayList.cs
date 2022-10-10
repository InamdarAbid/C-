using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace BasicPractice
{
    public class ArrayListEg
    {
        public static void ArrayListExample()
        {
            var arrlist1  = new ArrayList();
            arrlist1 .Add(1);
            arrlist1 .Add("Bill");
            arrlist1 .Add(" ");
            arrlist1 .Add(true);
            arrlist1 .Add(4.5);
            arrlist1 .Add(null);

            //adding objects using object initializer syntax
            var arrList2 = new ArrayList()
            {
                5,"john",0,true
            };

            //Use the Insert() method to insert an element at the specified index into an ArrayList./
            arrList2.Insert(2, 'A');

            //Use the InsertRange() method to insert a collection in an ArrayList at the specfied index.

            arrlist1.InsertRange(4, arrList2);

            Console.WriteLine(arrList2);
            
            Console.WriteLine("Arraylist 1 : ");
            foreach (var item in arrlist1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Arraylist 2 : ");
            foreach (var item in arrList2)
            {
                Console.WriteLine(item);
            }

            //Use the Remove(), RemoveAt(), or RemoveRange methods to remove elements from an ArrayList.
            arrlist1.Remove(null);
            arrlist1.RemoveAt(2);
            arrlist1.RemoveRange(4,2);
            
            Console.WriteLine("Arraylist 1 : ");
            foreach (var item in arrlist1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Arraylist 2 : ");
            foreach (var item in arrList2)
            {
                Console.WriteLine(item);
            }

            //Use the Contains() method to determine whether the specified element exists in the ArrayList or not. It returns true if exists otherwise returns false.
            Console.WriteLine(arrlist1.Contains(300)); // true
            Console.WriteLine(arrlist1.Contains("Bill")); // true
            Console.WriteLine(arrlist1.Contains(10)); // false
            Console.WriteLine(arrlist1.Contains("Steve")); // false

                
        }

    }
}
