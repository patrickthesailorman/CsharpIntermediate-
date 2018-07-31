using System;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
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
