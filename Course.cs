using System;
using System.Collections.Generic;

namespace UniversityManager
{
    class Course
    {
        string name, description;
        List<Course> prerequisites;

        public Course(string name, string description = "")
        {
            this.name = name;
            this.description = description;
        }

        public void addPrerequisite(Course course)
        {
            prerequisites.Add(course);
        }
    }
}
