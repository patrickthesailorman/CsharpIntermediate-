﻿using System;

namespace Constructors
{
    public class Vehicle
    {
        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized.");
        }
    }

    pubic class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
