using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    public class Student
    {
        public string FirstName = "Default";
        public string LastName = "Name";
        public string Email;

        public virtual void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, you are still alive ? ", FirstName, LastName);
        }
    }
    /// <summary>
    /// First child or subclass class for Inheritance.
    /// </summary>
    public class FullTimeStudent : Student
    {
        public float YearlySalary;
        //Override method using override keyword
        public override void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, youe are full time! ", FirstName, LastName);
        }
    }
    /// <summary>
    /// Second child or subclass of Inheritance.
    /// </summary>
    public class PartTimeStudent : Student
    {
        public float HourlyRate;
        //use new keyword in child class method if we want to override (hide) parent method.
        public new void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, youe are part time! ", FirstName, LastName);
        }
    }
    public class TemperoryTimeStudent : Student
    {
        public float wadge;
        public override void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, youe are temperory! ", FirstName, LastName);
        }
    }

    public class PolymorphismEg
    {
        //Compiletime polymorphism
        public static void area(int side)
        {
            Console.WriteLine("Area of squeare : {0}",(side* side));
        }

        public static void area(int l, int b)
        {
            Console.WriteLine("Area of rectangle : {0}", (l * b));
        }
    }

}
