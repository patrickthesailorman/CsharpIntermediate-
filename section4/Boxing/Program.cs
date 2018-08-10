using System;
using System.Collections;
using System.Collections.Generic;


namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Arraylist();
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            // var number = (int) list[1];
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add();
            
            // Console.WriteLine("Hello World!");
        }
    }
}

// - C# types are divided into two categories: value types and reference types.
// - Value types (eg int, char, bool, all primitive types and struct) are stored in the stack.
// They have a short life time and as soon as they go out of scope are removed from
// memory.
// - Reference types (eg all classes) are stored in the heap.
// - Every object can be implicitly cast to a base class reference.
// - The object class is the parent of all classes in .NET Framework.
// - So a value type instance (eg int) can be implicitly cast to an object reference.
// - Boxing happens when a value type instance is converted to an object reference.
// - Unboxing is the opposite: when an object reference is converted to a value type.
// - Both boxing and unboxing come with a performance penalty. This is not noticeable
// when dealing with small number of objects. But if you’re dealing with several
// thousands or tens of thousands of objects, it’s better to avoid it.