using System;

namespace UniversityManager
{
    abstract class Person
    {
        string name, surname;
        DateTime birth_date;

        // Constructor
        public Person(string name, string surname, DateTime birth_date)
        {
            this.name = name;
            this.surname = surname;
            this.birth_date = birth_date;
        }

        public string Name
        {
            get { return name; }
        }

        public string Surname
        {
            get { return surname; }
        }

        public DateTime BirthDay
        {
            get { return birth_date; }
        }
    }
}
