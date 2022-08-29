using System;
using System.Collections.Generic;
using System.Text;

namespace SetterGetterExample
{
    class Example1
    {
        public Example1()
        {
            Console.WriteLine("Constructor Print");
        }
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            set; get;
        }
    }

}
