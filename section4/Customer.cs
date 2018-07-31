using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set }
        public string { get; set; }

        public void Promote()
        {
            Console.WriteLine("Promote logic changed.");
        }
    }
}