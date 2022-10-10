using BasicPractice;
using static BasicPractice.Structure;

class Porgram
{
    /// <summary>
    /// Please refer respective class for some basic documentation and example.
    /// Uncomment the methods you want to see results 
    /// </summary>
    public static void Main()
    {
        //Console.WriteLine("Hello World!");

        //String options 
        //StringTypes.PrintStrings();

        //Nullable and non nullable data type and Null  coalscing operator
        //NullableType.NullableTypeEg();

        //Implicit and explicit conversion of data
        //DataTypeConversion.ImplicitExplicit();

        //Arrays
        //ArrayExample.OneDimentional();
        //ArrayExample.TwoDimentional();
        //ArrayExample.JaggedArray();

        //Comments 
        //Single line comments added using // 
        /*  Multiline comments example
            This is line 2                 
         */

        //If statements 
        //IfStatements.IfElseExample();

        //Switch Statement 
        //SwitchStatement.SwitchEg();

        //Loops 
        //Loops.WhileLoop();
        //Loops.ForLoop();
        //Loops.DoWhileLoop();

        //Method parameter types
        //MethodParameter.CallingMethod();

        //Consructor 
        //ConstructorEg cs = new ConstructorEg();
        //ConstructorEg cs_2 = new ConstructorEg(13);

        //Static class and constructor
        //StaticClass.Area(5);

        //Inheritance
        //PartTimeEmployee PTE = new PartTimeEmployee();
        //PTE.FirstName = "Abid";
        //PTE.LastName = "Inamdar";
        //PTE.PrintFullName();

        //InheritanceExample emp = new PartTimeEmployee();
        //emp.PrintFullName();

        ////Example of runtime Polymorphism
        //Student[] e = new Student[4];
        //e[0] = new Student();
        //e[1] = new FullTimeStudent();
        //e[2] = new PartTimeStudent();
        //e[3] = new TemperoryTimeStudent();

        //foreach (Student empl in e)
        //{
        //    empl.PrintFullName();
        //}

        ////Example of compile time polymorphism
        //PolymorphismEg.area(10);
        //PolymorphismEg.area(5, 6);

        ////Structure Example
        //Stud student = new Stud(101, "Abid");
        //student.PrintStudent();

        //Stud student2 = new Stud();
        //student2.Name = "Ram";
        //student2.Id = 102;
        //student2.PrintStudent();

        //Stud student3 = new Stud
        //{
        //    Id = 104,
        //    Name = "Sham"
        //};
        //student3.PrintStudent();


        ////Interface Example 
        //InterfaceExample I = new InterfaceExample();
        //I.Print();
        //I.Print2();


        ////Multiple Inheritance using Interface
        //ChildClass c1 = new ChildClass();
        //c1.printHello();
        //c1.PrintHelloI2();

        ////Abstract class
        //ACImplementation ACI = new ACImplementation();
        //ACI.PrintName("John");
        ////OR
        //AC abstractClassObject = new ACImplementation();
        //abstractClassObject.PrintName("John");

        //Delegate example
        //Delegateeg.DelegateExample();

        //Excpetion Handling
        //Exceptionhandling.ExceptionhandlingExample();

        //ArrayList
        ArrayListEg.ArrayListExample();


    }
}