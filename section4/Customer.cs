using System;

namespace Amazon
{
    public class RateCalculator
    {
        public int Calculate(Customer customer)
        {
            return 0;
        }
    }
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