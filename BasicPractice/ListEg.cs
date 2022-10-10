using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    internal class ListEg
    {
        public static void ListExample()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(2);
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);

            List<string> names = new List<string>();
            names.Add("Ross");
            names.Add("John");
            names.Add("Joey");
            names.Add("Rachel");
            names.Add("Chandler");

            //adding elements using collection-initializer syntax
            var bigCities = new List<string>()
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };

            Console.WriteLine("Prime numbers : ");
            foreach (int item in primeNumbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Names : ");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine("Big Cities  : ");
            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }

            string[] cities = new string[3] { "Mumbai", "London", "New York" };

            var popularCities = new List<string>();

            // adding an array in a List
            popularCities.AddRange(cities);

            var favouriteCities = new List<string>();

            // adding a List 
            favouriteCities.AddRange(bigCities);

            Console.WriteLine("Popular Cities  : ");
            foreach (string city in popularCities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("Favourite Cities  : ");
            foreach (string city in favouriteCities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
