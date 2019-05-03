using System;
using System.Collections.Generic;
using System.Text;

namespace PPC
{
    public class Car
    {
        public string Make;
        public string Model;
        public string Engine;
        public string Color;

        public int MyProperty { get; set; }
        public Car()
        {
            
        }


        public void Move()
        {   
            Console.WriteLine("The car is moving!");  
        }
    }
}
