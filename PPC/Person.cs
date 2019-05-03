using System;
using System.Collections.Generic;
using System.Text;

namespace PPC
{
    public class Person
    {
        public string Name { get; }

        public Person()
        {
            Name = "unknown";
        }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
