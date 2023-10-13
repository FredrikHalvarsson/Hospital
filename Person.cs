using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Person
    {
        public Person(string name="No name", int age=0)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Print()
        {
            
        }

    }
}
