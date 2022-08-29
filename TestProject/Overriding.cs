using System;
using System.Collections.Generic;
using System.Text;

namespace OverridingExample
{
    class Base1
    {
        public void Run()
        {
            Console.WriteLine("Base Class Run() Method");
        }
        public virtual void Walk()
        {
            Console.WriteLine("Base Class Walk() Method");
        }
    }

    class Child1 : Base1
    {
        public void Run()
        {
            Console.WriteLine("Child Class Run() Method");
        }

        override
        public void Walk()
        {
            Console.WriteLine("Child Class Walk() Method");
        }
    }
}
