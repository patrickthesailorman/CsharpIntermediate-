using System;

namespace Upcasting
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            text.Width  = 100;

            Console.WriteLine(text.Width);
        }
    }
}
