using solution.DB.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace solution.DB
{
    public class StudentsContext : DbContext
    {
        public StudentsContext() : base("DbConnection")
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set; }
    }
}