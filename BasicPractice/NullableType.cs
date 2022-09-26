using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    /// <summary>
    /// This class include example for Nullable type and how to cast from nullable to non nullable 
    /// </summary>
    public class NullableType
    {
        //Data types are divided into nullable (reference type) and non nullable (value type)
        // Value type eg int,float,double,struct,enum,etc & reference type eg array, class, delegate, Interface,etc
        public static void NullableTypeEg()
        {
            int i = 0; //Not nullable 
            int? j = null; //Nullable by using ? at start
            i = j ?? 1;//Now to assign j to i we nned to check if j is null it is done using ?? (null coalscing operator) if j is null then assign 1 else j
            Console.WriteLine("i value is {0} and j value is {1}", i, j);
        }
        


    }
}
