using System;
using System.Collections;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Arraylist();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            var number = (int) list[1];
            
            // Console.WriteLine("Hello World!");
        }
    }
}
