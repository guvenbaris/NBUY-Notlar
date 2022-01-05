using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_School.Models;

namespace MVC_School.Controllers
{
    public class StudentController : Controller
    {
        //Veritabanı yerine List kullandık
        public List<Student> Students = new List<Student>();

        private Student student = new Student
        {
            EducationClass = "10/A",
            Name = "Barış",
            Number = 442,
            Surname = "ÇAKAN"
        };

        


        // GET: Student listesini yazdırsın. Yanlarında Düzenleme,Silme bağlantıları ile birlikte.
        public ActionResult Index()
        {
            Students.Add(student);
            return View(Students);
        }


    }
}