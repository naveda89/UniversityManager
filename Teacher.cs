using System;

namespace UniversityManager
{
    class Teacher : Person
    {
        public Teacher(string name, string surname, DateTime birth_date)
                : base(name, surname, birth_date)
        {
        }
    }
}
