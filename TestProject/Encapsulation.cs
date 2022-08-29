using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExample
{
    class Base3
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Run()
        {
            Console.WriteLine("Base Class Run() Method");
        }
        public virtual void Walk()
        {
            Console.WriteLine("Child Class Walk() Method");
        }
    }

    class Child3 : Base3
    {
        public int Age
        {
            get;
            set;
        }
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
