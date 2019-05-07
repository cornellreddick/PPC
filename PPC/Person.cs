using System;
using System.Collections.Generic;
using System.Text;

namespace PPC
{
    public class Person
    {
        
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "unknown";
            Age = 21;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Running()
        {
           Console.WriteLine($"{Name} is runnning!");
        }

        public void Dunking()
        {
            Console.WriteLine($"{Name} just dunked!");
        }

        //public override string ToString()
        //{
        //    return Name;
        //}
    }
}
