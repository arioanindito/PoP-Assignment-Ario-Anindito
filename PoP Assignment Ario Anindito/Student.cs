using System;
using System.Collections.Generic;
using System.Text;

namespace PoP_Assignment_Ario_Anindito
{
    class Student : Person
    {
        static public int Count = 0;
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string StudentNumber { get; set; }
        public int Age { get; set; }
        public int Score { get; set; }
        public int AverageScore { get; set; }
        public string FullAddress { get; set; }
        public string City { get; set; }
        public Student()
        {

        }

        public override string ToString()
        {
            return ($" Student {FullName} score average is {AverageScore}\n " +
                $"Student {FullName} is living in {City}\n " +
                $"Student {FullName} address is {FullAddress}");
        }
    }
}
