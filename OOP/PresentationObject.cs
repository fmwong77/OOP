using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public void Copy()
        {
            Console.WriteLine("Copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Duplicated");
        }
    }
}
