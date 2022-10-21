using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.Models
{
    [Serializable]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public StudentWL StudentWithLinks(string columns = "Id,Name,Phone")
        {
            char[] separators = new char[] { ',' };
            List<string> columnsList = columns.Split(separators).ToList();

            return new StudentWL(this, columnsList);
        }
    }
}