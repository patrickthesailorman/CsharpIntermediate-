using System;

namespace Upcasting
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yo!");
        }
    }
}
