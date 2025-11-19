using System;

namespace SystemModules
{
    public class Person
    {
        public Person()
        {
            
        }
        public Person(Nullable<int> iD, string firstName, string lastName, string email, char gender, DateTime birthDate, byte age)
        {
            if (iD != null)
                ID = (int)iD;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            BirthDate = birthDate;
            Age = age;
        }

        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public char Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public byte Age { get; set; }
    }
}