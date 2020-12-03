namespace CobaCoba
{
    public class Person
    {
        private string name;
        private int age;
        private string eMail;

        public Person(string name, string email, int age)
        {
            Name = name;
            EMail = email;
            Age = age;
        }

        public Person(string name, int age) : this(name, null, age)
        {
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new System.ArgumentNullException("Name cannot be null");
                }

                name = value;
            }
        }

        public string EMail
        {
            get => eMail; set
            {
                if (value == null)
                {
                    eMail = value;
                }
                else if (value.Contains("@"))
                {
                    eMail = value;
                }
                else
                {
                    throw new System.ArgumentException("Incorrect e-mail.");
                }
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("Age have to be between 0 and 100");
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {Age} {EMail}";
        }
    }
}