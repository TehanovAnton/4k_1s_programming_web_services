using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.Models
{
    [Serializable]
    public class CollectionSWL : ModelWL
    {
        public CollectionSWL(List<Student> students, string columns)
        {
            Collection = StudentsWithLinks(students, columns);
            CollectionUrl = UrlPref;
        }

        public string CollectionUrl { get; set; }
        public List<StudentWL> Collection { get; set; }
    }
}