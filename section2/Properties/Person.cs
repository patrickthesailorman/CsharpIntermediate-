using System;
using System.Collections.Generic;

namespace Properties
{
  public class Person
    {
      public Person(DateTime birthdate)
      {
          Birthdate = birthdate;
      }
        public DateTime Birthdate { get; private set; }
         public int Age
         {
             get
             {
                 var timeSpan = DateTime.Today - Birthdate;
                 var years = timeSpan.Days / 365;

                 return years;
             }
         }
    }
}
