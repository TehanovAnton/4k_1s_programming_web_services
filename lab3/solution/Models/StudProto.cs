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
            if (IsInclude(columns, "Id"))
                Id = student.Id;

            if (IsInclude(columns, "Name"))
                Name = student.Name;

            if (IsInclude(columns, "Phone"))
                Phone = student.Phone;

            GlobalStr = student.Id + student.Name + student.Phone;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string GlobalStr { get; set; }

        private bool IsInclude(List<string> columns, string column)
        {
            return columns.Any((c) => c == column);
        }
    }
}