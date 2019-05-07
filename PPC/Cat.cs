using System;
using System.Collections.Generic;
using System.Text;

namespace PPC
{
    public class Cat : Animal
    {
        public Cat()
        {
            Name = "unknown";
            Color = "unknown";
            TypeOfAnimal = "unknown";
        }

        public Cat(string name, string color, string typeofanimal)
        {
            Name = name;
            Color = color;
            TypeOfAnimal = typeofanimal;
        }

        public override void Speak()
        {
            Console.WriteLine($"The {TypeOfAnimal} Meow!");
        }

    }
}
