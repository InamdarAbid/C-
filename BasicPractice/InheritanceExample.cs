using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPractice
{
    /// <summary>
    /// Parent or base class for Inheritance
    /// </summary>
    public class InheritanceExample
    {
        public string FirstName = "Default";
        public string LastName = "Name";
        public string Email;

        public void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, you are still alive ? ", FirstName, LastName);
        }
    }

    public class FullTimeEmployee : InheritanceExample
    {
        public float YearlySalary;
    }
    /// <summary>
    /// Second child or subclass of Inheritance.
    /// </summary>
    public class PartTimeEmployee : InheritanceExample
    {
        public float HourlyRate;
        //use new keyword in child class method if we want to override (hide) parent method.
        public new void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, youe are part time! ", FirstName, LastName);
        }
    }
    public class TemperoryTimeEmployee : InheritanceExample
    {
        public float wadge;
        public void PrintFullName()
        {
            Console.WriteLine("Damm {0} {1}, youe are temperory! ", FirstName, LastName);
        }
    }

}
