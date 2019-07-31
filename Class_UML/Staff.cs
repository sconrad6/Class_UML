using System;
namespace Class_UML
{
    class Staff : Person
    {
        public string School { get; set; }
        public double Pay { get; set; }

        public Staff()
        {

        }

        public Staff(string school, double pay, string name, string address)
            :base (name, address)
        {
            School = school;
            Pay = pay;
        }

        public override string ToString()
        {
            return $"Staff:\n{Name}\n{Address}\n{School}\nPay: ${Pay}\n";
        }

    }
}
