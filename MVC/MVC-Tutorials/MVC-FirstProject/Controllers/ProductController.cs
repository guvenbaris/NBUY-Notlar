using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FirstProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Create()
        {
            ViewBag.ProductName = "Laptop";
            ViewBag.UnitPrice = 100;
            return View();
        }

        public ActionResult Delete()
        {
            ViewBag.ProductId = 1;
            return View();
        }

        public ActionResult Update()
        {
            ViewBag.ProductId = 1;
            return View();
        }

        public ActionResult Add()
        {
            ViewBag.ProductName = "Mouse";
            ViewBag.UnitPrice = 20;
            return View();
        }
    }
}