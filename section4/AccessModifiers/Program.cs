using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set }
        public string { get; set; }

        public void Promote()
        {

        }

        public int CalculateRating()
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            // Console.WriteLine("Hello World!");
        }
    }
}
