using solution.DB.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.DB.models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Note> Notes { get; set; }
        public Student()
        {
            Notes = new List<Note>();
        }
    }
}