using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET : Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie{Name = "Shrek!"};

            return View(movie);
        }
    }
}
