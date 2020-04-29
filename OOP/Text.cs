using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void Hyperlink(string url)
        {
            Console.WriteLine("hyperlink");
        }
    }
}
