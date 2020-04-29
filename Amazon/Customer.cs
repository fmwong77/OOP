using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);
            if (rating == 0)
                Console.Write("Promote to level 1");
            else
                Console.Write("Promote to level 2");

        }
    }
}
