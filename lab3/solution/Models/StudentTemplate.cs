using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.Models
{
    [Serializable]
    public class StudentTemplate
    {
        public StudentTemplate() { }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Id { get; set; }
    }
}