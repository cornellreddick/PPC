using System;
using System.Collections.Generic;
using System.Text;

namespace PPC
{
    public class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string TypeOfAnimal { get; set; }

        public Animal()
        {
            Name = "unknown";
            Color = "unknown";
            TypeOfAnimal = "unknown";
        }

        public Animal(string name, string color, string typeofanimal)
        {
            Name = name;
            Color = color;
            TypeOfAnimal = typeofanimal;
        }

        public virtual void Speak()
        {
            
            Console.WriteLine($"The {TypeOfAnimal} is barking");
        }


    }
}
