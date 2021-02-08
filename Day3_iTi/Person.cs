using System;
using System.Collections.Generic;
using System.Text;

namespace Day3_iTi
{
    class Person
    {
        public int age { get; set; }
        public String name { get; set; }
        public Person(int Age, string Name)
        {
            age = Age;
            name = Name;
        }
        public override string ToString()
        {
            return $"Age is {age}  Name is {name}";

        }
    }
}
