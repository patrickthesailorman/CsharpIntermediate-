using System;
using System.Collections.Generic;

namespace firstFiles
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
      try
      {
          var num = int.Parse("abc");
      }
      catch(Exception)
      {
          Console.WriteLine("Conversion failed");
      }
      int number;
      var result = int.TryParse("abc", out number);
      if (result)
        Console.WriteLine(number);
      else
        Console.WriteLine("Conversion failed");
    }
    static void UseParams()
    {
      var calculator = new Calculator();
      Console.WriteLine(calculator.Add(1, 2));
      Console.WriteLine(calculator.Add(1, 2, 3));
      Console.WriteLine(calculator.Add(1, 2, 3, 4));
      Console.WriteLine(calculator.Add(new int[]{1, 2, 3, 4, 5, 6}));
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
