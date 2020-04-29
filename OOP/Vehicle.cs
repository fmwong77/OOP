using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Vehicle
    {
        private string _registrationNumber;

      /*  public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized");
        }*/
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized {0}", registrationNumber);

        }
    }
}
