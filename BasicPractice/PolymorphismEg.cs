using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class PolymorphismEg
    {
        Example of runtime Polymorphism
        Employee[] e = new Employee[4];
        e[0] = new Employee();
        e[1] = new PartTimeEmployee();
        e[2] = new FullTimeEmployee();
        e[3] = new TemperoryTimeEmployee();

        foreach(Employee empl in e)
        {
            empl.PrintFullName();
        }
}

    public static class CompiletimePolymorphism
    {
        public static void area(int side)
        {
            Console.WriteLine("Area of squeare : {0}",(side * side));
        }

        public static void area(int l,int b)
        {
            Console.WriteLine("Area of rectangle : {0}", (l * b));
        }
    }

}
