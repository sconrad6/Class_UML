using System;
using System.Collections.Generic;

namespace Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                PersonManager.PrintList();
                AddPerson();
            } while (true);
            
        }

        public static void AddPerson()
        {
            Console.WriteLine("Would you like to add a student or staff to the list?\n" +
                "Please type:\n" +
                "\"Student\" to add a student\n" +
                "\"Staff\" to add a staff member\n" +
                "or \"Exit\" to exit the program.");
            string userInput = Console.ReadLine().ToLower();

            switch (userInput)
            {
                case "student":
                    PersonManager.AddStudent();
                    PersonManager.PrintList();
                    break;
                case "staff":
                    PersonManager.AddStaff();
                    PersonManager.PrintList();
                    break;
                default:
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                    break;
            }
        }

        
    }
}
