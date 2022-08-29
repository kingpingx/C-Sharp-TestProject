using System;
using System.Collections.Generic;
using System.Text;

namespace InheritenceExample
{
    class Base2
    {
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Child2 : Base2
    {
        public int Age
        {
            get;
            set;
        }
  
    }  
}
