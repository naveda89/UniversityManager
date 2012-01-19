using System;
using System.Collections.Generic;

namespace UniversityManager
{
    class Teacher : Person
    {
        List<Course> courses;

        public Teacher(string name, string surname, DateTime birth_date)
                : base(name, surname, birth_date)
        {
        }
    }
}
