using System;
using System.Collections.Generic;
using System.Text;

namespace VariableScope
{
    public class Person
    {
        public string Name = "John Doe";

        public void SayHello()
        {
            string Name = "Test 123";
            Console.WriteLine("Hello, my name is " + Name);
        }
    }
}
