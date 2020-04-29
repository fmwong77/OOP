using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized {0}", registrationNumber);
        }
    }
}
