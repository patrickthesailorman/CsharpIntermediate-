using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set }
        public string { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
        }

        public int CalculateRating()
        {
            return 0;
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
