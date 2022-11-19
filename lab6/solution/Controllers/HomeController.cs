using solution.DB;
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
                Student user1 = new Student { Name = "Anton" };
                Student user2 = new Student { Name = "Andrew" };

                db.Students.Add(user1);
                db.Students.Add(user2);
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