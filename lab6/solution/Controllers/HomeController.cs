using solution.DB;
using solution.DB.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace solution.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (StudentContext db = new StudentContext())
            {
                Student anton = new Student { Name = "Anton" };
                Student andrew = new Student { Name = "Andrew" };
                Student roma = new Student { Name = "Roma" };

                db.Students.AddRange(new List<Student> { anton, andrew });
                db.SaveChanges();

                Note noteMathStudAnt = new Note { Subj = "Math", NoteValue = 7, StudentId = anton.Id };
                Note noteProgrammingAnt = new Note { Subj = "Programming", NoteValue = 8, StudentId = anton.Id };
                Note noteDbAnt = new Note { Subj = "Database", NoteValue = 10, StudentId = anton.Id };

                Note noteMathStudAndr = new Note { Subj = "Math", NoteValue = 8, StudentId = andrew.Id };
                Note noteProgrammingAndr = new Note { Subj = "Programming", NoteValue = 9, StudentId = andrew.Id };
                Note noteDbAndr = new Note { Subj = "Database", NoteValue = 10, StudentId = andrew.Id };

                Note noteMathStudRoma = new Note { Subj = "Math", NoteValue = 9, StudentId = andrew.Id };
                Note noteProgrammingRoma = new Note { Subj = "Programming", NoteValue = 10, StudentId = andrew.Id };
                Note noteDbRoma = new Note { Subj = "Database", NoteValue = 10, StudentId = andrew.Id };

                db.Notes.AddRange(new List<Note> { noteMathStudAnt, noteProgrammingAnt, noteMathStudAndr, noteProgrammingAndr });
                db.SaveChanges();

                Console.WriteLine("Объекты успешно сохранены");

                var students = db.Students;
                Console.WriteLine("Список объектов:");
                foreach (Student st in students)
                {
                    Console.WriteLine("{0}.{1}", st.Id, st.Name);
                }
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}