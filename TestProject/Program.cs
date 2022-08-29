using System;
using InheritenceExample;
using SetterGetterExample;
using EncapsulationExample;
using OverridingExample;
namespace TestProject
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("The Example of Setter, Getter Method & Class Usage :");
            Example1 obj1 = new Example1();
            obj1.name = "Prabal";
            obj1.Age = 22;
            Console.WriteLine("Name is " + obj1.Name + " & Age is " + obj1.Age + '\n');

            Console.WriteLine("The Example of Inheritence :");
            Child2 obj3 = new Child2();
            obj3.Name = "Test User";
            obj3.Age = 30;
            Console.WriteLine("Name is " + obj3.Name + " & Age is " + obj3.Age + '\n');

            Console.WriteLine("The Example of Compile Overriding:");
            Base1 obj4 = new Base1();
            Child1 obj5 = new Child1();
            Base1 obj6 = new Child1();
            obj4.Run();
            obj5.Run();
            obj6.Run();

            Console.WriteLine("\n The Example of Runtime Overriding :");
            obj4.Walk();
            obj5.Walk();
            obj6.Walk();
        }
    }
}
