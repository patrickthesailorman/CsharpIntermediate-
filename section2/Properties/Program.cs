using System;

namespace Properties
{
    public class Person
    {
        public DateTime Birthdate { get; set; }
         public int Age
         {
             get
             {
                 var timeSpan = DateTime.Today - Birthdate;
                 timeSpan.Days
             }
         }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        }
    }
}
