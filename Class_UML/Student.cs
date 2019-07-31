using System;
namespace Class_UML
{
    class Student : Person
    {
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }

        public Student()
        {

        }

        public Student(string program, int year, double fee, string name, string address)
            : base (name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override string ToString()
        {
            return $"Student:\n{Name}\n{Address}\n{Program}\n{Year}\nProgram Fee: ${Fee}\n";
        }

    }
}
