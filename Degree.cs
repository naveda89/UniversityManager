using System;
using System.Collections.Generic;

namespace UniversityManager
{
    class Degree
    {
        string name, description;
        List<List<Course>> courses;

        public Degree(string name, int years, string description = "")
        {
            this.name = name;
            this.description = description;
            courses = new List<List<Course>>();
            for (int i=0; i<years; ++i)
                courses.Add(new List<Course>());
        }

        public void addCourse(Course course, int year)
        {
            courses[year-1].Add(course);
        }
    }
}
