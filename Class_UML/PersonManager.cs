using System;
using System.Collections.Generic;

namespace Class_UML
{
    class PersonManager
    {
         static List<Person> personList = new List<Person>
            {
                new Student("Biology", 2020, 1200, "Patrick Joneses", "213 Main Street, Detroit MI"),
                new Student("Sociology", 2021, 1400, "Sasha White", "4 Westbrook Ave, GRand Rapids MI"),
                new Student("Creative Writing", 2022, 500, "Anton Wester", "35 Sweet Street, Ann Arbor MI"),
                new Staff("Saint Michael's College", 50000, "Jacob Hexly", "25 Linden Cr, Colchester, VT"),
                new Staff("University of Vermont", 60000, "Brian McCarthy","2 Pond View Dr, Waterford, VT")

            };

         public static void PrintList()
         {
            foreach (Person person in personList)
            {
                Console.WriteLine("----------");
                Console.WriteLine(person);
                Console.WriteLine("----------");
            }
            Console.WriteLine("----------");
        }

        public static void AddStudent()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Year of completion:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Fee:");
            double fee = double.Parse(Console.ReadLine());

            Console.WriteLine("Major:");
            string major = Console.ReadLine();

            Console.WriteLine("Address:");
            string address = Console.ReadLine();

            Student student = new Student(major, year, fee, name, address);
            personList.Add(student);

        }

        public static void AddStaff()
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Pay:");
            double pay = double.Parse(Console.ReadLine());

            Console.WriteLine("School:");
            string school = Console.ReadLine();

            Console.WriteLine("Address:");
            string address = Console.ReadLine();

            Staff staff = new Staff(school, pay, name, address);
            personList.Add(staff);

        }
    }
}
