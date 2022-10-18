﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace solution.Models
{
    [Serializable]
    public class StudentWL : ModelWL
    {
        public StudentWL(Student student)
        {
            Id = student.Id;
            Student = student;
            GetUrl = $"{UrlPref}/{student.Id}";
            UpdateUrl = $"{UrlPref}/{student.Id}";
            CreateUrl = $"{UrlPref}";
            DestroyUrl = $"{UrlPref}";
        }

        public int Id { get; set; }
        public Student Student { get; set; }
        public string CreateUrl { get; set; }
        public string GetUrl { get; set; }
        public string UpdateUrl { get; set; }
        public string DestroyUrl { get; set; }
    }
}