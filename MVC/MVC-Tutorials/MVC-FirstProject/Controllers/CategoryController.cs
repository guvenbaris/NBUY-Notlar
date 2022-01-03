using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_FirstProject.Models;


namespace MVC_FirstProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        private static List<Categories> _categoriesList = new List<Categories>();

        //List<string> categories = new List<string>
        //{
        //    "Car","Computer","Tech"
        //};


        public ActionResult List()
        {
            return View(_categoriesList);
        }

        public ActionResult Create()
        {
            return View();
        }

        //[HttpGet]
        //public ActionResult Create()
        //{
        //    return View();
        //}

        [HttpPost]
        public ActionResult Create(Categories category)
        {
            _categoriesList.Add(category);
            return RedirectToAction("List");
        }

    }
}