﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


namespace Upcasting
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();
            Text.text = (Text) shape;
        }
    }
}
