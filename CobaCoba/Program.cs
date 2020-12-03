using System;
using System.Collections.Generic;
using System.Text;

namespace CobaCoba
{
    public static class PersonManager
    {
        public static List<Person> CreatePersonList(int numberOfPersons)
        {
            List<Person> people = new List<Person>();

            while (people.Count < numberOfPersons)
            {
                try
                {
                    Console.WriteLine($"New Person {people.Count + 1 }");

                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Person person = new Person(name, email, age);

                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error while adding a person {ex.Message}.");
                    Console.WriteLine("Please enter it again.");
                }
            }

            return people;
        }
    }
}