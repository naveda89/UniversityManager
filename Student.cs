using System;

namespace UniversityManager
{
    class Student : Person
    {
        public Student(string name, string surname, DateTime birth_date)
                : base(name, surname, birth_date)
        {
        }
    }
}
