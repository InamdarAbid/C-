using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class SortedListEg
    {
        public static void SortedListExample()
        {
            SortedList list1 =  new SortedList();
            list1.Add(1, "This");
            list1.Add(2, "is ");
            list1.Add(3, "a");
            list1.Add(4, "SortedList");
            list1.Add(5, "Example");
            for (int x = 0; x < list1.Count; x++)
            {
                Console.WriteLine("{0} and {1}",list1.GetKey(x),list1.GetByIndex(x));
            }

            //You can access the individual value of the SortedList by using the index.
            //You need to pass the key or index as a parameter to find the respective value.
            //If the specified key is not available, then the compiler will throw an error.
            Console.WriteLine("Value of key 4 is {0}",list1[4]);

            //You can use a foreach loop to access the key/value pairs of the SortedList.
            foreach(DictionaryEntry pair in list1)
            {
                Console.WriteLine("Key is {0} and value is {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("----------------------");
            // Remove value having 1.07 key
            // Using Remove() method
            list1.Remove(3);
            foreach (DictionaryEntry pair in list1)
            {
                Console.WriteLine("Key is {0} and value is {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("----------------------");
            //Remove at index using RemoveAt(index) method 
            list1.RemoveAt(2);
            foreach (DictionaryEntry pair in list1)
            {
                Console.WriteLine("Key is {0} and value is {1}", pair.Key, pair.Value);
            }

            Console.WriteLine("----------------------");
            //Remove all elements using clear() method
            list1.Clear();
            Console.WriteLine("The total number of key/value pairs present in list1:{0}", list1.Count);


        }
    }
}
