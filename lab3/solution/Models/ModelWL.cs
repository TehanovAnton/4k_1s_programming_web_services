using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.Models
{
    public class ModelWL
    {
        public static string UrlPref = "http://localhost:50369/api/students";

        public static List<StudentWL> StudentsWithLinks(List<Student> students)
        {
            List<StudentWL> studentsWithLinks = new List<StudentWL>();
            foreach(Student student in students)
                studentsWithLinks.Add(student.StudentWithLinks());

            return studentsWithLinks;
        }

    }
}