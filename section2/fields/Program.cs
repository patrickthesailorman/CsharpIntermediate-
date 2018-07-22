using System;
using System.Collections.Generic;

namespace fields
{
  class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            // Console.WriteLine("Hello World!");
        }
    }
}
