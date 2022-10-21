using Microsoft.EntityFrameworkCore;
using solution.Models;

namespace solution.DataBase
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-SN6OS1NR\MSSQLSERVER01;Initial Catalog=lab3;Integrated Security=True");
        }
    }
}