using solution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace solution.DataBase
{
    public static class DB
    {
        static ApplicationContext db;

        public static List<Student> GetAll()
        {
            List<Student> records = new List<Student>();
            using (db = new ApplicationContext())
            {
                foreach (Student record in db.Students)
                {
                    records.Add(record);
                }
            }

            return records;
        }

        public static void AddRecord(string name, string phone)
        {
            using (db = new ApplicationContext())
            {
                Student record = new Student { Name = name, Phone = phone };
                db.Students.Add(record);
                db.SaveChanges();
            }
        }

        public static Student Find(int id)
        {
            Student record;
            using (db = new ApplicationContext())
            {
                record = GetAll().Find(el => el.Id == id);
            }

            return record;
        }

        public static void Update(int id, string name, string phone)
        {
            Student record = Find(id);
            using (db = new ApplicationContext())
            {
                record.Name = name;
                record.Phone = phone;
                db.Students.Update(record);
                db.SaveChanges();
            }
        }

        public static void Delete(int id)
        {
            Student record = Find(id);
            using (db = new ApplicationContext())
            {
                db.Students.Remove(record);
                db.SaveChanges();
            }
        }
    }
}