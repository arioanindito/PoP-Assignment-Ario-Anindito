using System;
using System.Collections.Generic;

namespace PoP_Assignment_Ario_Anindito
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            var adding = true;
            while (adding)
            {
                try
                {
                    var newStudent = new Student();
                    var newAddress = new Address();

                    newStudent.FirstName = Util.Console.Ask("Student First Name: ");
                    if (string.IsNullOrEmpty(newStudent.FirstName))
                    {
                        TryAgain();
                        continue;
                    }

                    newStudent.LastName = Util.Console.Ask("Student Last Name: ");
                    if (string.IsNullOrEmpty(newStudent.LastName))
                    {
                        TryAgain();
                        continue;
                    }

                    newStudent.StudentNumber = Util.Console.Ask("Student Number: ");
                    if (string.IsNullOrEmpty(newStudent.StudentNumber))
                    {
                        TryAgain();
                        continue;
                    }

                    newStudent.Age = Util.Console.AskInt("Student Age: ");

                    newAddress.Street = Util.Console.Ask("Student Address (Street): ");
                    if (string.IsNullOrEmpty(newAddress.Street))
                    {
                        TryAgain();
                        continue;
                    }

                    newAddress.City = Util.Console.Ask("Student Address (City): ");
                    if (string.IsNullOrEmpty(newAddress.City))
                    {
                        TryAgain();
                        continue;
                    }

                    newAddress.Country = Util.Console.Ask("Student Address (Country): ");
                    if (string.IsNullOrEmpty(newAddress.Country))
                    {
                        TryAgain();
                        continue;
                    }

                    newStudent.FullAddress = newAddress.address;
                    newStudent.City = newAddress.City;

                    int n = Util.Console.AskInt("How many score to input?: ");
                    Console.Write($"Input {n} number of score:\n");
                    int[] arr = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Score - {i + 1} : ");
                        arr[i] = int.Parse(Console.ReadLine());
                    }

                    int sum = 0;
                    int average = 0;
                    for (int i = 0; i < n; i++)
                    {
                        sum += arr[i];
                    }
                    average = sum / n;
                    newStudent.AverageScore = average;

                    students.Add(newStudent);
                    Student.Count++;

                    Console.WriteLine();
                    Console.WriteLine($"Student Count: {Student.Count}");
                    Console.WriteLine("Add another student? y/n");
                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                    Console.WriteLine();
                }
                catch (FormatException msg)
                {
                    Console.WriteLine(msg.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, Please try again!");
                }
            }

            Console.WriteLine("--------------- Student Information ---------------");

            foreach (var student in students)
            {
                Console.WriteLine(student.ToString());
                Console.WriteLine("---------------------------------------------------");
            }
            Console.ReadLine();
        }

        static void TryAgain()
        {
            Console.WriteLine("Field cannot be empty!");
        }
    }

}
