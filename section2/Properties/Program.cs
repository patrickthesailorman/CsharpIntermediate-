﻿using System;
using System.Collections.Generic;

namespace Properties
{

  class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Birthdate = new DateTime(1982, 1, 1);

            Console.WriteLine(person.Age);

        }
    }
}
