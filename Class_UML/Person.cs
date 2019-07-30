using System;
namespace Class_UML
{
    abstract class Person
    {
        protected string Name { get; set; }
        protected string Address { get; set; }

        protected Person()
        {

        }

        protected Person(string name, string address)
        {
             Name = name;
             Address = address;
        }

        public override string ToString()
        {
            return $"{Name}, {Address}\n";
        }
    }
}
