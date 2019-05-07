using System;
using System.Collections.Generic;
using System.Text;

namespace PPC
{
    public class Dog : Animal
    {
        public Dog()
        {
            Name = "unknown";
            Color = "unknown";
            TypeOfAnimal = "unknown";
        }

        public Dog(string name, string color, string typeofanimal)
        {
            Name = name;
            Color = color;
            TypeOfAnimal = typeofanimal;
        }
    }
}
