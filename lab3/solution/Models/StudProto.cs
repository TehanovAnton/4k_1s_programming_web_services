using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.Models
{
    [Serializable]
    public class StudProto
    {
        public StudProto(Student student, List<string> columns)
        {
            if (columns.Any((c) => c == "Id"))
                Id = student.Id;

            if (columns.Any((c) => c == "Name"))
                Name = student.Name;

            if (columns.Any((c) => c == "Phone"))
                Phone = student.Phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}