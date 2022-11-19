using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace solution.DB.models
{
    public class Note
    {
        public int Id { get; set; }
        public string Subj { get; set; }
        public int NoteValue { get; set; }

        public int? StudentId { get; set; }
        public Student Student { get; set; }
    }
}