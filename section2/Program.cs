using System;
using System.Collections.Generic;

namespace section2 
{
  class Program 
  {
    static void Main (string[] args) 
    {
      // var customer = new Customer (1, "John");

      // var order = new Order();
      // customer.Orders = new List<Order>();
      // customer.Orders.Add(order);

      // Console.WriteLine (customer.Id);
      // Console.WriteLine (customer.Name);
      
    }
    static void UsePoints()
    {
      try
      {
        var point = new Point(10,20);
        point.Move(null);
        Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

        point.Move(100, 200);
        Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
      }
      catch(Exception)
      {
          Console.WriteLine("An unexpected error occured");
      }
    }
  }
}