using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public abstract class AC
    {
        public abstract void PrintName(string name);
    }

    public class ACImplementation : AC
    {
        public override void PrintName(string name)
        {
            Console.WriteLine("Hello {0}",name);
        }
    }
   
}
